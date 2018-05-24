using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.ServiceReference1;
using DAL.Models;


namespace DAL
{    
    public class Methods
    {
        MethodsClient _WCF = new MethodsClient();
        
        public List<CarUI> GetCars()
        {
            List<Car> ListCar = _WCF.GetCars().ToList();
            List<CarUI> ListCarUI = ListCar.Select(c => ConvertToCarUI(c)).ToList();
            return ListCarUI;
        }
        public CarUI ConvertToCarUI(Car car)
        {
            CarUI carUI = new CarUI()
            {
                Id = car.Id,
                Name = car.Name,
                Price = car.Price,
                Status = car.Status,
                Engine = ConvertToEngineUI(car.Engine),
                Gearbox = ConvertToGearBoxUI(car.Gearbox),
                Interior = ConvertToInteriorUI(car.Interior),
                Exterior = ConvertToExteriorUI(car.Exterior)
            };
            return carUI;
        }
        public EngineUI ConvertToEngineUI(Engine engine)
        {
            return new EngineUI
            {
                Id = engine.Id,
                Cylinders = engine.Cylinders,
                HP = engine.HP,
                Liters = engine.Liters,
                Name = engine.Name,
                Price = engine.Price,
                Producer = engine.Producer,
                Torque = engine.Torque,
                Type = engine.Type
            };
        }
        public GearboxUI ConvertToGearBoxUI(Gearbox gearbox)
        {
            return new GearboxUI
            {
                Id = gearbox.Id,
                Name = gearbox.Name,
                Price = gearbox.Price,
                Producer = gearbox.Producer,
                Quantity = gearbox.Quantity,
                Type = gearbox.Type
            };
        }
        public InteriorUI ConvertToInteriorUI(Interior interior)
        {
            return new InteriorUI
            {
                Id = interior.Id,
                Name = interior.Name,
                Colour = interior.Colour,
                Material = interior.Material,
                Price = interior.Price,
                Producer = interior.Producer
            };
        }
        public ExteriorUI ConvertToExteriorUI(Exterior exterior)
        {
            return new ExteriorUI
            {
                Id = exterior.Id,
                Colour = exterior.Colour,
                Name = exterior.Name,
                Price = exterior.Price,
                Producer = exterior.Producer,
                TypeOfPaint = exterior.TypeOfPaint
            };
        }

        public void AddParts(BasePartsUI basePartsUI)
        {
            BaseParts BaseParts = null;
            if (basePartsUI is EngineUI)
            {
                BaseParts = ConvertToEngine(basePartsUI as EngineUI);
            }
            else if (basePartsUI is GearboxUI)
            {
                BaseParts = ConvertTOGearbox(basePartsUI as GearboxUI);
            }
            else if (basePartsUI is InteriorUI)
            {
                BaseParts = ConvertTOInterior(basePartsUI as InteriorUI);
            }
            else if (basePartsUI is ExteriorUI)
            {
                BaseParts = ConvertTOExterior(basePartsUI as ExteriorUI);
            }
            _WCF.AddParts(BaseParts);
        }

        public List<BasePartsUI> GetBasePartsUI()
        {
            List<BaseParts> ListBaseParts = _WCF.GetBaseParts().ToList();
            List<BasePartsUI> ListBasePartsUI = ListBaseParts.Select(p => ConvertoToBasePartsUI(p)).ToList();

            return ListBasePartsUI;
        }

        public BasePartsUI ConvertoToBasePartsUI(BaseParts baseParts)
        {
            BasePartsUI basePartsUI = null;
            if (baseParts is Engine)
            {
                basePartsUI = ConvertToEngineUI(baseParts as Engine);
            }
            else if (baseParts is Gearbox)
            {
                basePartsUI = ConvertToGearBoxUI(baseParts as Gearbox);
            }
            else if (baseParts is Interior)
            {
                basePartsUI = ConvertToInteriorUI(baseParts as Interior);
            }
            else if (baseParts is Exterior)
            {
                basePartsUI = ConvertToExteriorUI(baseParts as Exterior);
            }
            return basePartsUI;
        }

        public void ModifyParts(BasePartsUI basePartsUI)
        {
            BaseParts baseParts = null;
            if (basePartsUI is EngineUI)
            {
                baseParts = ConvertToEngine(basePartsUI as EngineUI);
            }
            else if (basePartsUI is GearboxUI)
            {
                baseParts = ConvertTOGearbox(basePartsUI as GearboxUI);
            }
            else if (basePartsUI is InteriorUI)
            {
                baseParts = ConvertTOInterior(basePartsUI as InteriorUI);
            }
            else if (basePartsUI is ExteriorUI)
            {
                baseParts = ConvertTOExterior(basePartsUI as ExteriorUI);
            }
            _WCF.ModifyParts(baseParts);
        }

        public void ModifyUser(UserUI userUI)
        {
            User user = new User()
            {
                Id = userUI.Id,
                Balance = userUI.Balance,
                Login = userUI.Login,
                Password = userUI.Password
            };
            _WCF.ModifyUser(user);
        }

        public void SellCar(int id, int userid)
        {
            _WCF.SellCar(id, userid);
        }


        public void AddCar(CarUI carUI)
        {
            
            Car car = new Car()
            {
                Name=carUI.Name,
                Price=carUI.Price,
                Status=carUI.Status,
                Engine = ConvertToEngine(carUI.Engine),
                Gearbox = ConvertTOGearbox(carUI.Gearbox),
                Interior = ConvertTOInterior(carUI.Interior),
                Exterior = ConvertTOExterior(carUI.Exterior)
            };
            _WCF.AddCar(car);
        }
        public Engine ConvertToEngine(EngineUI engineUI )
        {
            Engine engine = new Engine()
            {
                Id = engineUI.Id,
                Cylinders = engineUI.Cylinders,
                HP = engineUI.HP,
                Liters = engineUI.Liters,
                Name = engineUI.Name,
                Price = engineUI.Price,
                Producer = engineUI.Producer,
                Torque = engineUI.Torque,
                Type = engineUI.Type
            };
            return engine;
        }
        public Gearbox ConvertTOGearbox(GearboxUI gearboxUI)
        {
            Gearbox gearbox = new Gearbox()
            {
                Id = gearboxUI.Id,
                Name = gearboxUI.Name,
                Price = gearboxUI.Price,
                Producer = gearboxUI.Producer,
                Quantity = gearboxUI.Quantity,
                Type = gearboxUI.Type
            };
            return gearbox;
        }
        public Interior ConvertTOInterior(InteriorUI interiorUI)
        {
            Interior interior = new Interior()
            {
                Id = interiorUI.Id,
                Name = interiorUI.Name,
                Colour = interiorUI.Colour,
                Material = interiorUI.Material,
                Price = interiorUI.Price,
                Producer = interiorUI.Producer
            };
            return interior;
        }
        public Exterior ConvertTOExterior(ExteriorUI exteriorUI)
        {
            Exterior exterior = new Exterior()
            {
                Id = exteriorUI.Id,
                Colour = exteriorUI.Colour,
                Price = exteriorUI.Price,
                Producer = exteriorUI.Producer,
                TypeOfPaint = exteriorUI.TypeOfPaint
            };
            return exterior;
        }



        public UserUI ValidateUser(string login, string password)
        {
            User user = _WCF.ValidateUser(login, password);
            UserUI userUI = null;
            if (user != null)
            {
                userUI = new UserUI();
                userUI.Id = user.Id;
                userUI.Login = user.Login;
                userUI.Balance = user.Balance;
                userUI.Password = user.Password;
            }
            return userUI;
        }

        public void AddUser(UserUI userUI)
        {
            User user = new User() { Id = userUI.Id, Balance = userUI.Balance, Login = userUI.Login, Password = userUI.Password };
            _WCF.AddUser(user);
        }

        public UserUI GetUser(int id)
        {
            User user = _WCF.GetUser(id);
            return new UserUI() { Id = user.Id, Balance = user.Balance, Login = user.Login, Password = user.Password };
        }

        public void ModifyCar(CarUI carUI)
        {
            Car car = new Car()
            {
                Id=carUI.Id,
                Name = carUI.Name,
                Price = carUI.Price,
                Status = carUI.Status,
                Engine = ConvertToEngine(carUI.Engine),
                Gearbox = ConvertTOGearbox(carUI.Gearbox),
                Interior = ConvertTOInterior(carUI.Interior),
                Exterior = ConvertTOExterior(carUI.Exterior)
            };
            _WCF.ModifyCar(car);
        }
    }
}
