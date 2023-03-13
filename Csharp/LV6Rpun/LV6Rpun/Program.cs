using System;

namespace LV6Rpun
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            for (int i = 0; i < 10; i++)
            {
                notebook.AddNote(new Note($"title{i + 1}", $"text{i + 1}"));
            }
            IAbstractIterator iterator = notebook.GetIterator();
            Console.WriteLine(iterator.IsDone);
            iterator.Current.Show();
            iterator.First().Show();
            iterator.Next().Show();

            ToDoItem toDoItem = new ToDoItem("title", "text", DateTime.Now);
            Console.WriteLine(toDoItem.ToString());
            CareTaker careTaker = new CareTaker();
            Memento memento = toDoItem.StoreState();
            careTaker.AddState(memento);
            toDoItem.Rename("title2");
            memento = toDoItem.StoreState();
            careTaker.AddState(memento);
            toDoItem.ChangeTask("task2");
            toDoItem.RestoreState(memento);
            Console.WriteLine(toDoItem.ToString());
            foreach (Memento mementos in careTaker.GetPreviousStates())
            {
                Console.WriteLine(mementos.Text);
                Console.WriteLine(mementos.Title);
                Console.WriteLine(mementos.CreationTime);
                Console.WriteLine(mementos.TimeDue);
            }

            BankAccount bankAccount = new BankAccount("Dominik", "Brijest 73", 32);
            Console.WriteLine(bankAccount.Balance);
            BankAccountMemento bankMemento = bankAccount.StoreState();
            bankAccount.UpdateBalance(50);
            Console.WriteLine(bankAccount.Balance);
            bankMemento = bankAccount.StoreState();
            bankAccount.UpdateBalance(30);
            Console.WriteLine(bankAccount.Balance);
            bankMemento = bankAccount.StoreState();
            bankAccount.UpdateBalance(20);
            Console.WriteLine(bankAccount.Balance);
            bankAccount.RestoreState(bankMemento);
            Console.WriteLine(bankAccount.Balance );
            Console.WriteLine();

            Console.WriteLine("ZADNJI DIO:");
            AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            FileLogger fileLogger = new FileLogger(MessageType.ERROR | MessageType.WARNING, "logFile.txt");
            logger.SetNextLogger(fileLogger);
            logger.Log("message",MessageType.INFO);


            StringChecker stringDigitChecker = new StringDigitChecker();
            StringLengthChecker stringLengthChecker = new StringLengthChecker();
            StringLowerCaseChecker stringLowerCaseChecker = new StringLowerCaseChecker();
            StringUpperCaseChecker stringUpperCaseChecker = new StringUpperCaseChecker();

            stringDigitChecker.SetNext(stringLengthChecker);
            stringLengthChecker.SetNext(stringLowerCaseChecker);
            stringLowerCaseChecker.SetNext(stringUpperCaseChecker);

            Console.WriteLine(stringDigitChecker.Check("brate23A12as"));

            PasswordValidator passwordValidator = new PasswordValidator(new StringDigitChecker());
            passwordValidator.AddToChain(new StringUpperCaseChecker());
            passwordValidator.AddToChain(new StringLengthChecker());
            Console.WriteLine(passwordValidator.Validate("asdfd234aX12"));
        }
    }
}
