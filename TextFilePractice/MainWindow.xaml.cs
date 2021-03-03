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
using System.IO;

namespace TextFilePractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> lines = new List<string>();
        List<Array> arrayList = new List<Array>();
        string filePath = @"C:\Users\bryant\source\repos\TextFilePractice\TextFilePractice\StandardDataSet.txt";
        public MainWindow()
        {
            //personList.Items.Add(item);
            InitializeComponent();
            lines = File.ReadAllLines(filePath).ToList();
            foreach (var item in lines)
            {
                var arr = item.Split(',');
                arrayList.Add(arr);
            }

            foreach (var item in arrayList)
            {
                var str = $"{item[0] }";
            }
        }

        private void addUser_Click(object sender, RoutedEventArgs e)
        {
            string[] strArray = new string[] { "Jordan,Jones,41,1" };
            personList.Items.Add($"{firstName.Text},{lastName.Text},{age.Text},{checkBox.IsChecked}");
        }

        private void saveList_Click(object sender, RoutedEventArgs e)
        {
            lines.Add($"{firstName.Text},{lastName.Text},{age.Text},{checkBox.IsChecked}");
            File.WriteAllLines(filePath, lines);
        }
    }
}


