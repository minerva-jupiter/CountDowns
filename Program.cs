// See https://aka.ms/new-console-template for more information

bool forEver = true;
bool file;
string fileName = @"CountDown.txt";
Console.WriteLine("When is the target time?(yyyy/mm/dd hh:mm:ss)");
string targetTimeString = Console.ReadLine();
var targetTimeInt = DateTime.Parse(targetTimeString);

file = File.Exists(fileName);
Log(Convert.ToString(file));
if (file == false)
{
    StreamWriter sw = File.CreateText(fileName);
}
while (forEver)
{
    StreamWriter sw = new StreamWriter(fileName);
    var datNow = DateTime.Now;
    var time = CountDown(targetTimeInt,datNow);
    sw.WriteLine(time);
    sw.Close();
}


TimeSpan CountDown(DateTime dtTarget, DateTime dtNow)
{
    var tsDiff = dtTarget - dtNow;
    return tsDiff;
}

void Log(string message)
{
    Console.WriteLine(message);
}