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

	// RVA: 0x1076AE0 Offset: 0x10750E0 VA: 0x181076AE0
	internal void .ctor() { }

	// RVA: 0x1202F00 Offset: 0x1201500 VA: 0x181202F00
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion) { }

	// RVA: 0x1202E80 Offset: 0x1201480 VA: 0x181202E80 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x1202A50 Offset: 0x1201050 VA: 0x181202A50
	private static int GetInt32(byte[] buffer, int index) { }

	// RVA: 0x1202B00 Offset: 0x1201100 VA: 0x181202B00 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Dump() { }

}

