public static class StringFormatCache // TypeDefIndex: 10768
{	// Fields
	private static Dictionary<StringFormatCache.Key1, string> dict1; // 0x0
	private static Dictionary<StringFormatCache.Key2, string> dict2; // 0x8
	private static Dictionary<StringFormatCache.Key3, string> dict3; // 0x10
	private static Dictionary<StringFormatCache.Key4, string> dict4; // 0x18

	// Methods

	// RVA: 0x79E190 Offset: 0x79C790 VA: 0x18079E190
	public static string Get(string format, string value1) { }

	// RVA: 0x79E2D0 Offset: 0x79C8D0 VA: 0x18079E2D0
	public static string Get(string format, string value1, string value2) { }

	// RVA: 0x79E460 Offset: 0x79CA60 VA: 0x18079E460
	public static string Get(string format, string value1, string value2, string value3) { }

	// RVA: 0x79DE50 Offset: 0x79C450 VA: 0x18079DE50
	public static string Get(string format, string value1, string value2, string value3, string value4) { }

	// RVA: 0x79E600 Offset: 0x79CC00 VA: 0x18079E600
	private static void .cctor() { }

}

private struct StringFormatCache.Key1 : IEquatable<StringFormatCache.Key1> // TypeDefIndex: 10769
{	// Fields
	public string format; // 0x0
	public string value1; // 0x8

	// Methods

	// RVA: 0xF5A50 Offset: 0xF4E50 VA: 0x1800F5A50
	public void .ctor(string format, string value1) { }

	// RVA: 0xF59F0 Offset: 0xF4DF0 VA: 0x1800F59F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF58E0 Offset: 0xF4CE0 VA: 0x1800F58E0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xF5990 Offset: 0xF4D90 VA: 0x1800F5990 Slot: 4
	public bool Equals(StringFormatCache.Key1 other) { }

}

private struct StringFormatCache.Key2 : IEquatable<StringFormatCache.Key2> // TypeDefIndex: 10770
{	// Fields
	public string format; // 0x0
	public string value1; // 0x8
	public string value2; // 0x10

	// Methods

	// RVA: 0xF5C70 Offset: 0xF5070 VA: 0x1800F5C70
	public void .ctor(string format, string value1, string value2) { }

	// RVA: 0xF5BF0 Offset: 0xF4FF0 VA: 0x1800F5BF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF5A90 Offset: 0xF4E90 VA: 0x1800F5A90 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xF5B60 Offset: 0xF4F60 VA: 0x1800F5B60 Slot: 4
	public bool Equals(StringFormatCache.Key2 other) { }

}

private struct StringFormatCache.Key3 : IEquatable<StringFormatCache.Key3> // TypeDefIndex: 10771
{	// Fields
	public string format; // 0x0
	public string value1; // 0x8
	public string value2; // 0x10
	public string value3; // 0x18

	// Methods

	// RVA: 0xF5EF0 Offset: 0xF52F0 VA: 0x1800F5EF0
	public void .ctor(string format, string value1, string value2, string value3) { }

	// RVA: 0xF5E40 Offset: 0xF5240 VA: 0x1800F5E40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF5D60 Offset: 0xF5160 VA: 0x1800F5D60 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xF5CD0 Offset: 0xF50D0 VA: 0x1800F5CD0 Slot: 4
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

	// RVA: 0xF6250 Offset: 0xF5650 VA: 0x1800F6250
	public void .ctor(string format, string value1, string value2, string value3, string value4) { }

	// RVA: 0xF6170 Offset: 0xF5570 VA: 0x1800F6170 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF6080 Offset: 0xF5480 VA: 0x1800F6080 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xF6130 Offset: 0xF5530 VA: 0x1800F6130 Slot: 4
	public bool Equals(StringFormatCache.Key4 other) { }

}

