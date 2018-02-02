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

            

        }

        private void wbrand_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            wmodel.Items.Clear();
            if (((ComboBoxItem)wbrand.SelectedItem).Content.ToString() == "BMW")
            {
                wmodel.Items.Add("116i");
                wmodel.Items.Add("328i");
                wmodel.Items.Add("520i");
                wmodel.Items.Add("740");
                wmodel.Items.Add("X1");
                wmodel.Items.Add("X3");

            }

            if (((ComboBoxItem)wbrand.SelectedItem).Content.ToString() == "Toyota")
            {
                wmodel.Items.Add("Avanza");
                wmodel.Items.Add("Oris");
                wmodel.Items.Add("Fortuner");
                wmodel.Items.Add("Corolla");
                wmodel.Items.Add("Land Cruiser");
                wmodel.Items.Add("Yaris");

            }

            if (((ComboBoxItem)wbrand.SelectedItem).Content.ToString() == "Opel")
            {
                wmodel.Items.Add("Astra GTC");
                wmodel.Items.Add("Astra");
                wmodel.Items.Add("Adam");
                wmodel.Items.Add("Insignia");
                wmodel.Items.Add("Corsa");
                wmodel.Items.Add("Meriva");

            }
            if (((ComboBoxItem)wbrand.SelectedItem).Content.ToString() == "KIA")
            {
                wmodel.Items.Add("Picanto");
                wmodel.Items.Add("Rio");
                wmodel.Items.Add("Sportage");
                wmodel.Items.Add("Sorento");
                wmodel.Items.Add("Soul");
                wmodel.Items.Add("Cerato");

            }
            if (((ComboBoxItem)wbrand.SelectedItem).Content.ToString() == "Hyndai")
            {
                wmodel.Items.Add("I10");
                wmodel.Items.Add("I30");
                wmodel.Items.Add("IX35");
                wmodel.Items.Add("Accent");
                wmodel.Items.Add("Elantra");
                wmodel.Items.Add("Grand I10");

            }
            if (((ComboBoxItem)wbrand.SelectedItem).Content.ToString() == "VolexWagen")
            {
                wmodel.Items.Add("CC");
                wmodel.Items.Add("Passat");
                wmodel.Items.Add("Polo");
                wmodel.Items.Add("Tiguan");
                wmodel.Items.Add("Golf");
                wmodel.Items.Add("Jetta");

            }
            if (((ComboBoxItem)wbrand.SelectedItem).Content.ToString() == "Nissan")
            {
                wmodel.Items.Add("Pathfinder");
                wmodel.Items.Add("Tiida");
                wmodel.Items.Add("Juke");
                wmodel.Items.Add("Sentra");
                wmodel.Items.Add("Sunny");
                wmodel.Items.Add("Qasqai");

            }

        }

        private void wmodel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (wmodel.SelectedItem.ToString() == "116i")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.w116i));
            if (wmodel.SelectedItem.ToString() == "328i")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.w328i));
            if (wmodel.SelectedItem.ToString() == "520i")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.w520i));
            if (wmodel.SelectedItem.ToString() == "520i")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.w520i));
            if (wmodel.SelectedItem.ToString() == "740")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.w740));
            if (wmodel.SelectedItem.ToString() == "X1")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wx1));
            if (wmodel.SelectedItem.ToString() == "X3")

                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wx3));
            if (wmodel.SelectedItem.ToString() == "Avanza")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wavanza));
            if (wmodel.SelectedItem.ToString() == "Oris")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.woris));
            if (wmodel.SelectedItem.ToString() == "Fortuner")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wfortuner));
            if (wmodel.SelectedItem.ToString() == "Corolla")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wcorolla));
            if (wmodel.SelectedItem.ToString() == "Land Cruiser")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wlandcruiser));
            if (wmodel.SelectedItem.ToString() == "Yaris")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wyaris));

            if (wmodel.SelectedItem.ToString() == "Astra GTC")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wastragtc));
            if (wmodel.SelectedItem.ToString() == "Astra")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wastra));
            if (wmodel.SelectedItem.ToString() == "Adam")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wadam));
            if (wmodel.SelectedItem.ToString() == "Insignia")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wcorsa));
            if (wmodel.SelectedItem.ToString() == "Meriva")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wmeriva));

            if (wmodel.SelectedItem.ToString() == "Picanto")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wpicanto));
            if (wmodel.SelectedItem.ToString() == "Rio")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wrio));
            if (wmodel.SelectedItem.ToString() == "Sportage")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wsportage));
            if (wmodel.SelectedItem.ToString() == "Sorento")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wsorento));
            if (wmodel.SelectedItem.ToString() == "Soul")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.Soul));
            if (wmodel.SelectedItem.ToString() == "Cerato")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wcerato));

            if (wmodel.SelectedItem.ToString() == "I10")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wi10));
            if (wmodel.SelectedItem.ToString() == "I30")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wi30));
            if (wmodel.SelectedItem.ToString() == "IX35")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wix35));
            if (wmodel.SelectedItem.ToString() == "Accent")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.waccent));
            if (wmodel.SelectedItem.ToString() == "Elantra")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.welantra));
            if (wmodel.SelectedItem.ToString() == "Grand I10")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wgrandi10));

            if (wmodel.SelectedItem.ToString() == "CC")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wcc));
            if (wmodel.SelectedItem.ToString() == "Passat")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wpassat));
            if (wmodel.SelectedItem.ToString() == "Polo")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wpolo));
            if (wmodel.SelectedItem.ToString() == "Tiguan")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wtiguan));
            if (wmodel.SelectedItem.ToString() == "Golf")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wgolf));
            if (wmodel.SelectedItem.ToString() == "Jetta")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wjetta));

            if (wmodel.SelectedItem.ToString() == "Payhfinder")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wpathfinder));
            if (wmodel.SelectedItem.ToString() == "Tiida")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wtiida));
            if (wmodel.SelectedItem.ToString() == "Juke")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wjuke));
            if (wmodel.SelectedItem.ToString() == "Sentra")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wsentra));
            if (wmodel.SelectedItem.ToString() == "Sunny")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wsunny));
            if (wmodel.SelectedItem.ToString() == "Qashqai")
                this.Frame.Navigate(typeof(CarGuide.Assets.wcars.wqashqai));


























































































        }
    }
}
