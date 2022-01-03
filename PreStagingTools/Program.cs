
string[] paths = Environment.GetCommandLineArgs();



Console.WriteLine(paths[1]);
string[] lines = System.IO.File.ReadAllLines(paths[1]);
System.Console.WriteLine("Jebac pis = ");
foreach (string line in lines)
{
    
    Console.WriteLine("\t" + line);
}


Console.WriteLine("napisnij cos");
System.Console.ReadKey();