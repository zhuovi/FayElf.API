

namespace FayElf.Models.Entity
{
    public class Province
    {
		/// <summary> 
		/// 省份编码
		/// </summary>
		public string ProvinceId { get; set; }=string.Empty;

		/// <summary> 
		/// 省份简称
		/// </summary>
		public string ProvinceName { get; set; }=string.Empty;

		/// <summary> 
		/// 省份全名
		/// </summary>
		public string ProvinceFullName { get; set; }=string.Empty;

		/// <summary> 
		/// 拼音
		/// </summary>
		public string Pinyin { get; set; }=string.Empty;

		/// <summary> 
		/// 纬度
		/// </summary>
		public decimal Lat { get; set; }

		/// <summary> 
		/// 经度
		/// </summary>
		public decimal Lng { get; set; }


    }
}
