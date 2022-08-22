public sealed class X509SubjectKeyIdentifierExtension : X509Extension // TypeDefIndex: 2838
{	// Fields
	internal const string oid = "2.5.29.14";
	internal const string friendlyName = "Subject Key Identifier";
	private byte[] _subjectKeyIdentifier; // 0x28
	private string _ski; // 0x30
	private AsnDecodeStatus _status; // 0x38

	// Properties
	public string SubjectKeyIdentifier { get; }

	// Methods

	// RVA: 0x14DD670 Offset: 0x14DBC70 VA: 0x1814DD670
	public void .ctor() { }

	// RVA: 0x14DD310 Offset: 0x14DB910 VA: 0x1814DD310
	public void .ctor(AsnEncodedData encodedSubjectKeyIdentifier, bool critical) { }

	// RVA: 0x14DD1A0 Offset: 0x14DB7A0 VA: 0x1814DD1A0
	public void .ctor(byte[] subjectKeyIdentifier, bool critical) { }

	// RVA: 0x14DD3E0 Offset: 0x14DB9E0 VA: 0x1814DD3E0
	public void .ctor(string subjectKeyIdentifier, bool critical) { }

	// RVA: 0x14DD650 Offset: 0x14DBC50 VA: 0x1814DD650
	public void .ctor(PublicKey key, bool critical) { }

	// RVA: 0x14DD6F0 Offset: 0x14DBCF0 VA: 0x1814DD6F0
	public void .ctor(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical) { }

	// RVA: 0x14DDA90 Offset: 0x14DC090 VA: 0x1814DDA90
	public string get_SubjectKeyIdentifier() { }

	// RVA: 0x14DC9F0 Offset: 0x14DAFF0 VA: 0x1814DC9F0 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x14DCD50 Offset: 0x14DB350 VA: 0x1814DCD50
	internal static byte FromHexChar(char c) { }

	// RVA: 0x14DCD80 Offset: 0x14DB380 VA: 0x1814DCD80
	internal static byte FromHexChars(char c1, char c2) { }

	// RVA: 0x14DCE00 Offset: 0x14DB400 VA: 0x1814DCE00
	internal static byte[] FromHex(string hex) { }

	// RVA: 0x14DCB70 Offset: 0x14DB170 VA: 0x1814DCB70
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x14DCCD0 Offset: 0x14DB2D0 VA: 0x1814DCCD0
	internal byte[] Encode() { }

	// RVA: 0x14DCF80 Offset: 0x14DB580 VA: 0x1814DCF80 Slot: 6
	internal override string ToString(bool multiLine) { }

}

