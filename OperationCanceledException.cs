public class OperationCanceledException : SystemException // TypeDefIndex: 282
{	// Fields
	private CancellationToken _cancellationToken; // 0x88

	// Properties
	public CancellationToken CancellationToken { get; set; }

	// Methods

	// RVA: 0x574300 Offset: 0x572900 VA: 0x180574300
	public CancellationToken get_CancellationToken() { }

	// RVA: 0x1681E00 Offset: 0x1680400 VA: 0x181681E00
	private void set_CancellationToken(CancellationToken value) { }

	// RVA: 0x1681D20 Offset: 0x1680320 VA: 0x181681D20
	public void .ctor() { }

	// RVA: 0x1681D80 Offset: 0x1680380 VA: 0x181681D80
	public void .ctor(string message) { }

	// RVA: 0x1681DB0 Offset: 0x16803B0 VA: 0x181681DB0
	public void .ctor(string message, CancellationToken token) { }

	// RVA: 0xFDDEB0 Offset: 0xFDC4B0 VA: 0x180FDDEB0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

