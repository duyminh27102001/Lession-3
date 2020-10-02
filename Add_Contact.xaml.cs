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

namespace T1907A.Layout.BT03
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Add_Contact : Page
    {
        public Add_Contact()
        {
            this.InitializeComponent();
        }

        private void backtoListContact(object sender, RoutedEventArgs e)
        {
            Home.contentFrame.Navigate(typeof(BT03.ListContact));
        }

        private void save(object sender, RoutedEventArgs e)
        {
            ViewModel.ViewModel_Contact.ContactList.Add(new Models.Contact(Name.Text,Convert.ToInt32(Phone.Text),Address.Text,Job.Text));
            Home.contentFrame.Navigate(typeof(BT03.ListContact));
        }
    }
}
