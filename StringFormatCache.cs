public static class StringFormatCache // TypeDefIndex: 10768
{	private static Dictionary<StringFormatCache.Key1, string> dict1; // 0x0
	private static Dictionary<StringFormatCache.Key2, string> dict2; // 0x8
	private static Dictionary<StringFormatCache.Key3, string> dict3; // 0x10
	private static Dictionary<StringFormatCache.Key4, string> dict4; // 0x18


	public static string Get(string format, string value1) { }

	public static string Get(string format, string value1, string value2) { }

	public static string Get(string format, string value1, string value2, string value3) { }

	public static string Get(string format, string value1, string value2, string value3, string value4) { }

	private static void .cctor() { }

}

private struct StringFormatCache.Key1 : IEquatable<StringFormatCache.Key1> // TypeDefIndex: 10769
{	public string format; // 0x0
	public string value1; // 0x8


	public void .ctor(string format, string value1) { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(StringFormatCache.Key1 other) { }

}

private struct StringFormatCache.Key2 : IEquatable<StringFormatCache.Key2> // TypeDefIndex: 10770
{	public string format; // 0x0
	public string value1; // 0x8
	public string value2; // 0x10


	public void .ctor(string format, string value1, string value2) { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(StringFormatCache.Key2 other) { }

}

private struct StringFormatCache.Key3 : IEquatable<StringFormatCache.Key3> // TypeDefIndex: 10771
{	public string format; // 0x0
	public string value1; // 0x8
	public string value2; // 0x10
	public string value3; // 0x18


	public void .ctor(string format, string value1, string value2, string value3) { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(StringFormatCache.Key3 other) { }

}

private struct StringFormatCache.Key4 : IEquatable<StringFormatCache.Key4> // TypeDefIndex: 10772
{	public string format; // 0x0
	public string value1; // 0x8
	public string value2; // 0x10
	public string value3; // 0x18
	public string value4; // 0x20


	public void .ctor(string format, string value1, string value2, string value3, string value4) { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(StringFormatCache.Key4 other) { }

}

