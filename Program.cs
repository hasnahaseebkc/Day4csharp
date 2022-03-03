using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // **************DICTIONARY******************

            var pair = new Dictionary<string, string>();    //dictionary collection
            pair.Add("in", "India");
            pair.Add("af", "Africa");
            pair.Add("us", "United States");
            pair.Add("ja", "Japan");
            pair.Add("ch", "China");
            pair.Add("ca", "Canada");
            Console.WriteLine("Keys present in dictionary: ");
            var key = new List<string>(pair.Keys);
            foreach (string k in key)
            {
                Console.WriteLine("{0}", k);
            }
            Console.WriteLine("Values present in dictionary: ");
            var value = new List<string>(pair.Values);
            foreach (string val in value)
            {
                Console.WriteLine("{0}", val);
            }

            foreach (KeyValuePair<string, string> pair1 in pair)
            {
                Console.WriteLine("{0} and {1}", pair1.Key, pair1.Value);
            }


            ////********************** STACK **********************

            var st = new Stack<int>();
            st.Push(10);
            st.Push(40);
            st.Push(33);
            st.Push(62);
            st.Push(48);
            st.Push(21);
            st.Push(31);
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Peek());
            Console.WriteLine();
            foreach (int i in st)
            {
                Console.WriteLine(i);

            }


            ////******************** QUEUE ************************

            var q = new Queue<string>();
            q.Enqueue("Item 1");
            q.Enqueue("Item 2");
            q.Enqueue("Item 3");
            q.Enqueue("Item 4");
            q.Enqueue("Item 5");
            q.Enqueue("Item 6");
            q.Enqueue("Item 7");
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Peek());
            Console.WriteLine();
            foreach (string s in q)
            {
                Console.WriteLine(s);
            }

            //************************* HASHTABLE ******************************8

            Hashtable ht = new Hashtable();

            ht.Add("001", "Aakash");
            ht.Add("002", "Aakass Elango");
            ht.Add("003", "Riju");
            ht.Add("004", "Vishal");
            ht.Add("005", "Nevetha");
            ht.Add("006", "Naveen");
            ht.Add("007", "Lalith");

            if (ht.ContainsValue("xyz"))
            {
                Console.WriteLine("This student name is already in the list.");
            }
            else
            {
                ht.Add("008", "xyz");
            }

            ICollection key1 = ht.Keys;
            foreach (string s in key1)
            {
                Console.WriteLine(s + ":" + ht[s]);
            }


            //************************** BIT ARRAYS *************************




            Console.ReadLine();

        }
    }
}
