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

	// RVA: 0x1198130 Offset: 0x1196730 VA: 0x181198130
	internal X509Certificate2Impl get_Impl() { }

	// RVA: 0x1198020 Offset: 0x1196620 VA: 0x181198020
	public void .ctor() { }

	// RVA: 0x1197EB0 Offset: 0x11964B0 VA: 0x181197EB0
	public void .ctor(byte[] rawData) { }

	// RVA: 0x1198070 Offset: 0x1196670 VA: 0x181198070
	public void .ctor(string fileName, string password) { }

	// RVA: 0x1197FB0 Offset: 0x11965B0 VA: 0x181197FB0
	public void .ctor(X509Certificate certificate) { }

	// RVA: 0x1197F30 Offset: 0x1196530 VA: 0x181197F30
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1198100 Offset: 0x1196700 VA: 0x181198100
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x11981C0 Offset: 0x11967C0 VA: 0x1811981C0
	public X500DistinguishedName get_IssuerName() { }

	// RVA: 0x1198200 Offset: 0x1196800 VA: 0x181198200
	public DateTime get_NotAfter() { }

	// RVA: 0x1198240 Offset: 0x1196840 VA: 0x181198240
	public DateTime get_NotBefore() { }

	// RVA: 0x1198280 Offset: 0x1196880 VA: 0x181198280
	public AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x1198370 Offset: 0x1196970 VA: 0x181198370
	public void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x11982B0 Offset: 0x11968B0 VA: 0x1811982B0
	public PublicKey get_PublicKey() { }

	// RVA: 0xFCDEA0 Offset: 0xFCC4A0 VA: 0x180FCDEA0
	public string get_SerialNumber() { }

	// RVA: 0x11982E0 Offset: 0x11968E0 VA: 0x1811982E0
	public Oid get_SignatureAlgorithm() { }

	// RVA: 0x1198310 Offset: 0x1196910 VA: 0x181198310
	public X500DistinguishedName get_SubjectName() { }

	// RVA: 0x4C2760 Offset: 0x4C0D60 VA: 0x1804C2760
	public string get_Thumbprint() { }

	// RVA: 0x1198340 Offset: 0x1196940 VA: 0x181198340
	public int get_Version() { }

	[MonoTODOAttribute] // RVA: 0xAE930 Offset: 0xADD30 VA: 0x1800AE930
	// RVA: 0x11975B0 Offset: 0x1195BB0 VA: 0x1811975B0
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	[MonoTODOAttribute] // RVA: 0xAFD70 Offset: 0xAF170 VA: 0x1800AFD70
	// RVA: 0x1197600 Offset: 0x1195C00 VA: 0x181197600 Slot: 14
	public override void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	[MonoTODOAttribute] // RVA: 0xAFD70 Offset: 0xAF170 VA: 0x1800AFD70
	// RVA: 0x1197640 Offset: 0x1195C40 VA: 0x181197640 Slot: 15
	public override void Import(string fileName, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x11976A0 Offset: 0x1195CA0 VA: 0x1811976A0 Slot: 17
	public override void Reset() { }

	// RVA: 0x1197DA0 Offset: 0x11963A0 VA: 0x181197DA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x11976F0 Offset: 0x1195CF0 VA: 0x1811976F0 Slot: 13
	public override string ToString(bool verbose) { }

	// RVA: 0x11974F0 Offset: 0x1195AF0 VA: 0x1811974F0
	private static void AppendBuffer(StringBuilder sb, byte[] buffer) { }

	[MonoTODOAttribute] // RVA: 0xAFF50 Offset: 0xAF350 VA: 0x1800AFF50
	// RVA: 0x1197E00 Offset: 0x1196400 VA: 0x181197E00
	public bool Verify() { }

	// RVA: 0x11981F0 Offset: 0x11967F0 VA: 0x1811981F0
	internal X509Certificate get_MonoCertificate() { }

	// RVA: 0x1197E40 Offset: 0x1196440 VA: 0x181197E40
	private static void .cctor() { }

}

