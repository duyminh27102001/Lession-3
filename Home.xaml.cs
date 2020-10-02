using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using T1907A.Models;
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
    public sealed partial class Home : Page
    {
        public static Frame contentFrame;
        public Home()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SV.IsPaneOpen = !SV.IsPaneOpen;
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ProductItem selected = (ProductItem)LV.SelectedItem;
            if (selected.Dest.Equals("lst"))
            {
                FrContent.Navigate(typeof(BT03.ContactList));
            }
            else if (selected.Dest.Equals("Mail"))
            {
                FrContent.Navigate(typeof(BT03.AddContact));
            }
            else if (selected.Dest.Equals("add"))
            {
                FrContent.Navigate(typeof(BT03.ListContact));
            }


        }

        private void ScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            contentFrame = FrContent;
            FrContent.Navigate(typeof(BT03.ContactList));
        }

        private void ListView_Loaded(object sender, RoutedEventArgs e)
        {
            LV.Items.Add(new ProductItem((char)(Convert.ToInt32("E80F", 16)), "Home", "lst"));
            LV.Items.Add(new ProductItem((char)(Convert.ToInt32("EA4A", 16)), "Contact", "add"));
            LV.Items.Add(new ProductItem((char)(Convert.ToInt32("E715", 16)), "Email", "Mail"));
            LV.Items.Add(new ProductItem((char)(Convert.ToInt32("E77B", 16)), "Customer", "Contact"));
        }
    }
}
