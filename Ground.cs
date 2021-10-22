using System;

namespace GoombaProject
{
    class Ground
    {
        private int length;
        private string[] groundSprite;
        public Ground(int length)
        {
            this.length = length;
            groundSprite = new string[2];
            SetSprite();
        }
        private void SetSprite()
        {
            string grassOneLayer = "";
            for( int i = 0; i < length; i++)
                grassOneLayer += @"/";
            groundSprite[0] = grassOneLayer;
            groundSprite[1] = grassOneLayer;
        }
        public void DrawSprite()
        {
            foreach(string eachLine in groundSprite)
                Console.WriteLine(eachLine);
        }
    }
}