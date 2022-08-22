internal class X509Certificate : ISerializable // TypeDefIndex: 58
{	// Fields
	private ASN1 decoder; // 0x10
	private byte[] m_encodedcert; // 0x18
	private DateTime m_from; // 0x20
	private DateTime m_until; // 0x28
	private ASN1 issuer; // 0x30
	private string m_issuername; // 0x38
	private string m_keyalgo; // 0x40
	private byte[] m_keyalgoparams; // 0x48
	private ASN1 subject; // 0x50
	private string m_subject; // 0x58
	private byte[] m_publickey; // 0x60
	private byte[] signature; // 0x68
	private string m_signaturealgo; // 0x70
	private byte[] m_signaturealgoparams; // 0x78
	private RSA _rsa; // 0x80
	private DSA _dsa; // 0x88
	private int version; // 0x90
	private byte[] serialnumber; // 0x98
	private byte[] issuerUniqueID; // 0xA0
	private byte[] subjectUniqueID; // 0xA8
	private X509ExtensionCollection extensions; // 0xB0
	private static string encoding_error; // 0x0

	// Properties
	public DSA DSA { get; }
	public virtual string IssuerName { get; }
	public virtual byte[] KeyAlgorithmParameters { get; }
	public virtual RSA RSA { get; }
	public virtual byte[] RawData { get; }
	public virtual byte[] SerialNumber { get; }
	public virtual string SubjectName { get; }
	public virtual DateTime ValidFrom { get; }
	public virtual DateTime ValidUntil { get; }

	// Methods

	// RVA: 0x175DF40 Offset: 0x175C540 VA: 0x18175DF40
	private void Parse(byte[] data) { }

	// RVA: 0x175E830 Offset: 0x175CE30 VA: 0x18175E830
	public void .ctor(byte[] data) { }

	// RVA: 0x175DD80 Offset: 0x175C380 VA: 0x18175DD80
	private byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x175EA60 Offset: 0x175D060 VA: 0x18175EA60
	public DSA get_DSA() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 5
	public virtual string get_IssuerName() { }

	// RVA: 0x175EDC0 Offset: 0x175D3C0 VA: 0x18175EDC0 Slot: 6
	public virtual byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x175EE40 Offset: 0x175D440 VA: 0x18175EE40 Slot: 7
	public virtual RSA get_RSA() { }

	// RVA: 0x175F040 Offset: 0x175D640 VA: 0x18175F040 Slot: 8
	public virtual byte[] get_RawData() { }

	// RVA: 0x175F0C0 Offset: 0x175D6C0 VA: 0x18175F0C0 Slot: 9
	public virtual byte[] get_SerialNumber() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860 Slot: 10
	public virtual string get_SubjectName() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 11
	public virtual DateTime get_ValidFrom() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 12
	public virtual DateTime get_ValidUntil() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public ASN1 GetIssuerName() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public ASN1 GetSubjectName() { }

	// RVA: 0x175DD20 Offset: 0x175C320 VA: 0x18175DD20 Slot: 13
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x175DE30 Offset: 0x175C430 VA: 0x18175DE30
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x175E7E0 Offset: 0x175CDE0 VA: 0x18175E7E0
	private static void .cctor() { }

}

public class X509Certificate : IDeserializationCallback, ISerializable, IDisposable // TypeDefIndex: 1017
{	// Fields
	private X509CertificateImpl impl; // 0x10
	private bool hideDates; // 0x18
	private string issuer_name; // 0x20
	private string subject_name; // 0x28

	// Properties
	internal X509CertificateImpl Impl { get; }
	internal bool IsValid { get; }
	public string Issuer { get; }
	public string Subject { get; }

	// Methods

	// RVA: 0x17CC310 Offset: 0x17CA910 VA: 0x1817CC310
	internal void .ctor(byte[] data, bool dates) { }

	// RVA: 0x17CBF90 Offset: 0x17CA590 VA: 0x1817CBF90
	public void .ctor(byte[] data) { }

	// RVA: 0x17CC190 Offset: 0x17CA790 VA: 0x1817CC190
	internal void .ctor(X509CertificateImpl impl) { }

	// RVA: 0x17CBFE0 Offset: 0x17CA5E0 VA: 0x1817CBFE0
	public void .ctor(X509Certificate cert) { }

	// RVA: 0x17CBCF0 Offset: 0x17CA2F0 VA: 0x1817CBCF0
	internal void ImportHandle(X509CertificateImpl impl) { }

	// RVA: 0x17CC370 Offset: 0x17CA970 VA: 0x1817CC370
	internal X509CertificateImpl get_Impl() { }

	// RVA: 0x17CC3E0 Offset: 0x17CA9E0 VA: 0x1817CC3E0
	internal bool get_IsValid() { }

	// RVA: 0x17CB980 Offset: 0x17C9F80 VA: 0x1817CB980 Slot: 7
	public virtual bool Equals(X509Certificate other) { }

	// RVA: 0x17CBA90 Offset: 0x17CA090 VA: 0x1817CBA90 Slot: 8
	public virtual byte[] GetCertHash() { }

	// RVA: 0x17CBA60 Offset: 0x17CA060 VA: 0x1817CBA60 Slot: 9
	public virtual string GetCertHashString() { }

	// RVA: 0x17CBB10 Offset: 0x17CA110 VA: 0x1817CBB10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17CBB70 Offset: 0x17CA170 VA: 0x1817CBB70 Slot: 10
	public virtual byte[] GetRawCertData() { }

	// RVA: 0x17CBC60 Offset: 0x17CA260 VA: 0x1817CBC60 Slot: 11
	public virtual byte[] GetSerialNumber() { }

	// RVA: 0x17CBC00 Offset: 0x17CA200 VA: 0x1817CBC00 Slot: 12
	public virtual string GetSerialNumberString() { }

	// RVA: 0x17CBF20 Offset: 0x17CA520 VA: 0x1817CBF20 Slot: 3
	public override string ToString() { }

	// RVA: 0x17CBF30 Offset: 0x17CA530 VA: 0x1817CBF30 Slot: 13
	public virtual string ToString(bool fVerbose) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x17CC220 Offset: 0x17CA820 VA: 0x1817CC220
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17CC400 Offset: 0x17CAA00 VA: 0x1817CC400
	public string get_Issuer() { }

	// RVA: 0x17CC4B0 Offset: 0x17CAAB0 VA: 0x1817CC4B0
	public string get_Subject() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x17CB8E0 Offset: 0x17C9EE0 VA: 0x1817CB8E0 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisibleAttribute] // RVA: 0xCC820 Offset: 0xCBC20 VA: 0x1800CC820
	[MonoTODOAttribute] // RVA: 0xCC820 Offset: 0xCBC20 VA: 0x1800CC820
	// RVA: 0x17CBD30 Offset: 0x17CA330 VA: 0x1817CBD30 Slot: 14
	public virtual void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	[MonoTODOAttribute] // RVA: 0xCC9A0 Offset: 0xCBDA0 VA: 0x1800CC9A0
	[ComVisibleAttribute] // RVA: 0xCC9A0 Offset: 0xCBDA0 VA: 0x1800CC9A0
	// RVA: 0x1192D20 Offset: 0x1191320 VA: 0x181192D20 Slot: 15
	public virtual void Import(string fileName, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x17CBE60 Offset: 0x17CA460 VA: 0x1817CBE60 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17CB8A0 Offset: 0x17C9EA0 VA: 0x1817CB8A0 Slot: 6
	public void Dispose() { }

	// RVA: 0x17CB8C0 Offset: 0x17C9EC0 VA: 0x1817CB8C0 Slot: 16
	protected virtual void Dispose(bool disposing) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x17CBDA0 Offset: 0x17CA3A0 VA: 0x1817CBDA0 Slot: 17
	public virtual void Reset() { }

}

public class X509Certificate : ISerializable // TypeDefIndex: 1716
{	// Fields
	private ASN1 decoder; // 0x10
	private byte[] m_encodedcert; // 0x18
	private DateTime m_from; // 0x20
	private DateTime m_until; // 0x28
	private ASN1 issuer; // 0x30
	private string m_issuername; // 0x38
	private string m_keyalgo; // 0x40
	private byte[] m_keyalgoparams; // 0x48
	private ASN1 subject; // 0x50
	private string m_subject; // 0x58
	private byte[] m_publickey; // 0x60
	private byte[] signature; // 0x68
	private string m_signaturealgo; // 0x70
	private byte[] m_signaturealgoparams; // 0x78
	private byte[] certhash; // 0x80
	private RSA _rsa; // 0x88
	private DSA _dsa; // 0x90
	private int version; // 0x98
	private byte[] serialnumber; // 0xA0
	private byte[] issuerUniqueID; // 0xA8
	private byte[] subjectUniqueID; // 0xB0
	private X509ExtensionCollection extensions; // 0xB8
	private static string encoding_error; // 0x0

	// Properties
	public DSA DSA { get; set; }
	public X509ExtensionCollection Extensions { get; }
	public byte[] Hash { get; }
	public virtual string IssuerName { get; }
	public virtual string KeyAlgorithm { get; }
	public virtual byte[] KeyAlgorithmParameters { get; set; }
	public virtual byte[] PublicKey { get; }
	public virtual RSA RSA { get; set; }
	public virtual byte[] RawData { get; }
	public virtual byte[] SerialNumber { get; }
	public virtual byte[] Signature { get; }
	public virtual string SignatureAlgorithm { get; }
	public virtual string SubjectName { get; }
	public virtual DateTime ValidFrom { get; }
	public virtual DateTime ValidUntil { get; }
	public int Version { get; }

	// Methods

	// RVA: 0x227E430 Offset: 0x227CA30 VA: 0x18227E430
	private void Parse(byte[] data) { }

	// RVA: 0x227F1F0 Offset: 0x227D7F0 VA: 0x18227F1F0
	public void .ctor(byte[] data) { }

	// RVA: 0x227E270 Offset: 0x227C870 VA: 0x18227E270
	private byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x227F420 Offset: 0x227DA20 VA: 0x18227F420
	public DSA get_DSA() { }

	// RVA: 0x2280120 Offset: 0x227E720 VA: 0x182280120
	public void set_DSA(DSA value) { }

	// RVA: 0x7AD080 Offset: 0x7AB680 VA: 0x1807AD080
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x227F780 Offset: 0x227DD80 VA: 0x18227F780
	public byte[] get_Hash() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 5
	public virtual string get_IssuerName() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0 Slot: 6
	public virtual string get_KeyAlgorithm() { }

	// RVA: 0x227F9B0 Offset: 0x227DFB0 VA: 0x18227F9B0 Slot: 7
	public virtual byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810 Slot: 8
	public virtual void set_KeyAlgorithmParameters(byte[] value) { }

	// RVA: 0x227FA30 Offset: 0x227E030 VA: 0x18227FA30 Slot: 9
	public virtual byte[] get_PublicKey() { }

	// RVA: 0x227FAB0 Offset: 0x227E0B0 VA: 0x18227FAB0 Slot: 10
	public virtual RSA get_RSA() { }

	// RVA: 0x2280170 Offset: 0x227E770 VA: 0x182280170 Slot: 11
	public virtual void set_RSA(RSA value) { }

	// RVA: 0x227FCB0 Offset: 0x227E2B0 VA: 0x18227FCB0 Slot: 12
	public virtual byte[] get_RawData() { }

	// RVA: 0x227FD30 Offset: 0x227E330 VA: 0x18227FD30 Slot: 13
	public virtual byte[] get_SerialNumber() { }

	// RVA: 0x227FDB0 Offset: 0x227E3B0 VA: 0x18227FDB0 Slot: 14
	public virtual byte[] get_Signature() { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0 Slot: 15
	public virtual string get_SignatureAlgorithm() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860 Slot: 16
	public virtual string get_SubjectName() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 17
	public virtual DateTime get_ValidFrom() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 18
	public virtual DateTime get_ValidUntil() { }

	// RVA: 0xB9B530 Offset: 0xB99B30 VA: 0x180B9B530
	public int get_Version() { }

	// RVA: 0x227ECF0 Offset: 0x227D2F0 VA: 0x18227ECF0
	internal bool VerifySignature(DSA dsa) { }

	// RVA: 0x227F090 Offset: 0x227D690 VA: 0x18227F090
	internal bool VerifySignature(RSA rsa) { }

	// RVA: 0x227EDB0 Offset: 0x227D3B0 VA: 0x18227EDB0
	public bool VerifySignature(AsymmetricAlgorithm aa) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public ASN1 GetIssuerName() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public ASN1 GetSubjectName() { }

	// RVA: 0x227E210 Offset: 0x227C810 VA: 0x18227E210 Slot: 19
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x227E320 Offset: 0x227C920 VA: 0x18227E320
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x227F1A0 Offset: 0x227D7A0 VA: 0x18227F1A0
	private static void .cctor() { }

}

