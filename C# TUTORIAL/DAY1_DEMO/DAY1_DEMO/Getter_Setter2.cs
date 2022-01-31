namespace tutorialspoint
{
    class Student
    {
        private string code = "N.A";
        private string name = "not known";
        private int age = 0;

        // Declare a Code property of type string:
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        // Declare a Name property of type string:
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // Declare a Age property of type int:
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public override string ToString()
        {
            return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
        }
    }

    class ExampleDemo
    {
        public static void Fn()
        {

            // Create a new Student object:
            Student s = new Student();

            s.Name = "Tushar Gope";
            s.Age = 21;
            s.Code = "C1001";

            Console.WriteLine(s.Name);
            Console.WriteLine(s.Age);
            Console.WriteLine(s.Code);

        }
    }
}