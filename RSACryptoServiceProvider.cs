public sealed class RSACryptoServiceProvider : RSA // TypeDefIndex: 983
{	// Fields
	private static CspProviderFlags s_UseMachineKeyStore; // 0x0
	private KeyPairPersistence store; // 0x20
	private bool persistKey; // 0x28
	private bool persisted; // 0x29
	private bool privateKeyExportable; // 0x2A
	private bool m_disposed; // 0x2B
	private RSAManaged rsa; // 0x30

	// Properties
	public static bool UseMachineKeyStore { get; }
	public override int KeySize { get; }
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x17B7010 Offset: 0x17B5610 VA: 0x1817B7010
	public static bool get_UseMachineKeyStore() { }

	// RVA: 0x17B6E20 Offset: 0x17B5420 VA: 0x1817B6E20
	public void .ctor() { }

	// RVA: 0x17B6CF0 Offset: 0x17B52F0 VA: 0x1817B6CF0
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x17B6F80 Offset: 0x17B5580 VA: 0x1817B6F80
	public void .ctor(int dwKeySize) { }

	// RVA: 0x17B6E50 Offset: 0x17B5450 VA: 0x1817B6E50
	public void .ctor(int dwKeySize, CspParameters parameters) { }

	// RVA: 0x17B6760 Offset: 0x17B4D60 VA: 0x1817B6760
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0x17B69B0 Offset: 0x17B4FB0 VA: 0x1817B69B0
	private void Common(CspParameters p) { }

	// RVA: 0x9E4810 Offset: 0x9E2E10 VA: 0x1809E4810 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x17B6FC0 Offset: 0x17B55C0 VA: 0x1817B6FC0 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x17B6FF0 Offset: 0x17B55F0 VA: 0x1817B6FF0
	public bool get_PublicOnly() { }

	// RVA: 0x12AABE0 Offset: 0x12A91E0 VA: 0x1812AABE0 Slot: 10
	public override byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x17B6AC0 Offset: 0x17B50C0 VA: 0x1817B6AC0 Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x16FFBE0 Offset: 0x16FE1E0 VA: 0x1816FFBE0 Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x16FFAB0 Offset: 0x16FE0B0 VA: 0x1816FFAB0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x17B6C70 Offset: 0x17B5270 VA: 0x1817B6C70
	private void OnKeyGenerated(object sender, EventArgs e) { }

}

