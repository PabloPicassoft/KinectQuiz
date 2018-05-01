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
    /// Interaction logic for Methods.xaml
    /// </summary>
    public partial class Methods : UserControl
    {
        public string outTextVar;

        IncorrectChoicePopup incorrectChoice = new IncorrectChoicePopup();

        public Methods()
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
                outTextVar = "INCORRECT";
                PopulateText(outTextVar);

                this.KinectRegionGrid.Children.Add(incorrectChoice);
            }
            else if (selection == "2")
            {
                outTextVar = "INCORRECT";
                PopulateText(outTextVar);

                this.KinectRegionGrid.Children.Add(incorrectChoice);
                
            }
            else if (selection == "3")
            {
                outTextVar = "60";
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
