# Rouigram

Rouigram Reference for c#  
the first instagram_user id api now created for c# 

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
