int[] mass = {1, 34, 3, 41, 5, 6, 666, 8, 9, 45, 3975, 211, 543};

int n = mass.Length;
int find = 3975;
int index = 0;
while (index < n)
{
    if(mass[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}
//Console.WriteLine(mass[0]);
//int result = Max(
    //Max (mass[0], mass[1], mass[2]),
    //Max (mass[3], mass[4], mass[5]),
    //Max (mass[6], mass[7], mass[8]));
//Console.WriteLine(result);