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

	// RVA: 0x18AEDC0 Offset: 0x18AD3C0 VA: 0x1818AEDC0
	internal void SerializeEncoder(SerializationInfo info) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public EncoderFallback get_Fallback() { }

	// RVA: 0x18AEE20 Offset: 0x18AD420 VA: 0x1818AEE20
	public EncoderFallbackBuffer get_FallbackBuffer() { }

	// RVA: 0x17CB140 Offset: 0x17C9740 VA: 0x1817CB140
	internal bool get_InternalHasFallbackBuffer() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18AECF0 Offset: 0x18AD2F0 VA: 0x1818AECF0 Slot: 4
	public virtual void Reset() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetByteCount(char[] chars, int index, int count, bool flush);

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x18AE950 Offset: 0x18ACF50 VA: 0x1818AE950 Slot: 6
	public virtual int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush);

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x18AEAC0 Offset: 0x18AD0C0 VA: 0x1818AEAC0 Slot: 8
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18AE5E0 Offset: 0x18ACBE0 VA: 0x1818AE5E0 Slot: 9
	public virtual void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x18AE3A0 Offset: 0x18AC9A0 VA: 0x1818AE3A0 Slot: 10
	public virtual void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

}

public sealed class EncoderExceptionFallback : EncoderFallback // TypeDefIndex: 447
{	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0x18AE2F0 Offset: 0x18AC8F0 VA: 0x1818AE2F0 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x18AE340 Offset: 0x18AC940 VA: 0x1818AE340 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x18AE390 Offset: 0x18AC990 VA: 0x1818AE390 Slot: 2
	public override int GetHashCode() { }

}

public sealed class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 448
{	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0x18ADE80 Offset: 0x18AC480 VA: 0x1818ADE80 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x18ADF90 Offset: 0x18AC590 VA: 0x1818ADF90 Slot: 5
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

	// RVA: 0x19137E0 Offset: 0x1911DE0 VA: 0x1819137E0
	public void .ctor() { }

	// RVA: 0x15C8280 Offset: 0x15C6880 VA: 0x1815C8280
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1913840 Offset: 0x1911E40 VA: 0x181913840
	internal void .ctor(string message, char charUnknown, int index) { }

	// RVA: 0x1913560 Offset: 0x1911B60 VA: 0x181913560
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

	// RVA: 0x1913A40 Offset: 0x1912040 VA: 0x181913A40
	private static object get_InternalSyncObject() { }

	// RVA: 0x1913AD0 Offset: 0x19120D0 VA: 0x181913AD0
	public static EncoderFallback get_ReplacementFallback() { }

	// RVA: 0x1913880 Offset: 0x1911E80 VA: 0x181913880
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

	// RVA: 0x1913470 Offset: 0x1911A70 VA: 0x181913470 Slot: 9
	public virtual void Reset() { }

	// RVA: 0x1913450 Offset: 0x1911A50 VA: 0x181913450
	internal void InternalReset() { }

	// RVA: 0x1913410 Offset: 0x1911A10 VA: 0x181913410
	internal void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder) { }

	// RVA: 0x19133D0 Offset: 0x19119D0 VA: 0x1819133D0
	internal char InternalGetNextChar() { }

	// RVA: 0x1913210 Offset: 0x1911810 VA: 0x181913210 Slot: 10
	internal virtual bool InternalFallback(char ch, ref char* chars) { }

	// RVA: 0x19134A0 Offset: 0x1911AA0 VA: 0x1819134A0
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

	// RVA: 0x1914990 Offset: 0x1912F90 VA: 0x181914990
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1914860 Offset: 0x1912E60 VA: 0x181914860 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1914920 Offset: 0x1912F20 VA: 0x181914920
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x1914A50 Offset: 0x1913050 VA: 0x181914A50
	internal void .ctor() { }

	// RVA: 0x1914830 Offset: 0x1912E30 VA: 0x181914830 Slot: 4
	public override void Reset() { }

	// RVA: 0x1914190 Offset: 0x1912790 VA: 0x181914190 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

	// RVA: 0x1914340 Offset: 0x1912940 VA: 0x181914340 Slot: 6
	public override int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: 0x1914460 Offset: 0x1912A60 VA: 0x181914460 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: 0x19146E0 Offset: 0x1912CE0 VA: 0x1819146E0 Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x1913CB0 Offset: 0x19122B0 VA: 0x181913CB0 Slot: 9
	public override void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	// RVA: 0x1913FC0 Offset: 0x19125C0 VA: 0x181913FC0 Slot: 10
	public override void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public Encoding get_Encoding() { }

	// RVA: 0x82BC90 Offset: 0x82A290 VA: 0x18082BC90
	public bool get_MustFlush() { }

	// RVA: 0x1914A90 Offset: 0x1913090 VA: 0x181914A90 Slot: 12
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

	// RVA: 0x19150D0 Offset: 0x19136D0 VA: 0x1819150D0
	public void .ctor() { }

	// RVA: 0x1915110 Offset: 0x1913710 VA: 0x181915110
	public void .ctor(string replacement) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_DefaultString() { }

	// RVA: 0x1914FE0 Offset: 0x19135E0 VA: 0x181914FE0 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x18AD350 Offset: 0x18AB950 VA: 0x1818AD350 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x1915060 Offset: 0x1913660 VA: 0x181915060 Slot: 0
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

	// RVA: 0x1914F70 Offset: 0x1913570 VA: 0x181914F70
	public void .ctor(EncoderReplacementFallback fallback) { }

	// RVA: 0x1914D60 Offset: 0x1913360 VA: 0x181914D60 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x1914AA0 Offset: 0x19130A0 VA: 0x181914AA0 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x1914EE0 Offset: 0x19134E0 VA: 0x181914EE0 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x1914F30 Offset: 0x1913530 VA: 0x181914F30 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x1914FD0 Offset: 0x19135D0 VA: 0x181914FD0 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x1914F50 Offset: 0x1913550 VA: 0x181914F50 Slot: 9
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

	// RVA: 0x191AC80 Offset: 0x1919280 VA: 0x18191AC80
	protected void .ctor() { }

	// RVA: 0x191ABF0 Offset: 0x19191F0 VA: 0x18191ABF0
	protected void .ctor(int codePage) { }

	// RVA: 0x191A800 Offset: 0x1918E00 VA: 0x18191A800 Slot: 5
	internal virtual void SetDefaultFallbacks() { }

	// RVA: 0x191A6B0 Offset: 0x1918CB0 VA: 0x18191A6B0
	internal void OnDeserializing() { }

	// RVA: 0x191A660 Offset: 0x1918C60 VA: 0x18191A660
	internal void OnDeserialized() { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x191A6B0 Offset: 0x1918CB0 VA: 0x18191A6B0
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x191A660 Offset: 0x1918C60 VA: 0x18191A660
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA7DC80 Offset: 0xA7C280 VA: 0x180A7DC80
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x1918130 Offset: 0x1916730 VA: 0x181918130
	internal void DeserializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x191A6F0 Offset: 0x1918CF0 VA: 0x18191A6F0
	internal void SerializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x191AF80 Offset: 0x1919580 VA: 0x18191AF80
	private static object get_InternalSyncObject() { }

	// RVA: 0x1919390 Offset: 0x1917990 VA: 0x181919390
	public static Encoding GetEncoding(int codepage) { }

	// RVA: 0x191A240 Offset: 0x1918840 VA: 0x18191A240
	public static Encoding GetEncoding(string name) { }

	// RVA: 0x191A430 Offset: 0x1918A30 VA: 0x18191A430 Slot: 6
	public virtual byte[] GetPreamble() { }

	// RVA: 0x1919190 Offset: 0x1917790 VA: 0x181919190
	private void GetDataItem() { }

	// RVA: 0x191AE20 Offset: 0x1919420 VA: 0x18191AE20 Slot: 7
	public virtual string get_BodyName() { }

	// RVA: 0x191AF30 Offset: 0x1919530 VA: 0x18191AF30 Slot: 8
	public virtual string get_EncodingName() { }

	// RVA: 0x191AF40 Offset: 0x1919540 VA: 0x18191AF40 Slot: 9
	public virtual string get_HeaderName() { }

	// RVA: 0x191B520 Offset: 0x1919B20 VA: 0x18191B520 Slot: 10
	public virtual string get_WebName() { }

	// RVA: 0x191B560 Offset: 0x1919B60 VA: 0x18191B560 Slot: 11
	public virtual int get_WindowsCodePage() { }

	// RVA: 0x191B010 Offset: 0x1919610 VA: 0x18191B010 Slot: 12
	public virtual bool get_IsBrowserDisplay() { }

	// RVA: 0x191B050 Offset: 0x1919650 VA: 0x18191B050 Slot: 13
	public virtual bool get_IsBrowserSave() { }

	// RVA: 0x191B090 Offset: 0x1919690 VA: 0x18191B090 Slot: 14
	public virtual bool get_IsMailNewsDisplay() { }

	// RVA: 0x191B0D0 Offset: 0x19196D0 VA: 0x18191B0D0 Slot: 15
	public virtual bool get_IsMailNewsSave() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 16
	public virtual bool get_IsSingleByte() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public EncoderFallback get_EncoderFallback() { }

	// RVA: 0x191B670 Offset: 0x1919C70 VA: 0x18191B670
	public void set_EncoderFallback(EncoderFallback value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public DecoderFallback get_DecoderFallback() { }

	// RVA: 0x191B5B0 Offset: 0x1919BB0 VA: 0x18191B5B0
	public void set_DecoderFallback(DecoderFallback value) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1918040 Offset: 0x1916640 VA: 0x181918040 Slot: 17
	public virtual object Clone() { }

	// RVA: 0xB10400 Offset: 0xB0EA00 VA: 0x180B10400
	public bool get_IsReadOnly() { }

	// RVA: 0x191ACE0 Offset: 0x19192E0 VA: 0x18191ACE0
	public static Encoding get_ASCII() { }

	// RVA: 0x191B110 Offset: 0x1919710 VA: 0x18191B110
	private static Encoding get_Latin1() { }

	// RVA: 0x19185A0 Offset: 0x1916BA0 VA: 0x1819185A0 Slot: 18
	public virtual int GetByteCount(string s) { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract int GetByteCount(char[] chars, int index, int count);

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x1918650 Offset: 0x1916C50 VA: 0x181918650 Slot: 20
	public virtual int GetByteCount(char* chars, int count) { }

	// RVA: 0x1277070 Offset: 0x1275670 VA: 0x181277070 Slot: 21
	internal virtual int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x1918C60 Offset: 0x1917260 VA: 0x181918C60 Slot: 22
	public virtual byte[] GetBytes(char[] chars) { }

	// RVA: 0x1918B90 Offset: 0x1917190 VA: 0x181918B90 Slot: 23
	public virtual byte[] GetBytes(char[] chars, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);

	// RVA: 0x19189C0 Offset: 0x1916FC0 VA: 0x1819189C0 Slot: 25
	public virtual byte[] GetBytes(string s) { }

	// RVA: 0x1918AB0 Offset: 0x19170B0 VA: 0x181918AB0 Slot: 26
	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1918B70 Offset: 0x1917170 VA: 0x181918B70 Slot: 27
	internal virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x19187A0 Offset: 0x1916DA0 VA: 0x1819187A0 Slot: 28
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract int GetCharCount(byte[] bytes, int index, int count);

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x1918D10 Offset: 0x1917310 VA: 0x181918D10 Slot: 30
	public virtual int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1918E60 Offset: 0x1917460 VA: 0x181918E60 Slot: 31
	internal virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x1918E80 Offset: 0x1917480 VA: 0x181918E80 Slot: 32
	public virtual char[] GetChars(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 33
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x1918F50 Offset: 0x1917550 VA: 0x181918F50 Slot: 34
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1919170 Offset: 0x1917770 VA: 0x181919170 Slot: 35
	internal virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x191A490 Offset: 0x1918A90 VA: 0x18191A490
	public string GetString(byte* bytes, int byteCount) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 36
	public virtual int get_CodePage() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 37
	public virtual bool IsAlwaysNormalized(NormalizationForm form) { }

	// RVA: 0x19192B0 Offset: 0x19178B0 VA: 0x1819192B0 Slot: 38
	public virtual Decoder GetDecoder() { }

	// RVA: 0x19180D0 Offset: 0x19166D0 VA: 0x1819180D0
	private static Encoding CreateDefaultEncoding() { }

	// RVA: 0x13A3780 Offset: 0x13A1D80 VA: 0x1813A3780
	internal void setReadOnly(bool value = True) { }

	// RVA: 0x191AE60 Offset: 0x1919460 VA: 0x18191AE60
	public static Encoding get_Default() { }

	// RVA: 0x1919320 Offset: 0x1917920 VA: 0x181919320 Slot: 39
	public virtual Encoder GetEncoder() { }

	// RVA: -1 Offset: -1 Slot: 40
	public abstract int GetMaxByteCount(int charCount);

	// RVA: -1 Offset: -1 Slot: 41
	public abstract int GetMaxCharCount(int byteCount);

	// RVA: 0x191A580 Offset: 0x1918B80 VA: 0x18191A580 Slot: 42
	public virtual string GetString(byte[] bytes) { }

	// RVA: 0x191A630 Offset: 0x1918C30 VA: 0x18191A630 Slot: 43
	public virtual string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x191B480 Offset: 0x1919A80 VA: 0x18191B480
	public static Encoding get_Unicode() { }

	// RVA: 0x191AD80 Offset: 0x1919380 VA: 0x18191AD80
	public static Encoding get_BigEndianUnicode() { }

	// RVA: 0x191B2B0 Offset: 0x19198B0 VA: 0x18191B2B0
	public static Encoding get_UTF7() { }

	// RVA: 0x191B3A0 Offset: 0x19199A0 VA: 0x18191B3A0
	public static Encoding get_UTF8() { }

	// RVA: 0x191B1F0 Offset: 0x19197F0 VA: 0x18191B1F0
	public static Encoding get_UTF32() { }

	// RVA: 0x19183F0 Offset: 0x19169F0 VA: 0x1819183F0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x191A3C0 Offset: 0x19189C0 VA: 0x18191A3C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1918540 Offset: 0x1916B40 VA: 0x181918540 Slot: 44
	internal virtual char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x19184E0 Offset: 0x1916AE0 VA: 0x1819184E0 Slot: 45
	internal virtual char[] GetBestFitBytesToUnicodeData() { }

	// RVA: 0x191A950 Offset: 0x1918F50 VA: 0x18191A950
	internal void ThrowBytesOverflow() { }

	// RVA: 0x191A8C0 Offset: 0x1918EC0 VA: 0x18191A8C0
	internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded) { }

	// RVA: 0x191AAF0 Offset: 0x19190F0 VA: 0x18191AAF0
	internal void ThrowCharsOverflow() { }

	// RVA: 0x191AA50 Offset: 0x1919050 VA: 0x18191AA50
	internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded) { }

}

internal class Encoding.DefaultEncoder : Encoder, ISerializable, IObjectReference // TypeDefIndex: 456
{	// Fields
	private Encoding m_encoding; // 0x20
	private bool m_hasInitializedEncoding; // 0x28
	internal char charLeftOver; // 0x2A

	// Methods

	// RVA: 0x1912D50 Offset: 0x1911350 VA: 0x181912D50
	public void .ctor(Encoding encoding) { }

	// RVA: 0x1912FC0 Offset: 0x19115C0 VA: 0x181912FC0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1912E50 Offset: 0x1911450 VA: 0x181912E50 Slot: 12
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x1912F30 Offset: 0x1911530 VA: 0x181912F30 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1912D90 Offset: 0x1911390 VA: 0x181912D90 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

	// RVA: 0x1912DC0 Offset: 0x19113C0 VA: 0x181912DC0 Slot: 6
	public override int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: 0x1912DF0 Offset: 0x19113F0 VA: 0x181912DF0 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: 0x1912E20 Offset: 0x1911420 VA: 0x181912E20 Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

}

internal class Encoding.DefaultDecoder : Decoder, ISerializable, IObjectReference // TypeDefIndex: 457
{	// Fields
	private Encoding m_encoding; // 0x20
	private bool m_hasInitializedEncoding; // 0x28

	// Methods

	// RVA: 0x1912D50 Offset: 0x1911350 VA: 0x181912D50
	public void .ctor(Encoding encoding) { }

	// RVA: 0x1912B50 Offset: 0x1911150 VA: 0x181912B50
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1912A50 Offset: 0x1911050 VA: 0x181912A50 Slot: 14
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x1912AC0 Offset: 0x19110C0 VA: 0x181912AC0 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE4D640 Offset: 0xE4BC40 VA: 0x180E4D640 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x19129C0 Offset: 0x1910FC0 VA: 0x1819129C0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x1912990 Offset: 0x1910F90 VA: 0x181912990 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x18ACC90 Offset: 0x18AB290 VA: 0x1818ACC90 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1912A20 Offset: 0x1911020 VA: 0x181912A20 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x19129F0 Offset: 0x1910FF0 VA: 0x1819129F0 Slot: 10
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

	// RVA: 0x1915FE0 Offset: 0x19145E0 VA: 0x181915FE0
	internal void .ctor(Encoding enc, DecoderNLS decoder, char* charStart, int charCount, byte* byteStart, int byteCount) { }

	// RVA: 0x1915C20 Offset: 0x1914220 VA: 0x181915C20
	internal bool AddChar(char ch, int numBytes) { }

	// RVA: 0x1915D00 Offset: 0x1914300 VA: 0x181915D00
	internal bool AddChar(char ch) { }

	// RVA: 0x1915DE0 Offset: 0x19143E0 VA: 0x181915DE0
	internal void AdjustBytes(int count) { }

	// RVA: 0x19160F0 Offset: 0x19146F0 VA: 0x1819160F0
	internal bool get_MoreData() { }

	// RVA: 0x1915FC0 Offset: 0x19145C0 VA: 0x181915FC0
	internal byte GetNextByte() { }

	// RVA: 0x19160E0 Offset: 0x19146E0 VA: 0x1819160E0
	internal int get_BytesUsed() { }

	// RVA: 0x1915F40 Offset: 0x1914540 VA: 0x181915F40
	internal bool Fallback(byte fallbackByte) { }

	// RVA: 0x1915DF0 Offset: 0x19143F0 VA: 0x181915DF0
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

	// RVA: 0x1915910 Offset: 0x1913F10 VA: 0x181915910
	internal void .ctor(Encoding inEncoding, EncoderNLS inEncoder, byte* inByteStart, int inByteCount, char* inCharStart, int inCharCount) { }

	// RVA: 0x19156A0 Offset: 0x1913CA0 VA: 0x1819156A0
	internal bool AddByte(byte b, int moreBytesExpected) { }

	// RVA: 0x19155E0 Offset: 0x1913BE0 VA: 0x1819155E0
	internal bool AddByte(byte b1) { }

	// RVA: 0x19155F0 Offset: 0x1913BF0 VA: 0x1819155F0
	internal bool AddByte(byte b1, byte b2) { }

	// RVA: 0x1915640 Offset: 0x1913C40 VA: 0x181915640
	internal bool AddByte(byte b1, byte b2, int moreBytesExpected) { }

	// RVA: 0x1915820 Offset: 0x1913E20 VA: 0x181915820
	internal void MovePrevious(bool bThrow) { }

	// RVA: 0x1915BD0 Offset: 0x19141D0 VA: 0x181915BD0
	internal bool get_MoreData() { }

	// RVA: 0x19157B0 Offset: 0x1913DB0 VA: 0x1819157B0
	internal char GetNextChar() { }

	// RVA: 0x1915BB0 Offset: 0x19141B0 VA: 0x181915BB0
	internal int get_CharsUsed() { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	internal int get_Count() { }

}

internal abstract class EncodingNLS : Encoding // TypeDefIndex: 460
{	// Methods

	// RVA: 0x1917DB0 Offset: 0x19163B0 VA: 0x181917DB0
	protected void .ctor(int codePage) { }

	// RVA: 0x1916D60 Offset: 0x1915360 VA: 0x181916D60 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1916CC0 Offset: 0x19152C0 VA: 0x181916CC0 Slot: 18
	public override int GetByteCount(string s) { }

	// RVA: 0x1916BC0 Offset: 0x19151C0 VA: 0x181916BC0 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1917290 Offset: 0x1915890 VA: 0x181917290 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1916EF0 Offset: 0x19154F0 VA: 0x181916EF0 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1917150 Offset: 0x1915750 VA: 0x181917150 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x19174F0 Offset: 0x1915AF0 VA: 0x1819174F0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x1917680 Offset: 0x1915C80 VA: 0x181917680 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x19178C0 Offset: 0x1915EC0 VA: 0x1819178C0 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1917780 Offset: 0x1915D80 VA: 0x181917780 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1917C20 Offset: 0x1916220 VA: 0x181917C20 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1917B20 Offset: 0x1916120 VA: 0x181917B20 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x1917B80 Offset: 0x1916180 VA: 0x181917B80 Slot: 39
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

	// RVA: 0x1917ED0 Offset: 0x19164D0 VA: 0x181917ED0
	internal static Encoding GetEncodingFromProvider(int codepage) { }

	// RVA: 0x1917DC0 Offset: 0x19163C0 VA: 0x181917DC0
	internal static Encoding GetEncodingFromProvider(string encodingName) { }

	// RVA: 0x1917FE0 Offset: 0x19165E0 VA: 0x181917FE0
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

	// RVA: 0x1916960 Offset: 0x1914F60 VA: 0x181916960
	internal static Encoding get_UTF8Unmarked() { }

	// RVA: 0x19163A0 Offset: 0x19149A0 VA: 0x1819163A0
	internal static string InternalCodePage(ref int code_page) { }

	// RVA: 0x1916100 Offset: 0x1914700 VA: 0x181916100
	internal static Encoding GetDefaultEncoding() { }

	// RVA: 0x19163B0 Offset: 0x19149B0 VA: 0x1819163B0
	internal static object InvokeI18N(string name, object[] args) { }

	// RVA: 0x1916900 Offset: 0x1914F00 VA: 0x181916900
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

	// RVA: 0x224C390 Offset: 0x224A990 VA: 0x18224C390
	public void .ctor() { }

}

public class ENCiso_2022_jp : CP50220 // TypeDefIndex: 7807
{	// Methods

	// RVA: 0x2249B00 Offset: 0x2248100 VA: 0x182249B00
	public void .ctor() { }

}

public class ENCeuc_jp : CP51932 // TypeDefIndex: 7811
{	// Methods

	// RVA: 0x224AF10 Offset: 0x2249510 VA: 0x18224AF10
	public void .ctor() { }

}

internal class ENCgb2312 : CP936 // TypeDefIndex: 7814
{	// Methods

	// RVA: 0x224CEE0 Offset: 0x224B4E0 VA: 0x18224CEE0
	public void .ctor() { }

}

internal class ENCuhc : CP949 // TypeDefIndex: 7819
{	// Methods

	// RVA: 0x224CFB0 Offset: 0x224B5B0 VA: 0x18224CFB0
	public void .ctor() { }

}

internal class ENCeuc_kr : CP51949 // TypeDefIndex: 7820
{	// Methods

	// RVA: 0x224AFF0 Offset: 0x22495F0 VA: 0x18224AFF0
	public void .ctor() { }

}

internal class ENCbig5 : CP950 // TypeDefIndex: 7823
{	// Methods

	// RVA: 0x224D9C0 Offset: 0x224BFC0 VA: 0x18224D9C0
	public void .ctor() { }

}

internal class ENCgb18030 : GB18030Encoding // TypeDefIndex: 7828
{	// Methods

	// RVA: 0x224B0E0 Offset: 0x22496E0 VA: 0x18224B0E0
	public void .ctor() { }

}

public class ENCwindows_1254 : CP1254 // TypeDefIndex: 7841
{	// Methods

	// RVA: 0x2307990 Offset: 0x2305F90 VA: 0x182307990
	public void .ctor() { }

}

public class ENCwindows_1255 : CP1255 // TypeDefIndex: 7843
{	// Methods

	// RVA: 0x2307A90 Offset: 0x2306090 VA: 0x182307A90
	public void .ctor() { }

}

public class ENCwindows_1256 : CP1256 // TypeDefIndex: 7845
{	// Methods

	// RVA: 0x2307B90 Offset: 0x2306190 VA: 0x182307B90
	public void .ctor() { }

}

public class ENCiso_8859_6 : CP28596 // TypeDefIndex: 7847
{	// Methods

	// RVA: 0x2307690 Offset: 0x2305C90 VA: 0x182307690
	public void .ctor() { }

}

public class ENCiso_8859_8 : CP28598 // TypeDefIndex: 7849
{	// Methods

	// RVA: 0x2307790 Offset: 0x2305D90 VA: 0x182307790
	public void .ctor() { }

}

public class ENCiso_8859_9 : CP28599 // TypeDefIndex: 7851
{	// Methods

	// RVA: 0x2307890 Offset: 0x2305E90 VA: 0x182307890
	public void .ctor() { }

}

public class ENCwindows_38598 : CP38598 // TypeDefIndex: 7853
{	// Methods

	// RVA: 0x2307C90 Offset: 0x2306290 VA: 0x182307C90
	public void .ctor() { }

}

public class ENCwindows_1251 : CP1251 // TypeDefIndex: 7859
{	// Methods

	// RVA: 0x22F4A90 Offset: 0x22F3090 VA: 0x1822F4A90
	public void .ctor() { }

}

public class ENCwindows_1257 : CP1257 // TypeDefIndex: 7861
{	// Methods

	// RVA: 0x22F4B90 Offset: 0x22F3190 VA: 0x1822F4B90
	public void .ctor() { }

}

public class ENCwindows_1258 : CP1258 // TypeDefIndex: 7863
{	// Methods

	// RVA: 0x22F4C90 Offset: 0x22F3290 VA: 0x1822F4C90
	public void .ctor() { }

}

public class ENCkoi8_r : CP20866 // TypeDefIndex: 7865
{	// Methods

	// RVA: 0x22F4890 Offset: 0x22F2E90 VA: 0x1822F4890
	public void .ctor() { }

}

public class ENCkoi8_u : CP21866 // TypeDefIndex: 7867
{	// Methods

	// RVA: 0x22F4990 Offset: 0x22F2F90 VA: 0x1822F4990
	public void .ctor() { }

}

public class ENCiso_8859_4 : CP28594 // TypeDefIndex: 7869
{	// Methods

	// RVA: 0x22F4690 Offset: 0x22F2C90 VA: 0x1822F4690
	public void .ctor() { }

}

public class ENCiso_8859_5 : CP28595 // TypeDefIndex: 7871
{	// Methods

	// RVA: 0x22F4790 Offset: 0x22F2D90 VA: 0x1822F4790
	public void .ctor() { }

}

public class ENCx_iscii_de : CP57002 // TypeDefIndex: 7883
{	// Methods

	// RVA: 0x22F3DA0 Offset: 0x22F23A0 VA: 0x1822F3DA0
	public void .ctor() { }

}

public class ENCx_iscii_be : CP57003 // TypeDefIndex: 7884
{	// Methods

	// RVA: 0x22F3E20 Offset: 0x22F2420 VA: 0x1822F3E20
	public void .ctor() { }

}

public class ENCx_iscii_ta : CP57004 // TypeDefIndex: 7885
{	// Methods

	// RVA: 0x22F3EA0 Offset: 0x22F24A0 VA: 0x1822F3EA0
	public void .ctor() { }

}

public class ENCx_iscii_te : CP57005 // TypeDefIndex: 7886
{	// Methods

	// RVA: 0x22F3F20 Offset: 0x22F2520 VA: 0x1822F3F20
	public void .ctor() { }

}

public class ENCx_iscii_as : CP57006 // TypeDefIndex: 7887
{	// Methods

	// RVA: 0x22F3FA0 Offset: 0x22F25A0 VA: 0x1822F3FA0
	public void .ctor() { }

}

public class ENCx_iscii_or : CP57007 // TypeDefIndex: 7888
{	// Methods

	// RVA: 0x22F4020 Offset: 0x22F2620 VA: 0x1822F4020
	public void .ctor() { }

}

public class ENCx_iscii_ka : CP57008 // TypeDefIndex: 7889
{	// Methods

	// RVA: 0x22F40A0 Offset: 0x22F26A0 VA: 0x1822F40A0
	public void .ctor() { }

}

public class ENCx_iscii_ma : CP57009 // TypeDefIndex: 7890
{	// Methods

	// RVA: 0x22F4120 Offset: 0x22F2720 VA: 0x1822F4120
	public void .ctor() { }

}

public class ENCx_iscii_gu : CP57010 // TypeDefIndex: 7891
{	// Methods

	// RVA: 0x22F41A0 Offset: 0x22F27A0 VA: 0x1822F41A0
	public void .ctor() { }

}

public class ENCx_iscii_pa : CP57011 // TypeDefIndex: 7892
{	// Methods

	// RVA: 0x22F4220 Offset: 0x22F2820 VA: 0x1822F4220
	public void .ctor() { }

}

public class ENCwindows_874 : CP874 // TypeDefIndex: 7894
{	// Methods

	// RVA: 0x22F4D90 Offset: 0x22F3390 VA: 0x1822F4D90
	public void .ctor() { }

}

public class ENCibm866 : CP866 // TypeDefIndex: 7900
{	// Methods

	// RVA: 0x22EE0D0 Offset: 0x22EC6D0 VA: 0x1822EE0D0
	public void .ctor() { }

}

public class ENCibm1026 : CP1026 // TypeDefIndex: 7902
{	// Methods

	// RVA: 0x22ED730 Offset: 0x22EBD30 VA: 0x1822ED730
	public void .ctor() { }

}

public class ENCibm869 : CP869 // TypeDefIndex: 7904
{	// Methods

	// RVA: 0x22EE1D0 Offset: 0x22EC7D0 VA: 0x1822EE1D0
	public void .ctor() { }

}

public class ENCibm870 : CP870 // TypeDefIndex: 7906
{	// Methods

	// RVA: 0x22EE2D0 Offset: 0x22EC8D0 VA: 0x1822EE2D0
	public void .ctor() { }

}

public class ENCibm875 : CP875 // TypeDefIndex: 7908
{	// Methods

	// RVA: 0x22EE430 Offset: 0x22ECA30 VA: 0x1822EE430
	public void .ctor() { }

}

public class ENCibm1047 : CP1047 // TypeDefIndex: 7910
{	// Methods

	// RVA: 0x22ED790 Offset: 0x22EBD90 VA: 0x1822ED790
	public void .ctor() { }

}

public class ENCibm01140 : CP1140 // TypeDefIndex: 7912
{	// Methods

	// RVA: 0x22ED4F0 Offset: 0x22EBAF0 VA: 0x1822ED4F0
	public void .ctor() { }

}

public class ENCibm01141 : CP1141 // TypeDefIndex: 7914
{	// Methods

	// RVA: 0x22ED550 Offset: 0x22EBB50 VA: 0x1822ED550
	public void .ctor() { }

}

public class ENCibm01142 : CP1142 // TypeDefIndex: 7916
{	// Methods

	// RVA: 0x22ED5B0 Offset: 0x22EBBB0 VA: 0x1822ED5B0
	public void .ctor() { }

}

public class ENCibm01143 : CP1143 // TypeDefIndex: 7918
{	// Methods

	// RVA: 0x22ED610 Offset: 0x22EBC10 VA: 0x1822ED610
	public void .ctor() { }

}

public class ENCibm1144 : CP1144 // TypeDefIndex: 7920
{	// Methods

	// RVA: 0x22ED7F0 Offset: 0x22EBDF0 VA: 0x1822ED7F0
	public void .ctor() { }

}

public class ENCibm1145 : CP1145 // TypeDefIndex: 7922
{	// Methods

	// RVA: 0x22ED850 Offset: 0x22EBE50 VA: 0x1822ED850
	public void .ctor() { }

}

public class ENCibm1146 : CP1146 // TypeDefIndex: 7924
{	// Methods

	// RVA: 0x22ED8B0 Offset: 0x22EBEB0 VA: 0x1822ED8B0
	public void .ctor() { }

}

public class ENCibm1147 : CP1147 // TypeDefIndex: 7926
{	// Methods

	// RVA: 0x22ED910 Offset: 0x22EBF10 VA: 0x1822ED910
	public void .ctor() { }

}

public class ENCibm1148 : CP1148 // TypeDefIndex: 7928
{	// Methods

	// RVA: 0x22ED970 Offset: 0x22EBF70 VA: 0x1822ED970
	public void .ctor() { }

}

public class ENCibm1149 : CP1149 // TypeDefIndex: 7930
{	// Methods

	// RVA: 0x22ED9D0 Offset: 0x22EBFD0 VA: 0x1822ED9D0
	public void .ctor() { }

}

public class ENCibm273 : CP20273 // TypeDefIndex: 7932
{	// Methods

	// RVA: 0x22EDA30 Offset: 0x22EC030 VA: 0x1822EDA30
	public void .ctor() { }

}

public class ENCibm277 : CP20277 // TypeDefIndex: 7934
{	// Methods

	// RVA: 0x22EDA90 Offset: 0x22EC090 VA: 0x1822EDA90
	public void .ctor() { }

}

public class ENCibm278 : CP20278 // TypeDefIndex: 7936
{	// Methods

	// RVA: 0x22EDAF0 Offset: 0x22EC0F0 VA: 0x1822EDAF0
	public void .ctor() { }

}

public class ENCibm280 : CP20280 // TypeDefIndex: 7938
{	// Methods

	// RVA: 0x22EDB50 Offset: 0x22EC150 VA: 0x1822EDB50
	public void .ctor() { }

}

public class ENCibm284 : CP20284 // TypeDefIndex: 7940
{	// Methods

	// RVA: 0x22EDBB0 Offset: 0x22EC1B0 VA: 0x1822EDBB0
	public void .ctor() { }

}

public class ENCibm285 : CP20285 // TypeDefIndex: 7942
{	// Methods

	// RVA: 0x22EDC10 Offset: 0x22EC210 VA: 0x1822EDC10
	public void .ctor() { }

}

public class ENCibm290 : CP20290 // TypeDefIndex: 7944
{	// Methods

	// RVA: 0x22EDC70 Offset: 0x22EC270 VA: 0x1822EDC70
	public void .ctor() { }

}

public class ENCibm297 : CP20297 // TypeDefIndex: 7946
{	// Methods

	// RVA: 0x22EDCD0 Offset: 0x22EC2D0 VA: 0x1822EDCD0
	public void .ctor() { }

}

public class ENCibm420 : CP20420 // TypeDefIndex: 7948
{	// Methods

	// RVA: 0x22EDD30 Offset: 0x22EC330 VA: 0x1822EDD30
	public void .ctor() { }

}

public class ENCibm424 : CP20424 // TypeDefIndex: 7950
{	// Methods

	// RVA: 0x22EDD90 Offset: 0x22EC390 VA: 0x1822EDD90
	public void .ctor() { }

}

public class ENCibm871 : CP20871 // TypeDefIndex: 7952
{	// Methods

	// RVA: 0x22EE3D0 Offset: 0x22EC9D0 VA: 0x1822EE3D0
	public void .ctor() { }

}

public class ENCibm1025 : CP21025 // TypeDefIndex: 7954
{	// Methods

	// RVA: 0x22ED6D0 Offset: 0x22EBCD0 VA: 0x1822ED6D0
	public void .ctor() { }

}

public class ENCibm037 : CP37 // TypeDefIndex: 7956
{	// Methods

	// RVA: 0x22ED670 Offset: 0x22EBC70 VA: 0x1822ED670
	public void .ctor() { }

}

public class ENCibm500 : CP500 // TypeDefIndex: 7958
{	// Methods

	// RVA: 0x22EDDF0 Offset: 0x22EC3F0 VA: 0x1822EDDF0
	public void .ctor() { }

}

public class ENCasmo_708 : CP708 // TypeDefIndex: 7960
{	// Methods

	// RVA: 0x22ED430 Offset: 0x22EBA30 VA: 0x1822ED430
	public void .ctor() { }

}

public class ENCibm852 : CP852 // TypeDefIndex: 7962
{	// Methods

	// RVA: 0x22EDE50 Offset: 0x22EC450 VA: 0x1822EDE50
	public void .ctor() { }

}

public class ENCibm855 : CP855 // TypeDefIndex: 7964
{	// Methods

	// RVA: 0x22EDEB0 Offset: 0x22EC4B0 VA: 0x1822EDEB0
	public void .ctor() { }

}

public class ENCibm857 : CP857 // TypeDefIndex: 7966
{	// Methods

	// RVA: 0x22EDF10 Offset: 0x22EC510 VA: 0x1822EDF10
	public void .ctor() { }

}

public class ENCibm00858 : CP858 // TypeDefIndex: 7968
{	// Methods

	// RVA: 0x22ED490 Offset: 0x22EBA90 VA: 0x1822ED490
	public void .ctor() { }

}

public class ENCibm862 : CP862 // TypeDefIndex: 7970
{	// Methods

	// RVA: 0x22EDF70 Offset: 0x22EC570 VA: 0x1822EDF70
	public void .ctor() { }

}

public class ENCibm864 : CP864 // TypeDefIndex: 7972
{	// Methods

	// RVA: 0x22EDFD0 Offset: 0x22EC5D0 VA: 0x1822EDFD0
	public void .ctor() { }

}

public class ENCmacintosh : CP10000 // TypeDefIndex: 7978
{	// Methods

	// RVA: 0x228D4C0 Offset: 0x228BAC0 VA: 0x18228D4C0
	public void .ctor() { }

}

public class ENCx_mac_icelandic : CP10079 // TypeDefIndex: 7980
{	// Methods

	// RVA: 0x228D8C0 Offset: 0x228BEC0 VA: 0x18228D8C0
	public void .ctor() { }

}

public class ENCwindows_1250 : CP1250 // TypeDefIndex: 7982
{	// Methods

	// RVA: 0x228D5C0 Offset: 0x228BBC0 VA: 0x18228D5C0
	public void .ctor() { }

}

public class ENCwindows_1252 : CP1252 // TypeDefIndex: 7984
{	// Methods

	// RVA: 0x228D6C0 Offset: 0x228BCC0 VA: 0x18228D6C0
	public void .ctor() { }

}

public class ENCwindows_1253 : CP1253 // TypeDefIndex: 7986
{	// Methods

	// RVA: 0x228D7C0 Offset: 0x228BDC0 VA: 0x18228D7C0
	public void .ctor() { }

}

public class ENCiso_8859_2 : CP28592 // TypeDefIndex: 7988
{	// Methods

	// RVA: 0x228D1C0 Offset: 0x228B7C0 VA: 0x18228D1C0
	public void .ctor() { }

}

public class ENCiso_8859_3 : CP28593 // TypeDefIndex: 7990
{	// Methods

	// RVA: 0x228D2C0 Offset: 0x228B8C0 VA: 0x18228D2C0
	public void .ctor() { }

}

public class ENCiso_8859_7 : CP28597 // TypeDefIndex: 7992
{	// Methods

	// RVA: 0x228D3C0 Offset: 0x228B9C0 VA: 0x18228D3C0
	public void .ctor() { }

}

public class ENCiso_8859_15 : CP28605 // TypeDefIndex: 7994
{	// Methods

	// RVA: 0x228D0C0 Offset: 0x228B6C0 VA: 0x18228D0C0
	public void .ctor() { }

}

public class ENCibm437 : CP437 // TypeDefIndex: 7996
{	// Methods

	// RVA: 0x228CAC0 Offset: 0x228B0C0 VA: 0x18228CAC0
	public void .ctor() { }

}

public class ENCibm850 : CP850 // TypeDefIndex: 7998
{	// Methods

	// RVA: 0x228CBC0 Offset: 0x228B1C0 VA: 0x18228CBC0
	public void .ctor() { }

}

public class ENCibm860 : CP860 // TypeDefIndex: 8000
{	// Methods

	// RVA: 0x228CCC0 Offset: 0x228B2C0 VA: 0x18228CCC0
	public void .ctor() { }

}

public class ENCibm861 : CP861 // TypeDefIndex: 8002
{	// Methods

	// RVA: 0x228CDC0 Offset: 0x228B3C0 VA: 0x18228CDC0
	public void .ctor() { }

}

public class ENCibm863 : CP863 // TypeDefIndex: 8004
{	// Methods

	// RVA: 0x228CEC0 Offset: 0x228B4C0 VA: 0x18228CEC0
	public void .ctor() { }

}

public class ENCibm865 : CP865 // TypeDefIndex: 8006
{	// Methods

	// RVA: 0x228CFC0 Offset: 0x228B5C0 VA: 0x18228CFC0
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

