using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernardo___Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<object, string> karaokeSongs = new Dictionary<object, string>();
            int songNum, searchNum;
            string songName, searchName;
            bool session = true;
            while (session)
            {
                Console.WriteLine("\tKara-OKE!\n");
                Console.WriteLine(" Choose an Action to Perform:");
                Console.WriteLine("\t[1] Display all Songs");
                Console.WriteLine("\t[2] Add new Song");
                Console.WriteLine("\t[3] Search a Song");
                Console.WriteLine("\t[4] Update a Song");
                Console.WriteLine("\t[5] Delete a Song");
                Console.Write("\n Select an Action: ");
                int action = Convert.ToInt32(Console.ReadLine());
                if (action == 1)
                {
                    Console.WriteLine(" Song Code\tSong Title");
                    foreach (var item in karaokeSongs)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(" " + item.Key.ToString()+":" + "\t\t" + item.Value);
                        Console.ResetColor();
                    }
                }

                if (action == 2)
                {  
                  Console.Write(" Enter Song Number: ");
                  Console.ForegroundColor = ConsoleColor.Yellow;
                  songNum = Convert.ToInt32(Console.ReadLine()); Console.ResetColor();
                  Console.Write(" Enter Song Name: ");
                  Console.ForegroundColor = ConsoleColor.Blue;
                  songName = Console.ReadLine();
                  karaokeSongs.TryAdd(songNum, songName); Console.ResetColor();
                  Console.WriteLine(" New song has successfully been added!"); 
                  
                }

                if (action == 3)
                {
                    Console.Write(" Search Song Title: ");
                    searchName = Console.ReadLine();
                    if (karaokeSongs.Values.Contains(searchName))
                    {
                        Console.WriteLine(" Song/s found with the title " + searchName);
                        foreach (var item in karaokeSongs)
                        {
                            string key;
                            if (item.Value == searchName)
                            {
                                key = item.Key.ToString();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(" " + key + ": "); Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine(searchName); Console.ResetColor();
                               
                            }   
                        }    
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" " + searchName + " does not exist in Song Records!");
                        Console.ResetColor();
                    }
                }

                if (action == 4)
                {
                    Console.Write(" Enter Song Code to Update: ");
                    searchNum = Convert.ToInt32(Console.ReadLine());
                    if (karaokeSongs.ContainsKey(searchNum))
                    {
                        Console.Write(" Enter Updated Title: ");
                        songName = Console.ReadLine(); Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" " + karaokeSongs[searchNum]); Console.ResetColor();
                        Console.Write(" has been updated to new title ");
                        Console.ForegroundColor = ConsoleColor.Blue; Console.Write(songName); Console.ResetColor();
                        karaokeSongs[searchNum] = songName;
                    }
                    else 
                    {
                        Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" Song Code does not Exist!");
                        Console.ResetColor();
                    }
                      
                }

                if (action == 5)
                {
                    Console.Write(" Enter Song Code to Delete: ");
                    searchNum = Convert.ToInt32(Console.ReadLine());
                    if (karaokeSongs.ContainsKey(searchNum))
                    {
                        foreach (var item in karaokeSongs)
                        {
                            if ((int)item.Key == searchNum)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(" Song [" + item.Key + ": " + item.Value + "] was Deleted");
                                Console.ResetColor();
                            }         
                        }
                        karaokeSongs.Remove(searchNum);
                    }
                    else 
                    {
                        Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" Song Code does not Exist!");
                        Console.ResetColor();
                    }
                    
                }
                Console.Write("\n\n Press ENTER to go back to main menu...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
