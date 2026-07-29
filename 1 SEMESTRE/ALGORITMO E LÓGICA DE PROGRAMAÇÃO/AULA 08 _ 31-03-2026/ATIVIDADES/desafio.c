// Uma empresa de fornecimento de energia elétrica realiza a leitura mensal 
// dos medidores de consumo de seus clientes.

// Para cada consumidor, devem ser informados os seguintes dados:
//  Número do consumidor
//  Quantidade de kWh consumidos durante o mês
//  Tipo (código) do consumidor:
//  1 – Residencial (R$ 0,30 por kWh)
//  2 – Comercial   (R$ 0,50 por kWh)
//  3 – Industrial  (R$ 0,70 por kWh)

// A leitura dos dados deve continuar até que seja informado um consumidor 
// com número 0 (zero), que indica o fim da entrada de dados.

// O programa deve calcular e exibir:
// O custo total de energia para cada consumidor
// O total de consumo (kWh) para cada tipo de consumidor
// A média de consumo dos consumidores dos tipos 1 (residencial) e 2 (comercial)


#include <stdio.h>

int main()
{
    int numero, tipo;
    float consumo, custo;

    float total_residencial = 0;
    float total_comercial = 0;
    float total_industrial = 0;

    float soma_tipo1 = 0, soma_tipo2 = 0;
    int cont_tipo1 = 0, cont_tipo2 = 0;

    char op = 'S';

    printf("=========================================\n");
    printf("===== CONTROLE DE CONSUMO DE ENERGIA =====\n");
    printf("=========================================\n\n");

    do
    {
        printf("DIGITE O NUMERO DO CONSUMIDOR (0 PARA SAIR): ");
        scanf("%d", &numero);

        if (numero == 0)
        {
            printf("PROGRAMA FINALIZADO !!!");
            break;
        }

        printf("DIGITE A QUANTIDADE DE kWh CONSUMIDOS: ");
        scanf("%f", &consumo);

        printf("DIGITE O TIPO DO CONSUMIDOR (1-RES, 2-COM, 3-IND): ");
        scanf("%d", &tipo);

        if (tipo == 1)
        {
            custo = consumo * 0.3;
            total_residencial += consumo;

            soma_tipo1 += consumo;
            cont_tipo1++;
        }
        else if (tipo == 2)
        {
            custo = consumo * 0.5;
            total_comercial += consumo;

            soma_tipo2 += consumo;
            cont_tipo2++;
        }
        else if (tipo == 3)
        {
            custo = consumo * 0.7;
            total_industrial += consumo;
        }
        else
        {
            printf("TIPO INVALIDO!\n");
            continue;
        }

        printf("CUSTO TOTAL DO CONSUMIDOR: R$ %.2f\n", custo);

        printf("DESEJA CONTINUAR? (S/N) \n: ");
        scanf(" %c", &op);

    } while (op != 'N');

    printf("=========================================\n");
    printf("=========== RESULTADOS FINAIS ===========\n");
    printf("=========================================\n");

    printf("TOTAL DE CONSUMO RESIDENCIAL: %.2f kWh\n", total_residencial);
    printf("TOTAL DE CONSUMO COMERCIAL: %.2f kWh\n", total_comercial);
    printf("TOTAL DE CONSUMO INDUSTRIAL: %.2f kWh\n", total_industrial);

    if (cont_tipo1 > 0)
    {
        printf("MEDIA DE CONSUMO RESIDENCIAL: %.2f kWh\n", soma_tipo1 / cont_tipo1);
    }

    if (cont_tipo2 > 0)
    {
        printf("MEDIA DE CONSUMO COMERCIAL: %.2f kWh\n", soma_tipo2 / cont_tipo2);
    }

    return 0;
}