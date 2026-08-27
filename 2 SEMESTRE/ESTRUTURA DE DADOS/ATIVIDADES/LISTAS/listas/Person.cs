// AQUI CRIAMOS UMA CLASSE DE TIPO DE DADO ABSTRATO
// 

public class Person
{

    public string Name { get; set; }
    public int Age { get; set; }
    public CountryEnum Nationality { get; set; }

}

// ENUM = ENUMERADOR
// DIFERE DE CLASSE, É UMA LISTA DE VALORES

public enum CountryEnum
{
    BR,
    US, 
    AR,
    PY
}