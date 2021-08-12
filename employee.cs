class Employee
    {
        public int id;
        public string name;
        double sal;
        double hra;
        double travel;

        public Employee()
        {
   
        }

        public Employee(int empid, string empname, double basesal, double hr_allow, double travel_allow)
        {
            this.id = empid;
            this.name = empname;
            this.sal = basesal;
            this.hra = hr_allow;
            this.travel = travel_allow;
    }

        public double getsal()
        {
            return sal;
        }

        public double gethra()
        {
            return hra;
        }

        public double gettravel()
        {
            return travel;
        }

        public double gettax()
        {
            double netsal = sal + hra + travel;
            double tax = 0;
            if (netsal < 500000)
                tax = 0;
            else if (netsal > 500000 && netsal < 1000000)
                tax = .10 * (netsal - 500000);
            else
                tax = .20 * (netsal - 1000000);

            return tax;
        }
               
    }

    class DriverEmployee
    {
        public static void Main()
        {
            Console.WriteLine("Enter Employee ID");
            int empid = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name");
            string empname = (Console.ReadLine());

            Console.WriteLine("Enter Employee Basic salary");
            double basesal = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee HRA");
            double hr_allow = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Travel allowance");
            double travel_allow = double.Parse(Console.ReadLine());

            Employee e = new Employee(empid,empname,basesal,hr_allow,travel_allow);
            
            Console.WriteLine("Tax = " + e.gettax());
           

        }
    }