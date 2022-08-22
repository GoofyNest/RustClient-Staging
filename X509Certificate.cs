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

	// RVA: 0x175BB00 Offset: 0x175A100 VA: 0x18175BB00
	private void Parse(byte[] data) { }

	// RVA: 0x175C3F0 Offset: 0x175A9F0 VA: 0x18175C3F0
	public void .ctor(byte[] data) { }

	// RVA: 0x175B940 Offset: 0x1759F40 VA: 0x18175B940
	private byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x175C620 Offset: 0x175AC20 VA: 0x18175C620
	public DSA get_DSA() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340 Slot: 5
	public virtual string get_IssuerName() { }

	// RVA: 0x175C980 Offset: 0x175AF80 VA: 0x18175C980 Slot: 6
	public virtual byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x175CA00 Offset: 0x175B000 VA: 0x18175CA00 Slot: 7
	public virtual RSA get_RSA() { }

	// RVA: 0x175CC00 Offset: 0x175B200 VA: 0x18175CC00 Slot: 8
	public virtual byte[] get_RawData() { }

	// RVA: 0x175CC80 Offset: 0x175B280 VA: 0x18175CC80 Slot: 9
	public virtual byte[] get_SerialNumber() { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0 Slot: 10
	public virtual string get_SubjectName() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 11
	public virtual DateTime get_ValidFrom() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 12
	public virtual DateTime get_ValidUntil() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public ASN1 GetIssuerName() { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public ASN1 GetSubjectName() { }

	// RVA: 0x175B8E0 Offset: 0x1759EE0 VA: 0x18175B8E0 Slot: 13
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x175B9F0 Offset: 0x1759FF0 VA: 0x18175B9F0
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x175C3A0 Offset: 0x175A9A0 VA: 0x18175C3A0
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

	// RVA: 0x17C9E60 Offset: 0x17C8460 VA: 0x1817C9E60
	internal void .ctor(byte[] data, bool dates) { }

	// RVA: 0x17C9AE0 Offset: 0x17C80E0 VA: 0x1817C9AE0
	public void .ctor(byte[] data) { }

	// RVA: 0x17C9CE0 Offset: 0x17C82E0 VA: 0x1817C9CE0
	internal void .ctor(X509CertificateImpl impl) { }

	// RVA: 0x17C9B30 Offset: 0x17C8130 VA: 0x1817C9B30
	public void .ctor(X509Certificate cert) { }

	// RVA: 0x17C9840 Offset: 0x17C7E40 VA: 0x1817C9840
	internal void ImportHandle(X509CertificateImpl impl) { }

	// RVA: 0x17C9EC0 Offset: 0x17C84C0 VA: 0x1817C9EC0
	internal X509CertificateImpl get_Impl() { }

	// RVA: 0x17C9F30 Offset: 0x17C8530 VA: 0x1817C9F30
	internal bool get_IsValid() { }

	// RVA: 0x17C94D0 Offset: 0x17C7AD0 VA: 0x1817C94D0 Slot: 7
	public virtual bool Equals(X509Certificate other) { }

	// RVA: 0x17C95E0 Offset: 0x17C7BE0 VA: 0x1817C95E0 Slot: 8
	public virtual byte[] GetCertHash() { }

	// RVA: 0x17C95B0 Offset: 0x17C7BB0 VA: 0x1817C95B0 Slot: 9
	public virtual string GetCertHashString() { }

	// RVA: 0x17C9660 Offset: 0x17C7C60 VA: 0x1817C9660 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17C96C0 Offset: 0x17C7CC0 VA: 0x1817C96C0 Slot: 10
	public virtual byte[] GetRawCertData() { }

	// RVA: 0x17C97B0 Offset: 0x17C7DB0 VA: 0x1817C97B0 Slot: 11
	public virtual byte[] GetSerialNumber() { }

	// RVA: 0x17C9750 Offset: 0x17C7D50 VA: 0x1817C9750 Slot: 12
	public virtual string GetSerialNumberString() { }

	// RVA: 0x17C9A70 Offset: 0x17C8070 VA: 0x1817C9A70 Slot: 3
	public override string ToString() { }

	// RVA: 0x17C9A80 Offset: 0x17C8080 VA: 0x1817C9A80 Slot: 13
	public virtual string ToString(bool fVerbose) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x17C9D70 Offset: 0x17C8370 VA: 0x1817C9D70
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17C9F50 Offset: 0x17C8550 VA: 0x1817C9F50
	public string get_Issuer() { }

	// RVA: 0x17CA000 Offset: 0x17C8600 VA: 0x1817CA000
	public string get_Subject() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x17C9430 Offset: 0x17C7A30 VA: 0x1817C9430 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisibleAttribute] // RVA: 0xCC820 Offset: 0xCBC20 VA: 0x1800CC820
	[MonoTODOAttribute] // RVA: 0xCC820 Offset: 0xCBC20 VA: 0x1800CC820
	// RVA: 0x17C9880 Offset: 0x17C7E80 VA: 0x1817C9880 Slot: 14
	public virtual void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	[MonoTODOAttribute] // RVA: 0xCC9A0 Offset: 0xCBDA0 VA: 0x1800CC9A0
	[ComVisibleAttribute] // RVA: 0xCC9A0 Offset: 0xCBDA0 VA: 0x1800CC9A0
	// RVA: 0x1197640 Offset: 0x1195C40 VA: 0x181197640 Slot: 15
	public virtual void Import(string fileName, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x17C99B0 Offset: 0x17C7FB0 VA: 0x1817C99B0 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17C93F0 Offset: 0x17C79F0 VA: 0x1817C93F0 Slot: 6
	public void Dispose() { }

	// RVA: 0x17C9410 Offset: 0x17C7A10 VA: 0x1817C9410 Slot: 16
	protected virtual void Dispose(bool disposing) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x17C98F0 Offset: 0x17C7EF0 VA: 0x1817C98F0 Slot: 17
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

	// RVA: 0x227EC50 Offset: 0x227D250 VA: 0x18227EC50
	private void Parse(byte[] data) { }

	// RVA: 0x227FA10 Offset: 0x227E010 VA: 0x18227FA10
	public void .ctor(byte[] data) { }

	// RVA: 0x227EA90 Offset: 0x227D090 VA: 0x18227EA90
	private byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x227FC40 Offset: 0x227E240 VA: 0x18227FC40
	public DSA get_DSA() { }

	// RVA: 0x2280940 Offset: 0x227EF40 VA: 0x182280940
	public void set_DSA(DSA value) { }

	// RVA: 0x79BDD0 Offset: 0x79A3D0 VA: 0x18079BDD0
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x227FFA0 Offset: 0x227E5A0 VA: 0x18227FFA0
	public byte[] get_Hash() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340 Slot: 5
	public virtual string get_IssuerName() { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540 Slot: 6
	public virtual string get_KeyAlgorithm() { }

	// RVA: 0x22801D0 Offset: 0x227E7D0 VA: 0x1822801D0 Slot: 7
	public virtual byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x5DD7A0 Offset: 0x5DBDA0 VA: 0x1805DD7A0 Slot: 8
	public virtual void set_KeyAlgorithmParameters(byte[] value) { }

	// RVA: 0x2280250 Offset: 0x227E850 VA: 0x182280250 Slot: 9
	public virtual byte[] get_PublicKey() { }

	// RVA: 0x22802D0 Offset: 0x227E8D0 VA: 0x1822802D0 Slot: 10
	public virtual RSA get_RSA() { }

	// RVA: 0x2280990 Offset: 0x227EF90 VA: 0x182280990 Slot: 11
	public virtual void set_RSA(RSA value) { }

	// RVA: 0x22804D0 Offset: 0x227EAD0 VA: 0x1822804D0 Slot: 12
	public virtual byte[] get_RawData() { }

	// RVA: 0x2280550 Offset: 0x227EB50 VA: 0x182280550 Slot: 13
	public virtual byte[] get_SerialNumber() { }

	// RVA: 0x22805D0 Offset: 0x227EBD0 VA: 0x1822805D0 Slot: 14
	public virtual byte[] get_Signature() { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360 Slot: 15
	public virtual string get_SignatureAlgorithm() { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0 Slot: 16
	public virtual string get_SubjectName() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 17
	public virtual DateTime get_ValidFrom() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 18
	public virtual DateTime get_ValidUntil() { }

	// RVA: 0xB9BA00 Offset: 0xB9A000 VA: 0x180B9BA00
	public int get_Version() { }

	// RVA: 0x227F510 Offset: 0x227DB10 VA: 0x18227F510
	internal bool VerifySignature(DSA dsa) { }

	// RVA: 0x227F8B0 Offset: 0x227DEB0 VA: 0x18227F8B0
	internal bool VerifySignature(RSA rsa) { }

	// RVA: 0x227F5D0 Offset: 0x227DBD0 VA: 0x18227F5D0
	public bool VerifySignature(AsymmetricAlgorithm aa) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public ASN1 GetIssuerName() { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public ASN1 GetSubjectName() { }

	// RVA: 0x227EA30 Offset: 0x227D030 VA: 0x18227EA30 Slot: 19
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x227EB40 Offset: 0x227D140 VA: 0x18227EB40
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x227F9C0 Offset: 0x227DFC0 VA: 0x18227F9C0
	private static void .cctor() { }

}

