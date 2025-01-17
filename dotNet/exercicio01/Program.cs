﻿using System;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Calcular a idade da pessoa, lendo uma data fornecida pelo usuário.
            
            // declarar variáveis
            DateTime dataNascimento;
            int idade = 0 ;

            //Primeiro temos que ler a data de nascimento
            Console.WriteLine("Digite uma data de nascimento: ");
            if (DateTime.TryParse(Console.ReadLine(), out dataNascimento))
            {
                idade = DateTime.Today.Year - dataNascimento.Year;
                if (DateTime.Today.DayOfYear < dataNascimento.DayOfYear)
                {
                    --idade;
                }

                Console.WriteLine("-- Idade: " + idade);
            }else
            {
                Console.WriteLine("Formato de data inválido");
            }
        }
        
    }
}
