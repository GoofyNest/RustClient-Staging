public static class JsonUtility // TypeDefIndex: 4525
{
// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0xE7DF0 Offset: 0xE71F0 VA: 0x1800E7DF0
public static class JsonUtility // TypeDefIndex: 4525
	// Methods

	[ThreadSafeAttribute] // RVA: 0xE7F30 Offset: 0xE7330 VA: 0x1800E7F30
	[FreeFunctionAttribute] // RVA: 0xE7F30 Offset: 0xE7330 VA: 0x1800E7F30
	// RVA: 0x2322750 Offset: 0x2320D50 VA: 0x182322750
	private static object FromJsonInternal(string json, object objectToOverwrite, Type type) { }

	// RVA: -1 Offset: -1
	public static T FromJson<T>(string json) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B90B0 Offset: 0x15B76B0 VA: 0x1815B90B0
	|-JsonUtility.FromJson<RandomUsernames.DataFile>
	|-JsonUtility.FromJson<object>
	*/

	// RVA: 0x23227B0 Offset: 0x2320DB0 VA: 0x1823227B0
	public static object FromJson(string json, Type type) { }

}

internal enum JSONNodeType // TypeDefIndex: 5637
{	// Fields
	public int value__; // 0x0
	public const JSONNodeType Array = 1;
	public const JSONNodeType Object = 2;
	public const JSONNodeType String = 3;
	public const JSONNodeType Number = 4;
	public const JSONNodeType NullValue = 5;
	public const JSONNodeType Boolean = 6;
	public const JSONNodeType None = 7;
	public const JSONNodeType Custom = 255;

}

internal enum JSONTextMode // TypeDefIndex: 5638
{	// Fields
	public int value__; // 0x0
	public const JSONTextMode Compact = 0;
	public const JSONTextMode Indent = 1;

}

internal abstract class JSONNode // TypeDefIndex: 5639
{	// Fields
	public static bool forceASCII; // 0x0
	public static bool longAsString; // 0x1
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static StringBuilder m_EscapeBuilder; // 0x80000000

	// Properties
	public virtual JSONNode Item { get; }
	public virtual JSONNode Item { get; set; }
	public virtual string Value { get; }
	public virtual int Count { get; }
	public virtual bool IsNumber { get; }
	public virtual bool IsBoolean { get; }
	public virtual bool IsArray { get; }
	public virtual IEnumerable<JSONNode> Children { get; }
	public virtual double AsDouble { get; }
	public virtual int AsInt { get; }
	public virtual bool AsBool { get; }
	public virtual long AsLong { get; }
	public virtual JSONArray AsArray { get; }
	public virtual JSONObject AsObject { get; }
	internal static StringBuilder EscapeBuilder { get; }

	// Methods

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 4
	public virtual JSONNode get_Item(int aIndex) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 5
	public virtual JSONNode get_Item(string aKey) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	public virtual void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x13CA890 Offset: 0x13C8E90 VA: 0x1813CA890 Slot: 7
	public virtual string get_Value() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 8
	public virtual int get_Count() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	public virtual bool get_IsNumber() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 10
	public virtual bool get_IsBoolean() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 11
	public virtual bool get_IsArray() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	public virtual void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x13C91C0 Offset: 0x13C77C0 VA: 0x1813C91C0 Slot: 13
	public virtual void Add(JSONNode aItem) { }

	[IteratorStateMachineAttribute] // RVA: 0xBB950 Offset: 0xBAD50 VA: 0x1800BB950
	// RVA: 0x13CA7A0 Offset: 0x13C8DA0 VA: 0x1813CA7A0 Slot: 14
	public virtual IEnumerable<JSONNode> get_Children() { }

	// RVA: 0x13CA3F0 Offset: 0x13C89F0 VA: 0x1813CA3F0 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract JSONNode.Enumerator GetEnumerator();

	// RVA: 0x13CA5D0 Offset: 0x13C8BD0 VA: 0x1813CA5D0 Slot: 17
	public virtual double get_AsDouble() { }

	// RVA: 0x13CA6B0 Offset: 0x13C8CB0 VA: 0x1813CA6B0 Slot: 18
	public virtual int get_AsInt() { }

	// RVA: 0x13CA510 Offset: 0x13C8B10 VA: 0x1813CA510 Slot: 19
	public virtual bool get_AsBool() { }

	// RVA: 0x13CA6D0 Offset: 0x13C8CD0 VA: 0x1813CA6D0 Slot: 20
	public virtual long get_AsLong() { }

	// RVA: 0x13CA490 Offset: 0x13C8A90 VA: 0x1813CA490 Slot: 21
	public virtual JSONArray get_AsArray() { }

	// RVA: 0x13CA720 Offset: 0x13C8D20 VA: 0x1813CA720 Slot: 22
	public virtual JSONObject get_AsObject() { }

	// RVA: 0x13CAAC0 Offset: 0x13C90C0 VA: 0x1813CAAC0
	public static JSONNode op_Implicit(string s) { }

	// RVA: 0x13CAB20 Offset: 0x13C9120 VA: 0x1813CAB20
	public static string op_Implicit(JSONNode d) { }

	// RVA: 0x13CAB70 Offset: 0x13C9170 VA: 0x1813CAB70
	public static JSONNode op_Implicit(double n) { }

	// RVA: 0x13CAA60 Offset: 0x13C9060 VA: 0x1813CAA60
	public static JSONNode op_Implicit(bool b) { }

	// RVA: 0x13CA8C0 Offset: 0x13C8EC0 VA: 0x1813CA8C0
	public static bool op_Equality(JSONNode a, object b) { }

	// RVA: 0x13CABD0 Offset: 0x13C91D0 VA: 0x1813CABD0
	public static bool op_Inequality(JSONNode a, object b) { }

	// RVA: 0xAE59E0 Offset: 0xAE3FE0 VA: 0x180AE59E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCCE560 Offset: 0xCCCB60 VA: 0x180CCE560 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13CA800 Offset: 0x13C8E00 VA: 0x1813CA800
	internal static StringBuilder get_EscapeBuilder() { }

	// RVA: 0x13C9510 Offset: 0x13C7B10 VA: 0x1813C9510
	internal static string Escape(string aText) { }

	// RVA: 0x13C9970 Offset: 0x13C7F70 VA: 0x1813C9970
	private static JSONNode ParseElement(string token, bool quoted) { }

	// RVA: 0x13C9BD0 Offset: 0x13C81D0 VA: 0x1813C9BD0
	public static JSONNode Parse(string aJSON) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void SerializeBinary(BinaryWriter aWriter);

	// RVA: 0x13CA370 Offset: 0x13C8970 VA: 0x1813CA370
	public void SaveToBinaryStream(Stream aData) { }

	// RVA: 0x13CA1D0 Offset: 0x13C87D0 VA: 0x1813CA1D0
	public string SaveToBinaryBase64() { }

	// RVA: 0x13C9220 Offset: 0x13C7820 VA: 0x1813C9220
	public static JSONNode DeserializeBinary(BinaryReader aReader) { }

	// RVA: 0x13C9880 Offset: 0x13C7E80 VA: 0x1813C9880
	public static JSONNode LoadFromBinaryStream(Stream aData) { }

	// RVA: 0x13C97D0 Offset: 0x13C7DD0 VA: 0x1813C97D0
	public static JSONNode LoadFromBinaryBase64(string aBase64) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

public struct JSONNode.Enumerator // TypeDefIndex: 5640
{	// Fields
	private JSONNode.Enumerator.Type type; // 0x0
	private Dictionary.Enumerator<string, JSONNode> m_Object; // 0x8
	private List.Enumerator<JSONNode> m_Array; // 0x30

	// Properties
	public KeyValuePair<string, JSONNode> Current { get; }

	// Methods

	// RVA: 0x1EEFD0 Offset: 0x1EE3D0 VA: 0x1801EEFD0
	public void .ctor(List.Enumerator<JSONNode> aArrayEnum) { }

	// RVA: 0x1EF010 Offset: 0x1EE410 VA: 0x1801EF010
	public void .ctor(Dictionary.Enumerator<string, JSONNode> aDictEnum) { }

	// RVA: 0x1EF060 Offset: 0x1EE460 VA: 0x1801EF060
	public KeyValuePair<string, JSONNode> get_Current() { }

	// RVA: 0x1EEF60 Offset: 0x1EE360 VA: 0x1801EEF60
	public bool MoveNext() { }

}

private enum JSONNode.Enumerator.Type // TypeDefIndex: 5641
{	// Fields
	public int value__; // 0x0
	public const JSONNode.Enumerator.Type None = 0;
	public const JSONNode.Enumerator.Type Array = 1;
	public const JSONNode.Enumerator.Type Object = 2;

}

private sealed class JSONNode.<get_Children>d__40 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IDisposable, IEnumerator // TypeDefIndex: 5642
{	// Fields
	private int <>1__state; // 0x10
	private JSONNode <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20

	// Properties
	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD87490 Offset: 0xD85A90 VA: 0x180D87490
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13CF780 Offset: 0x13CDD80 VA: 0x1813CF780 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CF820 Offset: 0x13CDE20 VA: 0x1813CF820 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CF790 Offset: 0x13CDD90 VA: 0x1813CF790 Slot: 4
	private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<GameAnalyticsSDK.Net.Utilities.JSONNode>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CF790 Offset: 0x13CDD90 VA: 0x1813CF790 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

internal class JSONArray : JSONNode // TypeDefIndex: 5643
{	// Fields
	private List<JSONNode> m_List; // 0x10
	private bool inline; // 0x18

	// Properties
	public override bool IsArray { get; }
	public override JSONNode Item { get; }
	public override JSONNode Item { get; set; }
	public override int Count { get; }
	public override IEnumerable<JSONNode> Children { get; }

	// Methods

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 11
	public override bool get_IsArray() { }

	// RVA: 0x13C8270 Offset: 0x13C6870 VA: 0x1813C8270 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x13C86F0 Offset: 0x13C6CF0 VA: 0x1813C86F0 Slot: 4
	public override JSONNode get_Item(int aIndex) { }

	// RVA: 0x13C8680 Offset: 0x13C6C80 VA: 0x1813C8680 Slot: 5
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x13C87B0 Offset: 0x13C6DB0 VA: 0x1813C87B0 Slot: 6
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x13C8640 Offset: 0x13C6C40 VA: 0x1813C8640 Slot: 8
	public override int get_Count() { }

	// RVA: 0x13C81E0 Offset: 0x13C67E0 VA: 0x1813C81E0 Slot: 12
	public override void Add(string aKey, JSONNode aItem) { }

	[IteratorStateMachineAttribute] // RVA: 0xBBEB0 Offset: 0xBB2B0 VA: 0x1800BBEB0
	// RVA: 0x13C85D0 Offset: 0x13C6BD0 VA: 0x1813C85D0 Slot: 14
	public override IEnumerable<JSONNode> get_Children() { }

	// RVA: 0x13C8400 Offset: 0x13C6A00 VA: 0x1813C8400 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13C8300 Offset: 0x13C6900 VA: 0x1813C8300 Slot: 23
	public override void SerializeBinary(BinaryWriter aWriter) { }

	// RVA: 0x13C8560 Offset: 0x13C6B60 VA: 0x1813C8560
	public void .ctor() { }

}

private sealed class JSONArray.<get_Children>d__22 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IDisposable, IEnumerator // TypeDefIndex: 5644
{	// Fields
	private int <>1__state; // 0x10
	private JSONNode <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public JSONArray <>4__this; // 0x28
	private List.Enumerator<JSONNode> <>7__wrap1; // 0x30

	// Properties
	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD87490 Offset: 0xD85A90 VA: 0x180D87490
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CF360 Offset: 0x13CD960 VA: 0x1813CF360 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13CF110 Offset: 0x13CD710 VA: 0x1813CF110 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x13CF400 Offset: 0x13CDA00 VA: 0x1813CF400
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CF310 Offset: 0x13CD910 VA: 0x1813CF310 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CF270 Offset: 0x13CD870 VA: 0x1813CF270 Slot: 4
	private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<GameAnalyticsSDK.Net.Utilities.JSONNode>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CF270 Offset: 0x13CD870 VA: 0x1813CF270 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

internal class JSONObject : JSONNode // TypeDefIndex: 5645
{	// Fields
	private Dictionary<string, JSONNode> m_Dict; // 0x10
	private bool inline; // 0x18

	// Properties
	public override JSONNode Item { get; set; }
	public override JSONNode Item { get; }
	public override int Count { get; }
	public override IEnumerable<JSONNode> Children { get; }

	// Methods

	// RVA: 0x13CB500 Offset: 0x13C9B00 VA: 0x1813CB500 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x13CBBE0 Offset: 0x13CA1E0 VA: 0x1813CBBE0 Slot: 5
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x13CBCB0 Offset: 0x13CA2B0 VA: 0x1813CBCB0 Slot: 6
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x13CBB50 Offset: 0x13CA150 VA: 0x1813CBB50 Slot: 4
	public override JSONNode get_Item(int aIndex) { }

	// RVA: 0x13CBB00 Offset: 0x13CA100 VA: 0x1813CBB00 Slot: 8
	public override int get_Count() { }

	// RVA: 0x13CB3B0 Offset: 0x13C99B0 VA: 0x1813CB3B0 Slot: 12
	public override void Add(string aKey, JSONNode aItem) { }

	[IteratorStateMachineAttribute] // RVA: 0xBDD90 Offset: 0xBD190 VA: 0x1800BDD90
	// RVA: 0x13CBA90 Offset: 0x13CA090 VA: 0x1813CBA90 Slot: 14
	public override IEnumerable<JSONNode> get_Children() { }

	// RVA: 0x13CB780 Offset: 0x13C9D80 VA: 0x1813CB780 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13CB5B0 Offset: 0x13C9BB0 VA: 0x1813CB5B0 Slot: 23
	public override void SerializeBinary(BinaryWriter aWriter) { }

	// RVA: 0x13CBA20 Offset: 0x13CA020 VA: 0x1813CBA20
	public void .ctor() { }

}

private sealed class JSONObject.<get_Children>d__23 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IDisposable, IEnumerator // TypeDefIndex: 5646
{	// Fields
	private int <>1__state; // 0x10
	private JSONNode <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public JSONObject <>4__this; // 0x28
	private Dictionary.Enumerator<string, JSONNode> <>7__wrap1; // 0x30

	// Properties
	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD87490 Offset: 0xD85A90 VA: 0x180D87490
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CF6A0 Offset: 0x13CDCA0 VA: 0x1813CF6A0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13CF440 Offset: 0x13CDA40 VA: 0x1813CF440 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x13CF740 Offset: 0x13CDD40 VA: 0x1813CF740
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CF650 Offset: 0x13CDC50 VA: 0x1813CF650 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CF5B0 Offset: 0x13CDBB0 VA: 0x1813CF5B0 Slot: 4
	private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<GameAnalyticsSDK.Net.Utilities.JSONNode>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CF5B0 Offset: 0x13CDBB0 VA: 0x1813CF5B0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

internal class JSONString : JSONNode // TypeDefIndex: 5647
{	// Fields
	private string m_Data; // 0x10

	// Properties
	public override string Value { get; }

	// Methods

	// RVA: 0x13C88D0 Offset: 0x13C6ED0 VA: 0x1813C88D0 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 7
	public override string get_Value() { }

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(string aData) { }

	// RVA: 0x13CBF90 Offset: 0x13CA590 VA: 0x1813CBF90 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13CBD90 Offset: 0x13CA390 VA: 0x1813CBD90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xDE1FA0 Offset: 0xDE05A0 VA: 0x180DE1FA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13CBF30 Offset: 0x13CA530 VA: 0x1813CBF30 Slot: 23
	public override void SerializeBinary(BinaryWriter aWriter) { }

}

internal class JSONNumber : JSONNode // TypeDefIndex: 5648
{	// Fields
	private double m_Data; // 0x10

	// Properties
	public override bool IsNumber { get; }
	public override string Value { get; }
	public override double AsDouble { get; }
	public override long AsLong { get; }

	// Methods

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 9
	public override bool get_IsNumber() { }

	// RVA: 0x13C88D0 Offset: 0x13C6ED0 VA: 0x1813C88D0 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x13CB350 Offset: 0x13C9950 VA: 0x1813CB350 Slot: 7
	public override string get_Value() { }

	// RVA: 0xB3B890 Offset: 0xB39E90 VA: 0x180B3B890 Slot: 17
	public override double get_AsDouble() { }

	// RVA: 0x13CB340 Offset: 0x13C9940 VA: 0x1813CB340 Slot: 20
	public override long get_AsLong() { }

	// RVA: 0x13CB310 Offset: 0x13C9910 VA: 0x1813CB310
	public void .ctor(double aData) { }

	// RVA: 0x13CB2D0 Offset: 0x13C98D0 VA: 0x1813CB2D0 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13CB150 Offset: 0x13C9750 VA: 0x1813CB150
	private static bool IsNumeric(object value) { }

	// RVA: 0x13CAE80 Offset: 0x13C9480 VA: 0x1813CAE80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13CB140 Offset: 0x13C9740 VA: 0x1813CB140 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13CB270 Offset: 0x13C9870 VA: 0x1813CB270 Slot: 23
	public override void SerializeBinary(BinaryWriter aWriter) { }

}

internal class JSONBool : JSONNode // TypeDefIndex: 5649
{	// Fields
	private bool m_Data; // 0x10

	// Properties
	public override bool IsBoolean { get; }
	public override string Value { get; }
	public override bool AsBool { get; }

	// Methods

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 10
	public override bool get_IsBoolean() { }

	// RVA: 0x13C88D0 Offset: 0x13C6ED0 VA: 0x1813C88D0 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x13C89C0 Offset: 0x13C6FC0 VA: 0x1813C89C0 Slot: 7
	public override string get_Value() { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90 Slot: 19
	public override bool get_AsBool() { }

	// RVA: 0xF88700 Offset: 0xF86D00 VA: 0x180F88700
	public void .ctor(bool aData) { }

	// RVA: 0x13C8960 Offset: 0x13C6F60 VA: 0x1813C8960 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13C8840 Offset: 0x13C6E40 VA: 0x1813C8840 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13C88F0 Offset: 0x13C6EF0 VA: 0x1813C88F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13C8900 Offset: 0x13C6F00 VA: 0x1813C8900 Slot: 23
	public override void SerializeBinary(BinaryWriter aWriter) { }

}

internal class JSONNull : JSONNode // TypeDefIndex: 5650
{	// Fields
	private static JSONNull m_StaticInstance; // 0x0
	public static bool reuseSameInstance; // 0x8

	// Properties
	public override string Value { get; }
	public override bool AsBool { get; }

	// Methods

	// RVA: 0x13CABF0 Offset: 0x13C91F0 VA: 0x1813CABF0
	public static JSONNull CreateOrGet() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x13C88D0 Offset: 0x13C6ED0 VA: 0x1813C88D0 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x13CAE50 Offset: 0x13C9450 VA: 0x1813CAE50 Slot: 7
	public override string get_Value() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 19
	public override bool get_AsBool() { }

	// RVA: 0x13CACA0 Offset: 0x13C92A0 VA: 0x1813CACA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13CAD90 Offset: 0x13C9390 VA: 0x1813CAD90 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13CAD60 Offset: 0x13C9360 VA: 0x1813CAD60 Slot: 23
	public override void SerializeBinary(BinaryWriter aWriter) { }

	// RVA: 0x13CADE0 Offset: 0x13C93E0 VA: 0x1813CADE0
	private static void .cctor() { }

}

internal class JSONLazyCreator : JSONNode // TypeDefIndex: 5651
{	// Fields
	private JSONNode m_Node; // 0x10
	private string m_Key; // 0x18

	// Properties
	public override JSONNode Item { get; }
	public override JSONNode Item { get; set; }
	public override int AsInt { get; }
	public override double AsDouble { get; }
	public override long AsLong { get; }
	public override bool AsBool { get; }
	public override JSONArray AsArray { get; }
	public override JSONObject AsObject { get; }

	// Methods

	// RVA: 0x13C88D0 Offset: 0x13C6ED0 VA: 0x1813C88D0 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x13C8C00 Offset: 0x13C7200 VA: 0x1813C8C00
	public void .ctor(JSONNode aNode) { }

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	public void .ctor(JSONNode aNode, string aKey) { }

	// RVA: -1 Offset: -1
	private T Set<T>(T aVal) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CE940 Offset: 0x5CCF40 VA: 0x1805CE940
	|-JSONLazyCreator.Set<JSONArray>
	|-JSONLazyCreator.Set<JSONBool>
	|-JSONLazyCreator.Set<JSONNumber>
	|-JSONLazyCreator.Set<JSONObject>
	|-JSONLazyCreator.Set<JSONString>
	|-JSONLazyCreator.Set<object>
	*/

	// RVA: 0x13C9060 Offset: 0x13C7660 VA: 0x1813C9060 Slot: 4
	public override JSONNode get_Item(int aIndex) { }

	// RVA: 0x13C8FE0 Offset: 0x13C75E0 VA: 0x1813C8FE0 Slot: 5
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x13C90D0 Offset: 0x13C76D0 VA: 0x1813C90D0 Slot: 6
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x13C8AC0 Offset: 0x13C70C0 VA: 0x1813C8AC0 Slot: 13
	public override void Add(JSONNode aItem) { }

	// RVA: 0x13C89D0 Offset: 0x13C6FD0 VA: 0x1813C89D0 Slot: 12
	public override void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x13C8BA0 Offset: 0x13C71A0 VA: 0x1813C8BA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13C8DE0 Offset: 0x13C73E0 VA: 0x1813C8DE0 Slot: 18
	public override int get_AsInt() { }

	// RVA: 0x13C8D70 Offset: 0x13C7370 VA: 0x1813C8D70 Slot: 17
	public override double get_AsDouble() { }

	// RVA: 0x13C8E50 Offset: 0x13C7450 VA: 0x1813C8E50 Slot: 20
	public override long get_AsLong() { }

	// RVA: 0x13C8D00 Offset: 0x13C7300 VA: 0x1813C8D00 Slot: 19
	public override bool get_AsBool() { }

	// RVA: 0x13C8C50 Offset: 0x13C7250 VA: 0x1813C8C50 Slot: 21
	public override JSONArray get_AsArray() { }

	// RVA: 0x13C8F30 Offset: 0x13C7530 VA: 0x1813C8F30 Slot: 22
	public override JSONObject get_AsObject() { }

	// RVA: 0x13C8BB0 Offset: 0x13C71B0 VA: 0x1813C8BB0 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 23
	public override void SerializeBinary(BinaryWriter aWriter) { }

}

internal static class JSON // TypeDefIndex: 5652
{	// Methods

	// RVA: 0x13CC000 Offset: 0x13CA600 VA: 0x1813CC000
	public static JSONNode Parse(string aJSON) { }

}

public sealed class JsonConstructorAttribute : Attribute // TypeDefIndex: 5872
{	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

}

public class JsonException : Exception // TypeDefIndex: 5874
{	// Methods

	// RVA: 0xF8B240 Offset: 0xF89840 VA: 0x180F8B240
	public void .ctor() { }

	// RVA: 0xF8B320 Offset: 0xF89920 VA: 0x180F8B320
	public void .ctor(string message) { }

	// RVA: 0xF8B2A0 Offset: 0xF898A0 VA: 0x180F8B2A0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0xF8B1C0 Offset: 0xF897C0 VA: 0x180F8B1C0
	public void .ctor(SerializationInfo info, StreamingContext context) { }

}

public class JsonExtensionDataAttribute : Attribute // TypeDefIndex: 5875
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <WriteData>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <ReadData>k__BackingField; // 0x11

	// Properties
	public bool WriteData { get; set; }
	public bool ReadData { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_WriteData() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFC0 Offset: 0x4995C0 VA: 0x18049AFC0
	public void set_WriteData(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8B3B0 Offset: 0xF899B0 VA: 0x180F8B3B0
	public bool get_ReadData() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8B3C0 Offset: 0xF899C0 VA: 0x180F8B3C0
	public void set_ReadData(bool value) { }

	// RVA: 0xF8B390 Offset: 0xF89990 VA: 0x180F8B390
	public void .ctor() { }

}

internal enum JsonContainerType // TypeDefIndex: 5876
{	// Fields
	public int value__; // 0x0
	public const JsonContainerType None = 0;
	public const JsonContainerType Object = 1;
	public const JsonContainerType Array = 2;
	public const JsonContainerType Constructor = 3;

}

internal struct JsonPosition // TypeDefIndex: 5877
{	// Fields
	private static readonly char[] SpecialCharacters; // 0x0
	internal JsonContainerType Type; // 0x0
	internal int Position; // 0x4
	internal string PropertyName; // 0x8
	internal bool HasIndex; // 0x10

	// Methods

	// RVA: 0x141F70 Offset: 0x141370 VA: 0x180141F70
	public void .ctor(JsonContainerType type) { }

	// RVA: 0x141F50 Offset: 0x141350 VA: 0x180141F50
	internal int CalculateLength() { }

	// RVA: 0x141F60 Offset: 0x141360 VA: 0x180141F60
	internal void WriteTo(StringBuilder sb) { }

	// RVA: 0x4BCCA0 Offset: 0x4BB2A0 VA: 0x1804BCCA0
	internal static bool TypeHasIndex(JsonContainerType type) { }

	// RVA: 0xF8B3D0 Offset: 0xF899D0 VA: 0x180F8B3D0
	internal static string BuildPath(List<JsonPosition> positions, Nullable<JsonPosition> currentPosition) { }

	// RVA: 0xF8B7F0 Offset: 0xF89DF0 VA: 0x180F8B7F0
	internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message) { }

	// RVA: 0xF8BB30 Offset: 0xF8A130 VA: 0x180F8BB30
	private static void .cctor() { }

}

public sealed class JsonRequiredAttribute : Attribute // TypeDefIndex: 5878
{	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

}

public sealed class JsonArrayAttribute : JsonContainerAttribute // TypeDefIndex: 5884
{	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

}

public abstract class JsonContainerAttribute : Attribute // TypeDefIndex: 5885
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Type <ItemConverterType>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object[] <ItemConverterParameters>k__BackingField; // 0x18
	internal Nullable<bool> _isReference; // 0x20
	internal Nullable<bool> _itemIsReference; // 0x22
	internal Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling; // 0x24
	internal Nullable<TypeNameHandling> _itemTypeNameHandling; // 0x2C

	// Properties
	public Type ItemConverterType { get; }
	public object[] ItemConverterParameters { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public Type get_ItemConverterType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public object[] get_ItemConverterParameters() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	protected void .ctor() { }

}

public sealed class JsonConverterAttribute : Attribute // TypeDefIndex: 5887
{	// Fields
	private readonly Type _converterType; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object[] <ConverterParameters>k__BackingField; // 0x18

	// Properties
	public Type ConverterType { get; }
	public object[] ConverterParameters { get; }

	// Methods

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public Type get_ConverterType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public object[] get_ConverterParameters() { }

	// RVA: 0xF8B0F0 Offset: 0xF896F0 VA: 0x180F8B0F0
	public void .ctor(Type converterType) { }

}

public sealed class JsonObjectAttribute : JsonContainerAttribute // TypeDefIndex: 5888
{	// Fields
	private MemberSerialization _memberSerialization; // 0x38
	internal Nullable<Required> _itemRequired; // 0x3C

	// Properties
	public MemberSerialization MemberSerialization { get; }

	// Methods

	// RVA: 0x6BB940 Offset: 0x6B9F40 VA: 0x1806BB940
	public MemberSerialization get_MemberSerialization() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

}

public class JsonSerializerSettings // TypeDefIndex: 5889
{	// Fields
	internal static readonly StreamingContext DefaultContext; // 0x0
	internal static readonly CultureInfo DefaultCulture; // 0x10
	internal Nullable<Formatting> _formatting; // 0x10
	internal Nullable<DateFormatHandling> _dateFormatHandling; // 0x18
	internal Nullable<DateTimeZoneHandling> _dateTimeZoneHandling; // 0x20
	internal Nullable<DateParseHandling> _dateParseHandling; // 0x28
	internal Nullable<FloatFormatHandling> _floatFormatHandling; // 0x30
	internal Nullable<FloatParseHandling> _floatParseHandling; // 0x38
	internal Nullable<StringEscapeHandling> _stringEscapeHandling; // 0x40
	internal CultureInfo _culture; // 0x48
	internal Nullable<bool> _checkAdditionalContent; // 0x50
	internal Nullable<int> _maxDepth; // 0x54
	internal bool _maxDepthSet; // 0x5C
	internal string _dateFormatString; // 0x60
	internal bool _dateFormatStringSet; // 0x68
	internal Nullable<FormatterAssemblyStyle> _typeNameAssemblyFormat; // 0x6C
	internal Nullable<DefaultValueHandling> _defaultValueHandling; // 0x74
	internal Nullable<PreserveReferencesHandling> _preserveReferencesHandling; // 0x7C
	internal Nullable<NullValueHandling> _nullValueHandling; // 0x84
	internal Nullable<ObjectCreationHandling> _objectCreationHandling; // 0x8C
	internal Nullable<MissingMemberHandling> _missingMemberHandling; // 0x94
	internal Nullable<ReferenceLoopHandling> _referenceLoopHandling; // 0x9C
	internal Nullable<StreamingContext> _context; // 0xA8
	internal Nullable<ConstructorHandling> _constructorHandling; // 0xC0
	internal Nullable<TypeNameHandling> _typeNameHandling; // 0xC8
	internal Nullable<MetadataPropertyHandling> _metadataPropertyHandling; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IList<JsonConverter> <Converters>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IContractResolver <ContractResolver>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEqualityComparer <EqualityComparer>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Func<IReferenceResolver> <ReferenceResolverProvider>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ITraceWriter <TraceWriter>k__BackingField; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SerializationBinder <Binder>k__BackingField; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventHandler<ErrorEventArgs> <Error>k__BackingField; // 0x108

	// Properties
	public ReferenceLoopHandling ReferenceLoopHandling { get; }
	public MissingMemberHandling MissingMemberHandling { get; }
	public ObjectCreationHandling ObjectCreationHandling { get; }
	public NullValueHandling NullValueHandling { get; }
	public DefaultValueHandling DefaultValueHandling { get; }
	public IList<JsonConverter> Converters { get; set; }
	public PreserveReferencesHandling PreserveReferencesHandling { get; }
	public TypeNameHandling TypeNameHandling { get; }
	public MetadataPropertyHandling MetadataPropertyHandling { get; }
	public FormatterAssemblyStyle TypeNameAssemblyFormat { get; }
	public ConstructorHandling ConstructorHandling { get; }
	public IContractResolver ContractResolver { get; }
	public IEqualityComparer EqualityComparer { get; }
	public Func<IReferenceResolver> ReferenceResolverProvider { get; }
	public ITraceWriter TraceWriter { get; }
	public SerializationBinder Binder { get; }
	public EventHandler<ErrorEventArgs> Error { get; }
	public StreamingContext Context { get; }

	// Methods

	// RVA: 0xF907F0 Offset: 0xF8EDF0 VA: 0x180F907F0
	public ReferenceLoopHandling get_ReferenceLoopHandling() { }

	// RVA: 0xF906F0 Offset: 0xF8ECF0 VA: 0x180F906F0
	public MissingMemberHandling get_MissingMemberHandling() { }

	// RVA: 0xF90770 Offset: 0xF8ED70 VA: 0x180F90770
	public ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0xF90730 Offset: 0xF8ED30 VA: 0x180F90730
	public NullValueHandling get_NullValueHandling() { }

	// RVA: 0xF90670 Offset: 0xF8EC70 VA: 0x180F90670
	public DefaultValueHandling get_DefaultValueHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD9F470 Offset: 0xD9DA70 VA: 0x180D9F470
	public IList<JsonConverter> get_Converters() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD35070 Offset: 0xD33670 VA: 0x180D35070
	public void set_Converters(IList<JsonConverter> value) { }

	// RVA: 0xF907B0 Offset: 0xF8EDB0 VA: 0x180F907B0
	public PreserveReferencesHandling get_PreserveReferencesHandling() { }

	// RVA: 0xF90870 Offset: 0xF8EE70 VA: 0x180F90870
	public TypeNameHandling get_TypeNameHandling() { }

	// RVA: 0xF906B0 Offset: 0xF8ECB0 VA: 0x180F906B0
	public MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0xF90830 Offset: 0xF8EE30 VA: 0x180F90830
	public FormatterAssemblyStyle get_TypeNameAssemblyFormat() { }

	// RVA: 0xF90590 Offset: 0xF8EB90 VA: 0x180F90590
	public ConstructorHandling get_ConstructorHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4EF3A0 Offset: 0x4ED9A0 VA: 0x1804EF3A0
	public IContractResolver get_ContractResolver() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x872140 Offset: 0x870740 VA: 0x180872140
	public IEqualityComparer get_EqualityComparer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC73B60 Offset: 0xC72160 VA: 0x180C73B60
	public Func<IReferenceResolver> get_ReferenceResolverProvider() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB0EDC0 Offset: 0xB0D3C0 VA: 0x180B0EDC0
	public ITraceWriter get_TraceWriter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2A920 Offset: 0xA28F20 VA: 0x180A2A920
	public SerializationBinder get_Binder() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC831A0 Offset: 0xC817A0 VA: 0x180C831A0
	public EventHandler<ErrorEventArgs> get_Error() { }

	// RVA: 0xF905D0 Offset: 0xF8EBD0 VA: 0x180F905D0
	public StreamingContext get_Context() { }

	// RVA: 0xF903A0 Offset: 0xF8E9A0 VA: 0x180F903A0
	private static void .cctor() { }

	// RVA: 0xF90420 Offset: 0xF8EA20 VA: 0x180F90420
	public void .ctor() { }

}

private sealed class JsonSerializerSettings.<>c__DisplayClass90_0 // TypeDefIndex: 5890
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class JsonTextReader : JsonReader, IJsonLineInfo // TypeDefIndex: 5894
{	// Fields
	private readonly TextReader _reader; // 0x78
	private char[] _chars; // 0x80
	private int _charsUsed; // 0x88
	private int _charPos; // 0x8C
	private int _lineStartPos; // 0x90
	private int _lineNumber; // 0x94
	private bool _isEndOfFile; // 0x98
	private StringBuffer _stringBuffer; // 0xA0
	private StringReference _stringReference; // 0xB0
	private IArrayPool<char> _arrayPool; // 0xC0
	internal PropertyNameTable NameTable; // 0xC8

	// Properties
	public int LineNumber { get; }
	public int LinePosition { get; }

	// Methods

	// RVA: 0xF9B400 Offset: 0xF99A00 VA: 0x180F9B400
	public void .ctor(TextReader reader) { }

	// RVA: 0xF93820 Offset: 0xF91E20 VA: 0x180F93820
	private void EnsureBufferNotEmpty() { }

	// RVA: 0xF94040 Offset: 0xF92640 VA: 0x180F94040
	private void OnNewLine(int pos) { }

	// RVA: 0xF96930 Offset: 0xF94F30 VA: 0x180F96930
	private void ParseString(char quote, ReadType readType) { }

	// RVA: 0xBB3F60 Offset: 0xBB2560 VA: 0x180BB3F60
	private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count) { }

	// RVA: 0xF9B230 Offset: 0xF99830 VA: 0x180F9B230
	private void ShiftBufferIfNeeded() { }

	// RVA: 0xF99510 Offset: 0xF97B10 VA: 0x180F99510
	private int ReadData(bool append) { }

	// RVA: 0xF99280 Offset: 0xF97880 VA: 0x180F99280
	private int ReadData(bool append, int charsRequired) { }

	// RVA: 0xF93900 Offset: 0xF91F00 VA: 0x180F93900
	private bool EnsureChars(int relativePosition, bool append) { }

	// RVA: 0xF991F0 Offset: 0xF977F0 VA: 0x180F991F0
	private bool ReadChars(int relativePosition, bool append) { }

	// RVA: 0xF9AF40 Offset: 0xF99540 VA: 0x180F9AF40 Slot: 10
	public override bool Read() { }

	// RVA: 0xF99100 Offset: 0xF97700 VA: 0x180F99100 Slot: 11
	public override Nullable<int> ReadAsInt32() { }

	// RVA: 0xF98F20 Offset: 0xF97520 VA: 0x180F98F20 Slot: 17
	public override Nullable<DateTime> ReadAsDateTime() { }

	// RVA: 0xF99190 Offset: 0xF97790 VA: 0x180F99190 Slot: 12
	public override string ReadAsString() { }

	// RVA: 0xF98800 Offset: 0xF96E00 VA: 0x180F98800 Slot: 13
	public override byte[] ReadAsBytes() { }

	// RVA: 0xF9A5D0 Offset: 0xF98BD0 VA: 0x180F9A5D0
	private object ReadStringValue(ReadType readType) { }

	// RVA: 0xF935B0 Offset: 0xF91BB0 VA: 0x180F935B0
	private JsonReaderException CreateUnexpectedCharacterException(char c) { }

	// RVA: 0xF97ED0 Offset: 0xF964D0 VA: 0x180F97ED0 Slot: 15
	public override Nullable<bool> ReadAsBoolean() { }

	// RVA: 0xF97E60 Offset: 0xF96460 VA: 0x180F97E60
	private void ProcessValueComma() { }

	// RVA: 0xF99940 Offset: 0xF97F40 VA: 0x180F99940
	private object ReadNumberValue(ReadType readType) { }

	// RVA: 0xF98E80 Offset: 0xF97480 VA: 0x180F98E80 Slot: 18
	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0xF98FC0 Offset: 0xF975C0 VA: 0x180F98FC0 Slot: 16
	public override Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0xF99060 Offset: 0xF97660 VA: 0x180F99060 Slot: 14
	public override Nullable<double> ReadAsDouble() { }

	// RVA: 0xF939A0 Offset: 0xF91FA0 VA: 0x180F939A0
	private void HandleNull() { }

	// RVA: 0xF99520 Offset: 0xF97B20 VA: 0x180F99520
	private void ReadFinished() { }

	// RVA: 0xF996B0 Offset: 0xF97CB0 VA: 0x180F996B0
	private bool ReadNullChar() { }

	// RVA: 0xF93890 Offset: 0xF91E90 VA: 0x180F93890
	private void EnsureBuffer() { }

	// RVA: 0xF99F20 Offset: 0xF98520 VA: 0x180F99F20
	private void ReadStringIntoBuffer(char quote) { }

	// RVA: 0xF9B380 Offset: 0xF99980 VA: 0x180F9B380
	private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition) { }

	// RVA: 0xF96F90 Offset: 0xF95590 VA: 0x180F96F90
	private char ParseUnicode() { }

	// RVA: 0xF99700 Offset: 0xF97D00 VA: 0x180F99700
	private void ReadNumberIntoBuffer() { }

	// RVA: 0xF934F0 Offset: 0xF91AF0 VA: 0x180F934F0
	private void ClearRecentString() { }

	// RVA: 0xF962B0 Offset: 0xF948B0 VA: 0x180F962B0
	private bool ParsePostValue() { }

	// RVA: 0xF960E0 Offset: 0xF946E0 VA: 0x180F960E0
	private bool ParseObject() { }

	// RVA: 0xF965F0 Offset: 0xF94BF0 VA: 0x180F965F0
	private bool ParseProperty() { }

	// RVA: 0xF9B310 Offset: 0xF99910 VA: 0x180F9B310
	private bool ValidIdentifierChar(char value) { }

	// RVA: 0xF97080 Offset: 0xF95680 VA: 0x180F97080
	private void ParseUnquotedProperty() { }

	// RVA: 0xF972D0 Offset: 0xF958D0 VA: 0x180F972D0
	private bool ParseValue() { }

	// RVA: 0xF97E40 Offset: 0xF96440 VA: 0x180F97E40
	private void ProcessLineFeed() { }

	// RVA: 0xF97D50 Offset: 0xF96350 VA: 0x180F97D50
	private void ProcessCarriageReturn(bool append) { }

	// RVA: 0xF93660 Offset: 0xF91C60 VA: 0x180F93660
	private bool EatWhitespace(bool oneOrMore) { }

	// RVA: 0xF94440 Offset: 0xF92A40 VA: 0x180F94440
	private void ParseConstructor() { }

	// RVA: 0xF950D0 Offset: 0xF936D0 VA: 0x180F950D0
	private void ParseNumber(ReadType readType) { }

	// RVA: 0xF94050 Offset: 0xF92650 VA: 0x180F94050
	private void ParseComment(bool setToken) { }

	// RVA: 0xF937B0 Offset: 0xF91DB0 VA: 0x180F937B0
	private void EndComment(bool setToken, int initialPosition, int endPosition) { }

	// RVA: 0xF93F30 Offset: 0xF92530 VA: 0x180F93F30
	private bool MatchValue(string value) { }

	// RVA: 0xF93C20 Offset: 0xF92220 VA: 0x180F93C20
	private bool MatchValueWithTrailingSeparator(string value) { }

	// RVA: 0xF93AD0 Offset: 0xF920D0 VA: 0x180F93AD0
	private bool IsSeparator(char c) { }

	// RVA: 0xF96D80 Offset: 0xF95380 VA: 0x180F96D80
	private void ParseTrue() { }

	// RVA: 0xF94950 Offset: 0xF92F50 VA: 0x180F94950
	private void ParseNull() { }

	// RVA: 0xF96E90 Offset: 0xF95490 VA: 0x180F96E90
	private void ParseUndefined() { }

	// RVA: 0xF94840 Offset: 0xF92E40 VA: 0x180F94840
	private void ParseFalse() { }

	// RVA: 0xF94C70 Offset: 0xF93270 VA: 0x180F94C70
	private object ParseNumberNegativeInfinity(ReadType readType) { }

	// RVA: 0xF94EA0 Offset: 0xF934A0 VA: 0x180F94EA0
	private object ParseNumberPositiveInfinity(ReadType readType) { }

	// RVA: 0xF94A40 Offset: 0xF93040 VA: 0x180F94A40
	private object ParseNumberNaN(ReadType readType) { }

	// RVA: 0xF93510 Offset: 0xF91B10 VA: 0x180F93510 Slot: 20
	public override void Close() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 21
	public bool HasLineInfo() { }

	// RVA: 0xF9B4B0 Offset: 0xF99AB0 VA: 0x180F9B4B0 Slot: 22
	public int get_LineNumber() { }

	// RVA: 0xF9B500 Offset: 0xF99B00 VA: 0x180F9B500 Slot: 23
	public int get_LinePosition() { }

}

public sealed class JsonPropertyAttribute : Attribute // TypeDefIndex: 5895
{	// Fields
	internal Nullable<NullValueHandling> _nullValueHandling; // 0x10
	internal Nullable<DefaultValueHandling> _defaultValueHandling; // 0x18
	internal Nullable<ReferenceLoopHandling> _referenceLoopHandling; // 0x20
	internal Nullable<ObjectCreationHandling> _objectCreationHandling; // 0x28
	internal Nullable<TypeNameHandling> _typeNameHandling; // 0x30
	internal Nullable<bool> _isReference; // 0x38
	internal Nullable<int> _order; // 0x3C
	internal Nullable<Required> _required; // 0x44
	internal Nullable<bool> _itemIsReference; // 0x4C
	internal Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling; // 0x50
	internal Nullable<TypeNameHandling> _itemTypeNameHandling; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Type <ItemConverterType>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object[] <ItemConverterParameters>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <PropertyName>k__BackingField; // 0x70

	// Properties
	public Type ItemConverterType { get; }
	public object[] ItemConverterParameters { get; }
	public string PropertyName { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public Type get_ItemConverterType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public object[] get_ItemConverterParameters() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	public string get_PropertyName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460
	public void set_PropertyName(string value) { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xF8BC20 Offset: 0xF8A220 VA: 0x180F8BC20
	public void .ctor(string propertyName) { }

}

public sealed class JsonIgnoreAttribute : Attribute // TypeDefIndex: 5896
{	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

}

public class JsonTextWriter : JsonWriter // TypeDefIndex: 5897
{	// Fields
	private readonly TextWriter _writer; // 0x60
	private Base64Encoder _base64Encoder; // 0x68
	private char _indentChar; // 0x70
	private int _indentation; // 0x74
	private char _quoteChar; // 0x78
	private bool _quoteName; // 0x7A
	private bool[] _charEscapeFlags; // 0x80
	private char[] _writeBuffer; // 0x88
	private IArrayPool<char> _arrayPool; // 0x90
	private char[] _indentChars; // 0x98

	// Properties
	private Base64Encoder Base64Encoder { get; }
	public char QuoteChar { get; }

	// Methods

	// RVA: 0xE47790 Offset: 0xE45D90 VA: 0x180E47790
	private Base64Encoder get_Base64Encoder() { }

	// RVA: 0xE47810 Offset: 0xE45E10 VA: 0x180E47810
	public char get_QuoteChar() { }

	// RVA: 0xE476B0 Offset: 0xE45CB0 VA: 0x180E476B0
	public void .ctor(TextWriter textWriter) { }

	// RVA: 0xE45A00 Offset: 0xE44000 VA: 0x180E45A00 Slot: 6
	public override void Close() { }

	// RVA: 0xE464B0 Offset: 0xE44AB0 VA: 0x180E464B0 Slot: 7
	public override void WriteStartObject() { }

	// RVA: 0xE463B0 Offset: 0xE449B0 VA: 0x180E463B0 Slot: 9
	public override void WriteStartArray() { }

	// RVA: 0xE46400 Offset: 0xE44A00 VA: 0x180E46400 Slot: 11
	public override void WriteStartConstructor(string name) { }

	// RVA: 0xE45C40 Offset: 0xE44240 VA: 0x180E45C40 Slot: 17
	protected override void WriteEnd(JsonToken token) { }

	// RVA: 0xE46310 Offset: 0xE44910 VA: 0x180E46310 Slot: 13
	public override void WritePropertyName(string name) { }

	// RVA: 0xE46220 Offset: 0xE44820 VA: 0x180E46220 Slot: 14
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0xE45B00 Offset: 0xE44100 VA: 0x180E45B00 Slot: 5
	internal override void OnStringEscapeHandlingChanged() { }

	// RVA: 0xE45B10 Offset: 0xE44110 VA: 0x180E45B10
	private void UpdateCharEscapeFlags() { }

	// RVA: 0xE45E50 Offset: 0xE44450 VA: 0x180E45E50 Slot: 18
	protected override void WriteIndent() { }

	// RVA: 0xE465A0 Offset: 0xE44BA0 VA: 0x180E465A0 Slot: 19
	protected override void WriteValueDelimiter() { }

	// RVA: 0xE45E20 Offset: 0xE44420 VA: 0x180E45E20 Slot: 20
	protected override void WriteIndentSpace() { }

	// RVA: 0xE46380 Offset: 0xE44980 VA: 0x180E46380
	private void WriteValueInternal(string value, JsonToken token) { }

	// RVA: 0xE3AC40 Offset: 0xE39240 VA: 0x180E3AC40 Slot: 62
	public override void WriteValue(object value) { }

	// RVA: 0xE46180 Offset: 0xE44780 VA: 0x180E46180 Slot: 21
	public override void WriteNull() { }

	// RVA: 0xE46500 Offset: 0xE44B00 VA: 0x180E46500 Slot: 22
	public override void WriteUndefined() { }

	// RVA: 0xE46380 Offset: 0xE44980 VA: 0x180E46380 Slot: 23
	public override void WriteRaw(string json) { }

	// RVA: 0xE47460 Offset: 0xE45A60 VA: 0x180E47460 Slot: 25
	public override void WriteValue(string value) { }

	// RVA: 0xE45D20 Offset: 0xE44320 VA: 0x180E45D20
	private void WriteEscapedString(string value, bool quote) { }

	// RVA: 0xE47420 Offset: 0xE45A20 VA: 0x180E47420 Slot: 26
	public override void WriteValue(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE47190 Offset: 0xE45790 VA: 0x180E47190 Slot: 27
	public override void WriteValue(uint value) { }

	// RVA: 0xE47360 Offset: 0xE45960 VA: 0x180E47360 Slot: 28
	public override void WriteValue(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE46850 Offset: 0xE44E50 VA: 0x180E46850 Slot: 29
	public override void WriteValue(ulong value) { }

	// RVA: 0xE46690 Offset: 0xE44C90 VA: 0x180E46690 Slot: 30
	public override void WriteValue(float value) { }

	// RVA: 0xE46760 Offset: 0xE44D60 VA: 0x180E46760 Slot: 47
	public override void WriteValue(Nullable<float> value) { }

	// RVA: 0xE46890 Offset: 0xE44E90 VA: 0x180E46890 Slot: 31
	public override void WriteValue(double value) { }

	// RVA: 0xE471D0 Offset: 0xE457D0 VA: 0x180E471D0 Slot: 48
	public override void WriteValue(Nullable<double> value) { }

	// RVA: 0xE472C0 Offset: 0xE458C0 VA: 0x180E472C0 Slot: 32
	public override void WriteValue(bool value) { }

	// RVA: 0xE46FC0 Offset: 0xE455C0 VA: 0x180E46FC0 Slot: 33
	public override void WriteValue(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE473A0 Offset: 0xE459A0 VA: 0x180E473A0 Slot: 34
	public override void WriteValue(ushort value) { }

	// RVA: 0xE470F0 Offset: 0xE456F0 VA: 0x180E470F0 Slot: 35
	public override void WriteValue(char value) { }

	// RVA: 0xE473E0 Offset: 0xE459E0 VA: 0x180E473E0 Slot: 36
	public override void WriteValue(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE47670 Offset: 0xE45C70 VA: 0x180E47670 Slot: 37
	public override void WriteValue(sbyte value) { }

	// RVA: 0xE47520 Offset: 0xE45B20 VA: 0x180E47520 Slot: 38
	public override void WriteValue(Decimal value) { }

	// RVA: 0xE46A40 Offset: 0xE45040 VA: 0x180E46A40 Slot: 39
	public override void WriteValue(DateTime value) { }

	// RVA: 0xE46960 Offset: 0xE44F60 VA: 0x180E46960 Slot: 60
	public override void WriteValue(byte[] value) { }

	// RVA: 0xE46D10 Offset: 0xE45310 VA: 0x180E46D10 Slot: 40
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0xE47000 Offset: 0xE45600 VA: 0x180E47000 Slot: 41
	public override void WriteValue(Guid value) { }

	// RVA: 0xE475D0 Offset: 0xE45BD0 VA: 0x180E475D0 Slot: 42
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0xE465D0 Offset: 0xE44BD0 VA: 0x180E465D0 Slot: 61
	public override void WriteValue(Uri value) { }

	// RVA: 0xE45B90 Offset: 0xE44190 VA: 0x180E45B90 Slot: 63
	public override void WriteComment(string text) { }

	// RVA: 0xE45AC0 Offset: 0xE440C0 VA: 0x180E45AC0
	private void EnsureWriteBuffer() { }

	// RVA: 0xE460F0 Offset: 0xE446F0 VA: 0x180E460F0
	private void WriteIntegerValue(long value) { }

	// RVA: 0xE45FB0 Offset: 0xE445B0 VA: 0x180E45FB0
	private void WriteIntegerValue(ulong uvalue) { }

}

public class JsonWriterException : JsonException // TypeDefIndex: 5898
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Path>k__BackingField; // 0x88

	// Properties
	private string Path { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	private void set_Path(string value) { }

	// RVA: 0xE47A80 Offset: 0xE46080 VA: 0x180E47A80
	public void .ctor() { }

	// RVA: 0xE47A60 Offset: 0xE46060 VA: 0x180E47A60
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE47A20 Offset: 0xE46020 VA: 0x180E47A20
	internal void .ctor(string message, Exception innerException, string path) { }

	// RVA: 0xE47820 Offset: 0xE45E20 VA: 0x180E47820
	internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex) { }

	// RVA: 0xE47960 Offset: 0xE45F60 VA: 0x180E47960
	internal static JsonWriterException Create(string path, string message, Exception ex) { }

}

public class JsonReaderException : JsonException // TypeDefIndex: 5899
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <LineNumber>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <LinePosition>k__BackingField; // 0x8C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Path>k__BackingField; // 0x90

	// Properties
	private int LineNumber { set; }
	private int LinePosition { set; }
	private string Path { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8C000 Offset: 0xF8A600 VA: 0x180F8C000
	private void set_LineNumber(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8C010 Offset: 0xF8A610 VA: 0x180F8C010
	private void set_LinePosition(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E4060 Offset: 0x4E2660 VA: 0x1804E4060
	private void set_Path(string value) { }

	// RVA: 0xF8B240 Offset: 0xF89840 VA: 0x180F8B240
	public void .ctor() { }

	// RVA: 0xF8B1C0 Offset: 0xF897C0 VA: 0x180F8B1C0
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF8BF50 Offset: 0xF8A550 VA: 0x180F8BF50
	internal void .ctor(string message, Exception innerException, string path, int lineNumber, int linePosition) { }

	// RVA: 0xF8BC50 Offset: 0xF8A250 VA: 0x180F8BC50
	internal static JsonReaderException Create(JsonReader reader, string message) { }

	// RVA: 0xF8BC60 Offset: 0xF8A260 VA: 0x180F8BC60
	internal static JsonReaderException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0xF8BE00 Offset: 0xF8A400 VA: 0x180F8BE00
	internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }

}

public abstract class JsonConverter // TypeDefIndex: 5900
{	// Properties
	public virtual bool CanRead { get; }
	public virtual bool CanWrite { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool CanConvert(Type objectType);

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 7
	public virtual bool get_CanRead() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 8
	public virtual bool get_CanWrite() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

public class JsonConverterCollection : Collection<JsonConverter> // TypeDefIndex: 5901
{	// Methods

	// RVA: 0xF8B180 Offset: 0xF89780 VA: 0x180F8B180
	public void .ctor() { }

}

public abstract class JsonReader : IDisposable // TypeDefIndex: 5902
{	// Fields
	private JsonToken _tokenType; // 0x10
	private object _value; // 0x18
	internal char _quoteChar; // 0x20
	internal JsonReader.State _currentState; // 0x24
	private JsonPosition _currentPosition; // 0x28
	private CultureInfo _culture; // 0x40
	private DateTimeZoneHandling _dateTimeZoneHandling; // 0x48
	private Nullable<int> _maxDepth; // 0x4C
	private bool _hasExceededMaxDepth; // 0x54
	internal DateParseHandling _dateParseHandling; // 0x58
	internal FloatParseHandling _floatParseHandling; // 0x5C
	private string _dateFormatString; // 0x60
	private List<JsonPosition> _stack; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <CloseInput>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <SupportMultipleContent>k__BackingField; // 0x71

	// Properties
	protected JsonReader.State CurrentState { get; }
	public bool CloseInput { get; set; }
	public bool SupportMultipleContent { get; set; }
	public DateTimeZoneHandling DateTimeZoneHandling { get; set; }
	public DateParseHandling DateParseHandling { get; set; }
	public FloatParseHandling FloatParseHandling { get; set; }
	public string DateFormatString { get; set; }
	public Nullable<int> MaxDepth { get; set; }
	public virtual JsonToken TokenType { get; }
	public virtual object Value { get; }
	public virtual Type ValueType { get; }
	public virtual int Depth { get; }
	public virtual string Path { get; }
	public CultureInfo Culture { get; set; }

	// Methods

	// RVA: 0x7D0C00 Offset: 0x7CF200 VA: 0x1807D0C00
	protected JsonReader.State get_CurrentState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC312F0 Offset: 0xC2F8F0 VA: 0x180C312F0
	public bool get_CloseInput() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC32410 Offset: 0xC30A10 VA: 0x180C32410
	public void set_CloseInput(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE75840 Offset: 0xE73E40 VA: 0x180E75840
	public bool get_SupportMultipleContent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE75870 Offset: 0xE73E70 VA: 0x180E75870
	public void set_SupportMultipleContent(bool value) { }

	// RVA: 0x598420 Offset: 0x596A20 VA: 0x180598420
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0xF90010 Offset: 0xF8E610 VA: 0x180F90010
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0xAE97E0 Offset: 0xAE7DE0 VA: 0x180AE97E0
	public DateParseHandling get_DateParseHandling() { }

	// RVA: 0xF8FFA0 Offset: 0xF8E5A0 VA: 0x180F8FFA0
	public void set_DateParseHandling(DateParseHandling value) { }

	// RVA: 0x5743A0 Offset: 0x5729A0 VA: 0x1805743A0
	public FloatParseHandling get_FloatParseHandling() { }

	// RVA: 0xF90080 Offset: 0xF8E680 VA: 0x180F90080
	public void set_FloatParseHandling(FloatParseHandling value) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public string get_DateFormatString() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	public void set_DateFormatString(string value) { }

	// RVA: 0xF8FE70 Offset: 0xF8E470 VA: 0x180F8FE70
	public Nullable<int> get_MaxDepth() { }

	// RVA: 0xF900F0 Offset: 0xF8E6F0 VA: 0x180F900F0
	public void set_MaxDepth(Nullable<int> value) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 5
	public virtual JsonToken get_TokenType() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	public virtual object get_Value() { }

	// RVA: 0xF8FF80 Offset: 0xF8E580 VA: 0x180F8FF80 Slot: 7
	public virtual Type get_ValueType() { }

	// RVA: 0xF8FE00 Offset: 0xF8E400 VA: 0x180F8FE00 Slot: 8
	public virtual int get_Depth() { }

	// RVA: 0xF8FE80 Offset: 0xF8E480 VA: 0x180F8FE80 Slot: 9
	public virtual string get_Path() { }

	// RVA: 0xF8FDA0 Offset: 0xF8E3A0 VA: 0x180F8FDA0
	public CultureInfo get_Culture() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	public void set_Culture(CultureInfo value) { }

	// RVA: 0xF8C130 Offset: 0xF8A730 VA: 0x180F8C130
	internal JsonPosition GetPosition(int depth) { }

	// RVA: 0xF8FD70 Offset: 0xF8E370 VA: 0x180F8FD70
	protected void .ctor() { }

	// RVA: 0xF8C420 Offset: 0xF8AA20 VA: 0x180F8C420
	private void Push(JsonContainerType value) { }

	// RVA: 0xF8C320 Offset: 0xF8A920 VA: 0x180F8C320
	private JsonContainerType Pop() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	private JsonContainerType Peek() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool Read();

	// RVA: 0xF8DD60 Offset: 0xF8C360 VA: 0x180F8DD60 Slot: 11
	public virtual Nullable<int> ReadAsInt32() { }

	// RVA: 0xF8F190 Offset: 0xF8D790 VA: 0x180F8F190
	internal Nullable<int> ReadInt32String(string s) { }

	// RVA: 0xF8E040 Offset: 0xF8C640 VA: 0x180F8E040 Slot: 12
	public virtual string ReadAsString() { }

	// RVA: 0xF8CD20 Offset: 0xF8B320 VA: 0x180F8CD20 Slot: 13
	public virtual byte[] ReadAsBytes() { }

	// RVA: 0xF8C7C0 Offset: 0xF8ADC0 VA: 0x180F8C7C0
	internal byte[] ReadArrayIntoByteArray() { }

	// RVA: 0xF8DA90 Offset: 0xF8C090 VA: 0x180F8DA90 Slot: 14
	public virtual Nullable<double> ReadAsDouble() { }

	// RVA: 0xF8EF40 Offset: 0xF8D540 VA: 0x180F8EF40
	internal Nullable<double> ReadDoubleString(string s) { }

	// RVA: 0xF8CA30 Offset: 0xF8B030 VA: 0x180F8CA30 Slot: 15
	public virtual Nullable<bool> ReadAsBoolean() { }

	// RVA: 0xF8E460 Offset: 0xF8CA60 VA: 0x180F8E460
	internal Nullable<bool> ReadBooleanString(string s) { }

	// RVA: 0xF8D790 Offset: 0xF8BD90 VA: 0x180F8D790 Slot: 16
	public virtual Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0xF8ECC0 Offset: 0xF8D2C0 VA: 0x180F8ECC0
	internal Nullable<Decimal> ReadDecimalString(string s) { }

	// RVA: 0xF8D4C0 Offset: 0xF8BAC0 VA: 0x180F8D4C0 Slot: 17
	public virtual Nullable<DateTime> ReadAsDateTime() { }

	// RVA: 0xF8E9C0 Offset: 0xF8CFC0 VA: 0x180F8E9C0
	internal Nullable<DateTime> ReadDateTimeString(string s) { }

	// RVA: 0xF8D1C0 Offset: 0xF8B7C0 VA: 0x180F8D1C0 Slot: 18
	public virtual Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0xF8E650 Offset: 0xF8CC50 VA: 0x180F8E650
	internal Nullable<DateTimeOffset> ReadDateTimeOffsetString(string s) { }

	// RVA: 0xF8F5F0 Offset: 0xF8DBF0 VA: 0x180F8F5F0
	internal void ReaderReadAndAssert() { }

	// RVA: 0xF8C040 Offset: 0xF8A640 VA: 0x180F8C040
	internal JsonReaderException CreateUnexpectedEndException() { }

	// RVA: 0xF8F3A0 Offset: 0xF8D9A0 VA: 0x180F8F3A0
	internal void ReadIntoWrappedTypeObject() { }

	// RVA: 0xF8F9B0 Offset: 0xF8DFB0 VA: 0x180F8F9B0
	public void Skip() { }

	// RVA: 0xF8F990 Offset: 0xF8DF90 VA: 0x180F8F990
	protected void SetToken(JsonToken newToken) { }

	// RVA: 0xF8F970 Offset: 0xF8DF70 VA: 0x180F8F970
	protected void SetToken(JsonToken newToken, object value) { }

	// RVA: 0xF8F7B0 Offset: 0xF8DDB0 VA: 0x180F8F7B0
	internal void SetToken(JsonToken newToken, object value, bool updateIndex) { }

	// RVA: 0xF8F670 Offset: 0xF8DC70 VA: 0x180F8F670
	internal void SetPostValueState(bool updateIndex) { }

	// RVA: 0xF8FAD0 Offset: 0xF8E0D0 VA: 0x180F8FAD0
	private void UpdateScopeWithFinishedValue() { }

	// RVA: 0xF8FAE0 Offset: 0xF8E0E0 VA: 0x180F8FAE0
	private void ValidateEnd(JsonToken endToken) { }

	// RVA: 0xF8F6A0 Offset: 0xF8DCA0 VA: 0x180F8F6A0
	protected void SetStateBasedOnCurrent() { }

	// RVA: 0xF8F650 Offset: 0xF8DC50 VA: 0x180F8F650
	private void SetFinished() { }

	// RVA: 0xF8C1D0 Offset: 0xF8A7D0 VA: 0x180F8C1D0
	private JsonContainerType GetTypeForCloseToken(JsonToken token) { }

	// RVA: 0xF8FA60 Offset: 0xF8E060 VA: 0x180F8FA60 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0xF8C080 Offset: 0xF8A680 VA: 0x180F8C080 Slot: 19
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xF8C020 Offset: 0xF8A620 VA: 0x180F8C020 Slot: 20
	public virtual void Close() { }

	// RVA: 0xF8C6F0 Offset: 0xF8ACF0 VA: 0x180F8C6F0
	internal void ReadAndAssert() { }

	// RVA: 0xF8C760 Offset: 0xF8AD60 VA: 0x180F8C760
	internal bool ReadAndMoveToContent() { }

	// RVA: 0xF8C2C0 Offset: 0xF8A8C0 VA: 0x180F8C2C0
	internal bool MoveToContent() { }

	// RVA: 0xF8C0B0 Offset: 0xF8A6B0 VA: 0x180F8C0B0
	private JsonToken GetContentToken() { }

}

public static class JsonConvert // TypeDefIndex: 5904
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Func<JsonSerializerSettings> <DefaultSettings>k__BackingField; // 0x0
	public static readonly string True; // 0x8
	public static readonly string False; // 0x10
	public static readonly string Null; // 0x18
	public static readonly string Undefined; // 0x20
	public static readonly string PositiveInfinity; // 0x28
	public static readonly string NegativeInfinity; // 0x30
	public static readonly string NaN; // 0x38
	private static readonly JsonSerializerSettings InitialSerializerSettings; // 0x40

	// Properties
	public static Func<JsonSerializerSettings> DefaultSettings { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8B030 Offset: 0xF89630 VA: 0x180F8B030
	public static Func<JsonSerializerSettings> get_DefaultSettings() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8B090 Offset: 0xF89690 VA: 0x180F8B090
	public static void set_DefaultSettings(Func<JsonSerializerSettings> value) { }

	// RVA: 0xF8AD30 Offset: 0xF89330 VA: 0x180F8AD30
	private static void .cctor() { }

	// RVA: 0xF89F70 Offset: 0xF88570 VA: 0x180F89F70
	internal static JsonSerializerSettings GetDefaultSettings() { }

	// RVA: 0xF8AAD0 Offset: 0xF890D0 VA: 0x180F8AAD0
	public static string ToString(bool value) { }

	// RVA: 0xF8A6B0 Offset: 0xF88CB0 VA: 0x180F8A6B0
	public static string ToString(char value) { }

	// RVA: 0xF8A800 Offset: 0xF88E00 VA: 0x180F8A800
	internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0xF89E10 Offset: 0xF88410 VA: 0x180F89E10
	private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0xF8AC30 Offset: 0xF89230 VA: 0x180F8AC30
	internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0xF89D10 Offset: 0xF88310 VA: 0x180F89D10
	private static string EnsureDecimalPlace(double value, string text) { }

	// RVA: 0xF89CA0 Offset: 0xF882A0 VA: 0x180F89CA0
	private static string EnsureDecimalPlace(string text) { }

	// RVA: 0xF8A900 Offset: 0xF88F00 VA: 0x180F8A900
	public static string ToString(Decimal value) { }

	// RVA: 0xF8A5D0 Offset: 0xF88BD0 VA: 0x180F8A5D0
	public static string ToString(string value) { }

	// RVA: 0xF8A9E0 Offset: 0xF88FE0 VA: 0x180F8A9E0
	public static string ToString(string value, char delimiter) { }

	// RVA: 0xF8AB70 Offset: 0xF89170 VA: 0x180F8AB70
	public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0xF8A250 Offset: 0xF88850 VA: 0x180F8A250
	public static string SerializeObject(object value) { }

	// RVA: 0xF8A4C0 Offset: 0xF88AC0 VA: 0x180F8A4C0
	public static string SerializeObject(object value, Formatting formatting) { }

	// RVA: 0xF8A1B0 Offset: 0xF887B0 VA: 0x180F8A1B0
	public static string SerializeObject(object value, Type type, JsonSerializerSettings settings) { }

	// RVA: 0xF8A300 Offset: 0xF88900 VA: 0x180F8A300
	public static string SerializeObject(object value, Formatting formatting, JsonSerializerSettings settings) { }

	// RVA: 0xF8A3F0 Offset: 0xF889F0 VA: 0x180F8A3F0
	public static string SerializeObject(object value, Type type, Formatting formatting, JsonSerializerSettings settings) { }

	// RVA: 0xF89FD0 Offset: 0xF885D0 VA: 0x180F89FD0
	private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer) { }

	// RVA: 0xF89C30 Offset: 0xF88230 VA: 0x180F89C30
	public static object DeserializeObject(string value, Type type) { }

	// RVA: -1 Offset: -1
	public static T DeserializeObject<T>(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CFC90 Offset: 0x5CE290 VA: 0x1805CFC90
	|-JsonConvert.DeserializeObject<CameraMan.CameraState>
	|
	|-RVA: 0x5D0210 Offset: 0x5CE810 VA: 0x1805D0210
	|-JsonConvert.DeserializeObject<ClientFrametimeRequest>
	|-JsonConvert.DeserializeObject<CompanionSubscription.Status>
	|-JsonConvert.DeserializeObject<Account.AccountJson>
	|-JsonConvert.DeserializeObject<BuildInfo>
	|-JsonConvert.DeserializeObject<AddResponse>
	|-JsonConvert.DeserializeObject<BaseResponse>
	|-JsonConvert.DeserializeObject<QueryResponse[]>
	|-JsonConvert.DeserializeObject<Entry[]>
	|-JsonConvert.DeserializeObject<Rank>
	|-JsonConvert.DeserializeObject<Manifest>
	|-JsonConvert.DeserializeObject<SteamInventoryCrafting.MarketPrice>
	|-JsonConvert.DeserializeObject<Skin.Manifest>
	|-JsonConvert.DeserializeObject<Dictionary<string, CameraMan.CameraState>>
	|-JsonConvert.DeserializeObject<Dictionary<string, int>>
	|-JsonConvert.DeserializeObject<Dictionary<string, string>>
	|-JsonConvert.DeserializeObject<Dictionary<ulong, Chat.MuteEntry>>
	|-JsonConvert.DeserializeObject<List<Admin.PlayerInfo>>
	|-JsonConvert.DeserializeObject<List<Admin.ServerConvarInfo>>
	|-JsonConvert.DeserializeObject<List<Admin.ServerUGCInfo>>
	|-JsonConvert.DeserializeObject<Telephone.CensoredNumbers>
	|-JsonConvert.DeserializeObject<object>
	|
	|-RVA: 0x5D0050 Offset: 0x5CE650 VA: 0x1805D0050
	|-JsonConvert.DeserializeObject<NoticeData>
	|
	|-RVA: 0x5CFE40 Offset: 0x5CE440 VA: 0x1805CFE40
	|-JsonConvert.DeserializeObject<RCon.Command>
	|
	|-RVA: 0x5CFEE0 Offset: 0x5CE4E0 VA: 0x1805CFEE0
	|-JsonConvert.DeserializeObject<CorePropsFile>
	*/

	// RVA: -1 Offset: -1
	public static T DeserializeObject<T>(string value, JsonSerializerSettings settings) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CFB70 Offset: 0x5CE170 VA: 0x1805CFB70
	|-JsonConvert.DeserializeObject<CameraMan.CameraState>
	|
	|-RVA: 0x5D00F0 Offset: 0x5CE6F0 VA: 0x1805D00F0
	|-JsonConvert.DeserializeObject<NoticeData>
	|
	|-RVA: 0x5CFD20 Offset: 0x5CE320 VA: 0x1805CFD20
	|-JsonConvert.DeserializeObject<RCon.Command>
	|
	|-RVA: 0x5CFF50 Offset: 0x5CE550 VA: 0x1805CFF50
	|-JsonConvert.DeserializeObject<CorePropsFile>
	|
	|-RVA: 0x5D0280 Offset: 0x5CE880 VA: 0x1805D0280
	|-JsonConvert.DeserializeObject<object>
	*/

	// RVA: 0xF89A10 Offset: 0xF88010 VA: 0x180F89A10
	public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings) { }

}

public class JsonSerializationException : JsonException // TypeDefIndex: 5905
{	// Methods

	// RVA: 0xF8B240 Offset: 0xF89840 VA: 0x180F8B240
	public void .ctor() { }

	// RVA: 0xF8B320 Offset: 0xF89920 VA: 0x180F8B320
	public void .ctor(string message) { }

	// RVA: 0xF8B2A0 Offset: 0xF898A0 VA: 0x180F8B2A0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0xF8B1C0 Offset: 0xF897C0 VA: 0x180F8B1C0
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF90260 Offset: 0xF8E860 VA: 0x180F90260
	internal static JsonSerializationException Create(JsonReader reader, string message) { }

	// RVA: 0xF90270 Offset: 0xF8E870 VA: 0x180F90270
	internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0xF90180 Offset: 0xF8E780 VA: 0x180F90180
	internal static JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }

}

public class JsonSerializer // TypeDefIndex: 5906
{	// Fields
	internal TypeNameHandling _typeNameHandling; // 0x10
	internal FormatterAssemblyStyle _typeNameAssemblyFormat; // 0x14
	internal PreserveReferencesHandling _preserveReferencesHandling; // 0x18
	internal ReferenceLoopHandling _referenceLoopHandling; // 0x1C
	internal MissingMemberHandling _missingMemberHandling; // 0x20
	internal ObjectCreationHandling _objectCreationHandling; // 0x24
	internal NullValueHandling _nullValueHandling; // 0x28
	internal DefaultValueHandling _defaultValueHandling; // 0x2C
	internal ConstructorHandling _constructorHandling; // 0x30
	internal MetadataPropertyHandling _metadataPropertyHandling; // 0x34
	internal JsonConverterCollection _converters; // 0x38
	internal IContractResolver _contractResolver; // 0x40
	internal ITraceWriter _traceWriter; // 0x48
	internal IEqualityComparer _equalityComparer; // 0x50
	internal SerializationBinder _binder; // 0x58
	internal StreamingContext _context; // 0x60
	private IReferenceResolver _referenceResolver; // 0x70
	private Nullable<Formatting> _formatting; // 0x78
	private Nullable<DateFormatHandling> _dateFormatHandling; // 0x80
	private Nullable<DateTimeZoneHandling> _dateTimeZoneHandling; // 0x88
	private Nullable<DateParseHandling> _dateParseHandling; // 0x90
	private Nullable<FloatFormatHandling> _floatFormatHandling; // 0x98
	private Nullable<FloatParseHandling> _floatParseHandling; // 0xA0
	private Nullable<StringEscapeHandling> _stringEscapeHandling; // 0xA8
	private CultureInfo _culture; // 0xB0
	private Nullable<int> _maxDepth; // 0xB8
	private bool _maxDepthSet; // 0xC0
	private Nullable<bool> _checkAdditionalContent; // 0xC1
	private string _dateFormatString; // 0xC8
	private bool _dateFormatStringSet; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventHandler<ErrorEventArgs> Error; // 0xD8

	// Properties
	public virtual IReferenceResolver ReferenceResolver { set; }
	public virtual SerializationBinder Binder { set; }
	public virtual ITraceWriter TraceWriter { get; set; }
	public virtual IEqualityComparer EqualityComparer { set; }
	public virtual TypeNameHandling TypeNameHandling { set; }
	public virtual FormatterAssemblyStyle TypeNameAssemblyFormat { set; }
	public virtual PreserveReferencesHandling PreserveReferencesHandling { set; }
	public virtual ReferenceLoopHandling ReferenceLoopHandling { set; }
	public virtual MissingMemberHandling MissingMemberHandling { set; }
	public virtual NullValueHandling NullValueHandling { set; }
	public virtual DefaultValueHandling DefaultValueHandling { set; }
	public virtual ObjectCreationHandling ObjectCreationHandling { get; set; }
	public virtual ConstructorHandling ConstructorHandling { set; }
	public virtual MetadataPropertyHandling MetadataPropertyHandling { get; set; }
	public virtual JsonConverterCollection Converters { get; }
	public virtual IContractResolver ContractResolver { get; set; }
	public virtual StreamingContext Context { get; set; }
	public virtual Formatting Formatting { get; set; }
	public virtual bool CheckAdditionalContent { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF92B70 Offset: 0xF91170 VA: 0x180F92B70 Slot: 4
	public virtual void add_Error(EventHandler<ErrorEventArgs> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF92D20 Offset: 0xF91320 VA: 0x180F92D20 Slot: 5
	public virtual void remove_Error(EventHandler<ErrorEventArgs> value) { }

	// RVA: 0xF93380 Offset: 0xF91980 VA: 0x180F93380 Slot: 6
	public virtual void set_ReferenceResolver(IReferenceResolver value) { }

	// RVA: 0xF92DC0 Offset: 0xF913C0 VA: 0x180F92DC0 Slot: 7
	public virtual void set_Binder(SerializationBinder value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 8
	public virtual ITraceWriter get_TraceWriter() { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810 Slot: 9
	public virtual void set_TraceWriter(ITraceWriter value) { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890 Slot: 10
	public virtual void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0xF93480 Offset: 0xF91A80 VA: 0x180F93480 Slot: 11
	public virtual void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0xF93410 Offset: 0xF91A10 VA: 0x180F93410 Slot: 12
	public virtual void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	// RVA: 0xF932A0 Offset: 0xF918A0 VA: 0x180F932A0 Slot: 13
	public virtual void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0xF93310 Offset: 0xF91910 VA: 0x180F93310 Slot: 14
	public virtual void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0xF93150 Offset: 0xF91750 VA: 0x180F93150 Slot: 15
	public virtual void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0xF931C0 Offset: 0xF917C0 VA: 0x180F931C0 Slot: 16
	public virtual void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0xF93010 Offset: 0xF91610 VA: 0x180F93010 Slot: 17
	public virtual void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0x7D0C00 Offset: 0x7CF200 VA: 0x1807D0C00 Slot: 18
	public virtual ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0xF93230 Offset: 0xF91830 VA: 0x180F93230 Slot: 19
	public virtual void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0xF92EB0 Offset: 0xF914B0 VA: 0x180F92EB0 Slot: 20
	public virtual void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40 Slot: 21
	public virtual MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0xF930E0 Offset: 0xF916E0 VA: 0x180F930E0 Slot: 22
	public virtual void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0xF92C50 Offset: 0xF91250 VA: 0x180F92C50 Slot: 23
	public virtual JsonConverterCollection get_Converters() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0 Slot: 24
	public virtual IContractResolver get_ContractResolver() { }

	// RVA: 0xF92F40 Offset: 0xF91540 VA: 0x180F92F40 Slot: 25
	public virtual void set_ContractResolver(IContractResolver value) { }

	// RVA: 0xC31E40 Offset: 0xC30440 VA: 0x180C31E40 Slot: 26
	public virtual StreamingContext get_Context() { }

	// RVA: 0xF92F20 Offset: 0xF91520 VA: 0x180F92F20 Slot: 27
	public virtual void set_Context(StreamingContext value) { }

	// RVA: 0xF92CE0 Offset: 0xF912E0 VA: 0x180F92CE0 Slot: 28
	public virtual Formatting get_Formatting() { }

	// RVA: 0xF93080 Offset: 0xF91680 VA: 0x180F93080 Slot: 29
	public virtual void set_Formatting(Formatting value) { }

	// RVA: 0xF92C10 Offset: 0xF91210 VA: 0x180F92C10 Slot: 30
	public virtual bool get_CheckAdditionalContent() { }

	// RVA: 0xF92E50 Offset: 0xF91450 VA: 0x180F92E50 Slot: 31
	public virtual void set_CheckAdditionalContent(bool value) { }

	// RVA: 0xF91C10 Offset: 0xF90210 VA: 0x180F91C10
	internal bool IsCheckAdditionalContentSet() { }

	// RVA: 0xF92A00 Offset: 0xF91000 VA: 0x180F92A00
	public void .ctor() { }

	// RVA: 0xF91350 Offset: 0xF8F950 VA: 0x180F91350
	public static JsonSerializer Create() { }

	// RVA: 0xF914F0 Offset: 0xF8FAF0 VA: 0x180F914F0
	public static JsonSerializer Create(JsonSerializerSettings settings) { }

	// RVA: 0xF910B0 Offset: 0xF8F6B0 VA: 0x180F910B0
	public static JsonSerializer CreateDefault() { }

	// RVA: 0xF91310 Offset: 0xF8F910 VA: 0x180F91310
	public static JsonSerializer CreateDefault(JsonSerializerSettings settings) { }

	// RVA: 0xF908B0 Offset: 0xF8EEB0 VA: 0x180F908B0
	private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings) { }

	// RVA: 0xF91FE0 Offset: 0xF905E0 VA: 0x180F91FE0
	public void Populate(JsonReader reader, object target) { }

	// RVA: 0xF91CB0 Offset: 0xF902B0 VA: 0x180F91CB0 Slot: 32
	internal virtual void PopulateInternal(JsonReader reader, object target) { }

	// RVA: -1 Offset: -1
	public T Deserialize<T>(JsonReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0B40 Offset: 0x5CF140 VA: 0x1805D0B40
	|-JsonSerializer.Deserialize<Int32Enum>
	|-JsonSerializer.Deserialize<RegexOptions>
	|
	|-RVA: 0x5D0C20 Offset: 0x5CF220 VA: 0x1805D0C20
	|-JsonSerializer.Deserialize<object>
	*/

	// RVA: 0xF91A00 Offset: 0xF90000 VA: 0x180F91A00
	public object Deserialize(JsonReader reader, Type objectType) { }

	// RVA: 0xF916B0 Offset: 0xF8FCB0 VA: 0x180F916B0 Slot: 33
	internal virtual object DeserializeInternal(JsonReader reader, Type objectType) { }

	// RVA: 0xF92650 Offset: 0xF90C50 VA: 0x180F92650
	private void SetupReader(JsonReader reader, out CultureInfo previousCulture, out Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, out Nullable<DateParseHandling> previousDateParseHandling, out Nullable<FloatParseHandling> previousFloatParseHandling, out Nullable<int> previousMaxDepth, out string previousDateFormatString) { }

	// RVA: 0xF92000 Offset: 0xF90600 VA: 0x180F92000
	private void ResetReader(JsonReader reader, CultureInfo previousCulture, Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, Nullable<DateParseHandling> previousDateParseHandling, Nullable<FloatParseHandling> previousFloatParseHandling, Nullable<int> previousMaxDepth, string previousDateFormatString) { }

	// RVA: 0xF92630 Offset: 0xF90C30 VA: 0x180F92630
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0xF92600 Offset: 0xF90C00 VA: 0x180F92600
	public void Serialize(JsonWriter jsonWriter, object value) { }

	// RVA: 0xF92170 Offset: 0xF90770 VA: 0x180F92170 Slot: 34
	internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0xF91BA0 Offset: 0xF901A0 VA: 0x180F91BA0
	internal IReferenceResolver GetReferenceResolver() { }

	// RVA: 0xF91A20 Offset: 0xF90020 VA: 0x180F91A20
	internal JsonConverter GetMatchingConverter(Type type) { }

	// RVA: 0xF91AE0 Offset: 0xF900E0 VA: 0x180F91AE0
	internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType) { }

	// RVA: 0xF91C50 Offset: 0xF90250 VA: 0x180F91C50
	internal void OnError(ErrorEventArgs e) { }

}

public enum JsonToken // TypeDefIndex: 5911
{	// Fields
	public int value__; // 0x0
	public const JsonToken None = 0;
	public const JsonToken StartObject = 1;
	public const JsonToken StartArray = 2;
	public const JsonToken StartConstructor = 3;
	public const JsonToken PropertyName = 4;
	public const JsonToken Comment = 5;
	public const JsonToken Raw = 6;
	public const JsonToken Integer = 7;
	public const JsonToken Float = 8;
	public const JsonToken String = 9;
	public const JsonToken Boolean = 10;
	public const JsonToken Null = 11;
	public const JsonToken Undefined = 12;
	public const JsonToken EndObject = 13;
	public const JsonToken EndArray = 14;
	public const JsonToken EndConstructor = 15;
	public const JsonToken Date = 16;
	public const JsonToken Bytes = 17;

}

public abstract class JsonWriter : IDisposable // TypeDefIndex: 5912
{	// Fields
	private static readonly JsonWriter.State[][] StateArray; // 0x0
	internal static readonly JsonWriter.State[][] StateArrayTempate; // 0x8
	private List<JsonPosition> _stack; // 0x10
	private JsonPosition _currentPosition; // 0x18
	private JsonWriter.State _currentState; // 0x30
	private Formatting _formatting; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <CloseOutput>k__BackingField; // 0x38
	private DateFormatHandling _dateFormatHandling; // 0x3C
	private DateTimeZoneHandling _dateTimeZoneHandling; // 0x40
	private StringEscapeHandling _stringEscapeHandling; // 0x44
	private FloatFormatHandling _floatFormatHandling; // 0x48
	private string _dateFormatString; // 0x50
	private CultureInfo _culture; // 0x58

	// Properties
	public bool CloseOutput { get; set; }
	protected internal int Top { get; }
	public WriteState WriteState { get; }
	internal string ContainerPath { get; }
	public string Path { get; }
	public Formatting Formatting { get; set; }
	public DateFormatHandling DateFormatHandling { get; set; }
	public DateTimeZoneHandling DateTimeZoneHandling { get; set; }
	public StringEscapeHandling StringEscapeHandling { get; set; }
	public FloatFormatHandling FloatFormatHandling { get; set; }
	public string DateFormatString { get; set; }
	public CultureInfo Culture { get; set; }

	// Methods

	// RVA: 0xE48080 Offset: 0xE46680 VA: 0x180E48080
	internal static JsonWriter.State[][] BuildStateArray() { }

	// RVA: 0xE4B4E0 Offset: 0xE49AE0 VA: 0x180E4B4E0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1040 Offset: 0x8BF640 VA: 0x1808C1040
	public bool get_CloseOutput() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x78E170 Offset: 0x78C770 VA: 0x18078E170
	public void set_CloseOutput(bool value) { }

	// RVA: 0xE4C4C0 Offset: 0xE4AAC0 VA: 0x180E4C4C0
	protected internal int get_Top() { }

	// RVA: 0xE4C520 Offset: 0xE4AB20 VA: 0x180E4C520
	public WriteState get_WriteState() { }

	// RVA: 0xE4C2D0 Offset: 0xE4A8D0 VA: 0x180E4C2D0
	internal string get_ContainerPath() { }

	// RVA: 0xE4C3C0 Offset: 0xE4A9C0 VA: 0x180E4C3C0
	public string get_Path() { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40
	public Formatting get_Formatting() { }

	// RVA: 0xE4C780 Offset: 0xE4AD80 VA: 0x180E4C780
	public void set_Formatting(Formatting value) { }

	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50
	public DateFormatHandling get_DateFormatHandling() { }

	// RVA: 0xE4C630 Offset: 0xE4AC30 VA: 0x180E4C630
	public void set_DateFormatHandling(DateFormatHandling value) { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0xE4C6A0 Offset: 0xE4ACA0 VA: 0x180E4C6A0
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0x5DE450 Offset: 0x5DCA50 VA: 0x1805DE450
	public StringEscapeHandling get_StringEscapeHandling() { }

	// RVA: 0xE4C7F0 Offset: 0xE4ADF0 VA: 0x180E4C7F0
	public void set_StringEscapeHandling(StringEscapeHandling value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	internal virtual void OnStringEscapeHandlingChanged() { }

	// RVA: 0x598420 Offset: 0x596A20 VA: 0x180598420
	public FloatFormatHandling get_FloatFormatHandling() { }

	// RVA: 0xE4C710 Offset: 0xE4AD10 VA: 0x180E4C710
	public void set_FloatFormatHandling(FloatFormatHandling value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public string get_DateFormatString() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	public void set_DateFormatString(string value) { }

	// RVA: 0xE4C360 Offset: 0xE4A960 VA: 0x180E4C360
	public CultureInfo get_Culture() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	public void set_Culture(CultureInfo value) { }

	// RVA: 0xE4C2A0 Offset: 0xE4A8A0 VA: 0x180E4C2A0
	protected void .ctor() { }

	// RVA: 0xE48960 Offset: 0xE46F60 VA: 0x180E48960
	internal void UpdateScopeWithFinishedValue() { }

	// RVA: 0xE487F0 Offset: 0xE46DF0 VA: 0x180E487F0
	private void Push(JsonContainerType value) { }

	// RVA: 0xE48700 Offset: 0xE46D00 VA: 0x180E48700
	private JsonContainerType Pop() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	private JsonContainerType Peek() { }

	// RVA: 0xE39BA0 Offset: 0xE381A0 VA: 0x180E39BA0 Slot: 6
	public virtual void Close() { }

	// RVA: 0xE48E60 Offset: 0xE47460 VA: 0x180E48E60 Slot: 7
	public virtual void WriteStartObject() { }

	// RVA: 0xE48BD0 Offset: 0xE471D0 VA: 0x180E48BD0 Slot: 8
	public virtual void WriteEndObject() { }

	// RVA: 0xE48E40 Offset: 0xE47440 VA: 0x180E48E40 Slot: 9
	public virtual void WriteStartArray() { }

	// RVA: 0xE48BB0 Offset: 0xE471B0 VA: 0x180E48BB0 Slot: 10
	public virtual void WriteEndArray() { }

	// RVA: 0xE48E50 Offset: 0xE47450 VA: 0x180E48E50 Slot: 11
	public virtual void WriteStartConstructor(string name) { }

	// RVA: 0xE48BC0 Offset: 0xE471C0 VA: 0x180E48BC0 Slot: 12
	public virtual void WriteEndConstructor() { }

	// RVA: 0xE485A0 Offset: 0xE46BA0 VA: 0x180E485A0 Slot: 13
	public virtual void WritePropertyName(string name) { }

	// RVA: 0xE48DD0 Offset: 0xE473D0 VA: 0x180E48DD0 Slot: 14
	public virtual void WritePropertyName(string name, bool escape) { }

	// RVA: 0xE48CD0 Offset: 0xE472D0 VA: 0x180E48CD0 Slot: 15
	public virtual void WriteEnd() { }

	// RVA: 0xE49080 Offset: 0xE47680 VA: 0x180E49080
	public void WriteToken(JsonReader reader) { }

	// RVA: 0xE49900 Offset: 0xE47F00 VA: 0x180E49900
	public void WriteToken(JsonReader reader, bool writeChildren) { }

	// RVA: 0xE490F0 Offset: 0xE476F0 VA: 0x180E490F0
	public void WriteToken(JsonToken token, object value) { }

	// RVA: 0xE48E70 Offset: 0xE47470 VA: 0x180E48E70 Slot: 16
	internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

	// RVA: 0xE48970 Offset: 0xE46F70 VA: 0x180E48970
	private void WriteConstructorDate(JsonReader reader) { }

	// RVA: 0xE48BE0 Offset: 0xE471E0 VA: 0x180E48BE0
	private void WriteEnd(JsonContainerType type) { }

	// RVA: 0xE39BA0 Offset: 0xE381A0 VA: 0x180E39BA0
	private void AutoCompleteAll() { }

	// RVA: 0xE484C0 Offset: 0xE46AC0 VA: 0x180E484C0
	private JsonToken GetCloseTokenForType(JsonContainerType type) { }

	// RVA: 0xE47A90 Offset: 0xE46090 VA: 0x180E47A90
	private void AutoCompleteClose(JsonContainerType type) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 17
	protected virtual void WriteEnd(JsonToken token) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	protected virtual void WriteIndent() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 19
	protected virtual void WriteValueDelimiter() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 20
	protected virtual void WriteIndentSpace() { }

	// RVA: 0xE47E20 Offset: 0xE46420 VA: 0x180E47E20
	internal void AutoComplete(JsonToken tokenBeingWritten) { }

	// RVA: 0xE48DB0 Offset: 0xE473B0 VA: 0x180E48DB0 Slot: 21
	public virtual void WriteNull() { }

	// RVA: 0xE49980 Offset: 0xE47F80 VA: 0x180E49980 Slot: 22
	public virtual void WriteUndefined() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 23
	public virtual void WriteRaw(string json) { }

	// RVA: 0xE48DF0 Offset: 0xE473F0 VA: 0x180E48DF0 Slot: 24
	public virtual void WriteRawValue(string json) { }

	// RVA: 0xE49A10 Offset: 0xE48010 VA: 0x180E49A10 Slot: 25
	public virtual void WriteValue(string value) { }

	// RVA: 0xE4ABC0 Offset: 0xE491C0 VA: 0x180E4ABC0 Slot: 26
	public virtual void WriteValue(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE4ABC0 Offset: 0xE491C0 VA: 0x180E4ABC0 Slot: 27
	public virtual void WriteValue(uint value) { }

	// RVA: 0xE4ABC0 Offset: 0xE491C0 VA: 0x180E4ABC0 Slot: 28
	public virtual void WriteValue(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE4ABC0 Offset: 0xE491C0 VA: 0x180E4ABC0 Slot: 29
	public virtual void WriteValue(ulong value) { }

	// RVA: 0xE4B040 Offset: 0xE49640 VA: 0x180E4B040 Slot: 30
	public virtual void WriteValue(float value) { }

	// RVA: 0xE4B040 Offset: 0xE49640 VA: 0x180E4B040 Slot: 31
	public virtual void WriteValue(double value) { }

	// RVA: 0xE4AEC0 Offset: 0xE494C0 VA: 0x180E4AEC0 Slot: 32
	public virtual void WriteValue(bool value) { }

	// RVA: 0xE4ABC0 Offset: 0xE491C0 VA: 0x180E4ABC0 Slot: 33
	public virtual void WriteValue(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE4ABC0 Offset: 0xE491C0 VA: 0x180E4ABC0 Slot: 34
	public virtual void WriteValue(ushort value) { }

	// RVA: 0xE49A10 Offset: 0xE48010 VA: 0x180E49A10 Slot: 35
	public virtual void WriteValue(char value) { }

	// RVA: 0xE4ABC0 Offset: 0xE491C0 VA: 0x180E4ABC0 Slot: 36
	public virtual void WriteValue(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE4ABC0 Offset: 0xE491C0 VA: 0x180E4ABC0 Slot: 37
	public virtual void WriteValue(sbyte value) { }

	// RVA: 0xE4B040 Offset: 0xE49640 VA: 0x180E4B040 Slot: 38
	public virtual void WriteValue(Decimal value) { }

	// RVA: 0xE4B020 Offset: 0xE49620 VA: 0x180E4B020 Slot: 39
	public virtual void WriteValue(DateTime value) { }

	// RVA: 0xE4B020 Offset: 0xE49620 VA: 0x180E4B020 Slot: 40
	public virtual void WriteValue(DateTimeOffset value) { }

	// RVA: 0xE49A10 Offset: 0xE48010 VA: 0x180E49A10 Slot: 41
	public virtual void WriteValue(Guid value) { }

	// RVA: 0xE49A10 Offset: 0xE48010 VA: 0x180E49A10 Slot: 42
	public virtual void WriteValue(TimeSpan value) { }

	// RVA: 0xE4AD60 Offset: 0xE49360 VA: 0x180E4AD60 Slot: 43
	public virtual void WriteValue(Nullable<int> value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE4B470 Offset: 0xE49A70 VA: 0x180E4B470 Slot: 44
	public virtual void WriteValue(Nullable<uint> value) { }

	// RVA: 0xE4B310 Offset: 0xE49910 VA: 0x180E4B310 Slot: 45
	public virtual void WriteValue(Nullable<long> value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE499A0 Offset: 0xE47FA0 VA: 0x180E499A0 Slot: 46
	public virtual void WriteValue(Nullable<ulong> value) { }

	// RVA: 0xE4B380 Offset: 0xE49980 VA: 0x180E4B380 Slot: 47
	public virtual void WriteValue(Nullable<float> value) { }

	// RVA: 0xE4AC50 Offset: 0xE49250 VA: 0x180E4AC50 Slot: 48
	public virtual void WriteValue(Nullable<double> value) { }

	// RVA: 0xE4B140 Offset: 0xE49740 VA: 0x180E4B140 Slot: 49
	public virtual void WriteValue(Nullable<bool> value) { }

	// RVA: 0xE4B060 Offset: 0xE49660 VA: 0x180E4B060 Slot: 50
	public virtual void WriteValue(Nullable<short> value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE4ADD0 Offset: 0xE493D0 VA: 0x180E4ADD0 Slot: 51
	public virtual void WriteValue(Nullable<ushort> value) { }

	// RVA: 0xE4B0D0 Offset: 0xE496D0 VA: 0x180E4B0D0 Slot: 52
	public virtual void WriteValue(Nullable<char> value) { }

	// RVA: 0xE4AEE0 Offset: 0xE494E0 VA: 0x180E4AEE0 Slot: 53
	public virtual void WriteValue(Nullable<byte> value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE4ABE0 Offset: 0xE491E0 VA: 0x180E4ABE0 Slot: 54
	public virtual void WriteValue(Nullable<sbyte> value) { }

	// RVA: 0xE4AE40 Offset: 0xE49440 VA: 0x180E4AE40 Slot: 55
	public virtual void WriteValue(Nullable<Decimal> value) { }

	// RVA: 0xE4B2A0 Offset: 0xE498A0 VA: 0x180E4B2A0 Slot: 56
	public virtual void WriteValue(Nullable<DateTime> value) { }

	// RVA: 0xE4B3F0 Offset: 0xE499F0 VA: 0x180E4B3F0 Slot: 57
	public virtual void WriteValue(Nullable<DateTimeOffset> value) { }

	// RVA: 0xE4B1B0 Offset: 0xE497B0 VA: 0x180E4B1B0 Slot: 58
	public virtual void WriteValue(Nullable<Guid> value) { }

	// RVA: 0xE4B230 Offset: 0xE49830 VA: 0x180E4B230 Slot: 59
	public virtual void WriteValue(Nullable<TimeSpan> value) { }

	// RVA: 0xE49A30 Offset: 0xE48030 VA: 0x180E49A30 Slot: 60
	public virtual void WriteValue(byte[] value) { }

	// RVA: 0xE4ACC0 Offset: 0xE492C0 VA: 0x180E4ACC0 Slot: 61
	public virtual void WriteValue(Uri value) { }

	// RVA: 0xE4AF50 Offset: 0xE49550 VA: 0x180E4AF50 Slot: 62
	public virtual void WriteValue(object value) { }

	// RVA: 0xE48580 Offset: 0xE46B80 VA: 0x180E48580 Slot: 63
	public virtual void WriteComment(string text) { }

	// RVA: 0xE488F0 Offset: 0xE46EF0 VA: 0x180E488F0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE48490 Offset: 0xE46A90 VA: 0x180E48490 Slot: 64
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xE49A60 Offset: 0xE48060 VA: 0x180E49A60
	internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value) { }

	// RVA: 0xE483E0 Offset: 0xE469E0 VA: 0x180E483E0
	private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value) { }

	// RVA: 0xE48590 Offset: 0xE46B90 VA: 0x180E48590
	internal void InternalWriteEnd(JsonContainerType container) { }

	// RVA: 0xE485A0 Offset: 0xE46BA0 VA: 0x180E485A0
	internal void InternalWritePropertyName(string name) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void InternalWriteRaw() { }

	// RVA: 0xE485D0 Offset: 0xE46BD0 VA: 0x180E485D0
	internal void InternalWriteStart(JsonToken token, JsonContainerType container) { }

	// RVA: 0xE486E0 Offset: 0xE46CE0 VA: 0x180E486E0
	internal void InternalWriteValue(JsonToken token) { }

	// RVA: 0xE48580 Offset: 0xE46B80 VA: 0x180E48580
	internal void InternalWriteComment() { }

}

internal enum JsonWriter.State // TypeDefIndex: 5913
{	// Fields
	public int value__; // 0x0
	public const JsonWriter.State Start = 0;
	public const JsonWriter.State Property = 1;
	public const JsonWriter.State ObjectStart = 2;
	public const JsonWriter.State Object = 3;
	public const JsonWriter.State ArrayStart = 4;
	public const JsonWriter.State Array = 5;
	public const JsonWriter.State ConstructorStart = 6;
	public const JsonWriter.State Constructor = 7;
	public const JsonWriter.State Closed = 8;
	public const JsonWriter.State Error = 9;

}

internal static class JsonTokenUtils // TypeDefIndex: 5918
{	// Methods

	// RVA: 0x1808DA0 Offset: 0x18073A0 VA: 0x181808DA0
	internal static bool IsEndToken(JsonToken token) { }

	// RVA: 0x1808E10 Offset: 0x1807410 VA: 0x181808E10
	internal static bool IsStartToken(JsonToken token) { }

	// RVA: 0x1808DC0 Offset: 0x18073C0 VA: 0x181808DC0
	internal static bool IsPrimitiveToken(JsonToken token) { }

}

public class JsonContainerContract : JsonContract // TypeDefIndex: 5977
{	// Fields
	private JsonContract _itemContract; // 0x90
	private JsonContract _finalItemContract; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private JsonConverter <ItemConverter>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<bool> <ItemIsReference>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField; // 0xAC
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<TypeNameHandling> <ItemTypeNameHandling>k__BackingField; // 0xB4

	// Properties
	internal JsonContract ItemContract { get; set; }
	internal JsonContract FinalItemContract { get; }
	public JsonConverter ItemConverter { get; set; }
	public Nullable<bool> ItemIsReference { get; set; }
	public Nullable<ReferenceLoopHandling> ItemReferenceLoopHandling { get; set; }
	public Nullable<TypeNameHandling> ItemTypeNameHandling { get; set; }

	// Methods

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050
	internal JsonContract get_ItemContract() { }

	// RVA: 0x13F1BD0 Offset: 0x13F01D0 VA: 0x1813F1BD0
	internal void set_ItemContract(JsonContract value) { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	internal JsonContract get_FinalItemContract() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public JsonConverter get_ItemConverter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	public void set_ItemConverter(JsonConverter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1BA0 Offset: 0x13F01A0 VA: 0x1813F1BA0
	public Nullable<bool> get_ItemIsReference() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1C30 Offset: 0x13F0230 VA: 0x1813F1C30
	public void set_ItemIsReference(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1BB0 Offset: 0x13F01B0 VA: 0x1813F1BB0
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1C40 Offset: 0x13F0240 VA: 0x1813F1C40
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1BC0 Offset: 0x13F01C0 VA: 0x1813F1BC0
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1C50 Offset: 0x13F0250 VA: 0x1813F1C50
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

	// RVA: 0x13F1AA0 Offset: 0x13F00A0 VA: 0x1813F1AA0
	internal void .ctor(Type underlyingType) { }

}

internal class TraceJsonReader : JsonReader, IJsonLineInfo // TypeDefIndex: 5980
{	// Fields
	private readonly JsonReader _innerReader; // 0x78
	private readonly JsonTextWriter _textWriter; // 0x80
	private readonly StringWriter _sw; // 0x88

	// Properties
	public override int Depth { get; }
	public override string Path { get; }
	public override JsonToken TokenType { get; }
	public override object Value { get; }
	public override Type ValueType { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }

	// Methods

	// RVA: 0x1813210 Offset: 0x1811810 VA: 0x181813210
	public void .ctor(JsonReader innerReader) { }

	// RVA: 0x1812C80 Offset: 0x1811280 VA: 0x181812C80
	public string GetDeserializedJsonMessage() { }

	// RVA: 0x18131A0 Offset: 0x18117A0 VA: 0x1818131A0 Slot: 10
	public override bool Read() { }

	// RVA: 0x18130C0 Offset: 0x18116C0 VA: 0x1818130C0 Slot: 11
	public override Nullable<int> ReadAsInt32() { }

	// RVA: 0x1813130 Offset: 0x1811730 VA: 0x181813130 Slot: 12
	public override string ReadAsString() { }

	// RVA: 0x1812E40 Offset: 0x1811440 VA: 0x181812E40 Slot: 13
	public override byte[] ReadAsBytes() { }

	// RVA: 0x1812FC0 Offset: 0x18115C0 VA: 0x181812FC0 Slot: 16
	public override Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0x1813040 Offset: 0x1811640 VA: 0x181813040 Slot: 14
	public override Nullable<double> ReadAsDouble() { }

	// RVA: 0x1812DD0 Offset: 0x18113D0 VA: 0x181812DD0 Slot: 15
	public override Nullable<bool> ReadAsBoolean() { }

	// RVA: 0x1812F40 Offset: 0x1811540 VA: 0x181812F40 Slot: 17
	public override Nullable<DateTime> ReadAsDateTime() { }

	// RVA: 0x1812EB0 Offset: 0x18114B0 VA: 0x181812EB0 Slot: 18
	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0x1813360 Offset: 0x1811960 VA: 0x181813360 Slot: 8
	public override int get_Depth() { }

	// RVA: 0x1813390 Offset: 0x1811990 VA: 0x181813390 Slot: 9
	public override string get_Path() { }

	// RVA: 0x18133C0 Offset: 0x18119C0 VA: 0x1818133C0 Slot: 5
	public override JsonToken get_TokenType() { }

	// RVA: 0x1813420 Offset: 0x1811A20 VA: 0x181813420 Slot: 6
	public override object get_Value() { }

	// RVA: 0x18133F0 Offset: 0x18119F0 VA: 0x1818133F0 Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0x1812C50 Offset: 0x1811250 VA: 0x181812C50 Slot: 20
	public override void Close() { }

	// RVA: 0x1812CB0 Offset: 0x18112B0 VA: 0x181812CB0 Slot: 21
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0x1812D10 Offset: 0x1811310 VA: 0x181812D10 Slot: 22
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0x1812D70 Offset: 0x1811370 VA: 0x181812D70 Slot: 23
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

}

internal class TraceJsonWriter : JsonWriter // TypeDefIndex: 5981
{	// Fields
	private readonly JsonWriter _innerWriter; // 0x60
	private readonly JsonTextWriter _textWriter; // 0x68
	private readonly StringWriter _sw; // 0x70

	// Methods

	// RVA: 0x1814390 Offset: 0x1812990 VA: 0x181814390
	public void .ctor(JsonWriter innerWriter) { }

	// RVA: 0x18134A0 Offset: 0x1811AA0 VA: 0x1818134A0
	public string GetSerializedJsonMessage() { }

	// RVA: 0x1813FE0 Offset: 0x18125E0 VA: 0x181813FE0 Slot: 38
	public override void WriteValue(Decimal value) { }

	// RVA: 0x1813BD0 Offset: 0x18121D0 VA: 0x181813BD0 Slot: 32
	public override void WriteValue(bool value) { }

	// RVA: 0x1814140 Offset: 0x1812740 VA: 0x181814140 Slot: 36
	public override void WriteValue(byte value) { }

	// RVA: 0x1813F70 Offset: 0x1812570 VA: 0x181813F70 Slot: 53
	public override void WriteValue(Nullable<byte> value) { }

	// RVA: 0x1813A80 Offset: 0x1812080 VA: 0x181813A80 Slot: 35
	public override void WriteValue(char value) { }

	// RVA: 0x18139B0 Offset: 0x1811FB0 VA: 0x1818139B0 Slot: 60
	public override void WriteValue(byte[] value) { }

	// RVA: 0x1814220 Offset: 0x1812820 VA: 0x181814220 Slot: 39
	public override void WriteValue(DateTime value) { }

	// RVA: 0x1814290 Offset: 0x1812890 VA: 0x181814290 Slot: 40
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0x1813DB0 Offset: 0x18123B0 VA: 0x181813DB0 Slot: 31
	public override void WriteValue(double value) { }

	// RVA: 0x1813960 Offset: 0x1811F60 VA: 0x181813960 Slot: 22
	public override void WriteUndefined() { }

	// RVA: 0x1813630 Offset: 0x1811C30 VA: 0x181813630 Slot: 21
	public override void WriteNull() { }

	// RVA: 0x18141B0 Offset: 0x18127B0 VA: 0x1818141B0 Slot: 30
	public override void WriteValue(float value) { }

	// RVA: 0x1813CB0 Offset: 0x18122B0 VA: 0x181813CB0 Slot: 41
	public override void WriteValue(Guid value) { }

	// RVA: 0x1813A20 Offset: 0x1812020 VA: 0x181813A20 Slot: 26
	public override void WriteValue(int value) { }

	// RVA: 0x1813AF0 Offset: 0x18120F0 VA: 0x181813AF0 Slot: 28
	public override void WriteValue(long value) { }

	// RVA: 0x1813C40 Offset: 0x1812240 VA: 0x181813C40 Slot: 62
	public override void WriteValue(object value) { }

	// RVA: 0x1814070 Offset: 0x1812670 VA: 0x181814070 Slot: 37
	public override void WriteValue(sbyte value) { }

	// RVA: 0x1813D40 Offset: 0x1812340 VA: 0x181813D40 Slot: 33
	public override void WriteValue(short value) { }

	// RVA: 0x1813E90 Offset: 0x1812490 VA: 0x181813E90 Slot: 25
	public override void WriteValue(string value) { }

	// RVA: 0x1814320 Offset: 0x1812920 VA: 0x181814320 Slot: 42
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0x18140E0 Offset: 0x18126E0 VA: 0x1818140E0 Slot: 27
	public override void WriteValue(uint value) { }

	// RVA: 0x1813B60 Offset: 0x1812160 VA: 0x181813B60 Slot: 29
	public override void WriteValue(ulong value) { }

	// RVA: 0x1813E20 Offset: 0x1812420 VA: 0x181813E20 Slot: 61
	public override void WriteValue(Uri value) { }

	// RVA: 0x1813F00 Offset: 0x1812500 VA: 0x181813F00 Slot: 34
	public override void WriteValue(ushort value) { }

	// RVA: 0x18134D0 Offset: 0x1811AD0 VA: 0x1818134D0 Slot: 63
	public override void WriteComment(string text) { }

	// RVA: 0x1813850 Offset: 0x1811E50 VA: 0x181813850 Slot: 9
	public override void WriteStartArray() { }

	// RVA: 0x1813540 Offset: 0x1811B40 VA: 0x181813540 Slot: 10
	public override void WriteEndArray() { }

	// RVA: 0x18138A0 Offset: 0x1811EA0 VA: 0x1818138A0 Slot: 11
	public override void WriteStartConstructor(string name) { }

	// RVA: 0x1813590 Offset: 0x1811B90 VA: 0x181813590 Slot: 12
	public override void WriteEndConstructor() { }

	// RVA: 0x1813700 Offset: 0x1811D00 VA: 0x181813700 Slot: 13
	public override void WritePropertyName(string name) { }

	// RVA: 0x1813680 Offset: 0x1811C80 VA: 0x181813680 Slot: 14
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0x1813910 Offset: 0x1811F10 VA: 0x181813910 Slot: 7
	public override void WriteStartObject() { }

	// RVA: 0x18135E0 Offset: 0x1811BE0 VA: 0x1818135E0 Slot: 8
	public override void WriteEndObject() { }

	// RVA: 0x1813770 Offset: 0x1811D70 VA: 0x181813770 Slot: 24
	public override void WriteRawValue(string json) { }

	// RVA: 0x18137E0 Offset: 0x1811DE0 VA: 0x1818137E0 Slot: 23
	public override void WriteRaw(string json) { }

	// RVA: 0x1813450 Offset: 0x1811A50 VA: 0x181813450 Slot: 6
	public override void Close() { }

}

internal class JsonFormatterConverter : IFormatterConverter // TypeDefIndex: 5982
{	// Fields
	private readonly JsonSerializerInternalReader _reader; // 0x10
	private readonly JsonISerializableContract _contract; // 0x18
	private readonly JsonProperty _member; // 0x20

	// Methods

	// RVA: 0x13F3C10 Offset: 0x13F2210 VA: 0x1813F3C10
	public void .ctor(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: -1 Offset: -1
	private T GetTokenValue<T>(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0370 Offset: 0x5CE970 VA: 0x1805D0370
	|-JsonFormatterConverter.GetTokenValue<bool>
	|
	|-RVA: 0x5D0500 Offset: 0x5CEB00 VA: 0x1805D0500
	|-JsonFormatterConverter.GetTokenValue<int>
	|
	|-RVA: 0x5D0690 Offset: 0x5CEC90 VA: 0x1805D0690
	|-JsonFormatterConverter.GetTokenValue<long>
	|
	|-RVA: 0x5D0820 Offset: 0x5CEE20 VA: 0x1805D0820
	|-JsonFormatterConverter.GetTokenValue<object>
	|-JsonFormatterConverter.GetTokenValue<string>
	|
	|-RVA: 0x5D09B0 Offset: 0x5CEFB0 VA: 0x1805D09B0
	|-JsonFormatterConverter.GetTokenValue<float>
	*/

	// RVA: 0x13F3820 Offset: 0x13F1E20 VA: 0x1813F3820 Slot: 4
	public object Convert(object value, Type type) { }

	// RVA: 0x13F3A80 Offset: 0x13F2080 VA: 0x1813F3A80 Slot: 5
	public bool ToBoolean(object value) { }

	// RVA: 0x13F3AD0 Offset: 0x13F20D0 VA: 0x1813F3AD0 Slot: 6
	public int ToInt32(object value) { }

	// RVA: 0x13F3B20 Offset: 0x13F2120 VA: 0x1813F3B20 Slot: 7
	public long ToInt64(object value) { }

	// RVA: 0x13F3B70 Offset: 0x13F2170 VA: 0x1813F3B70 Slot: 8
	public float ToSingle(object value) { }

	// RVA: 0x13F3BC0 Offset: 0x13F21C0 VA: 0x1813F3BC0 Slot: 9
	public string ToString(object value) { }

}

public class JsonLinqContract : JsonContract // TypeDefIndex: 5984
{	// Methods

	// RVA: 0x13F3CE0 Offset: 0x13F22E0 VA: 0x1813F3CE0
	public void .ctor(Type underlyingType) { }

}

public class JsonPrimitiveContract : JsonContract // TypeDefIndex: 5985
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PrimitiveTypeCode <TypeCode>k__BackingField; // 0x90
	private static readonly Dictionary<Type, ReadType> ReadTypeMap; // 0x0

	// Properties
	internal PrimitiveTypeCode TypeCode { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD277E0 Offset: 0xD25DE0 VA: 0x180D277E0
	internal PrimitiveTypeCode get_TypeCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD27750 Offset: 0xD25D50 VA: 0x180D27750
	internal void set_TypeCode(PrimitiveTypeCode value) { }

	// RVA: 0x13F4600 Offset: 0x13F2C00 VA: 0x1813F4600
	public void .ctor(Type underlyingType) { }

	// RVA: 0x13F43C0 Offset: 0x13F29C0 VA: 0x1813F43C0
	private static void .cctor() { }

}

public class JsonArrayContract : JsonContainerContract // TypeDefIndex: 6005
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Type <CollectionItemType>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsMultidimensionalArray>k__BackingField; // 0xC8
	private readonly Type _genericCollectionDefinitionType; // 0xD0
	private Type _genericWrapperType; // 0xD8
	private ObjectConstructor<object> _genericWrapperCreator; // 0xE0
	private Func<object> _genericTemporaryCollectionCreator; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsArray>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <ShouldCreateWrapper>k__BackingField; // 0xF1
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <CanDeserialize>k__BackingField; // 0xF2
	private readonly ConstructorInfo _parameterizedConstructor; // 0xF8
	private ObjectConstructor<object> _parameterizedCreator; // 0x100
	private ObjectConstructor<object> _overrideCreator; // 0x108
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <HasParameterizedCreator>k__BackingField; // 0x110

	// Properties
	public Type CollectionItemType { get; set; }
	public bool IsMultidimensionalArray { get; set; }
	internal bool IsArray { get; set; }
	internal bool ShouldCreateWrapper { get; set; }
	internal bool CanDeserialize { get; set; }
	internal ObjectConstructor<object> ParameterizedCreator { get; }
	public ObjectConstructor<object> OverrideCreator { get; set; }
	public bool HasParameterizedCreator { get; set; }
	internal bool HasParameterizedCreatorInternal { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x104F1B0 Offset: 0x104D7B0 VA: 0x18104F1B0
	public Type get_CollectionItemType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEFAF20 Offset: 0xEF9520 VA: 0x180EFAF20
	private void set_CollectionItemType(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1960 Offset: 0x13EFF60 VA: 0x1813F1960
	public bool get_IsMultidimensionalArray() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1A50 Offset: 0x13F0050 VA: 0x1813F1A50
	private void set_IsMultidimensionalArray(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA00F0 Offset: 0xD9E6F0 VA: 0x180DA00F0
	internal bool get_IsArray() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA04D0 Offset: 0xD9EAD0 VA: 0x180DA04D0
	private void set_IsArray(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1A20 Offset: 0x13F0020 VA: 0x1813F1A20
	internal bool get_ShouldCreateWrapper() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1A90 Offset: 0x13F0090 VA: 0x1813F1A90
	private void set_ShouldCreateWrapper(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1910 Offset: 0x13EFF10 VA: 0x1813F1910
	internal bool get_CanDeserialize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1A30 Offset: 0x13F0030 VA: 0x1813F1A30
	private void set_CanDeserialize(bool value) { }

	// RVA: 0x13F1970 Offset: 0x13EFF70 VA: 0x1813F1970
	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	// RVA: 0xC831A0 Offset: 0xC817A0 VA: 0x180C831A0
	public ObjectConstructor<object> get_OverrideCreator() { }

	// RVA: 0x13F1A60 Offset: 0x13F0060 VA: 0x1813F1A60
	public void set_OverrideCreator(ObjectConstructor<object> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1950 Offset: 0x13EFF50 VA: 0x1813F1950
	public bool get_HasParameterizedCreator() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1A40 Offset: 0x13F0040 VA: 0x1813F1A40
	public void set_HasParameterizedCreator(bool value) { }

	// RVA: 0x13F1920 Offset: 0x13EFF20 VA: 0x1813F1920
	internal bool get_HasParameterizedCreatorInternal() { }

	// RVA: 0x13F0DC0 Offset: 0x13EF3C0 VA: 0x1813F0DC0
	public void .ctor(Type underlyingType) { }

	// RVA: 0x13F0950 Offset: 0x13EEF50 VA: 0x1813F0950
	internal IWrappedCollection CreateWrapper(object list) { }

	// RVA: 0x13F0730 Offset: 0x13EED30 VA: 0x1813F0730
	internal IList CreateTemporaryCollection() { }

}

internal enum JsonContractType // TypeDefIndex: 6006
{	// Fields
	public int value__; // 0x0
	public const JsonContractType None = 0;
	public const JsonContractType Object = 1;
	public const JsonContractType Array = 2;
	public const JsonContractType Primitive = 3;
	public const JsonContractType String = 4;
	public const JsonContractType Dictionary = 5;
	public const JsonContractType Dynamic = 6;
	public const JsonContractType Serializable = 7;
	public const JsonContractType Linq = 8;

}

public abstract class JsonContract // TypeDefIndex: 6011
{	// Fields
	internal bool IsNullable; // 0x10
	internal bool IsConvertable; // 0x11
	internal bool IsEnum; // 0x12
	internal Type NonNullableUnderlyingType; // 0x18
	internal ReadType InternalReadType; // 0x20
	internal JsonContractType ContractType; // 0x24
	internal bool IsReadOnlyOrFixedSize; // 0x28
	internal bool IsSealed; // 0x29
	internal bool IsInstantiable; // 0x2A
	private List<SerializationCallback> _onDeserializedCallbacks; // 0x30
	private IList<SerializationCallback> _onDeserializingCallbacks; // 0x38
	private IList<SerializationCallback> _onSerializedCallbacks; // 0x40
	private IList<SerializationCallback> _onSerializingCallbacks; // 0x48
	private IList<SerializationErrorCallback> _onErrorCallbacks; // 0x50
	private Type _createdType; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Type <UnderlyingType>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<bool> <IsReference>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private JsonConverter <Converter>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private JsonConverter <InternalConverter>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Func<object> <DefaultCreator>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <DefaultCreatorNonPublic>k__BackingField; // 0x88

	// Properties
	public Type UnderlyingType { get; set; }
	public Type CreatedType { get; set; }
	public Nullable<bool> IsReference { get; set; }
	public JsonConverter Converter { get; set; }
	internal JsonConverter InternalConverter { get; set; }
	public IList<SerializationCallback> OnDeserializedCallbacks { get; }
	public IList<SerializationCallback> OnDeserializingCallbacks { get; }
	public IList<SerializationCallback> OnSerializedCallbacks { get; }
	public IList<SerializationCallback> OnSerializingCallbacks { get; }
	public IList<SerializationErrorCallback> OnErrorCallbacks { get; }
	public Func<object> DefaultCreator { get; set; }
	public bool DefaultCreatorNonPublic { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public Type get_UnderlyingType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	private void set_UnderlyingType(Type value) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public Type get_CreatedType() { }

	// RVA: 0x13F2930 Offset: 0x13F0F30 VA: 0x1813F2930
	public void set_CreatedType(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F26F0 Offset: 0x13F0CF0 VA: 0x1813F26F0
	public Nullable<bool> get_IsReference() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F29A0 Offset: 0x13F0FA0 VA: 0x1813F29A0
	public void set_IsReference(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	public JsonConverter get_Converter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460
	public void set_Converter(JsonConverter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	internal JsonConverter get_InternalConverter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E8840 Offset: 0x4E6E40 VA: 0x1804E8840
	internal void set_InternalConverter(JsonConverter value) { }

	// RVA: 0x13F2700 Offset: 0x13F0D00 VA: 0x1813F2700
	public IList<SerializationCallback> get_OnDeserializedCallbacks() { }

	// RVA: 0x13F2770 Offset: 0x13F0D70 VA: 0x1813F2770
	public IList<SerializationCallback> get_OnDeserializingCallbacks() { }

	// RVA: 0x13F2850 Offset: 0x13F0E50 VA: 0x1813F2850
	public IList<SerializationCallback> get_OnSerializedCallbacks() { }

	// RVA: 0x13F28C0 Offset: 0x13F0EC0 VA: 0x1813F28C0
	public IList<SerializationCallback> get_OnSerializingCallbacks() { }

	// RVA: 0x13F27E0 Offset: 0x13F0DE0 VA: 0x1813F27E0
	public IList<SerializationErrorCallback> get_OnErrorCallbacks() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	public Func<object> get_DefaultCreator() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574470 Offset: 0x572A70 VA: 0x180574470
	public void set_DefaultCreator(Func<object> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D600 Offset: 0x69BC00 VA: 0x18069D600
	public bool get_DefaultCreatorNonPublic() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D610 Offset: 0x69BC10 VA: 0x18069D610
	public void set_DefaultCreatorNonPublic(bool value) { }

	// RVA: 0x13F2580 Offset: 0x13F0B80 VA: 0x1813F2580
	internal void .ctor(Type underlyingType) { }

	// RVA: 0x13F23D0 Offset: 0x13F09D0 VA: 0x1813F23D0
	internal void InvokeOnSerializing(object o, StreamingContext context) { }

	// RVA: 0x13F2220 Offset: 0x13F0820 VA: 0x1813F2220
	internal void InvokeOnSerialized(object o, StreamingContext context) { }

	// RVA: 0x13F1EB0 Offset: 0x13F04B0 VA: 0x1813F1EB0
	internal void InvokeOnDeserializing(object o, StreamingContext context) { }

	// RVA: 0x13F1D80 Offset: 0x13F0380 VA: 0x1813F1D80
	internal void InvokeOnDeserialized(object o, StreamingContext context) { }

	// RVA: 0x13F2060 Offset: 0x13F0660 VA: 0x1813F2060
	internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext) { }

	// RVA: 0x13F1C60 Offset: 0x13F0260 VA: 0x1813F1C60
	internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo) { }

	// RVA: 0x13F1CF0 Offset: 0x13F02F0 VA: 0x1813F1CF0
	internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo) { }

}

private sealed class JsonContract.<>c__DisplayClass73_0 // TypeDefIndex: 6012
{	// Fields
	public MethodInfo callbackMethodInfo; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1408F60 Offset: 0x1407560 VA: 0x181408F60
	internal void <CreateSerializationCallback>b__0(object o, StreamingContext context) { }

}

private sealed class JsonContract.<>c__DisplayClass74_0 // TypeDefIndex: 6013
{	// Fields
	public MethodInfo callbackMethodInfo; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1409050 Offset: 0x1407650 VA: 0x181409050
	internal void <CreateSerializationErrorCallback>b__0(object o, StreamingContext context, ErrorContext econtext) { }

}

public class JsonProperty // TypeDefIndex: 6015
{	// Fields
	internal Nullable<Required> _required; // 0x10
	internal bool _hasExplicitDefaultValue; // 0x18
	private object _defaultValue; // 0x20
	private bool _hasGeneratedDefaultValue; // 0x28
	private string _propertyName; // 0x30
	internal bool _skipPropertyNameEscape; // 0x38
	private Type _propertyType; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private JsonContract <PropertyContract>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Type <DeclaringType>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<int> <Order>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <UnderlyingName>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IValueProvider <ValueProvider>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IAttributeProvider <AttributeProvider>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private JsonConverter <Converter>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private JsonConverter <MemberConverter>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <Ignored>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <Readable>k__BackingField; // 0x89
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <Writable>k__BackingField; // 0x8A
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <HasMemberAttribute>k__BackingField; // 0x8B
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<bool> <IsReference>k__BackingField; // 0x8C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<NullValueHandling> <NullValueHandling>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<DefaultValueHandling> <DefaultValueHandling>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<ReferenceLoopHandling> <ReferenceLoopHandling>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<ObjectCreationHandling> <ObjectCreationHandling>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<TypeNameHandling> <TypeNameHandling>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Predicate<object> <ShouldSerialize>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Predicate<object> <ShouldDeserialize>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Predicate<object> <GetIsSpecified>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Action<object, object> <SetIsSpecified>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private JsonConverter <ItemConverter>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<bool> <ItemIsReference>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<TypeNameHandling> <ItemTypeNameHandling>k__BackingField; // 0xE4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField; // 0xEC

	// Properties
	internal JsonContract PropertyContract { get; set; }
	public string PropertyName { get; set; }
	public Type DeclaringType { get; set; }
	public Nullable<int> Order { get; set; }
	public string UnderlyingName { get; set; }
	public IValueProvider ValueProvider { get; set; }
	public IAttributeProvider AttributeProvider { set; }
	public Type PropertyType { get; set; }
	public JsonConverter Converter { get; set; }
	public JsonConverter MemberConverter { get; set; }
	public bool Ignored { get; set; }
	public bool Readable { get; set; }
	public bool Writable { get; set; }
	public bool HasMemberAttribute { get; set; }
	public object DefaultValue { get; set; }
	public Required Required { get; }
	public Nullable<bool> IsReference { get; set; }
	public Nullable<NullValueHandling> NullValueHandling { get; set; }
	public Nullable<DefaultValueHandling> DefaultValueHandling { get; set; }
	public Nullable<ReferenceLoopHandling> ReferenceLoopHandling { get; set; }
	public Nullable<ObjectCreationHandling> ObjectCreationHandling { get; set; }
	public Nullable<TypeNameHandling> TypeNameHandling { get; set; }
	public Predicate<object> ShouldSerialize { get; set; }
	public Predicate<object> ShouldDeserialize { get; }
	public Predicate<object> GetIsSpecified { get; set; }
	public Action<object, object> SetIsSpecified { get; set; }
	public JsonConverter ItemConverter { get; set; }
	public Nullable<bool> ItemIsReference { get; set; }
	public Nullable<TypeNameHandling> ItemTypeNameHandling { get; set; }
	public Nullable<ReferenceLoopHandling> ItemReferenceLoopHandling { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	internal JsonContract get_PropertyContract() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810
	internal void set_PropertyContract(JsonContract value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_PropertyName() { }

	// RVA: 0x13F4F60 Offset: 0x13F3560 VA: 0x1813F4F60
	public void set_PropertyName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public Type get_DeclaringType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	public void set_DeclaringType(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public Nullable<int> get_Order() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D8F30 Offset: 0x8D7530 VA: 0x1808D8F30
	public void set_Order(Nullable<int> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public string get_UnderlyingName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	public void set_UnderlyingName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public IValueProvider get_ValueProvider() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50
	public void set_ValueProvider(IValueProvider value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460
	public void set_AttributeProvider(IAttributeProvider value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public Type get_PropertyType() { }

	// RVA: 0x13F5000 Offset: 0x13F3600 VA: 0x1813F5000
	public void set_PropertyType(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	public JsonConverter get_Converter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E8840 Offset: 0x4E6E40 VA: 0x1804E8840
	public void set_Converter(JsonConverter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	public JsonConverter get_MemberConverter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574470 Offset: 0x572A70 VA: 0x180574470
	public void set_MemberConverter(JsonConverter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D600 Offset: 0x69BC00 VA: 0x18069D600
	public bool get_Ignored() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D610 Offset: 0x69BC10 VA: 0x18069D610
	public void set_Ignored(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEC11D0 Offset: 0xEBF7D0 VA: 0x180EC11D0
	public bool get_Readable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEC1870 Offset: 0xEBFE70 VA: 0x180EC1870
	public void set_Readable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F4EC0 Offset: 0x13F34C0 VA: 0x1813F4EC0
	public bool get_Writable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F5050 Offset: 0x13F3650 VA: 0x1813F5050
	public void set_Writable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F4E30 Offset: 0x13F3430 VA: 0x1813F4E30
	public bool get_HasMemberAttribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F4EF0 Offset: 0x13F34F0 VA: 0x1813F4EF0
	public void set_HasMemberAttribute(bool value) { }

	// RVA: 0x13F4E20 Offset: 0x13F3420 VA: 0x1813F4E20
	public object get_DefaultValue() { }

	// RVA: 0x13F4EE0 Offset: 0x13F34E0 VA: 0x1813F4EE0
	public void set_DefaultValue(object value) { }

	// RVA: 0x13F4D30 Offset: 0x13F3330 VA: 0x1813F4D30
	internal object GetResolvedDefaultValue() { }

	// RVA: 0x13F4E80 Offset: 0x13F3480 VA: 0x1813F4E80
	public Required get_Required() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F4E40 Offset: 0x13F3440 VA: 0x1813F4E40
	public Nullable<bool> get_IsReference() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F4F00 Offset: 0x13F3500 VA: 0x1813F4F00
	public void set_IsReference(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050
	public Nullable<NullValueHandling> get_NullValueHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F4F40 Offset: 0x13F3540 VA: 0x1813F4F40
	public void set_NullValueHandling(Nullable<NullValueHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public Nullable<DefaultValueHandling> get_DefaultValueHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F4ED0 Offset: 0x13F34D0 VA: 0x1813F4ED0
	public void set_DefaultValueHandling(Nullable<DefaultValueHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public Nullable<ReferenceLoopHandling> get_ReferenceLoopHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F5030 Offset: 0x13F3630 VA: 0x1813F5030
	public void set_ReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x952B90 Offset: 0x951190 VA: 0x180952B90
	public Nullable<ObjectCreationHandling> get_ObjectCreationHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F4F50 Offset: 0x13F3550 VA: 0x1813F4F50
	public void set_ObjectCreationHandling(Nullable<ObjectCreationHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9921A0 Offset: 0x9907A0 VA: 0x1809921A0
	public Nullable<TypeNameHandling> get_TypeNameHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F5040 Offset: 0x13F3640 VA: 0x1813F5040
	public void set_TypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7ACF70 Offset: 0x7AB570 VA: 0x1807ACF70
	public Predicate<object> get_ShouldSerialize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D230 Offset: 0xA4B830 VA: 0x180A4D230
	public void set_ShouldSerialize(Predicate<object> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x104F1B0 Offset: 0x104D7B0 VA: 0x18104F1B0
	public Predicate<object> get_ShouldDeserialize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA00E0 Offset: 0xD9E6E0 VA: 0x180DA00E0
	public Predicate<object> get_GetIsSpecified() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA04C0 Offset: 0xD9EAC0 VA: 0x180DA04C0
	public void set_GetIsSpecified(Predicate<object> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC73A80 Offset: 0xC72080 VA: 0x180C73A80
	public Action<object, object> get_SetIsSpecified() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC73BD0 Offset: 0xC721D0 VA: 0x180C73BD0
	public void set_SetIsSpecified(Action<object, object> value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 3
	public override string ToString() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD9F470 Offset: 0xD9DA70 VA: 0x180D9F470
	public JsonConverter get_ItemConverter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD35070 Offset: 0xD33670 VA: 0x180D35070
	public void set_ItemConverter(JsonConverter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F4E50 Offset: 0x13F3450 VA: 0x1813F4E50
	public Nullable<bool> get_ItemIsReference() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F4F10 Offset: 0x13F3510 VA: 0x1813F4F10
	public void set_ItemIsReference(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F4E70 Offset: 0x13F3470 VA: 0x1813F4E70
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F4F30 Offset: 0x13F3530 VA: 0x1813F4F30
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F4E60 Offset: 0x13F3460 VA: 0x1813F4E60
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F4F20 Offset: 0x13F3520 VA: 0x1813F4F20
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	// RVA: 0x13F4DD0 Offset: 0x13F33D0 VA: 0x1813F4DD0
	internal void WritePropertyName(JsonWriter writer) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class JsonPropertyCollection : KeyedCollection<string, JsonProperty> // TypeDefIndex: 6016
{	// Fields
	private readonly Type _type; // 0x38
	private readonly List<JsonProperty> _list; // 0x40

	// Methods

	// RVA: 0x13F4BF0 Offset: 0x13F31F0 VA: 0x1813F4BF0
	public void .ctor(Type type) { }

	// RVA: 0x13F4950 Offset: 0x13F2F50 VA: 0x1813F4950 Slot: 38
	protected override string GetKeyForItem(JsonProperty item) { }

	// RVA: 0x13F46F0 Offset: 0x13F2CF0 VA: 0x1813F46F0
	public void AddProperty(JsonProperty property) { }

	// RVA: 0x13F4910 Offset: 0x13F2F10 VA: 0x1813F4910
	public JsonProperty GetClosestMatchProperty(string propertyName) { }

	// RVA: 0x13F4B10 Offset: 0x13F3110 VA: 0x1813F4B10
	private bool TryGetValue(string key, out JsonProperty item) { }

	// RVA: 0x13F4970 Offset: 0x13F2F70 VA: 0x1813F4970
	public JsonProperty GetProperty(string propertyName, StringComparison comparisonType) { }

}

public class JsonObjectContract : JsonContainerContract // TypeDefIndex: 6018
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MemberSerialization <MemberSerialization>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<Required> <ItemRequired>k__BackingField; // 0xC4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private JsonPropertyCollection <Properties>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ExtensionDataSetter <ExtensionDataSetter>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ExtensionDataGetter <ExtensionDataGetter>k__BackingField; // 0xE0
	internal bool ExtensionDataIsJToken; // 0xE8
	private Nullable<bool> _hasRequiredOrDefaultValueProperties; // 0xE9
	private ConstructorInfo _parametrizedConstructor; // 0xF0
	private ConstructorInfo _overrideConstructor; // 0xF8
	private ObjectConstructor<object> _overrideCreator; // 0x100
	private ObjectConstructor<object> _parameterizedCreator; // 0x108
	private JsonPropertyCollection _creatorParameters; // 0x110
	private Type _extensionDataValueType; // 0x118

	// Properties
	public MemberSerialization MemberSerialization { get; set; }
	public Nullable<Required> ItemRequired { get; set; }
	public JsonPropertyCollection Properties { get; set; }
	public JsonPropertyCollection CreatorParameters { get; }
	[ObsoleteAttribute] // RVA: 0x8E1D0 Offset: 0x8D5D0 VA: 0x18008E1D0
	public ConstructorInfo OverrideConstructor { set; }
	[ObsoleteAttribute] // RVA: 0x8E250 Offset: 0x8D650 VA: 0x18008E250
	public ConstructorInfo ParametrizedConstructor { set; }
	public ObjectConstructor<object> OverrideCreator { get; }
	internal ObjectConstructor<object> ParameterizedCreator { get; }
	public ExtensionDataSetter ExtensionDataSetter { get; set; }
	public ExtensionDataGetter ExtensionDataGetter { get; set; }
	public Type ExtensionDataValueType { set; }
	internal bool HasRequiredOrDefaultValueProperties { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079E40 Offset: 0x1078440 VA: 0x181079E40
	public MemberSerialization get_MemberSerialization() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079FB0 Offset: 0x10785B0 VA: 0x181079FB0
	public void set_MemberSerialization(MemberSerialization value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F4180 Offset: 0x13F2780 VA: 0x1813F4180
	public Nullable<Required> get_ItemRequired() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F4250 Offset: 0x13F2850 VA: 0x1813F4250
	public void set_ItemRequired(Nullable<Required> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC73A80 Offset: 0xC72080 VA: 0x180C73A80
	public JsonPropertyCollection get_Properties() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC73BD0 Offset: 0xC721D0 VA: 0x180C73BD0
	private void set_Properties(JsonPropertyCollection value) { }

	// RVA: 0x13F3E90 Offset: 0x13F2490 VA: 0x1813F3E90
	public JsonPropertyCollection get_CreatorParameters() { }

	// RVA: 0x13F4260 Offset: 0x13F2860 VA: 0x1813F4260
	public void set_OverrideConstructor(ConstructorInfo value) { }

	// RVA: 0x13F4310 Offset: 0x13F2910 VA: 0x1813F4310
	public void set_ParametrizedConstructor(ConstructorInfo value) { }

	// RVA: 0xA2A920 Offset: 0xA28F20 VA: 0x180A2A920
	public ObjectConstructor<object> get_OverrideCreator() { }

	// RVA: 0xC831A0 Offset: 0xC817A0 VA: 0x180C831A0
	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD9F470 Offset: 0xD9DA70 VA: 0x180D9F470
	public ExtensionDataSetter get_ExtensionDataSetter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD35070 Offset: 0xD33670 VA: 0x180D35070
	public void set_ExtensionDataSetter(ExtensionDataSetter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4EF3A0 Offset: 0x4ED9A0 VA: 0x1804EF3A0
	public ExtensionDataGetter get_ExtensionDataGetter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4EF3B0 Offset: 0x4ED9B0 VA: 0x1804EF3B0
	public void set_ExtensionDataGetter(ExtensionDataGetter value) { }

	// RVA: 0x13F4190 Offset: 0x13F2790 VA: 0x1813F4190
	public void set_ExtensionDataValueType(Type value) { }

	// RVA: 0x13F3F10 Offset: 0x13F2510 VA: 0x1813F3F10
	internal bool get_HasRequiredOrDefaultValueProperties() { }

	// RVA: 0x13F3E00 Offset: 0x13F2400 VA: 0x1813F3E00
	public void .ctor(Type underlyingType) { }

	// RVA: 0x13F3D00 Offset: 0x13F2300 VA: 0x1813F3D00
	internal object GetUninitializedObject() { }

}

internal abstract class JsonSerializerInternalBase // TypeDefIndex: 6019
{	// Fields
	private ErrorContext _currentErrorContext; // 0x10
	private BidirectionalDictionary<string, object> _mappings; // 0x18
	internal readonly JsonSerializer Serializer; // 0x20
	internal readonly ITraceWriter TraceWriter; // 0x28
	protected JsonSerializerProxy InternalSerializer; // 0x30

	// Properties
	internal BidirectionalDictionary<string, object> DefaultReferenceMappings { get; }

	// Methods

	// RVA: 0x13F55B0 Offset: 0x13F3BB0 VA: 0x1813F55B0
	protected void .ctor(JsonSerializer serializer) { }

	// RVA: 0x13F5640 Offset: 0x13F3C40 VA: 0x1813F5640
	internal BidirectionalDictionary<string, object> get_DefaultReferenceMappings() { }

	// RVA: 0x13F50E0 Offset: 0x13F36E0 VA: 0x1813F50E0
	private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error) { }

	// RVA: 0x13F5060 Offset: 0x13F3660 VA: 0x1813F5060
	protected void ClearErrorContext() { }

	// RVA: 0x13F5200 Offset: 0x13F3800 VA: 0x1813F5200
	protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex) { }

}

private class JsonSerializerInternalBase.ReferenceEqualsEqualityComparer : IEqualityComparer<object> // TypeDefIndex: 6020
{	// Methods

	// RVA: 0x13CF910 Offset: 0x13CDF10 VA: 0x1813CF910 Slot: 4
	private bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y) { }

	// RVA: 0x14082A0 Offset: 0x14068A0 VA: 0x1814082A0 Slot: 5
	private int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal class JsonSerializerInternalReader : JsonSerializerInternalBase // TypeDefIndex: 6021
{	// Methods

	// RVA: 0x13F55B0 Offset: 0x13F3BB0 VA: 0x1813F55B0
	public void .ctor(JsonSerializer serializer) { }

	// RVA: 0x13FECE0 Offset: 0x13FD2E0 VA: 0x1813FECE0
	public void Populate(JsonReader reader, object target) { }

	// RVA: 0x13FBDB0 Offset: 0x13FA3B0 VA: 0x1813FBDB0
	private JsonContract GetContractSafe(Type type) { }

	// RVA: 0x13FAFE0 Offset: 0x13F95E0 VA: 0x1813FAFE0
	public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent) { }

	// RVA: 0x13FBF90 Offset: 0x13FA590 VA: 0x1813FBF90
	private JsonSerializerProxy GetInternalSerializer() { }

	// RVA: 0x13F69E0 Offset: 0x13F4FE0 VA: 0x1813F69E0
	private JToken CreateJToken(JsonReader reader, JsonContract contract) { }

	// RVA: 0x13F6780 Offset: 0x13F4D80 VA: 0x1813F6780
	private JToken CreateJObject(JsonReader reader) { }

	// RVA: 0x13FA830 Offset: 0x13F8E30 VA: 0x1813FA830
	private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	// RVA: 0x13F5E80 Offset: 0x13F4480 VA: 0x1813F5E80
	private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s) { }

	// RVA: 0x13FBEC0 Offset: 0x13FA4C0 VA: 0x1813FBEC0
	internal string GetExpectedDescription(JsonContract contract) { }

	// RVA: 0x13FBE20 Offset: 0x13FA420 VA: 0x1813FBE20
	private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x13F8FB0 Offset: 0x13F75B0 VA: 0x1813F8FB0
	private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	// RVA: 0x13FF540 Offset: 0x13FDB40 VA: 0x1813FF540
	private bool ReadMetadataPropertiesToken(JTokenReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	// RVA: 0x13FFBA0 Offset: 0x13FE1A0 VA: 0x1813FFBA0
	private bool ReadMetadataProperties(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	// RVA: 0x1400C70 Offset: 0x13FF270 VA: 0x181400C70
	private void ResolveTypeName(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName) { }

	// RVA: 0x13FB900 Offset: 0x13F9F00 VA: 0x1813FB900
	private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract) { }

	// RVA: 0x13F6C00 Offset: 0x13F5200 VA: 0x1813F6C00
	private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id) { }

	// RVA: 0x13FC0A0 Offset: 0x13FA6A0 VA: 0x1813FC0A0
	private bool HasNoDefinedType(JsonContract contract) { }

	// RVA: 0x13FBAA0 Offset: 0x13FA0A0 VA: 0x1813FBAA0
	private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType) { }

	// RVA: 0x1401320 Offset: 0x13FF920 VA: 0x181401320
	private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target) { }

	// RVA: 0x13F5940 Offset: 0x13F3F40 VA: 0x1813F5940
	private bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue) { }

	// RVA: 0x13F5710 Offset: 0x13F3D10 VA: 0x1813F5710
	private void AddReference(JsonReader reader, string id, object value) { }

	// RVA: 0xF9BFE0 Offset: 0xF9A5E0 VA: 0x180F9BFE0
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	// RVA: 0x1401B90 Offset: 0x1400190 VA: 0x181401B90
	private bool ShouldSetPropertyValue(JsonProperty property, object value) { }

	// RVA: 0x13F76F0 Offset: 0x13F5CF0 VA: 0x1813F76F0
	private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x13F7460 Offset: 0x13F5A60 VA: 0x1813F7460
	private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x13FC2C0 Offset: 0x13FA8C0 VA: 0x1813FC2C0
	private void OnDeserializing(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0x13FC130 Offset: 0x13FA730 VA: 0x1813FC130
	private void OnDeserialized(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0x13FC450 Offset: 0x13FAA50 VA: 0x1813FC450
	private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x13FD6E0 Offset: 0x13FBCE0 VA: 0x1813FD6E0
	private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x1401CC0 Offset: 0x14002C0 VA: 0x181401CC0
	private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message) { }

	// RVA: 0x13FCFC0 Offset: 0x13FB5C0 VA: 0x1813FCFC0
	private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x13F6120 Offset: 0x13F4720 VA: 0x1813F6120
	private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id) { }

	// RVA: 0x13F5F70 Offset: 0x13F4570 VA: 0x1813F5F70
	internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: 0x13F7C80 Offset: 0x13F6280 VA: 0x1813F7C80
	private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, ObjectConstructor<object> creator, string id) { }

	// RVA: 0x13FACE0 Offset: 0x13F92E0 VA: 0x1813FACE0
	private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue) { }

	// RVA: 0x14001C0 Offset: 0x13FE7C0 VA: 0x1814001C0
	private List<JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType) { }

	// RVA: 0x13FF300 Offset: 0x13FD900 VA: 0x1813FF300
	private bool ReadForType(JsonReader reader, JsonContract contract, bool hasConverter) { }

	// RVA: 0x13F7A20 Offset: 0x13F6020 VA: 0x1813F7A20
	public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x13FDF70 Offset: 0x13FC570 VA: 0x1813FDF70
	private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id) { }

	// RVA: 0x14019E0 Offset: 0x13FFFE0 VA: 0x1814019E0
	private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target) { }

	// RVA: 0x13F5D90 Offset: 0x13F4390 VA: 0x1813F5D90
	private bool CheckPropertyName(JsonReader reader, string memberName) { }

	// RVA: 0x14010B0 Offset: 0x13FF6B0 VA: 0x1814010B0
	private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o) { }

	// RVA: 0x13FF240 Offset: 0x13FD840 VA: 0x1813FF240
	private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader) { }

	// RVA: 0x13FB4C0 Offset: 0x13F9AC0 VA: 0x1813FB4C0
	private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, JsonSerializerInternalReader.PropertyPresence presence, bool setDefaultValue) { }

	// RVA: 0x1401200 Offset: 0x13FF800 VA: 0x181401200
	private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> requiredProperties) { }

	// RVA: 0x13FC010 Offset: 0x13FA610 VA: 0x1813FC010
	private void HandleError(JsonReader reader, bool readPastError, int initialDepth) { }

}

internal enum JsonSerializerInternalReader.PropertyPresence // TypeDefIndex: 6022
{	// Fields
	public int value__; // 0x0
	public const JsonSerializerInternalReader.PropertyPresence None = 0;
	public const JsonSerializerInternalReader.PropertyPresence Null = 1;
	public const JsonSerializerInternalReader.PropertyPresence Value = 2;

}

internal class JsonSerializerInternalReader.CreatorPropertyContext // TypeDefIndex: 6023
{	// Fields
	public string Name; // 0x10
	public JsonProperty Property; // 0x18
	public JsonProperty ConstructorProperty; // 0x20
	public Nullable<JsonSerializerInternalReader.PropertyPresence> Presence; // 0x28
	public object Value; // 0x30
	public bool Used; // 0x38

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class JsonSerializerInternalReader.<>c__DisplayClass36_0 // TypeDefIndex: 6024
{	// Fields
	public JsonProperty property; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1408E10 Offset: 0x1407410 VA: 0x181408E10
	internal bool <CreateObjectUsingCreatorWithParameters>b__1(JsonSerializerInternalReader.CreatorPropertyContext p) { }

}

private sealed class JsonSerializerInternalReader.<>c // TypeDefIndex: 6025
{	// Fields
	public static readonly JsonSerializerInternalReader.<>c <>9; // 0x0
	public static Func<JsonProperty, string> <>9__36_0; // 0x8
	public static Func<JsonProperty, string> <>9__36_2; // 0x10
	public static Func<JsonProperty, JsonProperty> <>9__41_0; // 0x18
	public static Func<JsonProperty, JsonSerializerInternalReader.PropertyPresence> <>9__41_1; // 0x20

	// Methods

	// RVA: 0x14091B0 Offset: 0x14077B0 VA: 0x1814091B0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13F4950 Offset: 0x13F2F50 VA: 0x1813F4950
	internal string <CreateObjectUsingCreatorWithParameters>b__36_0(JsonProperty p) { }

	// RVA: 0x13F4950 Offset: 0x13F2F50 VA: 0x1813F4950
	internal string <CreateObjectUsingCreatorWithParameters>b__36_2(JsonProperty p) { }

	// RVA: 0x7B4E80 Offset: 0x7B3480 VA: 0x1807B4E80
	internal JsonProperty <PopulateObject>b__41_0(JsonProperty m) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	internal JsonSerializerInternalReader.PropertyPresence <PopulateObject>b__41_1(JsonProperty m) { }

}

internal class JsonSerializerInternalWriter : JsonSerializerInternalBase // TypeDefIndex: 6026
{	// Fields
	private Type _rootType; // 0x38
	private int _rootLevel; // 0x40
	private readonly List<object> _serializeStack; // 0x48

	// Methods

	// RVA: 0x14081C0 Offset: 0x14067C0 VA: 0x1814081C0
	public void .ctor(JsonSerializer serializer) { }

	// RVA: 0x1406B00 Offset: 0x1405100 VA: 0x181406B00
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0x1402970 Offset: 0x1400F70 VA: 0x181402970
	private JsonSerializerProxy GetInternalSerializer() { }

	// RVA: 0x14028F0 Offset: 0x1400EF0 VA: 0x1814028F0
	private JsonContract GetContractSafe(object value) { }

	// RVA: 0x1405AB0 Offset: 0x14040B0 VA: 0x181405AB0
	private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x1405DF0 Offset: 0x14043F0 VA: 0x181405DF0
	private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x1403400 Offset: 0x1401A00 VA: 0x181403400
	private Nullable<bool> ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1407070 Offset: 0x1405670 VA: 0x181407070
	private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1406F80 Offset: 0x1405580 VA: 0x181406F80
	private bool ShouldWriteProperty(object memberValue, JsonProperty property) { }

	// RVA: 0x1402540 Offset: 0x1400B40 VA: 0x181402540
	private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x1407A30 Offset: 0x1406030 VA: 0x181407A30
	private void WriteReference(JsonWriter writer, object value) { }

	// RVA: 0x1402D60 Offset: 0x1401360 VA: 0x181402D60
	private string GetReference(JsonWriter writer, object value) { }

	// RVA: 0x14073C0 Offset: 0x14059C0 VA: 0x1814073C0
	internal static bool TryConvertToString(object value, Type type, out string s) { }

	// RVA: 0x1405D40 Offset: 0x1404340 VA: 0x181405D40
	private void SerializeString(JsonWriter writer, object value, JsonStringContract contract) { }

	// RVA: 0x1403290 Offset: 0x1401890 VA: 0x181403290
	private void OnSerializing(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0x1403120 Offset: 0x1401720 VA: 0x181403120
	private void OnSerialized(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0x14051F0 Offset: 0x14037F0 VA: 0x1814051F0
	private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1401DD0 Offset: 0x14003D0 VA: 0x181401DD0
	private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, out JsonContract memberContract, out object memberValue) { }

	// RVA: 0x1407610 Offset: 0x1405C10 VA: 0x181407610
	private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x14078A0 Offset: 0x1405EA0 VA: 0x1814078A0
	private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value) { }

	// RVA: 0x1408000 Offset: 0x1406600 VA: 0x181408000
	private void WriteTypeProperty(JsonWriter writer, Type type) { }

	// RVA: 0xF9BFE0 Offset: 0xF9A5E0 VA: 0x180F9BFE0
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	// RVA: 0xF9BFE0 Offset: 0xF9A5E0 VA: 0x180F9BFE0
	private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag) { }

	// RVA: 0xF9BFE0 Offset: 0xF9A5E0 VA: 0x180F9BFE0
	private bool HasFlag(TypeNameHandling value, TypeNameHandling flag) { }

	// RVA: 0x14034B0 Offset: 0x1401AB0 VA: 0x1814034B0
	private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1404790 Offset: 0x1402D90 VA: 0x181404790
	private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1405080 Offset: 0x1403680 VA: 0x181405080
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1404C80 Offset: 0x1403280 VA: 0x181404C80
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices) { }

	// RVA: 0x1407C00 Offset: 0x1406200 VA: 0x181407C00
	private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x14040D0 Offset: 0x14026D0 VA: 0x1814040D0
	private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1407250 Offset: 0x1405850 VA: 0x181407250
	private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x1403850 Offset: 0x1401E50 VA: 0x181403850
	private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x14029F0 Offset: 0x1400FF0 VA: 0x1814029F0
	private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape) { }

	// RVA: 0x1402EF0 Offset: 0x14014F0 VA: 0x181402EF0
	private void HandleError(JsonWriter writer, int initialDepth) { }

	// RVA: 0x1406DD0 Offset: 0x14053D0 VA: 0x181406DD0
	private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target) { }

	// RVA: 0x1402F70 Offset: 0x1401570 VA: 0x181402F70
	private bool IsSpecified(JsonWriter writer, JsonProperty property, object target) { }

}

internal class JsonSerializerProxy : JsonSerializer // TypeDefIndex: 6027
{	// Fields
	private readonly JsonSerializerInternalReader _serializerReader; // 0xE0
	private readonly JsonSerializerInternalWriter _serializerWriter; // 0xE8
	private readonly JsonSerializer _serializer; // 0xF0

	// Properties
	public override IReferenceResolver ReferenceResolver { set; }
	public override ITraceWriter TraceWriter { get; set; }
	public override IEqualityComparer EqualityComparer { set; }
	public override JsonConverterCollection Converters { get; }
	public override DefaultValueHandling DefaultValueHandling { set; }
	public override IContractResolver ContractResolver { get; set; }
	public override MissingMemberHandling MissingMemberHandling { set; }
	public override NullValueHandling NullValueHandling { set; }
	public override ObjectCreationHandling ObjectCreationHandling { get; set; }
	public override ReferenceLoopHandling ReferenceLoopHandling { set; }
	public override PreserveReferencesHandling PreserveReferencesHandling { set; }
	public override TypeNameHandling TypeNameHandling { set; }
	public override MetadataPropertyHandling MetadataPropertyHandling { get; set; }
	public override FormatterAssemblyStyle TypeNameAssemblyFormat { set; }
	public override ConstructorHandling ConstructorHandling { set; }
	public override SerializationBinder Binder { set; }
	public override StreamingContext Context { get; set; }
	public override Formatting Formatting { get; set; }
	public override bool CheckAdditionalContent { get; set; }

	// Methods

	// RVA: 0x18087D0 Offset: 0x1806DD0 VA: 0x1818087D0 Slot: 4
	public override void add_Error(EventHandler<ErrorEventArgs> value) { }

	// RVA: 0x1808990 Offset: 0x1806F90 VA: 0x181808990 Slot: 5
	public override void remove_Error(EventHandler<ErrorEventArgs> value) { }

	// RVA: 0x1808C70 Offset: 0x1807270 VA: 0x181808C70 Slot: 6
	public override void set_ReferenceResolver(IReferenceResolver value) { }

	// RVA: 0x1808960 Offset: 0x1806F60 VA: 0x181808960 Slot: 8
	public override ITraceWriter get_TraceWriter() { }

	// RVA: 0x1808CA0 Offset: 0x18072A0 VA: 0x181808CA0 Slot: 9
	public override void set_TraceWriter(ITraceWriter value) { }

	// RVA: 0x1808AF0 Offset: 0x18070F0 VA: 0x181808AF0 Slot: 10
	public override void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0x18088A0 Offset: 0x1806EA0 VA: 0x1818088A0 Slot: 23
	public override JsonConverterCollection get_Converters() { }

	// RVA: 0x1808AC0 Offset: 0x18070C0 VA: 0x181808AC0 Slot: 17
	public override void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0x1808870 Offset: 0x1806E70 VA: 0x181808870 Slot: 24
	public override IContractResolver get_ContractResolver() { }

	// RVA: 0x1808A90 Offset: 0x1807090 VA: 0x181808A90 Slot: 25
	public override void set_ContractResolver(IContractResolver value) { }

	// RVA: 0x1808B80 Offset: 0x1807180 VA: 0x181808B80 Slot: 15
	public override void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0x1808BB0 Offset: 0x18071B0 VA: 0x181808BB0 Slot: 16
	public override void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0x1808930 Offset: 0x1806F30 VA: 0x181808930 Slot: 18
	public override ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0x1808BE0 Offset: 0x18071E0 VA: 0x181808BE0 Slot: 19
	public override void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0x1808C40 Offset: 0x1807240 VA: 0x181808C40 Slot: 14
	public override void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0x1808C10 Offset: 0x1807210 VA: 0x181808C10 Slot: 13
	public override void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0x1808D00 Offset: 0x1807300 VA: 0x181808D00 Slot: 11
	public override void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0x1808900 Offset: 0x1806F00 VA: 0x181808900 Slot: 21
	public override MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0x1808B50 Offset: 0x1807150 VA: 0x181808B50 Slot: 22
	public override void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0x1808CD0 Offset: 0x18072D0 VA: 0x181808CD0 Slot: 12
	public override void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	// RVA: 0x1808A20 Offset: 0x1807020 VA: 0x181808A20 Slot: 20
	public override void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0x18089C0 Offset: 0x1806FC0 VA: 0x1818089C0 Slot: 7
	public override void set_Binder(SerializationBinder value) { }

	// RVA: 0x1808830 Offset: 0x1806E30 VA: 0x181808830 Slot: 26
	public override StreamingContext get_Context() { }

	// RVA: 0x1808A50 Offset: 0x1807050 VA: 0x181808A50 Slot: 27
	public override void set_Context(StreamingContext value) { }

	// RVA: 0x18088D0 Offset: 0x1806ED0 VA: 0x1818088D0 Slot: 28
	public override Formatting get_Formatting() { }

	// RVA: 0x1808B20 Offset: 0x1807120 VA: 0x181808B20 Slot: 29
	public override void set_Formatting(Formatting value) { }

	// RVA: 0x1808800 Offset: 0x1806E00 VA: 0x181808800 Slot: 30
	public override bool get_CheckAdditionalContent() { }

	// RVA: 0x18089F0 Offset: 0x1806FF0 VA: 0x1818089F0 Slot: 31
	public override void set_CheckAdditionalContent(bool value) { }

	// RVA: 0x1808580 Offset: 0x1806B80 VA: 0x181808580
	internal JsonSerializerInternalBase GetInternalSerializer() { }

	// RVA: 0x1808630 Offset: 0x1806C30 VA: 0x181808630
	public void .ctor(JsonSerializerInternalReader serializerReader) { }

	// RVA: 0x1808700 Offset: 0x1806D00 VA: 0x181808700
	public void .ctor(JsonSerializerInternalWriter serializerWriter) { }

	// RVA: 0x1808530 Offset: 0x1806B30 VA: 0x181808530 Slot: 33
	internal override object DeserializeInternal(JsonReader reader, Type objectType) { }

	// RVA: 0x18085A0 Offset: 0x1806BA0 VA: 0x1818085A0 Slot: 32
	internal override void PopulateInternal(JsonReader reader, object target) { }

	// RVA: 0x18085E0 Offset: 0x1806BE0 VA: 0x1818085E0 Slot: 34
	internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType) { }

}

public class JsonStringContract : JsonPrimitiveContract // TypeDefIndex: 6028
{	// Methods

	// RVA: 0x1808D30 Offset: 0x1807330 VA: 0x181808D30
	public void .ctor(Type underlyingType) { }

}

internal static class JsonTypeReflector // TypeDefIndex: 6029
{	// Fields
	private static Nullable<bool> _fullyTrusted; // 0x0
	private static readonly ThreadSafeStore<Type, Func<object[], JsonConverter>> JsonConverterCreatorCache; // 0x8
	private static readonly ThreadSafeStore<Type, Type> AssociatedMetadataTypesCache; // 0x10
	private static ReflectionObject _metadataTypeAttributeReflectionObject; // 0x18

	// Properties
	public static bool FullyTrusted { get; }
	public static ReflectionDelegateFactory ReflectionDelegateFactory { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T GetCachedAttribute<T>(object attributeProvider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D11E0 Offset: 0x5CF7E0 VA: 0x1805D11E0
	|-JsonTypeReflector.GetCachedAttribute<JsonContainerAttribute>
	|-JsonTypeReflector.GetCachedAttribute<JsonConverterAttribute>
	|-JsonTypeReflector.GetCachedAttribute<JsonObjectAttribute>
	|-JsonTypeReflector.GetCachedAttribute<object>
	|-JsonTypeReflector.GetCachedAttribute<SerializableAttribute>
	*/

	// RVA: 0x1809210 Offset: 0x1807810 VA: 0x181809210
	public static DataContractAttribute GetDataContractAttribute(Type type) { }

	// RVA: 0x18092A0 Offset: 0x18078A0 VA: 0x1818092A0
	public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo) { }

	// RVA: 0x1809A30 Offset: 0x1808030 VA: 0x181809A30
	public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute) { }

	// RVA: 0x1809960 Offset: 0x1807F60 VA: 0x181809960
	public static JsonConverter GetJsonConverter(object attributeProvider) { }

	// RVA: 0x1808E30 Offset: 0x1807430 VA: 0x181808E30
	public static JsonConverter CreateJsonConverterInstance(Type converterType, object[] converterArgs) { }

	// RVA: 0x1809810 Offset: 0x1807E10 VA: 0x181809810
	private static Func<object[], JsonConverter> GetJsonConverterCreator(Type converterType) { }

	// RVA: 0x1809BD0 Offset: 0x18081D0 VA: 0x181809BD0
	public static TypeConverter GetTypeConverter(Type type) { }

	// RVA: 0x1809190 Offset: 0x1807790 VA: 0x181809190
	private static Type GetAssociatedMetadataType(Type type) { }

	// RVA: 0x1808ED0 Offset: 0x18074D0 VA: 0x181808ED0
	private static Type GetAssociateMetadataTypeFromAttribute(Type type) { }

	// RVA: -1 Offset: -1
	private static T GetAttribute<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1060 Offset: 0x5CF660 VA: 0x1805D1060
	|-JsonTypeReflector.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	private static T GetAttribute<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0D00 Offset: 0x5CF300 VA: 0x1805D0D00
	|-JsonTypeReflector.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(object provider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0F50 Offset: 0x5CF550 VA: 0x1805D0F50
	|-JsonTypeReflector.GetAttribute<JsonExtensionDataAttribute>
	|-JsonTypeReflector.GetAttribute<JsonIgnoreAttribute>
	|-JsonTypeReflector.GetAttribute<JsonPropertyAttribute>
	|-JsonTypeReflector.GetAttribute<JsonRequiredAttribute>
	|-JsonTypeReflector.GetAttribute<DefaultValueAttribute>
	|-JsonTypeReflector.GetAttribute<NonSerializedAttribute>
	|-JsonTypeReflector.GetAttribute<object>
	|-JsonTypeReflector.GetAttribute<DataMemberAttribute>
	*/

	// RVA: 0x1809D30 Offset: 0x1808330 VA: 0x181809D30
	public static bool get_FullyTrusted() { }

	// RVA: 0x1809EB0 Offset: 0x18084B0 VA: 0x181809EB0
	public static ReflectionDelegateFactory get_ReflectionDelegateFactory() { }

	// RVA: 0x1809C30 Offset: 0x1808230 VA: 0x181809C30
	private static void .cctor() { }

}

private sealed class JsonTypeReflector.<>c__DisplayClass18_0 // TypeDefIndex: 6030
{	// Fields
	public Type converterType; // 0x10
	public Func<object> defaultConstructor; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1814DE0 Offset: 0x18133E0 VA: 0x181814DE0
	internal JsonConverter <GetJsonConverterCreator>b__0(object[] parameters) { }

}

private sealed class JsonTypeReflector.<>c // TypeDefIndex: 6031
{	// Fields
	public static readonly JsonTypeReflector.<>c <>9; // 0x0
	public static Func<object, Type> <>9__18_1; // 0x8

	// Methods

	// RVA: 0x18155F0 Offset: 0x1813BF0 VA: 0x1818155F0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x98C070 Offset: 0x98A670 VA: 0x18098C070
	internal Type <GetJsonConverterCreator>b__18_1(object param) { }

}

public class JPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 6038
{	// Properties
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	protected override int NameHashCode { get; }

	// Methods

	// RVA: 0xE35F20 Offset: 0xE34520 VA: 0x180E35F20
	public void .ctor(string name) { }

	// RVA: 0xE35AF0 Offset: 0xE340F0 VA: 0x180E35AF0
	private static JObject CastInstance(object instance) { }

	// RVA: 0xE35B70 Offset: 0xE34170 VA: 0x180E35B70 Slot: 17
	public override object GetValue(object component) { }

	// RVA: 0xE35C90 Offset: 0xE34290 VA: 0x180E35C90 Slot: 19
	public override void SetValue(object component, object value) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 20
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0xE35F30 Offset: 0xE34530 VA: 0x180E35F30 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0xE35F90 Offset: 0xE34590 VA: 0x180E35F90 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0 Slot: 8
	protected override int get_NameHashCode() { }

}

internal class JPropertyKeyedCollection : Collection<JToken> // TypeDefIndex: 6039
{	// Fields
	private static readonly IEqualityComparer<string> Comparer; // 0x0
	private Dictionary<string, JToken> _dictionary; // 0x20

	// Properties
	public ICollection<string> Keys { get; }

	// Methods

	// RVA: 0xE36BE0 Offset: 0xE351E0 VA: 0x180E36BE0
	public void .ctor() { }

	// RVA: 0xE35FF0 Offset: 0xE345F0 VA: 0x180E35FF0
	private void AddKey(string key, JToken item) { }

	// RVA: 0xE36060 Offset: 0xE34660 VA: 0x180E36060 Slot: 34
	protected override void ClearItems() { }

	// RVA: 0xE36440 Offset: 0xE34A40 VA: 0x180E36440
	public bool Contains(string key) { }

	// RVA: 0xE364D0 Offset: 0xE34AD0 VA: 0x180E364D0
	private void EnsureDictionary() { }

	// RVA: 0xE36580 Offset: 0xE34B80 VA: 0x180E36580
	private string GetKeyForItem(JToken item) { }

	// RVA: 0xE366E0 Offset: 0xE34CE0 VA: 0x180E366E0 Slot: 35
	protected override void InsertItem(int index, JToken item) { }

	// RVA: 0xE367A0 Offset: 0xE34DA0 VA: 0x180E367A0 Slot: 36
	protected override void RemoveItem(int index) { }

	// RVA: 0xE36860 Offset: 0xE34E60 VA: 0x180E36860
	private void RemoveKey(string key) { }

	// RVA: 0xE368B0 Offset: 0xE34EB0 VA: 0x180E368B0 Slot: 37
	protected override void SetItem(int index, JToken item) { }

	// RVA: 0xE36AB0 Offset: 0xE350B0 VA: 0x180E36AB0
	public bool TryGetValue(string key, out JToken value) { }

	// RVA: 0xE36C50 Offset: 0xE35250 VA: 0x180E36C50
	public ICollection<string> get_Keys() { }

	// RVA: 0xE36640 Offset: 0xE34C40 VA: 0x180E36640
	public int IndexOfReference(JToken t) { }

	// RVA: 0xE360C0 Offset: 0xE346C0 VA: 0x180E360C0
	public bool Compare(JPropertyKeyedCollection other) { }

	// RVA: 0xE36B30 Offset: 0xE35130 VA: 0x180E36B30
	private static void .cctor() { }

}

public class JsonLoadSettings // TypeDefIndex: 6040
{	// Fields
	private CommentHandling _commentHandling; // 0x10
	private LineInfoHandling _lineInfoHandling; // 0x14

	// Properties
	public CommentHandling CommentHandling { get; }
	public LineInfoHandling LineInfoHandling { get; }

	// Methods

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public CommentHandling get_CommentHandling() { }

	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0
	public LineInfoHandling get_LineInfoHandling() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class JsonMergeSettings // TypeDefIndex: 6041
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class JTokenEqualityComparer : IEqualityComparer<JToken> // TypeDefIndex: 6046
{
// Namespace: Newtonsoft.Json.Linq
[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
public class JTokenEqualityComparer : IEqualityComparer<JToken> // TypeDefIndex: 6046
	// Methods

	// RVA: 0xE38300 Offset: 0xE36900 VA: 0x180E38300 Slot: 4
	public bool Equals(JToken x, JToken y) { }

	// RVA: 0xE383A0 Offset: 0xE369A0 VA: 0x180E383A0 Slot: 5
	public int GetHashCode(JToken obj) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class JConstructor : JContainer // TypeDefIndex: 6056
{
// Namespace: Newtonsoft.Json.Linq
[PreserveAttribute] // RVA: 0x71550 Offset: 0x70950 VA: 0x180071550
[DefaultMemberAttribute] // RVA: 0x71550 Offset: 0x70950 VA: 0x180071550
public class JConstructor : JContainer // TypeDefIndex: 6056
	// Fields
	private string _name; // 0x48
	private readonly List<JToken> _values; // 0x50

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	public string Name { get; }
	public override JTokenType Type { get; }

	// Methods

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 45
	protected override IList<JToken> get_ChildrenTokens() { }

	// RVA: 0xE30C10 Offset: 0xE2F210 VA: 0x180E30C10 Slot: 47
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public string get_Name() { }

	// RVA: 0xAC1DA0 Offset: 0xAC03A0 VA: 0x180AC1DA0 Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0xE31040 Offset: 0xE2F640 VA: 0x180E31040
	public void .ctor() { }

	// RVA: 0xE31230 Offset: 0xE2F830 VA: 0x180E31230
	public void .ctor(JConstructor other) { }

	// RVA: 0xE310F0 Offset: 0xE2F6F0 VA: 0x180E310F0
	public void .ctor(string name) { }

	// RVA: 0xE30A00 Offset: 0xE2F000 VA: 0x180E30A00 Slot: 11
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0xE30940 Offset: 0xE2EF40 VA: 0x180E30940 Slot: 10
	internal override JToken CloneToken() { }

	// RVA: 0xE30E50 Offset: 0xE2F450 VA: 0x180E30E50 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE30BC0 Offset: 0xE2F1C0 VA: 0x180E30BC0 Slot: 18
	internal override int GetDeepHashCode() { }

	// RVA: 0xE30C60 Offset: 0xE2F260 VA: 0x180E30C60
	public static JConstructor Load(JsonReader reader, JsonLoadSettings settings) { }

}

public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, IBindingList, IList, ICollection // TypeDefIndex: 6057
{	// Fields
	internal ListChangedEventHandler _listChanged; // 0x30
	private object _syncRoot; // 0x38
	private bool _busy; // 0x40

	// Properties
	protected abstract IList<JToken> ChildrenTokens { get; }
	public override bool HasValues { get; }
	public override JToken First { get; }
	public override JToken Last { get; }
	private JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Item { get; set; }
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }
	public int Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 45
	protected abstract IList<JToken> get_ChildrenTokens();

	// RVA: 0xE33C30 Offset: 0xE32230 VA: 0x180E33C30
	internal void .ctor() { }

	// RVA: 0xE33C90 Offset: 0xE32290 VA: 0x180E33C90
	internal void .ctor(JContainer other) { }

	// RVA: 0xE316E0 Offset: 0xE2FCE0 VA: 0x180E316E0
	internal void CheckReentrancy() { }

	// RVA: 0xE32620 Offset: 0xE30C20 VA: 0x180E32620 Slot: 46
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xE33F60 Offset: 0xE32560 VA: 0x180E33F60 Slot: 13
	public override bool get_HasValues() { }

	// RVA: 0xE31A40 Offset: 0xE30040 VA: 0x180E31A40
	internal bool ContentsEqual(JContainer container) { }

	// RVA: 0xE33EE0 Offset: 0xE324E0 VA: 0x180E33EE0 Slot: 14
	public override JToken get_First() { }

	// RVA: 0xE33FC0 Offset: 0xE325C0 VA: 0x180E33FC0 Slot: 15
	public override JToken get_Last() { }

	// RVA: 0xE31790 Offset: 0xE2FD90 VA: 0x180E31790 Slot: 16
	public override JEnumerable<JToken> Children() { }

	// RVA: 0xE32490 Offset: 0xE30A90 VA: 0x180E32490
	internal bool IsMultiContent(object content) { }

	// RVA: 0xE32070 Offset: 0xE30670 VA: 0x180E32070
	internal JToken EnsureParentToken(JToken item, bool skipParentCheck) { }

	// RVA: -1 Offset: -1 Slot: 47
	internal abstract int IndexOfItem(JToken item);

	// RVA: 0xE32220 Offset: 0xE30820 VA: 0x180E32220 Slot: 48
	internal virtual void InsertItem(int index, JToken item, bool skipParentCheck) { }

	// RVA: 0xE32F50 Offset: 0xE31550 VA: 0x180E32F50 Slot: 49
	internal virtual void RemoveItemAt(int index) { }

	// RVA: 0xE331F0 Offset: 0xE317F0 VA: 0x180E331F0 Slot: 50
	internal virtual bool RemoveItem(JToken item) { }

	// RVA: 0xE321B0 Offset: 0xE307B0 VA: 0x180E321B0 Slot: 51
	internal virtual JToken GetItem(int index) { }

	// RVA: 0xE33290 Offset: 0xE31890 VA: 0x180E33290 Slot: 52
	internal virtual void SetItem(int index, JToken item) { }

	// RVA: 0xE317F0 Offset: 0xE2FDF0 VA: 0x180E317F0 Slot: 53
	internal virtual void ClearItems() { }

	// RVA: 0xE33240 Offset: 0xE31840 VA: 0x180E33240 Slot: 54
	internal virtual void ReplaceItem(JToken existing, JToken replacement) { }

	// RVA: 0xE31A20 Offset: 0xE30020 VA: 0x180E31A20 Slot: 55
	internal virtual bool ContainsItem(JToken item) { }

	// RVA: 0xE31D50 Offset: 0xE30350 VA: 0x180E31D50 Slot: 56
	internal virtual void CopyItemsTo(Array array, int arrayIndex) { }

	// RVA: 0xE32540 Offset: 0xE30B40 VA: 0x180E32540
	internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue) { }

	// RVA: 0xE33B20 Offset: 0xE32120 VA: 0x180E33B20 Slot: 57
	internal virtual void ValidateToken(JToken o, JToken existing) { }

	// RVA: 0xE31660 Offset: 0xE2FC60 VA: 0x180E31660 Slot: 58
	public virtual void Add(object content) { }

	// RVA: 0xE312D0 Offset: 0xE2F8D0 VA: 0x180E312D0
	internal void AddAndSkipParentCheck(JToken token) { }

	// RVA: 0xE31350 Offset: 0xE2F950 VA: 0x180E31350
	internal void AddInternal(int index, object content, bool skipParentCheck) { }

	// RVA: 0xE31FC0 Offset: 0xE305C0 VA: 0x180E31FC0
	internal static JToken CreateFromContent(object content) { }

	// RVA: 0xE30050 Offset: 0xE2E650 VA: 0x180E30050
	public void RemoveAll() { }

	// RVA: 0xE32DA0 Offset: 0xE313A0 VA: 0x180E32DA0
	internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options) { }

	// RVA: 0xE326C0 Offset: 0xE30CC0 VA: 0x180E326C0
	internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings) { }

	// RVA: 0xE31B80 Offset: 0xE30180 VA: 0x180E31B80
	internal int ContentsHashCode() { }

	// RVA: 0xE303C0 Offset: 0xE2E9C0 VA: 0x180E303C0 Slot: 21
	private int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(JToken item) { }

	// RVA: 0xE303E0 Offset: 0xE2E9E0 VA: 0x180E303E0 Slot: 22
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, JToken item) { }

	// RVA: 0xE305C0 Offset: 0xE2EBC0 VA: 0x180E305C0 Slot: 23
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index) { }

	// RVA: 0xE30900 Offset: 0xE2EF00 VA: 0x180E30900 Slot: 19
	private JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(int index) { }

	// RVA: 0xE30920 Offset: 0xE2EF20 VA: 0x180E30920 Slot: 20
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(int index, JToken value) { }

	// RVA: 0xE30030 Offset: 0xE2E630 VA: 0x180E30030 Slot: 26
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(JToken item) { }

	// RVA: 0xE30050 Offset: 0xE2E650 VA: 0x180E30050 Slot: 27
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear() { }

	// RVA: 0xE30120 Offset: 0xE2E720 VA: 0x180E30120 Slot: 28
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(JToken item) { }

	// RVA: 0xE30140 Offset: 0xE2E740 VA: 0x180E30140 Slot: 29
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 25
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly() { }

	// RVA: 0xE305E0 Offset: 0xE2EBE0 VA: 0x180E305E0 Slot: 30
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(JToken item) { }

	// RVA: 0xE32110 Offset: 0xE30710 VA: 0x180E32110
	private JToken EnsureValue(object value) { }

	// RVA: 0xE33620 Offset: 0xE31C20 VA: 0x180E33620 Slot: 33
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0xE30050 Offset: 0xE2E650 VA: 0x180E30050 Slot: 35
	private void System.Collections.IList.Clear() { }

	// RVA: 0xE33730 Offset: 0xE31D30 VA: 0x180E33730 Slot: 34
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0xE337F0 Offset: 0xE31DF0 VA: 0x180E337F0 Slot: 38
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0xE338B0 Offset: 0xE31EB0 VA: 0x180E338B0 Slot: 39
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 37
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 36
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xE33990 Offset: 0xE31F90 VA: 0x180E33990 Slot: 40
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0xE305C0 Offset: 0xE2EBC0 VA: 0x180E305C0 Slot: 41
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0xE30900 Offset: 0xE2EF00 VA: 0x180E30900 Slot: 31
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0xE33A50 Offset: 0xE32050 VA: 0x180E33A50 Slot: 32
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0xE30140 Offset: 0xE2E740 VA: 0x180E30140 Slot: 42
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0xE33E80 Offset: 0xE32480 VA: 0x180E33E80 Slot: 43
	public int get_Count() { }

	// RVA: 0xE335B0 Offset: 0xE31BB0 VA: 0x180E335B0 Slot: 44
	private object System.Collections.ICollection.get_SyncRoot() { }

}

public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, ICustomTypeDescriptor, INotifyPropertyChanging // TypeDefIndex: 6060
{	// Fields
	private readonly JPropertyKeyedCollection _properties; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PropertyChangedEventHandler PropertyChanged; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PropertyChangingEventHandler PropertyChanging; // 0x58

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	public override JTokenType Type { get; }
	public JToken Item { get; set; }
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Keys { get; }
	private ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Values { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.IsReadOnly { get; }

	// Methods

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 45
	protected override IList<JToken> get_ChildrenTokens() { }

	// RVA: 0xE35850 Offset: 0xE33E50 VA: 0x180E35850
	public void .ctor() { }

	// RVA: 0xE35790 Offset: 0xE33D90 VA: 0x180E35790
	public void .ctor(JObject other) { }

	// RVA: 0xE341C0 Offset: 0xE327C0 VA: 0x180E341C0 Slot: 11
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0xE342D0 Offset: 0xE328D0 VA: 0x180E342D0 Slot: 47
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xE34370 Offset: 0xE32970 VA: 0x180E34370 Slot: 48
	internal override void InsertItem(int index, JToken item, bool skipParentCheck) { }

	// RVA: 0xE353D0 Offset: 0xE339D0 VA: 0x180E353D0 Slot: 57
	internal override void ValidateToken(JToken o, JToken existing) { }

	// RVA: 0xE343E0 Offset: 0xE329E0 VA: 0x180E343E0
	internal void InternalPropertyChanged(JProperty childProperty) { }

	// RVA: 0xE344A0 Offset: 0xE32AA0 VA: 0x180E344A0
	internal void InternalPropertyChanging(JProperty childProperty) { }

	// RVA: 0xE340D0 Offset: 0xE326D0 VA: 0x180E340D0 Slot: 10
	internal override JToken CloneToken() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0xE347C0 Offset: 0xE32DC0 VA: 0x180E347C0
	public JProperty Property(string name) { }

	// RVA: 0xE35940 Offset: 0xE33F40 VA: 0x180E35940 Slot: 59
	public JToken get_Item(string propertyName) { }

	// RVA: 0xE359C0 Offset: 0xE33FC0 VA: 0x180E359C0 Slot: 60
	public void set_Item(string propertyName, JToken value) { }

	// RVA: 0xE34690 Offset: 0xE32C90 VA: 0x180E34690
	public static JObject Load(JsonReader reader) { }

	// RVA: 0xE344D0 Offset: 0xE32AD0 VA: 0x180E344D0
	public static JObject Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xE35690 Offset: 0xE33C90 VA: 0x180E35690 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE34040 Offset: 0xE32640 VA: 0x180E34040 Slot: 64
	public void Add(string propertyName, JToken value) { }

	// RVA: 0xE34EA0 Offset: 0xE334A0 VA: 0x180E34EA0 Slot: 63
	private bool System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.ContainsKey(string key) { }

	// RVA: 0xE34F40 Offset: 0xE33540 VA: 0x180E34F40 Slot: 61
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys() { }

	// RVA: 0xE348D0 Offset: 0xE32ED0 VA: 0x180E348D0 Slot: 65
	public bool Remove(string propertyName) { }

	// RVA: 0xE35370 Offset: 0xE33970 VA: 0x180E35370 Slot: 66
	public bool TryGetValue(string propertyName, out JToken value) { }

	// RVA: 0xE34FA0 Offset: 0xE335A0 VA: 0x180E34FA0 Slot: 62
	private ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values() { }

	// RVA: 0xE34960 Offset: 0xE32F60 VA: 0x180E34960 Slot: 69
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(KeyValuePair<string, JToken> item) { }

	// RVA: 0xE30050 Offset: 0xE2E650 VA: 0x180E30050 Slot: 70
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear() { }

	// RVA: 0xE349E0 Offset: 0xE32FE0 VA: 0x180E349E0 Slot: 71
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(KeyValuePair<string, JToken> item) { }

	// RVA: 0xE34A50 Offset: 0xE33050 VA: 0x180E34A50 Slot: 72
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 68
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly() { }

	// RVA: 0xE34D50 Offset: 0xE33350 VA: 0x180E34D50 Slot: 73
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(KeyValuePair<string, JToken> item) { }

	// RVA: 0xE30300 Offset: 0xE2E900 VA: 0x180E30300 Slot: 18
	internal override int GetDeepHashCode() { }

	// RVA: 0xE34260 Offset: 0xE32860 VA: 0x180E34260 Slot: 74
	public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator() { }

	// RVA: 0xE346A0 Offset: 0xE32CA0 VA: 0x180E346A0 Slot: 80
	protected virtual void OnPropertyChanged(string propertyName) { }

	// RVA: 0xE34730 Offset: 0xE32D30 VA: 0x180E34730 Slot: 81
	protected virtual void OnPropertyChanging(string propertyName) { }

	// RVA: 0xE352C0 Offset: 0xE338C0 VA: 0x180E352C0 Slot: 77
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xE350A0 Offset: 0xE336A0 VA: 0x180E350A0 Slot: 78
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0xE34FF0 Offset: 0xE335F0 VA: 0x180E34FF0 Slot: 75
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0xE35050 Offset: 0xE33650 VA: 0x180E35050 Slot: 76
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 79
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

private sealed class JObject.<>c // TypeDefIndex: 6061
{	// Fields
	public static readonly JObject.<>c <>9; // 0x35C6

	// Methods

	// RVA: 0xE4CD40 Offset: 0xE4B340 VA: 0x180E4CD40
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class JObject.<GetEnumerator>d__58 : IEnumerator<KeyValuePair<string, JToken>>, IDisposable, IEnumerator // TypeDefIndex: 6062
{	// Fields
	private int <>1__state; // 0x10
	private KeyValuePair<string, JToken> <>2__current; // 0x18
	public JObject <>4__this; // 0x28
	private IEnumerator<JToken> <>7__wrap1; // 0x30

	// Properties
	private KeyValuePair<string, JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE4CBE0 Offset: 0xE4B1E0 VA: 0x180E4CBE0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE4C930 Offset: 0xE4AF30 VA: 0x180E4C930 Slot: 6
	private bool MoveNext() { }

	// RVA: 0xE4CC90 Offset: 0xE4B290 VA: 0x180E4CC90
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB11230 Offset: 0xB0F830 VA: 0x180B11230 Slot: 4
	private KeyValuePair<string, JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE4CB40 Offset: 0xE4B140 VA: 0x180E4CB40 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE4CB90 Offset: 0xE4B190 VA: 0x180E4CB90 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable // TypeDefIndex: 6063
{	// Fields
	private readonly List<JToken> _values; // 0x48

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	public override JTokenType Type { get; }
	public JToken Item { get; set; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 45
	protected override IList<JToken> get_ChildrenTokens() { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0xE30700 Offset: 0xE2ED00 VA: 0x180E30700
	public void .ctor() { }

	// RVA: 0xE30880 Offset: 0xE2EE80 VA: 0x180E30880
	public void .ctor(JArray other) { }

	// RVA: 0xE307B0 Offset: 0xE2EDB0 VA: 0x180E307B0
	public void .ctor(object content) { }

	// RVA: 0xE30160 Offset: 0xE2E760 VA: 0x180E30160 Slot: 11
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0xE30070 Offset: 0xE2E670 VA: 0x180E30070 Slot: 10
	internal override JToken CloneToken() { }

	// RVA: 0xE305B0 Offset: 0xE2EBB0 VA: 0x180E305B0
	public static JArray Load(JsonReader reader) { }

	// RVA: 0xE30410 Offset: 0xE2EA10 VA: 0x180E30410
	public static JArray Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xE30600 Offset: 0xE2EC00 VA: 0x180E30600 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE30900 Offset: 0xE2EF00 VA: 0x180E30900 Slot: 19
	public JToken get_Item(int index) { }

	// RVA: 0xE30920 Offset: 0xE2EF20 VA: 0x180E30920 Slot: 20
	public void set_Item(int index, JToken value) { }

	// RVA: 0xE30370 Offset: 0xE2E970 VA: 0x180E30370 Slot: 47
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xE303C0 Offset: 0xE2E9C0 VA: 0x180E303C0 Slot: 21
	public int IndexOf(JToken item) { }

	// RVA: 0xE303E0 Offset: 0xE2E9E0 VA: 0x180E303E0 Slot: 22
	public void Insert(int index, JToken item) { }

	// RVA: 0xE305C0 Offset: 0xE2EBC0 VA: 0x180E305C0 Slot: 23
	public void RemoveAt(int index) { }

	// RVA: 0xE30310 Offset: 0xE2E910 VA: 0x180E30310 Slot: 4
	public IEnumerator<JToken> GetEnumerator() { }

	// RVA: 0xE30030 Offset: 0xE2E630 VA: 0x180E30030 Slot: 26
	public void Add(JToken item) { }

	// RVA: 0xE30050 Offset: 0xE2E650 VA: 0x180E30050 Slot: 27
	public void Clear() { }

	// RVA: 0xE30120 Offset: 0xE2E720 VA: 0x180E30120 Slot: 28
	public bool Contains(JToken item) { }

	// RVA: 0xE30140 Offset: 0xE2E740 VA: 0x180E30140 Slot: 29
	public void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 25
	public bool get_IsReadOnly() { }

	// RVA: 0xE305E0 Offset: 0xE2EBE0 VA: 0x180E305E0 Slot: 30
	public bool Remove(JToken item) { }

	// RVA: 0xE30300 Offset: 0xE2E900 VA: 0x180E30300 Slot: 18
	internal override int GetDeepHashCode() { }

}

public class JTokenReader : JsonReader, IJsonLineInfo // TypeDefIndex: 6064
{	// Fields
	private readonly JToken _root; // 0x78
	private string _initialPath; // 0x80
	private JToken _parent; // 0x88
	private JToken _current; // 0x90

	// Properties
	public JToken CurrentToken { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }
	public override string Path { get; }

	// Methods

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050
	public JToken get_CurrentToken() { }

	// RVA: 0xE39820 Offset: 0xE37E20 VA: 0x180E39820
	public void .ctor(JToken token) { }

	// RVA: 0xE387F0 Offset: 0xE36DF0 VA: 0x180E387F0 Slot: 10
	public override bool Read() { }

	// RVA: 0xE386C0 Offset: 0xE36CC0 VA: 0x180E386C0
	private bool ReadOver(JToken t) { }

	// RVA: 0xE387B0 Offset: 0xE36DB0 VA: 0x180E387B0
	private bool ReadToEnd() { }

	// RVA: 0xE383C0 Offset: 0xE369C0 VA: 0x180E383C0
	private Nullable<JsonToken> GetEndToken(JContainer c) { }

	// RVA: 0xE38620 Offset: 0xE36C20 VA: 0x180E38620
	private bool ReadInto(JContainer c) { }

	// RVA: 0xE38B30 Offset: 0xE37130 VA: 0x180E38B30
	private bool SetEnd(JContainer c) { }

	// RVA: 0xE38CD0 Offset: 0xE372D0 VA: 0x180E38CD0
	private void SetToken(JToken token) { }

	// RVA: 0xE38B10 Offset: 0xE37110 VA: 0x180E38B10
	private string SafeToString(object value) { }

	// RVA: 0xE38500 Offset: 0xE36B00 VA: 0x180E38500 Slot: 21
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0xE38560 Offset: 0xE36B60 VA: 0x180E38560 Slot: 22
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0xE385C0 Offset: 0xE36BC0 VA: 0x180E385C0 Slot: 23
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0xE39880 Offset: 0xE37E80 VA: 0x180E39880 Slot: 9
	public override string get_Path() { }

}

public class JTokenWriter : JsonWriter // TypeDefIndex: 6065
{	// Fields
	private JContainer _token; // 0x60
	private JContainer _parent; // 0x68
	private JValue _value; // 0x70
	private JToken _current; // 0x78

	// Properties
	public JToken Token { get; }

	// Methods

	// RVA: 0xE3ADC0 Offset: 0xE393C0 VA: 0x180E3ADC0
	public JToken get_Token() { }

	// RVA: 0xE3AD50 Offset: 0xE39350 VA: 0x180E3AD50
	public void .ctor() { }

	// RVA: 0xE39BA0 Offset: 0xE381A0 VA: 0x180E39BA0 Slot: 6
	public override void Close() { }

	// RVA: 0xE39FD0 Offset: 0xE385D0 VA: 0x180E39FD0 Slot: 7
	public override void WriteStartObject() { }

	// RVA: 0xE39970 Offset: 0xE37F70 VA: 0x180E39970
	private void AddParent(JContainer container) { }

	// RVA: 0xE39C10 Offset: 0xE38210 VA: 0x180E39C10
	private void RemoveParent() { }

	// RVA: 0xE39EE0 Offset: 0xE384E0 VA: 0x180E39EE0 Slot: 9
	public override void WriteStartArray() { }

	// RVA: 0xE39F50 Offset: 0xE38550 VA: 0x180E39F50 Slot: 11
	public override void WriteStartConstructor(string name) { }

	// RVA: 0xE39C10 Offset: 0xE38210 VA: 0x180E39C10 Slot: 17
	protected override void WriteEnd(JsonToken token) { }

	// RVA: 0xE39D20 Offset: 0xE38320 VA: 0x180E39D20 Slot: 13
	public override void WritePropertyName(string name) { }

	// RVA: 0xE39A40 Offset: 0xE38040 VA: 0x180E39A40
	private void AddValue(object value, JsonToken token) { }

	// RVA: 0xE39AD0 Offset: 0xE380D0 VA: 0x180E39AD0
	internal void AddValue(JValue value, JsonToken token) { }

	// RVA: 0xE3AC40 Offset: 0xE39240 VA: 0x180E3AC40 Slot: 62
	public override void WriteValue(object value) { }

	// RVA: 0xE39CE0 Offset: 0xE382E0 VA: 0x180E39CE0 Slot: 21
	public override void WriteNull() { }

	// RVA: 0xE3A2E0 Offset: 0xE388E0 VA: 0x180E3A2E0 Slot: 22
	public override void WriteUndefined() { }

	// RVA: 0xE39E70 Offset: 0xE38470 VA: 0x180E39E70 Slot: 23
	public override void WriteRaw(string json) { }

	// RVA: 0xE39C90 Offset: 0xE38290 VA: 0x180E39C90 Slot: 63
	public override void WriteComment(string text) { }

	// RVA: 0xE3A910 Offset: 0xE38F10 VA: 0x180E3A910 Slot: 25
	public override void WriteValue(string value) { }

	// RVA: 0xE3AAE0 Offset: 0xE390E0 VA: 0x180E3AAE0 Slot: 26
	public override void WriteValue(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE3A610 Offset: 0xE38C10 VA: 0x180E3A610 Slot: 27
	public override void WriteValue(uint value) { }

	// RVA: 0xE3A810 Offset: 0xE38E10 VA: 0x180E3A810 Slot: 28
	public override void WriteValue(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE3AC50 Offset: 0xE39250 VA: 0x180E3AC50 Slot: 29
	public override void WriteValue(ulong value) { }

	// RVA: 0xE3A4E0 Offset: 0xE38AE0 VA: 0x180E3A4E0 Slot: 30
	public override void WriteValue(float value) { }

	// RVA: 0xE3A9E0 Offset: 0xE38FE0 VA: 0x180E3A9E0 Slot: 31
	public override void WriteValue(double value) { }

	// RVA: 0xE3AB60 Offset: 0xE39160 VA: 0x180E3AB60 Slot: 32
	public override void WriteValue(bool value) { }

	// RVA: 0xE3ACD0 Offset: 0xE392D0 VA: 0x180E3ACD0 Slot: 33
	public override void WriteValue(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE3A890 Offset: 0xE38E90 VA: 0x180E3A890 Slot: 34
	public override void WriteValue(ushort value) { }

	// RVA: 0xE3A450 Offset: 0xE38A50 VA: 0x180E3A450 Slot: 35
	public override void WriteValue(char value) { }

	// RVA: 0xE3A710 Offset: 0xE38D10 VA: 0x180E3A710 Slot: 36
	public override void WriteValue(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE3AA60 Offset: 0xE39060 VA: 0x180E3AA60 Slot: 37
	public override void WriteValue(sbyte value) { }

	// RVA: 0xE3A320 Offset: 0xE38920 VA: 0x180E3A320 Slot: 38
	public override void WriteValue(Decimal value) { }

	// RVA: 0xE3A3A0 Offset: 0xE389A0 VA: 0x180E3A3A0 Slot: 39
	public override void WriteValue(DateTime value) { }

	// RVA: 0xE3A960 Offset: 0xE38F60 VA: 0x180E3A960 Slot: 40
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0xE3ABE0 Offset: 0xE391E0 VA: 0x180E3ABE0 Slot: 60
	public override void WriteValue(byte[] value) { }

	// RVA: 0xE3A790 Offset: 0xE38D90 VA: 0x180E3A790 Slot: 42
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0xE3A690 Offset: 0xE38C90 VA: 0x180E3A690 Slot: 41
	public override void WriteValue(Guid value) { }

	// RVA: 0xE3A560 Offset: 0xE38B60 VA: 0x180E3A560 Slot: 61
	public override void WriteValue(Uri value) { }

	// RVA: 0xE3A040 Offset: 0xE38640 VA: 0x180E3A040 Slot: 16
	internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

}

public abstract class JToken : IJEnumerable<JToken>, IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable // TypeDefIndex: 6066
{	// Fields
	private JContainer _parent; // 0x10
	private JToken _previous; // 0x18
	private JToken _next; // 0x20
	private object _annotations; // 0x28
	private static readonly JTokenType[] BooleanTypes; // 0x0
	private static readonly JTokenType[] NumberTypes; // 0x8
	private static readonly JTokenType[] StringTypes; // 0x10
	private static readonly JTokenType[] GuidTypes; // 0x18
	private static readonly JTokenType[] TimeSpanTypes; // 0x20
	private static readonly JTokenType[] UriTypes; // 0x28
	private static readonly JTokenType[] CharTypes; // 0x30
	private static readonly JTokenType[] DateTimeTypes; // 0x38
	private static readonly JTokenType[] BytesTypes; // 0x40

	// Properties
	public JContainer Parent { get; set; }
	public JToken Root { get; }
	public abstract JTokenType Type { get; }
	public abstract bool HasValues { get; }
	public JToken Next { get; set; }
	public JToken Previous { get; set; }
	public string Path { get; }
	public virtual JToken First { get; }
	public virtual JToken Last { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }

	// Methods

	[DebuggerStepThroughAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public JContainer get_Parent() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	internal void set_Parent(JContainer value) { }

	// RVA: 0xE3DE10 Offset: 0xE3C410 VA: 0x180E3DE10
	public JToken get_Root() { }

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract JToken CloneToken();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract bool DeepEquals(JToken node);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract JTokenType get_Type();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool get_HasValues();

	// RVA: 0xE3B1B0 Offset: 0xE397B0 VA: 0x180E3B1B0
	public static bool DeepEquals(JToken t1, JToken t2) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public JToken get_Next() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	internal void set_Next(JToken value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public JToken get_Previous() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	internal void set_Previous(JToken value) { }

	// RVA: 0xE3DB60 Offset: 0xE3C160 VA: 0x180E3DB60
	public string get_Path() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0xE3DA20 Offset: 0xE3C020 VA: 0x180E3DA20 Slot: 14
	public virtual JToken get_First() { }

	// RVA: 0xE3DAC0 Offset: 0xE3C0C0 VA: 0x180E3DAC0 Slot: 15
	public virtual JToken get_Last() { }

	// RVA: 0xE3B0A0 Offset: 0xE396A0 VA: 0x180E3B0A0 Slot: 16
	public virtual JEnumerable<JToken> Children() { }

	// RVA: 0xE3BBC0 Offset: 0xE3A1C0 VA: 0x180E3BBC0
	public void Remove() { }

	// RVA: 0xE3BC40 Offset: 0xE3A240 VA: 0x180E3BC40
	public void Replace(JToken value) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void WriteTo(JsonWriter writer, JsonConverter[] converters);

	// RVA: 0xE3D080 Offset: 0xE3B680 VA: 0x180E3D080 Slot: 3
	public override string ToString() { }

	// RVA: 0xE3CE90 Offset: 0xE3B490 VA: 0x180E3CE90
	public string ToString(Formatting formatting, JsonConverter[] converters) { }

	// RVA: 0xE3B1E0 Offset: 0xE397E0 VA: 0x180E3B1E0
	private static JValue EnsureValue(JToken value) { }

	// RVA: 0xE3B370 Offset: 0xE39970 VA: 0x180E3B370
	private static string GetType(JToken token) { }

	// RVA: 0xE3D0D0 Offset: 0xE3B6D0 VA: 0x180E3D0D0
	private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable) { }

	// RVA: 0xE42AF0 Offset: 0xE410F0 VA: 0x180E42AF0
	public static bool op_Explicit(JToken value) { }

	// RVA: 0xE400B0 Offset: 0xE3E6B0 VA: 0x180E400B0
	public static DateTimeOffset op_Explicit(JToken value) { }

	// RVA: 0xE40EB0 Offset: 0xE3F4B0 VA: 0x180E40EB0
	public static Nullable<bool> op_Explicit(JToken value) { }

	// RVA: 0xE3E270 Offset: 0xE3C870 VA: 0x180E3E270
	public static long op_Explicit(JToken value) { }

	// RVA: 0xE3E630 Offset: 0xE3CC30 VA: 0x180E3E630
	public static Nullable<DateTime> op_Explicit(JToken value) { }

	// RVA: 0xE41C20 Offset: 0xE40220 VA: 0x180E41C20
	public static Nullable<DateTimeOffset> op_Explicit(JToken value) { }

	// RVA: 0xE3F6E0 Offset: 0xE3DCE0 VA: 0x180E3F6E0
	public static Nullable<Decimal> op_Explicit(JToken value) { }

	// RVA: 0xE419D0 Offset: 0xE3FFD0 VA: 0x180E419D0
	public static Nullable<double> op_Explicit(JToken value) { }

	// RVA: 0xE3ED80 Offset: 0xE3D380 VA: 0x180E3ED80
	public static Nullable<char> op_Explicit(JToken value) { }

	// RVA: 0xE42FA0 Offset: 0xE415A0 VA: 0x180E42FA0
	public static int op_Explicit(JToken value) { }

	// RVA: 0xE40580 Offset: 0xE3EB80 VA: 0x180E40580
	public static short op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE42220 Offset: 0xE40820 VA: 0x180E42220
	public static ushort op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE3DE40 Offset: 0xE3C440 VA: 0x180E3DE40
	public static char op_Explicit(JToken value) { }

	// RVA: 0xE3FED0 Offset: 0xE3E4D0 VA: 0x180E3FED0
	public static byte op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE3EBA0 Offset: 0xE3D1A0 VA: 0x180E3EBA0
	public static sbyte op_Explicit(JToken value) { }

	// RVA: 0xE41100 Offset: 0xE3F700 VA: 0x180E41100
	public static Nullable<int> op_Explicit(JToken value) { }

	// RVA: 0xE415A0 Offset: 0xE3FBA0 VA: 0x180E415A0
	public static Nullable<short> op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE42400 Offset: 0xE40A00 VA: 0x180E42400
	public static Nullable<ushort> op_Explicit(JToken value) { }

	// RVA: 0xE41350 Offset: 0xE3F950 VA: 0x180E41350
	public static Nullable<byte> op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE40760 Offset: 0xE3ED60 VA: 0x180E40760
	public static Nullable<sbyte> op_Explicit(JToken value) { }

	// RVA: 0xE41FE0 Offset: 0xE405E0 VA: 0x180E41FE0
	public static DateTime op_Explicit(JToken value) { }

	// RVA: 0xE3F1B0 Offset: 0xE3D7B0 VA: 0x180E3F1B0
	public static Nullable<long> op_Explicit(JToken value) { }

	// RVA: 0xE40C60 Offset: 0xE3F260 VA: 0x180E40C60
	public static Nullable<float> op_Explicit(JToken value) { }

	// RVA: 0xE3F960 Offset: 0xE3DF60 VA: 0x180E3F960
	public static Decimal op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE428A0 Offset: 0xE40EA0 VA: 0x180E428A0
	public static Nullable<uint> op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE42650 Offset: 0xE40C50 VA: 0x180E42650
	public static Nullable<ulong> op_Explicit(JToken value) { }

	// RVA: 0xE3EFD0 Offset: 0xE3D5D0 VA: 0x180E3EFD0
	public static double op_Explicit(JToken value) { }

	// RVA: 0xE417F0 Offset: 0xE3FDF0 VA: 0x180E417F0
	public static float op_Explicit(JToken value) { }

	// RVA: 0xE409B0 Offset: 0xE3EFB0 VA: 0x180E409B0
	public static string op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE403A0 Offset: 0xE3E9A0 VA: 0x180E403A0
	public static uint op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE3E450 Offset: 0xE3CA50 VA: 0x180E3E450
	public static ulong op_Explicit(JToken value) { }

	// RVA: 0xE42CD0 Offset: 0xE412D0 VA: 0x180E42CD0
	public static Guid op_Explicit(JToken value) { }

	// RVA: 0xE3FB50 Offset: 0xE3E150 VA: 0x180E3FB50
	public static Nullable<Guid> op_Explicit(JToken value) { }

	// RVA: 0xE3E020 Offset: 0xE3C620 VA: 0x180E3E020
	public static TimeSpan op_Explicit(JToken value) { }

	// RVA: 0xE3E8E0 Offset: 0xE3CEE0 VA: 0x180E3E8E0
	public static Nullable<TimeSpan> op_Explicit(JToken value) { }

	// RVA: 0xE3F400 Offset: 0xE3DA00 VA: 0x180E3F400
	public static Uri op_Explicit(JToken value) { }

	// RVA: 0xE3BEA0 Offset: 0xE3A4A0 VA: 0x180E3BEA0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xE3BE40 Offset: 0xE3A440 VA: 0x180E3BE40 Slot: 4
	private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract int GetDeepHashCode();

	// RVA: 0xE3B100 Offset: 0xE39700 VA: 0x180E3B100
	public JsonReader CreateReader() { }

	// RVA: -1 Offset: -1
	public T ToObject<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CFAA0 Offset: 0x5CE0A0 VA: 0x1805CFAA0
	|-JToken.ToObject<UITwitchTrophy.TrophyPage>
	|-JToken.ToObject<object>
	*/

	// RVA: 0xE3C030 Offset: 0xE3A630 VA: 0x180E3C030
	public object ToObject(Type objectType) { }

	// RVA: 0xE3BEE0 Offset: 0xE3A4E0 VA: 0x180E3BEE0
	public object ToObject(Type objectType, JsonSerializer jsonSerializer) { }

	// RVA: 0xE3B860 Offset: 0xE39E60 VA: 0x180E3B860
	public static JToken ReadFrom(JsonReader reader) { }

	// RVA: 0xE3B8C0 Offset: 0xE39EC0 VA: 0x180E3B8C0
	public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xE3B800 Offset: 0xE39E00 VA: 0x180E3B800
	public static JToken Parse(string json) { }

	// RVA: 0xE3B630 Offset: 0xE39C30 VA: 0x180E3B630
	public static JToken Parse(string json, JsonLoadSettings settings) { }

	// RVA: 0xE3B4E0 Offset: 0xE39AE0 VA: 0x180E3B4E0
	public static JToken Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xE3BD50 Offset: 0xE3A350 VA: 0x180E3BD50
	internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings) { }

	// RVA: 0xE3BCD0 Offset: 0xE3A2D0 VA: 0x180E3BCD0
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0xE3B550 Offset: 0xE39B50 VA: 0x180E3B550 Slot: 6
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0xE3B590 Offset: 0xE39B90 VA: 0x180E3B590 Slot: 7
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0xE3B5E0 Offset: 0xE39BE0 VA: 0x180E3B5E0 Slot: 8
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0xE3B190 Offset: 0xE39790 VA: 0x180E3B190 Slot: 9
	private object System.ICloneable.Clone() { }

	// RVA: 0xE3B190 Offset: 0xE39790 VA: 0x180E3B190
	public JToken DeepClone() { }

	// RVA: 0xE3ADD0 Offset: 0xE393D0 VA: 0x180E3ADD0
	public void AddAnnotation(object annotation) { }

	// RVA: -1 Offset: -1
	public T Annotation<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CF900 Offset: 0x5CDF00 VA: 0x1805CF900
	|-JToken.Annotation<JToken.LineInfoAnnotation>
	|-JToken.Annotation<object>
	*/

	// RVA: 0xE3D1B0 Offset: 0xE3B7B0 VA: 0x180E3D1B0
	private static void .cctor() { }

}

private class JToken.LineInfoAnnotation // TypeDefIndex: 6067
{	// Fields
	internal readonly int LineNumber; // 0x10
	internal readonly int LinePosition; // 0x14

	// Methods

	// RVA: 0x45E8C0 Offset: 0x45CEC0 VA: 0x18045E8C0
	public void .ctor(int lineNumber, int linePosition) { }

}

public class JProperty : JContainer // TypeDefIndex: 6073
{
// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
private sealed class JToken.<AfterSelf>d__42 // TypeDefIndex: 6069

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
private sealed class JToken.<BeforeSelf>d__43 // TypeDefIndex: 6070

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
private sealed class JToken.<Annotations>d__171<T> // TypeDefIndex: 6071

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
private sealed class JToken.<Annotations>d__172 // TypeDefIndex: 6072

// Namespace: Newtonsoft.Json.Linq
[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
public class JProperty : JContainer // TypeDefIndex: 6073
	// Fields
	private readonly JProperty.JPropertyList _content; // 0x48
	private readonly string _name; // 0x50

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	public string Name { get; }
	public JToken Value { get; set; }
	public override JTokenType Type { get; }

	// Methods

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 45
	protected override IList<JToken> get_ChildrenTokens() { }

	[DebuggerStepThroughAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public string get_Name() { }

	[DebuggerStepThroughAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE37E60 Offset: 0xE36460 VA: 0x180E37E60
	public JToken get_Value() { }

	// RVA: 0xE37E80 Offset: 0xE36480 VA: 0x180E37E80
	public void set_Value(JToken value) { }

	// RVA: 0xE37AD0 Offset: 0xE360D0 VA: 0x180E37AD0
	public void .ctor(JProperty other) { }

	// RVA: 0xE37250 Offset: 0xE35850 VA: 0x180E37250 Slot: 51
	internal override JToken GetItem(int index) { }

	// RVA: 0xE377B0 Offset: 0xE35DB0 VA: 0x180E377B0 Slot: 52
	internal override void SetItem(int index, JToken item) { }

	// RVA: 0xE376E0 Offset: 0xE35CE0 VA: 0x180E376E0 Slot: 50
	internal override bool RemoveItem(JToken item) { }

	// RVA: 0xE37610 Offset: 0xE35C10 VA: 0x180E37610 Slot: 49
	internal override void RemoveItemAt(int index) { }

	// RVA: 0xE372D0 Offset: 0xE358D0 VA: 0x180E372D0 Slot: 47
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xE37300 Offset: 0xE35900 VA: 0x180E37300 Slot: 48
	internal override void InsertItem(int index, JToken item, bool skipParentCheck) { }

	// RVA: 0xE37000 Offset: 0xE35600 VA: 0x180E37000 Slot: 55
	internal override bool ContainsItem(JToken item) { }

	// RVA: 0xE36E70 Offset: 0xE35470 VA: 0x180E36E70 Slot: 53
	internal override void ClearItems() { }

	// RVA: 0xE37020 Offset: 0xE35620 VA: 0x180E37020 Slot: 11
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0xE36F40 Offset: 0xE35540 VA: 0x180E36F40 Slot: 10
	internal override JToken CloneToken() { }

	[DebuggerStepThroughAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE37E50 Offset: 0xE36450 VA: 0x180E37E50 Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0xE37D80 Offset: 0xE36380 VA: 0x180E37D80
	internal void .ctor(string name) { }

	// RVA: 0xE37B60 Offset: 0xE36160 VA: 0x180E37B60
	public void .ctor(string name, object content) { }

	// RVA: 0xE37A30 Offset: 0xE36030 VA: 0x180E37A30 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE371E0 Offset: 0xE357E0 VA: 0x180E371E0 Slot: 18
	internal override int GetDeepHashCode() { }

	// RVA: 0xE37420 Offset: 0xE35A20 VA: 0x180E37420
	public static JProperty Load(JsonReader reader, JsonLoadSettings settings) { }

}

private class JProperty.JPropertyList : IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable // TypeDefIndex: 6074
{	// Fields
	internal JToken _token; // 0x10

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	public JToken Item { get; set; }

	// Methods

	// RVA: 0xE36D60 Offset: 0xE35360 VA: 0x180E36D60 Slot: 16
	public IEnumerator<JToken> GetEnumerator() { }

	// RVA: 0xE36D60 Offset: 0xE35360 VA: 0x180E36D60 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630 Slot: 11
	public void Add(JToken item) { }

	// RVA: 0xE36CA0 Offset: 0xE352A0 VA: 0x180E36CA0 Slot: 12
	public void Clear() { }

	// RVA: 0xE36CC0 Offset: 0xE352C0 VA: 0x180E36CC0 Slot: 13
	public bool Contains(JToken item) { }

	// RVA: 0xE36CD0 Offset: 0xE352D0 VA: 0x180E36CD0 Slot: 14
	public void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0xE36E20 Offset: 0xE35420 VA: 0x180E36E20 Slot: 15
	public bool Remove(JToken item) { }

	// RVA: 0xE36E50 Offset: 0xE35450 VA: 0x180E36E50 Slot: 9
	public int get_Count() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0xE36DD0 Offset: 0xE353D0 VA: 0x180E36DD0 Slot: 6
	public int IndexOf(JToken item) { }

	// RVA: 0xE36DE0 Offset: 0xE353E0 VA: 0x180E36DE0 Slot: 7
	public void Insert(int index, JToken item) { }

	// RVA: 0xE36E00 Offset: 0xE35400 VA: 0x180E36E00 Slot: 8
	public void RemoveAt(int index) { }

	// RVA: 0xE36E60 Offset: 0xE35460 VA: 0x180E36E60 Slot: 4
	public JToken get_Item(int index) { }

	// RVA: 0xE36DE0 Offset: 0xE353E0 VA: 0x180E36DE0 Slot: 5
	public void set_Item(int index, JToken value) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class JProperty.JPropertyList.<GetEnumerator>d__1 : IEnumerator<JToken>, IDisposable, IEnumerator // TypeDefIndex: 6075
{	// Fields
	private int <>1__state; // 0x10
	private JToken <>2__current; // 0x18
	public JProperty.JPropertyList <>4__this; // 0x20

	// Properties
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE4C880 Offset: 0xE4AE80 VA: 0x180E4C880 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE4C8E0 Offset: 0xE4AEE0 VA: 0x180E4C8E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public enum JTokenType // TypeDefIndex: 6076
{	// Fields
	public int value__; // 0x0
	public const JTokenType None = 0;
	public const JTokenType Object = 1;
	public const JTokenType Array = 2;
	public const JTokenType Constructor = 3;
	public const JTokenType Property = 4;
	public const JTokenType Comment = 5;
	public const JTokenType Integer = 6;
	public const JTokenType Float = 7;
	public const JTokenType String = 8;
	public const JTokenType Boolean = 9;
	public const JTokenType Null = 10;
	public const JTokenType Undefined = 11;
	public const JTokenType Date = 12;
	public const JTokenType Raw = 13;
	public const JTokenType Bytes = 14;
	public const JTokenType Guid = 15;
	public const JTokenType Uri = 16;
	public const JTokenType TimeSpan = 17;

}

public class JValue : JToken, IFormattable, IComparable, IConvertible // TypeDefIndex: 6077
{	// Fields
	private JTokenType _valueType; // 0x30
	private object _value; // 0x38

	// Properties
	public override bool HasValues { get; }
	public override JTokenType Type { get; }
	public object Value { get; }

	// Methods

	// RVA: 0xE45980 Offset: 0xE43F80 VA: 0x180E45980
	internal void .ctor(object value, JTokenType type) { }

	// RVA: 0xE381F0 Offset: 0xE367F0 VA: 0x180E381F0
	public void .ctor(JValue other) { }

	// RVA: 0xE45940 Offset: 0xE43F40 VA: 0x180E45940
	public void .ctor(object value) { }

	// RVA: 0xE43E80 Offset: 0xE42480 VA: 0x180E43E80 Slot: 11
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 13
	public override bool get_HasValues() { }

	// RVA: 0xE43330 Offset: 0xE41930 VA: 0x180E43330
	internal static int Compare(JTokenType valueType, object objA, object objB) { }

	// RVA: 0xE43240 Offset: 0xE41840 VA: 0x180E43240
	private static int CompareFloat(object objA, object objB) { }

	// RVA: 0xE43180 Offset: 0xE41780 VA: 0x180E43180 Slot: 10
	internal override JToken CloneToken() { }

	// RVA: 0xE43CA0 Offset: 0xE422A0 VA: 0x180E43CA0
	public static JValue CreateComment(string value) { }

	// RVA: 0xE43D40 Offset: 0xE42340 VA: 0x180E43D40
	public static JValue CreateNull() { }

	// RVA: 0xE43DE0 Offset: 0xE423E0 VA: 0x180E43DE0
	public static JValue CreateUndefined() { }

	// RVA: 0xE44140 Offset: 0xE42740 VA: 0x180E44140
	private static JTokenType GetValueType(Nullable<JTokenType> current, object value) { }

	// RVA: 0xE440E0 Offset: 0xE426E0 VA: 0x180E440E0
	private static JTokenType GetStringValueType(Nullable<JTokenType> current) { }

	// RVA: 0xA38CE0 Offset: 0xA372E0 VA: 0x180A38CE0 Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public object get_Value() { }

	// RVA: 0xE44F50 Offset: 0xE43550 VA: 0x180E44F50 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE44070 Offset: 0xE42670 VA: 0x180E44070 Slot: 18
	internal override int GetDeepHashCode() { }

	// RVA: 0xE44F00 Offset: 0xE43500 VA: 0x180E44F00
	private static bool ValuesEquals(JValue v1, JValue v2) { }

	// RVA: 0xE44020 Offset: 0xE42620 VA: 0x180E44020
	public bool Equals(JValue other) { }

	// RVA: 0xE43F40 Offset: 0xE42540 VA: 0x180E43F40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xE440C0 Offset: 0xE426C0 VA: 0x180E440C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xE44C40 Offset: 0xE43240 VA: 0x180E44C40 Slot: 3
	public override string ToString() { }

	// RVA: 0xE44CA0 Offset: 0xE432A0 VA: 0x180E44CA0 Slot: 36
	public string ToString(IFormatProvider formatProvider) { }

	// RVA: 0xE44DC0 Offset: 0xE433C0 VA: 0x180E44DC0 Slot: 19
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0xE44550 Offset: 0xE42B50 VA: 0x180E44550 Slot: 20
	private int System.IComparable.CompareTo(object obj) { }

	// RVA: 0xE44670 Offset: 0xE42C70 VA: 0x180E44670 Slot: 21
	private TypeCode System.IConvertible.GetTypeCode() { }

	// RVA: 0xE446E0 Offset: 0xE42CE0 VA: 0x180E446E0 Slot: 22
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0xE447A0 Offset: 0xE42DA0 VA: 0x180E447A0 Slot: 23
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0xE44A50 Offset: 0xE43050 VA: 0x180E44A50 Slot: 24
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0xE44740 Offset: 0xE42D40 VA: 0x180E44740 Slot: 25
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0xE44930 Offset: 0xE42F30 VA: 0x180E44930 Slot: 26
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0xE44B20 Offset: 0xE43120 VA: 0x180E44B20 Slot: 27
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0xE44990 Offset: 0xE42F90 VA: 0x180E44990 Slot: 28
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0xE44B80 Offset: 0xE43180 VA: 0x180E44B80 Slot: 29
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0xE449F0 Offset: 0xE42FF0 VA: 0x180E449F0 Slot: 30
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0xE44BE0 Offset: 0xE431E0 VA: 0x180E44BE0 Slot: 31
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0xE44AB0 Offset: 0xE430B0 VA: 0x180E44AB0 Slot: 32
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0xE448D0 Offset: 0xE42ED0 VA: 0x180E448D0 Slot: 33
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0xE44860 Offset: 0xE42E60 VA: 0x180E44860 Slot: 34
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0xE44800 Offset: 0xE42E00 VA: 0x180E44800 Slot: 35
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0xE44B10 Offset: 0xE43110 VA: 0x180E44B10 Slot: 37
	private object System.IConvertible.ToType(Type conversionType, IFormatProvider provider) { }

}

public static class JSON // TypeDefIndex: 11582
{	// Fields
	private static readonly Type includeAttrType; // 0x0
	private static readonly Type excludeAttrType; // 0x8
	private static readonly Type decodeAliasAttrType; // 0x10
	private static readonly Dictionary<string, Type> typeCache; // 0x18
	private const BindingFlags instanceBindingFlags = 52;
	private const BindingFlags staticBindingFlags = 56;
	private static readonly MethodInfo decodeTypeMethod; // 0x20
	private static readonly MethodInfo decodeListMethod; // 0x28
	private static readonly MethodInfo decodeDictionaryMethod; // 0x30
	private static readonly MethodInfo decodeArrayMethod; // 0x38
	private static readonly MethodInfo decodeMultiRankArrayMethod; // 0x40

	// Methods

	// RVA: 0x87A9B0 Offset: 0x878FB0 VA: 0x18087A9B0
	public static Variant Load(string json) { }

	// RVA: 0x87A790 Offset: 0x878D90 VA: 0x18087A790
	public static string Dump(object data) { }

	// RVA: 0x87A5A0 Offset: 0x878BA0 VA: 0x18087A5A0
	public static string Dump(object data, EncodeOptions options) { }

	// RVA: -1 Offset: -1
	public static void MakeInto<T>(Variant data, out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CEB70 Offset: 0x5CD170 VA: 0x1805CEB70
	|-JSON.MakeInto<object>
	*/

	// RVA: 0x87A7F0 Offset: 0x878DF0 VA: 0x18087A7F0
	private static Type FindType(string fullName) { }

	[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	private static T DecodeType<T>(Variant data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD9F00 Offset: 0xBD8500 VA: 0x180BD9F00
	|-JSON.DecodeType<bool>
	|
	|-RVA: 0xBDBEE0 Offset: 0xBDA4E0 VA: 0x180BDBEE0
	|-JSON.DecodeType<Decimal>
	|
	|-RVA: 0xBDDEA0 Offset: 0xBDC4A0 VA: 0x180BDDEA0
	|-JSON.DecodeType<double>
	|
	|-RVA: 0x15A9370 Offset: 0x15A7970 VA: 0x1815A9370
	|-JSON.DecodeType<short>
	|
	|-RVA: 0x15AB340 Offset: 0x15A9940 VA: 0x1815AB340
	|-JSON.DecodeType<int>
	|
	|-RVA: 0x15AD2E0 Offset: 0x15AB8E0 VA: 0x1815AD2E0
	|-JSON.DecodeType<long>
	|
	|-RVA: 0x15AF2B0 Offset: 0x15AD8B0 VA: 0x1815AF2B0
	|-JSON.DecodeType<object>
	|
	|-RVA: 0x15B11D0 Offset: 0x15AF7D0 VA: 0x1815B11D0
	|-JSON.DecodeType<float>
	|
	|-RVA: 0x15B3170 Offset: 0x15B1770 VA: 0x1815B3170
	|-JSON.DecodeType<ushort>
	|
	|-RVA: 0x15B5140 Offset: 0x15B3740 VA: 0x1815B5140
	|-JSON.DecodeType<uint>
	|
	|-RVA: 0x15B70E0 Offset: 0x15B56E0 VA: 0x1815B70E0
	|-JSON.DecodeType<ulong>
	*/

	[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	private static List<T> DecodeList<T>(Variant data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AD510 Offset: 0x12ABB10 VA: 0x1812AD510
	|-JSON.DecodeList<bool>
	|
	|-RVA: 0x12AD700 Offset: 0x12ABD00 VA: 0x1812AD700
	|-JSON.DecodeList<Decimal>
	|
	|-RVA: 0x12AD900 Offset: 0x12ABF00 VA: 0x1812AD900
	|-JSON.DecodeList<double>
	|
	|-RVA: 0x12ADAF0 Offset: 0x12AC0F0 VA: 0x1812ADAF0
	|-JSON.DecodeList<short>
	|
	|-RVA: 0x12ADCE0 Offset: 0x12AC2E0 VA: 0x1812ADCE0
	|-JSON.DecodeList<int>
	|
	|-RVA: 0x12ADED0 Offset: 0x12AC4D0 VA: 0x1812ADED0
	|-JSON.DecodeList<long>
	|
	|-RVA: 0x12AE0C0 Offset: 0x12AC6C0 VA: 0x1812AE0C0
	|-JSON.DecodeList<object>
	|
	|-RVA: 0x12AE2B0 Offset: 0x12AC8B0 VA: 0x1812AE2B0
	|-JSON.DecodeList<float>
	|
	|-RVA: 0x12AE4A0 Offset: 0x12ACAA0 VA: 0x1812AE4A0
	|-JSON.DecodeList<ushort>
	|
	|-RVA: 0x12AE690 Offset: 0x12ACC90 VA: 0x1812AE690
	|-JSON.DecodeList<uint>
	|
	|-RVA: 0x12AE880 Offset: 0x12ACE80 VA: 0x1812AE880
	|-JSON.DecodeList<ulong>
	*/

	[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	private static Dictionary<TKey, TValue> DecodeDictionary<TKey, TValue>(Variant data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1538DE0 Offset: 0x15373E0 VA: 0x181538DE0
	|-JSON.DecodeDictionary<bool, bool>
	|
	|-RVA: 0x1539170 Offset: 0x1537770 VA: 0x181539170
	|-JSON.DecodeDictionary<bool, Decimal>
	|
	|-RVA: 0x1539500 Offset: 0x1537B00 VA: 0x181539500
	|-JSON.DecodeDictionary<bool, double>
	|
	|-RVA: 0x1539890 Offset: 0x1537E90 VA: 0x181539890
	|-JSON.DecodeDictionary<bool, short>
	|
	|-RVA: 0x1539C20 Offset: 0x1538220 VA: 0x181539C20
	|-JSON.DecodeDictionary<bool, int>
	|
	|-RVA: 0x1539FB0 Offset: 0x15385B0 VA: 0x181539FB0
	|-JSON.DecodeDictionary<bool, long>
	|
	|-RVA: 0x153A340 Offset: 0x1538940 VA: 0x18153A340
	|-JSON.DecodeDictionary<bool, object>
	|
	|-RVA: 0x153A6D0 Offset: 0x1538CD0 VA: 0x18153A6D0
	|-JSON.DecodeDictionary<bool, float>
	|
	|-RVA: 0x153AA60 Offset: 0x1539060 VA: 0x18153AA60
	|-JSON.DecodeDictionary<bool, ushort>
	|
	|-RVA: 0x153ADF0 Offset: 0x15393F0 VA: 0x18153ADF0
	|-JSON.DecodeDictionary<bool, uint>
	|
	|-RVA: 0x153B180 Offset: 0x1539780 VA: 0x18153B180
	|-JSON.DecodeDictionary<bool, ulong>
	|
	|-RVA: 0x153B510 Offset: 0x1539B10 VA: 0x18153B510
	|-JSON.DecodeDictionary<Decimal, bool>
	|
	|-RVA: 0x153B8A0 Offset: 0x1539EA0 VA: 0x18153B8A0
	|-JSON.DecodeDictionary<Decimal, Decimal>
	|
	|-RVA: 0x153BC40 Offset: 0x153A240 VA: 0x18153BC40
	|-JSON.DecodeDictionary<Decimal, double>
	|
	|-RVA: 0x153BFD0 Offset: 0x153A5D0 VA: 0x18153BFD0
	|-JSON.DecodeDictionary<Decimal, short>
	|
	|-RVA: 0x153C360 Offset: 0x153A960 VA: 0x18153C360
	|-JSON.DecodeDictionary<Decimal, int>
	|
	|-RVA: 0x153C6F0 Offset: 0x153ACF0 VA: 0x18153C6F0
	|-JSON.DecodeDictionary<Decimal, long>
	|
	|-RVA: 0x153CA80 Offset: 0x153B080 VA: 0x18153CA80
	|-JSON.DecodeDictionary<Decimal, object>
	|
	|-RVA: 0x153CE10 Offset: 0x153B410 VA: 0x18153CE10
	|-JSON.DecodeDictionary<Decimal, float>
	|
	|-RVA: 0x153D1A0 Offset: 0x153B7A0 VA: 0x18153D1A0
	|-JSON.DecodeDictionary<Decimal, ushort>
	|
	|-RVA: 0x153D530 Offset: 0x153BB30 VA: 0x18153D530
	|-JSON.DecodeDictionary<Decimal, uint>
	|
	|-RVA: 0x153D8C0 Offset: 0x153BEC0 VA: 0x18153D8C0
	|-JSON.DecodeDictionary<Decimal, ulong>
	|
	|-RVA: 0x153DC50 Offset: 0x153C250 VA: 0x18153DC50
	|-JSON.DecodeDictionary<double, bool>
	|
	|-RVA: 0x153DFE0 Offset: 0x153C5E0 VA: 0x18153DFE0
	|-JSON.DecodeDictionary<double, Decimal>
	|
	|-RVA: 0x153E380 Offset: 0x153C980 VA: 0x18153E380
	|-JSON.DecodeDictionary<double, double>
	|
	|-RVA: 0x153E710 Offset: 0x153CD10 VA: 0x18153E710
	|-JSON.DecodeDictionary<double, short>
	|
	|-RVA: 0x153EAA0 Offset: 0x153D0A0 VA: 0x18153EAA0
	|-JSON.DecodeDictionary<double, int>
	|
	|-RVA: 0x153EE30 Offset: 0x153D430 VA: 0x18153EE30
	|-JSON.DecodeDictionary<double, long>
	|
	|-RVA: 0x153F1C0 Offset: 0x153D7C0 VA: 0x18153F1C0
	|-JSON.DecodeDictionary<double, object>
	|
	|-RVA: 0x153F550 Offset: 0x153DB50 VA: 0x18153F550
	|-JSON.DecodeDictionary<double, float>
	|
	|-RVA: 0x153F8E0 Offset: 0x153DEE0 VA: 0x18153F8E0
	|-JSON.DecodeDictionary<double, ushort>
	|
	|-RVA: 0x153FC70 Offset: 0x153E270 VA: 0x18153FC70
	|-JSON.DecodeDictionary<double, uint>
	|
	|-RVA: 0x1540000 Offset: 0x153E600 VA: 0x181540000
	|-JSON.DecodeDictionary<double, ulong>
	|
	|-RVA: 0x1540390 Offset: 0x153E990 VA: 0x181540390
	|-JSON.DecodeDictionary<short, bool>
	|
	|-RVA: 0x1540720 Offset: 0x153ED20 VA: 0x181540720
	|-JSON.DecodeDictionary<short, Decimal>
	|
	|-RVA: 0x1540AB0 Offset: 0x153F0B0 VA: 0x181540AB0
	|-JSON.DecodeDictionary<short, double>
	|
	|-RVA: 0x1540E40 Offset: 0x153F440 VA: 0x181540E40
	|-JSON.DecodeDictionary<short, short>
	|
	|-RVA: 0x15411D0 Offset: 0x153F7D0 VA: 0x1815411D0
	|-JSON.DecodeDictionary<short, int>
	|
	|-RVA: 0x1541560 Offset: 0x153FB60 VA: 0x181541560
	|-JSON.DecodeDictionary<short, long>
	|
	|-RVA: 0x15418F0 Offset: 0x153FEF0 VA: 0x1815418F0
	|-JSON.DecodeDictionary<short, object>
	|
	|-RVA: 0x1541C80 Offset: 0x1540280 VA: 0x181541C80
	|-JSON.DecodeDictionary<short, float>
	|
	|-RVA: 0x1542010 Offset: 0x1540610 VA: 0x181542010
	|-JSON.DecodeDictionary<short, ushort>
	|
	|-RVA: 0x15423A0 Offset: 0x15409A0 VA: 0x1815423A0
	|-JSON.DecodeDictionary<short, uint>
	|
	|-RVA: 0x1542730 Offset: 0x1540D30 VA: 0x181542730
	|-JSON.DecodeDictionary<short, ulong>
	|
	|-RVA: 0x1542AC0 Offset: 0x15410C0 VA: 0x181542AC0
	|-JSON.DecodeDictionary<int, bool>
	|
	|-RVA: 0x1542E50 Offset: 0x1541450 VA: 0x181542E50
	|-JSON.DecodeDictionary<int, Decimal>
	|
	|-RVA: 0x15431E0 Offset: 0x15417E0 VA: 0x1815431E0
	|-JSON.DecodeDictionary<int, double>
	|
	|-RVA: 0x1543570 Offset: 0x1541B70 VA: 0x181543570
	|-JSON.DecodeDictionary<int, short>
	|
	|-RVA: 0x1543900 Offset: 0x1541F00 VA: 0x181543900
	|-JSON.DecodeDictionary<int, int>
	|
	|-RVA: 0x1543C90 Offset: 0x1542290 VA: 0x181543C90
	|-JSON.DecodeDictionary<int, long>
	|
	|-RVA: 0x1544020 Offset: 0x1542620 VA: 0x181544020
	|-JSON.DecodeDictionary<int, object>
	|
	|-RVA: 0x15443B0 Offset: 0x15429B0 VA: 0x1815443B0
	|-JSON.DecodeDictionary<int, float>
	|
	|-RVA: 0x1544740 Offset: 0x1542D40 VA: 0x181544740
	|-JSON.DecodeDictionary<int, ushort>
	|
	|-RVA: 0x1544AD0 Offset: 0x15430D0 VA: 0x181544AD0
	|-JSON.DecodeDictionary<int, uint>
	|
	|-RVA: 0x1544E60 Offset: 0x1543460 VA: 0x181544E60
	|-JSON.DecodeDictionary<int, ulong>
	|
	|-RVA: 0x15451F0 Offset: 0x15437F0 VA: 0x1815451F0
	|-JSON.DecodeDictionary<long, bool>
	|
	|-RVA: 0x1545580 Offset: 0x1543B80 VA: 0x181545580
	|-JSON.DecodeDictionary<long, Decimal>
	|
	|-RVA: 0x1545910 Offset: 0x1543F10 VA: 0x181545910
	|-JSON.DecodeDictionary<long, double>
	|
	|-RVA: 0x1545CA0 Offset: 0x15442A0 VA: 0x181545CA0
	|-JSON.DecodeDictionary<long, short>
	|
	|-RVA: 0x1546030 Offset: 0x1544630 VA: 0x181546030
	|-JSON.DecodeDictionary<long, int>
	|
	|-RVA: 0x15463C0 Offset: 0x15449C0 VA: 0x1815463C0
	|-JSON.DecodeDictionary<long, long>
	|
	|-RVA: 0x1546750 Offset: 0x1544D50 VA: 0x181546750
	|-JSON.DecodeDictionary<long, object>
	|
	|-RVA: 0x1546AE0 Offset: 0x15450E0 VA: 0x181546AE0
	|-JSON.DecodeDictionary<long, float>
	|
	|-RVA: 0x1546E70 Offset: 0x1545470 VA: 0x181546E70
	|-JSON.DecodeDictionary<long, ushort>
	|
	|-RVA: 0x1547200 Offset: 0x1545800 VA: 0x181547200
	|-JSON.DecodeDictionary<long, uint>
	|
	|-RVA: 0x1547590 Offset: 0x1545B90 VA: 0x181547590
	|-JSON.DecodeDictionary<long, ulong>
	|
	|-RVA: 0x1547920 Offset: 0x1545F20 VA: 0x181547920
	|-JSON.DecodeDictionary<object, bool>
	|
	|-RVA: 0x1547CC0 Offset: 0x15462C0 VA: 0x181547CC0
	|-JSON.DecodeDictionary<object, Decimal>
	|
	|-RVA: 0x1548060 Offset: 0x1546660 VA: 0x181548060
	|-JSON.DecodeDictionary<object, double>
	|
	|-RVA: 0x1548400 Offset: 0x1546A00 VA: 0x181548400
	|-JSON.DecodeDictionary<object, short>
	|
	|-RVA: 0x15487A0 Offset: 0x1546DA0 VA: 0x1815487A0
	|-JSON.DecodeDictionary<object, int>
	|
	|-RVA: 0x1548B40 Offset: 0x1547140 VA: 0x181548B40
	|-JSON.DecodeDictionary<object, long>
	|
	|-RVA: 0x1548EE0 Offset: 0x15474E0 VA: 0x181548EE0
	|-JSON.DecodeDictionary<object, object>
	|
	|-RVA: 0x1549280 Offset: 0x1547880 VA: 0x181549280
	|-JSON.DecodeDictionary<object, float>
	|
	|-RVA: 0x1549620 Offset: 0x1547C20 VA: 0x181549620
	|-JSON.DecodeDictionary<object, ushort>
	|
	|-RVA: 0x15499C0 Offset: 0x1547FC0 VA: 0x1815499C0
	|-JSON.DecodeDictionary<object, uint>
	|
	|-RVA: 0x1549D60 Offset: 0x1548360 VA: 0x181549D60
	|-JSON.DecodeDictionary<object, ulong>
	|
	|-RVA: 0x154A100 Offset: 0x1548700 VA: 0x18154A100
	|-JSON.DecodeDictionary<float, bool>
	|
	|-RVA: 0x154A490 Offset: 0x1548A90 VA: 0x18154A490
	|-JSON.DecodeDictionary<float, Decimal>
	|
	|-RVA: 0x154A830 Offset: 0x1548E30 VA: 0x18154A830
	|-JSON.DecodeDictionary<float, double>
	|
	|-RVA: 0x154ABC0 Offset: 0x15491C0 VA: 0x18154ABC0
	|-JSON.DecodeDictionary<float, short>
	|
	|-RVA: 0x154AF50 Offset: 0x1549550 VA: 0x18154AF50
	|-JSON.DecodeDictionary<float, int>
	|
	|-RVA: 0x154B2E0 Offset: 0x15498E0 VA: 0x18154B2E0
	|-JSON.DecodeDictionary<float, long>
	|
	|-RVA: 0x154B670 Offset: 0x1549C70 VA: 0x18154B670
	|-JSON.DecodeDictionary<float, object>
	|
	|-RVA: 0x154BA00 Offset: 0x154A000 VA: 0x18154BA00
	|-JSON.DecodeDictionary<float, float>
	|
	|-RVA: 0x154BD90 Offset: 0x154A390 VA: 0x18154BD90
	|-JSON.DecodeDictionary<float, ushort>
	|
	|-RVA: 0x154C120 Offset: 0x154A720 VA: 0x18154C120
	|-JSON.DecodeDictionary<float, uint>
	|
	|-RVA: 0x154C4B0 Offset: 0x154AAB0 VA: 0x18154C4B0
	|-JSON.DecodeDictionary<float, ulong>
	|
	|-RVA: 0x154C840 Offset: 0x154AE40 VA: 0x18154C840
	|-JSON.DecodeDictionary<ushort, bool>
	|
	|-RVA: 0x154CBD0 Offset: 0x154B1D0 VA: 0x18154CBD0
	|-JSON.DecodeDictionary<ushort, Decimal>
	|
	|-RVA: 0x154CF60 Offset: 0x154B560 VA: 0x18154CF60
	|-JSON.DecodeDictionary<ushort, double>
	|
	|-RVA: 0x154D2F0 Offset: 0x154B8F0 VA: 0x18154D2F0
	|-JSON.DecodeDictionary<ushort, short>
	|
	|-RVA: 0x154D680 Offset: 0x154BC80 VA: 0x18154D680
	|-JSON.DecodeDictionary<ushort, int>
	|
	|-RVA: 0x154DA10 Offset: 0x154C010 VA: 0x18154DA10
	|-JSON.DecodeDictionary<ushort, long>
	|
	|-RVA: 0x154DDA0 Offset: 0x154C3A0 VA: 0x18154DDA0
	|-JSON.DecodeDictionary<ushort, object>
	|
	|-RVA: 0x154E130 Offset: 0x154C730 VA: 0x18154E130
	|-JSON.DecodeDictionary<ushort, float>
	|
	|-RVA: 0x154E4C0 Offset: 0x154CAC0 VA: 0x18154E4C0
	|-JSON.DecodeDictionary<ushort, ushort>
	|
	|-RVA: 0x154E850 Offset: 0x154CE50 VA: 0x18154E850
	|-JSON.DecodeDictionary<ushort, uint>
	|
	|-RVA: 0x154EBE0 Offset: 0x154D1E0 VA: 0x18154EBE0
	|-JSON.DecodeDictionary<ushort, ulong>
	|
	|-RVA: 0x154EF70 Offset: 0x154D570 VA: 0x18154EF70
	|-JSON.DecodeDictionary<uint, bool>
	|
	|-RVA: 0x154F300 Offset: 0x154D900 VA: 0x18154F300
	|-JSON.DecodeDictionary<uint, Decimal>
	|
	|-RVA: 0x154F690 Offset: 0x154DC90 VA: 0x18154F690
	|-JSON.DecodeDictionary<uint, double>
	|
	|-RVA: 0x154FA20 Offset: 0x154E020 VA: 0x18154FA20
	|-JSON.DecodeDictionary<uint, short>
	|
	|-RVA: 0x154FDB0 Offset: 0x154E3B0 VA: 0x18154FDB0
	|-JSON.DecodeDictionary<uint, int>
	|
	|-RVA: 0x1550140 Offset: 0x154E740 VA: 0x181550140
	|-JSON.DecodeDictionary<uint, long>
	|
	|-RVA: 0xCFF930 Offset: 0xCFDF30 VA: 0x180CFF930
	|-JSON.DecodeDictionary<uint, object>
	|
	|-RVA: 0xCFFCC0 Offset: 0xCFE2C0 VA: 0x180CFFCC0
	|-JSON.DecodeDictionary<uint, float>
	|
	|-RVA: 0xD00050 Offset: 0xCFE650 VA: 0x180D00050
	|-JSON.DecodeDictionary<uint, ushort>
	|
	|-RVA: 0xD003E0 Offset: 0xCFE9E0 VA: 0x180D003E0
	|-JSON.DecodeDictionary<uint, uint>
	|
	|-RVA: 0xD00770 Offset: 0xCFED70 VA: 0x180D00770
	|-JSON.DecodeDictionary<uint, ulong>
	|
	|-RVA: 0xD00B00 Offset: 0xCFF100 VA: 0x180D00B00
	|-JSON.DecodeDictionary<ulong, bool>
	|
	|-RVA: 0xD00E90 Offset: 0xCFF490 VA: 0x180D00E90
	|-JSON.DecodeDictionary<ulong, Decimal>
	|
	|-RVA: 0xD01220 Offset: 0xCFF820 VA: 0x180D01220
	|-JSON.DecodeDictionary<ulong, double>
	|
	|-RVA: 0xD015B0 Offset: 0xCFFBB0 VA: 0x180D015B0
	|-JSON.DecodeDictionary<ulong, short>
	|
	|-RVA: 0xD01940 Offset: 0xCFFF40 VA: 0x180D01940
	|-JSON.DecodeDictionary<ulong, int>
	|
	|-RVA: 0xD01CD0 Offset: 0xD002D0 VA: 0x180D01CD0
	|-JSON.DecodeDictionary<ulong, long>
	|
	|-RVA: 0xD02060 Offset: 0xD00660 VA: 0x180D02060
	|-JSON.DecodeDictionary<ulong, object>
	|
	|-RVA: 0xD023F0 Offset: 0xD009F0 VA: 0x180D023F0
	|-JSON.DecodeDictionary<ulong, float>
	|
	|-RVA: 0xD02780 Offset: 0xD00D80 VA: 0x180D02780
	|-JSON.DecodeDictionary<ulong, ushort>
	|
	|-RVA: 0xD02B10 Offset: 0xD01110 VA: 0x180D02B10
	|-JSON.DecodeDictionary<ulong, uint>
	|
	|-RVA: 0xD02EA0 Offset: 0xD014A0 VA: 0x180D02EA0
	|-JSON.DecodeDictionary<ulong, ulong>
	*/

	[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	private static T[] DecodeArray<T>(Variant data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A39C30 Offset: 0x1A38230 VA: 0x181A39C30
	|-JSON.DecodeArray<bool>
	|
	|-RVA: 0x1A39E50 Offset: 0x1A38450 VA: 0x181A39E50
	|-JSON.DecodeArray<Decimal>
	|
	|-RVA: 0x1A3A090 Offset: 0x1A38690 VA: 0x181A3A090
	|-JSON.DecodeArray<double>
	|
	|-RVA: 0x1A3A2C0 Offset: 0x1A388C0 VA: 0x181A3A2C0
	|-JSON.DecodeArray<short>
	|
	|-RVA: 0x1A3A4E0 Offset: 0x1A38AE0 VA: 0x181A3A4E0
	|-JSON.DecodeArray<int>
	|
	|-RVA: 0x1A3A700 Offset: 0x1A38D00 VA: 0x181A3A700
	|-JSON.DecodeArray<long>
	|
	|-RVA: 0x1A3A920 Offset: 0x1A38F20 VA: 0x181A3A920
	|-JSON.DecodeArray<object>
	|
	|-RVA: 0x1A3AB30 Offset: 0x1A39130 VA: 0x181A3AB30
	|-JSON.DecodeArray<float>
	|
	|-RVA: 0x1A3AD60 Offset: 0x1A39360 VA: 0x181A3AD60
	|-JSON.DecodeArray<ushort>
	|
	|-RVA: 0x1A3AF80 Offset: 0x1A39580 VA: 0x181A3AF80
	|-JSON.DecodeArray<uint>
	|
	|-RVA: 0x1A3B1A0 Offset: 0x1A397A0 VA: 0x181A3B1A0
	|-JSON.DecodeArray<ulong>
	*/

	[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	private static void DecodeMultiRankArray<T>(ProxyArray arrayData, Array array, int arrayRank, int[] indices) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CE9C0 Offset: 0x5CCFC0 VA: 0x1805CE9C0
	|-JSON.DecodeMultiRankArray<object>
	*/

	[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static void SupportTypeForAOT<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CEBF0 Offset: 0x5CD1F0 VA: 0x1805CEBF0
	|-JSON.SupportTypeForAOT<bool>
	|
	|-RVA: 0x5CED20 Offset: 0x5CD320 VA: 0x1805CED20
	|-JSON.SupportTypeForAOT<Decimal>
	|
	|-RVA: 0x5CEE50 Offset: 0x5CD450 VA: 0x1805CEE50
	|-JSON.SupportTypeForAOT<double>
	|
	|-RVA: 0x5CEF80 Offset: 0x5CD580 VA: 0x1805CEF80
	|-JSON.SupportTypeForAOT<short>
	|
	|-RVA: 0x5CF0B0 Offset: 0x5CD6B0 VA: 0x1805CF0B0
	|-JSON.SupportTypeForAOT<int>
	|
	|-RVA: 0x5CF1E0 Offset: 0x5CD7E0 VA: 0x1805CF1E0
	|-JSON.SupportTypeForAOT<long>
	|
	|-RVA: 0x5CF310 Offset: 0x5CD910 VA: 0x1805CF310
	|-JSON.SupportTypeForAOT<object>
	|-JSON.SupportTypeForAOT<string>
	|
	|-RVA: 0x5CF440 Offset: 0x5CDA40 VA: 0x1805CF440
	|-JSON.SupportTypeForAOT<float>
	|
	|-RVA: 0x5CF570 Offset: 0x5CDB70 VA: 0x1805CF570
	|-JSON.SupportTypeForAOT<ushort>
	|
	|-RVA: 0x5CF6A0 Offset: 0x5CDCA0 VA: 0x1805CF6A0
	|-JSON.SupportTypeForAOT<uint>
	|
	|-RVA: 0x5CF7D0 Offset: 0x5CDDD0 VA: 0x1805CF7D0
	|-JSON.SupportTypeForAOT<ulong>
	*/

	[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x87AA20 Offset: 0x879020 VA: 0x18087AA20
	private static void SupportValueTypesForAOT() { }

	// RVA: 0x87AAF0 Offset: 0x8790F0 VA: 0x18087AAF0
	private static void .cctor() { }

}

