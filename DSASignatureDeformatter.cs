public class DSASignatureDeformatter : AsymmetricSignatureDeformatter // TypeDefIndex: 957
{	// Fields
	private DSA _dsaKey; // 0x10
	private string _oid; // 0x18

	// Methods

	// RVA: 0x1700140 Offset: 0x16FE740 VA: 0x181700140
	public void .ctor() { }

	// RVA: 0x1700020 Offset: 0x16FE620 VA: 0x181700020
	public void .ctor(AsymmetricAlgorithm key) { }

	// RVA: 0x16FFE50 Offset: 0x16FE450 VA: 0x1816FFE50 Slot: 4
	public override void SetKey(AsymmetricAlgorithm key) { }

	// RVA: 0x16FFDA0 Offset: 0x16FE3A0 VA: 0x1816FFDA0 Slot: 5
	public override void SetHashAlgorithm(string strName) { }

	// RVA: 0x16FFF10 Offset: 0x16FE510 VA: 0x1816FFF10 Slot: 6
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

}

