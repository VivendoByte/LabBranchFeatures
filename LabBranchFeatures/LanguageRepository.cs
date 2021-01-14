using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBranchFeatures
{
    public class LanguageRepository : IDisposable
    {
        public IDMLManager IDMLManager { get; private set; }

        public LanguageRepository(IDMLManager manager)
        {
            this.IDMLManager = manager;
        }

        public void Cancel()
        {

        }

        public void SaveChanges()
        {

        }

        public void Dispose()
        {
            this.IDMLManager.Dispose();
        }
    }
}