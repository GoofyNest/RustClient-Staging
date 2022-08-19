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
	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x16FFA60 Offset: 0x16FE060 VA: 0x1816FFA60
	public void .ctor() { }

	// RVA: 0x16FFA20 Offset: 0x16FE020 VA: 0x1816FFA20
	public void .ctor(int dwKeySize) { }

	// RVA: 0x16FF5B0 Offset: 0x16FDBB0 VA: 0x1816FF5B0
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0x9E4550 Offset: 0x9E2B50 VA: 0x1809E4550 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x16FFA90 Offset: 0x16FE090 VA: 0x1816FFA90 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x16FFAC0 Offset: 0x16FE0C0 VA: 0x1816FFAC0
	public bool get_PublicOnly() { }

	// RVA: 0x16FF840 Offset: 0x16FDE40 VA: 0x1816FF840 Slot: 11
	public override DSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x16FF920 Offset: 0x16FDF20 VA: 0x1816FF920 Slot: 12
	public override void ImportParameters(DSAParameters parameters) { }

	// RVA: 0x16FF9F0 Offset: 0x16FDFF0 VA: 0x1816FF9F0 Slot: 10
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

	// RVA: 0x16FF7F0 Offset: 0x16FDDF0 VA: 0x1816FF7F0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16FF970 Offset: 0x16FDF70 VA: 0x1816FF970
	private void OnKeyGenerated(object sender, EventArgs e) { }

}

