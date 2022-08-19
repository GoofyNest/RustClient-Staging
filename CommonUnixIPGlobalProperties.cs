internal abstract class CommonUnixIPGlobalProperties : IPGlobalProperties // TypeDefIndex: 3077
{	// Properties
	public override string DomainName { get; }

	// Methods

	// RVA: 0x132FC00 Offset: 0x132E200 VA: 0x18132FC00
	private static extern int getdomainname(byte[] name, int len) { }

	// RVA: 0x132FA90 Offset: 0x132E090 VA: 0x18132FA90 Slot: 4
	public override string get_DomainName() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

