using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using CarGuide.Assets.Cardescription;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CarGuide
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (model.SelectedItem.ToString() == "116i")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.BMW));
            if (model.SelectedItem.ToString() == "328i")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription._328i));
            if (model.SelectedItem.ToString() == "520i")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription._520i));
            if (model.SelectedItem.ToString() == "740")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription._740));
            if (model.SelectedItem.ToString() == "X1")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.x1));
            if (model.SelectedItem.ToString() == "X3")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.x3));

            if (model.SelectedItem.ToString() == "Avanza")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.avanza));
            if (model.SelectedItem.ToString() == "Oris")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.oris));
            if (model.SelectedItem.ToString() == "Fortuner")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.fortuner));
            if (model.SelectedItem.ToString() == "Corolla")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.corolla));
            if (model.SelectedItem.ToString() == "Land Cruiser")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.landcruiser));
            if (model.SelectedItem.ToString() == "Yaris")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.yaris));

            if (model.SelectedItem.ToString() == "Astra GTC")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.astragtc));
            if (model.SelectedItem.ToString() == "Astra")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.astra));
            if (model.SelectedItem.ToString() == "Adam")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.Adam));
            if (model.SelectedItem.ToString() == "Insignia")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.insignia));
            if (model.SelectedItem.ToString() == "Corsa")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.corsa));
            if (model.SelectedItem.ToString() == "Meriva")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.meriva));

            if (model.SelectedItem.ToString() == "Picanto")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.picanto));
            if (model.SelectedItem.ToString() == "Rio")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.rio));
            if (model.SelectedItem.ToString() == "Soul")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.Soul));
            if (model.SelectedItem.ToString() == "Sportage")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.sportage));
            if (model.SelectedItem.ToString() == "Sorento")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.sorento));
            if (model.SelectedItem.ToString() == "Cerato")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.cerato));

            if (model.SelectedItem.ToString() == "I10")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.i10));
            if (model.SelectedItem.ToString() == "I30")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.i30));
            if (model.SelectedItem.ToString() == "IX35")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.ix35));
            if (model.SelectedItem.ToString() == "Accent")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.accent));
            if (model.SelectedItem.ToString() == "Elantra")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.elantra));
            if (model.SelectedItem.ToString() == "Grand I10")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.grandi10));

            if (model.SelectedItem.ToString() == "CC")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.cc));
            if (model.SelectedItem.ToString() == "Passat")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.passat));
            if (model.SelectedItem.ToString() == "Polo")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.polo));
            if (model.SelectedItem.ToString() == "Tiguan")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.tiguan));
            if (model.SelectedItem.ToString() == "Golf")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.golf));
            if (model.SelectedItem.ToString() == "Jetta")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.jetta));


            if (model.SelectedItem.ToString() == "Pathfinder")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.pathfinder));
            if (model.SelectedItem.ToString() == "Tiida")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.tiida));
            if (model.SelectedItem.ToString() == "Juke")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.juke));
            if (model.SelectedItem.ToString() == "Sentra")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.sentra));
            if (model.SelectedItem.ToString() == "Sunny")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.sunny));
            if (model.SelectedItem.ToString() == "Qashqai")
                this.Frame.Navigate(typeof(CarGuide.Assets.Cardescription.qashqai));


        }




        private void brand_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (((ComboBoxItem)brand.SelectedItem).Content.ToString() == "BMW")
            {
                model.Items.Add("116i");
                model.Items.Add("328i");
                model.Items.Add("520i");
                model.Items.Add("740");
                model.Items.Add("X1");
                model.Items.Add("X3");

            }

            if (((ComboBoxItem)brand.SelectedItem).Content.ToString() == "Toyota")
            {
                model.Items.Add("Avanza");
                model.Items.Add("Oris");
                model.Items.Add("Fortuner");
                model.Items.Add("Corolla");
                model.Items.Add("Land Cruiser");
                model.Items.Add("Yaris");

            }

            if (((ComboBoxItem)brand.SelectedItem).Content.ToString() == "Opel")
            {
                model.Items.Add("Astra GTC");
                model.Items.Add("Astra");
                model.Items.Add("Adam");
                model.Items.Add("Insignia");
                model.Items.Add("Corsa");
                model.Items.Add("Meriva");

            }
            if (((ComboBoxItem)brand.SelectedItem).Content.ToString() == "KIA")
            {
                model.Items.Add("Picanto");
                model.Items.Add("Rio");
                model.Items.Add("Sportage");
                model.Items.Add("Sorento");
                model.Items.Add("Soul");
                model.Items.Add("Cerato");

            }
            if (((ComboBoxItem)brand.SelectedItem).Content.ToString() == "Hyndai")
            {
                model.Items.Add("I10");
                model.Items.Add("I30");
                model.Items.Add("IX35");
                model.Items.Add("Accent");
                model.Items.Add("Elantra");
                model.Items.Add("Grand I10");

            }
            if (((ComboBoxItem)brand.SelectedItem).Content.ToString() == "VolexWagen")
            {
                model.Items.Add("CC");
                model.Items.Add("Passat");
                model.Items.Add("Polo");
                model.Items.Add("Tiguan");
                model.Items.Add("Golf");
                model.Items.Add("Jetta");

            }
            if (((ComboBoxItem)brand.SelectedItem).Content.ToString() == "Nissan")
            {
                model.Items.Add("Pathfinder");
                model.Items.Add("Tiida");
                model.Items.Add("Juke");
                model.Items.Add("Sentra");
                model.Items.Add("Sunny");
                model.Items.Add("Qasqai");

            }

        }

        private void model_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
