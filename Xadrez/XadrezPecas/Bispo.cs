using Tabuleiro;

namespace XadrezPecas
{
    public class Bispo : Peca 
    {
           public Bispo(Cor cor, TabuleiroJ tab) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            if (Cor == Cor.Branca)
            return " ♗ ";
            else
            return " ♝ ";
        }
    }
}