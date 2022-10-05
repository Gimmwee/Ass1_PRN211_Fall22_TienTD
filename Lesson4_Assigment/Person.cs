using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Person
    {
        public int Code { get; set; }
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private string _address;

		public string Address
		{
			get { return _address; }
			set { _address = value; }
		}
        private string _position;

        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        private double _salary;

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public Person()
		{
		}

		public Person(int code, string name, string address, string position, double salary)
		{
			Code = code;
			Name = name;
			Address = address;
			Position = position;	
			Salary = salary;
		}

		public override string? ToString()
		{
			return String.Format("{0,-10}{1,-20}{2,-20}{3,-20}{4,-20}",Code,Name,Address,Position,Salary);
		}
	}
}
