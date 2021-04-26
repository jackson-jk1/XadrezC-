using System;

namespace Tabuleiro
{
    public class TabuleiroExcepition : Exception  
    {
        public TabuleiroExcepition(string msg) : base(msg){
            
        }
    }
}