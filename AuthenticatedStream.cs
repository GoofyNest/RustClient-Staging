public abstract class AuthenticatedStream : Stream // TypeDefIndex: 3067
{	// Fields
	private Stream _InnerStream; // 0x28
	private bool _LeaveStreamOpen; // 0x30

	// Properties
	protected Stream InnerStream { get; }
	public abstract bool IsAuthenticated { get; }

	// Methods

	// RVA: 0xFF7A80 Offset: 0xFF6080 VA: 0x180FF7A80
	protected void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	protected Stream get_InnerStream() { }

	// RVA: 0xFF7980 Offset: 0xFF5F80 VA: 0x180FF7980 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool get_IsAuthenticated();

}

