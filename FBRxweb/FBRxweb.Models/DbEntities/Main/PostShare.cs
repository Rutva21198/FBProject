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
    [Table("PostShares",Schema="dbo")]
    public partial class PostShare
    {
		#region ShareId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion ShareId Annotations

        public int ShareId { get; set; }

		#region PostId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion PostId Annotations

        public int PostId { get; set; }

		#region UserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion UserId Annotations

        public int UserId { get; set; }


        public PostShare()
        {
        }
	}
}