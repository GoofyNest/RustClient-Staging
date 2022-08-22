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
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x68

	// Properties
	public override int KeySize { get; }
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x1756970 Offset: 0x1754F70 VA: 0x181756970
	public void .ctor(int keySize) { }

	// RVA: 0x9E4810 Offset: 0x9E2E10 VA: 0x1809E4810 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x17556B0 Offset: 0x1753CB0 VA: 0x1817556B0
	private void GenerateKeyPair() { }

	// RVA: 0x1756B30 Offset: 0x1755130 VA: 0x181756B30 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x1756BE0 Offset: 0x17551E0 VA: 0x181756BE0
	public bool get_PublicOnly() { }

	// RVA: 0x1755120 Offset: 0x1753720 VA: 0x181755120 Slot: 10
	public override byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x1755240 Offset: 0x1753840 VA: 0x181755240 Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x1755AE0 Offset: 0x17540E0 VA: 0x181755AE0 Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x1754E00 Offset: 0x1753400 VA: 0x181754E00 Slot: 5
	protected override void Dispose(bool disposing) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1756A90 Offset: 0x1755090 VA: 0x181756A90
	public void add_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1756C90 Offset: 0x1755290 VA: 0x181756C90
	public void remove_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value) { }

	// RVA: 0x17561B0 Offset: 0x17547B0 VA: 0x1817561B0 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: 0x1755A30 Offset: 0x1754030 VA: 0x181755A30
	private byte[] GetPaddedValue(BigInteger value, int length) { }

}

public sealed class RSAManaged.KeyGeneratedEventHandler : MulticastDelegate // TypeDefIndex: 76
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x68

	// Properties
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x1AC36F0 Offset: 0x1AC1CF0 VA: 0x181AC36F0
	private void GenerateKeyPair() { }

	// RVA: 0x1AC4490 Offset: 0x1AC2A90 VA: 0x181AC4490
	public bool get_PublicOnly() { }

	// RVA: 0x1AC3280 Offset: 0x1AC1880 VA: 0x181AC3280 Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x1AC3D60 Offset: 0x1AC2360 VA: 0x181AC3D60 Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x1AC3CB0 Offset: 0x1AC22B0 VA: 0x181AC3CB0
	private byte[] GetPaddedValue(BigInteger value, int length) { }

}

public sealed class RSAManaged.KeyGeneratedEventHandler : MulticastDelegate // TypeDefIndex: 1762
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4880 Offset: 0xAE2E80 VA: 0x180AE4880 Slot: 12
	public virtual void Invoke(object sender, EventArgs e) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, EventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

