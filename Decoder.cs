public abstract class Decoder // TypeDefIndex: 433
{	// Fields
	internal DecoderFallback m_fallback; // 0x10
	internal DecoderFallbackBuffer m_fallbackBuffer; // 0x18

	// Properties
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public DecoderFallback Fallback { get; }
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public DecoderFallbackBuffer FallbackBuffer { get; }
	internal bool InternalHasFallbackBuffer { get; }

	// Methods

	// RVA: 0x18AD790 Offset: 0x18ABD90 VA: 0x1818AD790
	internal void SerializeDecoder(SerializationInfo info) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public DecoderFallback get_Fallback() { }

	// RVA: 0x18AD7F0 Offset: 0x18ABDF0 VA: 0x1818AD7F0
	public DecoderFallbackBuffer get_FallbackBuffer() { }

	// RVA: 0x17C8F50 Offset: 0x17C7550 VA: 0x1817C8F50
	internal bool get_InternalHasFallbackBuffer() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18AD6C0 Offset: 0x18ABCC0 VA: 0x1818AD6C0 Slot: 4
	public virtual void Reset() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetCharCount(byte[] bytes, int index, int count);

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18AD450 Offset: 0x18ABA50 VA: 0x1818AD450 Slot: 6
	public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x18AD300 Offset: 0x18AB900 VA: 0x1818AD300 Slot: 7
	public virtual int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	// RVA: 0x18AD6A0 Offset: 0x18ABCA0 VA: 0x1818AD6A0 Slot: 9
	public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x18AD470 Offset: 0x18ABA70 VA: 0x1818AD470 Slot: 10
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18ACF90 Offset: 0x18AB590 VA: 0x1818ACF90 Slot: 11
	public virtual void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x18ACD50 Offset: 0x18AB350 VA: 0x1818ACD50 Slot: 12
	public virtual void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

}

public class Decoder // TypeDefIndex: 7388
{	// Fields
	private static readonly Decoder.Params DecoderDefaultParams; // 0x0
	private Equalizer _Equalizer; // 0x10
	private SynthesisFilter _LeftChannelFilter; // 0x18
	private SynthesisFilter _RightChannelFilter; // 0x20
	private bool _IsInitialized; // 0x28
	private LayerIDecoder _L1Decoder; // 0x30
	private LayerIIDecoder _L2Decoder; // 0x38
	private LayerIIIDecoder _L3Decoder; // 0x40
	private ABuffer _Output; // 0x48
	private int _OutputChannels; // 0x50
	private int _OutputFrequency; // 0x54

	// Properties
	internal static Decoder.Params DefaultParams { get; }
	internal virtual ABuffer OutputBuffer { set; }

	// Methods

	// RVA: 0x5DD5A0 Offset: 0x5DBBA0 VA: 0x1805DD5A0
	internal void .ctor(Decoder.Params params0) { }

	// RVA: 0x5DD6E0 Offset: 0x5DBCE0 VA: 0x1805DD6E0
	internal static Decoder.Params get_DefaultParams() { }

	// RVA: 0x5DD7A0 Offset: 0x5DBDA0 VA: 0x1805DD7A0 Slot: 4
	internal virtual void set_OutputBuffer(ABuffer value) { }

	// RVA: 0x5DD020 Offset: 0x5DB620 VA: 0x1805DD020
	private void InitBlock() { }

	// RVA: 0x5DCD90 Offset: 0x5DB390 VA: 0x1805DCD90 Slot: 5
	internal virtual ABuffer DecodeFrame(Header header, Bitstream stream) { }

	// RVA: 0x5DD240 Offset: 0x5DB840 VA: 0x1805DD240 Slot: 6
	protected virtual DecoderException NewDecoderException(int errorcode, Exception throwable) { }

	// RVA: 0x5DD310 Offset: 0x5DB910 VA: 0x1805DD310 Slot: 7
	protected virtual IFrameDecoder RetrieveDecoder(Header header, Bitstream stream, int layer) { }

	// RVA: 0x5DD0C0 Offset: 0x5DB6C0 VA: 0x1805DD0C0
	private void Initialize(Header header) { }

	// RVA: 0x5DD540 Offset: 0x5DBB40 VA: 0x1805DD540
	private static void .cctor() { }

}

public class Decoder.Params : ICloneable // TypeDefIndex: 7389
{	// Fields
	private OutputChannels _OutputChannels; // 0x10
	private readonly Equalizer _Equalizer; // 0x18

	// Properties
	internal virtual Equalizer InitialEqualizerSettings { get; }

	// Methods

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 5
	internal virtual Equalizer get_InitialEqualizerSettings() { }

	// RVA: 0x672F30 Offset: 0x671530 VA: 0x180672F30 Slot: 4
	public object Clone() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public sealed class Decoder : IDisposable // TypeDefIndex: 11568
{	// Fields
	private const string whiteSpace = " \t\n\r";
	private const string wordBreak = " \t\n\r{}[],:\"";
	private StringReader json; // 0x10

	// Properties
	private char PeekChar { get; }
	private char NextChar { get; }
	private string NextWord { get; }
	private Decoder.Token NextToken { get; }

	// Methods

	// RVA: 0x85A680 Offset: 0x858C80 VA: 0x18085A680
	private void .ctor(string jsonString) { }

	// RVA: 0x85A500 Offset: 0x858B00 VA: 0x18085A500
	public static Variant Decode(string jsonString) { }

	// RVA: 0x85A640 Offset: 0x858C40 VA: 0x18085A640 Slot: 4
	public void Dispose() { }

	// RVA: 0x859F40 Offset: 0x858540 VA: 0x180859F40
	private ProxyObject DecodeObject() { }

	// RVA: 0x859B40 Offset: 0x858140 VA: 0x180859B40
	private ProxyArray DecodeArray() { }

	// RVA: 0x85A4D0 Offset: 0x858AD0 VA: 0x18085A4D0
	private Variant DecodeValue() { }

	// RVA: 0x859C70 Offset: 0x858270 VA: 0x180859C70
	private Variant DecodeByToken(Decoder.Token token) { }

	// RVA: 0x85A1A0 Offset: 0x8587A0 VA: 0x18085A1A0
	private Variant DecodeString() { }

	// RVA: 0x859EE0 Offset: 0x8584E0 VA: 0x180859EE0
	private Variant DecodeNumber() { }

	// RVA: 0x859A90 Offset: 0x858090 VA: 0x180859A90
	private void ConsumeWhiteSpace() { }

	// RVA: 0x85AB10 Offset: 0x859110 VA: 0x18085AB10
	private char get_PeekChar() { }

	// RVA: 0x85A700 Offset: 0x858D00 VA: 0x18085A700
	private char get_NextChar() { }

	// RVA: 0x85AA20 Offset: 0x859020 VA: 0x18085AA20
	private string get_NextWord() { }

	// RVA: 0x85A780 Offset: 0x858D80 VA: 0x18085A780
	private Decoder.Token get_NextToken() { }

}

private enum Decoder.Token // TypeDefIndex: 11569
{	// Fields
	public int value__; // 0x0
	public const Decoder.Token None = 0;
	public const Decoder.Token OpenBrace = 1;
	public const Decoder.Token CloseBrace = 2;
	public const Decoder.Token OpenBracket = 3;
	public const Decoder.Token CloseBracket = 4;
	public const Decoder.Token Colon = 5;
	public const Decoder.Token Comma = 6;
	public const Decoder.Token String = 7;
	public const Decoder.Token Number = 8;
	public const Decoder.Token True = 9;
	public const Decoder.Token False = 10;
	public const Decoder.Token Null = 11;

}

