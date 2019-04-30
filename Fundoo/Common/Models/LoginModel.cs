//-----------------------------------------------------------------------
// <copyright file="LoginModel.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Fundoo.Common.Models
{
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Login Model
    /// </summary>
    public class LoginModel
    {
        /// <summary>
        /// The user name
        /// </summary>
        private string userName;

        /// <summary>
        /// The password
        /// </summary>
        private string password;

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        public string UserName { get => this.userName; set => this.userName = value; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get => this.password; set => this.password = value; }
    }
}
