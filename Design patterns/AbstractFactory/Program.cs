using AbstractFactory;
using AbstractFactory.MacOS;
using AbstractFactory.Windows;


string config = "Windows";

GUIFactory factory;
Application app;

if (config == "Windows")
{
    factory = new WinFactory();
}
else if (config == "Mac")
{
    factory = new MacFactory();
}
else {
    throw new Exception("Error! Unknown operating system.");
}


app = new Application(factory);

app.CreateUI();
app.Paint();