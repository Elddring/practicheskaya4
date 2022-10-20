public class Employee
{
    public string State { get; set; }
    public string BigState { get; set; }
    public Employee() { }
    public void WriteEmployee()
    {
        using (StreamWriter sw = File.AppendText("EJEVNEVNIC.txt"))
        {
            sw.WriteLine(this.State);
            sw.WriteLine(this.BigState);
            sw.WriteLine(DateTime.Now);
        }
    }
    public static void DisplayEmployee(string name)
    {
        using (StreamReader sr = File.OpenText("EJEVNEVNIC.txt"))
        {
            string Name = null;

            /*while ((Name = sr.ReadLine()) != name && Name != null) ;
            if (Name == name)
            {
                Console.WriteLine("заметка: " );
                Console.WriteLine(String.Format("ТЕкст заметки  : " + sr.ReadLine()));
                Console.WriteLine(String.Format("Время: \n" + sr.ReadLine()));

            }*/
            /*int count = System.IO.File.ReadAllLines("EJEVNEVNIC.txt").Length;
            string[] NewFile = File.ReadAllLines("EJEVNEVNIC.txt");
            for (int i = 0; i < count; i += 3)
            {
                if (Name.Contains(d))
                {
                    int a = i;
                    string line = File.ReadLines("EJEVNEVNIC.txt").Skip(a).Take(1).First();
                    Console.WriteLine("  " + a / 3 + ". " + line);
                }
                

            }*/
            int count = System.IO.File.ReadAllLines("EJEVNEVNIC.txt").Length;
            string[] NewFile = File.ReadAllLines("EJEVNEVNIC.txt");
            for (int i = 0; i < count; i += 3)
            {
                
                int a = i;
                string line = File.ReadLines("EJEVNEVNIC.txt").Skip(a).Take(1).First();
                Console.WriteLine("  "+ a/3 +". " + line);

            }
            /*string line = File.ReadLines("EJEVNEVNIC.txt").Skip(4).Take(1).First();
            Console.WriteLine(line);*/

            /*for (int i = 0; i < count; i++)
            {
                Console.WriteLine(String.Format(sr.ReadLine()));
            }*/
        }
    }

}