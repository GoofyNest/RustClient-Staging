public enum TraceEventType // TypeDefIndex: 2639
{	public int value__; // 0x0
	public const TraceEventType Critical = 1;
	public const TraceEventType Error = 2;
	public const TraceEventType Warning = 4;
	public const TraceEventType Information = 8;
	public const TraceEventType Verbose = 16;
	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	public const TraceEventType Start = 256;
	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	public const TraceEventType Stop = 512;
	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	public const TraceEventType Suspend = 1024;
	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	public const TraceEventType Resume = 2048;
	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	public const TraceEventType Transfer = 4096;

}

