using System;
using System.Collections;

namespace Classes
{
    public class Stack
    {
        private readonly ArrayList list;
        public Stack()
        {
            list = new ArrayList();
        }
        public void Push(object newObj)
        {
            try
            {
                if (newObj != null)
                {
                    list.Add(newObj);
                    System.Console.WriteLine("Object has been added successfully!...");
                }
                else
                {
                    throw new InvalidOperationException("newObj");
                }
            }
            catch (System.Exception)
            {

                Console.WriteLine("Please enter object other than null.");
            }
            
        }

        public object Pop()
        {
            try
            {
                if (list.Count != 0)
                {
                    var obj = list[list.Count-1];
                    list.RemoveAt(list.Count-1);
                    Console.WriteLine("Object on the top of stack has been removed successfully!...");
                    return obj;
                }
                else
                {
                    throw new InvalidOperationException();
                }
                
            }
            catch (Exception)
            {

                Console.WriteLine("List is currently empty please add a element to pop.");
            }
            return "";
        }

        public void Clear()
        {
            list.Clear();
            Console.WriteLine("List has been cleared successfully!...");
        }


    }
}
