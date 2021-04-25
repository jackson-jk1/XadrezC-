using Tabuleiro;
namespace XadrezPecas
{
    public class Torre : Peca
    {
        public Torre(Cor cor, TabuleiroJ tab) : base(cor,tab)
        {
        }

        public override string ToString()
        {
            if (Cor == Cor.Branca)
            return "♖";
            else
            return "♜";
        }
    }
}