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

        double diners;

        protected override async Task OnInitializedAsync()
        {
            // Recuperar les dades
            Camp.Add(new Vaca()
            {
                Nom = "Pepa",
                Pes = 350.3,
                Raça = new Raça() { Nom = "Holdstein", LitresPerKg = 4.3 }
            });
        }

        public void move(Vaca vaca)
        {


        }
        protected double Diners;
    }
}