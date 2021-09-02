using System;
using System.Collections.Generic;

namespace ConsoleApp8_Y2HW1
{
    class T_shirt
    {
        public string size;
        public string color;
        public float price;
        public string image;
       
        public T_shirt (string valueSIZE,string valueCOLOR,float valuePRICE,string valueIMAGE)
        {
            size = valueSIZE;
            color = valueCOLOR;
            price = valuePRICE;
            image = valueIMAGE;
        }
        public void showorder()
        {
            Console.WriteLine("size is {0}", size);
            Console.WriteLine("color is {0}", color);
            Console.WriteLine("price is {0}", image);
            Console.WriteLine("image is {0}", price);
        }
    }
    class User
    {
        public string name;
        public string e_mail;
        public Shoppingcart shoppingcart;

        public User (string valueNAME, string valueE_MAIL, Shoppingcart valueShoppingCart)
        {
            name = valueNAME;
            e_mail = valueE_MAIL;
            shoppingcart  = valueShoppingCart;
        }
        public void showuser()
        {
            Console.WriteLine("name : {0}", name);
            Console.WriteLine("email : {0}", e_mail);
        }
    }
    class Address
    {
        public string street;
        public string city;
        public string zipcode;

        public Address(string valueSTREET, string valueCITY, string valueZIPCODE)
        {
            street = valueSTREET;
            city = valueCITY;
            zipcode = valueZIPCODE;
        }
        public void showaddress()
        {
            Console.WriteLine("{0}, {1}, {2}", street, city, zipcode);
        }
    }
    class Shoppingcart
    {
        public float totalcost = 0f;
        public Address address;
        private List<T_shirt> ordertshirt;
        public Shoppingcart(Address valueADDRESS)
        {
            address = valueADDRESS;
            ordertshirt = new List<T_shirt>();
        }
        public void TOTALCOST()
        {
            foreach (T_shirt tshirt in ordertshirt)
            {
                totalcost += tshirt.price;
            }
            Console.WriteLine("Total cost is  {0} ", totalcost );
        }
        public void addT_shirt(T_shirt tshirT)
        {
            ordertshirt .Add(tshirT);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            T_shirt order1 = new T_shirt("L", "RED", 500f, "Image1");
            T_shirt order2 = new T_shirt("M", "BLACK", 750f, "Image2");
            T_shirt order3 = new T_shirt("S", "magenta", 625f, "Image3");

            Address JameAddress = new Address("131/75 Phutthamonthon", "Nakhorn Pathom", "10180");
            Shoppingcart AllShoppingJame = new Shoppingcart(JameAddress);

            User Jame = new User("Jame Watson", "jame@gmail.com", AllShoppingJame);
            Jame.shoppingcart.addT_shirt(order1);
            Jame.shoppingcart.addT_shirt(order2);
            Jame.shoppingcart.addT_shirt(order3);

            order1.showorder();
            order2.showorder();
            order3.showorder();

            Jame.showuser();

            JameAddress.showaddress();


            Jame.shoppingcart.TOTALCOST ();

            Console.ReadLine();

            
        }
    }

}
