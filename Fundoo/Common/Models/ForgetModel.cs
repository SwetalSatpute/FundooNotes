//-----------------------------------------------------------------------
// <copyright file="EmailModel.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Fundoo.Common.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Forget Model
    /// </summary>
    public class ForgetModel
    {
        /// <summary>
        /// The email
        /// </summary>
        [Required]
        private string email;

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get => email; set => email = value;}
    }
}
