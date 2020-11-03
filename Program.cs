using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Инвентарь, Скамейка, Брусья, Мяч, Маты, Баскетбольный мяч,
Теннис.*/
namespace Laba5
{

    public static class Print
    {
        public static void IAmPrinting(Ten obj) //реализация IAmPrinting
        {
            Console.WriteLine($"This is {obj.GetType()}");
            obj.ToString();
        }
    }

    interface IAmForTypography //интерфейс (пользовательский)
    {
        bool ForTyp();
        bool NotForTyp();
    }

    public abstract class Ten
    {
        public string Shop { get; set; }
        public Ten(string shop)
        {
            Shop = shop;
        }

        public virtual void Typ() //виртуальный метод
        {
            Console.WriteLine("It's for typography");
        }
    }
    public class tennis : Ten
    {
        public int tennisAm { get; set; }
        public float Price { get; set; }
        public tennis(string shop, int amount, float price) : base(shop)
        {
            tennisAm = amount;
            Price = price;
        }

        public override string ToString()
        {
            string str;
            str = "Shop: " + Shop + "; Goods' amount:" + tennisAm + "; Goods' price: " + Price + " BYN";
            return str;
        }

    }


    public class brus : tennis, IAmForTypography
    {
        public bool IsForTyp = false;
        public string name = "Brus";
        public string brusFirm { get; set; }
        public string brusModel { get; set; }
        public brus(string firm, string model, string shop, int amount, float price) : base(shop, amount, price)
        {
            this.brusFirm = firm;
            this.brusModel = model;
        }

        public override string ToString()
        {
            string str;
            str = "Shop: " + Shop + "; Goods' name: " + name + "; firm: " + brusFirm + "; model: " + brusModel + "; amount: " + tennisAm + "; price: " + Price + " BYN";
            return str;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public bool ForTyp()
        {
            this.IsForTyp = true;
            return true;
        }

        public bool NotForTyp()
        {
            this.IsForTyp = false;
            return true;
        }

        public override void Typ() //переопр. вирт. метода
        {
            if (this.IsForTyp)
            {
                Console.WriteLine("It's a bench/brus/mats/other");
            }
            else Console.WriteLine("It's a stock/tennis/other");
        }
    }

    public class bench : tennis, IAmForTypography
    {
        public bool IsForTyp = false;
        public string name = "Bench";
        public string benchFirm { get; set; }
        public string benchModel { get; set; }
        public bench(string firm, string model, string shop, int amount, float price) : base(shop, amount, price)
        {
            this.benchFirm = firm;
            this.benchModel = model;
        }

        public override string ToString()
        {
            string str;
            str = "Shop: " + Shop + "; Goods' name: " + name + "; firm: " + benchFirm + "; model: " + benchModel + "; amount: " + tennisAm + "; price: " + Price + " BYN";
            return str;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public bool ForTyp()
        {
            this.IsForTyp = true;
            return true;
        }

        public bool NotForTyp()
        {
            this.IsForTyp = false;
            return true;
        }

        public override void Typ() //переопр. вирт. метода
        {
            if (this.IsForTyp)
            {
                Console.WriteLine("It's a bench/brus/mats/other");
            }
            else Console.WriteLine("It's a stock/tennis/other");
        }
    }

    public class mats : tennis, IAmForTypography
    {
        public bool IsForTyp = false;
        public string name = "Mats";
        public string matsFirm { get; set; }
        public string matsModel { get; set; }
        public mats(string firm, string model, string shop, int amount, float price) : base(shop, amount, price)
        {
            this.matsFirm = firm;
            this.matsModel = model;
        }

        public override string ToString()
        {
            string str;
            str = "Shop: " + Shop + "; Goods' name: " + name + "; firm: " + matsFirm + "; model: " + matsModel + "; amount: " + tennisAm + "; price: " + Price + " BYN";
            return str;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public bool ForTyp()
        {
            this.IsForTyp = true;
            return true;
        }

        public bool NotForTyp()
        {
            this.IsForTyp = false;
            return true;
        }

        public override void Typ() //переопр. вирт. метода
        {
            if (this.IsForTyp)
            {
                Console.WriteLine("It's a bench/brus/mats/other");
            }
            else Console.WriteLine("It's a stock/tennis/other");
        }
    }
    public class Ball : tennis, IAmForTypography
    {
        public bool IsForTyp = false;
        public string name = "Balls";
        public string ballFirm { get; set; }
        public string ballModel { get; set; }
        public Ball(string firm, string model, string shop, int amount, float price) : base(shop, amount, price)
        {
            this.ballFirm = firm;
            this.ballModel = model;
        }

        public override string ToString()
        {
            string str;
            str = "Shop: " + Shop + "; Goods' name: " + name + "; firm: " + ballFirm + "; model: " + ballModel + "; amount: " + tennisAm + "; price: " + Price + " BYN";
            return str;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public bool ForTyp()
        {
            this.IsForTyp = true;
            return true;
        }

        public bool NotForTyp()
        {
            this.IsForTyp = false;
            return true;
        }

        public override void Typ() //переопр. вирт. метода
        {
            if (this.IsForTyp)
            {
                Console.WriteLine("It's a bench/brus/mats/other");
            }
            else Console.WriteLine("It's a stock/tennis/other");
        }
    }
    sealed class Bball : Ball //бесплодный класс
    {
        public Bball(string firm, string model, string shop, int amount, float price) : base(firm, model, shop, amount, price) {; }
        public string ball = "notebook";
        public override string ToString()
        {
            string str;
            str = "Shop: " + Shop + "; Goods' name: " + ball + "; firm: " + ballFirm + "; model: " + ballModel + "; amount: " + tennisAm + "; price: " + Price + " BYN";
            return str;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ball ball1 = new Ball("HAF", "Max", "5ele", 5, 699);
            Console.WriteLine(ball1.ToString());
            Console.WriteLine(ball1.GetHashCode());
            Ball ball2 = new Ball("HAF", "izard", "5ele", 10, 1476);
            Console.WriteLine(ball2.Equals(ball1));

            Bball bb1 = new Bball("Pil", "lion", "5ele", 35, 2189);
            Console.WriteLine(bb1.ToString());

            if (bb1 is Ball) //принадлежит ПС?
            {
                Console.WriteLine("bb1 is ball");
            }
            else
            {
                Console.WriteLine("bb1 isn't ball");
            }
            Ball ball3 = bb1 as Ball; //преобразование в ПС
            ball3.ballModel = "Gaming";

            brus br1 = new brus("Central", "b 3", "5ele", 51, 539);
            Console.WriteLine(br1.ToString());

            mats mt1 = new mats("Luxe", "P-208II", "5ele", 7, 399);
            Console.WriteLine(mt1.ToString());

            bench bn1 = new bench("Max", "L805", "5ele", 16, 589);
            Console.WriteLine(bn1.ToString());

            Print.IAmPrinting(ball1);
            Print.IAmPrinting(ball2);
            Print.IAmPrinting(mt1);
            Print.IAmPrinting(bn1);

            Console.ReadLine();



        }
    }
}
