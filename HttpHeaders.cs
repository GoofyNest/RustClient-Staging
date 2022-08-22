public abstract class HttpHeaders : IEnumerable<KeyValuePair<string, IEnumerable<string>>>, IEnumerable // TypeDefIndex: 5775
{	// Fields
	private static readonly Dictionary<string, HeaderInfo> known_headers; // 0x0
	private readonly Dictionary<string, HttpHeaders.HeaderBucket> headers; // 0x10
	private readonly HttpHeaderKind HeaderKind; // 0x18
	internal Nullable<bool> connectionclose; // 0x1C
	internal Nullable<bool> transferEncodingChunked; // 0x1E

	// Methods

	// RVA: 0x108D410 Offset: 0x108BA10 VA: 0x18108D410
	private static void .cctor() { }

	// RVA: 0x108F620 Offset: 0x108DC20 VA: 0x18108F620
	protected void .ctor() { }

	// RVA: 0x108F710 Offset: 0x108DD10 VA: 0x18108F710
	internal void .ctor(HttpHeaderKind headerKind) { }

	// RVA: 0x108C270 Offset: 0x108A870 VA: 0x18108C270
	private bool AddInternal(string name, IEnumerable<string> values, HeaderInfo headerInfo, bool ignoreInvalid) { }

	// RVA: 0x108D130 Offset: 0x108B730 VA: 0x18108D130
	public bool TryAddWithoutValidation(string name, IEnumerable<string> values) { }

	// RVA: 0x108C610 Offset: 0x108AC10 VA: 0x18108C610
	private HeaderInfo CheckName(string name) { }

	// RVA: 0x108D2E0 Offset: 0x108B8E0 VA: 0x18108D2E0
	private bool TryCheckName(string name, out HeaderInfo headerInfo) { }

	[IteratorStateMachineAttribute] // RVA: 0xD9CE0 Offset: 0xD90E0 VA: 0x1800D9CE0
	// RVA: 0x108C910 Offset: 0x108AF10 VA: 0x18108C910 Slot: 4
	public IEnumerator<KeyValuePair<string, IEnumerable<string>>> GetEnumerator() { }

	// RVA: 0x108C910 Offset: 0x108AF10 VA: 0x18108C910 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x108CD40 Offset: 0x108B340 VA: 0x18108CD40
	public bool Remove(string name) { }

	// RVA: 0x108CA60 Offset: 0x108B060 VA: 0x18108CA60
	internal static string GetSingleHeaderString(string key, IEnumerable<string> values) { }

	// RVA: 0x108CEB0 Offset: 0x108B4B0 VA: 0x18108CEB0 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	internal void AddOrRemove<T>(string name, T value, Func<object, string> converter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE02D30 Offset: 0xE01330 VA: 0x180E02D30
	|-HttpHeaders.AddOrRemove<MediaTypeHeaderValue>
	|-HttpHeaders.AddOrRemove<object>
	*/

	// RVA: 0x108C760 Offset: 0x108AD60 VA: 0x18108C760
	private List<string> GetAllHeaderValues(HttpHeaders.HeaderBucket bucket, HeaderInfo headerInfo) { }

	// RVA: 0x108C980 Offset: 0x108AF80 VA: 0x18108C980
	internal static HttpHeaderKind GetKnownHeaderKind(string name) { }

	// RVA: -1 Offset: -1
	internal T GetValue<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDA3E0 Offset: 0xBD89E0 VA: 0x180BDA3E0
	|-HttpHeaders.GetValue<MediaTypeHeaderValue>
	|-HttpHeaders.GetValue<object>
	|-HttpHeaders.GetValue<string>
	|
	|-RVA: 0xBDA140 Offset: 0xBD8740 VA: 0x180BDA140
	|-HttpHeaders.GetValue<Nullable<long>>
	*/

	// RVA: -1 Offset: -1
	internal HttpHeaderValueCollection<T> GetValues<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED52E0 Offset: 0xED38E0 VA: 0x180ED52E0
	|-HttpHeaders.GetValues<TransferCodingHeaderValue>
	|-HttpHeaders.GetValues<object>
	|-HttpHeaders.GetValues<string>
	*/

	// RVA: -1 Offset: -1
	internal void SetValue<T>(string name, T value, Func<object, string> toStringConverter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE02D70 Offset: 0xE01370 VA: 0x180E02D70
	|-HttpHeaders.SetValue<long>
	|
	|-RVA: 0xE02E40 Offset: 0xE01440 VA: 0x180E02E40
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

	// RVA: 0x1089290 Offset: 0x1087890 VA: 0x181089290
	public void .ctor(object parsed, Func<object, string> converter) { }

	// RVA: 0x10892E0 Offset: 0x10878E0 VA: 0x1810892E0
	public bool get_HasStringValues() { }

	// RVA: 0x1089320 Offset: 0x1087920 VA: 0x181089320
	public List<string> get_Values() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_Values(List<string> value) { }

	// RVA: 0x1089220 Offset: 0x1087820 VA: 0x181089220
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
	// RVA: 0x10991F0 Offset: 0x10977F0 VA: 0x1810991F0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1098EF0 Offset: 0x10974F0 VA: 0x181098EF0 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x1099290 Offset: 0x1097890 VA: 0x181099290
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB119C0 Offset: 0xB0FFC0 VA: 0x180B119C0 Slot: 4
	private KeyValuePair<string, IEnumerable<string>> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1099150 Offset: 0x1097750 VA: 0x181099150 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10991A0 Offset: 0x10977A0 VA: 0x1810991A0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

