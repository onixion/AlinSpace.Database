﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AlinSpace.Database.Feuer.Models
{
    /// <summary>
    /// Represents the page model.
    /// </summary>
    public class Page
    {
        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        [Key]
        [Required]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the page name.
        /// </summary>
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [MaxLength(100)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the flag indicating whether or not the group is public accessible.
        /// </summary>
        public bool IsPublic { get; set; }

        /// <summary>
        /// Gets or sets the flag indicating whether or not the group is listed in the search.
        /// </summary>
        public bool IsListed { get; set; }

        /// <summary>
        /// Gets or sets the priority.
        /// </summary>
        /// <remarks>
        /// The higher the priority, the higher the value.
        /// </remarks>
        public long Priority { get; set; }

        /// <summary>
        /// Gets or sets the body HTML of the page.
        /// </summary>
        public string BodyHtml { get; set; }

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        public IList<Tag> Tags { get; set; } = new List<Tag>();

        /// <summary>
        /// Gets or sets the owner.
        /// </summary>
        [Required]
        public User Owner { get; set; }
    }
}
