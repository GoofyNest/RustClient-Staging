public static class StringEx // TypeDefIndex: 6608
{	// Fields
	private static readonly Regex regexNumeric; // 0x0
	private static readonly Regex regexAlphaNumeric; // 0x8

	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAC940 Offset: 0x1BAAF40 VA: 0x181BAC940
	public static string Replace(string originalString, string oldValue, string newValue, StringComparison comparisonType) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAC4A0 Offset: 0x1BAAAA0 VA: 0x181BAC4A0
	public static bool Contains(string haystack, string needle, CompareOptions options) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAC690 Offset: 0x1BAAC90 VA: 0x181BAC690
	public static bool IsLower(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BACBA0 Offset: 0x1BAB1A0 VA: 0x181BACBA0
	public static string ToPrintable(string str, int maxLength = 2147483647) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAC740 Offset: 0x1BAAD40 VA: 0x181BAC740
	public static bool IsNumeric(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAC610 Offset: 0x1BAAC10 VA: 0x181BAC610
	public static bool IsAlphaNumeric(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAC560 Offset: 0x1BAAB60 VA: 0x181BAC560
	public static string EscapeRichText(string str) { }

	[IteratorStateMachineAttribute] // RVA: 0xB4BA0 Offset: 0xB3FA0 VA: 0x1800B4BA0
	[ExtensionAttribute] // RVA: 0xB4BA0 Offset: 0xB3FA0 VA: 0x1800B4BA0
	// RVA: 0x1BACAA0 Offset: 0x1BAB0A0 VA: 0x181BACAA0
	public static IEnumerable<string> SplitToLines(string input) { }

	[IteratorStateMachineAttribute] // RVA: 0xB4CD0 Offset: 0xB40D0 VA: 0x1800B4CD0
	[ExtensionAttribute] // RVA: 0xB4CD0 Offset: 0xB40D0 VA: 0x1800B4CD0
	// RVA: 0x1BACA20 Offset: 0x1BAB020 VA: 0x181BACA20
	public static IEnumerable<string> SplitToChunks(string str, int chunkLength) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAC7C0 Offset: 0x1BAADC0 VA: 0x181BAC7C0
	public static uint ManifestHash(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BACB10 Offset: 0x1BAB110 VA: 0x181BACB10
	public static bool StartsWithAny(string str, string[] values) { }

	// RVA: 0x1BACD00 Offset: 0x1BAB300 VA: 0x181BACD00
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
	// RVA: 0xD87750 Offset: 0xD85D50 VA: 0x180D87750
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0090 Offset: 0x1BAE690 VA: 0x181BB0090 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1BAFE30 Offset: 0x1BAE430 VA: 0x181BAFE30 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1BB0140 Offset: 0x1BAE740 VA: 0x181BB0140
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BB0040 Offset: 0x1BAE640 VA: 0x181BB0040 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAFFA0 Offset: 0x1BAE5A0 VA: 0x181BAFFA0 Slot: 4
	private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAFFA0 Offset: 0x1BAE5A0 VA: 0x181BAFFA0 Slot: 5
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
	// RVA: 0xD87750 Offset: 0xD85D50 VA: 0x180D87750
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1BAFC00 Offset: 0x1BAE200 VA: 0x181BAFC00 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAFDE0 Offset: 0x1BAE3E0 VA: 0x181BAFDE0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAFD30 Offset: 0x1BAE330 VA: 0x181BAFD30 Slot: 4
	private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAFD30 Offset: 0x1BAE330 VA: 0x181BAFD30 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

