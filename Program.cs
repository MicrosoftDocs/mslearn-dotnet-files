using System;
using System.IO;
using System.Collections.Generic;

namespace files_module
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pass in the name of the folder "stores" to the FindFiles method
            var salesFiles = FindFiles("stores");

            // For each file that matched the search criteria in the FindFiles method
            // it was added to "salesFile" - and we now print each filename and its location
            foreach (var file in salesFiles) 
            {
                Console.WriteLine(file);
            }
        }

        // Create a new function called FindFiles that takes a folderName parameter.
        static IEnumerable<string> FindFiles(string folderName) 
        {
            // Create a new list of type strings named "salesFiles"
            List<string> salesFiles = new List<string>();

            // Searches the directory location specified and returns the full file names 
            // and the relevant file paths
            var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);
            
            // Search and check each file in "foundFiles" against parameter
            foreach (var file in foundFiles) 
            {
                // The file name will contain the full path so only check the end of it and if a match
                // add this file to "salesFile"
                if (file.EndsWith("sales.json")) 
                {
                    salesFiles.Add(file);
                }
            }
            return salesFiles; // Return the contents to "salesfile" to memory
        }//findFiles
    }//Program
}//files_module
