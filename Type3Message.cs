public class Type3Message : MessageBase // TypeDefIndex: 1733
{	// Fields
	private NtlmAuthLevel _level; // 0x18
	private byte[] _challenge; // 0x20
	private string _host; // 0x28
	private string _domain; // 0x30
	private string _username; // 0x38
	private string _password; // 0x40
	private Type2Message _type2; // 0x48
	private byte[] _lm; // 0x50
	private byte[] _nt; // 0x58

	// Properties
	public string Domain { set; }
	public string Password { set; }
	public string Username { set; }

	// Methods

	// RVA: 0x1AC6EB0 Offset: 0x1AC54B0 VA: 0x181AC6EB0
	public void .ctor(Type2Message type2) { }

	// RVA: 0x1AC6290 Offset: 0x1AC4890 VA: 0x181AC6290 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AC7100 Offset: 0x1AC5700 VA: 0x181AC7100
	public void set_Domain(string value) { }

	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	public void set_Password(string value) { }

	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	public void set_Username(string value) { }

	// RVA: 0x1AC5F40 Offset: 0x1AC4540 VA: 0x181AC5F40 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1AC5ED0 Offset: 0x1AC44D0 VA: 0x181AC5ED0
	private string DecodeString(byte[] buffer, int offset, int len) { }

	// RVA: 0x1AC6200 Offset: 0x1AC4800 VA: 0x181AC6200
	private byte[] EncodeString(string text) { }

	// RVA: 0x1AC6360 Offset: 0x1AC4960 VA: 0x181AC6360 Slot: 5
	public override byte[] GetBytes() { }

}

