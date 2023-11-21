using PatronProxy.Interfaces;
using PatronProxy.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronProxy.Proxy
{
    public class APIProxy : IAPI
    {

        private API _service = new API();

        public string UserName { get; set; }

        public string Request(string route)
        {
            bool canAccess = CheckUser();
            if (!canAccess) return "No estas autorizado para acceder a esta ruta";
            return _service.Request(route);
        }

        public bool CheckUser() => UserName == "admin";
    }
}