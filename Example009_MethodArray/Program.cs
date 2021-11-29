int [] array = {1, 12, 13, 14, 15, 6, 17, 14};

int n = array.Length;
int find = 14;

int index = 0;

while (index<n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}