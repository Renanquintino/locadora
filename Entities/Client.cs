using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Xml.Serialization;

namespace Pereirão.Entities
{
    class Client
    {
        public string   Cpf{ get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }

        public Client()
        {
        }

        public Client(string cpf, string name, DateTime birthDay)
        {
            Cpf = cpf;
            Name = name;
            BirthDay = birthDay;
        }

        public override string ToString()
        {
            return "Nome:  " + Name
                + "\n CPF: " + Cpf
                + "\n Data De Nascimento" + BirthDay.ToString("dd/MM/yyyy ", CultureInfo.InvariantCulture);
        }
    }


}
