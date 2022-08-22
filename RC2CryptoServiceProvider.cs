public sealed class RC2CryptoServiceProvider : RC2 // TypeDefIndex: 974
{	// Fields
	private bool m_use40bitSalt; // 0x50
	private static KeySizes[] s_legalKeySizes; // 0x0

	// Properties
	public override int EffectiveKeySize { get; }

	// Methods

	// RVA: 0x1705390 Offset: 0x1703990 VA: 0x181705390
	public void .ctor() { }

	// RVA: 0x6BBA50 Offset: 0x6BA050 VA: 0x1806BBA50 Slot: 26
	public override int get_EffectiveKeySize() { }

	// RVA: 0x17050F0 Offset: 0x17036F0 VA: 0x1817050F0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x1705030 Offset: 0x1703630 VA: 0x181705030 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x1705230 Offset: 0x1703830 VA: 0x181705230 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x17051B0 Offset: 0x17037B0 VA: 0x1817051B0 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x17052B0 Offset: 0x17038B0 VA: 0x1817052B0
	private static void .cctor() { }

}

