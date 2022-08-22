internal class X509CertificateImplCollection : IDisposable // TypeDefIndex: 2821
{	// Fields
	private List<X509CertificateImpl> list; // 0x10

	// Properties
	public int Count { get; }
	public X509CertificateImpl Item { get; }

	// Methods

	// RVA: 0x14D1AE0 Offset: 0x14D00E0 VA: 0x1814D1AE0
	public void .ctor() { }

	// RVA: 0x14D1950 Offset: 0x14CFF50 VA: 0x1814D1950
	private void .ctor(X509CertificateImplCollection other) { }

	// RVA: 0x14D1B50 Offset: 0x14D0150 VA: 0x1814D1B50
	public int get_Count() { }

	// RVA: 0x14D1B90 Offset: 0x14D0190 VA: 0x1814D1B90
	public X509CertificateImpl get_Item(int index) { }

	// RVA: 0x14D16B0 Offset: 0x14CFCB0 VA: 0x1814D16B0
	public void Add(X509CertificateImpl impl, bool takeOwnership) { }

	// RVA: 0x14D1740 Offset: 0x14CFD40 VA: 0x1814D1740
	public X509CertificateImplCollection Clone() { }

	// RVA: 0x14D18E0 Offset: 0x14CFEE0 VA: 0x1814D18E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x14D17A0 Offset: 0x14CFDA0 VA: 0x1814D17A0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x9E4D00 Offset: 0x9E3300 VA: 0x1809E4D00 Slot: 1
	protected override void Finalize() { }

}

