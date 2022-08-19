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

	// RVA: 0x10E9610 Offset: 0x10E7C10 VA: 0x1810E9610
	internal void .ctor(Type dataType) { }

	// RVA: 0x10E9450 Offset: 0x10E7A50 VA: 0x1810E9450
	internal void .ctor(Type dataType, string name, EventLevel level, EventOpcode opcode, EventKeywords keywords, EventTags tags) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Name() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public EventLevel get_Level() { }

	// RVA: 0x7D0C00 Offset: 0x7CF200 VA: 0x1807D0C00
	public EventOpcode get_Opcode() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public EventKeywords get_Keywords() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public EventTags get_Tags() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	internal Type get_DataType() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void WriteObjectData(TraceLoggingDataCollector collector, object value);

	// RVA: 0x7B4E80 Offset: 0x7B3480 VA: 0x1807B4E80 Slot: 6
	public virtual object GetData(object value) { }

}

