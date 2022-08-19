public class MemoryTraceWriter : ITraceWriter // TypeDefIndex: 5978
{	// Fields
	private readonly Queue<string> _traceMessages; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TraceLevel <LevelFilter>k__BackingField; // 0x18

	// Properties
	public TraceLevel LevelFilter { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470 Slot: 4
	public TraceLevel get_LevelFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7D0C80 Offset: 0x7CF280 VA: 0x1807D0C80
	public void set_LevelFilter(TraceLevel value) { }

	// RVA: 0x180A6F0 Offset: 0x1808CF0 VA: 0x18180A6F0
	public void .ctor() { }

	// RVA: 0x180A540 Offset: 0x1808B40 VA: 0x18180A540 Slot: 5
	public void Trace(TraceLevel level, string message, Exception ex) { }

	// RVA: 0x180A3C0 Offset: 0x18089C0 VA: 0x18180A3C0 Slot: 3
	public override string ToString() { }

}

