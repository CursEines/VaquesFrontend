using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using vacawasm.Model;

namespace vacawasm
{

    public class VaquesData : ComponentBase
    {
        protected List<Vaca> Camp = new List<Vaca>();
        protected string imatgeCamp = "/img/camp.png";
        protected List<Vaca> Camio = new List<Vaca>();
        protected string imatgeCamio = "/img/camio.png";

        protected string imatgeCiutat = "/img/ciutat.png";
        protected List<Vaca> Ciutat = new List<Vaca>();

        protected override async Task OnInitializedAsync()
        {
            // Recuperar les dades de http://localhost:4567/start/6
            //  Camp =  http://localhost:4567/camp
            //  Camio = http://localhost:4567/camio
            //  Ciutat = http://localhost:4567/ciutat
            Camp.Add(new Vaca()
            {
                Nom = "Pepa",
                Pes = 350.3,
                Raça = new Raça() { Nom = "Holdstein", LitresPerKg = 4.3 }
            });

            Camp.Add(new Vaca()
            {
                Nom = "Rufa",
                Pes = 378.0,
                Raça = new Raça() { Nom = "Ayshire", LitresPerKg = 3.3 }
            });

            Camp.Add(new Vaca()
            {
                Nom = "Flor",
                Pes = 450.9,
                Raça = new Raça() { Nom = "Jersey", LitresPerKg = 3.9 }
            });

            Camp.Add(new Vaca()
            {
                Nom = "Toñi",
                Pes = 550.7,
                Raça = new Raça() { Nom = "Holdstein", LitresPerKg = 4.3 }
            });

            Camp.Add(new Vaca()
            {
                Nom = "Marisol",
                Pes = 450.3,
                Raça = new Raça() { Nom = "Simental", LitresPerKg = 3.1 }
            });
        }

        protected double Litres;
    }
}