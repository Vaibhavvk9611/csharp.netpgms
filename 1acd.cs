using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 1acd
{
    {
        public virtual void Method1() { }
        public virtual void Method2() { }

        public void Method3()
        {

        }
        
    }

   abstract  class cls : Univ
    {

        abstract public  void Method4();
        public override  void Method1()
        {
            
        }

        public override  void Method2()
        {
            
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Univ u = new Univ();
            cls my = new cls();
        }
    }
     class One
    {
       public void OneMethod()
        {

        }

        void AnimalSound()
        {

        }
    }

    class Two
    {
        public void OneMethod()
        {
        }
    }
    interface IAnimal
    {               
          void AnimalSound();          
    }

    interface IAnimalProperties
    {
        void AnimalMovement();
    }

    class Dog : One,IAnimal   
    {
        public void AnimalSound()
        {
         
        }

       public  void AnimalMovement()
        {

        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }
}
