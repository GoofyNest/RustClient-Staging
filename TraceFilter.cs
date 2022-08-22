public abstract class TraceFilter // TypeDefIndex: 2640
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data);

	// RVA: 0x17343C0 Offset: 0x17329C0 VA: 0x1817343C0
	internal bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage) { }

}

