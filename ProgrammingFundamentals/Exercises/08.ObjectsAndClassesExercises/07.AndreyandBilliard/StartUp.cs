namespace _07.AndreyandBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> menu = new Dictionary<string, decimal>();
            for (int i = 0; i < n; i++)
            {
                menu=ReadGameBarMenu(menu);
            }

            Customer newCustomer = new Customer();
            var orders = Console.ReadLine();
            while (orders!="end of clients")
            {
                string[] getClientInfo = orders.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var name = getClientInfo[0];
                var product = getClientInfo[1];
                var quantity = getClientInfo[2];

                if (menu.ContainsKey(product))
                {
                    if (!newCustomer.ShopList.ContainsKey(name))
                    {
                        newCustomer.ShopList.Add(name,new Dictionary<string, decimal>());
                        newCustomer.ShopList[name].Add(product, decimal.Parse(quantity));
                    }
                    else if (!newCustomer.ShopList[name].ContainsKey(product))
                    {
                        newCustomer.ShopList[name].Add(product, decimal.Parse(quantity));
                    }
                    else
                    {
                        newCustomer.ShopList[name][product] += decimal.Parse(quantity);
                    }

                    if (!newCustomer.Bills.ContainsKey(name))
                    {
                        newCustomer.Bills.Add(name, decimal.Parse(quantity) * menu[product]);
                    }
                    else
                    {
                        newCustomer.Bills[name] += decimal.Parse(quantity) * menu[product];
                    }
                }
                orders = Console.ReadLine();
            }
            foreach (var client in newCustomer.Bills.OrderBy(x=>x.Key).ThenBy(x=>x.Value))
            {
                Console.WriteLine($"{client.Key}");
                foreach (var pair in newCustomer.ShopList)
                {
                    foreach (var item in pair.Value)
                    {
                        if (pair.Key==client.Key)
                        {
                            Console.WriteLine($"-- {item.Key} - {item.Value}");
                        }
                    }
                }
                Console.WriteLine($"Bill: {client.Value:F2}");
            }
            
            Console.WriteLine($"Total bill: {newCustomer.Bills.Sum(x => x.Value)}");

        }

        private static Dictionary<string, decimal> ReadGameBarMenu(Dictionary<string,decimal>menu)
        {
            var input = Console.ReadLine().Split('-');
            if (!menu.ContainsKey(input[0]))
            {
                menu.Add(input[0], decimal.Parse(input[1]));
            }
            else
            {
                menu[input[0]] = decimal.Parse(input[1]);
            }
            return menu;
        }
    }
    class Customer
    {
        public Dictionary<string, Dictionary<string, decimal>> ShopList = new Dictionary<string, Dictionary<string, decimal>>();
        public Dictionary<string, decimal> Bills { get; set; } = new Dictionary<string, decimal>();
    }
}
