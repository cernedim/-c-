void Fillmass(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 17);
        //index = index + 1;
        index++;
    }
}

void Printmass(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find);
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}

int[] mass = new int[15];

Fillmass(mass);
Printmass(mass);
Console.WriteLine();

int pos = IndexOf(mass, 4);
Console.WriteLine(pos);