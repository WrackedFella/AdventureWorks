using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Domain.Core
{
	public abstract class EntityBase
	{
        protected Guid Id { get; set; }
        [Display(Name ="CreatedBy")]
        public string CreatedBy { get; set; }
        [Display(Name ="CreatedDate"), DisplayFormat(DataFormatString = "{0:g}")]
        public DateTime CreatedDate { get; set; }
        [Display(Name ="LastModifiedBy")]
        public string LastModifiedBy { get; set; }
        [Display(Name ="LastModifiedDate"), DisplayFormat(DataFormatString = "{0:g}")]
        public DateTime LastModifiedDate { get; set; }
        public bool IsActive { get; set; } = true;

        public virtual void Deactivate()
        {
            this.IsActive = false;
        }

        internal void SetAuditDetails(string username)
        {
            this.LastModifiedBy = username;
            this.LastModifiedDate = DateTime.Now;

            if (!string.IsNullOrEmpty(this.CreatedBy))
            {
                return;
            }
            this.CreatedBy = username;
            this.CreatedDate = DateTime.Now;
        }


        /// <summary>
        /// The ID's in concrete Entities are named after the class (MotherId, ChildId, etc).
        /// This method allows us to access the ID in a common way, regardless of the concrete type.
        /// Useful when using generic classes that act on the base type, but need the GUID for the object.
        /// </summary>
        /// <returns>The GUID of the record.</returns>
        public Guid GetId() => this.Id;
	}
}
