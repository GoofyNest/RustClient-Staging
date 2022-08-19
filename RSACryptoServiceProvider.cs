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
	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x17B6D50 Offset: 0x17B5350 VA: 0x1817B6D50
	public static bool get_UseMachineKeyStore() { }

	// RVA: 0x17B6B60 Offset: 0x17B5160 VA: 0x1817B6B60
	public void .ctor() { }

	// RVA: 0x17B6A30 Offset: 0x17B5030 VA: 0x1817B6A30
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x17B6CC0 Offset: 0x17B52C0 VA: 0x1817B6CC0
	public void .ctor(int dwKeySize) { }

	// RVA: 0x17B6B90 Offset: 0x17B5190 VA: 0x1817B6B90
	public void .ctor(int dwKeySize, CspParameters parameters) { }

	// RVA: 0x17B64A0 Offset: 0x17B4AA0 VA: 0x1817B64A0
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0x17B66F0 Offset: 0x17B4CF0 VA: 0x1817B66F0
	private void Common(CspParameters p) { }

	// RVA: 0x9E4550 Offset: 0x9E2B50 VA: 0x1809E4550 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x17B6D00 Offset: 0x17B5300 VA: 0x1817B6D00 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x17B6D30 Offset: 0x17B5330 VA: 0x1817B6D30
	public bool get_PublicOnly() { }

	// RVA: 0x12AA920 Offset: 0x12A8F20 VA: 0x1812AA920 Slot: 10
	public override byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x17B6800 Offset: 0x17B4E00 VA: 0x1817B6800 Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x16FF920 Offset: 0x16FDF20 VA: 0x1816FF920 Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x16FF7F0 Offset: 0x16FDDF0 VA: 0x1816FF7F0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x17B69B0 Offset: 0x17B4FB0 VA: 0x1817B69B0
	private void OnKeyGenerated(object sender, EventArgs e) { }

}

