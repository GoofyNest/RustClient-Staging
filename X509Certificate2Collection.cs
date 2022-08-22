public class X509Certificate2Collection : X509CertificateCollection // TypeDefIndex: 2815
{	// Fields
	private static string[] newline_split; // 0x142A0

	// Properties
	public X509Certificate2 Item { get; }

	// Methods

	// RVA: 0x11972F0 Offset: 0x11958F0 VA: 0x1811972F0
	public void .ctor() { }

	// RVA: 0x1197300 Offset: 0x1195900 VA: 0x181197300
	public void .ctor(X509Certificate2Collection certificates) { }

	// RVA: 0x11973A0 Offset: 0x11959A0 VA: 0x1811973A0
	public X509Certificate2 get_Item(int index) { }

	// RVA: 0x1195FA0 Offset: 0x11945A0 VA: 0x181195FA0
	public int Add(X509Certificate2 certificate) { }

	[MonoTODOAttribute] // RVA: 0xB01A0 Offset: 0xAF5A0 VA: 0x1800B01A0
	// RVA: 0x1195F00 Offset: 0x1194500 VA: 0x181195F00
	public void AddRange(X509Certificate2Collection certificates) { }

	// RVA: 0x1196040 Offset: 0x1194640 VA: 0x181196040
	public bool Contains(X509Certificate2 certificate) { }

	[MonoTODOAttribute] // RVA: 0xB0230 Offset: 0xAF630 VA: 0x1800B0230
	// RVA: 0x11962A0 Offset: 0x11948A0 VA: 0x1811962A0
	public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly) { }

	// RVA: 0x11971D0 Offset: 0x11957D0 VA: 0x1811971D0
	public X509Certificate2Enumerator GetEnumerator() { }

	// RVA: 0x1197230 Offset: 0x1195830 VA: 0x181197230
	private static void .cctor() { }

}

