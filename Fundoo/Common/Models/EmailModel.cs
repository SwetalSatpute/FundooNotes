//-----------------------------------------------------------------------
// <copyright file="EmailModel.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace Fundoo.Common.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// email Model
    /// </summary>
    public class EmailModel
    {
        /// <summary>
        /// Gets or sets from address.
        /// </summary>
        /// <value>
        /// From address.
        /// </value>
        public string FromAddress { get; set; }

        /// <summary>
        /// Gets or sets the SMTP client.
        /// </summary>
        /// <value>
        /// The SMTP client.
        /// </value>
        public string SmtpClient { get; set; }

        /// <summary>
        /// Gets or sets the pasword.
        /// </summary>
        /// <value>
        /// The pasword.
        /// </value>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the u ser identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public string UserID { get; set; }

        /// <summary>
        /// Gets or sets the SMTP port.
        /// </summary>
        /// <value>
        /// The SMTP port.
        /// </value>
        public int SMTPPort { get; set; }

        /// <summary>
        /// Gets or sets the enable SSL.
        /// </summary>
        /// <value>
        /// The enable SSL.
        /// </value>
        public string EnableSsl { get; set; }
    }
}
