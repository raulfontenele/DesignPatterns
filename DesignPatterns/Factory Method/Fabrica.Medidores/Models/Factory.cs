using Fabrica.Medidores.Interfaces;

namespace Fabrica.Medidores.Models
{
    public class Factory
    {
        public IMeter Criar(string tipo)
        {
            if (tipo == "cronos")
                return new Cronos(12);
            else if (tipo == "zeus")
                return new Zeus(20);
            else
                return null;
        }
        public IMeter Criar()
        {
            Random rnd = new Random();
            int numero = rnd.Next(100);

            if (numero < 50)
                return new Cronos(12);
            else
                return new Zeus(10);
        }
    }
}
