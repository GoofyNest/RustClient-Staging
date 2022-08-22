public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter // TypeDefIndex: 1009
{	// Fields
	private RSA rsa; // 0x10
	private string hashName; // 0x18

	// Methods

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0x17B7470 Offset: 0x17B5A70 VA: 0x1817B7470
	public void .ctor(AsymmetricAlgorithm key) { }

	// RVA: 0x17B71A0 Offset: 0x17B57A0 VA: 0x1817B71A0 Slot: 5
	public override void SetHashAlgorithm(string strName) { }

	// RVA: 0x17B7220 Offset: 0x17B5820 VA: 0x1817B7220 Slot: 4
	public override void SetKey(AsymmetricAlgorithm key) { }

	// RVA: 0x17B72E0 Offset: 0x17B58E0 VA: 0x1817B72E0 Slot: 6
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

}

