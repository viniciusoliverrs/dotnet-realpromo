using Microsoft.AspNetCore.SignalR;
using RealPromo.ApiWeb.Models;

namespace RealPromo.ApiWeb.Hubs
{
    // RPC
    public class PromoHub : Hub
    {

        /*
         * Cliente - JS/C#/Java
         * RPC
         * - Cliente(JS) -> Hub(C#) (C# - CadastrarPromoca)
         * - Hub(C#) -> Cliente(JS) (JS - ReceberPromocao)
         */
        public async Task CadastrarPromocao(Promocao promocao)
        {
            /*
             * Banco
             * Queue/Scheduler........
             * Notificar o usuário (SignalR).
             *
             * All - Todos os clientes conectados
             * await Clients.All.ReceberPromocao(promocao);
             *
             * Client - Um cliente específico
             * await Clients.Client(Context.ConnectionId).ReceberPromocao(promocao);
             *
             * Group - Um grupo de clientes
             * await Clients.Group("promocoes").ReceberPromocao(promocao);
             *
             * Notificar todos exceto o cliente que enviou a mensagem
             * await Clients.Others.SendAsync("ReceberPromocao", promocao);
             */

            //  Noticar caller (cliente que enviou a mensagem)
            await Clients.Caller.SendAsync("CadastradoSucesso");

            
            await Clients.Others.SendAsync("ReceberPromocao", promocao);
        }
    }
}
