
//khoi tao list

using System.Collections.Generic;
using System;
using System.Diagnostics.Metrics;

List<String> list = new List<string>
    {
        "Nguyen Thi Ngoc Yen",
        "Nguyen Tuan Anh",
        "Ngo Tung Anh",
        "Tran Van Tuan",
        "Le Ngoc Yen" ,
        "Nguyen Thi Van Anh",
        "Nguyen Van Thao Nhi",
        "Le Van Thuy",
        "Doan Thi Van Thao",
        "Bui Thi Hai Yen"

    };
Console.WriteLine("List Svien: ");
foreach (string item in list)
{
    Console.WriteLine(item);
}

int count = 0;
Console.WriteLine("\nSvien co ten Yen la: ");
foreach (var o in list)
{
    String[] s = o.Split(' ');

    if (s[s.Length - 1].Trim().Equals("Yen"))
    {
        Console.Write(o + " , ");
        count++;
    }
}
Console.WriteLine("\nSo luong =" + count);

int count2 = 0;
foreach (string name in list)
{
    string[] s = name.Split(" ");
    //string[] s = item[1].Split(" ");
    for (int i = 1; i < s.Length - 1; i++)
    {
        if (s[i].ToLower().Trim().Equals("van"))
        {
            // if (count > 0) Console.Write(", ");
            //  Console.Write(s[0]);
            count2++;
            break;
        }
    }
}
Console.WriteLine("so hoc sinh co phan dem la chu Van = " + count2);

int count3 = 0;
foreach (string name in list)
{
    string[] s = name.Split(".");
    //string[] s = item[1].Split(" ");
    if (s[0].ToLower().Trim().StartsWith('n'))
    {
        //if (count3 > 0) Console.Write(", ");
        // Console.Write(s[0]);
        count3++;
    }
}

Console.WriteLine("\nso hoc sinh co ho bat dau bang chu N  = " + count3);
