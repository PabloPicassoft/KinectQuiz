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
    /// Interaction logic for IncorrectChoicePopup.xaml
    /// </summary>
    public partial class IncorrectChoicePopup : UserControl
    {
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
    }
}
