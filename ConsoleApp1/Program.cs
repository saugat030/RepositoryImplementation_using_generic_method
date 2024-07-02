using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRepo<Model> mod = new RepoImp<Model>(); //without calling the parametrized constructor. yo () khali xa so default ctor call hunxa empty wala

            List<Model> noctrmodel = new List<Model> //create a list with the type Model.
            {
            new Model{id =5 , Name = "madu" },
            new Model{id =12 , Name = "chige" }
            };
            mod.add(noctrmodel);
           List<Model> testOp = mod.GetAll().ToList(); 
            foreach (var op in testOp)
            {
                Console.WriteLine($"List is :{op.id} , {op.Name}");
            } 

            //Using constructor.

            List<Model> listmodel = new List<Model> //create a normal list of type model.
            {
            new Model{id =4 , Name = "nige" },
            new Model{id =12 , Name = "gian" }
            };
            

            IRepo<Model> cmods = new RepoImp<Model>(listmodel); // create a new obj cmods of RepoImp with the class being Model i.e T = Model.
            //pass the listmodel List to the constructor of RepoImp
            //Parent = new child. 

            cmods.add(listmodel); // now add a new list to the listmodel but the new list is itself. SO basically create a duplicate data inside it.

           
            //Just to print the output
            List<Model> getlist = cmods.GetAll().ToList();
            foreach (var op in getlist)
           {
               Console.WriteLine($"List is :{op.id} , {op.Name}");
           }

            //testing the remove method.
            Model modelToRemove = new Model { id = 4, Name = "nige" };
            cmods.remove(modelToRemove);

            Console.ReadLine();

        }
    }
}
