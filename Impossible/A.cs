namespace Impossible
{
    public class A
    {
        private static int Counter = 1;

        public static bool operator == (A obj1, int obj2)
        {
            return (Counter++ == obj2);
        }

        public static bool operator !=(A obj1, int obj2)
        {
            return !(obj1 == obj2);
        }
    }
}