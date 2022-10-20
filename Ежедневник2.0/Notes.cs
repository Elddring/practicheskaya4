/*
namespace Ежедневник2._0
{
    internal class Notes
    {
        public void example()
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
            DateTime = DateTime.AddDays(-1);
            //стрелка налево
            date = DateTime.AddDays(-1);


        }
    }
}*/
/*namespace Ежедневник2._0
{
    internal class Notes
    {
        public class Employee
        {
            public string Name { get; set; }
            public string Gender { get; set; }
            public string Phone { get; set; }
            public string Adress { get; set; }
            public string BirthDate { get; set; }
            public Employee() { }
            public void WriteEmployee()
            {
                using (StreamWriter sw = File.AppendText("SimpleNotebook.txt"))
                {
                    sw.WriteLine(this.Name);
                    sw.WriteLine(this.Gender);
                    sw.WriteLine(this.Phone);
                    sw.WriteLine(this.Adress);
                    sw.WriteLine(this.BirthDate);
                }
            }
            public static void DisplayEmployee(string name)
            {
                using (StreamReader sr = File.OpenText("SimpleNotebook.txt"))
                {
                    string temp = null;
                    while ((temp = sr.ReadLine()) != name && temp != null) ;
                    if (temp == name)
                    {
                        Console.WriteLine("Полное имя: " + temp);
                    }
                    else
                        Console.WriteLine("Такой сотрудник не найден . .");
                }
            }
        }
    }
}*/
/*public class Program
{
    public void second(string[] args)
    {
        Console.Clear()
        string state = null;
        while (state != "3")
        {
            Console.WriteLine(" 1 - добавить новую запись  2 - найти запись  3 - выход");
            state = Console.ReadLine();
            switch (state)
            {
                case "1":
                    Ejednevnik temp = new Ejednevnik();
                    Console.WriteLine("Введите заметку: ");
                    temp.Name = Console.ReadLine();
                    temp.WriteEmployee();
                    break;
                case "2":
                    string n = null;
                    Console.WriteLine("Введите имя сотрудника,которого ищем: ");
                    n = Console.ReadLine();
                    Ejednevnik.DisplayEmployee(n);
                    break;
                default:
                    break;
            }

        }
        Console.WriteLine("Работа завершена . . Нажмите клавишу для выхода . .");
        Console.ReadLine();
    }
}

*/