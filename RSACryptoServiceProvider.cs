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

	// RVA: 0x17B4B60 Offset: 0x17B3160 VA: 0x1817B4B60
	public static bool get_UseMachineKeyStore() { }

	// RVA: 0x17B4970 Offset: 0x17B2F70 VA: 0x1817B4970
	public void .ctor() { }

	// RVA: 0x17B4840 Offset: 0x17B2E40 VA: 0x1817B4840
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x17B4AD0 Offset: 0x17B30D0 VA: 0x1817B4AD0
	public void .ctor(int dwKeySize) { }

	// RVA: 0x17B49A0 Offset: 0x17B2FA0 VA: 0x1817B49A0
	public void .ctor(int dwKeySize, CspParameters parameters) { }

	// RVA: 0x17B42B0 Offset: 0x17B28B0 VA: 0x1817B42B0
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0x17B4500 Offset: 0x17B2B00 VA: 0x1817B4500
	private void Common(CspParameters p) { }

	// RVA: 0x9E4D00 Offset: 0x9E3300 VA: 0x1809E4D00 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x17B4B10 Offset: 0x17B3110 VA: 0x1817B4B10 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x17B4B40 Offset: 0x17B3140 VA: 0x1817B4B40
	public bool get_PublicOnly() { }

	// RVA: 0x12AB280 Offset: 0x12A9880 VA: 0x1812AB280 Slot: 10
	public override byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x17B4610 Offset: 0x17B2C10 VA: 0x1817B4610 Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x16FD7D0 Offset: 0x16FBDD0 VA: 0x1816FD7D0 Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x16FD6A0 Offset: 0x16FBCA0 VA: 0x1816FD6A0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x17B47C0 Offset: 0x17B2DC0 VA: 0x1817B47C0
	private void OnKeyGenerated(object sender, EventArgs e) { }

}

