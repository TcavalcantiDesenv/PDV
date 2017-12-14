using System;

namespace MGMPDV
{
    class MGM
    {
        public decimal[] valorParcelamento{get; set;}
        public MGM()
        { }

        public decimal[] gerarParcelamento(int nparcelas, decimal total)
        {
            decimal totalaux = total;
            decimal resto = 0;
            int parcelaaux = 0;
            valorParcelamento = new decimal[nparcelas];

            for (int i = 1; i <= nparcelas; i++)
            {
                if (nparcelas > 1)
                {
                    if (i == nparcelas)
                    {
                        parcelaaux = nparcelas - 1;
                        resto = totalaux * parcelaaux;
                        totalaux = total - resto;
                    }
                    else
                        totalaux = Decimal.Round(total / nparcelas, 2);
                }

                valorParcelamento[i-1] = totalaux;
            }

            return valorParcelamento;
        }

        public bool isInt(string inteiro, bool aceitanegativo, out int valor)
        {
            bool ok = false;
            int aux = 0;
            if (aceitanegativo)
            {
                try
                {
                    aux = int.Parse(inteiro);
                    ok = true;
                }
                catch { }
            }
            else
            {
                try
                {
                    aux = int.Parse(inteiro);
                    if (aux >= 0)
                    {
                        ok = true;
                    }
                }
                catch { }
            }
            valor = aux;
            return ok;
        }

        public bool isDouble(string numeroDouble, bool aceitanegativo, out double valor)
        {
            bool ok = false;
            double aux = 0;
            if (aceitanegativo)
            {
                try
                {
                    aux = double.Parse(numeroDouble);
                    ok = true;
                }
                catch { }
            }
            else
            {
                try
                {
                    aux = double.Parse(numeroDouble);
                    if (aux >= 0)
                    {
                        ok = true;
                    }
                }
                catch { }
            }
            valor = aux;
            return ok;
        }

        public bool isDecimal(string numeroDecimal, bool aceitanegativo, out decimal valor)
        {
            bool ok = false;
            decimal aux = 0;
            if (aceitanegativo)
            {
                try
                {
                    aux = decimal.Parse(numeroDecimal);
                    ok = true;
                }
                catch { }
            }
            else
            {
                try
                {
                    aux = decimal.Parse(numeroDecimal);
                    if (aux >= 0)
                    {
                        ok = true;
                    }
                }
                catch { }
            }
            valor = aux;
            return ok;
        }

        public bool isFloat(string numeroFloat, bool aceitanegativo, out float valor)
        {
            bool ok = false;
            float aux = 0;
            if (aceitanegativo)
            {
                try
                {
                    aux = float.Parse(numeroFloat);
                    ok = true;
                }
                catch { }
            }
            else
            {
                try
                {
                    aux = float.Parse(numeroFloat);
                    if (aux >= 0)
                    {
                        ok = true;
                    }
                }
                catch { }
            }
            valor = aux;
            return ok;
        }

        public bool isData(string datadeentrada, out DateTime data)
        {
            bool ok = false;
            DateTime aux = DateTime.Now;

            try
            {
                aux = Convert.ToDateTime(datadeentrada);
            }
            catch { }
            
            data = aux;
            return ok;
        }

        public string justificartexto(string texto,int tamanho_do_espaco)
        {
            double qtdeespaco = 0;
            try
            {
               qtdeespaco = tamanho_do_espaco-texto.Length;
            }
            catch { texto = ""; }
            qtdeespaco = tamanho_do_espaco-texto.Length;

            if (qtdeespaco<2)
            {
                return texto;
            }
            double espacoinicial = Math.Truncate(qtdeespaco / 2);
            double espacofinal = qtdeespaco - espacoinicial;

            for (int i = 0; i < espacoinicial; i++)
            {
                texto = " " + texto;
            }

            for (int i = 0; i < espacofinal; i++)
            {
                texto = texto + " ";
            }

            return texto;
        }

        public string formatartamanho(string texto, int tamanho_do_espaco)
        {
            int espacofinal = 0;
            try
            {
                if  (texto.Length<tamanho_do_espaco)
                {
                }
            }catch{ texto="";}

            if (texto.Length < tamanho_do_espaco)
            {
                espacofinal = tamanho_do_espaco - texto.Length;
                for (int i = 0; i < espacofinal; i++)
                {
                    texto = texto + " ";
                }
                return texto;
            }
            else
                return texto.Substring(0,tamanho_do_espaco-1);
        }

    }
}
