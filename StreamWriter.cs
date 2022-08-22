public class StreamWriter : TextWriter // TypeDefIndex: 648
{	// Fields
	public static readonly StreamWriter Null; // 0x0
	private Stream stream; // 0x28
	private Encoding encoding; // 0x30
	private Encoder encoder; // 0x38
	private byte[] byteBuffer; // 0x40
	private char[] charBuffer; // 0x48
	private int charPos; // 0x50
	private int charLen; // 0x54
	private bool autoFlush; // 0x58
	private bool haveWrittenPreamble; // 0x59
	private bool closable; // 0x5A
	private Task _asyncWriteTask; // 0x60
	private static Encoding _UTF8NoBOM; // 0x8

	// Properties
	internal static Encoding UTF8NoBOM { get; }
	public virtual bool AutoFlush { set; }
	public virtual Stream BaseStream { get; }
	internal bool LeaveOpen { get; }
	public override Encoding Encoding { get; }

	// Methods

	// RVA: 0x1630720 Offset: 0x162ED20 VA: 0x181630720
	private void CheckAsyncTaskInProgress() { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1631950 Offset: 0x162FF50 VA: 0x181631950
	internal static Encoding get_UTF8NoBOM() { }

	// RVA: 0x16312C0 Offset: 0x162F8C0 VA: 0x1816312C0
	internal void .ctor() { }

	// RVA: 0x1631670 Offset: 0x162FC70 VA: 0x181631670
	public void .ctor(Stream stream) { }

	// RVA: 0x1631910 Offset: 0x162FF10 VA: 0x181631910
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x1631780 Offset: 0x162FD80 VA: 0x181631780
	public void .ctor(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen) { }

	// RVA: 0x16316F0 Offset: 0x162FCF0 VA: 0x1816316F0
	public void .ctor(string path) { }

	// RVA: 0x1631350 Offset: 0x162F950 VA: 0x181631350
	public void .ctor(string path, bool append) { }

	// RVA: 0x1631320 Offset: 0x162F920 VA: 0x181631320
	public void .ctor(string path, bool append, Encoding encoding) { }

	// RVA: 0x1631290 Offset: 0x162F890 VA: 0x181631290
	public void .ctor(string path, bool append, Encoding encoding, int bufferSize) { }

	// RVA: 0x16313F0 Offset: 0x162F9F0 VA: 0x1816313F0
	internal void .ctor(string path, bool append, Encoding encoding, int bufferSize, bool checkHost) { }

	// RVA: 0x1630C20 Offset: 0x162F220 VA: 0x181630C20
	private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen) { }

	// RVA: 0x1630820 Offset: 0x162EE20 VA: 0x181630820
	private static Stream CreateFile(string path, bool append, bool checkHost) { }

	// RVA: 0x16307B0 Offset: 0x162EDB0 VA: 0x1816307B0 Slot: 8
	public override void Close() { }

	// RVA: 0x16308E0 Offset: 0x162EEE0 VA: 0x1816308E0 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1630A70 Offset: 0x162F070 VA: 0x181630A70 Slot: 10
	public override void Flush() { }

	// RVA: 0x1630AA0 Offset: 0x162F0A0 VA: 0x181630AA0
	private void Flush(bool flushStream, bool flushEncoder) { }

	// RVA: 0x1631A60 Offset: 0x1630060 VA: 0x181631A60 Slot: 23
	public virtual void set_AutoFlush(bool value) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 24
	public virtual Stream get_BaseStream() { }

	// RVA: 0x1631940 Offset: 0x162FF40 VA: 0x181631940
	internal bool get_LeaveOpen() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x1631130 Offset: 0x162F730 VA: 0x181631130 Slot: 12
	public override void Write(char value) { }

	// RVA: 0x1630D80 Offset: 0x162F380 VA: 0x181630D80 Slot: 13
	public override void Write(char[] buffer) { }

	// RVA: 0x1630E50 Offset: 0x162F450 VA: 0x181630E50 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x1631060 Offset: 0x162F660 VA: 0x181631060 Slot: 15
	public override void Write(string value) { }

	// RVA: 0x16311B0 Offset: 0x162F7B0 VA: 0x1816311B0
	private static void .cctor() { }

}

