using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScantelRoofingPrototype
{
    class People : DefaultData
    {
        public string Name { get;}
        public string PhoneNumber { get;}
        public string EmailAddress { get; }
        public string Address { get;}


        public People(int id, string name, string phonenumber, string email, string address)
        {
            this.ID = id;
            this.Name = name;
            this.PhoneNumber = phonenumber;
            this.EmailAddress = email;
            this.Address = address;
        }

        public static List<People> ReadFromFile()
        {
            return FileReader.ReadFromPeopleFile();
        }
    }
}
