using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DiceRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string path = Application.StartupPath + @"\rollLog.txt";

                bool exists = File.Exists(path);

                Random rand = new Random();

                Console.WriteLine("Welcome to Dice Roll Beta 0.0.1!");

                if (exists)
                {
                    string readText = File.ReadAllText(path);

                    double oneCount = (readText.Length - readText.Replace("One; ", "").Length) / 5;
                    double twoCount = (readText.Length - readText.Replace("Two; ", "").Length) / 5;
                    double threeCount = (readText.Length - readText.Replace("Three; ", "").Length) / 7;
                    double fourCount = (readText.Length - readText.Replace("Four; ", "").Length) / 6;
                    double fiveCount = (readText.Length - readText.Replace("Five; ", "").Length) / 6;
                    double sixCount = (readText.Length - readText.Replace("Six; ", "").Length) / 5;

                    Console.WriteLine("");
                    Console.WriteLine("Current Counts: ");
                    Console.WriteLine(oneCount + " 1's");
                    Console.WriteLine(twoCount + " 2's");
                    Console.WriteLine(threeCount + " 3's");
                    Console.WriteLine(fourCount + " 4's");
                    Console.WriteLine(fiveCount + " 5's");
                    Console.WriteLine(sixCount + " 6's");
                    Console.WriteLine("Total: " + (oneCount + twoCount + threeCount + fourCount + fiveCount + sixCount));
                    Console.WriteLine("");

                    if (oneCount != 0 && twoCount != 0 && threeCount != 0 && fourCount != 0 && fiveCount != 0 && sixCount != 0)
                    {
                        double oneProb = oneCount / (oneCount + twoCount + threeCount + fourCount + fiveCount + sixCount);
                        double twoProb = twoCount / (oneCount + twoCount + threeCount + fourCount + fiveCount + sixCount);
                        double threeProb = threeCount / (oneCount + twoCount + threeCount + fourCount + fiveCount + sixCount);
                        double fourProb = fourCount / (oneCount + twoCount + threeCount + fourCount + fiveCount + sixCount);
                        double fiveProb = fiveCount / (oneCount + twoCount + threeCount + fourCount + fiveCount + sixCount);
                        double sixProb = sixCount / (oneCount + twoCount + threeCount + fourCount + fiveCount + sixCount);

                        Console.WriteLine("Current Probability: ");
                        Console.WriteLine("Probability of 1: " + oneProb);
                        Console.WriteLine("Probability of 2: " + twoProb);
                        Console.WriteLine("Probability of 3: " + threeProb);
                        Console.WriteLine("Probability of 4: " + fourProb);
                        Console.WriteLine("Probability of 5: " + fiveProb);
                        Console.WriteLine("Probability of 6: " + sixProb);
                        Console.WriteLine("");
                    }

                }

                Console.WriteLine("Press Enter to Roll a Die");
                Console.ReadKey();
                while (true)
                {
                    Console.Clear();

                    int flip = rand.Next(1, 7);

                    switch (flip)
                    {
                        case 1:
                            Console.WriteLine("One!");
                            StreamWriter sw = new StreamWriter(Application.StartupPath + @"\rollLog.txt", true);
                            sw.Write("One; ");
                            sw.Close();
                            break;

                        case 2:
                            Console.WriteLine("Two!");
                            sw = new StreamWriter(Application.StartupPath + @"\rollLog.txt", true);
                            sw.Write("Two; ");
                            sw.Close();
                            break;

                        case 3:
                            Console.WriteLine("Three!");
                            sw = new StreamWriter(Application.StartupPath + @"\rollLog.txt", true);
                            sw.Write("Three; ");
                            sw.Close();
                            break;

                        case 4:
                            Console.WriteLine("Four!");
                            sw = new StreamWriter(Application.StartupPath + @"\rollLog.txt", true);
                            sw.Write("Four; ");
                            sw.Close();
                            break;

                        case 5:
                            Console.WriteLine("Five!");
                            sw = new StreamWriter(Application.StartupPath + @"\rollLog.txt", true);
                            sw.Write("Five; ");
                            sw.Close();
                            break;

                        case 6:
                            Console.WriteLine("Six!");
                            sw = new StreamWriter(Application.StartupPath + @"\rollLog.txt", true);
                            sw.Write("Six; ");
                            sw.Close();
                            break;
                    }

                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
            }
        }
    }
}


