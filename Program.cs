Console.Clear();
string pergunta = "";
bool respostaEhTchau = false;
Console.WriteLine("--- Groot Chatbot ---");
while (!respostaEhTchau)
{
    Console.Write("Pergunta: ");
    pergunta = Console.ReadLine();
    respostaEhTchau = pergunta == "Tchau";
    Console.WriteLine($"                          Resposta: Eu sou Groot{(respostaEhTchau ? "!" : ".")}");
}
