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
    [Table("FacebookApplicationObjectType",Schema="dbo")]
    public partial class FacebookApplicationObjectType
    {
		#region ApplicationObjectITypeId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion ApplicationObjectITypeId Annotations

        public int ApplicationObjectITypeId { get; set; }

		#region ApplicationObjectTypeName Annotations

        [Required]
        [MaxLength(50)]
		#endregion ApplicationObjectTypeName Annotations

        public string ApplicationObjectTypeName { get; set; }

		#region FacebookApplicationObject Annotations

        [InverseProperty("FacebookApplicationObjectType")]
		#endregion FacebookApplicationObject Annotations

        public virtual ICollection<FacebookApplicationObject> FacebookApplicationObject { get; set; }


        public FacebookApplicationObjectType()
        {
			FacebookApplicationObject = new HashSet<FacebookApplicationObject>();
        }
	}
}