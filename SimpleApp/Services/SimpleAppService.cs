using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleApp.Repositories;

namespace SimpleApp.Services
{
    public class SimpleAppService : ISimpleAppService
    {
        #region "Private Declarations"

        private ISimpleAppRepository _repo;

        #endregion

        #region "Constructor"
        /// <summary>
        /// Constructor with dependecy injection
        /// </summary>
        /// <param name="repo"></param>
        public SimpleAppService(ISimpleAppRepository repo)
        {
            _repo = repo;
        }

        #endregion

        #region "Service methods"
        /// <summary>
        /// Connects to the repository and gets Date and time
        /// </summary>
        /// <returns>DateTime</returns>
        public DateTime GetCurrentDateTime()
        {
            return _repo.GetCurrentDateTime();
        }

        #endregion

    }
}
