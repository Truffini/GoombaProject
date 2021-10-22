using System;

namespace GoombaProject 
{
    class GoombaAdv : Goomba
    {
        public int FootChange;
        private string[] goombaSpriteLeftFoot;
        private string[] goombaSpriteRightFoot;
        public GoombaAdv(int speed) : base(speed)
        {
            goombaSpriteLeftFoot = new string[10];
            goombaSpriteRightFoot = new string[10];
            SetSprite();    
        }         
        public void DrawSprite()
        {          
            string spaces = "";
            for(int i = 0; i < posX; i++)
                spaces += " ";
                FootChange += 1;
            if(FootChange%2 == 0)
                foreach(string eachLine in goombaSpriteRightFoot)
                    Console.WriteLine(spaces + eachLine);
            else
                foreach(string eachLine in goombaSpriteLeftFoot)
                    Console.WriteLine(spaces + eachLine);
        }
        private void SetSprite()
        {           
            goombaSpriteLeftFoot[0] = @"     ________  ";
            goombaSpriteLeftFoot[1] = @"    /        \ ";
            goombaSpriteLeftFoot[2] = @"   /  \    /  \ ";
            goombaSpriteLeftFoot[3] = @"  /   |    |   \ ";
            goombaSpriteLeftFoot[4] = @" /  -^------^-  \ ";
            goombaSpriteLeftFoot[5] = @"|________________| ";
            goombaSpriteLeftFoot[6] = @" ____ /    \ ";
            goombaSpriteLeftFoot[7] = @"/____\      |____ ";
            goombaSpriteLeftFoot[8] = @"       ==== /____\ ";
            goombaSpriteLeftFoot[9] = @"                     ";

            goombaSpriteRightFoot[0] = @"     ________  ";
            goombaSpriteRightFoot[1] = @"    /        \ ";
            goombaSpriteRightFoot[2] = @"   /  \    /  \ ";
            goombaSpriteRightFoot[3] = @"  /   |    |   \ "; 
            goombaSpriteRightFoot[4] = @" /  -^------^-  \ ";
            goombaSpriteRightFoot[5] = @"|________________| ";
            goombaSpriteRightFoot[6] = @"      /    \ ____ ";
            goombaSpriteRightFoot[7] = @" ____|      /____\ ";
            goombaSpriteRightFoot[8] = @"/____\ ====         ";
            goombaSpriteRightFoot[9] = @"                     ";         
        }       
    }
}