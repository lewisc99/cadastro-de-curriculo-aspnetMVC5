using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistedResumes.Data
{
    public class SendingService
    {
        private RegistedResumesContext _context;
       public  SendingService(RegistedResumesContext contexto)
        {
            _context = contexto;
        }
    }
}
