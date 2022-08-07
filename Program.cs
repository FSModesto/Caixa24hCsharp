using System;

class Aula12{

        static double valor;
        static char condicao;
    
    static void Main(){

        
        int nota100,nota50,nota20,nota10,nota5,nota2, nota1;

      do{ 

       Console.WriteLine("Seja Bem vindo ao caixa 24h! \nPor favor, Digite o seu valor para saque: ");
       valor=int.Parse(Console.ReadLine());

    if (valor >=100){
        nota100 = (int)valor/100;
        Console.WriteLine("Notas de 100: {0}", nota100);
        valor = valor % 100;
        }

    if (valor >=50){
        nota50 = (int)valor/50;
        Console.WriteLine("Notas de 50: {0}", nota50);
        valor = valor % 50;
        }

    if (valor>=20){
        nota20 = (int)valor/20;
        Console.WriteLine("Notas de 20: {0}", nota20);
        valor = valor % 20;
        }

    if (valor>=10){
        nota10 = (int)valor/10;
        Console.WriteLine("Notas de 10: {0}", nota10);
        valor= valor% 10;
        }

        if(valor>=5){
        nota5= (int)valor/5;
        Console.WriteLine("Notas de 5: {0}", nota5);
        valor = valor%5;
        }
        if(valor>=2){
        nota2 = (int)valor/2;
        Console.WriteLine("Notas de 2: {0}", nota2);
        valor= valor%2;
        }
        if(valor>=1){
        nota1 = (int)valor/1;
        Console.WriteLine("Notas de 1: {0}", nota1);
        }

            Console.WriteLine("Deseja fazer uma nova operação? (S/N)");
            condicao = char.Parse(Console.ReadLine());

        }    while(condicao == 's');


            Console.WriteLine("Obrigado e volte sempre!");
    }

}
