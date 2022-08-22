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

	// RVA: 0x1AC5D30 Offset: 0x1AC4330 VA: 0x181AC5D30
	public void .ctor(byte[] message) { }

	// RVA: 0x1AC5B60 Offset: 0x1AC4160 VA: 0x181AC5B60 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AC5DD0 Offset: 0x1AC43D0 VA: 0x181AC5DD0
	public byte[] get_Nonce() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_TargetName() { }

	// RVA: 0x1AC5E50 Offset: 0x1AC4450 VA: 0x181AC5E50
	public byte[] get_TargetInfo() { }

	// RVA: 0x1AC59D0 Offset: 0x1AC3FD0 VA: 0x181AC59D0 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1AC5C00 Offset: 0x1AC4200 VA: 0x181AC5C00 Slot: 5
	public override byte[] GetBytes() { }

}

