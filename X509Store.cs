public class X509Store // TypeDefIndex: 1721
{	// Fields
	private string _storePath; // 0x10
	private X509CertificateCollection _certificates; // 0x18
	private ArrayList _crls; // 0x20
	private bool _crl; // 0x28
	private bool _newFormat; // 0x29

	// Properties
	public X509CertificateCollection Certificates { get; }
	public ArrayList Crls { get; }

	// Methods

	// RVA: 0x22834A0 Offset: 0x2281AA0 VA: 0x1822834A0
	internal void .ctor(string path, bool crl, bool newFormat) { }

	// RVA: 0x2283500 Offset: 0x2281B00 VA: 0x182283500
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x2283540 Offset: 0x2281B40 VA: 0x182283540
	public ArrayList get_Crls() { }

	// RVA: 0x2283350 Offset: 0x2281950 VA: 0x182283350
	private byte[] Load(string filename) { }

	// RVA: 0x22831C0 Offset: 0x22817C0 VA: 0x1822831C0
	private X509Certificate LoadCertificate(string filename) { }

	// RVA: 0x2283230 Offset: 0x2281830 VA: 0x182283230
	private X509Crl LoadCrl(string filename) { }

	// RVA: 0x2283130 Offset: 0x2281730 VA: 0x182283130
	private bool CheckStore(string path, bool throwException) { }

	// RVA: 0x2282EA0 Offset: 0x22814A0 VA: 0x182282EA0
	private X509CertificateCollection BuildCertificatesCollection(string storeName) { }

	// RVA: 0x2282FF0 Offset: 0x22815F0 VA: 0x182282FF0
	private ArrayList BuildCrlsCollection(string storeName) { }

}

public sealed class X509Store : IDisposable // TypeDefIndex: 2837
{	// Fields
	private string _name; // 0x10
	private StoreLocation _location; // 0x18
	private X509Certificate2Collection list; // 0x20
	private OpenFlags _flags; // 0x28
	private X509Store store; // 0x30

	// Properties
	public X509Certificate2Collection Certificates { get; }
	private X509Stores Factory { get; }
	internal X509Store Store { get; }

	// Methods

	// RVA: 0x14DB8C0 Offset: 0x14D9EC0 VA: 0x1814DB8C0
	public void .ctor(StoreName storeName, StoreLocation storeLocation) { }

	// RVA: 0x14DBA00 Offset: 0x14DA000 VA: 0x1814DBA00
	public X509Certificate2Collection get_Certificates() { }

	// RVA: 0x14DBAA0 Offset: 0x14DA0A0 VA: 0x1814DBAA0
	private X509Stores get_Factory() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	internal X509Store get_Store() { }

	// RVA: 0x14DB560 Offset: 0x14D9B60 VA: 0x1814DB560
	public void Close() { }

	// RVA: 0x14DB560 Offset: 0x14D9B60 VA: 0x1814DB560 Slot: 4
	public void Dispose() { }

	// RVA: 0x14DB5A0 Offset: 0x14D9BA0 VA: 0x1814DB5A0
	public void Open(OpenFlags flags) { }

}

