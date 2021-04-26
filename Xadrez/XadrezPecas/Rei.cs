using Tabuleiro;
namespace XadrezPecas
{
    public class Rei : Peca
    {
        public Rei(Cor cor, TabuleiroJ tab) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            if (Cor == Cor.Branca)
            return " ♔ ";
            else
            return " ♚ ";
        }
    }
}