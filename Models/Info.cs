public static class Info 
{
private static List<Pais> ListaPaises = new List<Pais>();
private static void IniciarLista() {
ListaPaises.Add(new Pais("Sudán del Sur", "bandera_sudanDelSur.png", 10750000, new DateTime(2011,7,9), "Nilo blanco, Bandiglio national park"));
ListaPaises.Add(new Pais("Kiribati", "bandera_Kiribati.png", 128800, new DateTime(1979,7,12), "Makin, Aranuka, Isla FLint, Isla Vostok"));
ListaPaises.Add(new Pais("Tuvalu", "bandera_Tuvalu.png", 11200, new DateTime(1978,10,1), "Fongafale, David's Drill, Funafala"));
ListaPaises.Add(new Pais("Somalia", "bandera_Somalia.png", 17000000, new DateTime(1960,7,1), "Laas Geel, Masjidka Isbahaysiga, Mogadiscio, Bosaso"));
ListaPaises.Add(new Pais("Nauru", "bandera_Nauru.png", 12500, new DateTime(1968,1,31), "Bahía de Anibare, Laguna de Buada, Moqua Well"));
}

public static List<Pais> ListarPaises() {
    if (ListaPaises.Count() == 0) 
    ListarPaises();
    return ListaPaises;
}

public static Pais DetallePais(string nombrePais) {
    foreach (Pais paisRecorrido in ListaPaises)
    {
        if (paisRecorrido.Nombre == nombrePais) {
            return paisRecorrido;
        }
    }
    return new Pais("","",0,new DateTime(1,1,1),"");
}

}