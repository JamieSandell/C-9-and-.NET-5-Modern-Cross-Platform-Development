/*
Create a console application that creates a list of
shapes, user serialization to save it to the filesystem using XML, and then
deserializes it back.

Shapes should have a read-only property named Area so that when you
deserialize, you can output a list of shapes, including their areas.

This is what your output should look like when you run the application:

Loading shapes from XML:
Circle is Red and has an area of 19.63
Rectangle is Blue and has an area of 200.00
Circle is Green and has an area of 201.06
Circle is Purple and has an area of 475.99
Rectangle is Blue and has and area of 810.00
*/

using System;
using System.Collections.Generic;
using static System.Console;
using static System.Environment;
using System.IO;
using static System.IO.Path;
using System.Xml.Serialization;

namespace Exercise_9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of Shapes to serialize
            var listOfShapes  = new List<Shape>
            {
                new Circle { Color = "Red", Radius = 2.5 },
                new Rectangle { Color = "Blue", Height = 20.0, Width = 10.0 },
                new Circle { Color = "Green", Radius = 8.0 },
                new Circle { Color = "Purple", Radius = 12.3 },
                new Rectangle { Color = "Blue", Height = 45.0, Width = 18.0 }
            };
            var xs = new XmlSerializer(typeof(List<Shape>));
            string path = Combine(CurrentDirectory, "shape.xml");
            using (FileStream stream = File.Create(path))
            {
                xs.Serialize(stream, listOfShapes);
            }
            using (FileStream stream = File.OpenRead(path))
            {
                var loadedShapes = (List<Shape>)xs.Deserialize(stream);
                WriteLine("Loading shapes from XML:");
                foreach (Shape item in loadedShapes)
                {
                    WriteLine("{0} is {1} and has an area of {2:N2}", item.GetType().Name, item.Color, item.Area);
                }
            }
        }
    }
}
