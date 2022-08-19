public class DSASignatureDeformatter : AsymmetricSignatureDeformatter // TypeDefIndex: 957
{	// Fields
	private DSA _dsaKey; // 0x10
	private string _oid; // 0x18

	// Methods

	// RVA: 0x16FFE80 Offset: 0x16FE480 VA: 0x1816FFE80
	public void .ctor() { }

	// RVA: 0x16FFD60 Offset: 0x16FE360 VA: 0x1816FFD60
	public void .ctor(AsymmetricAlgorithm key) { }

	// RVA: 0x16FFB90 Offset: 0x16FE190 VA: 0x1816FFB90 Slot: 4
	public override void SetKey(AsymmetricAlgorithm key) { }

	// RVA: 0x16FFAE0 Offset: 0x16FE0E0 VA: 0x1816FFAE0 Slot: 5
	public override void SetHashAlgorithm(string strName) { }

	// RVA: 0x16FFC50 Offset: 0x16FE250 VA: 0x1816FFC50 Slot: 6
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

}

