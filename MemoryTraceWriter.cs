public class MemoryTraceWriter : ITraceWriter // TypeDefIndex: 5978
{	// Fields
	private readonly Queue<string> _traceMessages; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TraceLevel <LevelFilter>k__BackingField; // 0x18

	// Properties
	public TraceLevel LevelFilter { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400 Slot: 4
	public TraceLevel get_LevelFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C6B0 Offset: 0x79ACB0 VA: 0x18079C6B0
	public void set_LevelFilter(TraceLevel value) { }

	// RVA: 0x17F7DF0 Offset: 0x17F63F0 VA: 0x1817F7DF0
	public void .ctor() { }

	// RVA: 0x17F7C40 Offset: 0x17F6240 VA: 0x1817F7C40 Slot: 5
	public void Trace(TraceLevel level, string message, Exception ex) { }

	// RVA: 0x17F7AC0 Offset: 0x17F60C0 VA: 0x1817F7AC0 Slot: 3
	public override string ToString() { }

}

