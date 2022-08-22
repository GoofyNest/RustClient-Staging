public class UnhandledExceptionEventArgs : EventArgs // TypeDefIndex: 330
{	// Fields
	private object _Exception; // 0x10
	private bool _IsTerminating; // 0x18

	// Properties
	public object ExceptionObject { get; }
	public bool IsTerminating { get; }

	// Methods

	// RVA: 0x2146A20 Offset: 0x2145020 VA: 0x182146A20
	public void .ctor(object exception, bool isTerminating) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public object get_ExceptionObject() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0
	public bool get_IsTerminating() { }

}

