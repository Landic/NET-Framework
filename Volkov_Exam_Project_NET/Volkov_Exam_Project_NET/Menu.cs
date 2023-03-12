using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Volkov_Exam_Project_NET
{
    internal class Menu
    {
        int choose, item;
        List<MyDictionary> list;
        IReplace obj1;
        IRemove obj2;


        public Menu()
        {
            choose = 0;
            item = 0;
            list = new List<MyDictionary>();
            obj1 = null;
            obj2 = null;
        }

        public void RunMenu()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" ----------------------------");
                Console.WriteLine("|1. Create dictionary        |");
                Console.WriteLine("|----------------------------|");
                Console.WriteLine("|2. Add word and translation |");
                Console.WriteLine("|----------------------------|");
                Console.WriteLine("|3. Replace                  |");
                Console.WriteLine("|----------------------------|");
                Console.WriteLine("|4. Remove                   |");
                Console.WriteLine("|----------------------------|");
                Console.WriteLine("|5. All dictionary           |");
                Console.WriteLine("|----------------------------|");
                Console.WriteLine("|6. Load file                |");
                Console.WriteLine("|----------------------------|");
                Console.WriteLine("|7. Save file                |");
                Console.WriteLine("|----------------------------|");
                Console.WriteLine("|8. Find                     |");
                Console.WriteLine("|----------------------------|");
                Console.WriteLine("|9. Exit                     |");
                Console.WriteLine(" ----------------------------");
                choose = int.Parse(Console.ReadLine());
                Console.ResetColor();
                Console.Clear();
                switch (choose)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(" -----------------"  +
                                          "\n|Choose dictionary|" +
                                          "\n|-----------------|" +
                                          "\n|1.ENG-RU         |" + 
                                          "\n|-----------------|" +
                                          "\n|2.RU-ENG         |" +
                                          "\n -----------------");
                        choose = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                        if (choose == 1)
                        {
                            list.Add(new MyDictionary(new EngRus()));
                        }
                        else if (choose == 2)
                        {
                            list.Add(new MyDictionary(new RusEng()));
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" --------------" +
                                              "\n| No such item |" +
                                              "\n --------------");
                            Console.ResetColor();
                            continue;
                        }
                        Console.Clear();
                        continue;
                    case 2:
                        if (list.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" --------------------------" +
                                              "\n| Error! Create dictionary |" +
                                              "\n --------------------------");
                            Thread.Sleep(1000);
                            Console.ResetColor();
                            Console.Clear();
                            continue;
                        }
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(" -----------------" +
                                          "\n|Choose dictionary|" +
                                          "\n -----------------");
                        foreach (var i in list)
                        {
                            i.GetAllDictionary();
                        }
                        item = int.Parse(Console.ReadLine()) - 1;
                        Console.Clear();
                        Console.ResetColor();
                        if (item + 1 > list.Count)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" -------" +
                                              "\n| Error |" +
                                              "\n -------");
                            Thread.Sleep(1000);
                            Console.ResetColor();
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            list[item].AddDictionary();
                            Console.Clear();
                            Console.ResetColor();
                        }
                        continue;
                    case 3:
                        if (list.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" --------------------------" +
                                              "\n| Error! Create dictionary |" +
                                              "\n --------------------------");
                            Thread.Sleep(1000);
                            Console.ResetColor();
                            Console.Clear();
                            continue;
                        }
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(" -----------------" +
                                          "\n|Choose dictionary|" +
                                          "\n -----------------");
                        foreach (var i in list)
                        {
                            i.GetAllDictionary();
                        }
                        item = int.Parse(Console.ReadLine()) - 1;
                        Console.Clear();
                        Console.ResetColor();
                        if (item + 1 > list.Count)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" -------" +
                                              "\n| Error |" +
                                              "\n -------");
                            Thread.Sleep(1000);
                            Console.ResetColor();
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(" ------------------------\n" +
                                              "| 1. Replace word        |\n" +
                                              "|------------------------|\n" +
                                              "| 2. Replace translation |\n" +
                                              " ------------------------");
                            choose = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (choose == 1)
                            {
                                obj1 = new ReplaceWord();
                                obj1.MyReplace(list[item]);
                                Console.Clear();
                            }
                            else
                            {
                                obj1 = new ReplaceTranslation();
                                obj1.MyReplace(list[item]);
                                Console.Clear();
                            }
                            Console.ResetColor();
                        }
                        continue;
                    case 4:
                        if (list.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" --------------------------" +
                                              "\n| Error! Create dictionary |" +
                                              "\n --------------------------");
                            Thread.Sleep(1000);
                            Console.ResetColor();
                            Console.Clear();
                            continue;
                        }
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(" -----------------" +
                                          "\n|Choose dictionary|" +
                                          "\n -----------------");
                        foreach (var i in list)
                        {
                            i.GetAllDictionary();
                        }
                        item = int.Parse(Console.ReadLine()) - 1;
                        Console.Clear();
                        Console.ResetColor();
                        if (item + 1 > list.Count)
                        {

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" -------" +
                                              "\n| Error |" +
                                              "\n -------");
                            Thread.Sleep(1000);
                            Console.ResetColor();
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(" -----------------------\n" +
                                              "| 1. Remove word        |\n" +
                                              "|-----------------------|\n" +
                                              "| 2. Remove translation |\n" +
                                              " -----------------------");
                            choose = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (choose == 1)
                            {
                                obj2 = new RemoveWord();
                                obj2.MyRemove(list[item]);
                                Console.Clear();
                            }
                            else
                            {
                                obj2 = new RemoveTranslation();
                                obj2.MyRemove(list[item]);
                                Console.Clear();
                            }
                            Console.ResetColor();
                        }
                        continue;
                    case 5:
                        if (list.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" --------------------------" +
                                              "\n| Error! Create dictionary |" +
                                              "\n --------------------------");
                            Thread.Sleep(1000);
                            Console.ResetColor();
                            Console.Clear();
                            continue;
                        }
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(" ----------------\n" +
                                          "| All dictionary |\n" +
                                          " ----------------");
                        foreach (var i in list)
                        {
                            i.GetAllDictionary();
                        }
                        Console.WriteLine("1. Exit");
                        choose = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.ResetColor();
                        continue;
                    case 6:
                        if (list.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" --------------------------" +
                                              "\n| Error! Create dictionary |" +
                                              "\n --------------------------");
                            Thread.Sleep(1000);
                            Console.ResetColor();
                            Console.Clear();
                            continue;
                        }
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(" -----------------" +
                                          "\n|Choose dictionary|" +
                                          "\n -----------------");
                        foreach (var i in list)
                        {
                            i.GetAllDictionary();
                        }
                        item = int.Parse(Console.ReadLine()) - 1;
                        Console.Clear();
                        Console.ResetColor();
                        if (item + 1 > list.Count)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" -------" +
                                              "\n| Error |" +
                                              "\n -------");
                            Thread.Sleep(1000);
                            Console.ResetColor();
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            LoadXML obj3 = new LoadXML();
                            obj3.Load(list[item]);
                            Console.Clear();
                            Console.ResetColor();
                        }
                        continue;
                    case 7:
                        if (list.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" --------------------------" +
                                              "\n| Error! Create dictionary |" +
                                              "\n --------------------------");
                            Thread.Sleep(1000);
                            Console.ResetColor();
                            Console.Clear();
                            continue;
                        }
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(" -----------------" +
                                          "\n|Choose dictionary|" +
                                          "\n -----------------");
                        foreach (var i in list)
                        {
                            i.GetAllDictionary();
                        }
                        item = int.Parse(Console.ReadLine()) - 1;
                        Console.Clear();
                        Console.ResetColor();
                        if (item + 1 > list.Count)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" -------" +
                                              "\n| Error |" +
                                              "\n -------");
                            Thread.Sleep(1000);
                            Console.ResetColor();
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            SaveXML obj3 = new SaveXML();
                            obj3.SaveDictionary(list[item]);
                            Console.Clear();
                            Console.ResetColor();
                        }
                        continue;
                    case 8:
                        if (list.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" --------------------------" +
                                              "\n| Error! Create dictionary |" +
                                              "\n --------------------------");
                            Thread.Sleep(1000);
                            Console.ResetColor();
                            Console.Clear();
                            continue;
                        }
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(" -----------------" +
                                          "\n|Choose dictionary|" +
                                          "\n -----------------");
                        foreach (var i in list)
                        {
                            i.GetAllDictionary();
                        }
                        item = int.Parse(Console.ReadLine()) - 1;
                        Console.Clear();
                        Console.ResetColor();
                        if (item + 1 > list.Count)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" -------" +
                                              "\n| Error |" +
                                              "\n -------");
                            Thread.Sleep(1000);
                            Console.ResetColor();
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            FindTranslation obj3 = new FindTranslation();
                            obj3.MyFind(list[item]);
                            Console.WriteLine(" --------- \n" +
                                              "| 1. Exit | \n" +
                                              " ---------");
                            choose = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.ResetColor();
                        }
                        continue;
                    case 9:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(" ---------\n" +
                                          "| Exit... |\n" +
                                          " ---------");
                        Thread.Sleep(1000);
                        Console.ResetColor();
                        Console.Clear();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" --------------" +
                                          "\n| No such item |" +
                                          "\n --------------");
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.ResetColor();
                        continue;
                }
                break;
            }
        }
    }
}
