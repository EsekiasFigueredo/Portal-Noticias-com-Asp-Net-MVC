using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalNoticias.Models
{
    public class RepositorioNoticias
    {


        private static List<Noticia> noticias;

        public static List<Noticia> Noticias
        {
            get
            {
                if (noticias == null)
                    CriarNoticias();
                    return noticias;
            }
        }

        private static void CriarNoticias()
        {
            noticias = new List<Noticia>();

            noticias.Add(new Noticia
            {
                Id = 1,
                Titulo = "Teste Corona Virus",
                Autor = "Marcos Gregorio",
                Data = DateTime.Today.AddDays(-10),
                Conteudo = "Ainda existe uma grande subnotificação de casos em nosso pais"
            });

            noticias.Add(new Noticia
            {
                Id = 2,
                Titulo = "Vacina Covid 19",
                Autor = "João Ricardo",
                Data = DateTime.Today.AddDays(-10),
                Conteudo = "Enfim encontrado vacina contra o Civid 19"
            });

            noticias.Add(new Noticia
            {
                Id = 3,
                Titulo = "Reabertura do Comercio no Brasil",
                Autor = "Capriotti",
                Data = DateTime.Today.AddDays(-10),
                Conteudo = "devemos usar mascar e alcool gel ao sir de casa"
            });

            noticias.Add(new Noticia
            {
                Id = 4,
                Titulo = "China X Mundo",
                Autor = "Nyan Lee",
                Data = DateTime.Today.AddDays(-10),
                Conteudo = "Temos grande duvida sobre a origem dessa Pandemia"
            });

            noticias.Add(new Noticia
            {
                Id = 5,
                Titulo = "Teste do Presidente deu positivo para Covid 19",
                Autor = "João Zaydan",
                Data = DateTime.Today.AddDays(-10),
                Conteudo = "Agora ele será obrigado a cumprir quarentena"
            });
        }
    }
}