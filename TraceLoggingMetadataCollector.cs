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

	// RVA: 0x10E9FF0 Offset: 0x10E85F0 VA: 0x1810E9FF0
	internal void .ctor() { }

	// RVA: 0x10EA0B0 Offset: 0x10E86B0 VA: 0x1810EA0B0
	private void .ctor(TraceLoggingMetadataCollector other, FieldMetadata group) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C630 Offset: 0x79AC30 VA: 0x18079C630
	internal EventFieldTags get_Tags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C690 Offset: 0x79AC90 VA: 0x18079C690
	internal void set_Tags(EventFieldTags value) { }

	// RVA: 0x10EA160 Offset: 0x10E8760 VA: 0x1810EA160
	internal int get_ScratchSize() { }

	// RVA: 0x10EA120 Offset: 0x10E8720 VA: 0x1810EA120
	internal int get_DataCount() { }

	// RVA: 0x10EA140 Offset: 0x10E8740 VA: 0x1810EA140
	internal int get_PinCount() { }

	// RVA: 0x10EA110 Offset: 0x10E8710 VA: 0x1810EA110
	private bool get_BeginningBufferedArray() { }

	// RVA: 0x10E9B90 Offset: 0x10E8190 VA: 0x1810E9B90
	public TraceLoggingMetadataCollector AddGroup(string name) { }

	// RVA: 0x10E9CA0 Offset: 0x10E82A0 VA: 0x1810E9CA0
	public void AddScalar(string name, TraceLoggingDataType type) { }

	// RVA: 0x10E9980 Offset: 0x10E7F80 VA: 0x1810E9980
	public void AddBinary(string name, TraceLoggingDataType type) { }

	// RVA: 0x10E97D0 Offset: 0x10E7DD0 VA: 0x1810E97D0
	public void AddArray(string name, TraceLoggingDataType type) { }

	// RVA: 0x10E9E30 Offset: 0x10E8430 VA: 0x1810E9E30
	public void BeginBufferedArray() { }

	// RVA: 0x10E9EE0 Offset: 0x10E84E0 VA: 0x1810E9EE0
	public void EndBufferedArray() { }

	// RVA: 0x10E9F70 Offset: 0x10E8570 VA: 0x1810E9F70
	internal byte[] GetMetadata() { }

	// RVA: 0x10E9AB0 Offset: 0x10E80B0 VA: 0x1810E9AB0
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

	// RVA: 0x10DF130 Offset: 0x10DD730 VA: 0x1810DF130
	public void AddScalar(int size) { }

	// RVA: 0x10DF060 Offset: 0x10DD660 VA: 0x1810DF060
	public void AddNonscalar() { }

	// RVA: 0x10DF220 Offset: 0x10DD820 VA: 0x1810DF220
	public void BeginBuffered() { }

	// RVA: 0x10DF380 Offset: 0x10DD980 VA: 0x1810DF380
	public void EndBuffered() { }

	// RVA: 0x10DF250 Offset: 0x10DD850 VA: 0x1810DF250
	public int Encode(byte[] metadata) { }

	// RVA: 0x10DF390 Offset: 0x10DD990 VA: 0x1810DF390
	public void .ctor() { }

}

