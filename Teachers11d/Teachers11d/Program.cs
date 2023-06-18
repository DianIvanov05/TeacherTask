using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teachers11d
{
    public class Program
    {
        static void Main(string[] args)
        {
        
            try
            {
              Console.WriteLine("Enter the count of the teacher to be tested: ");
              int count = int.Parse(Console.ReadLine());
              List<Teacher> teacherList = new List<Teacher>();
              StreamWriter teacherInfo = new StreamWriter("teacherInfo.txt");
              for (int i = 0; i < count; i++)
              {
                Console.WriteLine("Enter information about the teacher(name, school, classes, his subject, his contract and the name of the inspectorate: ");
                var data = Console.ReadLine().Split();
                Teacher teacher = new Teacher(data[0], data[1], data[2], data[3], data[4], data[5]);
                    teacherList.Add(teacher);
                    using(teacherInfo)
                    {
                        teacherInfo.WriteLine(data[0]);
                        teacherInfo.WriteLine(data[1]);
                        teacherInfo.WriteLine(data[2]);
                        teacherInfo.WriteLine(data[3]);
                        teacherInfo.WriteLine(data[4]);
                        teacherInfo.WriteLine(data[5]);
                    }
              }
                teacherList.ForEach(x => x.Print());
                string minClass = teacherList.Select(x => x.Classes).Min();
                Console.WriteLine(minClass);
                IComparerClass compare = new IComparerClass();
                teacherList.Sort(compare);                       
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Please enter a valid teacher name!");                
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Please enter the name of the school!");
                throw new ArgumentNullException("Classes must not be empty!");
                throw new ArgumentNullException("Please enter teacher's subject!");
                throw new ArgumentNullException("Please enter the type of contract(fixed term/permanent)");
            }
       
            


        }
    }
}
