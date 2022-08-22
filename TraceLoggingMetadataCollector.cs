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

	// RVA: 0x10E9580 Offset: 0x10E7B80 VA: 0x1810E9580
	internal void .ctor() { }

	// RVA: 0x10E9640 Offset: 0x10E7C40 VA: 0x1810E9640
	private void .ctor(TraceLoggingMetadataCollector other, FieldMetadata group) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0D10 Offset: 0x7CF310 VA: 0x1807D0D10
	internal EventFieldTags get_Tags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0D70 Offset: 0x7CF370 VA: 0x1807D0D70
	internal void set_Tags(EventFieldTags value) { }

	// RVA: 0x10E96F0 Offset: 0x10E7CF0 VA: 0x1810E96F0
	internal int get_ScratchSize() { }

	// RVA: 0x10E96B0 Offset: 0x10E7CB0 VA: 0x1810E96B0
	internal int get_DataCount() { }

	// RVA: 0x10E96D0 Offset: 0x10E7CD0 VA: 0x1810E96D0
	internal int get_PinCount() { }

	// RVA: 0x10E96A0 Offset: 0x10E7CA0 VA: 0x1810E96A0
	private bool get_BeginningBufferedArray() { }

	// RVA: 0x10E9120 Offset: 0x10E7720 VA: 0x1810E9120
	public TraceLoggingMetadataCollector AddGroup(string name) { }

	// RVA: 0x10E9230 Offset: 0x10E7830 VA: 0x1810E9230
	public void AddScalar(string name, TraceLoggingDataType type) { }

	// RVA: 0x10E8F10 Offset: 0x10E7510 VA: 0x1810E8F10
	public void AddBinary(string name, TraceLoggingDataType type) { }

	// RVA: 0x10E8D60 Offset: 0x10E7360 VA: 0x1810E8D60
	public void AddArray(string name, TraceLoggingDataType type) { }

	// RVA: 0x10E93C0 Offset: 0x10E79C0 VA: 0x1810E93C0
	public void BeginBufferedArray() { }

	// RVA: 0x10E9470 Offset: 0x10E7A70 VA: 0x1810E9470
	public void EndBufferedArray() { }

	// RVA: 0x10E9500 Offset: 0x10E7B00 VA: 0x1810E9500
	internal byte[] GetMetadata() { }

	// RVA: 0x10E9040 Offset: 0x10E7640 VA: 0x1810E9040
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

	// RVA: 0x10DE6C0 Offset: 0x10DCCC0 VA: 0x1810DE6C0
	public void AddScalar(int size) { }

	// RVA: 0x10DE5F0 Offset: 0x10DCBF0 VA: 0x1810DE5F0
	public void AddNonscalar() { }

	// RVA: 0x10DE7B0 Offset: 0x10DCDB0 VA: 0x1810DE7B0
	public void BeginBuffered() { }

	// RVA: 0x10DE910 Offset: 0x10DCF10 VA: 0x1810DE910
	public void EndBuffered() { }

	// RVA: 0x10DE7E0 Offset: 0x10DCDE0 VA: 0x1810DE7E0
	public int Encode(byte[] metadata) { }

	// RVA: 0x10DE920 Offset: 0x10DCF20 VA: 0x1810DE920
	public void .ctor() { }

}

