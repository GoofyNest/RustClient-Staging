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

	// RVA: 0x1076DA0 Offset: 0x10753A0 VA: 0x181076DA0
	internal void .ctor() { }

	// RVA: 0x12031C0 Offset: 0x12017C0 VA: 0x1812031C0
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion) { }

	// RVA: 0x1203140 Offset: 0x1201740 VA: 0x181203140 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x1202D10 Offset: 0x1201310 VA: 0x181202D10
	private static int GetInt32(byte[] buffer, int index) { }

	// RVA: 0x1202DC0 Offset: 0x12013C0 VA: 0x181202DC0 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Dump() { }

}

