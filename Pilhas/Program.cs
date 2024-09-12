/* Basicamente as pilhas trabalham com uma estrutura LIFO -> Last In First Out
Três métodos Importantes:
Push() -> Insere um elemento no topo da pilha
Pop() -> Insere um elemento do topo e o retorna
Peek() -> Retorna o elemento do topo sem removêlo

Invertendo as bolas
*/
Stack<char> caracteres = new Stack<char>();
foreach (char c in "DARCY DA MONTANHA")
{
    caracteres.Push(c); 
}

//DESEMPILHANDO
string Invertido = string.Empty;
while(caracteres.Count > 0)
{
    Invertido += caracteres.Pop();
}

Console.WriteLine(Invertido);