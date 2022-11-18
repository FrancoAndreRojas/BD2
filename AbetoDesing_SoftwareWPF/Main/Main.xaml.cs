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
using AbetoDesing_SoftwareDAO.Model;

namespace AbetoDesing_SoftwareWPF.Main
{
    /// <summary>
    /// Lógica de interacción para Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeMaterialDesign();
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Session.SessionUserID = 1;
            Session.SessionUserName = "admin"; 
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        
        //    //PopupAcercaDe po = new PopupAcercaDe();
        //    //po.Show();


        private void lvwMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();

            //switch (((ListViewItem)(((ListView)sender).SelectedItem)).Name)
            //{
            //    case "listViewItem":
            //        usc = new Product.uscProduct();
            //        break;
            //}

            if (usc != null)
            {
                GridMain.Children.Add(usc);
            }

        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void InitializeMaterialDesign()
        {
            // Create dummy objects to force the MaterialDesign assemblies to be loaded
            // from this assembly, which causes the MaterialDesign assemblies to be searched
            // relative to this assembly's path. Otherwise, the MaterialDesign assemblies
            // are searched relative to Eclipse's path, so they're not found.
            var card = new Card();
            var hue = new Hue("Dummy", Colors.Black, Colors.White);
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PopupAcercaDe po = new PopupAcercaDe();
            po.Show();
        }

        private void lvwMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();

            switch (((ListViewItem)(((ListView)sender).SelectedItem)).Name)
            {
                case "listViewItem":
                    usc = new Product.uscProduct();
                    break;
            }

            if (usc != null)
            {
                GridMain.Children.Add(usc);
            }

        }
    }
}
