using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FayElf.Models.ViewModel
{
    public class UserInfoView
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
	}
}
