using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace _04.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDic = new Dictionary<string, string>();
            
            for (int i = 0; ; i++)
            {
                string name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                string mail = Console.ReadLine();
                string value = mail.Substring(mail.Length - 2, 2);
                
              

                if (!(value == "us" || value == "uk"))
                {
                    myDic[name] = mail;
                }
            }
            foreach (var item in myDic)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
            
        }
    }
}
