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

	// RVA: 0x16FD910 Offset: 0x16FBF10 VA: 0x1816FD910
	public void .ctor() { }

	// RVA: 0x16FD8D0 Offset: 0x16FBED0 VA: 0x1816FD8D0
	public void .ctor(int dwKeySize) { }

	// RVA: 0x16FD460 Offset: 0x16FBA60 VA: 0x1816FD460
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0x9E4D00 Offset: 0x9E3300 VA: 0x1809E4D00 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x16FD940 Offset: 0x16FBF40 VA: 0x1816FD940 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x16FD970 Offset: 0x16FBF70 VA: 0x1816FD970
	public bool get_PublicOnly() { }

	// RVA: 0x16FD6F0 Offset: 0x16FBCF0 VA: 0x1816FD6F0 Slot: 11
	public override DSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x16FD7D0 Offset: 0x16FBDD0 VA: 0x1816FD7D0 Slot: 12
	public override void ImportParameters(DSAParameters parameters) { }

	// RVA: 0x16FD8A0 Offset: 0x16FBEA0 VA: 0x1816FD8A0 Slot: 10
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

	// RVA: 0x16FD6A0 Offset: 0x16FBCA0 VA: 0x1816FD6A0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16FD820 Offset: 0x16FBE20 VA: 0x1816FD820
	private void OnKeyGenerated(object sender, EventArgs e) { }

}

