internal class RSAManaged : RSA // TypeDefIndex: 75
{	// Fields
	private bool isCRTpossible; // 0x20
	private bool keyBlinding; // 0x21
	private bool keypairGenerated; // 0x22
	private bool m_disposed; // 0x23
	private BigInteger d; // 0x28
	private BigInteger p; // 0x30
	private BigInteger q; // 0x38
	private BigInteger dp; // 0x40
	private BigInteger dq; // 0x48
	private BigInteger qInv; // 0x50
	private BigInteger n; // 0x58
	private BigInteger e; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private RSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x68

	// Properties
	public override int KeySize { get; }
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x17566B0 Offset: 0x1754CB0 VA: 0x1817566B0
	public void .ctor(int keySize) { }

	// RVA: 0x9E4550 Offset: 0x9E2B50 VA: 0x1809E4550 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x17553F0 Offset: 0x17539F0 VA: 0x1817553F0
	private void GenerateKeyPair() { }

	// RVA: 0x1756870 Offset: 0x1754E70 VA: 0x181756870 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x1756920 Offset: 0x1754F20 VA: 0x181756920
	public bool get_PublicOnly() { }

	// RVA: 0x1754E60 Offset: 0x1753460 VA: 0x181754E60 Slot: 10
	public override byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x1754F80 Offset: 0x1753580 VA: 0x181754F80 Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x1755820 Offset: 0x1753E20 VA: 0x181755820 Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x1754B40 Offset: 0x1753140 VA: 0x181754B40 Slot: 5
	protected override void Dispose(bool disposing) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x17567D0 Offset: 0x1754DD0 VA: 0x1817567D0
	public void add_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x17569D0 Offset: 0x1754FD0 VA: 0x1817569D0
	public void remove_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value) { }

	// RVA: 0x1755EF0 Offset: 0x17544F0 VA: 0x181755EF0 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: 0x1755770 Offset: 0x1753D70 VA: 0x181755770
	private byte[] GetPaddedValue(BigInteger value, int length) { }

}

public sealed class RSAManaged.KeyGeneratedEventHandler : MulticastDelegate // TypeDefIndex: 76
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

public class RSAManaged : RSA // TypeDefIndex: 1761
{	// Fields
	private bool isCRTpossible; // 0x20
	private bool keypairGenerated; // 0x21
	private bool m_disposed; // 0x22
	private BigInteger d; // 0x28
	private BigInteger p; // 0x30
	private BigInteger q; // 0x38
	private BigInteger dp; // 0x40
	private BigInteger dq; // 0x48
	private BigInteger qInv; // 0x50
	private BigInteger n; // 0x58
	private BigInteger e; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private RSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x68

	// Properties
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x1AC35F0 Offset: 0x1AC1BF0 VA: 0x181AC35F0
	private void GenerateKeyPair() { }

	// RVA: 0x1AC4390 Offset: 0x1AC2990 VA: 0x181AC4390
	public bool get_PublicOnly() { }

	// RVA: 0x1AC3180 Offset: 0x1AC1780 VA: 0x181AC3180 Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x1AC3C60 Offset: 0x1AC2260 VA: 0x181AC3C60 Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x1AC3BB0 Offset: 0x1AC21B0 VA: 0x181AC3BB0
	private byte[] GetPaddedValue(BigInteger value, int length) { }

}

public sealed class RSAManaged.KeyGeneratedEventHandler : MulticastDelegate // TypeDefIndex: 1762
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE45C0 Offset: 0xAE2BC0 VA: 0x180AE45C0 Slot: 12
	public virtual void Invoke(object sender, EventArgs e) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, EventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

