using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Themes.Prototype.WPF
{
    public class DesignQuotes
    {
        private readonly QuoteClass[] quotes = new[]
        {
            new QuoteClass("Steve Jobs", 
                "Design is a funny word. Some people think design means how it looks. But of course, if you dig deeper, it's really how it works."),
            new QuoteClass("Henry David Thoreau",
                "It’s not what you look at that matters, it’s what you see."),
            new QuoteClass("John Gossman (author of MVVM pattern)",
                "Model/View/ViewModel is a variation of Model/View/Controller (MVC) that is tailored for modern UI development platforms where the View is the responsibility of a designer rather than a classic developer.  The designer is generally a more graphical, artistic focused person, and does less classic coding than a traditional developer.. "),
        };
        private int lastQuoteIndex = -1;

        public QuoteClass NextQuote()
        {
            lastQuoteIndex++;
            if(lastQuoteIndex >= quotes.Length)
            {
                lastQuoteIndex = 0;
            }

            return quotes[lastQuoteIndex];
        }
    }

    public class QuoteClass
    {
        private readonly string author;
        private readonly string quote;

        public QuoteClass(string author, string quote)
	    {
            this.author = author;
            this.quote = quote;
	    }

        public string Author {get{return author;}}
        public string Quote {get{return quote;}}
    }
}
