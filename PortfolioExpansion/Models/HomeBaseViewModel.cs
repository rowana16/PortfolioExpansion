using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortfolioExpansion.Models
{
    public class HomeBaseViewModel
    {
        public bool ShowHeading { get; set; }
        public bool ShowSections { get; set; }

        public bool ShowConcepts { get; set; }
        public bool ShowLanguage { get; set; }
        public bool ShowFramework { get; set; }
        public bool ShowReference { get; set; }
        public bool ShowJob { get; set; }
        
        public string StateSelector { get; set; }
        

    }
}