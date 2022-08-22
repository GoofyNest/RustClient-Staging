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

	// RVA: 0x1AC66C0 Offset: 0x1AC4CC0 VA: 0x181AC66C0
	public void .ctor(Type2Message type2) { }

	// RVA: 0x1AC5AA0 Offset: 0x1AC40A0 VA: 0x181AC5AA0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AC6910 Offset: 0x1AC4F10 VA: 0x181AC6910
	public void set_Domain(string value) { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	public void set_Password(string value) { }

	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	public void set_Username(string value) { }

	// RVA: 0x1AC5750 Offset: 0x1AC3D50 VA: 0x181AC5750 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1AC56E0 Offset: 0x1AC3CE0 VA: 0x181AC56E0
	private string DecodeString(byte[] buffer, int offset, int len) { }

	// RVA: 0x1AC5A10 Offset: 0x1AC4010 VA: 0x181AC5A10
	private byte[] EncodeString(string text) { }

	// RVA: 0x1AC5B70 Offset: 0x1AC4170 VA: 0x181AC5B70 Slot: 5
	public override byte[] GetBytes() { }

}

