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

	// RVA: 0x1630440 Offset: 0x162EA40 VA: 0x181630440
	internal static int get_DefaultBufferSize() { }

	// RVA: 0x162E970 Offset: 0x162CF70 VA: 0x18162E970
	private void CheckAsyncTaskInProgress() { }

	// RVA: 0x16303E0 Offset: 0x162E9E0 VA: 0x1816303E0
	internal void .ctor() { }

	// RVA: 0x162FDF0 Offset: 0x162E3F0 VA: 0x18162FDF0
	public void .ctor(Stream stream) { }

	// RVA: 0x162FE80 Offset: 0x162E480 VA: 0x18162FE80
	public void .ctor(Stream stream, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x1630140 Offset: 0x162E740 VA: 0x181630140
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x162FF20 Offset: 0x162E520 VA: 0x18162FF20
	public void .ctor(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x16300B0 Offset: 0x162E6B0 VA: 0x1816300B0
	public void .ctor(string path) { }

	// RVA: 0x162FC90 Offset: 0x162E290 VA: 0x18162FC90
	public void .ctor(string path, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x162FD60 Offset: 0x162E360 VA: 0x18162FD60
	public void .ctor(string path, Encoding encoding) { }

	// RVA: 0x162FD30 Offset: 0x162E330 VA: 0x18162FD30
	public void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }

	// RVA: 0x16301D0 Offset: 0x162E7D0 VA: 0x1816301D0
	internal void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool checkHost) { }

	// RVA: 0x162EEE0 Offset: 0x162D4E0 VA: 0x18162EEE0
	private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x162F030 Offset: 0x162D630 VA: 0x18162F030
	internal void Init(Stream stream) { }

	// RVA: 0x162EA00 Offset: 0x162D000 VA: 0x18162EA00 Slot: 7
	public override void Close() { }

	// RVA: 0x162EDD0 Offset: 0x162D3D0 VA: 0x18162EDD0 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 14
	public virtual Encoding get_CurrentEncoding() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 15
	public virtual Stream get_BaseStream() { }

	// RVA: 0x1630450 Offset: 0x162EA50 VA: 0x181630450
	internal bool get_LeaveOpen() { }

	// RVA: 0x162F150 Offset: 0x162D750 VA: 0x18162F150 Slot: 9
	public override int Peek() { }

	// RVA: 0x162EA60 Offset: 0x162D060 VA: 0x18162EA60
	internal bool DataAvailable() { }

	// RVA: 0x162F8D0 Offset: 0x162DED0 VA: 0x18162F8D0 Slot: 10
	public override int Read() { }

	// RVA: 0x162F960 Offset: 0x162DF60 VA: 0x18162F960 Slot: 11
	public override int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x162F7F0 Offset: 0x162DDF0 VA: 0x18162F7F0 Slot: 12
	public override string ReadToEnd() { }

	// RVA: 0x162EA20 Offset: 0x162D020 VA: 0x18162EA20
	private void CompressBuffer(int n) { }

	// RVA: 0x162EA70 Offset: 0x162D070 VA: 0x18162EA70
	private void DetectEncoding() { }

	// RVA: 0x162F050 Offset: 0x162D650 VA: 0x18162F050
	private bool IsPreamble() { }

	// RVA: 0x162F430 Offset: 0x162DA30 VA: 0x18162F430 Slot: 16
	internal virtual int ReadBuffer() { }

	// RVA: 0x162F1E0 Offset: 0x162D7E0 VA: 0x18162F1E0
	private int ReadBuffer(char[] userBuffer, int userOffset, int desiredChars, out bool readToUserBuffer) { }

	// RVA: 0x162F5E0 Offset: 0x162DBE0 VA: 0x18162F5E0 Slot: 13
	public override string ReadLine() { }

	// RVA: 0x162FB80 Offset: 0x162E180 VA: 0x18162FB80
	private static void .cctor() { }

}

private class StreamReader.NullStreamReader : StreamReader // TypeDefIndex: 647
{	// Properties
	public override Stream BaseStream { get; }
	public override Encoding CurrentEncoding { get; }

	// Methods

	// RVA: 0x1628F20 Offset: 0x1627520 VA: 0x181628F20
	internal void .ctor() { }

	// RVA: 0x1628FF0 Offset: 0x16275F0 VA: 0x181628FF0 Slot: 15
	public override Stream get_BaseStream() { }

	// RVA: 0x1629050 Offset: 0x1627650 VA: 0x181629050 Slot: 14
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

	// RVA: 0x1628EE0 Offset: 0x16274E0 VA: 0x181628EE0 Slot: 12
	public override string ReadToEnd() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 16
	internal override int ReadBuffer() { }

}

