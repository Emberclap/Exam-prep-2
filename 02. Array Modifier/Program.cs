namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arrayOfIntegers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command = " ";
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> commandsList = command
                    .Split()
                    .ToList();
                if (commandsList.Count > 1)
                {
                    int firstIndex = int.Parse(commandsList[1]);
                    int secondIndex = int.Parse(commandsList[2]);

                    switch (commandsList[0])
                    {

                        case "swap":
                            int temp = arrayOfIntegers[firstIndex];
                            arrayOfIntegers.Insert(firstIndex, arrayOfIntegers[secondIndex]);
                            arrayOfIntegers.RemoveAt(firstIndex+1);
                            arrayOfIntegers.Insert(secondIndex, temp);
                            arrayOfIntegers.RemoveAt(secondIndex + 1);
                            break;
                        case "multiply":
                            arrayOfIntegers[firstIndex] = arrayOfIntegers[firstIndex] * arrayOfIntegers[secondIndex];
                            break;
                    }
                }
                if (commandsList[0] == "decrease")
                {
                    for (int i = 0; i < arrayOfIntegers.Count; i++)
                    {
                        arrayOfIntegers[i] -= 1;
                    }

                }
            }
                Console.WriteLine(string.Join(", ", arrayOfIntegers));
        }    
    }
}