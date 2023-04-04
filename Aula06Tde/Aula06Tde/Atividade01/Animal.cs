using System;

namespace Aula06Tde
{
    public abstract class Animal
    {
      public string  Nome{get; set;}
      
//abstract nao extancia a classe animal
      public abstract void falar();
      }
      public class Cachorro : Animal{

//override quando eu uso herança (reescrever o metodo)
        public override void falar(){
            Console.WriteLine("Cachorro " + Nome + " faz au au!");
        }
      }

      public class Gato : Animal{

        public override void falar(){
            Console.WriteLine("Gato " + Nome + " faz miau miau!");
        }
      }
}