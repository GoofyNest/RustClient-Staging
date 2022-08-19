public abstract class AuthenticatedStream : Stream // TypeDefIndex: 3067
{	// Fields
	private Stream _InnerStream; // 0x28
	private bool _LeaveStreamOpen; // 0x30

	// Properties
	protected Stream InnerStream { get; }
	public abstract bool IsAuthenticated { get; }

	// Methods

	// RVA: 0xFF6D20 Offset: 0xFF5320 VA: 0x180FF6D20
	protected void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	protected Stream get_InnerStream() { }

	// RVA: 0xFF6C20 Offset: 0xFF5220 VA: 0x180FF6C20 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool get_IsAuthenticated();

}

