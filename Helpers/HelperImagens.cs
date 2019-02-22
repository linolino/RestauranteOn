using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Helpers;


namespace RestauranteOnline.Helpers
{
    public static class HelperImagens
    {
        public static MvcHtmlString ExibeImagens(this HtmlHelper hp)
        {
            string str = "<div style=\"widt:100%; text-align:center; padding:10px\">" +
                         "<div style=\"widt:300px%; height:168px; margin:5px; display:inline-block\">" +
                         "<img src=\"Imagens/ComidaMineira.png\" /></div>" +

                         "<div style=\"widt:300px%; height:168px; margin:5px; display:inline-block\">" +
                         "<img src=\"Imagens/Pizza.png\" /></div>" +

                         "<div style=\"widt:300px%; height:168px; margin:5px; display:inline-block\">" +
                         "<img src=\"Imagens/Hamburger.png\" /></div>" +
                         "</div>";


            return new MvcHtmlString(str);
        }

        public static MvcHtmlString ExibeImagensUsuario(this HtmlHelper hp)
        {
            string str = "<div style=\"widt:100%; text-align:center; padding:10px\">" +
                         "<div style=\"widt:300px%; height:168px; margin:5px; display:inline-block\">" +
                         "<img src=\"Imagens/usuarios.png\" /></div>";

            return new MvcHtmlString(str);
        }

        public static MvcHtmlString ExibeImagensRestaurante(this HtmlHelper hp)
        {
            string str = "<div style=\"widt:100%; text-align:center; padding:10px\">" +
                         "<div style=\"widt:300px%; height:168px; margin:5px; display:inline-block\">" +
                         "<img src=\"Imagens/res4.png\" /></div>";



            return new MvcHtmlString(str);
        }
        public static MvcHtmlString ExibeImagensBairro(this HtmlHelper hp)
        {
            string str = "<div style=\"widt:100%; text-align:center; padding:10px\">" +
                         "<div style=\"widt:300px%; height:168px; margin:5px; display:inline-block\">" +
                         "<img src=\"Imagens/bairro.png\" /></div>";



            return new MvcHtmlString(str);
        }

        public static MvcHtmlString ExibeImagensGeneros(this HtmlHelper hp)
        {
            string str = "<div style=\"widt:100%; text-align:center; padding:10px\">" +
                         "<div style=\"widt:300px%; height:168px; margin:5px; display:inline-block\">" +
                         "<img src=\"Imagens/genero.png\" /></div>";
            return new MvcHtmlString(str);
        }


    }
}