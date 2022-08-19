public abstract class TraceFilter // TypeDefIndex: 2640
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data);

	// RVA: 0x1736540 Offset: 0x1734B40 VA: 0x181736540
	internal bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage) { }

}

