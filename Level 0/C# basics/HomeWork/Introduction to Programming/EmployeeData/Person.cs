namespace EmployeeData
{
    using System;
    using System.Text;

    internal class Person
    {
        private byte age;
        private string personalId;
        private int employeeNumber;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Gender PersonGender { get; set; }

        public int EmployeeNumber
        {
            get
            {
                return this.employeeNumber;
            }
            set
            {
                if (value < 27560000 || value > 27569999)
                {
                }
                this.employeeNumber = value;
            }
        }

        public string PersonalId
        {
            get
            {
                return this.personalId;
            }
            set
            {
                long num;
                if (!long.TryParse(value, out num))
                {
                    throw new ArgumentException("Only numbers are excepted");
                }
                if (value.Length != 10)
                {
                    throw new ArgumentException("Length have to be exacly 10 digits");
                }
                this.personalId = value;
            }
        }

        public byte Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0 && value > 100)
                {
                    throw new ArgumentException();
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(string.Format("First Name : {0}", this.FirstName));
            output.AppendLine(string.Format("Last Name : {0}", this.LastName));
            output.AppendLine(string.Format("Age : {0}", this.Age));
            output.AppendLine(string.Format("Gender : {0}", this.PersonGender));
            output.AppendLine(string.Format("Personal Id : {0}", this.PersonalId));
            output.Append(string.Format("Unique employee number : {0}", this.EmployeeNumber));

            return output.ToString();
        }
    }
}