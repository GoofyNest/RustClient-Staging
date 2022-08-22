public class Type1Message : MessageBase // TypeDefIndex: 1731
{	// Fields
	private string _host; // 0x18
	private string _domain; // 0x20

	// Properties
	public string Domain { set; }
	public string Host { set; }

	// Methods

	// RVA: 0x1AC4D90 Offset: 0x1AC3390 VA: 0x181AC4D90
	public void .ctor() { }

	// RVA: 0x1AC4E20 Offset: 0x1AC3420 VA: 0x181AC4E20
	public void set_Domain(string value) { }

	// RVA: 0x1AC4EA0 Offset: 0x1AC34A0 VA: 0x181AC4EA0
	public void set_Host(string value) { }

	// RVA: 0x1AC48E0 Offset: 0x1AC2EE0 VA: 0x181AC48E0 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1AC4A00 Offset: 0x1AC3000 VA: 0x181AC4A00 Slot: 5
	public override byte[] GetBytes() { }

}

