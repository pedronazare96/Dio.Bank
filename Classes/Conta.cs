namespace Dio.Bank
{
    public class Conta
    {
        private TipoConta tipoConta {get; set;}

        private double Saldo {get; set;}

        private double Credito {get;set;}

        private string Nome {get; set;}

        public Conta(tipoConta, double saldo, double credito, string nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo  =saldo;
            this.Credito = credito;
            this.Nome = nome;
        }
        public bool Sacar(double valorSaque)
        {
            if(this.Saldo.valorSaque <(this.Credito*-1))
            {
                Console.WriteLine("Saldo Insuficiente!");
                return false;
            }
            this.Saldo -= valorSaque;

            Console.WriteLine("Slado atual da conta de {0} é {1}", this.Nome, this.Saldo);

            return true;
            }
            public void Depositar(double valorDeposito)
            {
                this.Saldo += valorDeposito;

                Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
            }
            public void Transferir(double valorTransferencial, Conta contaDestino)
            {
                if(this.Sacar(valorTransferencial))
                {
                    contaDestino.Depositar(valorTransferencial);
                }
            }
            public override string ToString()
            {
                string return = "";
                retorno += "TipoConta " + this.TipoConta + " | ";
                retorno += "Nome " + this.Nome + " | ";
                retorno += "Saldo " + this.Saldo + " | ";
                retorno += "Crédito " + this.Credito + " | ";
                return retorno;

            }
        }        
    }
}