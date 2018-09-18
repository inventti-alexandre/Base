using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParafusoSolto.Frei.Bruno.Validacoes
{
    class ValidarCNPJ
    {
        public bool VerificarCNPJ(string CNPJ)
        {
            if (CNPJ.Length != 18)
                throw new ArgumentException("CNPJ inválido!");

            int a, b, c, d, e, f, g, h, i, j, k, l, X, Y, r1, r2 = 0;

            a = Convert.ToInt32(CNPJ.Substring(0, 1));
            b = Convert.ToInt32(CNPJ.Substring(1, 1));
            c = Convert.ToInt32(CNPJ.Substring(3, 1));
            d = Convert.ToInt32(CNPJ.Substring(4, 1));
            e = Convert.ToInt32(CNPJ.Substring(5, 1));
            f = Convert.ToInt32(CNPJ.Substring(7, 1));
            g = Convert.ToInt32(CNPJ.Substring(8, 1));
            h = Convert.ToInt32(CNPJ.Substring(9, 1));
            i = Convert.ToInt32(CNPJ.Substring(11, 1));
            j = Convert.ToInt32(CNPJ.Substring(12, 1));
            k = Convert.ToInt32(CNPJ.Substring(13, 1));
            l = Convert.ToInt32(CNPJ.Substring(14, 1));
            X = Convert.ToInt32(CNPJ.Substring(16, 1));
            Y = Convert.ToInt32(CNPJ.Substring(17, 1));

            r1 = (a * 5 + b * 4 + c * 3 + d * 2 + e * 9 + f * 8 + g * 7 + h * 6 + i * 5 + j * 4 + k * 3 + l * 2) % 11;

            if (r1 < 2)
            {
                if (X != 0)
                    throw new ArgumentException("CNPJ Inválido");
            }
            else if (r1 > 2)
            {
                if (11 - r1 != X)
                    throw new ArgumentException("CNPJ Inválido");
            }

            r2 = (a * 6 + b * 5 + c * 4 + d * 3 + e * 2 + f * 9 + g * 8 + h * 7 + i * 6 + j * 5 + k * 4 + l * 3 + X * 2) % 11;

            if (r2 < 2)
            {
                if (Y != 0)
                    throw new ArgumentException("CNPJ Inválido");
            }
            else if (r2 > 2)
            {
                if (11 - r2 != Y)
                    throw new ArgumentException("CNPJ Inválido");
            }

            return true;
        }
    }
}
