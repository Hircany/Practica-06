
using System;

public class Contacto
{
    string nombre; 

    public void SetContacto(string nombre)
{
    this.nombre = nombre;
}
    public void Saludar ()
    {
        Console.WriteLine ("Hola soy " + nombre);
    }
}

public class Prueba Contacto
{
    public static void Main ()
    {
        Persona per = new Contacto (); 
        per.SetContacto ("Hircany"); 
        per.Saludar();
    }
}