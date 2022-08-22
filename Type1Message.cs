public class Type1Message : MessageBase // TypeDefIndex: 1731
{	// Fields
	private string _host; // 0x18
	private string _domain; // 0x20

	// Properties
	public string Domain { set; }
	public string Host { set; }

	// Methods

	// RVA: 0x1AC5050 Offset: 0x1AC3650 VA: 0x181AC5050
	public void .ctor() { }

	// RVA: 0x1AC50E0 Offset: 0x1AC36E0 VA: 0x181AC50E0
	public void set_Domain(string value) { }

	// RVA: 0x1AC5160 Offset: 0x1AC3760 VA: 0x181AC5160
	public void set_Host(string value) { }

	// RVA: 0x1AC4BA0 Offset: 0x1AC31A0 VA: 0x181AC4BA0 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1AC4CC0 Offset: 0x1AC32C0 VA: 0x181AC4CC0 Slot: 5
	public override byte[] GetBytes() { }

}

