using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoVelhaDTO
{
    public class DTO
    {
        private string numero1;
        private string numero2;
        private string numero3;
        private string numero4;
        private string numero5;
        private string numero6;
        private string numero7;
        private string numero8;
        private string numero9;
        private bool vitoriaX;
        private bool vitoriaO;
        private bool velha;
        private bool vez;
        



        
        public bool VitoriaX { get => vitoriaX; set => vitoriaX = value; }
        public bool VitoriaO { get => vitoriaO; set => vitoriaO = value; }
        public bool Vez { get => vez; set => vez = value; }
        public string Numero1 { get => numero1; set => numero1 = value; }
        public string Numero2 { get => numero2; set => numero2 = value; }
        public string Numero3 { get => numero3; set => numero3 = value; }
        public string Numero4 { get => numero4; set => numero4 = value; }
        public string Numero5 { get => numero5; set => numero5 = value; }
        public string Numero6 { get => numero6; set => numero6 = value; }
        public string Numero8 { get => numero8; set => numero8 = value; }
        public string Numero7 { get => numero7; set => numero7 = value; }
        public string Numero9 { get => numero9; set => numero9 = value; }
        public bool Velha { get => velha; set => velha = value; }
    }
}
