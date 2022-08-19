internal sealed class InflateManager // TypeDefIndex: 6950
{	// Fields
	private InflateManager.InflateManagerMode mode; // 0x10
	internal ZlibCodec _codec; // 0x18
	internal int method; // 0x20
	internal uint computedCheck; // 0x24
	internal uint expectedCheck; // 0x28
	internal int marker; // 0x2C
	private bool _handleRfc1950HeaderBytes; // 0x30
	internal int wbits; // 0x34
	internal InflateBlocks blocks; // 0x38
	private static readonly byte[] mark; // 0x0

	// Properties
	internal bool HandleRfc1950HeaderBytes { get; }

	// Methods

	// RVA: 0x82BC90 Offset: 0x82A290 VA: 0x18082BC90
	internal bool get_HandleRfc1950HeaderBytes() { }

	// RVA: 0x21D4C30 Offset: 0x21D3230 VA: 0x1821D4C30
	public void .ctor(bool expectRfc1950HeaderBytes) { }

	// RVA: 0x21D4B30 Offset: 0x21D3130 VA: 0x1821D4B30
	internal int Reset() { }

	// RVA: 0x21D3F20 Offset: 0x21D2520 VA: 0x1821D3F20
	internal int End() { }

	// RVA: 0x21D4880 Offset: 0x21D2E80 VA: 0x1821D4880
	internal int Initialize(ZlibCodec codec, int w) { }

	// RVA: 0x21D3F90 Offset: 0x21D2590 VA: 0x1821D3F90
	internal int Inflate(FlushType flush) { }

	// RVA: 0x21D4BA0 Offset: 0x21D31A0 VA: 0x1821D4BA0
	private static void .cctor() { }

}

private enum InflateManager.InflateManagerMode // TypeDefIndex: 6951
{	// Fields
	public int value__; // 0x0
	public const InflateManager.InflateManagerMode METHOD = 0;
	public const InflateManager.InflateManagerMode FLAG = 1;
	public const InflateManager.InflateManagerMode DICT4 = 2;
	public const InflateManager.InflateManagerMode DICT3 = 3;
	public const InflateManager.InflateManagerMode DICT2 = 4;
	public const InflateManager.InflateManagerMode DICT1 = 5;
	public const InflateManager.InflateManagerMode DICT0 = 6;
	public const InflateManager.InflateManagerMode BLOCKS = 7;
	public const InflateManager.InflateManagerMode CHECK4 = 8;
	public const InflateManager.InflateManagerMode CHECK3 = 9;
	public const InflateManager.InflateManagerMode CHECK2 = 10;
	public const InflateManager.InflateManagerMode CHECK1 = 11;
	public const InflateManager.InflateManagerMode DONE = 12;
	public const InflateManager.InflateManagerMode BAD = 13;

}

