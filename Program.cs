using osztaly;

Auto kek = new Auto(2020, "Focus", "Ford");
Auto zold = new Auto(1998, "Golf", "Volkswagen");
Auto fekete = new Auto(2010, "Tiguan", "Volkswagen");

List <Auto> garazs = new List<Auto> { kek, zold, fekete};
foreach (Auto seged in garazs)
{
    seged.KiirAdatok();
}

//átlag
double atlag = garazs.Average(x => x.GyartasiEv);
Console.WriteLine($"Átlag gyártási év: {atlag}");
//Console.WriteLine($"Legfiatalabb autó: {garazs.Max(g => g.GyartasiEv)}");