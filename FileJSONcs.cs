using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Text.Json;
using System.Threading.Tasks;

namespace ExceptionHandling
{
  //  string FilePath = @"C:\Users\admin\Desktop\YASHWANTH\Myfile.txt";

    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class FileJson
    {
        string FilePath = @"C:\Users\admin\Desktop\YASHWANTH\MyJson.JSON";

        public void Create()
        {
            // Create an object to be serialized into JSON
            var person = new Person
            {
                Name = "Yashwanth",
                Age = 23
            };

            // Convert the object to JSON string
            string jsonString = JsonSerializer.Serialize(person);

            // Write the JSON string to the file
           
            File.WriteAllText(FilePath, jsonString);

            Console.WriteLine("JSON file created successfully.");
        }

        public void Read()
        {
            // Read the JSON file
            
            string jsonString = File.ReadAllText(FilePath);

            // Deserialize the JSON string into objects
            var person = JsonSerializer.Deserialize<Person>(jsonString);

            // Access the properties of the object
            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {person.Age}");

            Console.WriteLine("JSON file read successfully.");
        }

        public void Write()
        {
            // Read the JSON file
            
            string jsonString = File.ReadAllText(FilePath);

            // Deserialize the JSON string into objects
            var person = JsonSerializer.Deserialize<Person>(jsonString);

            // Update the object
            person.Name = "K.Yashwanth";
            person.Age = 23;

            // Convert the object to JSON string
            jsonString = JsonSerializer.Serialize(person);

            // Write the JSON string back to the file
            File.WriteAllText(FilePath, jsonString);

            Console.WriteLine("JSON file updated successfully.");
        }

       /* public void Append()
        {
            // Read the existing JSON file
            
            string eJsonString = File.ReadAllText(FilePath);

            // Deserialize the existing JSON string into objects
            var personList = JsonSerializer.Deserialize<List<Person>>(JsonString);

            // Create a new person
            var newPerson = new Person
            {
                Name = "Arun",
                Age = 25
            };

            // Add the new person to the list
            personList.Add(newPerson);

            // Convert the updated list to JSON string
            string updatedJsonString = JsonSerializer.Serialize(personList);

            // Write the updated JSON string back to the file
            File.WriteAllText(FilePath, updatedJsonString);

            Console.WriteLine("JSON file appended successfully.");
        }*/
    }

}

