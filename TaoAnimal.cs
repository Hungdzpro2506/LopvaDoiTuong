using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TaoAnimal
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("3.5kg","1.5","Bitch");
            cat.PrintInfo();
        }

    }
    public abstract class Animal
    {
        protected string Chieucao { get; set; }
        protected string Cannang { get; set; }
        public Animal(string cannang, string chieucao)
        {
            this.Chieucao = chieucao;
           this.Cannang = cannang;
        }
        public abstract void PrintInfo();
    }
    public class Cat : Animal
    {
        private String Name {get; set; }
        public Cat(string cannang, string chieucao, string name  )
            :base(cannang, chieucao)
        {
            this.Name = name;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Can nang: {Cannang}, Chieu cao: {Chieucao}, Ten: {Name}  ");
        }
        
    }

}
