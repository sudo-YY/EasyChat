﻿using System.Windows;
using System.Windows.Input;

namespace EasyChat.Views
{
    /// <summary>
    /// MyMsgBox.xaml 的交互逻辑
    /// </summary>
    public partial class MyMsgBox : Window
    {
        public MyMsgBox(string message)
        {
            InitializeComponent();
            MessageTextBlock.Text = message;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        public static void Show(string message)
        {
            var messageBox = new MyMsgBox(message);
            messageBox.ShowDialog();
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
