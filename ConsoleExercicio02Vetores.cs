//Faça um algoritmo que leia 10 salários. Depois de lidos e armazenados, mostre o maior valor. Utilize vetores.

double[] salarios = new double[10];
double maiorSalario;
for (int i = 0;i < salarios.Length; i++) // inicia na posição 0 e termina da ultima posição de salarios
{
    Console.WriteLine($"Entre com o valor do {i+1}º salário:");
    salarios[i] = Convert.ToDouble(Console.ReadLine());
}
maiorSalario = salarios[0];
for (int i = 0; i < salarios.Length; i++)
{
    if (salarios[i] > maiorSalario)
    {
        maiorSalario = salarios[i];
    }
}
Console.WriteLine($"O maior salário digitado é {maiorSalario}.");