﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer
{
    internal class Person
    {
        public string name;
        private Wallet wallet;

        public Person(string name, int cash)
        {
            //TODO 2: Assign the value of the 'name' parameter to the 'name' member variable. One line.
            this.name = name;
            //TODO 3: Instantiate a new 'Wallet' object, passing the 'cash' parameter into its constructor. Assign this new Wallet to the 'wallet' member variable. One line.
            wallet = new Wallet(cash);
        }

        public void DisplayInfo()
        {
            //TODO 4: Use string interpolation in a ConsoleWriteLine to display the user's name and also the amount of money in their wallet (using dot notation). One line.
            Console.WriteLine($"{name} has {wallet.money} in their wallet.");
        }

        public void AcceptMoney(int amount)
        {
            //TODO 7: Use an assignment operator to increase the amount of money in the person's wallet by the value of the 'amount' parameter. One line.
            wallet.money += amount;
        }

        public bool TransferMoney(Person receiver, int amountToTransfer)
        {
            //TODO 8: Use a conditional to check if the 'amountToTransfer' parameter of this method is less than or equal to the amount of money in the wallet of the giver.
            //If the parameter is less than the amount in the wallet, subtract that amount from the wallet, then call the receiver's AcceptMoney() method and pass 'amountToTransfer' into it. Also use a Console.WriteLine to describe the transaction that occurred.
            //If the parameter is greater than the amount in the giver's wallet, do not transfer any money and instead print a message describing why the transfer failed.
            if (amountToTransfer <= wallet.money)
            {
                wallet.money -= amountToTransfer;
                receiver.AcceptMoney(amountToTransfer);
                Console.WriteLine($"{name} transferred {amountToTransfer} to {receiver.name}");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry this transfer was unable to complete due to there not being enough funds available.");
                return false;
            }
        }


    }
}
