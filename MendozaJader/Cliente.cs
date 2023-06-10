namespace MendozaJader
{
    public  class Cliente
    {
        // prop tabx2 y se crea un atributo
        public int ID { get; set; }
        public string? nombre { get; set; }
        public string? correo { get; set; }
        public string? username { get; set; }
        public string? password { get; set; }


        public Cliente()
        {
            ID = 0;
            nombre = string.Empty;
            correo =string.Empty;
            username = string.Empty;
            password = string.Empty;
        }


        public void getData()
        {
            Console.WriteLine("*** Ingrese los datos del cliente ***");
            Console.WriteLine();

            Console.WriteLine("Ingrese el ID: ");
            ID = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre: ");
            string nombre = Console.ReadLine();
            this.nombre = nombre;

            Console.WriteLine("Ingrese el nombre de usuario: ");
            string username = Console.ReadLine();
            this.username = username;

            Console.WriteLine("Ingrese el correo: ");
            string correo = Console.ReadLine();
            this.correo = correo;


            Console.WriteLine("Ingrese la contraseña: ");
            string password = Console.ReadLine();
            this.password = password;


        }

        public void printData()
        {
            Console.WriteLine("*** Datos del cliente ***");
            Console.WriteLine();

            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Nombre de usuario: " + username);
            Console.WriteLine("Correo: " + correo);
            Console.WriteLine("Contraseña: " + password);        
        
        }


    }


   



}
