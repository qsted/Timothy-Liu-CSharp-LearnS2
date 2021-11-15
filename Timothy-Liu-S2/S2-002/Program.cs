using System;
using System.Collections.Generic;

namespace S2_002
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> 与非泛型Arraylist对应，后者都可以装但可能会有拆装箱操作
            // 与python list 对应 实现了Ilist 接口
            // 有序 有index
            // 有add方法就有{} 初始化器
            int[] array = new int[] { 100, 200, 300, 400 };
            Console.WriteLine(array is IEnumerable<int>);// True
            List<int> list = new List<int>();
            List<int> list1 = new List<int>(array);
            List<int> list2 = new List<int>(list1);
            List<int> list3 = new List<int>(50);// capacity = 50
            List<int> list5 = new List<int>() { 100, 200, 300, 400 };
            List<int> list6 = new List<int> { 10, 20, 30, 40 };

            list6.AddRange(list5);// 加在后边
            list6.Insert(0, 1000);
            list.Add(100);// 初始 capa = 4，8，16，32，2**n = list.Insert(list.Count,100)
            list6.InsertRange(0, list1);
            list6.AddRange(list1);
            list6.RemoveAt(0);// index
            list6.Remove(300);// value 第一个出现的值
            list6.RemoveAll(r => r == 400);
            list.RemoveRange(0, 2);// index
            list6.Clear();// capacity 不变

            Console.WriteLine($"{list.Count}/{list.Capacity}");// 0/0
            Console.WriteLine(String.Join(",",list));// 无元素 打印空行
        }
    }
}
