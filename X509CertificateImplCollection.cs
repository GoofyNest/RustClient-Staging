internal class X509CertificateImplCollection : IDisposable // TypeDefIndex: 2821
{	// Fields
	private List<X509CertificateImpl> list; // 0x10

	// Properties
	public int Count { get; }
	public X509CertificateImpl Item { get; }

	// Methods

	// RVA: 0x14D2A10 Offset: 0x14D1010 VA: 0x1814D2A10
	public void .ctor() { }

	// RVA: 0x14D2880 Offset: 0x14D0E80 VA: 0x1814D2880
	private void .ctor(X509CertificateImplCollection other) { }

	// RVA: 0x14D2A80 Offset: 0x14D1080 VA: 0x1814D2A80
	public int get_Count() { }

	// RVA: 0x14D2AC0 Offset: 0x14D10C0 VA: 0x1814D2AC0
	public X509CertificateImpl get_Item(int index) { }

	// RVA: 0x14D25E0 Offset: 0x14D0BE0 VA: 0x1814D25E0
	public void Add(X509CertificateImpl impl, bool takeOwnership) { }

	// RVA: 0x14D2670 Offset: 0x14D0C70 VA: 0x1814D2670
	public X509CertificateImplCollection Clone() { }

	// RVA: 0x14D2810 Offset: 0x14D0E10 VA: 0x1814D2810 Slot: 4
	public void Dispose() { }

	// RVA: 0x14D26D0 Offset: 0x14D0CD0 VA: 0x1814D26D0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x9E4810 Offset: 0x9E2E10 VA: 0x1809E4810 Slot: 1
	protected override void Finalize() { }

}

