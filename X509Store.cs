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

	// RVA: 0x22829C0 Offset: 0x2280FC0 VA: 0x1822829C0
	internal void .ctor(string path, bool crl, bool newFormat) { }

	// RVA: 0x2282A20 Offset: 0x2281020 VA: 0x182282A20
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x2282A60 Offset: 0x2281060 VA: 0x182282A60
	public ArrayList get_Crls() { }

	// RVA: 0x2282870 Offset: 0x2280E70 VA: 0x182282870
	private byte[] Load(string filename) { }

	// RVA: 0x22826E0 Offset: 0x2280CE0 VA: 0x1822826E0
	private X509Certificate LoadCertificate(string filename) { }

	// RVA: 0x2282750 Offset: 0x2280D50 VA: 0x182282750
	private X509Crl LoadCrl(string filename) { }

	// RVA: 0x2282650 Offset: 0x2280C50 VA: 0x182282650
	private bool CheckStore(string path, bool throwException) { }

	// RVA: 0x22823C0 Offset: 0x22809C0 VA: 0x1822823C0
	private X509CertificateCollection BuildCertificatesCollection(string storeName) { }

	// RVA: 0x2282510 Offset: 0x2280B10 VA: 0x182282510
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

	// RVA: 0x14DC530 Offset: 0x14DAB30 VA: 0x1814DC530
	public void .ctor(StoreName storeName, StoreLocation storeLocation) { }

	// RVA: 0x14DC670 Offset: 0x14DAC70 VA: 0x1814DC670
	public X509Certificate2Collection get_Certificates() { }

	// RVA: 0x14DC710 Offset: 0x14DAD10 VA: 0x1814DC710
	private X509Stores get_Factory() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	internal X509Store get_Store() { }

	// RVA: 0x14DC1D0 Offset: 0x14DA7D0 VA: 0x1814DC1D0
	public void Close() { }

	// RVA: 0x14DC1D0 Offset: 0x14DA7D0 VA: 0x1814DC1D0 Slot: 4
	public void Dispose() { }

	// RVA: 0x14DC210 Offset: 0x14DA810 VA: 0x1814DC210
	public void Open(OpenFlags flags) { }

}

