public class RIPEMD160Managed : RIPEMD160 // TypeDefIndex: 980
{	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateMD160; // 0x38
	private uint[] _blockDWords; // 0x40

	// Methods

	// RVA: 0x17093C0 Offset: 0x17079C0 VA: 0x1817093C0
	public void .ctor() { }

	// RVA: 0x1706EA0 Offset: 0x17054A0 VA: 0x181706EA0 Slot: 16
	public override void Initialize() { }

	// RVA: 0x1706D90 Offset: 0x1705390 VA: 0x181706D90 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x1706DA0 Offset: 0x17053A0 VA: 0x181706DA0 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x1706DC0 Offset: 0x17053C0 VA: 0x181706DC0
	private void InitializeState() { }

	// RVA: 0x1709250 Offset: 0x1707850 VA: 0x181709250
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x1709010 Offset: 0x1707610 VA: 0x181709010
	private byte[] _EndHash() { }

	// RVA: 0x1706F00 Offset: 0x1705500 VA: 0x181706F00
	private static void MDTransform(uint* blockDWords, uint* state, byte* block) { }

	// RVA: 0x1706D60 Offset: 0x1705360 VA: 0x181706D60
	private static uint F(uint x, uint y, uint z) { }

	// RVA: 0x1706D70 Offset: 0x1705370 VA: 0x181706D70
	private static uint G(uint x, uint y, uint z) { }

	// RVA: 0x1706D80 Offset: 0x1705380 VA: 0x181706D80
	private static uint H(uint x, uint y, uint z) { }

	// RVA: 0x1706DB0 Offset: 0x17053B0 VA: 0x181706DB0
	private static uint I(uint x, uint y, uint z) { }

	// RVA: 0x1706EF0 Offset: 0x17054F0 VA: 0x181706EF0
	private static uint J(uint x, uint y, uint z) { }

}

