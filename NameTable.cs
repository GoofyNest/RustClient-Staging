public class NameTable : XmlNameTable // TypeDefIndex: 1990
{	// Fields
	private NameTable.Entry[] entries; // 0x10
	private int count; // 0x18
	private int mask; // 0x1C
	private int hashCodeRandomizer; // 0x20

	// Methods

	// RVA: 0xF5FE60 Offset: 0xF5E460 VA: 0x180F5FE60
	public void .ctor() { }

	// RVA: 0xF5F780 Offset: 0xF5DD80 VA: 0x180F5F780 Slot: 6
	public override string Add(string key) { }

	// RVA: 0xF5F900 Offset: 0xF5DF00 VA: 0x180F5F900 Slot: 5
	public override string Add(char[] key, int start, int len) { }

	// RVA: 0xF5FB00 Offset: 0xF5E100 VA: 0x180F5FB00 Slot: 4
	public override string Get(string value) { }

	// RVA: 0xF5F500 Offset: 0xF5DB00 VA: 0x180F5F500
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0xF5FC70 Offset: 0xF5E270 VA: 0x180F5FC70
	private void Grow() { }

	// RVA: 0xF5FDD0 Offset: 0xF5E3D0 VA: 0x180F5FDD0
	private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length) { }

}

private class NameTable.Entry // TypeDefIndex: 1991
{	// Fields
	internal string str; // 0x10
	internal int hashCode; // 0x18
	internal NameTable.Entry next; // 0x20

	// Methods

	// RVA: 0xF5EED0 Offset: 0xF5D4D0 VA: 0x180F5EED0
	internal void .ctor(string str, int hashCode, NameTable.Entry next) { }

}

