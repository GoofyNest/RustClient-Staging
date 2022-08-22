public abstract class AuthenticatedStream : Stream // TypeDefIndex: 3067
{	// Fields
	private Stream _InnerStream; // 0x28
	private bool _LeaveStreamOpen; // 0x30

	// Properties
	protected Stream InnerStream { get; }
	public abstract bool IsAuthenticated { get; }

	// Methods

	// RVA: 0xFF6FE0 Offset: 0xFF55E0 VA: 0x180FF6FE0
	protected void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	protected Stream get_InnerStream() { }

	// RVA: 0xFF6EE0 Offset: 0xFF54E0 VA: 0x180FF6EE0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool get_IsAuthenticated();

}

