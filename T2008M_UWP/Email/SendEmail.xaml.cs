using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2008M_UWP.Email
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SendEmail : Page
    {
        public SendEmail()
        {
            this.InitializeComponent();
        }
        int index = 1;
        List<String> ListLetter = new List<String>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListLetter.Add(inputEmail.Text + " - " + inputTopic.Text + " - " + inputContent.Text.Substring(0, 10));
            letters.Text += index + " - " +ListLetter.Last() + "\n";
            inputTopic.Text = "";
            inputEmail.Text = "";
            inputContent.Text = "";
            index++;
        }
    }
}
