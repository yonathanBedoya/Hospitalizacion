
namespace HospiEnCasa.App.Dominio   
{
    public class Persona
    {
        // Declaracion de proppiedades de la calse persona
        public int Id {get; set;}
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumeroTelefonico { get; set; }
        public Genero Genero { set; get; }
    }
    
}