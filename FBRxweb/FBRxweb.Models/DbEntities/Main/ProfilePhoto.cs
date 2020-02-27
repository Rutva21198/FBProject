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
    [Table("ProfilePhotos",Schema="dbo")]
    public partial class ProfilePhoto
    {
		#region ProfilePhotoId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion ProfilePhotoId Annotations

        public int ProfilePhotoId { get; set; }

		#region Photo Annotations

        [Required]
		#endregion Photo Annotations

        public string Photo { get; set; }

		#region UserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion UserId Annotations

        public int UserId { get; set; }


        public ProfilePhoto()
        {
        }
	}
}