using System;

Console.WriteLine("---ASSIGMENT_PRN211_FALL22--- ");

Console.WriteLine("\n----Thay Tien depzaimatlaii!!----");


// khai báo và khởi tạo mảng
int[] a = { 1, 7, 13, 52, 15, 24, 38, 5, 82, 320, 24, 56, 1507, 1709 };


bool checkSnt(int n) // hàm check số nguyên tố 
{
    if (n < 2)
    {
        return false;
    }
    int count = 0;
    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {
            count++;
        }
    }
    if (count == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
bool checkHs(int v)   //hàm check hợp số
{
    if (v % 2 == 0 && v > 2)
    {
        return true;
    }
    else
    {
        for (int j = 3; j < v; j++)
        {
            if (v % j == 0 && v > 2)
            {
                return true;
            }
        }
    }
    return false;
}
Console.WriteLine("\nCac so nguyen to cua mang nay la :");
int countsnt = 0;
for (int i = 0; i < a.Length; i++)
{
    if (checkSnt(a[i]) == true)
    {
        Console.Write(a[i] + " ");
        countsnt++;
    }
}


int counths = 0;
for (int i = 0; i < a.Length; i++)
{
    if (checkHs(a[i]) == true)
    {
        counths++;
    }
}
Console.WriteLine("\nso luong so hop so =" + counths + "\nso luong so nguyen to =" + countsnt);

bool checkSquare(int x)
{
    if (x >= 0)
    {
        double sr = Math.Sqrt((double)x);
        if (sr * sr == x) return true;
    }
    return false;
}

static int[] BubleSort(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        for (int j = 0; j < a.Length - i - 1; j++)
        {
            if (a[j] > a[j + 1])
            {
                int tmp = a[j];
                a[j] = a[j + 1];
                a[j + 1] = tmp;
            }
        }
    }
    return a;
}
Console.WriteLine("sx giam dan square number :  ");
int[] b = new int[100];
int h = 0;
for (int i = 0; i < a.Length; i++)
{
    if (checkSquare(a[i]) == true)
    {
        b[h] = a[i];
        h++;
    }
}
BubleSort(b);
Console.Write("\t");
for (int i = b.Length - 1; i >= b.Length - h; i--)
{
    Console.Write(b[i] + " ");
}
Console.WriteLine("\n\n");





