
Console.WriteLine("please,insert a sentence ");

string herr = " estoy  haciondo pruebas";
string harr = "ESTOY  HACIONDO  PRUEBAS";

Console.WriteLine(herr.ToUpper());//este vuelve a masyusculas
Console.WriteLine(harr.ToLower());//este lo vuelve a minusculas 

//segundo mentodo
Console.WriteLine("segundo metodo");
Console.WriteLine(herr.Trim());//recurda los parentesis
Console.WriteLine(harr.Trim());

//tercer metodo
Console.WriteLine("tercer metodo");

string a = "afdggg";
string b = "aasgdsee";

Console.WriteLine(a);// 1 es lo letra que vamos a cambiar y 2 es la que lo remplaza
Console.WriteLine(b);//                       1    2
Console.WriteLine("a con replace "+a.Replace("a", "b"));
Console.WriteLine("b con replace "+b.Replace("a", "b"));

Console.WriteLine("cuarto metodo");

Console.WriteLine("a se el remove 3 "+a.Remove(3));//solo acepta una
Console.WriteLine("b se le remueve 2 "+b.Remove(2));//borras todod que esten despues del numero dado

Console.WriteLine("quinto metodo");
string information = "gonzalo, 21, chile, juan, treces";
string[] split = information.Split(',');//esto hace para dividir la informvion

Console.WriteLine("cero "+split[0]);
Console.WriteLine("primera palabra "+split[1]);
Console.WriteLine("segunda palabra "+split[2]);
Console.WriteLine("tercera palabra "+split[3]);
Console.WriteLine("cuarta palabra "+split[4]);