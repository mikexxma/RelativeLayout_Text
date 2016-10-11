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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RelativePanel_Test
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void sc2_Click(object sender, RoutedEventArgs e)
        {
            if (mySplitView.IsPaneOpen) { mySplitView.IsPaneOpen = !mySplitView.IsPaneOpen; }
            MyFrame.Navigate(typeof(sc2));
        }

        private void sfv_Click(object sender, RoutedEventArgs e)
        {
            if (mySplitView.IsPaneOpen) { mySplitView.IsPaneOpen = !mySplitView.IsPaneOpen; }
            MyFrame.Navigate(typeof(stv));
        }

        private void lol_Click(object sender, RoutedEventArgs e)
        {
            if (mySplitView.IsPaneOpen) { mySplitView.IsPaneOpen = !mySplitView.IsPaneOpen; }
            MyFrame.Navigate(typeof(lol));
        }

        private void menu_Click(object sender, RoutedEventArgs e)
        {
            //永远和当前状态相反 当点击menu 的时候
            mySplitView.IsPaneOpen = !mySplitView.IsPaneOpen;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
            }
        }

        private void Forward_Click(object sender, RoutedEventArgs e)
        {
            //myframe 是当前page包含的fame
            if (MyFrame.CanGoForward)
            {
                MyFrame.GoForward();
            }
        }

        private void navigateToAnotherPage_Click(object sender, RoutedEventArgs e)
        {
            //大写的frame 是指当前page所在的父frame 
            Frame.Navigate(typeof(sc2));
        }
    }
}
