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
    public partial class IncorrectChoicePopup : UserControl
    {

        public IncorrectChoicePopup()
        {
            InitializeComponent();
        }

        //This method will be called when the onclick of the try again button on the popup is called.
        public void TryAgainClick(object sender, RoutedEventArgs e)
        {
            //assigning the parent panel of this popup panel to a variable 
            //(in this case the parent is the question panel that triggered the popup)
            var parent = (Panel)this.Parent;

            //this method call will remove the popup from the parent child hierarchy, therefore
            //disposing of the popup panel
            parent.Children.Remove(this);

            //assigning the output textblock of the parent panel to a variable
            TextBlock outputParent = (TextBlock)parent.FindName("outputText");

            //this will check if the output box of the parent panel is not null.
            //if the condition passes, the output textbox will be cleared of its previous text and reset to
            //only contain 'Output:' ready to be used again.
            if (outputParent != null)
            {
                outputParent.Text = "Output:";
            }
        }
    }
}

