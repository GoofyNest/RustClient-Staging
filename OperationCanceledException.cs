public class OperationCanceledException : SystemException // TypeDefIndex: 282
{	// Fields
	private CancellationToken _cancellationToken; // 0x88

	// Properties
	public CancellationToken CancellationToken { get; set; }

	// Methods

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public CancellationToken get_CancellationToken() { }

	// RVA: 0x1683F50 Offset: 0x1682550 VA: 0x181683F50
	private void set_CancellationToken(CancellationToken value) { }

	// RVA: 0x1683E70 Offset: 0x1682470 VA: 0x181683E70
	public void .ctor() { }

	// RVA: 0x1683ED0 Offset: 0x16824D0 VA: 0x181683ED0
	public void .ctor(string message) { }

	// RVA: 0x1683F00 Offset: 0x1682500 VA: 0x181683F00
	public void .ctor(string message, CancellationToken token) { }

	// RVA: 0xFDD150 Offset: 0xFDB750 VA: 0x180FDD150
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

