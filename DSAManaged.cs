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

	// RVA: 0x17477D0 Offset: 0x1745DD0 VA: 0x1817477D0
	public void .ctor(int dwKeySize) { }

	// RVA: 0x9E4810 Offset: 0x9E2E10 VA: 0x1809E4810 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1746D50 Offset: 0x1745350 VA: 0x181746D50
	private void Generate() { }

	// RVA: 0x1746380 Offset: 0x1744980 VA: 0x181746380
	private void GenerateKeyPair() { }

	// RVA: 0x1747960 Offset: 0x1745F60 VA: 0x181747960
	private void add(byte[] a, byte[] b, int value) { }

	// RVA: 0x17464B0 Offset: 0x1744AB0 VA: 0x1817464B0
	private void GenerateParams(int keyLength) { }

	// RVA: 0x1747AB0 Offset: 0x17460B0 VA: 0x181747AB0
	private RandomNumberGenerator get_Random() { }

	// RVA: 0x1747A10 Offset: 0x1746010 VA: 0x181747A10 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x1747A40 Offset: 0x1746040 VA: 0x181747A40
	public bool get_PublicOnly() { }

	// RVA: 0x17472A0 Offset: 0x17458A0 VA: 0x1817472A0
	private byte[] NormalizeArray(byte[] array) { }

	// RVA: 0x1745F50 Offset: 0x1744550 VA: 0x181745F50 Slot: 11
	public override DSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x1746EB0 Offset: 0x17454B0 VA: 0x181746EB0 Slot: 12
	public override void ImportParameters(DSAParameters parameters) { }

	// RVA: 0x1747350 Offset: 0x1745950 VA: 0x181747350 Slot: 10
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

	// RVA: 0x1745C90 Offset: 0x1744290 VA: 0x181745C90 Slot: 5
	protected override void Dispose(bool disposing) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x17478C0 Offset: 0x1745EC0 VA: 0x1817478C0
	public void add_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1747AF0 Offset: 0x17460F0 VA: 0x181747AF0
	public void remove_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }

}

public sealed class DSAManaged.KeyGeneratedEventHandler : MulticastDelegate // TypeDefIndex: 79
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1111400 Offset: 0x110FA00 VA: 0x181111400 Slot: 12
	public virtual void Invoke(object sender, EventArgs e) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, EventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

