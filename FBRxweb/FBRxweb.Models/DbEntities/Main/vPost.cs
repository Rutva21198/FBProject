using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using FBRxweb.BoundedContext.SqlContext;
namespace FBRxweb.Models.Main
{
    [Table("vPost",Schema="dbo")]
    public partial class vPost
    {

        public string Caption { get; set; }


        public string Comment { get; set; }


        public string Media { get; set; }


        public System.DateTimeOffset CreatedDateTime { get; set; }

		#region LikeId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion LikeId Annotations

        public int LikeId { get; set; }


        public int ShareId { get; set; }


        public vPost()
        {
        }
	}
}