namespace Assemente
{
    internal class Program
    {

        #region Q-2

        

        enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA,
        SecurityOfficer 
    }

    class HireDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HireDate(int day, int month, int year)
        {
            
            if (day < 1 || day > 31) day = 1;
            if (month < 1 || month > 12) month = 1;
            if (year < 1900 || year > DateTime.Now.Year) year = 2000;

            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }

    class Employee
    {
        public int ID { get; set; }  
        public string Name { get; set; }

        private char gender;
        public char Gender
        {
            get => gender;
            set
            {
                if (value == 'M' || value == 'F')
                    gender = value;
                else
                    gender = 'M';
            }
        }

        public double Salary { get; set; }
        public HireDate HiringDate { get; set; }
        public SecurityLevel Level { get; set; }

        public Employee(int id, string name, char gender, double salary, HireDate hiringDate, SecurityLevel level)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Salary = salary;
            HiringDate = hiringDate;
            Level = level;
        }

        public override string ToString()
        {
            return $"ID: {ID}\nName: {Name}\nGender: {Gender}\nSalary: {String.Format("{0:C}", Salary)}\nHire Date: {HiringDate}\nSecurity Level: {Level}";
        }
    }

    
        static void Main()
        {
            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(1, "Ali", 'M', 10000, new HireDate(5, 6, 2020), SecurityLevel.DBA);
            EmpArr[1] = new Employee(2, "Sara", 'F', 6000, new HireDate(10, 1, 2023), SecurityLevel.Guest);
            EmpArr[2] = new Employee(3, "Omar", 'M', 12000, new HireDate(15, 3, 2019), SecurityLevel.SecurityOfficer);

            foreach (var emp in EmpArr)
            {
                Console.WriteLine("----------");
                Console.WriteLine(emp);
            }
        }
        #endregion 
    }

}
    

