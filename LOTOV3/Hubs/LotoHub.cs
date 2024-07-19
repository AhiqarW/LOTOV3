using LOTOV3.Models;
using Microsoft.AspNetCore.SignalR;

namespace LOTOV3.Hubs
{
    public class LotoHub: Hub
    { 

        public async Task SignalerDonnee(NouvelleDonnee donnee)
        {

            Console.WriteLine($"data: {donnee.DonneeAjoutee}");

            await Clients.All.SendAsync("NouvelleDonneeRecue", donnee);

        }
    }
}
