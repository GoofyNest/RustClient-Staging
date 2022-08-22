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

	// RVA: 0x1AC6400 Offset: 0x1AC4A00 VA: 0x181AC6400
	public void .ctor(Type2Message type2) { }

	// RVA: 0x1AC57E0 Offset: 0x1AC3DE0 VA: 0x181AC57E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AC6650 Offset: 0x1AC4C50 VA: 0x181AC6650
	public void set_Domain(string value) { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	public void set_Password(string value) { }

	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	public void set_Username(string value) { }

	// RVA: 0x1AC5490 Offset: 0x1AC3A90 VA: 0x181AC5490 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1AC5420 Offset: 0x1AC3A20 VA: 0x181AC5420
	private string DecodeString(byte[] buffer, int offset, int len) { }

	// RVA: 0x1AC5750 Offset: 0x1AC3D50 VA: 0x181AC5750
	private byte[] EncodeString(string text) { }

	// RVA: 0x1AC58B0 Offset: 0x1AC3EB0 VA: 0x181AC58B0 Slot: 5
	public override byte[] GetBytes() { }

}

