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
                            + atmMachine.CurrentATMState.GetType().Name);

            Console.WriteLine();
            atmMachine.EnterPin();
            atmMachine.WithdrawCash();
            atmMachine.EjectCard();
            atmMachine.InsertCard();

            Console.WriteLine();

            atmMachine.EnterPin();
            atmMachine.WithdrawCash();

            //Insert again when Machine has no cash
            atmMachine.InsertCard();
            atmMachine.EjectCard();

            Console.Read();
        }
    }
}
