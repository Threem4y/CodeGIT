using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Stonks
{
    public partial class MainWindow : Window
    {
        List<Zapis> zapisi = new List<Zapis>();

        public MainWindow()
        {
            InitializeComponent();
            List<Zapis> zapisi = new List<Zapis>()
            {
                new Zapis("Что то", "fsdfsd", 250),
            new Zapis("Что то", "fsdfsd", 2310),
            new Zapis("Что то", "fsdfsd", 123)
        };
            GridStonks.ItemsSource = zapisi;


        }


        private void GridStonks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Zapis selected = GridStonks.SelectedItem as Zapis;
            MessageBox.Show($"Имя: {selected.name} . тип: {selected.type}. цена: {selected.cost}");
            
        }

        private void BoxName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BoxType_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
      /*      Zapis a = new Zapis();*/
            Choose window = new Choose();
         /*   bool? result = window.ShowDialog();*/
           window.ShowDialog();
            /*           if (result == true)
                        {
                            BoxName.SelectedText
                        }*/
          /*  BoxType.Text = a.type;*/
        }

        private void BoxCost_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AddBut_Click(object sender, RoutedEventArgs e)
        {
/*            if (BoxName.Text != null && BoxType.Text != null && BoxCost != null)
            {
                var zapisonda = new Zapis();
                zapisonda.name = BoxName.Text;
                zapisonda.type = BoxType.Text;
                zapisonda.cost = Convert.ToInt32(BoxCost);*/
                zapisi.Add(new Zapis("новое имя","fsdfsd", 10));
                GridStonks.ItemsSource = null;
                GridStonks.ItemsSource = zapisi;

            
        }

        private void DeleteBut_Click(object sender, RoutedEventArgs e)
        {
            zapisi.RemoveAt(GridStonks.SelectedIndex);
            GridStonks.ItemsSource = zapisi;
           
        }

        private void ChangeBut_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
