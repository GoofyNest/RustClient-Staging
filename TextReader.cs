public abstract class TextReader : MarshalByRefObject, IDisposable // TypeDefIndex: 651
{	// Fields
	private static Func<object, string> _ReadLineDelegate; // 0x0
	private static Func<object, int> _ReadDelegate; // 0x8
	public static readonly TextReader Null; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x1622770 Offset: 0x1620D70 VA: 0x181622770 Slot: 7
	public virtual void Close() { }

	// RVA: 0x16227E0 Offset: 0x1620DE0 VA: 0x1816227E0 Slot: 6
	public void Dispose() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x6869A0 Offset: 0x684FA0 VA: 0x1806869A0 Slot: 9
	public virtual int Peek() { }

	// RVA: 0x6869A0 Offset: 0x684FA0 VA: 0x1806869A0 Slot: 10
	public virtual int Read() { }

	// RVA: 0x1622A50 Offset: 0x1621050 VA: 0x181622A50 Slot: 11
	public virtual int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x1622960 Offset: 0x1620F60 VA: 0x181622960 Slot: 12
	public virtual string ReadToEnd() { }

	// RVA: 0x1622850 Offset: 0x1620E50 VA: 0x181622850 Slot: 13
	public virtual string ReadLine() { }

	// RVA: 0x1622C30 Offset: 0x1621230 VA: 0x181622C30
	public static TextReader Synchronized(TextReader reader) { }

	// RVA: 0x1622D20 Offset: 0x1621320 VA: 0x181622D20
	private static void .cctor() { }

}

private sealed class TextReader.NullTextReader : TextReader // TypeDefIndex: 652
{	// Methods

	// RVA: 0x1616AE0 Offset: 0x16150E0 VA: 0x181616AE0
	public void .ctor() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 11
	public override int Read(char[] buffer, int index, int count) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 13
	public override string ReadLine() { }

}

internal sealed class TextReader.SyncTextReader : TextReader // TypeDefIndex: 653
{	// Fields
	internal TextReader _in; // 0x18

	// Methods

	// RVA: 0x1622250 Offset: 0x1620850 VA: 0x181622250
	internal void .ctor(TextReader t) { }

	// RVA: 0x13D1C30 Offset: 0x13D0230 VA: 0x1813D1C30 Slot: 7
	public override void Close() { }

	// RVA: 0x1622190 Offset: 0x1620790 VA: 0x181622190 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1564960 Offset: 0x1562F60 VA: 0x181564960 Slot: 9
	public override int Peek() { }

	// RVA: 0x1319910 Offset: 0x1317F10 VA: 0x181319910 Slot: 10
	public override int Read() { }

	// RVA: 0x1622220 Offset: 0x1620820 VA: 0x181622220 Slot: 11
	public override int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x13D1C00 Offset: 0x13D0200 VA: 0x1813D1C00 Slot: 13
	public override string ReadLine() { }

	// RVA: 0x16221F0 Offset: 0x16207F0 VA: 0x1816221F0 Slot: 12
	public override string ReadToEnd() { }

}

private sealed class TextReader.<>c // TypeDefIndex: 654
{	// Fields
	public static readonly TextReader.<>c <>9; // 0x2B1039C

	// Methods

	// RVA: 0x1624D20 Offset: 0x1623320 VA: 0x181624D20
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x16246A0 Offset: 0x1622CA0 VA: 0x1816246A0
	internal string <.cctor>b__22_0(object state) { }

	// RVA: 0x1624770 Offset: 0x1622D70 VA: 0x181624770
	internal int <.cctor>b__22_1(object state) { }

}

