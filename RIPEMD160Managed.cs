public class RIPEMD160Managed : RIPEMD160 // TypeDefIndex: 980
{	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateMD160; // 0x38
	private uint[] _blockDWords; // 0x40

	// Methods

	// RVA: 0x1706FB0 Offset: 0x17055B0 VA: 0x181706FB0
	public void .ctor() { }

	// RVA: 0x1704A90 Offset: 0x1703090 VA: 0x181704A90 Slot: 16
	public override void Initialize() { }

	// RVA: 0x1704980 Offset: 0x1702F80 VA: 0x181704980 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x1704990 Offset: 0x1702F90 VA: 0x181704990 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x17049B0 Offset: 0x1702FB0 VA: 0x1817049B0
	private void InitializeState() { }

	// RVA: 0x1706E40 Offset: 0x1705440 VA: 0x181706E40
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x1706C00 Offset: 0x1705200 VA: 0x181706C00
	private byte[] _EndHash() { }

	// RVA: 0x1704AF0 Offset: 0x17030F0 VA: 0x181704AF0
	private static void MDTransform(uint* blockDWords, uint* state, byte* block) { }

	// RVA: 0x1704950 Offset: 0x1702F50 VA: 0x181704950
	private static uint F(uint x, uint y, uint z) { }

	// RVA: 0x1704960 Offset: 0x1702F60 VA: 0x181704960
	private static uint G(uint x, uint y, uint z) { }

	// RVA: 0x1704970 Offset: 0x1702F70 VA: 0x181704970
	private static uint H(uint x, uint y, uint z) { }

	// RVA: 0x17049A0 Offset: 0x1702FA0 VA: 0x1817049A0
	private static uint I(uint x, uint y, uint z) { }

	// RVA: 0x1704AE0 Offset: 0x17030E0 VA: 0x181704AE0
	private static uint J(uint x, uint y, uint z) { }

}

