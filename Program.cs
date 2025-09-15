
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


var times = Enum.GetValues(typeof(TimeOfDay));
var heroes = Enum.GetValues(typeof(Hero));
for (int i = 0; i < times.Length; i++) {
    TimeOfDay time = (TimeOfDay)times.GetValue(i);
    Console.WriteLine($"\nВремя сейчас: {time}");

    for (int j = 0; j < heroes.Length; j++) {
        Hero h = (Hero)heroes.GetValue(j);
        Console.Write($"{h} - ");
        switch (time) {
            case TimeOfDay.Утро:
                Console.WriteLine(h switch
                {
                    Hero.воин => "делает зарядку с мечом",
                    Hero.маг => "заваривает зелье",
                    Hero.вор => "крадётся по базару",
                    _ => "ничего не делает"
                });
                break;
            case TimeOfDay.День:
                Console.WriteLine(h switch
                {
                    Hero.воин => "тренируется на арене",
                    Hero.маг => "изучает древние книги",
                    Hero.вор => "прячется в тенях",
                    _ => ""
                });
                break;
            case TimeOfDay.Вечер:
                Console.WriteLine(h switch
                {
                    Hero.воин => "ест мясо у костра",
                    Hero.маг => "создаёт магический щит",
                    Hero.вор => "планирует налёт",
                    _ => ""
                });
                break;
            case TimeOfDay.Ночь:
                Console.WriteLine(h switch
                {
                    Hero.воин => "спит в палатке",
                    Hero.маг => "медитирует под луной",
                    Hero.вор => "лезет в чужой дом",
                    _ => ""
                });
                break;

        }
    
    }
}

    enum Hero { воин, маг, вор }
enum TimeOfDay { Утро, День, Вечер, Ночь }



