using PatronProxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronProxy.Service
{
    public class API : IAPI
    {

        public string Request(string route)
        {
            return $"{route} - Status Code 200";
        }
    }
}