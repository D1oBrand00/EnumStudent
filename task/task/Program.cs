using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Program
    {
        enum Actions { OutPutAllStudents = 1,OutPutMaleStudents, OutPutFemaleStudents,InPut,Exit}
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                List<Student> st = new List<Student>();
                Console.Write("1 - Вывести список всех студентов.\n2 - Вывести список всех студентов-юношей.\n3 - Вывести список всех студентов-девушек.\n4 - Добавить студента в список.\n5 - Exit.\n\n");
                int act = int.Parse(Console.ReadLine());
                switch(act)
                {
                    case 1:
                        st.Add(Student.Input());
                        break;
                    case 2:
                        Student.OutPutAll(st);
                        break;
                }
                //switch((Actions)act)
                //{
                //    case Actions.OutPutAllStudents:
                //        Console.Clear();
                //        stud.OutPutAll();
                        
                //        break;
                //    //case Actions.OutPutMaleStudents:
                //    //    Console.Clear();
                //    //    foreach (var student in st)
                //    //    {
                //    //        if(student.Gend == Gender.Male)
                //    //        {
                //    //            student.OutPut();
                //    //        }    
                //    //    }
                //    //    Console.Write("Нажмите любую клавишу, чтобы вернуться назад.");
                //    //    char message2 = Console.ReadKey().KeyChar;
                //    //    break;
                //    //case Actions.OutPutFemaleStudents:
                //    //    Console.Clear();
                //    //    foreach (var student in st)
                //    //    {
                //    //        if (student.Gend == Gender.Female)
                //    //        {
                //    //            student.OutPut();
                //    //        }
                //    //    }
                //    //    Console.Write("Нажмите любую клавишу, чтобы вернуться назад.");
                //    //    char message3 = Console.ReadKey().KeyChar;
                //    //    break;
                //    case Actions.InPut:
                //        Console.Clear();
                //        stud.Input();
                //        break;
                //    case Actions.Exit:
                //        return;
                //}
            }    
            
        }

        
    }
}
