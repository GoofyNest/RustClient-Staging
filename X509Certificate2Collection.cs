public class X509Certificate2Collection : X509CertificateCollection // TypeDefIndex: 2815
{	// Fields
	private static string[] newline_split; // 0x14514

	// Properties
	public X509Certificate2 Item { get; }

	// Methods

	// RVA: 0x11929D0 Offset: 0x1190FD0 VA: 0x1811929D0
	public void .ctor() { }

	// RVA: 0x11929E0 Offset: 0x1190FE0 VA: 0x1811929E0
	public void .ctor(X509Certificate2Collection certificates) { }

	// RVA: 0x1192A80 Offset: 0x1191080 VA: 0x181192A80
	public X509Certificate2 get_Item(int index) { }

	// RVA: 0x1191680 Offset: 0x118FC80 VA: 0x181191680
	public int Add(X509Certificate2 certificate) { }

	[MonoTODOAttribute] // RVA: 0xB01A0 Offset: 0xAF5A0 VA: 0x1800B01A0
	// RVA: 0x11915E0 Offset: 0x118FBE0 VA: 0x1811915E0
	public void AddRange(X509Certificate2Collection certificates) { }

	// RVA: 0x1191720 Offset: 0x118FD20 VA: 0x181191720
	public bool Contains(X509Certificate2 certificate) { }

	[MonoTODOAttribute] // RVA: 0xB0230 Offset: 0xAF630 VA: 0x1800B0230
	// RVA: 0x1191980 Offset: 0x118FF80 VA: 0x181191980
	public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly) { }

	// RVA: 0x11928B0 Offset: 0x1190EB0 VA: 0x1811928B0
	public X509Certificate2Enumerator GetEnumerator() { }

	// RVA: 0x1192910 Offset: 0x1190F10 VA: 0x181192910
	private static void .cctor() { }

}

