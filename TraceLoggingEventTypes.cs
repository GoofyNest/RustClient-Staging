internal class TraceLoggingEventTypes // TypeDefIndex: 1586
{	// Fields
	internal readonly TraceLoggingTypeInfo[] typeInfos; // 0x10
	internal readonly string name; // 0x18
	internal readonly EventTags tags; // 0x20
	internal readonly byte level; // 0x24
	internal readonly byte opcode; // 0x25
	internal readonly EventKeywords keywords; // 0x28
	internal readonly byte[] typeMetadata; // 0x30
	internal readonly int scratchSize; // 0x38
	internal readonly int dataCount; // 0x3C
	internal readonly int pinCount; // 0x40
	private ConcurrentSet<KeyValuePair<string, EventTags>, NameInfo> nameInfos; // 0x48

	// Properties
	internal string Name { get; }
	internal EventTags Tags { get; }

	// Methods

	// RVA: 0x10E8BB0 Offset: 0x10E71B0 VA: 0x1810E8BB0
	internal void .ctor(string name, EventTags tags, Type[] types) { }

	// RVA: 0x10E87B0 Offset: 0x10E6DB0 VA: 0x1810E87B0
	internal void .ctor(string name, EventTags tags, ParameterInfo[] paramInfos) { }

	// RVA: 0x10E85B0 Offset: 0x10E6BB0 VA: 0x1810E85B0
	private void .ctor(EventTags tags, string defaultName, TraceLoggingTypeInfo[] typeInfos) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal string get_Name() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	internal EventTags get_Tags() { }

	// RVA: 0x10E8070 Offset: 0x10E6670 VA: 0x1810E8070
	internal NameInfo GetNameInfo(string name, EventTags tags) { }

	// RVA: 0x10E8290 Offset: 0x10E6890 VA: 0x1810E8290
	private TraceLoggingTypeInfo[] MakeArray(ParameterInfo[] paramInfos) { }

	// RVA: 0x10E8430 Offset: 0x10E6A30 VA: 0x1810E8430
	private static TraceLoggingTypeInfo[] MakeArray(Type[] types) { }

}

