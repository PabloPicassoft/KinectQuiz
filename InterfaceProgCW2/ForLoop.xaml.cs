using Microsoft.Kinect;
using Microsoft.Kinect.Toolkit;
using Microsoft.Kinect.Toolkit.Controls;
using Microsoft.Speech.AudioFormat;
using Microsoft.Speech.Recognition;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InterfaceProgCW2
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class ForLoop : UserControl
    {
        //SpeechHelper SpeechHelper;

        public string outTextVar;

        //private KinectSensorChooser sensorChooser;
        //public SpeechRecognitionEngine sre;
        //public Thread audioThread;
        //private KinectSensor sensor;


        //provide access to the speech methods available in mainwindow.xaml.cs 


        IncorrectChoicePopup incorrectChoice = new IncorrectChoicePopup();

        public ForLoop()
        {
            //SpeechHelper = new SpeechHelper();

            InitializeComponent();
            //Loaded += OnLoaded;
        }


        //private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
        //{
        //    this.sensorChooser = new KinectSensorChooser();
        //    this.sensorChooser.KinectChanged += SensorChooserOnKinectChanged;
        //    this.sensorChooserUi.KinectSensorChooser = SpeechHelper.GetKinectSensorChooser();
        //    SpeechHelper.GetKinectSensorChooser().Start();
        //}

        public void PopulateText(string outTextVar)
        {
            outputText.Text = "Output: " + outTextVar;
        }

        private void HomeButtonClick(object sender, RoutedEventArgs e)
        {
            var parent = (Panel)this.Parent;
            parent.Children.Remove(this);
        }

        private void KinectCircleClick(Object sender, RoutedEventArgs e)
        {
            var button = (KinectCircleButton)e.OriginalSource;
            string selection = button.Label as string;

            //button interaction logic
            if (selection == "1")
            {
                outTextVar = "1, 2, 3, 4, 5, 6, 7, 8, 9";
                PopulateText(outTextVar);

                this.KinectRegionGrid.Children.Add(incorrectChoice);
            }
            else if (selection == "2")
            {
                outTextVar = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10";
                PopulateText(outTextVar);

                Cbutton1.Visibility = Visibility.Hidden;
                Cbutton2.Visibility = Visibility.Hidden;
                Cbutton3.Visibility = Visibility.Hidden;

                answer1.Visibility = Visibility.Hidden;
                answer2.Visibility = Visibility.Hidden;
                answer3.Visibility = Visibility.Hidden;

                Congratulations.Visibility = Visibility.Visible;

                tickimg.Visibility = Visibility.Visible;
            }
            else if (selection == "3")
            {
                outTextVar = "1, 2, 3, 4, 5, 6, 7, 8, 9";
                PopulateText(outTextVar);

                this.KinectRegionGrid.Children.Add(incorrectChoice);
            }
        }
        
        //public void setKinectSensor(KinectSensor theSensor)
        //{
        //    this.sensor = theSensor;
        //}

        //public KinectSensor getKinectSensor()
        //{
        //    return this.sensor;
        //}




        ////for detection of the kinectsensor
        //public void SensorChooserOnKinectChanged(object sender, KinectChangedEventArgs e)
        //{
        //    bool errorOccured = false;

        //    if (e.OldSensor != null)
        //    {
        //        try
        //        {
        //            e.OldSensor.DepthStream.Range = DepthRange.Default;
        //            e.OldSensor.SkeletonStream.EnableTrackingInNearRange = false;
        //            e.OldSensor.DepthStream.Disable();
        //            e.OldSensor.SkeletonStream.Disable();
        //        }
        //        catch (InvalidOperationException)
        //        {
        //            // KinectSensor might enter an invalid state while enabling/disabling streams or stream features.  
        //            // E.g.: sensor might be abruptly unplugged.
        //            errorOccured = true;
        //        }
        //    }
        //    if (e.NewSensor != null)
        //    {
        //        try
        //        {
        //            e.NewSensor.DepthStream.Enable(DepthImageFormat.Resolution640x480Fps30);
        //            e.NewSensor.SkeletonStream.Enable();
        //            //initializeSpeech();
        //            try
        //            {
        //                e.NewSensor.DepthStream.Range = DepthRange.Near;
        //                e.NewSensor.SkeletonStream.EnableTrackingInNearRange = true;
        //                e.NewSensor.SkeletonStream.TrackingMode = SkeletonTrackingMode.Seated;
        //                //initializeSpeech();
        //            }
        //            catch (InvalidOperationException)
        //            {
        //                // Non Kinect for Windows devices do not support Near mode, so reset back to default mode.  
        //                e.NewSensor.DepthStream.Range = DepthRange.Default;
        //                e.NewSensor.SkeletonStream.EnableTrackingInNearRange = false;
        //                errorOccured = true;
        //            }
        //        }
        //        catch (InvalidOperationException)
        //        {
        //            // KinectSensor might enter an invalid state while enabling/disabling streams or stream features.  
        //            // E.g.: sensor might be abruptly unplugged.  
        //            errorOccured = true;
        //        }

        //        if (!errorOccured)
        //        {
        //            sensor = SpeechHelper.GetKinectSensor();
                    
        //            initializeSpeech();
        //        }
        //    }
        //}

        ////Speech recognition methods
        //public void initializeSpeech()
        //{
        //    RecognizerInfo ri = GetKinectRecognizer();
        //    sre = new SpeechRecognitionEngine(ri.Id);

        //    //get commands list
        //    var commands = getChoices();

        //    //culture support i.e. fr for french
        //    var gb = new GrammarBuilder();
        //    gb.Culture = ri.Culture;
        //    gb.Append(commands);

        //    //load culture into grammer
        //    var g = new Grammar(gb);

        //    //load grammar into engine
        //    sre.LoadGrammar(g);

        //    //load in event handler for commands
        //    sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Kinect_SpeechRecognized);

        //    //initiate listening
            
        //    audioThread = new Thread(startAudioListening);
        //    audioThread.Start();
        //}

        //private static RecognizerInfo GetKinectRecognizer()
        //{
        //    Func<RecognizerInfo, bool> matchingFunc = r =>
        //    {
        //        string value;
        //        r.AdditionalInfo.TryGetValue("Kinect", out value);
        //        return "True".Equals(value, StringComparison.InvariantCultureIgnoreCase) && "en-US".Equals(r.Culture.Name,
        //        StringComparison.InvariantCultureIgnoreCase);
        //    };
        //    return SpeechRecognitionEngine.InstalledRecognizers().Where(matchingFunc).FirstOrDefault();
        //}

        //private void startAudioListening()
        //{
        //    var audioSource = SpeechHelper.GetKinectSensor().AudioSource;
        //    audioSource.AutomaticGainControlEnabled = false;

        //    Stream aStream = audioSource.Start();
        //    sre.SetInputToAudioStream(aStream, new SpeechAudioFormatInfo(EncodingFormat.Pcm, 16000, 16, 1, 32000, 2, null));
        //    sre.RecognizeAsync(RecognizeMode.Multiple);
        //}

        //public Choices getChoices()
        //{
        //    var choices = new Choices();

        //    choices.Add("home");

        //    return choices;
        //}


        //public void Kinect_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        //{
        //    if (e.Result.Text.ToLower() == "home" && e.Result.Confidence >= 0.85)
        //    {
        //        var parent = (Panel)this.Parent;
        //        parent.Children.Remove(this);
        //    }
        //}
        

        //public void Kinect_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        //{
        //    if (e.Result.Text.ToLower() == "home" && e.Result.Confidence >= 0.85)
        //    {
        //        string voiceSelection = e.Result.Text.ToLower();

        //        mainWindow.VoiceNavigation(voiceSelection);
        //    }
        //}
    }
}
