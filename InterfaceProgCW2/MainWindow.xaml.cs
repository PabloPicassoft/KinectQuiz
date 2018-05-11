using Microsoft.Kinect;
using Microsoft.Kinect.Toolkit;
using Microsoft.Kinect.Toolkit.Controls;
using System;
using System.Windows;
using Microsoft.Speech.Recognition;
using System.Threading;
using Microsoft.Speech.AudioFormat;
using System.IO;
using System.Linq;
using System.Windows.Threading;
using System.Windows.Controls;

namespace InterfaceProgCW2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        //SpeechHelper speechHelper;

        private KinectSensorChooser sensorChooser;
        public SpeechRecognitionEngine sre;
        public Thread audioThread;
        private KinectSensor sensor;
        
        public MainWindow()
        {
            //speechHelper = new SpeechHelper();

            InitializeComponent();
            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {
            this.sensorChooser = new KinectSensorChooser();
            this.sensorChooser.KinectChanged += SensorChooserOnKinectChanged;
            this.sensorChooserUi.KinectSensorChooser = this.sensorChooser;
            this.sensorChooser.Start();

            //speechHelper.SetKinectSensorChooser(this.sensorChooser);
        }
        
        //Speech recognition methods
        public void initializeSpeech()
        {
            RecognizerInfo ri = GetKinectRecognizer();
            sre = new SpeechRecognitionEngine(ri.Id);

            //get commands list
            var commands = getChoices();

            //culture support i.e. fr for french
            var gb = new GrammarBuilder();
            gb.Culture = ri.Culture;
            gb.Append(commands);

            //load culture into grammer
            var g = new Grammar(gb);

            //load grammar into engine
            sre.LoadGrammar(g);

            //load in event handler for commands
            sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Kinect_SpeechRecognized);

            //initiate listening
            audioThread = new Thread(startAudioListening);
            audioThread.Start();
        }

        private static RecognizerInfo GetKinectRecognizer()
        {
            Func<RecognizerInfo, bool> matchingFunc = r =>
            {
                string value;
                r.AdditionalInfo.TryGetValue("Kinect", out value);
                return "True".Equals(value, StringComparison.InvariantCultureIgnoreCase) && "en-US".Equals(r.Culture.Name,
                StringComparison.InvariantCultureIgnoreCase);
            };
            return SpeechRecognitionEngine.InstalledRecognizers().Where(matchingFunc).FirstOrDefault();
        }

        private void startAudioListening()
        {
            var audioSource = sensor.AudioSource;
            audioSource.AutomaticGainControlEnabled = false;

            Stream aStream = audioSource.Start();
            sre.SetInputToAudioStream(aStream, new SpeechAudioFormatInfo(EncodingFormat.Pcm, 16000, 16, 1, 32000, 2, null));
            sre.RecognizeAsync(RecognizeMode.Multiple);
        }

        public Choices getChoices()
        {
            var choices = new Choices();

            choices.Add("hello world");// listening for Hello world to open hello world quiz question 
            choices.Add("do while");
            choices.Add("for loop");
            choices.Add("if statement");
            choices.Add("methods");

            //navigate back to home
            choices.Add("home");

            //select try again button after incorrect answer
            choices.Add("try again");

            //voice selection of quiz answer
            choices.Add("one");
            choices.Add("two");
            choices.Add("three");
            //choices.Add("fizz buzz"); //add fizzbuzz question

            return choices;
        }

        public void Kinect_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (this.Parent != null && (e.Result.Text.ToLower() == "home" && e.Result.Confidence >= 0.75))
            {
                var parent = (Panel)this.Parent;
                parent.Children.Remove(this);
            }

            if ((e.Result.Text.ToLower() == "hello world" ||
                e.Result.Text.ToLower() == "do while" ||
                e.Result.Text.ToLower() == "for loop" ||
                e.Result.Text.ToLower() == "methods" ||
                e.Result.Text.ToLower() == "if statement") && e.Result.Confidence >= 0.75)
            {
                string pageToNavTo = e.Result.Text.ToLower();

                VoiceNavigation(pageToNavTo);
            }
        }
        
        //for detection of the kinectsensor
        public void SensorChooserOnKinectChanged(object sender, KinectChangedEventArgs e)
        {
            bool errorOccured = false;

            if (e.OldSensor != null)
            {
                try
                {
                    e.OldSensor.DepthStream.Range = DepthRange.Default;
                    e.OldSensor.SkeletonStream.EnableTrackingInNearRange = false;
                    e.OldSensor.DepthStream.Disable();
                    e.OldSensor.SkeletonStream.Disable();
                }
                catch (InvalidOperationException)
                {
                    // KinectSensor might enter an invalid state while enabling/disabling streams or stream features.  
                    // E.g.: sensor might be abruptly unplugged.
                    errorOccured = true;
                }
            }
            if (e.NewSensor != null)
            {
                try
                {
                    e.NewSensor.DepthStream.Enable(DepthImageFormat.Resolution640x480Fps30);
                    e.NewSensor.SkeletonStream.Enable();
                    //initializeSpeech();
                    try
                    {
                        e.NewSensor.DepthStream.Range = DepthRange.Near;
                        e.NewSensor.SkeletonStream.EnableTrackingInNearRange = true;
                        e.NewSensor.SkeletonStream.TrackingMode = SkeletonTrackingMode.Seated;
                        //initializeSpeech();
                    }
                    catch (InvalidOperationException)
                    {
                        // Non Kinect for Windows devices do not support Near mode, so reset back to default mode.  
                        e.NewSensor.DepthStream.Range = DepthRange.Default;
                        e.NewSensor.SkeletonStream.EnableTrackingInNearRange = false;
                        errorOccured = true;
                    }
                }
                catch (InvalidOperationException)
                {
                    // KinectSensor might enter an invalid state while enabling/disabling streams or stream features.  
                    // E.g.: sensor might be abruptly unplugged.  
                    errorOccured = true;
                }

                if (!errorOccured)
                {
                    kinectRegion.KinectSensor = e.NewSensor;
                    setKinectSensor(e.NewSensor);
                    
                    initializeSpeech();
                }
            }
        }
        
        public void setKinectSensor (KinectSensor theSensor)
        {
            this.sensor = theSensor;
        }

        public KinectSensor getKinectSensor()
        {
            return this.sensor;
        }

        public void VoiceNavigation(String pageToNavTo)
        {
            switch (pageToNavTo)
            {
                case "for loop":
                    ForLoop ForLoopPage = new ForLoop();
                    this.kinectRegionGrid.Children.Add(ForLoopPage);
                    break;
                case "if statement":
                    IfStatement ifStatementPage = new IfStatement();
                    this.kinectRegionGrid.Children.Add(ifStatementPage);
                    break;
                case "do while":
                    WhileLoop whileLoopPage = new WhileLoop();
                    this.kinectRegionGrid.Children.Add(whileLoopPage);
                    break;
                case "hello world":
                    HelloWorld helloWorldPage = new HelloWorld();
                    this.kinectRegionGrid.Children.Add(helloWorldPage);
                    break;
                case "methods":
                    Methods methodsPage = new Methods();
                    this.kinectRegionGrid.Children.Add(methodsPage);
                    break;
            }
        }


        private void KinectTileButtonClick(object sender, RoutedEventArgs e)
        {
            var button = (KinectTileButton)e.OriginalSource;
            string selection = button.Label as string;

            switch (selection)
            {
                case "For Loop":
                    ForLoop ForLoopPage = new ForLoop();
                    this.kinectRegionGrid.Children.Add(ForLoopPage);
                    break;
                case "If Statement":
                    IfStatement ifStatementPage = new IfStatement();
                    this.kinectRegionGrid.Children.Add(ifStatementPage);
                    break;
                case "Do While":
                    WhileLoop whileLoopPage = new WhileLoop();
                    this.kinectRegionGrid.Children.Add(whileLoopPage);
                    break;
                case "Hello World":
                    HelloWorld helloWorldPage = new HelloWorld();
                    this.kinectRegionGrid.Children.Add(helloWorldPage);
                    break;
                case "Methods":
                    Methods methodsPage = new Methods();
                    this.kinectRegionGrid.Children.Add(methodsPage);
                    break;
            }
        }
    }
}
