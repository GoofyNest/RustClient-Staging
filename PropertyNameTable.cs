internal class PropertyNameTable // TypeDefIndex: 5919
{	// Fields
	private static readonly int HashCodeRandomizer; // 0x0
	private int _count; // 0x10
	private PropertyNameTable.Entry[] _entries; // 0x18
	private int _mask; // 0x20

	// Methods

	// RVA: 0x180B9F0 Offset: 0x1809FF0 VA: 0x18180B9F0
	private static void .cctor() { }

	// RVA: 0x180BA30 Offset: 0x180A030 VA: 0x18180BA30
	public void .ctor() { }

	// RVA: 0x180B660 Offset: 0x1809C60 VA: 0x18180B660
	public string Get(char[] key, int start, int length) { }

	// RVA: 0x180B4C0 Offset: 0x1809AC0 VA: 0x18180B4C0
	public string Add(string key) { }

	// RVA: 0x180B240 Offset: 0x1809840 VA: 0x18180B240
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0x180B890 Offset: 0x1809E90 VA: 0x18180B890
	private void Grow() { }

	// RVA: 0xF5FDD0 Offset: 0xF5E3D0 VA: 0x180F5FDD0
	private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length) { }

}

private class PropertyNameTable.Entry // TypeDefIndex: 5920
{	// Fields
	internal readonly string Value; // 0x10
	internal readonly int HashCode; // 0x18
	internal PropertyNameTable.Entry Next; // 0x20

	// Methods

	// RVA: 0xF5EED0 Offset: 0xF5D4D0 VA: 0x180F5EED0
	internal void .ctor(string value, int hashCode, PropertyNameTable.Entry next) { }

}

