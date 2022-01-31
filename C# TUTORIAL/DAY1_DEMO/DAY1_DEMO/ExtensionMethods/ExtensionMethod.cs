namespace ExtensionMethods
{
    public static class ExtensionMethods
    {   
        //Integer Methods
        public static bool IsGreaterThan(this int i,dynamic value)
        {
            return i > value;
        }
        
        public static bool IsLessThan(this int i,dynamic value)
        {
            return i < value;
        }
        
        public static bool IsEqualsTo(this int i,dynamic value)
        {
            return i == value;
        }
        
        public static bool IsZero(this int i)
        {
            return i == 0;
        }


        //String Methods 
        public static bool IsEquals(this string i, string value)
        {
            return i == value;
        }
    }
}
