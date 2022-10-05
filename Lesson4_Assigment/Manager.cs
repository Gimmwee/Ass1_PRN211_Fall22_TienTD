using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

internal class Manager : IManager
{
    private List<Player> listPlayer;
    private List<Coach> listCoach;



    public Manager()
    {

    }
    public Manager(List<Player> listPlayer, List<Coach> listCoach)
    {
        this.listPlayer = listPlayer;
        this.listCoach = listCoach;
    }

    public void inputListCoach()
    {
        Console.WriteLine("Enter Code");
        int code = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter address");
        string address = Console.ReadLine();
        Console.WriteLine("Enter position");
        string position = Console.ReadLine();
        Console.WriteLine("Enter Salary");
        double salary = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Experience");
        int experience = Convert.ToInt32(Console.ReadLine());
        listCoach.Add(new Coach(code, name, address, position, salary, experience));
    }

    public void inputListPlayer()
    {
        Console.WriteLine("Enter Code");
        int code = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter address");
        string address = Console.ReadLine();
        Console.WriteLine("Enter shirt number:"); ;
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Chosse position 1.Tien Dao 2.Hau Ve 3.GK");
        int option = Convert.ToInt32(Console.ReadLine());
        string position = "";


        switch (option)
        {
            case 1:
                {
                    position = "Tien Dao";
                    break;
                }
            case 2:
                {
                    position = "Hau Ve";
                    break;
                }
            case 3:
                {
                    position = "GK";
                    break;
                }
            default:
                break;
        }
        Console.WriteLine("Enter Salary");
        double salary = Convert.ToDouble(Console.ReadLine());


        listPlayer.Add(new Player(code, name, address, number, position, salary));
    }

    public void loadFile()
    {

        try
        {
            string filePlayer = "..\\..\\..\\PlayerData.txt";
            using (StreamReader sr1 = new StreamReader(filePlayer))
            {
                string item = sr1.ReadLine();
                while (item != null)
                {
                    string[] s = item.Split("\t");
                    int code = Convert.ToInt32(s[0]);
                    string name = s[1];
                    string address = s[2];
                    int number = Convert.ToInt32(s[3]);
                    string position = s[4];
                    double salary = Convert.ToDouble(s[5]);
                    listPlayer.Add(new Player(code, name, address, number, position, salary));
                    item = sr1.ReadLine();
                }
            }

            string fileCoach = "..\\..\\..\\CoachData.txt";
            using (StreamReader sr2 = new StreamReader(fileCoach))
            {
                string item = sr2.ReadLine();
                while (item != null)
                {
                    string[] s = item.Split("\t");
                    int code = Convert.ToInt32(s[0]);
                    string name = s[1];
                    string address = s[2];
                    string position = s[3];
                    double salary = Convert.ToDouble(s[4]);
                    int experience = Convert.ToInt32(s[5]);
                    listCoach.Add(new Coach(code, name, address, position, salary, experience));
                    item = sr2.ReadLine();
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Load file error: " + ex.Message);
        }
    }

    public void saveFile()
    {
        try
        {
            string filename = "..\\..\\..\\PlayerData.txt"; // 1 // them @ o dau
            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach (var item in listPlayer)
                {
                    sw.WriteLine(item);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Save File Error!!" + ex.Message);
        }
    }

    public void showListCoach()
    {
        if (!checkCoachNull())
        {
            Console.WriteLine(String.Format("{0,-10}{1,-20}{2,-20}{3,-20}{4,-20}{5,-10}",
            "Code", "Name", "Address", "Position", "Salary", "Experience"));
            foreach (Coach item in listCoach)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("List of Coach is empty!");
        }
    }

    public bool checkPlayerNull()
    {
        string str = "";
        foreach (Player item in listPlayer)
        {
            str += item;
        }
        if (str.Trim().Equals("")) return true;
        return false;
    }

    public bool checkCoachNull()
    {
        string str = "";
        foreach (Coach item in listCoach)
        {
            str += item;
        }
        if (str.Trim().Equals("")) return true;
        return false;
    }


    public void showListPlayer()
    {
        if (!checkPlayerNull())
        {
            Console.WriteLine(String.Format("{0,-10}{1,-20}{2,-20}{3,-20}{4,-20}{5,-10}",
            "Code", "Name", "Address", "Position", "Salary", "Shirt number"));
            foreach (Player item in listPlayer)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("List of Player is empty!");
        }
    }

    public void updatePlayer()
    {
        Console.WriteLine("Input information of Player for update.");
        Console.WriteLine("Enter code: ");
        int code = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(("Enter option:" +
            "\n\t (0).Change the shirt number." +
            "\n\t(!0).Change salary."));
        int option = Convert.ToInt32(Console.ReadLine());
        int number = 0;
        double salary = 0;
        if (option == 0)
        {
            Console.WriteLine("Enter shirt number");
            number = Convert.ToInt32(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("Enter salary");
            salary = Convert.ToDouble(Console.ReadLine());
        }
        changePlayer(code, option, number, salary);
    }

    public void changePlayer(int playercode, int option, int shirtnumber, double salary)
    {
        Player p = new Player();
        while (true)
        {
            if (searchPlayerCode(playercode) == null)
            {
                Console.WriteLine("Player code not found!");
                Console.WriteLine("Enter code: ");
                playercode = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                p = searchPlayerCode(playercode);
                break;
            }
        }
        if (option == 0)
        {
            while (true)
            {
                if (!duplicatePlayerNumber(shirtnumber))
                {
                    p.Number = shirtnumber;
                    break;
                }
                else
                {
                    Console.WriteLine("Shirt number is exist!");
                }
            }


        }
        else
        {
            p.Salary = salary;
        }
        Console.WriteLine("Update successful!");
    }

    private Player searchPlayerCode(int playercode)
    {
        foreach (Player item in listPlayer)
        {
            if (item.Code == playercode) return item;
        }
        return null;
    }

    private bool duplicatePlayerNumber(int number)
    {
        foreach (Player item in listPlayer)
        {
            if (item.Number == number) return true;
        }
        return false;
    }

    int countEx = 0;
    public void countExperience()
    {
        foreach (var item in listCoach)
        {
            if (item.Experience >= 3)
            {
                countEx++;
            }
        }
        Console.WriteLine("so luong coachs co hon 3 nam kinh nghiem la : " + countEx);
    }

    public void showMaxLuong()
    {
        double salary = 0;
        int count = 1;
        foreach (Coach item in listCoach)
        {
            if (item.Salary >= salary)
            {
                salary = item.Salary;
            }
        }
        foreach (Player item in listPlayer)
        {
            if (item.Salary >= salary)
            {
                salary = item.Salary;
            }
        }
        Console.WriteLine("Persons have MAX salary is: " + salary);
        //Console.WriteLine(String.Format("{0,-10}{1,-20}{2,-10}",
        // "STT", "Name", "Position"));
        foreach (Coach item in listCoach)
        {
            if (item.Salary == salary)
            {
                Console.WriteLine(String.Format("{0,-10}{1,-20}{2,-10}",
                    count + ".", item.Name, "Coach"));
                count++;
            }
        }
        foreach (Player item in listPlayer)
        {
            if (item.Salary == salary)
            {
                Console.WriteLine(String.Format("{0,-10}{1,-20}{2,-10}",
                    count + ".", item.Name, "Player"));
                count++;
            }
        }
    }

    public void sortNumberAscending()
    {
        Console.WriteLine(String.Format("{0,-10}{1,-20}{2,-20}{3,-20}{4,-20}{5,-10}",
               "Code", "Name", "Address", "Position", "Salary", "Shirt number"));
        var PlayerInAscOrder = listPlayer.OrderBy(x => x.Number);


        foreach (var item in PlayerInAscOrder)
        {
            Console.WriteLine(item);
        }
    }

    public void sortSalaryDescending()
    {

        Console.WriteLine(String.Format("{0,-10}{1,-20}{2,-20}{3,-20}{4,-20}{5,-10}",
            "Code", "Name", "Address", "Position", "Salary", "Experience"));
        var CoachInDescOrder = listCoach.OrderByDescending(x => x.Salary);
        foreach (var item in CoachInDescOrder)
        {
            if (item.Experience == 3)
                Console.WriteLine(item);
        }
    }

    public void sumSalary()
    {
        double sum = 0;
        foreach (Player item in listPlayer)
        {
            if (item.Position.Trim().ToLower().Contains("striker")) sum += item.Salary;
        }
        Console.WriteLine("Sum salary of player are triker: " + sum);
    }
}