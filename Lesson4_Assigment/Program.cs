using System.Collections.Generic;
using System.Numerics;
using System;

public class Program
{
    static void Main(string[] args)
    {
        List<Player> listPlayer = new List<Player>();
        List<Coach> listCoach = new List<Coach>();
        IManager m = new Manager(listPlayer, listCoach);

        while (true)
        {
            Console.WriteLine("\t---MANAGE FOOTBALL TEAM---\n");
            Console.WriteLine("1.Input list of players.");
            Console.WriteLine("2.Input list of coaches.");
            Console.WriteLine("3.Show list of players.");
            Console.WriteLine("4.Show list of coaches.");
            Console.WriteLine("5.Update the information of players.");
            Console.WriteLine("6.Count the coaches have years of experience >=3.");
            Console.WriteLine("7.Sum of the salary of the players are the striker.");
            Console.WriteLine("8.Person have the max salary.");
            Console.WriteLine("9.Sort the list of players by ascending shirt number.");
            Console.WriteLine("10.Sort descending salaries of experienced coaches = 3.");
            Console.WriteLine("11.Save to file txt.");
            Console.WriteLine("12.Load from file.");
            Console.WriteLine("0.Exit.");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 0:
                    {
                        Console.WriteLine("THANK YOU!");
                        return;
                    }
                case 1:
                    {
                        m.inputListPlayer();
                        break;
                    }
                case 2:
                    {
                        m.inputListCoach();
                        break;
                    }
                case 3:
                    {
                        m.showListPlayer();
                        break;
                    }
                case 4:
                    {
                        m.showListCoach();
                        break;
                    }
                case 5:
                    {
                        m.updatePlayer();
                        break;
                    }
                case 6:
                    {
                        m.countExperience();
                        break;
                    }
                case 7:
                    {
                        m.sumSalary();
                        break;
                    }
                case 8:
                    {
                        m.showMaxLuong();
                        break;
                    }
                case 9:
                    {
                        m.sortNumberAscending();
                        break;
                    }
                case 10:
                    {
                        m.sortSalaryDescending();
                        break;
                    }
                case 11:
                    {
                        m.loadFile();
                        break;
                    }
                case 12:
                    {
                        m.saveFile();
                        break;
                    }
                default: break;

            }
        }
    }

}