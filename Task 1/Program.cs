int[] array = new int[10] {8,9,2,8,10,7,7,5,6,10};
float result = 0f;
int min = array[0];
int max = array[0];

for (int i = 0; i < array.Length; i++)
{
    result = result + array[i];
}
result = result/array.Length;
Console.WriteLine(result);

for (int i = 1; i < 10; i++)
{
    if(min > array[i])
    {
        min = array[i];
    }
    if(max < array[i])
    { 
        max = array[i];
    }
}
Console.WriteLine(max);
Console.WriteLine(min); 