decimal peso;
decimal taraDoPrato = 0.100m;
bool incluiSuco;
int qtdSuco = 0;
decimal totalPagar;
decimal valorKilo = 60;
decimal valorSuco = 7;

Console.Write("Informe o Peso do Prato: ");
peso = Convert.ToDecimal(Console.ReadLine());

Console.Write("Deseja incluir Suco ? 0 = não, 1 = sim ");
incluiSuco = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));

if (incluiSuco == true)
{
    Console.Write("Informe a quantidade de sucos: ");
    qtdSuco = Convert.ToInt32(Console.ReadLine());
}

//calculo
totalPagar = (peso - taraDoPrato) * valorKilo + qtdSuco * valorSuco;

Console.WriteLine("Valor Total: " + totalPagar);