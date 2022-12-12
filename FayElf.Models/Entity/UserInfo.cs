

namespace FayElf.Models.Entity
{
	public class UserInfo
	{
		/// <summary> 
		/// GUID
		/// </summary>
		public string Id { get; set; } = string.Empty;

		/// <summary> 
		/// </summary>
		public string Code { get; set; } = string.Empty;

		/// <summary> 
		/// 姓名
		/// </summary>
		public string Name { get; set; } = string.Empty;

		/// <summary> 
		/// M 男、F 女、 ‘ ’ 保密
		/// </summary>
		public string Gender { get; set; } = string.Empty;

		/// <summary> 
		/// 企业微信
		/// </summary>
		public string EnterpriseWechat { get; set; } = string.Empty;

		/// <summary> 
		/// 职务
		/// </summary>
		public string PostJob { get; set; } = string.Empty;

		/// <summary> 
		/// 所属公司
		/// </summary>
		public string Company { get; set; } = string.Empty;

		/// <summary> 
		/// 可作为登录凭证
		/// </summary>
		public string Email { get; set; } = string.Empty;

		/// <summary> 
		/// 可作为登录凭证
		/// </summary>
		public string Mobile { get; set; } = string.Empty;

		/// <summary> 
		/// 先esc，再md5
		/// </summary>
		public string Password { get; set; } = string.Empty;


		/// <summary> 
		/// 备注
		/// </summary>
		public string Remark { get; set; } = string.Empty;


		/// <summary> 
		/// ACTIVE、INACTIVE
		/// </summary>
		public string Status { get; set; } = string.Empty;

		/// <summary> 
		/// b_User.UserId
		/// </summary>
		public string CreateUserId { get; set; } = string.Empty;

		/// <summary> 
		/// 创建时间
		/// </summary>
		public DateTime CreateStamp { get; set; } = DateTime.Now.ToLocalTime();

		/// <summary> 
		/// </summary>
		public string ModifyUserId { get; set; } = string.Empty;

		/// <summary> 
		/// 修改时间
		/// </summary>
		public DateTime ModifyStamp { get; set; }
        /// <summary> 
        /// 1:删除；0:正常
        /// </summary>
        public bool IsDelete { get; set; } = false;

        /// <summary> 
        /// b_User.UserId
        /// </summary>
        public string DeleteUserId { get; set; } = string.Empty;

        /// <summary> 
        /// 删除时间
        /// </summary>
        public DateTime? DeleteStamp { get; set; }


	}
}
