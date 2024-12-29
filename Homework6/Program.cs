using Homework6;

var pr = new Producer();
var cn = new Consumer();

while (true)
{
    pr.PushData();
    cn.ProcessData();
    Console.WriteLine("Process more data or exit");
    var str = Console.ReadLine();
    if (str == "exit")
        break;
}
