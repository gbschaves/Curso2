// See https://aka.ms/new-console-template for more information
// using System.Collections;

// Console.WriteLine("Primeiro programa");

// int idade = 23;
// Console.WriteLine(idade);
// string nomePessoa = "Rafael Almeida";
// Console.WriteLine(nomePessoa);
// decimal valor = 200.99m;
// double valorDouble = 200.99;
// float valorFloat = 200.99f;
// Console.WriteLine(valor);
// Console.WriteLine(valorDouble);
// Console.WriteLine(valorFloat);
// var idadeNova = 34;
// char flag = 'Y';
// Console.WriteLine(flag);
// bool ativo = true;
// Console.WriteLine(ativo);

// const string descricao = "CursoCSHARP";
// descricao = "Curso";

// Console.WriteLine(descricao);

// int numero1 = 1;
// var numero2 = 2;

// int soma = numero1 + numero2;

// Console.WriteLine(soma);

// int subtracao = numero2 - numero1;
// Console.WriteLine(subtracao);

// int multiplicacao = (numero2 * numero1) * 10;
// Console.WriteLine(multiplicacao);

// int divisao = numero2 / numero1;
// Console.WriteLine(divisao);

// bool igual = numero1 == numero2;
// Console.WriteLine(igual);

// bool menor = numero2 < numero1;
// Console.WriteLine(menor);

// bool menorOuIgual = numero2 <= numero1;
// Console.WriteLine(menorOuIgual);

// bool maiorOuIgual = numero2 >= numero1;
// Console.WriteLine(maiorOuIgual);

// bool diferente = numero2 != numero1;
// Console.WriteLine(diferente);


// bool valido = numero2 > numero1 && 6 > 7;
// Console.WriteLine(valido);

// bool valido2 = numero2 > 10 || 6 > 7;
// Console.WriteLine(valido2);

// bool valido3 = !(numero2 > 3);
// Console.WriteLine(valido3);

// bool ativo = false;
// string status = ativo ? "Cadastro Ativo" : "Cadastro inativo";
// Console.WriteLine(status);

// void EscreverNome()
// {
//   var nome = NomeCompleto();
//   var soma = SomaValores();

//   Console.WriteLine(nome);
//   Console.WriteLine(soma)
// }

// string NomeCompleto()
// {
//   string primeiroNome = "Rafael";
//   string segundoNome = "Almeida";

//   return primeiroNome + "" + segundoNome;
// }


// var soma = SomaValores(3, 2);

// Console.WriteLine(soma);

// int SomaValores()
// {
//   return 8 + 2;
// }

// var soma = SomaValores(3, 5);
// Console.WriteLine(soma);

// var nome = NomeEIdade("Rafael", 33);
// Console.WriteLine(nome);

// int SomaValores(int a, int b)
// {
//   return a + b;
// }

// string NomeEIdade(string nome, int idade)
// {
//   return "Meu nome é " + nome + " e tenho " + idade + " anos";
// }

// var arrayList = new ArrayList();

// arrayList.Add(1);
// arrayList.Add("Rafael");
// arrayList.Add(true);

// Console.WriteLine(arrayList[1]);

// arrayList.RemoveAt(1);
// arrayList.Clear();

// foreach(var item in arrayList)
// {
//   Console.WriteLine(item);
// }


// var arrayTipadoNumero = new int[3] { 1, 2, 3 };

// var arrayTipadoNumero = new int [3];

// arrayTipadoNumero[0] = 5;
// arrayTipadoNumero[1] = 5;
// arrayTipadoNumero[2] = 10;

// Array.Resize(ref arrayTipadoNumero, 100);

// arrayTipadoNumero[10] = 100;

// foreach (var item in arrayTipadoNumero)
// {
//   Console.WriteLine(item);
// }

// var arrayTipadoString = new string[2] {"Rafael", "Almeida"};

// var arrayTipadoString = new string[2];

// arrayTipadoString[0] = "Rafael";
// arrayTipadoString[1] = "Almeida";

// foreach (var item in arrayTipadoString)
// {
//   Console.WriteLine(item);
// }

// var lista = new List<string>(10)
// {
//   "Rafael",
//   "Almeida",
// };

// lista.Add("Rafael");
// lista.Add("Almeida");
// lista.Add("Curso");

// var nome = lista[0];
// Console.WriteLine(nome);

// lista.RemoveAt(1);

// foreach (var item in lista)
// {
//   Console.WriteLine(item);
// }

// var dicionario = new Dictionary<string, string>()
// {
//   {"5", "Teste"},
//   {"teste 6", "Teste 6"},
// };

// dicionario.Add("nome", "Rafael");

// dicionario["curso"] = "Curso";

// var nome = dicionario["curso"];

// Console.WriteLine(nome);

// foreach (var item in dicionario)
// {
//   Console.WriteLine(item);
// }


// var queue = new Queue<string>();
// {
//   queue.Enqueue("Rafael");
//   queue.Enqueue("Almeida");
// }

// var nome = queue.Peek();
// var nome1 = queue.Peek();

// var nome = queue.Dequeue();
// var nome1 = queue.Dequeue();

// Console.WriteLine(nome);
// Console.WriteLine(nome1);

// foreach (var item in queue)
// {
//   Console.WriteLine(item);
// }

// var stack = new Stack<string>();

// stack.Push("Rafael");
// stack.Push("Almeida");

// var nome = stack.Pop();
// var nome1 = stack.Pop();

// Console.WriteLine(nome);
// Console.WriteLine(nome1);


// foreach (var item in stack)
// {
//   Console.WriteLine(item);
// }


// var diaDaSemana = 0;
// if(diaDaSemana == 0)
// {
//   Console.WriteLine("Hoje é domingo");
// }
// else if(diaDaSemana == 1)
// {
//   Console.WriteLine("Hoje é segunda");
// }else if(diaDaSemana == 2)
// {
//   Console.WriteLine("Hoje é terça");
// }else if(diaDaSemana == 3)
// {
//   Console.WriteLine("Hoje é quarta");
// }else if(diaDaSemana == 4)
// {
//   Console.WriteLine("Hoje é quinta");
// }else
// {
//   Console.WriteLine("Dia da semana inválido");
// }

// var diaDaSemana = 0;
// switch(diaDaSemana)
// {
//   case 0:
//   {
//     Console.WriteLine("Teste1");
//     break;
//   }  case 1:
//   {
//     Console.WriteLine("Teste2");
//     break;
//   }  case 2:
//   {
//     Console.WriteLine("Teste3");
//     break;
//   }  default:
//   {
//     Console.WriteLine("Teste4");
//     break;
//   }
// }

// var diaDaSemana = 0;
// switch(diaDaSemana < 1)
// {
//   case true:
//   Console.WriteLine("Hoje é sábado");
//   break;
//   case false:
//   Console.WriteLine("Hoje é sábado");
//   break;
// }


// var lista = new List<string>() {"Rafael", "Curso", "Csharp"};
// var count = lista.Count;

// for(var i=0; i < count; i++)
// {
//   var nome = lista[i];
//   Console.WriteLine(nome);
// }

// var lista = new List<string>() {"Rafael", "Curso", "Csharp"};

// foreach(string item in lista)
// {
//   Console.WriteLine(item);

// }

// foreach(var letra in "Rafael Almeida")
// {
//   Console.WriteLine(letra)
// }

// var i = 0;

// while(i < 2)
// {
//   Console.WriteLine("var i = " + i);
//   //i += 1;
//   i++;
// }

// var j = 3;

// do 
// {
//   Console.WriteLine("var j = " + j);
//   j++;
// }while(j<2);


// var i = 0;

// while (i < 5)
// {
//   Console.WriteLine("var i = " + i);
  
//   if (i < 2)
//   {
//     Console.WriteLine("Continuando");
//     i++;
//     continue;
//   }
//   i++;
//   if (i == 2)
//   {
//     Console.WriteLine("Valor de i é igual a 2(dois)");
//     break;
//   }

// }