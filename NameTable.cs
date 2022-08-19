public class NameTable : XmlNameTable // TypeDefIndex: 1990
{	// Fields
	private NameTable.Entry[] entries; // 0x10
	private int count; // 0x18
	private int mask; // 0x1C
	private int hashCodeRandomizer; // 0x20

	// Methods

	// RVA: 0xF5FBA0 Offset: 0xF5E1A0 VA: 0x180F5FBA0
	public void .ctor() { }

	// RVA: 0xF5F4C0 Offset: 0xF5DAC0 VA: 0x180F5F4C0 Slot: 6
	public override string Add(string key) { }

	// RVA: 0xF5F640 Offset: 0xF5DC40 VA: 0x180F5F640 Slot: 5
	public override string Add(char[] key, int start, int len) { }

	// RVA: 0xF5F840 Offset: 0xF5DE40 VA: 0x180F5F840 Slot: 4
	public override string Get(string value) { }

	// RVA: 0xF5F240 Offset: 0xF5D840 VA: 0x180F5F240
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0xF5F9B0 Offset: 0xF5DFB0 VA: 0x180F5F9B0
	private void Grow() { }

	// RVA: 0xF5FB10 Offset: 0xF5E110 VA: 0x180F5FB10
	private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length) { }

}

private class NameTable.Entry // TypeDefIndex: 1991
{	// Fields
	internal string str; // 0x10
	internal int hashCode; // 0x18
	internal NameTable.Entry next; // 0x20

	// Methods

	// RVA: 0xF5EC10 Offset: 0xF5D210 VA: 0x180F5EC10
	internal void .ctor(string str, int hashCode, NameTable.Entry next) { }

}

