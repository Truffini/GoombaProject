using System;

namespace GoombaProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Star star = new Star(4);
            GoombaAdv goombaAdv = new GoombaAdv(4);
            Ground ground = new Ground(120);
            Goomba goomba = new Goomba(4);
            GoombaWalk gWalk = new GoombaWalk(star, goombaAdv, ground, goomba);
            Console.Clear();
            gWalk.StartAnimation();
        }
    }
}
