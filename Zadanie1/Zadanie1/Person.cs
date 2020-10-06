using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class Person
    {
        private string _Name;
        private string _Surname;
        private int _Age;
        private string _Gender;
        private int _Code;
        private string _City;
        private string _Street;
        private int _HouseNumber;

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (value.Length == 0)
                    Console.WriteLine("Pole nie może być puste!");

                _Name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _Surname;
            }
            set
            {
                if (value.Length == 0)
                    Console.WriteLine("Pole nie może być puste!");

                _Surname = value;
            }
        }

        public int Age
        {
            get
            {
                return _Age;
            }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Wprowadziłeś nieprawidłowy wiek!");

                _Age = value;
            }
        }

        public string Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                string check1 = "K"; string check2 = "M";
                string check3 = "KOBIETA"; string check4 = "MĘŻCZYZNA";
                if (!(value.ToUpper().Equals(check1) || value.ToUpper().Equals(check2) || value.ToUpper().Equals(check3) || value.ToUpper().Equals(check4)))
                    Console.WriteLine("Pole żle wypełnione!");

                _Gender = value;
            }
        }

        public int Code
        {
            get
            {
                return _Code;
            }
            set
            {
                if (value <= 5)
                    Console.WriteLine("Wprowadziłeś nieprawidłowy kod pocztowy!");

                _Code = value;
            }
        }

        public string City
        {
            get
            {
                return _City;
            }
            set
            {
                if (value.Length == 0)
                    Console.WriteLine("Pole nie może być puste!");

                _City = value;
            }
        }

        public string Street
        {
            get
            {
                return _Street;
            }
            set
            {
                if (value.Length == 0)
                    Console.WriteLine("Pole nie może być puste!");

                _Street = value;
            }
        }

        public int HouseNumber
        {
            get
            {
                return _HouseNumber;
            }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Wprowadziłeś nieprawidłowy numer domu!");

                _HouseNumber = value;
            }
        }

        public Person()
        {
            _Name = string.Empty;
            _Surname = string.Empty;
            _Age = 0;
            _Gender = string.Empty;
            _Code = 0;
            _City = string.Empty;
            _Street = string.Empty;
            _HouseNumber = 0;
        }
    }
}