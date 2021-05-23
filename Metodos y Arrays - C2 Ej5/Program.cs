using System;

namespace Metodos_y_Arrays___C2_Ej5
{
    class PasarABinario
    {
        public String SuBinario(int midecimal)
        {
            string mibinario = "";
            int cociente = midecimal;
            int resultado = midecimal;
            int resto = 0;

            do
            {
                resultado = cociente / 2;
                resto = cociente % 2;
                if (resto == 0)
                {
                    mibinario = "0" + mibinario;
                }
                else
                {
                    mibinario = "1" + mibinario;
                }
                cociente = resultado;
            }
            while (resultado > 1);
            mibinario = "1" + mibinario;
            return mibinario;

        }
        static void Main(string[] args)
        {
            int numero;
            PasarABinario elbinario = new PasarABinario();
            Console.WriteLine("Introduce un numero para calcular su binario:");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(elbinario.SuBinario(numero));

        }
    }
}
