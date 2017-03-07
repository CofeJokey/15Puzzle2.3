using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Game2 : Game
    {


       

        public Game2(int[] Mas,int qe) :base(Mas, qe) 
        {
            
        }

        public Boolean EndGame()
        {
            bool fl = false;
            int value = 1;
            for (int i = 0; i < LenghtField; ++i)
            {
                for (int j = 0; j < WidthField; ++j)
                {
                    if (ItemsNew[i, j] == value)
                    {

                        fl = true;
                        value++;
                        if (value == Lenght)
                        {
                            value = 0;
                        }
                    }
                    else
                    {
                        return false;
                    }

                }


            }
            return fl;
        }


        public void RandomValues(int[] Mas)
        {
            int tmp = 0;
            Random rnd = new Random();

            for (int i = 0; i < 16; i++)
            {
                bool isExist = false;
                do
                {
                    isExist = false;
                    tmp = rnd.Next(0, 16);
                    for (int j = 0; j < i; j++)
                    {
                        if (tmp == Mas[j]) { isExist = true; }
                    }
                }
                while (isExist);
                Mas[i] = tmp;
            }
        }




    }
}