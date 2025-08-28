Console.WriteLine("Hello, World!");

var persona = new Personas();
Personas persona1 = new Personas();
Personas persona2 = new Estudiantes();

IEstudiantes i_estudiante = new Estudiantes();

persona.Id = 1;
persona.Nombre = "Pepito Perez";
persona.Activo = true;
persona.Salario = 1400000.0m;
persona.Tipo = new Tipos() { Id = 1, Nombre = "Casado" };
persona.VideoJuegos = new List<VideoJuegos>();
persona.VideoJuegos.Add(new VideoJuegos() { Id = 1, Nombre = "LOZ 2025" });
persona.VideoJuegos.Add(new VideoJuegos() { Id = 2, Nombre = "Tetrix" });

Console.WriteLine(persona.Nombre);
Console.WriteLine(persona.Tipo.Nombre);

foreach (var elemento in persona.VideoJuegos)
{
    Console.WriteLine(elemento.Nombre);
}

public class Tipos
{
    public int Id = 0;
    public String? Nombre = "";

    public List<Personas> Personas = new List<Personas>();
}

public class VideoJuegos
{
    public int Id = 0;
    public String? Nombre = "";
}

public class Personas
{
    public int Id = 0;
    public String? Nombre = "";
    public DateTime Fecha = DateTime.Now;
    public bool Activo = false;
    public decimal Salario = 0.0m;
    public Tipos Tipo = new Tipos();
    public List<VideoJuegos> VideoJuegos = new List<VideoJuegos>();
}

public interface IEstudiantes
{
    bool Utiles();
}

public class Estudiantes : Personas, IEstudiantes
{
    public String? Carnet = "";

    public bool Utiles()
    {
        return true;
    }
}

public class EstudiantesItm : Personas, IEstudiantes
{
    public String? Carnet = "";

    public bool Utiles()
    {
        return false;
    }
}
