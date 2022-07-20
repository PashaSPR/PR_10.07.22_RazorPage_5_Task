using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PR_10._07._22_RazorPage_5_Task.Pages
{
    public class QuoteModel : PageModel
    {
        //створити клас цитата: цитата і автор(ім'я) 
        //switch,випадкові числа
        public string textQuote { get; set; }
        public string autorName { get; set; }
        //public Quote quote;

        Random rand = new Random();
        public void OnGet()
        {
            int num = rand.Next(1, 12);
            stringQuote(num);
        }

        private string stringQuote(int num)
        {
            switch (num)
            {
                case 1:
                    textQuote = "Людям не те що позакладало вуха — людям позакладало душі";
                    autorName = "Ліна Костенко";
                    break;
                case 2:
                    textQuote = "Мова росте елементарно, разом з душею народу";
                    autorName = "Іван Франко";
                    break;
                case 3:
                    textQuote = "Як ліки не завжди приємні, так і істина буває сувора";
                    autorName = "Григорій Сковорода";
                    break;
                case 4:
                    textQuote = "І тепер я маю одно тільки право: — нікому, ніколи й нічого не говорити, як розкололось моє власне \"я\"";
                    autorName = "Микола Хвильовий";
                    break;
                case 5:
                    textQuote = "Двоє дивляться вниз. Один бачить калюжу, другий — зорі. Що кому";
                    autorName = "Олексадр Довженко";
                    break;
                case 6:
                    textQuote = "Орлині крила маєм за плечима, самі ж кайданами прикуті до землі";
                    autorName = "Леся Українка";
                    break;
                case 7:
                    textQuote = "Ліпше вмерти біжучи, ніж жити гниючи";
                    autorName = "Іван Багряний";
                    break;
                case 8:
                    textQuote = "Мрія дає нуль, якщо її не зробити життям.";
                    autorName = "Григорій Тютюнник";
                    break;
                case 9:
                    textQuote = "Можна все на світі вибирати, сину, вибрати не можна тільки Батьківщину";
                    autorName = "Василь Симоненко";
                    break;
                case 10:
                    textQuote = "Хоч би які великі були московські насильства, вони не дають москалям жодного законного права на Україну";
                    autorName = "Пилип Орлик";
                    break;
                case 11:
                    textQuote = "Не можна, мабуть, інакше, як тілько горем та бідою довести людей до розуму";
                    autorName = "\n\tПантелеймон Куліш";
                    break;
                default:
                    textQuote = "Помилка";
                    autorName = "Рандом";
                    break;
            }
            return textQuote+autorName;
        }
        //private Quote stringQuote(int num)
        //{
        //    switch (num)
        //    {
        //        case 1:
        //            quote.textQuote = "Людям не те що позакладало вуха — людям позакладало душі";
        //            quote.autorName="Ліна Костенко";
        //            break;
        //        case 2:  quote.textQuote = "Мова росте елементарно, разом з душею народу";
        //            quote.autorName="Іван Франко"; 
        //            break;
        //        case 3:  quote.textQuote = "Як ліки не завжди приємні, так і істина буває сувора";
        //            quote.autorName="Григорій Сковорода"; 
        //            break;
        //        case 4:  quote.textQuote = "І тепер я маю одно тільки право: — нікому, ніколи й нічого не говорити, як розкололось моє власне \"я\"";
        //            quote.autorName = "Микола Хвильовий"; 
        //            break;
        //        case 5:  quote.textQuote = "Двоє дивляться вниз. Один бачить калюжу, другий — зорі. Що кому";
        //                 quote.autorName = "Олексадр Довженко"; 
        //            break;       
        //        case 6:  quote.textQuote = "Орлині крила маєм за плечима, самі ж кайданами прикуті до землі";
        //                 quote.autorName = "Леся Українка"; 
        //            break;       
        //        case 7:  quote.textQuote = "Ліпше вмерти біжучи, ніж жити гниючи";
        //                 quote.autorName = "Іван Багряний"; 
        //            break;       
        //        case 8:  quote.textQuote = "Мрія дає нуль, якщо її не зробити життям.";
        //            quote.autorName = "Григорій Тютюнник"; 
        //            break;       
        //        case 9:  quote.textQuote = "Можна все на світі вибирати, сину, вибрати не можна тільки Батьківщину";
        //            quote.autorName = "Василь Симоненко"; 
        //            break;       
        //        case 10: quote.textQuote = "Хоч би які великі були московські насильства, вони не дають москалям жодного законного права на Україну";
        //            quote.autorName = "Пилип Орлик";
        //            break;
        //        case 11: quote.textQuote = "Не можна, мабуть, інакше, як тілько горем та бідою довести людей до розуму";
        //            quote.autorName = "\n\tПантелеймон Куліш"; 
        //            break;
        //        default:quote.textQuote = "Помилка";
        //            quote.autorName = "Рандом";
        //            break;
        //    }
        //    return quote;
        //}
    }
}
