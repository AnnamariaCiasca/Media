using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
   public class GeneratoreEvento
    {
        public delegate void GestoreEventi(GeneratoreEvento gen, double media);

        public event GestoreEventi MediaSuperata;

        public void SuperamentoMedia(double media)
        {
          if(MediaSuperata != null)
            {
                MediaSuperata(this, media);
            }
        }
    
    
    
    }
}
