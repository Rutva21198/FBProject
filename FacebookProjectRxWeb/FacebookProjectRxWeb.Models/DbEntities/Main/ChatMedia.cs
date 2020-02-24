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
    [Table("ChatMedia",Schema="dbo")]
    public partial class ChatMedia
    {
		#region MediaId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion MediaId Annotations

        public int MediaId { get; set; }

		#region Media Annotations

        [Required]
		#endregion Media Annotations

        public string Media { get; set; }

		#region MediaTypeAO Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion MediaTypeAO Annotations

        public int MediaTypeAO { get; set; }

		#region SenderId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("FacebookUsers","dbo","","SenderId")]
       
		#endregion SenderId Annotations

        public int SenderId { get; set; }

		#region ReceiverId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("FacebookUsers","dbo","","ReceiverId")]
		#endregion ReceiverId Annotations

        public int ReceiverId { get; set; }

		#region SendDateTime Annotations

        [Required]
		#endregion SendDateTime Annotations

        public System.DateTimeOffset SendDateTime { get; set; }

		#region FacebookUser Annotations

        [ForeignKey(nameof(SenderId))]
        [InverseProperty(nameof(FacebookProjectRxWeb.Models.Main.FacebookUser.ChatMedia))]
		#endregion FacebookUser Annotations

        public virtual FacebookUser FacebookUser { get; set; }


        public ChatMedia()
        {
        }
	}
}