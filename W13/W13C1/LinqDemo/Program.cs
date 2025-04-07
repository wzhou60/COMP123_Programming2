namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, 7, 8, 11, 15, 21, 5, 13 };

            //Query notation
            //var query = from number in numbers
            //            where number % 2 == 1
            //            select number;

            //function notation
            var query2 = numbers.Where(x => x % 2 == 1).Select(x => x);

            //Console.WriteLine(query);
            foreach (int number in query2)
            {
                Console.WriteLine(number);
            }

            string sentence = "Today is a good day to play ball";
            var words = sentence.Split(' ');

            var selectedWords = from word in words
                                group word by word.Length into wordLength
                                select wordLength;
            //select word.Length;
            /*where word.Length > 3
            select word;*/

            Console.WriteLine();
            foreach (var group in selectedWords)
            {
                Console.WriteLine(group.Key);
                foreach (var word in group)
                {
                    Console.WriteLine(word);
                }
            }

            var complexQuery = from word in words
                               select new { w = word, l = word.Length };
            //select new { word,  word.Length };

            Console.WriteLine();
            Console.WriteLine();
            foreach (var complex in complexQuery)
            {
                Console.WriteLine(complex);
                //Console.WriteLine(complex.word);
                //Console.WriteLine(complex.Length);
            }

            var joinWords = from number in numbers
                            from word in words
                            select $"{word} {number}";
            //select new { word, number };

            //extend queries
            var joinWords2 = (from word in joinWords
                             where word.Length > 4 
                             select word);

            //var joinWords2 = (from word in joinWords
            //                 where word.Length == 5
            //                 select word).Take(3); //gets only 3 elements

          //  var joinWords3 = joinWords2.ToList();
            var joinWords3 = joinWords2.Take(5).ToDictionary(x => x.Split(' ')[0], x => x);

            Console.WriteLine();
            foreach (var item in joinWords)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            //foreach (var item in joinWords2.Take(3))
            foreach (var item in joinWords2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            //foreach (var item in joinWords2.Take(3))
            foreach (var item in joinWords3)
            {
                Console.WriteLine(item);
            }

            var orderQuery = from word in joinWords2
                             where word.Length > 4
                             orderby (word)
                             select word;

            Console.WriteLine();
            foreach (var item in orderQuery)
            {
                Console.WriteLine(item);
            }

            int noOfChars = joinWords2.Sum(x => x.Length);
            Console.WriteLine(noOfChars);



        }
    }
}