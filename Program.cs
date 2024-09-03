namespace Sharp;

class Program
    {
        static int x = 5;
        static string test = "This is a test";
        static double y = 3.14;
        static char oneChar = 'R';
        static int[] myIntArr = { 4, 6, 23, 2 };
        static string[] myStrgArr = { "What", "the", "heck", "is", "going", "on", "?" };
        static List<string> myList = new List<string>();

        static Dictionary<int, string> myDictionary = new Dictionary<int, string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(x);
            Console.WriteLine(test);
            Console.WriteLine(y);
            Console.WriteLine(oneChar);

            for (int i = 0; i < myIntArr.Length; i++)
            {
                Console.WriteLine(myIntArr[i]);
            }

            foreach (string str in myStrgArr)
            {
                Console.WriteLine(str);
            }

            myList.Add("hei");
            myList.Add("på");
            myList.Add("deg");
            
            foreach (string item in myList)
            {
                Console.WriteLine(item);
            }

            myDictionary.Add(23, "Velkommen");
            myDictionary.Add(77, "hit");

            foreach (KeyValuePair<int, string> ele1 in myDictionary)
            {
                Console.WriteLine(ele1.Value);
                Console.WriteLine(ele1.Key);
                Console.WriteLine($"{ele1.Key}: {ele1.Value}");
            }
    }}
