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
	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	public TraceFilter Filter { get; }
	protected bool NeedIndent { get; set; }
	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	public TraceOptions TraceOutputOptions { get; }

	// Methods

	// RVA: 0x1738390 Offset: 0x1736990 VA: 0x181738390
	protected void .ctor(string name) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 7
	public virtual bool get_IsThreadSafe() { }

	// RVA: 0x17378B0 Offset: 0x1735EB0 VA: 0x1817378B0 Slot: 6
	public void Dispose() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public virtual void Flush() { }

	// RVA: 0x17383D0 Offset: 0x17369D0 VA: 0x1817383D0
	public void set_IndentLevel(int value) { }

	// RVA: 0x17383F0 Offset: 0x17369F0 VA: 0x1817383F0
	public void set_IndentSize(int value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public TraceFilter get_Filter() { }

	// RVA: 0x774690 Offset: 0x772C90 VA: 0x180774690
	protected bool get_NeedIndent() { }

	// RVA: 0x7746D0 Offset: 0x772CD0 VA: 0x1807746D0
	protected void set_NeedIndent(bool value) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public TraceOptions get_TraceOutputOptions() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Write(string message);

	// RVA: 0x17382E0 Offset: 0x17368E0 VA: 0x1817382E0 Slot: 11
	protected virtual void WriteIndent() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void WriteLine(string message);

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x1737930 Offset: 0x1735F30 VA: 0x181737930 Slot: 13
	public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message) { }

	// RVA: 0x17381C0 Offset: 0x17367C0 VA: 0x1817381C0
	private void WriteHeader(string source, TraceEventType eventType, int id) { }

	// RVA: 0x1737AE0 Offset: 0x17360E0 VA: 0x181737AE0
	private void WriteFooter(TraceEventCache eventCache) { }

	// RVA: 0x1737920 Offset: 0x1735F20 VA: 0x181737920
	internal bool IsEnabled(TraceOptions opts) { }

}

