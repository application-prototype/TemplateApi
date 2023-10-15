
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Utilities
{
    public class UserAccessor 
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserAccessor(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Guid Id => GetId(_httpContextAccessor);
        public bool IsAuthenticated => IsUserAuthenticated(_httpContextAccessor);

        public string Email => throw new NotImplementedException();

        private bool IsUserAuthenticated(IHttpContextAccessor httpContextAccessor)
        {
            var isAuthenticated = httpContextAccessor.HttpContext?.User?.Identity?.IsAuthenticated;
            return isAuthenticated.HasValue && isAuthenticated.Value == true;
        }

        private Guid GetId(IHttpContextAccessor httpContextAccessor)
        {
            //get the id from token first, then consumer id
            //var userUuid = httpContextAccessor.HttpContext?.User.GetUuid() ?? Guid.Empty;

            //if (userUuid == Guid.Empty)
            //{
            //    var consumerId = httpContextAccessor.HttpContext?.Request.Headers[AuthConstants.ConsumerIdHeaderName].ToString();

            //    if (!string.IsNullOrEmpty(consumerId) && Guid.TryParse(consumerId, out var id))
            //    {
            //        return id;
            //    }
            //}

            //return userUuid;
            return Guid.NewGuid();
        }
    }
}
