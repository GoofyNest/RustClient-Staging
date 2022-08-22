public abstract class TextReader : MarshalByRefObject, IDisposable // TypeDefIndex: 651
{	// Fields
	private static Func<object, string> _ReadLineDelegate; // 0x0
	private static Func<object, int> _ReadDelegate; // 0x8
	public static readonly TextReader Null; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x1635450 Offset: 0x1633A50 VA: 0x181635450 Slot: 7
	public virtual void Close() { }

	// RVA: 0x16354C0 Offset: 0x1633AC0 VA: 0x1816354C0 Slot: 6
	public void Dispose() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x686A10 Offset: 0x685010 VA: 0x180686A10 Slot: 9
	public virtual int Peek() { }

	// RVA: 0x686A10 Offset: 0x685010 VA: 0x180686A10 Slot: 10
	public virtual int Read() { }

	// RVA: 0x1635730 Offset: 0x1633D30 VA: 0x181635730 Slot: 11
	public virtual int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x1635640 Offset: 0x1633C40 VA: 0x181635640 Slot: 12
	public virtual string ReadToEnd() { }

	// RVA: 0x1635530 Offset: 0x1633B30 VA: 0x181635530 Slot: 13
	public virtual string ReadLine() { }

	// RVA: 0x1635910 Offset: 0x1633F10 VA: 0x181635910
	public static TextReader Synchronized(TextReader reader) { }

	// RVA: 0x1635A00 Offset: 0x1634000 VA: 0x181635A00
	private static void .cctor() { }

}

private sealed class TextReader.NullTextReader : TextReader // TypeDefIndex: 652
{	// Methods

	// RVA: 0x16297C0 Offset: 0x1627DC0 VA: 0x1816297C0
	public void .ctor() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 11
	public override int Read(char[] buffer, int index, int count) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 13
	public override string ReadLine() { }

}

internal sealed class TextReader.SyncTextReader : TextReader // TypeDefIndex: 653
{	// Fields
	internal TextReader _in; // 0x18

	// Methods

	// RVA: 0x1634F30 Offset: 0x1633530 VA: 0x181634F30
	internal void .ctor(TextReader t) { }

	// RVA: 0x13D2B30 Offset: 0x13D1130 VA: 0x1813D2B30 Slot: 7
	public override void Close() { }

	// RVA: 0x1634E70 Offset: 0x1633470 VA: 0x181634E70 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1565890 Offset: 0x1563E90 VA: 0x181565890 Slot: 9
	public override int Peek() { }

	// RVA: 0x131A810 Offset: 0x1318E10 VA: 0x18131A810 Slot: 10
	public override int Read() { }

	// RVA: 0x1634F00 Offset: 0x1633500 VA: 0x181634F00 Slot: 11
	public override int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x13D2B00 Offset: 0x13D1100 VA: 0x1813D2B00 Slot: 13
	public override string ReadLine() { }

	// RVA: 0x1634ED0 Offset: 0x16334D0 VA: 0x181634ED0 Slot: 12
	public override string ReadToEnd() { }

}

private sealed class TextReader.<>c // TypeDefIndex: 654
{	// Fields
	public static readonly TextReader.<>c <>9; // 0x13DE0

	// Methods

	// RVA: 0x1637A00 Offset: 0x1636000 VA: 0x181637A00
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1637380 Offset: 0x1635980 VA: 0x181637380
	internal string <.cctor>b__22_0(object state) { }

	// RVA: 0x1637450 Offset: 0x1635A50 VA: 0x181637450
	internal int <.cctor>b__22_1(object state) { }

}

