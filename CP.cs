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

	// RVA: 0x224CE70 Offset: 0x224B470 VA: 0x18224CE70
	public void .ctor() { }

	// RVA: 0x224C1D0 Offset: 0x224A7D0 VA: 0x18224C1D0 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x224C3E0 Offset: 0x224A9E0 VA: 0x18224C3E0 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x224CA80 Offset: 0x224B080 VA: 0x18224CA80 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224CBE0 Offset: 0x224B1E0 VA: 0x18224CBE0 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224CD70 Offset: 0x224B370 VA: 0x18224CD70 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x224CDF0 Offset: 0x224B3F0 VA: 0x18224CDF0 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x224CCD0 Offset: 0x224B2D0 VA: 0x18224CCD0 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x224CE80 Offset: 0x224B480 VA: 0x18224CE80 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224CEB0 Offset: 0x224B4B0 VA: 0x18224CEB0 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224CEE0 Offset: 0x224B4E0 VA: 0x18224CEE0 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 15
	public override bool get_IsMailNewsSave() { }

	// RVA: 0x224CF10 Offset: 0x224B510 VA: 0x18224CF10 Slot: 10
	public override string get_WebName() { }

	// RVA: 0x224CF40 Offset: 0x224B540 VA: 0x18224CF40 Slot: 11
	public override int get_WindowsCodePage() { }

}

internal sealed class CP932Decoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7798
{	// Fields
	private JISConvert convert; // 0x28
	private int last_byte_count; // 0x30
	private int last_byte_chars; // 0x34

	// Methods

	// RVA: 0x224C180 Offset: 0x224A780 VA: 0x18224C180
	public void .ctor(JISConvert convert) { }

	// RVA: 0x224BCC0 Offset: 0x224A2C0 VA: 0x18224BCC0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224BBE0 Offset: 0x224A1E0 VA: 0x18224BBE0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	// RVA: 0x224BD80 Offset: 0x224A380 VA: 0x18224BD80 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224BDB0 Offset: 0x224A3B0 VA: 0x18224BDB0 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

}

public class CP50220 : ISO2022JPEncoding // TypeDefIndex: 7800
{	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x224A5E0 Offset: 0x2248BE0 VA: 0x18224A5E0
	public void .ctor() { }

	// RVA: 0x224A610 Offset: 0x2248C10 VA: 0x18224A610 Slot: 8
	public override string get_EncodingName() { }

}

public class CP50221 : ISO2022JPEncoding // TypeDefIndex: 7801
{	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x224A640 Offset: 0x2248C40 VA: 0x18224A640
	public void .ctor() { }

	// RVA: 0x224A670 Offset: 0x2248C70 VA: 0x18224A670 Slot: 8
	public override string get_EncodingName() { }

}

public class CP50222 : ISO2022JPEncoding // TypeDefIndex: 7802
{	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x224A6A0 Offset: 0x2248CA0 VA: 0x18224A6A0
	public void .ctor() { }

	// RVA: 0x224A6D0 Offset: 0x2248CD0 VA: 0x18224A6D0 Slot: 8
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

	// RVA: 0x224B9F0 Offset: 0x2249FF0 VA: 0x18224B9F0
	public void .ctor() { }

	// RVA: 0x224B560 Offset: 0x2249B60 VA: 0x18224B560 Slot: 19
	public override int GetByteCount(char[] chars, int index, int length) { }

	// RVA: 0x224B4C0 Offset: 0x2249AC0 VA: 0x18224B4C0 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x224B610 Offset: 0x2249C10 VA: 0x18224B610 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x224B6D0 Offset: 0x2249CD0 VA: 0x18224B6D0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224B770 Offset: 0x2249D70 VA: 0x18224B770 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224B8F0 Offset: 0x2249EF0 VA: 0x18224B8F0 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x224B970 Offset: 0x2249F70 VA: 0x18224B970 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x224B890 Offset: 0x2249E90 VA: 0x18224B890 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x224B830 Offset: 0x2249E30 VA: 0x18224B830 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x224BA10 Offset: 0x224A010 VA: 0x18224BA10 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224BA40 Offset: 0x224A040 VA: 0x18224BA40 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224BA70 Offset: 0x224A070 VA: 0x18224BA70 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 15
	public override bool get_IsMailNewsSave() { }

	// RVA: 0x224BAA0 Offset: 0x224A0A0 VA: 0x18224BAA0 Slot: 10
	public override string get_WebName() { }

}

public class CP51932Encoder : MonoEncoder // TypeDefIndex: 7809
{	// Methods

	// RVA: 0x224B4B0 Offset: 0x2249AB0 VA: 0x18224B4B0
	public void .ctor(MonoEncoding encoding) { }

	// RVA: 0x224AEA0 Offset: 0x22494A0 VA: 0x18224AEA0 Slot: 11
	public override int GetByteCountImpl(char* chars, int count, bool refresh) { }

	// RVA: 0x224B0B0 Offset: 0x22496B0 VA: 0x18224B0B0 Slot: 12
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool refresh) { }

}

internal class CP51932Decoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7810
{	// Fields
	private int last_count; // 0x28
	private int last_bytes; // 0x2C

	// Methods

	// RVA: 0x224AE70 Offset: 0x2249470 VA: 0x18224AE70
	public void .ctor() { }

	// RVA: 0xE4E3B0 Offset: 0xE4C9B0 VA: 0x180E4E3B0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224A700 Offset: 0x2248D00 VA: 0x18224A700 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	// RVA: 0x18AC670 Offset: 0x18AAC70 VA: 0x1818AC670 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224A940 Offset: 0x2248F40 VA: 0x18224A940 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

	// RVA: 0x224AE00 Offset: 0x2249400 VA: 0x18224AE00
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

	// RVA: 0x224D9C0 Offset: 0x224BFC0 VA: 0x18224D9C0
	public void .ctor() { }

	// RVA: 0x224D8E0 Offset: 0x224BEE0 VA: 0x18224D8E0 Slot: 48
	internal override DbcsConvert GetConvert() { }

	// RVA: 0x224D540 Offset: 0x224BB40 VA: 0x18224D540 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x224D630 Offset: 0x224BC30 VA: 0x18224D630 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x224D800 Offset: 0x224BE00 VA: 0x18224D800 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224D870 Offset: 0x224BE70 VA: 0x18224D870 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224D940 Offset: 0x224BF40 VA: 0x18224D940 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x224D9D0 Offset: 0x224BFD0 VA: 0x18224D9D0 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224DA00 Offset: 0x224C000 VA: 0x18224DA00 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224DA30 Offset: 0x224C030 VA: 0x18224DA30 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 15
	public override bool get_IsMailNewsSave() { }

	// RVA: 0x224DA60 Offset: 0x224C060 VA: 0x18224DA60 Slot: 10
	public override string get_WebName() { }

}

internal sealed class CP936Decoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7813
{	// Fields
	private int last_byte_count; // 0x28
	private int last_byte_bytes; // 0x2C

	// Methods

	// RVA: 0x15C0090 Offset: 0x15BE690 VA: 0x1815C0090
	public void .ctor(DbcsConvert convert) { }

	// RVA: 0x224CF50 Offset: 0x224B550 VA: 0x18224CF50 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224D010 Offset: 0x224B610 VA: 0x18224D010 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	// RVA: 0x224D0E0 Offset: 0x224B6E0 VA: 0x18224D0E0 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224D2F0 Offset: 0x224B8F0 VA: 0x18224D2F0 Slot: 9
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

	// RVA: 0x224DA90 Offset: 0x224C090 VA: 0x18224DA90
	public void .ctor() { }

	// RVA: 0x224DAC0 Offset: 0x224C0C0 VA: 0x18224DAC0 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224DAF0 Offset: 0x224C0F0 VA: 0x18224DAF0 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224DB20 Offset: 0x224C120 VA: 0x18224DB20 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x224DB50 Offset: 0x224C150 VA: 0x18224DB50 Slot: 10
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

	// RVA: 0x224BAD0 Offset: 0x224A0D0 VA: 0x18224BAD0
	public void .ctor() { }

	// RVA: 0x224BB00 Offset: 0x224A100 VA: 0x18224BB00 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224BB30 Offset: 0x224A130 VA: 0x18224BB30 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224BB60 Offset: 0x224A160 VA: 0x18224BB60 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x224BB90 Offset: 0x224A190 VA: 0x18224BB90 Slot: 10
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

	// RVA: 0x224E4A0 Offset: 0x224CAA0 VA: 0x18224E4A0
	public void .ctor() { }

	// RVA: 0x224E3C0 Offset: 0x224C9C0 VA: 0x18224E3C0 Slot: 48
	internal override DbcsConvert GetConvert() { }

	// RVA: 0x224E2D0 Offset: 0x224C8D0 VA: 0x18224E2D0 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x224D630 Offset: 0x224BC30 VA: 0x18224D630 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x224D870 Offset: 0x224BE70 VA: 0x18224D870 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224E420 Offset: 0x224CA20 VA: 0x18224E420 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x224E4B0 Offset: 0x224CAB0 VA: 0x18224E4B0 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224E4E0 Offset: 0x224CAE0 VA: 0x18224E4E0 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224E510 Offset: 0x224CB10 VA: 0x18224E510 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x224E540 Offset: 0x224CB40 VA: 0x18224E540 Slot: 10
	public override string get_WebName() { }

}

private sealed class CP950.CP950Decoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7822
{	// Fields
	private int last_byte_count; // 0x28
	private int last_byte_conv; // 0x2C

	// Methods

	// RVA: 0x15C0090 Offset: 0x15BE690 VA: 0x1815C0090
	public void .ctor(DbcsConvert convert) { }

	// RVA: 0x224DB80 Offset: 0x224C180 VA: 0x18224DB80 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224DCC0 Offset: 0x224C2C0 VA: 0x18224DCC0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	// RVA: 0x224DE10 Offset: 0x224C410 VA: 0x18224DE10 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224E050 Offset: 0x224C650 VA: 0x18224E050 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

}

public class CP54936 : GB18030Encoding // TypeDefIndex: 7829
{	// Methods

	// RVA: 0x224BBC0 Offset: 0x224A1C0 VA: 0x18224BBC0
	public void .ctor() { }

}

public class CP1254 : ByteEncoding // TypeDefIndex: 7840
{	// Fields
	private static readonly char[] ToChars; // 0x2130

	// Methods

	// RVA: 0x2305DB0 Offset: 0x23043B0 VA: 0x182305DB0
	public void .ctor() { }

	// RVA: 0x2305D40 Offset: 0x2304340 VA: 0x182305D40
	private static void .cctor() { }

	// RVA: 0x23058E0 Offset: 0x2303EE0 VA: 0x1823058E0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1255 : ByteEncoding // TypeDefIndex: 7842
{	// Fields
	private static readonly char[] ToChars; // 0x21A0

	// Methods

	// RVA: 0x23062F0 Offset: 0x23048F0 VA: 0x1823062F0
	public void .ctor() { }

	// RVA: 0x2306280 Offset: 0x2304880 VA: 0x182306280
	private static void .cctor() { }

	// RVA: 0x2305E70 Offset: 0x2304470 VA: 0x182305E70 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1256 : ByteEncoding // TypeDefIndex: 7844
{	// Fields
	private static readonly char[] ToChars; // 0x2B104E4

	// Methods

	// RVA: 0x2306E50 Offset: 0x2305450 VA: 0x182306E50
	public void .ctor() { }

	// RVA: 0x2306DE0 Offset: 0x23053E0 VA: 0x182306DE0
	private static void .cctor() { }

	// RVA: 0x23063A0 Offset: 0x23049A0 VA: 0x1823063A0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28596 : ByteEncoding // TypeDefIndex: 7846
{	// Fields
	private static readonly char[] ToChars; // 0x21A0

	// Methods

	// RVA: 0x2307930 Offset: 0x2305F30 VA: 0x182307930
	public void .ctor() { }

	// RVA: 0x23078C0 Offset: 0x2305EC0 VA: 0x1823078C0
	private static void .cctor() { }

	// RVA: 0x2306F00 Offset: 0x2305500 VA: 0x182306F00 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28598 : ByteEncoding // TypeDefIndex: 7848
{	// Fields
	private static readonly char[] ToChars; // 0x21FF

	// Methods

	// RVA: 0x2307C60 Offset: 0x2306260 VA: 0x182307C60
	public void .ctor() { }

	// RVA: 0x2307BF0 Offset: 0x23061F0 VA: 0x182307BF0
	private static void .cctor() { }

	// RVA: 0x23079E0 Offset: 0x2305FE0 VA: 0x1823079E0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28599 : ByteEncoding // TypeDefIndex: 7850
{	// Fields
	private static readonly char[] ToChars; // 0x2B104D4

	// Methods

	// RVA: 0x2307F90 Offset: 0x2306590 VA: 0x182307F90
	public void .ctor() { }

	// RVA: 0x2307F20 Offset: 0x2306520 VA: 0x182307F20
	private static void .cctor() { }

	// RVA: 0x2307D10 Offset: 0x2306310 VA: 0x182307D10 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP38598 : ByteEncoding // TypeDefIndex: 7852
{	// Fields
	private static readonly char[] ToChars; // 0x2200

	// Methods

	// RVA: 0x23080B0 Offset: 0x23066B0 VA: 0x1823080B0
	public void .ctor() { }

	// RVA: 0x2308040 Offset: 0x2306640 VA: 0x182308040
	private static void .cctor() { }

	// RVA: 0x23079E0 Offset: 0x2305FE0 VA: 0x1823079E0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1251 : ByteEncoding // TypeDefIndex: 7858
{	// Fields
	private static readonly char[] ToChars; // 0x227D

	// Methods

	// RVA: 0x22F1E70 Offset: 0x22F0470 VA: 0x1822F1E70
	public void .ctor() { }

	// RVA: 0x22F1E00 Offset: 0x22F0400 VA: 0x1822F1E00
	private static void .cctor() { }

	// RVA: 0x22F18C0 Offset: 0x22EFEC0 VA: 0x1822F18C0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1257 : ByteEncoding // TypeDefIndex: 7860
{	// Fields
	private static readonly char[] ToChars; // 0x2B10464

	// Methods

	// RVA: 0x22F2720 Offset: 0x22F0D20 VA: 0x1822F2720
	public void .ctor() { }

	// RVA: 0x22F26B0 Offset: 0x22F0CB0 VA: 0x1822F26B0
	private static void .cctor() { }

	// RVA: 0x22F1F30 Offset: 0x22F0530 VA: 0x1822F1F30 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1258 : ByteEncoding // TypeDefIndex: 7862
{	// Fields
	private static readonly char[] ToChars; // 0x2280

	// Methods

	// RVA: 0x22F2CD0 Offset: 0x22F12D0 VA: 0x1822F2CD0
	public void .ctor() { }

	// RVA: 0x22F2C60 Offset: 0x22F1260 VA: 0x1822F2C60
	private static void .cctor() { }

	// RVA: 0x22F27E0 Offset: 0x22F0DE0 VA: 0x1822F27E0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20866 : ByteEncoding // TypeDefIndex: 7864
{	// Fields
	private static readonly char[] ToChars; // 0x22BB

	// Methods

	// RVA: 0x22F3500 Offset: 0x22F1B00 VA: 0x1822F3500
	public void .ctor() { }

	// RVA: 0x22F3490 Offset: 0x22F1A90 VA: 0x1822F3490
	private static void .cctor() { }

	// RVA: 0x22F2D80 Offset: 0x22F1380 VA: 0x1822F2D80 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP21866 : ByteEncoding // TypeDefIndex: 7866
{	// Fields
	private static readonly char[] ToChars; // 0x2B1039C

	// Methods

	// RVA: 0x22F3E10 Offset: 0x22F2410 VA: 0x1822F3E10
	public void .ctor() { }

	// RVA: 0x22F3DA0 Offset: 0x22F23A0 VA: 0x1822F3DA0
	private static void .cctor() { }

	// RVA: 0x22F35B0 Offset: 0x22F1BB0 VA: 0x1822F35B0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28594 : ByteEncoding // TypeDefIndex: 7868
{	// Fields
	private static readonly char[] ToChars; // 0x22C0

	// Methods

	// RVA: 0x22F44B0 Offset: 0x22F2AB0 VA: 0x1822F44B0
	public void .ctor() { }

	// RVA: 0x22F4440 Offset: 0x22F2A40 VA: 0x1822F4440
	private static void .cctor() { }

	// RVA: 0x22F3EC0 Offset: 0x22F24C0 VA: 0x1822F3EC0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28595 : ByteEncoding // TypeDefIndex: 7870
{	// Fields
	private static readonly char[] ToChars; // 0x22FC

	// Methods

	// RVA: 0x22F47D0 Offset: 0x22F2DD0 VA: 0x1822F47D0
	public void .ctor() { }

	// RVA: 0x22F4760 Offset: 0x22F2D60 VA: 0x1822F4760
	private static void .cctor() { }

	// RVA: 0x22F4560 Offset: 0x22F2B60 VA: 0x1822F4560 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP57002 : ISCIIEncoding // TypeDefIndex: 7873
{	// Methods

	// RVA: 0x22F4880 Offset: 0x22F2E80 VA: 0x1822F4880
	public void .ctor() { }

}

public class CP57003 : ISCIIEncoding // TypeDefIndex: 7874
{	// Methods

	// RVA: 0x22F4900 Offset: 0x22F2F00 VA: 0x1822F4900
	public void .ctor() { }

}

public class CP57004 : ISCIIEncoding // TypeDefIndex: 7875
{	// Methods

	// RVA: 0x22F4980 Offset: 0x22F2F80 VA: 0x1822F4980
	public void .ctor() { }

}

public class CP57005 : ISCIIEncoding // TypeDefIndex: 7876
{	// Methods

	// RVA: 0x22F4A00 Offset: 0x22F3000 VA: 0x1822F4A00
	public void .ctor() { }

}

public class CP57006 : ISCIIEncoding // TypeDefIndex: 7877
{	// Methods

	// RVA: 0x22F4A80 Offset: 0x22F3080 VA: 0x1822F4A80
	public void .ctor() { }

}

public class CP57007 : ISCIIEncoding // TypeDefIndex: 7878
{	// Methods

	// RVA: 0x22F4B00 Offset: 0x22F3100 VA: 0x1822F4B00
	public void .ctor() { }

}

public class CP57008 : ISCIIEncoding // TypeDefIndex: 7879
{	// Methods

	// RVA: 0x22F4B80 Offset: 0x22F3180 VA: 0x1822F4B80
	public void .ctor() { }

}

public class CP57009 : ISCIIEncoding // TypeDefIndex: 7880
{	// Methods

	// RVA: 0x22F4C00 Offset: 0x22F3200 VA: 0x1822F4C00
	public void .ctor() { }

}

public class CP57010 : ISCIIEncoding // TypeDefIndex: 7881
{	// Methods

	// RVA: 0x22F4C80 Offset: 0x22F3280 VA: 0x1822F4C80
	public void .ctor() { }

}

public class CP57011 : ISCIIEncoding // TypeDefIndex: 7882
{	// Methods

	// RVA: 0x22F4D00 Offset: 0x22F3300 VA: 0x1822F4D00
	public void .ctor() { }

}

public class CP874 : ByteEncoding // TypeDefIndex: 7893
{	// Fields
	private static readonly char[] ToChars; // 0x2B10640

	// Methods

	// RVA: 0x22F50C0 Offset: 0x22F36C0 VA: 0x1822F50C0
	public void .ctor() { }

	// RVA: 0x22F5050 Offset: 0x22F3650 VA: 0x1822F5050
	private static void .cctor() { }

	// RVA: 0x22F4D80 Offset: 0x22F3380 VA: 0x1822F4D80 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP866 : ByteEncoding // TypeDefIndex: 7899
{	// Fields
	private static readonly char[] ToChars; // 0x2300

	// Methods

	// RVA: 0x22EB840 Offset: 0x22E9E40 VA: 0x1822EB840
	public void .ctor() { }

	// RVA: 0x22EB7D0 Offset: 0x22E9DD0 VA: 0x1822EB7D0
	private static void .cctor() { }

	// RVA: 0x22EAE50 Offset: 0x22E9450 VA: 0x1822EAE50 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1026 : ByteEncoding // TypeDefIndex: 7901
{	// Fields
	private static readonly char[] ToChars; // 0x2356

	// Methods

	// RVA: 0x21882B0 Offset: 0x21868B0 VA: 0x1821882B0
	public void .ctor() { }

	// RVA: 0x2188240 Offset: 0x2186840 VA: 0x182188240
	private static void .cctor() { }

	// RVA: 0x2187550 Offset: 0x2185B50 VA: 0x182187550 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP869 : ByteEncoding // TypeDefIndex: 7903
{	// Fields
	private static readonly char[] ToChars; // 0x2B10360

	// Methods

	// RVA: 0x22EC460 Offset: 0x22EAA60 VA: 0x1822EC460
	public void .ctor() { }

	// RVA: 0x22EC3F0 Offset: 0x22EA9F0 VA: 0x1822EC3F0
	private static void .cctor() { }

	// RVA: 0x22EB8F0 Offset: 0x22E9EF0 VA: 0x1822EB8F0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP870 : ByteEncoding // TypeDefIndex: 7905
{	// Fields
	private static readonly char[] ToChars; // 0x2360

	// Methods

	// RVA: 0x22ED2C0 Offset: 0x22EB8C0 VA: 0x1822ED2C0
	public void .ctor() { }

	// RVA: 0x22ED250 Offset: 0x22EB850 VA: 0x1822ED250
	private static void .cctor() { }

	// RVA: 0x22EC510 Offset: 0x22EAB10 VA: 0x1822EC510 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP875 : ByteEncoding // TypeDefIndex: 7907
{	// Fields
	private static readonly char[] ToChars; // 0x2391

	// Methods

	// RVA: 0x22EDE60 Offset: 0x22EC460 VA: 0x1822EDE60
	public void .ctor() { }

	// RVA: 0x22EDDF0 Offset: 0x22EC3F0 VA: 0x1822EDDF0
	private static void .cctor() { }

	// RVA: 0x22ED370 Offset: 0x22EB970 VA: 0x1822ED370 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1047 : ByteEncoding // TypeDefIndex: 7909
{	// Fields
	private static readonly char[] ToChars; // 0x2B10394

	// Methods

	// RVA: 0x2189060 Offset: 0x2187660 VA: 0x182189060
	public void .ctor() { }

	// RVA: 0x2188FF0 Offset: 0x21875F0 VA: 0x182188FF0
	private static void .cctor() { }

	// RVA: 0x2188360 Offset: 0x2186960 VA: 0x182188360 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1140 : ByteEncoding // TypeDefIndex: 7911
{	// Fields
	private static readonly char[] ToChars; // 0x23A0

	// Methods

	// RVA: 0x2189E20 Offset: 0x2188420 VA: 0x182189E20
	public void .ctor() { }

	// RVA: 0x2189DB0 Offset: 0x21883B0 VA: 0x182189DB0
	private static void .cctor() { }

	// RVA: 0x2189110 Offset: 0x2187710 VA: 0x182189110 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1141 : ByteEncoding // TypeDefIndex: 7913
{	// Fields
	private static readonly char[] ToChars; // 0x2417

	// Methods

	// RVA: 0x218ABE0 Offset: 0x21891E0 VA: 0x18218ABE0
	public void .ctor() { }

	// RVA: 0x218AB70 Offset: 0x2189170 VA: 0x18218AB70
	private static void .cctor() { }

	// RVA: 0x2189ED0 Offset: 0x21884D0 VA: 0x182189ED0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1142 : ByteEncoding // TypeDefIndex: 7915
{	// Fields
	private static readonly char[] ToChars; // 0x2B10510

	// Methods

	// RVA: 0x218B9A0 Offset: 0x2189FA0 VA: 0x18218B9A0
	public void .ctor() { }

	// RVA: 0x218B930 Offset: 0x2189F30 VA: 0x18218B930
	private static void .cctor() { }

	// RVA: 0x218AC90 Offset: 0x2189290 VA: 0x18218AC90 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1143 : ByteEncoding // TypeDefIndex: 7917
{	// Fields
	private static readonly char[] ToChars; // 0x2420

	// Methods

	// RVA: 0x218C760 Offset: 0x218AD60 VA: 0x18218C760
	public void .ctor() { }

	// RVA: 0x218C6F0 Offset: 0x218ACF0 VA: 0x18218C6F0
	private static void .cctor() { }

	// RVA: 0x218BA50 Offset: 0x218A050 VA: 0x18218BA50 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1144 : ByteEncoding // TypeDefIndex: 7919
{	// Fields
	private static readonly char[] ToChars; // 0x24B7

	// Methods

	// RVA: 0x218D520 Offset: 0x218BB20 VA: 0x18218D520
	public void .ctor() { }

	// RVA: 0x218D4B0 Offset: 0x218BAB0 VA: 0x18218D4B0
	private static void .cctor() { }

	// RVA: 0x218C810 Offset: 0x218AE10 VA: 0x18218C810 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1145 : ByteEncoding // TypeDefIndex: 7921
{	// Fields
	private static readonly char[] ToChars; // 0x2B10570

	// Methods

	// RVA: 0x218E2E0 Offset: 0x218C8E0 VA: 0x18218E2E0
	public void .ctor() { }

	// RVA: 0x218E270 Offset: 0x218C870 VA: 0x18218E270
	private static void .cctor() { }

	// RVA: 0x218D5D0 Offset: 0x218BBD0 VA: 0x18218D5D0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1146 : ByteEncoding // TypeDefIndex: 7923
{	// Fields
	private static readonly char[] ToChars; // 0x24C0

	// Methods

	// RVA: 0x218F0A0 Offset: 0x218D6A0 VA: 0x18218F0A0
	public void .ctor() { }

	// RVA: 0x218F030 Offset: 0x218D630 VA: 0x18218F030
	private static void .cctor() { }

	// RVA: 0x218E390 Offset: 0x218C990 VA: 0x18218E390 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1147 : ByteEncoding // TypeDefIndex: 7925
{	// Fields
	private static readonly char[] ToChars; // 0x2527

	// Methods

	// RVA: 0x218FE60 Offset: 0x218E460 VA: 0x18218FE60
	public void .ctor() { }

	// RVA: 0x218FDF0 Offset: 0x218E3F0 VA: 0x18218FDF0
	private static void .cctor() { }

	// RVA: 0x218F150 Offset: 0x218D750 VA: 0x18218F150 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1148 : ByteEncoding // TypeDefIndex: 7927
{	// Fields
	private static readonly char[] ToChars; // 0x2B10370

	// Methods

	// RVA: 0x2190C20 Offset: 0x218F220 VA: 0x182190C20
	public void .ctor() { }

	// RVA: 0x2190BB0 Offset: 0x218F1B0 VA: 0x182190BB0
	private static void .cctor() { }

	// RVA: 0x218FF10 Offset: 0x218E510 VA: 0x18218FF10 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1149 : ByteEncoding // TypeDefIndex: 7929
{	// Fields
	private static readonly char[] ToChars; // 0x2530

	// Methods

	// RVA: 0x21919E0 Offset: 0x218FFE0 VA: 0x1821919E0
	public void .ctor() { }

	// RVA: 0x2191970 Offset: 0x218FF70 VA: 0x182191970
	private static void .cctor() { }

	// RVA: 0x2190CD0 Offset: 0x218F2D0 VA: 0x182190CD0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20273 : ByteEncoding // TypeDefIndex: 7931
{	// Fields
	private static readonly char[] ToChars; // 0x2578

	// Methods

	// RVA: 0x21927A0 Offset: 0x2190DA0 VA: 0x1821927A0
	public void .ctor() { }

	// RVA: 0x2192730 Offset: 0x2190D30 VA: 0x182192730
	private static void .cctor() { }

	// RVA: 0x2191A90 Offset: 0x2190090 VA: 0x182191A90 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20277 : ByteEncoding // TypeDefIndex: 7933
{	// Fields
	private static readonly char[] ToChars; // 0x2B10640

	// Methods

	// RVA: 0x2193560 Offset: 0x2191B60 VA: 0x182193560
	public void .ctor() { }

	// RVA: 0x21934F0 Offset: 0x2191AF0 VA: 0x1821934F0
	private static void .cctor() { }

	// RVA: 0x2192850 Offset: 0x2190E50 VA: 0x182192850 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20278 : ByteEncoding // TypeDefIndex: 7935
{	// Fields
	private static readonly char[] ToChars; // 0x2580

	// Methods

	// RVA: 0x2194320 Offset: 0x2192920 VA: 0x182194320
	public void .ctor() { }

	// RVA: 0x21942B0 Offset: 0x21928B0 VA: 0x1821942B0
	private static void .cctor() { }

	// RVA: 0x2193610 Offset: 0x2191C10 VA: 0x182193610 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20280 : ByteEncoding // TypeDefIndex: 7937
{	// Fields
	private static readonly char[] ToChars; // 0x25B9

	// Methods

	// RVA: 0x21950E0 Offset: 0x21936E0 VA: 0x1821950E0
	public void .ctor() { }

	// RVA: 0x2195070 Offset: 0x2193670 VA: 0x182195070
	private static void .cctor() { }

	// RVA: 0x21943D0 Offset: 0x21929D0 VA: 0x1821943D0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20284 : ByteEncoding // TypeDefIndex: 7939
{	// Fields
	private static readonly char[] ToChars; // 0x2B10380

	// Methods

	// RVA: 0x2195EA0 Offset: 0x21944A0 VA: 0x182195EA0
	public void .ctor() { }

	// RVA: 0x2195E30 Offset: 0x2194430 VA: 0x182195E30
	private static void .cctor() { }

	// RVA: 0x2195190 Offset: 0x2193790 VA: 0x182195190 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20285 : ByteEncoding // TypeDefIndex: 7941
{	// Fields
	private static readonly char[] ToChars; // 0x25C0

	// Methods

	// RVA: 0x2196C60 Offset: 0x2195260 VA: 0x182196C60
	public void .ctor() { }

	// RVA: 0x2196BF0 Offset: 0x21951F0 VA: 0x182196BF0
	private static void .cctor() { }

	// RVA: 0x2195F50 Offset: 0x2194550 VA: 0x182195F50 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20290 : ByteEncoding // TypeDefIndex: 7943
{	// Fields
	private static readonly char[] ToChars; // 0x25DD

	// Methods

	// RVA: 0x21975F0 Offset: 0x2195BF0 VA: 0x1821975F0
	public void .ctor() { }

	// RVA: 0x2197580 Offset: 0x2195B80 VA: 0x182197580
	private static void .cctor() { }

	// RVA: 0x2196D10 Offset: 0x2195310 VA: 0x182196D10 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20297 : ByteEncoding // TypeDefIndex: 7945
{	// Fields
	private static readonly char[] ToChars; // 0x2B10368

	// Methods

	// RVA: 0x21983B0 Offset: 0x21969B0 VA: 0x1821983B0
	public void .ctor() { }

	// RVA: 0x2198340 Offset: 0x2196940 VA: 0x182198340
	private static void .cctor() { }

	// RVA: 0x21976A0 Offset: 0x2195CA0 VA: 0x1821976A0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20420 : ByteEncoding // TypeDefIndex: 7947
{	// Fields
	private static readonly char[] ToChars; // 0x25E0

	// Methods

	// RVA: 0x21991D0 Offset: 0x21977D0 VA: 0x1821991D0
	public void .ctor() { }

	// RVA: 0x2199160 Offset: 0x2197760 VA: 0x182199160
	private static void .cctor() { }

	// RVA: 0x2198460 Offset: 0x2196A60 VA: 0x182198460 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20424 : ByteEncoding // TypeDefIndex: 7949
{	// Fields
	private static readonly char[] ToChars; // 0x2649

	// Methods

	// RVA: 0x2199C70 Offset: 0x2198270 VA: 0x182199C70
	public void .ctor() { }

	// RVA: 0x2199C00 Offset: 0x2198200 VA: 0x182199C00
	private static void .cctor() { }

	// RVA: 0x2199280 Offset: 0x2197880 VA: 0x182199280 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20871 : ByteEncoding // TypeDefIndex: 7951
{	// Fields
	private static readonly char[] ToChars; // 0x2B104DC

	// Methods

	// RVA: 0x219AA30 Offset: 0x2199030 VA: 0x18219AA30
	public void .ctor() { }

	// RVA: 0x219A9C0 Offset: 0x2198FC0 VA: 0x18219A9C0
	private static void .cctor() { }

	// RVA: 0x2199D20 Offset: 0x2198320 VA: 0x182199D20 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP21025 : ByteEncoding // TypeDefIndex: 7953
{	// Fields
	private static readonly char[] ToChars; // 0x2650

	// Methods

	// RVA: 0x219B6D0 Offset: 0x2199CD0 VA: 0x18219B6D0
	public void .ctor() { }

	// RVA: 0x219B660 Offset: 0x2199C60 VA: 0x18219B660
	private static void .cctor() { }

	// RVA: 0x219AAE0 Offset: 0x21990E0 VA: 0x18219AAE0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP37 : ByteEncoding // TypeDefIndex: 7955
{	// Fields
	private static readonly char[] ToChars; // 0x27F7

	// Methods

	// RVA: 0x219C490 Offset: 0x219AA90 VA: 0x18219C490
	public void .ctor() { }

	// RVA: 0x219C420 Offset: 0x219AA20 VA: 0x18219C420
	private static void .cctor() { }

	// RVA: 0x219B780 Offset: 0x2199D80 VA: 0x18219B780 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP500 : ByteEncoding // TypeDefIndex: 7957
{	// Fields
	private static readonly char[] ToChars; // 0x2B10A58

	// Methods

	// RVA: 0x219D250 Offset: 0x219B850 VA: 0x18219D250
	public void .ctor() { }

	// RVA: 0x219D1E0 Offset: 0x219B7E0 VA: 0x18219D1E0
	private static void .cctor() { }

	// RVA: 0x219C540 Offset: 0x219AB40 VA: 0x18219C540 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP708 : ByteEncoding // TypeDefIndex: 7959
{	// Fields
	private static readonly char[] ToChars; // 0x2800

	// Methods

	// RVA: 0x219D8D0 Offset: 0x219BED0 VA: 0x18219D8D0
	public void .ctor() { }

	// RVA: 0x219D860 Offset: 0x219BE60 VA: 0x18219D860
	private static void .cctor() { }

	// RVA: 0x219D300 Offset: 0x219B900 VA: 0x18219D300 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP852 : ByteEncoding // TypeDefIndex: 7961
{	// Fields
	private static readonly char[] ToChars; // 0x2845

	// Methods

	// RVA: 0x219E730 Offset: 0x219CD30 VA: 0x18219E730
	public void .ctor() { }

	// RVA: 0x219E6C0 Offset: 0x219CCC0 VA: 0x18219E6C0
	private static void .cctor() { }

	// RVA: 0x219D990 Offset: 0x219BF90 VA: 0x18219D990 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP855 : ByteEncoding // TypeDefIndex: 7963
{	// Fields
	private static readonly char[] ToChars; // 0x2B10360

	// Methods

	// RVA: 0x219F4D0 Offset: 0x219DAD0 VA: 0x18219F4D0
	public void .ctor() { }

	// RVA: 0x219F460 Offset: 0x219DA60 VA: 0x18219F460
	private static void .cctor() { }

	// RVA: 0x219E7E0 Offset: 0x219CDE0 VA: 0x18219E7E0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP857 : ByteEncoding // TypeDefIndex: 7965
{	// Fields
	private static readonly char[] ToChars; // 0x2850

	// Methods

	// RVA: 0x21A02B0 Offset: 0x219E8B0 VA: 0x1821A02B0
	public void .ctor() { }

	// RVA: 0x21A0240 Offset: 0x219E840 VA: 0x1821A0240
	private static void .cctor() { }

	// RVA: 0x219F580 Offset: 0x219DB80 VA: 0x18219F580 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP858 : ByteEncoding // TypeDefIndex: 7967
{	// Fields
	private static readonly char[] ToChars; // 0x2898

	// Methods

	// RVA: 0x21A1100 Offset: 0x219F700 VA: 0x1821A1100
	public void .ctor() { }

	// RVA: 0x21A1090 Offset: 0x219F690 VA: 0x1821A1090
	private static void .cctor() { }

	// RVA: 0x21A0360 Offset: 0x219E960 VA: 0x1821A0360 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP862 : ByteEncoding // TypeDefIndex: 7969
{	// Fields
	private static readonly char[] ToChars; // 0x2B10510

	// Methods

	// RVA: 0x21A1E30 Offset: 0x21A0430 VA: 0x1821A1E30
	public void .ctor() { }

	// RVA: 0x21A1DC0 Offset: 0x21A03C0 VA: 0x1821A1DC0
	private static void .cctor() { }

	// RVA: 0x21A11B0 Offset: 0x219F7B0 VA: 0x1821A11B0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP864 : ByteEncoding // TypeDefIndex: 7971
{	// Fields
	private static readonly char[] ToChars; // 0x28A0

	// Methods

	// RVA: 0x22EADA0 Offset: 0x22E93A0 VA: 0x1822EADA0
	public void .ctor() { }

	// RVA: 0x22EAD30 Offset: 0x22E9330 VA: 0x1822EAD30
	private static void .cctor() { }

	// RVA: 0x22EA040 Offset: 0x22E8640 VA: 0x1822EA040 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP10000 : ByteEncoding // TypeDefIndex: 7977
{	// Fields
	private static readonly char[] ToChars; // 0x28F9

	// Methods

	// RVA: 0x2284110 Offset: 0x2282710 VA: 0x182284110
	public void .ctor() { }

	// RVA: 0x22840A0 Offset: 0x22826A0 VA: 0x1822840A0
	private static void .cctor() { }

	// RVA: 0x22836E0 Offset: 0x2281CE0 VA: 0x1822836E0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP10079 : ByteEncoding // TypeDefIndex: 7979
{	// Fields
	private static readonly char[] ToChars; // 0x2B10360

	// Methods

	// RVA: 0x2284BA0 Offset: 0x22831A0 VA: 0x182284BA0
	public void .ctor() { }

	// RVA: 0x2284B30 Offset: 0x2283130 VA: 0x182284B30
	private static void .cctor() { }

	// RVA: 0x22841C0 Offset: 0x22827C0 VA: 0x1822841C0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1250 : ByteEncoding // TypeDefIndex: 7981
{	// Fields
	private static readonly char[] ToChars; // 0x2900

	// Methods

	// RVA: 0x22853A0 Offset: 0x22839A0 VA: 0x1822853A0
	public void .ctor() { }

	// RVA: 0x2285330 Offset: 0x2283930 VA: 0x182285330
	private static void .cctor() { }

	// RVA: 0x2284C50 Offset: 0x2283250 VA: 0x182284C50 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1252 : ByteEncoding // TypeDefIndex: 7983
{	// Fields
	private static readonly char[] ToChars; // 0x2967

	// Methods

	// RVA: 0x22858E0 Offset: 0x2283EE0 VA: 0x1822858E0
	public void .ctor() { }

	// RVA: 0x2285870 Offset: 0x2283E70 VA: 0x182285870
	private static void .cctor() { }

	// RVA: 0x2285460 Offset: 0x2283A60 VA: 0x182285460 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1253 : ByteEncoding // TypeDefIndex: 7985
{	// Fields
	private static readonly char[] ToChars; // 0x2B104D4

	// Methods

	// RVA: 0x2285DF0 Offset: 0x22843F0 VA: 0x182285DF0
	public void .ctor() { }

	// RVA: 0x2285D80 Offset: 0x2284380 VA: 0x182285D80
	private static void .cctor() { }

	// RVA: 0x22859A0 Offset: 0x2283FA0 VA: 0x1822859A0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28592 : ByteEncoding // TypeDefIndex: 7987
{	// Fields
	private static readonly char[] ToChars; // 0x2970

	// Methods

	// RVA: 0x22869E0 Offset: 0x2284FE0 VA: 0x1822869E0
	public void .ctor() { }

	// RVA: 0x2286970 Offset: 0x2284F70 VA: 0x182286970
	private static void .cctor() { }

	// RVA: 0x2285EB0 Offset: 0x22844B0 VA: 0x182285EB0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28593 : ByteEncoding // TypeDefIndex: 7989
{	// Fields
	private static readonly char[] ToChars; // 0x29CC

	// Methods

	// RVA: 0x2286EA0 Offset: 0x22854A0 VA: 0x182286EA0
	public void .ctor() { }

	// RVA: 0x2286E30 Offset: 0x2285430 VA: 0x182286E30
	private static void .cctor() { }

	// RVA: 0x2286A90 Offset: 0x2285090 VA: 0x182286A90 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28597 : ByteEncoding // TypeDefIndex: 7991
{	// Fields
	private static readonly char[] ToChars; // 0x2B10380

	// Methods

	// RVA: 0x2287220 Offset: 0x2285820 VA: 0x182287220
	public void .ctor() { }

	// RVA: 0x22871B0 Offset: 0x22857B0 VA: 0x1822871B0
	private static void .cctor() { }

	// RVA: 0x2286F50 Offset: 0x2285550 VA: 0x182286F50 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28605 : ByteEncoding // TypeDefIndex: 7993
{	// Fields
	private static readonly char[] ToChars; // 0x29D0

	// Methods

	// RVA: 0x2287580 Offset: 0x2285B80 VA: 0x182287580
	public void .ctor() { }

	// RVA: 0x2287510 Offset: 0x2285B10 VA: 0x182287510
	private static void .cctor() { }

	// RVA: 0x22872D0 Offset: 0x22858D0 VA: 0x1822872D0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP437 : ByteEncoding // TypeDefIndex: 7995
{	// Fields
	private static readonly char[] ToChars; // 0x29F8

	// Methods

	// RVA: 0x2288D20 Offset: 0x2287320 VA: 0x182288D20
	public void .ctor() { }

	// RVA: 0x2288CB0 Offset: 0x22872B0 VA: 0x182288CB0
	private static void .cctor() { }

	// RVA: 0x2287630 Offset: 0x2285C30 VA: 0x182287630 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP850 : ByteEncoding // TypeDefIndex: 7997
{	// Fields
	private static readonly char[] ToChars; // 0x2B10394

	// Methods

	// RVA: 0x2289B70 Offset: 0x2288170 VA: 0x182289B70
	public void .ctor() { }

	// RVA: 0x2289B00 Offset: 0x2288100 VA: 0x182289B00
	private static void .cctor() { }

	// RVA: 0x2288DD0 Offset: 0x22873D0 VA: 0x182288DD0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP860 : ByteEncoding // TypeDefIndex: 7999
{	// Fields
	private static readonly char[] ToChars; // 0x2A00

	// Methods

	// RVA: 0x228A9D0 Offset: 0x2288FD0 VA: 0x18228A9D0
	public void .ctor() { }

	// RVA: 0x228A960 Offset: 0x2288F60 VA: 0x18228A960
	private static void .cctor() { }

	// RVA: 0x2289C20 Offset: 0x2288220 VA: 0x182289C20 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP861 : ByteEncoding // TypeDefIndex: 8001
{	// Fields
	private static readonly char[] ToChars; // 0x2A5C

	// Methods

	// RVA: 0x228B830 Offset: 0x2289E30 VA: 0x18228B830
	public void .ctor() { }

	// RVA: 0x228B7C0 Offset: 0x2289DC0 VA: 0x18228B7C0
	private static void .cctor() { }

	// RVA: 0x228AA80 Offset: 0x2289080 VA: 0x18228AA80 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP863 : ByteEncoding // TypeDefIndex: 8003
{	// Fields
	private static readonly char[] ToChars; // 0x2B10380

	// Methods

	// RVA: 0x228C680 Offset: 0x228AC80 VA: 0x18228C680
	public void .ctor() { }

	// RVA: 0x228C610 Offset: 0x228AC10 VA: 0x18228C610
	private static void .cctor() { }

	// RVA: 0x228B8E0 Offset: 0x2289EE0 VA: 0x18228B8E0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP865 : ByteEncoding // TypeDefIndex: 8005
{	// Fields
	private static readonly char[] ToChars; // 0x2A60

	// Methods

	// RVA: 0x228D4E0 Offset: 0x228BAE0 VA: 0x18228D4E0
	public void .ctor() { }

	// RVA: 0x228D470 Offset: 0x228BA70 VA: 0x18228D470
	private static void .cctor() { }

	// RVA: 0x228C730 Offset: 0x228AD30 VA: 0x18228C730 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

