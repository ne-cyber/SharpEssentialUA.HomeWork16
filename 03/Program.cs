using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        class House
        {
            public object field1;
            public object field2;

            public object Property1 { get; set; }
            public object Property2 { get; set; }

            public House Clone()
            {
                return (House)MemberwiseClone();
            }
            public House DeepClone()
            {
                House other = (House)MemberwiseClone();
                other.field1 = new object();
                other.field2 = new object();
                other.Property1 = new object();
                other.Property2 = new object();
                return other;
            }


            public House()
            {
                field1 = new object();
                field2 = new object();

                Property1 = new object();
                Property2 = new object();
            }
        }
        static void Main(string[] args)
        {
            House origin = new House();
            House clone = origin.Clone();

            Console.WriteLine("Shallow copy");
            Console.WriteLine("origin: {0}    field1 {1}     filed2 {2}    Property1 {3}    Property1 {4}", origin.GetHashCode(), origin.field1.GetHashCode(), origin.field2.GetHashCode(), origin.Property1.GetHashCode(), origin.Property2.GetHashCode());
            Console.WriteLine("clone:  {0}    field1 {1}     filed2 {2}    Property1 {3}    Property1 {4}", clone.GetHashCode(), clone.field1.GetHashCode(), clone.field2.GetHashCode(), clone.Property1.GetHashCode(), clone.Property2.GetHashCode());
           
            
            Console.WriteLine(new string('-', 30));

            clone = origin.DeepClone();
            Console.WriteLine("Deep copy");
            Console.WriteLine("origin: {0}    field1 {1}     filed2 {2}    Property1 {3}    Property1 {4}", origin.GetHashCode(), origin.field1.GetHashCode(), origin.field2.GetHashCode(), origin.Property1.GetHashCode(), origin.Property2.GetHashCode());
            Console.WriteLine("clone:  {0}    field1 {1}     filed2 {2}    Property1 {3}    Property1 {4}", clone.GetHashCode(), clone.field1.GetHashCode(), clone.field2.GetHashCode(), clone.Property1.GetHashCode(), clone.Property2.GetHashCode());

            






            Console.ReadKey();
        }
    }
}
