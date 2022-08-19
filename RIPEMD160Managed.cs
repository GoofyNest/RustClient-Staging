public class RIPEMD160Managed : RIPEMD160 // TypeDefIndex: 980
{	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateMD160; // 0x38
	private uint[] _blockDWords; // 0x40

	// Methods

	// RVA: 0x1709100 Offset: 0x1707700 VA: 0x181709100
	public void .ctor() { }

	// RVA: 0x1706BE0 Offset: 0x17051E0 VA: 0x181706BE0 Slot: 16
	public override void Initialize() { }

	// RVA: 0x1706AD0 Offset: 0x17050D0 VA: 0x181706AD0 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x1706AE0 Offset: 0x17050E0 VA: 0x181706AE0 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x1706B00 Offset: 0x1705100 VA: 0x181706B00
	private void InitializeState() { }

	// RVA: 0x1708F90 Offset: 0x1707590 VA: 0x181708F90
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x1708D50 Offset: 0x1707350 VA: 0x181708D50
	private byte[] _EndHash() { }

	// RVA: 0x1706C40 Offset: 0x1705240 VA: 0x181706C40
	private static void MDTransform(uint* blockDWords, uint* state, byte* block) { }

	// RVA: 0x1706AA0 Offset: 0x17050A0 VA: 0x181706AA0
	private static uint F(uint x, uint y, uint z) { }

	// RVA: 0x1706AB0 Offset: 0x17050B0 VA: 0x181706AB0
	private static uint G(uint x, uint y, uint z) { }

	// RVA: 0x1706AC0 Offset: 0x17050C0 VA: 0x181706AC0
	private static uint H(uint x, uint y, uint z) { }

	// RVA: 0x1706AF0 Offset: 0x17050F0 VA: 0x181706AF0
	private static uint I(uint x, uint y, uint z) { }

	// RVA: 0x1706C30 Offset: 0x1705230 VA: 0x181706C30
	private static uint J(uint x, uint y, uint z) { }

}

