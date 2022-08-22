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

	// RVA: 0xD870E0 Offset: 0xD856E0 VA: 0x180D870E0
	public void .ctor() { }

	// RVA: 0xD87150 Offset: 0xD85750 VA: 0x180D87150
	public void .ctor(bool fNeedFileInfo) { }

	// RVA: 0xD87110 Offset: 0xD85710 VA: 0x180D87110
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0xD871B0 Offset: 0xD857B0 VA: 0x180D871B0
	private void init_frames(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0xD871A0 Offset: 0xD857A0 VA: 0x180D871A0
	private static StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0xD86F30 Offset: 0xD85530 VA: 0x180D86F30
	public void .ctor(Exception e, bool fNeedFileInfo) { }

	// RVA: 0xD86FE0 Offset: 0xD855E0 VA: 0x180D86FE0
	public void .ctor(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0xD87190 Offset: 0xD85790 VA: 0x180D87190 Slot: 4
	public virtual int get_FrameCount() { }

	// RVA: 0xD86900 Offset: 0xD84F00 VA: 0x180D86900 Slot: 5
	public virtual StackFrame GetFrame(int index) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 6
	public virtual StackFrame[] GetFrames() { }

	// RVA: 0xD86800 Offset: 0xD84E00 VA: 0x180D86800
	private static string GetAotId() { }

	// RVA: 0xD86380 Offset: 0xD84980 VA: 0x180D86380
	private bool AddFrames(StringBuilder sb) { }

	// RVA: 0xD86970 Offset: 0xD84F70 VA: 0x180D86970
	internal void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi) { }

	// RVA: 0xD86E10 Offset: 0xD85410 VA: 0x180D86E10 Slot: 3
	public override string ToString() { }

	// RVA: 0xD86DF0 Offset: 0xD853F0 VA: 0x180D86DF0
	internal string ToString(StackTrace.TraceFormat traceFormat) { }

}

internal enum StackTrace.TraceFormat // TypeDefIndex: 1504
{	// Fields
	public int value__; // 0x0
	public const StackTrace.TraceFormat Normal = 0;
	public const StackTrace.TraceFormat TrailingNewLine = 1;
	public const StackTrace.TraceFormat NoResourceLookup = 2;

}

