using Microsoft.Kinect.Toolkit.Controls;
using System;
using System.Windows;
using System.Windows.Controls;

namespace InterfaceProgCW2
{
    /// <summary>
    /// Interaction logic for IfStatement.xaml
    /// </summary>
    public partial class IfStatement : UserControl
    {
        public string outTextVar;

        IncorrectChoicePopup inCorrectChoice = new IncorrectChoicePopup();

        public IfStatement()
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
                outTextVar = "- Condition Failed - ";
                PopulateText(outTextVar);

                this.KinectRegionGrid.Children.Add(inCorrectChoice);
            }
            else if (selection == "2")
            {
                outTextVar = "- Condition Failed -";
                PopulateText(outTextVar);

                this.KinectRegionGrid.Children.Add(inCorrectChoice);
            }
            else if (selection == "3")
            {
                outTextVar = "30";
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
        }
    }
}
