using System;

namespace Ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = Convert.ToInt32("42");
            Console.WriteLine($"value = {value}");

            value = int.Parse("42");
            Console.WriteLine($"value = {value}");

            bool success = int.TryParse("42", out value);
            Console.WriteLine($"value = {success}");

            MyClass myClass = new MyClass(1, "First item");
            Console.WriteLine($"myClass = {myClass.GetType()} - {myClass.ToString()}");
            string myClassStr = Convert.ToString(myClass);
            Console.WriteLine($"myClassStr = {myClassStr.GetType()} - {myClassStr.ToString()}");

            var input = "2 Second item";
            var myClass2 = MyClass.Parse(input);
            Console.WriteLine($"myClass2 = {myClass2}");
        }
    }

    //IFormattable is used to change the way the class is shown throught ToString method using the IFormatProvider
    class MyClass : IFormattable
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public MyClass(int id, string text)
        {
            this.Id = id;
            this.Text = text;
        }

        public static MyClass Parse(string value)
        {
            var splitIndex = value.IndexOf(' ');
            var id = int.Parse(value.Substring(0, splitIndex));
            splitIndex++;
            var text = value.Substring(splitIndex, value.Length - splitIndex);
            var result = new MyClass(id, text);

            return result;
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return $"{Id} {Text}";
        }
    }
}
