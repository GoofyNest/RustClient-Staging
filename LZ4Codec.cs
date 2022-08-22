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

	// RVA: 0x22D1D60 Offset: 0x22D0360 VA: 0x1822D1D60
	internal static void CheckArguments(byte[] input, int inputOffset, ref int inputLength, byte[] output, int outputOffset, ref int outputLength) { }

	// RVA: 0x22D1C80 Offset: 0x22D0280 VA: 0x1822D1C80
	private static void BlockCopy(byte* src, byte* dst, int len) { }

	// RVA: 0x22D1CF0 Offset: 0x22D02F0 VA: 0x1822D1CF0
	private static void BlockFill(byte* dst, int len, byte val) { }

	// RVA: 0x22D2AA0 Offset: 0x22D10A0 VA: 0x1822D2AA0
	public static int Encode32(byte* input, byte* output, int inputLength, int outputLength) { }

	// RVA: 0x22D2BF0 Offset: 0x22D11F0 VA: 0x1822D2BF0
	public static int Encode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22D2240 Offset: 0x22D0840 VA: 0x1822D2240
	public static int Decode32(byte* input, int inputLength, byte* output, int outputLength, bool knownOutputLength) { }

	// RVA: 0x22D1EF0 Offset: 0x22D04F0 VA: 0x1822D1EF0
	public static int Decode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength) { }

	// RVA: 0x22D3560 Offset: 0x22D1B60 VA: 0x1822D3560
	public static int Encode64(byte* input, byte* output, int inputLength, int outputLength) { }

	// RVA: 0x22D3200 Offset: 0x22D1800 VA: 0x1822D3200
	public static int Encode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22D26C0 Offset: 0x22D0CC0 VA: 0x1822D26C0
	public static int Decode64(byte* input, int inputLength, byte* output, int outputLength, bool knownOutputLength) { }

	// RVA: 0x22D2370 Offset: 0x22D0970 VA: 0x1822D2370
	public static int Decode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength) { }

	// RVA: 0x22D38E0 Offset: 0x22D1EE0 VA: 0x1822D38E0
	private static LZ4Codec.LZ4HC_Data_Structure LZ4HC_Create(byte* src) { }

	// RVA: 0x22D7020 Offset: 0x22D5620 VA: 0x1822D7020
	private static int LZ4_compressHC_32(byte* input, byte* output, int inputLength, int outputLength) { }

	// RVA: 0x22D27F0 Offset: 0x22D0DF0 VA: 0x1822D27F0
	public static int Encode32HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22D70C0 Offset: 0x22D56C0 VA: 0x1822D70C0
	private static int LZ4_compressHC_64(byte* input, byte* output, int inputLength, int outputLength) { }

	// RVA: 0x22D2F50 Offset: 0x22D1550 VA: 0x1822D2F50
	public static int Encode64HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22D5580 Offset: 0x22D3B80 VA: 0x1822D5580
	private static int LZ4_compressCtx_32(byte** hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D48B0 Offset: 0x22D2EB0 VA: 0x1822D48B0
	private static int LZ4_compress64kCtx_32(ushort* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D7530 Offset: 0x22D5B30 VA: 0x1822D7530
	private static int LZ4_uncompress_32(byte* src, byte* dst, int dst_len) { }

	// RVA: 0x22D7CA0 Offset: 0x22D62A0 VA: 0x1822D7CA0
	private static int LZ4_uncompress_unknownOutputSize_32(byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D47F0 Offset: 0x22D2DF0 VA: 0x1822D47F0
	private static void LZ4HC_Insert_32(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p) { }

	// RVA: 0x22D36B0 Offset: 0x22D1CB0 VA: 0x1822D36B0
	private static int LZ4HC_CommonLength_32(byte* p1, byte* p2, byte* src_LASTLITERALS) { }

	// RVA: 0x22D3A00 Offset: 0x22D2000 VA: 0x1822D3A00
	private static int LZ4HC_InsertAndFindBestMatch_32(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p, byte* src_LASTLITERALS, ref byte* matchpos) { }

	// RVA: 0x22D4000 Offset: 0x22D2600 VA: 0x1822D4000
	private static int LZ4HC_InsertAndGetWiderMatch_32(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p, byte* startLimit, byte* src_LASTLITERALS, int longest, ref byte* matchpos, ref byte* startpos) { }

	// RVA: 0x22D7160 Offset: 0x22D5760 VA: 0x1822D7160
	private static int LZ4_encodeSequence_32(ref byte* src_p, ref byte* dst_p, ref byte* src_anchor, int matchLength, byte* xxx_ref, byte* dst_end) { }

	// RVA: 0x22D6280 Offset: 0x22D4880 VA: 0x1822D6280
	private static int LZ4_compressHCCtx_32(LZ4Codec.LZ4HC_Data_Structure ctx, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D5BE0 Offset: 0x22D41E0 VA: 0x1822D5BE0
	private static int LZ4_compressCtx_64(uint* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D4F00 Offset: 0x22D3500 VA: 0x1822D4F00
	private static int LZ4_compress64kCtx_64(ushort* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D78A0 Offset: 0x22D5EA0 VA: 0x1822D78A0
	private static int LZ4_uncompress_64(byte* src, byte* dst, int dst_len) { }

	// RVA: 0x22D8070 Offset: 0x22D6670 VA: 0x1822D8070
	private static int LZ4_uncompress_unknownOutputSize_64(byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D47F0 Offset: 0x22D2DF0 VA: 0x1822D47F0
	private static void LZ4HC_Insert_64(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p) { }

	// RVA: 0x22D37B0 Offset: 0x22D1DB0 VA: 0x1822D37B0
	private static int LZ4HC_CommonLength_64(byte* p1, byte* p2, byte* src_LASTLITERALS) { }

	// RVA: 0x22D3D00 Offset: 0x22D2300 VA: 0x1822D3D00
	private static int LZ4HC_InsertAndFindBestMatch_64(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p, byte* src_LASTLITERALS, ref byte* matchpos) { }

	// RVA: 0x22D43E0 Offset: 0x22D29E0 VA: 0x1822D43E0
	private static int LZ4HC_InsertAndGetWiderMatch_64(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p, byte* startLimit, byte* src_LASTLITERALS, int longest, ref byte* matchpos, ref byte* startpos) { }

	// RVA: 0x22D7350 Offset: 0x22D5950 VA: 0x1822D7350
	private static int LZ4_encodeSequence_64(ref byte* src_p, ref byte* dst_p, ref byte* src_anchor, int matchLength, byte* src_ref, byte* dst_end) { }

	// RVA: 0x22D6950 Offset: 0x22D4F50 VA: 0x1822D6950
	private static int LZ4_compressHCCtx_64(LZ4Codec.LZ4HC_Data_Structure ctx, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D84C0 Offset: 0x22D6AC0 VA: 0x1822D84C0
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

	// RVA: 0x2254CA0 Offset: 0x22532A0 VA: 0x182254CA0
	internal static void CheckArguments(byte[] input, int inputOffset, ref int inputLength, byte[] output, int outputOffset, ref int outputLength) { }

	// RVA: 0x225FB60 Offset: 0x225E160 VA: 0x18225FB60
	internal static void Poke2(byte[] buffer, int offset, ushort value) { }

	// RVA: 0x225FB00 Offset: 0x225E100 VA: 0x18225FB00
	internal static ushort Peek2(byte[] buffer, int offset) { }

	// RVA: 0x12033B0 Offset: 0x12019B0 VA: 0x1812033B0
	internal static uint Peek4(byte[] buffer, int offset) { }

	// RVA: 0x22609C0 Offset: 0x225EFC0 VA: 0x1822609C0
	private static uint Xor4(byte[] buffer, int offset1, int offset2) { }

	// RVA: 0x2260B50 Offset: 0x225F150 VA: 0x182260B50
	private static ulong Xor8(byte[] buffer, int offset1, int offset2) { }

	// RVA: 0x2256460 Offset: 0x2254A60 VA: 0x182256460
	private static bool Equal2(byte[] buffer, int offset1, int offset2) { }

	// RVA: 0x2256500 Offset: 0x2254B00 VA: 0x182256500
	private static bool Equal4(byte[] buffer, int offset1, int offset2) { }

	// RVA: 0x2254E30 Offset: 0x2253430 VA: 0x182254E30
	private static void Copy4(byte[] buf, int src, int dst) { }

	// RVA: 0x2254F70 Offset: 0x2253570 VA: 0x182254F70
	private static void Copy8(byte[] buf, int src, int dst) { }

	// RVA: 0x2254820 Offset: 0x2252E20 VA: 0x182254820
	private static void BlockCopy(byte[] src, int src_0, byte[] dst, int dst_0, int len) { }

	// RVA: 0x22607B0 Offset: 0x225EDB0 VA: 0x1822607B0
	private static int WildCopy(byte[] src, int src_0, byte[] dst, int dst_0, int dst_end) { }

	// RVA: 0x225FBC0 Offset: 0x225E1C0 VA: 0x18225FBC0
	private static int SecureCopy(byte[] buffer, int src, int dst, int dst_end) { }

	// RVA: 0x2255AE0 Offset: 0x22540E0 VA: 0x182255AE0
	public static int Encode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x2256000 Offset: 0x2254600 VA: 0x182256000
	public static int Encode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22551E0 Offset: 0x22537E0 VA: 0x1822551E0
	public static int Decode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength) { }

	// RVA: 0x22554C0 Offset: 0x2253AC0 VA: 0x1822554C0
	public static int Decode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength) { }

	// RVA: 0x2256C50 Offset: 0x2255250 VA: 0x182256C50
	private static LZ4Codec.LZ4HC_Data_Structure LZ4HC_Create(byte[] src, int src_0, int src_len, byte[] dst, int dst_0, int dst_len) { }

	// RVA: 0x225CF50 Offset: 0x225B550 VA: 0x18225CF50
	private static int LZ4_compressHC_32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x2255870 Offset: 0x2253E70 VA: 0x182255870
	public static int Encode32HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x225CFF0 Offset: 0x225B5F0 VA: 0x18225CFF0
	private static int LZ4_compressHC_64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x2255D90 Offset: 0x2254390 VA: 0x182255D90
	public static int Encode64HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x225A250 Offset: 0x2258850 VA: 0x18225A250
	private static int LZ4_compressCtx_safe32(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x2258450 Offset: 0x2256A50 VA: 0x182258450
	private static int LZ4_compress64kCtx_safe32(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x225DBD0 Offset: 0x225C1D0 VA: 0x18225DBD0
	private static int LZ4_uncompress_safe32(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len) { }

	// RVA: 0x225EAF0 Offset: 0x225D0F0 VA: 0x18225EAF0
	private static int LZ4_uncompress_unknownOutputSize_safe32(byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x2258110 Offset: 0x2256710 VA: 0x182258110
	private static void LZ4HC_Insert_32(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p) { }

	// RVA: 0x22568A0 Offset: 0x2254EA0 VA: 0x1822568A0
	private static int LZ4HC_CommonLength_32(LZ4Codec.LZ4HC_Data_Structure ctx, int p1, int p2) { }

	// RVA: 0x2256DA0 Offset: 0x22553A0 VA: 0x182256DA0
	private static int LZ4HC_InsertAndFindBestMatch_32(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p, ref int src_match) { }

	// RVA: 0x22577A0 Offset: 0x2255DA0 VA: 0x1822577A0
	private static int LZ4HC_InsertAndGetWiderMatch_32(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p, int startLimit, int longest, ref int matchpos, ref int startpos) { }

	// RVA: 0x225D090 Offset: 0x225B690 VA: 0x18225D090
	private static int LZ4_encodeSequence_32(LZ4Codec.LZ4HC_Data_Structure ctx, ref int src_p, ref int dst_p, ref int src_anchor, int matchLength, int src_ref, int dst_end) { }

	// RVA: 0x225C1A0 Offset: 0x225A7A0 VA: 0x18225C1A0
	private static int LZ4_compressHCCtx_32(LZ4Codec.LZ4HC_Data_Structure ctx) { }

	// RVA: 0x225B1D0 Offset: 0x22597D0 VA: 0x18225B1D0
	private static int LZ4_compressCtx_safe64(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x2259330 Offset: 0x2257930 VA: 0x182259330
	private static int LZ4_compress64kCtx_safe64(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x225E330 Offset: 0x225C930 VA: 0x18225E330
	private static int LZ4_uncompress_safe64(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len) { }

	// RVA: 0x225F2C0 Offset: 0x225D8C0 VA: 0x18225F2C0
	private static int LZ4_uncompress_unknownOutputSize_safe64(byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x22582B0 Offset: 0x22568B0 VA: 0x1822582B0
	private static void LZ4HC_Insert_64(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p) { }

	// RVA: 0x2256A50 Offset: 0x2255050 VA: 0x182256A50
	private static int LZ4HC_CommonLength_64(LZ4Codec.LZ4HC_Data_Structure ctx, int p1, int p2) { }

	// RVA: 0x22572A0 Offset: 0x22558A0 VA: 0x1822572A0
	private static int LZ4HC_InsertAndFindBestMatch_64(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p, ref int matchpos) { }

	// RVA: 0x2257C30 Offset: 0x2256230 VA: 0x182257C30
	private static int LZ4HC_InsertAndGetWiderMatch_64(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p, int startLimit, int longest, ref int matchpos, ref int startpos) { }

	// RVA: 0x225D630 Offset: 0x225BC30 VA: 0x18225D630
	private static int LZ4_encodeSequence_64(LZ4Codec.LZ4HC_Data_Structure ctx, ref int src_p, ref int dst_p, ref int src_anchor, int matchLength, int src_ref) { }

	// RVA: 0x225C890 Offset: 0x225AE90 VA: 0x18225C890
	private static int LZ4_compressHCCtx_64(LZ4Codec.LZ4HC_Data_Structure ctx) { }

	// RVA: 0x2260E80 Offset: 0x225F480 VA: 0x182260E80
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

	// RVA: 0x22566D0 Offset: 0x2254CD0 VA: 0x1822566D0
	private static void InitializeLZ4mm() { }

	// RVA: 0x2256640 Offset: 0x2254C40 VA: 0x182256640
	private static void InitializeLZ4cc() { }

	// RVA: 0x2256760 Offset: 0x2254D60 VA: 0x182256760
	private static void InitializeLZ4n() { }

	// RVA: 0x2256800 Offset: 0x2254E00 VA: 0x182256800
	private static void InitializeLZ4s() { }

	// RVA: 0x2260FB0 Offset: 0x225F5B0 VA: 0x182260FB0
	private static void .cctor() { }

	// RVA: 0x225FE20 Offset: 0x225E420 VA: 0x18225FE20
	private static void SelectCodec(out ILZ4Service encoder, out ILZ4Service decoder, out ILZ4Service encoderHC) { }

	// RVA: 0x22543F0 Offset: 0x22529F0 VA: 0x1822543F0
	private static ILZ4Service AutoTest(ILZ4Service service) { }

	// RVA: 0x2260750 Offset: 0x225ED50 VA: 0x182260750
	private static void Try(Action method) { }

	// RVA: -1 Offset: -1
	private static T Try<T>(Func<T> method, T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1210 Offset: 0x5CF810 VA: 0x1805D1210
	|-LZ4Codec.Try<bool>
	|
	|-RVA: 0x5D1290 Offset: 0x5CF890 VA: 0x1805D1290
	|-LZ4Codec.Try<object>
	*/

	// RVA: -1 Offset: -1
	private static ILZ4Service TryService<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125DC30 Offset: 0x125C230 VA: 0x18125DC30
	|-LZ4Codec.TryService<Safe32LZ4Service>
	|-LZ4Codec.TryService<Safe64LZ4Service>
	|-LZ4Codec.TryService<Unsafe32LZ4Service>
	|-LZ4Codec.TryService<Unsafe64LZ4Service>
	|-LZ4Codec.TryService<object>
	*/

	// RVA: 0x225FAE0 Offset: 0x225E0E0 VA: 0x18225FAE0
	public static int MaximumOutputLength(int inputLength) { }

	// RVA: 0x22563A0 Offset: 0x22549A0 VA: 0x1822563A0
	public static int Encode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22562B0 Offset: 0x22548B0 VA: 0x1822562B0
	public static int EncodeHC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22557A0 Offset: 0x2253DA0 VA: 0x1822557A0
	public static int Decode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength = 0, bool knownOutputLength = False) { }

}

