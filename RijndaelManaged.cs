public sealed class RijndaelManaged : Rijndael // TypeDefIndex: 976
{	// Methods

	// RVA: 0x17BB740 Offset: 0x17B9D40 VA: 0x1817BB740
	public void .ctor() { }

	// RVA: 0x17BB320 Offset: 0x17B9920 VA: 0x1817BB320 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x17BB1A0 Offset: 0x17B97A0 VA: 0x1817BB1A0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x17BB530 Offset: 0x17B9B30 VA: 0x1817BB530 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x17BB4A0 Offset: 0x17B9AA0 VA: 0x1817BB4A0 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x17BB5C0 Offset: 0x17B9BC0 VA: 0x1817BB5C0
	private ICryptoTransform NewEncryptor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int feedbackSize, RijndaelManagedTransformMode encryptMode) { }

}

