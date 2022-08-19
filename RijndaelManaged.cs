public sealed class RijndaelManaged : Rijndael // TypeDefIndex: 976
{	// Methods

	// RVA: 0x17BB480 Offset: 0x17B9A80 VA: 0x1817BB480
	public void .ctor() { }

	// RVA: 0x17BB060 Offset: 0x17B9660 VA: 0x1817BB060 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x17BAEE0 Offset: 0x17B94E0 VA: 0x1817BAEE0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x17BB270 Offset: 0x17B9870 VA: 0x1817BB270 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x17BB1E0 Offset: 0x17B97E0 VA: 0x1817BB1E0 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x17BB300 Offset: 0x17B9900 VA: 0x1817BB300
	private ICryptoTransform NewEncryptor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int feedbackSize, RijndaelManagedTransformMode encryptMode) { }

}

