public class StackTrace // TypeDefIndex: 1503
{	// Fields
	public const int METHODS_TO_SKIP = 0;
	private StackFrame[] frames; // 0x10
	private readonly StackTrace[] captured_traces; // 0x18
	private bool debug_info; // 0x20
	private static bool isAotidSet; // 0x0
	private static string aotid; // 0x8

	// Properties
	public virtual int FrameCount { get; }

	// Methods

	// RVA: 0xD87B90 Offset: 0xD86190 VA: 0x180D87B90
	public void .ctor() { }

	// RVA: 0xD87C00 Offset: 0xD86200 VA: 0x180D87C00
	public void .ctor(bool fNeedFileInfo) { }

	// RVA: 0xD87BC0 Offset: 0xD861C0 VA: 0x180D87BC0
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0xD87C60 Offset: 0xD86260 VA: 0x180D87C60
	private void init_frames(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0xD87C50 Offset: 0xD86250 VA: 0x180D87C50
	private static StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0xD879E0 Offset: 0xD85FE0 VA: 0x180D879E0
	public void .ctor(Exception e, bool fNeedFileInfo) { }

	// RVA: 0xD87A90 Offset: 0xD86090 VA: 0x180D87A90
	public void .ctor(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0xD87C40 Offset: 0xD86240 VA: 0x180D87C40 Slot: 4
	public virtual int get_FrameCount() { }

	// RVA: 0xD873B0 Offset: 0xD859B0 VA: 0x180D873B0 Slot: 5
	public virtual StackFrame GetFrame(int index) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 6
	public virtual StackFrame[] GetFrames() { }

	// RVA: 0xD872B0 Offset: 0xD858B0 VA: 0x180D872B0
	private static string GetAotId() { }

	// RVA: 0xD86E30 Offset: 0xD85430 VA: 0x180D86E30
	private bool AddFrames(StringBuilder sb) { }

	// RVA: 0xD87420 Offset: 0xD85A20 VA: 0x180D87420
	internal void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi) { }

	// RVA: 0xD878C0 Offset: 0xD85EC0 VA: 0x180D878C0 Slot: 3
	public override string ToString() { }

	// RVA: 0xD878A0 Offset: 0xD85EA0 VA: 0x180D878A0
	internal string ToString(StackTrace.TraceFormat traceFormat) { }

}

internal enum StackTrace.TraceFormat // TypeDefIndex: 1504
{	// Fields
	public int value__; // 0x0
	public const StackTrace.TraceFormat Normal = 0;
	public const StackTrace.TraceFormat TrailingNewLine = 1;
	public const StackTrace.TraceFormat NoResourceLookup = 2;

}

