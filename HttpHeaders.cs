public abstract class HttpHeaders : IEnumerable<KeyValuePair<string, IEnumerable<string>>>, IEnumerable // TypeDefIndex: 5775
{	// Fields
	private static readonly Dictionary<string, HeaderInfo> known_headers; // 0x0
	private readonly Dictionary<string, HttpHeaders.HeaderBucket> headers; // 0x10
	private readonly HttpHeaderKind HeaderKind; // 0x18
	internal Nullable<bool> connectionclose; // 0x1C
	internal Nullable<bool> transferEncodingChunked; // 0x1E

	// Methods

	// RVA: 0x108C9A0 Offset: 0x108AFA0 VA: 0x18108C9A0
	private static void .cctor() { }

	// RVA: 0x108EBB0 Offset: 0x108D1B0 VA: 0x18108EBB0
	protected void .ctor() { }

	// RVA: 0x108ECA0 Offset: 0x108D2A0 VA: 0x18108ECA0
	internal void .ctor(HttpHeaderKind headerKind) { }

	// RVA: 0x108B800 Offset: 0x1089E00 VA: 0x18108B800
	private bool AddInternal(string name, IEnumerable<string> values, HeaderInfo headerInfo, bool ignoreInvalid) { }

	// RVA: 0x108C6C0 Offset: 0x108ACC0 VA: 0x18108C6C0
	public bool TryAddWithoutValidation(string name, IEnumerable<string> values) { }

	// RVA: 0x108BBA0 Offset: 0x108A1A0 VA: 0x18108BBA0
	private HeaderInfo CheckName(string name) { }

	// RVA: 0x108C870 Offset: 0x108AE70 VA: 0x18108C870
	private bool TryCheckName(string name, out HeaderInfo headerInfo) { }

	[IteratorStateMachineAttribute] // RVA: 0xD9CE0 Offset: 0xD90E0 VA: 0x1800D9CE0
	// RVA: 0x108BEA0 Offset: 0x108A4A0 VA: 0x18108BEA0 Slot: 4
	public IEnumerator<KeyValuePair<string, IEnumerable<string>>> GetEnumerator() { }

	// RVA: 0x108BEA0 Offset: 0x108A4A0 VA: 0x18108BEA0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x108C2D0 Offset: 0x108A8D0 VA: 0x18108C2D0
	public bool Remove(string name) { }

	// RVA: 0x108BFF0 Offset: 0x108A5F0 VA: 0x18108BFF0
	internal static string GetSingleHeaderString(string key, IEnumerable<string> values) { }

	// RVA: 0x108C440 Offset: 0x108AA40 VA: 0x18108C440 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	internal void AddOrRemove<T>(string name, T value, Func<object, string> converter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE02280 Offset: 0xE00880 VA: 0x180E02280
	|-HttpHeaders.AddOrRemove<MediaTypeHeaderValue>
	|-HttpHeaders.AddOrRemove<object>
	*/

	// RVA: 0x108BCF0 Offset: 0x108A2F0 VA: 0x18108BCF0
	private List<string> GetAllHeaderValues(HttpHeaders.HeaderBucket bucket, HeaderInfo headerInfo) { }

	// RVA: 0x108BF10 Offset: 0x108A510 VA: 0x18108BF10
	internal static HttpHeaderKind GetKnownHeaderKind(string name) { }

	// RVA: -1 Offset: -1
	internal T GetValue<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD9F10 Offset: 0xBD8510 VA: 0x180BD9F10
	|-HttpHeaders.GetValue<MediaTypeHeaderValue>
	|-HttpHeaders.GetValue<object>
	|-HttpHeaders.GetValue<string>
	|
	|-RVA: 0xBD9C70 Offset: 0xBD8270 VA: 0x180BD9C70
	|-HttpHeaders.GetValue<Nullable<long>>
	*/

	// RVA: -1 Offset: -1
	internal HttpHeaderValueCollection<T> GetValues<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED4830 Offset: 0xED2E30 VA: 0x180ED4830
	|-HttpHeaders.GetValues<TransferCodingHeaderValue>
	|-HttpHeaders.GetValues<object>
	|-HttpHeaders.GetValues<string>
	*/

	// RVA: -1 Offset: -1
	internal void SetValue<T>(string name, T value, Func<object, string> toStringConverter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE022C0 Offset: 0xE008C0 VA: 0x180E022C0
	|-HttpHeaders.SetValue<long>
	|
	|-RVA: 0xE02390 Offset: 0xE00990 VA: 0x180E02390
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

	// RVA: 0x1088820 Offset: 0x1086E20 VA: 0x181088820
	public void .ctor(object parsed, Func<object, string> converter) { }

	// RVA: 0x1088870 Offset: 0x1086E70 VA: 0x181088870
	public bool get_HasStringValues() { }

	// RVA: 0x10888B0 Offset: 0x1086EB0 VA: 0x1810888B0
	public List<string> get_Values() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_Values(List<string> value) { }

	// RVA: 0x10887B0 Offset: 0x1086DB0 VA: 0x1810887B0
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1098780 Offset: 0x1096D80 VA: 0x181098780 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1098480 Offset: 0x1096A80 VA: 0x181098480 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x1098820 Offset: 0x1096E20 VA: 0x181098820
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB114F0 Offset: 0xB0FAF0 VA: 0x180B114F0 Slot: 4
	private KeyValuePair<string, IEnumerable<string>> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10986E0 Offset: 0x1096CE0 VA: 0x1810986E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1098730 Offset: 0x1096D30 VA: 0x181098730 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

