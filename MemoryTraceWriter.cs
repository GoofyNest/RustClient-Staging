public class MemoryTraceWriter : ITraceWriter // TypeDefIndex: 5978
{	private readonly Queue<string> _traceMessages; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private TraceLevel <LevelFilter>k__BackingField; // 0x18

	public TraceLevel LevelFilter { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public TraceLevel get_LevelFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_LevelFilter(TraceLevel value) { }

	public void .ctor() { }

	public void Trace(TraceLevel level, string message, Exception ex) { }

	public override string ToString() { }

}

