using _2023._01._25LINQ;
using _2023._01._25LinqApp;
using _2023._01._25LinqApp.DataSource;
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


//Created By Muhammed EROGLU
namespace LinqProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OgrenciData ogrenciData = new OgrenciData();
        public MainWindow()
        {
            InitializeComponent();
            dtgridStudent.ItemsSource = ogrenciData.OgrenciListesi;
        }

        private void dtgridStudent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void rdPassedStudents_Checked(object sender, RoutedEventArgs e)
        {
            dtgridStudent.ItemsSource = LinqMethods.GetPassedStudends();
        }

        private void rdFailedStudents_Checked(object sender, RoutedEventArgs e)
        {
            dtgridStudent.ItemsSource = LinqMethods.GetFailedStudends();
        }

        private void rdSuccessfulStudents_Checked(object sender, RoutedEventArgs e)
        {
            dtgridStudent.ItemsSource = LinqMethods.LinqTakeSuccessfulStudentElements();
        }

        private void rdThankfulStudents_Checked(object sender, RoutedEventArgs e)
        {
            dtgridStudent.ItemsSource = LinqMethods.LinqTakeThankfulStudentElements();
        }

        private void rdOrderStudentsAscending_Checked(object sender, RoutedEventArgs e)
        {
            dtgridStudent.ItemsSource = LinqMethods.LinqOrderStudentsAscending();
        }

        private void rdOrderStudentsDecending_Checked(object sender, RoutedEventArgs e)
        {
            dtgridStudent.ItemsSource = LinqMethods.LinqOrderStudentsDecending();
        }

        private void rdAllStudents_Checked(object sender, RoutedEventArgs e)
        {
            dtgridStudent.ItemsSource = ogrenciData.OgrenciListesi;
        }

        private void rdOrderStudentsOrderByName_Checked(object sender, RoutedEventArgs e)
        {
            dtgridStudent.ItemsSource = LinqMethods.LinqOrderWithNameAndSurname();
        }

        private void rdOrderStudentsOrderByGender_Checked(object sender, RoutedEventArgs e)
        {
            dtgridStudent.ItemsSource = LinqMethods.GroupStudentsAccordingToTheGender();
        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            // Todo implement search.
        }
    }
}
