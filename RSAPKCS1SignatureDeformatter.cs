public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter // TypeDefIndex: 1009
{	// Fields
	private RSA rsa; // 0x10
	private string hashName; // 0x18

	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0x17B4FC0 Offset: 0x17B35C0 VA: 0x1817B4FC0
	public void .ctor(AsymmetricAlgorithm key) { }

	// RVA: 0x17B4CF0 Offset: 0x17B32F0 VA: 0x1817B4CF0 Slot: 5
	public override void SetHashAlgorithm(string strName) { }

	// RVA: 0x17B4D70 Offset: 0x17B3370 VA: 0x1817B4D70 Slot: 4
	public override void SetKey(AsymmetricAlgorithm key) { }

	// RVA: 0x17B4E30 Offset: 0x17B3430 VA: 0x1817B4E30 Slot: 6
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

}

