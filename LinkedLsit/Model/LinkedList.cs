using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace LinkedLsit.Model
{
    /// <summary>
    /// Linked list
    /// </summary>
    public class LinkedList<T> : IEnumerable
    {
        /// <summary>
        /// First element of the list
        /// </summary>
        public Item<T> Head { get; private set; }
        /// <summary>
        /// Last element of the list
        /// </summary>
        public Item<T> Tail { get; private set; }
        /// <summary>
        /// Amount of elements in the list
        /// </summary>

        public int Count { get; private set; }

        /// <summary>
        /// Create empty list
        /// </summary>
        public LinkedList()
        {
           Clear();
        }

        /// <summary>
        /// Create list with first element
        /// </summary>
        /// <param name="data"></param>
        public LinkedList(T data)
        {
            
            SetHeadAndTail(data);
        }

        /// <summary>
        /// Add data to the end of the list
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            if(Tail != null)
            {
                var item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        /// <summary>
        /// Delete first entry in the list
        /// </summary>
        /// <param name="data"></param>
        public void Delete(T data)
        {
            if(Head != null)
            {
                if(Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }
                var current = Head.Next;
                var previous = Head;

                while(current != null)
                {
                    if(current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }

                    previous = current;
                    current = current.Next;
                }
            }
            else
            {
                SetHeadAndTail(data);
            }
        }
        /// <summary>
        /// Add data to the list
        /// </summary>
        /// <param name="data"></param>
        public void AppendHead(T data)
        {
            var item = new Item<T>(data);
            item.Next = Head;
            Head = item;
            Count++;
        }

        public void InsertAfter(T target, T data)
        {
            if (Head != null)
            {
                var item = new Item<T>(data);
                var current = Head;
                while(current != null)
                if (current.Equals(target))
                {
                    item.Next = Head.Next;
                    Head.Next = item;
                    Count++;
                    return;
                }
                else
                {
                    current = current.Next;
                }
            }
            else
            {
                SetHeadAndTail(target);
                Add(data);
            }
        }

        /// <summary>
        /// Clear the list
        /// </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        private void SetHeadAndTail(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        /// <summary>
        /// Get amount of elements in the list
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while(current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public override string ToString()
        {
            return "Linked List" + Count + " element's";
        }
    }
}
