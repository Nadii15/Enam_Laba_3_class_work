
//DayOfWeek day = DayOfWeek.Воскресенье;
//Console.WriteLine(day);
//enum DayOfWeek { 
//    Понедельник,
//    Вторник,
//    Среда,
//    Четверг,
//    Пятница,
//    Суббота,
//    Воскресенье
//}
//Console.ForegroundColor = ConsoleColor.Green;


//var times = Enum.GetValues(typeof(TimeOfDay));
//var heroes = Enum.GetValues(typeof(Hero));
//for (int i = 0; i < times.Length; i++) {
//    TimeOfDay time = (TimeOfDay)times.GetValue(i);
//    Console.WriteLine($"\nВремя сейчас: {time}");

//    for (int j = 0; j < heroes.Length; j++) {
//        Hero h = (Hero)heroes.GetValue(j);
//        Console.Write($"{h} - ");
//        switch (time) {
//            case TimeOfDay.Утро:
//                Console.WriteLine(h switch
//                {
//                    Hero.воин => "делает зарядку с мечом",
//                    Hero.маг => "заваривает зелье",
//                    Hero.вор => "крадётся по базару",
//                    _ => "ничего не делает"
//                });
//                break;
//            case TimeOfDay.День:
//                Console.WriteLine(h switch
//                {
//                    Hero.воин => "тренируется на арене",
//                    Hero.маг => "изучает древние книги",
//                    Hero.вор => "прячется в тенях",
//                    _ => ""
//                });
//                break;
//            case TimeOfDay.Вечер:
//                Console.WriteLine(h switch
//                {
//                    Hero.воин => "ест мясо у костра",
//                    Hero.маг => "создаёт магический щит",
//                    Hero.вор => "планирует налёт",
//                    _ => ""
//                });
//                break;
//            case TimeOfDay.Ночь:
//                Console.WriteLine(h switch
//                {
//                    Hero.воин => "спит в палатке",
//                    Hero.маг => "медитирует под луной",
//                    Hero.вор => "лезет в чужой дом",
//                    _ => ""
//                });
//                break;

//        }

//    }
//}

//    enum Hero { воин, маг, вор }
//enum TimeOfDay { Утро, День, Вечер, Ночь }

//int[] numbers = [1, 2, 3, 4, 5];
//int[] number2 = new int[5] { 1, 2, 3, 4, 5 };
//Console.WriteLine(numbers[1]);
//Console.WriteLine(number2.Length);
//Console.WriteLine(numbers[^1]); // первый эл с конца 

//foreach (var c in numbers) {
//    Console.WriteLine(c);
//}
//for(int i = 0; i< numbers.Length; i++) {
//    Console.WriteLine(numbers[i]);
//}

//List<string> people = ["Denis", "Anton", "Bogdan"];
//List<string> people2 = new List<string>
//{"Bogdan","Denis" };
//people.Add("Dima");
//people.Insert(1, "Kirill");
//people.RemoveAt(1);
//people.Clear();
//Console.WriteLine(people.Count);

//int[] numbers = [-1, -2, -3, -4, -5, -6, 0, 43, 56, -34, 12, 45, -102, 76, -45, 96, -4, -3, 5, 76, -6, -8, 2, 0, 5, -9];
//int result = 0;
//foreach (int number in numbers) {
//    if (number > 0)
//        result++;

//}
//Console.WriteLine($"Число элементов больше нуля: {result}");

//int[] numbers = [-1, -2, -3, -4, -5, -6, 0, 43, 56, -34, 12, 45, -102, 76, -45, 96, -4, -3, 5, 76, -6, -8, 2, 0, 5, -9];
//int n = numbers.Length;
//int k = n / 2;
//int temp;
//for (int i = 0; i < k; i++) 
//{
//    temp = numbers[i];
//    numbers[i] = numbers[n - i - 1];
//    numbers[n - i - 1] = temp;
//}
//foreach(int i in numbers) {
//    Console.Write($"{i} \t");
//}

//int[] nums = [54, 7, -41, 2, 4, 2, 89, 33, -5, 12];
//int temp;
//for (int i = 0; i <nums.Length -1; i++) {
//    for(int j = i + 1; j < nums.Length; j++) {
//        if (nums[i] > nums[j]) {
//            temp = nums[i];
//            nums[i] = nums[j];
//            nums[j] = temp;
//        }
//    }
//}
//Console.WriteLine("Вывод отсортированного массива");
//for (int i = 0; i < nums.Length; i++) {
//    Console.WriteLine(nums[i]);
//}