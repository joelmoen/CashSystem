using System.Dynamic;
using System.Net.Http.Headers;
namespace Checkout_System;

static class Program
{
    private static string? x;
    private static string? kvitto;
    //private static string? count;

    static void Main(string[] args)
    {
        // kvitto formatering
        using var file = File.AppendText("kvitto.txt");
        DateTime thisDay = DateTime.Today;
        file.WriteLine(" ");
        file.WriteLine(thisDay);
        file.WriteLine("Kvitto:");

        // Skapar varor
        var a1 = new Product(plu:"100", name:"Banan", price:20);
        var a2 = new Product(plu:"200", name:"Mjölk", price:35);
        var a3 = new Product(plu:"300", name:"Citron", price:30);
        var a4 = new Product(plu:"400", name:"Nocco", price:25);
        var a5 = new Product(plu:"500", name:"Snus", price:40);

        Console.WriteLine("---Kassa---");
        Console.WriteLine("1: Ny kund");
        Console.WriteLine("2: Avsluta");
        Console.WriteLine("-----------");
        int start = Convert.ToInt32(Console.ReadLine());
        if (start == 1)
        {
            while (x != "pay")
            {
                Console.WriteLine("Komando för betalning: 'pay 1'");
                Console.WriteLine("Skriv Plu och antal");
                string[] inputs = Console.ReadLine().Split(" ");
                string x = inputs[0];
                string antals = inputs[1];
            switch (x)
            {
                case "100":
                    Console.WriteLine(a1.GetName());
                    Console.WriteLine("Skriv antalet:");
                    int antal = Int32.Parse(antals);
                    file.WriteLine(a1.GetName() + " * "  + antal + " * " + a1.GetPrice() + " = " + (antal * a1.GetPrice()) + "kr");
                    //string kvitto =  antal+ " * " + a1.GetPrice()+" = "+ (antal * a1.GetPrice()) + "kr";
                    //Console.WriteLine( kvitto);
                    break;
                case "200":
                    Console.WriteLine(a2.GetName());
                    Console.WriteLine("Skriv antalet:");
                    antal = Int32.Parse(antals);
                    file.WriteLine(a2.GetName() + " * "  + antal + " * " + a2.GetPrice() + " = " + (antal * a2.GetPrice()) + "kr");
                    //Console.WriteLine(antal + " * " + a2.GetPrice() + " = " + (antal * a2.GetPrice()) + "kr");
                    break;
                case "300":
                    Console.WriteLine(a3.GetName());
                    Console.WriteLine("Skriv antalet:");
                    antal = Int32.Parse(antals);
                    file.WriteLine(a3.GetName() + " * "  + antal + " * " + a3.GetPrice() + " = " + (antal * a3.GetPrice()) + "kr");
                   //Console.WriteLine(antal + " * " + a3.GetPrice() + " = " + (antal * a3.GetPrice()) + "kr");
                    break;
                case "400":
                    Console.WriteLine(a4.GetName());
                    Console.WriteLine("Skriv antalet:");
                    antal = Int32.Parse(antals);
                    file.WriteLine(a4.GetName() + " * " + antal + " * " + a4.GetPrice() + " = " + (antal * a4.GetPrice()) + "kr");
                    //Console.WriteLine(antal + " * " + a4.GetPrice() + " = " + (antal * a4.GetPrice()) + "kr");
                    break;
                case "500":
                    Console.WriteLine(a5.GetName());
                    Console.WriteLine("Skriv antalet:");
                    antal = Int32.Parse(antals);
                    file.WriteLine(a5.GetName() + " * "  + antal + " * " + a5.GetPrice() + " = " + (antal * a5.GetPrice()) + "kr");
                    //Console.WriteLine(antal + " * " + a5.GetPrice() + " = " + (antal * a5.GetPrice()) + "kr");
                    break;
                case "pay":
                    Console.WriteLine("Du har betalat");
                    return;
                //break;
                default:
                    Console.WriteLine("Denna vara finns ej");
                    break;
                }
            }
            }
        else if(start == 2)
        {
           Console.WriteLine("hej då");
        }
        else
        {
            Console.WriteLine("Error...");
        }
        // else (throw bad exeption)
        //TODO
    }
}