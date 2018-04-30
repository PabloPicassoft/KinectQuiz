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

namespace InterfaceProgCW2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        private KinectSensorChooser sensorChooser;

        private SpeechRecognitionEngine sre;
        private Thread audioThread;

        //private KinectSensor sensor;

        public MainWindow()
        {
            InitializeComponent();
            //Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {
            this.sensorChooser = new KinectSensorChooser();
            this.sensorChooser.KinectChanged += SensorChooserOnKinectChanged;
            this.sensorChooserUi.KinectSensorChooser = this.sensorChooser;
            this.sensorChooser.Start();
        }


        //Speech recognition methods
        private void initializeSpeech() //called from initiate_kinect()
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

            //load grammer into engine
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

            //var audioSource = kinectSensor.AudioSource;
            audioSource.AutomaticGainControlEnabled = false;

            Stream aStream = audioSource.Start();

            sre.SetInputToAudioStream(aStream, new SpeechAudioFormatInfo(EncodingFormat.Pcm, 16000, 16, 1, 32000, 2, null));
            sre.RecognizeAsync(RecognizeMode.Multiple);

        }

        public Choices getChoices()
        {
            var choices = new Choices();

            choices.Add("hello world");// listening for computer 

            return choices;
        }

        public void Kinect_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text.ToLower() == "hello world" && e.Result.Confidence >= 0.85)
            {
                //if kinect recognises "computer", it will print "YOU SAID COMPUTER!" into the console log
                Console.WriteLine("Hello World!!!");

            }
        }

        //for detection of the kinectsensor
        private void SensorChooserOnKinectChanged(object sender, KinectChangedEventArgs e)
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
                    try
                    {
                        e.NewSensor.DepthStream.Range = DepthRange.Near;
                        e.NewSensor.SkeletonStream.EnableTrackingInNearRange = true;
                        e.NewSensor.SkeletonStream.TrackingMode = SkeletonTrackingMode.Seated;

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
                }
            }
        }
        
        //private void ButtonOnClick(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Well done!");
        //}

        private void KinectTileButtonClick(object sender, RoutedEventArgs e)
        {
            var button = (KinectTileButton)e.OriginalSource;
            string selection = button.Label as string;

            //if (selection == "For Loop")
            //{
            //    UserControl1 ForLoopPage = new UserControl1();
            //    this.kinectRegionGrid.Children.Add(ForLoopPage);
            //}

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
                case "While Loop":
                    WhileLoop whileLoopPage = new WhileLoop();
                    this.kinectRegionGrid.Children.Add(whileLoopPage);
                    break;
                case "Hello World":
                    HelloWorld helloWorldPage = new HelloWorld();
                    this.kinectRegionGrid.Children.Add(helloWorldPage);
                    break;
            }
        }
    }


}
