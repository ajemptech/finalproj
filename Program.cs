using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.NetworkInformation;
using System.Diagnostics;

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

                if (maininput == "B")
                {
                    int cdloop = 1;

                    while (cdloop == 1)
                    {
                        Console.WriteLine("A. | Council 1");
                        Console.WriteLine("B. | Council 2"); //fill in names for these later
                        Console.WriteLine("C. | Return to main menu");
                        Console.Write("Please input the letter of the council you would like to view: ");
                        string cdinput = Console.ReadLine().ToUpper();
                        Console.Clear();

                        if (cdinput == "A")
                        {
                            int councloop = 1;

                            while (councloop == 1)
                            {
                                Console.WriteLine("*information about council/department*");
                                Console.WriteLine("A. | Organization/Committee 1"); //fill in names for these later
                                Console.WriteLine("B. | Return to student council menu");
                                Console.Write("Please input the letter of the officer you would like to view: ");
                                string councinput = Console.ReadLine().ToUpper();
                                Console.Clear();

                                if (councinput == "A")
                                {
                                    Console.WriteLine("*insert info about organization/committee here*");
                                    Console.Write("Please enter any input to go back to the organization/committee menu.");
                                    string exitinput = Console.ReadLine();
                                    Console.Clear();
                                }
                                else if (councinput == "B")
                                {
                                    councloop = 0;
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

                        else if (cdinput == "B")
                        {
                            int councloop = 1;

                            while (councloop == 1)
                            {
                                Console.WriteLine("*information about council/department*");
                                Console.WriteLine("A. | Organization/Committee 1"); //fill in names for these later
                                Console.WriteLine("B. | Return to student council menu");
                                Console.Write("Please input the letter of the officer you would like to view: ");
                                string depinput = Console.ReadLine().ToUpper();
                                Console.Clear();

                                if (depinput == "A")
                                {
                                    Console.WriteLine("*insert info about organization/committee here*");
                                    Console.Write("Please enter any input to go back to the organization/committee menu.");
                                    string exitinput = Console.ReadLine();
                                    Console.Clear();
                                }
                                else if (depinput == "B")
                                {
                                    councloop = 0;
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

                        else if (cdinput == "C")
                        {
                            cdloop = 0;
                            Console.Clear();
                        }

                        else
                        {
                            Console.WriteLine("Invalid input!");
                            Console.Write("Please enter any input to go back to the council menu.");
                            string exitinput = Console.ReadLine();
                            Console.Clear();
                        }
                    }
                }

                else if (maininput == "C")
                {
                    int resloop1 = 1;

                    while (resloop1 == 1)
                    {
                        Console.WriteLine("A. | Resource form 1");
                        Console.WriteLine("B. | Resource form 2");
                        Console.WriteLine("C. | Return to main menu");
                        Console.Write("Please input the letter of the resource form you would like to view: ");
                        string resinput1 = Console.ReadLine().ToUpper();
                        Console.Clear();

                        if (resinput1 == "A")
                        {
                            int resloop2 = 1;
                            
                            while (resloop2 == 1)
                            {
                                Console.WriteLine("*information about resource form*");
                                Console.WriteLine("Would you like to open the form? (Y/N)");
                                string resinput2 = Console.ReadLine().ToUpper();
                                Console.Clear();

                                if (resinput2 == "Y")
                                {
                                    Console.WriteLine("Opening form...");
                                    Thread.Sleep(3000);
                                    var openlink = new ProcessStartInfo("chrome.exe");
                                    openlink.Arguments = "https://www.youtube.com/watch?v=PYnWKSXXyIk"; //not final link, just a placeholder
                                    Process.Start(openlink);
                                    resloop2 = 0;
                                    Console.Clear();
                                }
                                else if (resinput2 == "N")
                                {
                                    resloop2 = 0;
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input!");
                                    Console.Write("Please enter any input to go back to try again.");
                                    string exitinput = Console.ReadLine();
                                    Console.Clear();
                                }
                            }
                        }

                        if (resinput1 == "B")
                        {
                            int resloop2 = 1;

                            while (resloop2 == 1)
                            {
                                Console.WriteLine("*information about resource form*");
                                Console.WriteLine("Would you like to open the form? (Y/N)");
                                string resinput2 = Console.ReadLine().ToUpper();
                                Console.Clear();

                                if (resinput2 == "Y")
                                {
                                    Console.WriteLine("Opening form...");
                                    Thread.Sleep(3000);
                                    var openlink = new ProcessStartInfo("chrome.exe");
                                    openlink.Arguments = "https://www.youtube.com/watch?v=PYnWKSXXyIk"; //not final link, just a placeholder
                                    Process.Start(openlink);
                                    resloop2 = 0;
                                    Console.Clear();
                                }
                                else if (resinput2 == "N")
                                {
                                    resloop2 = 0;
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input!");
                                    Console.Write("Please enter any input to go back to try again.");
                                    string exitinput = Console.ReadLine();
                                    Console.Clear();
                                }
                            }
                        }

                        else if (resinput1 == "C")
                        {
                            resloop1 = 0;
                            Console.Clear();
                        }

                        else
                        {
                            Console.WriteLine("Invalid input!");
                            Console.Write("Please enter any input to go back to the resource form menu.");
                            string exitinput = Console.ReadLine();
                            Console.Clear();
                        }
                    }
                }
            }
        }
    }
}
