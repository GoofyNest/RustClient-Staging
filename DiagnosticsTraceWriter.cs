public class DiagnosticsTraceWriter : ITraceWriter // TypeDefIndex: 5974
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TraceLevel <LevelFilter>k__BackingField; // 0x10

	// Properties
	public TraceLevel LevelFilter { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 4
	public TraceLevel get_LevelFilter() { }

	// RVA: 0x13EFC70 Offset: 0x13EE270 VA: 0x1813EFC70
	private TraceEventType GetTraceEventType(TraceLevel level) { }

	// RVA: 0x13EFD10 Offset: 0x13EE310 VA: 0x1813EFD10 Slot: 5
	public void Trace(TraceLevel level, string message, Exception ex) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

