public abstract class TextWriter : MarshalByRefObject, IDisposable // TypeDefIndex: 655
{	// Fields
	public static readonly TextWriter Null; // 0x0
	private static Action<object> _WriteCharDelegate; // 0x8
	private static Action<object> _WriteStringDelegate; // 0x10
	private static Action<object> _WriteCharArrayRangeDelegate; // 0x18
	private static Action<object> _WriteLineCharDelegate; // 0x20
	private static Action<object> _WriteLineStringDelegate; // 0x28
	private static Action<object> _WriteLineCharArrayRangeDelegate; // 0x30
	private static Action<object> _FlushDelegate; // 0x38
	protected char[] CoreNewLine; // 0x18
	private IFormatProvider InternalFormatProvider; // 0x20

	// Properties
	private static string InitialNewLine { get; }
	public virtual IFormatProvider FormatProvider { get; }
	public abstract Encoding Encoding { get; }

	// Methods

	// RVA: 0x1636670 Offset: 0x1634C70 VA: 0x181636670
	private static string get_InitialNewLine() { }

	// RVA: 0x1636500 Offset: 0x1634B00 VA: 0x181636500
	protected void .ctor() { }

	// RVA: 0x1636590 Offset: 0x1634B90 VA: 0x181636590
	protected void .ctor(IFormatProvider formatProvider) { }

	// RVA: 0x1636630 Offset: 0x1634C30 VA: 0x181636630 Slot: 7
	public virtual IFormatProvider get_FormatProvider() { }

	// RVA: 0x16358B0 Offset: 0x1633EB0 VA: 0x1816358B0 Slot: 8
	public virtual void Close() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1635920 Offset: 0x1633F20 VA: 0x181635920 Slot: 6
	public void Dispose() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	public virtual void Flush() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Encoding get_Encoding();

	// RVA: 0x1635990 Offset: 0x1633F90 VA: 0x181635990
	public static TextWriter Synchronized(TextWriter writer) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	public virtual void Write(char value) { }

	// RVA: 0x1636180 Offset: 0x1634780 VA: 0x181636180 Slot: 13
	public virtual void Write(char[] buffer) { }

	// RVA: 0x1635FA0 Offset: 0x16345A0 VA: 0x181635FA0 Slot: 14
	public virtual void Write(char[] buffer, int index, int count) { }

	// RVA: 0x1635F60 Offset: 0x1634560 VA: 0x181635F60 Slot: 15
	public virtual void Write(string value) { }

	// RVA: 0x1635F40 Offset: 0x1634540 VA: 0x181635F40 Slot: 16
	public virtual void WriteLine() { }

	// RVA: 0x1635AA0 Offset: 0x16340A0 VA: 0x181635AA0 Slot: 17
	public virtual void WriteLine(char value) { }

	// RVA: 0x1635F00 Offset: 0x1634500 VA: 0x181635F00 Slot: 18
	public virtual void WriteLine(char[] buffer, int index, int count) { }

	// RVA: 0x1635CF0 Offset: 0x16342F0 VA: 0x181635CF0 Slot: 19
	public virtual void WriteLine(string value) { }

	// RVA: 0x1635AE0 Offset: 0x16340E0 VA: 0x181635AE0 Slot: 20
	public virtual void WriteLine(object value) { }

	// RVA: 0x1635C90 Offset: 0x1634290 VA: 0x181635C90 Slot: 21
	public virtual void WriteLine(string format, object arg0) { }

	// RVA: 0x1635C10 Offset: 0x1634210 VA: 0x181635C10 Slot: 22
	public virtual void WriteLine(string format, object arg0, object arg1) { }

	// RVA: 0x16361B0 Offset: 0x16347B0 VA: 0x1816361B0
	private static void .cctor() { }

}

private sealed class TextWriter.NullTextWriter : TextWriter // TypeDefIndex: 656
{	// Properties
	public override Encoding Encoding { get; }

	// Methods

	// RVA: 0x1629560 Offset: 0x1627B60 VA: 0x181629560
	internal void .ctor() { }

	// RVA: 0x16295F0 Offset: 0x1627BF0 VA: 0x1816295F0 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 15
	public override void Write(string value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 16
	public override void WriteLine() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 19
	public override void WriteLine(string value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 20
	public override void WriteLine(object value) { }

}

internal sealed class TextWriter.SyncTextWriter : TextWriter, IDisposable // TypeDefIndex: 657
{	// Fields
	private TextWriter _out; // 0x28

	// Properties
	public override Encoding Encoding { get; }
	public override IFormatProvider FormatProvider { get; }

	// Methods

	// RVA: 0x1634EF0 Offset: 0x16334F0 VA: 0x181634EF0
	internal void .ctor(TextWriter t) { }

	// RVA: 0xBA49A0 Offset: 0xBA2FA0 VA: 0x180BA49A0 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0xBA48E0 Offset: 0xBA2EE0 VA: 0x180BA48E0 Slot: 7
	public override IFormatProvider get_FormatProvider() { }

	// RVA: 0xBA4910 Offset: 0xBA2F10 VA: 0x180BA4910 Slot: 8
	public override void Close() { }

	// RVA: 0x1634CE0 Offset: 0x16332E0 VA: 0x181634CE0 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0xBA4970 Offset: 0xBA2F70 VA: 0x180BA4970 Slot: 10
	public override void Flush() { }

	// RVA: 0xBA49D0 Offset: 0xBA2FD0 VA: 0x180BA49D0 Slot: 12
	public override void Write(char value) { }

	// RVA: 0x1634EC0 Offset: 0x16334C0 VA: 0x181634EC0 Slot: 13
	public override void Write(char[] buffer) { }

	// RVA: 0x1634E90 Offset: 0x1633490 VA: 0x181634E90 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x1634E60 Offset: 0x1633460 VA: 0x181634E60 Slot: 15
	public override void Write(string value) { }

	// RVA: 0x1634E30 Offset: 0x1633430 VA: 0x181634E30 Slot: 16
	public override void WriteLine() { }

	// RVA: 0x1634E00 Offset: 0x1633400 VA: 0x181634E00 Slot: 17
	public override void WriteLine(char value) { }

	// RVA: 0x1634D40 Offset: 0x1633340 VA: 0x181634D40 Slot: 18
	public override void WriteLine(char[] buffer, int index, int count) { }

	// RVA: 0x1634DA0 Offset: 0x16333A0 VA: 0x181634DA0 Slot: 19
	public override void WriteLine(string value) { }

	// RVA: 0xBA45D0 Offset: 0xBA2BD0 VA: 0x180BA45D0 Slot: 20
	public override void WriteLine(object value) { }

	// RVA: 0x1634D70 Offset: 0x1633370 VA: 0x181634D70 Slot: 21
	public override void WriteLine(string format, object arg0) { }

	// RVA: 0x1634DD0 Offset: 0x16333D0 VA: 0x181634DD0 Slot: 22
	public override void WriteLine(string format, object arg0, object arg1) { }

}

private sealed class TextWriter.<>c // TypeDefIndex: 658
{	// Fields
	public static readonly TextWriter.<>c <>9; // 0x13E04

	// Methods

	// RVA: 0x16377A0 Offset: 0x1635DA0 VA: 0x1816377A0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1637240 Offset: 0x1635840 VA: 0x181637240
	internal void <.cctor>b__73_0(object state) { }

	// RVA: 0x16372E0 Offset: 0x16358E0 VA: 0x1816372E0
	internal void <.cctor>b__73_1(object state) { }

	// RVA: 0x1637380 Offset: 0x1635980 VA: 0x181637380
	internal void <.cctor>b__73_2(object state) { }

	// RVA: 0x1637430 Offset: 0x1635A30 VA: 0x181637430
	internal void <.cctor>b__73_3(object state) { }

	// RVA: 0x16374D0 Offset: 0x1635AD0 VA: 0x1816374D0
	internal void <.cctor>b__73_4(object state) { }

	// RVA: 0x1637570 Offset: 0x1635B70 VA: 0x181637570
	internal void <.cctor>b__73_5(object state) { }

	// RVA: 0x1637620 Offset: 0x1635C20 VA: 0x181637620
	internal void <.cctor>b__73_6(object state) { }

}

