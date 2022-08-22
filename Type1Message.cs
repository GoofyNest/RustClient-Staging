public class Type1Message : MessageBase // TypeDefIndex: 1731
{	// Fields
	private string _host; // 0x18
	private string _domain; // 0x20

	// Properties
	public string Domain { set; }
	public string Host { set; }

	// Methods

	// RVA: 0x1AC5840 Offset: 0x1AC3E40 VA: 0x181AC5840
	public void .ctor() { }

	// RVA: 0x1AC58D0 Offset: 0x1AC3ED0 VA: 0x181AC58D0
	public void set_Domain(string value) { }

	// RVA: 0x1AC5950 Offset: 0x1AC3F50 VA: 0x181AC5950
	public void set_Host(string value) { }

	// RVA: 0x1AC5390 Offset: 0x1AC3990 VA: 0x181AC5390 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1AC54B0 Offset: 0x1AC3AB0 VA: 0x181AC54B0 Slot: 5
	public override byte[] GetBytes() { }

}

