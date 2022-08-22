public class PKCS7.ContentInfo // TypeDefIndex: 49
{
// Namespace: 
public class PKCS7.ContentInfo // TypeDefIndex: 49
	// Fields
	private string contentType; // 0x10
	private ASN1 content; // 0x18

	// Properties
	public ASN1 ASN1 { get; }
	public ASN1 Content { get; set; }
	public string ContentType { get; set; }

	// Methods

	// RVA: 0x1743770 Offset: 0x1741D70 VA: 0x181743770
	public void .ctor() { }

	// RVA: 0x1743540 Offset: 0x1741B40 VA: 0x181743540
	public void .ctor(string oid) { }

	// RVA: 0x17437E0 Offset: 0x1741DE0 VA: 0x1817437E0
	public void .ctor(byte[] data) { }

	// RVA: 0x17435D0 Offset: 0x1741BD0 VA: 0x1817435D0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x1743410 Offset: 0x1741A10 VA: 0x181743410
	public ASN1 get_ASN1() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public ASN1 get_Content() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_Content(ASN1 value) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_ContentType() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_ContentType(string value) { }

	// RVA: 0x1743410 Offset: 0x1741A10 VA: 0x181743410
	internal ASN1 GetASN1() { }

}

public class PKCS7.EncryptedData // TypeDefIndex: 50
{	// Fields
	private byte _version; // 0x10
	private PKCS7.ContentInfo _content; // 0x18
	private PKCS7.ContentInfo _encryptionAlgorithm; // 0x20
	private byte[] _encrypted; // 0x28

	// Properties
	public PKCS7.ContentInfo EncryptionAlgorithm { get; }
	public byte[] EncryptedContent { get; }

	// Methods

	// RVA: 0x17460C0 Offset: 0x17446C0 VA: 0x1817460C0
	public void .ctor() { }

	// RVA: 0x17460E0 Offset: 0x17446E0 VA: 0x1817460E0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public PKCS7.ContentInfo get_EncryptionAlgorithm() { }

	// RVA: 0x1746450 Offset: 0x1744A50 VA: 0x181746450
	public byte[] get_EncryptedContent() { }

}

public class PKCS7.ContentInfo // TypeDefIndex: 1708
{
// Namespace: 
public class PKCS7.ContentInfo // TypeDefIndex: 1708
	// Fields
	private string contentType; // 0x10
	private ASN1 content; // 0x18

	// Properties
	public ASN1 ASN1 { get; }
	public ASN1 Content { get; set; }
	public string ContentType { get; set; }

	// Methods

	// RVA: 0x1AB4A20 Offset: 0x1AB3020 VA: 0x181AB4A20
	public void .ctor() { }

	// RVA: 0x1AB4AA0 Offset: 0x1AB30A0 VA: 0x181AB4AA0
	public void .ctor(string oid) { }

	// RVA: 0x1AB4AD0 Offset: 0x1AB30D0 VA: 0x181AB4AD0
	public void .ctor(byte[] data) { }

	// RVA: 0x1AB4850 Offset: 0x1AB2E50 VA: 0x181AB4850
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x1AB4B40 Offset: 0x1AB3140 VA: 0x181AB4B40
	public ASN1 get_ASN1() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public ASN1 get_Content() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_Content(ASN1 value) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_ContentType() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_ContentType(string value) { }

	// RVA: 0x1AB4690 Offset: 0x1AB2C90 VA: 0x181AB4690
	internal ASN1 GetASN1() { }

}

public class PKCS7.EncryptedData // TypeDefIndex: 1709
{	// Fields
	private byte _version; // 0x10
	private PKCS7.ContentInfo _content; // 0x18
	private PKCS7.ContentInfo _encryptionAlgorithm; // 0x20
	private byte[] _encrypted; // 0x28

	// Properties
	public PKCS7.ContentInfo EncryptionAlgorithm { get; }
	public byte[] EncryptedContent { get; }

	// Methods

	// RVA: 0x17460C0 Offset: 0x17446C0 VA: 0x1817460C0
	public void .ctor() { }

	// RVA: 0x1AB54F0 Offset: 0x1AB3AF0 VA: 0x181AB54F0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public PKCS7.ContentInfo get_EncryptionAlgorithm() { }

	// RVA: 0x1AB5880 Offset: 0x1AB3E80 VA: 0x181AB5880
	public byte[] get_EncryptedContent() { }

}

