internal sealed class DeflateManager // TypeDefIndex: 6942
{	// Fields
	private static readonly int MEM_LEVEL_MAX; // 0x0
	private static readonly int MEM_LEVEL_DEFAULT; // 0x4
	private DeflateManager.CompressFunc DeflateFunction; // 0x10
	private static readonly string[] _ErrorMessage; // 0x8
	private static readonly int PRESET_DICT; // 0x10
	private static readonly int INIT_STATE; // 0x14
	private static readonly int BUSY_STATE; // 0x18
	private static readonly int FINISH_STATE; // 0x1C
	private static readonly int Z_DEFLATED; // 0x20
	private static readonly int STORED_BLOCK; // 0x24
	private static readonly int STATIC_TREES; // 0x28
	private static readonly int DYN_TREES; // 0x2C
	private static readonly int Z_BINARY; // 0x30
	private static readonly int Z_ASCII; // 0x34
	private static readonly int Z_UNKNOWN; // 0x38
	private static readonly int Buf_size; // 0x3C
	private static readonly int MIN_MATCH; // 0x40
	private static readonly int MAX_MATCH; // 0x44
	private static readonly int MIN_LOOKAHEAD; // 0x48
	private static readonly int HEAP_SIZE; // 0x4C
	private static readonly int END_BLOCK; // 0x50
	internal ZlibCodec _codec; // 0x18
	internal int status; // 0x20
	internal byte[] pending; // 0x28
	internal int nextPending; // 0x30
	internal int pendingCount; // 0x34
	internal sbyte data_type; // 0x38
	internal int last_flush; // 0x3C
	internal int w_size; // 0x40
	internal int w_bits; // 0x44
	internal int w_mask; // 0x48
	internal byte[] window; // 0x50
	internal int window_size; // 0x58
	internal short[] prev; // 0x60
	internal short[] head; // 0x68
	internal int ins_h; // 0x70
	internal int hash_size; // 0x74
	internal int hash_bits; // 0x78
	internal int hash_mask; // 0x7C
	internal int hash_shift; // 0x80
	internal int block_start; // 0x84
	private DeflateManager.Config config; // 0x88
	internal int match_length; // 0x90
	internal int prev_match; // 0x94
	internal int match_available; // 0x98
	internal int strstart; // 0x9C
	internal int match_start; // 0xA0
	internal int lookahead; // 0xA4
	internal int prev_length; // 0xA8
	internal CompressionLevel compressionLevel; // 0xAC
	internal CompressionStrategy compressionStrategy; // 0xB0
	internal short[] dyn_ltree; // 0xB8
	internal short[] dyn_dtree; // 0xC0
	internal short[] bl_tree; // 0xC8
	internal Tree treeLiterals; // 0xD0
	internal Tree treeDistances; // 0xD8
	internal Tree treeBitLengths; // 0xE0
	internal short[] bl_count; // 0xE8
	internal int[] heap; // 0xF0
	internal int heap_len; // 0xF8
	internal int heap_max; // 0xFC
	internal sbyte[] depth; // 0x100
	internal int _lengthOffset; // 0x108
	internal int lit_bufsize; // 0x10C
	internal int last_lit; // 0x110
	internal int _distanceOffset; // 0x114
	internal int opt_len; // 0x118
	internal int static_len; // 0x11C
	internal int matches; // 0x120
	internal int last_eob_len; // 0x124
	internal short bi_buf; // 0x128
	internal int bi_valid; // 0x12C
	private bool Rfc1950BytesEmitted; // 0x130
	private bool _WantRfc1950HeaderBytes; // 0x131

	// Properties
	internal bool WantRfc1950HeaderBytes { get; set; }

	// Methods

	// RVA: 0x21CAE20 Offset: 0x21C9420 VA: 0x1821CAE20
	internal void .ctor() { }

	// RVA: 0x21CA3C0 Offset: 0x21C89C0 VA: 0x1821CA3C0
	private void _InitializeLazyMatch() { }

	// RVA: 0x21CA5D0 Offset: 0x21C8BD0 VA: 0x1821CA5D0
	private void _InitializeTreeData() { }

	// RVA: 0x21CA1A0 Offset: 0x21C87A0 VA: 0x1821CA1A0
	internal void _InitializeBlocks() { }

	// RVA: 0x21CCCC0 Offset: 0x21CB2C0 VA: 0x1821CCCC0
	internal void pqdownheap(short[] tree, int k) { }

	// RVA: 0x21CA740 Offset: 0x21C8D40 VA: 0x1821CA740
	internal static bool _IsSmaller(short[] tree, int n, int m, sbyte[] depth) { }

	// RVA: 0x21CCF60 Offset: 0x21CB560 VA: 0x1821CCF60
	internal void scan_tree(short[] tree, int max_code) { }

	// RVA: 0x21CC2C0 Offset: 0x21CA8C0 VA: 0x1821CC2C0
	internal int build_bl_tree() { }

	// RVA: 0x21CD2A0 Offset: 0x21CB8A0 VA: 0x1821CD2A0
	internal void send_all_trees(int lcodes, int dcodes, int blcodes) { }

	// RVA: 0x21CDB50 Offset: 0x21CC150 VA: 0x1821CDB50
	internal void send_tree(short[] tree, int max_code) { }

	// RVA: 0x21CCF10 Offset: 0x21CB510 VA: 0x1821CCF10
	private void put_bytes(byte[] p, int start, int len) { }

	// RVA: 0x21CD5C0 Offset: 0x21CBBC0 VA: 0x1821CD5C0
	internal void send_code(int c, short[] tree) { }

	// RVA: 0x21CD420 Offset: 0x21CBA20 VA: 0x1821CD420
	internal void send_bits(int value, int length) { }

	// RVA: 0x21CB420 Offset: 0x21C9A20 VA: 0x1821CB420
	internal void _tr_align() { }

	// RVA: 0x21CBD10 Offset: 0x21CA310 VA: 0x1821CBD10
	internal bool _tr_tally(int dist, int lc) { }

	// RVA: 0x21CD630 Offset: 0x21CBC30 VA: 0x1821CD630
	internal void send_compressed_block(short[] ltree, short[] dtree) { }

	// RVA: 0x21CDFD0 Offset: 0x21CC5D0 VA: 0x1821CDFD0
	internal void set_data_type() { }

	// RVA: 0x21CC0C0 Offset: 0x21CA6C0 VA: 0x1821CC0C0
	internal void bi_flush() { }

	// RVA: 0x21CC1C0 Offset: 0x21CA7C0 VA: 0x1821CC1C0
	internal void bi_windup() { }

	// RVA: 0x21CC450 Offset: 0x21CAA50 VA: 0x1821CC450
	internal void copy_block(int buf, int len, bool header) { }

	// RVA: 0x21CC5B0 Offset: 0x21CABB0 VA: 0x1821CC5B0
	internal void flush_block_only(bool eof) { }

	// RVA: 0x21C8720 Offset: 0x21C6D20 VA: 0x1821C8720
	internal BlockState DeflateNone(FlushType flush) { }

	// RVA: 0x21CBB50 Offset: 0x21CA150 VA: 0x1821CBB50
	internal void _tr_stored_block(int buf, int stored_len, bool eof) { }

	// RVA: 0x21CB650 Offset: 0x21C9C50 VA: 0x1821CB650
	internal void _tr_flush_block(int buf, int stored_len, bool eof) { }

	// RVA: 0x21CB060 Offset: 0x21C9660 VA: 0x1821CB060
	private void _fillWindow() { }

	// RVA: 0x21C8070 Offset: 0x21C6670 VA: 0x1821C8070
	internal BlockState DeflateFast(FlushType flush) { }

	// RVA: 0x21C8950 Offset: 0x21C6F50 VA: 0x1821C8950
	internal BlockState DeflateSlow(FlushType flush) { }

	// RVA: 0x21CC620 Offset: 0x21CAC20 VA: 0x1821CC620
	internal int longest_match(int cur_match) { }

	// RVA: 0x21CC610 Offset: 0x21CAC10 VA: 0x1821CC610
	internal bool get_WantRfc1950HeaderBytes() { }

	// RVA: 0x21CDFC0 Offset: 0x21CC5C0 VA: 0x1821CDFC0
	internal void set_WantRfc1950HeaderBytes(bool value) { }

	// RVA: 0x21C9D90 Offset: 0x21C8390 VA: 0x1821C9D90
	internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits, CompressionStrategy compressionStrategy) { }

	// RVA: 0x21C9AB0 Offset: 0x21C80B0 VA: 0x1821C9AB0
	internal int Initialize(ZlibCodec codec, CompressionLevel level, int windowBits, int memLevel, CompressionStrategy strategy) { }

	// RVA: 0x21C9E40 Offset: 0x21C8440 VA: 0x1821C9E40
	internal void Reset() { }

	// RVA: 0x21CA0D0 Offset: 0x21C86D0 VA: 0x1821CA0D0
	private void SetDeflater() { }

	// RVA: 0x21C9150 Offset: 0x21C7750 VA: 0x1821C9150
	internal int Deflate(FlushType flush) { }

	// RVA: 0x21CA800 Offset: 0x21C8E00 VA: 0x1821CA800
	private static void .cctor() { }

}

internal sealed class DeflateManager.CompressFunc : MulticastDelegate // TypeDefIndex: 6943
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19FAA40 Offset: 0x19F9040 VA: 0x1819FAA40 Slot: 12
	public virtual BlockState Invoke(FlushType flush) { }

	// RVA: 0x21C7920 Offset: 0x21C5F20 VA: 0x1821C7920 Slot: 13
	public virtual IAsyncResult BeginInvoke(FlushType flush, AsyncCallback callback, object object) { }

	// RVA: 0xB9A9D0 Offset: 0xB98FD0 VA: 0x180B9A9D0 Slot: 14
	public virtual BlockState EndInvoke(IAsyncResult result) { }

}

internal class DeflateManager.Config // TypeDefIndex: 6944
{	// Fields
	internal int GoodLength; // 0x10
	internal int MaxLazy; // 0x14
	internal int NiceLength; // 0x18
	internal int MaxChainLength; // 0x1C
	internal DeflateFlavor Flavor; // 0x20
	private static readonly DeflateManager.Config[] Table; // 0x0

	// Methods

	// RVA: 0x21C8010 Offset: 0x21C6610 VA: 0x1821C8010
	private void .ctor(int goodLength, int maxLazy, int niceLength, int maxChainLength, DeflateFlavor flavor) { }

	// RVA: 0x21C79A0 Offset: 0x21C5FA0 VA: 0x1821C79A0
	public static DeflateManager.Config Lookup(CompressionLevel level) { }

	// RVA: 0x21C7A30 Offset: 0x21C6030 VA: 0x1821C7A30
	private static void .cctor() { }

}

