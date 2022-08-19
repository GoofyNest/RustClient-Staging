public sealed class RC2CryptoServiceProvider : RC2 // TypeDefIndex: 974
{	// Fields
	private bool m_use40bitSalt; // 0x50
	private static KeySizes[] s_legalKeySizes; // 0x0

	// Properties
	public override int EffectiveKeySize { get; }

	// Methods

	// RVA: 0x17050D0 Offset: 0x17036D0 VA: 0x1817050D0
	public void .ctor() { }

	// RVA: 0x6BB940 Offset: 0x6B9F40 VA: 0x1806BB940 Slot: 26
	public override int get_EffectiveKeySize() { }

	// RVA: 0x1704E30 Offset: 0x1703430 VA: 0x181704E30 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x1704D70 Offset: 0x1703370 VA: 0x181704D70 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x1704F70 Offset: 0x1703570 VA: 0x181704F70 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x1704EF0 Offset: 0x17034F0 VA: 0x181704EF0 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x1704FF0 Offset: 0x17035F0 VA: 0x181704FF0
	private static void .cctor() { }

}

