public static class StringFormatCache // TypeDefIndex: 10768
{	// Fields
	private static Dictionary<StringFormatCache.Key1, string> dict1; // 0x0
	private static Dictionary<StringFormatCache.Key2, string> dict2; // 0x8
	private static Dictionary<StringFormatCache.Key3, string> dict3; // 0x10
	private static Dictionary<StringFormatCache.Key4, string> dict4; // 0x18

	// Methods

	// RVA: 0x79E080 Offset: 0x79C680 VA: 0x18079E080
	public static string Get(string format, string value1) { }

	// RVA: 0x79E1C0 Offset: 0x79C7C0 VA: 0x18079E1C0
	public static string Get(string format, string value1, string value2) { }

	// RVA: 0x79E350 Offset: 0x79C950 VA: 0x18079E350
	public static string Get(string format, string value1, string value2, string value3) { }

	// RVA: 0x79DD40 Offset: 0x79C340 VA: 0x18079DD40
	public static string Get(string format, string value1, string value2, string value3, string value4) { }

	// RVA: 0x79E4F0 Offset: 0x79CAF0 VA: 0x18079E4F0
	private static void .cctor() { }

}

private struct StringFormatCache.Key1 : IEquatable<StringFormatCache.Key1> // TypeDefIndex: 10769
{	// Fields
	public string format; // 0x0
	public string value1; // 0x8

	// Methods

	// RVA: 0xF5AD0 Offset: 0xF4ED0 VA: 0x1800F5AD0
	public void .ctor(string format, string value1) { }

	// RVA: 0xF5A70 Offset: 0xF4E70 VA: 0x1800F5A70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF5960 Offset: 0xF4D60 VA: 0x1800F5960 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xF5A10 Offset: 0xF4E10 VA: 0x1800F5A10 Slot: 4
	public bool Equals(StringFormatCache.Key1 other) { }

}

private struct StringFormatCache.Key2 : IEquatable<StringFormatCache.Key2> // TypeDefIndex: 10770
{	// Fields
	public string format; // 0x0
	public string value1; // 0x8
	public string value2; // 0x10

	// Methods

	// RVA: 0xF5CF0 Offset: 0xF50F0 VA: 0x1800F5CF0
	public void .ctor(string format, string value1, string value2) { }

	// RVA: 0xF5C70 Offset: 0xF5070 VA: 0x1800F5C70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF5B10 Offset: 0xF4F10 VA: 0x1800F5B10 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xF5BE0 Offset: 0xF4FE0 VA: 0x1800F5BE0 Slot: 4
	public bool Equals(StringFormatCache.Key2 other) { }

}

private struct StringFormatCache.Key3 : IEquatable<StringFormatCache.Key3> // TypeDefIndex: 10771
{	// Fields
	public string format; // 0x0
	public string value1; // 0x8
	public string value2; // 0x10
	public string value3; // 0x18

	// Methods

	// RVA: 0xF5F70 Offset: 0xF5370 VA: 0x1800F5F70
	public void .ctor(string format, string value1, string value2, string value3) { }

	// RVA: 0xF5EC0 Offset: 0xF52C0 VA: 0x1800F5EC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF5DE0 Offset: 0xF51E0 VA: 0x1800F5DE0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xF5D50 Offset: 0xF5150 VA: 0x1800F5D50 Slot: 4
	public bool Equals(StringFormatCache.Key3 other) { }

}

private struct StringFormatCache.Key4 : IEquatable<StringFormatCache.Key4> // TypeDefIndex: 10772
{	// Fields
	public string format; // 0x0
	public string value1; // 0x8
	public string value2; // 0x10
	public string value3; // 0x18
	public string value4; // 0x20

	// Methods

	// RVA: 0xF62D0 Offset: 0xF56D0 VA: 0x1800F62D0
	public void .ctor(string format, string value1, string value2, string value3, string value4) { }

	// RVA: 0xF61F0 Offset: 0xF55F0 VA: 0x1800F61F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF6100 Offset: 0xF5500 VA: 0x1800F6100 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xF61B0 Offset: 0xF55B0 VA: 0x1800F61B0 Slot: 4
	public bool Equals(StringFormatCache.Key4 other) { }

}

