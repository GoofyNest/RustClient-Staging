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

	// RVA: 0x1754530 Offset: 0x1752B30 VA: 0x181754530
	public void .ctor(int keySize) { }

	// RVA: 0x9E4D00 Offset: 0x9E3300 VA: 0x1809E4D00 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1753270 Offset: 0x1751870 VA: 0x181753270
	private void GenerateKeyPair() { }

	// RVA: 0x17546F0 Offset: 0x1752CF0 VA: 0x1817546F0 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x17547A0 Offset: 0x1752DA0 VA: 0x1817547A0
	public bool get_PublicOnly() { }

	// RVA: 0x1752CE0 Offset: 0x17512E0 VA: 0x181752CE0 Slot: 10
	public override byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x1752E00 Offset: 0x1751400 VA: 0x181752E00 Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x17536A0 Offset: 0x1751CA0 VA: 0x1817536A0 Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x17529C0 Offset: 0x1750FC0 VA: 0x1817529C0 Slot: 5
	protected override void Dispose(bool disposing) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1754650 Offset: 0x1752C50 VA: 0x181754650
	public void add_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1754850 Offset: 0x1752E50 VA: 0x181754850
	public void remove_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value) { }

	// RVA: 0x1753D70 Offset: 0x1752370 VA: 0x181753D70 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: 0x17535F0 Offset: 0x1751BF0 VA: 0x1817535F0
	private byte[] GetPaddedValue(BigInteger value, int length) { }

}

public sealed class RSAManaged.KeyGeneratedEventHandler : MulticastDelegate // TypeDefIndex: 76
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

	// RVA: 0x1AC3EE0 Offset: 0x1AC24E0 VA: 0x181AC3EE0
	private void GenerateKeyPair() { }

	// RVA: 0x1AC4C80 Offset: 0x1AC3280 VA: 0x181AC4C80
	public bool get_PublicOnly() { }

	// RVA: 0x1AC3A70 Offset: 0x1AC2070 VA: 0x181AC3A70 Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x1AC4550 Offset: 0x1AC2B50 VA: 0x181AC4550 Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x1AC44A0 Offset: 0x1AC2AA0 VA: 0x181AC44A0
	private byte[] GetPaddedValue(BigInteger value, int length) { }

}

public sealed class RSAManaged.KeyGeneratedEventHandler : MulticastDelegate // TypeDefIndex: 1762
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4D50 Offset: 0xAE3350 VA: 0x180AE4D50 Slot: 12
	public virtual void Invoke(object sender, EventArgs e) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, EventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

