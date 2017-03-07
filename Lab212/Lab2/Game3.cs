using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Game3 : Game2
    {
       static int LenghtHistory;
        Dictionary<int, Point> Goes = new Dictionary<int, Point>();
        public Game3(int[] Mas,int qe) :base(Mas, qe)
        {

       // int currentStep = 0;

        }

        public void History(int newvalue) 
    {
    LenghtHistory++;
    Goes[LenghtHistory] = GetLoc(newvalue); 
    }

    public void Undo(int newvalue)
    {
         int i = LenghtHistory;
    
         this.Shift(this.ItemsNew[Goes[i].x, Goes[i].y], this);

            i--;
     
    }

    public void Redo(int newvalue)
    {
          int i = LenghtHistory;
       
          this.Shift(this.ItemsNew[Goes[i].x, Goes[i].y], this);
            i++;
     
    }

    }

}
