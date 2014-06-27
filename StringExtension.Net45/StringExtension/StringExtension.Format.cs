
namespace System
{
    public static partial class StringExtension
    {
        /// <summary>
        /// 将指定字符串中的格式项替换为指定数组中相应对象的字符串表示形式。
        /// </summary>
        /// <param name="format">符合格式字符串（参见“备注”）。</param>
        /// <param name="args">一个对象数组，其中包含零个或多个要设置格式的对象。</param>
        /// <returns>format 的一个副本，其中格式项已替换为 args 中相应对象的字符串表示形式。</returns>
        /// <exception cref="System.ArgumentNullException"><c>format</c> 或 <c>args</c> 为 null。</exception>
        /// <exception cref="System.FormatException"><c>format</c> 无效。 - 或 - 格式项的索引小于零或大于等于 <c>args</c> 数组的长度。</exception>
        public static string Format(this string format, params object[] args)
        {
            return string.Format(format, args);
        }
    }
}
