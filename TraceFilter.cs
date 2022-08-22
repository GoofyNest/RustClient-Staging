public abstract class TraceFilter // TypeDefIndex: 2640
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data);

	// RVA: 0x1736800 Offset: 0x1734E00 VA: 0x181736800
	internal bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage) { }

}

