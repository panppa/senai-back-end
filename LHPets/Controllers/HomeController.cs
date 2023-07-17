using LHPets.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LHPets.Controllers
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
            //lista de clientes
            List<Cliente> listClientes = new();

            Cliente cliente1 = new Cliente(1, "Cliente 1", "1111111111", "a@b.c");
            listClientes.Add(cliente1);

            Cliente cliente2 = new Cliente(2, "Cliente 2", "2222222222", "b@c.d");
            listClientes.Add(cliente2);

            Cliente cliente3 = new Cliente(3, "Cliente 3", "3333333333", "c@d.e");
            listClientes.Add(cliente3);

            Cliente cliente4 = new Cliente(4, "Cliente 4", "4444444444", "d@e.f");
            listClientes.Add(cliente4);

            Cliente cliente5 = new Cliente(5, "Cliente 5", "5555555555", "e@f.g");
            listClientes.Add(cliente5);

            Cliente cliente6 = new Cliente(6, "Cliente 6", "6666666666", "f@g.h");
            listClientes.Add(cliente6);

            Cliente cliente7 = new Cliente(7, "Cliente 7", "7777777777", "g@h.i");
            listClientes.Add(cliente7);

            Cliente cliente8 = new Cliente(8, "Cliente 8", "8888888888", "h@i.j");
            listClientes.Add(cliente8);

            Cliente cliente9 = new Cliente(9, "Cliente 9", "9999999999", "i@j.k");
            listClientes.Add(cliente9);

            Cliente cliente10 = new Cliente(10, "Cliente 10", "1010101010", "j@k.l");
            listClientes.Add(cliente10);

            ViewBag.listClientes = listClientes;

            //lista de pets
            /*
            List<Pet> listPets = new();

            Pet novoPet1 = new Pet(1, cliente1, "Pitchulinha", "Cachorro");
            listPets.Add(novoPet1);

            Pet novoPet11 = new Pet(1, cliente1, "Pitchulinha2", "Kiwi");
            listPets.Add(novoPet11);

            Pet novoPet2 = new Pet(2, cliente2, "Mittens", "Gato");
            listPets.Add(novoPet2);

            Pet novoPet3 = new Pet(3, cliente3, "Buddy", "Cachorro");
            listPets.Add(novoPet3);

            Pet novoPet4 = new Pet(4, cliente4, "Charlie", "Gato");
            listPets.Add(novoPet4);

            Pet novoPet5 = new Pet(5, cliente5, "Rocky", "Cachorro");
            listPets.Add(novoPet5);

            Pet novoPet6 = new Pet(6, cliente6, "Daisy", "Cachorro");
            listPets.Add(novoPet6);

            Pet novoPet7 = new Pet(7, cliente7, "Lola", "Gato");
            listPets.Add(novoPet7);

            Pet novoPet8 = new Pet(8, cliente8, "Max", "Cachorro");
            listPets.Add(novoPet8);

            Pet novoPet9 = new Pet(9, cliente9, "Lucy", "Gato");
            listPets.Add(novoPet9);

            Pet novoPet10 = new Pet(10, cliente10, "Bella", "Cachorro");
            listPets.Add(novoPet10);

            ViewBag.listPets = listPets;
            */
            //lista de Fornecedores

            List<Fornecedor> listFornecedor = new();

            Fornecedor fornecedor1 = new Fornecedor(1, "Fornecedor 1", "11111111111111", "fornecedor1@example.com");
            listFornecedor.Add(fornecedor1);

            Fornecedor fornecedor2 = new Fornecedor(2, "Fornecedor 2", "22222222222222", "fornecedor2@example.com");
            listFornecedor.Add(fornecedor2);

            Fornecedor fornecedor3 = new Fornecedor(3, "Fornecedor 3", "33333333333333", "fornecedor3@example.com");
            listFornecedor.Add(fornecedor3);

            Fornecedor fornecedor4 = new Fornecedor(4, "Fornecedor 4", "44444444444444", "fornecedor4@example.com");
            listFornecedor.Add(fornecedor4);

            Fornecedor fornecedor5 = new Fornecedor(5, "Fornecedor 5", "55555555555555", "fornecedor5@example.com");
            listFornecedor.Add(fornecedor5);

            Fornecedor fornecedor6 = new Fornecedor(6, "Fornecedor 6", "66666666666666", "fornecedor6@example.com");
            listFornecedor.Add(fornecedor6);

            Fornecedor fornecedor7 = new Fornecedor(7, "Fornecedor 7", "77777777777777", "fornecedor7@example.com");
            listFornecedor.Add(fornecedor7);

            Fornecedor fornecedor8 = new Fornecedor(8, "Fornecedor 8", "88888888888888", "fornecedor8@example.com");
            listFornecedor.Add(fornecedor8);

            Fornecedor fornecedor9 = new Fornecedor(9, "Fornecedor 9", "99999999999999", "fornecedor9@example.com");
            listFornecedor.Add(fornecedor9);

            Fornecedor fornecedor10 = new Fornecedor(10, "Fornecedor 10", "10101010101010", "fornecedor10@example.com");
            listFornecedor.Add(fornecedor10);

            ViewBag.listFornecedor = listFornecedor;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}