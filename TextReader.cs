public abstract class TextReader : MarshalByRefObject, IDisposable // TypeDefIndex: 651
{	private static Func<object, string> _ReadLineDelegate; // 0x0
	private static Func<object, int> _ReadDelegate; // 0x8
	public static readonly TextReader Null; // 0x10


	protected void .ctor() { }

	public virtual void Close() { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual int Peek() { }

	public virtual int Read() { }

	public virtual int Read([In] [Out] char[] buffer, int index, int count) { }

	public virtual string ReadToEnd() { }

	public virtual string ReadLine() { }

	public static TextReader Synchronized(TextReader reader) { }

	private static void .cctor() { }

}

private sealed class TextReader.NullTextReader : TextReader // TypeDefIndex: 652
{
	public void .ctor() { }

	public override int Read(char[] buffer, int index, int count) { }

	public override string ReadLine() { }

}

internal sealed class TextReader.SyncTextReader : TextReader // TypeDefIndex: 653
{	internal TextReader _in; // 0x18


	internal void .ctor(TextReader t) { }

	public override void Close() { }

	protected override void Dispose(bool disposing) { }

	public override int Peek() { }

	public override int Read() { }

	public override int Read([In] [Out] char[] buffer, int index, int count) { }

	public override string ReadLine() { }

	public override string ReadToEnd() { }

}

private sealed class TextReader.<>c // TypeDefIndex: 654
{	public static readonly TextReader.<>c <>9; // 0x12FC0


	private static void .cctor() { }

	public void .ctor() { }

	internal string <.cctor>b__22_0(object state) { }

	internal int <.cctor>b__22_1(object state) { }

}

