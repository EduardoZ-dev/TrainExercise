using TrenAlSur.Controller;

namespace TrenAlSur.View
{
    public class Program
    {
        static void Main(string[] args)
        {
            Train01 tren = new Train01("South", 25,5, 5);
            tren.ArribarEstacion();
            tren.SubirPasajeros();
            tren.ArribarEstacion();
            tren.DescenderPasajeros();
            tren.DescenderPasajeros();
            tren.SubirPasajeros();

        }
    }
}