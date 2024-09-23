using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace FootballApp.Pages
{
    public class IndexModel : PageModel
    {
        public List<Team> Teams { get; set; }

        public void OnGet()
        {
            // Liste des équipes de football simulée
            Teams = new List<Team>
            {
                new Team { Id = 1, Name = "Paris Saint-Germain" },
                new Team { Id = 2, Name = "Real Madrid" },
                new Team { Id = 3, Name = "FC Barcelona" }
            };
        }
    }
}
