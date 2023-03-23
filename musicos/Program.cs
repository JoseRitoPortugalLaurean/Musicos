abstract class Musico //clase abstracta que solo puede generar subclases, pero no objetos diretamente
{
    public string Nombre { get; set; }
    public virtual string GetSaludo() {return $"Hola, soy {Nombre}";}//método virtual que puede ser sobreescrito por las subclases
    public virtual void Saludo() {Console.WriteLine(GetSaludo());}//método virtual que puede ser sobreescrito por las subclases
    public Musico(string n) {Nombre = n;}
    public void Saluda() {Console.WriteLine($"Hola, soy {Nombre}");}
    public abstract void Toca();//para implementar métodos abstractos, debemos de usar la palabra reservada override
}
    class Bajista : Musico
    {
        public string? Bajo { get; set; }
        public Bajista (string n, string b) : base(n) {Bajo = b;}
        public override void Toca() {Console.WriteLine($"{Nombre} está tocando el bajo");}
    }

    class Baterista : Musico
    {
        public string? Batería { get; set; }
        public Baterista (string n, string b) : base(n) {Batería = b;}
        public override void Toca() {Console.WriteLine($"{Nombre} está tocando la batería");}
        public override string GetSaludo() => base.GetSaludo() + " y lamentablemente soy baterista";
        public override void Saludo() {Console.WriteLine(GetSaludo());}
    }

internal class Program
{
    private static void Main(string[] args)
    {
        List<Musico> grupo = new List<Musico>();
        grupo.Add(new Bajista("Joe", "Yamaha"));
        grupo.Add(new Baterista("John", "Pearl"));
        grupo.Add(new Baterista("Paul", "el de los Beatles"));
        grupo.Add(new Bajista("George", "el de los Beatles"));
        grupo.Add(new Bajista("Ringo", "Gibson"));
        foreach (var m in grupo)
        {
            m.Saluda();
        }
        foreach (var m in grupo)
        {
            m.Toca();
        }

        Console.WriteLine("Hello, World!");
    }
}