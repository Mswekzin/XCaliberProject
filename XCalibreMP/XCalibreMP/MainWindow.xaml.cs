using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Path = System.IO.Path;

namespace XCalibreMP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
//Saving the data on xml file on the specific chosen location 
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog fileToSave = new SaveFileDialog();

                String paths = "";
                  
                if (fileToSave.ShowDialog()==true)
                {     
                    paths=Path.GetFullPath(fileToSave.FileName);
                 }
                String[] s = paths.Split('\\');
                String sw = "";
                foreach(var item in s)
                {
                    sw += item + "/";
                }
                sw = sw.Remove(sw.Length - 1);
                information info = new information();
                info.StudentName = Name_txtb.Text;
                info.StudentID = ID_txtbx.Text;
                info.StudentName = Password1.Password;
                SaveXml.savedata(info, sw+".xml") ;
                msgLabel.Visibility = Visibility.Visible;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

//Clearing all the textboxes after inserting and saving the data
        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            Name_txtb.Text = "";
            ID_txtbx.Text = "";
            Password1.Password = ""; msgLabel.Visibility = Visibility.Hidden;
        }
    }
}
