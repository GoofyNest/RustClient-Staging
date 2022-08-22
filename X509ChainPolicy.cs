public sealed class X509ChainPolicy // TypeDefIndex: 2828
{	// Fields
	private OidCollection apps; // 0x10
	private OidCollection cert; // 0x18
	private X509CertificateCollection store; // 0x20
	private X509Certificate2Collection store2; // 0x28
	private X509RevocationFlag rflag; // 0x30
	private X509RevocationMode mode; // 0x34
	private TimeSpan timeout; // 0x38
	private X509VerificationFlags vflags; // 0x40
	private DateTime vtime; // 0x48

	// Properties
	public X509Certificate2Collection ExtraStore { get; }
	public X509RevocationFlag RevocationFlag { get; set; }
	public X509RevocationMode RevocationMode { get; set; }
	public TimeSpan UrlRetrievalTimeout { set; }
	public X509VerificationFlags VerificationFlags { get; set; }
	public DateTime VerificationTime { get; }

	// Methods

	// RVA: 0x14D8290 Offset: 0x14D6890 VA: 0x1814D8290
	public void .ctor() { }

	// RVA: 0x14D8250 Offset: 0x14D6850 VA: 0x1814D8250
	internal void .ctor(X509CertificateCollection store) { }

	// RVA: 0x14D82B0 Offset: 0x14D68B0 VA: 0x1814D82B0
	public X509Certificate2Collection get_ExtraStore() { }

	// RVA: 0xA39490 Offset: 0xA37A90 VA: 0x180A39490
	public X509RevocationFlag get_RevocationFlag() { }

	// RVA: 0x14D8570 Offset: 0x14D6B70 VA: 0x1814D8570
	public void set_RevocationFlag(X509RevocationFlag value) { }

	// RVA: 0x5E2ED0 Offset: 0x5E14D0 VA: 0x1805E2ED0
	public X509RevocationMode get_RevocationMode() { }

	// RVA: 0x14D85E0 Offset: 0x14D6BE0 VA: 0x1814D85E0
	public void set_RevocationMode(X509RevocationMode value) { }

	// RVA: 0xC157D0 Offset: 0xC13DD0 VA: 0x180C157D0
	public void set_UrlRetrievalTimeout(TimeSpan value) { }

	// RVA: 0x5DE3D0 Offset: 0x5DC9D0 VA: 0x1805DE3D0
	public X509VerificationFlags get_VerificationFlags() { }

	// RVA: 0x14D8650 Offset: 0x14D6C50 VA: 0x1814D8650
	public void set_VerificationFlags(X509VerificationFlags value) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public DateTime get_VerificationTime() { }

	// RVA: 0x14D8140 Offset: 0x14D6740 VA: 0x1814D8140
	public void Reset() { }

}

