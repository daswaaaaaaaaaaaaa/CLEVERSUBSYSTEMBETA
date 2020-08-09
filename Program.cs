using System;
using System.IO;
using System.Diagnostics;

namespace SubSystemForWindows
{
    class Program
    {
        static void Main(string[] args)
        {
            bool commandfound = false;
            bool isrun = true;
            Console.Title = "SuBSystemCLEVER";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter your name or nickname:");
            string username = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("k1ll3r SySt3m corporation.(2018-2020)");
            Console.WriteLine("The free application with open source.");
            Console.WriteLine("github: none.");
            Console.WriteLine("yandex disk: none.");
            Console.WriteLine("The SubSystem for Windows.");
            Console.Write("@root:" + username + "@:");
            while (isrun) {
                string command = Console.ReadLine().ToLower();
                if (command == "clear") {
                    commandfound = true;
                    Console.Clear();
                    Console.Write("@root:" + username + "@:");
                }
                if (command == "author")
                {
                    commandfound = true;
                    Console.WriteLine("nickname: k1ll3r SySt3m.");
                    Console.WriteLine("Youtube channel: https://www.youtube.com/channel/UC0t57h0KYh7iA4v1EbKFwWg.");
                    Console.Write("@root@" + username + "@:");
                }
                if (command == "copyright") {
                    commandfound = true;
                    Console.WriteLine("k1ll3r SySt3m corporation.(2018-2020)");
                    Console.WriteLine("The free application with open source.");
                    Console.Write("@root:" + username + "@:");
                }
                if (command == "help") {
                    commandfound = true;
                    Console.WriteLine("author - creator the subsystem.");
                    Console.WriteLine("createfile - create new file on set path.");
                    Console.WriteLine("writefile - write value in file on set path.");
                    Console.WriteLine("delfile - delete file on set path.");
                    Console.WriteLine("filecrypt - crypt file on set path.");
                    Console.WriteLine("start - start process.");
                    Console.WriteLine("copyright - the copyright.");
                    Console.WriteLine("set username - the set your username.");
                    Console.WriteLine("quit - the exit.");
                    Console.Write("@root:" + username + "@:");
                }
                if (command == " ")
                {
                    commandfound = true;
                    Console.Write("@root:" + username + "@:");
                }
                if(command == "quit")
                {
                    commandfound = true;
                    isrun = false;
                }
                if (command == "set username") 
                {
                    commandfound = true;
                    Console.Write("Please enter your new nickname:");
                    username = Console.ReadLine();                }
                if(command == "createfile")
                {
                    commandfound = true;
                    Console.Write("Enter path for file with name:");
                    string path = Console.ReadLine();
                    File.Create(path).Close();
                    Console.Write("@root:" + username + "@:");
                }
                if(command == "writefile")
                {
                    commandfound = true;
                    Console.Write("Enter path for file with name:");
                    string path = Console.ReadLine();
                    Console.Write("Enter text in file:");
                    string filetext = Console.ReadLine();
                    File.WriteAllText(path, filetext);
                    Console.Write("@root:" + username + "@:");
                }
                if (command == "delfile") 
                {
                    commandfound = true;
                    Console.Write("Enter path file delete:");
                    string deletefile = Console.ReadLine();
                    File.Delete(deletefile);
                    Console.Write("@root:" + username + "@:");
                }
                if(command == "filecrypt") 
                {
                    commandfound = true;
                    Console.Write("Enter path crypt file:");
                    string cryptfile = Console.ReadLine();
                    File.Encrypt(cryptfile);
                    Console.Write("@root:" + username + "@:");
                }
                if (command == "start") {
                    commandfound = true;
                    Console.Write("Enter file started:");
                    string filestarted = Console.ReadLine();
                    Process.Start(filestarted);
                    Console.Write("@root:" + username + "@:");
                }
                if (commandfound == false) {
                    Console.WriteLine("Command not found!");
                    Console.Write("@root:" + username + "@:");
                }
                else
                {
                    commandfound = false;
                }
            }
        }
    }
}
