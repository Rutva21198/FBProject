using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using FacebookProjectRxWeb.Models.Enums.Main;
using FacebookProjectRxWeb.BoundedContext.SqlContext;
namespace FacebookProjectRxWeb.Models.Main
{
    [Table("FacebookApplicationObject",Schema="dbo")]
    public partial class FacebookApplicationObject
    {
		#region ApplicationObjectId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion ApplicationObjectId Annotations

        public int ApplicationObjectId { get; set; }

		#region ApplicationObjectTypeId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("FacebookApplicationObjectType","dbo","","ApplicationObjectTypeId")]
		#endregion ApplicationObjectTypeId Annotations

        public int ApplicationObjectTypeId { get; set; }

		#region ApplicationObjectName Annotations

        [Required]
        [MaxLength(50)]
		#endregion ApplicationObjectName Annotations

        public string ApplicationObjectName { get; set; }

		#region FacebookApplicationObjectType Annotations

        [ForeignKey(nameof(ApplicationObjectTypeId))]
        [InverseProperty(nameof(FacebookProjectRxWeb.Models.Main.FacebookApplicationObjectType.FacebookApplicationObject))]
		#endregion FacebookApplicationObjectType Annotations

        public virtual FacebookApplicationObjectType FacebookApplicationObjectType { get; set; }

		#region UserDetails Annotations

        [InverseProperty("FacebookApplicationObject")]
		#endregion UserDetails Annotations

        public virtual ICollection<UserDetail> UserDetails { get; set; }

		#region FacebookUsers Annotations

        [InverseProperty("FacebookApplicationObject")]
		#endregion FacebookUsers Annotations

        public virtual ICollection<FacebookUser> FacebookUsers { get; set; }


        public FacebookApplicationObject()
        {
			UserDetails = new HashSet<UserDetail>();
			FacebookUsers = new HashSet<FacebookUser>();
        }
	}
}