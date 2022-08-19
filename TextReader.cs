public abstract class TextReader : MarshalByRefObject, IDisposable // TypeDefIndex: 651
{	// Fields
	private static Func<object, string> _ReadLineDelegate; // 0x0
	private static Func<object, int> _ReadDelegate; // 0x8
	public static readonly TextReader Null; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x1635190 Offset: 0x1633790 VA: 0x181635190 Slot: 7
	public virtual void Close() { }

	// RVA: 0x1635200 Offset: 0x1633800 VA: 0x181635200 Slot: 6
	public void Dispose() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x686A10 Offset: 0x685010 VA: 0x180686A10 Slot: 9
	public virtual int Peek() { }

	// RVA: 0x686A10 Offset: 0x685010 VA: 0x180686A10 Slot: 10
	public virtual int Read() { }

	// RVA: 0x1635470 Offset: 0x1633A70 VA: 0x181635470 Slot: 11
	public virtual int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x1635380 Offset: 0x1633980 VA: 0x181635380 Slot: 12
	public virtual string ReadToEnd() { }

	// RVA: 0x1635270 Offset: 0x1633870 VA: 0x181635270 Slot: 13
	public virtual string ReadLine() { }

	// RVA: 0x1635650 Offset: 0x1633C50 VA: 0x181635650
	public static TextReader Synchronized(TextReader reader) { }

	// RVA: 0x1635740 Offset: 0x1633D40 VA: 0x181635740
	private static void .cctor() { }

}

private sealed class TextReader.NullTextReader : TextReader // TypeDefIndex: 652
{	// Methods

	// RVA: 0x1629500 Offset: 0x1627B00 VA: 0x181629500
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

	// RVA: 0x1634C70 Offset: 0x1633270 VA: 0x181634C70
	internal void .ctor(TextReader t) { }

	// RVA: 0x13D2870 Offset: 0x13D0E70 VA: 0x1813D2870 Slot: 7
	public override void Close() { }

	// RVA: 0x1634BB0 Offset: 0x16331B0 VA: 0x181634BB0 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x15655D0 Offset: 0x1563BD0 VA: 0x1815655D0 Slot: 9
	public override int Peek() { }

	// RVA: 0x131A550 Offset: 0x1318B50 VA: 0x18131A550 Slot: 10
	public override int Read() { }

	// RVA: 0x1634C40 Offset: 0x1633240 VA: 0x181634C40 Slot: 11
	public override int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x13D2840 Offset: 0x13D0E40 VA: 0x1813D2840 Slot: 13
	public override string ReadLine() { }

	// RVA: 0x1634C10 Offset: 0x1633210 VA: 0x181634C10 Slot: 12
	public override string ReadToEnd() { }

}

private sealed class TextReader.<>c // TypeDefIndex: 654
{	// Fields
	public static readonly TextReader.<>c <>9; // 0x13DE0

	// Methods

	// RVA: 0x1637740 Offset: 0x1635D40 VA: 0x181637740
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x16370C0 Offset: 0x16356C0 VA: 0x1816370C0
	internal string <.cctor>b__22_0(object state) { }

	// RVA: 0x1637190 Offset: 0x1635790 VA: 0x181637190
	internal int <.cctor>b__22_1(object state) { }

}

