using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public enum Gender { Male, Female }
    class Student
    {
        public string Fio { get; set; }
        public int Date { get; set; }
        //public Gender Gend {get;set;}
        public Student() { }
        public Student(string fio, int date)
        {
            //try
            //{
                this.Fio = fio;
                this.Date = date;
                //this.Gend = (Gender)Enum.Parse(typeof(Gender) , gend);
            //}
            //catch
            //{
            //    Console.Clear();
            //    Console.Write("Данные введены неправильно.\nНажмите любую клавишу, чтобы вернуться назад.\n");
            //    char message = Console.ReadKey().KeyChar;
            //}
            
        }
        public static Student Input()
        {
            //try
            //{
                Console.Write($"Введите ФИО студента: ");
                string fio = Console.ReadLine();
                Console.Write($"Введите год рождения студента: ");
                int date = int.Parse(Console.ReadLine());
                //Console.Write($"Введите гендер студента: ");
                //string gend = Console.ReadLine();
                return new Student(fio, date);
                //Console.Write("Нажмите любую клавишу, чтобы вернуться назад.");
                //char message4 = Console.ReadKey().KeyChar;



        }
        public void OutPut()
        {
            Console.Write($"{Fio}\n{Date}");
        }
        public static void OutPutAll(List<Student> students)
        {
            foreach(var st in students)
            {
                st.OutPut();
            }
            Console.Write("Нажмите любую клавишу, чтобы вернуться назад.");
            char message4 = Console.ReadKey().KeyChar;
        }
    }
}
