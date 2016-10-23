using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortfolioExpansion.Models
{
    public class HomeActionsModel : HomeBaseViewModel
    {
        public void SetState()
        {
            ShowSections = true;
            switch (StateSelector)
            {
                case "Concepts":
                    ShowConcepts = true;
                    break;

                case "Language":
                    ShowLanguage = true;
                    break;

                case "Framework":
                    ShowFramework = true;
                    break;

                case "Reference":
                    ShowReference = true;
                    break;

                default:
                    break;
            }
        }

        public void ResetState()
        {
            ShowConcepts = false;
            ShowLanguage = false;
            ShowFramework = false;
            ShowReference = false;
            ShowHeading = false;
            ShowSections = false;
        }
        
    }
}