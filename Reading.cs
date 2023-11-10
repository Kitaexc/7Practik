using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Xml.Serialization;


namespace Convertor_0_0
{
    internal class Reading
    {
        public Reading()
        {

            ConsoleKeyInfo key;

            

            string way_1 = Convert.ToString(Console.ReadLine());

            string myText = File.ReadAllText($"{way_1}");
            
            Console.Clear();

            Console.WriteLine("Для того чтобы сохранить файл в одном из трёх форматов (txt, json, xml) - F1. Закрыть программу - Escape");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine(myText);

            key = Console.ReadKey();


            if (key.Key == ConsoleKey.F1)
            {
                Console.Clear();

                Console.WriteLine("Введите путь до файла (вместе с названием), куда вы хотите сохранить текст");
                Console.WriteLine("--------------------------------------------------------------------------");

                string way_2 = Convert.ToString(Console.ReadLine());

                if (way_2.EndsWith(".json"))
                {
                    File.WriteAllText(way_2, JsonConvert.SerializeObject(myText));
                }
                else if (way_2.EndsWith(".xml"))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(string));
                    using (TextWriter writer = new StreamWriter(way_2))
                    {
                        xmlSerializer.Serialize(writer, myText);
                    }
                }
                else
                {
                    File.WriteAllText(way_2, myText);
                }
            }


        }
    }
}