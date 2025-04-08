using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.NetworkInformation;

namespace finalproj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //still a draft !!
            Console.WriteLine("Welcome to SHOr na SHOr!");
            Console.WriteLine("Please enter any input to proceed to the main menu.");
            string entryinput = Console.ReadLine();
            Console.Clear();

            int mainloop = 1;

            while (mainloop == 1)
            {
                Console.WriteLine("A. | Student Council Profiles");
                Console.WriteLine("B. | Councils and Departments");
                Console.WriteLine("C. | Resource Forms");
                Console.WriteLine("D. | Trivia Quiz");
                Console.WriteLine("E. | Exit");
                Console.Write("Please input the letter of the feature you would like to view: ");
                string maininput = Console.ReadLine().ToUpper();
                Console.Clear();

                if (maininput == "A")
                {
                    int scloop = 1;

                    while (scloop == 1)
                    {
                        Console.WriteLine("A. | Department 1");
                        Console.WriteLine("B. | Department 2"); //fill in names for these later
                        Console.WriteLine("C. | Return to main menu");
                        Console.Write("Please input the letter of the department you would like to view: ");
                        string scinput = Console.ReadLine().ToUpper();
                        Console.Clear();

                        if (scinput == "A")
                        {
                            int deploop = 1;

                            while (deploop == 1)
                            {
                                Console.WriteLine("A. | Officer 1");
                                Console.WriteLine("B. | Officer 2"); //fill in names for these later
                                Console.WriteLine("C. | Return to student council menu");
                                Console.Write("Please input the letter of the officer you would like to view: ");
                                string depinput = Console.ReadLine().ToUpper();
                                Console.Clear();

                                if (depinput == "A")
                                {
                                    Console.WriteLine("*insert info about officer here*");
                                    Console.Write("Please enter any input to go back to the officer menu.");
                                    string exitinput = Console.ReadLine();
                                    Console.Clear();
                                }

                                else if (depinput == "B")
                                {
                                    Console.WriteLine("*insert info about officer here*");
                                    Console.Write("Please enter any input to go back to the officer menu.");
                                    string exitinput = Console.ReadLine();
                                    Console.Clear();
                                }
                                else if (depinput == "C")
                                {
                                    deploop = 0;
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input!");
                                    Console.Write("Please enter any input to go back to the officer menu.");
                                    string exitinput = Console.ReadLine();
                                    Console.Clear();
                                }
                            }
                        }

                        else if (scinput == "B")
                        {
                            int deploop = 1;

                            while (deploop == 1)
                            {
                                Console.WriteLine("A. | Officer 1");
                                Console.WriteLine("B. | Officer 2"); //fill in names for these later
                                Console.WriteLine("C. | Return to student council menu");
                                Console.Write("Please input the letter of the officer you would like to view: ");
                                string depinput = Console.ReadLine().ToUpper();
                                Console.Clear();

                                if (depinput == "A")
                                {
                                    Console.WriteLine("*insert info about officer here*");
                                    Console.Write("Please enter any input to go back to the officer menu.");
                                    string exitinput = Console.ReadLine();
                                    Console.Clear();
                                }

                                else if (depinput == "B")
                                {
                                    Console.WriteLine("*insert info about officer here*");
                                    Console.Write("Please enter any input to go back to the officer menu.");
                                    string exitinput = Console.ReadLine();
                                    Console.Clear();
                                }
                                else if (depinput == "C")
                                {
                                    deploop = 0;
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input!");
                                    Console.Write("Please enter any input to go back to the officer menu.");
                                    string exitinput = Console.ReadLine();
                                    Console.Clear();
                                }
                            }
                        }

                        else if (scinput == "C")
                        {
                            scloop = 0;
                            Console.Clear();
                        }

                        else
                        {
                            Console.WriteLine("Invalid input!");
                            Console.Write("Please enter any input to go back to the officer menu.");
                            string exitinput = Console.ReadLine();
                            Console.Clear();
                        }

                    }

                }
            }
        }
    }
}
