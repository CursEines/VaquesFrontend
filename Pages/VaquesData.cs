using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using vacawasm.Model;

namespace vacawasm
{
    public class VaquesData : ComponentBase
    {

        protected string imatgeCamp = "/img/camp.png";
        protected string imatgeCamio = "/img/camio.png";
        protected string imatgeCiutat = "/img/ciutat.png";

        protected List<Vaca> Camio = new List<Vaca>();
        protected List<Vaca> Camp = new List<Vaca>();
        protected List<Vaca> Ciutat = new List<Vaca>();

        protected int Viatges;
        protected double Litres;

    }
}