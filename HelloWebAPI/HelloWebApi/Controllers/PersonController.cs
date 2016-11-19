using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace HelloWebApi
{

    [RouteAttribute("/person")]
    public class PersonController
    {
        static List<string> prods = new List<string>{"test","hi"};

        public  List<string> Get() {
                return prods;
        }
    }
}

