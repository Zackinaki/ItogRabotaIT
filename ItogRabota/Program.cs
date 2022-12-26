void InputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Convert.ToString(Console.ReadLine()); 
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} \t");
}

Console.Clear();
Console.Write("Vvedite kol-vo elem-ov v massive: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array;
array = new string[n];
Console.WriteLine("Vvedite elem-ti massiva: ");
InputArray(array);
Console.WriteLine("\nMassiv emeet vid: ");
PrintArray(array);