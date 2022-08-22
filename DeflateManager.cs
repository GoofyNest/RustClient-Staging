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

	// RVA: 0x21CB640 Offset: 0x21C9C40 VA: 0x1821CB640
	internal void .ctor() { }

	// RVA: 0x21CABE0 Offset: 0x21C91E0 VA: 0x1821CABE0
	private void _InitializeLazyMatch() { }

	// RVA: 0x21CADF0 Offset: 0x21C93F0 VA: 0x1821CADF0
	private void _InitializeTreeData() { }

	// RVA: 0x21CA9C0 Offset: 0x21C8FC0 VA: 0x1821CA9C0
	internal void _InitializeBlocks() { }

	// RVA: 0x21CD4E0 Offset: 0x21CBAE0 VA: 0x1821CD4E0
	internal void pqdownheap(short[] tree, int k) { }

	// RVA: 0x21CAF60 Offset: 0x21C9560 VA: 0x1821CAF60
	internal static bool _IsSmaller(short[] tree, int n, int m, sbyte[] depth) { }

	// RVA: 0x21CD780 Offset: 0x21CBD80 VA: 0x1821CD780
	internal void scan_tree(short[] tree, int max_code) { }

	// RVA: 0x21CCAE0 Offset: 0x21CB0E0 VA: 0x1821CCAE0
	internal int build_bl_tree() { }

	// RVA: 0x21CDAC0 Offset: 0x21CC0C0 VA: 0x1821CDAC0
	internal void send_all_trees(int lcodes, int dcodes, int blcodes) { }

	// RVA: 0x21CE370 Offset: 0x21CC970 VA: 0x1821CE370
	internal void send_tree(short[] tree, int max_code) { }

	// RVA: 0x21CD730 Offset: 0x21CBD30 VA: 0x1821CD730
	private void put_bytes(byte[] p, int start, int len) { }

	// RVA: 0x21CDDE0 Offset: 0x21CC3E0 VA: 0x1821CDDE0
	internal void send_code(int c, short[] tree) { }

	// RVA: 0x21CDC40 Offset: 0x21CC240 VA: 0x1821CDC40
	internal void send_bits(int value, int length) { }

	// RVA: 0x21CBC40 Offset: 0x21CA240 VA: 0x1821CBC40
	internal void _tr_align() { }

	// RVA: 0x21CC530 Offset: 0x21CAB30 VA: 0x1821CC530
	internal bool _tr_tally(int dist, int lc) { }

	// RVA: 0x21CDE50 Offset: 0x21CC450 VA: 0x1821CDE50
	internal void send_compressed_block(short[] ltree, short[] dtree) { }

	// RVA: 0x21CE7F0 Offset: 0x21CCDF0 VA: 0x1821CE7F0
	internal void set_data_type() { }

	// RVA: 0x21CC8E0 Offset: 0x21CAEE0 VA: 0x1821CC8E0
	internal void bi_flush() { }

	// RVA: 0x21CC9E0 Offset: 0x21CAFE0 VA: 0x1821CC9E0
	internal void bi_windup() { }

	// RVA: 0x21CCC70 Offset: 0x21CB270 VA: 0x1821CCC70
	internal void copy_block(int buf, int len, bool header) { }

	// RVA: 0x21CCDD0 Offset: 0x21CB3D0 VA: 0x1821CCDD0
	internal void flush_block_only(bool eof) { }

	// RVA: 0x21C8F40 Offset: 0x21C7540 VA: 0x1821C8F40
	internal BlockState DeflateNone(FlushType flush) { }

	// RVA: 0x21CC370 Offset: 0x21CA970 VA: 0x1821CC370
	internal void _tr_stored_block(int buf, int stored_len, bool eof) { }

	// RVA: 0x21CBE70 Offset: 0x21CA470 VA: 0x1821CBE70
	internal void _tr_flush_block(int buf, int stored_len, bool eof) { }

	// RVA: 0x21CB880 Offset: 0x21C9E80 VA: 0x1821CB880
	private void _fillWindow() { }

	// RVA: 0x21C8890 Offset: 0x21C6E90 VA: 0x1821C8890
	internal BlockState DeflateFast(FlushType flush) { }

	// RVA: 0x21C9170 Offset: 0x21C7770 VA: 0x1821C9170
	internal BlockState DeflateSlow(FlushType flush) { }

	// RVA: 0x21CCE40 Offset: 0x21CB440 VA: 0x1821CCE40
	internal int longest_match(int cur_match) { }

	// RVA: 0x21CCE30 Offset: 0x21CB430 VA: 0x1821CCE30
	internal bool get_WantRfc1950HeaderBytes() { }

	// RVA: 0x21CE7E0 Offset: 0x21CCDE0 VA: 0x1821CE7E0
	internal void set_WantRfc1950HeaderBytes(bool value) { }

	// RVA: 0x21CA5B0 Offset: 0x21C8BB0 VA: 0x1821CA5B0
	internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits, CompressionStrategy compressionStrategy) { }

	// RVA: 0x21CA2D0 Offset: 0x21C88D0 VA: 0x1821CA2D0
	internal int Initialize(ZlibCodec codec, CompressionLevel level, int windowBits, int memLevel, CompressionStrategy strategy) { }

	// RVA: 0x21CA660 Offset: 0x21C8C60 VA: 0x1821CA660
	internal void Reset() { }

	// RVA: 0x21CA8F0 Offset: 0x21C8EF0 VA: 0x1821CA8F0
	private void SetDeflater() { }

	// RVA: 0x21C9970 Offset: 0x21C7F70 VA: 0x1821C9970
	internal int Deflate(FlushType flush) { }

	// RVA: 0x21CB020 Offset: 0x21C9620 VA: 0x1821CB020
	private static void .cctor() { }

}

internal sealed class DeflateManager.CompressFunc : MulticastDelegate // TypeDefIndex: 6943
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19E7E40 Offset: 0x19E6440 VA: 0x1819E7E40 Slot: 12
	public virtual BlockState Invoke(FlushType flush) { }

	// RVA: 0x21C8140 Offset: 0x21C6740 VA: 0x1821C8140 Slot: 13
	public virtual IAsyncResult BeginInvoke(FlushType flush, AsyncCallback callback, object object) { }

	// RVA: 0xB9AEA0 Offset: 0xB994A0 VA: 0x180B9AEA0 Slot: 14
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

	// RVA: 0x21C8830 Offset: 0x21C6E30 VA: 0x1821C8830
	private void .ctor(int goodLength, int maxLazy, int niceLength, int maxChainLength, DeflateFlavor flavor) { }

	// RVA: 0x21C81C0 Offset: 0x21C67C0 VA: 0x1821C81C0
	public static DeflateManager.Config Lookup(CompressionLevel level) { }

	// RVA: 0x21C8250 Offset: 0x21C6850 VA: 0x1821C8250
	private static void .cctor() { }

}

