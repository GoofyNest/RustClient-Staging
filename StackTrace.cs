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

	// RVA: 0xD86E20 Offset: 0xD85420 VA: 0x180D86E20
	public void .ctor() { }

	// RVA: 0xD86E90 Offset: 0xD85490 VA: 0x180D86E90
	public void .ctor(bool fNeedFileInfo) { }

	// RVA: 0xD86E50 Offset: 0xD85450 VA: 0x180D86E50
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0xD86EF0 Offset: 0xD854F0 VA: 0x180D86EF0
	private void init_frames(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0xD86EE0 Offset: 0xD854E0 VA: 0x180D86EE0
	private static StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0xD86C70 Offset: 0xD85270 VA: 0x180D86C70
	public void .ctor(Exception e, bool fNeedFileInfo) { }

	// RVA: 0xD86D20 Offset: 0xD85320 VA: 0x180D86D20
	public void .ctor(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0xD86ED0 Offset: 0xD854D0 VA: 0x180D86ED0 Slot: 4
	public virtual int get_FrameCount() { }

	// RVA: 0xD86640 Offset: 0xD84C40 VA: 0x180D86640 Slot: 5
	public virtual StackFrame GetFrame(int index) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 6
	public virtual StackFrame[] GetFrames() { }

	// RVA: 0xD86540 Offset: 0xD84B40 VA: 0x180D86540
	private static string GetAotId() { }

	// RVA: 0xD860C0 Offset: 0xD846C0 VA: 0x180D860C0
	private bool AddFrames(StringBuilder sb) { }

	// RVA: 0xD866B0 Offset: 0xD84CB0 VA: 0x180D866B0
	internal void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi) { }

	// RVA: 0xD86B50 Offset: 0xD85150 VA: 0x180D86B50 Slot: 3
	public override string ToString() { }

	// RVA: 0xD86B30 Offset: 0xD85130 VA: 0x180D86B30
	internal string ToString(StackTrace.TraceFormat traceFormat) { }

}

internal enum StackTrace.TraceFormat // TypeDefIndex: 1504
{	// Fields
	public int value__; // 0x0
	public const StackTrace.TraceFormat Normal = 0;
	public const StackTrace.TraceFormat TrailingNewLine = 1;
	public const StackTrace.TraceFormat NoResourceLookup = 2;

}

