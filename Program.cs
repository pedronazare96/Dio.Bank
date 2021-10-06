using System;

namespace Dio.Bank
{
    class Program
    {
        static list<Conta> listContas = new list<Conta>();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                    opcaoUsuario = ObterOpcaoUsuario();
                {
                    Console.WriteLine("Obrigado por utilizar nossos serviços.");
                    Console.ReadLine();                   
                }
                
                private static void Transferir()
                {
                    Console.Write("Digite o número da conta de origem: ");
                    int indiceContaOrigem = int.Perse(Console.ReadLine());

                    Console.Write("Digite o numero da conta de destino: ");
                    int indiceContDestino = double.Parce(Console.ReadLine());

                    Console.WriteLine("Digite o valor a ser transferido: ");
                    double valorTransferencial = double.Parse(Console.ReadLine());

                    listContas[indiceContaOrigem].Transferir(valorTransferencial, listContas[indiceContDestino]);
                }

                private static void Sacar()
                {
                    Console.Write("Digite o número da conta: ");
                    int indiceConta = int.Perse(Console.ReadLine());

                    Console.Write("Digite o valor a ser sacado: ");
                    int valorSaque = double.Parce(Console.ReadLine());

                    listContas[indiceConta].Sacar(valorSaque);
                }
                private static void Depositar()
                {
                   Console.Write("Digite o número da conta: ");
                    int indiceConta = int.Perse(Console.ReadLine());

                    Console.Write("Digite o valor a ser depositado: ");
                    int valorDeposito = double.Parce(Console.ReadLine());

                    listContas[indiceConta].Depositar(valorDeposito);
                
                }
                private static void InserirConta()
                {
                    Console.WriteLine("Inserir nova conta");
                    Console.WriteLine("Digite 1 para Conta Física ou 2 para Juridica: ");
                    int entradaTipoConta = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o Nome do Cliente: ");
                    string entradaNome = Console.ReadLine();

                    Console.WriteLine("Digita o saldo inicial: ");
                    double entradaSaldo = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digita o crédito: ");
                    double entradaCredito = double.Parse(Console.ReadLine());

                    Conta novaConta = new Conta (tipoConta:(TipoConta)entradaTipoConta,
                                                 saldo: entradaSaldo,
                                                 credito: entradaCredito,
                                                 nome: entradaNome);
                    listars.Add(novaConta);
                
                }

                private static void ListarContas()
                {
                    Console.WriteLine("Listar Contas");
                    if(listContas.Count ==0)
                    {
                        Console.WriteLine("Nenhuma conta cadastrada.");
                        return;
                    }
                    for (int i = 0; i< listContas.Count; i++)
                    {
                        Conta conta = listContas[i];
                        Console.WriteLine("#{0} - ", i );
                        Console.WriteLine(conta);
                    }
                }
        
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Bank a seu dispor! ");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar contas");
            Console.WriteLine("2-Inserir nova conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4- Sacar");
            Console.WriteLine("5- Depositar");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("x-Sair");

            string opcaoUsuario = Conta.ReadLine().ToString();
            Console.WriteLine();
            retorno opcaoUsuario;

        }
    }
}
