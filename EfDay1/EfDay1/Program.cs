﻿using EfDay1;
using Microsoft.Extensions.Configuration;

namespace EfDay1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var context = new ApplicationContext())
            { 
                var wlt=context.wallets.Single(x=>x.id==7);
                context.wallets.Remove(wlt);
                context.SaveChanges();
            }
        }
    }
}
//using (var context = new ApplicationContext())
//{
//    var wall = context.wallets.Single(x => x.Holder == "Medhat");
//    wall.Balance = 5060;
//    Console.WriteLine(wall.Balance);
//    context.SaveChanges();
//}
//var wallet = new Wallet();

//{
//Balance = 125400,
//            Holder = "Medhat"
//        };
//using(var context = new ApplicationContext()) 
//{
//    wallet.id = 7;
//    context.Add(wallet);
//    context.SaveChanges();
//}
//Console.WriteLine("Hello, There!");
//var itemId = 2;
//using (var context = new ApplicationContext())
//{
//    var item = context.wallets.FirstOrDefault(x => x.id == itemId);
//    Console.WriteLine(item);
//}