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

	// RVA: 0x2228AA0 Offset: 0x22270A0 VA: 0x182228AA0
	public void .ctor(Aes algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x2224F40 Offset: 0x2223540 VA: 0x182224F40 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x2228680 Offset: 0x2226C80 VA: 0x182228680
	private uint SubByte(uint a) { }

	// RVA: 0x2224F70 Offset: 0x2223570 VA: 0x182224F70
	private void Encrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	// RVA: 0x2221870 Offset: 0x221FE70 VA: 0x182221870
	private void Decrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	// RVA: 0x2228790 Offset: 0x2226D90 VA: 0x182228790
	private static void .cctor() { }

}

