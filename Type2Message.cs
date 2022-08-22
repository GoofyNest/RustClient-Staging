public class Type2Message : MessageBase // TypeDefIndex: 1732
{	// Fields
	private byte[] _nonce; // 0x18
	private string _targetName; // 0x20
	private byte[] _targetInfo; // 0x28

	// Properties
	public byte[] Nonce { get; }
	public string TargetName { get; }
	public byte[] TargetInfo { get; }

	// Methods

	// RVA: 0x1AC5280 Offset: 0x1AC3880 VA: 0x181AC5280
	public void .ctor(byte[] message) { }

	// RVA: 0x1AC50B0 Offset: 0x1AC36B0 VA: 0x181AC50B0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AC5320 Offset: 0x1AC3920 VA: 0x181AC5320
	public byte[] get_Nonce() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_TargetName() { }

	// RVA: 0x1AC53A0 Offset: 0x1AC39A0 VA: 0x181AC53A0
	public byte[] get_TargetInfo() { }

	// RVA: 0x1AC4F20 Offset: 0x1AC3520 VA: 0x181AC4F20 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1AC5150 Offset: 0x1AC3750 VA: 0x181AC5150 Slot: 5
	public override byte[] GetBytes() { }

}

