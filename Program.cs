using Shop.Model;
using Shop.Repositories;
using Shop.Services;
using System;

namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CandyFileReaderService candyFileReaderService = new CandyFileReaderService();
            CandiesRepository candiesRepository = new CandiesRepository(candyFileReaderService);

            ShoppingBag shoppingBag = new ShoppingBag();


            Console.WriteLine("Įveskite kiek turite pinigų");
            if (int.TryParse(Console.ReadLine(), out int customerMoney))
            {
                if (customerMoney > 0)
                {
                    Console.WriteLine("Ar norite pamatyti prekių sąrašus ? (T/N)");
                    var customerChoiceForSeeingList = Console.ReadLine();
                    if (customerChoiceForSeeingList == "T")
                    {
                        Console.WriteLine("Jei norite pamatyti saldainių sąrašą spauskite S, jei mėsos - M, jei daržovių - D, jei gėrimų - G");
                        var customerChoiceForSeeingSpecificList = Console.ReadLine();
                        switch (customerChoiceForSeeingSpecificList)
                        {
                            case "S":
                                Console.WriteLine("Saldainiai:");
                                foreach (var candy in candiesRepository.GetAll())
                                {
                                    Console.WriteLine($"{candy.Name} {candy.Price} {candy.Weight}");
                                }
                                break;
                            case "M":
                                //TODO
                                break;
                            case "D":
                                //TODO
                                break;
                            case "G":
                                //TODO
                                break;
                            default:
                                //TODO
                                break;
                        }
                    }

                    while (true)
                    {
                        Console.WriteLine("Įveskite saldainio pavadinimą, kurį norite pirkti. Jeigu pirkti nenorite spauskite N");
                        var customerChoiceForBuyingProduct = Console.ReadLine();
                        if (customerChoiceForBuyingProduct == "N")
                        {
                            break;
                        }

                        var boughtProduct = candiesRepository.GetByName(customerChoiceForBuyingProduct);
                        shoppingBag.Products.Add(new Product() { Name = boughtProduct.Name, Price = boughtProduct.Price });
                    }

                    Console.WriteLine("Jūsų pirktos prekės yra:");
                    foreach (var item in shoppingBag.Products)
                    {
                        Console.WriteLine($"{item.Name} {item.Price}");
                    }
                    Console.WriteLine($"Galutinė kaina yra: {shoppingBag.FinalPrice}");


                }

            }





        }
    }
}
