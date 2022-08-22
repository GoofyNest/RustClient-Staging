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

	// RVA: 0x1636930 Offset: 0x1634F30 VA: 0x181636930
	private static string get_InitialNewLine() { }

	// RVA: 0x16367C0 Offset: 0x1634DC0 VA: 0x1816367C0
	protected void .ctor() { }

	// RVA: 0x1636850 Offset: 0x1634E50 VA: 0x181636850
	protected void .ctor(IFormatProvider formatProvider) { }

	// RVA: 0x16368F0 Offset: 0x1634EF0 VA: 0x1816368F0 Slot: 7
	public virtual IFormatProvider get_FormatProvider() { }

	// RVA: 0x1635B70 Offset: 0x1634170 VA: 0x181635B70 Slot: 8
	public virtual void Close() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1635BE0 Offset: 0x16341E0 VA: 0x181635BE0 Slot: 6
	public void Dispose() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	public virtual void Flush() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Encoding get_Encoding();

	// RVA: 0x1635C50 Offset: 0x1634250 VA: 0x181635C50
	public static TextWriter Synchronized(TextWriter writer) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	public virtual void Write(char value) { }

	// RVA: 0x1636440 Offset: 0x1634A40 VA: 0x181636440 Slot: 13
	public virtual void Write(char[] buffer) { }

	// RVA: 0x1636260 Offset: 0x1634860 VA: 0x181636260 Slot: 14
	public virtual void Write(char[] buffer, int index, int count) { }

	// RVA: 0x1636220 Offset: 0x1634820 VA: 0x181636220 Slot: 15
	public virtual void Write(string value) { }

	// RVA: 0x1636200 Offset: 0x1634800 VA: 0x181636200 Slot: 16
	public virtual void WriteLine() { }

	// RVA: 0x1635D60 Offset: 0x1634360 VA: 0x181635D60 Slot: 17
	public virtual void WriteLine(char value) { }

	// RVA: 0x16361C0 Offset: 0x16347C0 VA: 0x1816361C0 Slot: 18
	public virtual void WriteLine(char[] buffer, int index, int count) { }

	// RVA: 0x1635FB0 Offset: 0x16345B0 VA: 0x181635FB0 Slot: 19
	public virtual void WriteLine(string value) { }

	// RVA: 0x1635DA0 Offset: 0x16343A0 VA: 0x181635DA0 Slot: 20
	public virtual void WriteLine(object value) { }

	// RVA: 0x1635F50 Offset: 0x1634550 VA: 0x181635F50 Slot: 21
	public virtual void WriteLine(string format, object arg0) { }

	// RVA: 0x1635ED0 Offset: 0x16344D0 VA: 0x181635ED0 Slot: 22
	public virtual void WriteLine(string format, object arg0, object arg1) { }

	// RVA: 0x1636470 Offset: 0x1634A70 VA: 0x181636470
	private static void .cctor() { }

}

private sealed class TextWriter.NullTextWriter : TextWriter // TypeDefIndex: 656
{	// Properties
	public override Encoding Encoding { get; }

	// Methods

	// RVA: 0x1629820 Offset: 0x1627E20 VA: 0x181629820
	internal void .ctor() { }

	// RVA: 0x16298B0 Offset: 0x1627EB0 VA: 0x1816298B0 Slot: 11
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

	// RVA: 0x16351B0 Offset: 0x16337B0 VA: 0x1816351B0
	internal void .ctor(TextWriter t) { }

	// RVA: 0xBA4C60 Offset: 0xBA3260 VA: 0x180BA4C60 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0xBA4BA0 Offset: 0xBA31A0 VA: 0x180BA4BA0 Slot: 7
	public override IFormatProvider get_FormatProvider() { }

	// RVA: 0xBA4BD0 Offset: 0xBA31D0 VA: 0x180BA4BD0 Slot: 8
	public override void Close() { }

	// RVA: 0x1634FA0 Offset: 0x16335A0 VA: 0x181634FA0 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0xBA4C30 Offset: 0xBA3230 VA: 0x180BA4C30 Slot: 10
	public override void Flush() { }

	// RVA: 0xBA4C90 Offset: 0xBA3290 VA: 0x180BA4C90 Slot: 12
	public override void Write(char value) { }

	// RVA: 0x1635180 Offset: 0x1633780 VA: 0x181635180 Slot: 13
	public override void Write(char[] buffer) { }

	// RVA: 0x1635150 Offset: 0x1633750 VA: 0x181635150 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x1635120 Offset: 0x1633720 VA: 0x181635120 Slot: 15
	public override void Write(string value) { }

	// RVA: 0x16350F0 Offset: 0x16336F0 VA: 0x1816350F0 Slot: 16
	public override void WriteLine() { }

	// RVA: 0x16350C0 Offset: 0x16336C0 VA: 0x1816350C0 Slot: 17
	public override void WriteLine(char value) { }

	// RVA: 0x1635000 Offset: 0x1633600 VA: 0x181635000 Slot: 18
	public override void WriteLine(char[] buffer, int index, int count) { }

	// RVA: 0x1635060 Offset: 0x1633660 VA: 0x181635060 Slot: 19
	public override void WriteLine(string value) { }

	// RVA: 0xBA4890 Offset: 0xBA2E90 VA: 0x180BA4890 Slot: 20
	public override void WriteLine(object value) { }

	// RVA: 0x1635030 Offset: 0x1633630 VA: 0x181635030 Slot: 21
	public override void WriteLine(string format, object arg0) { }

	// RVA: 0x1635090 Offset: 0x1633690 VA: 0x181635090 Slot: 22
	public override void WriteLine(string format, object arg0, object arg1) { }

}

private sealed class TextWriter.<>c // TypeDefIndex: 658
{	// Fields
	public static readonly TextWriter.<>c <>9; // 0x13E04

	// Methods

	// RVA: 0x1637A60 Offset: 0x1636060 VA: 0x181637A60
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1637500 Offset: 0x1635B00 VA: 0x181637500
	internal void <.cctor>b__73_0(object state) { }

	// RVA: 0x16375A0 Offset: 0x1635BA0 VA: 0x1816375A0
	internal void <.cctor>b__73_1(object state) { }

	// RVA: 0x1637640 Offset: 0x1635C40 VA: 0x181637640
	internal void <.cctor>b__73_2(object state) { }

	// RVA: 0x16376F0 Offset: 0x1635CF0 VA: 0x1816376F0
	internal void <.cctor>b__73_3(object state) { }

	// RVA: 0x1637790 Offset: 0x1635D90 VA: 0x181637790
	internal void <.cctor>b__73_4(object state) { }

	// RVA: 0x1637830 Offset: 0x1635E30 VA: 0x181637830
	internal void <.cctor>b__73_5(object state) { }

	// RVA: 0x16378E0 Offset: 0x1635EE0 VA: 0x1816378E0
	internal void <.cctor>b__73_6(object state) { }

}

