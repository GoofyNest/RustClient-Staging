public sealed class RijndaelManaged : Rijndael // TypeDefIndex: 976
{	// Methods

	// RVA: 0x17B9290 Offset: 0x17B7890 VA: 0x1817B9290
	public void .ctor() { }

	// RVA: 0x17B8E70 Offset: 0x17B7470 VA: 0x1817B8E70 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x17B8CF0 Offset: 0x17B72F0 VA: 0x1817B8CF0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x17B9080 Offset: 0x17B7680 VA: 0x1817B9080 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x17B8FF0 Offset: 0x17B75F0 VA: 0x1817B8FF0 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x17B9110 Offset: 0x17B7710 VA: 0x1817B9110
	private ICryptoTransform NewEncryptor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int feedbackSize, RijndaelManagedTransformMode encryptMode) { }

}

