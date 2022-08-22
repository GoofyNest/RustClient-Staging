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

	// RVA: 0x1736210 Offset: 0x1734810 VA: 0x181736210
	protected void .ctor(string name) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 7
	public virtual bool get_IsThreadSafe() { }

	// RVA: 0x1735730 Offset: 0x1733D30 VA: 0x181735730 Slot: 6
	public void Dispose() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public virtual void Flush() { }

	// RVA: 0x1736250 Offset: 0x1734850 VA: 0x181736250
	public void set_IndentLevel(int value) { }

	// RVA: 0x1736270 Offset: 0x1734870 VA: 0x181736270
	public void set_IndentSize(int value) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public TraceFilter get_Filter() { }

	// RVA: 0x7746F0 Offset: 0x772CF0 VA: 0x1807746F0
	protected bool get_NeedIndent() { }

	// RVA: 0x774730 Offset: 0x772D30 VA: 0x180774730
	protected void set_NeedIndent(bool value) { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public TraceOptions get_TraceOutputOptions() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Write(string message);

	// RVA: 0x1736160 Offset: 0x1734760 VA: 0x181736160 Slot: 11
	protected virtual void WriteIndent() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void WriteLine(string message);

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x17357B0 Offset: 0x1733DB0 VA: 0x1817357B0 Slot: 13
	public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message) { }

	// RVA: 0x1736040 Offset: 0x1734640 VA: 0x181736040
	private void WriteHeader(string source, TraceEventType eventType, int id) { }

	// RVA: 0x1735960 Offset: 0x1733F60 VA: 0x181735960
	private void WriteFooter(TraceEventCache eventCache) { }

	// RVA: 0x17357A0 Offset: 0x1733DA0 VA: 0x1817357A0
	internal bool IsEnabled(TraceOptions opts) { }

}

