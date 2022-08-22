public abstract class TraceListener : MarshalByRefObject, IDisposable // TypeDefIndex: 2643
{	// Fields
	private int indentLevel; // 0x18
	private int indentSize; // 0x1C
	private TraceOptions traceOptions; // 0x20
	private bool needIndent; // 0x24
	private string listenerName; // 0x28
	private TraceFilter filter; // 0x30

	// Properties
	public virtual bool IsThreadSafe { get; }
	public int IndentLevel { set; }
	public int IndentSize { set; }
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public TraceFilter Filter { get; }
	protected bool NeedIndent { get; set; }
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public TraceOptions TraceOutputOptions { get; }

	// Methods

	// RVA: 0x1738650 Offset: 0x1736C50 VA: 0x181738650
	protected void .ctor(string name) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 7
	public virtual bool get_IsThreadSafe() { }

	// RVA: 0x1737B70 Offset: 0x1736170 VA: 0x181737B70 Slot: 6
	public void Dispose() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public virtual void Flush() { }

	// RVA: 0x1738690 Offset: 0x1736C90 VA: 0x181738690
	public void set_IndentLevel(int value) { }

	// RVA: 0x17386B0 Offset: 0x1736CB0 VA: 0x1817386B0
	public void set_IndentSize(int value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public TraceFilter get_Filter() { }

	// RVA: 0x7747A0 Offset: 0x772DA0 VA: 0x1807747A0
	protected bool get_NeedIndent() { }

	// RVA: 0x7747E0 Offset: 0x772DE0 VA: 0x1807747E0
	protected void set_NeedIndent(bool value) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public TraceOptions get_TraceOutputOptions() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Write(string message);

	// RVA: 0x17385A0 Offset: 0x1736BA0 VA: 0x1817385A0 Slot: 11
	protected virtual void WriteIndent() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void WriteLine(string message);

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1737BF0 Offset: 0x17361F0 VA: 0x181737BF0 Slot: 13
	public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message) { }

	// RVA: 0x1738480 Offset: 0x1736A80 VA: 0x181738480
	private void WriteHeader(string source, TraceEventType eventType, int id) { }

	// RVA: 0x1737DA0 Offset: 0x17363A0 VA: 0x181737DA0
	private void WriteFooter(TraceEventCache eventCache) { }

	// RVA: 0x1737BE0 Offset: 0x17361E0 VA: 0x181737BE0
	internal bool IsEnabled(TraceOptions opts) { }

}

