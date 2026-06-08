using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SistemaAcademico.Controllers
{
    public class AlunoController : Controller
    {
        // Rota que será acessada: /Aluno/Listar
        public IActionResult Listar()
        {
            // INSTRUÇÃO DO CHECKPOINT VII: Utilizar uma lista de strings para carregar os dados
            List<string> listaAlunos = new List<string>()
            {
                "Ana Clara Silva",
                "Bruno Henrique Souza",
                "Carlos Eduardo Lima",
                "Daniela Oliveira Costa",
                "Fernando Alves Pereira"
            };

            // Passando a lista de strings de forma dinâmica para a View usando a ViewBag
            ViewBag.ListaDeAlunos = listaAlunos;

            return View();
        }
    }
}
