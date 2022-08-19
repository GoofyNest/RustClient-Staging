public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter // TypeDefIndex: 1009
{	// Fields
	private RSA rsa; // 0x10
	private string hashName; // 0x18

	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0x17B71B0 Offset: 0x17B57B0 VA: 0x1817B71B0
	public void .ctor(AsymmetricAlgorithm key) { }

	// RVA: 0x17B6EE0 Offset: 0x17B54E0 VA: 0x1817B6EE0 Slot: 5
	public override void SetHashAlgorithm(string strName) { }

	// RVA: 0x17B6F60 Offset: 0x17B5560 VA: 0x1817B6F60 Slot: 4
	public override void SetKey(AsymmetricAlgorithm key) { }

	// RVA: 0x17B7020 Offset: 0x17B5620 VA: 0x1817B7020 Slot: 6
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

}

