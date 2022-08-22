internal class AesTransform : SymmetricTransform // TypeDefIndex: 3196
{	// Fields
	private uint[] expandedKey; // 0x58
	private int Nk; // 0x60
	private int Nr; // 0x64
	private static readonly uint[] Rcon; // 0x0
	private static readonly byte[] SBox; // 0x8
	private static readonly byte[] iSBox; // 0x10
	private static readonly uint[] T0; // 0x18
	private static readonly uint[] T1; // 0x20
	private static readonly uint[] T2; // 0x28
	private static readonly uint[] T3; // 0x30
	private static readonly uint[] iT0; // 0x38
	private static readonly uint[] iT1; // 0x40
	private static readonly uint[] iT2; // 0x48
	private static readonly uint[] iT3; // 0x50

	// Methods

	// RVA: 0x22288E0 Offset: 0x2226EE0 VA: 0x1822288E0
	public void .ctor(Aes algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x2224D80 Offset: 0x2223380 VA: 0x182224D80 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x22284C0 Offset: 0x2226AC0 VA: 0x1822284C0
	private uint SubByte(uint a) { }

	// RVA: 0x2224DB0 Offset: 0x22233B0 VA: 0x182224DB0
	private void Encrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	// RVA: 0x22216B0 Offset: 0x221FCB0 VA: 0x1822216B0
	private void Decrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	// RVA: 0x22285D0 Offset: 0x2226BD0 VA: 0x1822285D0
	private static void .cctor() { }

}

