using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScantelRoofingPrototype
{
    class People
    {
        public int ID { get;}
        public string Name { get;}
        public string PhoneNumber { get;}
        public string EmailAddress { get; }
        public string Address { get;}


        public People(int id, string name, string phonenumber, string email, string address)
        {
            ID = id;
            Name = name;
            PhoneNumber = phonenumber;
            EmailAddress = email;
            Address = address;
        }

        public static int GetHighestID(List<People> people)
        {
            int highest = 0;
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].ID > highest)
                {
                    highest = people[i].ID;
                }
            }
            return highest;
        }
        public static List<People> ReadFromFile()
        {
            return FileReader.ReadFromPeopleFile();
        }
    }
}
