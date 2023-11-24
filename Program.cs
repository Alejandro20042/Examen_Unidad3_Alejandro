namespace Examen_Unidad3_Alejandro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada listaEnlazada = new ListaEnlazada();
            listaEnlazada.InsertarAlFinal(40);
            listaEnlazada.InsertarAlFinal(30);
            listaEnlazada.InsertarAlFinal(10);


            Console.WriteLine("Edades persona: ");
            listaEnlazada.ImprimirLista();

        }
    }
}
