List<string> produtosPrincipal = new List<string> { "Mouse", "Teclado", "Monitor", "Joystick"};
List<string> produtosSecundaria = new List<string> { "Headset", "Webcam", "Smartphone", "Mousepad" };


produtosPrincipal.AddRange(produtosSecundaria);

Console.WriteLine("Lista consolidada:");
foreach (string produto in produtosPrincipal)
{
    Console.WriteLine(produto);
}