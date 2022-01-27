using System;
using Project2.src.entities;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Knigth Arus = new Knigth("Arus", 25, "knight", 200, 50); 
            BlackWizard bw = new BlackWizard("Yennifer", 99, "Black Wizard", 150, 300);
            WhiteWizard ww = new WhiteWizard("Gôndola", 46, "White Wizard", 130, 250);
            Ninja ninja = new Ninja("Naruto", 58, "Ninja", 180, 150);


            Console.WriteLine(Arus.Attack(7, ww));
            Console.WriteLine(ww.HP);

            // Console.WriteLine(ww.Attack(8));
            // Console.WriteLine(bw.Attack(5));
            // Console.WriteLine(ninja.Attack(4));




        }
    }
}
