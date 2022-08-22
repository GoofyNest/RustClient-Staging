public sealed class RC2CryptoServiceProvider : RC2 // TypeDefIndex: 974
{	// Fields
	private bool m_use40bitSalt; // 0x50
	private static KeySizes[] s_legalKeySizes; // 0x0

	// Properties
	public override int EffectiveKeySize { get; }

	// Methods

	// RVA: 0x1702F80 Offset: 0x1701580 VA: 0x181702F80
	public void .ctor() { }

	// RVA: 0x6BB9E0 Offset: 0x6B9FE0 VA: 0x1806BB9E0 Slot: 26
	public override int get_EffectiveKeySize() { }

	// RVA: 0x1702CE0 Offset: 0x17012E0 VA: 0x181702CE0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x1702C20 Offset: 0x1701220 VA: 0x181702C20 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x1702E20 Offset: 0x1701420 VA: 0x181702E20 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x1702DA0 Offset: 0x17013A0 VA: 0x181702DA0 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x1702EA0 Offset: 0x17014A0 VA: 0x181702EA0
	private static void .cctor() { }

}

