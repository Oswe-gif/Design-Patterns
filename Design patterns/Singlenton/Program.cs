// See https://aka.ms/new-console-template for more information
using Singleton;

Thread t1 = new Thread(() => {
    Database foo = Database.GetInstance();
    foo.Value = "Object 1";
    Console.WriteLine(foo.Value);
});
Thread t2 = new Thread(() => {
    Database bar = Database.GetInstance();
    Console.WriteLine(bar.Value);
    bar.Value = "Change all";
    Console.WriteLine(bar.Value);
});

t1.Start();
t2.Start();

t1.Join();
t2.Join();


    

    




//Database finalObject = new Database(); it fails!