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
    [Table("Posts",Schema="dbo")]
    public partial class Post
    {
		#region PostId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion PostId Annotations

        public int PostId { get; set; }

		#region UserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("FacebookUsers","dbo","","UserId")]
		#endregion UserId Annotations

        public int UserId { get; set; }

		#region Media Annotations

        [Required]
		#endregion Media Annotations

        public string Media { get; set; }

		#region CreatedDateTime Annotations

        [Required]
		#endregion CreatedDateTime Annotations

        public System.DateTimeOffset CreatedDateTime { get; set; }

		#region MediaTypeAO Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion MediaTypeAO Annotations

        public int MediaTypeAO { get; set; }

		#region FacebookUser Annotations

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(FacebookProjectRxWeb.Models.Main.FacebookUser.Posts))]
		#endregion FacebookUser Annotations

        public virtual FacebookUser FacebookUser { get; set; }


        public Post()
        {
        }
	}
}