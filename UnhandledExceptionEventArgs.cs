public class UnhandledExceptionEventArgs : EventArgs // TypeDefIndex: 330
{	// Fields
	private object _Exception; // 0x10
	private bool _IsTerminating; // 0x18

	// Properties
	public object ExceptionObject { get; }
	public bool IsTerminating { get; }

	// Methods

	// RVA: 0x2146200 Offset: 0x2144800 VA: 0x182146200
	public void .ctor(object exception, bool isTerminating) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public object get_ExceptionObject() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x95FAF0 Offset: 0x95E0F0 VA: 0x18095FAF0
	public bool get_IsTerminating() { }

}

