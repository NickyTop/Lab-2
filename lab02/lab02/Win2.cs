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
    internal class Win2
    {
        //Створення розмітки
        TextBox Zalik;
        TextBox Surname;
        TextBox Name;
        TextBox SecName;
        TextBox Group;
        Window window2;
        public Win2()
        {
            init(); 
        }
        private void init()
        {
            window2 = new Window();
            window2.ResizeMode = ResizeMode.NoResize;
            Grid myGrid = new Grid();
            window2.Height = 450;
            window2.Width = 1100;
            window2.Background = new SolidColorBrush(Colors.LightYellow);
            window2.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            myGrid.HorizontalAlignment = HorizontalAlignment.Center;
            myGrid.VerticalAlignment = VerticalAlignment.Center;
            RowDefinition[] rows = new RowDefinition[20];
            ColumnDefinition[] cols = new ColumnDefinition[20];
            GridLengthConverter gridLengthConverter = new GridLengthConverter();
            for (int i = 0; i < 20; i++)
            {
                rows[i] = new RowDefinition();
                rows[i].Height = (GridLength)gridLengthConverter.ConvertFrom(30);
                myGrid.RowDefinitions.Add(rows[i]);
            }
            for (int i = 0; i < 20; i++)
            {
                cols[i] = new ColumnDefinition();
                cols[i].Width = (GridLength)gridLengthConverter.ConvertFrom(100);
                myGrid.ColumnDefinitions.Add(cols[i]);
            }
            Zalik = new TextBox();
            Zalik.Text = "12345";
            Surname = new TextBox();
            Surname.Text = "Сорока";
            Name = new TextBox();
            Name.Text = "Микита";
            SecName = new TextBox();
            SecName.Text = "Іванович";
            Group = new TextBox();
            Group.Text = "КП-13";
            Grid.SetRow(Zalik, 7);
            Grid.SetColumn(Zalik, 5);
            Grid.SetRow(Surname, 7);
            Grid.SetColumn(Surname, 7);
            Grid.SetRow(Name, 7);
            Grid.SetColumn(Name, 9);
            Grid.SetRow(SecName, 7);
            Grid.SetColumn(SecName, 11);
            Grid.SetRow(Group, 7);
            Grid.SetColumn(Group, 13);
            myGrid.Children.Add(Zalik);
            myGrid.Children.Add(Surname);
            myGrid.Children.Add(Name);
            myGrid.Children.Add(SecName);
            myGrid.Children.Add(Group);
            Button AddStud = new Button();
            Button DelStud = new Button();
            Grid.SetRow(AddStud, 12);
            Grid.SetColumn(AddStud, 11);
            Grid.SetRow(DelStud, 12);
            Grid.SetColumn(DelStud, 13);
            AddStud.Content = "Додати";
            AddStud.Background = new SolidColorBrush(Colors.LightGreen);
            DelStud.Content = "Видалити";
            DelStud.Background = new SolidColorBrush(Colors.LightGreen);
            AddStud.Click += AddStud_Click;
            DelStud.Click += DelStud_Click;
            myGrid.Children.Add(AddStud);
            myGrid.Children.Add(DelStud);
            Button Back2 = new Button();
            Back2.Background = new SolidColorBrush(Colors.Red);
            Back2.Content = "На головну";
            Back2.Click += Back2_Click;
            Grid.SetRow(Back2, 12);
            Grid.SetColumn(Back2, 5);
            myGrid.Children.Add(Back2);
            window2.Content = myGrid;
            window2.Show();
        }

        //Код виконавчих процесів
        struct student
        {
            private string id;
            private string pibg;
            public student(string ID, string prizv, string im, string pob, string grupa)
            {
                id = ID;
                pibg = prizv + " " + im + " " + pob + " " + grupa;
            }
            public string GetId() => id;
            public string GetPIBG() => pibg;
        }
        private void AddStud_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("Students.txt");
                List<student> st = new List<student>();
                while (!sr.EndOfStream)
                {
                    string[] stud = new string[5];
                    stud = sr.ReadLine().Split(' ');
                    student stu = new student(stud[0], stud[1], stud[2], stud[3], stud[4]);
                    st.Add(stu);
                }
                sr.Close();
                foreach (student s in st)
                {
                    if (s.GetId() == Zalik.Text)
                    {
                        MessageBox.Show("Веведений номер залікової книжки вже є в списку");
                        return;
                    }
                }
                StreamWriter sw = new StreamWriter("Students.txt", true);
                if (Zalik.Text != "" && Surname.Text != "" && Name.Text != "" && SecName.Text != "" && Group.Text != "")
                {
                    sw.WriteLine(Zalik.Text + " " + Surname.Text + " " + Name.Text + " " + SecName.Text + " " + Group.Text);
                    MessageBox.Show("Студент успішно доданий");
                }
                else
                {
                    MessageBox.Show("Повинні бути заповнені усі поля");
                    return;
                }
                sw.Close();
            }
            catch
            {
                StreamWriter sw = new StreamWriter("Students.txt", true);
                if (Zalik.Text != "" && Surname.Text != "" && Name.Text != "" && SecName.Text != "" && Group.Text != "")
                {
                    sw.WriteLine(Zalik.Text + " " + Surname.Text + " " + Name.Text + " " + SecName.Text + " " + Group.Text);
                    MessageBox.Show("Студент успішно доданий");
                }
                else
                {
                    MessageBox.Show("Повинні бути заповнені усі поля");
                    return;
                }
                sw.Close();
            }
        }

        private void DelStud_Click(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader("Students.txt");
            List<student> st = new List<student>();
            while (!sr.EndOfStream)
            {
                string[] stud = new string[5];
                stud = sr.ReadLine().Split(' ');
                student stu = new student(stud[0], stud[1], stud[2], stud[3], stud[4]);
                st.Add(stu);
            }
            sr.Close();
            bool flag = false;
            foreach (student s in st)
            {
                if (s.GetId() == Zalik.Text)
                {
                    st.Remove(s);
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("Студент не знайдений");
                return;
            }
            StreamWriter sw = new StreamWriter("Students.txt");
            foreach (student s in st)
            {
                sw.WriteLine(s.GetId() + " " + s.GetPIBG());
            }
            MessageBox.Show("Студент успішно видалений");
            sw.Close();
        }

        private void Back2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            window2.Hide();
            mw.Show();
        }
    }
}
