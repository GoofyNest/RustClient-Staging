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

	// RVA: 0x1747510 Offset: 0x1745B10 VA: 0x181747510
	public void .ctor(int dwKeySize) { }

	// RVA: 0x9E4550 Offset: 0x9E2B50 VA: 0x1809E4550 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1746A90 Offset: 0x1745090 VA: 0x181746A90
	private void Generate() { }

	// RVA: 0x17460C0 Offset: 0x17446C0 VA: 0x1817460C0
	private void GenerateKeyPair() { }

	// RVA: 0x17476A0 Offset: 0x1745CA0 VA: 0x1817476A0
	private void add(byte[] a, byte[] b, int value) { }

	// RVA: 0x17461F0 Offset: 0x17447F0 VA: 0x1817461F0
	private void GenerateParams(int keyLength) { }

	// RVA: 0x17477F0 Offset: 0x1745DF0 VA: 0x1817477F0
	private RandomNumberGenerator get_Random() { }

	// RVA: 0x1747750 Offset: 0x1745D50 VA: 0x181747750 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x1747780 Offset: 0x1745D80 VA: 0x181747780
	public bool get_PublicOnly() { }

	// RVA: 0x1746FE0 Offset: 0x17455E0 VA: 0x181746FE0
	private byte[] NormalizeArray(byte[] array) { }

	// RVA: 0x1745C90 Offset: 0x1744290 VA: 0x181745C90 Slot: 11
	public override DSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x1746BF0 Offset: 0x17451F0 VA: 0x181746BF0 Slot: 12
	public override void ImportParameters(DSAParameters parameters) { }

	// RVA: 0x1747090 Offset: 0x1745690 VA: 0x181747090 Slot: 10
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

	// RVA: 0x17459D0 Offset: 0x1743FD0 VA: 0x1817459D0 Slot: 5
	protected override void Dispose(bool disposing) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1747600 Offset: 0x1745C00 VA: 0x181747600
	public void add_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1747830 Offset: 0x1745E30 VA: 0x181747830
	public void remove_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }

}

public sealed class DSAManaged.KeyGeneratedEventHandler : MulticastDelegate // TypeDefIndex: 79
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1111140 Offset: 0x110F740 VA: 0x181111140 Slot: 12
	public virtual void Invoke(object sender, EventArgs e) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, EventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

