using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth.Demo
{
    public interface IJwtAuthenticationManager
    {
        string AuthenticatedEncryptorConfiguration(string username, string password);
    }
}
