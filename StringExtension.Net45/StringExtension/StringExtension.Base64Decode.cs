using System.Text;

namespace System
{
    public static partial class StringExtension
    {
        /// <summary>
        /// 将当前字符串进行 Base64 解码。
        /// </summary>
        /// <param name="value">当前 System.String 对象。</param>
        /// <returns>解码后的字符串。</returns>
        /// <exception cref="System.ArgumentNullException"><c>value</c> 为 null。</exception>
        public static string Base64Decode(this string value)
        {
            byte[] bytes = Convert.FromBase64String(value);
            return Encoding.UTF8.GetString(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// 将当前字符串进行 Base64 解码。
        /// </summary>
        /// <param name="value">当前 System.String 对象。</param>
        /// <returns>解码后的字符串。</returns>
        public static string Base64DecodeSafely(this string value)
        {
            return string.IsNullOrEmpty(value) ? value : Base64Decode(value);
        }
    }
}
