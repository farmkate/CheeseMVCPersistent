using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.ViewModels;
using CheeseMVC.Data;
using CheeseMVC.Models;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using Microsoft.AspNetCore.Mvc;


namespace CheeseMVC.Models
{
    public class CheeseCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public IList<Cheese> Cheeses { get; set; }
    }
}
