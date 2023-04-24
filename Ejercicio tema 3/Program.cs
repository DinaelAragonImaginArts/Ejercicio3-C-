

internal class Program
{
    private static void Main(string[] args)
    {
        int main(int a, int b, int c)
        {
            int resultado = a + b + c;
            Console.WriteLine(resultado);
            return resultado;
        }
        main(3, 4, 4);
    }
    //Segunda parte
    public class Coche
    {
        public int numeroPuertas { get; set;}
        public Coche(int puertas){
            numeroPuertas =  puertas;
        }
        public void changePuertas(int puertas){
            numeroPuertas = numeroPuertas + puertas;
        }
    }
}