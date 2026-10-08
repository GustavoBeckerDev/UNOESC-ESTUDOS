using System.Diagnostics.CodeAnalysis;

namespace Consectionary
{
    public class Car
    {
        public string Placa {get; set;}
        public string Marca {get; set;}
        public string Modelo {get; set;}
        public string Nome {get; set;}
        public int Ano {get; set;}
        public float Valor {get; set;}

        public Car (string placa, string marca, string modelo, string nome, int ano, float valor)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Nome = nome;
            Ano = ano;
            Valor = valor;
        }
    };


}


