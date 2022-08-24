public class UnhandledExceptionEventArgs : EventArgs // TypeDefIndex: 330
{	private object _Exception; // 0x10
	private bool _IsTerminating; // 0x18

	public object ExceptionObject { get; }
	public bool IsTerminating { get; }


	public void .ctor(object exception, bool isTerminating) { }

	[ReliabilityContractAttribute] // RVA: 0x76D50 Offset: 0x76150 VA: 0x180076D50
	public object get_ExceptionObject() { }

	[ReliabilityContractAttribute] // RVA: 0x76D50 Offset: 0x76150 VA: 0x180076D50
	public bool get_IsTerminating() { }

}

