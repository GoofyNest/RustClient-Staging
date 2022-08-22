public static class StringEx // TypeDefIndex: 6608
{	// Fields
	private static readonly Regex regexNumeric; // 0x0
	private static readonly Regex regexAlphaNumeric; // 0x8

	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAC680 Offset: 0x1BAAC80 VA: 0x181BAC680
	public static string Replace(string originalString, string oldValue, string newValue, StringComparison comparisonType) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAC1E0 Offset: 0x1BAA7E0 VA: 0x181BAC1E0
	public static bool Contains(string haystack, string needle, CompareOptions options) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAC3D0 Offset: 0x1BAA9D0 VA: 0x181BAC3D0
	public static bool IsLower(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAC8E0 Offset: 0x1BAAEE0 VA: 0x181BAC8E0
	public static string ToPrintable(string str, int maxLength = 2147483647) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAC480 Offset: 0x1BAAA80 VA: 0x181BAC480
	public static bool IsNumeric(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAC350 Offset: 0x1BAA950 VA: 0x181BAC350
	public static bool IsAlphaNumeric(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAC2A0 Offset: 0x1BAA8A0 VA: 0x181BAC2A0
	public static string EscapeRichText(string str) { }

	[IteratorStateMachineAttribute] // RVA: 0xB4BA0 Offset: 0xB3FA0 VA: 0x1800B4BA0
	[ExtensionAttribute] // RVA: 0xB4BA0 Offset: 0xB3FA0 VA: 0x1800B4BA0
	// RVA: 0x1BAC7E0 Offset: 0x1BAADE0 VA: 0x181BAC7E0
	public static IEnumerable<string> SplitToLines(string input) { }

	[IteratorStateMachineAttribute] // RVA: 0xB4CD0 Offset: 0xB40D0 VA: 0x1800B4CD0
	[ExtensionAttribute] // RVA: 0xB4CD0 Offset: 0xB40D0 VA: 0x1800B4CD0
	// RVA: 0x1BAC760 Offset: 0x1BAAD60 VA: 0x181BAC760
	public static IEnumerable<string> SplitToChunks(string str, int chunkLength) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAC500 Offset: 0x1BAAB00 VA: 0x181BAC500
	public static uint ManifestHash(string str) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAC850 Offset: 0x1BAAE50 VA: 0x181BAC850
	public static bool StartsWithAny(string str, string[] values) { }

	// RVA: 0x1BACA40 Offset: 0x1BAB040 VA: 0x181BACA40
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
	// RVA: 0xD87490 Offset: 0xD85A90 VA: 0x180D87490
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAFDD0 Offset: 0x1BAE3D0 VA: 0x181BAFDD0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1BAFB70 Offset: 0x1BAE170 VA: 0x181BAFB70 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1BAFE80 Offset: 0x1BAE480 VA: 0x181BAFE80
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAFD80 Offset: 0x1BAE380 VA: 0x181BAFD80 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAFCE0 Offset: 0x1BAE2E0 VA: 0x181BAFCE0 Slot: 4
	private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAFCE0 Offset: 0x1BAE2E0 VA: 0x181BAFCE0 Slot: 5
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
	// RVA: 0xD87490 Offset: 0xD85A90 VA: 0x180D87490
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1BAF940 Offset: 0x1BADF40 VA: 0x181BAF940 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAFB20 Offset: 0x1BAE120 VA: 0x181BAFB20 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAFA70 Offset: 0x1BAE070 VA: 0x181BAFA70 Slot: 4
	private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1BAFA70 Offset: 0x1BAE070 VA: 0x181BAFA70 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

