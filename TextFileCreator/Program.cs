
using System.Security.Cryptography;

namespace TextFileCreator
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            string archive = @"C:\Test\newtext.txt"; //put a folder that you want and write a name to your new text file

            FileCreator(archive);

            Splitter(archive);
                
        }

        public static void FileCreator(string file)
        {
            StreamWriter writer = File.CreateText(file); //creating the text file

            writer.WriteLine("Eduardo-Maciel"); //writing my name to separate it

            writer.Close();
        }

        public static void Splitter(string file)
        {
            var list = new GenericList<Name>(); //class "Name" gonna be the type of my list

            string? text_line;

            StreamReader reader = new StreamReader(file); //reading the file

            while((text_line = reader.ReadLine()) != null)
            {
                string[] subs = text_line.Split('-'); //splits the string by the character you pass

                list.MyList.Add(new Name() { FirstName = subs[0], LastName = subs[1] }); //adding to my class variables

            }

            foreach (var item in list.MyList) //picking up items from my generic list
            {
                Console.WriteLine("First Name: "+item.FirstName
                                 +"\nLast Name: "+item.LastName);
            }
        }

        
    }
}
