internal abstract class TraceLoggingTypeInfo // TypeDefIndex: 1589
{	// Fields
	private readonly string name; // 0x10
	private readonly EventKeywords keywords; // 0x18
	private readonly EventLevel level; // 0x20
	private readonly EventOpcode opcode; // 0x24
	private readonly EventTags tags; // 0x28
	private readonly Type dataType; // 0x30

	// Properties
	public string Name { get; }
	public EventLevel Level { get; }
	public EventOpcode Opcode { get; }
	public EventKeywords Keywords { get; }
	public EventTags Tags { get; }
	internal Type DataType { get; }

	// Methods

	// RVA: 0x10EA340 Offset: 0x10E8940 VA: 0x1810EA340
	internal void .ctor(Type dataType) { }

	// RVA: 0x10EA180 Offset: 0x10E8780 VA: 0x1810EA180
	internal void .ctor(Type dataType, string name, EventLevel level, EventOpcode opcode, EventKeywords keywords, EventTags tags) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Name() { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public EventLevel get_Level() { }

	// RVA: 0x79C630 Offset: 0x79AC30 VA: 0x18079C630
	public EventOpcode get_Opcode() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public EventKeywords get_Keywords() { }

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
	public EventTags get_Tags() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	internal Type get_DataType() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void WriteObjectData(TraceLoggingDataCollector collector, object value);

	// RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380 Slot: 6
	public virtual object GetData(object value) { }

}

