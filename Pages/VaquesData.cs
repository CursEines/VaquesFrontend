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

        protected int Viatges;
        protected double Litres;
        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(1);

            var races = new List<Raça>() {
                new Raça() { Nom = "Holdstein", LitresPerKg = 0.086 },
                new Raça() { Nom = "Ayshire", LitresPerKg = 0.066 },
                new Raça() { Nom = "Jersey", LitresPerKg = 0.078 },
                new Raça() { Nom = "Simental", LitresPerKg = 0.062 }
            };

            Viatges = 0;
            Litres = 0;
            // Recuperar les dades de http://localhost:4567/start/6
            //  Camp =  http://localhost:4567/camp
            //  Camio = http://localhost:4567/camio
            //  Ciutat = http://localhost:4567/ciutat
            Camp.Add(new Vaca()
            {
                Nom = "Pepa",
                Pes = 350.3,
                Raça = races[0]
            });

            Camp.Add(new Vaca()
            {
                Nom = "Rufa",
                Pes = 378.0,
                Raça = races[1]
            });

            Camp.Add(new Vaca()
            {
                Nom = "Flor",
                Pes = 450.9,
                Raça = races[2]
            });

            Camp.Add(new Vaca()
            {
                Nom = "Toñi",
                Pes = 550.7,
                Raça = races[0]
            });

            Camp.Add(new Vaca()
            {
                Nom = "Marisol",
                Pes = 450.3,
                Raça = races[3]
            });

            Camp.Add(new Vaca()
            {
                Nom = "Conxi",
                Pes = 350.9,
                Raça = races[1]
            });

            Camp.Add(new Vaca()
            {
                Nom = "Moreneta",
                Pes = 350.9,
                Raça = races[2]
            });
        }


    }
}