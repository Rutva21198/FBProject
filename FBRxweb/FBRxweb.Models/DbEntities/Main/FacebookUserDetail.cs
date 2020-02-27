using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using FBRxweb.Models.Enums.Main;
using FBRxweb.BoundedContext.SqlContext;
namespace FBRxweb.Models.Main
{
    [Table("FacebookUserDetails",Schema="dbo")]
    public partial class FacebookUserDetail
    {
		#region UserDetailId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion UserDetailId Annotations

        public int UserDetailId { get; set; }

		#region UserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion UserId Annotations

        public int UserId { get; set; }

		#region CurrentCity Annotations

        [MaxLength(30)]
		#endregion CurrentCity Annotations

        public string CurrentCity { get; set; }

		#region HomeTown Annotations

        [MaxLength(50)]
		#endregion HomeTown Annotations

        public string HomeTown { get; set; }


        public Nullable<int> RelationshipAO { get; set; }


        public string Bio { get; set; }


        public Nullable<int> ProfilePhotoId { get; set; }


        public Nullable<int> CoverPhotoId { get; set; }


        public FacebookUserDetail()
        {
        }
	}
}