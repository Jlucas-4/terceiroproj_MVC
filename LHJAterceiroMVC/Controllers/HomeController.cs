using LHJAterceiroMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LHJAterceiroMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {         

            Fisica fisica = new Fisica
            {
               
                Id = 10000,
                Nome = "penisiso",
                Sexo = 'M',
                CPF = 47465464867,
                RG = 4356747689,
                Dig_RG = '5'

            };
            ViewData["Id"] = fisica.Id;
            ViewData["Nome"] = fisica.Nome;
            ViewData["Sexo"] = fisica.Sexo;
            ViewData["RG"] = fisica.RG;
            ViewData["CPF"] = fisica.CPF;
            ViewData["Dig_RG"] = fisica.Dig_RG;
            return View(fisica);
        }
            

        public IActionResult Privacy()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Id = 000001;  
            pessoa.Nome = "Jhonathan_Joestar";
            pessoa.Sexo = 'M';

            ViewBag.id = pessoa.Id; 
            ViewBag.Nome = pessoa.Nome; 
            ViewBag.Sexo = pessoa.Sexo;

            return View(pessoa);
        }

        public IActionResult Juridica()
        {
            Juridica juridica = new Juridica();
            juridica.Id = 1074;
            juridica.Nome = "Jhonatham_Joestar";
            juridica.CNPJ = 17251654000157;
            juridica.IE = 12548598478;
            return View(juridica);
        }

       
    }
}
