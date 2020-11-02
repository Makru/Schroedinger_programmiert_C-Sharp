namespace Codes {
	using System;

	public static class StringExtensions {
		public static string UpperCaseLetters(this string text, int letterCount = 1) {
			if (String.IsNullOrEmpty(text))
				return text;

			char[] chars = text.ToCharArray();
			for (int i = 0; i < letterCount && i < text.Length; i++)
				chars[i] = char.ToUpper(chars[i]);
			return new string(chars);
		}
	}
}
