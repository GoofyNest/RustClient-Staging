public class StreamReader : TextReader // TypeDefIndex: 646
{	// Fields
	public static readonly StreamReader Null; // 0x0
	private Stream stream; // 0x18
	private Encoding encoding; // 0x20
	private Decoder decoder; // 0x28
	private byte[] byteBuffer; // 0x30
	private char[] charBuffer; // 0x38
	private byte[] _preamble; // 0x40
	private int charPos; // 0x48
	private int charLen; // 0x4C
	private int byteLen; // 0x50
	private int bytePos; // 0x54
	private int _maxCharsPerBuffer; // 0x58
	private bool _detectEncoding; // 0x5C
	private bool _checkPreamble; // 0x5D
	private bool _isBlocked; // 0x5E
	private bool _closable; // 0x5F
	private Task _asyncReadTask; // 0x60

	// Properties
	internal static int DefaultBufferSize { get; }
	public virtual Encoding CurrentEncoding { get; }
	public virtual Stream BaseStream { get; }
	internal bool LeaveOpen { get; }

	// Methods

	// RVA: 0x1630700 Offset: 0x162ED00 VA: 0x181630700
	internal static int get_DefaultBufferSize() { }

	// RVA: 0x162EC30 Offset: 0x162D230 VA: 0x18162EC30
	private void CheckAsyncTaskInProgress() { }

	// RVA: 0x16306A0 Offset: 0x162ECA0 VA: 0x1816306A0
	internal void .ctor() { }

	// RVA: 0x16300B0 Offset: 0x162E6B0 VA: 0x1816300B0
	public void .ctor(Stream stream) { }

	// RVA: 0x1630140 Offset: 0x162E740 VA: 0x181630140
	public void .ctor(Stream stream, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x1630400 Offset: 0x162EA00 VA: 0x181630400
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x16301E0 Offset: 0x162E7E0 VA: 0x1816301E0
	public void .ctor(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x1630370 Offset: 0x162E970 VA: 0x181630370
	public void .ctor(string path) { }

	// RVA: 0x162FF50 Offset: 0x162E550 VA: 0x18162FF50
	public void .ctor(string path, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x1630020 Offset: 0x162E620 VA: 0x181630020
	public void .ctor(string path, Encoding encoding) { }

	// RVA: 0x162FFF0 Offset: 0x162E5F0 VA: 0x18162FFF0
	public void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }

	// RVA: 0x1630490 Offset: 0x162EA90 VA: 0x181630490
	internal void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool checkHost) { }

	// RVA: 0x162F1A0 Offset: 0x162D7A0 VA: 0x18162F1A0
	private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x162F2F0 Offset: 0x162D8F0 VA: 0x18162F2F0
	internal void Init(Stream stream) { }

	// RVA: 0x162ECC0 Offset: 0x162D2C0 VA: 0x18162ECC0 Slot: 7
	public override void Close() { }

	// RVA: 0x162F090 Offset: 0x162D690 VA: 0x18162F090 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 14
	public virtual Encoding get_CurrentEncoding() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 15
	public virtual Stream get_BaseStream() { }

	// RVA: 0x1630710 Offset: 0x162ED10 VA: 0x181630710
	internal bool get_LeaveOpen() { }

	// RVA: 0x162F410 Offset: 0x162DA10 VA: 0x18162F410 Slot: 9
	public override int Peek() { }

	// RVA: 0x162ED20 Offset: 0x162D320 VA: 0x18162ED20
	internal bool DataAvailable() { }

	// RVA: 0x162FB90 Offset: 0x162E190 VA: 0x18162FB90 Slot: 10
	public override int Read() { }

	// RVA: 0x162FC20 Offset: 0x162E220 VA: 0x18162FC20 Slot: 11
	public override int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x162FAB0 Offset: 0x162E0B0 VA: 0x18162FAB0 Slot: 12
	public override string ReadToEnd() { }

	// RVA: 0x162ECE0 Offset: 0x162D2E0 VA: 0x18162ECE0
	private void CompressBuffer(int n) { }

	// RVA: 0x162ED30 Offset: 0x162D330 VA: 0x18162ED30
	private void DetectEncoding() { }

	// RVA: 0x162F310 Offset: 0x162D910 VA: 0x18162F310
	private bool IsPreamble() { }

	// RVA: 0x162F6F0 Offset: 0x162DCF0 VA: 0x18162F6F0 Slot: 16
	internal virtual int ReadBuffer() { }

	// RVA: 0x162F4A0 Offset: 0x162DAA0 VA: 0x18162F4A0
	private int ReadBuffer(char[] userBuffer, int userOffset, int desiredChars, out bool readToUserBuffer) { }

	// RVA: 0x162F8A0 Offset: 0x162DEA0 VA: 0x18162F8A0 Slot: 13
	public override string ReadLine() { }

	// RVA: 0x162FE40 Offset: 0x162E440 VA: 0x18162FE40
	private static void .cctor() { }

}

private class StreamReader.NullStreamReader : StreamReader // TypeDefIndex: 647
{	// Properties
	public override Stream BaseStream { get; }
	public override Encoding CurrentEncoding { get; }

	// Methods

	// RVA: 0x16291E0 Offset: 0x16277E0 VA: 0x1816291E0
	internal void .ctor() { }

	// RVA: 0x16292B0 Offset: 0x16278B0 VA: 0x1816292B0 Slot: 15
	public override Stream get_BaseStream() { }

	// RVA: 0x1629310 Offset: 0x1627910 VA: 0x181629310 Slot: 14
	public override Encoding get_CurrentEncoding() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x686A10 Offset: 0x685010 VA: 0x180686A10 Slot: 9
	public override int Peek() { }

	// RVA: 0x686A10 Offset: 0x685010 VA: 0x180686A10 Slot: 10
	public override int Read() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 11
	public override int Read(char[] buffer, int index, int count) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 13
	public override string ReadLine() { }

	// RVA: 0x16291A0 Offset: 0x16277A0 VA: 0x1816291A0 Slot: 12
	public override string ReadToEnd() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 16
	internal override int ReadBuffer() { }

}

