using System;
					
string a = "Hello";
string b = "World";

string c = a + " " + b;                 //Hello World
string d = $"Program mówi: {a} {b}";    //Program mówi: Hello World
string e = " Hello World ";
string f = e.Trim();                    //Hello World
string g = c.Substring(6);              //World
string h = c.Substring(0, 5);           //Hello
string i = a.ToUpper();                 //HELLO
string j = a.ToLower();                 //hello

int length = a.Length;            //5
int index1 = a.IndexOf('o');      //4
int index2 = a.IndexOf('l');      //2
int index3 = a.LastIndexOf('l');  //3

bool start = a.StartsWith('H');   //true
bool end   = a.EndsWith('o');     //true