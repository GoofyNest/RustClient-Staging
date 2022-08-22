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

	// RVA: 0x10DDD30 Offset: 0x10DC330 VA: 0x1810DDD30
	public void .ctor(string name, TraceLoggingDataType type, EventFieldTags tags, bool variableCount) { }

	// RVA: 0x10DDA90 Offset: 0x10DC090 VA: 0x1810DDA90
	private void .ctor(string name, TraceLoggingDataType dataType, EventFieldTags tags, byte countFlags, ushort fixedCount = 0, byte[] custom) { }

	// RVA: 0x10DDA10 Offset: 0x10DC010 VA: 0x1810DDA10
	public void IncrementStructFieldCount() { }

	// RVA: 0x10DD7E0 Offset: 0x10DBDE0 VA: 0x1810DD7E0
	public void Encode(ref int pos, byte[] metadata) { }

}

