public abstract class Decoder // TypeDefIndex: 433
{	internal DecoderFallback m_fallback; // 0x10
	internal DecoderFallbackBuffer m_fallbackBuffer; // 0x18

	[ComVisibleAttribute] // RVA: 0x75DF0 Offset: 0x751F0 VA: 0x180075DF0
	public DecoderFallback Fallback { get; }
	[ComVisibleAttribute] // RVA: 0x75DF0 Offset: 0x751F0 VA: 0x180075DF0
	public DecoderFallbackBuffer FallbackBuffer { get; }
	internal bool InternalHasFallbackBuffer { get; }


	internal void SerializeDecoder(SerializationInfo info) { }

	protected void .ctor() { }

	public DecoderFallback get_Fallback() { }

	public DecoderFallbackBuffer get_FallbackBuffer() { }

	internal bool get_InternalHasFallbackBuffer() { }

	[ComVisibleAttribute] // RVA: 0x75DF0 Offset: 0x751F0 VA: 0x180075DF0
	public virtual void Reset() { }

	public abstract int GetCharCount(byte[] bytes, int index, int count);

	[ComVisibleAttribute] // RVA: 0x75DF0 Offset: 0x751F0 VA: 0x180075DF0
	public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	[ComVisibleAttribute] // RVA: 0x90290 Offset: 0x8F690 VA: 0x180090290
	[CLSCompliantAttribute] // RVA: 0x90290 Offset: 0x8F690 VA: 0x180090290
	public virtual int GetCharCount(byte* bytes, int count, bool flush) { }

	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	[CLSCompliantAttribute] // RVA: 0x90790 Offset: 0x8FB90 VA: 0x180090790
	[ComVisibleAttribute] // RVA: 0x90790 Offset: 0x8FB90 VA: 0x180090790
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	[ComVisibleAttribute] // RVA: 0x75DF0 Offset: 0x751F0 VA: 0x180075DF0
	public virtual void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[ComVisibleAttribute] // RVA: 0x90290 Offset: 0x8F690 VA: 0x180090290
	[CLSCompliantAttribute] // RVA: 0x90290 Offset: 0x8F690 VA: 0x180090290
	public virtual void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

}

public class Decoder // TypeDefIndex: 7388
{	private static readonly Decoder.Params DecoderDefaultParams; // 0x0
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

	internal static Decoder.Params DefaultParams { get; }
	internal virtual ABuffer OutputBuffer { set; }


	internal void .ctor(Decoder.Params params0) { }

	internal static Decoder.Params get_DefaultParams() { }

	internal virtual void set_OutputBuffer(ABuffer value) { }

	private void InitBlock() { }

	internal virtual ABuffer DecodeFrame(Header header, Bitstream stream) { }

	protected virtual DecoderException NewDecoderException(int errorcode, Exception throwable) { }

	protected virtual IFrameDecoder RetrieveDecoder(Header header, Bitstream stream, int layer) { }

	private void Initialize(Header header) { }

	private static void .cctor() { }

}

public class Decoder.Params : ICloneable // TypeDefIndex: 7389
{	private OutputChannels _OutputChannels; // 0x10
	private readonly Equalizer _Equalizer; // 0x18

	internal virtual Equalizer InitialEqualizerSettings { get; }


	internal virtual Equalizer get_InitialEqualizerSettings() { }

	public object Clone() { }

	public void .ctor() { }

}

public sealed class Decoder : IDisposable // TypeDefIndex: 11572
{	private const string whiteSpace = " \t\n\r";
	private const string wordBreak = " \t\n\r{}[],:\"";
	private StringReader json; // 0x10

	private char PeekChar { get; }
	private char NextChar { get; }
	private string NextWord { get; }
	private Decoder.Token NextToken { get; }


	private void .ctor(string jsonString) { }

	public static Variant Decode(string jsonString) { }

	public void Dispose() { }

	private ProxyObject DecodeObject() { }

	private ProxyArray DecodeArray() { }

	private Variant DecodeValue() { }

	private Variant DecodeByToken(Decoder.Token token) { }

	private Variant DecodeString() { }

	private Variant DecodeNumber() { }

	private void ConsumeWhiteSpace() { }

	private char get_PeekChar() { }

	private char get_NextChar() { }

	private string get_NextWord() { }

	private Decoder.Token get_NextToken() { }

}

private enum Decoder.Token // TypeDefIndex: 11573
{	public int value__; // 0x0
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

