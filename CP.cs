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

	// RVA: 0x224C650 Offset: 0x224AC50 VA: 0x18224C650
	public void .ctor() { }

	// RVA: 0x224B9B0 Offset: 0x2249FB0 VA: 0x18224B9B0 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x224BBC0 Offset: 0x224A1C0 VA: 0x18224BBC0 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x224C260 Offset: 0x224A860 VA: 0x18224C260 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224C3C0 Offset: 0x224A9C0 VA: 0x18224C3C0 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224C550 Offset: 0x224AB50 VA: 0x18224C550 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x224C5D0 Offset: 0x224ABD0 VA: 0x18224C5D0 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x224C4B0 Offset: 0x224AAB0 VA: 0x18224C4B0 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x224C660 Offset: 0x224AC60 VA: 0x18224C660 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224C690 Offset: 0x224AC90 VA: 0x18224C690 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224C6C0 Offset: 0x224ACC0 VA: 0x18224C6C0 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 15
	public override bool get_IsMailNewsSave() { }

	// RVA: 0x224C6F0 Offset: 0x224ACF0 VA: 0x18224C6F0 Slot: 10
	public override string get_WebName() { }

	// RVA: 0x224C720 Offset: 0x224AD20 VA: 0x18224C720 Slot: 11
	public override int get_WindowsCodePage() { }

}

internal sealed class CP932Decoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7798
{	// Fields
	private JISConvert convert; // 0x28
	private int last_byte_count; // 0x30
	private int last_byte_chars; // 0x34

	// Methods

	// RVA: 0x224B960 Offset: 0x2249F60 VA: 0x18224B960
	public void .ctor(JISConvert convert) { }

	// RVA: 0x224B4A0 Offset: 0x2249AA0 VA: 0x18224B4A0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224B3C0 Offset: 0x22499C0 VA: 0x18224B3C0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	// RVA: 0x224B560 Offset: 0x2249B60 VA: 0x18224B560 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224B590 Offset: 0x2249B90 VA: 0x18224B590 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

}

public class CP50220 : ISO2022JPEncoding // TypeDefIndex: 7800
{	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x2249DC0 Offset: 0x22483C0 VA: 0x182249DC0
	public void .ctor() { }

	// RVA: 0x2249DF0 Offset: 0x22483F0 VA: 0x182249DF0 Slot: 8
	public override string get_EncodingName() { }

}

public class CP50221 : ISO2022JPEncoding // TypeDefIndex: 7801
{	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x2249E20 Offset: 0x2248420 VA: 0x182249E20
	public void .ctor() { }

	// RVA: 0x2249E50 Offset: 0x2248450 VA: 0x182249E50 Slot: 8
	public override string get_EncodingName() { }

}

public class CP50222 : ISO2022JPEncoding // TypeDefIndex: 7802
{	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x2249E80 Offset: 0x2248480 VA: 0x182249E80
	public void .ctor() { }

	// RVA: 0x2249EB0 Offset: 0x22484B0 VA: 0x182249EB0 Slot: 8
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

	// RVA: 0x224B1D0 Offset: 0x22497D0 VA: 0x18224B1D0
	public void .ctor() { }

	// RVA: 0x224AD40 Offset: 0x2249340 VA: 0x18224AD40 Slot: 19
	public override int GetByteCount(char[] chars, int index, int length) { }

	// RVA: 0x224ACA0 Offset: 0x22492A0 VA: 0x18224ACA0 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x224ADF0 Offset: 0x22493F0 VA: 0x18224ADF0 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x224AEB0 Offset: 0x22494B0 VA: 0x18224AEB0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224AF50 Offset: 0x2249550 VA: 0x18224AF50 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224B0D0 Offset: 0x22496D0 VA: 0x18224B0D0 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x224B150 Offset: 0x2249750 VA: 0x18224B150 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x224B070 Offset: 0x2249670 VA: 0x18224B070 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x224B010 Offset: 0x2249610 VA: 0x18224B010 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x224B1F0 Offset: 0x22497F0 VA: 0x18224B1F0 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224B220 Offset: 0x2249820 VA: 0x18224B220 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224B250 Offset: 0x2249850 VA: 0x18224B250 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 15
	public override bool get_IsMailNewsSave() { }

	// RVA: 0x224B280 Offset: 0x2249880 VA: 0x18224B280 Slot: 10
	public override string get_WebName() { }

}

public class CP51932Encoder : MonoEncoder // TypeDefIndex: 7809
{	// Methods

	// RVA: 0x224AC90 Offset: 0x2249290 VA: 0x18224AC90
	public void .ctor(MonoEncoding encoding) { }

	// RVA: 0x224A680 Offset: 0x2248C80 VA: 0x18224A680 Slot: 11
	public override int GetByteCountImpl(char* chars, int count, bool refresh) { }

	// RVA: 0x224A890 Offset: 0x2248E90 VA: 0x18224A890 Slot: 12
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool refresh) { }

}

internal class CP51932Decoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7810
{	// Fields
	private int last_count; // 0x28
	private int last_bytes; // 0x2C

	// Methods

	// RVA: 0x224A650 Offset: 0x2248C50 VA: 0x18224A650
	public void .ctor() { }

	// RVA: 0xE4D900 Offset: 0xE4BF00 VA: 0x180E4D900 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x2249EE0 Offset: 0x22484E0 VA: 0x182249EE0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	// RVA: 0x18ACF50 Offset: 0x18AB550 VA: 0x1818ACF50 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224A120 Offset: 0x2248720 VA: 0x18224A120 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

	// RVA: 0x224A5E0 Offset: 0x2248BE0 VA: 0x18224A5E0
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

	// RVA: 0x224D1A0 Offset: 0x224B7A0 VA: 0x18224D1A0
	public void .ctor() { }

	// RVA: 0x224D0C0 Offset: 0x224B6C0 VA: 0x18224D0C0 Slot: 48
	internal override DbcsConvert GetConvert() { }

	// RVA: 0x224CD20 Offset: 0x224B320 VA: 0x18224CD20 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x224CE10 Offset: 0x224B410 VA: 0x18224CE10 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x224CFE0 Offset: 0x224B5E0 VA: 0x18224CFE0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224D050 Offset: 0x224B650 VA: 0x18224D050 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224D120 Offset: 0x224B720 VA: 0x18224D120 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x224D1B0 Offset: 0x224B7B0 VA: 0x18224D1B0 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224D1E0 Offset: 0x224B7E0 VA: 0x18224D1E0 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224D210 Offset: 0x224B810 VA: 0x18224D210 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 15
	public override bool get_IsMailNewsSave() { }

	// RVA: 0x224D240 Offset: 0x224B840 VA: 0x18224D240 Slot: 10
	public override string get_WebName() { }

}

internal sealed class CP936Decoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7813
{	// Fields
	private int last_byte_count; // 0x28
	private int last_byte_bytes; // 0x2C

	// Methods

	// RVA: 0x15C0FC0 Offset: 0x15BF5C0 VA: 0x1815C0FC0
	public void .ctor(DbcsConvert convert) { }

	// RVA: 0x224C730 Offset: 0x224AD30 VA: 0x18224C730 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224C7F0 Offset: 0x224ADF0 VA: 0x18224C7F0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	// RVA: 0x224C8C0 Offset: 0x224AEC0 VA: 0x18224C8C0 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224CAD0 Offset: 0x224B0D0 VA: 0x18224CAD0 Slot: 9
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

	// RVA: 0x224D270 Offset: 0x224B870 VA: 0x18224D270
	public void .ctor() { }

	// RVA: 0x224D2A0 Offset: 0x224B8A0 VA: 0x18224D2A0 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224D2D0 Offset: 0x224B8D0 VA: 0x18224D2D0 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224D300 Offset: 0x224B900 VA: 0x18224D300 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x224D330 Offset: 0x224B930 VA: 0x18224D330 Slot: 10
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

	// RVA: 0x224B2B0 Offset: 0x22498B0 VA: 0x18224B2B0
	public void .ctor() { }

	// RVA: 0x224B2E0 Offset: 0x22498E0 VA: 0x18224B2E0 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224B310 Offset: 0x2249910 VA: 0x18224B310 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224B340 Offset: 0x2249940 VA: 0x18224B340 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x224B370 Offset: 0x2249970 VA: 0x18224B370 Slot: 10
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

	// RVA: 0x224DC80 Offset: 0x224C280 VA: 0x18224DC80
	public void .ctor() { }

	// RVA: 0x224DBA0 Offset: 0x224C1A0 VA: 0x18224DBA0 Slot: 48
	internal override DbcsConvert GetConvert() { }

	// RVA: 0x224DAB0 Offset: 0x224C0B0 VA: 0x18224DAB0 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x224CE10 Offset: 0x224B410 VA: 0x18224CE10 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x224D050 Offset: 0x224B650 VA: 0x18224D050 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224DC00 Offset: 0x224C200 VA: 0x18224DC00 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x224DC90 Offset: 0x224C290 VA: 0x18224DC90 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224DCC0 Offset: 0x224C2C0 VA: 0x18224DCC0 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224DCF0 Offset: 0x224C2F0 VA: 0x18224DCF0 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x224DD20 Offset: 0x224C320 VA: 0x18224DD20 Slot: 10
	public override string get_WebName() { }

}

private sealed class CP950.CP950Decoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7822
{	// Fields
	private int last_byte_count; // 0x28
	private int last_byte_conv; // 0x2C

	// Methods

	// RVA: 0x15C0FC0 Offset: 0x15BF5C0 VA: 0x1815C0FC0
	public void .ctor(DbcsConvert convert) { }

	// RVA: 0x224D360 Offset: 0x224B960 VA: 0x18224D360 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224D4A0 Offset: 0x224BAA0 VA: 0x18224D4A0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	// RVA: 0x224D5F0 Offset: 0x224BBF0 VA: 0x18224D5F0 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224D830 Offset: 0x224BE30 VA: 0x18224D830 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

}

public class CP54936 : GB18030Encoding // TypeDefIndex: 7829
{	// Methods

	// RVA: 0x224B3A0 Offset: 0x22499A0 VA: 0x18224B3A0
	public void .ctor() { }

}

public class CP1254 : ByteEncoding // TypeDefIndex: 7840
{	// Fields
	private static readonly char[] ToChars; // 0x2356

	// Methods

	// RVA: 0x2305590 Offset: 0x2303B90 VA: 0x182305590
	public void .ctor() { }

	// RVA: 0x2305520 Offset: 0x2303B20 VA: 0x182305520
	private static void .cctor() { }

	// RVA: 0x23050C0 Offset: 0x23036C0 VA: 0x1823050C0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1255 : ByteEncoding // TypeDefIndex: 7842
{	// Fields
	private static readonly char[] ToChars; // 0x2B111C0

	// Methods

	// RVA: 0x2305AD0 Offset: 0x23040D0 VA: 0x182305AD0
	public void .ctor() { }

	// RVA: 0x2305A60 Offset: 0x2304060 VA: 0x182305A60
	private static void .cctor() { }

	// RVA: 0x2305650 Offset: 0x2303C50 VA: 0x182305650 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1256 : ByteEncoding // TypeDefIndex: 7844
{	// Fields
	private static readonly char[] ToChars; // 0x2360

	// Methods

	// RVA: 0x2306630 Offset: 0x2304C30 VA: 0x182306630
	public void .ctor() { }

	// RVA: 0x23065C0 Offset: 0x2304BC0 VA: 0x1823065C0
	private static void .cctor() { }

	// RVA: 0x2305B80 Offset: 0x2304180 VA: 0x182305B80 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28596 : ByteEncoding // TypeDefIndex: 7846
{	// Fields
	private static readonly char[] ToChars; // 0x2391

	// Methods

	// RVA: 0x2307110 Offset: 0x2305710 VA: 0x182307110
	public void .ctor() { }

	// RVA: 0x23070A0 Offset: 0x23056A0 VA: 0x1823070A0
	private static void .cctor() { }

	// RVA: 0x23066E0 Offset: 0x2304CE0 VA: 0x1823066E0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28598 : ByteEncoding // TypeDefIndex: 7848
{	// Fields
	private static readonly char[] ToChars; // 0x2B111F4

	// Methods

	// RVA: 0x2307440 Offset: 0x2305A40 VA: 0x182307440
	public void .ctor() { }

	// RVA: 0x23073D0 Offset: 0x23059D0 VA: 0x1823073D0
	private static void .cctor() { }

	// RVA: 0x23071C0 Offset: 0x23057C0 VA: 0x1823071C0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28599 : ByteEncoding // TypeDefIndex: 7850
{	// Fields
	private static readonly char[] ToChars; // 0x23A0

	// Methods

	// RVA: 0x2307770 Offset: 0x2305D70 VA: 0x182307770
	public void .ctor() { }

	// RVA: 0x2307700 Offset: 0x2305D00 VA: 0x182307700
	private static void .cctor() { }

	// RVA: 0x23074F0 Offset: 0x2305AF0 VA: 0x1823074F0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP38598 : ByteEncoding // TypeDefIndex: 7852
{	// Fields
	private static readonly char[] ToChars; // 0x2417

	// Methods

	// RVA: 0x2307890 Offset: 0x2305E90 VA: 0x182307890
	public void .ctor() { }

	// RVA: 0x2307820 Offset: 0x2305E20 VA: 0x182307820
	private static void .cctor() { }

	// RVA: 0x23071C0 Offset: 0x23057C0 VA: 0x1823071C0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1251 : ByteEncoding // TypeDefIndex: 7858
{	// Fields
	private static readonly char[] ToChars; // 0x2B11370

	// Methods

	// RVA: 0x22F1650 Offset: 0x22EFC50 VA: 0x1822F1650
	public void .ctor() { }

	// RVA: 0x22F15E0 Offset: 0x22EFBE0 VA: 0x1822F15E0
	private static void .cctor() { }

	// RVA: 0x22F10A0 Offset: 0x22EF6A0 VA: 0x1822F10A0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1257 : ByteEncoding // TypeDefIndex: 7860
{	// Fields
	private static readonly char[] ToChars; // 0x2420

	// Methods

	// RVA: 0x22F1F00 Offset: 0x22F0500 VA: 0x1822F1F00
	public void .ctor() { }

	// RVA: 0x22F1E90 Offset: 0x22F0490 VA: 0x1822F1E90
	private static void .cctor() { }

	// RVA: 0x22F1710 Offset: 0x22EFD10 VA: 0x1822F1710 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1258 : ByteEncoding // TypeDefIndex: 7862
{	// Fields
	private static readonly char[] ToChars; // 0x24B7

	// Methods

	// RVA: 0x22F24B0 Offset: 0x22F0AB0 VA: 0x1822F24B0
	public void .ctor() { }

	// RVA: 0x22F2440 Offset: 0x22F0A40 VA: 0x1822F2440
	private static void .cctor() { }

	// RVA: 0x22F1FC0 Offset: 0x22F05C0 VA: 0x1822F1FC0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20866 : ByteEncoding // TypeDefIndex: 7864
{	// Fields
	private static readonly char[] ToChars; // 0x2B113D0

	// Methods

	// RVA: 0x22F2CE0 Offset: 0x22F12E0 VA: 0x1822F2CE0
	public void .ctor() { }

	// RVA: 0x22F2C70 Offset: 0x22F1270 VA: 0x1822F2C70
	private static void .cctor() { }

	// RVA: 0x22F2560 Offset: 0x22F0B60 VA: 0x1822F2560 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP21866 : ByteEncoding // TypeDefIndex: 7866
{	// Fields
	private static readonly char[] ToChars; // 0x24C0

	// Methods

	// RVA: 0x22F35F0 Offset: 0x22F1BF0 VA: 0x1822F35F0
	public void .ctor() { }

	// RVA: 0x22F3580 Offset: 0x22F1B80 VA: 0x1822F3580
	private static void .cctor() { }

	// RVA: 0x22F2D90 Offset: 0x22F1390 VA: 0x1822F2D90 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28594 : ByteEncoding // TypeDefIndex: 7868
{	// Fields
	private static readonly char[] ToChars; // 0x2527

	// Methods

	// RVA: 0x22F3C90 Offset: 0x22F2290 VA: 0x1822F3C90
	public void .ctor() { }

	// RVA: 0x22F3C20 Offset: 0x22F2220 VA: 0x1822F3C20
	private static void .cctor() { }

	// RVA: 0x22F36A0 Offset: 0x22F1CA0 VA: 0x1822F36A0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28595 : ByteEncoding // TypeDefIndex: 7870
{	// Fields
	private static readonly char[] ToChars; // 0x2B111D0

	// Methods

	// RVA: 0x22F3FB0 Offset: 0x22F25B0 VA: 0x1822F3FB0
	public void .ctor() { }

	// RVA: 0x22F3F40 Offset: 0x22F2540 VA: 0x1822F3F40
	private static void .cctor() { }

	// RVA: 0x22F3D40 Offset: 0x22F2340 VA: 0x1822F3D40 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP57002 : ISCIIEncoding // TypeDefIndex: 7873
{	// Methods

	// RVA: 0x22F4060 Offset: 0x22F2660 VA: 0x1822F4060
	public void .ctor() { }

}

public class CP57003 : ISCIIEncoding // TypeDefIndex: 7874
{	// Methods

	// RVA: 0x22F40E0 Offset: 0x22F26E0 VA: 0x1822F40E0
	public void .ctor() { }

}

public class CP57004 : ISCIIEncoding // TypeDefIndex: 7875
{	// Methods

	// RVA: 0x22F4160 Offset: 0x22F2760 VA: 0x1822F4160
	public void .ctor() { }

}

public class CP57005 : ISCIIEncoding // TypeDefIndex: 7876
{	// Methods

	// RVA: 0x22F41E0 Offset: 0x22F27E0 VA: 0x1822F41E0
	public void .ctor() { }

}

public class CP57006 : ISCIIEncoding // TypeDefIndex: 7877
{	// Methods

	// RVA: 0x22F4260 Offset: 0x22F2860 VA: 0x1822F4260
	public void .ctor() { }

}

public class CP57007 : ISCIIEncoding // TypeDefIndex: 7878
{	// Methods

	// RVA: 0x22F42E0 Offset: 0x22F28E0 VA: 0x1822F42E0
	public void .ctor() { }

}

public class CP57008 : ISCIIEncoding // TypeDefIndex: 7879
{	// Methods

	// RVA: 0x22F4360 Offset: 0x22F2960 VA: 0x1822F4360
	public void .ctor() { }

}

public class CP57009 : ISCIIEncoding // TypeDefIndex: 7880
{	// Methods

	// RVA: 0x22F43E0 Offset: 0x22F29E0 VA: 0x1822F43E0
	public void .ctor() { }

}

public class CP57010 : ISCIIEncoding // TypeDefIndex: 7881
{	// Methods

	// RVA: 0x22F4460 Offset: 0x22F2A60 VA: 0x1822F4460
	public void .ctor() { }

}

public class CP57011 : ISCIIEncoding // TypeDefIndex: 7882
{	// Methods

	// RVA: 0x22F44E0 Offset: 0x22F2AE0 VA: 0x1822F44E0
	public void .ctor() { }

}

public class CP874 : ByteEncoding // TypeDefIndex: 7893
{	// Fields
	private static readonly char[] ToChars; // 0x2530

	// Methods

	// RVA: 0x22F48A0 Offset: 0x22F2EA0 VA: 0x1822F48A0
	public void .ctor() { }

	// RVA: 0x22F4830 Offset: 0x22F2E30 VA: 0x1822F4830
	private static void .cctor() { }

	// RVA: 0x22F4560 Offset: 0x22F2B60 VA: 0x1822F4560 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP866 : ByteEncoding // TypeDefIndex: 7899
{	// Fields
	private static readonly char[] ToChars; // 0x2578

	// Methods

	// RVA: 0x22EB020 Offset: 0x22E9620 VA: 0x1822EB020
	public void .ctor() { }

	// RVA: 0x22EAFB0 Offset: 0x22E95B0 VA: 0x1822EAFB0
	private static void .cctor() { }

	// RVA: 0x22EA630 Offset: 0x22E8C30 VA: 0x1822EA630 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1026 : ByteEncoding // TypeDefIndex: 7901
{	// Fields
	private static readonly char[] ToChars; // 0x2B114A0

	// Methods

	// RVA: 0x2187A90 Offset: 0x2186090 VA: 0x182187A90
	public void .ctor() { }

	// RVA: 0x2187A20 Offset: 0x2186020 VA: 0x182187A20
	private static void .cctor() { }

	// RVA: 0x2186D30 Offset: 0x2185330 VA: 0x182186D30 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP869 : ByteEncoding // TypeDefIndex: 7903
{	// Fields
	private static readonly char[] ToChars; // 0x2580

	// Methods

	// RVA: 0x22EBC40 Offset: 0x22EA240 VA: 0x1822EBC40
	public void .ctor() { }

	// RVA: 0x22EBBD0 Offset: 0x22EA1D0 VA: 0x1822EBBD0
	private static void .cctor() { }

	// RVA: 0x22EB0D0 Offset: 0x22E96D0 VA: 0x1822EB0D0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP870 : ByteEncoding // TypeDefIndex: 7905
{	// Fields
	private static readonly char[] ToChars; // 0x25B9

	// Methods

	// RVA: 0x22ECAA0 Offset: 0x22EB0A0 VA: 0x1822ECAA0
	public void .ctor() { }

	// RVA: 0x22ECA30 Offset: 0x22EB030 VA: 0x1822ECA30
	private static void .cctor() { }

	// RVA: 0x22EBCF0 Offset: 0x22EA2F0 VA: 0x1822EBCF0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP875 : ByteEncoding // TypeDefIndex: 7907
{	// Fields
	private static readonly char[] ToChars; // 0x2B111E0

	// Methods

	// RVA: 0x22ED640 Offset: 0x22EBC40 VA: 0x1822ED640
	public void .ctor() { }

	// RVA: 0x22ED5D0 Offset: 0x22EBBD0 VA: 0x1822ED5D0
	private static void .cctor() { }

	// RVA: 0x22ECB50 Offset: 0x22EB150 VA: 0x1822ECB50 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1047 : ByteEncoding // TypeDefIndex: 7909
{	// Fields
	private static readonly char[] ToChars; // 0x25C0

	// Methods

	// RVA: 0x2188840 Offset: 0x2186E40 VA: 0x182188840
	public void .ctor() { }

	// RVA: 0x21887D0 Offset: 0x2186DD0 VA: 0x1821887D0
	private static void .cctor() { }

	// RVA: 0x2187B40 Offset: 0x2186140 VA: 0x182187B40 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1140 : ByteEncoding // TypeDefIndex: 7911
{	// Fields
	private static readonly char[] ToChars; // 0x25DD

	// Methods

	// RVA: 0x2189600 Offset: 0x2187C00 VA: 0x182189600
	public void .ctor() { }

	// RVA: 0x2189590 Offset: 0x2187B90 VA: 0x182189590
	private static void .cctor() { }

	// RVA: 0x21888F0 Offset: 0x2186EF0 VA: 0x1821888F0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1141 : ByteEncoding // TypeDefIndex: 7913
{	// Fields
	private static readonly char[] ToChars; // 0x2B111C8

	// Methods

	// RVA: 0x218A3C0 Offset: 0x21889C0 VA: 0x18218A3C0
	public void .ctor() { }

	// RVA: 0x218A350 Offset: 0x2188950 VA: 0x18218A350
	private static void .cctor() { }

	// RVA: 0x21896B0 Offset: 0x2187CB0 VA: 0x1821896B0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1142 : ByteEncoding // TypeDefIndex: 7915
{	// Fields
	private static readonly char[] ToChars; // 0x25E0

	// Methods

	// RVA: 0x218B180 Offset: 0x2189780 VA: 0x18218B180
	public void .ctor() { }

	// RVA: 0x218B110 Offset: 0x2189710 VA: 0x18218B110
	private static void .cctor() { }

	// RVA: 0x218A470 Offset: 0x2188A70 VA: 0x18218A470 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1143 : ByteEncoding // TypeDefIndex: 7917
{	// Fields
	private static readonly char[] ToChars; // 0x2649

	// Methods

	// RVA: 0x218BF40 Offset: 0x218A540 VA: 0x18218BF40
	public void .ctor() { }

	// RVA: 0x218BED0 Offset: 0x218A4D0 VA: 0x18218BED0
	private static void .cctor() { }

	// RVA: 0x218B230 Offset: 0x2189830 VA: 0x18218B230 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1144 : ByteEncoding // TypeDefIndex: 7919
{	// Fields
	private static readonly char[] ToChars; // 0x2B1133C

	// Methods

	// RVA: 0x218CD00 Offset: 0x218B300 VA: 0x18218CD00
	public void .ctor() { }

	// RVA: 0x218CC90 Offset: 0x218B290 VA: 0x18218CC90
	private static void .cctor() { }

	// RVA: 0x218BFF0 Offset: 0x218A5F0 VA: 0x18218BFF0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1145 : ByteEncoding // TypeDefIndex: 7921
{	// Fields
	private static readonly char[] ToChars; // 0x2650

	// Methods

	// RVA: 0x218DAC0 Offset: 0x218C0C0 VA: 0x18218DAC0
	public void .ctor() { }

	// RVA: 0x218DA50 Offset: 0x218C050 VA: 0x18218DA50
	private static void .cctor() { }

	// RVA: 0x218CDB0 Offset: 0x218B3B0 VA: 0x18218CDB0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1146 : ByteEncoding // TypeDefIndex: 7923
{	// Fields
	private static readonly char[] ToChars; // 0x27F7

	// Methods

	// RVA: 0x218E880 Offset: 0x218CE80 VA: 0x18218E880
	public void .ctor() { }

	// RVA: 0x218E810 Offset: 0x218CE10 VA: 0x18218E810
	private static void .cctor() { }

	// RVA: 0x218DB70 Offset: 0x218C170 VA: 0x18218DB70 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1147 : ByteEncoding // TypeDefIndex: 7925
{	// Fields
	private static readonly char[] ToChars; // 0x2B118B8

	// Methods

	// RVA: 0x218F640 Offset: 0x218DC40 VA: 0x18218F640
	public void .ctor() { }

	// RVA: 0x218F5D0 Offset: 0x218DBD0 VA: 0x18218F5D0
	private static void .cctor() { }

	// RVA: 0x218E930 Offset: 0x218CF30 VA: 0x18218E930 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1148 : ByteEncoding // TypeDefIndex: 7927
{	// Fields
	private static readonly char[] ToChars; // 0x2800

	// Methods

	// RVA: 0x2190400 Offset: 0x218EA00 VA: 0x182190400
	public void .ctor() { }

	// RVA: 0x2190390 Offset: 0x218E990 VA: 0x182190390
	private static void .cctor() { }

	// RVA: 0x218F6F0 Offset: 0x218DCF0 VA: 0x18218F6F0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1149 : ByteEncoding // TypeDefIndex: 7929
{	// Fields
	private static readonly char[] ToChars; // 0x2845

	// Methods

	// RVA: 0x21911C0 Offset: 0x218F7C0 VA: 0x1821911C0
	public void .ctor() { }

	// RVA: 0x2191150 Offset: 0x218F750 VA: 0x182191150
	private static void .cctor() { }

	// RVA: 0x21904B0 Offset: 0x218EAB0 VA: 0x1821904B0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20273 : ByteEncoding // TypeDefIndex: 7931
{	// Fields
	private static readonly char[] ToChars; // 0x2B111C0

	// Methods

	// RVA: 0x2191F80 Offset: 0x2190580 VA: 0x182191F80
	public void .ctor() { }

	// RVA: 0x2191F10 Offset: 0x2190510 VA: 0x182191F10
	private static void .cctor() { }

	// RVA: 0x2191270 Offset: 0x218F870 VA: 0x182191270 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20277 : ByteEncoding // TypeDefIndex: 7933
{	// Fields
	private static readonly char[] ToChars; // 0x2850

	// Methods

	// RVA: 0x2192D40 Offset: 0x2191340 VA: 0x182192D40
	public void .ctor() { }

	// RVA: 0x2192CD0 Offset: 0x21912D0 VA: 0x182192CD0
	private static void .cctor() { }

	// RVA: 0x2192030 Offset: 0x2190630 VA: 0x182192030 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20278 : ByteEncoding // TypeDefIndex: 7935
{	// Fields
	private static readonly char[] ToChars; // 0x2898

	// Methods

	// RVA: 0x2193B00 Offset: 0x2192100 VA: 0x182193B00
	public void .ctor() { }

	// RVA: 0x2193A90 Offset: 0x2192090 VA: 0x182193A90
	private static void .cctor() { }

	// RVA: 0x2192DF0 Offset: 0x21913F0 VA: 0x182192DF0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20280 : ByteEncoding // TypeDefIndex: 7937
{	// Fields
	private static readonly char[] ToChars; // 0x2B11370

	// Methods

	// RVA: 0x21948C0 Offset: 0x2192EC0 VA: 0x1821948C0
	public void .ctor() { }

	// RVA: 0x2194850 Offset: 0x2192E50 VA: 0x182194850
	private static void .cctor() { }

	// RVA: 0x2193BB0 Offset: 0x21921B0 VA: 0x182193BB0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20284 : ByteEncoding // TypeDefIndex: 7939
{	// Fields
	private static readonly char[] ToChars; // 0x28A0

	// Methods

	// RVA: 0x2195680 Offset: 0x2193C80 VA: 0x182195680
	public void .ctor() { }

	// RVA: 0x2195610 Offset: 0x2193C10 VA: 0x182195610
	private static void .cctor() { }

	// RVA: 0x2194970 Offset: 0x2192F70 VA: 0x182194970 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20285 : ByteEncoding // TypeDefIndex: 7941
{	// Fields
	private static readonly char[] ToChars; // 0x28F9

	// Methods

	// RVA: 0x2196440 Offset: 0x2194A40 VA: 0x182196440
	public void .ctor() { }

	// RVA: 0x21963D0 Offset: 0x21949D0 VA: 0x1821963D0
	private static void .cctor() { }

	// RVA: 0x2195730 Offset: 0x2193D30 VA: 0x182195730 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20290 : ByteEncoding // TypeDefIndex: 7943
{	// Fields
	private static readonly char[] ToChars; // 0x2B111C0

	// Methods

	// RVA: 0x2196DD0 Offset: 0x21953D0 VA: 0x182196DD0
	public void .ctor() { }

	// RVA: 0x2196D60 Offset: 0x2195360 VA: 0x182196D60
	private static void .cctor() { }

	// RVA: 0x21964F0 Offset: 0x2194AF0 VA: 0x1821964F0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20297 : ByteEncoding // TypeDefIndex: 7945
{	// Fields
	private static readonly char[] ToChars; // 0x2900

	// Methods

	// RVA: 0x2197B90 Offset: 0x2196190 VA: 0x182197B90
	public void .ctor() { }

	// RVA: 0x2197B20 Offset: 0x2196120 VA: 0x182197B20
	private static void .cctor() { }

	// RVA: 0x2196E80 Offset: 0x2195480 VA: 0x182196E80 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20420 : ByteEncoding // TypeDefIndex: 7947
{	// Fields
	private static readonly char[] ToChars; // 0x2967

	// Methods

	// RVA: 0x21989B0 Offset: 0x2196FB0 VA: 0x1821989B0
	public void .ctor() { }

	// RVA: 0x2198940 Offset: 0x2196F40 VA: 0x182198940
	private static void .cctor() { }

	// RVA: 0x2197C40 Offset: 0x2196240 VA: 0x182197C40 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20424 : ByteEncoding // TypeDefIndex: 7949
{	// Fields
	private static readonly char[] ToChars; // 0x2B11334

	// Methods

	// RVA: 0x2199450 Offset: 0x2197A50 VA: 0x182199450
	public void .ctor() { }

	// RVA: 0x21993E0 Offset: 0x21979E0 VA: 0x1821993E0
	private static void .cctor() { }

	// RVA: 0x2198A60 Offset: 0x2197060 VA: 0x182198A60 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20871 : ByteEncoding // TypeDefIndex: 7951
{	// Fields
	private static readonly char[] ToChars; // 0x2970

	// Methods

	// RVA: 0x219A210 Offset: 0x2198810 VA: 0x18219A210
	public void .ctor() { }

	// RVA: 0x219A1A0 Offset: 0x21987A0 VA: 0x18219A1A0
	private static void .cctor() { }

	// RVA: 0x2199500 Offset: 0x2197B00 VA: 0x182199500 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP21025 : ByteEncoding // TypeDefIndex: 7953
{	// Fields
	private static readonly char[] ToChars; // 0x29CC

	// Methods

	// RVA: 0x219AEB0 Offset: 0x21994B0 VA: 0x18219AEB0
	public void .ctor() { }

	// RVA: 0x219AE40 Offset: 0x2199440 VA: 0x18219AE40
	private static void .cctor() { }

	// RVA: 0x219A2C0 Offset: 0x21988C0 VA: 0x18219A2C0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP37 : ByteEncoding // TypeDefIndex: 7955
{	// Fields
	private static readonly char[] ToChars; // 0x2B111E0

	// Methods

	// RVA: 0x219BC70 Offset: 0x219A270 VA: 0x18219BC70
	public void .ctor() { }

	// RVA: 0x219BC00 Offset: 0x219A200 VA: 0x18219BC00
	private static void .cctor() { }

	// RVA: 0x219AF60 Offset: 0x2199560 VA: 0x18219AF60 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP500 : ByteEncoding // TypeDefIndex: 7957
{	// Fields
	private static readonly char[] ToChars; // 0x29D0

	// Methods

	// RVA: 0x219CA30 Offset: 0x219B030 VA: 0x18219CA30
	public void .ctor() { }

	// RVA: 0x219C9C0 Offset: 0x219AFC0 VA: 0x18219C9C0
	private static void .cctor() { }

	// RVA: 0x219BD20 Offset: 0x219A320 VA: 0x18219BD20 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP708 : ByteEncoding // TypeDefIndex: 7959
{	// Fields
	private static readonly char[] ToChars; // 0x29F8

	// Methods

	// RVA: 0x219D0B0 Offset: 0x219B6B0 VA: 0x18219D0B0
	public void .ctor() { }

	// RVA: 0x219D040 Offset: 0x219B640 VA: 0x18219D040
	private static void .cctor() { }

	// RVA: 0x219CAE0 Offset: 0x219B0E0 VA: 0x18219CAE0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP852 : ByteEncoding // TypeDefIndex: 7961
{	// Fields
	private static readonly char[] ToChars; // 0x2B111F4

	// Methods

	// RVA: 0x219DF10 Offset: 0x219C510 VA: 0x18219DF10
	public void .ctor() { }

	// RVA: 0x219DEA0 Offset: 0x219C4A0 VA: 0x18219DEA0
	private static void .cctor() { }

	// RVA: 0x219D170 Offset: 0x219B770 VA: 0x18219D170 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP855 : ByteEncoding // TypeDefIndex: 7963
{	// Fields
	private static readonly char[] ToChars; // 0x2A00

	// Methods

	// RVA: 0x219ECB0 Offset: 0x219D2B0 VA: 0x18219ECB0
	public void .ctor() { }

	// RVA: 0x219EC40 Offset: 0x219D240 VA: 0x18219EC40
	private static void .cctor() { }

	// RVA: 0x219DFC0 Offset: 0x219C5C0 VA: 0x18219DFC0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP857 : ByteEncoding // TypeDefIndex: 7965
{	// Fields
	private static readonly char[] ToChars; // 0x2A5C

	// Methods

	// RVA: 0x219FA90 Offset: 0x219E090 VA: 0x18219FA90
	public void .ctor() { }

	// RVA: 0x219FA20 Offset: 0x219E020 VA: 0x18219FA20
	private static void .cctor() { }

	// RVA: 0x219ED60 Offset: 0x219D360 VA: 0x18219ED60 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP858 : ByteEncoding // TypeDefIndex: 7967
{	// Fields
	private static readonly char[] ToChars; // 0x2B111E0

	// Methods

	// RVA: 0x21A08E0 Offset: 0x219EEE0 VA: 0x1821A08E0
	public void .ctor() { }

	// RVA: 0x21A0870 Offset: 0x219EE70 VA: 0x1821A0870
	private static void .cctor() { }

	// RVA: 0x219FB40 Offset: 0x219E140 VA: 0x18219FB40 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP862 : ByteEncoding // TypeDefIndex: 7969
{	// Fields
	private static readonly char[] ToChars; // 0x2A60

	// Methods

	// RVA: 0x21A1610 Offset: 0x219FC10 VA: 0x1821A1610
	public void .ctor() { }

	// RVA: 0x21A15A0 Offset: 0x219FBA0 VA: 0x1821A15A0
	private static void .cctor() { }

	// RVA: 0x21A0990 Offset: 0x219EF90 VA: 0x1821A0990 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP864 : ByteEncoding // TypeDefIndex: 7971
{	// Fields
	private static readonly char[] ToChars; // 0x2AB5

	// Methods

	// RVA: 0x22EA580 Offset: 0x22E8B80 VA: 0x1822EA580
	public void .ctor() { }

	// RVA: 0x22EA510 Offset: 0x22E8B10 VA: 0x1822EA510
	private static void .cctor() { }

	// RVA: 0x22E9820 Offset: 0x22E7E20 VA: 0x1822E9820 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP10000 : ByteEncoding // TypeDefIndex: 7977
{	// Fields
	private static readonly char[] ToChars; // 0x2B111D0

	// Methods

	// RVA: 0x22838F0 Offset: 0x2281EF0 VA: 0x1822838F0
	public void .ctor() { }

	// RVA: 0x2283880 Offset: 0x2281E80 VA: 0x182283880
	private static void .cctor() { }

	// RVA: 0x2282EC0 Offset: 0x22814C0 VA: 0x182282EC0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP10079 : ByteEncoding // TypeDefIndex: 7979
{	// Fields
	private static readonly char[] ToChars; // 0x2AC0

	// Methods

	// RVA: 0x2284380 Offset: 0x2282980 VA: 0x182284380
	public void .ctor() { }

	// RVA: 0x2284310 Offset: 0x2282910 VA: 0x182284310
	private static void .cctor() { }

	// RVA: 0x22839A0 Offset: 0x2281FA0 VA: 0x1822839A0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1250 : ByteEncoding // TypeDefIndex: 7981
{	// Fields
	private static readonly char[] ToChars; // 0x2B27

	// Methods

	// RVA: 0x2284B80 Offset: 0x2283180 VA: 0x182284B80
	public void .ctor() { }

	// RVA: 0x2284B10 Offset: 0x2283110 VA: 0x182284B10
	private static void .cctor() { }

	// RVA: 0x2284430 Offset: 0x2282A30 VA: 0x182284430 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1252 : ByteEncoding // TypeDefIndex: 7983
{	// Fields
	private static readonly char[] ToChars; // 0x2B111E0

	// Methods

	// RVA: 0x22850C0 Offset: 0x22836C0 VA: 0x1822850C0
	public void .ctor() { }

	// RVA: 0x2285050 Offset: 0x2283650 VA: 0x182285050
	private static void .cctor() { }

	// RVA: 0x2284C40 Offset: 0x2283240 VA: 0x182284C40 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1253 : ByteEncoding // TypeDefIndex: 7985
{	// Fields
	private static readonly char[] ToChars; // 0x2B30

	// Methods

	// RVA: 0x22855D0 Offset: 0x2283BD0 VA: 0x1822855D0
	public void .ctor() { }

	// RVA: 0x2285560 Offset: 0x2283B60 VA: 0x182285560
	private static void .cctor() { }

	// RVA: 0x2285180 Offset: 0x2283780 VA: 0x182285180 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28592 : ByteEncoding // TypeDefIndex: 7987
{	// Fields
	private static readonly char[] ToChars; // 0x2B4F

	// Methods

	// RVA: 0x22861C0 Offset: 0x22847C0 VA: 0x1822861C0
	public void .ctor() { }

	// RVA: 0x2286150 Offset: 0x2284750 VA: 0x182286150
	private static void .cctor() { }

	// RVA: 0x2285690 Offset: 0x2283C90 VA: 0x182285690 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28593 : ByteEncoding // TypeDefIndex: 7989
{	// Fields
	private static readonly char[] ToChars; // 0x2B111C8

	// Methods

	// RVA: 0x2286680 Offset: 0x2284C80 VA: 0x182286680
	public void .ctor() { }

	// RVA: 0x2286610 Offset: 0x2284C10 VA: 0x182286610
	private static void .cctor() { }

	// RVA: 0x2286270 Offset: 0x2284870 VA: 0x182286270 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28597 : ByteEncoding // TypeDefIndex: 7991
{	// Fields
	private static readonly char[] ToChars; // 0x2B50

	// Methods

	// RVA: 0x2286A00 Offset: 0x2285000 VA: 0x182286A00
	public void .ctor() { }

	// RVA: 0x2286990 Offset: 0x2284F90 VA: 0x182286990
	private static void .cctor() { }

	// RVA: 0x2286730 Offset: 0x2284D30 VA: 0x182286730 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28605 : ByteEncoding // TypeDefIndex: 7993
{	// Fields
	private static readonly char[] ToChars; // 0x2BC1

	// Methods

	// RVA: 0x2286D60 Offset: 0x2285360 VA: 0x182286D60
	public void .ctor() { }

	// RVA: 0x2286CF0 Offset: 0x22852F0 VA: 0x182286CF0
	private static void .cctor() { }

	// RVA: 0x2286AB0 Offset: 0x22850B0 VA: 0x182286AB0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP437 : ByteEncoding // TypeDefIndex: 7995
{	// Fields
	private static readonly char[] ToChars; // 0x2B11344

	// Methods

	// RVA: 0x2288500 Offset: 0x2286B00 VA: 0x182288500
	public void .ctor() { }

	// RVA: 0x2288490 Offset: 0x2286A90 VA: 0x182288490
	private static void .cctor() { }

	// RVA: 0x2286E10 Offset: 0x2285410 VA: 0x182286E10 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP850 : ByteEncoding // TypeDefIndex: 7997
{	// Fields
	private static readonly char[] ToChars; // 0x2BD0

	// Methods

	// RVA: 0x2289350 Offset: 0x2287950 VA: 0x182289350
	public void .ctor() { }

	// RVA: 0x22892E0 Offset: 0x22878E0 VA: 0x1822892E0
	private static void .cctor() { }

	// RVA: 0x22885B0 Offset: 0x2286BB0 VA: 0x1822885B0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP860 : ByteEncoding // TypeDefIndex: 7999
{	// Fields
	private static readonly char[] ToChars; // 0x2C22

	// Methods

	// RVA: 0x228A1B0 Offset: 0x22887B0 VA: 0x18228A1B0
	public void .ctor() { }

	// RVA: 0x228A140 Offset: 0x2288740 VA: 0x18228A140
	private static void .cctor() { }

	// RVA: 0x2289400 Offset: 0x2287A00 VA: 0x182289400 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP861 : ByteEncoding // TypeDefIndex: 8001
{	// Fields
	private static readonly char[] ToChars; // 0x2B112A0

	// Methods

	// RVA: 0x228B010 Offset: 0x2289610 VA: 0x18228B010
	public void .ctor() { }

	// RVA: 0x228AFA0 Offset: 0x22895A0 VA: 0x18228AFA0
	private static void .cctor() { }

	// RVA: 0x228A260 Offset: 0x2288860 VA: 0x18228A260 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP863 : ByteEncoding // TypeDefIndex: 8003
{	// Fields
	private static readonly char[] ToChars; // 0x2C30

	// Methods

	// RVA: 0x228BE60 Offset: 0x228A460 VA: 0x18228BE60
	public void .ctor() { }

	// RVA: 0x228BDF0 Offset: 0x228A3F0 VA: 0x18228BDF0
	private static void .cctor() { }

	// RVA: 0x228B0C0 Offset: 0x22896C0 VA: 0x18228B0C0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP865 : ByteEncoding // TypeDefIndex: 8005
{	// Fields
	private static readonly char[] ToChars; // 0x2C96

	// Methods

	// RVA: 0x228CCC0 Offset: 0x228B2C0 VA: 0x18228CCC0
	public void .ctor() { }

	// RVA: 0x228CC50 Offset: 0x228B250 VA: 0x18228CC50
	private static void .cctor() { }

	// RVA: 0x228BF10 Offset: 0x228A510 VA: 0x18228BF10 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

