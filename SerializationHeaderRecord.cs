internal sealed class SerializationHeaderRecord // TypeDefIndex: 1071
{	// Fields
	internal int binaryFormatterMajorVersion; // 0x10
	internal int binaryFormatterMinorVersion; // 0x14
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x18
	internal int topId; // 0x1C
	internal int headerId; // 0x20
	internal int majorVersion; // 0x24
	internal int minorVersion; // 0x28

	// Methods

	// RVA: 0x1077810 Offset: 0x1075E10 VA: 0x181077810
	internal void .ctor() { }

	// RVA: 0x1203860 Offset: 0x1201E60 VA: 0x181203860
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion) { }

	// RVA: 0x12037E0 Offset: 0x1201DE0 VA: 0x1812037E0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x12033B0 Offset: 0x12019B0 VA: 0x1812033B0
	private static int GetInt32(byte[] buffer, int index) { }

	// RVA: 0x1203460 Offset: 0x1201A60 VA: 0x181203460 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Dump() { }

}

