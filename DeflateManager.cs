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

	// RVA: 0x21CAB60 Offset: 0x21C9160 VA: 0x1821CAB60
	internal void .ctor() { }

	// RVA: 0x21CA100 Offset: 0x21C8700 VA: 0x1821CA100
	private void _InitializeLazyMatch() { }

	// RVA: 0x21CA310 Offset: 0x21C8910 VA: 0x1821CA310
	private void _InitializeTreeData() { }

	// RVA: 0x21C9EE0 Offset: 0x21C84E0 VA: 0x1821C9EE0
	internal void _InitializeBlocks() { }

	// RVA: 0x21CCA00 Offset: 0x21CB000 VA: 0x1821CCA00
	internal void pqdownheap(short[] tree, int k) { }

	// RVA: 0x21CA480 Offset: 0x21C8A80 VA: 0x1821CA480
	internal static bool _IsSmaller(short[] tree, int n, int m, sbyte[] depth) { }

	// RVA: 0x21CCCA0 Offset: 0x21CB2A0 VA: 0x1821CCCA0
	internal void scan_tree(short[] tree, int max_code) { }

	// RVA: 0x21CC000 Offset: 0x21CA600 VA: 0x1821CC000
	internal int build_bl_tree() { }

	// RVA: 0x21CCFE0 Offset: 0x21CB5E0 VA: 0x1821CCFE0
	internal void send_all_trees(int lcodes, int dcodes, int blcodes) { }

	// RVA: 0x21CD890 Offset: 0x21CBE90 VA: 0x1821CD890
	internal void send_tree(short[] tree, int max_code) { }

	// RVA: 0x21CCC50 Offset: 0x21CB250 VA: 0x1821CCC50
	private void put_bytes(byte[] p, int start, int len) { }

	// RVA: 0x21CD300 Offset: 0x21CB900 VA: 0x1821CD300
	internal void send_code(int c, short[] tree) { }

	// RVA: 0x21CD160 Offset: 0x21CB760 VA: 0x1821CD160
	internal void send_bits(int value, int length) { }

	// RVA: 0x21CB160 Offset: 0x21C9760 VA: 0x1821CB160
	internal void _tr_align() { }

	// RVA: 0x21CBA50 Offset: 0x21CA050 VA: 0x1821CBA50
	internal bool _tr_tally(int dist, int lc) { }

	// RVA: 0x21CD370 Offset: 0x21CB970 VA: 0x1821CD370
	internal void send_compressed_block(short[] ltree, short[] dtree) { }

	// RVA: 0x21CDD10 Offset: 0x21CC310 VA: 0x1821CDD10
	internal void set_data_type() { }

	// RVA: 0x21CBE00 Offset: 0x21CA400 VA: 0x1821CBE00
	internal void bi_flush() { }

	// RVA: 0x21CBF00 Offset: 0x21CA500 VA: 0x1821CBF00
	internal void bi_windup() { }

	// RVA: 0x21CC190 Offset: 0x21CA790 VA: 0x1821CC190
	internal void copy_block(int buf, int len, bool header) { }

	// RVA: 0x21CC2F0 Offset: 0x21CA8F0 VA: 0x1821CC2F0
	internal void flush_block_only(bool eof) { }

	// RVA: 0x21C8460 Offset: 0x21C6A60 VA: 0x1821C8460
	internal BlockState DeflateNone(FlushType flush) { }

	// RVA: 0x21CB890 Offset: 0x21C9E90 VA: 0x1821CB890
	internal void _tr_stored_block(int buf, int stored_len, bool eof) { }

	// RVA: 0x21CB390 Offset: 0x21C9990 VA: 0x1821CB390
	internal void _tr_flush_block(int buf, int stored_len, bool eof) { }

	// RVA: 0x21CADA0 Offset: 0x21C93A0 VA: 0x1821CADA0
	private void _fillWindow() { }

	// RVA: 0x21C7DB0 Offset: 0x21C63B0 VA: 0x1821C7DB0
	internal BlockState DeflateFast(FlushType flush) { }

	// RVA: 0x21C8690 Offset: 0x21C6C90 VA: 0x1821C8690
	internal BlockState DeflateSlow(FlushType flush) { }

	// RVA: 0x21CC360 Offset: 0x21CA960 VA: 0x1821CC360
	internal int longest_match(int cur_match) { }

	// RVA: 0x21CC350 Offset: 0x21CA950 VA: 0x1821CC350
	internal bool get_WantRfc1950HeaderBytes() { }

	// RVA: 0x21CDD00 Offset: 0x21CC300 VA: 0x1821CDD00
	internal void set_WantRfc1950HeaderBytes(bool value) { }

	// RVA: 0x21C9AD0 Offset: 0x21C80D0 VA: 0x1821C9AD0
	internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits, CompressionStrategy compressionStrategy) { }

	// RVA: 0x21C97F0 Offset: 0x21C7DF0 VA: 0x1821C97F0
	internal int Initialize(ZlibCodec codec, CompressionLevel level, int windowBits, int memLevel, CompressionStrategy strategy) { }

	// RVA: 0x21C9B80 Offset: 0x21C8180 VA: 0x1821C9B80
	internal void Reset() { }

	// RVA: 0x21C9E10 Offset: 0x21C8410 VA: 0x1821C9E10
	private void SetDeflater() { }

	// RVA: 0x21C8E90 Offset: 0x21C7490 VA: 0x1821C8E90
	internal int Deflate(FlushType flush) { }

	// RVA: 0x21CA540 Offset: 0x21C8B40 VA: 0x1821CA540
	private static void .cctor() { }

}

internal sealed class DeflateManager.CompressFunc : MulticastDelegate // TypeDefIndex: 6943
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19FA780 Offset: 0x19F8D80 VA: 0x1819FA780 Slot: 12
	public virtual BlockState Invoke(FlushType flush) { }

	// RVA: 0x21C7660 Offset: 0x21C5C60 VA: 0x1821C7660 Slot: 13
	public virtual IAsyncResult BeginInvoke(FlushType flush, AsyncCallback callback, object object) { }

	// RVA: 0xB9A710 Offset: 0xB98D10 VA: 0x180B9A710 Slot: 14
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

	// RVA: 0x21C7D50 Offset: 0x21C6350 VA: 0x1821C7D50
	private void .ctor(int goodLength, int maxLazy, int niceLength, int maxChainLength, DeflateFlavor flavor) { }

	// RVA: 0x21C76E0 Offset: 0x21C5CE0 VA: 0x1821C76E0
	public static DeflateManager.Config Lookup(CompressionLevel level) { }

	// RVA: 0x21C7770 Offset: 0x21C5D70 VA: 0x1821C7770
	private static void .cctor() { }

}

