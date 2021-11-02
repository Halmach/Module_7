using System;

namespace Module_7
{
    class Program
    {
        static void Main(string[] args)
        {
           
            



        }



    }



    abstract class Delivery
    {
        protected Address address;
        protected float deliveryCost;
        protected int phoneNumber;
        protected DateTime receiveTimeBegin;
        protected DateTime receiveTimeEnd;
        protected int numOrder;

        public Address Address { get { return address; } }
        public float DeliveryCost { get { return deliveryCost; } }
        public int PhoneNumber { get { return phoneNumber; } }
        public DateTime ReceiveTimeBegin { get { return receiveTimeBegin; } } // ?
        public DateTime ReceiveTimeEnd { get { return receiveTimeBegin; } } // ?
        public int NumOrder { get { return numOrder; } }


        public abstract void SendMessageToClient();
        // переопределить метод который сообщает что заказ прибыл 
        // 

        public Delivery(Address address,float deliveryCost,int phoneNumber,DateTime receiveTimeBegin, DateTime receiveTimeEnd, int numOrder)
        {
            this.numOrder = numOrder;
            this.address = address;
            this.deliveryCost = deliveryCost;
            this.phoneNumber = phoneNumber;
            this.receiveTimeBegin = receiveTimeBegin;
            this.receiveTimeEnd = receiveTimeEnd;
        }

    }

     class HomeDelivery:Delivery
    {

        private Courier courier;
        public HomeDelivery(Address address,
            float deliveryCost,
            int phoneNumber,
            DateTime receiveTimeBegin,
            DateTime receiveTimeEnd,
            int numOrder,
            Courier courier):base(address,deliveryCost,phoneNumber,receiveTimeBegin,receiveTimeEnd, numOrder)
        {
            this.courier = courier;

        }

        public override void SendMessageToClient()
        {
            Console.WriteLine("Курьер {0} сегодня будет у вас с {1} до {2}",
                (courier.Name + " " + courier.SurName),
                receiveTimeBegin.ToString("hh:mm"),
                receiveTimeEnd.ToString("hh:mm"));
            Console.WriteLine("Номер заказа:" + numOrder);
            Console.WriteLine("Телефон курьера:"+ courier.PhoneNumber); //  + courier.Phone
            Console.WriteLine("Телефон поддержки:" + phoneNumber); 
        }
    }

    sealed class PickPointDelivery : Delivery
    {
        private string pickPointName;
        int receiveCode;
        DateTime shelfLife;

        static int GenerateCode()
        {
            return new Random().Next();
        }

        public override void SendMessageToClient()
        {
            Console.WriteLine("Заказ № "+ numOrder + "доставлен в точку "+ pickPointName);
            address.ShowAddress();
            Console.WriteLine($"Код для получения заказа:{receiveCode}");
            Console.WriteLine("Срок хранения заказа  до {0:M}" + shelfLife);
            Console.WriteLine("Телефон службы поддежрки: " + phoneNumber);
            Console.WriteLine(" Точка работает с {0} до  {1} ", ReceiveTimeBegin.ToString(("hh:mm")), ReceiveTimeEnd.ToString(("hh:mm")));
        }

        public PickPointDelivery(Address address, float deliveryCost, int phoneNumber, DateTime receiveTimeBegin, DateTime receiveTimeEnd,
            string pickPointName,
            int numOrder) : base(address,
            deliveryCost,
            phoneNumber,
            receiveTimeBegin,
            receiveTimeEnd, numOrder)
        {
            this.pickPointName = pickPointName;
            receiveCode = GenerateCode();
        }

    }

    sealed class ShopDelivery : Delivery
    {
        private string shopName;
        public ShopDelivery(Address address, float deliveryCost, int phoneNumber, DateTime receiveTimeBegin, DateTime receiveTimeEnd,
            string shopName,
            int numOrder) : base(address,
            deliveryCost,
            phoneNumber,
            receiveTimeBegin,
            receiveTimeEnd,
            numOrder)
        {
            this.shopName = shopName;
        }


        public override void SendMessageToClient()
        {
            Console.WriteLine("Заказ № " + numOrder + "доставлен в магазин " + shopName);
            address.ShowAddress();
            Console.WriteLine("Телефон магазина: " + phoneNumber);
            Console.WriteLine(" Магазин работает с {0} до  {1} ", ReceiveTimeBegin.ToString(("hh:mm")), ReceiveTimeEnd.ToString(("hh:mm")));
        }
    }





    class OrderCollection<TDelivery> where TDelivery : Delivery
    {
        // массив заказов
        // индексатор для массива заказов

        private int numOrder = 0;
        private Order<TDelivery>[] orders = new Order<TDelivery>[100];

        public OrderCollection(Order<TDelivery> order)
        {

            orders[numOrder] = order;
            numOrder++;
        }


        public void AddOrder(Order<TDelivery> order)
        {
            orders[numOrder] = order;
            numOrder++;
        }
        

        public int OrdersLength
        {
            get { return orders.Length; }
        }

        public Order<TDelivery> this[int index]
        {
            get
            {
                if (index >= 0 && index < orders.Length)
                    return orders[index];
                return null;
            }
        }
    }

    class Product
    {
        protected string productName;

        public string ProductName
        {
            get { return productName; }
        }

        protected string description;

        public string Description
        {
            get { return description; }
        }

        protected float price;

        public float Price
        {
            get { return price; }
        }

        protected int numProduct;

        public int NumProduct
        {
            get { return numProduct; }
            set { if (numProduct > value) numProduct -= value;
                else Console.WriteLine("Недостаточно товара на складе для заказа");
            }
        }

        public Product(string productName,string description,float price,int numProduct)
        {
            this.productName = productName;
            this.description = description;
            this.price = price;
            this.numProduct = numProduct;
        }

        public void ShowProduct()
        {
            Console.WriteLine($"Наименование: {productName}");
            Console.WriteLine($"Описание: {description}");
            Console.WriteLine($"Цена: {price}");
            Console.WriteLine($"Количество товара на складе: {numProduct}");
        }

    }

    abstract class Person
    {
        protected string name;
        protected string surName;
        protected string mail;
        protected int phoneNumber;

        public string Name { get { return name; } }
        public string SurName { get { return surName; } }
        public int PhoneNumber { get { return phoneNumber; } }

      

        public string Mail
        {
            get { return mail; }
            set { if (value.Contains('@')) mail = value; else Console.WriteLine("Неверный email"); }
        }

        public Person(string name, string surName, string mail, int phoneNumber)
        {
            this.name = name;
            this.surName = surName;
            this.phoneNumber = phoneNumber;
        }

        

    }

    static class PersonExtension //s<T> where T:Person
    {
        public static void ShowOrders<T>(this  T person) where T: Client<Delivery>
        {
            for (int i = 0; i < person.Orders.OrdersLength; i++)
            {
                Console.WriteLine(person.Orders[i]);
                //...
            }
            
        }

   
    }

    class Courier : Person
    {
        public Courier(string name, string surName, string mail, int phoneNumber) : base(name, surName,
            mail, phoneNumber)
        {
           
        }
    }

    class Client<TDelivery> : Person where TDelivery : Delivery
    {
        Address address;
        protected OrderCollection<TDelivery> orders;

        public OrderCollection<TDelivery> Orders
        {
            get { return orders; }
        }

        public Address Address { get => address; set => address = value; }

        public Client(string name, string surName, string mail, int phoneNumber, Address address) : base(name, surName,
            mail, phoneNumber)
        {
            this.address = address;
        }

        public void AddOrder()
        {
            // выбирается тип доставки
            // выбирается добавляется заказ
            // 
        }
    }

    class Address
    {
        public string Country { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public int HouseNum { get; set; }


        public Address(string country, string city, string street, int houseNum)
        {
            this.Country = country;
            this.City = city;
            this.Street = street;
            this.HouseNum = houseNum;
        }

        public void ShowAddress()
        {
            Console.WriteLine($"Адрес: страна {Country}, город {City}, улица {Street}, дом {HouseNum}");
        }
    }


    

    class Order<TDelivery> where TDelivery : Delivery
    {
        protected int numOrder;

        public int NumOrder
        {
            get { return numOrder; }
        }
        protected TDelivery Delivery; // композиция

        protected Product[] goods;

        protected float orderPrice;

        protected float deliveryCost; // Delivery

        protected string orderComment;

        protected string orderStatus; // оплачен или нет 

        protected string orderDeliveryStatus; // Delivery

        protected int numGoods = 0; // количество товаров в заказе


        public void AddProduct()
        {
            // fill goods
        }



    }


}
