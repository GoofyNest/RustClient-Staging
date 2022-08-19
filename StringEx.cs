public static class StringEx // TypeDefIndex: 6608
{	// Fields
	private static readonly Regex regexNumeric; // 0x0
	private static readonly Regex regexAlphaNumeric; // 0x8

	// Methods

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BAC840 Offset: 0x1BAAE40 VA: 0x181BAC840
	public static string Replace(string originalString, string oldValue, string newValue, StringComparison comparisonType) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BAC3A0 Offset: 0x1BAA9A0 VA: 0x181BAC3A0
	public static bool Contains(string haystack, string needle, CompareOptions options) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BAC590 Offset: 0x1BAAB90 VA: 0x181BAC590
	public static bool IsLower(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BACAA0 Offset: 0x1BAB0A0 VA: 0x181BACAA0
	public static string ToPrintable(string str, int maxLength = 2147483647) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BAC640 Offset: 0x1BAAC40 VA: 0x181BAC640
	public static bool IsNumeric(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BAC510 Offset: 0x1BAAB10 VA: 0x181BAC510
	public static bool IsAlphaNumeric(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BAC460 Offset: 0x1BAAA60 VA: 0x181BAC460
	public static string EscapeRichText(string str) { }

	[IteratorStateMachineAttribute] // RVA: 0xB4B00 Offset: 0xB3F00 VA: 0x1800B4B00
	[ExtensionAttribute] // RVA: 0xB4B00 Offset: 0xB3F00 VA: 0x1800B4B00
	// RVA: 0x1BAC9A0 Offset: 0x1BAAFA0 VA: 0x181BAC9A0
	public static IEnumerable<string> SplitToLines(string input) { }

	[IteratorStateMachineAttribute] // RVA: 0xB4C30 Offset: 0xB4030 VA: 0x1800B4C30
	[ExtensionAttribute] // RVA: 0xB4C30 Offset: 0xB4030 VA: 0x1800B4C30
	// RVA: 0x1BAC920 Offset: 0x1BAAF20 VA: 0x181BAC920
	public static IEnumerable<string> SplitToChunks(string str, int chunkLength) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BAC6C0 Offset: 0x1BAACC0 VA: 0x181BAC6C0
	public static uint ManifestHash(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BACA10 Offset: 0x1BAB010 VA: 0x181BACA10
	public static bool StartsWithAny(string str, string[] values) { }

	// RVA: 0x1BACC00 Offset: 0x1BAB200 VA: 0x181BACC00
	private static void .cctor() { }

}

private sealed class StringEx.<SplitToLines>d__9 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable // TypeDefIndex: 6609
{	// Fields
	private int <>1__state; // 0x10
	private string <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private string input; // 0x28
	public string <>3__input; // 0x30
	private StringReader <reader>5__2; // 0x38

	// Properties
	private string System.Collections.Generic.IEnumerator<System.String>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xD87490 Offset: 0xD85A90 VA: 0x180D87490
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BAFF90 Offset: 0x1BAE590 VA: 0x181BAFF90 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1BAFD30 Offset: 0x1BAE330 VA: 0x181BAFD30 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1BB0040 Offset: 0x1BAE640 VA: 0x181BB0040
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BAFF40 Offset: 0x1BAE540 VA: 0x181BAFF40 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BAFEA0 Offset: 0x1BAE4A0 VA: 0x181BAFEA0 Slot: 4
	private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BAFEA0 Offset: 0x1BAE4A0 VA: 0x181BAFEA0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

private sealed class StringEx.<SplitToChunks>d__10 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable // TypeDefIndex: 6610
{	// Fields
	private int <>1__state; // 0x10
	private string <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private string str; // 0x28
	public string <>3__str; // 0x30
	private int chunkLength; // 0x38
	public int <>3__chunkLength; // 0x3C
	private int <i>5__2; // 0x40

	// Properties
	private string System.Collections.Generic.IEnumerator<System.String>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xD87490 Offset: 0xD85A90 VA: 0x180D87490
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1BAFB00 Offset: 0x1BAE100 VA: 0x181BAFB00 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BAFCE0 Offset: 0x1BAE2E0 VA: 0x181BAFCE0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BAFC30 Offset: 0x1BAE230 VA: 0x181BAFC30 Slot: 4
	private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1BAFC30 Offset: 0x1BAE230 VA: 0x181BAFC30 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

