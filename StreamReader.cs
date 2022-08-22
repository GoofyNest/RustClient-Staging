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

	// RVA: 0x161DA20 Offset: 0x161C020 VA: 0x18161DA20
	internal static int get_DefaultBufferSize() { }

	// RVA: 0x161BF50 Offset: 0x161A550 VA: 0x18161BF50
	private void CheckAsyncTaskInProgress() { }

	// RVA: 0x161D9C0 Offset: 0x161BFC0 VA: 0x18161D9C0
	internal void .ctor() { }

	// RVA: 0x161D3D0 Offset: 0x161B9D0 VA: 0x18161D3D0
	public void .ctor(Stream stream) { }

	// RVA: 0x161D460 Offset: 0x161BA60 VA: 0x18161D460
	public void .ctor(Stream stream, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x161D720 Offset: 0x161BD20 VA: 0x18161D720
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x161D500 Offset: 0x161BB00 VA: 0x18161D500
	public void .ctor(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x161D690 Offset: 0x161BC90 VA: 0x18161D690
	public void .ctor(string path) { }

	// RVA: 0x161D270 Offset: 0x161B870 VA: 0x18161D270
	public void .ctor(string path, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x161D340 Offset: 0x161B940 VA: 0x18161D340
	public void .ctor(string path, Encoding encoding) { }

	// RVA: 0x161D310 Offset: 0x161B910 VA: 0x18161D310
	public void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }

	// RVA: 0x161D7B0 Offset: 0x161BDB0 VA: 0x18161D7B0
	internal void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool checkHost) { }

	// RVA: 0x161C4C0 Offset: 0x161AAC0 VA: 0x18161C4C0
	private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x161C610 Offset: 0x161AC10 VA: 0x18161C610
	internal void Init(Stream stream) { }

	// RVA: 0x161BFE0 Offset: 0x161A5E0 VA: 0x18161BFE0 Slot: 7
	public override void Close() { }

	// RVA: 0x161C3B0 Offset: 0x161A9B0 VA: 0x18161C3B0 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 14
	public virtual Encoding get_CurrentEncoding() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 15
	public virtual Stream get_BaseStream() { }

	// RVA: 0x161DA30 Offset: 0x161C030 VA: 0x18161DA30
	internal bool get_LeaveOpen() { }

	// RVA: 0x161C730 Offset: 0x161AD30 VA: 0x18161C730 Slot: 9
	public override int Peek() { }

	// RVA: 0x161C040 Offset: 0x161A640 VA: 0x18161C040
	internal bool DataAvailable() { }

	// RVA: 0x161CEB0 Offset: 0x161B4B0 VA: 0x18161CEB0 Slot: 10
	public override int Read() { }

	// RVA: 0x161CF40 Offset: 0x161B540 VA: 0x18161CF40 Slot: 11
	public override int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x161CDD0 Offset: 0x161B3D0 VA: 0x18161CDD0 Slot: 12
	public override string ReadToEnd() { }

	// RVA: 0x161C000 Offset: 0x161A600 VA: 0x18161C000
	private void CompressBuffer(int n) { }

	// RVA: 0x161C050 Offset: 0x161A650 VA: 0x18161C050
	private void DetectEncoding() { }

	// RVA: 0x161C630 Offset: 0x161AC30 VA: 0x18161C630
	private bool IsPreamble() { }

	// RVA: 0x161CA10 Offset: 0x161B010 VA: 0x18161CA10 Slot: 16
	internal virtual int ReadBuffer() { }

	// RVA: 0x161C7C0 Offset: 0x161ADC0 VA: 0x18161C7C0
	private int ReadBuffer(char[] userBuffer, int userOffset, int desiredChars, out bool readToUserBuffer) { }

	// RVA: 0x161CBC0 Offset: 0x161B1C0 VA: 0x18161CBC0 Slot: 13
	public override string ReadLine() { }

	// RVA: 0x161D160 Offset: 0x161B760 VA: 0x18161D160
	private static void .cctor() { }

}

private class StreamReader.NullStreamReader : StreamReader // TypeDefIndex: 647
{	// Properties
	public override Stream BaseStream { get; }
	public override Encoding CurrentEncoding { get; }

	// Methods

	// RVA: 0x1616500 Offset: 0x1614B00 VA: 0x181616500
	internal void .ctor() { }

	// RVA: 0x16165D0 Offset: 0x1614BD0 VA: 0x1816165D0 Slot: 15
	public override Stream get_BaseStream() { }

	// RVA: 0x1616630 Offset: 0x1614C30 VA: 0x181616630 Slot: 14
	public override Encoding get_CurrentEncoding() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x6869A0 Offset: 0x684FA0 VA: 0x1806869A0 Slot: 9
	public override int Peek() { }

	// RVA: 0x6869A0 Offset: 0x684FA0 VA: 0x1806869A0 Slot: 10
	public override int Read() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 11
	public override int Read(char[] buffer, int index, int count) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 13
	public override string ReadLine() { }

	// RVA: 0x16164C0 Offset: 0x1614AC0 VA: 0x1816164C0 Slot: 12
	public override string ReadToEnd() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 16
	internal override int ReadBuffer() { }

}

