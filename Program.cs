Console.Clear();
Console.WriteLine("--- Groot Chatbot ---");
string pergunta = "";
while (true)
{
    Console.Write("Pergunta: ");
    pergunta = Console.ReadLine();
    if (pergunta == "Tchau")
    {
        Console.WriteLine("                          Resposta: Eu sou Groot!");        
        break;
    }
    Console.WriteLine("                          Resposta: Eu sou Groot.");
}
