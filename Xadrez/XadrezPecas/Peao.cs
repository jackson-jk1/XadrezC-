using Tabuleiro;

namespace XadrezPecas
{
    public class Peao : Peca

    {
         public Peao(Cor cor, TabuleiroJ tab) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            if (Cor == Cor.Branca)
            return " ♟";
            else
            return " ♙ ";
        }
    }
}