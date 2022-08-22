public class OperationCanceledException : SystemException // TypeDefIndex: 282
{	// Fields
	private CancellationToken _cancellationToken; // 0x88

	// Properties
	public CancellationToken CancellationToken { get; set; }

	// Methods

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public CancellationToken get_CancellationToken() { }

	// RVA: 0x1684210 Offset: 0x1682810 VA: 0x181684210
	private void set_CancellationToken(CancellationToken value) { }

	// RVA: 0x1684130 Offset: 0x1682730 VA: 0x181684130
	public void .ctor() { }

	// RVA: 0x1684190 Offset: 0x1682790 VA: 0x181684190
	public void .ctor(string message) { }

	// RVA: 0x16841C0 Offset: 0x16827C0 VA: 0x1816841C0
	public void .ctor(string message, CancellationToken token) { }

	// RVA: 0xFDD410 Offset: 0xFDBA10 VA: 0x180FDD410
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

