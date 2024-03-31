namespace Inheritance_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Student st = new Student();

            
            st.Grades = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine(string.Join(", ", st.Grades));
        }
    }
    public class Student
    {
        private int[] _grades;

        public int[] Grades
        {
            get { return _grades; }
            set
            {
                
                _grades = value.Where(x => x % 2 == 0).ToArray();
            }
        }
    }
}