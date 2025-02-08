using System;
using static System.Console;
namespace Project{
    class Class3 {
        struct Client {
            public string Code;
            public string Name;
            public string Address;
            public string Phone;
            public int CountOrders;
            public int SumOrders;

            // constructor 
        public Client (string code, string name, string adress, string phone, int countOrders, int sumOrders)
        {
            Code = code;
            Name = name;
            Address = adress;
            Phone = phone;
            CountOrders = countOrders;
            SumOrders = sumOrders;
            }
        

        public void ShowInfo(){
            WriteLine($"Code: {Code}, Name: {Name}, Address: {Address}, Phone:{Phone}, CountOrders: {CountOrders}, SumOrders: {SumOrders}$");
            }
        }

        static void Main(){
            Client client1 = new Client ("VIP", "Versace", "Milan street 15", "5176667", 3, 400);
            client1.ShowInfo();
        }
    }
        
}