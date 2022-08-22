internal sealed class InflateBlocks // TypeDefIndex: 6946
{	// Fields
	internal static readonly int[] border; // 0x0
	private InflateBlocks.InflateBlockMode mode; // 0x10
	internal int left; // 0x14
	internal int table; // 0x18
	internal int index; // 0x1C
	internal int[] blens; // 0x20
	internal int[] bb; // 0x28
	internal int[] tb; // 0x30
	internal InflateCodes codes; // 0x38
	internal int last; // 0x40
	internal ZlibCodec _codec; // 0x48
	internal int bitk; // 0x50
	internal int bitb; // 0x54
	internal int[] hufts; // 0x58
	internal byte[] window; // 0x60
	internal int end; // 0x68
	internal int readAt; // 0x6C
	internal int writeAt; // 0x70
	internal object checkfn; // 0x78
	internal uint check; // 0x80
	internal InfTree inftree; // 0x88

	// Methods

	// RVA: 0x21D22B0 Offset: 0x21D08B0 VA: 0x1821D22B0
	internal void .ctor(ZlibCodec codec, object checkfn, int w) { }

	// RVA: 0x21D2180 Offset: 0x21D0780 VA: 0x1821D2180
	internal uint Reset() { }

	// RVA: 0x21D09E0 Offset: 0x21CEFE0 VA: 0x1821D09E0
	internal int Process(int r) { }

	// RVA: 0x21D09A0 Offset: 0x21CEFA0 VA: 0x1821D09A0
	internal void Free() { }

	// RVA: 0x21D0810 Offset: 0x21CEE10 VA: 0x1821D0810
	internal int Flush(int r) { }

	// RVA: 0x21D2240 Offset: 0x21D0840 VA: 0x1821D2240
	private static void .cctor() { }

}

private enum InflateBlocks.InflateBlockMode // TypeDefIndex: 6947
{	// Fields
	public int value__; // 0x0
	public const InflateBlocks.InflateBlockMode TYPE = 0;
	public const InflateBlocks.InflateBlockMode LENS = 1;
	public const InflateBlocks.InflateBlockMode STORED = 2;
	public const InflateBlocks.InflateBlockMode TABLE = 3;
	public const InflateBlocks.InflateBlockMode BTREE = 4;
	public const InflateBlocks.InflateBlockMode DTREE = 5;
	public const InflateBlocks.InflateBlockMode CODES = 6;
	public const InflateBlocks.InflateBlockMode DRY = 7;
	public const InflateBlocks.InflateBlockMode DONE = 8;
	public const InflateBlocks.InflateBlockMode BAD = 9;

}

