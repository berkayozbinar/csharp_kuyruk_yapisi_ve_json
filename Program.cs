using System;

namespace veriproje
{
    class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Title = "ŞİİR-ŞAİR";

            Queue obj = new Queue(10);

            Poetrist poetrist1 = new Poetrist("Cemal", "Süreyya", "Türk");
            poetrist1.AddPoetry(new Poetry("Sevgilim Ben Şimdi", 1, 9));
            poetrist1.AddPoetry(new Poetry("Bir Çiçek", 3, 10));
            obj.Enqueue(poetrist1);

            Poetrist poetrist2 = new Poetrist("Nazım", "Hikmet", "Türk");
            poetrist2.AddPoetry(new Poetry("Herkes Gibisin", 2, 8));
            poetrist2.AddPoetry(new Poetry("Ceviz Ağacı", 3, 16));
            poetrist2.AddPoetry(new Poetry("Güzel Günler Göreceğiz Çocuklar", 9, 31));
            obj.Enqueue(poetrist2);

            Poetrist poetrist3 = new Poetrist("Özdemir", "Asaf", "Türk");
            poetrist3.AddPoetry(new Poetry("Ben Değildim", 4, 20));
            obj.Enqueue(poetrist3);

            Poetrist poetrist4 = new Poetrist("Edgar Allan", "Poe", "Amerikan");
            poetrist4.AddPoetry(new Poetry("Annabel Lee", 1, 38));
            obj.Enqueue(poetrist4);

            Poetrist poetrist5 = new Poetrist("Charles", "Baudelaire", "Fransız");
            poetrist5.AddPoetry(new Poetry("Ne Dersin Bu Akşam", 3, 14));
            obj.Enqueue(poetrist5);

            Poetrist poetrist6 = new Poetrist("Jorge Luis", "Borges", "Arjantinli");
            poetrist6.AddPoetry(new Poetry("An’lar", 4, 29));
            obj.Enqueue(poetrist6);

            Poetrist poetrist7 = new Poetrist("Johann Wolfgang von", "Goethe", "Alman");
            poetrist7.AddPoetry(new Poetry("Melankoli ", 1, 6));
            obj.Enqueue(poetrist7);

            Poetrist poetrist8 = new Poetrist("Pablo", "Neruda", "Şilili");
            poetrist8.AddPoetry(new Poetry("Matilde’ye Sone", 1, 14));
            obj.Enqueue(poetrist8);

            Poetrist poetrist9 = new Poetrist("William", "Shakespeare", "İngiliz");
            poetrist9.AddPoetry(new Poetry("Sone 22", 1, 14));
            obj.Enqueue(poetrist9);

            Poetrist poetrist10 = new Poetrist("Victor", "Hugo", "Fransız");
            poetrist10.AddPoetry(new Poetry("Aşk Ki Sevgili Kızım...", 1, 12));
            obj.Enqueue(poetrist10);

            DataToJson.ToJson(obj);

            DataFromJson.FromJson();
        }
    }
}
