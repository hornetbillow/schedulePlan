using System.Text.RegularExpressions;

namespace Raise.Monitor.Tools {
  public  static class RegexUtils {
      /// <summary>
      /// 验证是否是整数或者小数
      /// </summary>
      /// <param name="content">验证文本</param>
      /// <returns>返回验证结果</returns>
      public static bool IsNumerric(string content) {
          return new Regex(RegexConstants.NUMERIC_REGEX).IsMatch(content);
      }

      /// <summary>
      /// 验证是否是整数
      /// </summary>
      /// <param name="content">验证文本</param>
      /// <returns>返回验证结果</returns>
      public static bool IsNumber(string content) {
          return new Regex(RegexConstants.NUMBER_REGEX).IsMatch(content);
      }
    }
}
