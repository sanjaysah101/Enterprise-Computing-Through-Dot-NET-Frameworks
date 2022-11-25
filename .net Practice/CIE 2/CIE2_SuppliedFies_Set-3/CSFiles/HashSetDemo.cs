using System;
using System.Collections.Generic;
 
class HashSetDemo{
 
    static public void Main()
    {
        HashSet<string> h1 = new HashSet<string>();       
        HashSet<string> h2 = new HashSet<string>();
 
 
      
        h1.Add("C");
        h1.Add("C++");
        h1.Add("C#");
        h1.Add("Java");
        h1.Add("Ruby");
        h2.Add("PHP");
        h2.Add("C++");
        h2.Add("Perl");
        h2.Add("Java");
 
        h1.UnionWith(h2);

        foreach(var ele in h1)
        {
            Console.WriteLine(ele);
        }
    }
}

