﻿using System;
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
    public sealed partial class ContactList : Page
    {
        public ContactList()
        {
            this.InitializeComponent();
            ViewModel.ViewModel_Mail vm = new ViewModel.ViewModel_Mail();
            GV.ItemsSource = vm.Mails;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Home.contentFrame.Navigate(typeof(BT03.AddContact));
        }

       
    }
}
