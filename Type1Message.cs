public class Type1Message : MessageBase // TypeDefIndex: 1731
{	// Fields
	private string _host; // 0x18
	private string _domain; // 0x20

	// Properties
	public string Domain { set; }
	public string Host { set; }

	// Methods

	// RVA: 0x1AC4F50 Offset: 0x1AC3550 VA: 0x181AC4F50
	public void .ctor() { }

	// RVA: 0x1AC4FE0 Offset: 0x1AC35E0 VA: 0x181AC4FE0
	public void set_Domain(string value) { }

	// RVA: 0x1AC5060 Offset: 0x1AC3660 VA: 0x181AC5060
	public void set_Host(string value) { }

	// RVA: 0x1AC4AA0 Offset: 0x1AC30A0 VA: 0x181AC4AA0 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1AC4BC0 Offset: 0x1AC31C0 VA: 0x181AC4BC0 Slot: 5
	public override byte[] GetBytes() { }

}

