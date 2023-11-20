void Fillmass(int[] collection)
{
     int Length = collection.Length;
     int index = 0;
     while (index < Length)
     {
        collection[index] = new Random().Next(1, 888);
        //index = index + 1;
        index++;
     }
}
//я тут
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

int indexoff(int[] collection, int find);
{
   int count = Collection.Length
   int index = 0;
}

int[] mass = new int[15];

Fillmass(mass);
Printmass(mass);