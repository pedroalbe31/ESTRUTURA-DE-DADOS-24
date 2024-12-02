using System;
using System.Collections.Generic;

class Documento
{
    public string Texto { get; set; }
}

class Navegador
{
    public static void Main()
    {
        // Definindo as páginas com conteúdo diferente
        Documento pagina1 = new Documento() { Texto = "Conteúdo da página 1" };
        Documento pagina2 = new Documento() { Texto = "Conteúdo da página 2" };
        Documento pagina3 = new Documento() { Texto = "Conteúdo da página 3" };
        Documento pagina4 = new Documento() { Texto = "Conteúdo da página 4" };
        Documento pagina5 = new Documento() { Texto = "Conteúdo da página 5" };
        Documento pagina6 = new Documento() { Texto = "Conteúdo da página 6" };

        // Criando a lista encadeada para as páginas
        LinkedList<Documento> documentoList = new LinkedList<Documento>();
        documentoList.AddLast(pagina2);
        LinkedListNode<Documento> noPagina4 = documentoList.AddLast(pagina4);
        documentoList.AddLast(pagina6);
        documentoList.AddFirst(pagina1);
        documentoList.AddBefore(noPagina4, pagina3);
        documentoList.AddAfter(noPagina4, pagina5);

        // Navegação pelas páginas
        LinkedListNode<Documento> paginaAtual = documentoList.First;
        int indicePagina = 1;

        while (paginaAtual != null)
        {
            Console.Clear();
            string indicePaginaStr = $"Página {indicePagina}";
            int espaços = (90 - indicePaginaStr.Length) / 2;
            Console.WriteLine(indicePaginaStr.PadLeft(espaços + indicePaginaStr.Length));
            Console.WriteLine();

            // Exibindo o conteúdo da página
            string conteudoPagina = paginaAtual.Value.Texto;
            for (int i = 0; i < conteudoPagina.Length; i += 90)
            {
                string linha = conteudoPagina.Substring(i, Math.Min(90, conteudoPagina.Length - i));
                Console.WriteLine(linha);
            }

            Console.WriteLine();
            Console.WriteLine("Navegação");
            Console.WriteLine();
            Console.Write(paginaAtual.Previous != null ? "< ANTERIOR [P]" : " ".PadLeft(14));
            Console.Write(paginaAtual.Next != null ? "[PRÓXIMO] [N] >".PadLeft(76) : string.Empty);
            Console.WriteLine();

            // Lendo o comando do usuário
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.N:
                    if (paginaAtual.Next != null)
                    {
                        paginaAtual = paginaAtual.Next;
                        indicePagina++;
                    }
                    break;
                case ConsoleKey.P:
                    if (paginaAtual.Previous != null)
                    {
                        paginaAtual = paginaAtual.Previous;
                        indicePagina--;
                    }
                    break;
                default:
                    return;
            }
        }
    }
}