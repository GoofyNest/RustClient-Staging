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

	// RVA: 0x161DA40 Offset: 0x161C040 VA: 0x18161DA40
	private void CheckAsyncTaskInProgress() { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x161EC70 Offset: 0x161D270 VA: 0x18161EC70
	internal static Encoding get_UTF8NoBOM() { }

	// RVA: 0x161E5E0 Offset: 0x161CBE0 VA: 0x18161E5E0
	internal void .ctor() { }

	// RVA: 0x161E990 Offset: 0x161CF90 VA: 0x18161E990
	public void .ctor(Stream stream) { }

	// RVA: 0x161EC30 Offset: 0x161D230 VA: 0x18161EC30
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x161EAA0 Offset: 0x161D0A0 VA: 0x18161EAA0
	public void .ctor(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen) { }

	// RVA: 0x161EA10 Offset: 0x161D010 VA: 0x18161EA10
	public void .ctor(string path) { }

	// RVA: 0x161E670 Offset: 0x161CC70 VA: 0x18161E670
	public void .ctor(string path, bool append) { }

	// RVA: 0x161E640 Offset: 0x161CC40 VA: 0x18161E640
	public void .ctor(string path, bool append, Encoding encoding) { }

	// RVA: 0x161E5B0 Offset: 0x161CBB0 VA: 0x18161E5B0
	public void .ctor(string path, bool append, Encoding encoding, int bufferSize) { }

	// RVA: 0x161E710 Offset: 0x161CD10 VA: 0x18161E710
	internal void .ctor(string path, bool append, Encoding encoding, int bufferSize, bool checkHost) { }

	// RVA: 0x161DF40 Offset: 0x161C540 VA: 0x18161DF40
	private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen) { }

	// RVA: 0x161DB40 Offset: 0x161C140 VA: 0x18161DB40
	private static Stream CreateFile(string path, bool append, bool checkHost) { }

	// RVA: 0x161DAD0 Offset: 0x161C0D0 VA: 0x18161DAD0 Slot: 8
	public override void Close() { }

	// RVA: 0x161DC00 Offset: 0x161C200 VA: 0x18161DC00 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x161DD90 Offset: 0x161C390 VA: 0x18161DD90 Slot: 10
	public override void Flush() { }

	// RVA: 0x161DDC0 Offset: 0x161C3C0 VA: 0x18161DDC0
	private void Flush(bool flushStream, bool flushEncoder) { }

	// RVA: 0x161ED80 Offset: 0x161D380 VA: 0x18161ED80 Slot: 23
	public virtual void set_AutoFlush(bool value) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 24
	public virtual Stream get_BaseStream() { }

	// RVA: 0x161EC60 Offset: 0x161D260 VA: 0x18161EC60
	internal bool get_LeaveOpen() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x161E450 Offset: 0x161CA50 VA: 0x18161E450 Slot: 12
	public override void Write(char value) { }

	// RVA: 0x161E0A0 Offset: 0x161C6A0 VA: 0x18161E0A0 Slot: 13
	public override void Write(char[] buffer) { }

	// RVA: 0x161E170 Offset: 0x161C770 VA: 0x18161E170 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x161E380 Offset: 0x161C980 VA: 0x18161E380 Slot: 15
	public override void Write(string value) { }

	// RVA: 0x161E4D0 Offset: 0x161CAD0 VA: 0x18161E4D0
	private static void .cctor() { }

}

