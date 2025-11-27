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

namespace CustomTextboxControl.View.UserControls
{
    /// <summary>
    /// Interaction logic for ClearableTextBox.xaml
    /// </summary>
    public partial class ClearableTextBox : UserControl
    {
        private string placeholder;

        public string Placeholder
        {
            get { return placeholder; }
            set { placeholder = tbPlaceholder.Text = value; }
        }
        public ClearableTextBox()
        {
            InitializeComponent();

        }

      
        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbPlaceholder.Visibility = txtInput.Text == "" ? Visibility.Visible : Visibility.Hidden;
            //if (txtInput.Text.Length > 16) Window.GetWindow(this).Focus();
               // if (txtInput.Text.Length > 16) txtInput.Text = txtInput.Text.Substring(0,16);
              // if(e.Changes)
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = "";
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Down);
            if (e.Key == Key.Enter)
            ///https://learn.microsoft.com/en-us/dotnet/desktop/wpf/advanced/focus-overview#:~:text=navigationMenu%2C%0A%20%20%20%20KeyboardNavigationMode.Cycle)%3B-,%D0%9F%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%BC%D0%BD%D0%BE%D0%B5%20%D0%BF%D0%B5%D1%80%D0%B5%D0%BC%D0%B5%D1%89%D0%B5%D0%BD%D0%B8%D0%B5%20%D1%84%D0%BE%D0%BA%D1%83%D1%81%D0%B0,-%D0%94%D0%BE%D0%BF%D0%BE%D0%BB%D0%BD%D0%B8%D1%82%D0%B5%D0%BB%D1%8C%D0%BD%D1%8B%D0%BC%D0%B8%20API%20%D0%B4%D0%BB%D1%8F
            {
                txtInput.MoveFocus(request);
                e.Handled = true;
            }
                
        }
    }
}
