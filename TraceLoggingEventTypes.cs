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

	// RVA: 0x10E9620 Offset: 0x10E7C20 VA: 0x1810E9620
	internal void .ctor(string name, EventTags tags, Type[] types) { }

	// RVA: 0x10E9220 Offset: 0x10E7820 VA: 0x1810E9220
	internal void .ctor(string name, EventTags tags, ParameterInfo[] paramInfos) { }

	// RVA: 0x10E9020 Offset: 0x10E7620 VA: 0x1810E9020
	private void .ctor(EventTags tags, string defaultName, TraceLoggingTypeInfo[] typeInfos) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal string get_Name() { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	internal EventTags get_Tags() { }

	// RVA: 0x10E8AE0 Offset: 0x10E70E0 VA: 0x1810E8AE0
	internal NameInfo GetNameInfo(string name, EventTags tags) { }

	// RVA: 0x10E8D00 Offset: 0x10E7300 VA: 0x1810E8D00
	private TraceLoggingTypeInfo[] MakeArray(ParameterInfo[] paramInfos) { }

	// RVA: 0x10E8EA0 Offset: 0x10E74A0 VA: 0x1810E8EA0
	private static TraceLoggingTypeInfo[] MakeArray(Type[] types) { }

}

