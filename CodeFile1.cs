using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4GUI

{
    public class Gadjets
    {
        public static Random rnd = new Random();
        public int rasmer = 0;
        public virtual String GetInfo()
        {
            var str = String.Format("\nРазмер дисплея ={0}", this.rasmer);
            return str;
        }
    }
    public enum NoutbukType { Hp, Lenovo, Acer };
    public class Noutbuk : Gadjets
    {
        public NoutbukType type = NoutbukType.Hp;
        public int volumeHard = 0;
        public int quantityCore = 0;
        public bool rgb = false;
        public override String GetInfo()
        {
            var str = "";
            str += String.Format("\nФирма ноутбука: {0}", this.type);
            str += base.GetInfo();
            str += String.Format("\nОбъём жесткого диска: {0} Тб", this.volumeHard);
            str += String.Format("\nКоличество ядер: {0}", this.quantityCore);
            str += String.Format("\nНаличие подсветки: {0}", this.rgb);
            return str;
        }
        public static Noutbuk Generate()
        {
            return new Noutbuk
            {
                rasmer = 10+ rnd.Next() % 15,
                volumeHard =1+ rnd.Next() % 2,
                quantityCore =rnd.Next() % 12,
                rgb = rnd.Next() % 2 == 0,
                type = (NoutbukType)rnd.Next(3)
            };
        }
    }
    public enum PlanshetType { Prestige, Huawei, Meizu };
    public class Planshet : Gadjets
        {
            public PlanshetType type = PlanshetType.Prestige;
            public int dpi = 0;
            public bool camera = false;
            public override String GetInfo()
            {
                var str = "";
                str += String.Format("\nФирма планшета: {0}", this.type);
                str += base.GetInfo();
                str += String.Format("\nКоличество dpi экрана: {0}", this.dpi);
                str += String.Format("\nНаличие камеры: {0}", this.camera);
                return str;
            }
            public static Planshet Generate()
            {
                return new Planshet
                {
                    rasmer = 10 + rnd.Next() % 16,
                    dpi = 300 + rnd.Next() %1000, 
                    camera = rnd.Next() % 2 == 0,
                    type = (PlanshetType)rnd.Next(3)
                };

            }
        }
    public enum SmartfonType { Samsung, Apple, Honor };
    public class Smartfon : Gadjets
        {
            public SmartfonType type = SmartfonType.Samsung;
            public int quantitySim = 0;
            public int quantityMgps = 0;
            public bool battery = false;
            public override String GetInfo()
            {
                var str = "";
                str += String.Format("\nФирма смартфона: {0}", this.type);
                str += base.GetInfo();
                str += String.Format("\nКоличество слотов для Sim-карт: {0}", this.quantitySim);
                str += String.Format("\nКоличество мегапикселей: {0}", this.quantityMgps);
                str += String.Format("\nСъемная батарея: {0}", this.battery);
                return str;
            }
            public static Smartfon Generate()
            {
                    return new Smartfon
                    {
                        rasmer =8+ rnd.Next() % 8,
                        quantitySim = 1 + rnd.Next() % 2,
                        quantityMgps = 12 + rnd.Next() % 48, 
                        battery = rnd.Next() % 2 == 0,
                        type = (SmartfonType)rnd.Next(3)
                    };
            }

        }
    }
