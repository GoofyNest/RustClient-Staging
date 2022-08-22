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

	// RVA: 0x22D1280 Offset: 0x22CF880 VA: 0x1822D1280
	internal static void CheckArguments(byte[] input, int inputOffset, ref int inputLength, byte[] output, int outputOffset, ref int outputLength) { }

	// RVA: 0x22D11A0 Offset: 0x22CF7A0 VA: 0x1822D11A0
	private static void BlockCopy(byte* src, byte* dst, int len) { }

	// RVA: 0x22D1210 Offset: 0x22CF810 VA: 0x1822D1210
	private static void BlockFill(byte* dst, int len, byte val) { }

	// RVA: 0x22D1FC0 Offset: 0x22D05C0 VA: 0x1822D1FC0
	public static int Encode32(byte* input, byte* output, int inputLength, int outputLength) { }

	// RVA: 0x22D2110 Offset: 0x22D0710 VA: 0x1822D2110
	public static int Encode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22D1760 Offset: 0x22CFD60 VA: 0x1822D1760
	public static int Decode32(byte* input, int inputLength, byte* output, int outputLength, bool knownOutputLength) { }

	// RVA: 0x22D1410 Offset: 0x22CFA10 VA: 0x1822D1410
	public static int Decode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength) { }

	// RVA: 0x22D2A80 Offset: 0x22D1080 VA: 0x1822D2A80
	public static int Encode64(byte* input, byte* output, int inputLength, int outputLength) { }

	// RVA: 0x22D2720 Offset: 0x22D0D20 VA: 0x1822D2720
	public static int Encode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22D1BE0 Offset: 0x22D01E0 VA: 0x1822D1BE0
	public static int Decode64(byte* input, int inputLength, byte* output, int outputLength, bool knownOutputLength) { }

	// RVA: 0x22D1890 Offset: 0x22CFE90 VA: 0x1822D1890
	public static int Decode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength) { }

	// RVA: 0x22D2E00 Offset: 0x22D1400 VA: 0x1822D2E00
	private static LZ4Codec.LZ4HC_Data_Structure LZ4HC_Create(byte* src) { }

	// RVA: 0x22D6540 Offset: 0x22D4B40 VA: 0x1822D6540
	private static int LZ4_compressHC_32(byte* input, byte* output, int inputLength, int outputLength) { }

	// RVA: 0x22D1D10 Offset: 0x22D0310 VA: 0x1822D1D10
	public static int Encode32HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22D65E0 Offset: 0x22D4BE0 VA: 0x1822D65E0
	private static int LZ4_compressHC_64(byte* input, byte* output, int inputLength, int outputLength) { }

	// RVA: 0x22D2470 Offset: 0x22D0A70 VA: 0x1822D2470
	public static int Encode64HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22D4AA0 Offset: 0x22D30A0 VA: 0x1822D4AA0
	private static int LZ4_compressCtx_32(byte** hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D3DD0 Offset: 0x22D23D0 VA: 0x1822D3DD0
	private static int LZ4_compress64kCtx_32(ushort* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D6A50 Offset: 0x22D5050 VA: 0x1822D6A50
	private static int LZ4_uncompress_32(byte* src, byte* dst, int dst_len) { }

	// RVA: 0x22D71C0 Offset: 0x22D57C0 VA: 0x1822D71C0
	private static int LZ4_uncompress_unknownOutputSize_32(byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D3D10 Offset: 0x22D2310 VA: 0x1822D3D10
	private static void LZ4HC_Insert_32(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p) { }

	// RVA: 0x22D2BD0 Offset: 0x22D11D0 VA: 0x1822D2BD0
	private static int LZ4HC_CommonLength_32(byte* p1, byte* p2, byte* src_LASTLITERALS) { }

	// RVA: 0x22D2F20 Offset: 0x22D1520 VA: 0x1822D2F20
	private static int LZ4HC_InsertAndFindBestMatch_32(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p, byte* src_LASTLITERALS, ref byte* matchpos) { }

	// RVA: 0x22D3520 Offset: 0x22D1B20 VA: 0x1822D3520
	private static int LZ4HC_InsertAndGetWiderMatch_32(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p, byte* startLimit, byte* src_LASTLITERALS, int longest, ref byte* matchpos, ref byte* startpos) { }

	// RVA: 0x22D6680 Offset: 0x22D4C80 VA: 0x1822D6680
	private static int LZ4_encodeSequence_32(ref byte* src_p, ref byte* dst_p, ref byte* src_anchor, int matchLength, byte* xxx_ref, byte* dst_end) { }

	// RVA: 0x22D57A0 Offset: 0x22D3DA0 VA: 0x1822D57A0
	private static int LZ4_compressHCCtx_32(LZ4Codec.LZ4HC_Data_Structure ctx, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D5100 Offset: 0x22D3700 VA: 0x1822D5100
	private static int LZ4_compressCtx_64(uint* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D4420 Offset: 0x22D2A20 VA: 0x1822D4420
	private static int LZ4_compress64kCtx_64(ushort* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D6DC0 Offset: 0x22D53C0 VA: 0x1822D6DC0
	private static int LZ4_uncompress_64(byte* src, byte* dst, int dst_len) { }

	// RVA: 0x22D7590 Offset: 0x22D5B90 VA: 0x1822D7590
	private static int LZ4_uncompress_unknownOutputSize_64(byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D3D10 Offset: 0x22D2310 VA: 0x1822D3D10
	private static void LZ4HC_Insert_64(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p) { }

	// RVA: 0x22D2CD0 Offset: 0x22D12D0 VA: 0x1822D2CD0
	private static int LZ4HC_CommonLength_64(byte* p1, byte* p2, byte* src_LASTLITERALS) { }

	// RVA: 0x22D3220 Offset: 0x22D1820 VA: 0x1822D3220
	private static int LZ4HC_InsertAndFindBestMatch_64(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p, byte* src_LASTLITERALS, ref byte* matchpos) { }

	// RVA: 0x22D3900 Offset: 0x22D1F00 VA: 0x1822D3900
	private static int LZ4HC_InsertAndGetWiderMatch_64(LZ4Codec.LZ4HC_Data_Structure hc4, byte* src_p, byte* startLimit, byte* src_LASTLITERALS, int longest, ref byte* matchpos, ref byte* startpos) { }

	// RVA: 0x22D6870 Offset: 0x22D4E70 VA: 0x1822D6870
	private static int LZ4_encodeSequence_64(ref byte* src_p, ref byte* dst_p, ref byte* src_anchor, int matchLength, byte* src_ref, byte* dst_end) { }

	// RVA: 0x22D5E70 Offset: 0x22D4470 VA: 0x1822D5E70
	private static int LZ4_compressHCCtx_64(LZ4Codec.LZ4HC_Data_Structure ctx, byte* src, byte* dst, int src_len, int dst_maxlen) { }

	// RVA: 0x22D79E0 Offset: 0x22D5FE0 VA: 0x1822D79E0
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

	// RVA: 0x22541C0 Offset: 0x22527C0 VA: 0x1822541C0
	internal static void CheckArguments(byte[] input, int inputOffset, ref int inputLength, byte[] output, int outputOffset, ref int outputLength) { }

	// RVA: 0x225F080 Offset: 0x225D680 VA: 0x18225F080
	internal static void Poke2(byte[] buffer, int offset, ushort value) { }

	// RVA: 0x225F020 Offset: 0x225D620 VA: 0x18225F020
	internal static ushort Peek2(byte[] buffer, int offset) { }

	// RVA: 0x1202A50 Offset: 0x1201050 VA: 0x181202A50
	internal static uint Peek4(byte[] buffer, int offset) { }

	// RVA: 0x225FEE0 Offset: 0x225E4E0 VA: 0x18225FEE0
	private static uint Xor4(byte[] buffer, int offset1, int offset2) { }

	// RVA: 0x2260070 Offset: 0x225E670 VA: 0x182260070
	private static ulong Xor8(byte[] buffer, int offset1, int offset2) { }

	// RVA: 0x2255980 Offset: 0x2253F80 VA: 0x182255980
	private static bool Equal2(byte[] buffer, int offset1, int offset2) { }

	// RVA: 0x2255A20 Offset: 0x2254020 VA: 0x182255A20
	private static bool Equal4(byte[] buffer, int offset1, int offset2) { }

	// RVA: 0x2254350 Offset: 0x2252950 VA: 0x182254350
	private static void Copy4(byte[] buf, int src, int dst) { }

	// RVA: 0x2254490 Offset: 0x2252A90 VA: 0x182254490
	private static void Copy8(byte[] buf, int src, int dst) { }

	// RVA: 0x2253D40 Offset: 0x2252340 VA: 0x182253D40
	private static void BlockCopy(byte[] src, int src_0, byte[] dst, int dst_0, int len) { }

	// RVA: 0x225FCD0 Offset: 0x225E2D0 VA: 0x18225FCD0
	private static int WildCopy(byte[] src, int src_0, byte[] dst, int dst_0, int dst_end) { }

	// RVA: 0x225F0E0 Offset: 0x225D6E0 VA: 0x18225F0E0
	private static int SecureCopy(byte[] buffer, int src, int dst, int dst_end) { }

	// RVA: 0x2255000 Offset: 0x2253600 VA: 0x182255000
	public static int Encode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x2255520 Offset: 0x2253B20 VA: 0x182255520
	public static int Encode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x2254700 Offset: 0x2252D00 VA: 0x182254700
	public static int Decode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength) { }

	// RVA: 0x22549E0 Offset: 0x2252FE0 VA: 0x1822549E0
	public static int Decode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength) { }

	// RVA: 0x2256170 Offset: 0x2254770 VA: 0x182256170
	private static LZ4Codec.LZ4HC_Data_Structure LZ4HC_Create(byte[] src, int src_0, int src_len, byte[] dst, int dst_0, int dst_len) { }

	// RVA: 0x225C470 Offset: 0x225AA70 VA: 0x18225C470
	private static int LZ4_compressHC_32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x2254D90 Offset: 0x2253390 VA: 0x182254D90
	public static int Encode32HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x225C510 Offset: 0x225AB10 VA: 0x18225C510
	private static int LZ4_compressHC_64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22552B0 Offset: 0x22538B0 VA: 0x1822552B0
	public static int Encode64HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x2259770 Offset: 0x2257D70 VA: 0x182259770
	private static int LZ4_compressCtx_safe32(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x2257970 Offset: 0x2255F70 VA: 0x182257970
	private static int LZ4_compress64kCtx_safe32(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x225D0F0 Offset: 0x225B6F0 VA: 0x18225D0F0
	private static int LZ4_uncompress_safe32(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len) { }

	// RVA: 0x225E010 Offset: 0x225C610 VA: 0x18225E010
	private static int LZ4_uncompress_unknownOutputSize_safe32(byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x2257630 Offset: 0x2255C30 VA: 0x182257630
	private static void LZ4HC_Insert_32(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p) { }

	// RVA: 0x2255DC0 Offset: 0x22543C0 VA: 0x182255DC0
	private static int LZ4HC_CommonLength_32(LZ4Codec.LZ4HC_Data_Structure ctx, int p1, int p2) { }

	// RVA: 0x22562C0 Offset: 0x22548C0 VA: 0x1822562C0
	private static int LZ4HC_InsertAndFindBestMatch_32(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p, ref int src_match) { }

	// RVA: 0x2256CC0 Offset: 0x22552C0 VA: 0x182256CC0
	private static int LZ4HC_InsertAndGetWiderMatch_32(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p, int startLimit, int longest, ref int matchpos, ref int startpos) { }

	// RVA: 0x225C5B0 Offset: 0x225ABB0 VA: 0x18225C5B0
	private static int LZ4_encodeSequence_32(LZ4Codec.LZ4HC_Data_Structure ctx, ref int src_p, ref int dst_p, ref int src_anchor, int matchLength, int src_ref, int dst_end) { }

	// RVA: 0x225B6C0 Offset: 0x2259CC0 VA: 0x18225B6C0
	private static int LZ4_compressHCCtx_32(LZ4Codec.LZ4HC_Data_Structure ctx) { }

	// RVA: 0x225A6F0 Offset: 0x2258CF0 VA: 0x18225A6F0
	private static int LZ4_compressCtx_safe64(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x2258850 Offset: 0x2256E50 VA: 0x182258850
	private static int LZ4_compress64kCtx_safe64(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x225D850 Offset: 0x225BE50 VA: 0x18225D850
	private static int LZ4_uncompress_safe64(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len) { }

	// RVA: 0x225E7E0 Offset: 0x225CDE0 VA: 0x18225E7E0
	private static int LZ4_uncompress_unknownOutputSize_safe64(byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen) { }

	// RVA: 0x22577D0 Offset: 0x2255DD0 VA: 0x1822577D0
	private static void LZ4HC_Insert_64(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p) { }

	// RVA: 0x2255F70 Offset: 0x2254570 VA: 0x182255F70
	private static int LZ4HC_CommonLength_64(LZ4Codec.LZ4HC_Data_Structure ctx, int p1, int p2) { }

	// RVA: 0x22567C0 Offset: 0x2254DC0 VA: 0x1822567C0
	private static int LZ4HC_InsertAndFindBestMatch_64(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p, ref int matchpos) { }

	// RVA: 0x2257150 Offset: 0x2255750 VA: 0x182257150
	private static int LZ4HC_InsertAndGetWiderMatch_64(LZ4Codec.LZ4HC_Data_Structure ctx, int src_p, int startLimit, int longest, ref int matchpos, ref int startpos) { }

	// RVA: 0x225CB50 Offset: 0x225B150 VA: 0x18225CB50
	private static int LZ4_encodeSequence_64(LZ4Codec.LZ4HC_Data_Structure ctx, ref int src_p, ref int dst_p, ref int src_anchor, int matchLength, int src_ref) { }

	// RVA: 0x225BDB0 Offset: 0x225A3B0 VA: 0x18225BDB0
	private static int LZ4_compressHCCtx_64(LZ4Codec.LZ4HC_Data_Structure ctx) { }

	// RVA: 0x22603A0 Offset: 0x225E9A0 VA: 0x1822603A0
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

	// RVA: 0x2255BF0 Offset: 0x22541F0 VA: 0x182255BF0
	private static void InitializeLZ4mm() { }

	// RVA: 0x2255B60 Offset: 0x2254160 VA: 0x182255B60
	private static void InitializeLZ4cc() { }

	// RVA: 0x2255C80 Offset: 0x2254280 VA: 0x182255C80
	private static void InitializeLZ4n() { }

	// RVA: 0x2255D20 Offset: 0x2254320 VA: 0x182255D20
	private static void InitializeLZ4s() { }

	// RVA: 0x22604D0 Offset: 0x225EAD0 VA: 0x1822604D0
	private static void .cctor() { }

	// RVA: 0x225F340 Offset: 0x225D940 VA: 0x18225F340
	private static void SelectCodec(out ILZ4Service encoder, out ILZ4Service decoder, out ILZ4Service encoderHC) { }

	// RVA: 0x2253910 Offset: 0x2251F10 VA: 0x182253910
	private static ILZ4Service AutoTest(ILZ4Service service) { }

	// RVA: 0x225FC70 Offset: 0x225E270 VA: 0x18225FC70
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

	// RVA: 0x225F000 Offset: 0x225D600 VA: 0x18225F000
	public static int MaximumOutputLength(int inputLength) { }

	// RVA: 0x22558C0 Offset: 0x2253EC0 VA: 0x1822558C0
	public static int Encode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x22557D0 Offset: 0x2253DD0 VA: 0x1822557D0
	public static int EncodeHC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength) { }

	// RVA: 0x2254CC0 Offset: 0x22532C0 VA: 0x182254CC0
	public static int Decode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength = 0, bool knownOutputLength = False) { }

}

