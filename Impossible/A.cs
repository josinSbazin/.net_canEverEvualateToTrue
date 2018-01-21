namespace Impossible
{
    public class A
    {
        public static bool operator == (A obj1, int obj2)
        {
            return true;
        }

        public static bool operator !=(A obj1, int obj2)
        {
            return !(obj1 == obj2);
        }
    }
}