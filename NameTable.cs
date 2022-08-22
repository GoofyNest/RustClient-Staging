public class NameTable : XmlNameTable // TypeDefIndex: 1990
{	// Fields
	private NameTable.Entry[] entries; // 0x10
	private int count; // 0x18
	private int mask; // 0x1C
	private int hashCodeRandomizer; // 0x20

	// Methods

	// RVA: 0xF60900 Offset: 0xF5EF00 VA: 0x180F60900
	public void .ctor() { }

	// RVA: 0xF60220 Offset: 0xF5E820 VA: 0x180F60220 Slot: 6
	public override string Add(string key) { }

	// RVA: 0xF603A0 Offset: 0xF5E9A0 VA: 0x180F603A0 Slot: 5
	public override string Add(char[] key, int start, int len) { }

	// RVA: 0xF605A0 Offset: 0xF5EBA0 VA: 0x180F605A0 Slot: 4
	public override string Get(string value) { }

	// RVA: 0xF5FFA0 Offset: 0xF5E5A0 VA: 0x180F5FFA0
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0xF60710 Offset: 0xF5ED10 VA: 0x180F60710
	private void Grow() { }

	// RVA: 0xF60870 Offset: 0xF5EE70 VA: 0x180F60870
	private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length) { }

}

private class NameTable.Entry // TypeDefIndex: 1991
{	// Fields
	internal string str; // 0x10
	internal int hashCode; // 0x18
	internal NameTable.Entry next; // 0x20

	// Methods

	// RVA: 0xF5F970 Offset: 0xF5DF70 VA: 0x180F5F970
	internal void .ctor(string str, int hashCode, NameTable.Entry next) { }

}

