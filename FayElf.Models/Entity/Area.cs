

namespace FayElf.Models.Entity
{
    public class Area
    {

		public string CityId { get; set; }=string.Empty;

		/// <summary> 
		/// 区县编码
		/// </summary>
		public string AreaId { get; set; }=string.Empty;

		/// <summary> 
		/// 区县名称
		/// </summary>
		public string AreaName { get; set; }=string.Empty;

		/// <summary> 
		/// 区县全名
		/// </summary>
		public string AreaFullName { get; set; }=string.Empty;

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
