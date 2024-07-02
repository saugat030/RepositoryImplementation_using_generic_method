using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IRepo<T> //Yo simply interface declare hanya. should not be hard to understand.
    {
        IEnumerable<T> Get(int id);  
        IEnumerable<T> GetAll();
        void add(List<T> item);
        void Update (T item);   
        void remove(T item);
    }
}
