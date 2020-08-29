using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrot
    {
        /// <summary>
        /// This class generates Mandelbrot sets in the console window!
        /// </summary>


        class Class1
        {
            /// <summary>
            /// This is the Main() method for Class1 -
            /// this is where we call the Mandelbrot generator!
            /// </summary>
            /// <param name="args">
            /// The args parameter is used to read in
            /// arguments passed from the console window
            /// </param>

            [STAThread]
            static void Main(string[] args)
            {   //Setting double values for the beginning and end point 
                double realCoord, imagCoord, userImagCoordStart, userImagCoordEnd = 0, userRealCoordStart, userRealCoordEnd = 0;
                bool isImagCoordValid = false, isRealCoordValid = false;

                Console.WriteLine("Please provide a value for Image start and Real start: ");
                //Sets the start value and takes the string and converts it into a double
                Console.WriteLine("Image Start value: ");
                string imagInputStart = Console.ReadLine();
                userImagCoordStart = Convert.ToDouble(imagInputStart);
                //Sets the start value and takes the string and converts it into a double
                Console.WriteLine("Real Start value: ");
                string realInputStart = Console.ReadLine();
                userRealCoordStart = Convert.ToDouble(realInputStart);

                Console.WriteLine("Please provide a value for Image end and Real end: ");

                while (isImagCoordValid != true)
                {
                    //asks the user to imput a value that will be used in the math equation
                    Console.WriteLine("Image End value less than Image Start value: ");
                    string imageInputEnd = Console.ReadLine();
                    userImagCoordEnd = Convert.ToDouble(imageInputEnd);
                    
                    if (userImagCoordEnd > userImagCoordStart)
                    {
                        // this if statement is to correct if any number
                        Console.WriteLine("Please input an Image End value less than the Image Start value: ");
                    } else
                    {
                        isImagCoordValid = true;
                    }
                }

                while (isRealCoordValid != true)
                {
                //asks the user to imput a value that will be used in the math equation
                    Console.WriteLine("Real End value greater than Real Start value: ");
                    string realInputEnd = Console.ReadLine();
                    userRealCoordEnd = Convert.ToDouble(realInputEnd);
                // this if statement is to correct if any number
                    if (userRealCoordEnd < userRealCoordStart)
                    {
                        Console.WriteLine("Please input an Real End value greater than the Real Start value: ");
                    }
                    else
                    {
                        isRealCoordValid = true;
                    }
                }


                double realTemp, imagTemp, realTemp2, arg;
                int iterations;
                //math fomula for the image coordinates
                for (imagCoord = userImagCoordStart; imagCoord >= userImagCoordEnd; imagCoord -= ((Math.Abs(userImagCoordStart) + Math.Abs(userImagCoordEnd))/48))
                {
                    //math formula for the real coordinates
                    for (realCoord = userRealCoordStart; realCoord <= userRealCoordEnd; realCoord += ((Math.Abs(userImagCoordStart) + Math.Abs(userImagCoordEnd))/80))
                    {
                        iterations = 0;
                        realTemp = realCoord;
                        imagTemp = imagCoord;
                        arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                        while ((arg < 4) && (iterations < 40))
                        {
                            realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                               - realCoord;
                            imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                            realTemp = realTemp2;
                            arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                            iterations += 1;
                        }
                        switch (iterations % 4)
                        {
                            case 0:
                                Console.Write(".");
                                break;
                            case 1:
                                Console.Write("o");
                                break;
                            case 2:
                                Console.Write("O");
                                break;
                            case 3:
                                Console.Write("@");
                                break;
                        }
                    }
                    Console.Write("\n");
                }

            }
        }
    }

