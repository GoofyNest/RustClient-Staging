public static class StringFormatCache // TypeDefIndex: 10768
{	// Fields
	private static Dictionary<StringFormatCache.Key1, string> dict1; // 0x0
	private static Dictionary<StringFormatCache.Key2, string> dict2; // 0x8
	private static Dictionary<StringFormatCache.Key3, string> dict3; // 0x10
	private static Dictionary<StringFormatCache.Key4, string> dict4; // 0x18

	// Methods

	// RVA: 0x7BC590 Offset: 0x7BAB90 VA: 0x1807BC590
	public static string Get(string format, string value1) { }

	// RVA: 0x7BC6D0 Offset: 0x7BACD0 VA: 0x1807BC6D0
	public static string Get(string format, string value1, string value2) { }

	// RVA: 0x7BC860 Offset: 0x7BAE60 VA: 0x1807BC860
	public static string Get(string format, string value1, string value2, string value3) { }

	// RVA: 0x7BC250 Offset: 0x7BA850 VA: 0x1807BC250
	public static string Get(string format, string value1, string value2, string value3, string value4) { }

	// RVA: 0x7BCA00 Offset: 0x7BB000 VA: 0x1807BCA00
	private static void .cctor() { }

}

private struct StringFormatCache.Key1 : IEquatable<StringFormatCache.Key1> // TypeDefIndex: 10769
{	// Fields
	public string format; // 0x0
	public string value1; // 0x8

	// Methods

	// RVA: 0xF5DB0 Offset: 0xF51B0 VA: 0x1800F5DB0
	public void .ctor(string format, string value1) { }

	// RVA: 0xF5D50 Offset: 0xF5150 VA: 0x1800F5D50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF5C40 Offset: 0xF5040 VA: 0x1800F5C40 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xF5CF0 Offset: 0xF50F0 VA: 0x1800F5CF0 Slot: 4
	public bool Equals(StringFormatCache.Key1 other) { }

}

private struct StringFormatCache.Key2 : IEquatable<StringFormatCache.Key2> // TypeDefIndex: 10770
{	// Fields
	public string format; // 0x0
	public string value1; // 0x8
	public string value2; // 0x10

	// Methods

	// RVA: 0xF5FD0 Offset: 0xF53D0 VA: 0x1800F5FD0
	public void .ctor(string format, string value1, string value2) { }

	// RVA: 0xF5F50 Offset: 0xF5350 VA: 0x1800F5F50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF5DF0 Offset: 0xF51F0 VA: 0x1800F5DF0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xF5EC0 Offset: 0xF52C0 VA: 0x1800F5EC0 Slot: 4
	public bool Equals(StringFormatCache.Key2 other) { }

}

private struct StringFormatCache.Key3 : IEquatable<StringFormatCache.Key3> // TypeDefIndex: 10771
{	// Fields
	public string format; // 0x0
	public string value1; // 0x8
	public string value2; // 0x10
	public string value3; // 0x18

	// Methods

	// RVA: 0xF6250 Offset: 0xF5650 VA: 0x1800F6250
	public void .ctor(string format, string value1, string value2, string value3) { }

	// RVA: 0xF61A0 Offset: 0xF55A0 VA: 0x1800F61A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF60C0 Offset: 0xF54C0 VA: 0x1800F60C0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xF6030 Offset: 0xF5430 VA: 0x1800F6030 Slot: 4
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

	// RVA: 0xF65B0 Offset: 0xF59B0 VA: 0x1800F65B0
	public void .ctor(string format, string value1, string value2, string value3, string value4) { }

	// RVA: 0xF64D0 Offset: 0xF58D0 VA: 0x1800F64D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF63E0 Offset: 0xF57E0 VA: 0x1800F63E0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xF6490 Offset: 0xF5890 VA: 0x1800F6490 Slot: 4
	public bool Equals(StringFormatCache.Key4 other) { }

}

