using System;

namespace StateDesignPattern_ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initially ATM Machine in CardNotInsertedState
            ATMMachineContext atmMachine = new ATMMachineContext();

            Console.WriteLine("ATM Machine Current state : "
                            + atmMachine.atmMachineState.GetType().Name);
            Console.WriteLine();
            atmMachine.EnterPin();
            atmMachine.WithdrawMoney();
            atmMachine.EjectCard();
            atmMachine.InsertCard();

            Console.WriteLine();

            // Card has been inserted so internal state of ATM Machine
            // has been changed to CardInsertedState
            Console.WriteLine("ATM Machine Current state : "
                            + atmMachine.atmMachineState.GetType().Name);
            Console.WriteLine();
            atmMachine.EnterPin();
            atmMachine.WithdrawMoney();
            atmMachine.InsertCard();
            atmMachine.EjectCard();
            Console.WriteLine("");
            // Card has been ejected so internal state of ATM Machine
            // has been changed to CardNotInsertedState
            Console.WriteLine("ATM Machine Current state : "
                            + atmMachine.atmMachineState.GetType().Name);
            Console.Read();

        }
    }
}
