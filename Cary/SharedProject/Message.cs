using System;
using System.Collections.Generic;
using System.Text;

namespace SharedProject
{
    class Message
    {
        public int id { get; set; }
        public string textMessage { get; set; }
        public int idPerson { get; set; }

        private static string test = "";


        static void sendMessage()
        {
            int id = getLastId();
            saveMessage(id);
        }

        static void saveMessage(int id)
        {
            // You can modify the path if necessary"C:\Users\Public\TestFolder" folder on your machine.

            // Write an array of strings to a file.
            // Create a string array that consists of three lines.
            string[] lines = { id.ToString(), "Second line", "Third line" };
            // WriteAllLines creates a file, writes a collection of strings to the file,
            // and then closes the file.  You do NOT need to call Flush() or Close().
            // System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\WriteLines.txt", lines);

        }

        public void printMessage()
        {
            test = "hello";
        }

        static int getLastId()
        {
            return 3;
        }

    }
}
