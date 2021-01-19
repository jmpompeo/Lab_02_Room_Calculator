using System;

namespace Lab_02_Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string length;
            double lengthNumber;

            string width;
            double widthNumber;

            string height;
            double heightNumber;

            double area;
           
            double perimeter;
           
            double surfaceArea;

            double volume; 

            
            string userRespone;


            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

            do  
            {

                {
                    Console.Write("Length: ");
                    length = Console.ReadLine();
                    lengthNumber = double.Parse(length);


                    Console.Write("Enter Width: ");
                    width = Console.ReadLine();
                    widthNumber = double.Parse(width);

                    Console.Write("Enter Height: ");
                    height = Console.ReadLine();
                    heightNumber = double.Parse(height);

                    Console.Write("Area: ");
                    area = lengthNumber * widthNumber;
                    Console.WriteLine(area);

                    Console.Write("Perimeter: ");
                    perimeter = 2 * (lengthNumber + widthNumber);
                    Console.WriteLine(perimeter);

                    Console.Write("Surface Area: ");
                    surfaceArea = lengthNumber * widthNumber;
                    Console.WriteLine(surfaceArea);

                    Console.Write("Volume: ");
                    volume = lengthNumber * widthNumber * heightNumber;
                    Console.WriteLine(volume);
                }      

                    

                    Console.WriteLine("Continue? (y)/(n): ");
                    userRespone = Console.ReadLine();


            }
            while (userRespone == "y");
            
            if (userRespone == "n")
            {
                Console.WriteLine("Have a nice day.");
            }
            else
            {
                Console.WriteLine("You have entered a wrong input.");
            }




           

        }

            







        }
    }

