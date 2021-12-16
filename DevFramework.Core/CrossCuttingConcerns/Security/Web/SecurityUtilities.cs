using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace DevFramework.Core.CrossCuttingConcerns.Security.Web
{
    public class SecurityUtilities
    {
        public Identity FormAuthTicketToIdentity(FormsAuthenticationTicket ticket)
        {
            var identity = new Identity
            {
                Id= setId(ticket),
                Name= setName(ticket),
                Email= setEmail(ticket),
                Roles= setRoles(ticket),
                FirstName= setFirstName(ticket),
                LastName= setLastName(ticket),
                AuthenticationType= setAuthType(),
                IsAuthenticated=setIsAuthenticated()
            };
            return identity;
        }

        private bool setIsAuthenticated()
        {
            return true;
        }

        private string setAuthType()
        {
            return "Forms";
        }

        private string setLastName(FormsAuthenticationTicket ticket)
        {
            string[] data = ticket.UserData.Split('|');
            return data[3];
        }

        private string setFirstName(FormsAuthenticationTicket ticket)
        {
            string[] data = ticket.UserData.Split('|');
            return data[2];
        }

        private string[] setRoles(FormsAuthenticationTicket ticket)
        {
            string[] data = ticket.UserData.Split('|');
            string[] roles = data[1].Split(new char[] { ',' },StringSplitOptions.RemoveEmptyEntries);
            return roles;
        }

        private string setEmail(FormsAuthenticationTicket ticket)
        {
            string[] data = ticket.UserData.Split('|');
            return data[0];
        }

        private string setName(FormsAuthenticationTicket ticket)
        {
            return ticket.Name;
        }

        private Guid setId(FormsAuthenticationTicket ticket)
        {
            string[] data = ticket.UserData.Split('|');
            return new Guid(data[4]);
        }
    }
}
