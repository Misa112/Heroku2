using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public string AnimalType { get; set; }
        public bool IsKing { get; set; }
        public bool IsGood { get;set; }
        public BankAccount(string name, decimal balance, string animalType, bool isKing, bool isGood)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            IsKing = isKing;
            IsGood = isGood;
        }
        public BankAccount()
        {

        }
        public static List<BankAccount> InitializeList()
        {
            var bankAccounts = new List<BankAccount>()
            {
                new BankAccount("Simba",2000,"lion", true, true),
                new BankAccount("Scar",3000,"lion", true, false),
                new BankAccount("Mustafa", 5000, "lion", true, true),
                new BankAccount("Timon",800,"meerkat", false, true),
                new BankAccount("Pumbaa",1200,"pig", false, true),
                new BankAccount("Kamari",400,"hyena", false, false)
            };
            return bankAccounts;
        }
    }
}
