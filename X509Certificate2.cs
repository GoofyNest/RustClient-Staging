public class X509Certificate2 : X509Certificate // TypeDefIndex: 2814
{	// Fields
	private string friendlyName; // 0x30
	private static byte[] signedData; // 0x0

	// Properties
	internal X509Certificate2Impl Impl { get; }
	public X509ExtensionCollection Extensions { get; }
	public X500DistinguishedName IssuerName { get; }
	public DateTime NotAfter { get; }
	public DateTime NotBefore { get; }
	public AsymmetricAlgorithm PrivateKey { get; set; }
	public PublicKey PublicKey { get; }
	public string SerialNumber { get; }
	public Oid SignatureAlgorithm { get; }
	public X500DistinguishedName SubjectName { get; }
	public string Thumbprint { get; }
	public int Version { get; }
	[MonoTODOAttribute] // RVA: 0xAFFE0 Offset: 0xAF3E0 VA: 0x1800AFFE0
	internal X509Certificate MonoCertificate { get; }

	// Methods

	// RVA: 0x1193810 Offset: 0x1191E10 VA: 0x181193810
	internal X509Certificate2Impl get_Impl() { }

	// RVA: 0x1193700 Offset: 0x1191D00 VA: 0x181193700
	public void .ctor() { }

	// RVA: 0x1193590 Offset: 0x1191B90 VA: 0x181193590
	public void .ctor(byte[] rawData) { }

	// RVA: 0x1193750 Offset: 0x1191D50 VA: 0x181193750
	public void .ctor(string fileName, string password) { }

	// RVA: 0x1193690 Offset: 0x1191C90 VA: 0x181193690
	public void .ctor(X509Certificate certificate) { }

	// RVA: 0x1193610 Offset: 0x1191C10 VA: 0x181193610
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11937E0 Offset: 0x1191DE0 VA: 0x1811937E0
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x11938A0 Offset: 0x1191EA0 VA: 0x1811938A0
	public X500DistinguishedName get_IssuerName() { }

	// RVA: 0x11938E0 Offset: 0x1191EE0 VA: 0x1811938E0
	public DateTime get_NotAfter() { }

	// RVA: 0x1193920 Offset: 0x1191F20 VA: 0x181193920
	public DateTime get_NotBefore() { }

	// RVA: 0x1193960 Offset: 0x1191F60 VA: 0x181193960
	public AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x1193A50 Offset: 0x1192050 VA: 0x181193A50
	public void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x1193990 Offset: 0x1191F90 VA: 0x181193990
	public PublicKey get_PublicKey() { }

	// RVA: 0xFCD400 Offset: 0xFCBA00 VA: 0x180FCD400
	public string get_SerialNumber() { }

	// RVA: 0x11939C0 Offset: 0x1191FC0 VA: 0x1811939C0
	public Oid get_SignatureAlgorithm() { }

	// RVA: 0x11939F0 Offset: 0x1191FF0 VA: 0x1811939F0
	public X500DistinguishedName get_SubjectName() { }

	// RVA: 0x4C27D0 Offset: 0x4C0DD0 VA: 0x1804C27D0
	public string get_Thumbprint() { }

	// RVA: 0x1193A20 Offset: 0x1192020 VA: 0x181193A20
	public int get_Version() { }

	[MonoTODOAttribute] // RVA: 0xAE930 Offset: 0xADD30 VA: 0x1800AE930
	// RVA: 0x1192C90 Offset: 0x1191290 VA: 0x181192C90
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	[MonoTODOAttribute] // RVA: 0xAFD70 Offset: 0xAF170 VA: 0x1800AFD70
	// RVA: 0x1192CE0 Offset: 0x11912E0 VA: 0x181192CE0 Slot: 14
	public override void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	[MonoTODOAttribute] // RVA: 0xAFD70 Offset: 0xAF170 VA: 0x1800AFD70
	// RVA: 0x1192D20 Offset: 0x1191320 VA: 0x181192D20 Slot: 15
	public override void Import(string fileName, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x1192D80 Offset: 0x1191380 VA: 0x181192D80 Slot: 17
	public override void Reset() { }

	// RVA: 0x1193480 Offset: 0x1191A80 VA: 0x181193480 Slot: 3
	public override string ToString() { }

	// RVA: 0x1192DD0 Offset: 0x11913D0 VA: 0x181192DD0 Slot: 13
	public override string ToString(bool verbose) { }

	// RVA: 0x1192BD0 Offset: 0x11911D0 VA: 0x181192BD0
	private static void AppendBuffer(StringBuilder sb, byte[] buffer) { }

	[MonoTODOAttribute] // RVA: 0xAFF50 Offset: 0xAF350 VA: 0x1800AFF50
	// RVA: 0x11934E0 Offset: 0x1191AE0 VA: 0x1811934E0
	public bool Verify() { }

	// RVA: 0x11938D0 Offset: 0x1191ED0 VA: 0x1811938D0
	internal X509Certificate get_MonoCertificate() { }

	// RVA: 0x1193520 Offset: 0x1191B20 VA: 0x181193520
	private static void .cctor() { }

}

