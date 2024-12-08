namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //завдання 1
            //int[] array = { 1, 1, 2, 2, 3, 4, 5, 5 };

            //int evenCount = 0, oddCount = 0, uniqueCount = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] % 2 == 0)
            //        evenCount++;
            //    else
            //        oddCount++;
            //}

            //for (int i = 0; i < array.Length; i++)
            //{
            //    bool isUnique = true;
            //    for (int j = 0; j < array.Length; j++)
            //    {
            //        if (i != j && array[i] == array[j])
            //        {
            //            isUnique = false;
            //            break;
            //        }
            //    }
            //    if (isUnique)
            //        uniqueCount++;
            //}

            //Console.WriteLine($"Парнi: {evenCount}");
            //Console.WriteLine($"Непарнi: {oddCount}");
            //Console.WriteLine($"Унiкальнi: {uniqueCount}");

            //завдання 2
            //int[] array = { 1, 1, 2, 2, 3, 4, 5, 5 };

            //Console.Write("Введiть число: ");
            //int number = int.Parse(Console.ReadLine());

            //int count = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] < number)
            //        count++;
            //}

            //Console.WriteLine($"Кiлькiсть чисел менших за {number}: {count}");

            //завдання 3
            //Console.Write("Введiть речення: ");
            //string sentence = Console.ReadLine().ToLower();

            //char[] vowels = { 'а', 'е', 'и', 'і', 'о', 'у', 'я', 'ю', 'є', 'ї' };
            //int vowelCount = 0;

            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    for (int j = 0; j < vowels.Length; j++)
            //    {
            //        if (sentence[i] == vowels[j])
            //        {
            //            vowelCount++;
            //            break;
            //        }
            //    }
            //}

            //Console.WriteLine($"Кiлькiсть голосних лiтер: {vowelCount}");

            //завдання 4
            Console.Write("Введiть речення: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                char[] wordArray = words[i].ToCharArray();
                Array.Reverse(wordArray);
                words[i] = new string(wordArray);
            }

            string result = string.Join(" ", words);
            Console.WriteLine($"Перевернуте речення: {result}");
        }
    }
}
