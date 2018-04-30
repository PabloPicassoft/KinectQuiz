using Microsoft.Kinect.Toolkit.Controls;
using Microsoft.Speech.Recognition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public string outTextVar;

        //provide access to the speech methods available in mainwindow.xaml.cs 
        //MainWindow mainWindow = new MainWindow();

        IncorrectChoicePopup incorrectChoice = new IncorrectChoicePopup();

        public ForLoop()
        {
            InitializeComponent();
        }

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
