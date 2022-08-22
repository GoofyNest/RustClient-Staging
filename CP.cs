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

	// RVA: 0x224C390 Offset: 0x224A990 VA: 0x18224C390
	public void .ctor() { }

	// RVA: 0x224B6F0 Offset: 0x2249CF0 VA: 0x18224B6F0 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x224B900 Offset: 0x2249F00 VA: 0x18224B900 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x224BFA0 Offset: 0x224A5A0 VA: 0x18224BFA0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224C100 Offset: 0x224A700 VA: 0x18224C100 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224C290 Offset: 0x224A890 VA: 0x18224C290 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x224C310 Offset: 0x224A910 VA: 0x18224C310 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x224C1F0 Offset: 0x224A7F0 VA: 0x18224C1F0 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x224C3A0 Offset: 0x224A9A0 VA: 0x18224C3A0 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224C3D0 Offset: 0x224A9D0 VA: 0x18224C3D0 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224C400 Offset: 0x224AA00 VA: 0x18224C400 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 15
	public override bool get_IsMailNewsSave() { }

	// RVA: 0x224C430 Offset: 0x224AA30 VA: 0x18224C430 Slot: 10
	public override string get_WebName() { }

	// RVA: 0x224C460 Offset: 0x224AA60 VA: 0x18224C460 Slot: 11
	public override int get_WindowsCodePage() { }

}

internal sealed class CP932Decoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7798
{	// Fields
	private JISConvert convert; // 0x28
	private int last_byte_count; // 0x30
	private int last_byte_chars; // 0x34

	// Methods

	// RVA: 0x224B6A0 Offset: 0x2249CA0 VA: 0x18224B6A0
	public void .ctor(JISConvert convert) { }

	// RVA: 0x224B1E0 Offset: 0x22497E0 VA: 0x18224B1E0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224B100 Offset: 0x2249700 VA: 0x18224B100 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	// RVA: 0x224B2A0 Offset: 0x22498A0 VA: 0x18224B2A0 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224B2D0 Offset: 0x22498D0 VA: 0x18224B2D0 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

}

public class CP50220 : ISO2022JPEncoding // TypeDefIndex: 7800
{	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x2249B00 Offset: 0x2248100 VA: 0x182249B00
	public void .ctor() { }

	// RVA: 0x2249B30 Offset: 0x2248130 VA: 0x182249B30 Slot: 8
	public override string get_EncodingName() { }

}

public class CP50221 : ISO2022JPEncoding // TypeDefIndex: 7801
{	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x2249B60 Offset: 0x2248160 VA: 0x182249B60
	public void .ctor() { }

	// RVA: 0x2249B90 Offset: 0x2248190 VA: 0x182249B90 Slot: 8
	public override string get_EncodingName() { }

}

public class CP50222 : ISO2022JPEncoding // TypeDefIndex: 7802
{	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x2249BC0 Offset: 0x22481C0 VA: 0x182249BC0
	public void .ctor() { }

	// RVA: 0x2249BF0 Offset: 0x22481F0 VA: 0x182249BF0 Slot: 8
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

	// RVA: 0x224AF10 Offset: 0x2249510 VA: 0x18224AF10
	public void .ctor() { }

	// RVA: 0x224AA80 Offset: 0x2249080 VA: 0x18224AA80 Slot: 19
	public override int GetByteCount(char[] chars, int index, int length) { }

	// RVA: 0x224A9E0 Offset: 0x2248FE0 VA: 0x18224A9E0 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x224AB30 Offset: 0x2249130 VA: 0x18224AB30 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x224ABF0 Offset: 0x22491F0 VA: 0x18224ABF0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224AC90 Offset: 0x2249290 VA: 0x18224AC90 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224AE10 Offset: 0x2249410 VA: 0x18224AE10 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x224AE90 Offset: 0x2249490 VA: 0x18224AE90 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x224ADB0 Offset: 0x22493B0 VA: 0x18224ADB0 Slot: 39
	public override Encoder GetEncoder() { }

	// RVA: 0x224AD50 Offset: 0x2249350 VA: 0x18224AD50 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x224AF30 Offset: 0x2249530 VA: 0x18224AF30 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224AF60 Offset: 0x2249560 VA: 0x18224AF60 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224AF90 Offset: 0x2249590 VA: 0x18224AF90 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 15
	public override bool get_IsMailNewsSave() { }

	// RVA: 0x224AFC0 Offset: 0x22495C0 VA: 0x18224AFC0 Slot: 10
	public override string get_WebName() { }

}

public class CP51932Encoder : MonoEncoder // TypeDefIndex: 7809
{	// Methods

	// RVA: 0x224A9D0 Offset: 0x2248FD0 VA: 0x18224A9D0
	public void .ctor(MonoEncoding encoding) { }

	// RVA: 0x224A3C0 Offset: 0x22489C0 VA: 0x18224A3C0 Slot: 11
	public override int GetByteCountImpl(char* chars, int count, bool refresh) { }

	// RVA: 0x224A5D0 Offset: 0x2248BD0 VA: 0x18224A5D0 Slot: 12
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool refresh) { }

}

internal class CP51932Decoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7810
{	// Fields
	private int last_count; // 0x28
	private int last_bytes; // 0x2C

	// Methods

	// RVA: 0x224A390 Offset: 0x2248990 VA: 0x18224A390
	public void .ctor() { }

	// RVA: 0xE4D640 Offset: 0xE4BC40 VA: 0x180E4D640 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x2249C20 Offset: 0x2248220 VA: 0x182249C20 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	// RVA: 0x18ACC90 Offset: 0x18AB290 VA: 0x1818ACC90 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2249E60 Offset: 0x2248460 VA: 0x182249E60 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

	// RVA: 0x224A320 Offset: 0x2248920 VA: 0x18224A320
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

	// RVA: 0x224CEE0 Offset: 0x224B4E0 VA: 0x18224CEE0
	public void .ctor() { }

	// RVA: 0x224CE00 Offset: 0x224B400 VA: 0x18224CE00 Slot: 48
	internal override DbcsConvert GetConvert() { }

	// RVA: 0x224CA60 Offset: 0x224B060 VA: 0x18224CA60 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x224CB50 Offset: 0x224B150 VA: 0x18224CB50 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x224CD20 Offset: 0x224B320 VA: 0x18224CD20 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224CD90 Offset: 0x224B390 VA: 0x18224CD90 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224CE60 Offset: 0x224B460 VA: 0x18224CE60 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x224CEF0 Offset: 0x224B4F0 VA: 0x18224CEF0 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224CF20 Offset: 0x224B520 VA: 0x18224CF20 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224CF50 Offset: 0x224B550 VA: 0x18224CF50 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 15
	public override bool get_IsMailNewsSave() { }

	// RVA: 0x224CF80 Offset: 0x224B580 VA: 0x18224CF80 Slot: 10
	public override string get_WebName() { }

}

internal sealed class CP936Decoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7813
{	// Fields
	private int last_byte_count; // 0x28
	private int last_byte_bytes; // 0x2C

	// Methods

	// RVA: 0x15C0D00 Offset: 0x15BF300 VA: 0x1815C0D00
	public void .ctor(DbcsConvert convert) { }

	// RVA: 0x224C470 Offset: 0x224AA70 VA: 0x18224C470 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224C530 Offset: 0x224AB30 VA: 0x18224C530 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	// RVA: 0x224C600 Offset: 0x224AC00 VA: 0x18224C600 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224C810 Offset: 0x224AE10 VA: 0x18224C810 Slot: 9
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

	// RVA: 0x224CFB0 Offset: 0x224B5B0 VA: 0x18224CFB0
	public void .ctor() { }

	// RVA: 0x224CFE0 Offset: 0x224B5E0 VA: 0x18224CFE0 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224D010 Offset: 0x224B610 VA: 0x18224D010 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224D040 Offset: 0x224B640 VA: 0x18224D040 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x224D070 Offset: 0x224B670 VA: 0x18224D070 Slot: 10
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

	// RVA: 0x224AFF0 Offset: 0x22495F0 VA: 0x18224AFF0
	public void .ctor() { }

	// RVA: 0x224B020 Offset: 0x2249620 VA: 0x18224B020 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224B050 Offset: 0x2249650 VA: 0x18224B050 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224B080 Offset: 0x2249680 VA: 0x18224B080 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x224B0B0 Offset: 0x22496B0 VA: 0x18224B0B0 Slot: 10
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

	// RVA: 0x224D9C0 Offset: 0x224BFC0 VA: 0x18224D9C0
	public void .ctor() { }

	// RVA: 0x224D8E0 Offset: 0x224BEE0 VA: 0x18224D8E0 Slot: 48
	internal override DbcsConvert GetConvert() { }

	// RVA: 0x224D7F0 Offset: 0x224BDF0 VA: 0x18224D7F0 Slot: 46
	public override int GetByteCountImpl(char* chars, int count) { }

	// RVA: 0x224CB50 Offset: 0x224B150 VA: 0x18224CB50 Slot: 47
	public override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x224CD90 Offset: 0x224B390 VA: 0x18224CD90 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224D940 Offset: 0x224BF40 VA: 0x18224D940 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x224D9D0 Offset: 0x224BFD0 VA: 0x18224D9D0 Slot: 7
	public override string get_BodyName() { }

	// RVA: 0x224DA00 Offset: 0x224C000 VA: 0x18224DA00 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x224DA30 Offset: 0x224C030 VA: 0x18224DA30 Slot: 9
	public override string get_HeaderName() { }

	// RVA: 0x224DA60 Offset: 0x224C060 VA: 0x18224DA60 Slot: 10
	public override string get_WebName() { }

}

private sealed class CP950.CP950Decoder : DbcsEncoding.DbcsDecoder // TypeDefIndex: 7822
{	// Fields
	private int last_byte_count; // 0x28
	private int last_byte_conv; // 0x2C

	// Methods

	// RVA: 0x15C0D00 Offset: 0x15BF300 VA: 0x1815C0D00
	public void .ctor(DbcsConvert convert) { }

	// RVA: 0x224D0A0 Offset: 0x224B6A0 VA: 0x18224D0A0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x224D1E0 Offset: 0x224B7E0 VA: 0x18224D1E0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool refresh) { }

	// RVA: 0x224D330 Offset: 0x224B930 VA: 0x18224D330 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x224D570 Offset: 0x224BB70 VA: 0x18224D570 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool refresh) { }

}

public class CP54936 : GB18030Encoding // TypeDefIndex: 7829
{	// Methods

	// RVA: 0x224B0E0 Offset: 0x22496E0 VA: 0x18224B0E0
	public void .ctor() { }

}

public class CP1254 : ByteEncoding // TypeDefIndex: 7840
{	// Fields
	private static readonly char[] ToChars; // 0x2356

	// Methods

	// RVA: 0x23052D0 Offset: 0x23038D0 VA: 0x1823052D0
	public void .ctor() { }

	// RVA: 0x2305260 Offset: 0x2303860 VA: 0x182305260
	private static void .cctor() { }

	// RVA: 0x2304E00 Offset: 0x2303400 VA: 0x182304E00 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1255 : ByteEncoding // TypeDefIndex: 7842
{	// Fields
	private static readonly char[] ToChars; // 0x2B10180

	// Methods

	// RVA: 0x2305810 Offset: 0x2303E10 VA: 0x182305810
	public void .ctor() { }

	// RVA: 0x23057A0 Offset: 0x2303DA0 VA: 0x1823057A0
	private static void .cctor() { }

	// RVA: 0x2305390 Offset: 0x2303990 VA: 0x182305390 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1256 : ByteEncoding // TypeDefIndex: 7844
{	// Fields
	private static readonly char[] ToChars; // 0x2360

	// Methods

	// RVA: 0x2306370 Offset: 0x2304970 VA: 0x182306370
	public void .ctor() { }

	// RVA: 0x2306300 Offset: 0x2304900 VA: 0x182306300
	private static void .cctor() { }

	// RVA: 0x23058C0 Offset: 0x2303EC0 VA: 0x1823058C0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28596 : ByteEncoding // TypeDefIndex: 7846
{	// Fields
	private static readonly char[] ToChars; // 0x2391

	// Methods

	// RVA: 0x2306E50 Offset: 0x2305450 VA: 0x182306E50
	public void .ctor() { }

	// RVA: 0x2306DE0 Offset: 0x23053E0 VA: 0x182306DE0
	private static void .cctor() { }

	// RVA: 0x2306420 Offset: 0x2304A20 VA: 0x182306420 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28598 : ByteEncoding // TypeDefIndex: 7848
{	// Fields
	private static readonly char[] ToChars; // 0x2B101B4

	// Methods

	// RVA: 0x2307180 Offset: 0x2305780 VA: 0x182307180
	public void .ctor() { }

	// RVA: 0x2307110 Offset: 0x2305710 VA: 0x182307110
	private static void .cctor() { }

	// RVA: 0x2306F00 Offset: 0x2305500 VA: 0x182306F00 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28599 : ByteEncoding // TypeDefIndex: 7850
{	// Fields
	private static readonly char[] ToChars; // 0x23A0

	// Methods

	// RVA: 0x23074B0 Offset: 0x2305AB0 VA: 0x1823074B0
	public void .ctor() { }

	// RVA: 0x2307440 Offset: 0x2305A40 VA: 0x182307440
	private static void .cctor() { }

	// RVA: 0x2307230 Offset: 0x2305830 VA: 0x182307230 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP38598 : ByteEncoding // TypeDefIndex: 7852
{	// Fields
	private static readonly char[] ToChars; // 0x2417

	// Methods

	// RVA: 0x23075D0 Offset: 0x2305BD0 VA: 0x1823075D0
	public void .ctor() { }

	// RVA: 0x2307560 Offset: 0x2305B60 VA: 0x182307560
	private static void .cctor() { }

	// RVA: 0x2306F00 Offset: 0x2305500 VA: 0x182306F00 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1251 : ByteEncoding // TypeDefIndex: 7858
{	// Fields
	private static readonly char[] ToChars; // 0x2B10330

	// Methods

	// RVA: 0x22F1390 Offset: 0x22EF990 VA: 0x1822F1390
	public void .ctor() { }

	// RVA: 0x22F1320 Offset: 0x22EF920 VA: 0x1822F1320
	private static void .cctor() { }

	// RVA: 0x22F0DE0 Offset: 0x22EF3E0 VA: 0x1822F0DE0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1257 : ByteEncoding // TypeDefIndex: 7860
{	// Fields
	private static readonly char[] ToChars; // 0x2420

	// Methods

	// RVA: 0x22F1C40 Offset: 0x22F0240 VA: 0x1822F1C40
	public void .ctor() { }

	// RVA: 0x22F1BD0 Offset: 0x22F01D0 VA: 0x1822F1BD0
	private static void .cctor() { }

	// RVA: 0x22F1450 Offset: 0x22EFA50 VA: 0x1822F1450 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1258 : ByteEncoding // TypeDefIndex: 7862
{	// Fields
	private static readonly char[] ToChars; // 0x24B7

	// Methods

	// RVA: 0x22F21F0 Offset: 0x22F07F0 VA: 0x1822F21F0
	public void .ctor() { }

	// RVA: 0x22F2180 Offset: 0x22F0780 VA: 0x1822F2180
	private static void .cctor() { }

	// RVA: 0x22F1D00 Offset: 0x22F0300 VA: 0x1822F1D00 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20866 : ByteEncoding // TypeDefIndex: 7864
{	// Fields
	private static readonly char[] ToChars; // 0x2B10390

	// Methods

	// RVA: 0x22F2A20 Offset: 0x22F1020 VA: 0x1822F2A20
	public void .ctor() { }

	// RVA: 0x22F29B0 Offset: 0x22F0FB0 VA: 0x1822F29B0
	private static void .cctor() { }

	// RVA: 0x22F22A0 Offset: 0x22F08A0 VA: 0x1822F22A0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP21866 : ByteEncoding // TypeDefIndex: 7866
{	// Fields
	private static readonly char[] ToChars; // 0x24C0

	// Methods

	// RVA: 0x22F3330 Offset: 0x22F1930 VA: 0x1822F3330
	public void .ctor() { }

	// RVA: 0x22F32C0 Offset: 0x22F18C0 VA: 0x1822F32C0
	private static void .cctor() { }

	// RVA: 0x22F2AD0 Offset: 0x22F10D0 VA: 0x1822F2AD0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28594 : ByteEncoding // TypeDefIndex: 7868
{	// Fields
	private static readonly char[] ToChars; // 0x2527

	// Methods

	// RVA: 0x22F39D0 Offset: 0x22F1FD0 VA: 0x1822F39D0
	public void .ctor() { }

	// RVA: 0x22F3960 Offset: 0x22F1F60 VA: 0x1822F3960
	private static void .cctor() { }

	// RVA: 0x22F33E0 Offset: 0x22F19E0 VA: 0x1822F33E0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28595 : ByteEncoding // TypeDefIndex: 7870
{	// Fields
	private static readonly char[] ToChars; // 0x2B10190

	// Methods

	// RVA: 0x22F3CF0 Offset: 0x22F22F0 VA: 0x1822F3CF0
	public void .ctor() { }

	// RVA: 0x22F3C80 Offset: 0x22F2280 VA: 0x1822F3C80
	private static void .cctor() { }

	// RVA: 0x22F3A80 Offset: 0x22F2080 VA: 0x1822F3A80 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP57002 : ISCIIEncoding // TypeDefIndex: 7873
{	// Methods

	// RVA: 0x22F3DA0 Offset: 0x22F23A0 VA: 0x1822F3DA0
	public void .ctor() { }

}

public class CP57003 : ISCIIEncoding // TypeDefIndex: 7874
{	// Methods

	// RVA: 0x22F3E20 Offset: 0x22F2420 VA: 0x1822F3E20
	public void .ctor() { }

}

public class CP57004 : ISCIIEncoding // TypeDefIndex: 7875
{	// Methods

	// RVA: 0x22F3EA0 Offset: 0x22F24A0 VA: 0x1822F3EA0
	public void .ctor() { }

}

public class CP57005 : ISCIIEncoding // TypeDefIndex: 7876
{	// Methods

	// RVA: 0x22F3F20 Offset: 0x22F2520 VA: 0x1822F3F20
	public void .ctor() { }

}

public class CP57006 : ISCIIEncoding // TypeDefIndex: 7877
{	// Methods

	// RVA: 0x22F3FA0 Offset: 0x22F25A0 VA: 0x1822F3FA0
	public void .ctor() { }

}

public class CP57007 : ISCIIEncoding // TypeDefIndex: 7878
{	// Methods

	// RVA: 0x22F4020 Offset: 0x22F2620 VA: 0x1822F4020
	public void .ctor() { }

}

public class CP57008 : ISCIIEncoding // TypeDefIndex: 7879
{	// Methods

	// RVA: 0x22F40A0 Offset: 0x22F26A0 VA: 0x1822F40A0
	public void .ctor() { }

}

public class CP57009 : ISCIIEncoding // TypeDefIndex: 7880
{	// Methods

	// RVA: 0x22F4120 Offset: 0x22F2720 VA: 0x1822F4120
	public void .ctor() { }

}

public class CP57010 : ISCIIEncoding // TypeDefIndex: 7881
{	// Methods

	// RVA: 0x22F41A0 Offset: 0x22F27A0 VA: 0x1822F41A0
	public void .ctor() { }

}

public class CP57011 : ISCIIEncoding // TypeDefIndex: 7882
{	// Methods

	// RVA: 0x22F4220 Offset: 0x22F2820 VA: 0x1822F4220
	public void .ctor() { }

}

public class CP874 : ByteEncoding // TypeDefIndex: 7893
{	// Fields
	private static readonly char[] ToChars; // 0x2530

	// Methods

	// RVA: 0x22F45E0 Offset: 0x22F2BE0 VA: 0x1822F45E0
	public void .ctor() { }

	// RVA: 0x22F4570 Offset: 0x22F2B70 VA: 0x1822F4570
	private static void .cctor() { }

	// RVA: 0x22F42A0 Offset: 0x22F28A0 VA: 0x1822F42A0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP866 : ByteEncoding // TypeDefIndex: 7899
{	// Fields
	private static readonly char[] ToChars; // 0x2578

	// Methods

	// RVA: 0x22EAD60 Offset: 0x22E9360 VA: 0x1822EAD60
	public void .ctor() { }

	// RVA: 0x22EACF0 Offset: 0x22E92F0 VA: 0x1822EACF0
	private static void .cctor() { }

	// RVA: 0x22EA370 Offset: 0x22E8970 VA: 0x1822EA370 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1026 : ByteEncoding // TypeDefIndex: 7901
{	// Fields
	private static readonly char[] ToChars; // 0x2B10460

	// Methods

	// RVA: 0x21877D0 Offset: 0x2185DD0 VA: 0x1821877D0
	public void .ctor() { }

	// RVA: 0x2187760 Offset: 0x2185D60 VA: 0x182187760
	private static void .cctor() { }

	// RVA: 0x2186A70 Offset: 0x2185070 VA: 0x182186A70 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP869 : ByteEncoding // TypeDefIndex: 7903
{	// Fields
	private static readonly char[] ToChars; // 0x2580

	// Methods

	// RVA: 0x22EB980 Offset: 0x22E9F80 VA: 0x1822EB980
	public void .ctor() { }

	// RVA: 0x22EB910 Offset: 0x22E9F10 VA: 0x1822EB910
	private static void .cctor() { }

	// RVA: 0x22EAE10 Offset: 0x22E9410 VA: 0x1822EAE10 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP870 : ByteEncoding // TypeDefIndex: 7905
{	// Fields
	private static readonly char[] ToChars; // 0x25B9

	// Methods

	// RVA: 0x22EC7E0 Offset: 0x22EADE0 VA: 0x1822EC7E0
	public void .ctor() { }

	// RVA: 0x22EC770 Offset: 0x22EAD70 VA: 0x1822EC770
	private static void .cctor() { }

	// RVA: 0x22EBA30 Offset: 0x22EA030 VA: 0x1822EBA30 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP875 : ByteEncoding // TypeDefIndex: 7907
{	// Fields
	private static readonly char[] ToChars; // 0x2B101A0

	// Methods

	// RVA: 0x22ED380 Offset: 0x22EB980 VA: 0x1822ED380
	public void .ctor() { }

	// RVA: 0x22ED310 Offset: 0x22EB910 VA: 0x1822ED310
	private static void .cctor() { }

	// RVA: 0x22EC890 Offset: 0x22EAE90 VA: 0x1822EC890 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1047 : ByteEncoding // TypeDefIndex: 7909
{	// Fields
	private static readonly char[] ToChars; // 0x25C0

	// Methods

	// RVA: 0x2188580 Offset: 0x2186B80 VA: 0x182188580
	public void .ctor() { }

	// RVA: 0x2188510 Offset: 0x2186B10 VA: 0x182188510
	private static void .cctor() { }

	// RVA: 0x2187880 Offset: 0x2185E80 VA: 0x182187880 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1140 : ByteEncoding // TypeDefIndex: 7911
{	// Fields
	private static readonly char[] ToChars; // 0x25DD

	// Methods

	// RVA: 0x2189340 Offset: 0x2187940 VA: 0x182189340
	public void .ctor() { }

	// RVA: 0x21892D0 Offset: 0x21878D0 VA: 0x1821892D0
	private static void .cctor() { }

	// RVA: 0x2188630 Offset: 0x2186C30 VA: 0x182188630 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1141 : ByteEncoding // TypeDefIndex: 7913
{	// Fields
	private static readonly char[] ToChars; // 0x2B10188

	// Methods

	// RVA: 0x218A100 Offset: 0x2188700 VA: 0x18218A100
	public void .ctor() { }

	// RVA: 0x218A090 Offset: 0x2188690 VA: 0x18218A090
	private static void .cctor() { }

	// RVA: 0x21893F0 Offset: 0x21879F0 VA: 0x1821893F0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1142 : ByteEncoding // TypeDefIndex: 7915
{	// Fields
	private static readonly char[] ToChars; // 0x25E0

	// Methods

	// RVA: 0x218AEC0 Offset: 0x21894C0 VA: 0x18218AEC0
	public void .ctor() { }

	// RVA: 0x218AE50 Offset: 0x2189450 VA: 0x18218AE50
	private static void .cctor() { }

	// RVA: 0x218A1B0 Offset: 0x21887B0 VA: 0x18218A1B0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1143 : ByteEncoding // TypeDefIndex: 7917
{	// Fields
	private static readonly char[] ToChars; // 0x2649

	// Methods

	// RVA: 0x218BC80 Offset: 0x218A280 VA: 0x18218BC80
	public void .ctor() { }

	// RVA: 0x218BC10 Offset: 0x218A210 VA: 0x18218BC10
	private static void .cctor() { }

	// RVA: 0x218AF70 Offset: 0x2189570 VA: 0x18218AF70 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1144 : ByteEncoding // TypeDefIndex: 7919
{	// Fields
	private static readonly char[] ToChars; // 0x2B102FC

	// Methods

	// RVA: 0x218CA40 Offset: 0x218B040 VA: 0x18218CA40
	public void .ctor() { }

	// RVA: 0x218C9D0 Offset: 0x218AFD0 VA: 0x18218C9D0
	private static void .cctor() { }

	// RVA: 0x218BD30 Offset: 0x218A330 VA: 0x18218BD30 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1145 : ByteEncoding // TypeDefIndex: 7921
{	// Fields
	private static readonly char[] ToChars; // 0x2650

	// Methods

	// RVA: 0x218D800 Offset: 0x218BE00 VA: 0x18218D800
	public void .ctor() { }

	// RVA: 0x218D790 Offset: 0x218BD90 VA: 0x18218D790
	private static void .cctor() { }

	// RVA: 0x218CAF0 Offset: 0x218B0F0 VA: 0x18218CAF0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1146 : ByteEncoding // TypeDefIndex: 7923
{	// Fields
	private static readonly char[] ToChars; // 0x27F7

	// Methods

	// RVA: 0x218E5C0 Offset: 0x218CBC0 VA: 0x18218E5C0
	public void .ctor() { }

	// RVA: 0x218E550 Offset: 0x218CB50 VA: 0x18218E550
	private static void .cctor() { }

	// RVA: 0x218D8B0 Offset: 0x218BEB0 VA: 0x18218D8B0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1147 : ByteEncoding // TypeDefIndex: 7925
{	// Fields
	private static readonly char[] ToChars; // 0x2B10878

	// Methods

	// RVA: 0x218F380 Offset: 0x218D980 VA: 0x18218F380
	public void .ctor() { }

	// RVA: 0x218F310 Offset: 0x218D910 VA: 0x18218F310
	private static void .cctor() { }

	// RVA: 0x218E670 Offset: 0x218CC70 VA: 0x18218E670 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1148 : ByteEncoding // TypeDefIndex: 7927
{	// Fields
	private static readonly char[] ToChars; // 0x2800

	// Methods

	// RVA: 0x2190140 Offset: 0x218E740 VA: 0x182190140
	public void .ctor() { }

	// RVA: 0x21900D0 Offset: 0x218E6D0 VA: 0x1821900D0
	private static void .cctor() { }

	// RVA: 0x218F430 Offset: 0x218DA30 VA: 0x18218F430 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1149 : ByteEncoding // TypeDefIndex: 7929
{	// Fields
	private static readonly char[] ToChars; // 0x2845

	// Methods

	// RVA: 0x2190F00 Offset: 0x218F500 VA: 0x182190F00
	public void .ctor() { }

	// RVA: 0x2190E90 Offset: 0x218F490 VA: 0x182190E90
	private static void .cctor() { }

	// RVA: 0x21901F0 Offset: 0x218E7F0 VA: 0x1821901F0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20273 : ByteEncoding // TypeDefIndex: 7931
{	// Fields
	private static readonly char[] ToChars; // 0x2B10180

	// Methods

	// RVA: 0x2191CC0 Offset: 0x21902C0 VA: 0x182191CC0
	public void .ctor() { }

	// RVA: 0x2191C50 Offset: 0x2190250 VA: 0x182191C50
	private static void .cctor() { }

	// RVA: 0x2190FB0 Offset: 0x218F5B0 VA: 0x182190FB0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20277 : ByteEncoding // TypeDefIndex: 7933
{	// Fields
	private static readonly char[] ToChars; // 0x2850

	// Methods

	// RVA: 0x2192A80 Offset: 0x2191080 VA: 0x182192A80
	public void .ctor() { }

	// RVA: 0x2192A10 Offset: 0x2191010 VA: 0x182192A10
	private static void .cctor() { }

	// RVA: 0x2191D70 Offset: 0x2190370 VA: 0x182191D70 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20278 : ByteEncoding // TypeDefIndex: 7935
{	// Fields
	private static readonly char[] ToChars; // 0x2898

	// Methods

	// RVA: 0x2193840 Offset: 0x2191E40 VA: 0x182193840
	public void .ctor() { }

	// RVA: 0x21937D0 Offset: 0x2191DD0 VA: 0x1821937D0
	private static void .cctor() { }

	// RVA: 0x2192B30 Offset: 0x2191130 VA: 0x182192B30 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20280 : ByteEncoding // TypeDefIndex: 7937
{	// Fields
	private static readonly char[] ToChars; // 0x2B10330

	// Methods

	// RVA: 0x2194600 Offset: 0x2192C00 VA: 0x182194600
	public void .ctor() { }

	// RVA: 0x2194590 Offset: 0x2192B90 VA: 0x182194590
	private static void .cctor() { }

	// RVA: 0x21938F0 Offset: 0x2191EF0 VA: 0x1821938F0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20284 : ByteEncoding // TypeDefIndex: 7939
{	// Fields
	private static readonly char[] ToChars; // 0x28A0

	// Methods

	// RVA: 0x21953C0 Offset: 0x21939C0 VA: 0x1821953C0
	public void .ctor() { }

	// RVA: 0x2195350 Offset: 0x2193950 VA: 0x182195350
	private static void .cctor() { }

	// RVA: 0x21946B0 Offset: 0x2192CB0 VA: 0x1821946B0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20285 : ByteEncoding // TypeDefIndex: 7941
{	// Fields
	private static readonly char[] ToChars; // 0x28F9

	// Methods

	// RVA: 0x2196180 Offset: 0x2194780 VA: 0x182196180
	public void .ctor() { }

	// RVA: 0x2196110 Offset: 0x2194710 VA: 0x182196110
	private static void .cctor() { }

	// RVA: 0x2195470 Offset: 0x2193A70 VA: 0x182195470 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20290 : ByteEncoding // TypeDefIndex: 7943
{	// Fields
	private static readonly char[] ToChars; // 0x2B10180

	// Methods

	// RVA: 0x2196B10 Offset: 0x2195110 VA: 0x182196B10
	public void .ctor() { }

	// RVA: 0x2196AA0 Offset: 0x21950A0 VA: 0x182196AA0
	private static void .cctor() { }

	// RVA: 0x2196230 Offset: 0x2194830 VA: 0x182196230 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20297 : ByteEncoding // TypeDefIndex: 7945
{	// Fields
	private static readonly char[] ToChars; // 0x2900

	// Methods

	// RVA: 0x21978D0 Offset: 0x2195ED0 VA: 0x1821978D0
	public void .ctor() { }

	// RVA: 0x2197860 Offset: 0x2195E60 VA: 0x182197860
	private static void .cctor() { }

	// RVA: 0x2196BC0 Offset: 0x21951C0 VA: 0x182196BC0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20420 : ByteEncoding // TypeDefIndex: 7947
{	// Fields
	private static readonly char[] ToChars; // 0x2967

	// Methods

	// RVA: 0x21986F0 Offset: 0x2196CF0 VA: 0x1821986F0
	public void .ctor() { }

	// RVA: 0x2198680 Offset: 0x2196C80 VA: 0x182198680
	private static void .cctor() { }

	// RVA: 0x2197980 Offset: 0x2195F80 VA: 0x182197980 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20424 : ByteEncoding // TypeDefIndex: 7949
{	// Fields
	private static readonly char[] ToChars; // 0x2B102F4

	// Methods

	// RVA: 0x2199190 Offset: 0x2197790 VA: 0x182199190
	public void .ctor() { }

	// RVA: 0x2199120 Offset: 0x2197720 VA: 0x182199120
	private static void .cctor() { }

	// RVA: 0x21987A0 Offset: 0x2196DA0 VA: 0x1821987A0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP20871 : ByteEncoding // TypeDefIndex: 7951
{	// Fields
	private static readonly char[] ToChars; // 0x2970

	// Methods

	// RVA: 0x2199F50 Offset: 0x2198550 VA: 0x182199F50
	public void .ctor() { }

	// RVA: 0x2199EE0 Offset: 0x21984E0 VA: 0x182199EE0
	private static void .cctor() { }

	// RVA: 0x2199240 Offset: 0x2197840 VA: 0x182199240 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP21025 : ByteEncoding // TypeDefIndex: 7953
{	// Fields
	private static readonly char[] ToChars; // 0x29CC

	// Methods

	// RVA: 0x219ABF0 Offset: 0x21991F0 VA: 0x18219ABF0
	public void .ctor() { }

	// RVA: 0x219AB80 Offset: 0x2199180 VA: 0x18219AB80
	private static void .cctor() { }

	// RVA: 0x219A000 Offset: 0x2198600 VA: 0x18219A000 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP37 : ByteEncoding // TypeDefIndex: 7955
{	// Fields
	private static readonly char[] ToChars; // 0x2B101A0

	// Methods

	// RVA: 0x219B9B0 Offset: 0x2199FB0 VA: 0x18219B9B0
	public void .ctor() { }

	// RVA: 0x219B940 Offset: 0x2199F40 VA: 0x18219B940
	private static void .cctor() { }

	// RVA: 0x219ACA0 Offset: 0x21992A0 VA: 0x18219ACA0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP500 : ByteEncoding // TypeDefIndex: 7957
{	// Fields
	private static readonly char[] ToChars; // 0x29D0

	// Methods

	// RVA: 0x219C770 Offset: 0x219AD70 VA: 0x18219C770
	public void .ctor() { }

	// RVA: 0x219C700 Offset: 0x219AD00 VA: 0x18219C700
	private static void .cctor() { }

	// RVA: 0x219BA60 Offset: 0x219A060 VA: 0x18219BA60 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP708 : ByteEncoding // TypeDefIndex: 7959
{	// Fields
	private static readonly char[] ToChars; // 0x29F8

	// Methods

	// RVA: 0x219CDF0 Offset: 0x219B3F0 VA: 0x18219CDF0
	public void .ctor() { }

	// RVA: 0x219CD80 Offset: 0x219B380 VA: 0x18219CD80
	private static void .cctor() { }

	// RVA: 0x219C820 Offset: 0x219AE20 VA: 0x18219C820 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP852 : ByteEncoding // TypeDefIndex: 7961
{	// Fields
	private static readonly char[] ToChars; // 0x2B101B4

	// Methods

	// RVA: 0x219DC50 Offset: 0x219C250 VA: 0x18219DC50
	public void .ctor() { }

	// RVA: 0x219DBE0 Offset: 0x219C1E0 VA: 0x18219DBE0
	private static void .cctor() { }

	// RVA: 0x219CEB0 Offset: 0x219B4B0 VA: 0x18219CEB0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP855 : ByteEncoding // TypeDefIndex: 7963
{	// Fields
	private static readonly char[] ToChars; // 0x2A00

	// Methods

	// RVA: 0x219E9F0 Offset: 0x219CFF0 VA: 0x18219E9F0
	public void .ctor() { }

	// RVA: 0x219E980 Offset: 0x219CF80 VA: 0x18219E980
	private static void .cctor() { }

	// RVA: 0x219DD00 Offset: 0x219C300 VA: 0x18219DD00 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP857 : ByteEncoding // TypeDefIndex: 7965
{	// Fields
	private static readonly char[] ToChars; // 0x2A5C

	// Methods

	// RVA: 0x219F7D0 Offset: 0x219DDD0 VA: 0x18219F7D0
	public void .ctor() { }

	// RVA: 0x219F760 Offset: 0x219DD60 VA: 0x18219F760
	private static void .cctor() { }

	// RVA: 0x219EAA0 Offset: 0x219D0A0 VA: 0x18219EAA0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP858 : ByteEncoding // TypeDefIndex: 7967
{	// Fields
	private static readonly char[] ToChars; // 0x2B101A0

	// Methods

	// RVA: 0x21A0620 Offset: 0x219EC20 VA: 0x1821A0620
	public void .ctor() { }

	// RVA: 0x21A05B0 Offset: 0x219EBB0 VA: 0x1821A05B0
	private static void .cctor() { }

	// RVA: 0x219F880 Offset: 0x219DE80 VA: 0x18219F880 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP862 : ByteEncoding // TypeDefIndex: 7969
{	// Fields
	private static readonly char[] ToChars; // 0x2A60

	// Methods

	// RVA: 0x21A1350 Offset: 0x219F950 VA: 0x1821A1350
	public void .ctor() { }

	// RVA: 0x21A12E0 Offset: 0x219F8E0 VA: 0x1821A12E0
	private static void .cctor() { }

	// RVA: 0x21A06D0 Offset: 0x219ECD0 VA: 0x1821A06D0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP864 : ByteEncoding // TypeDefIndex: 7971
{	// Fields
	private static readonly char[] ToChars; // 0x2AB5

	// Methods

	// RVA: 0x22EA2C0 Offset: 0x22E88C0 VA: 0x1822EA2C0
	public void .ctor() { }

	// RVA: 0x22EA250 Offset: 0x22E8850 VA: 0x1822EA250
	private static void .cctor() { }

	// RVA: 0x22E9560 Offset: 0x22E7B60 VA: 0x1822E9560 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP10000 : ByteEncoding // TypeDefIndex: 7977
{	// Fields
	private static readonly char[] ToChars; // 0x2B10190

	// Methods

	// RVA: 0x2283630 Offset: 0x2281C30 VA: 0x182283630
	public void .ctor() { }

	// RVA: 0x22835C0 Offset: 0x2281BC0 VA: 0x1822835C0
	private static void .cctor() { }

	// RVA: 0x2282C00 Offset: 0x2281200 VA: 0x182282C00 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP10079 : ByteEncoding // TypeDefIndex: 7979
{	// Fields
	private static readonly char[] ToChars; // 0x2AC0

	// Methods

	// RVA: 0x22840C0 Offset: 0x22826C0 VA: 0x1822840C0
	public void .ctor() { }

	// RVA: 0x2284050 Offset: 0x2282650 VA: 0x182284050
	private static void .cctor() { }

	// RVA: 0x22836E0 Offset: 0x2281CE0 VA: 0x1822836E0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1250 : ByteEncoding // TypeDefIndex: 7981
{	// Fields
	private static readonly char[] ToChars; // 0x2B27

	// Methods

	// RVA: 0x22848C0 Offset: 0x2282EC0 VA: 0x1822848C0
	public void .ctor() { }

	// RVA: 0x2284850 Offset: 0x2282E50 VA: 0x182284850
	private static void .cctor() { }

	// RVA: 0x2284170 Offset: 0x2282770 VA: 0x182284170 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1252 : ByteEncoding // TypeDefIndex: 7983
{	// Fields
	private static readonly char[] ToChars; // 0x2B101A0

	// Methods

	// RVA: 0x2284E00 Offset: 0x2283400 VA: 0x182284E00
	public void .ctor() { }

	// RVA: 0x2284D90 Offset: 0x2283390 VA: 0x182284D90
	private static void .cctor() { }

	// RVA: 0x2284980 Offset: 0x2282F80 VA: 0x182284980 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP1253 : ByteEncoding // TypeDefIndex: 7985
{	// Fields
	private static readonly char[] ToChars; // 0x2B30

	// Methods

	// RVA: 0x2285310 Offset: 0x2283910 VA: 0x182285310
	public void .ctor() { }

	// RVA: 0x22852A0 Offset: 0x22838A0 VA: 0x1822852A0
	private static void .cctor() { }

	// RVA: 0x2284EC0 Offset: 0x22834C0 VA: 0x182284EC0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28592 : ByteEncoding // TypeDefIndex: 7987
{	// Fields
	private static readonly char[] ToChars; // 0x2B4F

	// Methods

	// RVA: 0x2285F00 Offset: 0x2284500 VA: 0x182285F00
	public void .ctor() { }

	// RVA: 0x2285E90 Offset: 0x2284490 VA: 0x182285E90
	private static void .cctor() { }

	// RVA: 0x22853D0 Offset: 0x22839D0 VA: 0x1822853D0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28593 : ByteEncoding // TypeDefIndex: 7989
{	// Fields
	private static readonly char[] ToChars; // 0x2B10188

	// Methods

	// RVA: 0x22863C0 Offset: 0x22849C0 VA: 0x1822863C0
	public void .ctor() { }

	// RVA: 0x2286350 Offset: 0x2284950 VA: 0x182286350
	private static void .cctor() { }

	// RVA: 0x2285FB0 Offset: 0x22845B0 VA: 0x182285FB0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28597 : ByteEncoding // TypeDefIndex: 7991
{	// Fields
	private static readonly char[] ToChars; // 0x2B50

	// Methods

	// RVA: 0x2286740 Offset: 0x2284D40 VA: 0x182286740
	public void .ctor() { }

	// RVA: 0x22866D0 Offset: 0x2284CD0 VA: 0x1822866D0
	private static void .cctor() { }

	// RVA: 0x2286470 Offset: 0x2284A70 VA: 0x182286470 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP28605 : ByteEncoding // TypeDefIndex: 7993
{	// Fields
	private static readonly char[] ToChars; // 0x2BC1

	// Methods

	// RVA: 0x2286AA0 Offset: 0x22850A0 VA: 0x182286AA0
	public void .ctor() { }

	// RVA: 0x2286A30 Offset: 0x2285030 VA: 0x182286A30
	private static void .cctor() { }

	// RVA: 0x22867F0 Offset: 0x2284DF0 VA: 0x1822867F0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP437 : ByteEncoding // TypeDefIndex: 7995
{	// Fields
	private static readonly char[] ToChars; // 0x2B10304

	// Methods

	// RVA: 0x2288240 Offset: 0x2286840 VA: 0x182288240
	public void .ctor() { }

	// RVA: 0x22881D0 Offset: 0x22867D0 VA: 0x1822881D0
	private static void .cctor() { }

	// RVA: 0x2286B50 Offset: 0x2285150 VA: 0x182286B50 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP850 : ByteEncoding // TypeDefIndex: 7997
{	// Fields
	private static readonly char[] ToChars; // 0x2BD0

	// Methods

	// RVA: 0x2289090 Offset: 0x2287690 VA: 0x182289090
	public void .ctor() { }

	// RVA: 0x2289020 Offset: 0x2287620 VA: 0x182289020
	private static void .cctor() { }

	// RVA: 0x22882F0 Offset: 0x22868F0 VA: 0x1822882F0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP860 : ByteEncoding // TypeDefIndex: 7999
{	// Fields
	private static readonly char[] ToChars; // 0x2C22

	// Methods

	// RVA: 0x2289EF0 Offset: 0x22884F0 VA: 0x182289EF0
	public void .ctor() { }

	// RVA: 0x2289E80 Offset: 0x2288480 VA: 0x182289E80
	private static void .cctor() { }

	// RVA: 0x2289140 Offset: 0x2287740 VA: 0x182289140 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP861 : ByteEncoding // TypeDefIndex: 8001
{	// Fields
	private static readonly char[] ToChars; // 0x2B10260

	// Methods

	// RVA: 0x228AD50 Offset: 0x2289350 VA: 0x18228AD50
	public void .ctor() { }

	// RVA: 0x228ACE0 Offset: 0x22892E0 VA: 0x18228ACE0
	private static void .cctor() { }

	// RVA: 0x2289FA0 Offset: 0x22885A0 VA: 0x182289FA0 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP863 : ByteEncoding // TypeDefIndex: 8003
{	// Fields
	private static readonly char[] ToChars; // 0x2C30

	// Methods

	// RVA: 0x228BBA0 Offset: 0x228A1A0 VA: 0x18228BBA0
	public void .ctor() { }

	// RVA: 0x228BB30 Offset: 0x228A130 VA: 0x18228BB30
	private static void .cctor() { }

	// RVA: 0x228AE00 Offset: 0x2289400 VA: 0x18228AE00 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

public class CP865 : ByteEncoding // TypeDefIndex: 8005
{	// Fields
	private static readonly char[] ToChars; // 0x2C96

	// Methods

	// RVA: 0x228CA00 Offset: 0x228B000 VA: 0x18228CA00
	public void .ctor() { }

	// RVA: 0x228C990 Offset: 0x228AF90 VA: 0x18228C990
	private static void .cctor() { }

	// RVA: 0x228BC50 Offset: 0x228A250 VA: 0x18228BC50 Slot: 48
	protected override void ToBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

}

