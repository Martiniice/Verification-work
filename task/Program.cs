//{ "hello", "2", "world", ":-)" } {"1234", "1567", "-2", "computer science"} {"Russia", "Denmark", "Kazan"};
string[] arr = { "hello", "2", "world", ":-)" }; 
int length = 0;
int CountArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) length++;
    }
    return length;
}
void WriteOutElements(string[] array,string[] massiv)
{
    int i = 0;
    int j = 0;
    while(i < array.Length)
    {
        if (array[i].Length <= 3) 
        {
            massiv[j] = array[i];
            j++;
        }
        i++;
    }
}
void WriteArray(string[] mass)
{
    for (int i = 0; i < mass.Length; i++) System.Console.Write($"{mass[i]}; ");
}
CountArray(arr);
string[] aray = new string[length];
WriteOutElements(arr, aray);
WriteArray(aray);
if (length == 0) System.Console.WriteLine("В заданном массиве нет эллементов меньше либо равных 3 символам");
