namespace EpamHW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Honda = new Car("Honda Civic", 300);
            Car Mercedes = new Car("Mercedes Sprinter", 320);
            if (Honda.Max_velocity > Mercedes.Max_velocity)
            {
                Console.WriteLine($"Найшвидша машина {Honda.Name}");
            }
            else if (Mercedes.Max_velocity > Honda.Max_velocity) 
            {
                Console.WriteLine($"Найшвидша машина {Mercedes.Name}");
            }
            else 
            {
                Console.WriteLine("Визначити найшвидшу машину неможливо");
            }
        }
    }
}