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
    [Table("LogActivities",Schema="dbo")]
    public partial class LogActivity
    {
		#region LogActivityId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion LogActivityId Annotations

        public int LogActivityId { get; set; }

		#region UserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("FacebookUsers","dbo","","UserId")]
		#endregion UserId Annotations

        public int UserId { get; set; }

		#region FacebookUser Annotations

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(FacebookProjectRxWeb.Models.Main.FacebookUser.LogActivities))]
		#endregion FacebookUser Annotations

        public virtual FacebookUser FacebookUser { get; set; }


        public LogActivity()
        {
        }
	}
}