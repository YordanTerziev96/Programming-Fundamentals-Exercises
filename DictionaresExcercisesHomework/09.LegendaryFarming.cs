using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FilesExcercises
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] input = Console.ReadLine().ToLower().Split(new char[] { ' ', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            SortedDictionary<string, int> items = new SortedDictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();
            bool isTrue = true;
            while (isTrue)
            {


                for (int i = 1; i < input.Length; i = i + 2)
                {
                    if (!((input[i].Equals("fragments")) && (input[i].Equals("motes")) && (input[i].Equals("shards"))))
                    {
                        if (!junk.ContainsKey(input[i]))
                        {
                            junk[input[i]] = 0;
                        }
                        junk[input[i]] += int.Parse(input[i - 1]);
                    }
                    if (!items.ContainsKey(input[i]))
                    {
                        items[input[i]] = 0;
                    }
                    items[input[i]] += int.Parse(input[i - 1]);
                    if (items.ContainsKey("fragments"))
                    {
                        if (items["fragments"] >= 250)
                        {
                            isTrue = false;
                            items[input[i]] -= 250;
                            Console.WriteLine("Valanyr obtained!");
                            foreach (var item in items.OrderByDescending(x => x.Value).Where(x => x.Key.Equals("fragments") || x.Key.Equals("motes") || x.Key.Equals("shards")))
                            {
                                Console.WriteLine("{0}: {1}", item.Key, item.Value);
                                
                            }
                            foreach (var item in junk.OrderBy(x => x.Key).Where(x => x.Key != "fragments").Where(x => x.Key != "motes").Where(x => x.Key != "shards"))
                            {
                                Console.WriteLine("{0}: {1}", item.Key, item.Value);

                            }
                            break;
                        }
                        
                    }
                    else
                    {
                        items["fragments"] = 0;
                    }
                    if (items.ContainsKey("shards"))
                    {
                        if (items["shards"] >= 250)
                        {
                            isTrue = false;
                            items[input[i]] -= 250;
                            Console.WriteLine("Shadowmourne obtained!");
                            foreach (var item in items.OrderByDescending(x => x.Value).Where(x => x.Key.Equals("fragments") || x.Key.Equals("motes") || x.Key.Equals("shards")))
                            {
                                Console.WriteLine("{0}: {1}", item.Key, item.Value);
                                
                            }
                            foreach (var item in junk.OrderBy(x => x.Key).Where(x => x.Key != "shards").Where(x => x.Key != "fragments").Where(x => x.Key != "motes"))
                            {
                                Console.WriteLine("{0}: {1}", item.Key, item.Value);

                            }
                            break;
                        }
                        
                    }
                    else
                    {
                        items["shards"] = 0;
                    }
                    if (items.ContainsKey("motes"))
                    {
                        if (items["motes"] >= 250)
                        {
                            isTrue = false;
                            items[input[i]] -= 250;
                            Console.WriteLine("Dragonwrath obtained!");
                            foreach (var item in items.OrderByDescending(x => x.Value).Where(x => x.Key.Equals("fragments") || x.Key.Equals("motes") || x.Key.Equals("shards")))
                            {
                                Console.WriteLine("{0}: {1}", item.Key, item.Value);
                                
                            }
                            foreach (var item in junk.OrderBy(x => x.Key).Where(x => x.Key != "motes").Where(x => x.Key != "fragments").Where(x => x.Key != "shards"))
                            {
                                Console.WriteLine("{0}: {1}", item.Key, item.Value);

                            }
                            break;
                        }
                        
                    }
                    else
                    {
                        items["motes"] = 0;
                    }

                }
                if (isTrue)
                {
                    input = Console.ReadLine().ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                }
                else
                {
                    break;
                }
                
            }
        }
    }
}
