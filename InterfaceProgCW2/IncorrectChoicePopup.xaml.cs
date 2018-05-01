using Microsoft.Kinect;
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
    /// Interaction logic for IncorrectChoicePopup.xaml
    /// </summary>
    public partial class IncorrectChoicePopup : UserControl
    {
        private SpeechRecognitionEngine sre;
        private Thread audioThread;

        MainWindow main = new MainWindow();

        private KinectSensor sensor;

        public IncorrectChoicePopup()
        {
            InitializeComponent();
        }

        public void TryAgainClick(object sender, RoutedEventArgs e)
        {
            var parent = (Panel)this.Parent;
            parent.Children.Remove(this);

            TextBlock outputParent = (TextBlock)parent.FindName("outputText");
            if (outputParent != null)
            {
                outputParent.Text = "Output:";
            }
        }


        //Create instance of engine
        void voiceEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text.ToLower() == "try again") // e.Result.Text contains the recognized text
            {
                var parent = (Panel)this.Parent;
                parent.Children.Remove(this);

                TextBlock outputParent = (TextBlock)parent.FindName("outputText");
                if (outputParent != null)
                {
                    outputParent.Text = "Output:";
                }
            }
        }
    }
}

