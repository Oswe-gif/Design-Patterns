// See https://aka.ms/new-console-template for more information

using Builder;

CarBuilder builder = new CarBuilder();

var car = builder.Id(1).Color("Green").Brand("Mercedes").Build();

Console.WriteLine(car.ToString());


//using a director --> the director is used when we want to reuse specific configurations of the products we are building --- But it's optional to use a director

Director director = new Director();
CarBuilder builder2 = new CarBuilder();
director.BuildBugatti(builder2);
CarSchema car2 = builder2.Build();

Console.WriteLine(car2.ToString());


Director director2 = new Director();
CarBuilder builder3 = new CarBuilder();
director2.buildLambo(builder3);
CarSchema car3 = builder3.Build();

Console.WriteLine(car3.ToString());