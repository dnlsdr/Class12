using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_tutorial_05_custom_textbox_control.View.UserControls
{
    public partial class ClearableTextBox : UserControl
    {
        public ClearableTextBox()
        {
            InitializeComponent();
        }

        private string placeholder;

        public string Placeholder
        {
            get { return placeholder; }
            set {
                placeholder = value;
                // ez nem jo gyakorlat, később OnPropertyChanged()-del fogjuk csinalni
                tbPlaceholder.Text = placeholder;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            // törlés után a focust is akarod
            txtInput.Focus();

        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            // megnezzuk h van e barmilyen text a box-ban
            if (string.IsNullOrEmpty(txtInput.Text)){
                // tehat ha nincs benne semmi, akkor
                tbPlaceholder.Visibility = Visibility.Visible;
            }
            else
            {
                // ha valami van a box-ban, akor legtyen elrejtve
                tbPlaceholder.Visibility = Visibility.Hidden;
            }
        }
    }
}
