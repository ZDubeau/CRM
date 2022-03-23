using System;
using System.Collections.Generic;

namespace crm.Entity.Data.Client
{
    public class ClientList
    {
        public List<string> _clientList = new();

        public ClientList()
        {
        }

        public void AddtoList(string toAdd)
        {
            _clientList.Add(toAdd);
        }
    }
}
