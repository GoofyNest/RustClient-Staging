public class CP932 : MonoEncoding // TypeDefIndex: 7797
{	// Fields
	private const int SHIFTJIS_CODE_PAGE = 932;

	// Properties
	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override bool IsBrowserDisplay { get; }
	public override bool IsBrowserSave { get; }
	public override bool IsMailNewsDisplay { get; }
	public override bool IsMailNewsSave { get; }
	public override string WebName { get; }
	public override int WindowsCodePage { get; }

	// Methods

	// RVA: 0x224C550 Offset: 0x224AB50 VA: 0x18224C550
	public void .ctor() { }

	// RVA: 0x224B8B0 Offset: 0x2249EB0 VA: 0x18224B8B0 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x224BAC0 Offset: 0x224A0C0 VA: 0x18224BAC0 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x224C160 Offset: 0x224A760 VA: 0x18224C160 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224C2C0 Offset: 0x224A8C0 VA: 0x18224C2C0 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224C450 Offset: 0x224AA50 VA: 0x18224C450 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x224C4D0 Offset: 0x224AAD0 VA: 0x18224C4D0 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x224C3B0 Offset: 0x224A9B0 VA: 0x18224C3B0 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x224C560 Offset: 0x224AB60 VA: 0x18224C560 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224C590 Offset: 0x224AB90 VA: 0x18224C590 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224C5C0 Offset: 0x224ABC0 VA: 0x18224C5C0 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 15
	public override bool get_IsMailNewsSave() { }

	// RVA: 0x224C5F0 Offset: 0x224ABF0 VA: 0x18224C5F0 Slot: 10
	public override string get_WebName() { }

	// RVA: 0x224C620 Offset: 0x224AC20 VA: 0x18224C620 Slot: 11
	public override int get_WindowsCodePage() { }

}

internal sealed class CP932Decoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7798
{	// Fields
	private JISConvert convert; // 0x28
	private int last_byte_count; // 0x30
	private int last_byte_chars; // 0x34

	// Methods

	// RVA: 0x224B860 Offset: 0x2249E60 VA: 0x18224B860
	public void .ctor(JISConvert convert) { }

	// RVA: 0x224B3A0 Offset: 0x22499A0 VA: 0x18224B3A0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224B2C0 Offset: 0x22498C0 VA: 0x18224B2C0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	// RVA: 0x224B460 Offset: 0x2249A60 VA: 0x18224B460 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224B490 Offset: 0x2249A90 VA: 0x18224B490 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

}

public class CP50220 : ISO2022JPEncoding // TypeDefIndex: 7800
{	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x2249CC0 Offset: 0x22482C0 VA: 0x182249CC0
	public void .ctor() { }

	// RVA: 0x2249CF0 Offset: 0x22482F0 VA: 0x182249CF0 Slot: 8
	public override string get_EncodingName() { }

}

public class CP50221 : ISO2022JPEncoding // TypeDefIndex: 7801
{	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x2249D20 Offset: 0x2248320 VA: 0x182249D20
	public void .ctor() { }

	// RVA: 0x2249D50 Offset: 0x2248350 VA: 0x182249D50 Slot: 8
	public override string get_EncodingName() { }

}

public class CP50222 : ISO2022JPEncoding // TypeDefIndex: 7802
{	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x2249D80 Offset: 0x2248380 VA: 0x182249D80
	public void .ctor() { }

	// RVA: 0x2249DB0 Offset: 0x22483B0 VA: 0x182249DB0 Slot: 8
	public override string get_EncodingName() { }

}

public class CP51932 : MonoEncoding // TypeDefIndex: 7808
{	// Fields
	private const int EUC_JP_CODE_PAGE = 51932;

	// Properties
	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override bool IsBrowserDisplay { get; }
	public override bool IsBrowserSave { get; }
	public override bool IsMailNewsDisplay { get; }
	public override bool IsMailNewsSave { get; }
	public override string WebName { get; }

	// Methods

	// RVA: 0x224B0D0 Offset: 0x22496D0 VA: 0x18224B0D0
	public void .ctor() { }

	// RVA: 0x224AC40 Offset: 0x2249240 VA: 0x18224AC40 Slot: 19
	public override int GetByteCount(char[] chars, int index, int length) { }

	// RVA: 0x224ABA0 Offset: 0x22491A0 VA: 0x18224ABA0 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x224ACF0 Offset: 0x22492F0 VA: 0x18224ACF0 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x224ADB0 Offset: 0x22493B0 VA: 0x18224ADB0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224AE50 Offset: 0x2249450 VA: 0x18224AE50 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224AFD0 Offset: 0x22495D0 VA: 0x18224AFD0 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x224B050 Offset: 0x2249650 VA: 0x18224B050 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x224AF70 Offset: 0x2249570 VA: 0x18224AF70 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x224AF10 Offset: 0x2249510 VA: 0x18224AF10 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x224B0F0 Offset: 0x22496F0 VA: 0x18224B0F0 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224B120 Offset: 0x2249720 VA: 0x18224B120 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224B150 Offset: 0x2249750 VA: 0x18224B150 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 15
	public override bool get_IsMailNewsSave() { }

	// RVA: 0x224B180 Offset: 0x2249780 VA: 0x18224B180 Slot: 10
	public override string get_WebName() { }

}

public class CP51932Encoder : MonoEncoder // TypeDefIndex: 7809
{	// Methods

	// RVA: 0x224AB90 Offset: 0x2249190 VA: 0x18224AB90
	public void .ctor(MonoEncoding encoding) { }

	// RVA: 0x224A580 Offset: 0x2248B80 VA: 0x18224A580 Slot: 11
	public override int GetByteCountImpl(char* chars, int count, bool refresh) { }

	// RVA: 0x224A790 Offset: 0x2248D90 VA: 0x18224A790 Slot: 12
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool refresh) { }

}

internal class CP51932Decoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7810
{	// Fields
	private int last_count; // 0x28
	private int last_bytes; // 0x2C

	// Methods

	// RVA: 0x224A550 Offset: 0x2248B50 VA: 0x18224A550
	public void .ctor() { }

	// RVA: 0xE4D640 Offset: 0xE4BC40 VA: 0x180E4D640 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x2249DE0 Offset: 0x22483E0 VA: 0x182249DE0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	// RVA: 0x18ACCD0 Offset: 0x18AB2D0 VA: 0x1818ACCD0 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224A020 Offset: 0x2248620 VA: 0x18224A020 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

	// RVA: 0x224A4E0 Offset: 0x2248AE0 VA: 0x18224A4E0
	private Exception Insufficient() { }

}

internal class CP936 : DbcsEncoding // TypeDefIndex: 7812
{	// Fields
	private const int GB2312_CODE_PAGE = 936;

	// Properties
	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override bool IsBrowserDisplay { get; }
	public override bool IsBrowserSave { get; }
	public override bool IsMailNewsDisplay { get; }
	public override bool IsMailNewsSave { get; }
	public override string WebName { get; }

	// Methods

	// RVA: 0x224D0A0 Offset: 0x224B6A0 VA: 0x18224D0A0
	public void .ctor() { }

	// RVA: 0x224CFC0 Offset: 0x224B5C0 VA: 0x18224CFC0 Slot: 48
	internal override DbcsConvert GetConvert() { }

	// RVA: 0x224CC20 Offset: 0x224B220 VA: 0x18224CC20 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x224CD10 Offset: 0x224B310 VA: 0x18224CD10 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x224CEE0 Offset: 0x224B4E0 VA: 0x18224CEE0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224CF50 Offset: 0x224B550 VA: 0x18224CF50 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224D020 Offset: 0x224B620 VA: 0x18224D020 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x224D0B0 Offset: 0x224B6B0 VA: 0x18224D0B0 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224D0E0 Offset: 0x224B6E0 VA: 0x18224D0E0 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224D110 Offset: 0x224B710 VA: 0x18224D110 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 15
	public override bool get_IsMailNewsSave() { }

	// RVA: 0x224D140 Offset: 0x224B740 VA: 0x18224D140 Slot: 10
	public override string get_WebName() { }

}

internal sealed class CP936Decoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7813
{	// Fields
	private int last_byte_count; // 0x28
	private int last_byte_bytes; // 0x2C

	// Methods

	// RVA: 0x15C0D00 Offset: 0x15BF300 VA: 0x1815C0D00
	public void .ctor(DbcsConvert convert) { }

	// RVA: 0x224C630 Offset: 0x224AC30 VA: 0x18224C630 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224C6F0 Offset: 0x224ACF0 VA: 0x18224C6F0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	// RVA: 0x224C7C0 Offset: 0x224ADC0 VA: 0x18224C7C0 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224C9D0 Offset: 0x224AFD0 VA: 0x18224C9D0 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

}

internal class CP949 : KoreanEncoding // TypeDefIndex: 7815
{	// Fields
	private const int UHC_CODE_PAGE = 949;

	// Properties
	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override string WebName { get; }

	// Methods

	// RVA: 0x224D170 Offset: 0x224B770 VA: 0x18224D170
	public void .ctor() { }

	// RVA: 0x224D1A0 Offset: 0x224B7A0 VA: 0x18224D1A0 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224D1D0 Offset: 0x224B7D0 VA: 0x18224D1D0 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224D200 Offset: 0x224B800 VA: 0x18224D200 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x224D230 Offset: 0x224B830 VA: 0x18224D230 Slot: 10
	public override string get_WebName() { }

}

internal class CP51949 : KoreanEncoding // TypeDefIndex: 7816
{	// Fields
	private const int EUCKR_CODE_PAGE = 51949;

	// Properties
	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override string WebName { get; }

	// Methods

	// RVA: 0x224B1B0 Offset: 0x22497B0 VA: 0x18224B1B0
	public void .ctor() { }

	// RVA: 0x224B1E0 Offset: 0x22497E0 VA: 0x18224B1E0 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224B210 Offset: 0x2249810 VA: 0x18224B210 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224B240 Offset: 0x2249840 VA: 0x18224B240 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x224B270 Offset: 0x2249870 VA: 0x18224B270 Slot: 10
	public override string get_WebName() { }

}

internal class CP950 : DbcsEncoding // TypeDefIndex: 7821
{	// Fields
	private const int BIG5_CODE_PAGE = 950;

	// Properties
	public override string BodyName { get; }
	public override string EncodingName { get; }
	public override string HeaderName { get; }
	public override string WebName { get; }

	// Methods

	// RVA: 0x224DB80 Offset: 0x224C180 VA: 0x18224DB80
	public void .ctor() { }

	// RVA: 0x224DAA0 Offset: 0x224C0A0 VA: 0x18224DAA0 Slot: 48
	internal override DbcsConvert GetConvert() { }

	// RVA: 0x224D9B0 Offset: 0x224BFB0 VA: 0x18224D9B0 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x224CD10 Offset: 0x224B310 VA: 0x18224CD10 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x224CF50 Offset: 0x224B550 VA: 0x18224CF50 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224DB00 Offset: 0x224C100 VA: 0x18224DB00 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x224DB90 Offset: 0x224C190 VA: 0x18224DB90 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224DBC0 Offset: 0x224C1C0 VA: 0x18224DBC0 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224DBF0 Offset: 0x224C1F0 VA: 0x18224DBF0 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x224DC20 Offset: 0x224C220 VA: 0x18224DC20 Slot: 10
	public override string get_WebName() { }

}

private sealed class CP950.CP950Decoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7822
{	// Fields
	private int last_byte_count; // 0x28
	private int last_byte_conv; // 0x2C

	// Methods

	// RVA: 0x15C0D00 Offset: 0x15BF300 VA: 0x1815C0D00
	public void .ctor(DbcsConvert convert) { }

	// RVA: 0x224D260 Offset: 0x224B860 VA: 0x18224D260 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224D3A0 Offset: 0x224B9A0 VA: 0x18224D3A0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	// RVA: 0x224D4F0 Offset: 0x224BAF0 VA: 0x18224D4F0 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224D730 Offset: 0x224BD30 VA: 0x18224D730 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

}

public class CP54936 : GB18030Encoding // TypeDefIndex: 7829
{	// Methods

	// RVA: 0x224B2A0 Offset: 0x22498A0 VA: 0x18224B2A0
	public void .ctor() { }

}

public class CP1254 : ByteEncoding // TypeDefIndex: 7840
{	// Fields
	private static readonly char[] ToChars; // 0x2356

	// Methods

	// RVA: 0x2305490 Offset: 0x2303A90 VA: 0x182305490
	public void .ctor() { }

	// RVA: 0x2305420 Offset: 0x2303A20 VA: 0x182305420
	private static void .cctor() { }

	// RVA: 0x2304FC0 Offset: 0x23035C0 VA: 0x182304FC0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1255 : ByteEncoding // TypeDefIndex: 7842
{	// Fields
	private static readonly char[] ToChars; // 0x2B11160

	// Methods

	// RVA: 0x23059D0 Offset: 0x2303FD0 VA: 0x1823059D0
	public void .ctor() { }

	// RVA: 0x2305960 Offset: 0x2303F60 VA: 0x182305960
	private static void .cctor() { }

	// RVA: 0x2305550 Offset: 0x2303B50 VA: 0x182305550 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1256 : ByteEncoding // TypeDefIndex: 7844
{	// Fields
	private static readonly char[] ToChars; // 0x2360

	// Methods

	// RVA: 0x2306530 Offset: 0x2304B30 VA: 0x182306530
	public void .ctor() { }

	// RVA: 0x23064C0 Offset: 0x2304AC0 VA: 0x1823064C0
	private static void .cctor() { }

	// RVA: 0x2305A80 Offset: 0x2304080 VA: 0x182305A80 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28596 : ByteEncoding // TypeDefIndex: 7846
{	// Fields
	private static readonly char[] ToChars; // 0x2391

	// Methods

	// RVA: 0x2307010 Offset: 0x2305610 VA: 0x182307010
	public void .ctor() { }

	// RVA: 0x2306FA0 Offset: 0x23055A0 VA: 0x182306FA0
	private static void .cctor() { }

	// RVA: 0x23065E0 Offset: 0x2304BE0 VA: 0x1823065E0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28598 : ByteEncoding // TypeDefIndex: 7848
{	// Fields
	private static readonly char[] ToChars; // 0x2B11194

	// Methods

	// RVA: 0x2307340 Offset: 0x2305940 VA: 0x182307340
	public void .ctor() { }

	// RVA: 0x23072D0 Offset: 0x23058D0 VA: 0x1823072D0
	private static void .cctor() { }

	// RVA: 0x23070C0 Offset: 0x23056C0 VA: 0x1823070C0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28599 : ByteEncoding // TypeDefIndex: 7850
{	// Fields
	private static readonly char[] ToChars; // 0x23A0

	// Methods

	// RVA: 0x2307670 Offset: 0x2305C70 VA: 0x182307670
	public void .ctor() { }

	// RVA: 0x2307600 Offset: 0x2305C00 VA: 0x182307600
	private static void .cctor() { }

	// RVA: 0x23073F0 Offset: 0x23059F0 VA: 0x1823073F0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP38598 : ByteEncoding // TypeDefIndex: 7852
{	// Fields
	private static readonly char[] ToChars; // 0x2417

	// Methods

	// RVA: 0x2307790 Offset: 0x2305D90 VA: 0x182307790
	public void .ctor() { }

	// RVA: 0x2307720 Offset: 0x2305D20 VA: 0x182307720
	private static void .cctor() { }

	// RVA: 0x23070C0 Offset: 0x23056C0 VA: 0x1823070C0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1251 : ByteEncoding // TypeDefIndex: 7858
{	// Fields
	private static readonly char[] ToChars; // 0x2B11310

	// Methods

	// RVA: 0x22F1550 Offset: 0x22EFB50 VA: 0x1822F1550
	public void .ctor() { }

	// RVA: 0x22F14E0 Offset: 0x22EFAE0 VA: 0x1822F14E0
	private static void .cctor() { }

	// RVA: 0x22F0FA0 Offset: 0x22EF5A0 VA: 0x1822F0FA0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1257 : ByteEncoding // TypeDefIndex: 7860
{	// Fields
	private static readonly char[] ToChars; // 0x2420

	// Methods

	// RVA: 0x22F1E00 Offset: 0x22F0400 VA: 0x1822F1E00
	public void .ctor() { }

	// RVA: 0x22F1D90 Offset: 0x22F0390 VA: 0x1822F1D90
	private static void .cctor() { }

	// RVA: 0x22F1610 Offset: 0x22EFC10 VA: 0x1822F1610 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1258 : ByteEncoding // TypeDefIndex: 7862
{	// Fields
	private static readonly char[] ToChars; // 0x24B7

	// Methods

	// RVA: 0x22F23B0 Offset: 0x22F09B0 VA: 0x1822F23B0
	public void .ctor() { }

	// RVA: 0x22F2340 Offset: 0x22F0940 VA: 0x1822F2340
	private static void .cctor() { }

	// RVA: 0x22F1EC0 Offset: 0x22F04C0 VA: 0x1822F1EC0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20866 : ByteEncoding // TypeDefIndex: 7864
{	// Fields
	private static readonly char[] ToChars; // 0x2B11370

	// Methods

	// RVA: 0x22F2BE0 Offset: 0x22F11E0 VA: 0x1822F2BE0
	public void .ctor() { }

	// RVA: 0x22F2B70 Offset: 0x22F1170 VA: 0x1822F2B70
	private static void .cctor() { }

	// RVA: 0x22F2460 Offset: 0x22F0A60 VA: 0x1822F2460 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP21866 : ByteEncoding // TypeDefIndex: 7866
{	// Fields
	private static readonly char[] ToChars; // 0x24C0

	// Methods

	// RVA: 0x22F34F0 Offset: 0x22F1AF0 VA: 0x1822F34F0
	public void .ctor() { }

	// RVA: 0x22F3480 Offset: 0x22F1A80 VA: 0x1822F3480
	private static void .cctor() { }

	// RVA: 0x22F2C90 Offset: 0x22F1290 VA: 0x1822F2C90 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28594 : ByteEncoding // TypeDefIndex: 7868
{	// Fields
	private static readonly char[] ToChars; // 0x2527

	// Methods

	// RVA: 0x22F3B90 Offset: 0x22F2190 VA: 0x1822F3B90
	public void .ctor() { }

	// RVA: 0x22F3B20 Offset: 0x22F2120 VA: 0x1822F3B20
	private static void .cctor() { }

	// RVA: 0x22F35A0 Offset: 0x22F1BA0 VA: 0x1822F35A0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28595 : ByteEncoding // TypeDefIndex: 7870
{	// Fields
	private static readonly char[] ToChars; // 0x2B11170

	// Methods

	// RVA: 0x22F3EB0 Offset: 0x22F24B0 VA: 0x1822F3EB0
	public void .ctor() { }

	// RVA: 0x22F3E40 Offset: 0x22F2440 VA: 0x1822F3E40
	private static void .cctor() { }

	// RVA: 0x22F3C40 Offset: 0x22F2240 VA: 0x1822F3C40 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP57002 : ISCIIEncoding // TypeDefIndex: 7873
{	// Methods

	// RVA: 0x22F3F60 Offset: 0x22F2560 VA: 0x1822F3F60
	public void .ctor() { }

}

public class CP57003 : ISCIIEncoding // TypeDefIndex: 7874
{	// Methods

	// RVA: 0x22F3FE0 Offset: 0x22F25E0 VA: 0x1822F3FE0
	public void .ctor() { }

}

public class CP57004 : ISCIIEncoding // TypeDefIndex: 7875
{	// Methods

	// RVA: 0x22F4060 Offset: 0x22F2660 VA: 0x1822F4060
	public void .ctor() { }

}

public class CP57005 : ISCIIEncoding // TypeDefIndex: 7876
{	// Methods

	// RVA: 0x22F40E0 Offset: 0x22F26E0 VA: 0x1822F40E0
	public void .ctor() { }

}

public class CP57006 : ISCIIEncoding // TypeDefIndex: 7877
{	// Methods

	// RVA: 0x22F4160 Offset: 0x22F2760 VA: 0x1822F4160
	public void .ctor() { }

}

public class CP57007 : ISCIIEncoding // TypeDefIndex: 7878
{	// Methods

	// RVA: 0x22F41E0 Offset: 0x22F27E0 VA: 0x1822F41E0
	public void .ctor() { }

}

public class CP57008 : ISCIIEncoding // TypeDefIndex: 7879
{	// Methods

	// RVA: 0x22F4260 Offset: 0x22F2860 VA: 0x1822F4260
	public void .ctor() { }

}

public class CP57009 : ISCIIEncoding // TypeDefIndex: 7880
{	// Methods

	// RVA: 0x22F42E0 Offset: 0x22F28E0 VA: 0x1822F42E0
	public void .ctor() { }

}

public class CP57010 : ISCIIEncoding // TypeDefIndex: 7881
{	// Methods

	// RVA: 0x22F4360 Offset: 0x22F2960 VA: 0x1822F4360
	public void .ctor() { }

}

public class CP57011 : ISCIIEncoding // TypeDefIndex: 7882
{	// Methods

	// RVA: 0x22F43E0 Offset: 0x22F29E0 VA: 0x1822F43E0
	public void .ctor() { }

}

public class CP874 : ByteEncoding // TypeDefIndex: 7893
{	// Fields
	private static readonly char[] ToChars; // 0x2530

	// Methods

	// RVA: 0x22F47A0 Offset: 0x22F2DA0 VA: 0x1822F47A0
	public void .ctor() { }

	// RVA: 0x22F4730 Offset: 0x22F2D30 VA: 0x1822F4730
	private static void .cctor() { }

	// RVA: 0x22F4460 Offset: 0x22F2A60 VA: 0x1822F4460 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP866 : ByteEncoding // TypeDefIndex: 7899
{	// Fields
	private static readonly char[] ToChars; // 0x2578

	// Methods

	// RVA: 0x22EAF20 Offset: 0x22E9520 VA: 0x1822EAF20
	public void .ctor() { }

	// RVA: 0x22EAEB0 Offset: 0x22E94B0 VA: 0x1822EAEB0
	private static void .cctor() { }

	// RVA: 0x22EA530 Offset: 0x22E8B30 VA: 0x1822EA530 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1026 : ByteEncoding // TypeDefIndex: 7901
{	// Fields
	private static readonly char[] ToChars; // 0x2B11440

	// Methods

	// RVA: 0x2187990 Offset: 0x2185F90 VA: 0x182187990
	public void .ctor() { }

	// RVA: 0x2187920 Offset: 0x2185F20 VA: 0x182187920
	private static void .cctor() { }

	// RVA: 0x2186C30 Offset: 0x2185230 VA: 0x182186C30 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP869 : ByteEncoding // TypeDefIndex: 7903
{	// Fields
	private static readonly char[] ToChars; // 0x2580

	// Methods

	// RVA: 0x22EBB40 Offset: 0x22EA140 VA: 0x1822EBB40
	public void .ctor() { }

	// RVA: 0x22EBAD0 Offset: 0x22EA0D0 VA: 0x1822EBAD0
	private static void .cctor() { }

	// RVA: 0x22EAFD0 Offset: 0x22E95D0 VA: 0x1822EAFD0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP870 : ByteEncoding // TypeDefIndex: 7905
{	// Fields
	private static readonly char[] ToChars; // 0x25B9

	// Methods

	// RVA: 0x22EC9A0 Offset: 0x22EAFA0 VA: 0x1822EC9A0
	public void .ctor() { }

	// RVA: 0x22EC930 Offset: 0x22EAF30 VA: 0x1822EC930
	private static void .cctor() { }

	// RVA: 0x22EBBF0 Offset: 0x22EA1F0 VA: 0x1822EBBF0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP875 : ByteEncoding // TypeDefIndex: 7907
{	// Fields
	private static readonly char[] ToChars; // 0x2B11180

	// Methods

	// RVA: 0x22ED540 Offset: 0x22EBB40 VA: 0x1822ED540
	public void .ctor() { }

	// RVA: 0x22ED4D0 Offset: 0x22EBAD0 VA: 0x1822ED4D0
	private static void .cctor() { }

	// RVA: 0x22ECA50 Offset: 0x22EB050 VA: 0x1822ECA50 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1047 : ByteEncoding // TypeDefIndex: 7909
{	// Fields
	private static readonly char[] ToChars; // 0x25C0

	// Methods

	// RVA: 0x2188740 Offset: 0x2186D40 VA: 0x182188740
	public void .ctor() { }

	// RVA: 0x21886D0 Offset: 0x2186CD0 VA: 0x1821886D0
	private static void .cctor() { }

	// RVA: 0x2187A40 Offset: 0x2186040 VA: 0x182187A40 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1140 : ByteEncoding // TypeDefIndex: 7911
{	// Fields
	private static readonly char[] ToChars; // 0x25DD

	// Methods

	// RVA: 0x2189500 Offset: 0x2187B00 VA: 0x182189500
	public void .ctor() { }

	// RVA: 0x2189490 Offset: 0x2187A90 VA: 0x182189490
	private static void .cctor() { }

	// RVA: 0x21887F0 Offset: 0x2186DF0 VA: 0x1821887F0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1141 : ByteEncoding // TypeDefIndex: 7913
{	// Fields
	private static readonly char[] ToChars; // 0x2B11168

	// Methods

	// RVA: 0x218A2C0 Offset: 0x21888C0 VA: 0x18218A2C0
	public void .ctor() { }

	// RVA: 0x218A250 Offset: 0x2188850 VA: 0x18218A250
	private static void .cctor() { }

	// RVA: 0x21895B0 Offset: 0x2187BB0 VA: 0x1821895B0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1142 : ByteEncoding // TypeDefIndex: 7915
{	// Fields
	private static readonly char[] ToChars; // 0x25E0

	// Methods

	// RVA: 0x218B080 Offset: 0x2189680 VA: 0x18218B080
	public void .ctor() { }

	// RVA: 0x218B010 Offset: 0x2189610 VA: 0x18218B010
	private static void .cctor() { }

	// RVA: 0x218A370 Offset: 0x2188970 VA: 0x18218A370 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1143 : ByteEncoding // TypeDefIndex: 7917
{	// Fields
	private static readonly char[] ToChars; // 0x2649

	// Methods

	// RVA: 0x218BE40 Offset: 0x218A440 VA: 0x18218BE40
	public void .ctor() { }

	// RVA: 0x218BDD0 Offset: 0x218A3D0 VA: 0x18218BDD0
	private static void .cctor() { }

	// RVA: 0x218B130 Offset: 0x2189730 VA: 0x18218B130 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1144 : ByteEncoding // TypeDefIndex: 7919
{	// Fields
	private static readonly char[] ToChars; // 0x2B112DC

	// Methods

	// RVA: 0x218CC00 Offset: 0x218B200 VA: 0x18218CC00
	public void .ctor() { }

	// RVA: 0x218CB90 Offset: 0x218B190 VA: 0x18218CB90
	private static void .cctor() { }

	// RVA: 0x218BEF0 Offset: 0x218A4F0 VA: 0x18218BEF0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1145 : ByteEncoding // TypeDefIndex: 7921
{	// Fields
	private static readonly char[] ToChars; // 0x2650

	// Methods

	// RVA: 0x218D9C0 Offset: 0x218BFC0 VA: 0x18218D9C0
	public void .ctor() { }

	// RVA: 0x218D950 Offset: 0x218BF50 VA: 0x18218D950
	private static void .cctor() { }

	// RVA: 0x218CCB0 Offset: 0x218B2B0 VA: 0x18218CCB0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1146 : ByteEncoding // TypeDefIndex: 7923
{	// Fields
	private static readonly char[] ToChars; // 0x27F7

	// Methods

	// RVA: 0x218E780 Offset: 0x218CD80 VA: 0x18218E780
	public void .ctor() { }

	// RVA: 0x218E710 Offset: 0x218CD10 VA: 0x18218E710
	private static void .cctor() { }

	// RVA: 0x218DA70 Offset: 0x218C070 VA: 0x18218DA70 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1147 : ByteEncoding // TypeDefIndex: 7925
{	// Fields
	private static readonly char[] ToChars; // 0x2B11858

	// Methods

	// RVA: 0x218F540 Offset: 0x218DB40 VA: 0x18218F540
	public void .ctor() { }

	// RVA: 0x218F4D0 Offset: 0x218DAD0 VA: 0x18218F4D0
	private static void .cctor() { }

	// RVA: 0x218E830 Offset: 0x218CE30 VA: 0x18218E830 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1148 : ByteEncoding // TypeDefIndex: 7927
{	// Fields
	private static readonly char[] ToChars; // 0x2800

	// Methods

	// RVA: 0x2190300 Offset: 0x218E900 VA: 0x182190300
	public void .ctor() { }

	// RVA: 0x2190290 Offset: 0x218E890 VA: 0x182190290
	private static void .cctor() { }

	// RVA: 0x218F5F0 Offset: 0x218DBF0 VA: 0x18218F5F0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1149 : ByteEncoding // TypeDefIndex: 7929
{	// Fields
	private static readonly char[] ToChars; // 0x2845

	// Methods

	// RVA: 0x21910C0 Offset: 0x218F6C0 VA: 0x1821910C0
	public void .ctor() { }

	// RVA: 0x2191050 Offset: 0x218F650 VA: 0x182191050
	private static void .cctor() { }

	// RVA: 0x21903B0 Offset: 0x218E9B0 VA: 0x1821903B0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20273 : ByteEncoding // TypeDefIndex: 7931
{	// Fields
	private static readonly char[] ToChars; // 0x2B11160

	// Methods

	// RVA: 0x2191E80 Offset: 0x2190480 VA: 0x182191E80
	public void .ctor() { }

	// RVA: 0x2191E10 Offset: 0x2190410 VA: 0x182191E10
	private static void .cctor() { }

	// RVA: 0x2191170 Offset: 0x218F770 VA: 0x182191170 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20277 : ByteEncoding // TypeDefIndex: 7933
{	// Fields
	private static readonly char[] ToChars; // 0x2850

	// Methods

	// RVA: 0x2192C40 Offset: 0x2191240 VA: 0x182192C40
	public void .ctor() { }

	// RVA: 0x2192BD0 Offset: 0x21911D0 VA: 0x182192BD0
	private static void .cctor() { }

	// RVA: 0x2191F30 Offset: 0x2190530 VA: 0x182191F30 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20278 : ByteEncoding // TypeDefIndex: 7935
{	// Fields
	private static readonly char[] ToChars; // 0x2898

	// Methods

	// RVA: 0x2193A00 Offset: 0x2192000 VA: 0x182193A00
	public void .ctor() { }

	// RVA: 0x2193990 Offset: 0x2191F90 VA: 0x182193990
	private static void .cctor() { }

	// RVA: 0x2192CF0 Offset: 0x21912F0 VA: 0x182192CF0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20280 : ByteEncoding // TypeDefIndex: 7937
{	// Fields
	private static readonly char[] ToChars; // 0x2B11310

	// Methods

	// RVA: 0x21947C0 Offset: 0x2192DC0 VA: 0x1821947C0
	public void .ctor() { }

	// RVA: 0x2194750 Offset: 0x2192D50 VA: 0x182194750
	private static void .cctor() { }

	// RVA: 0x2193AB0 Offset: 0x21920B0 VA: 0x182193AB0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20284 : ByteEncoding // TypeDefIndex: 7939
{	// Fields
	private static readonly char[] ToChars; // 0x28A0

	// Methods

	// RVA: 0x2195580 Offset: 0x2193B80 VA: 0x182195580
	public void .ctor() { }

	// RVA: 0x2195510 Offset: 0x2193B10 VA: 0x182195510
	private static void .cctor() { }

	// RVA: 0x2194870 Offset: 0x2192E70 VA: 0x182194870 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20285 : ByteEncoding // TypeDefIndex: 7941
{	// Fields
	private static readonly char[] ToChars; // 0x28F9

	// Methods

	// RVA: 0x2196340 Offset: 0x2194940 VA: 0x182196340
	public void .ctor() { }

	// RVA: 0x21962D0 Offset: 0x21948D0 VA: 0x1821962D0
	private static void .cctor() { }

	// RVA: 0x2195630 Offset: 0x2193C30 VA: 0x182195630 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20290 : ByteEncoding // TypeDefIndex: 7943
{	// Fields
	private static readonly char[] ToChars; // 0x2B11160

	// Methods

	// RVA: 0x2196CD0 Offset: 0x21952D0 VA: 0x182196CD0
	public void .ctor() { }

	// RVA: 0x2196C60 Offset: 0x2195260 VA: 0x182196C60
	private static void .cctor() { }

	// RVA: 0x21963F0 Offset: 0x21949F0 VA: 0x1821963F0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20297 : ByteEncoding // TypeDefIndex: 7945
{	// Fields
	private static readonly char[] ToChars; // 0x2900

	// Methods

	// RVA: 0x2197A90 Offset: 0x2196090 VA: 0x182197A90
	public void .ctor() { }

	// RVA: 0x2197A20 Offset: 0x2196020 VA: 0x182197A20
	private static void .cctor() { }

	// RVA: 0x2196D80 Offset: 0x2195380 VA: 0x182196D80 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20420 : ByteEncoding // TypeDefIndex: 7947
{	// Fields
	private static readonly char[] ToChars; // 0x2967

	// Methods

	// RVA: 0x21988B0 Offset: 0x2196EB0 VA: 0x1821988B0
	public void .ctor() { }

	// RVA: 0x2198840 Offset: 0x2196E40 VA: 0x182198840
	private static void .cctor() { }

	// RVA: 0x2197B40 Offset: 0x2196140 VA: 0x182197B40 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20424 : ByteEncoding // TypeDefIndex: 7949
{	// Fields
	private static readonly char[] ToChars; // 0x2B112D4

	// Methods

	// RVA: 0x2199350 Offset: 0x2197950 VA: 0x182199350
	public void .ctor() { }

	// RVA: 0x21992E0 Offset: 0x21978E0 VA: 0x1821992E0
	private static void .cctor() { }

	// RVA: 0x2198960 Offset: 0x2196F60 VA: 0x182198960 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20871 : ByteEncoding // TypeDefIndex: 7951
{	// Fields
	private static readonly char[] ToChars; // 0x2970

	// Methods

	// RVA: 0x219A110 Offset: 0x2198710 VA: 0x18219A110
	public void .ctor() { }

	// RVA: 0x219A0A0 Offset: 0x21986A0 VA: 0x18219A0A0
	private static void .cctor() { }

	// RVA: 0x2199400 Offset: 0x2197A00 VA: 0x182199400 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP21025 : ByteEncoding // TypeDefIndex: 7953
{	// Fields
	private static readonly char[] ToChars; // 0x29CC

	// Methods

	// RVA: 0x219ADB0 Offset: 0x21993B0 VA: 0x18219ADB0
	public void .ctor() { }

	// RVA: 0x219AD40 Offset: 0x2199340 VA: 0x18219AD40
	private static void .cctor() { }

	// RVA: 0x219A1C0 Offset: 0x21987C0 VA: 0x18219A1C0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP37 : ByteEncoding // TypeDefIndex: 7955
{	// Fields
	private static readonly char[] ToChars; // 0x2B11180

	// Methods

	// RVA: 0x219BB70 Offset: 0x219A170 VA: 0x18219BB70
	public void .ctor() { }

	// RVA: 0x219BB00 Offset: 0x219A100 VA: 0x18219BB00
	private static void .cctor() { }

	// RVA: 0x219AE60 Offset: 0x2199460 VA: 0x18219AE60 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP500 : ByteEncoding // TypeDefIndex: 7957
{	// Fields
	private static readonly char[] ToChars; // 0x29D0

	// Methods

	// RVA: 0x219C930 Offset: 0x219AF30 VA: 0x18219C930
	public void .ctor() { }

	// RVA: 0x219C8C0 Offset: 0x219AEC0 VA: 0x18219C8C0
	private static void .cctor() { }

	// RVA: 0x219BC20 Offset: 0x219A220 VA: 0x18219BC20 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP708 : ByteEncoding // TypeDefIndex: 7959
{	// Fields
	private static readonly char[] ToChars; // 0x29F8

	// Methods

	// RVA: 0x219CFB0 Offset: 0x219B5B0 VA: 0x18219CFB0
	public void .ctor() { }

	// RVA: 0x219CF40 Offset: 0x219B540 VA: 0x18219CF40
	private static void .cctor() { }

	// RVA: 0x219C9E0 Offset: 0x219AFE0 VA: 0x18219C9E0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP852 : ByteEncoding // TypeDefIndex: 7961
{	// Fields
	private static readonly char[] ToChars; // 0x2B11194

	// Methods

	// RVA: 0x219DE10 Offset: 0x219C410 VA: 0x18219DE10
	public void .ctor() { }

	// RVA: 0x219DDA0 Offset: 0x219C3A0 VA: 0x18219DDA0
	private static void .cctor() { }

	// RVA: 0x219D070 Offset: 0x219B670 VA: 0x18219D070 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP855 : ByteEncoding // TypeDefIndex: 7963
{	// Fields
	private static readonly char[] ToChars; // 0x2A00

	// Methods

	// RVA: 0x219EBB0 Offset: 0x219D1B0 VA: 0x18219EBB0
	public void .ctor() { }

	// RVA: 0x219EB40 Offset: 0x219D140 VA: 0x18219EB40
	private static void .cctor() { }

	// RVA: 0x219DEC0 Offset: 0x219C4C0 VA: 0x18219DEC0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP857 : ByteEncoding // TypeDefIndex: 7965
{	// Fields
	private static readonly char[] ToChars; // 0x2A5C

	// Methods

	// RVA: 0x219F990 Offset: 0x219DF90 VA: 0x18219F990
	public void .ctor() { }

	// RVA: 0x219F920 Offset: 0x219DF20 VA: 0x18219F920
	private static void .cctor() { }

	// RVA: 0x219EC60 Offset: 0x219D260 VA: 0x18219EC60 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP858 : ByteEncoding // TypeDefIndex: 7967
{	// Fields
	private static readonly char[] ToChars; // 0x2B11180

	// Methods

	// RVA: 0x21A07E0 Offset: 0x219EDE0 VA: 0x1821A07E0
	public void .ctor() { }

	// RVA: 0x21A0770 Offset: 0x219ED70 VA: 0x1821A0770
	private static void .cctor() { }

	// RVA: 0x219FA40 Offset: 0x219E040 VA: 0x18219FA40 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP862 : ByteEncoding // TypeDefIndex: 7969
{	// Fields
	private static readonly char[] ToChars; // 0x2A60

	// Methods

	// RVA: 0x21A1510 Offset: 0x219FB10 VA: 0x1821A1510
	public void .ctor() { }

	// RVA: 0x21A14A0 Offset: 0x219FAA0 VA: 0x1821A14A0
	private static void .cctor() { }

	// RVA: 0x21A0890 Offset: 0x219EE90 VA: 0x1821A0890 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP864 : ByteEncoding // TypeDefIndex: 7971
{	// Fields
	private static readonly char[] ToChars; // 0x2AB5

	// Methods

	// RVA: 0x22EA480 Offset: 0x22E8A80 VA: 0x1822EA480
	public void .ctor() { }

	// RVA: 0x22EA410 Offset: 0x22E8A10 VA: 0x1822EA410
	private static void .cctor() { }

	// RVA: 0x22E9720 Offset: 0x22E7D20 VA: 0x1822E9720 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP10000 : ByteEncoding // TypeDefIndex: 7977
{	// Fields
	private static readonly char[] ToChars; // 0x2B11170

	// Methods

	// RVA: 0x22837F0 Offset: 0x2281DF0 VA: 0x1822837F0
	public void .ctor() { }

	// RVA: 0x2283780 Offset: 0x2281D80 VA: 0x182283780
	private static void .cctor() { }

	// RVA: 0x2282DC0 Offset: 0x22813C0 VA: 0x182282DC0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP10079 : ByteEncoding // TypeDefIndex: 7979
{	// Fields
	private static readonly char[] ToChars; // 0x2AC0

	// Methods

	// RVA: 0x2284280 Offset: 0x2282880 VA: 0x182284280
	public void .ctor() { }

	// RVA: 0x2284210 Offset: 0x2282810 VA: 0x182284210
	private static void .cctor() { }

	// RVA: 0x22838A0 Offset: 0x2281EA0 VA: 0x1822838A0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1250 : ByteEncoding // TypeDefIndex: 7981
{	// Fields
	private static readonly char[] ToChars; // 0x2B27

	// Methods

	// RVA: 0x2284A80 Offset: 0x2283080 VA: 0x182284A80
	public void .ctor() { }

	// RVA: 0x2284A10 Offset: 0x2283010 VA: 0x182284A10
	private static void .cctor() { }

	// RVA: 0x2284330 Offset: 0x2282930 VA: 0x182284330 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1252 : ByteEncoding // TypeDefIndex: 7983
{	// Fields
	private static readonly char[] ToChars; // 0x2B11180

	// Methods

	// RVA: 0x2284FC0 Offset: 0x22835C0 VA: 0x182284FC0
	public void .ctor() { }

	// RVA: 0x2284F50 Offset: 0x2283550 VA: 0x182284F50
	private static void .cctor() { }

	// RVA: 0x2284B40 Offset: 0x2283140 VA: 0x182284B40 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1253 : ByteEncoding // TypeDefIndex: 7985
{	// Fields
	private static readonly char[] ToChars; // 0x2B30

	// Methods

	// RVA: 0x22854D0 Offset: 0x2283AD0 VA: 0x1822854D0
	public void .ctor() { }

	// RVA: 0x2285460 Offset: 0x2283A60 VA: 0x182285460
	private static void .cctor() { }

	// RVA: 0x2285080 Offset: 0x2283680 VA: 0x182285080 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28592 : ByteEncoding // TypeDefIndex: 7987
{	// Fields
	private static readonly char[] ToChars; // 0x2B4F

	// Methods

	// RVA: 0x22860C0 Offset: 0x22846C0 VA: 0x1822860C0
	public void .ctor() { }

	// RVA: 0x2286050 Offset: 0x2284650 VA: 0x182286050
	private static void .cctor() { }

	// RVA: 0x2285590 Offset: 0x2283B90 VA: 0x182285590 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28593 : ByteEncoding // TypeDefIndex: 7989
{	// Fields
	private static readonly char[] ToChars; // 0x2B11168

	// Methods

	// RVA: 0x2286580 Offset: 0x2284B80 VA: 0x182286580
	public void .ctor() { }

	// RVA: 0x2286510 Offset: 0x2284B10 VA: 0x182286510
	private static void .cctor() { }

	// RVA: 0x2286170 Offset: 0x2284770 VA: 0x182286170 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28597 : ByteEncoding // TypeDefIndex: 7991
{	// Fields
	private static readonly char[] ToChars; // 0x2B50

	// Methods

	// RVA: 0x2286900 Offset: 0x2284F00 VA: 0x182286900
	public void .ctor() { }

	// RVA: 0x2286890 Offset: 0x2284E90 VA: 0x182286890
	private static void .cctor() { }

	// RVA: 0x2286630 Offset: 0x2284C30 VA: 0x182286630 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28605 : ByteEncoding // TypeDefIndex: 7993
{	// Fields
	private static readonly char[] ToChars; // 0x2BC1

	// Methods

	// RVA: 0x2286C60 Offset: 0x2285260 VA: 0x182286C60
	public void .ctor() { }

	// RVA: 0x2286BF0 Offset: 0x22851F0 VA: 0x182286BF0
	private static void .cctor() { }

	// RVA: 0x22869B0 Offset: 0x2284FB0 VA: 0x1822869B0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP437 : ByteEncoding // TypeDefIndex: 7995
{	// Fields
	private static readonly char[] ToChars; // 0x2B112E4

	// Methods

	// RVA: 0x2288400 Offset: 0x2286A00 VA: 0x182288400
	public void .ctor() { }

	// RVA: 0x2288390 Offset: 0x2286990 VA: 0x182288390
	private static void .cctor() { }

	// RVA: 0x2286D10 Offset: 0x2285310 VA: 0x182286D10 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP850 : ByteEncoding // TypeDefIndex: 7997
{	// Fields
	private static readonly char[] ToChars; // 0x2BD0

	// Methods

	// RVA: 0x2289250 Offset: 0x2287850 VA: 0x182289250
	public void .ctor() { }

	// RVA: 0x22891E0 Offset: 0x22877E0 VA: 0x1822891E0
	private static void .cctor() { }

	// RVA: 0x22884B0 Offset: 0x2286AB0 VA: 0x1822884B0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP860 : ByteEncoding // TypeDefIndex: 7999
{	// Fields
	private static readonly char[] ToChars; // 0x2C22

	// Methods

	// RVA: 0x228A0B0 Offset: 0x22886B0 VA: 0x18228A0B0
	public void .ctor() { }

	// RVA: 0x228A040 Offset: 0x2288640 VA: 0x18228A040
	private static void .cctor() { }

	// RVA: 0x2289300 Offset: 0x2287900 VA: 0x182289300 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP861 : ByteEncoding // TypeDefIndex: 8001
{	// Fields
	private static readonly char[] ToChars; // 0x2B11240

	// Methods

	// RVA: 0x228AF10 Offset: 0x2289510 VA: 0x18228AF10
	public void .ctor() { }

	// RVA: 0x228AEA0 Offset: 0x22894A0 VA: 0x18228AEA0
	private static void .cctor() { }

	// RVA: 0x228A160 Offset: 0x2288760 VA: 0x18228A160 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP863 : ByteEncoding // TypeDefIndex: 8003
{	// Fields
	private static readonly char[] ToChars; // 0x2C30

	// Methods

	// RVA: 0x228BD60 Offset: 0x228A360 VA: 0x18228BD60
	public void .ctor() { }

	// RVA: 0x228BCF0 Offset: 0x228A2F0 VA: 0x18228BCF0
	private static void .cctor() { }

	// RVA: 0x228AFC0 Offset: 0x22895C0 VA: 0x18228AFC0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP865 : ByteEncoding // TypeDefIndex: 8005
{	// Fields
	private static readonly char[] ToChars; // 0x2C96

	// Methods

	// RVA: 0x228CBC0 Offset: 0x228B1C0 VA: 0x18228CBC0
	public void .ctor() { }

	// RVA: 0x228CB50 Offset: 0x228B150 VA: 0x18228CB50
	private static void .cctor() { }

	// RVA: 0x228BE10 Offset: 0x228A410 VA: 0x18228BE10 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

