internal class FieldMetadata // TypeDefIndex: 1523
{	// Fields
	private readonly string name; // 0x10
	private readonly int nameSize; // 0x18
	private readonly EventFieldTags tags; // 0x1C
	private readonly byte[] custom; // 0x20
	private readonly ushort fixedCount; // 0x28
	private byte inType; // 0x2A
	private byte outType; // 0x2B

	// Methods

	// RVA: 0x10DE7A0 Offset: 0x10DCDA0 VA: 0x1810DE7A0
	public void .ctor(string name, TraceLoggingDataType type, EventFieldTags tags, bool variableCount) { }

	// RVA: 0x10DE500 Offset: 0x10DCB00 VA: 0x1810DE500
	private void .ctor(string name, TraceLoggingDataType dataType, EventFieldTags tags, byte countFlags, ushort fixedCount = 0, byte[] custom) { }

	// RVA: 0x10DE480 Offset: 0x10DCA80 VA: 0x1810DE480
	public void IncrementStructFieldCount() { }

	// RVA: 0x10DE250 Offset: 0x10DC850 VA: 0x1810DE250
	public void Encode(ref int pos, byte[] metadata) { }

}

