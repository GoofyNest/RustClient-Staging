public sealed class DSACryptoServiceProvider : DSA // TypeDefIndex: 1005
{	// Fields
	private KeyPairPersistence store; // 0x20
	private bool persistKey; // 0x28
	private bool persisted; // 0x29
	private bool privateKeyExportable; // 0x2A
	private bool m_disposed; // 0x2B
	private DSAManaged dsa; // 0x30
	private static bool useMachineKeyStore; // 0x0

	// Properties
	public override int KeySize { get; }
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x16FFD20 Offset: 0x16FE320 VA: 0x1816FFD20
	public void .ctor() { }

	// RVA: 0x16FFCE0 Offset: 0x16FE2E0 VA: 0x1816FFCE0
	public void .ctor(int dwKeySize) { }

	// RVA: 0x16FF870 Offset: 0x16FDE70 VA: 0x1816FF870
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0x9E4810 Offset: 0x9E2E10 VA: 0x1809E4810 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x16FFD50 Offset: 0x16FE350 VA: 0x1816FFD50 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x16FFD80 Offset: 0x16FE380 VA: 0x1816FFD80
	public bool get_PublicOnly() { }

	// RVA: 0x16FFB00 Offset: 0x16FE100 VA: 0x1816FFB00 Slot: 11
	public override DSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x16FFBE0 Offset: 0x16FE1E0 VA: 0x1816FFBE0 Slot: 12
	public override void ImportParameters(DSAParameters parameters) { }

	// RVA: 0x16FFCB0 Offset: 0x16FE2B0 VA: 0x1816FFCB0 Slot: 10
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

	// RVA: 0x16FFAB0 Offset: 0x16FE0B0 VA: 0x1816FFAB0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16FFC30 Offset: 0x16FE230 VA: 0x1816FFC30
	private void OnKeyGenerated(object sender, EventArgs e) { }

}

