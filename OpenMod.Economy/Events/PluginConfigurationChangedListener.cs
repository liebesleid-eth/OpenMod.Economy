#region

using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.Extensions.Logging;
using OpenMod.API.Eventing;
using OpenMod.Core.Plugins.Events;
using OpenMod.Core.Users.Events;
using OpenMod.Economy.Controllers;
using OpenMod.Extensions.Economy.Abstractions;

#endregion

namespace OpenMod.Economy.Events
{
    [UsedImplicitly]
    public sealed class PlayerConnectedEvent : IEventListener<IUserConnectedEvent>
    {
        private readonly ILogger<Economy> m_Logger;

        public PlayerConnectedEvent(IEconomyProvider economyProvider, ILogger<Economy> logger)
        {
            m_Logger = logger;
        }


        public async Task HandleEventAsync(object sender, IUserConnectedEvent @event)
        {
            var Usuario = @event.User;

        }
    }
}