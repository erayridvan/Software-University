using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactList
{
    class Program
    {
        static void Main()
        {
            List<string> contacts = Console.ReadLine()
                .Split(" ")
                .ToList();

            while (true)
            {
                string text = Console.ReadLine();
                string[] separatedText = text
                    .Split(" ")
                    .ToArray();

                string command = separatedText[0];

                if (command == "Add")
                {
                    string contact = separatedText[1];
                    int index = int.Parse(separatedText[2]);

                    if (!(contacts.Contains(contact)))
                    {
                        contacts.Add(contact);
                    }
                    else if (contacts.Contains(contact))
                    {
                        if (index < contacts.Count && index >= 0)
                        {
                            contacts.Insert(index, contact);
                        }
                    }
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(separatedText[1]);
                    if (index < contacts.Count && index >= 0)
                    {
                        contacts.RemoveAt(index);
                    }
                }
                else if (command == "Export")
                {
                    int startIndex = int.Parse(separatedText[1]);
                    int count = int.Parse(separatedText[2]);

                    if (count > contacts.Count)
                    {
                        count = contacts.Count - startIndex;
                    }

                    var rangeConcactss = contacts.GetRange(startIndex,
                            count);
                    Console.WriteLine($"{string.Join(" ", rangeConcactss)}");
                }
                else if (command == "Print")
                {
                    string order = separatedText[1];

                    if (order == "Normal")
                    {
                        Console.Write("Contacts: ");
                        Console.WriteLine(string.Join(" ", contacts));
                    }
                    else if (order == "Reversed")
                    {
                        Console.Write("Contacts: ");
                        for (int i = contacts.Count - 1; i >= 0; i--)
                        {
                            Console.Write(contacts[i] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                }
            }
        }
    }
}
