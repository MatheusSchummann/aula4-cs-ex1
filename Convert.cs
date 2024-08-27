using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula4_cs_ex1
{
    public class Convert
    {
        public List<int> conversor(List<string> listaS)
        {
            List<int> listaA = new List<int>();
            listaA = listaS.ConvertAll(int.Parse);
            return listaA;
        }
        public List<int> logica(List<int> listaA)
        {
            listaA.Sort();
            return listaA;
        }
    }
}
