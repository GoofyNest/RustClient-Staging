internal class PropertyNameTable // TypeDefIndex: 5919
{	// Fields
	private static readonly int HashCodeRandomizer; // 0x0
	private int _count; // 0x10
	private PropertyNameTable.Entry[] _entries; // 0x18
	private int _mask; // 0x20

	// Methods

	// RVA: 0x180B730 Offset: 0x1809D30 VA: 0x18180B730
	private static void .cctor() { }

	// RVA: 0x180B770 Offset: 0x1809D70 VA: 0x18180B770
	public void .ctor() { }

	// RVA: 0x180B3A0 Offset: 0x18099A0 VA: 0x18180B3A0
	public string Get(char[] key, int start, int length) { }

	// RVA: 0x180B200 Offset: 0x1809800 VA: 0x18180B200
	public string Add(string key) { }

	// RVA: 0x180AF80 Offset: 0x1809580 VA: 0x18180AF80
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0x180B5D0 Offset: 0x1809BD0 VA: 0x18180B5D0
	private void Grow() { }

	// RVA: 0xF5FB10 Offset: 0xF5E110 VA: 0x180F5FB10
	private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length) { }

}

private class PropertyNameTable.Entry // TypeDefIndex: 5920
{	// Fields
	internal readonly string Value; // 0x10
	internal readonly int HashCode; // 0x18
	internal PropertyNameTable.Entry Next; // 0x20

	// Methods

	// RVA: 0xF5EC10 Offset: 0xF5D210 VA: 0x180F5EC10
	internal void .ctor(string value, int hashCode, PropertyNameTable.Entry next) { }

}

