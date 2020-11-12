using System;
using System.Collections.Generic;
namespace DesmondLimited
{

    public delegate IList<decimal> InterestDel();
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("James", "Stuart", "0045504239", "Banker", 60000M, 0.6, 5);
            Customer customer2 = new Customer("Erhabor", "Pamela", "4356937898", "Coder", 60400M, 0.8, 3);
            Customer customer3 = new Customer("Samuel", "Bankole", "7755479799", "Teacher", 50000M, 0.4, 4);
            Customer customer4 = new Customer("Samuel", "Olugbemi", "0069404239", "Programmer", 1000000M, 0.8, 7);
            IList<Customer> customers = new List<Customer>(){customer1, customer2, customer3, customer4};
            Interest interest = new Interest(customers);
            InterestDel simpleinterestDel = interest.SimpleInterest;
            InterestDel compoundInterestDel = interest.CompoundInterest;
            IList<decimal> simpleInterests = simpleinterestDel();
            IList<decimal> compoundInterests = compoundInterestDel();

            // foreach (var item in simpleInterests)
            // {
            //     Console.WriteLine($"{item:C}");
            // }
            // Console.WriteLine();
            // foreach (var item in compoundInterests)
            // {
            //     Console.WriteLine($"{item:C}");
            // }
            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine($"{customers[i]}\nSimple Interest: {simpleInterests[i]:C}\nCompound Interest: {compoundInterests[i]:C}\n");
            }
        }
    }
}
