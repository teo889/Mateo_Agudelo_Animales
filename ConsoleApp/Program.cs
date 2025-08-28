public class Animales
{
    public int Id = 0;
    public string? Nombre = "";
    public int Edad = 0;

    public int peso = 0;

    public tipos Tipo = new tipos();
    public colores Colores = new colores();
    public sexos Sexos = new sexos();

    public list<sexos> Sexos = new list<sexos>();
    
}


public class tipos
{
    public int Id = 0;
    public string? Nombre ="";

    public list<Animales> Animales = new list<Animales>();
}


public class colores
{
    public int Id = 0;
    public string? Nombre ="";

    public list<Animales> Animales = new list<Animales>();
}

public class sexos
{
    public int Id = 0;
    public string? Nombre ="";
}   


public class conflicto2 
{
    
}

