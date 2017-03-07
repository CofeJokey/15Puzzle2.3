using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lab2
{
    class Game
    {
    
       public const int LenghtField = 4, WidthField = 4;
       public int[,] ItemsNew = new int[LenghtField, WidthField];
       public Point[] ItemsValue = new Point[100];
       public int[] Mas = new int[100];
       public static int[] ListMass = new int[100];
       public  int Lenght = 0;

        public Game(int[] Mas,int qe) {
            Lenght = qe;
            int ae = 0;
            this.Mas = Mas;
          
            for (int i = 0; i <LenghtField; i++)
            {
                for(int j=0; j<WidthField; j++)
                {
                    ItemsNew[i, j] = Mas[ae];
                    ItemsValue[Mas[ae]] = new Point(i, j);
                    ae++;
                }
            }
        }
        public Point GetLoc(int value)
        {
            return ItemsValue[value];
        }
      
        public void Print()
        {
            for (int i = 0; i < LenghtField; i++)
            {
                for (int j = 0; j < WidthField; j++)
                {
                    Console.Write("{0,5}",ItemsNew[i,j]);

                }
                Console.WriteLine();
            }

        }
        
    public void Shift(int value, Game3 games) 
    { 

    try 
    { 
  //  Console.WriteLine(value);
    if (value < 0 || value > 15) { throw new ArgumentException(); }
    

    int zeroLoctionX = GetLoc(0).x;
    int zeroLoctionY = GetLoc(0).y;

    int ValueX = GetLoc(value).x;
    int ValueY = GetLoc(value).y;

    if ((ValueX == zeroLoctionX && (ValueY == zeroLoctionY - 1 || ValueY == zeroLoctionY + 1))
        || (ValueY == zeroLoctionY && (ValueX == zeroLoctionX - 1 || ValueX == zeroLoctionX + 1))) 
    {

        ItemsNew[zeroLoctionX, zeroLoctionY] = value;
    ItemsNew[ValueX, ValueY] = 0; 

    var vere = ItemsValue[0];
    ItemsValue[0] = ItemsValue[value];
    ItemsValue[value] = vere;
    games.History(value);
    } 

     else 
        { 
        throw new Exception(); 
        } 
    } 

    catch (ArgumentException) 
    {
        Console.WriteLine("Нет такого числа. ");
        Console.WriteLine(); 
    } 
    catch (Exception) 
    {
        Console.WriteLine("Некуда двигать. ");
        Console.WriteLine();
    } 

    }
    
    }
}
