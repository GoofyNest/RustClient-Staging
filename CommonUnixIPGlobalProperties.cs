internal abstract class CommonUnixIPGlobalProperties : IPGlobalProperties // TypeDefIndex: 3077
{	// Properties
	public override string DomainName { get; }

	// Methods

	// RVA: 0x132EFC0 Offset: 0x132D5C0 VA: 0x18132EFC0
	private static extern int getdomainname(byte[] name, int len) { }

	// RVA: 0x132EE50 Offset: 0x132D450 VA: 0x18132EE50 Slot: 4
	public override string get_DomainName() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

