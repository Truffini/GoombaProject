using System;
using System.Threading;

namespace GoombaProject
{
    class GoombaWalk
    {
        private Star star;
        private GoombaAdv goombaAdv;
        private Ground ground;
        private Goomba goomba;
        public GoombaWalk(Star star, GoombaAdv goombaAdv, Ground ground, Goomba goomba)
        {
            this.star =star;
            this.goombaAdv = goombaAdv;
            this.ground = ground;
            this.goomba = goomba;
        }
        public void StartAnimation()
        {
              for(int i=0; i < 20; i++)
            {
                Console.Clear();                
                DrawFrame();
                goombaAdv.UpdatePos();
                Thread.Sleep(200);    
            }
            goombaAdv.ChangeDir();
            goombaAdv.UpdatePos();
            for(int i=0; i < 20; i++)
            {
                Console.Clear();
                DrawFrame();
                goombaAdv.UpdatePos();
                Thread.Sleep(200);
            }
            Console.Clear();
            DrawEndFrame();
        }
        public void DrawFrame()
        {
            star.DrawSprite();
            goombaAdv.DrawSprite();
            ground.DrawSprite();
        }
        public void DrawEndFrame()
        {
            star.DrawSprite();
            goomba.DrawSprite();
            ground.DrawSprite();
        }

        
    }
}