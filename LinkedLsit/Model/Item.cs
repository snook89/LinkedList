using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLsit.Model
{
    /// <summary>
    /// List cell
    /// </summary>
    public class Item<T>
    {
        private T data = default(T);
        /// <summary>
        /// Data in the list cells
        /// </summary>
        public T Data
        {
            get => data;
            set { if (value != null)
                    data = value;
                else
                    throw new ArgumentNullException(nameof(value)); }

        }

        /// <summary>
        /// Next list cell
        /// </summary>
        public Item<T> Next { get; set; }

        public Item(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
