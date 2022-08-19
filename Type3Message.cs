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

	// RVA: 0x1AC65C0 Offset: 0x1AC4BC0 VA: 0x181AC65C0
	public void .ctor(Type2Message type2) { }

	// RVA: 0x1AC59A0 Offset: 0x1AC3FA0 VA: 0x181AC59A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AC6810 Offset: 0x1AC4E10 VA: 0x181AC6810
	public void set_Domain(string value) { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	public void set_Password(string value) { }

	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	public void set_Username(string value) { }

	// RVA: 0x1AC5650 Offset: 0x1AC3C50 VA: 0x181AC5650 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1AC55E0 Offset: 0x1AC3BE0 VA: 0x181AC55E0
	private string DecodeString(byte[] buffer, int offset, int len) { }

	// RVA: 0x1AC5910 Offset: 0x1AC3F10 VA: 0x181AC5910
	private byte[] EncodeString(string text) { }

	// RVA: 0x1AC5A70 Offset: 0x1AC4070 VA: 0x181AC5A70 Slot: 5
	public override byte[] GetBytes() { }

}

