using crm.Entity.Data.Client;
using crm.Entity.Data.Prospect;
using crm.Services.Interface;
//test
namespace crm.Services.Implements
{
    public class ClientService : IClientService
    {
        public readonly ClientList listClient = new();
        public readonly ProspectList listProspect = new();

        public int TotalCP()
        {
            int total;

            int _client = listClient._clientList.Count;
            int _prospect = listProspect._prospectList.Count;

            total = _client + _prospect;

            return total;
        }
    }
}