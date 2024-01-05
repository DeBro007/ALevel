using System.Numerics;
using System.Security.Cryptography;

Console.WriteLine("Enter the number of array elements");
string size = Console.ReadLine();

Console.WriteLine();

int[] elements = new int[Convert.ToInt32(size)];



for (int i = 0; i < Convert.ToInt32(size); i++)
{
    elements[i] = new Random().Next(1, 26);
}


int[] even = new int[Convert.ToInt32(size)];
int[] uneven = new int[Convert.ToInt32(size)]; 


for (int i = 0; i < Convert.ToInt32(size); i++)
{
    if (elements[i] % 2 == 0)
    {
        even[i] = elements[i];
    }
    else
    {
        uneven[i] = elements[i];
    }

}


char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

int evenTotal = 0;
int unevenTotal = 0;

for (int i = 0; i < Convert.ToInt32(size); i++)
{
    if (even[i] != 0)
    {
        evenTotal++;
    }
    if (uneven[i] != 0)
    {
        unevenTotal++;
    }
}

Console.WriteLine("An array that contains more uppercase letters:");

if (evenTotal > unevenTotal)
{
    for (int i = 0; i < Convert.ToInt32(size); i++)
    {
        if (even[i] != 0)
        {
            if (even[i] == 1 || even[i] == 5 || even[i] == 9 || even[i] == 4 || even[i] == 8 || even[i] == 10)
            {
                Console.Write(char.ToUpper(alphabet[even[i] - 1]) + " ");
            }
            else
            {
                Console.Write(alphabet[even[i] - 1] + " ");
            }
        }
    }
}
else if (evenTotal < unevenTotal)
{
    for (int i = 0; i < Convert.ToInt32(size); i++)
    {
        if (uneven[i] != 0)
        {
            if (uneven[i] == 1 || uneven[i] == 5 || uneven[i] == 9 || uneven[i] == 4 || uneven[i] == 8 || uneven[i] == 10)
            {
                Console.Write(char.ToUpper(alphabet[uneven[i] - 1]) + " ");
            }
            else
            {
                Console.Write(alphabet[uneven[i] - 1] + " ");
            }
        }
    }
}
else
{
    Console.Write("Arrays of the same size");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Both arrays:");

for (int i = 0; i < Convert.ToInt32(size); i++)
{
    if (even[i] != 0)
    {
        if (even[i] == 1 || even[i] == 5 || even[i] == 9 || even[i] == 4 || even[i] == 8 || even[i] == 10)
        {
            Console.Write(char.ToUpper(alphabet[even[i] - 1]) + " ");
        }
        else
        {
            Console.Write(alphabet[even[i] - 1] + " ");
        }
    }
}

Console.WriteLine();

for (int i = 0; i < Convert.ToInt32(size); i++)
{
    if (uneven[i] != 0)
    {
        if (uneven[i] == 1 || uneven[i] == 5 || uneven[i] == 9 || uneven[i] == 4 || uneven[i] == 8 || uneven[i] == 10)
        {
            Console.Write(char.ToUpper(alphabet[uneven[i] - 1]) + " ");
        }
        else
        {
            Console.Write(alphabet[uneven[i] - 1] + " ");
        }
    }
}

Console.WriteLine();
Console.WriteLine("Press enter to end the program");
Console.ReadLine();
