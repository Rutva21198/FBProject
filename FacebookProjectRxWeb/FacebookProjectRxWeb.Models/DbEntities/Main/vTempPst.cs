using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using FacebookProjectRxWeb.BoundedContext.SqlContext;
namespace FacebookProjectRxWeb.Models.Main
{
    [Table("vTempPst",Schema="dbo")]
    public partial class vTempPst
    {

        public string media { get; set; }


        public string caption { get; set; }


        public string message { get; set; }


        public vTempPst()
        {
        }
	}
}