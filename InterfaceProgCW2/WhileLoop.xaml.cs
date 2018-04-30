using Microsoft.Kinect.Toolkit.Controls;
using System;
using System.Windows;
using System.Windows.Controls;

namespace InterfaceProgCW2
{
    /// <summary>
    /// Interaction logic for WhileLoop.xaml
    /// </summary>
    public partial class WhileLoop : UserControl
    {
        public string outTextVar;

        IncorrectChoicePopup incorrectChoice = new IncorrectChoicePopup();

        public WhileLoop()
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
                outTextVar = "1, 2, 3, 4, ... ∞";
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
    }
}
