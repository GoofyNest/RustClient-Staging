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

	// RVA: 0x18AE070 Offset: 0x18AC670 VA: 0x1818AE070
	internal void SerializeDecoder(SerializationInfo info) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public DecoderFallback get_Fallback() { }

	// RVA: 0x18AE0D0 Offset: 0x18AC6D0 VA: 0x1818AE0D0
	public DecoderFallbackBuffer get_FallbackBuffer() { }

	// RVA: 0x17CB400 Offset: 0x17C9A00 VA: 0x1817CB400
	internal bool get_InternalHasFallbackBuffer() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18ADFA0 Offset: 0x18AC5A0 VA: 0x1818ADFA0 Slot: 4
	public virtual void Reset() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetCharCount(byte[] bytes, int index, int count);

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18ADD30 Offset: 0x18AC330 VA: 0x1818ADD30 Slot: 6
	public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x18ADBE0 Offset: 0x18AC1E0 VA: 0x1818ADBE0 Slot: 7
	public virtual int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	// RVA: 0x18ADF80 Offset: 0x18AC580 VA: 0x1818ADF80 Slot: 9
	public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	[CLSCompliantAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	[ComVisibleAttribute] // RVA: 0x90700 Offset: 0x8FB00 VA: 0x180090700
	// RVA: 0x18ADD50 Offset: 0x18AC350 VA: 0x1818ADD50 Slot: 10
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18AD870 Offset: 0x18ABE70 VA: 0x1818AD870 Slot: 11
	public virtual void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[ComVisibleAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	[CLSCompliantAttribute] // RVA: 0x902D0 Offset: 0x8F6D0 VA: 0x1800902D0
	// RVA: 0x18AD630 Offset: 0x18ABC30 VA: 0x1818AD630 Slot: 12
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

	// RVA: 0x5DD610 Offset: 0x5DBC10 VA: 0x1805DD610
	internal void .ctor(Decoder.Params params0) { }

	// RVA: 0x5DD750 Offset: 0x5DBD50 VA: 0x1805DD750
	internal static Decoder.Params get_DefaultParams() { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810 Slot: 4
	internal virtual void set_OutputBuffer(ABuffer value) { }

	// RVA: 0x5DD090 Offset: 0x5DB690 VA: 0x1805DD090
	private void InitBlock() { }

	// RVA: 0x5DCE00 Offset: 0x5DB400 VA: 0x1805DCE00 Slot: 5
	internal virtual ABuffer DecodeFrame(Header header, Bitstream stream) { }

	// RVA: 0x5DD2B0 Offset: 0x5DB8B0 VA: 0x1805DD2B0 Slot: 6
	protected virtual DecoderException NewDecoderException(int errorcode, Exception throwable) { }

	// RVA: 0x5DD380 Offset: 0x5DB980 VA: 0x1805DD380 Slot: 7
	protected virtual IFrameDecoder RetrieveDecoder(Header header, Bitstream stream, int layer) { }

	// RVA: 0x5DD130 Offset: 0x5DB730 VA: 0x1805DD130
	private void Initialize(Header header) { }

	// RVA: 0x5DD5B0 Offset: 0x5DBBB0 VA: 0x1805DD5B0
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

	// RVA: 0x672FA0 Offset: 0x6715A0 VA: 0x180672FA0 Slot: 4
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

	// RVA: 0x877340 Offset: 0x875940 VA: 0x180877340
	private void .ctor(string jsonString) { }

	// RVA: 0x8771C0 Offset: 0x8757C0 VA: 0x1808771C0
	public static Variant Decode(string jsonString) { }

	// RVA: 0x877300 Offset: 0x875900 VA: 0x180877300 Slot: 4
	public void Dispose() { }

	// RVA: 0x876C00 Offset: 0x875200 VA: 0x180876C00
	private ProxyObject DecodeObject() { }

	// RVA: 0x876800 Offset: 0x874E00 VA: 0x180876800
	private ProxyArray DecodeArray() { }

	// RVA: 0x877190 Offset: 0x875790 VA: 0x180877190
	private Variant DecodeValue() { }

	// RVA: 0x876930 Offset: 0x874F30 VA: 0x180876930
	private Variant DecodeByToken(Decoder.Token token) { }

	// RVA: 0x876E60 Offset: 0x875460 VA: 0x180876E60
	private Variant DecodeString() { }

	// RVA: 0x876BA0 Offset: 0x8751A0 VA: 0x180876BA0
	private Variant DecodeNumber() { }

	// RVA: 0x876750 Offset: 0x874D50 VA: 0x180876750
	private void ConsumeWhiteSpace() { }

	// RVA: 0x8777D0 Offset: 0x875DD0 VA: 0x1808777D0
	private char get_PeekChar() { }

	// RVA: 0x8773C0 Offset: 0x8759C0 VA: 0x1808773C0
	private char get_NextChar() { }

	// RVA: 0x8776E0 Offset: 0x875CE0 VA: 0x1808776E0
	private string get_NextWord() { }

	// RVA: 0x877440 Offset: 0x875A40 VA: 0x180877440
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

