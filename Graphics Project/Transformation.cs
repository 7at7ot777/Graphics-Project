using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Graphics_1st_try
{
    public class Transformation
    {
        int POneX, POneY, PTwoX, PTwoY, PThreeX, PThreeY;
        Panel p;

         public Transformation(int x1 ,int y1 , int x2 , int y2 , int x3 , int y3 , Panel panel )
        {
            POneX = x1;
            POneY = y1;

            PTwoX = x2;
            PTwoY = y2; 

            PThreeX = x3;
            PThreeY = y3;

            p = panel;
        
        }    
    }
}
