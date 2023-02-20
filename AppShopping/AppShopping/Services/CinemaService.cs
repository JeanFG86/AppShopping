using AppShopping.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppShopping.Services
{
    public class CinemaService
    {
        public List<Film> GetFilms()
        {
            return new List<Film>()
            {
                new Film() {Cover="https://m.media-amazon.com/images/I/71xkQk77OeL._AC_SY879_.jpg",  Name = "1917", Description = "1917 é um filme de guerra dirigido por Sam Mendes, que conta a história de dois soldados britânicos, Schofield e Blake, durante a Primeira Guerra Mundial. A missão deles é atravessar território inimigo para entregar uma mensagem urgente que pode salvar a vida de 1.600 soldados. "},
                new Film() {Cover="https://m.media-amazon.com/images/I/71xkQk77OeL._AC_SY879_.jpg", Name = "Coringa", Description = "Coringa é um filme dirigido por Todd Phillips que retrata a história de Arthur Fleck, um comediante fracassado que vive em Gotham City na década de 1980. Com problemas de saúde mental e em meio a uma cidade em crise, Arthur é empurrado para a beira do abismo e se transforma no vilão Coringa. "}
            };
        }
    }
}
