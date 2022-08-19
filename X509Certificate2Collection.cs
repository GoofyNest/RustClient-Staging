public class X509Certificate2Collection : X509CertificateCollection // TypeDefIndex: 2815
{	// Fields
	private static string[] newline_split; // 0x14514

	// Properties
	public X509Certificate2 Item { get; }

	// Methods

	// RVA: 0x1192710 Offset: 0x1190D10 VA: 0x181192710
	public void .ctor() { }

	// RVA: 0x1192720 Offset: 0x1190D20 VA: 0x181192720
	public void .ctor(X509Certificate2Collection certificates) { }

	// RVA: 0x11927C0 Offset: 0x1190DC0 VA: 0x1811927C0
	public X509Certificate2 get_Item(int index) { }

	// RVA: 0x11913C0 Offset: 0x118F9C0 VA: 0x1811913C0
	public int Add(X509Certificate2 certificate) { }

	[MonoTODOAttribute] // RVA: 0xB0160 Offset: 0xAF560 VA: 0x1800B0160
	// RVA: 0x1191320 Offset: 0x118F920 VA: 0x181191320
	public void AddRange(X509Certificate2Collection certificates) { }

	// RVA: 0x1191460 Offset: 0x118FA60 VA: 0x181191460
	public bool Contains(X509Certificate2 certificate) { }

	[MonoTODOAttribute] // RVA: 0xB01E0 Offset: 0xAF5E0 VA: 0x1800B01E0
	// RVA: 0x11916C0 Offset: 0x118FCC0 VA: 0x1811916C0
	public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly) { }

	// RVA: 0x11925F0 Offset: 0x1190BF0 VA: 0x1811925F0
	public X509Certificate2Enumerator GetEnumerator() { }

	// RVA: 0x1192650 Offset: 0x1190C50 VA: 0x181192650
	private static void .cctor() { }

}

