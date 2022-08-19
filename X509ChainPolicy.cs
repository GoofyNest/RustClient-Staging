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

	// RVA: 0x14D8F00 Offset: 0x14D7500 VA: 0x1814D8F00
	public void .ctor() { }

	// RVA: 0x14D8EC0 Offset: 0x14D74C0 VA: 0x1814D8EC0
	internal void .ctor(X509CertificateCollection store) { }

	// RVA: 0x14D8F20 Offset: 0x14D7520 VA: 0x1814D8F20
	public X509Certificate2Collection get_ExtraStore() { }

	// RVA: 0xA38CE0 Offset: 0xA372E0 VA: 0x180A38CE0
	public X509RevocationFlag get_RevocationFlag() { }

	// RVA: 0x14D91E0 Offset: 0x14D77E0 VA: 0x1814D91E0
	public void set_RevocationFlag(X509RevocationFlag value) { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40
	public X509RevocationMode get_RevocationMode() { }

	// RVA: 0x14D9250 Offset: 0x14D7850 VA: 0x1814D9250
	public void set_RevocationMode(X509RevocationMode value) { }

	// RVA: 0xC15040 Offset: 0xC13640 VA: 0x180C15040
	public void set_UrlRetrievalTimeout(TimeSpan value) { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	public X509VerificationFlags get_VerificationFlags() { }

	// RVA: 0x14D92C0 Offset: 0x14D78C0 VA: 0x1814D92C0
	public void set_VerificationFlags(X509VerificationFlags value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public DateTime get_VerificationTime() { }

	// RVA: 0x14D8DB0 Offset: 0x14D73B0 VA: 0x1814D8DB0
	public void Reset() { }

}

