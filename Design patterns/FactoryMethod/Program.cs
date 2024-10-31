using FactoryMethod;

var config = "Windows";
Dialog dialog;
if (config == "Windows")
{
    dialog = new WindowsDialog();
}
else if (config == "Web")
{
    dialog = new WebDialog();
}
else {
    throw new Exception("Error! Unknown operating system.");
}


dialog.Render();

//NEW ONE

dialog.CreateButton().onClick("New button with own onClick");