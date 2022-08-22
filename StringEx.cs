public static class StringEx // TypeDefIndex: 6608
{	// Fields
	private static readonly Regex regexNumeric; // 0x0
	private static readonly Regex regexAlphaNumeric; // 0x8

	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAD130 Offset: 0x1BAB730 VA: 0x181BAD130
	public static string Replace(string originalString, string oldValue, string newValue, StringComparison comparisonType) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BACC90 Offset: 0x1BAB290 VA: 0x181BACC90
	public static bool Contains(string haystack, string needle, CompareOptions options) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BACE80 Offset: 0x1BAB480 VA: 0x181BACE80
	public static bool IsLower(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAD390 Offset: 0x1BAB990 VA: 0x181BAD390
	public static string ToPrintable(string str, int maxLength = 2147483647) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BACF30 Offset: 0x1BAB530 VA: 0x181BACF30
	public static bool IsNumeric(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BACE00 Offset: 0x1BAB400 VA: 0x181BACE00
	public static bool IsAlphaNumeric(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BACD50 Offset: 0x1BAB350 VA: 0x181BACD50
	public static string EscapeRichText(string str) { }

	[IteratorStateMachineAttribute] // RVA: 0xB4BA0 Offset: 0xB3FA0 VA: 0x1800B4BA0
	[ExtensionAttribute] // RVA: 0xB4BA0 Offset: 0xB3FA0 VA: 0x1800B4BA0
	// RVA: 0x1BAD290 Offset: 0x1BAB890 VA: 0x181BAD290
	public static IEnumerable<string> SplitToLines(string input) { }

	[IteratorStateMachineAttribute] // RVA: 0xB4CD0 Offset: 0xB40D0 VA: 0x1800B4CD0
	[ExtensionAttribute] // RVA: 0xB4CD0 Offset: 0xB40D0 VA: 0x1800B4CD0
	// RVA: 0x1BAD210 Offset: 0x1BAB810 VA: 0x181BAD210
	public static IEnumerable<string> SplitToChunks(string str, int chunkLength) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BACFB0 Offset: 0x1BAB5B0 VA: 0x181BACFB0
	public static uint ManifestHash(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAD300 Offset: 0x1BAB900 VA: 0x181BAD300
	public static bool StartsWithAny(string str, string[] values) { }

	// RVA: 0x1BAD4F0 Offset: 0x1BABAF0 VA: 0x181BAD4F0
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD88200 Offset: 0xD86800 VA: 0x180D88200
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0880 Offset: 0x1BAEE80 VA: 0x181BB0880 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1BB0620 Offset: 0x1BAEC20 VA: 0x181BB0620 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1BB0930 Offset: 0x1BAEF30 VA: 0x181BB0930
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0830 Offset: 0x1BAEE30 VA: 0x181BB0830 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0790 Offset: 0x1BAED90 VA: 0x181BB0790 Slot: 4
	private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0790 Offset: 0x1BAED90 VA: 0x181BB0790 Slot: 5
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD88200 Offset: 0xD86800 VA: 0x180D88200
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1BB03F0 Offset: 0x1BAE9F0 VA: 0x181BB03F0 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB05D0 Offset: 0x1BAEBD0 VA: 0x181BB05D0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0520 Offset: 0x1BAEB20 VA: 0x181BB0520 Slot: 4
	private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0520 Offset: 0x1BAEB20 VA: 0x181BB0520 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

