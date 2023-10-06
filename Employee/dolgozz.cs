using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class dolgozz
    {
        public string name { get; set; }
        public int age { get; set; }
        public string city { get; set; }
        public string department { get; set; }
        public string position{ get; set; }
        public string gender { get; set; }
        public string maritalstatus { get; set; }
        public int salary { get; set; }

        public dolgozz(string sorok)
        {
            string[] sor = sorok.Split(";");
            name = sor[0];
            age = Convert.ToInt32(sor[1]);
            city = sor[2];
            department = sor[3];
            position = sor[4];
            gender = sor[5];
            maritalstatus = sor[6];
            salary = Convert.ToInt32(sor[7]);
        }
        public  void kiir()
        {
            Console.WriteLine($"A legidősebb ember adatai:{name},{age},{city},{department},{position},{gender},{maritalstatus},{salary}");
        }
    }
    
}
