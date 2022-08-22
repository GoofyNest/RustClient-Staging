public struct X509ChainStatus // TypeDefIndex: 2829
{	// Fields
	private X509ChainStatusFlags status; // 0x0
	private string info; // 0x8

	// Properties
	public X509ChainStatusFlags Status { get; set; }
	public string StatusInformation { set; }

	// Methods

	// RVA: 0x1F1AA0 Offset: 0x1F0EA0 VA: 0x1801F1AA0
	internal void .ctor(X509ChainStatusFlags flag) { }

	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720
	public X509ChainStatusFlags get_Status() { }

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public void set_Status(X509ChainStatusFlags value) { }

	// RVA: 0xF14A0 Offset: 0xF08A0 VA: 0x1800F14A0
	public void set_StatusInformation(string value) { }

	// RVA: 0x14D9340 Offset: 0x14D7940 VA: 0x1814D9340
	internal static string GetInformation(X509ChainStatusFlags flags) { }

}

