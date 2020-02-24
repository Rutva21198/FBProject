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

        public string Password { get; set; }

		#region DateOfBirth Annotations

        [Required]
		#endregion DateOfBirth Annotations

        public System.DateTime DateOfBirth { get; set; }

		#region GenderAO Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("FacebookApplicationObject","dbo","","GenderAO")]
		#endregion GenderAO Annotations

        public int GenderAO { get; set; }

		#region CreatedDateTime Annotations

        [Required]
		#endregion CreatedDateTime Annotations

        public System.DateTimeOffset CreatedDateTime { get; set; }

		#region FacebookApplicationObject Annotations

        [ForeignKey(nameof(GenderAO))]
        [InverseProperty(nameof(FacebookProjectRxWeb.Models.Main.FacebookApplicationObject.FacebookUsers))]
		#endregion FacebookApplicationObject Annotations

        public virtual FacebookApplicationObject FacebookApplicationObject { get; set; }

		#region CoverPhotos Annotations

        [InverseProperty("FacebookUser")]
		#endregion CoverPhotos Annotations

        public virtual ICollection<CoverPhoto> CoverPhotos { get; set; }

		#region Posts Annotations

        [InverseProperty("FacebookUser")]
		#endregion Posts Annotations

        public virtual ICollection<Post> Posts { get; set; }

		#region PostMessages Annotations

        [InverseProperty("FacebookUser")]
		#endregion PostMessages Annotations

        public virtual ICollection<PostMessage> PostMessages { get; set; }

		#region ChatMedia Annotations

        [InverseProperty("FacebookUser")]
		#endregion ChatMedia Annotations

        public virtual ICollection<ChatMedia> ChatMedia { get; set; }

	

		#region ChatMessages Annotations

        [InverseProperty("FacebookUser")]
		#endregion ChatMessages Annotations

        public virtual ICollection<ChatMessage> ChatMessages { get; set; }

		

		#region LogActivities Annotations

        [InverseProperty("FacebookUser")]
		#endregion LogActivities Annotations

        public virtual ICollection<LogActivity> LogActivities { get; set; }

		#region PostComments Annotations

        [InverseProperty("FacebookUser")]
		#endregion PostComments Annotations

        public virtual ICollection<PostComment> PostComments { get; set; }

		#region PostLikes Annotations

        [InverseProperty("FacebookUser")]
		#endregion PostLikes Annotations

        public virtual ICollection<PostLike> PostLikes { get; set; }

		#region PostShares Annotations

        [InverseProperty("FacebookUser")]
		#endregion PostShares Annotations

        public virtual ICollection<PostShare> PostShares { get; set; }

		#region ProfilePhotos Annotations

        [InverseProperty("FacebookUser")]
		#endregion ProfilePhotos Annotations

        public virtual ICollection<ProfilePhoto> ProfilePhotos { get; set; }

		#region UserDetails Annotations

        [InverseProperty("FacebookUser")]
		#endregion UserDetails Annotations

        public virtual ICollection<UserDetail> UserDetails { get; set; }

		#region UserWorks Annotations

        [InverseProperty("FacebookUser")]
		#endregion UserWorks Annotations

        public virtual ICollection<UserWork> UserWorks { get; set; }


        public FacebookUser()
        {
			CoverPhotos = new HashSet<CoverPhoto>();
			Posts = new HashSet<Post>();
			PostMessages = new HashSet<PostMessage>();
			ChatMedia = new HashSet<ChatMedia>();
			ChatMessages = new HashSet<ChatMessage>();
			LogActivities = new HashSet<LogActivity>();
			PostComments = new HashSet<PostComment>();
			PostLikes = new HashSet<PostLike>();
			PostShares = new HashSet<PostShare>();
			ProfilePhotos = new HashSet<ProfilePhoto>();
			UserDetails = new HashSet<UserDetail>();
			UserWorks = new HashSet<UserWork>();
        }
	}
}