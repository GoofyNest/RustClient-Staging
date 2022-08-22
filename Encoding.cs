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

	// RVA: 0x18AE7A0 Offset: 0x18ACDA0 VA: 0x1818AE7A0
	internal void SerializeEncoder(SerializationInfo info) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public EncoderFallback get_Fallback() { }

	// RVA: 0x18AE800 Offset: 0x18ACE00 VA: 0x1818AE800
	public EncoderFallbackBuffer get_FallbackBuffer() { }

	// RVA: 0x17C8F50 Offset: 0x17C7550 VA: 0x1817C8F50
	internal bool get_InternalHasFallbackBuffer() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18AE6D0 Offset: 0x18ACCD0 VA: 0x1818AE6D0 Slot: 4
	public virtual void Reset() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetByteCount(char[] chars, int index, int count, bool flush);

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x18AE330 Offset: 0x18AC930 VA: 0x1818AE330 Slot: 6
	public virtual int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush);

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x18AE4A0 Offset: 0x18ACAA0 VA: 0x1818AE4A0 Slot: 8
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18ADFC0 Offset: 0x18AC5C0 VA: 0x1818ADFC0 Slot: 9
	public virtual void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x18ADD80 Offset: 0x18AC380 VA: 0x1818ADD80 Slot: 10
	public virtual void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

}

public sealed class EncoderExceptionFallback : EncoderFallback // TypeDefIndex: 447
{	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0x18ADCD0 Offset: 0x18AC2D0 VA: 0x1818ADCD0 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x18ADD20 Offset: 0x18AC320 VA: 0x1818ADD20 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x18ADD70 Offset: 0x18AC370 VA: 0x1818ADD70 Slot: 2
	public override int GetHashCode() { }

}

public sealed class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 448
{	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0x18AD860 Offset: 0x18ABE60 VA: 0x1818AD860 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x18AD970 Offset: 0x18ABF70 VA: 0x1818AD970 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 8
	public override int get_Remaining() { }

}

public sealed class EncoderFallbackException : ArgumentException // TypeDefIndex: 449
{	// Fields
	private char charUnknown; // 0x90
	private char charUnknownHigh; // 0x92
	private char charUnknownLow; // 0x94
	private int index; // 0x98

	// Methods

	// RVA: 0x19131C0 Offset: 0x19117C0 VA: 0x1819131C0
	public void .ctor() { }

	// RVA: 0x15C7610 Offset: 0x15C5C10 VA: 0x1815C7610
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1913220 Offset: 0x1911820 VA: 0x181913220
	internal void .ctor(string message, char charUnknown, int index) { }

	// RVA: 0x1912F40 Offset: 0x1911540 VA: 0x181912F40
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

	// RVA: 0x1913420 Offset: 0x1911A20 VA: 0x181913420
	private static object get_InternalSyncObject() { }

	// RVA: 0x19134B0 Offset: 0x1911AB0 VA: 0x1819134B0
	public static EncoderFallback get_ReplacementFallback() { }

	// RVA: 0x1913260 Offset: 0x1911860 VA: 0x181913260
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

	// RVA: 0x1912E50 Offset: 0x1911450 VA: 0x181912E50 Slot: 9
	public virtual void Reset() { }

	// RVA: 0x1912E30 Offset: 0x1911430 VA: 0x181912E30
	internal void InternalReset() { }

	// RVA: 0x1912DF0 Offset: 0x19113F0 VA: 0x181912DF0
	internal void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder) { }

	// RVA: 0x1912DB0 Offset: 0x19113B0 VA: 0x181912DB0
	internal char InternalGetNextChar() { }

	// RVA: 0x1912BF0 Offset: 0x19111F0 VA: 0x181912BF0 Slot: 10
	internal virtual bool InternalFallback(char ch, ref char* chars) { }

	// RVA: 0x1912E80 Offset: 0x1911480 VA: 0x181912E80
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

	// RVA: 0x1914370 Offset: 0x1912970 VA: 0x181914370
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1914240 Offset: 0x1912840 VA: 0x181914240 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1914300 Offset: 0x1912900 VA: 0x181914300
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x1914430 Offset: 0x1912A30 VA: 0x181914430
	internal void .ctor() { }

	// RVA: 0x1914210 Offset: 0x1912810 VA: 0x181914210 Slot: 4
	public override void Reset() { }

	// RVA: 0x1913B70 Offset: 0x1912170 VA: 0x181913B70 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

	// RVA: 0x1913D20 Offset: 0x1912320 VA: 0x181913D20 Slot: 6
	public override int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: 0x1913E40 Offset: 0x1912440 VA: 0x181913E40 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: 0x19140C0 Offset: 0x19126C0 VA: 0x1819140C0 Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x1913690 Offset: 0x1911C90 VA: 0x181913690 Slot: 9
	public override void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	// RVA: 0x19139A0 Offset: 0x1911FA0 VA: 0x1819139A0 Slot: 10
	public override void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public Encoding get_Encoding() { }

	// RVA: 0x82C2F0 Offset: 0x82A8F0 VA: 0x18082C2F0
	public bool get_MustFlush() { }

	// RVA: 0x1914470 Offset: 0x1912A70 VA: 0x181914470 Slot: 12
	internal virtual bool get_HasState() { }

	// RVA: 0xF60AC0 Offset: 0xF5F0C0 VA: 0x180F60AC0
	internal void ClearMustFlush() { }

}

public sealed class EncoderReplacementFallback : EncoderFallback // TypeDefIndex: 453
{	// Fields
	private string strDefault; // 0x18

	// Properties
	public string DefaultString { get; }
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x1914AB0 Offset: 0x19130B0 VA: 0x181914AB0
	public void .ctor() { }

	// RVA: 0x1914AF0 Offset: 0x19130F0 VA: 0x181914AF0
	public void .ctor(string replacement) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_DefaultString() { }

	// RVA: 0x19149C0 Offset: 0x1912FC0 VA: 0x1819149C0 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x18ACD30 Offset: 0x18AB330 VA: 0x1818ACD30 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x1914A40 Offset: 0x1913040 VA: 0x181914A40 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0xAE6200 Offset: 0xAE4800 VA: 0x180AE6200 Slot: 2
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

	// RVA: 0x1914950 Offset: 0x1912F50 VA: 0x181914950
	public void .ctor(EncoderReplacementFallback fallback) { }

	// RVA: 0x1914740 Offset: 0x1912D40 VA: 0x181914740 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x1914480 Offset: 0x1912A80 VA: 0x181914480 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x19148C0 Offset: 0x1912EC0 VA: 0x1819148C0 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x1914910 Offset: 0x1912F10 VA: 0x181914910 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x19149B0 Offset: 0x1912FB0 VA: 0x1819149B0 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x1914930 Offset: 0x1912F30 VA: 0x181914930 Slot: 9
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

	// RVA: 0x191A660 Offset: 0x1918C60 VA: 0x18191A660
	protected void .ctor() { }

	// RVA: 0x191A5D0 Offset: 0x1918BD0 VA: 0x18191A5D0
	protected void .ctor(int codePage) { }

	// RVA: 0x191A1E0 Offset: 0x19187E0 VA: 0x18191A1E0 Slot: 5
	internal virtual void SetDefaultFallbacks() { }

	// RVA: 0x191A090 Offset: 0x1918690 VA: 0x18191A090
	internal void OnDeserializing() { }

	// RVA: 0x191A040 Offset: 0x1918640 VA: 0x18191A040
	internal void OnDeserialized() { }

	[OnDeserializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x191A090 Offset: 0x1918690 VA: 0x18191A090
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x191A040 Offset: 0x1918640 VA: 0x18191A040
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA7E410 Offset: 0xA7CA10 VA: 0x180A7E410
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x1917B10 Offset: 0x1916110 VA: 0x181917B10
	internal void DeserializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x191A0D0 Offset: 0x19186D0 VA: 0x18191A0D0
	internal void SerializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x191A960 Offset: 0x1918F60 VA: 0x18191A960
	private static object get_InternalSyncObject() { }

	// RVA: 0x1918D70 Offset: 0x1917370 VA: 0x181918D70
	public static Encoding GetEncoding(int codepage) { }

	// RVA: 0x1919C20 Offset: 0x1918220 VA: 0x181919C20
	public static Encoding GetEncoding(string name) { }

	// RVA: 0x1919E10 Offset: 0x1918410 VA: 0x181919E10 Slot: 6
	public virtual byte[] GetPreamble() { }

	// RVA: 0x1918B70 Offset: 0x1917170 VA: 0x181918B70
	private void GetDataItem() { }

	// RVA: 0x191A800 Offset: 0x1918E00 VA: 0x18191A800 Slot: 7
	public virtual string get_BodyName() { }

	// RVA: 0x191A910 Offset: 0x1918F10 VA: 0x18191A910 Slot: 8
	public virtual string get_EncodingName() { }

	// RVA: 0x191A920 Offset: 0x1918F20 VA: 0x18191A920 Slot: 9
	public virtual string get_HeaderName() { }

	// RVA: 0x191AF00 Offset: 0x1919500 VA: 0x18191AF00 Slot: 10
	public virtual string get_WebName() { }

	// RVA: 0x191AF40 Offset: 0x1919540 VA: 0x18191AF40 Slot: 11
	public virtual int get_WindowsCodePage() { }

	// RVA: 0x191A9F0 Offset: 0x1918FF0 VA: 0x18191A9F0 Slot: 12
	public virtual bool get_IsBrowserDisplay() { }

	// RVA: 0x191AA30 Offset: 0x1919030 VA: 0x18191AA30 Slot: 13
	public virtual bool get_IsBrowserSave() { }

	// RVA: 0x191AA70 Offset: 0x1919070 VA: 0x18191AA70 Slot: 14
	public virtual bool get_IsMailNewsDisplay() { }

	// RVA: 0x191AAB0 Offset: 0x19190B0 VA: 0x18191AAB0 Slot: 15
	public virtual bool get_IsMailNewsSave() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 16
	public virtual bool get_IsSingleByte() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public EncoderFallback get_EncoderFallback() { }

	// RVA: 0x191B050 Offset: 0x1919650 VA: 0x18191B050
	public void set_EncoderFallback(EncoderFallback value) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public DecoderFallback get_DecoderFallback() { }

	// RVA: 0x191AF90 Offset: 0x1919590 VA: 0x18191AF90
	public void set_DecoderFallback(DecoderFallback value) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1917A20 Offset: 0x1916020 VA: 0x181917A20 Slot: 17
	public virtual object Clone() { }

	// RVA: 0xB10B90 Offset: 0xB0F190 VA: 0x180B10B90
	public bool get_IsReadOnly() { }

	// RVA: 0x191A6C0 Offset: 0x1918CC0 VA: 0x18191A6C0
	public static Encoding get_ASCII() { }

	// RVA: 0x191AAF0 Offset: 0x19190F0 VA: 0x18191AAF0
	private static Encoding get_Latin1() { }

	// RVA: 0x1917F80 Offset: 0x1916580 VA: 0x181917F80 Slot: 18
	public virtual int GetByteCount(string s) { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract int GetByteCount(char[] chars, int index, int count);

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x1918030 Offset: 0x1916630 VA: 0x181918030 Slot: 20
	public virtual int GetByteCount(char* chars, int count) { }

	// RVA: 0x12779D0 Offset: 0x1275FD0 VA: 0x1812779D0 Slot: 21
	internal virtual int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x1918640 Offset: 0x1916C40 VA: 0x181918640 Slot: 22
	public virtual byte[] GetBytes(char[] chars) { }

	// RVA: 0x1918570 Offset: 0x1916B70 VA: 0x181918570 Slot: 23
	public virtual byte[] GetBytes(char[] chars, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);

	// RVA: 0x19183A0 Offset: 0x19169A0 VA: 0x1819183A0 Slot: 25
	public virtual byte[] GetBytes(string s) { }

	// RVA: 0x1918490 Offset: 0x1916A90 VA: 0x181918490 Slot: 26
	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1918550 Offset: 0x1916B50 VA: 0x181918550 Slot: 27
	internal virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x1918180 Offset: 0x1916780 VA: 0x181918180 Slot: 28
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract int GetCharCount(byte[] bytes, int index, int count);

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x19186F0 Offset: 0x1916CF0 VA: 0x1819186F0 Slot: 30
	public virtual int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x1918840 Offset: 0x1916E40 VA: 0x181918840 Slot: 31
	internal virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x1918860 Offset: 0x1916E60 VA: 0x181918860 Slot: 32
	public virtual char[] GetChars(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 33
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x1918930 Offset: 0x1916F30 VA: 0x181918930 Slot: 34
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1918B50 Offset: 0x1917150 VA: 0x181918B50 Slot: 35
	internal virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x1919E70 Offset: 0x1918470 VA: 0x181919E70
	public string GetString(byte* bytes, int byteCount) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 36
	public virtual int get_CodePage() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 37
	public virtual bool IsAlwaysNormalized(NormalizationForm form) { }

	// RVA: 0x1918C90 Offset: 0x1917290 VA: 0x181918C90 Slot: 38
	public virtual Decoder GetDecoder() { }

	// RVA: 0x1917AB0 Offset: 0x19160B0 VA: 0x181917AB0
	private static Encoding CreateDefaultEncoding() { }

	// RVA: 0x13A2B40 Offset: 0x13A1140 VA: 0x1813A2B40
	internal void setReadOnly(bool value = True) { }

	// RVA: 0x191A840 Offset: 0x1918E40 VA: 0x18191A840
	public static Encoding get_Default() { }

	// RVA: 0x1918D00 Offset: 0x1917300 VA: 0x181918D00 Slot: 39
	public virtual Encoder GetEncoder() { }

	// RVA: -1 Offset: -1 Slot: 40
	public abstract int GetMaxByteCount(int charCount);

	// RVA: -1 Offset: -1 Slot: 41
	public abstract int GetMaxCharCount(int byteCount);

	// RVA: 0x1919F60 Offset: 0x1918560 VA: 0x181919F60 Slot: 42
	public virtual string GetString(byte[] bytes) { }

	// RVA: 0x191A010 Offset: 0x1918610 VA: 0x18191A010 Slot: 43
	public virtual string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x191AE60 Offset: 0x1919460 VA: 0x18191AE60
	public static Encoding get_Unicode() { }

	// RVA: 0x191A760 Offset: 0x1918D60 VA: 0x18191A760
	public static Encoding get_BigEndianUnicode() { }

	// RVA: 0x191AC90 Offset: 0x1919290 VA: 0x18191AC90
	public static Encoding get_UTF7() { }

	// RVA: 0x191AD80 Offset: 0x1919380 VA: 0x18191AD80
	public static Encoding get_UTF8() { }

	// RVA: 0x191ABD0 Offset: 0x19191D0 VA: 0x18191ABD0
	public static Encoding get_UTF32() { }

	// RVA: 0x1917DD0 Offset: 0x19163D0 VA: 0x181917DD0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1919DA0 Offset: 0x19183A0 VA: 0x181919DA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1917F20 Offset: 0x1916520 VA: 0x181917F20 Slot: 44
	internal virtual char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x1917EC0 Offset: 0x19164C0 VA: 0x181917EC0 Slot: 45
	internal virtual char[] GetBestFitBytesToUnicodeData() { }

	// RVA: 0x191A330 Offset: 0x1918930 VA: 0x18191A330
	internal void ThrowBytesOverflow() { }

	// RVA: 0x191A2A0 Offset: 0x19188A0 VA: 0x18191A2A0
	internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded) { }

	// RVA: 0x191A4D0 Offset: 0x1918AD0 VA: 0x18191A4D0
	internal void ThrowCharsOverflow() { }

	// RVA: 0x191A430 Offset: 0x1918A30 VA: 0x18191A430
	internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded) { }

}

internal class Encoding.DefaultEncoder : Encoder, ISerializable, IObjectReference // TypeDefIndex: 456
{	// Fields
	private Encoding m_encoding; // 0x20
	private bool m_hasInitializedEncoding; // 0x28
	internal char charLeftOver; // 0x2A

	// Methods

	// RVA: 0x1912730 Offset: 0x1910D30 VA: 0x181912730
	public void .ctor(Encoding encoding) { }

	// RVA: 0x19129A0 Offset: 0x1910FA0 VA: 0x1819129A0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1912830 Offset: 0x1910E30 VA: 0x181912830 Slot: 12
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x1912910 Offset: 0x1910F10 VA: 0x181912910 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1912770 Offset: 0x1910D70 VA: 0x181912770 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

	// RVA: 0x19127A0 Offset: 0x1910DA0 VA: 0x1819127A0 Slot: 6
	public override int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: 0x19127D0 Offset: 0x1910DD0 VA: 0x1819127D0 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: 0x1912800 Offset: 0x1910E00 VA: 0x181912800 Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

}

internal class Encoding.DefaultDecoder : Decoder, ISerializable, IObjectReference // TypeDefIndex: 457
{	// Fields
	private Encoding m_encoding; // 0x20
	private bool m_hasInitializedEncoding; // 0x28

	// Methods

	// RVA: 0x1912730 Offset: 0x1910D30 VA: 0x181912730
	public void .ctor(Encoding encoding) { }

	// RVA: 0x1912530 Offset: 0x1910B30 VA: 0x181912530
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1912430 Offset: 0x1910A30 VA: 0x181912430 Slot: 14
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x19124A0 Offset: 0x1910AA0 VA: 0x1819124A0 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE4E3B0 Offset: 0xE4C9B0 VA: 0x180E4E3B0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x19123A0 Offset: 0x19109A0 VA: 0x1819123A0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x1912370 Offset: 0x1910970 VA: 0x181912370 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x18AC670 Offset: 0x18AAC70 VA: 0x1818AC670 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1912400 Offset: 0x1910A00 VA: 0x181912400 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x19123D0 Offset: 0x19109D0 VA: 0x1819123D0 Slot: 10
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

	// RVA: 0x19159C0 Offset: 0x1913FC0 VA: 0x1819159C0
	internal void .ctor(Encoding enc, DecoderNLS decoder, char* charStart, int charCount, byte* byteStart, int byteCount) { }

	// RVA: 0x1915600 Offset: 0x1913C00 VA: 0x181915600
	internal bool AddChar(char ch, int numBytes) { }

	// RVA: 0x19156E0 Offset: 0x1913CE0 VA: 0x1819156E0
	internal bool AddChar(char ch) { }

	// RVA: 0x19157C0 Offset: 0x1913DC0 VA: 0x1819157C0
	internal void AdjustBytes(int count) { }

	// RVA: 0x1915AD0 Offset: 0x19140D0 VA: 0x181915AD0
	internal bool get_MoreData() { }

	// RVA: 0x19159A0 Offset: 0x1913FA0 VA: 0x1819159A0
	internal byte GetNextByte() { }

	// RVA: 0x1915AC0 Offset: 0x19140C0 VA: 0x181915AC0
	internal int get_BytesUsed() { }

	// RVA: 0x1915920 Offset: 0x1913F20 VA: 0x181915920
	internal bool Fallback(byte fallbackByte) { }

	// RVA: 0x19157D0 Offset: 0x1913DD0 VA: 0x1819157D0
	internal bool Fallback(byte[] byteBuffer) { }

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
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

	// RVA: 0x19152F0 Offset: 0x19138F0 VA: 0x1819152F0
	internal void .ctor(Encoding inEncoding, EncoderNLS inEncoder, byte* inByteStart, int inByteCount, char* inCharStart, int inCharCount) { }

	// RVA: 0x1915080 Offset: 0x1913680 VA: 0x181915080
	internal bool AddByte(byte b, int moreBytesExpected) { }

	// RVA: 0x1914FC0 Offset: 0x19135C0 VA: 0x181914FC0
	internal bool AddByte(byte b1) { }

	// RVA: 0x1914FD0 Offset: 0x19135D0 VA: 0x181914FD0
	internal bool AddByte(byte b1, byte b2) { }

	// RVA: 0x1915020 Offset: 0x1913620 VA: 0x181915020
	internal bool AddByte(byte b1, byte b2, int moreBytesExpected) { }

	// RVA: 0x1915200 Offset: 0x1913800 VA: 0x181915200
	internal void MovePrevious(bool bThrow) { }

	// RVA: 0x19155B0 Offset: 0x1913BB0 VA: 0x1819155B0
	internal bool get_MoreData() { }

	// RVA: 0x1915190 Offset: 0x1913790 VA: 0x181915190
	internal char GetNextChar() { }

	// RVA: 0x1915590 Offset: 0x1913B90 VA: 0x181915590
	internal int get_CharsUsed() { }

	// RVA: 0x5DE3D0 Offset: 0x5DC9D0 VA: 0x1805DE3D0
	internal int get_Count() { }

}

internal abstract class EncodingNLS : Encoding // TypeDefIndex: 460
{	// Methods

	// RVA: 0x1917790 Offset: 0x1915D90 VA: 0x181917790
	protected void .ctor(int codePage) { }

	// RVA: 0x1916740 Offset: 0x1914D40 VA: 0x181916740 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x19166A0 Offset: 0x1914CA0 VA: 0x1819166A0 Slot: 18
	public override int GetByteCount(string s) { }

	// RVA: 0x19165A0 Offset: 0x1914BA0 VA: 0x1819165A0 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1916C70 Offset: 0x1915270 VA: 0x181916C70 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x19168D0 Offset: 0x1914ED0 VA: 0x1819168D0 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1916B30 Offset: 0x1915130 VA: 0x181916B30 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1916ED0 Offset: 0x19154D0 VA: 0x181916ED0 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x1917060 Offset: 0x1915660 VA: 0x181917060 Slot: 30
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x19172A0 Offset: 0x19158A0 VA: 0x1819172A0 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1917160 Offset: 0x1915760 VA: 0x181917160 Slot: 34
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1917600 Offset: 0x1915C00 VA: 0x181917600 Slot: 43
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x1917500 Offset: 0x1915B00 VA: 0x181917500 Slot: 38
	public override Decoder GetDecoder() { }

	// RVA: 0x1917560 Offset: 0x1915B60 VA: 0x181917560 Slot: 39
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

	// RVA: 0x19178B0 Offset: 0x1915EB0 VA: 0x1819178B0
	internal static Encoding GetEncodingFromProvider(int codepage) { }

	// RVA: 0x19177A0 Offset: 0x1915DA0 VA: 0x1819177A0
	internal static Encoding GetEncodingFromProvider(string encodingName) { }

	// RVA: 0x19179C0 Offset: 0x1915FC0 VA: 0x1819179C0
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

	// RVA: 0x1916340 Offset: 0x1914940 VA: 0x181916340
	internal static Encoding get_UTF8Unmarked() { }

	// RVA: 0x1915D80 Offset: 0x1914380 VA: 0x181915D80
	internal static string InternalCodePage(ref int code_page) { }

	// RVA: 0x1915AE0 Offset: 0x19140E0 VA: 0x181915AE0
	internal static Encoding GetDefaultEncoding() { }

	// RVA: 0x1915D90 Offset: 0x1914390 VA: 0x181915D90
	internal static object InvokeI18N(string name, object[] args) { }

	// RVA: 0x19162E0 Offset: 0x19148E0 VA: 0x1819162E0
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

	// RVA: 0x16E5C60 Offset: 0x16E4260 VA: 0x1816E5C60
	private static int GetNumEncodingItems() { }

	// RVA: 0x16E5870 Offset: 0x16E3E70 VA: 0x1816E5870
	private static InternalEncodingDataItem ENC(string name, ushort cp) { }

	// RVA: 0x16E5CD0 Offset: 0x16E42D0 VA: 0x1816E5CD0
	private static InternalCodePageDataItem MapCodePageDataItem(ushort cp, ushort fcp, string names, uint flags) { }

	// RVA: 0x16E5D00 Offset: 0x16E4300 VA: 0x1816E5D00
	private static void .cctor() { }

	// RVA: 0x16EF930 Offset: 0x16EDF30 VA: 0x1816EF930
	private static int internalGetCodePageFromName(string name) { }

	// RVA: 0x16E5AE0 Offset: 0x16E40E0 VA: 0x1816E5AE0
	internal static int GetCodePageFromName(string name) { }

	// RVA: 0x16E58B0 Offset: 0x16E3EB0 VA: 0x1816E58B0
	internal static CodePageDataItem GetCodePageDataItem(int codepage) { }

}

public class ENCshift_jis : CP932 // TypeDefIndex: 7799
{	// Methods

	// RVA: 0x224CE70 Offset: 0x224B470 VA: 0x18224CE70
	public void .ctor() { }

}

public class ENCiso_2022_jp : CP50220 // TypeDefIndex: 7807
{	// Methods

	// RVA: 0x224A5E0 Offset: 0x2248BE0 VA: 0x18224A5E0
	public void .ctor() { }

}

public class ENCeuc_jp : CP51932 // TypeDefIndex: 7811
{	// Methods

	// RVA: 0x224B9F0 Offset: 0x2249FF0 VA: 0x18224B9F0
	public void .ctor() { }

}

internal class ENCgb2312 : CP936 // TypeDefIndex: 7814
{	// Methods

	// RVA: 0x224D9C0 Offset: 0x224BFC0 VA: 0x18224D9C0
	public void .ctor() { }

}

internal class ENCuhc : CP949 // TypeDefIndex: 7819
{	// Methods

	// RVA: 0x224DA90 Offset: 0x224C090 VA: 0x18224DA90
	public void .ctor() { }

}

internal class ENCeuc_kr : CP51949 // TypeDefIndex: 7820
{	// Methods

	// RVA: 0x224BAD0 Offset: 0x224A0D0 VA: 0x18224BAD0
	public void .ctor() { }

}

internal class ENCbig5 : CP950 // TypeDefIndex: 7823
{	// Methods

	// RVA: 0x224E4A0 Offset: 0x224CAA0 VA: 0x18224E4A0
	public void .ctor() { }

}

internal class ENCgb18030 : GB18030Encoding // TypeDefIndex: 7828
{	// Methods

	// RVA: 0x224BBC0 Offset: 0x224A1C0 VA: 0x18224BBC0
	public void .ctor() { }

}

public class ENCwindows_1254 : CP1254 // TypeDefIndex: 7841
{	// Methods

	// RVA: 0x2308470 Offset: 0x2306A70 VA: 0x182308470
	public void .ctor() { }

}

public class ENCwindows_1255 : CP1255 // TypeDefIndex: 7843
{	// Methods

	// RVA: 0x2308570 Offset: 0x2306B70 VA: 0x182308570
	public void .ctor() { }

}

public class ENCwindows_1256 : CP1256 // TypeDefIndex: 7845
{	// Methods

	// RVA: 0x2308670 Offset: 0x2306C70 VA: 0x182308670
	public void .ctor() { }

}

public class ENCiso_8859_6 : CP28596 // TypeDefIndex: 7847
{	// Methods

	// RVA: 0x2308170 Offset: 0x2306770 VA: 0x182308170
	public void .ctor() { }

}

public class ENCiso_8859_8 : CP28598 // TypeDefIndex: 7849
{	// Methods

	// RVA: 0x2308270 Offset: 0x2306870 VA: 0x182308270
	public void .ctor() { }

}

public class ENCiso_8859_9 : CP28599 // TypeDefIndex: 7851
{	// Methods

	// RVA: 0x2308370 Offset: 0x2306970 VA: 0x182308370
	public void .ctor() { }

}

public class ENCwindows_38598 : CP38598 // TypeDefIndex: 7853
{	// Methods

	// RVA: 0x2308770 Offset: 0x2306D70 VA: 0x182308770
	public void .ctor() { }

}

public class ENCwindows_1251 : CP1251 // TypeDefIndex: 7859
{	// Methods

	// RVA: 0x22F5570 Offset: 0x22F3B70 VA: 0x1822F5570
	public void .ctor() { }

}

public class ENCwindows_1257 : CP1257 // TypeDefIndex: 7861
{	// Methods

	// RVA: 0x22F5670 Offset: 0x22F3C70 VA: 0x1822F5670
	public void .ctor() { }

}

public class ENCwindows_1258 : CP1258 // TypeDefIndex: 7863
{	// Methods

	// RVA: 0x22F5770 Offset: 0x22F3D70 VA: 0x1822F5770
	public void .ctor() { }

}

public class ENCkoi8_r : CP20866 // TypeDefIndex: 7865
{	// Methods

	// RVA: 0x22F5370 Offset: 0x22F3970 VA: 0x1822F5370
	public void .ctor() { }

}

public class ENCkoi8_u : CP21866 // TypeDefIndex: 7867
{	// Methods

	// RVA: 0x22F5470 Offset: 0x22F3A70 VA: 0x1822F5470
	public void .ctor() { }

}

public class ENCiso_8859_4 : CP28594 // TypeDefIndex: 7869
{	// Methods

	// RVA: 0x22F5170 Offset: 0x22F3770 VA: 0x1822F5170
	public void .ctor() { }

}

public class ENCiso_8859_5 : CP28595 // TypeDefIndex: 7871
{	// Methods

	// RVA: 0x22F5270 Offset: 0x22F3870 VA: 0x1822F5270
	public void .ctor() { }

}

public class ENCx_iscii_de : CP57002 // TypeDefIndex: 7883
{	// Methods

	// RVA: 0x22F4880 Offset: 0x22F2E80 VA: 0x1822F4880
	public void .ctor() { }

}

public class ENCx_iscii_be : CP57003 // TypeDefIndex: 7884
{	// Methods

	// RVA: 0x22F4900 Offset: 0x22F2F00 VA: 0x1822F4900
	public void .ctor() { }

}

public class ENCx_iscii_ta : CP57004 // TypeDefIndex: 7885
{	// Methods

	// RVA: 0x22F4980 Offset: 0x22F2F80 VA: 0x1822F4980
	public void .ctor() { }

}

public class ENCx_iscii_te : CP57005 // TypeDefIndex: 7886
{	// Methods

	// RVA: 0x22F4A00 Offset: 0x22F3000 VA: 0x1822F4A00
	public void .ctor() { }

}

public class ENCx_iscii_as : CP57006 // TypeDefIndex: 7887
{	// Methods

	// RVA: 0x22F4A80 Offset: 0x22F3080 VA: 0x1822F4A80
	public void .ctor() { }

}

public class ENCx_iscii_or : CP57007 // TypeDefIndex: 7888
{	// Methods

	// RVA: 0x22F4B00 Offset: 0x22F3100 VA: 0x1822F4B00
	public void .ctor() { }

}

public class ENCx_iscii_ka : CP57008 // TypeDefIndex: 7889
{	// Methods

	// RVA: 0x22F4B80 Offset: 0x22F3180 VA: 0x1822F4B80
	public void .ctor() { }

}

public class ENCx_iscii_ma : CP57009 // TypeDefIndex: 7890
{	// Methods

	// RVA: 0x22F4C00 Offset: 0x22F3200 VA: 0x1822F4C00
	public void .ctor() { }

}

public class ENCx_iscii_gu : CP57010 // TypeDefIndex: 7891
{	// Methods

	// RVA: 0x22F4C80 Offset: 0x22F3280 VA: 0x1822F4C80
	public void .ctor() { }

}

public class ENCx_iscii_pa : CP57011 // TypeDefIndex: 7892
{	// Methods

	// RVA: 0x22F4D00 Offset: 0x22F3300 VA: 0x1822F4D00
	public void .ctor() { }

}

public class ENCwindows_874 : CP874 // TypeDefIndex: 7894
{	// Methods

	// RVA: 0x22F5870 Offset: 0x22F3E70 VA: 0x1822F5870
	public void .ctor() { }

}

public class ENCibm866 : CP866 // TypeDefIndex: 7900
{	// Methods

	// RVA: 0x22EEBB0 Offset: 0x22ED1B0 VA: 0x1822EEBB0
	public void .ctor() { }

}

public class ENCibm1026 : CP1026 // TypeDefIndex: 7902
{	// Methods

	// RVA: 0x22EE210 Offset: 0x22EC810 VA: 0x1822EE210
	public void .ctor() { }

}

public class ENCibm869 : CP869 // TypeDefIndex: 7904
{	// Methods

	// RVA: 0x22EECB0 Offset: 0x22ED2B0 VA: 0x1822EECB0
	public void .ctor() { }

}

public class ENCibm870 : CP870 // TypeDefIndex: 7906
{	// Methods

	// RVA: 0x22EEDB0 Offset: 0x22ED3B0 VA: 0x1822EEDB0
	public void .ctor() { }

}

public class ENCibm875 : CP875 // TypeDefIndex: 7908
{	// Methods

	// RVA: 0x22EEF10 Offset: 0x22ED510 VA: 0x1822EEF10
	public void .ctor() { }

}

public class ENCibm1047 : CP1047 // TypeDefIndex: 7910
{	// Methods

	// RVA: 0x22EE270 Offset: 0x22EC870 VA: 0x1822EE270
	public void .ctor() { }

}

public class ENCibm01140 : CP1140 // TypeDefIndex: 7912
{	// Methods

	// RVA: 0x22EDFD0 Offset: 0x22EC5D0 VA: 0x1822EDFD0
	public void .ctor() { }

}

public class ENCibm01141 : CP1141 // TypeDefIndex: 7914
{	// Methods

	// RVA: 0x22EE030 Offset: 0x22EC630 VA: 0x1822EE030
	public void .ctor() { }

}

public class ENCibm01142 : CP1142 // TypeDefIndex: 7916
{	// Methods

	// RVA: 0x22EE090 Offset: 0x22EC690 VA: 0x1822EE090
	public void .ctor() { }

}

public class ENCibm01143 : CP1143 // TypeDefIndex: 7918
{	// Methods

	// RVA: 0x22EE0F0 Offset: 0x22EC6F0 VA: 0x1822EE0F0
	public void .ctor() { }

}

public class ENCibm1144 : CP1144 // TypeDefIndex: 7920
{	// Methods

	// RVA: 0x22EE2D0 Offset: 0x22EC8D0 VA: 0x1822EE2D0
	public void .ctor() { }

}

public class ENCibm1145 : CP1145 // TypeDefIndex: 7922
{	// Methods

	// RVA: 0x22EE330 Offset: 0x22EC930 VA: 0x1822EE330
	public void .ctor() { }

}

public class ENCibm1146 : CP1146 // TypeDefIndex: 7924
{	// Methods

	// RVA: 0x22EE390 Offset: 0x22EC990 VA: 0x1822EE390
	public void .ctor() { }

}

public class ENCibm1147 : CP1147 // TypeDefIndex: 7926
{	// Methods

	// RVA: 0x22EE3F0 Offset: 0x22EC9F0 VA: 0x1822EE3F0
	public void .ctor() { }

}

public class ENCibm1148 : CP1148 // TypeDefIndex: 7928
{	// Methods

	// RVA: 0x22EE450 Offset: 0x22ECA50 VA: 0x1822EE450
	public void .ctor() { }

}

public class ENCibm1149 : CP1149 // TypeDefIndex: 7930
{	// Methods

	// RVA: 0x22EE4B0 Offset: 0x22ECAB0 VA: 0x1822EE4B0
	public void .ctor() { }

}

public class ENCibm273 : CP20273 // TypeDefIndex: 7932
{	// Methods

	// RVA: 0x22EE510 Offset: 0x22ECB10 VA: 0x1822EE510
	public void .ctor() { }

}

public class ENCibm277 : CP20277 // TypeDefIndex: 7934
{	// Methods

	// RVA: 0x22EE570 Offset: 0x22ECB70 VA: 0x1822EE570
	public void .ctor() { }

}

public class ENCibm278 : CP20278 // TypeDefIndex: 7936
{	// Methods

	// RVA: 0x22EE5D0 Offset: 0x22ECBD0 VA: 0x1822EE5D0
	public void .ctor() { }

}

public class ENCibm280 : CP20280 // TypeDefIndex: 7938
{	// Methods

	// RVA: 0x22EE630 Offset: 0x22ECC30 VA: 0x1822EE630
	public void .ctor() { }

}

public class ENCibm284 : CP20284 // TypeDefIndex: 7940
{	// Methods

	// RVA: 0x22EE690 Offset: 0x22ECC90 VA: 0x1822EE690
	public void .ctor() { }

}

public class ENCibm285 : CP20285 // TypeDefIndex: 7942
{	// Methods

	// RVA: 0x22EE6F0 Offset: 0x22ECCF0 VA: 0x1822EE6F0
	public void .ctor() { }

}

public class ENCibm290 : CP20290 // TypeDefIndex: 7944
{	// Methods

	// RVA: 0x22EE750 Offset: 0x22ECD50 VA: 0x1822EE750
	public void .ctor() { }

}

public class ENCibm297 : CP20297 // TypeDefIndex: 7946
{	// Methods

	// RVA: 0x22EE7B0 Offset: 0x22ECDB0 VA: 0x1822EE7B0
	public void .ctor() { }

}

public class ENCibm420 : CP20420 // TypeDefIndex: 7948
{	// Methods

	// RVA: 0x22EE810 Offset: 0x22ECE10 VA: 0x1822EE810
	public void .ctor() { }

}

public class ENCibm424 : CP20424 // TypeDefIndex: 7950
{	// Methods

	// RVA: 0x22EE870 Offset: 0x22ECE70 VA: 0x1822EE870
	public void .ctor() { }

}

public class ENCibm871 : CP20871 // TypeDefIndex: 7952
{	// Methods

	// RVA: 0x22EEEB0 Offset: 0x22ED4B0 VA: 0x1822EEEB0
	public void .ctor() { }

}

public class ENCibm1025 : CP21025 // TypeDefIndex: 7954
{	// Methods

	// RVA: 0x22EE1B0 Offset: 0x22EC7B0 VA: 0x1822EE1B0
	public void .ctor() { }

}

public class ENCibm037 : CP37 // TypeDefIndex: 7956
{	// Methods

	// RVA: 0x22EE150 Offset: 0x22EC750 VA: 0x1822EE150
	public void .ctor() { }

}

public class ENCibm500 : CP500 // TypeDefIndex: 7958
{	// Methods

	// RVA: 0x22EE8D0 Offset: 0x22ECED0 VA: 0x1822EE8D0
	public void .ctor() { }

}

public class ENCasmo_708 : CP708 // TypeDefIndex: 7960
{	// Methods

	// RVA: 0x22EDF10 Offset: 0x22EC510 VA: 0x1822EDF10
	public void .ctor() { }

}

public class ENCibm852 : CP852 // TypeDefIndex: 7962
{	// Methods

	// RVA: 0x22EE930 Offset: 0x22ECF30 VA: 0x1822EE930
	public void .ctor() { }

}

public class ENCibm855 : CP855 // TypeDefIndex: 7964
{	// Methods

	// RVA: 0x22EE990 Offset: 0x22ECF90 VA: 0x1822EE990
	public void .ctor() { }

}

public class ENCibm857 : CP857 // TypeDefIndex: 7966
{	// Methods

	// RVA: 0x22EE9F0 Offset: 0x22ECFF0 VA: 0x1822EE9F0
	public void .ctor() { }

}

public class ENCibm00858 : CP858 // TypeDefIndex: 7968
{	// Methods

	// RVA: 0x22EDF70 Offset: 0x22EC570 VA: 0x1822EDF70
	public void .ctor() { }

}

public class ENCibm862 : CP862 // TypeDefIndex: 7970
{	// Methods

	// RVA: 0x22EEA50 Offset: 0x22ED050 VA: 0x1822EEA50
	public void .ctor() { }

}

public class ENCibm864 : CP864 // TypeDefIndex: 7972
{	// Methods

	// RVA: 0x22EEAB0 Offset: 0x22ED0B0 VA: 0x1822EEAB0
	public void .ctor() { }

}

public class ENCmacintosh : CP10000 // TypeDefIndex: 7978
{	// Methods

	// RVA: 0x228DFA0 Offset: 0x228C5A0 VA: 0x18228DFA0
	public void .ctor() { }

}

public class ENCx_mac_icelandic : CP10079 // TypeDefIndex: 7980
{	// Methods

	// RVA: 0x228E3A0 Offset: 0x228C9A0 VA: 0x18228E3A0
	public void .ctor() { }

}

public class ENCwindows_1250 : CP1250 // TypeDefIndex: 7982
{	// Methods

	// RVA: 0x228E0A0 Offset: 0x228C6A0 VA: 0x18228E0A0
	public void .ctor() { }

}

public class ENCwindows_1252 : CP1252 // TypeDefIndex: 7984
{	// Methods

	// RVA: 0x228E1A0 Offset: 0x228C7A0 VA: 0x18228E1A0
	public void .ctor() { }

}

public class ENCwindows_1253 : CP1253 // TypeDefIndex: 7986
{	// Methods

	// RVA: 0x228E2A0 Offset: 0x228C8A0 VA: 0x18228E2A0
	public void .ctor() { }

}

public class ENCiso_8859_2 : CP28592 // TypeDefIndex: 7988
{	// Methods

	// RVA: 0x228DCA0 Offset: 0x228C2A0 VA: 0x18228DCA0
	public void .ctor() { }

}

public class ENCiso_8859_3 : CP28593 // TypeDefIndex: 7990
{	// Methods

	// RVA: 0x228DDA0 Offset: 0x228C3A0 VA: 0x18228DDA0
	public void .ctor() { }

}

public class ENCiso_8859_7 : CP28597 // TypeDefIndex: 7992
{	// Methods

	// RVA: 0x228DEA0 Offset: 0x228C4A0 VA: 0x18228DEA0
	public void .ctor() { }

}

public class ENCiso_8859_15 : CP28605 // TypeDefIndex: 7994
{	// Methods

	// RVA: 0x228DBA0 Offset: 0x228C1A0 VA: 0x18228DBA0
	public void .ctor() { }

}

public class ENCibm437 : CP437 // TypeDefIndex: 7996
{	// Methods

	// RVA: 0x228D5A0 Offset: 0x228BBA0 VA: 0x18228D5A0
	public void .ctor() { }

}

public class ENCibm850 : CP850 // TypeDefIndex: 7998
{	// Methods

	// RVA: 0x228D6A0 Offset: 0x228BCA0 VA: 0x18228D6A0
	public void .ctor() { }

}

public class ENCibm860 : CP860 // TypeDefIndex: 8000
{	// Methods

	// RVA: 0x228D7A0 Offset: 0x228BDA0 VA: 0x18228D7A0
	public void .ctor() { }

}

public class ENCibm861 : CP861 // TypeDefIndex: 8002
{	// Methods

	// RVA: 0x228D8A0 Offset: 0x228BEA0 VA: 0x18228D8A0
	public void .ctor() { }

}

public class ENCibm863 : CP863 // TypeDefIndex: 8004
{	// Methods

	// RVA: 0x228D9A0 Offset: 0x228BFA0 VA: 0x18228D9A0
	public void .ctor() { }

}

public class ENCibm865 : CP865 // TypeDefIndex: 8006
{	// Methods

	// RVA: 0x228DAA0 Offset: 0x228C0A0 VA: 0x18228DAA0
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

	// RVA: 0x85D930 Offset: 0x85BF30 VA: 0x18085D930
	private void .ctor(EncodeOptions options) { }

	// RVA: 0x85D520 Offset: 0x85BB20 VA: 0x18085D520
	public static string Encode(object obj) { }

	// RVA: 0x85D440 Offset: 0x85BA40 VA: 0x18085D440
	public static string Encode(object obj, EncodeOptions options) { }

	// RVA: 0x85D9D0 Offset: 0x85BFD0 VA: 0x18085D9D0
	private bool get_PrettyPrintEnabled() { }

	// RVA: 0x85D9E0 Offset: 0x85BFE0 VA: 0x18085D9E0
	private bool get_TypeHintsEnabled() { }

	// RVA: 0x85D9C0 Offset: 0x85BFC0 VA: 0x18085D9C0
	private bool get_IncludePublicPropertiesEnabled() { }

	// RVA: 0x85D9B0 Offset: 0x85BFB0 VA: 0x18085D9B0
	private bool get_EnforceHierarchyOrderEnabled() { }

	// RVA: 0x85CE30 Offset: 0x85B430 VA: 0x18085CE30
	private void EncodeValue(object value, bool forceTypeHint) { }

	// RVA: 0x85D580 Offset: 0x85BB80 VA: 0x18085D580
	private IEnumerable<FieldInfo> GetFieldsForType(Type type) { }

	// RVA: 0x85D6F0 Offset: 0x85BCF0 VA: 0x18085D6F0
	private IEnumerable<PropertyInfo> GetPropertiesForType(Type type) { }

	// RVA: 0x85B940 Offset: 0x859F40 VA: 0x18085B940
	private void EncodeObject(object value, bool forceTypeHint) { }

	// RVA: 0x85C4D0 Offset: 0x85AAD0 VA: 0x18085C4D0
	private void EncodeProxyArray(ProxyArray value) { }

	// RVA: 0x85C7E0 Offset: 0x85ADE0 VA: 0x18085C7E0
	private void EncodeProxyObject(ProxyObject value) { }

	// RVA: 0x85B210 Offset: 0x859810 VA: 0x18085B210
	private void EncodeDictionary(IDictionary value, bool forceTypeHint) { }

	// RVA: 0x85B630 Offset: 0x859C30 VA: 0x18085B630
	private void EncodeList(IList value, bool forceTypeHint) { }

	// RVA: 0x85B150 Offset: 0x859750 VA: 0x18085B150
	private void EncodeArray(Array value, bool forceTypeHint) { }

	// RVA: 0x85AE50 Offset: 0x859450 VA: 0x18085AE50
	private void EncodeArrayRank(Array value, int rank, int[] indices, bool forceTypeHint) { }

	// RVA: 0x85CB40 Offset: 0x85B140 VA: 0x18085CB40
	private void EncodeString(string value) { }

	// RVA: 0x85AD60 Offset: 0x859360 VA: 0x18085AD60
	private void AppendIndent() { }

	// RVA: 0x85ADB0 Offset: 0x8593B0 VA: 0x18085ADB0
	private void AppendOpenBrace() { }

	// RVA: 0x85AB90 Offset: 0x859190 VA: 0x18085AB90
	private void AppendCloseBrace() { }

	// RVA: 0x85AE00 Offset: 0x859400 VA: 0x18085AE00
	private void AppendOpenBracket() { }

	// RVA: 0x85AC10 Offset: 0x859210 VA: 0x18085AC10
	private void AppendCloseBracket() { }

	// RVA: 0x85ACE0 Offset: 0x8592E0 VA: 0x18085ACE0
	private void AppendComma(bool firstItem) { }

	// RVA: 0x85AC90 Offset: 0x859290 VA: 0x18085AC90
	private void AppendColon() { }

	// RVA: 0x85D860 Offset: 0x85BE60 VA: 0x18085D860
	private static void .cctor() { }

}

