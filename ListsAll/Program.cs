using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
▪ List<T> съдържа списък от елементи (като масив, но разширяващ се)

▪ Позволява добавяне / вмъкване / премахване / търсене на елементи:
▪ Add(element) – добавя елемент към List<T>
▪ Count – връща броя на елементите в List<T>
▪ Remove(element) – премахва първото срещане на елемент (връща true / false)
▪ RemoveAt(index) – премахва елемент по неговия индекс
▪ Insert(index, element) – вмъква елемент на зададената позиция
▪ Contains(element) – определя дали елемента се съдържа в списъка
▪ Sort() – сортира във възходящ ред
▪ Reverse() – обръща списъка наобратно



string values = Console.ReadLine();
List<string> items = values.Split(' ').ToList();
List<int> nums = new List<int>();
for (int i = 0; i < items.Count; i++)
nums.Add(int.Parse(items[i]));
2 8 30 25 40 72 -2 44 56 string.Split(' ')
отделя низа с интервали
и прави колекция
Превръща
колекцията в List
var items = Console.ReadLine().Split(' ')
.Select(int.Parse).ToList();
 */
namespace ListsAll
{
    class Program
    {
        static void CreateNumList(List<int>myIntList)
        {
            Random rndObject = new Random();
            int n = rndObject.Next(5, 10);
            for (int i = 0; i < n; i++)
            {
                myIntList.Add(rndObject.Next(-100, 100));
            }
        }
        static void Main(string[] args)
        {
            /*
            var names = new List<string>(); // създава списък от низове
            names.Add("Peter");
            names.Add("Maria");
            names.Add("George");
            foreach (var name in names)
                Console.WriteLine(name);
            names.Remove("Maria");
            Console.WriteLine(String.Join(", ", names));

            Console.WriteLine();
            var nums = new List<int> {10, 20, 30, 40, 50, 60};// създава списък от цели числа
            foreach (var num in nums)
                Console.WriteLine(num);
            nums.RemoveAt(2);
            nums.Add(100);
            nums.Insert(0, -100);
            Console.WriteLine(String.Join(", ", nums));

            //Въвеждане на списъци от конзолата:
            int n = int.Parse(Console.ReadLine());
            List<int> myList = new List<int>();
            for (int i = 0; i < n; i++)
            {
                myList.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(String.Join(", ", myList));

            //Въвеждане на данни от един ред:
            string myNums = Console.ReadLine();
            List<string> myStrNumsLust = myNums.Split(' ').ToList();
            List<int> myIntNumsList = new List<int>();
            foreach (var strNum in myStrNumsLust)
            {
                myIntNumsList.Add(int.Parse(strNum));
            }
            Console.WriteLine(String.Join(" ",myIntNumsList));
            */
            //List<int> myIntList = new List<int>();
            //CreateNumList(myIntList);
            //Console.WriteLine(String.Join(" ", myIntList));

            ////Да се създаде списък от цели числа и да се премахнат всички срещания в списъка на последното му число. 
            //int num = myIntList[myIntList.Count() - 1];
            //while (myIntList.Remove(num))
            //{
            //    myIntList.Remove(num);
            //}
            //Console.WriteLine(String.Join(" ", myIntList));

            ////Да се създаде списък от цели числа, да се премахнат всички отрицателни числа и да се изведе списъка наобратно
            //List<int> myIntList2 = new List<int>();
            //CreateNumList(myIntList2);
            //Console.WriteLine(String.Join(" ", myIntList2));
            //for (int i = 0; i < myIntList2.Count(); i++)
            //{
            //    if (myIntList2[i]<0)
            //    {
            //        myIntList2.Remove(myIntList2[i]);
            //        i--;
            //    }
            //}
            //for (int i = myIntList2.Count()-1; i >= 0; i--)
            //{
            //    Console.Write(myIntList2[i]+" ");
            //}
            //Console.WriteLine();

            ////Въведете няколко списъци от цели числа
            ////▪ Стойностите са разделени от един или няколко интервала, а самите списъци са разделени с |
            ////▪ Изведете списъците слети започвайки с последния

            ////въвеждане на стринг с числа, разделени с интервали и | :
            //string nums = Console.ReadLine();           

            ////Създаване  на списък от списъци:
            //List<string> myNumsLists = nums.Split('|').ToList();

            //for (int i = myNumsLists.Count() - 1; i >=0 ; i--)
            //{
            //    List<string> endNumsString = myNumsLists[i].Split(' ').ToList<string>();

            //    List<int> endNums= new List<int>();
            //    foreach (var newNum in endNumsString)
            //    {
            //        newNum.Trim();
            //        endNums.Add(Convert.ToInt32(newNum));                    
            //    }
            //    Console.Write(String.Join(" ", endNums));
            //    Console.Write(" ");                
            //}           

            //var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //var counts = new int[nums.Max() + 1];
            //foreach (var num in nums)
            //    counts[num]++;
            //for (int i = 0; i < counts.Length; i++)
            //{
            //    if (counts[i] > 0)
            //        Console.WriteLine($"{i} -> {counts[i]}");
            //}


            //Console.WriteLine();
            //най-дълга растяща поредица в списък:
            List<int> myIntList = new List<int>();
            string line = Console.ReadLine();
            while (line!=null)
            {
                int x = int.Parse(line);
                myIntList.Add(x);
                line = Console.ReadLine();
            }
            myIntList.Sort();
            int count = 1;
            for (int i = 0; i < myIntList.Count()-1; i++)
            {                
                if (myIntList[i]== myIntList[i+1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("The element {0} occurs {1} times in the list.",myIntList[i],count);
                    count = 1;
                }
            }
            Console.WriteLine(String.Join(" ", myIntList));

            Console.ReadKey();

        }
    }
}
