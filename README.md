# NO LONGER ACTIVE !

Rouigram
=========
Rouigram was the first Instagram user Id API which had been devloped and maintained by [Mohammad Ali Mirhammed](https://github.com/MohammadaliMirhamed/rouigram.py).

Rouigram Reference for C#  
=========================
As one of my very first projects pushed to github, I had managed to create a C# reference for this astonishing webservice.

How to Use
=========================
you have to install Newtonsoft before using this dll 
example code:

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rouigram;

namespace Test
{
    class Program
    {
    
        static void Main(string[] args)
        {
            rouigram.rouigram r = new rouigram.rouigram();
            
            Console.WriteLine(r.biography("mazdakpak"));
            
        }
    }
}
```
