using Microsoft.VisualBasic;
using shablon;
using System.IO;
using System.Text;

namespace Ежедневник2._0
{
    internal class Program
    {
        private static string path;

        static void Main(string[] args)
        {
            string file_name = "EJEVNEVNIC.txt";
            string state = null;
            Console.Clear();
            while (state != "3")
            {
                try
                {
                    Search();
                    Console.ReadLine();
                    Vivod();
                    DATA();
                    Console.WriteLine(" 1 - добавить новую запись  3 - выход");
                    state = Console.ReadLine();
                    switch (state)
                    {
                        case "1":
                            Vvod();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("Нажмите клавишу для выхода . .");
            Console.ReadLine();
        }
        static void DATA()
        {
            Console.Clear();
            DateTime date = new DateTime(2022, 10, 20);
            int position = 1;
            while (true)
            {
                Console.WriteLine("Выбрана дата:"+ date);
                string a = File.ReadAllText("EJEVNEVNIC.txt");
                Vivod();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                string TEXT = File.ReadAllText("EJEVNEVNIC.txt");
                string d = null;
                d = date.ToString("dd.MM.yyyy");
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position = position - 1;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    position = position + 1;
                }
                if (position == 0)
                {
                    position = position + 1;
                }
                if (position == 20)
                {
                    position = position - 1;
                }
                if (position == 1 /*&& date == TEXT*/)
                {
                    if (key.Key == ConsoleKey.Enter)
                    {
                        
                    }
                }
                if (position == 2)
                {
                    if (key.Key == ConsoleKey.Enter)
                    {
                        
                    }
                }
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    date = date.AddDays(-1);
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    date = date.AddDays(+1);
                }

            }

        }

        static void Vvod()
        {
            Employee temp = new Employee();
            Console.WriteLine("Введите заголовок заметки: ");
            temp.State = Console.ReadLine();
            Console.WriteLine("Введите Сообщение заметки ");
            temp.BigState = Console.ReadLine();
            temp.WriteEmployee();
        }
        static void Vivod()
        {
            string n = null;
            Employee.DisplayEmployee(n);
        }
        static void Search() 
        {
           
        }
    }
}


/*static void September()
{
    DateTime f = new DateTime(2022, 10, 12);
    f = DateTime.Now;
    f = f.AddDays(-1);
}
static void example()
{

    Notes note1 = new Notes();
    note1.Name = "fast";
    note1.Description = "fast";
    note1.EndDate = DateTime.Now;

    List<Notes> notes = new List<Notes>();
    notes.Add(note1);
    notes.Add(note1);
    notes.Add(note1);
    notes.Add(note1);
    DateTime date = DateTime.Now;

    List<Notes> nowNotes = Notes.Where(x => x.EndDate.Date == date.Date).ToList();
    //стелка направо
    date = DateTime.AddDays(+1);
    //стрелка налево
    date = DateTime.AddDays(-1);


}*/
