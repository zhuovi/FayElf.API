
namespace FayElf.Models.Entity
{
    public class Site
    {
		/// <summary> 
		/// ID
		/// </summary>
		public string Id { get; set; }=string.Empty;

		/// <summary> 
		/// Code
		/// </summary>
		public string SiteCode { get; set; }=string.Empty;

		/// <summary> 
		/// 名称
		/// </summary>
		public string SiteName { get; set; }=string.Empty;

		/// <summary> 
		/// 图标
		/// </summary>
		public string SiteLogo { get; set; }=string.Empty;

		/// <summary> 
		/// 路径
		/// </summary>
		public string SiteUrl { get; set; }=string.Empty;

		/// <summary> 
		/// 描述
		/// </summary>
		public string Description { get; set; }=string.Empty;

		/// <summary> 
		/// ACTIVE、INACTIVE
		/// </summary>
		public string Status { get; set; }=string.Empty;

		/// <summary> 
		/// b_User.UserId
		/// </summary>
		public string CreateUserId { get; set; }=string.Empty;

		/// <summary> 
		/// 创建时间
		/// </summary>
		public DateTime CreateStamp { get; set; }

		/// <summary> 
		/// </summary>
		public string ModifyUserId { get; set; }=string.Empty;

		/// <summary> 
		/// 修改时间
		/// </summary>
		public DateTime ModifyStamp { get; set; }


    }
}
