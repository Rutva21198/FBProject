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
    [Table("FacebookUsers",Schema="dbo")]
    public partial class FacebookUser
    {
		#region UserID Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion UserID Annotations

        public int UserID { get; set; }

		#region FirstName Annotations

        [Required]
        [MaxLength(50)]
		#endregion FirstName Annotations

        public string FirstName { get; set; }

		#region LastName Annotations

        [Required]
        [MaxLength(50)]
		#endregion LastName Annotations

        public string LastName { get; set; }

		#region MobileNo Annotations

        [Required]
		#endregion MobileNo Annotations

        public long MobileNo { get; set; }

		#region Email Annotations

        [Required]
        [MaxLength(50)]
		#endregion Email Annotations

        public string Email { get; set; }

		#region Password Annotations

        [Required]
        [MaxLength(200)]
		#endregion Password Annotations

        public byte[] Password { get; set; }

		#region DateOfBirth Annotations

        [Required]
		#endregion DateOfBirth Annotations

        public System.DateTime DateOfBirth { get; set; }

		#region GenderAO Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion GenderAO Annotations

        public int GenderAO { get; set; }

		#region CreatedDateTime Annotations

        [Required]
		#endregion CreatedDateTime Annotations

        public System.DateTimeOffset CreatedDateTime { get; set; }

		#region LoginStatus Annotations

        [Required]
		#endregion LoginStatus Annotations

        public bool LoginStatus { get; set; }

		#region Salt Annotations

        [Required]
        [MaxLength(140)]
		#endregion Salt Annotations

        public byte[] Salt { get; set; }


        public FacebookUser()
        {
        }
	}
}