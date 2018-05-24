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
using DAL;
using DAL.Models;
using MahApps.Metro.Controls;

namespace courseworkui
{
    /// <summary>
    /// Interaction logic for DealerWindow.xaml
    /// </summary>
    public partial class DealerWindow : MetroWindow
    {
        public int id;
        UserUI UserUI = null;
        Methods Methods = new Methods();
        public DealerWindow()
        {
            InitializeComponent();

        }

        public void SetUser(UserUI userUI)
        {
            UserUI = userUI;
            usertextblock.Text = "Login: " + userUI.Login + "\nPassword: " + userUI.Password + "\nBalance: " + userUI.Balance;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            datagridcar.ItemsSource = null;
            datagridcar.ItemsSource = Methods.GetCars();

            CarEngine.ItemsSource = Methods.GetBasePartsUI().Where(i => i is EngineUI);
            CarGearbox.ItemsSource = Methods.GetBasePartsUI().Where(i => i is GearboxUI);
            CarInterior.ItemsSource = Methods.GetBasePartsUI().Where(i => i is InteriorUI);
            CarExterior.ItemsSource = Methods.GetBasePartsUI().Where(i => i is ExteriorUI);

            datagridengine.ItemsSource = Methods.GetBasePartsUI().Where(i => i is EngineUI);
            datagridgearbox.ItemsSource = Methods.GetBasePartsUI().Where(i => i is GearboxUI);
            datagridinterior.ItemsSource = Methods.GetBasePartsUI().Where(i => i is InteriorUI);
            datagridexterior.ItemsSource = Methods.GetBasePartsUI().Where(i => i is ExteriorUI);
        }

        private void AddCar(object sender, RoutedEventArgs e)
        {
            decimal.TryParse(CarPrice.Text, out decimal price);
            string name = CarName.Text;

            if (CarEngine.SelectedIndex >= 0 && CarGearbox.SelectedIndex >= 0 && CarInterior.SelectedIndex >= 0 && CarExterior.SelectedIndex >= 0 && price >= 0)
            {
                EngineUI engineUI = CarEngine.SelectedItem as EngineUI;
                GearboxUI gearboxUI = CarGearbox.SelectedItem as GearboxUI;
                InteriorUI interiorUI = CarInterior.SelectedItem as InteriorUI;
                ExteriorUI exteriorUI = CarExterior.SelectedItem as ExteriorUI;
                CarUI carUI = new CarUI() { Engine = engineUI, Exterior = exteriorUI, Gearbox = gearboxUI, Interior = interiorUI, Name = name, Price = price, Status = "Not Sold" };
                Methods.AddCar(carUI);
            }


        }

        private async void Refresh(object sender, RoutedEventArgs e)
        {
            List<CarUI> CarUI = await Task.Run(() =>
            {
                return Methods.GetCars();
            });
            var engine = await Task.Run(() => { return Methods.GetBasePartsUI().Where(i => i is EngineUI); });
            var gearbox = await Task.Run(() => { return Methods.GetBasePartsUI().Where(i => i is GearboxUI); });
            var interior = await Task.Run(() => { return Methods.GetBasePartsUI().Where(i => i is InteriorUI); });
            var exterior = await Task.Run(() => { return Methods.GetBasePartsUI().Where(i => i is ExteriorUI); });

            datagridcar.ItemsSource = null;
            CarEngine.ItemsSource = null;
            CarGearbox.ItemsSource = null;
            CarInterior.ItemsSource = null;
            CarExterior.ItemsSource = null;

            datagridcar.ItemsSource = CarUI;
            CarEngine.ItemsSource = engine;
            CarGearbox.ItemsSource = gearbox;
            CarInterior.ItemsSource = interior;
            CarExterior.ItemsSource = exterior;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (datagridcar.SelectedIndex >= 0)
            {
                if ((datagridcar.SelectedItem as CarUI).Status == "Not Sold")
                {
                    Methods.SellCar((datagridcar.SelectedItem as CarUI).Id, UserUI.Id);
                }
            }
        }

        private void AddEngine(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(EngineLiters.Text, out double Liters) &&
             int.TryParse(EngineHP.Text, out int HP) &&
             int.TryParse(EngineTorque.Text, out int Torque) &&
             int.TryParse(EngineCylinders.Text, out int Cylinders) &&
             decimal.TryParse(EnginePrice.Text, out decimal Price))
            {
                EngineUI engineUI = new EngineUI() { Cylinders = Cylinders, HP = HP, Torque = Torque, Price = Price, Liters = Liters, Name = EngineName.Text, Producer = EngineProducer.Text, Type = EngineType.Text };
                Methods.AddParts(engineUI);
            }

        }

        private void RefreshEngine(object sender, RoutedEventArgs e)
        {
            datagridengine.ItemsSource = null;
            datagridengine.ItemsSource = Methods.GetBasePartsUI().Where(i => i is EngineUI);
        }

        private void AddGearbox(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(GearboxGears.Text, out int Quantity) &&
             decimal.TryParse(GearboxPrice.Text, out decimal Price))
            {
                GearboxUI gearboxUI = new GearboxUI() { Name = GearboxName.Text, Price = Price, Quantity = Quantity, Producer = GearboxProducer.Text, Type = GearboxType.Text };
                Methods.AddParts(gearboxUI);
            }
        }

        private void RefreshGearbox(object sender, RoutedEventArgs e)
        {
            datagridgearbox.ItemsSource = null;
            datagridgearbox.ItemsSource = Methods.GetBasePartsUI().Where(i => i is GearboxUI);
        }

        private void AddInterior(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse(InteriorPrice.Text, out decimal Price))
            {
                InteriorUI interiorUI = new InteriorUI() { Price = Price, Producer = InteriorProducer.Text, Colour = InteriorColour.Text, Material = InteriorMaterial.Text };
                Methods.AddParts(interiorUI);
            }
        }

        private void RefreshInterior(object sender, RoutedEventArgs e)
        {
            datagridinterior.ItemsSource = null;
            datagridinterior.ItemsSource = Methods.GetBasePartsUI().Where(i => i is InteriorUI);
        }

        private void AddExterior(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse(ExteriorPrice.Text, out decimal Price))
            {
                ExteriorUI exteriorUI = new ExteriorUI() { Price = Price, Producer = ExteriorProducer.Text, Colour = ExteriorColour.Text, TypeOfPaint = ExteriorTypeOfPaint.Text };
                Methods.AddParts(exteriorUI);
            }
        }

        private void RefreshExterior(object sender, RoutedEventArgs e)
        {
            datagridexterior.ItemsSource = null;
            datagridexterior.ItemsSource = Methods.GetBasePartsUI().Where(i => i is ExteriorUI);
        }

        private void ModifyUser(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse(UserBalance.Text, out decimal Balance))
            {
                UserUI userUI = new UserUI() { Login = UserLogin.Text, Password = UserPassword.Text, Balance = Balance, Id = UserUI.Id };
                Methods.ModifyUser(userUI);
                UserUI = Methods.GetUser(UserUI.Id);
                usertextblock.Text = "Login: " + UserUI.Login + "\nPassword: " + UserUI.Password + "\nBalance: " + UserUI.Balance;
            }
        }

        private void BeginModifyEngine(object sender, RoutedEventArgs e)
        {
            EngineName.Text = (datagridengine.SelectedItem as EngineUI).Name;
            EnginePrice.Text = (datagridengine.SelectedItem as EngineUI).Price.ToString();
            EngineProducer.Text = (datagridengine.SelectedItem as EngineUI).Producer;
            EngineCylinders.Text = (datagridengine.SelectedItem as EngineUI).Cylinders.ToString();
            EngineHP.Text = (datagridengine.SelectedItem as EngineUI).HP.ToString();
            EngineTorque.Text = (datagridengine.SelectedItem as EngineUI).Torque.ToString(); ;
            EngineType.Text = (datagridengine.SelectedItem as EngineUI).Type;
            EngineLiters.Text = (datagridengine.SelectedItem as EngineUI).Liters.ToString();
            id = (datagridengine.SelectedItem as EngineUI).Id;
        }

        private void EndModifyEngine(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse(EnginePrice.Text, out decimal price)
                && (int.TryParse(EngineCylinders.Text, out int cylinders))
                && (int.TryParse(EngineHP.Text, out int hp))
                && (int.TryParse(EngineTorque.Text, out int torque))
                && (int.TryParse(EngineLiters.Text, out int liters))
                )
            {
                EngineUI engineUI = new EngineUI()
                {
                    Name = EngineName.Text,
                    Price = price,
                    Producer = EngineProducer.Text,
                    Cylinders = cylinders,
                    HP = hp,
                    Torque = torque,
                    Type = EngineType.Text,
                    Liters = liters,
                    Id = id
                };
                Methods.ModifyParts(engineUI);
            }
        }

        private void BeginModifyGearbox(object sender, RoutedEventArgs e)
        {
            GearboxName.Text = (datagridgearbox.SelectedItem as GearboxUI).Name;
            GearboxPrice.Text = (datagridgearbox.SelectedItem as GearboxUI).Price.ToString();
            GearboxProducer.Text = (datagridgearbox.SelectedItem as GearboxUI).Producer;
            GearboxGears.Text = (datagridgearbox.SelectedItem as GearboxUI).Quantity.ToString();
            GearboxType.Text = (datagridgearbox.SelectedItem as GearboxUI).Type;
            id = (datagridgearbox.SelectedItem as GearboxUI).Id;
        }

        private void EndModifyGearbox(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse(GearboxPrice.Text, out decimal price)
                && (int.TryParse(GearboxGears.Text, out int gears))
                )
            {
                GearboxUI gearboxUI = new GearboxUI()
                {
                    Name = GearboxName.Text,
                    Price = price,
                    Producer = GearboxProducer.Text,
                    Quantity = gears,
                    Type = GearboxType.Text,
                    Id = id
                };
                Methods.ModifyParts(gearboxUI);
            }
        }

        private void BeginModifyInterior(object sender, RoutedEventArgs e)
        {
            InteriorPrice.Text = (datagridinterior.SelectedItem as InteriorUI).Price.ToString();
            InteriorProducer.Text = (datagridinterior.SelectedItem as InteriorUI).Producer;
            InteriorColour.Text = (datagridinterior.SelectedItem as InteriorUI).Colour;
            InteriorMaterial.Text = (datagridinterior.SelectedItem as InteriorUI).Material;
            id = (datagridinterior.SelectedItem as InteriorUI).Id;
        }

        private void EndModifyInterior(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse(InteriorPrice.Text, out decimal price))
            {
                InteriorUI interiorUI = new InteriorUI()
                {
                    Price = price,
                    Producer = InteriorProducer.Text,
                    Colour = InteriorColour.Text,
                    Material = InteriorMaterial.Text,
                    Id = id
                };
                Methods.ModifyParts(interiorUI);
            }
        }

        private void BeginModifyExterior(object sender, RoutedEventArgs e)
        {
            ExteriorPrice.Text = (datagridexterior.SelectedItem as ExteriorUI).Price.ToString();
            ExteriorProducer.Text = (datagridexterior.SelectedItem as ExteriorUI).Producer;
            ExteriorColour.Text = (datagridexterior.SelectedItem as ExteriorUI).Colour;
            ExteriorTypeOfPaint.Text = (datagridexterior.SelectedItem as ExteriorUI).TypeOfPaint;
            id = (datagridexterior.SelectedItem as ExteriorUI).Id;
        }

        private void EndModifyExterior(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse(ExteriorPrice.Text, out decimal price))
            {
                ExteriorUI exteriorUI = new ExteriorUI()
                {
                    Price = price,
                    Producer = ExteriorProducer.Text,
                    Colour = ExteriorColour.Text,
                    TypeOfPaint = ExteriorTypeOfPaint.Text,
                    Id = id
                };
                Methods.ModifyParts(exteriorUI);
            }
        }

        private void BeginModifyCar(object sender, RoutedEventArgs e)
        {
            CarName.Text = (datagridcar.SelectedItem as CarUI).Name;
            CarPrice.Text = (datagridcar.SelectedItem as CarUI).Price.ToString();
            foreach (var item in CarEngine.Items)
            {
                if ((item as EngineUI).Id == (datagridcar.SelectedItem as CarUI).Engine.Id)
                    CarEngine.SelectedItem = item;
            }
            foreach (var item in CarGearbox.Items)
            {
                if ((item as GearboxUI).Id == (datagridcar.SelectedItem as CarUI).Gearbox.Id)
                    CarGearbox.SelectedItem = item;
            }
            foreach (var item in CarInterior.Items)
            {
                if ((item as InteriorUI).Id == (datagridcar.SelectedItem as CarUI).Interior.Id)
                    CarInterior.SelectedItem = item;
            }
            foreach (var item in CarExterior.Items)
            {
                if ((item as ExteriorUI).Id == (datagridcar.SelectedItem as CarUI).Exterior.Id)
                    CarExterior.SelectedItem = item;
            }
            id = (datagridcar.SelectedItem as CarUI).Id;
        }

        private void EndModifyCar(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse(CarPrice.Text, out decimal price))
            {
                CarUI carUI = new CarUI()
                {
                    Name = CarName.Text,
                    Price = price,
                    Engine = CarEngine.SelectedItem as EngineUI,
                    Gearbox = CarGearbox.SelectedItem as GearboxUI,
                    Interior = CarInterior.SelectedItem as InteriorUI,
                    Exterior = CarExterior.SelectedItem as ExteriorUI,
                    Id = id                    
                };
                Methods.ModifyCar(carUI);
            }
        }
    }
}
