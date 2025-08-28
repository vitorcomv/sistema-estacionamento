namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Pede ao usuário para digitar a placa do veículo
            Console.WriteLine("Digite a placa do veículo para estacionar: ");

            // Lê a placa digitada e guarda na variável "placaDigitada"
            string placaDigitada = Console.ReadLine().ToUpper();

            // Adiciona a placa digitada na lista "veiculos"
            veiculos.Add(placaDigitada);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover: ");

            // Lê a placa digitada e guarda na variável "placa"
            string placa = Console.ReadLine().ToUpper();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");

                // Declara as variavéis e seus valores
                int horas = 0;
                decimal valorTotal = 0;

                if ( !int.TryParse(Console.ReadLine(), out horas) )
                {
                    Console.WriteLine("Valor inválido. Por favor, digite apenas números.");

                    return;
                }

                // Converte string para int e lê o que foi digitado

                // Formúla para calcular o valor total
                valorTotal = (precoInicial + precoPorHora * horas);

                // Remove a placa digitada
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                // Loop que percorre todas as placas registradas    
                foreach (string contadorVeiculos in veiculos)
                {
                    Console.WriteLine($"{contadorVeiculos}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}