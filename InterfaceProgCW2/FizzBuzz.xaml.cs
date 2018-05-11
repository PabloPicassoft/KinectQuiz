using Microsoft.Kinect.Toolkit.Controls;
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
    /// Interaction logic for FizzBuzz.xaml
    /// </summary>
    public partial class FizzBuzz : UserControl
    {
        public string outTextVar;

        IncorrectChoicePopup inCorrectChoice = new IncorrectChoicePopup();

        public FizzBuzz()
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
                outTextVar = "1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz ... FizzBuzz";
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
            else if (selection == "2")
            {
                outTextVar = "Condition failed, no output.";
                PopulateText(outTextVar);

                this.KinectRegionGrid.Children.Add(inCorrectChoice);
            }
            else if (selection == "3")
            {
                outTextVar = "[Exception] Cannot compare an integer and string.";
                PopulateText(outTextVar);

                this.KinectRegionGrid.Children.Add(inCorrectChoice);
            }
        }
    }
}
