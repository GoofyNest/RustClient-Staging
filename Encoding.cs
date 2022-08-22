public abstract class Encoder // TypeDefIndex: 444
{	// Fields
	internal EncoderFallback m_fallback; // 0x10
	internal EncoderFallbackBuffer m_fallbackBuffer; // 0x18

	// Properties
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public EncoderFallback Fallback { get; }
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public EncoderFallbackBuffer FallbackBuffer { get; }
	internal bool InternalHasFallbackBuffer { get; }

	// Methods

	// RVA: 0x18AF080 Offset: 0x18AD680 VA: 0x1818AF080
	internal void SerializeEncoder(SerializationInfo info) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public EncoderFallback get_Fallback() { }

	// RVA: 0x18AF0E0 Offset: 0x18AD6E0 VA: 0x1818AF0E0
	public EncoderFallbackBuffer get_FallbackBuffer() { }

	// RVA: 0x17CB400 Offset: 0x17C9A00 VA: 0x1817CB400
	internal bool get_InternalHasFallbackBuffer() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18AEFB0 Offset: 0x18AD5B0 VA: 0x1818AEFB0 Slot: 4
	public virtual void Reset() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetByteCount(char[] chars, int index, int count, bool flush);

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x18AEC10 Offset: 0x18AD210 VA: 0x1818AEC10 Slot: 6
	public virtual int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush);

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x18AED80 Offset: 0x18AD380 VA: 0x1818AED80 Slot: 8
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18AE8A0 Offset: 0x18ACEA0 VA: 0x1818AE8A0 Slot: 9
	public virtual void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x18AE660 Offset: 0x18ACC60 VA: 0x1818AE660 Slot: 10
	public virtual void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

}

public sealed class EncoderExceptionFallback : EncoderFallback // TypeDefIndex: 447
{	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0x18AE5B0 Offset: 0x18ACBB0 VA: 0x1818AE5B0 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x18AE600 Offset: 0x18ACC00 VA: 0x1818AE600 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x18AE650 Offset: 0x18ACC50 VA: 0x1818AE650 Slot: 2
	public override int GetHashCode() { }

}

public sealed class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 448
{	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0x18AE140 Offset: 0x18AC740 VA: 0x1818AE140 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x18AE250 Offset: 0x18AC850 VA: 0x1818AE250 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 8
	public override int get_Remaining() { }

}

public sealed class EncoderFallbackException : ArgumentException // TypeDefIndex: 449
{	// Fields
	private char charUnknown; // 0x90
	private char charUnknownHigh; // 0x92
	private char charUnknownLow; // 0x94
	private int index; // 0x98

	// Methods

	// RVA: 0x1913AA0 Offset: 0x19120A0 VA: 0x181913AA0
	public void .ctor() { }

	// RVA: 0x15C8540 Offset: 0x15C6B40 VA: 0x1815C8540
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1913B00 Offset: 0x1912100 VA: 0x181913B00
	internal void .ctor(string message, char charUnknown, int index) { }

	// RVA: 0x1913820 Offset: 0x1911E20 VA: 0x181913820
	internal void .ctor(string message, char charUnknownHigh, char charUnknownLow, int index) { }

}

public abstract class EncoderFallback // TypeDefIndex: 450
{	// Fields
	internal bool bIsMicrosoftBestFitFallback; // 0x10
	private static EncoderFallback replacementFallback; // 0x0
	private static EncoderFallback exceptionFallback; // 0x8
	private static object s_InternalSyncObject; // 0x10

	// Properties
	private static object InternalSyncObject { get; }
	public static EncoderFallback ReplacementFallback { get; }
	public static EncoderFallback ExceptionFallback { get; }
	public abstract int MaxCharCount { get; }

	// Methods

	// RVA: 0x1913D00 Offset: 0x1912300 VA: 0x181913D00
	private static object get_InternalSyncObject() { }

	// RVA: 0x1913D90 Offset: 0x1912390 VA: 0x181913D90
	public static EncoderFallback get_ReplacementFallback() { }

	// RVA: 0x1913B40 Offset: 0x1912140 VA: 0x181913B40
	public static EncoderFallback get_ExceptionFallback() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract EncoderFallbackBuffer CreateFallbackBuffer();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_MaxCharCount();

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

public abstract class EncoderFallbackBuffer // TypeDefIndex: 451
{	// Fields
	internal char* charStart; // 0x10
	internal char* charEnd; // 0x18
	internal EncoderNLS encoder; // 0x20
	internal bool setEncoder; // 0x28
	internal bool bUsedEncoder; // 0x29
	internal bool bFallingBack; // 0x2A
	internal int iRecursionCount; // 0x2C
	private const int iMaxRecursion = 250;

	// Properties
	public abstract int Remaining { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Fallback(char charUnknown, int index);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract char GetNextChar();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool MovePrevious();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_Remaining();

	// RVA: 0x1913730 Offset: 0x1911D30 VA: 0x181913730 Slot: 9
	public virtual void Reset() { }

	// RVA: 0x1913710 Offset: 0x1911D10 VA: 0x181913710
	internal void InternalReset() { }

	// RVA: 0x19136D0 Offset: 0x1911CD0 VA: 0x1819136D0
	internal void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder) { }

	// RVA: 0x1913690 Offset: 0x1911C90 VA: 0x181913690
	internal char InternalGetNextChar() { }

	// RVA: 0x19134D0 Offset: 0x1911AD0 VA: 0x1819134D0 Slot: 10
	internal virtual bool InternalFallback(char ch, ref char* chars) { }

	// RVA: 0x1913760 Offset: 0x1911D60 VA: 0x181913760
	internal void ThrowLastCharRecursive(int charRecursive) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

internal class EncoderNLS : Encoder, ISerializable // TypeDefIndex: 452
{	// Fields
	internal char charLeftOver; // 0x20
	protected Encoding m_encoding; // 0x28
	protected bool m_mustFlush; // 0x30
	internal bool m_throwOnOverflow; // 0x31
	internal int m_charsUsed; // 0x34

	// Properties
	public Encoding Encoding { get; }
	public bool MustFlush { get; }
	internal virtual bool HasState { get; }

	// Methods

	// RVA: 0x1914C50 Offset: 0x1913250 VA: 0x181914C50
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1914B20 Offset: 0x1913120 VA: 0x181914B20 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1914BE0 Offset: 0x19131E0 VA: 0x181914BE0
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x1914D10 Offset: 0x1913310 VA: 0x181914D10
	internal void .ctor() { }

	// RVA: 0x1914AF0 Offset: 0x19130F0 VA: 0x181914AF0 Slot: 4
	public override void Reset() { }

	// RVA: 0x1914450 Offset: 0x1912A50 VA: 0x181914450 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

	// RVA: 0x1914600 Offset: 0x1912C00 VA: 0x181914600 Slot: 6
	public override int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: 0x1914720 Offset: 0x1912D20 VA: 0x181914720 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: 0x19149A0 Offset: 0x1912FA0 VA: 0x1819149A0 Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x1913F70 Offset: 0x1912570 VA: 0x181913F70 Slot: 9
	public override void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	// RVA: 0x1914280 Offset: 0x1912880 VA: 0x181914280 Slot: 10
	public override void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public Encoding get_Encoding() { }

	// RVA: 0x82BDA0 Offset: 0x82A3A0 VA: 0x18082BDA0
	public bool get_MustFlush() { }

	// RVA: 0x1914D50 Offset: 0x1913350 VA: 0x181914D50 Slot: 12
	internal virtual bool get_HasState() { }

	// RVA: 0xF60020 Offset: 0xF5E620 VA: 0x180F60020
	internal void ClearMustFlush() { }

}

public sealed class EncoderReplacementFallback : EncoderFallback // TypeDefIndex: 453
{	// Fields
	private string strDefault; // 0x18

	// Properties
	public string DefaultString { get; }
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x1915390 Offset: 0x1913990 VA: 0x181915390
	public void .ctor() { }

	// RVA: 0x19153D0 Offset: 0x19139D0 VA: 0x1819153D0
	public void .ctor(string replacement) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_DefaultString() { }

	// RVA: 0x19152A0 Offset: 0x19138A0 VA: 0x1819152A0 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x18AD610 Offset: 0x18ABC10 VA: 0x1818AD610 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x1915320 Offset: 0x1913920 VA: 0x181915320 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0xAE5D30 Offset: 0xAE4330 VA: 0x180AE5D30 Slot: 2
	public override int GetHashCode() { }

}

public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 454
{	// Fields
	private string strDefault; // 0x30
	private int fallbackCount; // 0x38
	private int fallbackIndex; // 0x3C

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x1915230 Offset: 0x1913830 VA: 0x181915230
	public void .ctor(EncoderReplacementFallback fallback) { }

	// RVA: 0x1915020 Offset: 0x1913620 VA: 0x181915020 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x1914D60 Offset: 0x1913360 VA: 0x181914D60 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x19151A0 Offset: 0x19137A0 VA: 0x1819151A0 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x19151F0 Offset: 0x19137F0 VA: 0x1819151F0 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x1915290 Offset: 0x1913890 VA: 0x181915290 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x1915210 Offset: 0x1913810 VA: 0x181915210 Slot: 9
	public override void Reset() { }

}

public abstract class Encoding : ICloneable // TypeDefIndex: 455
{	// Fields
	private static Encoding defaultEncoding; // 0x0
	private static Encoding unicodeEncoding; // 0x8
	private static Encoding bigEndianUnicode; // 0x10
	private static Encoding utf7Encoding; // 0x18
	private static Encoding utf8Encoding; // 0x20
	private static Encoding utf32Encoding; // 0x28
	private static Encoding asciiEncoding; // 0x30
	private static Encoding latin1Encoding; // 0x38
	private static Hashtable encodings; // 0x40
	private const int MIMECONTF_MAILNEWS = 1;
	private const int MIMECONTF_BROWSER = 2;
	private const int MIMECONTF_SAVABLE_MAILNEWS = 256;
	private const int MIMECONTF_SAVABLE_BROWSER = 512;
	private const int CodePageDefault = 0;
	private const int CodePageNoOEM = 1;
	private const int CodePageNoMac = 2;
	private const int CodePageNoThread = 3;
	private const int CodePageNoSymbol = 42;
	private const int CodePageUnicode = 1200;
	private const int CodePageBigEndian = 1201;
	private const int CodePageWindows1252 = 1252;
	private const int CodePageMacGB2312 = 10008;
	private const int CodePageGB2312 = 20936;
	private const int CodePageMacKorean = 10003;
	private const int CodePageDLLKorean = 20949;
	private const int ISO2022JP = 50220;
	private const int ISO2022JPESC = 50221;
	private const int ISO2022JPSISO = 50222;
	private const int ISOKorean = 50225;
	private const int ISOSimplifiedCN = 50227;
	private const int EUCJP = 51932;
	private const int ChineseHZ = 52936;
	private const int DuplicateEUCCN = 51936;
	private const int EUCCN = 936;
	private const int EUCKR = 51949;
	internal const int CodePageASCII = 20127;
	internal const int ISO_8859_1 = 28591;
	private const int ISCIIAssemese = 57006;
	private const int ISCIIBengali = 57003;
	private const int ISCIIDevanagari = 57002;
	private const int ISCIIGujarathi = 57010;
	private const int ISCIIKannada = 57008;
	private const int ISCIIMalayalam = 57009;
	private const int ISCIIOriya = 57007;
	private const int ISCIIPanjabi = 57011;
	private const int ISCIITamil = 57004;
	private const int ISCIITelugu = 57005;
	private const int GB18030 = 54936;
	private const int ISO_8859_8I = 38598;
	private const int ISO_8859_8_Visual = 28598;
	private const int ENC50229 = 50229;
	private const int CodePageUTF7 = 65000;
	private const int CodePageUTF8 = 65001;
	private const int CodePageUTF32 = 12000;
	private const int CodePageUTF32BE = 12001;
	internal int m_codePage; // 0x10
	internal CodePageDataItem dataItem; // 0x18
	internal bool m_deserializedFromEverett; // 0x20
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	private bool m_isReadOnly; // 0x21
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	internal EncoderFallback encoderFallback; // 0x28
	[OptionalFieldAttribute] // RVA: 0x92F60 Offset: 0x92360 VA: 0x180092F60
	internal DecoderFallback decoderFallback; // 0x30
	private static object s_InternalSyncObject; // 0x48

	// Properties
	private static object InternalSyncObject { get; }
	public virtual string BodyName { get; }
	public virtual string EncodingName { get; }
	public virtual string HeaderName { get; }
	public virtual string WebName { get; }
	public virtual int WindowsCodePage { get; }
	public virtual bool IsBrowserDisplay { get; }
	public virtual bool IsBrowserSave { get; }
	public virtual bool IsMailNewsDisplay { get; }
	public virtual bool IsMailNewsSave { get; }
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public virtual bool IsSingleByte { get; }
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public EncoderFallback EncoderFallback { get; set; }
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public DecoderFallback DecoderFallback { get; set; }
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public bool IsReadOnly { get; }
	public static Encoding ASCII { get; }
	private static Encoding Latin1 { get; }
	public virtual int CodePage { get; }
	public static Encoding Default { get; }
	public static Encoding Unicode { get; }
	public static Encoding BigEndianUnicode { get; }
	public static Encoding UTF7 { get; }
	public static Encoding UTF8 { get; }
	public static Encoding UTF32 { get; }

	// Methods

	// RVA: 0x191AF40 Offset: 0x1919540 VA: 0x18191AF40
	protected void .ctor() { }

	// RVA: 0x191AEB0 Offset: 0x19194B0 VA: 0x18191AEB0
	protected void .ctor(int codePage) { }

	// RVA: 0x191AAC0 Offset: 0x19190C0 VA: 0x18191AAC0 Slot: 5
	internal virtual void SetDefaultFallbacks() { }

	// RVA: 0x191A970 Offset: 0x1918F70 VA: 0x18191A970
	internal void OnDeserializing() { }

	// RVA: 0x191A920 Offset: 0x1918F20 VA: 0x18191A920
	internal void OnDeserialized() { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x191A970 Offset: 0x1918F70 VA: 0x18191A970
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x191A920 Offset: 0x1918F20 VA: 0x18191A920
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA7DF40 Offset: 0xA7C540 VA: 0x180A7DF40
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x19183F0 Offset: 0x19169F0 VA: 0x1819183F0
	internal void DeserializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x191A9B0 Offset: 0x1918FB0 VA: 0x18191A9B0
	internal void SerializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x191B240 Offset: 0x1919840 VA: 0x18191B240
	private static object get_InternalSyncObject() { }

	// RVA: 0x1919650 Offset: 0x1917C50 VA: 0x181919650
	public static Encoding GetEncoding(int codepage) { }

	// RVA: 0x191A500 Offset: 0x1918B00 VA: 0x18191A500
	public static Encoding GetEncoding(string name) { }

	// RVA: 0x191A6F0 Offset: 0x1918CF0 VA: 0x18191A6F0 Slot: 6
	public virtual byte[] GetPreamble() { }

	// RVA: 0x1919450 Offset: 0x1917A50 VA: 0x181919450
	private void GetDataItem() { }

	// RVA: 0x191B0E0 Offset: 0x19196E0 VA: 0x18191B0E0 Slot: 7
	public virtual string get_BodyName() { }

	// RVA: 0x191B1F0 Offset: 0x19197F0 VA: 0x18191B1F0 Slot: 8
	public virtual string get_EncodingName() { }

	// RVA: 0x191B200 Offset: 0x1919800 VA: 0x18191B200 Slot: 9
	public virtual string get_HeaderName() { }

	// RVA: 0x191B7E0 Offset: 0x1919DE0 VA: 0x18191B7E0 Slot: 10
	public virtual string get_WebName() { }

	// RVA: 0x191B820 Offset: 0x1919E20 VA: 0x18191B820 Slot: 11
	public virtual int get_WindowsCodePage() { }

	// RVA: 0x191B2D0 Offset: 0x19198D0 VA: 0x18191B2D0 Slot: 12
	public virtual bool get_IsBrowserDisplay() { }

	// RVA: 0x191B310 Offset: 0x1919910 VA: 0x18191B310 Slot: 13
	public virtual bool get_IsBrowserSave() { }

	// RVA: 0x191B350 Offset: 0x1919950 VA: 0x18191B350 Slot: 14
	public virtual bool get_IsMailNewsDisplay() { }

	// RVA: 0x191B390 Offset: 0x1919990 VA: 0x18191B390 Slot: 15
	public virtual bool get_IsMailNewsSave() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 16
	public virtual bool get_IsSingleByte() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public EncoderFallback get_EncoderFallback() { }

	// RVA: 0x191B930 Offset: 0x1919F30 VA: 0x18191B930
	public void set_EncoderFallback(EncoderFallback value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public DecoderFallback get_DecoderFallback() { }

	// RVA: 0x191B870 Offset: 0x1919E70 VA: 0x18191B870
	public void set_DecoderFallback(DecoderFallback value) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1918300 Offset: 0x1916900 VA: 0x181918300 Slot: 17
	public virtual object Clone() { }

	// RVA: 0xB106C0 Offset: 0xB0ECC0 VA: 0x180B106C0
	public bool get_IsReadOnly() { }

	// RVA: 0x191AFA0 Offset: 0x19195A0 VA: 0x18191AFA0
	public static Encoding get_ASCII() { }

	// RVA: 0x191B3D0 Offset: 0x19199D0 VA: 0x18191B3D0
	private static Encoding get_Latin1() { }

	// RVA: 0x1918860 Offset: 0x1916E60 VA: 0x181918860 Slot: 18
	public virtual int GetByteCount(string s) { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract int GetByteCount(char[] chars, int index, int count);

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x1918910 Offset: 0x1916F10 VA: 0x181918910 Slot: 20
	public virtual int GetByteCount(char* chars, int count) { }

	// RVA: 0x1277330 Offset: 0x1275930 VA: 0x181277330 Slot: 21
	internal virtual int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x1918F20 Offset: 0x1917520 VA: 0x181918F20 Slot: 22
	public virtual byte[] GetBytes(char[] chars) { }

	// RVA: 0x1918E50 Offset: 0x1917450 VA: 0x181918E50 Slot: 23
	public virtual byte[] GetBytes(char[] chars, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);

	// RVA: 0x1918C80 Offset: 0x1917280 VA: 0x181918C80 Slot: 25
	public virtual byte[] GetBytes(string s) { }

	// RVA: 0x1918D70 Offset: 0x1917370 VA: 0x181918D70 Slot: 26
	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1918E30 Offset: 0x1917430 VA: 0x181918E30 Slot: 27
	internal virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x1918A60 Offset: 0x1917060 VA: 0x181918A60 Slot: 28
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract int GetCharCount(byte[] bytes, int index, int count);

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x1918FD0 Offset: 0x19175D0 VA: 0x181918FD0 Slot: 30
	public virtual int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1919120 Offset: 0x1917720 VA: 0x181919120 Slot: 31
	internal virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x1919140 Offset: 0x1917740 VA: 0x181919140 Slot: 32
	public virtual char[] GetChars(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 33
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x1919210 Offset: 0x1917810 VA: 0x181919210 Slot: 34
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1919430 Offset: 0x1917A30 VA: 0x181919430 Slot: 35
	internal virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x191A750 Offset: 0x1918D50 VA: 0x18191A750
	public string GetString(byte* bytes, int byteCount) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 36
	public virtual int get_CodePage() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 37
	public virtual bool IsAlwaysNormalized(NormalizationForm form) { }

	// RVA: 0x1919570 Offset: 0x1917B70 VA: 0x181919570 Slot: 38
	public virtual Decoder GetDecoder() { }

	// RVA: 0x1918390 Offset: 0x1916990 VA: 0x181918390
	private static Encoding CreateDefaultEncoding() { }

	// RVA: 0x13A3A40 Offset: 0x13A2040 VA: 0x1813A3A40
	internal void setReadOnly(bool value = True) { }

	// RVA: 0x191B120 Offset: 0x1919720 VA: 0x18191B120
	public static Encoding get_Default() { }

	// RVA: 0x19195E0 Offset: 0x1917BE0 VA: 0x1819195E0 Slot: 39
	public virtual Encoder GetEncoder() { }

	// RVA: -1 Offset: -1 Slot: 40
	public abstract int GetMaxByteCount(int charCount);

	// RVA: -1 Offset: -1 Slot: 41
	public abstract int GetMaxCharCount(int byteCount);

	// RVA: 0x191A840 Offset: 0x1918E40 VA: 0x18191A840 Slot: 42
	public virtual string GetString(byte[] bytes) { }

	// RVA: 0x191A8F0 Offset: 0x1918EF0 VA: 0x18191A8F0 Slot: 43
	public virtual string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x191B740 Offset: 0x1919D40 VA: 0x18191B740
	public static Encoding get_Unicode() { }

	// RVA: 0x191B040 Offset: 0x1919640 VA: 0x18191B040
	public static Encoding get_BigEndianUnicode() { }

	// RVA: 0x191B570 Offset: 0x1919B70 VA: 0x18191B570
	public static Encoding get_UTF7() { }

	// RVA: 0x191B660 Offset: 0x1919C60 VA: 0x18191B660
	public static Encoding get_UTF8() { }

	// RVA: 0x191B4B0 Offset: 0x1919AB0 VA: 0x18191B4B0
	public static Encoding get_UTF32() { }

	// RVA: 0x19186B0 Offset: 0x1916CB0 VA: 0x1819186B0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x191A680 Offset: 0x1918C80 VA: 0x18191A680 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1918800 Offset: 0x1916E00 VA: 0x181918800 Slot: 44
	internal virtual char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x19187A0 Offset: 0x1916DA0 VA: 0x1819187A0 Slot: 45
	internal virtual char[] GetBestFitBytesToUnicodeData() { }

	// RVA: 0x191AC10 Offset: 0x1919210 VA: 0x18191AC10
	internal void ThrowBytesOverflow() { }

	// RVA: 0x191AB80 Offset: 0x1919180 VA: 0x18191AB80
	internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded) { }

	// RVA: 0x191ADB0 Offset: 0x19193B0 VA: 0x18191ADB0
	internal void ThrowCharsOverflow() { }

	// RVA: 0x191AD10 Offset: 0x1919310 VA: 0x18191AD10
	internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded) { }

}

internal class Encoding.DefaultEncoder : Encoder, ISerializable, IObjectReference // TypeDefIndex: 456
{	// Fields
	private Encoding m_encoding; // 0x20
	private bool m_hasInitializedEncoding; // 0x28
	internal char charLeftOver; // 0x2A

	// Methods

	// RVA: 0x1913010 Offset: 0x1911610 VA: 0x181913010
	public void .ctor(Encoding encoding) { }

	// RVA: 0x1913280 Offset: 0x1911880 VA: 0x181913280
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1913110 Offset: 0x1911710 VA: 0x181913110 Slot: 12
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x19131F0 Offset: 0x19117F0 VA: 0x1819131F0 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1913050 Offset: 0x1911650 VA: 0x181913050 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

	// RVA: 0x1913080 Offset: 0x1911680 VA: 0x181913080 Slot: 6
	public override int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: 0x19130B0 Offset: 0x19116B0 VA: 0x1819130B0 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: 0x19130E0 Offset: 0x19116E0 VA: 0x1819130E0 Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

}

internal class Encoding.DefaultDecoder : Decoder, ISerializable, IObjectReference // TypeDefIndex: 457
{	// Fields
	private Encoding m_encoding; // 0x20
	private bool m_hasInitializedEncoding; // 0x28

	// Methods

	// RVA: 0x1913010 Offset: 0x1911610 VA: 0x181913010
	public void .ctor(Encoding encoding) { }

	// RVA: 0x1912E10 Offset: 0x1911410 VA: 0x181912E10
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1912D10 Offset: 0x1911310 VA: 0x181912D10 Slot: 14
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x1912D80 Offset: 0x1911380 VA: 0x181912D80 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE4D900 Offset: 0xE4BF00 VA: 0x180E4D900 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x1912C80 Offset: 0x1911280 VA: 0x181912C80 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x1912C50 Offset: 0x1911250 VA: 0x181912C50 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x18ACF50 Offset: 0x18AB550 VA: 0x1818ACF50 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1912CE0 Offset: 0x19112E0 VA: 0x181912CE0 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x1912CB0 Offset: 0x19112B0 VA: 0x181912CB0 Slot: 10
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

}

internal class Encoding.EncodingCharBuffer // TypeDefIndex: 458
{	// Fields
	private char* chars; // 0x10
	private char* charStart; // 0x18
	private char* charEnd; // 0x20
	private int charCountResult; // 0x28
	private Encoding enc; // 0x30
	private DecoderNLS decoder; // 0x38
	private byte* byteStart; // 0x40
	private byte* byteEnd; // 0x48
	private byte* bytes; // 0x50
	private DecoderFallbackBuffer fallbackBuffer; // 0x58

	// Properties
	internal bool MoreData { get; }
	internal int BytesUsed { get; }
	internal int Count { get; }

	// Methods

	// RVA: 0x19162A0 Offset: 0x19148A0 VA: 0x1819162A0
	internal void .ctor(Encoding enc, DecoderNLS decoder, char* charStart, int charCount, byte* byteStart, int byteCount) { }

	// RVA: 0x1915EE0 Offset: 0x19144E0 VA: 0x181915EE0
	internal bool AddChar(char ch, int numBytes) { }

	// RVA: 0x1915FC0 Offset: 0x19145C0 VA: 0x181915FC0
	internal bool AddChar(char ch) { }

	// RVA: 0x19160A0 Offset: 0x19146A0 VA: 0x1819160A0
	internal void AdjustBytes(int count) { }

	// RVA: 0x19163B0 Offset: 0x19149B0 VA: 0x1819163B0
	internal bool get_MoreData() { }

	// RVA: 0x1916280 Offset: 0x1914880 VA: 0x181916280
	internal byte GetNextByte() { }

	// RVA: 0x19163A0 Offset: 0x19149A0 VA: 0x1819163A0
	internal int get_BytesUsed() { }

	// RVA: 0x1916200 Offset: 0x1914800 VA: 0x181916200
	internal bool Fallback(byte fallbackByte) { }

	// RVA: 0x19160B0 Offset: 0x19146B0 VA: 0x1819160B0
	internal bool Fallback(byte[] byteBuffer) { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	internal int get_Count() { }

}

internal class Encoding.EncodingByteBuffer // TypeDefIndex: 459
{	// Fields
	private byte* bytes; // 0x10
	private byte* byteStart; // 0x18
	private byte* byteEnd; // 0x20
	private char* chars; // 0x28
	private char* charStart; // 0x30
	private char* charEnd; // 0x38
	private int byteCountResult; // 0x40
	private Encoding enc; // 0x48
	private EncoderNLS encoder; // 0x50
	internal EncoderFallbackBuffer fallbackBuffer; // 0x58

	// Properties
	internal bool MoreData { get; }
	internal int CharsUsed { get; }
	internal int Count { get; }

	// Methods

	// RVA: 0x1915BD0 Offset: 0x19141D0 VA: 0x181915BD0
	internal void .ctor(Encoding inEncoding, EncoderNLS inEncoder, byte* inByteStart, int inByteCount, char* inCharStart, int inCharCount) { }

	// RVA: 0x1915960 Offset: 0x1913F60 VA: 0x181915960
	internal bool AddByte(byte b, int moreBytesExpected) { }

	// RVA: 0x19158A0 Offset: 0x1913EA0 VA: 0x1819158A0
	internal bool AddByte(byte b1) { }

	// RVA: 0x19158B0 Offset: 0x1913EB0 VA: 0x1819158B0
	internal bool AddByte(byte b1, byte b2) { }

	// RVA: 0x1915900 Offset: 0x1913F00 VA: 0x181915900
	internal bool AddByte(byte b1, byte b2, int moreBytesExpected) { }

	// RVA: 0x1915AE0 Offset: 0x19140E0 VA: 0x181915AE0
	internal void MovePrevious(bool bThrow) { }

	// RVA: 0x1915E90 Offset: 0x1914490 VA: 0x181915E90
	internal bool get_MoreData() { }

	// RVA: 0x1915A70 Offset: 0x1914070 VA: 0x181915A70
	internal char GetNextChar() { }

	// RVA: 0x1915E70 Offset: 0x1914470 VA: 0x181915E70
	internal int get_CharsUsed() { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	internal int get_Count() { }

}

internal abstract class EncodingNLS : Encoding // TypeDefIndex: 460
{	// Methods

	// RVA: 0x1918070 Offset: 0x1916670 VA: 0x181918070
	protected void .ctor(int codePage) { }

	// RVA: 0x1917020 Offset: 0x1915620 VA: 0x181917020 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1916F80 Offset: 0x1915580 VA: 0x181916F80 Slot: 18
	public override int GetByteCount(string s) { }

	// RVA: 0x1916E80 Offset: 0x1915480 VA: 0x181916E80 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1917550 Offset: 0x1915B50 VA: 0x181917550 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x19171B0 Offset: 0x19157B0 VA: 0x1819171B0 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1917410 Offset: 0x1915A10 VA: 0x181917410 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x19177B0 Offset: 0x1915DB0 VA: 0x1819177B0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x1917940 Offset: 0x1915F40 VA: 0x181917940 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1917B80 Offset: 0x1916180 VA: 0x181917B80 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1917A40 Offset: 0x1916040 VA: 0x181917A40 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1917EE0 Offset: 0x19164E0 VA: 0x181917EE0 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1917DE0 Offset: 0x19163E0 VA: 0x181917DE0 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x1917E40 Offset: 0x1916440 VA: 0x181917E40 Slot: 39
	public override Encoder GetEncoder() { }

}

public abstract class EncodingProvider // TypeDefIndex: 461
{	// Fields
	private static object s_InternalSyncObject; // 0x0
	private static EncodingProvider[] s_providers; // 0x8

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Encoding GetEncoding(string name);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Encoding GetEncoding(int codepage);

	// RVA: 0x1918190 Offset: 0x1916790 VA: 0x181918190
	internal static Encoding GetEncodingFromProvider(int codepage) { }

	// RVA: 0x1918080 Offset: 0x1916680 VA: 0x181918080
	internal static Encoding GetEncodingFromProvider(string encodingName) { }

	// RVA: 0x19182A0 Offset: 0x19168A0 VA: 0x1819182A0
	private static void .cctor() { }

}

internal static class EncodingHelper // TypeDefIndex: 479
{	// Fields
	private static Encoding utf8EncodingWithoutMarkers; // 0x0
	private static readonly object lockobj; // 0x8
	private static Assembly i18nAssembly; // 0x10
	private static bool i18nDisabled; // 0x18

	// Properties
	internal static Encoding UTF8Unmarked { get; }

	// Methods

	// RVA: 0x1916C20 Offset: 0x1915220 VA: 0x181916C20
	internal static Encoding get_UTF8Unmarked() { }

	// RVA: 0x1916660 Offset: 0x1914C60 VA: 0x181916660
	internal static string InternalCodePage(ref int code_page) { }

	// RVA: 0x19163C0 Offset: 0x19149C0 VA: 0x1819163C0
	internal static Encoding GetDefaultEncoding() { }

	// RVA: 0x1916670 Offset: 0x1914C70 VA: 0x181916670
	internal static object InvokeI18N(string name, object[] args) { }

	// RVA: 0x1916BC0 Offset: 0x19151C0 VA: 0x181916BC0
	private static void .cctor() { }

}

internal static class EncodingTable // TypeDefIndex: 736
{	// Fields
	internal static InternalEncodingDataItem[] encodingDataPtr; // 0x0
	internal static InternalCodePageDataItem[] codePageDataPtr; // 0x8
	private static int lastEncodingItem; // 0x10
	private static Hashtable hashByName; // 0x18
	private static Hashtable hashByCodePage; // 0x20

	// Methods

	// RVA: 0x16E8070 Offset: 0x16E6670 VA: 0x1816E8070
	private static int GetNumEncodingItems() { }

	// RVA: 0x16E7C80 Offset: 0x16E6280 VA: 0x1816E7C80
	private static InternalEncodingDataItem ENC(string name, ushort cp) { }

	// RVA: 0x16E80E0 Offset: 0x16E66E0 VA: 0x1816E80E0
	private static InternalCodePageDataItem MapCodePageDataItem(ushort cp, ushort fcp, string names, uint flags) { }

	// RVA: 0x16E8110 Offset: 0x16E6710 VA: 0x1816E8110
	private static void .cctor() { }

	// RVA: 0x16F1D40 Offset: 0x16F0340 VA: 0x1816F1D40
	private static int internalGetCodePageFromName(string name) { }

	// RVA: 0x16E7EF0 Offset: 0x16E64F0 VA: 0x1816E7EF0
	internal static int GetCodePageFromName(string name) { }

	// RVA: 0x16E7CC0 Offset: 0x16E62C0 VA: 0x1816E7CC0
	internal static CodePageDataItem GetCodePageDataItem(int codepage) { }

}

public class ENCshift_jis : CP932 // TypeDefIndex: 7799
{	// Methods

	// RVA: 0x224C650 Offset: 0x224AC50 VA: 0x18224C650
	public void .ctor() { }

}

public class ENCiso_2022_jp : CP50220 // TypeDefIndex: 7807
{	// Methods

	// RVA: 0x2249DC0 Offset: 0x22483C0 VA: 0x182249DC0
	public void .ctor() { }

}

public class ENCeuc_jp : CP51932 // TypeDefIndex: 7811
{	// Methods

	// RVA: 0x224B1D0 Offset: 0x22497D0 VA: 0x18224B1D0
	public void .ctor() { }

}

internal class ENCgb2312 : CP936 // TypeDefIndex: 7814
{	// Methods

	// RVA: 0x224D1A0 Offset: 0x224B7A0 VA: 0x18224D1A0
	public void .ctor() { }

}

internal class ENCuhc : CP949 // TypeDefIndex: 7819
{	// Methods

	// RVA: 0x224D270 Offset: 0x224B870 VA: 0x18224D270
	public void .ctor() { }

}

internal class ENCeuc_kr : CP51949 // TypeDefIndex: 7820
{	// Methods

	// RVA: 0x224B2B0 Offset: 0x22498B0 VA: 0x18224B2B0
	public void .ctor() { }

}

internal class ENCbig5 : CP950 // TypeDefIndex: 7823
{	// Methods

	// RVA: 0x224DC80 Offset: 0x224C280 VA: 0x18224DC80
	public void .ctor() { }

}

internal class ENCgb18030 : GB18030Encoding // TypeDefIndex: 7828
{	// Methods

	// RVA: 0x224B3A0 Offset: 0x22499A0 VA: 0x18224B3A0
	public void .ctor() { }

}

public class ENCwindows_1254 : CP1254 // TypeDefIndex: 7841
{	// Methods

	// RVA: 0x2307C50 Offset: 0x2306250 VA: 0x182307C50
	public void .ctor() { }

}

public class ENCwindows_1255 : CP1255 // TypeDefIndex: 7843
{	// Methods

	// RVA: 0x2307D50 Offset: 0x2306350 VA: 0x182307D50
	public void .ctor() { }

}

public class ENCwindows_1256 : CP1256 // TypeDefIndex: 7845
{	// Methods

	// RVA: 0x2307E50 Offset: 0x2306450 VA: 0x182307E50
	public void .ctor() { }

}

public class ENCiso_8859_6 : CP28596 // TypeDefIndex: 7847
{	// Methods

	// RVA: 0x2307950 Offset: 0x2305F50 VA: 0x182307950
	public void .ctor() { }

}

public class ENCiso_8859_8 : CP28598 // TypeDefIndex: 7849
{	// Methods

	// RVA: 0x2307A50 Offset: 0x2306050 VA: 0x182307A50
	public void .ctor() { }

}

public class ENCiso_8859_9 : CP28599 // TypeDefIndex: 7851
{	// Methods

	// RVA: 0x2307B50 Offset: 0x2306150 VA: 0x182307B50
	public void .ctor() { }

}

public class ENCwindows_38598 : CP38598 // TypeDefIndex: 7853
{	// Methods

	// RVA: 0x2307F50 Offset: 0x2306550 VA: 0x182307F50
	public void .ctor() { }

}

public class ENCwindows_1251 : CP1251 // TypeDefIndex: 7859
{	// Methods

	// RVA: 0x22F4D50 Offset: 0x22F3350 VA: 0x1822F4D50
	public void .ctor() { }

}

public class ENCwindows_1257 : CP1257 // TypeDefIndex: 7861
{	// Methods

	// RVA: 0x22F4E50 Offset: 0x22F3450 VA: 0x1822F4E50
	public void .ctor() { }

}

public class ENCwindows_1258 : CP1258 // TypeDefIndex: 7863
{	// Methods

	// RVA: 0x22F4F50 Offset: 0x22F3550 VA: 0x1822F4F50
	public void .ctor() { }

}

public class ENCkoi8_r : CP20866 // TypeDefIndex: 7865
{	// Methods

	// RVA: 0x22F4B50 Offset: 0x22F3150 VA: 0x1822F4B50
	public void .ctor() { }

}

public class ENCkoi8_u : CP21866 // TypeDefIndex: 7867
{	// Methods

	// RVA: 0x22F4C50 Offset: 0x22F3250 VA: 0x1822F4C50
	public void .ctor() { }

}

public class ENCiso_8859_4 : CP28594 // TypeDefIndex: 7869
{	// Methods

	// RVA: 0x22F4950 Offset: 0x22F2F50 VA: 0x1822F4950
	public void .ctor() { }

}

public class ENCiso_8859_5 : CP28595 // TypeDefIndex: 7871
{	// Methods

	// RVA: 0x22F4A50 Offset: 0x22F3050 VA: 0x1822F4A50
	public void .ctor() { }

}

public class ENCx_iscii_de : CP57002 // TypeDefIndex: 7883
{	// Methods

	// RVA: 0x22F4060 Offset: 0x22F2660 VA: 0x1822F4060
	public void .ctor() { }

}

public class ENCx_iscii_be : CP57003 // TypeDefIndex: 7884
{	// Methods

	// RVA: 0x22F40E0 Offset: 0x22F26E0 VA: 0x1822F40E0
	public void .ctor() { }

}

public class ENCx_iscii_ta : CP57004 // TypeDefIndex: 7885
{	// Methods

	// RVA: 0x22F4160 Offset: 0x22F2760 VA: 0x1822F4160
	public void .ctor() { }

}

public class ENCx_iscii_te : CP57005 // TypeDefIndex: 7886
{	// Methods

	// RVA: 0x22F41E0 Offset: 0x22F27E0 VA: 0x1822F41E0
	public void .ctor() { }

}

public class ENCx_iscii_as : CP57006 // TypeDefIndex: 7887
{	// Methods

	// RVA: 0x22F4260 Offset: 0x22F2860 VA: 0x1822F4260
	public void .ctor() { }

}

public class ENCx_iscii_or : CP57007 // TypeDefIndex: 7888
{	// Methods

	// RVA: 0x22F42E0 Offset: 0x22F28E0 VA: 0x1822F42E0
	public void .ctor() { }

}

public class ENCx_iscii_ka : CP57008 // TypeDefIndex: 7889
{	// Methods

	// RVA: 0x22F4360 Offset: 0x22F2960 VA: 0x1822F4360
	public void .ctor() { }

}

public class ENCx_iscii_ma : CP57009 // TypeDefIndex: 7890
{	// Methods

	// RVA: 0x22F43E0 Offset: 0x22F29E0 VA: 0x1822F43E0
	public void .ctor() { }

}

public class ENCx_iscii_gu : CP57010 // TypeDefIndex: 7891
{	// Methods

	// RVA: 0x22F4460 Offset: 0x22F2A60 VA: 0x1822F4460
	public void .ctor() { }

}

public class ENCx_iscii_pa : CP57011 // TypeDefIndex: 7892
{	// Methods

	// RVA: 0x22F44E0 Offset: 0x22F2AE0 VA: 0x1822F44E0
	public void .ctor() { }

}

public class ENCwindows_874 : CP874 // TypeDefIndex: 7894
{	// Methods

	// RVA: 0x22F5050 Offset: 0x22F3650 VA: 0x1822F5050
	public void .ctor() { }

}

public class ENCibm866 : CP866 // TypeDefIndex: 7900
{	// Methods

	// RVA: 0x22EE390 Offset: 0x22EC990 VA: 0x1822EE390
	public void .ctor() { }

}

public class ENCibm1026 : CP1026 // TypeDefIndex: 7902
{	// Methods

	// RVA: 0x22ED9F0 Offset: 0x22EBFF0 VA: 0x1822ED9F0
	public void .ctor() { }

}

public class ENCibm869 : CP869 // TypeDefIndex: 7904
{	// Methods

	// RVA: 0x22EE490 Offset: 0x22ECA90 VA: 0x1822EE490
	public void .ctor() { }

}

public class ENCibm870 : CP870 // TypeDefIndex: 7906
{	// Methods

	// RVA: 0x22EE590 Offset: 0x22ECB90 VA: 0x1822EE590
	public void .ctor() { }

}

public class ENCibm875 : CP875 // TypeDefIndex: 7908
{	// Methods

	// RVA: 0x22EE6F0 Offset: 0x22ECCF0 VA: 0x1822EE6F0
	public void .ctor() { }

}

public class ENCibm1047 : CP1047 // TypeDefIndex: 7910
{	// Methods

	// RVA: 0x22EDA50 Offset: 0x22EC050 VA: 0x1822EDA50
	public void .ctor() { }

}

public class ENCibm01140 : CP1140 // TypeDefIndex: 7912
{	// Methods

	// RVA: 0x22ED7B0 Offset: 0x22EBDB0 VA: 0x1822ED7B0
	public void .ctor() { }

}

public class ENCibm01141 : CP1141 // TypeDefIndex: 7914
{	// Methods

	// RVA: 0x22ED810 Offset: 0x22EBE10 VA: 0x1822ED810
	public void .ctor() { }

}

public class ENCibm01142 : CP1142 // TypeDefIndex: 7916
{	// Methods

	// RVA: 0x22ED870 Offset: 0x22EBE70 VA: 0x1822ED870
	public void .ctor() { }

}

public class ENCibm01143 : CP1143 // TypeDefIndex: 7918
{	// Methods

	// RVA: 0x22ED8D0 Offset: 0x22EBED0 VA: 0x1822ED8D0
	public void .ctor() { }

}

public class ENCibm1144 : CP1144 // TypeDefIndex: 7920
{	// Methods

	// RVA: 0x22EDAB0 Offset: 0x22EC0B0 VA: 0x1822EDAB0
	public void .ctor() { }

}

public class ENCibm1145 : CP1145 // TypeDefIndex: 7922
{	// Methods

	// RVA: 0x22EDB10 Offset: 0x22EC110 VA: 0x1822EDB10
	public void .ctor() { }

}

public class ENCibm1146 : CP1146 // TypeDefIndex: 7924
{	// Methods

	// RVA: 0x22EDB70 Offset: 0x22EC170 VA: 0x1822EDB70
	public void .ctor() { }

}

public class ENCibm1147 : CP1147 // TypeDefIndex: 7926
{	// Methods

	// RVA: 0x22EDBD0 Offset: 0x22EC1D0 VA: 0x1822EDBD0
	public void .ctor() { }

}

public class ENCibm1148 : CP1148 // TypeDefIndex: 7928
{	// Methods

	// RVA: 0x22EDC30 Offset: 0x22EC230 VA: 0x1822EDC30
	public void .ctor() { }

}

public class ENCibm1149 : CP1149 // TypeDefIndex: 7930
{	// Methods

	// RVA: 0x22EDC90 Offset: 0x22EC290 VA: 0x1822EDC90
	public void .ctor() { }

}

public class ENCibm273 : CP20273 // TypeDefIndex: 7932
{	// Methods

	// RVA: 0x22EDCF0 Offset: 0x22EC2F0 VA: 0x1822EDCF0
	public void .ctor() { }

}

public class ENCibm277 : CP20277 // TypeDefIndex: 7934
{	// Methods

	// RVA: 0x22EDD50 Offset: 0x22EC350 VA: 0x1822EDD50
	public void .ctor() { }

}

public class ENCibm278 : CP20278 // TypeDefIndex: 7936
{	// Methods

	// RVA: 0x22EDDB0 Offset: 0x22EC3B0 VA: 0x1822EDDB0
	public void .ctor() { }

}

public class ENCibm280 : CP20280 // TypeDefIndex: 7938
{	// Methods

	// RVA: 0x22EDE10 Offset: 0x22EC410 VA: 0x1822EDE10
	public void .ctor() { }

}

public class ENCibm284 : CP20284 // TypeDefIndex: 7940
{	// Methods

	// RVA: 0x22EDE70 Offset: 0x22EC470 VA: 0x1822EDE70
	public void .ctor() { }

}

public class ENCibm285 : CP20285 // TypeDefIndex: 7942
{	// Methods

	// RVA: 0x22EDED0 Offset: 0x22EC4D0 VA: 0x1822EDED0
	public void .ctor() { }

}

public class ENCibm290 : CP20290 // TypeDefIndex: 7944
{	// Methods

	// RVA: 0x22EDF30 Offset: 0x22EC530 VA: 0x1822EDF30
	public void .ctor() { }

}

public class ENCibm297 : CP20297 // TypeDefIndex: 7946
{	// Methods

	// RVA: 0x22EDF90 Offset: 0x22EC590 VA: 0x1822EDF90
	public void .ctor() { }

}

public class ENCibm420 : CP20420 // TypeDefIndex: 7948
{	// Methods

	// RVA: 0x22EDFF0 Offset: 0x22EC5F0 VA: 0x1822EDFF0
	public void .ctor() { }

}

public class ENCibm424 : CP20424 // TypeDefIndex: 7950
{	// Methods

	// RVA: 0x22EE050 Offset: 0x22EC650 VA: 0x1822EE050
	public void .ctor() { }

}

public class ENCibm871 : CP20871 // TypeDefIndex: 7952
{	// Methods

	// RVA: 0x22EE690 Offset: 0x22ECC90 VA: 0x1822EE690
	public void .ctor() { }

}

public class ENCibm1025 : CP21025 // TypeDefIndex: 7954
{	// Methods

	// RVA: 0x22ED990 Offset: 0x22EBF90 VA: 0x1822ED990
	public void .ctor() { }

}

public class ENCibm037 : CP37 // TypeDefIndex: 7956
{	// Methods

	// RVA: 0x22ED930 Offset: 0x22EBF30 VA: 0x1822ED930
	public void .ctor() { }

}

public class ENCibm500 : CP500 // TypeDefIndex: 7958
{	// Methods

	// RVA: 0x22EE0B0 Offset: 0x22EC6B0 VA: 0x1822EE0B0
	public void .ctor() { }

}

public class ENCasmo_708 : CP708 // TypeDefIndex: 7960
{	// Methods

	// RVA: 0x22ED6F0 Offset: 0x22EBCF0 VA: 0x1822ED6F0
	public void .ctor() { }

}

public class ENCibm852 : CP852 // TypeDefIndex: 7962
{	// Methods

	// RVA: 0x22EE110 Offset: 0x22EC710 VA: 0x1822EE110
	public void .ctor() { }

}

public class ENCibm855 : CP855 // TypeDefIndex: 7964
{	// Methods

	// RVA: 0x22EE170 Offset: 0x22EC770 VA: 0x1822EE170
	public void .ctor() { }

}

public class ENCibm857 : CP857 // TypeDefIndex: 7966
{	// Methods

	// RVA: 0x22EE1D0 Offset: 0x22EC7D0 VA: 0x1822EE1D0
	public void .ctor() { }

}

public class ENCibm00858 : CP858 // TypeDefIndex: 7968
{	// Methods

	// RVA: 0x22ED750 Offset: 0x22EBD50 VA: 0x1822ED750
	public void .ctor() { }

}

public class ENCibm862 : CP862 // TypeDefIndex: 7970
{	// Methods

	// RVA: 0x22EE230 Offset: 0x22EC830 VA: 0x1822EE230
	public void .ctor() { }

}

public class ENCibm864 : CP864 // TypeDefIndex: 7972
{	// Methods

	// RVA: 0x22EE290 Offset: 0x22EC890 VA: 0x1822EE290
	public void .ctor() { }

}

public class ENCmacintosh : CP10000 // TypeDefIndex: 7978
{	// Methods

	// RVA: 0x228D780 Offset: 0x228BD80 VA: 0x18228D780
	public void .ctor() { }

}

public class ENCx_mac_icelandic : CP10079 // TypeDefIndex: 7980
{	// Methods

	// RVA: 0x228DB80 Offset: 0x228C180 VA: 0x18228DB80
	public void .ctor() { }

}

public class ENCwindows_1250 : CP1250 // TypeDefIndex: 7982
{	// Methods

	// RVA: 0x228D880 Offset: 0x228BE80 VA: 0x18228D880
	public void .ctor() { }

}

public class ENCwindows_1252 : CP1252 // TypeDefIndex: 7984
{	// Methods

	// RVA: 0x228D980 Offset: 0x228BF80 VA: 0x18228D980
	public void .ctor() { }

}

public class ENCwindows_1253 : CP1253 // TypeDefIndex: 7986
{	// Methods

	// RVA: 0x228DA80 Offset: 0x228C080 VA: 0x18228DA80
	public void .ctor() { }

}

public class ENCiso_8859_2 : CP28592 // TypeDefIndex: 7988
{	// Methods

	// RVA: 0x228D480 Offset: 0x228BA80 VA: 0x18228D480
	public void .ctor() { }

}

public class ENCiso_8859_3 : CP28593 // TypeDefIndex: 7990
{	// Methods

	// RVA: 0x228D580 Offset: 0x228BB80 VA: 0x18228D580
	public void .ctor() { }

}

public class ENCiso_8859_7 : CP28597 // TypeDefIndex: 7992
{	// Methods

	// RVA: 0x228D680 Offset: 0x228BC80 VA: 0x18228D680
	public void .ctor() { }

}

public class ENCiso_8859_15 : CP28605 // TypeDefIndex: 7994
{	// Methods

	// RVA: 0x228D380 Offset: 0x228B980 VA: 0x18228D380
	public void .ctor() { }

}

public class ENCibm437 : CP437 // TypeDefIndex: 7996
{	// Methods

	// RVA: 0x228CD80 Offset: 0x228B380 VA: 0x18228CD80
	public void .ctor() { }

}

public class ENCibm850 : CP850 // TypeDefIndex: 7998
{	// Methods

	// RVA: 0x228CE80 Offset: 0x228B480 VA: 0x18228CE80
	public void .ctor() { }

}

public class ENCibm860 : CP860 // TypeDefIndex: 8000
{	// Methods

	// RVA: 0x228CF80 Offset: 0x228B580 VA: 0x18228CF80
	public void .ctor() { }

}

public class ENCibm861 : CP861 // TypeDefIndex: 8002
{	// Methods

	// RVA: 0x228D080 Offset: 0x228B680 VA: 0x18228D080
	public void .ctor() { }

}

public class ENCibm863 : CP863 // TypeDefIndex: 8004
{	// Methods

	// RVA: 0x228D180 Offset: 0x228B780 VA: 0x18228D180
	public void .ctor() { }

}

public class ENCibm865 : CP865 // TypeDefIndex: 8006
{	// Methods

	// RVA: 0x228D280 Offset: 0x228B880 VA: 0x18228D280
	public void .ctor() { }

}

public sealed class Encoder // TypeDefIndex: 11571
{	// Fields
	private static readonly Type includeAttrType; // 0x0
	private static readonly Type excludeAttrType; // 0x8
	private static readonly Type typeHintAttrType; // 0x10
	private readonly StringBuilder builder; // 0x10
	private readonly EncodeOptions options; // 0x18
	private int indent; // 0x1C

	// Properties
	private bool PrettyPrintEnabled { get; }
	private bool TypeHintsEnabled { get; }
	private bool IncludePublicPropertiesEnabled { get; }
	private bool EnforceHierarchyOrderEnabled { get; }

	// Methods

	// RVA: 0x87A5F0 Offset: 0x878BF0 VA: 0x18087A5F0
	private void .ctor(EncodeOptions options) { }

	// RVA: 0x87A1E0 Offset: 0x8787E0 VA: 0x18087A1E0
	public static string Encode(object obj) { }

	// RVA: 0x87A100 Offset: 0x878700 VA: 0x18087A100
	public static string Encode(object obj, EncodeOptions options) { }

	// RVA: 0x87A690 Offset: 0x878C90 VA: 0x18087A690
	private bool get_PrettyPrintEnabled() { }

	// RVA: 0x87A6A0 Offset: 0x878CA0 VA: 0x18087A6A0
	private bool get_TypeHintsEnabled() { }

	// RVA: 0x87A680 Offset: 0x878C80 VA: 0x18087A680
	private bool get_IncludePublicPropertiesEnabled() { }

	// RVA: 0x87A670 Offset: 0x878C70 VA: 0x18087A670
	private bool get_EnforceHierarchyOrderEnabled() { }

	// RVA: 0x879AF0 Offset: 0x8780F0 VA: 0x180879AF0
	private void EncodeValue(object value, bool forceTypeHint) { }

	// RVA: 0x87A240 Offset: 0x878840 VA: 0x18087A240
	private IEnumerable<FieldInfo> GetFieldsForType(Type type) { }

	// RVA: 0x87A3B0 Offset: 0x8789B0 VA: 0x18087A3B0
	private IEnumerable<PropertyInfo> GetPropertiesForType(Type type) { }

	// RVA: 0x878600 Offset: 0x876C00 VA: 0x180878600
	private void EncodeObject(object value, bool forceTypeHint) { }

	// RVA: 0x879190 Offset: 0x877790 VA: 0x180879190
	private void EncodeProxyArray(ProxyArray value) { }

	// RVA: 0x8794A0 Offset: 0x877AA0 VA: 0x1808794A0
	private void EncodeProxyObject(ProxyObject value) { }

	// RVA: 0x877ED0 Offset: 0x8764D0 VA: 0x180877ED0
	private void EncodeDictionary(IDictionary value, bool forceTypeHint) { }

	// RVA: 0x8782F0 Offset: 0x8768F0 VA: 0x1808782F0
	private void EncodeList(IList value, bool forceTypeHint) { }

	// RVA: 0x877E10 Offset: 0x876410 VA: 0x180877E10
	private void EncodeArray(Array value, bool forceTypeHint) { }

	// RVA: 0x877B10 Offset: 0x876110 VA: 0x180877B10
	private void EncodeArrayRank(Array value, int rank, int[] indices, bool forceTypeHint) { }

	// RVA: 0x879800 Offset: 0x877E00 VA: 0x180879800
	private void EncodeString(string value) { }

	// RVA: 0x877A20 Offset: 0x876020 VA: 0x180877A20
	private void AppendIndent() { }

	// RVA: 0x877A70 Offset: 0x876070 VA: 0x180877A70
	private void AppendOpenBrace() { }

	// RVA: 0x877850 Offset: 0x875E50 VA: 0x180877850
	private void AppendCloseBrace() { }

	// RVA: 0x877AC0 Offset: 0x8760C0 VA: 0x180877AC0
	private void AppendOpenBracket() { }

	// RVA: 0x8778D0 Offset: 0x875ED0 VA: 0x1808778D0
	private void AppendCloseBracket() { }

	// RVA: 0x8779A0 Offset: 0x875FA0 VA: 0x1808779A0
	private void AppendComma(bool firstItem) { }

	// RVA: 0x877950 Offset: 0x875F50 VA: 0x180877950
	private void AppendColon() { }

	// RVA: 0x87A520 Offset: 0x878B20 VA: 0x18087A520
	private static void .cctor() { }

}

