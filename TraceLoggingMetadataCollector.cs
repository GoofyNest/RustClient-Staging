internal class TraceLoggingMetadataCollector // TypeDefIndex: 1587
{	// Fields
	private readonly TraceLoggingMetadataCollector.Impl impl; // 0x10
	private readonly FieldMetadata currentGroup; // 0x18
	private int bufferedArrayFieldCount; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventFieldTags <Tags>k__BackingField; // 0x24

	// Properties
	internal EventFieldTags Tags { get; set; }
	internal int ScratchSize { get; }
	internal int DataCount { get; }
	internal int PinCount { get; }
	private bool BeginningBufferedArray { get; }

	// Methods

	// RVA: 0x10E92C0 Offset: 0x10E78C0 VA: 0x1810E92C0
	internal void .ctor() { }

	// RVA: 0x10E9380 Offset: 0x10E7980 VA: 0x1810E9380
	private void .ctor(TraceLoggingMetadataCollector other, FieldMetadata group) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0C00 Offset: 0x7CF200 VA: 0x1807D0C00
	internal EventFieldTags get_Tags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0C60 Offset: 0x7CF260 VA: 0x1807D0C60
	internal void set_Tags(EventFieldTags value) { }

	// RVA: 0x10E9430 Offset: 0x10E7A30 VA: 0x1810E9430
	internal int get_ScratchSize() { }

	// RVA: 0x10E93F0 Offset: 0x10E79F0 VA: 0x1810E93F0
	internal int get_DataCount() { }

	// RVA: 0x10E9410 Offset: 0x10E7A10 VA: 0x1810E9410
	internal int get_PinCount() { }

	// RVA: 0x10E93E0 Offset: 0x10E79E0 VA: 0x1810E93E0
	private bool get_BeginningBufferedArray() { }

	// RVA: 0x10E8E60 Offset: 0x10E7460 VA: 0x1810E8E60
	public TraceLoggingMetadataCollector AddGroup(string name) { }

	// RVA: 0x10E8F70 Offset: 0x10E7570 VA: 0x1810E8F70
	public void AddScalar(string name, TraceLoggingDataType type) { }

	// RVA: 0x10E8C50 Offset: 0x10E7250 VA: 0x1810E8C50
	public void AddBinary(string name, TraceLoggingDataType type) { }

	// RVA: 0x10E8AA0 Offset: 0x10E70A0 VA: 0x1810E8AA0
	public void AddArray(string name, TraceLoggingDataType type) { }

	// RVA: 0x10E9100 Offset: 0x10E7700 VA: 0x1810E9100
	public void BeginBufferedArray() { }

	// RVA: 0x10E91B0 Offset: 0x10E77B0 VA: 0x1810E91B0
	public void EndBufferedArray() { }

	// RVA: 0x10E9240 Offset: 0x10E7840 VA: 0x1810E9240
	internal byte[] GetMetadata() { }

	// RVA: 0x10E8D80 Offset: 0x10E7380 VA: 0x1810E8D80
	private void AddField(FieldMetadata fieldMetadata) { }

}

private class TraceLoggingMetadataCollector.Impl // TypeDefIndex: 1588
{	// Fields
	internal readonly List<FieldMetadata> fields; // 0x10
	internal short scratchSize; // 0x18
	internal sbyte dataCount; // 0x1A
	internal sbyte pinCount; // 0x1B
	private int bufferNesting; // 0x1C
	private bool scalar; // 0x20

	// Methods

	// RVA: 0x10DE400 Offset: 0x10DCA00 VA: 0x1810DE400
	public void AddScalar(int size) { }

	// RVA: 0x10DE330 Offset: 0x10DC930 VA: 0x1810DE330
	public void AddNonscalar() { }

	// RVA: 0x10DE4F0 Offset: 0x10DCAF0 VA: 0x1810DE4F0
	public void BeginBuffered() { }

	// RVA: 0x10DE650 Offset: 0x10DCC50 VA: 0x1810DE650
	public void EndBuffered() { }

	// RVA: 0x10DE520 Offset: 0x10DCB20 VA: 0x1810DE520
	public int Encode(byte[] metadata) { }

	// RVA: 0x10DE660 Offset: 0x10DCC60 VA: 0x1810DE660
	public void .ctor() { }

}

