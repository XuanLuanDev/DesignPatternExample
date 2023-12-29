using DesignPatternExample;

Console.WriteLine("Start");

# region Singleton Pattern Example
var a = Singleton.GetInstance();
a.PrintMessage("message for a");
var b = Singleton.GetInstance();
b.PrintMessage("message for b");

//class singleton is only create one time
#endregion

#region Factory Pattern Example
Book c =new ProgrammingBookFactory().CreateBook();
Console.WriteLine(c.Type);
c = new LanguageBookFactory().CreateBook();
Console.WriteLine(c.Type);
#endregion

Console.ReadLine();
