﻿using ModernWpf.Controls;
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
using System.Windows.Shapes;
using Fluent_Android_Helper.Function_Views.Software_Settings_Views;
namespace Fluent_Android_Helper.Function_Views
{
    /// <summary>
    /// Software_Settings.xaml 的交互逻辑
    /// </summary>
    public partial class Software_Settings : Window
    {
        public Software_Settings()
        {
            InitializeComponent();
        }
        private void NavView_Loaded(object sender, RoutedEventArgs e)
        {
            /* You can also add items in code.
            NavView.MenuItems.Add(new NavigationViewItemSeparator());
            NavView.MenuItems.Add(new NavigationViewItem
            {
                Content = "My content",
                Icon = new SymbolIcon((Symbol)0xF1AD),
                Tag = "content"
            });
            _pages.Add(("content", typeof(MyContentPage)));*/

            NavView_Navigate("theme");

        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            var navItemTag = args.InvokedItemContainer.Tag.ToString();
            NavView_Navigate(navItemTag);
        }

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            var navItemTag = args.SelectedItemContainer.Tag.ToString();
            NavView_Navigate(navItemTag);

        }

        private void NavView_Navigate(string navItemTag)
        {

            if (navItemTag == "theme") ContentFrame.Navigate(new Theme());
            else if (navItemTag == "version") ContentFrame.Navigate(new Software_Settings_Views.About());
            else if (navItemTag == "github") ContentFrame.Navigate(new Github());
        }
    }
}
