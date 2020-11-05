using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JogoVelhaDTO;
using System.Data;
using System.Threading;
namespace JogoVelhaBLL
{
   public class BLL
    {
        public void Checar(DTO dto)
        {
            //------------------------------
            //X
            if (dto.Numero1== "M_X" && dto.Numero2== "M_X" && dto.Numero3== "M_X")
            {
                dto.VitoriaX = true;
            }
            if (dto.Numero4 == "M_X" && dto.Numero5 == "M_X" && dto.Numero6 == "M_X")
            {
                dto.VitoriaX = true;
            }
            if (dto.Numero7 == "M_X" && dto.Numero8 == "M_X" && dto.Numero9 == "M_X")
            {
                dto.VitoriaX = true;
            }
            if (dto.Numero1 == "M_X" && dto.Numero4 == "M_X" && dto.Numero7 == "M_X")
            {
                dto.VitoriaX = true;
            }
            if (dto.Numero2 == "M_X" && dto.Numero5 == "M_X" && dto.Numero8 == "M_X")
            {
                dto.VitoriaX = true;
            }
            if (dto.Numero3 == "M_X" && dto.Numero6 == "M_X" && dto.Numero9 == "M_X")
            {
                dto.VitoriaX = true;
            }
            if (dto.Numero1 == "M_X" && dto.Numero5 == "M_X" && dto.Numero9 == "M_X")
            {
                dto.VitoriaX = true;
            }
            if (dto.Numero3 == "M_X" && dto.Numero5 == "M_X" && dto.Numero7 == "M_X")
            {
                dto.VitoriaX = true;
            }
            //------------------------------------------------------------------
            //Circulo
            if (dto.Numero1 == "M_O" && dto.Numero2 == "M_O" && dto.Numero3 == "M_O")
            {
                dto.VitoriaO = true;
            }
            if (dto.Numero4 == "M_O" && dto.Numero5 == "M_O" && dto.Numero6 == "M_O")
            {
                dto.VitoriaO = true;
            }
            if (dto.Numero7 == "M_O" && dto.Numero8 == "M_O" && dto.Numero9 == "M_O")
            {
                dto.VitoriaO = true;
            }
            if (dto.Numero1 == "M_O" && dto.Numero4 == "M_O" && dto.Numero7 == "M_O")
            {
                dto.VitoriaO = true;
            }
            if (dto.Numero2 == "M_O" && dto.Numero5 == "M_O" && dto.Numero8 == "M_O")
            {
                dto.VitoriaO = true;
            }
            if (dto.Numero3 == "M_O" && dto.Numero6 == "M_O" && dto.Numero9 == "M_O")
            {
                dto.VitoriaO = true;
            }
            if (dto.Numero1 == "M_O" && dto.Numero5 == "M_O" && dto.Numero9 == "M_O")
            {
                dto.VitoriaO = true;
            }
            if (dto.Numero3 == "M_O" && dto.Numero5 == "M_O" && dto.Numero7 == "M_O")
            {
                dto.VitoriaO = true;
            }

        }

        
    }
}
