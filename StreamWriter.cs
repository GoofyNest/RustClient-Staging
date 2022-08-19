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

	// RVA: 0x1630460 Offset: 0x162EA60 VA: 0x181630460
	private void CheckAsyncTaskInProgress() { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1631690 Offset: 0x162FC90 VA: 0x181631690
	internal static Encoding get_UTF8NoBOM() { }

	// RVA: 0x1631000 Offset: 0x162F600 VA: 0x181631000
	internal void .ctor() { }

	// RVA: 0x16313B0 Offset: 0x162F9B0 VA: 0x1816313B0
	public void .ctor(Stream stream) { }

	// RVA: 0x1631650 Offset: 0x162FC50 VA: 0x181631650
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x16314C0 Offset: 0x162FAC0 VA: 0x1816314C0
	public void .ctor(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen) { }

	// RVA: 0x1631430 Offset: 0x162FA30 VA: 0x181631430
	public void .ctor(string path) { }

	// RVA: 0x1631090 Offset: 0x162F690 VA: 0x181631090
	public void .ctor(string path, bool append) { }

	// RVA: 0x1631060 Offset: 0x162F660 VA: 0x181631060
	public void .ctor(string path, bool append, Encoding encoding) { }

	// RVA: 0x1630FD0 Offset: 0x162F5D0 VA: 0x181630FD0
	public void .ctor(string path, bool append, Encoding encoding, int bufferSize) { }

	// RVA: 0x1631130 Offset: 0x162F730 VA: 0x181631130
	internal void .ctor(string path, bool append, Encoding encoding, int bufferSize, bool checkHost) { }

	// RVA: 0x1630960 Offset: 0x162EF60 VA: 0x181630960
	private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen) { }

	// RVA: 0x1630560 Offset: 0x162EB60 VA: 0x181630560
	private static Stream CreateFile(string path, bool append, bool checkHost) { }

	// RVA: 0x16304F0 Offset: 0x162EAF0 VA: 0x1816304F0 Slot: 8
	public override void Close() { }

	// RVA: 0x1630620 Offset: 0x162EC20 VA: 0x181630620 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16307B0 Offset: 0x162EDB0 VA: 0x1816307B0 Slot: 10
	public override void Flush() { }

	// RVA: 0x16307E0 Offset: 0x162EDE0 VA: 0x1816307E0
	private void Flush(bool flushStream, bool flushEncoder) { }

	// RVA: 0x16317A0 Offset: 0x162FDA0 VA: 0x1816317A0 Slot: 23
	public virtual void set_AutoFlush(bool value) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 24
	public virtual Stream get_BaseStream() { }

	// RVA: 0x1631680 Offset: 0x162FC80 VA: 0x181631680
	internal bool get_LeaveOpen() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x1630E70 Offset: 0x162F470 VA: 0x181630E70 Slot: 12
	public override void Write(char value) { }

	// RVA: 0x1630AC0 Offset: 0x162F0C0 VA: 0x181630AC0 Slot: 13
	public override void Write(char[] buffer) { }

	// RVA: 0x1630B90 Offset: 0x162F190 VA: 0x181630B90 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x1630DA0 Offset: 0x162F3A0 VA: 0x181630DA0 Slot: 15
	public override void Write(string value) { }

	// RVA: 0x1630EF0 Offset: 0x162F4F0 VA: 0x181630EF0
	private static void .cctor() { }

}

