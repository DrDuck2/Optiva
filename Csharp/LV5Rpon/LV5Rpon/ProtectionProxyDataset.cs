using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace LV5Rpon
{
    public class ProtectionProxyDataset : IDataset
    {
        private Dataset dataset;
        private List<int> allowedIDs;
        public User user { private get; set; }
        
        public ProtectionProxyDataset(User user)
        {
            this.allowedIDs = new List<int>(new int[] { 1, 3, 5 });
            this.user = user;
        }

        private bool AuthenticateUser()
        {
            return allowedIDs.Contains(this.user.ID);
        }

        public ReadOnlyCollection<List<string>> GetData()
        {
            if(this.AuthenticateUser())
            {
                if(this.dataset == null)
                {
                    this.dataset = new Dataset(@"C:\Users\vidov\Desktop\Da.txt");
                }
                return this.dataset.GetData();
            }
            return null;
        }
    }
}
