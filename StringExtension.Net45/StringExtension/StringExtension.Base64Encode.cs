using System.Text;

namespace System
{
    public static partial class StringExtension
    {
        /// <summary>
        /// 将当前字符串进行 Base64 编码。
        /// </summary>
        /// <param name="value">当前 System.String 对象。</param>
        /// <returns>编码后的字符串。</returns>
        /// <exception cref="System.ArgumentNullException"><c>value</c> 为 null。</exception>
        public static string Base64Encode(this string value)
        {
            var bytes = Encoding.UTF8.GetBytes(value);
            return Convert.ToBase64String(bytes);
        }

        /// <summary>
        /// 将当前字符串进行 Base64 编码。
        /// </summary>
        /// <param name="value">当前 System.String 对象。</param>
        /// <returns>编码后的字符串。</returns>
        public static string Base64EncodeSafely(this string value)
        {
            return string.IsNullOrEmpty(value) ? value : Base64Encode(value);
        }
    }
}
