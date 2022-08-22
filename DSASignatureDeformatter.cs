public class DSASignatureDeformatter : AsymmetricSignatureDeformatter // TypeDefIndex: 957
{	// Fields
	private DSA _dsaKey; // 0x10
	private string _oid; // 0x18

	// Methods

	// RVA: 0x16FDD30 Offset: 0x16FC330 VA: 0x1816FDD30
	public void .ctor() { }

	// RVA: 0x16FDC10 Offset: 0x16FC210 VA: 0x1816FDC10
	public void .ctor(AsymmetricAlgorithm key) { }

	// RVA: 0x16FDA40 Offset: 0x16FC040 VA: 0x1816FDA40 Slot: 4
	public override void SetKey(AsymmetricAlgorithm key) { }

	// RVA: 0x16FD990 Offset: 0x16FBF90 VA: 0x1816FD990 Slot: 5
	public override void SetHashAlgorithm(string strName) { }

	// RVA: 0x16FDB00 Offset: 0x16FC100 VA: 0x1816FDB00 Slot: 6
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

}

