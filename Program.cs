using System;

namespace LV_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadatak 1
            //    Notebook notebook = new Notebook();
            //    notebook.AddNote(new Note("Dominik", "domi"));
            //    notebook.AddNote(new Note("Skrinjar", "skic"));
            //    notebook.AddNote(new Note("osijek", "031"));

            //    Iterator iterator = notebook.GetIterator();

            //    while (iterator.IsDone != true)
            //    {
            //        iterator.Current.show();
            //        iterator.Next();
            //    }

            //3 zadatak
            //CareTaker careTaker = new CareTaker();
            //ToDoItem toDo = new ToDoItem("Dominik", "blabla", new DateTime(2020, 5, 14));
            //careTaker.AddPreviousState(toDo.StoreState());
            //toDo.text = "tekst";
            //toDo.title = "title";
            //careTaker.AddPreviousState(toDo.StoreState());

            //Console.WriteLine(toDo.ToString());


            //toDo.RestoreState(careTaker.Undo());
            //Console.WriteLine(toDo.ToString());
            //toDo.RestoreState(careTaker.Redo());
            //Console.WriteLine(toDo.ToString());
            //zadatak 4
            //BankCareTaker bankCare = new BankCareTaker();
            //BankAccount acc = new BankAccount("Dominik", "Skrinjar", 5.32m);
            //BankMemento memento = new BankMemento(acc);
            //bankCare.PreviousState = memento;
            //Console.WriteLine(bankCare.PreviousState.Balance.ToString());
            // acc.UpdateBalance(100m);
            //memento.AddPreviousState(acc);
            //bankCare.PreviousState = memento;
            //Console.WriteLine(bankCare.PreviousState.Balance.ToString());
            //zadatak 5
            AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            FileLogger fileLogger = new FileLogger(MessageType.ERROR | MessageType.WARNING, "logFile.txt");

            logger.Log("Burazz", MessageType.INFO);
            fileLogger.Log("Ajme buraz", MessageType.WARNING);
            fileLogger.Log("KKKKK", MessageType.INFO);

        }
    }
}
