using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Media;

namespace lab02
{
    internal class Win3
    {
        Window window3;
        static bool d = false;
        Grid myGrid;
        public Win3()
        {
            init();
        }
        Button f00, f01, f02, f03, f04, f10, f11, f12, f13, f14, f20, f21, f22, f23, f24, f30, f31, f32, f33, f34, f40, f41, f42, f43, f44;
        private void init()
        {
            window3 = new Window();
            window3.Title = "Хрестики-Нулики";
            window3.ResizeMode = ResizeMode.NoResize;
            myGrid = new Grid();
            window3.Height = 650;
            window3.Width = 650;
            window3.Background = new SolidColorBrush(Colors.LightYellow);
            window3.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            //myGrid.Width = 400;
            //myGrid.Height = 320;
            myGrid.HorizontalAlignment = HorizontalAlignment.Center;
            myGrid.VerticalAlignment = VerticalAlignment.Center;
            //myGrid.ShowGridLines = true;
            RowDefinition[] rows = new RowDefinition[20];
            ColumnDefinition[] cols = new ColumnDefinition[20];
            GridLengthConverter gridLengthConverter = new GridLengthConverter();
            for (int i = 0; i < 20; i++)
            {
                rows[i] = new RowDefinition();
                rows[i].Height = (GridLength)gridLengthConverter.ConvertFrom(69);
                myGrid.RowDefinitions.Add(rows[i]);
            }
            for (int i = 0; i < 20; i++)
            {
                cols[i] = new ColumnDefinition();
                cols[i].Width = (GridLength)gridLengthConverter.ConvertFrom(69);
                myGrid.ColumnDefinitions.Add(cols[i]);
            }
            //
            f00 = new Button();
            f00.Background = new SolidColorBrush(Colors.LightPink);
            f00.Content = "▢";
            f00.Click += Field_Click;
            Grid.SetRow(f00, 7);
            Grid.SetColumn(f00, 7);
            myGrid.Children.Add(f00);
            //
            //
            f01 = new Button();
            f01.Background = new SolidColorBrush(Colors.LightPink);
            f01.Content = "▢";
            f01.Click += Field_Click;
            Grid.SetRow(f01, 7);
            Grid.SetColumn(f01, 8);
            myGrid.Children.Add(f01);
            //
            f02 = new Button();
            f02.Background = new SolidColorBrush(Colors.LightPink);
            f02.Content = "▢";
            f02.Click += Field_Click;
            Grid.SetRow(f02, 7);
            Grid.SetColumn(f02, 9);
            myGrid.Children.Add(f02);
            //
            f03 = new Button();
            f03.Background = new SolidColorBrush(Colors.LightPink);
            f03.Content = "▢";
            f03.Click += Field_Click;
            Grid.SetRow(f03, 7);
            Grid.SetColumn(f03, 10);
            myGrid.Children.Add(f03);
            //
            f04 = new Button();
            f04.Background = new SolidColorBrush(Colors.LightPink);
            f04.Content = "▢";
            f04.Click += Field_Click;
            Grid.SetRow(f04, 7);
            Grid.SetColumn(f04, 11);
            myGrid.Children.Add(f04);
            //
            //
            f10 = new Button();
            f10.Background = new SolidColorBrush(Colors.LightPink);
            f10.Content = "▢";
            f10.Click += Field_Click;
            Grid.SetRow(f10, 8);
            Grid.SetColumn(f10, 7);
            myGrid.Children.Add(f10);
            //
            //
            f11 = new Button();
            f11.Background = new SolidColorBrush(Colors.LightPink);
            f11.Content = "▢";
            f11.Click += Field_Click;
            Grid.SetRow(f11, 8);
            Grid.SetColumn(f11, 8);
            myGrid.Children.Add(f11);
            //
           f12 = new Button();
            f12.Background = new SolidColorBrush(Colors.LightPink);
            f12.Content = "▢";
            f12.Click += Field_Click;
            Grid.SetRow(f12, 8);
            Grid.SetColumn(f12, 9);
            myGrid.Children.Add(f12);
            //
            f13 = new Button();
            f13.Background = new SolidColorBrush(Colors.LightPink);
            f13.Content = "▢";
            f13.Click += Field_Click;
            Grid.SetRow(f13, 8);
            Grid.SetColumn(f13, 10);
            myGrid.Children.Add(f13);
            //
            f14 = new Button();
            f14.Background = new SolidColorBrush(Colors.LightPink);
            f14.Content = "▢";
            f14.Click += Field_Click;
            Grid.SetRow(f14, 8);
            Grid.SetColumn(f14, 11);
            myGrid.Children.Add(f14);
            //
            //
            f20 = new Button();
            f20.Background = new SolidColorBrush(Colors.LightPink);
            f20.Content = "▢";
            f20.Click += Field_Click;
            Grid.SetRow(f20, 9);
            Grid.SetColumn(f20, 7);
            myGrid.Children.Add(f20);
            //
            //
            f21 = new Button();
            f21.Background = new SolidColorBrush(Colors.LightPink);
            f21.Content = "▢";
            f21.Click += Field_Click;
            Grid.SetRow(f21, 9);
            Grid.SetColumn(f21, 8);
            myGrid.Children.Add(f21);
            //
            f22 = new Button();
            f22.Background = new SolidColorBrush(Colors.LightPink);
            f22.Content = "▢";
            f22.Click += Field_Click;
            Grid.SetRow(f22, 9);
            Grid.SetColumn(f22, 9);
            myGrid.Children.Add(f22);
            //
            f23 = new Button();
            f23.Background = new SolidColorBrush(Colors.LightPink);
            f23.Content = "▢";
            f23.Click += Field_Click;
            Grid.SetRow(f23, 9);
            Grid.SetColumn(f23, 10);
            myGrid.Children.Add(f23);
            //
            f24 = new Button();
            f24.Background = new SolidColorBrush(Colors.LightPink);
            f24.Content = "▢";
            f24.Click += Field_Click;
            Grid.SetRow(f24, 9);
            Grid.SetColumn(f24, 11);
            myGrid.Children.Add(f24);
            //
            //
           f30 = new Button();
            f30.Background = new SolidColorBrush(Colors.LightPink);
            f30.Content = "▢";
            f30.Click += Field_Click;
            Grid.SetRow(f30, 10);
            Grid.SetColumn(f30, 7);
            myGrid.Children.Add(f30);
            //
            //
            f31 = new Button();
            f31.Background = new SolidColorBrush(Colors.LightPink);
            f31.Content = "▢";
            f31.Click += Field_Click;
            Grid.SetRow(f31, 10);
            Grid.SetColumn(f31, 8);
            myGrid.Children.Add(f31);
            //
            f32 = new Button();
            f32.Background = new SolidColorBrush(Colors.LightPink);
            f32.Content = "▢";
            f32.Click += Field_Click;
            Grid.SetRow(f32, 10);
            Grid.SetColumn(f32, 9);
            myGrid.Children.Add(f32);
            //
            f33 = new Button();
            f33.Background = new SolidColorBrush(Colors.LightPink);
            f33.Content = "▢";
            f33.Click += Field_Click;
            Grid.SetRow(f33, 10);
            Grid.SetColumn(f33, 10);
            myGrid.Children.Add(f33);
            //
            f34 = new Button();
            f34.Background = new SolidColorBrush(Colors.LightPink);
            f34.Content = "▢";
            f34.Click += Field_Click;
            Grid.SetRow(f34, 10);
            Grid.SetColumn(f34, 11);
            myGrid.Children.Add(f34);
            //
            //
            f40 = new Button();
            f40.Background = new SolidColorBrush(Colors.LightPink);
            f40.Content = "▢";
            f40.Click += Field_Click;
            Grid.SetRow(f40, 11);
            Grid.SetColumn(f40, 7);
            myGrid.Children.Add(f40);
            //
            //
            f41 = new Button();
            f41.Background = new SolidColorBrush(Colors.LightPink);
            f41.Content = "▢";
            f41.Click += Field_Click;
            Grid.SetRow(f41, 11);
            Grid.SetColumn(f41, 8);
            myGrid.Children.Add(f41);
            //
            f42 = new Button();
            f42.Background = new SolidColorBrush(Colors.LightPink);
            f42.Content = "▢";
            f42.Click += Field_Click;
            Grid.SetRow(f42, 11);
            Grid.SetColumn(f42, 9);
            myGrid.Children.Add(f42);
            //
            f43 = new Button();
            f43.Background = new SolidColorBrush(Colors.LightPink);
            f43.Content = "▢";
            f43.Click += Field_Click;
            Grid.SetRow(f43, 11);
            Grid.SetColumn(f43, 10);
            myGrid.Children.Add(f43);
            //
            f44 = new Button();
            f44.Background = new SolidColorBrush(Colors.LightPink);
            f44.Content = "▢";
            f44.Click += Field_Click;
            Grid.SetRow(f44, 11);
            Grid.SetColumn(f44, 11);
            myGrid.Children.Add(f44);
            //
            Button Back3 = new Button();
            Back3.Background = new SolidColorBrush(Colors.Red);
            Back3.Content = "На Головну";
            Back3.Click += Back3_Click;
            Grid.SetRow(Back3, 13);
            Grid.SetColumn(Back3, 6);
            myGrid.Children.Add(Back3);
            window3.Content = myGrid;
            window3.Show();
        }
        private void Back3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            window3.Hide();
            mw.Show();
        }
        private void Field_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)e.Source;
            if ((string)b.Content == "▢")
            {
                b.Content = "X";
            }
            b.IsEnabled = false;
            win_check();
            comp_move();
            if (d == false)
            {
                win_check();
            }
        }
        private void reload()
        {
            
            window3.Hide();
            Win3 ww3 = new Win3();
        }
        private void comp_move()
        {
            bool flag = false;
            Random r = new Random();
            while (flag == false)
            {
                int num = r.Next(0, 25);
                int counter = 0;
                foreach (Button b in myGrid.Children.OfType<Button>())
                {
                    if (counter == num && (string)b.Content == "▢")
                    {
                        b.Content = "⭕";
                        b.IsEnabled = false;
                        flag = true;
                        return;
                    }
                    counter++;
                }
            }
            win_check();
        }
        private void win_check()
        {
            //
            if (((string)f00.Content == "X" && (string)f01.Content == "X" && (string)f02.Content == "X" && (string)f03.Content == "X") || ((string)f01.Content == "X" && (string)f02.Content == "X" && (string)f03.Content == "X" && (string)f04.Content == "X"))
            {
                MessageBox.Show("Ви перемогли!");
                d = true;
                reload();
            }
            if (((string)f10.Content == "X" && (string)f11.Content == "X" && (string)f12.Content == "X" && (string)f13.Content == "X") || ((string)f11.Content == "X" && (string)f12.Content == "X" && (string)f13.Content == "X" && (string)f14.Content == "X"))
            {
                MessageBox.Show("Ви перемогли!");
                d = true;
                reload();
            }
            if (((string)f20.Content == "X" && (string)f21.Content == "X" && (string)f22.Content == "X" && (string)f23.Content == "X") || ((string)f21.Content == "X" && (string)f22.Content == "X" && (string)f23.Content == "X" && (string)f24.Content == "X"))
            {
                MessageBox.Show("Ви перемогли!");
                d = true;
                reload();
            }
            if (((string)f30.Content == "X" && (string)f31.Content == "X" && (string)f32.Content == "X" && (string)f33.Content == "X") || ((string)f31.Content == "X" && (string)f32.Content == "X" && (string)f33.Content == "X" && (string)f34.Content == "X"))
            {
                MessageBox.Show("Ви перемогли!");
                d = true;
                reload();
            }
            if (((string)f40.Content == "X" && (string)f41.Content == "X" && (string)f42.Content == "X" && (string)f43.Content == "X") || ((string)f41.Content == "X" && (string)f42.Content == "X" && (string)f43.Content == "X" && (string)f44.Content == "X"))
            {
                MessageBox.Show("Ви перемогли!");
                d = true;
                reload();
            }
            if (((string)f00.Content == "X" && (string)f10.Content == "X" && (string)f20.Content == "X" && (string)f30.Content == "X") || ((string)f10.Content == "X" && (string)f20.Content == "X" && (string)f30.Content == "X" && (string)f40.Content == "X"))
            {
                MessageBox.Show("Ви перемогли!");
                d = true;
                reload();
            }
            if (((string)f01.Content == "X" && (string)f11.Content == "X" && (string)f21.Content == "X" && (string)f31.Content == "X") || ((string)f11.Content == "X" && (string)f21.Content == "X" && (string)f31.Content == "X" && (string)f41.Content == "X"))
            {
                MessageBox.Show("Ви перемогли!");
                d = true;
                reload();
            }
            if (((string)f02.Content == "X" && (string)f12.Content == "X" && (string)f22.Content == "X" && (string)f32.Content == "X") || ((string)f12.Content == "X" && (string)f22.Content == "X" && (string)f32.Content == "X" && (string)f42.Content == "X"))
            {
                MessageBox.Show("Ви перемогли!");
                d = true;
                reload();
            }
            if (((string)f03.Content == "X" && (string)f13.Content == "X" && (string)f23.Content == "X" && (string)f33.Content == "X") || ((string)f13.Content == "X" && (string)f23.Content == "X" && (string)f33.Content == "X" && (string)f43.Content == "X"))
            {
                MessageBox.Show("Ви перемогли!");
                d = true;
                reload();
            }
            if (((string)f04.Content == "X" && (string)f14.Content == "X" && (string)f24.Content == "X" && (string)f34.Content == "X") || ((string)f14.Content == "X" && (string)f24.Content == "X" && (string)f34.Content == "X" && (string)f44.Content == "X"))
            {
                MessageBox.Show("Ви перемогли!");
                d = true;
                reload();
            }
            if (((string)f00.Content == "X" && (string)f11.Content == "X" && (string)f22.Content == "X" && (string)f33.Content == "X") || ((string)f11.Content == "X" && (string)f22.Content == "X" && (string)f33.Content == "X" && (string)f44.Content == "X"))
            {
                MessageBox.Show("Ви перемогли!");
                d = true;
                reload();
            }
            if (((string)f40.Content == "X" && (string)f31.Content == "X" && (string)f22.Content == "X" && (string)f13.Content == "X") || ((string)f31.Content == "X" && (string)f22.Content == "X" && (string)f13.Content == "X" && (string)f04.Content == "X"))
            {
                MessageBox.Show("Ви перемогли!");
                d = true;
                reload();
            }
            if ((string)f01.Content == "X" && (string)f12.Content == "X" && (string)f23.Content == "X" && (string)f34.Content == "X")
            {
                MessageBox.Show("Ви перемогли!");
                d = true;
                reload();
            }
            if ((string)f10.Content == "X" && (string)f21.Content == "X" && (string)f32.Content == "X" && (string)f43.Content == "X")
            {
                MessageBox.Show("Ви перемогли!");
                d = true;
                reload();
            }
            if ((string)f03.Content == "X" && (string)f12.Content == "X" && (string)f21.Content == "X" && (string)f30.Content == "X")
            {
                MessageBox.Show("Ви перемогли!");
                d = true;
                reload();
            }
            if ((string)f14.Content == "X" && (string)f23.Content == "X" && (string)f32.Content == "X" && (string)f41.Content == "X")
            {
                MessageBox.Show("Ви перемогли!");
                d = true;
                reload();
            }
            //
            if (((string)f00.Content == "⭕" && (string)f01.Content == "⭕" && (string)f02.Content == "⭕" && (string)f03.Content == "⭕") || ((string)f01.Content == "⭕" && (string)f02.Content == "⭕" && (string)f03.Content == "⭕" && (string)f04.Content == "⭕"))
            {
                MessageBox.Show("Ви програли!");
                reload();
            }
            if (((string)f10.Content == "⭕" && (string)f11.Content == "⭕" && (string)f12.Content == "⭕" && (string)f13.Content == "⭕") || ((string)f11.Content == "⭕" && (string)f12.Content == "⭕" && (string)f13.Content == "⭕" && (string)f14.Content == "⭕"))
            {
                MessageBox.Show("Ви програли!");
                reload();
            }
            if (((string)f20.Content == "⭕" && (string)f21.Content == "⭕" && (string)f22.Content == "⭕" && (string)f23.Content == "⭕") || ((string)f21.Content == "⭕" && (string)f22.Content == "⭕" && (string)f23.Content == "⭕" && (string)f24.Content == "⭕"))
            {
                MessageBox.Show("Ви програли!");
                reload();
            }
            if (((string)f30.Content == "⭕" && (string)f31.Content == "⭕" && (string)f32.Content == "⭕" && (string)f33.Content == "⭕") || ((string)f31.Content == "⭕" && (string)f32.Content == "⭕" && (string)f33.Content == "⭕" && (string)f34.Content == "⭕"))
            {
                MessageBox.Show("Ви програли!");
                reload();
            }
            if (((string)f40.Content == "⭕" && (string)f41.Content == "⭕" && (string)f42.Content == "⭕" && (string)f43.Content == "⭕") || ((string)f41.Content == "⭕" && (string)f42.Content == "⭕" && (string)f43.Content == "⭕" && (string)f44.Content == "⭕"))
            {
                MessageBox.Show("Ви програли!");
                reload();
            }
            if (((string)f00.Content == "⭕" && (string)f10.Content == "⭕" && (string)f20.Content == "⭕" && (string)f30.Content == "⭕") || ((string)f10.Content == "⭕" && (string)f20.Content == "⭕" && (string)f30.Content == "⭕" && (string)f40.Content == "⭕"))
            {
                MessageBox.Show("Ви програли!");
                reload();
            }
            if (((string)f01.Content == "⭕" && (string)f11.Content == "⭕" && (string)f21.Content == "⭕" && (string)f31.Content == "⭕") || ((string)f11.Content == "⭕" && (string)f21.Content == "⭕" && (string)f31.Content == "⭕" && (string)f41.Content == "⭕"))
            {
                MessageBox.Show("Ви програли!");
                reload();
            }
            if (((string)f02.Content == "⭕" && (string)f12.Content == "⭕" && (string)f22.Content == "⭕" && (string)f32.Content == "⭕") || ((string)f12.Content == "⭕" && (string)f22.Content == "⭕" && (string)f32.Content == "⭕" && (string)f42.Content == "⭕"))
            {
                MessageBox.Show("Ви програли!");
                reload();
            }
            if (((string)f03.Content == "⭕" && (string)f13.Content == "⭕" && (string)f23.Content == "⭕" && (string)f33.Content == "⭕") || ((string)f13.Content == "⭕" && (string)f23.Content == "⭕" && (string)f33.Content == "⭕" && (string)f43.Content == "⭕"))
            {
                MessageBox.Show("Ви програли!");
                reload();
            }
            if (((string)f04.Content == "⭕" && (string)f14.Content == "⭕" && (string)f24.Content == "⭕" && (string)f34.Content == "⭕") || ((string)f14.Content == "⭕" && (string)f24.Content == "⭕" && (string)f34.Content == "⭕" && (string)f44.Content == "⭕"))
            {
                MessageBox.Show("Ви програли!");
                reload();
            }
            if (((string)f00.Content == "⭕" && (string)f11.Content == "⭕" && (string)f22.Content == "⭕" && (string)f33.Content == "⭕") || ((string)f11.Content == "⭕" && (string)f22.Content == "⭕" && (string)f33.Content == "⭕" && (string)f44.Content == "⭕"))
            {
                MessageBox.Show("Ви програли!");
                reload();
            }
            if (((string)f40.Content == "⭕" && (string)f31.Content == "⭕" && (string)f22.Content == "⭕" && (string)f13.Content == "⭕") || ((string)f31.Content == "⭕" && (string)f22.Content == "⭕" && (string)f13.Content == "⭕" && (string)f04.Content == "⭕"))
            {
                MessageBox.Show("Ви програли!");
                reload();
            }
            if ((string)f01.Content == "⭕" && (string)f12.Content == "⭕" && (string)f23.Content == "⭕" && (string)f34.Content == "⭕")
            {
                MessageBox.Show("Ви програли!");
                reload();
            }
            if ((string)f10.Content == "⭕" && (string)f21.Content == "⭕" && (string)f32.Content == "⭕" && (string)f43.Content == "⭕")
            {
                MessageBox.Show("Ви програли!");
                reload();
            }
            if ((string)f03.Content == "⭕" && (string)f12.Content == "⭕" && (string)f21.Content == "⭕" && (string)f30.Content == "⭕")
            {
                MessageBox.Show("Ви програли!");
                reload();
            }
            if ((string)f14.Content == "⭕" && (string)f23.Content == "⭕" && (string)f32.Content == "⭕" && (string)f41.Content == "⭕")
            {
                MessageBox.Show("Ви програли!");
                reload();
            }
            int counter = 0;
            foreach (Button b in myGrid.Children.OfType<Button>())
            {
                if ((string)b.Content == "▢")
                {
                    counter++;
                }
            }
            if (counter == 0)
            {
                MessageBox.Show("Нічия!");
                reload();
            }
        }
    }
}
