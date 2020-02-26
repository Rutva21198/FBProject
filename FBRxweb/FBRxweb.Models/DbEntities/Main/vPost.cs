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

        public string FirstName { get; set; }


        public string Caption { get; set; }


        public string Comment { get; set; }


        public string Media { get; set; }


        public System.DateTimeOffset CreatedDateTime { get; set; }


        public vPost()
        {
        }
	}
}