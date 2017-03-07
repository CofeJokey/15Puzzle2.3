using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int i;
            int[] p = new int[100];

            for (i = 0; i < 16; i++)
            {
                p[i] = i + 1;
            }

            p[15] = 0;
            Game2 game2 = new Game2(p, i);
            game2.RandomValues(p);
            Game3 game1 = new Game3(p,i);
         //   Game game1 = new Game(p, i);
            game1.RandomValues(p);
          //  while (true)
        //    {
          //      Console.WriteLine("Выберите действие:" + Environment.NewLine + "1 - играть" + Environment.NewLine + "6 - выход");


            //    try
         //       {
                   //int key = Convert.ToInt16(Console.ReadLine());
                   //if (key <= 0 || key > 6) { throw new Exception(); }

             //       switch (key)
              //      {
               //         case 1:

                            for (; ; )
                            {
                           
                                game1.Print();
                                
                                Console.WriteLine("Двигайте цифру ");

                                int a = Convert.ToInt32(Console.ReadLine());

                                game1.Shift(a, game1);
                          //      while (true)
                      //   {
                                game1.Print();
                        //        Console.WriteLine("1 - Отменить шаг, 2 - продолжить игру, 3 - выход, 4 - шаг назад");
                                Console.WriteLine("1 - Отменить шаг, 2 - продолжить игру, 3 - выход");
                                try
                                {
                                    int key = Convert.ToInt16(Console.ReadLine());
                                    if (key <= 0 || key > 6) { throw new Exception(); }
                                    switch (key)
                                    {

                                        case 1:
                                            game1.Undo(a);
                                            game1.Print();
                                            Console.WriteLine("1 - Вернуть откат, 2 - Продолжить игру ");
                                            try
                                            {
                                                int keys = Convert.ToInt16(Console.ReadLine());
                                                if (keys <= 0 || keys > 2) { throw new Exception(); }
                                                switch (keys)
                                                {
                                                    case 1:
                                                        game1.Redo(a);
                                                     
                                                        break; 
                                                  
                                                    case 2:

                                                        break;

                                                    default: 

                                            break;
                                                   
                                                }
                                            }
                                                catch
                                {
                                    Console.WriteLine("Недопустимый символ, попробуйте еще раз");
                                }
                                            break;
                                        case 2: 
                                           
                                            

                                            break;

                                        case 3:
                                            Environment.Exit(0);
                                            
                                           break;

                                  //     case 4:
                                //           game1.Redo(a);
                                  //         break;
                                        default: 

                                            break;

                                    }
                                }

                                catch
                                {
                                    Console.WriteLine("Недопустимый символ, попробуйте еще раз");
                                }

                                if (game1.EndGame())
                                {
                                    game1.Print();
                                    Console.WriteLine("Вы прошли игру");

                                    break;
                                }
                                
}
                                
                            }
                       //   break;
                    //    case 6:
                   //         Environment.Exit(0);
                   //         break;
                   //     default:
                   //         break;
                //    }
              //  }
                

            }
        
    }