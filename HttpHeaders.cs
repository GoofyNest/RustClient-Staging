public abstract class HttpHeaders : IEnumerable<KeyValuePair<string, IEnumerable<string>>>, IEnumerable // TypeDefIndex: 5775
{	// Fields
	private static readonly Dictionary<string, HeaderInfo> known_headers; // 0x0
	private readonly Dictionary<string, HttpHeaders.HeaderBucket> headers; // 0x10
	private readonly HttpHeaderKind HeaderKind; // 0x18
	internal Nullable<bool> connectionclose; // 0x1C
	internal Nullable<bool> transferEncodingChunked; // 0x1E

	// Methods

	// RVA: 0x108C6E0 Offset: 0x108ACE0 VA: 0x18108C6E0
	private static void .cctor() { }

	// RVA: 0x108E8F0 Offset: 0x108CEF0 VA: 0x18108E8F0
	protected void .ctor() { }

	// RVA: 0x108E9E0 Offset: 0x108CFE0 VA: 0x18108E9E0
	internal void .ctor(HttpHeaderKind headerKind) { }

	// RVA: 0x108B540 Offset: 0x1089B40 VA: 0x18108B540
	private bool AddInternal(string name, IEnumerable<string> values, HeaderInfo headerInfo, bool ignoreInvalid) { }

	// RVA: 0x108C400 Offset: 0x108AA00 VA: 0x18108C400
	public bool TryAddWithoutValidation(string name, IEnumerable<string> values) { }

	// RVA: 0x108B8E0 Offset: 0x1089EE0 VA: 0x18108B8E0
	private HeaderInfo CheckName(string name) { }

	// RVA: 0x108C5B0 Offset: 0x108ABB0 VA: 0x18108C5B0
	private bool TryCheckName(string name, out HeaderInfo headerInfo) { }

	[IteratorStateMachineAttribute] // RVA: 0xD9CD0 Offset: 0xD90D0 VA: 0x1800D9CD0
	// RVA: 0x108BBE0 Offset: 0x108A1E0 VA: 0x18108BBE0 Slot: 4
	public IEnumerator<KeyValuePair<string, IEnumerable<string>>> GetEnumerator() { }

	// RVA: 0x108BBE0 Offset: 0x108A1E0 VA: 0x18108BBE0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x108C010 Offset: 0x108A610 VA: 0x18108C010
	public bool Remove(string name) { }

	// RVA: 0x108BD30 Offset: 0x108A330 VA: 0x18108BD30
	internal static string GetSingleHeaderString(string key, IEnumerable<string> values) { }

	// RVA: 0x108C180 Offset: 0x108A780 VA: 0x18108C180 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	internal void AddOrRemove<T>(string name, T value, Func<object, string> converter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE01FC0 Offset: 0xE005C0 VA: 0x180E01FC0
	|-HttpHeaders.AddOrRemove<MediaTypeHeaderValue>
	|-HttpHeaders.AddOrRemove<object>
	*/

	// RVA: 0x108BA30 Offset: 0x108A030 VA: 0x18108BA30
	private List<string> GetAllHeaderValues(HttpHeaders.HeaderBucket bucket, HeaderInfo headerInfo) { }

	// RVA: 0x108BC50 Offset: 0x108A250 VA: 0x18108BC50
	internal static HttpHeaderKind GetKnownHeaderKind(string name) { }

	// RVA: -1 Offset: -1
	internal T GetValue<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD9C50 Offset: 0xBD8250 VA: 0x180BD9C50
	|-HttpHeaders.GetValue<MediaTypeHeaderValue>
	|-HttpHeaders.GetValue<object>
	|-HttpHeaders.GetValue<string>
	|
	|-RVA: 0xBD99B0 Offset: 0xBD7FB0 VA: 0x180BD99B0
	|-HttpHeaders.GetValue<Nullable<long>>
	*/

	// RVA: -1 Offset: -1
	internal HttpHeaderValueCollection<T> GetValues<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED4570 Offset: 0xED2B70 VA: 0x180ED4570
	|-HttpHeaders.GetValues<TransferCodingHeaderValue>
	|-HttpHeaders.GetValues<object>
	|-HttpHeaders.GetValues<string>
	*/

	// RVA: -1 Offset: -1
	internal void SetValue<T>(string name, T value, Func<object, string> toStringConverter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE02000 Offset: 0xE00600 VA: 0x180E02000
	|-HttpHeaders.SetValue<long>
	|
	|-RVA: 0xE020D0 Offset: 0xE006D0 VA: 0x180E020D0
	|-HttpHeaders.SetValue<object>
	*/

}

private class HttpHeaders.HeaderBucket // TypeDefIndex: 5776
{	// Fields
	public object Parsed; // 0x10
	private List<string> values; // 0x18
	public readonly Func<object, string> CustomToString; // 0x20

	// Properties
	public bool HasStringValues { get; }
	public List<string> Values { get; set; }

	// Methods

	// RVA: 0x1088560 Offset: 0x1086B60 VA: 0x181088560
	public void .ctor(object parsed, Func<object, string> converter) { }

	// RVA: 0x10885B0 Offset: 0x1086BB0 VA: 0x1810885B0
	public bool get_HasStringValues() { }

	// RVA: 0x10885F0 Offset: 0x1086BF0 VA: 0x1810885F0
	public List<string> get_Values() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_Values(List<string> value) { }

	// RVA: 0x10884F0 Offset: 0x1086AF0 VA: 0x1810884F0
	public string ParsedToString() { }

}

private sealed class HttpHeaders.<GetEnumerator>d__19 : IEnumerator<KeyValuePair<string, IEnumerable<string>>>, IDisposable, IEnumerator // TypeDefIndex: 5777
{	// Fields
	private int <>1__state; // 0x10
	private KeyValuePair<string, IEnumerable<string>> <>2__current; // 0x18
	public HttpHeaders <>4__this; // 0x28
	private Dictionary.Enumerator<string, HttpHeaders.HeaderBucket> <>7__wrap1; // 0x30

	// Properties
	private KeyValuePair<string, IEnumerable<string>> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10984C0 Offset: 0x1096AC0 VA: 0x1810984C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x10981C0 Offset: 0x10967C0 VA: 0x1810981C0 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x1098560 Offset: 0x1096B60 VA: 0x181098560
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xB11230 Offset: 0xB0F830 VA: 0x180B11230 Slot: 4
	private KeyValuePair<string, IEnumerable<string>> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1098420 Offset: 0x1096A20 VA: 0x181098420 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1098470 Offset: 0x1096A70 VA: 0x181098470 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

