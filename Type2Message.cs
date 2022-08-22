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

	// RVA: 0x1AC5540 Offset: 0x1AC3B40 VA: 0x181AC5540
	public void .ctor(byte[] message) { }

	// RVA: 0x1AC5370 Offset: 0x1AC3970 VA: 0x181AC5370 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AC55E0 Offset: 0x1AC3BE0 VA: 0x181AC55E0
	public byte[] get_Nonce() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_TargetName() { }

	// RVA: 0x1AC5660 Offset: 0x1AC3C60 VA: 0x181AC5660
	public byte[] get_TargetInfo() { }

	// RVA: 0x1AC51E0 Offset: 0x1AC37E0 VA: 0x181AC51E0 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1AC5410 Offset: 0x1AC3A10 VA: 0x181AC5410 Slot: 5
	public override byte[] GetBytes() { }

}

