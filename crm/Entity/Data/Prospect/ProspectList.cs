using System;
using System.Collections.Generic;

namespace crm.Entity.Data.Prospect
{
    public class ProspectList
    {
        public List<string> _prospectList = new();

        public ProspectList()
        {
        }

        public void AddtoListP(string toAdd)
        {
            _prospectList.Add(toAdd);
        }
    }
}
