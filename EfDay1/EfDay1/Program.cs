using EfDay1;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace EfDay1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var context = new ApplicationContext())
            {
                using(var transc= context.Database.BeginTransaction())
                {
                    var frmWalt = context.wallets.Single(x => x.id == 2);
                    var toWalt =  context.wallets.Single(y => y.id == 6);
                    var ammountToTransfer = 6000;
                    // Withdrawal From Id=1 :
                    frmWalt.Balance -= ammountToTransfer;
                    //Deposit To Id =6:
                    toWalt.Balance += ammountToTransfer;
                    Console.WriteLine($"Sender Balance : {frmWalt.Balance}");
                    Console.WriteLine($"Reciever Balance : {toWalt.Balance}");
                    context.SaveChanges();
                    transc.Commit();


                }
                //context.SaveChanges();
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