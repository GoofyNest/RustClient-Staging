internal class X509CertificateImplCollection : IDisposable // TypeDefIndex: 2821
{	// Fields
	private List<X509CertificateImpl> list; // 0x10

	// Properties
	public int Count { get; }
	public X509CertificateImpl Item { get; }

	// Methods

	// RVA: 0x14D2750 Offset: 0x14D0D50 VA: 0x1814D2750
	public void .ctor() { }

	// RVA: 0x14D25C0 Offset: 0x14D0BC0 VA: 0x1814D25C0
	private void .ctor(X509CertificateImplCollection other) { }

	// RVA: 0x14D27C0 Offset: 0x14D0DC0 VA: 0x1814D27C0
	public int get_Count() { }

	// RVA: 0x14D2800 Offset: 0x14D0E00 VA: 0x1814D2800
	public X509CertificateImpl get_Item(int index) { }

	// RVA: 0x14D2320 Offset: 0x14D0920 VA: 0x1814D2320
	public void Add(X509CertificateImpl impl, bool takeOwnership) { }

	// RVA: 0x14D23B0 Offset: 0x14D09B0 VA: 0x1814D23B0
	public X509CertificateImplCollection Clone() { }

	// RVA: 0x14D2550 Offset: 0x14D0B50 VA: 0x1814D2550 Slot: 4
	public void Dispose() { }

	// RVA: 0x14D2410 Offset: 0x14D0A10 VA: 0x1814D2410 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x9E4550 Offset: 0x9E2B50 VA: 0x1809E4550 Slot: 1
	protected override void Finalize() { }

}

