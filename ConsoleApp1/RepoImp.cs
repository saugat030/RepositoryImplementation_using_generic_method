using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class RepoImp<T> : IRepo<T> where T : class
    {
        private List<T> categ; //euta private feild banako categ vanne eslai value halixa  from the Program.cs file.
        public RepoImp() 
        {
            categ = new List<T>(); //  Yo chai bina parametrized ctor. aka bina constructor. categ= naya list banxa. 
        }                           //tala chai categ=citem banxa.
        public RepoImp(List<T> citem)
        {
            categ = citem ?? new List<T>();  //yo chai paramertic ctor lai( ??new List<T> vanya chai null xa vane chai naya list declare hande vanya ho.)
        }
        public void add(List<T> item) //We call the add method from the Program.cs then this gets executed.
        {
            List<T> itemsToAdd = new List<T>(item); //This is an important step. Dhyan dera bujh.
            // Hamile main program ma listmodel vanne list lai ctor ma pass hanera .add ma ni same listmodel lai pass haneko xa. 
            //Tyo garda k hunxa vanda add method ma aaune item variable ra categ variable le same list lai refrence hanxa.
            // So say you have 2 items in the list categ rn. Then you add the same list refrencing the same list. Add garda kheri foreach loop thes khanxa aba. There were previously 2 items in that list so 2 choti chalnu parne loop aba 3 vayo mc.
            // Ani error thow handinxa.  
            //Hope my future self undertands this :(

            if (item == null)
              throw new ArgumentNullException(nameof(item)); // null vaye error hande

            foreach (var items in itemsToAdd) //add(); ma pass vako list lai ek ek iterate handai .Add use garne. Since we cant do a list+list to merge the list
            {
                categ.Add(items); 
            }
        }

        public IEnumerable<T> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return categ;
        }

        public void remove(T item)
        {
            categ.Remove(item);
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
