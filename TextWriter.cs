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

	// RVA: 0x1623C50 Offset: 0x1622250 VA: 0x181623C50
	private static string get_InitialNewLine() { }

	// RVA: 0x1623AE0 Offset: 0x16220E0 VA: 0x181623AE0
	protected void .ctor() { }

	// RVA: 0x1623B70 Offset: 0x1622170 VA: 0x181623B70
	protected void .ctor(IFormatProvider formatProvider) { }

	// RVA: 0x1623C10 Offset: 0x1622210 VA: 0x181623C10 Slot: 7
	public virtual IFormatProvider get_FormatProvider() { }

	// RVA: 0x1622E90 Offset: 0x1621490 VA: 0x181622E90 Slot: 8
	public virtual void Close() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1622F00 Offset: 0x1621500 VA: 0x181622F00 Slot: 6
	public void Dispose() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	public virtual void Flush() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Encoding get_Encoding();

	// RVA: 0x1622F70 Offset: 0x1621570 VA: 0x181622F70
	public static TextWriter Synchronized(TextWriter writer) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	public virtual void Write(char value) { }

	// RVA: 0x1623760 Offset: 0x1621D60 VA: 0x181623760 Slot: 13
	public virtual void Write(char[] buffer) { }

	// RVA: 0x1623580 Offset: 0x1621B80 VA: 0x181623580 Slot: 14
	public virtual void Write(char[] buffer, int index, int count) { }

	// RVA: 0x1623540 Offset: 0x1621B40 VA: 0x181623540 Slot: 15
	public virtual void Write(string value) { }

	// RVA: 0x1623520 Offset: 0x1621B20 VA: 0x181623520 Slot: 16
	public virtual void WriteLine() { }

	// RVA: 0x1623080 Offset: 0x1621680 VA: 0x181623080 Slot: 17
	public virtual void WriteLine(char value) { }

	// RVA: 0x16234E0 Offset: 0x1621AE0 VA: 0x1816234E0 Slot: 18
	public virtual void WriteLine(char[] buffer, int index, int count) { }

	// RVA: 0x16232D0 Offset: 0x16218D0 VA: 0x1816232D0 Slot: 19
	public virtual void WriteLine(string value) { }

	// RVA: 0x16230C0 Offset: 0x16216C0 VA: 0x1816230C0 Slot: 20
	public virtual void WriteLine(object value) { }

	// RVA: 0x1623270 Offset: 0x1621870 VA: 0x181623270 Slot: 21
	public virtual void WriteLine(string format, object arg0) { }

	// RVA: 0x16231F0 Offset: 0x16217F0 VA: 0x1816231F0 Slot: 22
	public virtual void WriteLine(string format, object arg0, object arg1) { }

	// RVA: 0x1623790 Offset: 0x1621D90 VA: 0x181623790
	private static void .cctor() { }

}

private sealed class TextWriter.NullTextWriter : TextWriter // TypeDefIndex: 656
{	// Properties
	public override Encoding Encoding { get; }

	// Methods

	// RVA: 0x1616B40 Offset: 0x1615140 VA: 0x181616B40
	internal void .ctor() { }

	// RVA: 0x1616BD0 Offset: 0x16151D0 VA: 0x181616BD0 Slot: 11
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

	// RVA: 0x16224D0 Offset: 0x1620AD0 VA: 0x1816224D0
	internal void .ctor(TextWriter t) { }

	// RVA: 0xBA5130 Offset: 0xBA3730 VA: 0x180BA5130 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0xBA5070 Offset: 0xBA3670 VA: 0x180BA5070 Slot: 7
	public override IFormatProvider get_FormatProvider() { }

	// RVA: 0xBA50A0 Offset: 0xBA36A0 VA: 0x180BA50A0 Slot: 8
	public override void Close() { }

	// RVA: 0x16222C0 Offset: 0x16208C0 VA: 0x1816222C0 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0xBA5100 Offset: 0xBA3700 VA: 0x180BA5100 Slot: 10
	public override void Flush() { }

	// RVA: 0xBA5160 Offset: 0xBA3760 VA: 0x180BA5160 Slot: 12
	public override void Write(char value) { }

	// RVA: 0x16224A0 Offset: 0x1620AA0 VA: 0x1816224A0 Slot: 13
	public override void Write(char[] buffer) { }

	// RVA: 0x1622470 Offset: 0x1620A70 VA: 0x181622470 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x1622440 Offset: 0x1620A40 VA: 0x181622440 Slot: 15
	public override void Write(string value) { }

	// RVA: 0x1622410 Offset: 0x1620A10 VA: 0x181622410 Slot: 16
	public override void WriteLine() { }

	// RVA: 0x16223E0 Offset: 0x16209E0 VA: 0x1816223E0 Slot: 17
	public override void WriteLine(char value) { }

	// RVA: 0x1622320 Offset: 0x1620920 VA: 0x181622320 Slot: 18
	public override void WriteLine(char[] buffer, int index, int count) { }

	// RVA: 0x1622380 Offset: 0x1620980 VA: 0x181622380 Slot: 19
	public override void WriteLine(string value) { }

	// RVA: 0xBA4D60 Offset: 0xBA3360 VA: 0x180BA4D60 Slot: 20
	public override void WriteLine(object value) { }

	// RVA: 0x1622350 Offset: 0x1620950 VA: 0x181622350 Slot: 21
	public override void WriteLine(string format, object arg0) { }

	// RVA: 0x16223B0 Offset: 0x16209B0 VA: 0x1816223B0 Slot: 22
	public override void WriteLine(string format, object arg0, object arg1) { }

}

private sealed class TextWriter.<>c // TypeDefIndex: 658
{	// Fields
	public static readonly TextWriter.<>c <>9; // 0x13BC0

	// Methods

	// RVA: 0x1624D80 Offset: 0x1623380 VA: 0x181624D80
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1624820 Offset: 0x1622E20 VA: 0x181624820
	internal void <.cctor>b__73_0(object state) { }

	// RVA: 0x16248C0 Offset: 0x1622EC0 VA: 0x1816248C0
	internal void <.cctor>b__73_1(object state) { }

	// RVA: 0x1624960 Offset: 0x1622F60 VA: 0x181624960
	internal void <.cctor>b__73_2(object state) { }

	// RVA: 0x1624A10 Offset: 0x1623010 VA: 0x181624A10
	internal void <.cctor>b__73_3(object state) { }

	// RVA: 0x1624AB0 Offset: 0x16230B0 VA: 0x181624AB0
	internal void <.cctor>b__73_4(object state) { }

	// RVA: 0x1624B50 Offset: 0x1623150 VA: 0x181624B50
	internal void <.cctor>b__73_5(object state) { }

	// RVA: 0x1624C00 Offset: 0x1623200 VA: 0x181624C00
	internal void <.cctor>b__73_6(object state) { }

}

