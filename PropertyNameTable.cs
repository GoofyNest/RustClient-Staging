internal class PropertyNameTable // TypeDefIndex: 5919
{	// Fields
	private static readonly int HashCodeRandomizer; // 0x0
	private int _count; // 0x10
	private PropertyNameTable.Entry[] _entries; // 0x18
	private int _mask; // 0x20

	// Methods

	// RVA: 0x17F8E30 Offset: 0x17F7430 VA: 0x1817F8E30
	private static void .cctor() { }

	// RVA: 0x17F8E70 Offset: 0x17F7470 VA: 0x1817F8E70
	public void .ctor() { }

	// RVA: 0x17F8AA0 Offset: 0x17F70A0 VA: 0x1817F8AA0
	public string Get(char[] key, int start, int length) { }

	// RVA: 0x17F8900 Offset: 0x17F6F00 VA: 0x1817F8900
	public string Add(string key) { }

	// RVA: 0x17F8680 Offset: 0x17F6C80 VA: 0x1817F8680
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0x17F8CD0 Offset: 0x17F72D0 VA: 0x1817F8CD0
	private void Grow() { }

	// RVA: 0xF60870 Offset: 0xF5EE70 VA: 0x180F60870
	private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length) { }

}

private class PropertyNameTable.Entry // TypeDefIndex: 5920
{	// Fields
	internal readonly string Value; // 0x10
	internal readonly int HashCode; // 0x18
	internal PropertyNameTable.Entry Next; // 0x20

	// Methods

	// RVA: 0xF5F970 Offset: 0xF5DF70 VA: 0x180F5F970
	internal void .ctor(string value, int hashCode, PropertyNameTable.Entry next) { }

}

