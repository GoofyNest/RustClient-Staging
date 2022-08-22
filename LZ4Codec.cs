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

	// RVA: 0x22D1540 Offset: 0x22CFB40 VA: 0x1822D1540
	internal static void CheckArguments(byte[] input, int inputOffset, ref int inputLength, byte[] output, int outputOffset, ref int outputLength) { }

	// RVA: 0x22D1460 Offset: 0x22CFA60 VA: 0x1822D1460
	private static void BlockCopy(byte* src, byte* dst, int len) { }

	// RVA: 0x22D14D0 Offset: 0x22CFAD0 VA: 0x1822D14D0
	private static void BlockFill(byte* dst, int len, byte val) { }

	// RVA: 0x22D2280 Offset: 0x22D0880 VA: 0x1822D2280
	public static int Encode32(byte* input, byte* output, int inputLength, int outputLength) { }

	// RVA: 0x22D23D0 Offset: 0x22D09D0 VA: 0x1822D23D0
	public static int Encode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22D1A20 Offset: 0x22D0020 VA: 0x1822D1A20
	public static int Decode32(byte* input, int inputLength, byte* output, int outputLength, bool knownOutputLength) { }

	// RVA: 0x22D16D0 Offset: 0x22CFCD0 VA: 0x1822D16D0
	public static int Decode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength) { }

	// RVA: 0x22D2D40 Offset: 0x22D1340 VA: 0x1822D2D40
	public static int Encode64(byte* input, byte* output, int inputLength, int outputLength) { }

	// RVA: 0x22D29E0 Offset: 0x22D0FE0 VA: 0x1822D29E0
	public static int Encode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22D1EA0 Offset: 0x22D04A0 VA: 0x1822D1EA0
	public static int Decode64(byte* input, int inputLength, byte* output, int outputLength, bool knownOutputLength) { }

	// RVA: 0x22D1B50 Offset: 0x22D0150 VA: 0x1822D1B50
	public static int Decode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength) { }

	// RVA: 0x22D30C0 Offset: 0x22D16C0 VA: 0x1822D30C0
	private static LZ4Codec.LZ4HC_Data_Structure LZ4HC_Create(byte* src) { }

	// RVA: 0x22D6800 Offset: 0x22D4E00 VA: 0x1822D6800
	private static int LZ4_compressHC_32(byte* input, byte* output, int inputLength, int outputLength) { }

	// RVA: 0x22D1FD0 Offset: 0x22D05D0 VA: 0x1822D1FD0
	public static int Encode32HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22D68A0 Offset: 0x22D4EA0 VA: 0x1822D68A0
	private static int LZ4_compressHC_64(byte* input, byte* output, int inputLength, int outputLength) { }

	// RVA: 0x22D2730 Offset: 0x22D0D30 VA: 0x1822D2730
	public static int Encode64HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22D4D60 Offset: 0x22D3360 VA: 0x1822D4D60
	private static int LZ4_compressCtx_32(byte** hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D4090 Offset: 0x22D2690 VA: 0x1822D4090
	private static int LZ4_compress64kCtx_32(ushort* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D6D10 Offset: 0x22D5310 VA: 0x1822D6D10
	private static int LZ4_uncompress_32(byte* src, byte* dst, int dst_len) { }

	// RVA: 0x22D7480 Offset: 0x22D5A80 VA: 0x1822D7480
	private static int LZ4_uncompress_unknownOutputSize_32(byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D3FD0 Offset: 0x22D25D0 VA: 0x1822D3FD0
	private static void LZ4HC_Insert_32(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p) { }

	// RVA: 0x22D2E90 Offset: 0x22D1490 VA: 0x1822D2E90
	private static int LZ4HC_CommonLength_32(byte* p1, byte* p2, byte* src_LASTLITERALS) { }

	// RVA: 0x22D31E0 Offset: 0x22D17E0 VA: 0x1822D31E0
	private static int LZ4HC_InsertAndFindBestMatch_32(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p, byte* src_LASTLITERALS, ref byte* matchpos) { }

	// RVA: 0x22D37E0 Offset: 0x22D1DE0 VA: 0x1822D37E0
	private static int LZ4HC_InsertAndGetWiderMatch_32(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p, byte* startLimit, byte* src_LASTLITERALS, int longest, ref byte* matchpos, ref byte* startpos) { }

	// RVA: 0x22D6940 Offset: 0x22D4F40 VA: 0x1822D6940
	private static int LZ4_encodeSequence_32(ref byte* src_p, ref byte* dst_p, ref byte* src_anchor, int matchLength, byte* xxx_ref, byte* dst_end) { }

	// RVA: 0x22D5A60 Offset: 0x22D4060 VA: 0x1822D5A60
	private static int LZ4_compressHCCtx_32(LZ4Codec.LZ4HC_Data_Structure ctx, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D53C0 Offset: 0x22D39C0 VA: 0x1822D53C0
	private static int LZ4_compressCtx_64(uint* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D46E0 Offset: 0x22D2CE0 VA: 0x1822D46E0
	private static int LZ4_compress64kCtx_64(ushort* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D7080 Offset: 0x22D5680 VA: 0x1822D7080
	private static int LZ4_uncompress_64(byte* src, byte* dst, int dst_len) { }

	// RVA: 0x22D7850 Offset: 0x22D5E50 VA: 0x1822D7850
	private static int LZ4_uncompress_unknownOutputSize_64(byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D3FD0 Offset: 0x22D25D0 VA: 0x1822D3FD0
	private static void LZ4HC_Insert_64(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p) { }

	// RVA: 0x22D2F90 Offset: 0x22D1590 VA: 0x1822D2F90
	private static int LZ4HC_CommonLength_64(byte* p1, byte* p2, byte* src_LASTLITERALS) { }

	// RVA: 0x22D34E0 Offset: 0x22D1AE0 VA: 0x1822D34E0
	private static int LZ4HC_InsertAndFindBestMatch_64(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p, byte* src_LASTLITERALS, ref byte* matchpos) { }

	// RVA: 0x22D3BC0 Offset: 0x22D21C0 VA: 0x1822D3BC0
	private static int LZ4HC_InsertAndGetWiderMatch_64(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p, byte* startLimit, byte* src_LASTLITERALS, int longest, ref byte* matchpos, ref byte* startpos) { }

	// RVA: 0x22D6B30 Offset: 0x22D5130 VA: 0x1822D6B30
	private static int LZ4_encodeSequence_64(ref byte* src_p, ref byte* dst_p, ref byte* src_anchor, int matchLength, byte* src_ref, byte* dst_end) { }

	// RVA: 0x22D6130 Offset: 0x22D4730 VA: 0x1822D6130
	private static int LZ4_compressHCCtx_64(LZ4Codec.LZ4HC_Data_Structure ctx, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D7CA0 Offset: 0x22D62A0 VA: 0x1822D7CA0
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

	// RVA: 0x2254480 Offset: 0x2252A80 VA: 0x182254480
	internal static void CheckArguments(byte[] input, int inputOffset, ref int inputLength, byte[] output, int outputOffset, ref int outputLength) { }

	// RVA: 0x225F340 Offset: 0x225D940 VA: 0x18225F340
	internal static void Poke2(byte[] buffer, int offset, ushort value) { }

	// RVA: 0x225F2E0 Offset: 0x225D8E0 VA: 0x18225F2E0
	internal static ushort Peek2(byte[] buffer, int offset) { }

	// RVA: 0x1202D10 Offset: 0x1201310 VA: 0x181202D10
	internal static uint Peek4(byte[] buffer, int offset) { }

	// RVA: 0x22601A0 Offset: 0x225E7A0 VA: 0x1822601A0
	private static uint Xor4(byte[] buffer, int offset1, int offset2) { }

	// RVA: 0x2260330 Offset: 0x225E930 VA: 0x182260330
	private static ulong Xor8(byte[] buffer, int offset1, int offset2) { }

	// RVA: 0x2255C40 Offset: 0x2254240 VA: 0x182255C40
	private static bool Equal2(byte[] buffer, int offset1, int offset2) { }

	// RVA: 0x2255CE0 Offset: 0x22542E0 VA: 0x182255CE0
	private static bool Equal4(byte[] buffer, int offset1, int offset2) { }

	// RVA: 0x2254610 Offset: 0x2252C10 VA: 0x182254610
	private static void Copy4(byte[] buf, int src, int dst) { }

	// RVA: 0x2254750 Offset: 0x2252D50 VA: 0x182254750
	private static void Copy8(byte[] buf, int src, int dst) { }

	// RVA: 0x2254000 Offset: 0x2252600 VA: 0x182254000
	private static void BlockCopy(byte[] src, int src_0, byte[] dst, int dst_0, int len) { }

	// RVA: 0x225FF90 Offset: 0x225E590 VA: 0x18225FF90
	private static int WildCopy(byte[] src, int src_0, byte[] dst, int dst_0, int dst_end) { }

	// RVA: 0x225F3A0 Offset: 0x225D9A0 VA: 0x18225F3A0
	private static int SecureCopy(byte[] buffer, int src, int dst, int dst_end) { }

	// RVA: 0x22552C0 Offset: 0x22538C0 VA: 0x1822552C0
	public static int Encode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22557E0 Offset: 0x2253DE0 VA: 0x1822557E0
	public static int Encode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22549C0 Offset: 0x2252FC0 VA: 0x1822549C0
	public static int Decode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength) { }

	// RVA: 0x2254CA0 Offset: 0x22532A0 VA: 0x182254CA0
	public static int Decode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength) { }

	// RVA: 0x2256430 Offset: 0x2254A30 VA: 0x182256430
	private static LZ4Codec.LZ4HC_Data_Structure LZ4HC_Create(byte[] src, int src_0, int src_len, byte[] dst, int dst_0, int dst_len) { }

	// RVA: 0x225C730 Offset: 0x225AD30 VA: 0x18225C730
	private static int LZ4_compressHC_32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x2255050 Offset: 0x2253650 VA: 0x182255050
	public static int Encode32HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x225C7D0 Offset: 0x225ADD0 VA: 0x18225C7D0
	private static int LZ4_compressHC_64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x2255570 Offset: 0x2253B70 VA: 0x182255570
	public static int Encode64HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x2259A30 Offset: 0x2258030 VA: 0x182259A30
	private static int LZ4_compressCtx_safe32(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x2257C30 Offset: 0x2256230 VA: 0x182257C30
	private static int LZ4_compress64kCtx_safe32(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x225D3B0 Offset: 0x225B9B0 VA: 0x18225D3B0
	private static int LZ4_uncompress_safe32(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len) { }

	// RVA: 0x225E2D0 Offset: 0x225C8D0 VA: 0x18225E2D0
	private static int LZ4_uncompress_unknownOutputSize_safe32(byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x22578F0 Offset: 0x2255EF0 VA: 0x1822578F0
	private static void LZ4HC_Insert_32(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p) { }

	// RVA: 0x2256080 Offset: 0x2254680 VA: 0x182256080
	private static int LZ4HC_CommonLength_32(LZ4Codec.LZ4HC_Data_Structure ctx, int p1, int p2) { }

	// RVA: 0x2256580 Offset: 0x2254B80 VA: 0x182256580
	private static int LZ4HC_InsertAndFindBestMatch_32(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p, ref int src_match) { }

	// RVA: 0x2256F80 Offset: 0x2255580 VA: 0x182256F80
	private static int LZ4HC_InsertAndGetWiderMatch_32(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p, int startLimit, int longest, ref int matchpos, ref int startpos) { }

	// RVA: 0x225C870 Offset: 0x225AE70 VA: 0x18225C870
	private static int LZ4_encodeSequence_32(LZ4Codec.LZ4HC_Data_Structure ctx, ref int src_p, ref int dst_p, ref int src_anchor, int matchLength, int src_ref, int dst_end) { }

	// RVA: 0x225B980 Offset: 0x2259F80 VA: 0x18225B980
	private static int LZ4_compressHCCtx_32(LZ4Codec.LZ4HC_Data_Structure ctx) { }

	// RVA: 0x225A9B0 Offset: 0x2258FB0 VA: 0x18225A9B0
	private static int LZ4_compressCtx_safe64(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x2258B10 Offset: 0x2257110 VA: 0x182258B10
	private static int LZ4_compress64kCtx_safe64(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x225DB10 Offset: 0x225C110 VA: 0x18225DB10
	private static int LZ4_uncompress_safe64(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len) { }

	// RVA: 0x225EAA0 Offset: 0x225D0A0 VA: 0x18225EAA0
	private static int LZ4_uncompress_unknownOutputSize_safe64(byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x2257A90 Offset: 0x2256090 VA: 0x182257A90
	private static void LZ4HC_Insert_64(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p) { }

	// RVA: 0x2256230 Offset: 0x2254830 VA: 0x182256230
	private static int LZ4HC_CommonLength_64(LZ4Codec.LZ4HC_Data_Structure ctx, int p1, int p2) { }

	// RVA: 0x2256A80 Offset: 0x2255080 VA: 0x182256A80
	private static int LZ4HC_InsertAndFindBestMatch_64(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p, ref int matchpos) { }

	// RVA: 0x2257410 Offset: 0x2255A10 VA: 0x182257410
	private static int LZ4HC_InsertAndGetWiderMatch_64(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p, int startLimit, int longest, ref int matchpos, ref int startpos) { }

	// RVA: 0x225CE10 Offset: 0x225B410 VA: 0x18225CE10
	private static int LZ4_encodeSequence_64(LZ4Codec.LZ4HC_Data_Structure ctx, ref int src_p, ref int dst_p, ref int src_anchor, int matchLength, int src_ref) { }

	// RVA: 0x225C070 Offset: 0x225A670 VA: 0x18225C070
	private static int LZ4_compressHCCtx_64(LZ4Codec.LZ4HC_Data_Structure ctx) { }

	// RVA: 0x2260660 Offset: 0x225EC60 VA: 0x182260660
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

	// RVA: 0x2255EB0 Offset: 0x22544B0 VA: 0x182255EB0
	private static void InitializeLZ4mm() { }

	// RVA: 0x2255E20 Offset: 0x2254420 VA: 0x182255E20
	private static void InitializeLZ4cc() { }

	// RVA: 0x2255F40 Offset: 0x2254540 VA: 0x182255F40
	private static void InitializeLZ4n() { }

	// RVA: 0x2255FE0 Offset: 0x22545E0 VA: 0x182255FE0
	private static void InitializeLZ4s() { }

	// RVA: 0x2260790 Offset: 0x225ED90 VA: 0x182260790
	private static void .cctor() { }

	// RVA: 0x225F600 Offset: 0x225DC00 VA: 0x18225F600
	private static void SelectCodec(out ILZ4Service encoder, out ILZ4Service decoder, out ILZ4Service encoderHC) { }

	// RVA: 0x2253BD0 Offset: 0x22521D0 VA: 0x182253BD0
	private static ILZ4Service AutoTest(ILZ4Service service) { }

	// RVA: 0x225FF30 Offset: 0x225E530 VA: 0x18225FF30
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
	|-RVA: 0x125D590 Offset: 0x125BB90 VA: 0x18125D590
	|-LZ4Codec.TryService<Safe32LZ4Service>
	|-LZ4Codec.TryService<Safe64LZ4Service>
	|-LZ4Codec.TryService<Unsafe32LZ4Service>
	|-LZ4Codec.TryService<Unsafe64LZ4Service>
	|-LZ4Codec.TryService<object>
	*/

	// RVA: 0x225F2C0 Offset: 0x225D8C0 VA: 0x18225F2C0
	public static int MaximumOutputLength(int inputLength) { }

	// RVA: 0x2255B80 Offset: 0x2254180 VA: 0x182255B80
	public static int Encode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x2255A90 Offset: 0x2254090 VA: 0x182255A90
	public static int EncodeHC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x2254F80 Offset: 0x2253580 VA: 0x182254F80
	public static int Decode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength = 0, bool knownOutputLength = False) { }

}

