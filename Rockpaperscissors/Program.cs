﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;

            int randomInt;
            bool playAgain = true;
             
              while (playAgain)
              {
                  
              int scorePlayer = 0;
              int scoreCPU = 0;

            while (scorePlayer < 3 && scoreCPU < 3)
            {
            

            Console.Write("Chose between ROCK,PAPER,SCISSORS:");
            inputPlayer = Console.ReadLine();

            Random rnd = new Random();

            randomInt = rnd.Next(1,4);

            switch (randomInt)
            {
                case 1:
                inputCPU = "ROCK";
                Console.WriteLine("Computer chose Rock");
                if (inputPlayer == "ROCK")
                {
                    Console.WriteLine("DRAW!!\n\n");
                }

                else if (inputPlayer == "PAPER")
                {
                    Console.WriteLine("PLAYER WINS!!\n\n");
                    scorePlayer++;
                }
                else if(inputPlayer == "SCISSORS")
                {
                     Console.WriteLine("CPU WINS!!\n\n");
                     scoreCPU++;
                }
                    
                break;

                 case 2:
                 inputCPU = "PAPER";
                 Console.WriteLine("Computer chose paper");
                 if (inputPlayer == "PAPER")
                 {
                      Console.WriteLine("DRAW!!\n\n");
                 }

                 else if (inputPlayer == "ROCK")
                 {
                      Console.WriteLine("CPU WINS!!\n\n");
                      scoreCPU++;
                      
                 }
                 
                 else if(inputPlayer == "SCISSORS")
                 {
                      Console.WriteLine("PLAYER WINS!!\n\n");
                      scorePlayer++;
                 }
                break;


                 case 3:
                 inputCPU = "SCISSORS";
                 Console.WriteLine("Computer chose scissors");
                 if (inputPlayer == "SCISSORS")
                 {
                     Console.WriteLine("DRAW!!\n\n");
                 }
                 else if (inputPlayer== "ROCK")
                 {
                     Console.WriteLine("PLAYER WINS!!\n\n");
                     scorePlayer++;
                 }
                 else if (inputPlayer == "PAPER")
                 {
                     Console.WriteLine("CPU WINS!!\n\n");
                     scoreCPU++;
                 }

                break;
                
                default:
                Console.WriteLine("Invalid Entry");
                break;
            }

            Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}", scorePlayer,scoreCPU);

          

          if (scorePlayer == 3)
          {
              Console.WriteLine("PLAYER WON!!");
          }
          else if (scoreCPU == 3)
          {
              Console.WriteLine("CPU WON!!");
          }
          else
          { 

          }
            }

          Console.WriteLine("Do you want to play again?(Y/N)");
          string loop = Console.ReadLine();
          if (loop =="Y")
          {
            playAgain = true;
            Console.Clear();
          }
          else if (loop == "N")
          {
              playAgain = false;
          }
          else
          {

          }
        
     }     
    }
  }
}
