internal sealed class ObjectMapInfo // TypeDefIndex: 1106
{	// Fields
	internal int objectId; // 0x10
	private int numMembers; // 0x14
	private string[] memberNames; // 0x18
	private Type[] memberTypes; // 0x20

	// Methods

	// RVA: 0x11F6B80 Offset: 0x11F5180 VA: 0x1811F6B80
	internal void .ctor(int objectId, int numMembers, string[] memberNames, Type[] memberTypes) { }

	// RVA: 0x11F6BE0 Offset: 0x11F51E0 VA: 0x1811F6BE0
	internal bool isCompatible(int numMembers, string[] memberNames, Type[] memberTypes) { }

}

