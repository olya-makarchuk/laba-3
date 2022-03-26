string plus = null;
var list = new List<string>() { "Меркурiй", "Венера", "Земля", "Марс", "Юпiтер", "Сатурн", "Уран", "Нептун" };
laba_3_1.Planet planet = new laba_3_1.Planet(list);

laba_3_1.Star star = new laba_3_1.Star() { Name = "Сонце" };

laba_3_1.Satellite satellite = new laba_3_1.Satellite() { Name = "Мiсяць" };
laba_3_1.Satellite satellite1 = new laba_3_1.Satellite() { Name = "Мiсяць" };

Console.WriteLine(Object.Equals(satellite, satellite1));

do
{
    Console.WriteLine(satellite.ToString());
    Console.WriteLine(star.ToString());

    Console.WriteLine($"\n {planet.ToString()}");
    planet.Print();
    Console.WriteLine("\n Якщо хочете добавити планету, напишiть \"+\"");
    plus = Console.ReadLine();
    if (plus == "+")
    {
        Console.Clear();
        Console.WriteLine("Добавте планету:");
        planet.Plus_planet();
        Console.Clear();
    }
} while (plus == "+");
