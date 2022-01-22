using System;

namespace FormatExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable controlling the loop
            int myContinue = 0;

            do{
            
                try
            {
                Method1();
            }
            catch (FormatException)
            {
                Console.WriteLine("Don't enter words.");
                Console.ReadKey();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Zero gallons used? \nPlease enter using values between (1-100000):");
                Console.ReadKey();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Too high of a number \nPlease enter using values between (1-100000):");
                Console.ReadKey();
            }

             // Wanted to use finally somewhere in my code
                finally{
             Console.WriteLine("Would you like to continue? (Enter y or the program will close): ");
                    string choice = Console.ReadLine();
                    if (choice == "y")
                    {
                        myContinue = 1;
                    }
                    
                }
            } while(myContinue == 1);
        } // End of main


            static void Method1(){
            //initializeing the variables for the while loop
                double milesD;
                double milesG;

                do
                {
                    Console.WriteLine("Please enter positive values between (1-100000):");

                    Console.WriteLine("Enter the miles driven:");
                    string milesDriven = Console.ReadLine();
                    milesD = Convert.ToDouble(milesDriven);


                    Console.WriteLine("Enter the gallons used:");
                    string milesGallon = Console.ReadLine();
                    milesG = Convert.ToDouble(milesGallon);

                    //Divide by zero never gets caught so I throw it myself
                    if (milesG == 0)
                        throw new DivideByZeroException();
                        
                } while (milesD <= 0 || milesG <= 0);

                Console.WriteLine("The miles per gallon is: " + milesD / milesG);
                Console.ReadKey();
            }
            
            }
    }

