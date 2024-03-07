// See https://aka.ms/new-console-template for more information
Console.WriteLine("Gestion de archivos");
Console.WriteLine();

//Creacion de archivo
StreamWriter archivo = new StreamWriter("archivo.text");
archivo.WriteLine("Contenido del archivo");
archivo.WriteLine("Contenido en otra linea");
archivo.Close();
