string firstName = "Gustavo";
string lastName = "Becker";

string note = firstName.ToUpper() + " " + lastName.ToUpper();

Console.WriteLine(note);

string initials = firstName[0] + " " + lastName[0].ToString();

Console.WriteLine(initials);

// FORMATAÇÃO DE STRINGS

string text = string.Format("{0} {1} nascido em {2}", firstName, lastName, 1998);

Console.WriteLine(text);

// C# É UMA LINGUAGEM DO C++, TOTALMENTE ORIENTADA A OBJETOS
// PORTANTO, TUDO DENTRO DO C É DESCENDENTE DO TIPO OBJECT, ATÉ OS TIPOS PRIMITIVOS

int age = 28;
object ageBoxing = age;

int ageUmboxing = (int)ageBoxing; // CASTING -> CONVERSÃO DE TIPO - OBJECT NAO HERDA DE INT, E SIM INT DE OBJECT

// FAZER ATIVIDADE DO LIVRO QUE O PROFESSOR FALOU:

// PAGINA 14 15 16 17 DO DOCUMENTO #csharp-data-structures-and-algorithms.pdf








