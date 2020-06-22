namespace Aula22ConversorDeMoedas
{
    public class Conversor
    {
        protected static float CotacaoDolar = 5.23f;

        public static float RealxDolar(float ValorBRL){ //Convertendo real para dolar
            return ValorBRL / CotacaoDolar;
        }

        public static float DolarxReal(float ValorUS){ //Convertendo dolar para real
            return CotacaoDolar * ValorUS;
        }

        protected static float CotacaoEuro = 5.93f;

        public static float RealxEuro(float ValorBRL){
            return ValorBRL / CotacaoEuro;
        }

        public static float EuroxReal(float ValorEUR){
            return CotacaoEuro * ValorEUR;
        }


    }
}