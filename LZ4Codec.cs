public static class LZ4Codec // TypeDefIndex: 6711
{
// Namespace: LZ4pn
public static class LZ4Codec // TypeDefIndex: 6711
	// Fields
	private static readonly int[] DECODER_TABLE_32; // 0x0
	private static readonly int[] DECODER_TABLE_64; // 0x8
	private static readonly int[] DEBRUIJN_TABLE_32; // 0x10
	private static readonly int[] DEBRUIJN_TABLE_64; // 0x18

	// Methods

	// RVA: 0x22D1440 Offset: 0x22CFA40 VA: 0x1822D1440
	internal static void CheckArguments(byte[] input, int inputOffset, ref int inputLength, byte[] output, int outputOffset, ref int outputLength) { }

	// RVA: 0x22D1360 Offset: 0x22CF960 VA: 0x1822D1360
	private static void BlockCopy(byte* src, byte* dst, int len) { }

	// RVA: 0x22D13D0 Offset: 0x22CF9D0 VA: 0x1822D13D0
	private static void BlockFill(byte* dst, int len, byte val) { }

	// RVA: 0x22D2180 Offset: 0x22D0780 VA: 0x1822D2180
	public static int Encode32(byte* input, byte* output, int inputLength, int outputLength) { }

	// RVA: 0x22D22D0 Offset: 0x22D08D0 VA: 0x1822D22D0
	public static int Encode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22D1920 Offset: 0x22CFF20 VA: 0x1822D1920
	public static int Decode32(byte* input, int inputLength, byte* output, int outputLength, bool knownOutputLength) { }

	// RVA: 0x22D15D0 Offset: 0x22CFBD0 VA: 0x1822D15D0
	public static int Decode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength) { }

	// RVA: 0x22D2C40 Offset: 0x22D1240 VA: 0x1822D2C40
	public static int Encode64(byte* input, byte* output, int inputLength, int outputLength) { }

	// RVA: 0x22D28E0 Offset: 0x22D0EE0 VA: 0x1822D28E0
	public static int Encode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22D1DA0 Offset: 0x22D03A0 VA: 0x1822D1DA0
	public static int Decode64(byte* input, int inputLength, byte* output, int outputLength, bool knownOutputLength) { }

	// RVA: 0x22D1A50 Offset: 0x22D0050 VA: 0x1822D1A50
	public static int Decode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength) { }

	// RVA: 0x22D2FC0 Offset: 0x22D15C0 VA: 0x1822D2FC0
	private static LZ4Codec.LZ4HC_Data_Structure LZ4HC_Create(byte* src) { }

	// RVA: 0x22D6700 Offset: 0x22D4D00 VA: 0x1822D6700
	private static int LZ4_compressHC_32(byte* input, byte* output, int inputLength, int outputLength) { }

	// RVA: 0x22D1ED0 Offset: 0x22D04D0 VA: 0x1822D1ED0
	public static int Encode32HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22D67A0 Offset: 0x22D4DA0 VA: 0x1822D67A0
	private static int LZ4_compressHC_64(byte* input, byte* output, int inputLength, int outputLength) { }

	// RVA: 0x22D2630 Offset: 0x22D0C30 VA: 0x1822D2630
	public static int Encode64HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22D4C60 Offset: 0x22D3260 VA: 0x1822D4C60
	private static int LZ4_compressCtx_32(byte** hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D3F90 Offset: 0x22D2590 VA: 0x1822D3F90
	private static int LZ4_compress64kCtx_32(ushort* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D6C10 Offset: 0x22D5210 VA: 0x1822D6C10
	private static int LZ4_uncompress_32(byte* src, byte* dst, int dst_len) { }

	// RVA: 0x22D7380 Offset: 0x22D5980 VA: 0x1822D7380
	private static int LZ4_uncompress_unknownOutputSize_32(byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D3ED0 Offset: 0x22D24D0 VA: 0x1822D3ED0
	private static void LZ4HC_Insert_32(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p) { }

	// RVA: 0x22D2D90 Offset: 0x22D1390 VA: 0x1822D2D90
	private static int LZ4HC_CommonLength_32(byte* p1, byte* p2, byte* src_LASTLITERALS) { }

	// RVA: 0x22D30E0 Offset: 0x22D16E0 VA: 0x1822D30E0
	private static int LZ4HC_InsertAndFindBestMatch_32(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p, byte* src_LASTLITERALS, ref byte* matchpos) { }

	// RVA: 0x22D36E0 Offset: 0x22D1CE0 VA: 0x1822D36E0
	private static int LZ4HC_InsertAndGetWiderMatch_32(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p, byte* startLimit, byte* src_LASTLITERALS, int longest, ref byte* matchpos, ref byte* startpos) { }

	// RVA: 0x22D6840 Offset: 0x22D4E40 VA: 0x1822D6840
	private static int LZ4_encodeSequence_32(ref byte* src_p, ref byte* dst_p, ref byte* src_anchor, int matchLength, byte* xxx_ref, byte* dst_end) { }

	// RVA: 0x22D5960 Offset: 0x22D3F60 VA: 0x1822D5960
	private static int LZ4_compressHCCtx_32(LZ4Codec.LZ4HC_Data_Structure ctx, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D52C0 Offset: 0x22D38C0 VA: 0x1822D52C0
	private static int LZ4_compressCtx_64(uint* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D45E0 Offset: 0x22D2BE0 VA: 0x1822D45E0
	private static int LZ4_compress64kCtx_64(ushort* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D6F80 Offset: 0x22D5580 VA: 0x1822D6F80
	private static int LZ4_uncompress_64(byte* src, byte* dst, int dst_len) { }

	// RVA: 0x22D7750 Offset: 0x22D5D50 VA: 0x1822D7750
	private static int LZ4_uncompress_unknownOutputSize_64(byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D3ED0 Offset: 0x22D24D0 VA: 0x1822D3ED0
	private static void LZ4HC_Insert_64(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p) { }

	// RVA: 0x22D2E90 Offset: 0x22D1490 VA: 0x1822D2E90
	private static int LZ4HC_CommonLength_64(byte* p1, byte* p2, byte* src_LASTLITERALS) { }

	// RVA: 0x22D33E0 Offset: 0x22D19E0 VA: 0x1822D33E0
	private static int LZ4HC_InsertAndFindBestMatch_64(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p, byte* src_LASTLITERALS, ref byte* matchpos) { }

	// RVA: 0x22D3AC0 Offset: 0x22D20C0 VA: 0x1822D3AC0
	private static int LZ4HC_InsertAndGetWiderMatch_64(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p, byte* startLimit, byte* src_LASTLITERALS, int longest, ref byte* matchpos, ref byte* startpos) { }

	// RVA: 0x22D6A30 Offset: 0x22D5030 VA: 0x1822D6A30
	private static int LZ4_encodeSequence_64(ref byte* src_p, ref byte* dst_p, ref byte* src_anchor, int matchLength, byte* src_ref, byte* dst_end) { }

	// RVA: 0x22D6030 Offset: 0x22D4630 VA: 0x1822D6030
	private static int LZ4_compressHCCtx_64(LZ4Codec.LZ4HC_Data_Structure ctx, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D7BA0 Offset: 0x22D61A0 VA: 0x1822D7BA0
	private static void .cctor() { }

}

private class LZ4Codec.LZ4HC_Data_Structure // TypeDefIndex: 6712
{	// Fields
	public byte* src_base; // 0x10
	public byte* nextToUpdate; // 0x18
	public int[] hashTable; // 0x20
	public ushort[] chainTable; // 0x28

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public static class LZ4Codec // TypeDefIndex: 6981
{
// Namespace: 
private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=68 // TypeDefIndex: 6970

// Namespace: 
private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=6144 // TypeDefIndex: 6971

// Namespace: 
private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=384 // TypeDefIndex: 6972

// Namespace: 
private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=124 // TypeDefIndex: 6973

// Namespace: 
private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 // TypeDefIndex: 6974

// Namespace: 
private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=116 // TypeDefIndex: 6975

// Namespace: 
private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=19 // TypeDefIndex: 6976

// Namespace: 
private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=512 // TypeDefIndex: 6977

// Namespace: 
private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=256 // TypeDefIndex: 6978

// Namespace: 
private struct <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=1152 // TypeDefIndex: 6979

// Namespace: 
internal class <Module> // TypeDefIndex: 6980

// Namespace: LZ4ps
public static class LZ4Codec // TypeDefIndex: 6981
	// Fields
	private static readonly int[] DECODER_TABLE_32; // 0x0
	private static readonly int[] DECODER_TABLE_64; // 0x8
	private static readonly int[] DEBRUIJN_TABLE_32; // 0x10
	private static readonly int[] DEBRUIJN_TABLE_64; // 0x18

	// Methods

	// RVA: 0x2254380 Offset: 0x2252980 VA: 0x182254380
	internal static void CheckArguments(byte[] input, int inputOffset, ref int inputLength, byte[] output, int outputOffset, ref int outputLength) { }

	// RVA: 0x225F240 Offset: 0x225D840 VA: 0x18225F240
	internal static void Poke2(byte[] buffer, int offset, ushort value) { }

	// RVA: 0x225F1E0 Offset: 0x225D7E0 VA: 0x18225F1E0
	internal static ushort Peek2(byte[] buffer, int offset) { }

	// RVA: 0x1202A50 Offset: 0x1201050 VA: 0x181202A50
	internal static uint Peek4(byte[] buffer, int offset) { }

	// RVA: 0x22600A0 Offset: 0x225E6A0 VA: 0x1822600A0
	private static uint Xor4(byte[] buffer, int offset1, int offset2) { }

	// RVA: 0x2260230 Offset: 0x225E830 VA: 0x182260230
	private static ulong Xor8(byte[] buffer, int offset1, int offset2) { }

	// RVA: 0x2255B40 Offset: 0x2254140 VA: 0x182255B40
	private static bool Equal2(byte[] buffer, int offset1, int offset2) { }

	// RVA: 0x2255BE0 Offset: 0x22541E0 VA: 0x182255BE0
	private static bool Equal4(byte[] buffer, int offset1, int offset2) { }

	// RVA: 0x2254510 Offset: 0x2252B10 VA: 0x182254510
	private static void Copy4(byte[] buf, int src, int dst) { }

	// RVA: 0x2254650 Offset: 0x2252C50 VA: 0x182254650
	private static void Copy8(byte[] buf, int src, int dst) { }

	// RVA: 0x2253F00 Offset: 0x2252500 VA: 0x182253F00
	private static void BlockCopy(byte[] src, int src_0, byte[] dst, int dst_0, int len) { }

	// RVA: 0x225FE90 Offset: 0x225E490 VA: 0x18225FE90
	private static int WildCopy(byte[] src, int src_0, byte[] dst, int dst_0, int dst_end) { }

	// RVA: 0x225F2A0 Offset: 0x225D8A0 VA: 0x18225F2A0
	private static int SecureCopy(byte[] buffer, int src, int dst, int dst_end) { }

	// RVA: 0x22551C0 Offset: 0x22537C0 VA: 0x1822551C0
	public static int Encode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22556E0 Offset: 0x2253CE0 VA: 0x1822556E0
	public static int Encode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22548C0 Offset: 0x2252EC0 VA: 0x1822548C0
	public static int Decode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength) { }

	// RVA: 0x2254BA0 Offset: 0x22531A0 VA: 0x182254BA0
	public static int Decode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength) { }

	// RVA: 0x2256330 Offset: 0x2254930 VA: 0x182256330
	private static LZ4Codec.LZ4HC_Data_Structure LZ4HC_Create(byte[] src, int src_0, int src_len, byte[] dst, int dst_0, int dst_len) { }

	// RVA: 0x225C630 Offset: 0x225AC30 VA: 0x18225C630
	private static int LZ4_compressHC_32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x2254F50 Offset: 0x2253550 VA: 0x182254F50
	public static int Encode32HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x225C6D0 Offset: 0x225ACD0 VA: 0x18225C6D0
	private static int LZ4_compressHC_64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x2255470 Offset: 0x2253A70 VA: 0x182255470
	public static int Encode64HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x2259930 Offset: 0x2257F30 VA: 0x182259930
	private static int LZ4_compressCtx_safe32(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x2257B30 Offset: 0x2256130 VA: 0x182257B30
	private static int LZ4_compress64kCtx_safe32(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x225D2B0 Offset: 0x225B8B0 VA: 0x18225D2B0
	private static int LZ4_uncompress_safe32(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len) { }

	// RVA: 0x225E1D0 Offset: 0x225C7D0 VA: 0x18225E1D0
	private static int LZ4_uncompress_unknownOutputSize_safe32(byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x22577F0 Offset: 0x2255DF0 VA: 0x1822577F0
	private static void LZ4HC_Insert_32(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p) { }

	// RVA: 0x2255F80 Offset: 0x2254580 VA: 0x182255F80
	private static int LZ4HC_CommonLength_32(LZ4Codec.LZ4HC_Data_Structure ctx, int p1, int p2) { }

	// RVA: 0x2256480 Offset: 0x2254A80 VA: 0x182256480
	private static int LZ4HC_InsertAndFindBestMatch_32(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p, ref int src_match) { }

	// RVA: 0x2256E80 Offset: 0x2255480 VA: 0x182256E80
	private static int LZ4HC_InsertAndGetWiderMatch_32(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p, int startLimit, int longest, ref int matchpos, ref int startpos) { }

	// RVA: 0x225C770 Offset: 0x225AD70 VA: 0x18225C770
	private static int LZ4_encodeSequence_32(LZ4Codec.LZ4HC_Data_Structure ctx, ref int src_p, ref int dst_p, ref int src_anchor, int matchLength, int src_ref, int dst_end) { }

	// RVA: 0x225B880 Offset: 0x2259E80 VA: 0x18225B880
	private static int LZ4_compressHCCtx_32(LZ4Codec.LZ4HC_Data_Structure ctx) { }

	// RVA: 0x225A8B0 Offset: 0x2258EB0 VA: 0x18225A8B0
	private static int LZ4_compressCtx_safe64(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x2258A10 Offset: 0x2257010 VA: 0x182258A10
	private static int LZ4_compress64kCtx_safe64(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x225DA10 Offset: 0x225C010 VA: 0x18225DA10
	private static int LZ4_uncompress_safe64(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len) { }

	// RVA: 0x225E9A0 Offset: 0x225CFA0 VA: 0x18225E9A0
	private static int LZ4_uncompress_unknownOutputSize_safe64(byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x2257990 Offset: 0x2255F90 VA: 0x182257990
	private static void LZ4HC_Insert_64(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p) { }

	// RVA: 0x2256130 Offset: 0x2254730 VA: 0x182256130
	private static int LZ4HC_CommonLength_64(LZ4Codec.LZ4HC_Data_Structure ctx, int p1, int p2) { }

	// RVA: 0x2256980 Offset: 0x2254F80 VA: 0x182256980
	private static int LZ4HC_InsertAndFindBestMatch_64(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p, ref int matchpos) { }

	// RVA: 0x2257310 Offset: 0x2255910 VA: 0x182257310
	private static int LZ4HC_InsertAndGetWiderMatch_64(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p, int startLimit, int longest, ref int matchpos, ref int startpos) { }

	// RVA: 0x225CD10 Offset: 0x225B310 VA: 0x18225CD10
	private static int LZ4_encodeSequence_64(LZ4Codec.LZ4HC_Data_Structure ctx, ref int src_p, ref int dst_p, ref int src_anchor, int matchLength, int src_ref) { }

	// RVA: 0x225BF70 Offset: 0x225A570 VA: 0x18225BF70
	private static int LZ4_compressHCCtx_64(LZ4Codec.LZ4HC_Data_Structure ctx) { }

	// RVA: 0x2260560 Offset: 0x225EB60 VA: 0x182260560
	private static void .cctor() { }

}

private class LZ4Codec.LZ4HC_Data_Structure // TypeDefIndex: 6982
{	// Fields
	public byte[] src; // 0x10
	public int src_base; // 0x18
	public int src_end; // 0x1C
	public int src_LASTLITERALS; // 0x20
	public byte[] dst; // 0x28
	public int dst_base; // 0x30
	public int dst_len; // 0x34
	public int dst_end; // 0x38
	public int[] hashTable; // 0x40
	public ushort[] chainTable; // 0x48
	public int nextToUpdate; // 0x50

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public static class LZ4Codec // TypeDefIndex: 6989
{	// Fields
	private static readonly ILZ4Service Encoder; // 0x0
	private static readonly ILZ4Service EncoderHC; // 0x8
	private static readonly ILZ4Service Decoder; // 0x10
	private static ILZ4Service _service_MM32; // 0x18
	private static ILZ4Service _service_MM64; // 0x20
	private static ILZ4Service _service_CC32; // 0x28
	private static ILZ4Service _service_CC64; // 0x30
	private static ILZ4Service _service_N32; // 0x38
	private static ILZ4Service _service_N64; // 0x40
	private static ILZ4Service _service_S32; // 0x48
	private static ILZ4Service _service_S64; // 0x50

	// Methods

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private static bool Has2010Runtime() { }

	// RVA: 0x2255DB0 Offset: 0x22543B0 VA: 0x182255DB0
	private static void InitializeLZ4mm() { }

	// RVA: 0x2255D20 Offset: 0x2254320 VA: 0x182255D20
	private static void InitializeLZ4cc() { }

	// RVA: 0x2255E40 Offset: 0x2254440 VA: 0x182255E40
	private static void InitializeLZ4n() { }

	// RVA: 0x2255EE0 Offset: 0x22544E0 VA: 0x182255EE0
	private static void InitializeLZ4s() { }

	// RVA: 0x2260690 Offset: 0x225EC90 VA: 0x182260690
	private static void .cctor() { }

	// RVA: 0x225F500 Offset: 0x225DB00 VA: 0x18225F500
	private static void SelectCodec(out ILZ4Service encoder, out ILZ4Service decoder, out ILZ4Service encoderHC) { }

	// RVA: 0x2253AD0 Offset: 0x22520D0 VA: 0x182253AD0
	private static ILZ4Service AutoTest(ILZ4Service service) { }

	// RVA: 0x225FE30 Offset: 0x225E430 VA: 0x18225FE30
	private static void Try(Action method) { }

	// RVA: -1 Offset: -1
	private static T Try<T>(Func<T> method, T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1280 Offset: 0x5CF880 VA: 0x1805D1280
	|-LZ4Codec.Try<bool>
	|
	|-RVA: 0x5D1300 Offset: 0x5CF900 VA: 0x1805D1300
	|-LZ4Codec.Try<object>
	*/

	// RVA: -1 Offset: -1
	private static ILZ4Service TryService<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D2D0 Offset: 0x125B8D0 VA: 0x18125D2D0
	|-LZ4Codec.TryService<Safe32LZ4Service>
	|-LZ4Codec.TryService<Safe64LZ4Service>
	|-LZ4Codec.TryService<Unsafe32LZ4Service>
	|-LZ4Codec.TryService<Unsafe64LZ4Service>
	|-LZ4Codec.TryService<object>
	*/

	// RVA: 0x225F1C0 Offset: 0x225D7C0 VA: 0x18225F1C0
	public static int MaximumOutputLength(int inputLength) { }

	// RVA: 0x2255A80 Offset: 0x2254080 VA: 0x182255A80
	public static int Encode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x2255990 Offset: 0x2253F90 VA: 0x182255990
	public static int EncodeHC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x2254E80 Offset: 0x2253480 VA: 0x182254E80
	public static int Decode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength = 0, bool knownOutputLength = False) { }

}

