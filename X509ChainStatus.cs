public struct X509ChainStatus // TypeDefIndex: 2829
{	// Fields
	private X509ChainStatusFlags status; // 0x0
	private string info; // 0x8

	// Properties
	public X509ChainStatusFlags Status { get; set; }
	public string StatusInformation { set; }

	// Methods

	// RVA: 0x1F1B20 Offset: 0x1F0F20 VA: 0x1801F1B20
	internal void .ctor(X509ChainStatusFlags flag) { }

	// RVA: 0xF37A0 Offset: 0xF2BA0 VA: 0x1800F37A0
	public X509ChainStatusFlags get_Status() { }

	// RVA: 0xF38D0 Offset: 0xF2CD0 VA: 0x1800F38D0
	public void set_Status(X509ChainStatusFlags value) { }

	// RVA: 0xF1520 Offset: 0xF0920 VA: 0x1800F1520
	public void set_StatusInformation(string value) { }

	// RVA: 0x14D9340 Offset: 0x14D7940 VA: 0x1814D9340
	internal static string GetInformation(X509ChainStatusFlags flags) { }

}

