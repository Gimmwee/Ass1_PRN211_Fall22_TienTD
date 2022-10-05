
using System;
using System.Security.Cryptography;

Console.WriteLine("---ASSIGMENT_PRN211_FALL22--- ");

Console.WriteLine("\n----Thay Tien depzaimatlaii!!----");


Console.WriteLine("\nEnter n number :");
int n = Convert.ToInt32(Console.ReadLine());

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
Console.WriteLine("\nHop So le tu 0 - n la: ");
for (int i = 0; i < n; i++)
{
    if (checkHs(i) == true && (i % 2 != 0))
    {
        Console.Write(i + " ");
    }
}
int k = 0;
int prime = 2;
int h = 2 * n;
Console.WriteLine("\nn So nguyen to thu 2 la : ");
while (k < h)
{
    if (checkSnt(prime) == true)
    {
        if (k >= n)
        {
            Console.Write(prime + " "); // chua lam xong
        }
        k++;
    }
    prime++;
}
Console.WriteLine("\ncac so chia het cho 3 la: ");
for (int i = 0; i <= n; i++)
{
    if (i % 3 == 0)
    {
        Console.Write(i + " ");
    }

}
Console.WriteLine("\nCac so chia cho 4 du 1 la: ");
for (int i = 0; i <= n; i++)
{
    if (i % 4 == 1)
    {
        Console.Write(i + " ");
    }
}
Console.WriteLine("\ncac phan tu co chu so tan cung la so 6 la : ");
for (int i = 0; i < n; i++)
{
    if (i % 10 == 6)
    {
        Console.Write(i + " ");
    }

}

int m = n;
int cout = 0;
Console.Write("\n" + m + " --> ");
for (int i = 2; i <= n; i++)
{
    int count = 0;
    while (n % i == 0)
    {
        count++;
        n /= i;
    }
    if (count > 0)
    {
        if (count > 1) Console.Write(i + "^" + count);
        else Console.Write(i);
        if (n > i)
        {
            Console.Write("."); ;
        }
    }
}

Console.WriteLine("\n\n");







