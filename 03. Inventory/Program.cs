namespace _03._Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine()
                .Split(", ")
                .ToList();
            string command = "";

            while ((command = Console.ReadLine()) != "Craft!")
            {
                
                List<string> commandList = command.Split(" - ").ToList();

                string item = commandList[1];
                
                switch (commandList[0])
                {
                    

                    case "Collect":
                          if (inputList.Contains(item))
                          {
                              break;
                          }
                          else
                          {
                              inputList.Add(item);
                          }
                        break;
                    case "Drop":

                        if (inputList.Contains(item))
                        {
                            inputList.Remove(item);
                        }
                        
                        break;
                    case "Renew":
                        if (inputList.Contains(item))
                        {
                            inputList.Add(item);
                            inputList.Remove(item);
                        }
                        break;
                    case "Combine Items":
                        List<string> items = item
                            .Split(':')
                            .ToList();

                        for (int i = 0; i < inputList.Count; i++)
                        {
                            if (inputList[i] == items[0])
                            {
                                inputList.Insert(i + 1, items[1]);
                            }
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", inputList));
        }
    }
}