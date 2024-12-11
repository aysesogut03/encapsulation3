using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    public class hasta
    {
        private string tc;
        public string  TC
        {
            get
            {
                return tc.Substring(0, 4);
            }
                set
            {
                bool kontrol = false;
                if(value.Length ==11) 
                { 
                    for(int i=0;i<value.Length;i++)
                    {
                        bool sayiMi = char.IsNumber(value[i]);
                        if(sayiMi)
                        {

                        }
                        else
                        {
                            kontrol= true;
                            break;
                        }

                    }
                    if(kontrol)
                    {
                        Console.WriteLine("Tc kimlik numaranızda geçersiz değer bulundu");
                    }
                    else
                    {
                        tc= value;
                    }
                }
            }
        
        
        }
    }
}
