public class MemoryTraceWriter : ITraceWriter // TypeDefIndex: 5978
{	// Fields
	private readonly Queue<string> _traceMessages; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TraceLevel <LevelFilter>k__BackingField; // 0x18

	// Properties
	public TraceLevel LevelFilter { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470 Slot: 4
	public TraceLevel get_LevelFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0D90 Offset: 0x7CF390 VA: 0x1807D0D90
	public void set_LevelFilter(TraceLevel value) { }

	// RVA: 0x180A9B0 Offset: 0x1808FB0 VA: 0x18180A9B0
	public void .ctor() { }

	// RVA: 0x180A800 Offset: 0x1808E00 VA: 0x18180A800 Slot: 5
	public void Trace(TraceLevel level, string message, Exception ex) { }

	// RVA: 0x180A680 Offset: 0x1808C80 VA: 0x18180A680 Slot: 3
	public override string ToString() { }

}

