using Tabuleiro;
namespace XadrezPecas
{
    public class Rainha : Peca
    {
           public Rainha(Cor cor, TabuleiroJ tab) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            if (Cor == Cor.Branca)
            return " ♕ ";
            else
            return " ♛ ";
        }
    }
}