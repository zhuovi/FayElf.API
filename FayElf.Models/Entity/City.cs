

namespace FayElf.Models.Entity
{

    public class City
    {
		/// <summary> 
		/// a_Division_Province.ProvinceId
		/// </summary>

		public string ProvinceId { get; set; }=string.Empty;

		/// <summary> 
		/// 城市编码
		/// </summary>

		public string CityId { get; set; }=string.Empty;

		/// <summary> 
		/// 城市名称
		/// </summary>

		public string CityName { get; set; }=string.Empty;

		/// <summary> 
		/// 城市全名
		/// </summary>

		public string CityFullName { get; set; }=string.Empty;

		/// <summary> 
		/// 聚合名称
		/// </summary>

		public string GatherName { get; set; }=string.Empty;

		/// <summary> 
		/// 聚合全名
		/// </summary>

		public string GatherFullName { get; set; }=string.Empty;

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
