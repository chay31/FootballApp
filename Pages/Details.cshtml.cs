using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace FootballApp.Pages
{
    public class DetailsModel : PageModel
    {
        public Team Team { get; set; }

        public void OnGet(int id)
        {
            // Liste des équipes simulée
            var teams = new List<Team>
            {
                new Team { Id = 1, Name = "Paris Saint-Germain", NextMatch = "PSG vs Lyon - 25 Septembre" },
                new Team { Id = 2, Name = "Real Madrid", NextMatch = "Real Madrid vs Atletico - 1 Octobre" },
                new Team { Id = 3, Name = "FC Barcelona", NextMatch = "Barcelone vs Séville - 5 Octobre" }
            };

            // Récupérer les détails de l'équipe en fonction de l'ID
            Team = teams.FirstOrDefault(t => t.Id == id);
        }
    }
}
