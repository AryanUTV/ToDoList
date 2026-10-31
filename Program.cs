namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // En Lista som sparar alla uppgifter 
            List<string> tasks = new List<string>();

            while (true)
            {
                Console.WriteLine("====================");
                Console.WriteLine("    To-Do Lista     ");
                Console.WriteLine("====================");

                Console.WriteLine();

                Console.WriteLine("1. Lägg till uppgift");
                Console.WriteLine("2. Visa uppgifter");
                Console.WriteLine("3. Ta bort uppgift");
                Console.WriteLine("4. Avsluta");

                Console.WriteLine();
                Console.Write("Välj: ");

                // Här kontrolleras att användaren skriver ett nummer 
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    Console.WriteLine();

                    if (input == 1)
                    {
                        Console.Write("Vad vill du lägga till: ");
                        string answer = Console.ReadLine()!;

                        // Uppgiften läggs till i listan
                        tasks.Add(answer);
                    }

                    else if (input == 2)
                    {
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("Det finns inga uppgifter!");
                        }
                        else
                        {
                            Console.WriteLine("Dina uppgifter:");

                            int i = 0;

                            // Går igenom alla uppgifter som finns i listan
                            foreach (string task in tasks)
                            {
                                Console.WriteLine($"{i + 1}. {task}");
                                i++;
                            }
                        }

                        Console.ReadLine();
                    }

                    else if (input == 3)
                    {
                       // Kontrollerar om listan har 0 uppgifter
                       if (tasks.Count == 0)
                        {
                            Console.WriteLine("Det finns inga uppgifter att ta bort!");
                        }
                        else
                        {
                            Console.WriteLine("Dina uppgifter:");

                            int i = 0;

                            // Den går igenom varje uppgift i listan
                            foreach (string task in tasks)
                            {
                                Console.WriteLine($"{i + 1}. {task}");
                                i++;
                            }

                            Console.WriteLine();
                            Console.Write("Vilken uppgift vill du ta bort?: ");

                            // Här kontrolleraras det att användaren skriver ett nummer
                            if (int.TryParse(Console.ReadLine(), out int remove))
                            {
                                // Här så kollar den om numret är ens med i listan
                                if (remove > tasks.Count || remove < 1)
                                {
                                    Console.WriteLine("Det numret finns inte!");
                                }
                                else
                                {
                                    tasks.RemoveAt(remove - 1);

                                    Console.WriteLine("Uppgiften har tagits bort!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Du måste skriva ett nummer!");
                            }
                        }

                        Console.ReadLine();
                    }

                    else if (input == 4)
                    {
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Det numret finns inte!");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Du måste skriva ett nummer från 1 - 4");
                    Console.ReadLine();
                }

                Console.Clear();
            }
        }
    }
}