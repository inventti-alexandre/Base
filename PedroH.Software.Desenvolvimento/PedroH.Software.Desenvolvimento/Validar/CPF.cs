using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParafusoSolto.Frei.Bruno.Validacoes
{
    class ValidarCPF
    {
        /// <summary>
        /// Função que verifica se um CPF é válido
        /// </summary>
        /// <param name="dto">CPF vindo da Business com CPF já validado com RegEx</param>
        /// <returns>Retorna True caso o CPF seja válido</returns>
        public bool VerificarCPF(string CPF)
        {
            if (CPF.Contains(" "))
                throw new ArgumentException("Digite um CPF!");

            VerificarCPFP2(CPF);

            int a, b, c, d, e, f, g, h, i, X, Y, r1, r2 = 0;

            a = Convert.ToInt32(CPF.Substring(0, 1));
            b = Convert.ToInt32(CPF.Substring(1, 1));
            c = Convert.ToInt32(CPF.Substring(2, 1));
            d = Convert.ToInt32(CPF.Substring(4, 1));
            e = Convert.ToInt32(CPF.Substring(5, 1));
            f = Convert.ToInt32(CPF.Substring(6, 1));
            g = Convert.ToInt32(CPF.Substring(8, 1));
            h = Convert.ToInt32(CPF.Substring(9, 1));
            i = Convert.ToInt32(CPF.Substring(10, 1));
            X = Convert.ToInt32(CPF.Substring(12, 1));
            Y = Convert.ToInt32(CPF.Substring(13, 1));

            // Verificar primeiro digito
            r1 = (10 * a + 9 * b + 8 * c + 7 * d + 6 * e + 5 * f + 4 * g + 3 * h + 2 * i) % 11;
            if (r1 == 0 || r1 == 1)
            {
                if (X != 0)
                    throw new ArgumentException("CPF Inválido!");
            }
            else if (r1 > 1 && r1 < 11)
            {
                if (X != 11 - r1)
                    throw new ArgumentException("CPF Inválido!");
            }
            else
                throw new ArgumentException("CPF Inválido!");

            // Verificar segundo digito
            r2 = (11 * a + 10 * b + 9 * c + 8 * d + 7 * e + 6 * f + 5 * g + 4 * h + 3 * i + 2 * X) % 11;
            if (r2 == 0 || r2 == 1)
            {
                if (Y != 0)
                    throw new ArgumentException("CPF Inválido!");
            }
            else if (r2 > 1 && r2 < 11)
            {
                if (Y != 11 - r2)
                    throw new ArgumentException("CPF Inválido!");
            }
            else
                throw new ArgumentException("CPF Inválido!");

            return true;
        }

        private void VerificarCPFP2(string CPF)
        {
            int a, b, c, d, e, f, g, h, i, X, Y = 0;

            a = Convert.ToInt32(CPF.Substring(0, 1));
            b = Convert.ToInt32(CPF.Substring(1, 1));
            c = Convert.ToInt32(CPF.Substring(2, 1));
            d = Convert.ToInt32(CPF.Substring(4, 1));
            e = Convert.ToInt32(CPF.Substring(5, 1));
            f = Convert.ToInt32(CPF.Substring(6, 1));
            g = Convert.ToInt32(CPF.Substring(8, 1));
            h = Convert.ToInt32(CPF.Substring(9, 1));
            i = Convert.ToInt32(CPF.Substring(10, 1));
            X = Convert.ToInt32(CPF.Substring(12, 1));
            Y = Convert.ToInt32(CPF.Substring(13, 1));

            if (a == b && b == c && c == d && d == e && e == f && f == g && g == h && h == i && i == X && X == Y)
                throw new ArgumentException("CPF Inválido!");

        }
    }
}
