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
    [Table("CoverPhotos",Schema="dbo")]
    public partial class CoverPhoto
    {
		#region CoverPhotoId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion CoverPhotoId Annotations

        public int CoverPhotoId { get; set; }

		#region Photo Annotations

        [Required]
		#endregion Photo Annotations

        public string Photo { get; set; }

		#region UserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion UserId Annotations

        public int UserId { get; set; }


        public CoverPhoto()
        {
        }
	}
}