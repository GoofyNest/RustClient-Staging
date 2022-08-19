public abstract class Encoder // TypeDefIndex: 444
{	// Fields
	internal EncoderFallback m_fallback; // 0x10
	internal EncoderFallbackBuffer m_fallbackBuffer; // 0x18

	// Properties
	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	public EncoderFallback Fallback { get; }
	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	public EncoderFallbackBuffer FallbackBuffer { get; }
	internal bool InternalHasFallbackBuffer { get; }

	// Methods

	// RVA: 0x18AEE00 Offset: 0x18AD400 VA: 0x1818AEE00
	internal void SerializeEncoder(SerializationInfo info) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public EncoderFallback get_Fallback() { }

	// RVA: 0x18AEE60 Offset: 0x18AD460 VA: 0x1818AEE60
	public EncoderFallbackBuffer get_FallbackBuffer() { }

	// RVA: 0x17CB140 Offset: 0x17C9740 VA: 0x1817CB140
	internal bool get_InternalHasFallbackBuffer() { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x18AED30 Offset: 0x18AD330 VA: 0x1818AED30 Slot: 4
	public virtual void Reset() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetByteCount(char[] chars, int index, int count, bool flush);

	[CLSCompliantAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	[ComVisibleAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	// RVA: 0x18AE990 Offset: 0x18ACF90 VA: 0x1818AE990 Slot: 6
	public virtual int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush);

	[CLSCompliantAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	[ComVisibleAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	// RVA: 0x18AEB00 Offset: 0x18AD100 VA: 0x1818AEB00 Slot: 8
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x18AE620 Offset: 0x18ACC20 VA: 0x1818AE620 Slot: 9
	public virtual void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	[ComVisibleAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	[CLSCompliantAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	// RVA: 0x18AE3E0 Offset: 0x18AC9E0 VA: 0x1818AE3E0 Slot: 10
	public virtual void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

}

public sealed class EncoderExceptionFallback : EncoderFallback // TypeDefIndex: 447
{	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0x18AE330 Offset: 0x18AC930 VA: 0x1818AE330 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x18AE380 Offset: 0x18AC980 VA: 0x1818AE380 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x18AE3D0 Offset: 0x18AC9D0 VA: 0x1818AE3D0 Slot: 2
	public override int GetHashCode() { }

}

public sealed class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 448
{	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0x18ADEC0 Offset: 0x18AC4C0 VA: 0x1818ADEC0 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x18ADFD0 Offset: 0x18AC5D0 VA: 0x1818ADFD0 Slot: 5
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

	// RVA: 0x1913820 Offset: 0x1911E20 VA: 0x181913820
	public void .ctor() { }

	// RVA: 0x15C8280 Offset: 0x15C6880 VA: 0x1815C8280
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1913880 Offset: 0x1911E80 VA: 0x181913880
	internal void .ctor(string message, char charUnknown, int index) { }

	// RVA: 0x19135A0 Offset: 0x1911BA0 VA: 0x1819135A0
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

	// RVA: 0x1913A80 Offset: 0x1912080 VA: 0x181913A80
	private static object get_InternalSyncObject() { }

	// RVA: 0x1913B10 Offset: 0x1912110 VA: 0x181913B10
	public static EncoderFallback get_ReplacementFallback() { }

	// RVA: 0x19138C0 Offset: 0x1911EC0 VA: 0x1819138C0
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

	// RVA: 0x19134B0 Offset: 0x1911AB0 VA: 0x1819134B0 Slot: 9
	public virtual void Reset() { }

	// RVA: 0x1913490 Offset: 0x1911A90 VA: 0x181913490
	internal void InternalReset() { }

	// RVA: 0x1913450 Offset: 0x1911A50 VA: 0x181913450
	internal void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder) { }

	// RVA: 0x1913410 Offset: 0x1911A10 VA: 0x181913410
	internal char InternalGetNextChar() { }

	// RVA: 0x1913250 Offset: 0x1911850 VA: 0x181913250 Slot: 10
	internal virtual bool InternalFallback(char ch, ref char* chars) { }

	// RVA: 0x19134E0 Offset: 0x1911AE0 VA: 0x1819134E0
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

	// RVA: 0x19149D0 Offset: 0x1912FD0 VA: 0x1819149D0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x19148A0 Offset: 0x1912EA0 VA: 0x1819148A0 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1914960 Offset: 0x1912F60 VA: 0x181914960
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x1914A90 Offset: 0x1913090 VA: 0x181914A90
	internal void .ctor() { }

	// RVA: 0x1914870 Offset: 0x1912E70 VA: 0x181914870 Slot: 4
	public override void Reset() { }

	// RVA: 0x19141D0 Offset: 0x19127D0 VA: 0x1819141D0 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

	// RVA: 0x1914380 Offset: 0x1912980 VA: 0x181914380 Slot: 6
	public override int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: 0x19144A0 Offset: 0x1912AA0 VA: 0x1819144A0 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: 0x1914720 Offset: 0x1912D20 VA: 0x181914720 Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x1913CF0 Offset: 0x19122F0 VA: 0x181913CF0 Slot: 9
	public override void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	// RVA: 0x1914000 Offset: 0x1912600 VA: 0x181914000 Slot: 10
	public override void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public Encoding get_Encoding() { }

	// RVA: 0x82BC90 Offset: 0x82A290 VA: 0x18082BC90
	public bool get_MustFlush() { }

	// RVA: 0x1914AD0 Offset: 0x19130D0 VA: 0x181914AD0 Slot: 12
	internal virtual bool get_HasState() { }

	// RVA: 0xF5FD60 Offset: 0xF5E360 VA: 0x180F5FD60
	internal void ClearMustFlush() { }

}

public sealed class EncoderReplacementFallback : EncoderFallback // TypeDefIndex: 453
{	// Fields
	private string strDefault; // 0x18

	// Properties
	public string DefaultString { get; }
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x1915110 Offset: 0x1913710 VA: 0x181915110
	public void .ctor() { }

	// RVA: 0x1915150 Offset: 0x1913750 VA: 0x181915150
	public void .ctor(string replacement) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_DefaultString() { }

	// RVA: 0x1915020 Offset: 0x1913620 VA: 0x181915020 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x18AD390 Offset: 0x18AB990 VA: 0x1818AD390 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x19150A0 Offset: 0x19136A0 VA: 0x1819150A0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0xAE5A70 Offset: 0xAE4070 VA: 0x180AE5A70 Slot: 2
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

	// RVA: 0x1914FB0 Offset: 0x19135B0 VA: 0x181914FB0
	public void .ctor(EncoderReplacementFallback fallback) { }

	// RVA: 0x1914DA0 Offset: 0x19133A0 VA: 0x181914DA0 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x1914AE0 Offset: 0x19130E0 VA: 0x181914AE0 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x1914F20 Offset: 0x1913520 VA: 0x181914F20 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x1914F70 Offset: 0x1913570 VA: 0x181914F70 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x1915010 Offset: 0x1913610 VA: 0x181915010 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x1914F90 Offset: 0x1913590 VA: 0x181914F90 Slot: 9
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
	[OptionalFieldAttribute] // RVA: 0x92F70 Offset: 0x92370 VA: 0x180092F70
	private bool m_isReadOnly; // 0x21
	[OptionalFieldAttribute] // RVA: 0x92F70 Offset: 0x92370 VA: 0x180092F70
	internal EncoderFallback encoderFallback; // 0x28
	[OptionalFieldAttribute] // RVA: 0x92F70 Offset: 0x92370 VA: 0x180092F70
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
	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	public virtual bool IsSingleByte { get; }
	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	public EncoderFallback EncoderFallback { get; set; }
	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	public DecoderFallback DecoderFallback { get; set; }
	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
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

	// RVA: 0x191ACC0 Offset: 0x19192C0 VA: 0x18191ACC0
	protected void .ctor() { }

	// RVA: 0x191AC30 Offset: 0x1919230 VA: 0x18191AC30
	protected void .ctor(int codePage) { }

	// RVA: 0x191A840 Offset: 0x1918E40 VA: 0x18191A840 Slot: 5
	internal virtual void SetDefaultFallbacks() { }

	// RVA: 0x191A6F0 Offset: 0x1918CF0 VA: 0x18191A6F0
	internal void OnDeserializing() { }

	// RVA: 0x191A6A0 Offset: 0x1918CA0 VA: 0x18191A6A0
	internal void OnDeserialized() { }

	[OnDeserializingAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x191A6F0 Offset: 0x1918CF0 VA: 0x18191A6F0
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x191A6A0 Offset: 0x1918CA0 VA: 0x18191A6A0
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA7DC80 Offset: 0xA7C280 VA: 0x180A7DC80
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x1918170 Offset: 0x1916770 VA: 0x181918170
	internal void DeserializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x191A730 Offset: 0x1918D30 VA: 0x18191A730
	internal void SerializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x191AFC0 Offset: 0x19195C0 VA: 0x18191AFC0
	private static object get_InternalSyncObject() { }

	// RVA: 0x19193D0 Offset: 0x19179D0 VA: 0x1819193D0
	public static Encoding GetEncoding(int codepage) { }

	// RVA: 0x191A280 Offset: 0x1918880 VA: 0x18191A280
	public static Encoding GetEncoding(string name) { }

	// RVA: 0x191A470 Offset: 0x1918A70 VA: 0x18191A470 Slot: 6
	public virtual byte[] GetPreamble() { }

	// RVA: 0x19191D0 Offset: 0x19177D0 VA: 0x1819191D0
	private void GetDataItem() { }

	// RVA: 0x191AE60 Offset: 0x1919460 VA: 0x18191AE60 Slot: 7
	public virtual string get_BodyName() { }

	// RVA: 0x191AF70 Offset: 0x1919570 VA: 0x18191AF70 Slot: 8
	public virtual string get_EncodingName() { }

	// RVA: 0x191AF80 Offset: 0x1919580 VA: 0x18191AF80 Slot: 9
	public virtual string get_HeaderName() { }

	// RVA: 0x191B560 Offset: 0x1919B60 VA: 0x18191B560 Slot: 10
	public virtual string get_WebName() { }

	// RVA: 0x191B5A0 Offset: 0x1919BA0 VA: 0x18191B5A0 Slot: 11
	public virtual int get_WindowsCodePage() { }

	// RVA: 0x191B050 Offset: 0x1919650 VA: 0x18191B050 Slot: 12
	public virtual bool get_IsBrowserDisplay() { }

	// RVA: 0x191B090 Offset: 0x1919690 VA: 0x18191B090 Slot: 13
	public virtual bool get_IsBrowserSave() { }

	// RVA: 0x191B0D0 Offset: 0x19196D0 VA: 0x18191B0D0 Slot: 14
	public virtual bool get_IsMailNewsDisplay() { }

	// RVA: 0x191B110 Offset: 0x1919710 VA: 0x18191B110 Slot: 15
	public virtual bool get_IsMailNewsSave() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 16
	public virtual bool get_IsSingleByte() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public EncoderFallback get_EncoderFallback() { }

	// RVA: 0x191B6B0 Offset: 0x1919CB0 VA: 0x18191B6B0
	public void set_EncoderFallback(EncoderFallback value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public DecoderFallback get_DecoderFallback() { }

	// RVA: 0x191B5F0 Offset: 0x1919BF0 VA: 0x18191B5F0
	public void set_DecoderFallback(DecoderFallback value) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x1918080 Offset: 0x1916680 VA: 0x181918080 Slot: 17
	public virtual object Clone() { }

	// RVA: 0xB10400 Offset: 0xB0EA00 VA: 0x180B10400
	public bool get_IsReadOnly() { }

	// RVA: 0x191AD20 Offset: 0x1919320 VA: 0x18191AD20
	public static Encoding get_ASCII() { }

	// RVA: 0x191B150 Offset: 0x1919750 VA: 0x18191B150
	private static Encoding get_Latin1() { }

	// RVA: 0x19185E0 Offset: 0x1916BE0 VA: 0x1819185E0 Slot: 18
	public virtual int GetByteCount(string s) { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract int GetByteCount(char[] chars, int index, int count);

	[ComVisibleAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	[CLSCompliantAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	// RVA: 0x1918690 Offset: 0x1916C90 VA: 0x181918690 Slot: 20
	public virtual int GetByteCount(char* chars, int count) { }

	// RVA: 0x1277070 Offset: 0x1275670 VA: 0x181277070 Slot: 21
	internal virtual int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x1918CA0 Offset: 0x19172A0 VA: 0x181918CA0 Slot: 22
	public virtual byte[] GetBytes(char[] chars) { }

	// RVA: 0x1918BD0 Offset: 0x19171D0 VA: 0x181918BD0 Slot: 23
	public virtual byte[] GetBytes(char[] chars, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);

	// RVA: 0x1918A00 Offset: 0x1917000 VA: 0x181918A00 Slot: 25
	public virtual byte[] GetBytes(string s) { }

	// RVA: 0x1918AF0 Offset: 0x19170F0 VA: 0x181918AF0 Slot: 26
	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1918BB0 Offset: 0x19171B0 VA: 0x181918BB0 Slot: 27
	internal virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	[CLSCompliantAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	[ComVisibleAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	// RVA: 0x19187E0 Offset: 0x1916DE0 VA: 0x1819187E0 Slot: 28
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract int GetCharCount(byte[] bytes, int index, int count);

	[CLSCompliantAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	[ComVisibleAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	// RVA: 0x1918D50 Offset: 0x1917350 VA: 0x181918D50 Slot: 30
	public virtual int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1918EA0 Offset: 0x19174A0 VA: 0x181918EA0 Slot: 31
	internal virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x1918EC0 Offset: 0x19174C0 VA: 0x181918EC0 Slot: 32
	public virtual char[] GetChars(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 33
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	[ComVisibleAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	[CLSCompliantAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	// RVA: 0x1918F90 Offset: 0x1917590 VA: 0x181918F90 Slot: 34
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x19191B0 Offset: 0x19177B0 VA: 0x1819191B0 Slot: 35
	internal virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	[CLSCompliantAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	[ComVisibleAttribute] // RVA: 0x90730 Offset: 0x8FB30 VA: 0x180090730
	// RVA: 0x191A4D0 Offset: 0x1918AD0 VA: 0x18191A4D0
	public string GetString(byte* bytes, int byteCount) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 36
	public virtual int get_CodePage() { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 37
	public virtual bool IsAlwaysNormalized(NormalizationForm form) { }

	// RVA: 0x19192F0 Offset: 0x19178F0 VA: 0x1819192F0 Slot: 38
	public virtual Decoder GetDecoder() { }

	// RVA: 0x1918110 Offset: 0x1916710 VA: 0x181918110
	private static Encoding CreateDefaultEncoding() { }

	// RVA: 0x13A3780 Offset: 0x13A1D80 VA: 0x1813A3780
	internal void setReadOnly(bool value = True) { }

	// RVA: 0x191AEA0 Offset: 0x19194A0 VA: 0x18191AEA0
	public static Encoding get_Default() { }

	// RVA: 0x1919360 Offset: 0x1917960 VA: 0x181919360 Slot: 39
	public virtual Encoder GetEncoder() { }

	// RVA: -1 Offset: -1 Slot: 40
	public abstract int GetMaxByteCount(int charCount);

	// RVA: -1 Offset: -1 Slot: 41
	public abstract int GetMaxCharCount(int byteCount);

	// RVA: 0x191A5C0 Offset: 0x1918BC0 VA: 0x18191A5C0 Slot: 42
	public virtual string GetString(byte[] bytes) { }

	// RVA: 0x191A670 Offset: 0x1918C70 VA: 0x18191A670 Slot: 43
	public virtual string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x191B4C0 Offset: 0x1919AC0 VA: 0x18191B4C0
	public static Encoding get_Unicode() { }

	// RVA: 0x191ADC0 Offset: 0x19193C0 VA: 0x18191ADC0
	public static Encoding get_BigEndianUnicode() { }

	// RVA: 0x191B2F0 Offset: 0x19198F0 VA: 0x18191B2F0
	public static Encoding get_UTF7() { }

	// RVA: 0x191B3E0 Offset: 0x19199E0 VA: 0x18191B3E0
	public static Encoding get_UTF8() { }

	// RVA: 0x191B230 Offset: 0x1919830 VA: 0x18191B230
	public static Encoding get_UTF32() { }

	// RVA: 0x1918430 Offset: 0x1916A30 VA: 0x181918430 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x191A400 Offset: 0x1918A00 VA: 0x18191A400 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1918580 Offset: 0x1916B80 VA: 0x181918580 Slot: 44
	internal virtual char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x1918520 Offset: 0x1916B20 VA: 0x181918520 Slot: 45
	internal virtual char[] GetBestFitBytesToUnicodeData() { }

	// RVA: 0x191A990 Offset: 0x1918F90 VA: 0x18191A990
	internal void ThrowBytesOverflow() { }

	// RVA: 0x191A900 Offset: 0x1918F00 VA: 0x18191A900
	internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded) { }

	// RVA: 0x191AB30 Offset: 0x1919130 VA: 0x18191AB30
	internal void ThrowCharsOverflow() { }

	// RVA: 0x191AA90 Offset: 0x1919090 VA: 0x18191AA90
	internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded) { }

}

internal class Encoding.DefaultEncoder : Encoder, ISerializable, IObjectReference // TypeDefIndex: 456
{	// Fields
	private Encoding m_encoding; // 0x20
	private bool m_hasInitializedEncoding; // 0x28
	internal char charLeftOver; // 0x2A

	// Methods

	// RVA: 0x1912D90 Offset: 0x1911390 VA: 0x181912D90
	public void .ctor(Encoding encoding) { }

	// RVA: 0x1913000 Offset: 0x1911600 VA: 0x181913000
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1912E90 Offset: 0x1911490 VA: 0x181912E90 Slot: 12
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x1912F70 Offset: 0x1911570 VA: 0x181912F70 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1912DD0 Offset: 0x19113D0 VA: 0x181912DD0 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

	// RVA: 0x1912E00 Offset: 0x1911400 VA: 0x181912E00 Slot: 6
	public override int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: 0x1912E30 Offset: 0x1911430 VA: 0x181912E30 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: 0x1912E60 Offset: 0x1911460 VA: 0x181912E60 Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

}

internal class Encoding.DefaultDecoder : Decoder, ISerializable, IObjectReference // TypeDefIndex: 457
{	// Fields
	private Encoding m_encoding; // 0x20
	private bool m_hasInitializedEncoding; // 0x28

	// Methods

	// RVA: 0x1912D90 Offset: 0x1911390 VA: 0x181912D90
	public void .ctor(Encoding encoding) { }

	// RVA: 0x1912B90 Offset: 0x1911190 VA: 0x181912B90
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1912A90 Offset: 0x1911090 VA: 0x181912A90 Slot: 14
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x1912B00 Offset: 0x1911100 VA: 0x181912B00 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE4D640 Offset: 0xE4BC40 VA: 0x180E4D640 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x1912A00 Offset: 0x1911000 VA: 0x181912A00 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x19129D0 Offset: 0x1910FD0 VA: 0x1819129D0 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x18ACCD0 Offset: 0x18AB2D0 VA: 0x1818ACCD0 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1912A60 Offset: 0x1911060 VA: 0x181912A60 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x1912A30 Offset: 0x1911030 VA: 0x181912A30 Slot: 10
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

	// RVA: 0x1916020 Offset: 0x1914620 VA: 0x181916020
	internal void .ctor(Encoding enc, DecoderNLS decoder, char* charStart, int charCount, byte* byteStart, int byteCount) { }

	// RVA: 0x1915C60 Offset: 0x1914260 VA: 0x181915C60
	internal bool AddChar(char ch, int numBytes) { }

	// RVA: 0x1915D40 Offset: 0x1914340 VA: 0x181915D40
	internal bool AddChar(char ch) { }

	// RVA: 0x1915E20 Offset: 0x1914420 VA: 0x181915E20
	internal void AdjustBytes(int count) { }

	// RVA: 0x1916130 Offset: 0x1914730 VA: 0x181916130
	internal bool get_MoreData() { }

	// RVA: 0x1916000 Offset: 0x1914600 VA: 0x181916000
	internal byte GetNextByte() { }

	// RVA: 0x1916120 Offset: 0x1914720 VA: 0x181916120
	internal int get_BytesUsed() { }

	// RVA: 0x1915F80 Offset: 0x1914580 VA: 0x181915F80
	internal bool Fallback(byte fallbackByte) { }

	// RVA: 0x1915E30 Offset: 0x1914430 VA: 0x181915E30
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

	// RVA: 0x1915950 Offset: 0x1913F50 VA: 0x181915950
	internal void .ctor(Encoding inEncoding, EncoderNLS inEncoder, byte* inByteStart, int inByteCount, char* inCharStart, int inCharCount) { }

	// RVA: 0x19156E0 Offset: 0x1913CE0 VA: 0x1819156E0
	internal bool AddByte(byte b, int moreBytesExpected) { }

	// RVA: 0x1915620 Offset: 0x1913C20 VA: 0x181915620
	internal bool AddByte(byte b1) { }

	// RVA: 0x1915630 Offset: 0x1913C30 VA: 0x181915630
	internal bool AddByte(byte b1, byte b2) { }

	// RVA: 0x1915680 Offset: 0x1913C80 VA: 0x181915680
	internal bool AddByte(byte b1, byte b2, int moreBytesExpected) { }

	// RVA: 0x1915860 Offset: 0x1913E60 VA: 0x181915860
	internal void MovePrevious(bool bThrow) { }

	// RVA: 0x1915C10 Offset: 0x1914210 VA: 0x181915C10
	internal bool get_MoreData() { }

	// RVA: 0x19157F0 Offset: 0x1913DF0 VA: 0x1819157F0
	internal char GetNextChar() { }

	// RVA: 0x1915BF0 Offset: 0x19141F0 VA: 0x181915BF0
	internal int get_CharsUsed() { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	internal int get_Count() { }

}

internal abstract class EncodingNLS : Encoding // TypeDefIndex: 460
{	// Methods

	// RVA: 0x1917DF0 Offset: 0x19163F0 VA: 0x181917DF0
	protected void .ctor(int codePage) { }

	// RVA: 0x1916DA0 Offset: 0x19153A0 VA: 0x181916DA0 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1916D00 Offset: 0x1915300 VA: 0x181916D00 Slot: 18
	public override int GetByteCount(string s) { }

	// RVA: 0x1916C00 Offset: 0x1915200 VA: 0x181916C00 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x19172D0 Offset: 0x19158D0 VA: 0x1819172D0 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1916F30 Offset: 0x1915530 VA: 0x181916F30 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1917190 Offset: 0x1915790 VA: 0x181917190 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1917530 Offset: 0x1915B30 VA: 0x181917530 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x19176C0 Offset: 0x1915CC0 VA: 0x1819176C0 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1917900 Offset: 0x1915F00 VA: 0x181917900 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x19177C0 Offset: 0x1915DC0 VA: 0x1819177C0 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1917C60 Offset: 0x1916260 VA: 0x181917C60 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1917B60 Offset: 0x1916160 VA: 0x181917B60 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x1917BC0 Offset: 0x19161C0 VA: 0x181917BC0 Slot: 39
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

	// RVA: 0x1917F10 Offset: 0x1916510 VA: 0x181917F10
	internal static Encoding GetEncodingFromProvider(int codepage) { }

	// RVA: 0x1917E00 Offset: 0x1916400 VA: 0x181917E00
	internal static Encoding GetEncodingFromProvider(string encodingName) { }

	// RVA: 0x1918020 Offset: 0x1916620 VA: 0x181918020
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

	// RVA: 0x19169A0 Offset: 0x1914FA0 VA: 0x1819169A0
	internal static Encoding get_UTF8Unmarked() { }

	// RVA: 0x19163E0 Offset: 0x19149E0 VA: 0x1819163E0
	internal static string InternalCodePage(ref int code_page) { }

	// RVA: 0x1916140 Offset: 0x1914740 VA: 0x181916140
	internal static Encoding GetDefaultEncoding() { }

	// RVA: 0x19163F0 Offset: 0x19149F0 VA: 0x1819163F0
	internal static object InvokeI18N(string name, object[] args) { }

	// RVA: 0x1916940 Offset: 0x1914F40 VA: 0x181916940
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

	// RVA: 0x16E7DB0 Offset: 0x16E63B0 VA: 0x1816E7DB0
	private static int GetNumEncodingItems() { }

	// RVA: 0x16E79C0 Offset: 0x16E5FC0 VA: 0x1816E79C0
	private static InternalEncodingDataItem ENC(string name, ushort cp) { }

	// RVA: 0x16E7E20 Offset: 0x16E6420 VA: 0x1816E7E20
	private static InternalCodePageDataItem MapCodePageDataItem(ushort cp, ushort fcp, string names, uint flags) { }

	// RVA: 0x16E7E50 Offset: 0x16E6450 VA: 0x1816E7E50
	private static void .cctor() { }

	// RVA: 0x16F1A80 Offset: 0x16F0080 VA: 0x1816F1A80
	private static int internalGetCodePageFromName(string name) { }

	// RVA: 0x16E7C30 Offset: 0x16E6230 VA: 0x1816E7C30
	internal static int GetCodePageFromName(string name) { }

	// RVA: 0x16E7A00 Offset: 0x16E6000 VA: 0x1816E7A00
	internal static CodePageDataItem GetCodePageDataItem(int codepage) { }

}

public class ENCshift_jis : CP932 // TypeDefIndex: 7799
{	// Methods

	// RVA: 0x224C550 Offset: 0x224AB50 VA: 0x18224C550
	public void .ctor() { }

}

public class ENCiso_2022_jp : CP50220 // TypeDefIndex: 7807
{	// Methods

	// RVA: 0x2249CC0 Offset: 0x22482C0 VA: 0x182249CC0
	public void .ctor() { }

}

public class ENCeuc_jp : CP51932 // TypeDefIndex: 7811
{	// Methods

	// RVA: 0x224B0D0 Offset: 0x22496D0 VA: 0x18224B0D0
	public void .ctor() { }

}

internal class ENCgb2312 : CP936 // TypeDefIndex: 7814
{	// Methods

	// RVA: 0x224D0A0 Offset: 0x224B6A0 VA: 0x18224D0A0
	public void .ctor() { }

}

internal class ENCuhc : CP949 // TypeDefIndex: 7819
{	// Methods

	// RVA: 0x224D170 Offset: 0x224B770 VA: 0x18224D170
	public void .ctor() { }

}

internal class ENCeuc_kr : CP51949 // TypeDefIndex: 7820
{	// Methods

	// RVA: 0x224B1B0 Offset: 0x22497B0 VA: 0x18224B1B0
	public void .ctor() { }

}

internal class ENCbig5 : CP950 // TypeDefIndex: 7823
{	// Methods

	// RVA: 0x224DB80 Offset: 0x224C180 VA: 0x18224DB80
	public void .ctor() { }

}

internal class ENCgb18030 : GB18030Encoding // TypeDefIndex: 7828
{	// Methods

	// RVA: 0x224B2A0 Offset: 0x22498A0 VA: 0x18224B2A0
	public void .ctor() { }

}

public class ENCwindows_1254 : CP1254 // TypeDefIndex: 7841
{	// Methods

	// RVA: 0x2307B50 Offset: 0x2306150 VA: 0x182307B50
	public void .ctor() { }

}

public class ENCwindows_1255 : CP1255 // TypeDefIndex: 7843
{	// Methods

	// RVA: 0x2307C50 Offset: 0x2306250 VA: 0x182307C50
	public void .ctor() { }

}

public class ENCwindows_1256 : CP1256 // TypeDefIndex: 7845
{	// Methods

	// RVA: 0x2307D50 Offset: 0x2306350 VA: 0x182307D50
	public void .ctor() { }

}

public class ENCiso_8859_6 : CP28596 // TypeDefIndex: 7847
{	// Methods

	// RVA: 0x2307850 Offset: 0x2305E50 VA: 0x182307850
	public void .ctor() { }

}

public class ENCiso_8859_8 : CP28598 // TypeDefIndex: 7849
{	// Methods

	// RVA: 0x2307950 Offset: 0x2305F50 VA: 0x182307950
	public void .ctor() { }

}

public class ENCiso_8859_9 : CP28599 // TypeDefIndex: 7851
{	// Methods

	// RVA: 0x2307A50 Offset: 0x2306050 VA: 0x182307A50
	public void .ctor() { }

}

public class ENCwindows_38598 : CP38598 // TypeDefIndex: 7853
{	// Methods

	// RVA: 0x2307E50 Offset: 0x2306450 VA: 0x182307E50
	public void .ctor() { }

}

public class ENCwindows_1251 : CP1251 // TypeDefIndex: 7859
{	// Methods

	// RVA: 0x22F4C50 Offset: 0x22F3250 VA: 0x1822F4C50
	public void .ctor() { }

}

public class ENCwindows_1257 : CP1257 // TypeDefIndex: 7861
{	// Methods

	// RVA: 0x22F4D50 Offset: 0x22F3350 VA: 0x1822F4D50
	public void .ctor() { }

}

public class ENCwindows_1258 : CP1258 // TypeDefIndex: 7863
{	// Methods

	// RVA: 0x22F4E50 Offset: 0x22F3450 VA: 0x1822F4E50
	public void .ctor() { }

}

public class ENCkoi8_r : CP20866 // TypeDefIndex: 7865
{	// Methods

	// RVA: 0x22F4A50 Offset: 0x22F3050 VA: 0x1822F4A50
	public void .ctor() { }

}

public class ENCkoi8_u : CP21866 // TypeDefIndex: 7867
{	// Methods

	// RVA: 0x22F4B50 Offset: 0x22F3150 VA: 0x1822F4B50
	public void .ctor() { }

}

public class ENCiso_8859_4 : CP28594 // TypeDefIndex: 7869
{	// Methods

	// RVA: 0x22F4850 Offset: 0x22F2E50 VA: 0x1822F4850
	public void .ctor() { }

}

public class ENCiso_8859_5 : CP28595 // TypeDefIndex: 7871
{	// Methods

	// RVA: 0x22F4950 Offset: 0x22F2F50 VA: 0x1822F4950
	public void .ctor() { }

}

public class ENCx_iscii_de : CP57002 // TypeDefIndex: 7883
{	// Methods

	// RVA: 0x22F3F60 Offset: 0x22F2560 VA: 0x1822F3F60
	public void .ctor() { }

}

public class ENCx_iscii_be : CP57003 // TypeDefIndex: 7884
{	// Methods

	// RVA: 0x22F3FE0 Offset: 0x22F25E0 VA: 0x1822F3FE0
	public void .ctor() { }

}

public class ENCx_iscii_ta : CP57004 // TypeDefIndex: 7885
{	// Methods

	// RVA: 0x22F4060 Offset: 0x22F2660 VA: 0x1822F4060
	public void .ctor() { }

}

public class ENCx_iscii_te : CP57005 // TypeDefIndex: 7886
{	// Methods

	// RVA: 0x22F40E0 Offset: 0x22F26E0 VA: 0x1822F40E0
	public void .ctor() { }

}

public class ENCx_iscii_as : CP57006 // TypeDefIndex: 7887
{	// Methods

	// RVA: 0x22F4160 Offset: 0x22F2760 VA: 0x1822F4160
	public void .ctor() { }

}

public class ENCx_iscii_or : CP57007 // TypeDefIndex: 7888
{	// Methods

	// RVA: 0x22F41E0 Offset: 0x22F27E0 VA: 0x1822F41E0
	public void .ctor() { }

}

public class ENCx_iscii_ka : CP57008 // TypeDefIndex: 7889
{	// Methods

	// RVA: 0x22F4260 Offset: 0x22F2860 VA: 0x1822F4260
	public void .ctor() { }

}

public class ENCx_iscii_ma : CP57009 // TypeDefIndex: 7890
{	// Methods

	// RVA: 0x22F42E0 Offset: 0x22F28E0 VA: 0x1822F42E0
	public void .ctor() { }

}

public class ENCx_iscii_gu : CP57010 // TypeDefIndex: 7891
{	// Methods

	// RVA: 0x22F4360 Offset: 0x22F2960 VA: 0x1822F4360
	public void .ctor() { }

}

public class ENCx_iscii_pa : CP57011 // TypeDefIndex: 7892
{	// Methods

	// RVA: 0x22F43E0 Offset: 0x22F29E0 VA: 0x1822F43E0
	public void .ctor() { }

}

public class ENCwindows_874 : CP874 // TypeDefIndex: 7894
{	// Methods

	// RVA: 0x22F4F50 Offset: 0x22F3550 VA: 0x1822F4F50
	public void .ctor() { }

}

public class ENCibm866 : CP866 // TypeDefIndex: 7900
{	// Methods

	// RVA: 0x22EE290 Offset: 0x22EC890 VA: 0x1822EE290
	public void .ctor() { }

}

public class ENCibm1026 : CP1026 // TypeDefIndex: 7902
{	// Methods

	// RVA: 0x22ED8F0 Offset: 0x22EBEF0 VA: 0x1822ED8F0
	public void .ctor() { }

}

public class ENCibm869 : CP869 // TypeDefIndex: 7904
{	// Methods

	// RVA: 0x22EE390 Offset: 0x22EC990 VA: 0x1822EE390
	public void .ctor() { }

}

public class ENCibm870 : CP870 // TypeDefIndex: 7906
{	// Methods

	// RVA: 0x22EE490 Offset: 0x22ECA90 VA: 0x1822EE490
	public void .ctor() { }

}

public class ENCibm875 : CP875 // TypeDefIndex: 7908
{	// Methods

	// RVA: 0x22EE5F0 Offset: 0x22ECBF0 VA: 0x1822EE5F0
	public void .ctor() { }

}

public class ENCibm1047 : CP1047 // TypeDefIndex: 7910
{	// Methods

	// RVA: 0x22ED950 Offset: 0x22EBF50 VA: 0x1822ED950
	public void .ctor() { }

}

public class ENCibm01140 : CP1140 // TypeDefIndex: 7912
{	// Methods

	// RVA: 0x22ED6B0 Offset: 0x22EBCB0 VA: 0x1822ED6B0
	public void .ctor() { }

}

public class ENCibm01141 : CP1141 // TypeDefIndex: 7914
{	// Methods

	// RVA: 0x22ED710 Offset: 0x22EBD10 VA: 0x1822ED710
	public void .ctor() { }

}

public class ENCibm01142 : CP1142 // TypeDefIndex: 7916
{	// Methods

	// RVA: 0x22ED770 Offset: 0x22EBD70 VA: 0x1822ED770
	public void .ctor() { }

}

public class ENCibm01143 : CP1143 // TypeDefIndex: 7918
{	// Methods

	// RVA: 0x22ED7D0 Offset: 0x22EBDD0 VA: 0x1822ED7D0
	public void .ctor() { }

}

public class ENCibm1144 : CP1144 // TypeDefIndex: 7920
{	// Methods

	// RVA: 0x22ED9B0 Offset: 0x22EBFB0 VA: 0x1822ED9B0
	public void .ctor() { }

}

public class ENCibm1145 : CP1145 // TypeDefIndex: 7922
{	// Methods

	// RVA: 0x22EDA10 Offset: 0x22EC010 VA: 0x1822EDA10
	public void .ctor() { }

}

public class ENCibm1146 : CP1146 // TypeDefIndex: 7924
{	// Methods

	// RVA: 0x22EDA70 Offset: 0x22EC070 VA: 0x1822EDA70
	public void .ctor() { }

}

public class ENCibm1147 : CP1147 // TypeDefIndex: 7926
{	// Methods

	// RVA: 0x22EDAD0 Offset: 0x22EC0D0 VA: 0x1822EDAD0
	public void .ctor() { }

}

public class ENCibm1148 : CP1148 // TypeDefIndex: 7928
{	// Methods

	// RVA: 0x22EDB30 Offset: 0x22EC130 VA: 0x1822EDB30
	public void .ctor() { }

}

public class ENCibm1149 : CP1149 // TypeDefIndex: 7930
{	// Methods

	// RVA: 0x22EDB90 Offset: 0x22EC190 VA: 0x1822EDB90
	public void .ctor() { }

}

public class ENCibm273 : CP20273 // TypeDefIndex: 7932
{	// Methods

	// RVA: 0x22EDBF0 Offset: 0x22EC1F0 VA: 0x1822EDBF0
	public void .ctor() { }

}

public class ENCibm277 : CP20277 // TypeDefIndex: 7934
{	// Methods

	// RVA: 0x22EDC50 Offset: 0x22EC250 VA: 0x1822EDC50
	public void .ctor() { }

}

public class ENCibm278 : CP20278 // TypeDefIndex: 7936
{	// Methods

	// RVA: 0x22EDCB0 Offset: 0x22EC2B0 VA: 0x1822EDCB0
	public void .ctor() { }

}

public class ENCibm280 : CP20280 // TypeDefIndex: 7938
{	// Methods

	// RVA: 0x22EDD10 Offset: 0x22EC310 VA: 0x1822EDD10
	public void .ctor() { }

}

public class ENCibm284 : CP20284 // TypeDefIndex: 7940
{	// Methods

	// RVA: 0x22EDD70 Offset: 0x22EC370 VA: 0x1822EDD70
	public void .ctor() { }

}

public class ENCibm285 : CP20285 // TypeDefIndex: 7942
{	// Methods

	// RVA: 0x22EDDD0 Offset: 0x22EC3D0 VA: 0x1822EDDD0
	public void .ctor() { }

}

public class ENCibm290 : CP20290 // TypeDefIndex: 7944
{	// Methods

	// RVA: 0x22EDE30 Offset: 0x22EC430 VA: 0x1822EDE30
	public void .ctor() { }

}

public class ENCibm297 : CP20297 // TypeDefIndex: 7946
{	// Methods

	// RVA: 0x22EDE90 Offset: 0x22EC490 VA: 0x1822EDE90
	public void .ctor() { }

}

public class ENCibm420 : CP20420 // TypeDefIndex: 7948
{	// Methods

	// RVA: 0x22EDEF0 Offset: 0x22EC4F0 VA: 0x1822EDEF0
	public void .ctor() { }

}

public class ENCibm424 : CP20424 // TypeDefIndex: 7950
{	// Methods

	// RVA: 0x22EDF50 Offset: 0x22EC550 VA: 0x1822EDF50
	public void .ctor() { }

}

public class ENCibm871 : CP20871 // TypeDefIndex: 7952
{	// Methods

	// RVA: 0x22EE590 Offset: 0x22ECB90 VA: 0x1822EE590
	public void .ctor() { }

}

public class ENCibm1025 : CP21025 // TypeDefIndex: 7954
{	// Methods

	// RVA: 0x22ED890 Offset: 0x22EBE90 VA: 0x1822ED890
	public void .ctor() { }

}

public class ENCibm037 : CP37 // TypeDefIndex: 7956
{	// Methods

	// RVA: 0x22ED830 Offset: 0x22EBE30 VA: 0x1822ED830
	public void .ctor() { }

}

public class ENCibm500 : CP500 // TypeDefIndex: 7958
{	// Methods

	// RVA: 0x22EDFB0 Offset: 0x22EC5B0 VA: 0x1822EDFB0
	public void .ctor() { }

}

public class ENCasmo_708 : CP708 // TypeDefIndex: 7960
{	// Methods

	// RVA: 0x22ED5F0 Offset: 0x22EBBF0 VA: 0x1822ED5F0
	public void .ctor() { }

}

public class ENCibm852 : CP852 // TypeDefIndex: 7962
{	// Methods

	// RVA: 0x22EE010 Offset: 0x22EC610 VA: 0x1822EE010
	public void .ctor() { }

}

public class ENCibm855 : CP855 // TypeDefIndex: 7964
{	// Methods

	// RVA: 0x22EE070 Offset: 0x22EC670 VA: 0x1822EE070
	public void .ctor() { }

}

public class ENCibm857 : CP857 // TypeDefIndex: 7966
{	// Methods

	// RVA: 0x22EE0D0 Offset: 0x22EC6D0 VA: 0x1822EE0D0
	public void .ctor() { }

}

public class ENCibm00858 : CP858 // TypeDefIndex: 7968
{	// Methods

	// RVA: 0x22ED650 Offset: 0x22EBC50 VA: 0x1822ED650
	public void .ctor() { }

}

public class ENCibm862 : CP862 // TypeDefIndex: 7970
{	// Methods

	// RVA: 0x22EE130 Offset: 0x22EC730 VA: 0x1822EE130
	public void .ctor() { }

}

public class ENCibm864 : CP864 // TypeDefIndex: 7972
{	// Methods

	// RVA: 0x22EE190 Offset: 0x22EC790 VA: 0x1822EE190
	public void .ctor() { }

}

public class ENCmacintosh : CP10000 // TypeDefIndex: 7978
{	// Methods

	// RVA: 0x228D680 Offset: 0x228BC80 VA: 0x18228D680
	public void .ctor() { }

}

public class ENCx_mac_icelandic : CP10079 // TypeDefIndex: 7980
{	// Methods

	// RVA: 0x228DA80 Offset: 0x228C080 VA: 0x18228DA80
	public void .ctor() { }

}

public class ENCwindows_1250 : CP1250 // TypeDefIndex: 7982
{	// Methods

	// RVA: 0x228D780 Offset: 0x228BD80 VA: 0x18228D780
	public void .ctor() { }

}

public class ENCwindows_1252 : CP1252 // TypeDefIndex: 7984
{	// Methods

	// RVA: 0x228D880 Offset: 0x228BE80 VA: 0x18228D880
	public void .ctor() { }

}

public class ENCwindows_1253 : CP1253 // TypeDefIndex: 7986
{	// Methods

	// RVA: 0x228D980 Offset: 0x228BF80 VA: 0x18228D980
	public void .ctor() { }

}

public class ENCiso_8859_2 : CP28592 // TypeDefIndex: 7988
{	// Methods

	// RVA: 0x228D380 Offset: 0x228B980 VA: 0x18228D380
	public void .ctor() { }

}

public class ENCiso_8859_3 : CP28593 // TypeDefIndex: 7990
{	// Methods

	// RVA: 0x228D480 Offset: 0x228BA80 VA: 0x18228D480
	public void .ctor() { }

}

public class ENCiso_8859_7 : CP28597 // TypeDefIndex: 7992
{	// Methods

	// RVA: 0x228D580 Offset: 0x228BB80 VA: 0x18228D580
	public void .ctor() { }

}

public class ENCiso_8859_15 : CP28605 // TypeDefIndex: 7994
{	// Methods

	// RVA: 0x228D280 Offset: 0x228B880 VA: 0x18228D280
	public void .ctor() { }

}

public class ENCibm437 : CP437 // TypeDefIndex: 7996
{	// Methods

	// RVA: 0x228CC80 Offset: 0x228B280 VA: 0x18228CC80
	public void .ctor() { }

}

public class ENCibm850 : CP850 // TypeDefIndex: 7998
{	// Methods

	// RVA: 0x228CD80 Offset: 0x228B380 VA: 0x18228CD80
	public void .ctor() { }

}

public class ENCibm860 : CP860 // TypeDefIndex: 8000
{	// Methods

	// RVA: 0x228CE80 Offset: 0x228B480 VA: 0x18228CE80
	public void .ctor() { }

}

public class ENCibm861 : CP861 // TypeDefIndex: 8002
{	// Methods

	// RVA: 0x228CF80 Offset: 0x228B580 VA: 0x18228CF80
	public void .ctor() { }

}

public class ENCibm863 : CP863 // TypeDefIndex: 8004
{	// Methods

	// RVA: 0x228D080 Offset: 0x228B680 VA: 0x18228D080
	public void .ctor() { }

}

public class ENCibm865 : CP865 // TypeDefIndex: 8006
{	// Methods

	// RVA: 0x228D180 Offset: 0x228B780 VA: 0x18228D180
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

	// RVA: 0x87A4E0 Offset: 0x878AE0 VA: 0x18087A4E0
	private void .ctor(EncodeOptions options) { }

	// RVA: 0x87A0D0 Offset: 0x8786D0 VA: 0x18087A0D0
	public static string Encode(object obj) { }

	// RVA: 0x879FF0 Offset: 0x8785F0 VA: 0x180879FF0
	public static string Encode(object obj, EncodeOptions options) { }

	// RVA: 0x87A580 Offset: 0x878B80 VA: 0x18087A580
	private bool get_PrettyPrintEnabled() { }

	// RVA: 0x87A590 Offset: 0x878B90 VA: 0x18087A590
	private bool get_TypeHintsEnabled() { }

	// RVA: 0x87A570 Offset: 0x878B70 VA: 0x18087A570
	private bool get_IncludePublicPropertiesEnabled() { }

	// RVA: 0x87A560 Offset: 0x878B60 VA: 0x18087A560
	private bool get_EnforceHierarchyOrderEnabled() { }

	// RVA: 0x8799E0 Offset: 0x877FE0 VA: 0x1808799E0
	private void EncodeValue(object value, bool forceTypeHint) { }

	// RVA: 0x87A130 Offset: 0x878730 VA: 0x18087A130
	private IEnumerable<FieldInfo> GetFieldsForType(Type type) { }

	// RVA: 0x87A2A0 Offset: 0x8788A0 VA: 0x18087A2A0
	private IEnumerable<PropertyInfo> GetPropertiesForType(Type type) { }

	// RVA: 0x8784F0 Offset: 0x876AF0 VA: 0x1808784F0
	private void EncodeObject(object value, bool forceTypeHint) { }

	// RVA: 0x879080 Offset: 0x877680 VA: 0x180879080
	private void EncodeProxyArray(ProxyArray value) { }

	// RVA: 0x879390 Offset: 0x877990 VA: 0x180879390
	private void EncodeProxyObject(ProxyObject value) { }

	// RVA: 0x877DC0 Offset: 0x8763C0 VA: 0x180877DC0
	private void EncodeDictionary(IDictionary value, bool forceTypeHint) { }

	// RVA: 0x8781E0 Offset: 0x8767E0 VA: 0x1808781E0
	private void EncodeList(IList value, bool forceTypeHint) { }

	// RVA: 0x877D00 Offset: 0x876300 VA: 0x180877D00
	private void EncodeArray(Array value, bool forceTypeHint) { }

	// RVA: 0x877A00 Offset: 0x876000 VA: 0x180877A00
	private void EncodeArrayRank(Array value, int rank, int[] indices, bool forceTypeHint) { }

	// RVA: 0x8796F0 Offset: 0x877CF0 VA: 0x1808796F0
	private void EncodeString(string value) { }

	// RVA: 0x877910 Offset: 0x875F10 VA: 0x180877910
	private void AppendIndent() { }

	// RVA: 0x877960 Offset: 0x875F60 VA: 0x180877960
	private void AppendOpenBrace() { }

	// RVA: 0x877740 Offset: 0x875D40 VA: 0x180877740
	private void AppendCloseBrace() { }

	// RVA: 0x8779B0 Offset: 0x875FB0 VA: 0x1808779B0
	private void AppendOpenBracket() { }

	// RVA: 0x8777C0 Offset: 0x875DC0 VA: 0x1808777C0
	private void AppendCloseBracket() { }

	// RVA: 0x877890 Offset: 0x875E90 VA: 0x180877890
	private void AppendComma(bool firstItem) { }

	// RVA: 0x877840 Offset: 0x875E40 VA: 0x180877840
	private void AppendColon() { }

	// RVA: 0x87A410 Offset: 0x878A10 VA: 0x18087A410
	private static void .cctor() { }

}

