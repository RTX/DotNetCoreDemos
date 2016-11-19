using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace HelloWebApi
{

    [RouteAttribute("/products")]
    public class ProductsController
    {
        static List<string> prods = new List<string>{"test","hi"};

        public  List<string> Get() {
                return prods;
        }
    }
}

