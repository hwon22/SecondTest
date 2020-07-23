using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTest
{
    class ClassUse
    {
        static void Main(string[] args)
        {
            //list 요소 값 찾기
            List<int> list = new List<int>();
            list.Add(23);
            list.Add(52);
            list.Add(110);
            foreach (var item in list)
            {
                Console.WriteLine("Count: " + list.Count + "\titem: " + item);
                /* 
                   Count: 3     item: 23
                   Count: 3     item: 52
                   Count: 3     item: 110
                */
            }
            
            Console.WriteLine(); // 줄바꿈
            
            //list 번호와 값 출력하기
            for(int i=0; i<list.Count; i++) //배열은 0부터 세기 때문에 012 칸 까지 사용, 따라서 범위는 i<list.Count
            {
                Console.WriteLine("item_Number: " + i+ "\titem_Value: " + list[i]); //list로 찍어버리면 list의 값을 담는 공간이 없어서 그냥 리스트정보? 같은 것 나옴
                /* 
                 Count: 0     item: 23
                 Count: 1     item: 52
                 Count: 2     item: 110
                */
            }
            
            Console.WriteLine(); // 줄바꿈

            //list 클래스 선언과 동시에 초기화하기
            List<int> list2 = new List<int>() { 52, 23, 10, 2 } ;
            foreach(var item in list2)
            {
                Console.WriteLine("Count: " + list2.Count + "\titem: " + item);
                /* 
                Count: 4     item: 52
                Count: 4     item: 23
                Count: 4     item: 10
                Count: 4     item: 2
               */
            }

            Console.WriteLine();

            //list 요소 삭제
            List<int> list3 = new List<int>();
            list3.Add(22);
            list3.Add(33);
            list3.Add(44);
            list3.Add(55);

            list3.Remove(33);

            foreach(var item in list3)
            {
                Console.WriteLine("Count: " + list3.Count + "\titem: " + item);
                /* 
                Count: 3     item: 22
                Count: 3     item: 44
                Count: 3     item: 55
               */
            }

        }

    }
}
