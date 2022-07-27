// ENTRADA DE DADOS

Console.WriteLine("Boas vindas ao programa 'Calcula Lâmpada'!");
Console.WriteLine("Informe o nome do còmodo: ");
string roomName = Console.ReadLine();

Console.WriteLine("Informe em metros a largura deste cômodo: ");
decimal width = decimal.Parse(Console.ReadLine());

Console.WriteLine("Informe em metros o comprimento deste cômodo: ");
decimal length = decimal.Parse(Console.ReadLine());

Console.WriteLine("Informe a potência em watts da lâmpada que será utilizada: ");
int power = int.Parse(Console.ReadLine());


Console.WriteLine("Os dados informados são: Nome do comodo -> " + roomName +
" Largura: " + width +
" Comprimento: " + length +
" Potência: " + power);

// PROCESSAMENTO

decimal squareMeter = width * length;
decimal quotientX = power / 18M;
decimal totalLightBulbs = squareMeter / quotientX;

// SAIDA DE DADOS
Console.WriteLine("Para iluminar o cõmodo: " + roomName +
" com " + squareMeter.ToString("N2") +
" metros quadrados " +
"será necessario a instalação de "
+ totalLightBulbs.ToString("N2") + " lâmpada(s)");
