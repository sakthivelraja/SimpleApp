using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp.Repositories
{
    public class SimpleAppRepository : ISimpleAppRepository
    {
        #region "Constructor"
        public SimpleAppRepository()
        {

        }
        #endregion

        #region "Repository Methods"
        /// <summary>
        /// Gets the current Date time
        /// </summary>
        /// <returns>DateTime</returns>
        public DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }
        #endregion

    }
}
