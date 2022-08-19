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

	// RVA: 0x1AC5440 Offset: 0x1AC3A40 VA: 0x181AC5440
	public void .ctor(byte[] message) { }

	// RVA: 0x1AC5270 Offset: 0x1AC3870 VA: 0x181AC5270 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AC54E0 Offset: 0x1AC3AE0 VA: 0x181AC54E0
	public byte[] get_Nonce() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_TargetName() { }

	// RVA: 0x1AC5560 Offset: 0x1AC3B60 VA: 0x181AC5560
	public byte[] get_TargetInfo() { }

	// RVA: 0x1AC50E0 Offset: 0x1AC36E0 VA: 0x181AC50E0 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1AC5310 Offset: 0x1AC3910 VA: 0x181AC5310 Slot: 5
	public override byte[] GetBytes() { }

}

