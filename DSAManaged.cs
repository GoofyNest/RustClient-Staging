internal class DSAManaged : DSA // TypeDefIndex: 78
{	// Fields
	private bool keypairGenerated; // 0x20
	private bool m_disposed; // 0x21
	private BigInteger p; // 0x28
	private BigInteger q; // 0x30
	private BigInteger g; // 0x38
	private BigInteger x; // 0x40
	private BigInteger y; // 0x48
	private BigInteger j; // 0x50
	private BigInteger seed; // 0x58
	private int counter; // 0x60
	private bool j_missing; // 0x64
	private RandomNumberGenerator rng; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private DSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x70

	// Properties
	private RandomNumberGenerator Random { get; }
	public override int KeySize { get; }
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x1745390 Offset: 0x1743990 VA: 0x181745390
	public void .ctor(int dwKeySize) { }

	// RVA: 0x9E4D00 Offset: 0x9E3300 VA: 0x1809E4D00 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1744910 Offset: 0x1742F10 VA: 0x181744910
	private void Generate() { }

	// RVA: 0x1743F40 Offset: 0x1742540 VA: 0x181743F40
	private void GenerateKeyPair() { }

	// RVA: 0x1745520 Offset: 0x1743B20 VA: 0x181745520
	private void add(byte[] a, byte[] b, int value) { }

	// RVA: 0x1744070 Offset: 0x1742670 VA: 0x181744070
	private void GenerateParams(int keyLength) { }

	// RVA: 0x1745670 Offset: 0x1743C70 VA: 0x181745670
	private RandomNumberGenerator get_Random() { }

	// RVA: 0x17455D0 Offset: 0x1743BD0 VA: 0x1817455D0 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x1745600 Offset: 0x1743C00 VA: 0x181745600
	public bool get_PublicOnly() { }

	// RVA: 0x1744E60 Offset: 0x1743460 VA: 0x181744E60
	private byte[] NormalizeArray(byte[] array) { }

	// RVA: 0x1743B10 Offset: 0x1742110 VA: 0x181743B10 Slot: 11
	public override DSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x1744A70 Offset: 0x1743070 VA: 0x181744A70 Slot: 12
	public override void ImportParameters(DSAParameters parameters) { }

	// RVA: 0x1744F10 Offset: 0x1743510 VA: 0x181744F10 Slot: 10
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

	// RVA: 0x1743850 Offset: 0x1741E50 VA: 0x181743850 Slot: 5
	protected override void Dispose(bool disposing) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1745480 Offset: 0x1743A80 VA: 0x181745480
	public void add_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x17456B0 Offset: 0x1743CB0 VA: 0x1817456B0
	public void remove_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }

}

public sealed class DSAManaged.KeyGeneratedEventHandler : MulticastDelegate // TypeDefIndex: 79
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1111E70 Offset: 0x1110470 VA: 0x181111E70 Slot: 12
	public virtual void Invoke(object sender, EventArgs e) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, EventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

