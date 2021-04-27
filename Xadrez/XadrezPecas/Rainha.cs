using Tabuleiro;
namespace XadrezPecas
{
    public class Rainha : Peca
    {
           public Rainha(Cor cor, TabuleiroJ tab) : base(cor, tab)
        {
        }

        public override bool[,] movimentosPossiveis()
        {
            throw new System.NotImplementedException();
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