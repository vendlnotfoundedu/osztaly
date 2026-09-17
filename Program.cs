using osztaly;

Auto kek = new Auto(2020, "Focus", "Ford");
Auto zold = new Auto(3100, "Golf", "Volkswagen");
Auto fekete = new Auto(2010, "Tiguan", "Volkswagen");

List <Auto> garazs = new List<Auto> { kek, zold, fekete};
foreach (Auto seged in garazs)
{
    seged.KiirAdatok();
}