
class Structures
{
    struct Coordinate
    {
        private string name = string.Empty; 
        public string x { get { return name; } set { name = value; } }
        public int y { get; set; }

        //public Coordinate(int x, int y)
        //{
        //    this.x = x;
        //    this.y = y;
        //}
    }
    static void fn()
    {
        //Structure can be created with or without NEW operator
        Coordinate point = new Coordinate();

        Console.WriteLine(point.x); //output: 10  
        Console.WriteLine(point.y); //output: 20  
    }
}



