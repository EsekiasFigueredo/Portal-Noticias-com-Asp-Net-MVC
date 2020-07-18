using PortalNoticias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalNoticias.Controllers
{
    public class NoticiasController : Controller
    {
        // GET: Noticias
        public ActionResult Index()
        {
            return View(RepositorioNoticias.Noticias);
        }

        public ActionResult Detalhes(int id)
        {
            var noticia = RepositorioNoticias.Noticias.FirstOrDefault( n => n.Id == id);
            return View(noticia);

            /*
             * .FirstOrDefault => irá retornar o primeiro resultado referente a pesquisa feita.
             * n é uma variavel que respresenta da notica a ser retornada
             * (=>)  é uma expressão Lambda
             */
        }
        public ActionResult Buscar(string texto)
        {
            var noticias = RepositorioNoticias.Noticias.Where(n => n.Titulo.Contains(texto) || n.Conteudo.Contains(texto));
            return View(noticias);
        }

    }
} 