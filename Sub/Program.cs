using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Sub
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"H:\Avatar (2009) UHD 4K Upscaled x264 DTS Soup\Avatar (2009) UHD 4K Upscaled x264 DTS Soup.srt";
            int i = 2, cunt_readText = 0, newSub = 0, Num_of_New_Sub = 1, g;
            // Open the file to read from.
            string[] readText = File.ReadAllLines(path, Encoding.Default);
            int megethos_readText = readText.Length;
            string[] CorectSub = new string[((megethos_readText/2))];
            foreach (string s in readText)
            {
                int metritis_gia_na_vro_mexri_to_keno = cunt_readText;
                string w = i.ToString();
                if (s == w)
                {
                    i += 2;
                    CorectSub[newSub] = Num_of_New_Sub.ToString();
                    Num_of_New_Sub++;
                    newSub++;
                    do
                    {
                        if (metritis_gia_na_vro_mexri_to_keno >= megethos_readText - 1) break;
                        metritis_gia_na_vro_mexri_to_keno++;
                        CorectSub[newSub] = readText[metritis_gia_na_vro_mexri_to_keno];
                        newSub++;
                    } while (readText[metritis_gia_na_vro_mexri_to_keno] != "");
                    if (newSub!= (megethos_readText / 2))
                    {
                        CorectSub[newSub] = "";
                    }
                }
                cunt_readText++;
            }
            File.WriteAllLines(path, CorectSub, Encoding.Default);
        }
       
    }
}
