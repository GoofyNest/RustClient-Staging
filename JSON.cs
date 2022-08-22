public static class JsonUtility // TypeDefIndex: 4525
{
// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0xE7DF0 Offset: 0xE71F0 VA: 0x1800E7DF0
public static class JsonUtility // TypeDefIndex: 4525
	// Methods

	[ThreadSafeAttribute] // RVA: 0xE7F30 Offset: 0xE7330 VA: 0x1800E7F30
	[FreeFunctionAttribute] // RVA: 0xE7F30 Offset: 0xE7330 VA: 0x1800E7F30
	// RVA: 0x2322A10 Offset: 0x2321010 VA: 0x182322A10
	private static object FromJsonInternal(string json, object objectToOverwrite, Type type) { }

	// RVA: -1 Offset: -1
	public static T FromJson<T>(string json) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9370 Offset: 0x15B7970 VA: 0x1815B9370
	|-JsonUtility.FromJson<RandomUsernames.DataFile>
	|-JsonUtility.FromJson<object>
	*/

	// RVA: 0x2322A70 Offset: 0x2321070 VA: 0x182322A70
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

	// RVA: 0x13CAB50 Offset: 0x13C9150 VA: 0x1813CAB50 Slot: 7
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

	// RVA: 0x13C9480 Offset: 0x13C7A80 VA: 0x1813C9480 Slot: 13
	public virtual void Add(JSONNode aItem) { }

	[IteratorStateMachineAttribute] // RVA: 0xBB950 Offset: 0xBAD50 VA: 0x1800BB950
	// RVA: 0x13CAA60 Offset: 0x13C9060 VA: 0x1813CAA60 Slot: 14
	public virtual IEnumerable<JSONNode> get_Children() { }

	// RVA: 0x13CA6B0 Offset: 0x13C8CB0 VA: 0x1813CA6B0 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract JSONNode.Enumerator GetEnumerator();

	// RVA: 0x13CA890 Offset: 0x13C8E90 VA: 0x1813CA890 Slot: 17
	public virtual double get_AsDouble() { }

	// RVA: 0x13CA970 Offset: 0x13C8F70 VA: 0x1813CA970 Slot: 18
	public virtual int get_AsInt() { }

	// RVA: 0x13CA7D0 Offset: 0x13C8DD0 VA: 0x1813CA7D0 Slot: 19
	public virtual bool get_AsBool() { }

	// RVA: 0x13CA990 Offset: 0x13C8F90 VA: 0x1813CA990 Slot: 20
	public virtual long get_AsLong() { }

	// RVA: 0x13CA750 Offset: 0x13C8D50 VA: 0x1813CA750 Slot: 21
	public virtual JSONArray get_AsArray() { }

	// RVA: 0x13CA9E0 Offset: 0x13C8FE0 VA: 0x1813CA9E0 Slot: 22
	public virtual JSONObject get_AsObject() { }

	// RVA: 0x13CAD80 Offset: 0x13C9380 VA: 0x1813CAD80
	public static JSONNode op_Implicit(string s) { }

	// RVA: 0x13CADE0 Offset: 0x13C93E0 VA: 0x1813CADE0
	public static string op_Implicit(JSONNode d) { }

	// RVA: 0x13CAE30 Offset: 0x13C9430 VA: 0x1813CAE30
	public static JSONNode op_Implicit(double n) { }

	// RVA: 0x13CAD20 Offset: 0x13C9320 VA: 0x1813CAD20
	public static JSONNode op_Implicit(bool b) { }

	// RVA: 0x13CAB80 Offset: 0x13C9180 VA: 0x1813CAB80
	public static bool op_Equality(JSONNode a, object b) { }

	// RVA: 0x13CAE90 Offset: 0x13C9490 VA: 0x1813CAE90
	public static bool op_Inequality(JSONNode a, object b) { }

	// RVA: 0xAE5CA0 Offset: 0xAE42A0 VA: 0x180AE5CA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCCE820 Offset: 0xCCCE20 VA: 0x180CCE820 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13CAAC0 Offset: 0x13C90C0 VA: 0x1813CAAC0
	internal static StringBuilder get_EscapeBuilder() { }

	// RVA: 0x13C97D0 Offset: 0x13C7DD0 VA: 0x1813C97D0
	internal static string Escape(string aText) { }

	// RVA: 0x13C9C30 Offset: 0x13C8230 VA: 0x1813C9C30
	private static JSONNode ParseElement(string token, bool quoted) { }

	// RVA: 0x13C9E90 Offset: 0x13C8490 VA: 0x1813C9E90
	public static JSONNode Parse(string aJSON) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void SerializeBinary(BinaryWriter aWriter);

	// RVA: 0x13CA630 Offset: 0x13C8C30 VA: 0x1813CA630
	public void SaveToBinaryStream(Stream aData) { }

	// RVA: 0x13CA490 Offset: 0x13C8A90 VA: 0x1813CA490
	public string SaveToBinaryBase64() { }

	// RVA: 0x13C94E0 Offset: 0x13C7AE0 VA: 0x1813C94E0
	public static JSONNode DeserializeBinary(BinaryReader aReader) { }

	// RVA: 0x13C9B40 Offset: 0x13C8140 VA: 0x1813C9B40
	public static JSONNode LoadFromBinaryStream(Stream aData) { }

	// RVA: 0x13C9A90 Offset: 0x13C8090 VA: 0x1813C9A90
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
	// RVA: 0xD87750 Offset: 0xD85D50 VA: 0x180D87750
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13CFA40 Offset: 0x13CE040 VA: 0x1813CFA40 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CFAE0 Offset: 0x13CE0E0 VA: 0x1813CFAE0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CFA50 Offset: 0x13CE050 VA: 0x1813CFA50 Slot: 4
	private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<GameAnalyticsSDK.Net.Utilities.JSONNode>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CFA50 Offset: 0x13CE050 VA: 0x1813CFA50 Slot: 5
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

	// RVA: 0x13C8530 Offset: 0x13C6B30 VA: 0x1813C8530 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x13C89B0 Offset: 0x13C6FB0 VA: 0x1813C89B0 Slot: 4
	public override JSONNode get_Item(int aIndex) { }

	// RVA: 0x13C8940 Offset: 0x13C6F40 VA: 0x1813C8940 Slot: 5
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x13C8A70 Offset: 0x13C7070 VA: 0x1813C8A70 Slot: 6
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x13C8900 Offset: 0x13C6F00 VA: 0x1813C8900 Slot: 8
	public override int get_Count() { }

	// RVA: 0x13C84A0 Offset: 0x13C6AA0 VA: 0x1813C84A0 Slot: 12
	public override void Add(string aKey, JSONNode aItem) { }

	[IteratorStateMachineAttribute] // RVA: 0xBBEB0 Offset: 0xBB2B0 VA: 0x1800BBEB0
	// RVA: 0x13C8890 Offset: 0x13C6E90 VA: 0x1813C8890 Slot: 14
	public override IEnumerable<JSONNode> get_Children() { }

	// RVA: 0x13C86C0 Offset: 0x13C6CC0 VA: 0x1813C86C0 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13C85C0 Offset: 0x13C6BC0 VA: 0x1813C85C0 Slot: 23
	public override void SerializeBinary(BinaryWriter aWriter) { }

	// RVA: 0x13C8820 Offset: 0x13C6E20 VA: 0x1813C8820
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
	// RVA: 0xD87750 Offset: 0xD85D50 VA: 0x180D87750
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CF620 Offset: 0x13CDC20 VA: 0x1813CF620 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13CF3D0 Offset: 0x13CD9D0 VA: 0x1813CF3D0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x13CF6C0 Offset: 0x13CDCC0 VA: 0x1813CF6C0
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CF5D0 Offset: 0x13CDBD0 VA: 0x1813CF5D0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CF530 Offset: 0x13CDB30 VA: 0x1813CF530 Slot: 4
	private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<GameAnalyticsSDK.Net.Utilities.JSONNode>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CF530 Offset: 0x13CDB30 VA: 0x1813CF530 Slot: 5
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

	// RVA: 0x13CB7C0 Offset: 0x13C9DC0 VA: 0x1813CB7C0 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x13CBEA0 Offset: 0x13CA4A0 VA: 0x1813CBEA0 Slot: 5
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x13CBF70 Offset: 0x13CA570 VA: 0x1813CBF70 Slot: 6
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x13CBE10 Offset: 0x13CA410 VA: 0x1813CBE10 Slot: 4
	public override JSONNode get_Item(int aIndex) { }

	// RVA: 0x13CBDC0 Offset: 0x13CA3C0 VA: 0x1813CBDC0 Slot: 8
	public override int get_Count() { }

	// RVA: 0x13CB670 Offset: 0x13C9C70 VA: 0x1813CB670 Slot: 12
	public override void Add(string aKey, JSONNode aItem) { }

	[IteratorStateMachineAttribute] // RVA: 0xBDD90 Offset: 0xBD190 VA: 0x1800BDD90
	// RVA: 0x13CBD50 Offset: 0x13CA350 VA: 0x1813CBD50 Slot: 14
	public override IEnumerable<JSONNode> get_Children() { }

	// RVA: 0x13CBA40 Offset: 0x13CA040 VA: 0x1813CBA40 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13CB870 Offset: 0x13C9E70 VA: 0x1813CB870 Slot: 23
	public override void SerializeBinary(BinaryWriter aWriter) { }

	// RVA: 0x13CBCE0 Offset: 0x13CA2E0 VA: 0x1813CBCE0
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
	// RVA: 0xD87750 Offset: 0xD85D50 VA: 0x180D87750
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CF960 Offset: 0x13CDF60 VA: 0x1813CF960 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13CF700 Offset: 0x13CDD00 VA: 0x1813CF700 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x13CFA00 Offset: 0x13CE000 VA: 0x1813CFA00
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CF910 Offset: 0x13CDF10 VA: 0x1813CF910 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CF870 Offset: 0x13CDE70 VA: 0x1813CF870 Slot: 4
	private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<GameAnalyticsSDK.Net.Utilities.JSONNode>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CF870 Offset: 0x13CDE70 VA: 0x1813CF870 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

internal class JSONString : JSONNode // TypeDefIndex: 5647
{	// Fields
	private string m_Data; // 0x10

	// Properties
	public override string Value { get; }

	// Methods

	// RVA: 0x13C8B90 Offset: 0x13C7190 VA: 0x1813C8B90 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 7
	public override string get_Value() { }

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(string aData) { }

	// RVA: 0x13CC250 Offset: 0x13CA850 VA: 0x1813CC250 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13CC050 Offset: 0x13CA650 VA: 0x1813CC050 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xDE2260 Offset: 0xDE0860 VA: 0x180DE2260 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13CC1F0 Offset: 0x13CA7F0 VA: 0x1813CC1F0 Slot: 23
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

	// RVA: 0x13C8B90 Offset: 0x13C7190 VA: 0x1813C8B90 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x13CB610 Offset: 0x13C9C10 VA: 0x1813CB610 Slot: 7
	public override string get_Value() { }

	// RVA: 0xB3BB50 Offset: 0xB3A150 VA: 0x180B3BB50 Slot: 17
	public override double get_AsDouble() { }

	// RVA: 0x13CB600 Offset: 0x13C9C00 VA: 0x1813CB600 Slot: 20
	public override long get_AsLong() { }

	// RVA: 0x13CB5D0 Offset: 0x13C9BD0 VA: 0x1813CB5D0
	public void .ctor(double aData) { }

	// RVA: 0x13CB590 Offset: 0x13C9B90 VA: 0x1813CB590 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13CB410 Offset: 0x13C9A10 VA: 0x1813CB410
	private static bool IsNumeric(object value) { }

	// RVA: 0x13CB140 Offset: 0x13C9740 VA: 0x1813CB140 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13CB400 Offset: 0x13C9A00 VA: 0x1813CB400 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13CB530 Offset: 0x13C9B30 VA: 0x1813CB530 Slot: 23
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

	// RVA: 0x13C8B90 Offset: 0x13C7190 VA: 0x1813C8B90 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x13C8C80 Offset: 0x13C7280 VA: 0x1813C8C80 Slot: 7
	public override string get_Value() { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90 Slot: 19
	public override bool get_AsBool() { }

	// RVA: 0xF889C0 Offset: 0xF86FC0 VA: 0x180F889C0
	public void .ctor(bool aData) { }

	// RVA: 0x13C8C20 Offset: 0x13C7220 VA: 0x1813C8C20 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13C8B00 Offset: 0x13C7100 VA: 0x1813C8B00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13C8BB0 Offset: 0x13C71B0 VA: 0x1813C8BB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13C8BC0 Offset: 0x13C71C0 VA: 0x1813C8BC0 Slot: 23
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

	// RVA: 0x13CAEB0 Offset: 0x13C94B0 VA: 0x1813CAEB0
	public static JSONNull CreateOrGet() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x13C8B90 Offset: 0x13C7190 VA: 0x1813C8B90 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x13CB110 Offset: 0x13C9710 VA: 0x1813CB110 Slot: 7
	public override string get_Value() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 19
	public override bool get_AsBool() { }

	// RVA: 0x13CAF60 Offset: 0x13C9560 VA: 0x1813CAF60 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13CB050 Offset: 0x13C9650 VA: 0x1813CB050 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13CB020 Offset: 0x13C9620 VA: 0x1813CB020 Slot: 23
	public override void SerializeBinary(BinaryWriter aWriter) { }

	// RVA: 0x13CB0A0 Offset: 0x13C96A0 VA: 0x1813CB0A0
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

	// RVA: 0x13C8B90 Offset: 0x13C7190 VA: 0x1813C8B90 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x13C8EC0 Offset: 0x13C74C0 VA: 0x1813C8EC0
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

	// RVA: 0x13C9320 Offset: 0x13C7920 VA: 0x1813C9320 Slot: 4
	public override JSONNode get_Item(int aIndex) { }

	// RVA: 0x13C92A0 Offset: 0x13C78A0 VA: 0x1813C92A0 Slot: 5
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x13C9390 Offset: 0x13C7990 VA: 0x1813C9390 Slot: 6
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x13C8D80 Offset: 0x13C7380 VA: 0x1813C8D80 Slot: 13
	public override void Add(JSONNode aItem) { }

	// RVA: 0x13C8C90 Offset: 0x13C7290 VA: 0x1813C8C90 Slot: 12
	public override void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x13C8E60 Offset: 0x13C7460 VA: 0x1813C8E60 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13C90A0 Offset: 0x13C76A0 VA: 0x1813C90A0 Slot: 18
	public override int get_AsInt() { }

	// RVA: 0x13C9030 Offset: 0x13C7630 VA: 0x1813C9030 Slot: 17
	public override double get_AsDouble() { }

	// RVA: 0x13C9110 Offset: 0x13C7710 VA: 0x1813C9110 Slot: 20
	public override long get_AsLong() { }

	// RVA: 0x13C8FC0 Offset: 0x13C75C0 VA: 0x1813C8FC0 Slot: 19
	public override bool get_AsBool() { }

	// RVA: 0x13C8F10 Offset: 0x13C7510 VA: 0x1813C8F10 Slot: 21
	public override JSONArray get_AsArray() { }

	// RVA: 0x13C91F0 Offset: 0x13C77F0 VA: 0x1813C91F0 Slot: 22
	public override JSONObject get_AsObject() { }

	// RVA: 0x13C8E70 Offset: 0x13C7470 VA: 0x1813C8E70 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 23
	public override void SerializeBinary(BinaryWriter aWriter) { }

}

internal static class JSON // TypeDefIndex: 5652
{	// Methods

	// RVA: 0x13CC2C0 Offset: 0x13CA8C0 VA: 0x1813CC2C0
	public static JSONNode Parse(string aJSON) { }

}

public sealed class JsonConstructorAttribute : Attribute // TypeDefIndex: 5872
{	// Methods

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

}

public class JsonException : Exception // TypeDefIndex: 5874
{	// Methods

	// RVA: 0xF8B500 Offset: 0xF89B00 VA: 0x180F8B500
	public void .ctor() { }

	// RVA: 0xF8B5E0 Offset: 0xF89BE0 VA: 0x180F8B5E0
	public void .ctor(string message) { }

	// RVA: 0xF8B560 Offset: 0xF89B60 VA: 0x180F8B560
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0xF8B480 Offset: 0xF89A80 VA: 0x180F8B480
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
	// RVA: 0xF8B670 Offset: 0xF89C70 VA: 0x180F8B670
	public bool get_ReadData() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8B680 Offset: 0xF89C80 VA: 0x180F8B680
	public void set_ReadData(bool value) { }

	// RVA: 0xF8B650 Offset: 0xF89C50 VA: 0x180F8B650
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

	// RVA: 0xF8B690 Offset: 0xF89C90 VA: 0x180F8B690
	internal static string BuildPath(List<JsonPosition> positions, Nullable<JsonPosition> currentPosition) { }

	// RVA: 0xF8BAB0 Offset: 0xF8A0B0 VA: 0x180F8BAB0
	internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message) { }

	// RVA: 0xF8BDF0 Offset: 0xF8A3F0 VA: 0x180F8BDF0
	private static void .cctor() { }

}

public sealed class JsonRequiredAttribute : Attribute // TypeDefIndex: 5878
{	// Methods

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

}

public sealed class JsonArrayAttribute : JsonContainerAttribute // TypeDefIndex: 5884
{	// Methods

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
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

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
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

	// RVA: 0xF8B3B0 Offset: 0xF899B0 VA: 0x180F8B3B0
	public void .ctor(Type converterType) { }

}

public sealed class JsonObjectAttribute : JsonContainerAttribute // TypeDefIndex: 5888
{	// Fields
	private MemberSerialization _memberSerialization; // 0x38
	internal Nullable<Required> _itemRequired; // 0x3C

	// Properties
	public MemberSerialization MemberSerialization { get; }

	// Methods

	// RVA: 0x6BBA50 Offset: 0x6BA050 VA: 0x1806BBA50
	public MemberSerialization get_MemberSerialization() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
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

	// RVA: 0xF90AB0 Offset: 0xF8F0B0 VA: 0x180F90AB0
	public ReferenceLoopHandling get_ReferenceLoopHandling() { }

	// RVA: 0xF909B0 Offset: 0xF8EFB0 VA: 0x180F909B0
	public MissingMemberHandling get_MissingMemberHandling() { }

	// RVA: 0xF90A30 Offset: 0xF8F030 VA: 0x180F90A30
	public ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0xF909F0 Offset: 0xF8EFF0 VA: 0x180F909F0
	public NullValueHandling get_NullValueHandling() { }

	// RVA: 0xF90930 Offset: 0xF8EF30 VA: 0x180F90930
	public DefaultValueHandling get_DefaultValueHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD9F730 Offset: 0xD9DD30 VA: 0x180D9F730
	public IList<JsonConverter> get_Converters() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD35330 Offset: 0xD33930 VA: 0x180D35330
	public void set_Converters(IList<JsonConverter> value) { }

	// RVA: 0xF90A70 Offset: 0xF8F070 VA: 0x180F90A70
	public PreserveReferencesHandling get_PreserveReferencesHandling() { }

	// RVA: 0xF90B30 Offset: 0xF8F130 VA: 0x180F90B30
	public TypeNameHandling get_TypeNameHandling() { }

	// RVA: 0xF90970 Offset: 0xF8EF70 VA: 0x180F90970
	public MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0xF90AF0 Offset: 0xF8F0F0 VA: 0x180F90AF0
	public FormatterAssemblyStyle get_TypeNameAssemblyFormat() { }

	// RVA: 0xF90850 Offset: 0xF8EE50 VA: 0x180F90850
	public ConstructorHandling get_ConstructorHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4EF3A0 Offset: 0x4ED9A0 VA: 0x1804EF3A0
	public IContractResolver get_ContractResolver() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x872250 Offset: 0x870850 VA: 0x180872250
	public IEqualityComparer get_EqualityComparer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC73E20 Offset: 0xC72420 VA: 0x180C73E20
	public Func<IReferenceResolver> get_ReferenceResolverProvider() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB0F080 Offset: 0xB0D680 VA: 0x180B0F080
	public ITraceWriter get_TraceWriter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2ABE0 Offset: 0xA291E0 VA: 0x180A2ABE0
	public SerializationBinder get_Binder() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC83460 Offset: 0xC81A60 VA: 0x180C83460
	public EventHandler<ErrorEventArgs> get_Error() { }

	// RVA: 0xF90890 Offset: 0xF8EE90 VA: 0x180F90890
	public StreamingContext get_Context() { }

	// RVA: 0xF90660 Offset: 0xF8EC60 VA: 0x180F90660
	private static void .cctor() { }

	// RVA: 0xF906E0 Offset: 0xF8ECE0 VA: 0x180F906E0
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

	// RVA: 0xF9B6C0 Offset: 0xF99CC0 VA: 0x180F9B6C0
	public void .ctor(TextReader reader) { }

	// RVA: 0xF93AE0 Offset: 0xF920E0 VA: 0x180F93AE0
	private void EnsureBufferNotEmpty() { }

	// RVA: 0xF94300 Offset: 0xF92900 VA: 0x180F94300
	private void OnNewLine(int pos) { }

	// RVA: 0xF96BF0 Offset: 0xF951F0 VA: 0x180F96BF0
	private void ParseString(char quote, ReadType readType) { }

	// RVA: 0xBB4220 Offset: 0xBB2820 VA: 0x180BB4220
	private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count) { }

	// RVA: 0xF9B4F0 Offset: 0xF99AF0 VA: 0x180F9B4F0
	private void ShiftBufferIfNeeded() { }

	// RVA: 0xF997D0 Offset: 0xF97DD0 VA: 0x180F997D0
	private int ReadData(bool append) { }

	// RVA: 0xF99540 Offset: 0xF97B40 VA: 0x180F99540
	private int ReadData(bool append, int charsRequired) { }

	// RVA: 0xF93BC0 Offset: 0xF921C0 VA: 0x180F93BC0
	private bool EnsureChars(int relativePosition, bool append) { }

	// RVA: 0xF994B0 Offset: 0xF97AB0 VA: 0x180F994B0
	private bool ReadChars(int relativePosition, bool append) { }

	// RVA: 0xF9B200 Offset: 0xF99800 VA: 0x180F9B200 Slot: 10
	public override bool Read() { }

	// RVA: 0xF993C0 Offset: 0xF979C0 VA: 0x180F993C0 Slot: 11
	public override Nullable<int> ReadAsInt32() { }

	// RVA: 0xF991E0 Offset: 0xF977E0 VA: 0x180F991E0 Slot: 17
	public override Nullable<DateTime> ReadAsDateTime() { }

	// RVA: 0xF99450 Offset: 0xF97A50 VA: 0x180F99450 Slot: 12
	public override string ReadAsString() { }

	// RVA: 0xF98AC0 Offset: 0xF970C0 VA: 0x180F98AC0 Slot: 13
	public override byte[] ReadAsBytes() { }

	// RVA: 0xF9A890 Offset: 0xF98E90 VA: 0x180F9A890
	private object ReadStringValue(ReadType readType) { }

	// RVA: 0xF93870 Offset: 0xF91E70 VA: 0x180F93870
	private JsonReaderException CreateUnexpectedCharacterException(char c) { }

	// RVA: 0xF98190 Offset: 0xF96790 VA: 0x180F98190 Slot: 15
	public override Nullable<bool> ReadAsBoolean() { }

	// RVA: 0xF98120 Offset: 0xF96720 VA: 0x180F98120
	private void ProcessValueComma() { }

	// RVA: 0xF99C00 Offset: 0xF98200 VA: 0x180F99C00
	private object ReadNumberValue(ReadType readType) { }

	// RVA: 0xF99140 Offset: 0xF97740 VA: 0x180F99140 Slot: 18
	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0xF99280 Offset: 0xF97880 VA: 0x180F99280 Slot: 16
	public override Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0xF99320 Offset: 0xF97920 VA: 0x180F99320 Slot: 14
	public override Nullable<double> ReadAsDouble() { }

	// RVA: 0xF93C60 Offset: 0xF92260 VA: 0x180F93C60
	private void HandleNull() { }

	// RVA: 0xF997E0 Offset: 0xF97DE0 VA: 0x180F997E0
	private void ReadFinished() { }

	// RVA: 0xF99970 Offset: 0xF97F70 VA: 0x180F99970
	private bool ReadNullChar() { }

	// RVA: 0xF93B50 Offset: 0xF92150 VA: 0x180F93B50
	private void EnsureBuffer() { }

	// RVA: 0xF9A1E0 Offset: 0xF987E0 VA: 0x180F9A1E0
	private void ReadStringIntoBuffer(char quote) { }

	// RVA: 0xF9B640 Offset: 0xF99C40 VA: 0x180F9B640
	private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition) { }

	// RVA: 0xF97250 Offset: 0xF95850 VA: 0x180F97250
	private char ParseUnicode() { }

	// RVA: 0xF999C0 Offset: 0xF97FC0 VA: 0x180F999C0
	private void ReadNumberIntoBuffer() { }

	// RVA: 0xF937B0 Offset: 0xF91DB0 VA: 0x180F937B0
	private void ClearRecentString() { }

	// RVA: 0xF96570 Offset: 0xF94B70 VA: 0x180F96570
	private bool ParsePostValue() { }

	// RVA: 0xF963A0 Offset: 0xF949A0 VA: 0x180F963A0
	private bool ParseObject() { }

	// RVA: 0xF968B0 Offset: 0xF94EB0 VA: 0x180F968B0
	private bool ParseProperty() { }

	// RVA: 0xF9B5D0 Offset: 0xF99BD0 VA: 0x180F9B5D0
	private bool ValidIdentifierChar(char value) { }

	// RVA: 0xF97340 Offset: 0xF95940 VA: 0x180F97340
	private void ParseUnquotedProperty() { }

	// RVA: 0xF97590 Offset: 0xF95B90 VA: 0x180F97590
	private bool ParseValue() { }

	// RVA: 0xF98100 Offset: 0xF96700 VA: 0x180F98100
	private void ProcessLineFeed() { }

	// RVA: 0xF98010 Offset: 0xF96610 VA: 0x180F98010
	private void ProcessCarriageReturn(bool append) { }

	// RVA: 0xF93920 Offset: 0xF91F20 VA: 0x180F93920
	private bool EatWhitespace(bool oneOrMore) { }

	// RVA: 0xF94700 Offset: 0xF92D00 VA: 0x180F94700
	private void ParseConstructor() { }

	// RVA: 0xF95390 Offset: 0xF93990 VA: 0x180F95390
	private void ParseNumber(ReadType readType) { }

	// RVA: 0xF94310 Offset: 0xF92910 VA: 0x180F94310
	private void ParseComment(bool setToken) { }

	// RVA: 0xF93A70 Offset: 0xF92070 VA: 0x180F93A70
	private void EndComment(bool setToken, int initialPosition, int endPosition) { }

	// RVA: 0xF941F0 Offset: 0xF927F0 VA: 0x180F941F0
	private bool MatchValue(string value) { }

	// RVA: 0xF93EE0 Offset: 0xF924E0 VA: 0x180F93EE0
	private bool MatchValueWithTrailingSeparator(string value) { }

	// RVA: 0xF93D90 Offset: 0xF92390 VA: 0x180F93D90
	private bool IsSeparator(char c) { }

	// RVA: 0xF97040 Offset: 0xF95640 VA: 0x180F97040
	private void ParseTrue() { }

	// RVA: 0xF94C10 Offset: 0xF93210 VA: 0x180F94C10
	private void ParseNull() { }

	// RVA: 0xF97150 Offset: 0xF95750 VA: 0x180F97150
	private void ParseUndefined() { }

	// RVA: 0xF94B00 Offset: 0xF93100 VA: 0x180F94B00
	private void ParseFalse() { }

	// RVA: 0xF94F30 Offset: 0xF93530 VA: 0x180F94F30
	private object ParseNumberNegativeInfinity(ReadType readType) { }

	// RVA: 0xF95160 Offset: 0xF93760 VA: 0x180F95160
	private object ParseNumberPositiveInfinity(ReadType readType) { }

	// RVA: 0xF94D00 Offset: 0xF93300 VA: 0x180F94D00
	private object ParseNumberNaN(ReadType readType) { }

	// RVA: 0xF937D0 Offset: 0xF91DD0 VA: 0x180F937D0 Slot: 20
	public override void Close() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 21
	public bool HasLineInfo() { }

	// RVA: 0xF9B770 Offset: 0xF99D70 VA: 0x180F9B770 Slot: 22
	public int get_LineNumber() { }

	// RVA: 0xF9B7C0 Offset: 0xF99DC0 VA: 0x180F9B7C0 Slot: 23
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

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xF8BEE0 Offset: 0xF8A4E0 VA: 0x180F8BEE0
	public void .ctor(string propertyName) { }

}

public sealed class JsonIgnoreAttribute : Attribute // TypeDefIndex: 5896
{	// Methods

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
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

	// RVA: 0xE47A50 Offset: 0xE46050 VA: 0x180E47A50
	private Base64Encoder get_Base64Encoder() { }

	// RVA: 0xE47AD0 Offset: 0xE460D0 VA: 0x180E47AD0
	public char get_QuoteChar() { }

	// RVA: 0xE47970 Offset: 0xE45F70 VA: 0x180E47970
	public void .ctor(TextWriter textWriter) { }

	// RVA: 0xE45CC0 Offset: 0xE442C0 VA: 0x180E45CC0 Slot: 6
	public override void Close() { }

	// RVA: 0xE46770 Offset: 0xE44D70 VA: 0x180E46770 Slot: 7
	public override void WriteStartObject() { }

	// RVA: 0xE46670 Offset: 0xE44C70 VA: 0x180E46670 Slot: 9
	public override void WriteStartArray() { }

	// RVA: 0xE466C0 Offset: 0xE44CC0 VA: 0x180E466C0 Slot: 11
	public override void WriteStartConstructor(string name) { }

	// RVA: 0xE45F00 Offset: 0xE44500 VA: 0x180E45F00 Slot: 17
	protected override void WriteEnd(JsonToken token) { }

	// RVA: 0xE465D0 Offset: 0xE44BD0 VA: 0x180E465D0 Slot: 13
	public override void WritePropertyName(string name) { }

	// RVA: 0xE464E0 Offset: 0xE44AE0 VA: 0x180E464E0 Slot: 14
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0xE45DC0 Offset: 0xE443C0 VA: 0x180E45DC0 Slot: 5
	internal override void OnStringEscapeHandlingChanged() { }

	// RVA: 0xE45DD0 Offset: 0xE443D0 VA: 0x180E45DD0
	private void UpdateCharEscapeFlags() { }

	// RVA: 0xE46110 Offset: 0xE44710 VA: 0x180E46110 Slot: 18
	protected override void WriteIndent() { }

	// RVA: 0xE46860 Offset: 0xE44E60 VA: 0x180E46860 Slot: 19
	protected override void WriteValueDelimiter() { }

	// RVA: 0xE460E0 Offset: 0xE446E0 VA: 0x180E460E0 Slot: 20
	protected override void WriteIndentSpace() { }

	// RVA: 0xE46640 Offset: 0xE44C40 VA: 0x180E46640
	private void WriteValueInternal(string value, JsonToken token) { }

	// RVA: 0xE3AF00 Offset: 0xE39500 VA: 0x180E3AF00 Slot: 62
	public override void WriteValue(object value) { }

	// RVA: 0xE46440 Offset: 0xE44A40 VA: 0x180E46440 Slot: 21
	public override void WriteNull() { }

	// RVA: 0xE467C0 Offset: 0xE44DC0 VA: 0x180E467C0 Slot: 22
	public override void WriteUndefined() { }

	// RVA: 0xE46640 Offset: 0xE44C40 VA: 0x180E46640 Slot: 23
	public override void WriteRaw(string json) { }

	// RVA: 0xE47720 Offset: 0xE45D20 VA: 0x180E47720 Slot: 25
	public override void WriteValue(string value) { }

	// RVA: 0xE45FE0 Offset: 0xE445E0 VA: 0x180E45FE0
	private void WriteEscapedString(string value, bool quote) { }

	// RVA: 0xE476E0 Offset: 0xE45CE0 VA: 0x180E476E0 Slot: 26
	public override void WriteValue(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE47450 Offset: 0xE45A50 VA: 0x180E47450 Slot: 27
	public override void WriteValue(uint value) { }

	// RVA: 0xE47620 Offset: 0xE45C20 VA: 0x180E47620 Slot: 28
	public override void WriteValue(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE46B10 Offset: 0xE45110 VA: 0x180E46B10 Slot: 29
	public override void WriteValue(ulong value) { }

	// RVA: 0xE46950 Offset: 0xE44F50 VA: 0x180E46950 Slot: 30
	public override void WriteValue(float value) { }

	// RVA: 0xE46A20 Offset: 0xE45020 VA: 0x180E46A20 Slot: 47
	public override void WriteValue(Nullable<float> value) { }

	// RVA: 0xE46B50 Offset: 0xE45150 VA: 0x180E46B50 Slot: 31
	public override void WriteValue(double value) { }

	// RVA: 0xE47490 Offset: 0xE45A90 VA: 0x180E47490 Slot: 48
	public override void WriteValue(Nullable<double> value) { }

	// RVA: 0xE47580 Offset: 0xE45B80 VA: 0x180E47580 Slot: 32
	public override void WriteValue(bool value) { }

	// RVA: 0xE47280 Offset: 0xE45880 VA: 0x180E47280 Slot: 33
	public override void WriteValue(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE47660 Offset: 0xE45C60 VA: 0x180E47660 Slot: 34
	public override void WriteValue(ushort value) { }

	// RVA: 0xE473B0 Offset: 0xE459B0 VA: 0x180E473B0 Slot: 35
	public override void WriteValue(char value) { }

	// RVA: 0xE476A0 Offset: 0xE45CA0 VA: 0x180E476A0 Slot: 36
	public override void WriteValue(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE47930 Offset: 0xE45F30 VA: 0x180E47930 Slot: 37
	public override void WriteValue(sbyte value) { }

	// RVA: 0xE477E0 Offset: 0xE45DE0 VA: 0x180E477E0 Slot: 38
	public override void WriteValue(Decimal value) { }

	// RVA: 0xE46D00 Offset: 0xE45300 VA: 0x180E46D00 Slot: 39
	public override void WriteValue(DateTime value) { }

	// RVA: 0xE46C20 Offset: 0xE45220 VA: 0x180E46C20 Slot: 60
	public override void WriteValue(byte[] value) { }

	// RVA: 0xE46FD0 Offset: 0xE455D0 VA: 0x180E46FD0 Slot: 40
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0xE472C0 Offset: 0xE458C0 VA: 0x180E472C0 Slot: 41
	public override void WriteValue(Guid value) { }

	// RVA: 0xE47890 Offset: 0xE45E90 VA: 0x180E47890 Slot: 42
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0xE46890 Offset: 0xE44E90 VA: 0x180E46890 Slot: 61
	public override void WriteValue(Uri value) { }

	// RVA: 0xE45E50 Offset: 0xE44450 VA: 0x180E45E50 Slot: 63
	public override void WriteComment(string text) { }

	// RVA: 0xE45D80 Offset: 0xE44380 VA: 0x180E45D80
	private void EnsureWriteBuffer() { }

	// RVA: 0xE463B0 Offset: 0xE449B0 VA: 0x180E463B0
	private void WriteIntegerValue(long value) { }

	// RVA: 0xE46270 Offset: 0xE44870 VA: 0x180E46270
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

	// RVA: 0xE47D40 Offset: 0xE46340 VA: 0x180E47D40
	public void .ctor() { }

	// RVA: 0xE47D20 Offset: 0xE46320 VA: 0x180E47D20
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE47CE0 Offset: 0xE462E0 VA: 0x180E47CE0
	internal void .ctor(string message, Exception innerException, string path) { }

	// RVA: 0xE47AE0 Offset: 0xE460E0 VA: 0x180E47AE0
	internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex) { }

	// RVA: 0xE47C20 Offset: 0xE46220 VA: 0x180E47C20
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
	// RVA: 0xF8C2C0 Offset: 0xF8A8C0 VA: 0x180F8C2C0
	private void set_LineNumber(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8C2D0 Offset: 0xF8A8D0 VA: 0x180F8C2D0
	private void set_LinePosition(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E4060 Offset: 0x4E2660 VA: 0x1804E4060
	private void set_Path(string value) { }

	// RVA: 0xF8B500 Offset: 0xF89B00 VA: 0x180F8B500
	public void .ctor() { }

	// RVA: 0xF8B480 Offset: 0xF89A80 VA: 0x180F8B480
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF8C210 Offset: 0xF8A810 VA: 0x180F8C210
	internal void .ctor(string message, Exception innerException, string path, int lineNumber, int linePosition) { }

	// RVA: 0xF8BF10 Offset: 0xF8A510 VA: 0x180F8BF10
	internal static JsonReaderException Create(JsonReader reader, string message) { }

	// RVA: 0xF8BF20 Offset: 0xF8A520 VA: 0x180F8BF20
	internal static JsonReaderException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0xF8C0C0 Offset: 0xF8A6C0 VA: 0x180F8C0C0
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

	// RVA: 0xF8B440 Offset: 0xF89A40 VA: 0x180F8B440
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

	// RVA: 0x7D0D10 Offset: 0x7CF310 VA: 0x1807D0D10
	protected JsonReader.State get_CurrentState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC315B0 Offset: 0xC2FBB0 VA: 0x180C315B0
	public bool get_CloseInput() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC326D0 Offset: 0xC30CD0 VA: 0x180C326D0
	public void set_CloseInput(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE75B00 Offset: 0xE74100 VA: 0x180E75B00
	public bool get_SupportMultipleContent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE75B30 Offset: 0xE74130 VA: 0x180E75B30
	public void set_SupportMultipleContent(bool value) { }

	// RVA: 0x598420 Offset: 0x596A20 VA: 0x180598420
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0xF902D0 Offset: 0xF8E8D0 VA: 0x180F902D0
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0xAE9AA0 Offset: 0xAE80A0 VA: 0x180AE9AA0
	public DateParseHandling get_DateParseHandling() { }

	// RVA: 0xF90260 Offset: 0xF8E860 VA: 0x180F90260
	public void set_DateParseHandling(DateParseHandling value) { }

	// RVA: 0x5743A0 Offset: 0x5729A0 VA: 0x1805743A0
	public FloatParseHandling get_FloatParseHandling() { }

	// RVA: 0xF90340 Offset: 0xF8E940 VA: 0x180F90340
	public void set_FloatParseHandling(FloatParseHandling value) { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public string get_DateFormatString() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	public void set_DateFormatString(string value) { }

	// RVA: 0xF90130 Offset: 0xF8E730 VA: 0x180F90130
	public Nullable<int> get_MaxDepth() { }

	// RVA: 0xF903B0 Offset: 0xF8E9B0 VA: 0x180F903B0
	public void set_MaxDepth(Nullable<int> value) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 5
	public virtual JsonToken get_TokenType() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	public virtual object get_Value() { }

	// RVA: 0xF90240 Offset: 0xF8E840 VA: 0x180F90240 Slot: 7
	public virtual Type get_ValueType() { }

	// RVA: 0xF900C0 Offset: 0xF8E6C0 VA: 0x180F900C0 Slot: 8
	public virtual int get_Depth() { }

	// RVA: 0xF90140 Offset: 0xF8E740 VA: 0x180F90140 Slot: 9
	public virtual string get_Path() { }

	// RVA: 0xF90060 Offset: 0xF8E660 VA: 0x180F90060
	public CultureInfo get_Culture() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	public void set_Culture(CultureInfo value) { }

	// RVA: 0xF8C3F0 Offset: 0xF8A9F0 VA: 0x180F8C3F0
	internal JsonPosition GetPosition(int depth) { }

	// RVA: 0xF90030 Offset: 0xF8E630 VA: 0x180F90030
	protected void .ctor() { }

	// RVA: 0xF8C6E0 Offset: 0xF8ACE0 VA: 0x180F8C6E0
	private void Push(JsonContainerType value) { }

	// RVA: 0xF8C5E0 Offset: 0xF8ABE0 VA: 0x180F8C5E0
	private JsonContainerType Pop() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	private JsonContainerType Peek() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool Read();

	// RVA: 0xF8E020 Offset: 0xF8C620 VA: 0x180F8E020 Slot: 11
	public virtual Nullable<int> ReadAsInt32() { }

	// RVA: 0xF8F450 Offset: 0xF8DA50 VA: 0x180F8F450
	internal Nullable<int> ReadInt32String(string s) { }

	// RVA: 0xF8E300 Offset: 0xF8C900 VA: 0x180F8E300 Slot: 12
	public virtual string ReadAsString() { }

	// RVA: 0xF8CFE0 Offset: 0xF8B5E0 VA: 0x180F8CFE0 Slot: 13
	public virtual byte[] ReadAsBytes() { }

	// RVA: 0xF8CA80 Offset: 0xF8B080 VA: 0x180F8CA80
	internal byte[] ReadArrayIntoByteArray() { }

	// RVA: 0xF8DD50 Offset: 0xF8C350 VA: 0x180F8DD50 Slot: 14
	public virtual Nullable<double> ReadAsDouble() { }

	// RVA: 0xF8F200 Offset: 0xF8D800 VA: 0x180F8F200
	internal Nullable<double> ReadDoubleString(string s) { }

	// RVA: 0xF8CCF0 Offset: 0xF8B2F0 VA: 0x180F8CCF0 Slot: 15
	public virtual Nullable<bool> ReadAsBoolean() { }

	// RVA: 0xF8E720 Offset: 0xF8CD20 VA: 0x180F8E720
	internal Nullable<bool> ReadBooleanString(string s) { }

	// RVA: 0xF8DA50 Offset: 0xF8C050 VA: 0x180F8DA50 Slot: 16
	public virtual Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0xF8EF80 Offset: 0xF8D580 VA: 0x180F8EF80
	internal Nullable<Decimal> ReadDecimalString(string s) { }

	// RVA: 0xF8D780 Offset: 0xF8BD80 VA: 0x180F8D780 Slot: 17
	public virtual Nullable<DateTime> ReadAsDateTime() { }

	// RVA: 0xF8EC80 Offset: 0xF8D280 VA: 0x180F8EC80
	internal Nullable<DateTime> ReadDateTimeString(string s) { }

	// RVA: 0xF8D480 Offset: 0xF8BA80 VA: 0x180F8D480 Slot: 18
	public virtual Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0xF8E910 Offset: 0xF8CF10 VA: 0x180F8E910
	internal Nullable<DateTimeOffset> ReadDateTimeOffsetString(string s) { }

	// RVA: 0xF8F8B0 Offset: 0xF8DEB0 VA: 0x180F8F8B0
	internal void ReaderReadAndAssert() { }

	// RVA: 0xF8C300 Offset: 0xF8A900 VA: 0x180F8C300
	internal JsonReaderException CreateUnexpectedEndException() { }

	// RVA: 0xF8F660 Offset: 0xF8DC60 VA: 0x180F8F660
	internal void ReadIntoWrappedTypeObject() { }

	// RVA: 0xF8FC70 Offset: 0xF8E270 VA: 0x180F8FC70
	public void Skip() { }

	// RVA: 0xF8FC50 Offset: 0xF8E250 VA: 0x180F8FC50
	protected void SetToken(JsonToken newToken) { }

	// RVA: 0xF8FC30 Offset: 0xF8E230 VA: 0x180F8FC30
	protected void SetToken(JsonToken newToken, object value) { }

	// RVA: 0xF8FA70 Offset: 0xF8E070 VA: 0x180F8FA70
	internal void SetToken(JsonToken newToken, object value, bool updateIndex) { }

	// RVA: 0xF8F930 Offset: 0xF8DF30 VA: 0x180F8F930
	internal void SetPostValueState(bool updateIndex) { }

	// RVA: 0xF8FD90 Offset: 0xF8E390 VA: 0x180F8FD90
	private void UpdateScopeWithFinishedValue() { }

	// RVA: 0xF8FDA0 Offset: 0xF8E3A0 VA: 0x180F8FDA0
	private void ValidateEnd(JsonToken endToken) { }

	// RVA: 0xF8F960 Offset: 0xF8DF60 VA: 0x180F8F960
	protected void SetStateBasedOnCurrent() { }

	// RVA: 0xF8F910 Offset: 0xF8DF10 VA: 0x180F8F910
	private void SetFinished() { }

	// RVA: 0xF8C490 Offset: 0xF8AA90 VA: 0x180F8C490
	private JsonContainerType GetTypeForCloseToken(JsonToken token) { }

	// RVA: 0xF8FD20 Offset: 0xF8E320 VA: 0x180F8FD20 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0xF8C340 Offset: 0xF8A940 VA: 0x180F8C340 Slot: 19
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xF8C2E0 Offset: 0xF8A8E0 VA: 0x180F8C2E0 Slot: 20
	public virtual void Close() { }

	// RVA: 0xF8C9B0 Offset: 0xF8AFB0 VA: 0x180F8C9B0
	internal void ReadAndAssert() { }

	// RVA: 0xF8CA20 Offset: 0xF8B020 VA: 0x180F8CA20
	internal bool ReadAndMoveToContent() { }

	// RVA: 0xF8C580 Offset: 0xF8AB80 VA: 0x180F8C580
	internal bool MoveToContent() { }

	// RVA: 0xF8C370 Offset: 0xF8A970 VA: 0x180F8C370
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
	// RVA: 0xF8B2F0 Offset: 0xF898F0 VA: 0x180F8B2F0
	public static Func<JsonSerializerSettings> get_DefaultSettings() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8B350 Offset: 0xF89950 VA: 0x180F8B350
	public static void set_DefaultSettings(Func<JsonSerializerSettings> value) { }

	// RVA: 0xF8AFF0 Offset: 0xF895F0 VA: 0x180F8AFF0
	private static void .cctor() { }

	// RVA: 0xF8A230 Offset: 0xF88830 VA: 0x180F8A230
	internal static JsonSerializerSettings GetDefaultSettings() { }

	// RVA: 0xF8AD90 Offset: 0xF89390 VA: 0x180F8AD90
	public static string ToString(bool value) { }

	// RVA: 0xF8A970 Offset: 0xF88F70 VA: 0x180F8A970
	public static string ToString(char value) { }

	// RVA: 0xF8AAC0 Offset: 0xF890C0 VA: 0x180F8AAC0
	internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0xF8A0D0 Offset: 0xF886D0 VA: 0x180F8A0D0
	private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0xF8AEF0 Offset: 0xF894F0 VA: 0x180F8AEF0
	internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0xF89FD0 Offset: 0xF885D0 VA: 0x180F89FD0
	private static string EnsureDecimalPlace(double value, string text) { }

	// RVA: 0xF89F60 Offset: 0xF88560 VA: 0x180F89F60
	private static string EnsureDecimalPlace(string text) { }

	// RVA: 0xF8ABC0 Offset: 0xF891C0 VA: 0x180F8ABC0
	public static string ToString(Decimal value) { }

	// RVA: 0xF8A890 Offset: 0xF88E90 VA: 0x180F8A890
	public static string ToString(string value) { }

	// RVA: 0xF8ACA0 Offset: 0xF892A0 VA: 0x180F8ACA0
	public static string ToString(string value, char delimiter) { }

	// RVA: 0xF8AE30 Offset: 0xF89430 VA: 0x180F8AE30
	public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0xF8A510 Offset: 0xF88B10 VA: 0x180F8A510
	public static string SerializeObject(object value) { }

	// RVA: 0xF8A780 Offset: 0xF88D80 VA: 0x180F8A780
	public static string SerializeObject(object value, Formatting formatting) { }

	// RVA: 0xF8A470 Offset: 0xF88A70 VA: 0x180F8A470
	public static string SerializeObject(object value, Type type, JsonSerializerSettings settings) { }

	// RVA: 0xF8A5C0 Offset: 0xF88BC0 VA: 0x180F8A5C0
	public static string SerializeObject(object value, Formatting formatting, JsonSerializerSettings settings) { }

	// RVA: 0xF8A6B0 Offset: 0xF88CB0 VA: 0x180F8A6B0
	public static string SerializeObject(object value, Type type, Formatting formatting, JsonSerializerSettings settings) { }

	// RVA: 0xF8A290 Offset: 0xF88890 VA: 0x180F8A290
	private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer) { }

	// RVA: 0xF89EF0 Offset: 0xF884F0 VA: 0x180F89EF0
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

	// RVA: 0xF89CD0 Offset: 0xF882D0 VA: 0x180F89CD0
	public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings) { }

}

public class JsonSerializationException : JsonException // TypeDefIndex: 5905
{	// Methods

	// RVA: 0xF8B500 Offset: 0xF89B00 VA: 0x180F8B500
	public void .ctor() { }

	// RVA: 0xF8B5E0 Offset: 0xF89BE0 VA: 0x180F8B5E0
	public void .ctor(string message) { }

	// RVA: 0xF8B560 Offset: 0xF89B60 VA: 0x180F8B560
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0xF8B480 Offset: 0xF89A80 VA: 0x180F8B480
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF90520 Offset: 0xF8EB20 VA: 0x180F90520
	internal static JsonSerializationException Create(JsonReader reader, string message) { }

	// RVA: 0xF90530 Offset: 0xF8EB30 VA: 0x180F90530
	internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0xF90440 Offset: 0xF8EA40 VA: 0x180F90440
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
	// RVA: 0xF92E30 Offset: 0xF91430 VA: 0x180F92E30 Slot: 4
	public virtual void add_Error(EventHandler<ErrorEventArgs> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF92FE0 Offset: 0xF915E0 VA: 0x180F92FE0 Slot: 5
	public virtual void remove_Error(EventHandler<ErrorEventArgs> value) { }

	// RVA: 0xF93640 Offset: 0xF91C40 VA: 0x180F93640 Slot: 6
	public virtual void set_ReferenceResolver(IReferenceResolver value) { }

	// RVA: 0xF93080 Offset: 0xF91680 VA: 0x180F93080 Slot: 7
	public virtual void set_Binder(SerializationBinder value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 8
	public virtual ITraceWriter get_TraceWriter() { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810 Slot: 9
	public virtual void set_TraceWriter(ITraceWriter value) { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890 Slot: 10
	public virtual void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0xF93740 Offset: 0xF91D40 VA: 0x180F93740 Slot: 11
	public virtual void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0xF936D0 Offset: 0xF91CD0 VA: 0x180F936D0 Slot: 12
	public virtual void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	// RVA: 0xF93560 Offset: 0xF91B60 VA: 0x180F93560 Slot: 13
	public virtual void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0xF935D0 Offset: 0xF91BD0 VA: 0x180F935D0 Slot: 14
	public virtual void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0xF93410 Offset: 0xF91A10 VA: 0x180F93410 Slot: 15
	public virtual void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0xF93480 Offset: 0xF91A80 VA: 0x180F93480 Slot: 16
	public virtual void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0xF932D0 Offset: 0xF918D0 VA: 0x180F932D0 Slot: 17
	public virtual void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0x7D0D10 Offset: 0x7CF310 VA: 0x1807D0D10 Slot: 18
	public virtual ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0xF934F0 Offset: 0xF91AF0 VA: 0x180F934F0 Slot: 19
	public virtual void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0xF93170 Offset: 0xF91770 VA: 0x180F93170 Slot: 20
	public virtual void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40 Slot: 21
	public virtual MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0xF933A0 Offset: 0xF919A0 VA: 0x180F933A0 Slot: 22
	public virtual void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0xF92F10 Offset: 0xF91510 VA: 0x180F92F10 Slot: 23
	public virtual JsonConverterCollection get_Converters() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0 Slot: 24
	public virtual IContractResolver get_ContractResolver() { }

	// RVA: 0xF93200 Offset: 0xF91800 VA: 0x180F93200 Slot: 25
	public virtual void set_ContractResolver(IContractResolver value) { }

	// RVA: 0xC32100 Offset: 0xC30700 VA: 0x180C32100 Slot: 26
	public virtual StreamingContext get_Context() { }

	// RVA: 0xF931E0 Offset: 0xF917E0 VA: 0x180F931E0 Slot: 27
	public virtual void set_Context(StreamingContext value) { }

	// RVA: 0xF92FA0 Offset: 0xF915A0 VA: 0x180F92FA0 Slot: 28
	public virtual Formatting get_Formatting() { }

	// RVA: 0xF93340 Offset: 0xF91940 VA: 0x180F93340 Slot: 29
	public virtual void set_Formatting(Formatting value) { }

	// RVA: 0xF92ED0 Offset: 0xF914D0 VA: 0x180F92ED0 Slot: 30
	public virtual bool get_CheckAdditionalContent() { }

	// RVA: 0xF93110 Offset: 0xF91710 VA: 0x180F93110 Slot: 31
	public virtual void set_CheckAdditionalContent(bool value) { }

	// RVA: 0xF91ED0 Offset: 0xF904D0 VA: 0x180F91ED0
	internal bool IsCheckAdditionalContentSet() { }

	// RVA: 0xF92CC0 Offset: 0xF912C0 VA: 0x180F92CC0
	public void .ctor() { }

	// RVA: 0xF91610 Offset: 0xF8FC10 VA: 0x180F91610
	public static JsonSerializer Create() { }

	// RVA: 0xF917B0 Offset: 0xF8FDB0 VA: 0x180F917B0
	public static JsonSerializer Create(JsonSerializerSettings settings) { }

	// RVA: 0xF91370 Offset: 0xF8F970 VA: 0x180F91370
	public static JsonSerializer CreateDefault() { }

	// RVA: 0xF915D0 Offset: 0xF8FBD0 VA: 0x180F915D0
	public static JsonSerializer CreateDefault(JsonSerializerSettings settings) { }

	// RVA: 0xF90B70 Offset: 0xF8F170 VA: 0x180F90B70
	private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings) { }

	// RVA: 0xF922A0 Offset: 0xF908A0 VA: 0x180F922A0
	public void Populate(JsonReader reader, object target) { }

	// RVA: 0xF91F70 Offset: 0xF90570 VA: 0x180F91F70 Slot: 32
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

	// RVA: 0xF91CC0 Offset: 0xF902C0 VA: 0x180F91CC0
	public object Deserialize(JsonReader reader, Type objectType) { }

	// RVA: 0xF91970 Offset: 0xF8FF70 VA: 0x180F91970 Slot: 33
	internal virtual object DeserializeInternal(JsonReader reader, Type objectType) { }

	// RVA: 0xF92910 Offset: 0xF90F10 VA: 0x180F92910
	private void SetupReader(JsonReader reader, out CultureInfo previousCulture, out Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, out Nullable<DateParseHandling> previousDateParseHandling, out Nullable<FloatParseHandling> previousFloatParseHandling, out Nullable<int> previousMaxDepth, out string previousDateFormatString) { }

	// RVA: 0xF922C0 Offset: 0xF908C0 VA: 0x180F922C0
	private void ResetReader(JsonReader reader, CultureInfo previousCulture, Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, Nullable<DateParseHandling> previousDateParseHandling, Nullable<FloatParseHandling> previousFloatParseHandling, Nullable<int> previousMaxDepth, string previousDateFormatString) { }

	// RVA: 0xF928F0 Offset: 0xF90EF0 VA: 0x180F928F0
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0xF928C0 Offset: 0xF90EC0 VA: 0x180F928C0
	public void Serialize(JsonWriter jsonWriter, object value) { }

	// RVA: 0xF92430 Offset: 0xF90A30 VA: 0x180F92430 Slot: 34
	internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0xF91E60 Offset: 0xF90460 VA: 0x180F91E60
	internal IReferenceResolver GetReferenceResolver() { }

	// RVA: 0xF91CE0 Offset: 0xF902E0 VA: 0x180F91CE0
	internal JsonConverter GetMatchingConverter(Type type) { }

	// RVA: 0xF91DA0 Offset: 0xF903A0 VA: 0x180F91DA0
	internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType) { }

	// RVA: 0xF91F10 Offset: 0xF90510 VA: 0x180F91F10
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

	// RVA: 0xE48340 Offset: 0xE46940 VA: 0x180E48340
	internal static JsonWriter.State[][] BuildStateArray() { }

	// RVA: 0xE4B7A0 Offset: 0xE49DA0 VA: 0x180E4B7A0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1150 Offset: 0x8BF750 VA: 0x1808C1150
	public bool get_CloseOutput() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x78E280 Offset: 0x78C880 VA: 0x18078E280
	public void set_CloseOutput(bool value) { }

	// RVA: 0xE4C780 Offset: 0xE4AD80 VA: 0x180E4C780
	protected internal int get_Top() { }

	// RVA: 0xE4C7E0 Offset: 0xE4ADE0 VA: 0x180E4C7E0
	public WriteState get_WriteState() { }

	// RVA: 0xE4C590 Offset: 0xE4AB90 VA: 0x180E4C590
	internal string get_ContainerPath() { }

	// RVA: 0xE4C680 Offset: 0xE4AC80 VA: 0x180E4C680
	public string get_Path() { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40
	public Formatting get_Formatting() { }

	// RVA: 0xE4CA40 Offset: 0xE4B040 VA: 0x180E4CA40
	public void set_Formatting(Formatting value) { }

	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50
	public DateFormatHandling get_DateFormatHandling() { }

	// RVA: 0xE4C8F0 Offset: 0xE4AEF0 VA: 0x180E4C8F0
	public void set_DateFormatHandling(DateFormatHandling value) { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0xE4C960 Offset: 0xE4AF60 VA: 0x180E4C960
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0x5DE450 Offset: 0x5DCA50 VA: 0x1805DE450
	public StringEscapeHandling get_StringEscapeHandling() { }

	// RVA: 0xE4CAB0 Offset: 0xE4B0B0 VA: 0x180E4CAB0
	public void set_StringEscapeHandling(StringEscapeHandling value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	internal virtual void OnStringEscapeHandlingChanged() { }

	// RVA: 0x598420 Offset: 0x596A20 VA: 0x180598420
	public FloatFormatHandling get_FloatFormatHandling() { }

	// RVA: 0xE4C9D0 Offset: 0xE4AFD0 VA: 0x180E4C9D0
	public void set_FloatFormatHandling(FloatFormatHandling value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public string get_DateFormatString() { }

	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	public void set_DateFormatString(string value) { }

	// RVA: 0xE4C620 Offset: 0xE4AC20 VA: 0x180E4C620
	public CultureInfo get_Culture() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	public void set_Culture(CultureInfo value) { }

	// RVA: 0xE4C560 Offset: 0xE4AB60 VA: 0x180E4C560
	protected void .ctor() { }

	// RVA: 0xE48C20 Offset: 0xE47220 VA: 0x180E48C20
	internal void UpdateScopeWithFinishedValue() { }

	// RVA: 0xE48AB0 Offset: 0xE470B0 VA: 0x180E48AB0
	private void Push(JsonContainerType value) { }

	// RVA: 0xE489C0 Offset: 0xE46FC0 VA: 0x180E489C0
	private JsonContainerType Pop() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	private JsonContainerType Peek() { }

	// RVA: 0xE39E60 Offset: 0xE38460 VA: 0x180E39E60 Slot: 6
	public virtual void Close() { }

	// RVA: 0xE49120 Offset: 0xE47720 VA: 0x180E49120 Slot: 7
	public virtual void WriteStartObject() { }

	// RVA: 0xE48E90 Offset: 0xE47490 VA: 0x180E48E90 Slot: 8
	public virtual void WriteEndObject() { }

	// RVA: 0xE49100 Offset: 0xE47700 VA: 0x180E49100 Slot: 9
	public virtual void WriteStartArray() { }

	// RVA: 0xE48E70 Offset: 0xE47470 VA: 0x180E48E70 Slot: 10
	public virtual void WriteEndArray() { }

	// RVA: 0xE49110 Offset: 0xE47710 VA: 0x180E49110 Slot: 11
	public virtual void WriteStartConstructor(string name) { }

	// RVA: 0xE48E80 Offset: 0xE47480 VA: 0x180E48E80 Slot: 12
	public virtual void WriteEndConstructor() { }

	// RVA: 0xE48860 Offset: 0xE46E60 VA: 0x180E48860 Slot: 13
	public virtual void WritePropertyName(string name) { }

	// RVA: 0xE49090 Offset: 0xE47690 VA: 0x180E49090 Slot: 14
	public virtual void WritePropertyName(string name, bool escape) { }

	// RVA: 0xE48F90 Offset: 0xE47590 VA: 0x180E48F90 Slot: 15
	public virtual void WriteEnd() { }

	// RVA: 0xE49340 Offset: 0xE47940 VA: 0x180E49340
	public void WriteToken(JsonReader reader) { }

	// RVA: 0xE49BC0 Offset: 0xE481C0 VA: 0x180E49BC0
	public void WriteToken(JsonReader reader, bool writeChildren) { }

	// RVA: 0xE493B0 Offset: 0xE479B0 VA: 0x180E493B0
	public void WriteToken(JsonToken token, object value) { }

	// RVA: 0xE49130 Offset: 0xE47730 VA: 0x180E49130 Slot: 16
	internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

	// RVA: 0xE48C30 Offset: 0xE47230 VA: 0x180E48C30
	private void WriteConstructorDate(JsonReader reader) { }

	// RVA: 0xE48EA0 Offset: 0xE474A0 VA: 0x180E48EA0
	private void WriteEnd(JsonContainerType type) { }

	// RVA: 0xE39E60 Offset: 0xE38460 VA: 0x180E39E60
	private void AutoCompleteAll() { }

	// RVA: 0xE48780 Offset: 0xE46D80 VA: 0x180E48780
	private JsonToken GetCloseTokenForType(JsonContainerType type) { }

	// RVA: 0xE47D50 Offset: 0xE46350 VA: 0x180E47D50
	private void AutoCompleteClose(JsonContainerType type) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 17
	protected virtual void WriteEnd(JsonToken token) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	protected virtual void WriteIndent() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 19
	protected virtual void WriteValueDelimiter() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 20
	protected virtual void WriteIndentSpace() { }

	// RVA: 0xE480E0 Offset: 0xE466E0 VA: 0x180E480E0
	internal void AutoComplete(JsonToken tokenBeingWritten) { }

	// RVA: 0xE49070 Offset: 0xE47670 VA: 0x180E49070 Slot: 21
	public virtual void WriteNull() { }

	// RVA: 0xE49C40 Offset: 0xE48240 VA: 0x180E49C40 Slot: 22
	public virtual void WriteUndefined() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 23
	public virtual void WriteRaw(string json) { }

	// RVA: 0xE490B0 Offset: 0xE476B0 VA: 0x180E490B0 Slot: 24
	public virtual void WriteRawValue(string json) { }

	// RVA: 0xE49CD0 Offset: 0xE482D0 VA: 0x180E49CD0 Slot: 25
	public virtual void WriteValue(string value) { }

	// RVA: 0xE4AE80 Offset: 0xE49480 VA: 0x180E4AE80 Slot: 26
	public virtual void WriteValue(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE4AE80 Offset: 0xE49480 VA: 0x180E4AE80 Slot: 27
	public virtual void WriteValue(uint value) { }

	// RVA: 0xE4AE80 Offset: 0xE49480 VA: 0x180E4AE80 Slot: 28
	public virtual void WriteValue(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE4AE80 Offset: 0xE49480 VA: 0x180E4AE80 Slot: 29
	public virtual void WriteValue(ulong value) { }

	// RVA: 0xE4B300 Offset: 0xE49900 VA: 0x180E4B300 Slot: 30
	public virtual void WriteValue(float value) { }

	// RVA: 0xE4B300 Offset: 0xE49900 VA: 0x180E4B300 Slot: 31
	public virtual void WriteValue(double value) { }

	// RVA: 0xE4B180 Offset: 0xE49780 VA: 0x180E4B180 Slot: 32
	public virtual void WriteValue(bool value) { }

	// RVA: 0xE4AE80 Offset: 0xE49480 VA: 0x180E4AE80 Slot: 33
	public virtual void WriteValue(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE4AE80 Offset: 0xE49480 VA: 0x180E4AE80 Slot: 34
	public virtual void WriteValue(ushort value) { }

	// RVA: 0xE49CD0 Offset: 0xE482D0 VA: 0x180E49CD0 Slot: 35
	public virtual void WriteValue(char value) { }

	// RVA: 0xE4AE80 Offset: 0xE49480 VA: 0x180E4AE80 Slot: 36
	public virtual void WriteValue(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE4AE80 Offset: 0xE49480 VA: 0x180E4AE80 Slot: 37
	public virtual void WriteValue(sbyte value) { }

	// RVA: 0xE4B300 Offset: 0xE49900 VA: 0x180E4B300 Slot: 38
	public virtual void WriteValue(Decimal value) { }

	// RVA: 0xE4B2E0 Offset: 0xE498E0 VA: 0x180E4B2E0 Slot: 39
	public virtual void WriteValue(DateTime value) { }

	// RVA: 0xE4B2E0 Offset: 0xE498E0 VA: 0x180E4B2E0 Slot: 40
	public virtual void WriteValue(DateTimeOffset value) { }

	// RVA: 0xE49CD0 Offset: 0xE482D0 VA: 0x180E49CD0 Slot: 41
	public virtual void WriteValue(Guid value) { }

	// RVA: 0xE49CD0 Offset: 0xE482D0 VA: 0x180E49CD0 Slot: 42
	public virtual void WriteValue(TimeSpan value) { }

	// RVA: 0xE4B020 Offset: 0xE49620 VA: 0x180E4B020 Slot: 43
	public virtual void WriteValue(Nullable<int> value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE4B730 Offset: 0xE49D30 VA: 0x180E4B730 Slot: 44
	public virtual void WriteValue(Nullable<uint> value) { }

	// RVA: 0xE4B5D0 Offset: 0xE49BD0 VA: 0x180E4B5D0 Slot: 45
	public virtual void WriteValue(Nullable<long> value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE49C60 Offset: 0xE48260 VA: 0x180E49C60 Slot: 46
	public virtual void WriteValue(Nullable<ulong> value) { }

	// RVA: 0xE4B640 Offset: 0xE49C40 VA: 0x180E4B640 Slot: 47
	public virtual void WriteValue(Nullable<float> value) { }

	// RVA: 0xE4AF10 Offset: 0xE49510 VA: 0x180E4AF10 Slot: 48
	public virtual void WriteValue(Nullable<double> value) { }

	// RVA: 0xE4B400 Offset: 0xE49A00 VA: 0x180E4B400 Slot: 49
	public virtual void WriteValue(Nullable<bool> value) { }

	// RVA: 0xE4B320 Offset: 0xE49920 VA: 0x180E4B320 Slot: 50
	public virtual void WriteValue(Nullable<short> value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE4B090 Offset: 0xE49690 VA: 0x180E4B090 Slot: 51
	public virtual void WriteValue(Nullable<ushort> value) { }

	// RVA: 0xE4B390 Offset: 0xE49990 VA: 0x180E4B390 Slot: 52
	public virtual void WriteValue(Nullable<char> value) { }

	// RVA: 0xE4B1A0 Offset: 0xE497A0 VA: 0x180E4B1A0 Slot: 53
	public virtual void WriteValue(Nullable<byte> value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE4AEA0 Offset: 0xE494A0 VA: 0x180E4AEA0 Slot: 54
	public virtual void WriteValue(Nullable<sbyte> value) { }

	// RVA: 0xE4B100 Offset: 0xE49700 VA: 0x180E4B100 Slot: 55
	public virtual void WriteValue(Nullable<Decimal> value) { }

	// RVA: 0xE4B560 Offset: 0xE49B60 VA: 0x180E4B560 Slot: 56
	public virtual void WriteValue(Nullable<DateTime> value) { }

	// RVA: 0xE4B6B0 Offset: 0xE49CB0 VA: 0x180E4B6B0 Slot: 57
	public virtual void WriteValue(Nullable<DateTimeOffset> value) { }

	// RVA: 0xE4B470 Offset: 0xE49A70 VA: 0x180E4B470 Slot: 58
	public virtual void WriteValue(Nullable<Guid> value) { }

	// RVA: 0xE4B4F0 Offset: 0xE49AF0 VA: 0x180E4B4F0 Slot: 59
	public virtual void WriteValue(Nullable<TimeSpan> value) { }

	// RVA: 0xE49CF0 Offset: 0xE482F0 VA: 0x180E49CF0 Slot: 60
	public virtual void WriteValue(byte[] value) { }

	// RVA: 0xE4AF80 Offset: 0xE49580 VA: 0x180E4AF80 Slot: 61
	public virtual void WriteValue(Uri value) { }

	// RVA: 0xE4B210 Offset: 0xE49810 VA: 0x180E4B210 Slot: 62
	public virtual void WriteValue(object value) { }

	// RVA: 0xE48840 Offset: 0xE46E40 VA: 0x180E48840 Slot: 63
	public virtual void WriteComment(string text) { }

	// RVA: 0xE48BB0 Offset: 0xE471B0 VA: 0x180E48BB0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE48750 Offset: 0xE46D50 VA: 0x180E48750 Slot: 64
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xE49D20 Offset: 0xE48320 VA: 0x180E49D20
	internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value) { }

	// RVA: 0xE486A0 Offset: 0xE46CA0 VA: 0x180E486A0
	private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value) { }

	// RVA: 0xE48850 Offset: 0xE46E50 VA: 0x180E48850
	internal void InternalWriteEnd(JsonContainerType container) { }

	// RVA: 0xE48860 Offset: 0xE46E60 VA: 0x180E48860
	internal void InternalWritePropertyName(string name) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void InternalWriteRaw() { }

	// RVA: 0xE48890 Offset: 0xE46E90 VA: 0x180E48890
	internal void InternalWriteStart(JsonToken token, JsonContainerType container) { }

	// RVA: 0xE489A0 Offset: 0xE46FA0 VA: 0x180E489A0
	internal void InternalWriteValue(JsonToken token) { }

	// RVA: 0xE48840 Offset: 0xE46E40 VA: 0x180E48840
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

	// RVA: 0x1809060 Offset: 0x1807660 VA: 0x181809060
	internal static bool IsEndToken(JsonToken token) { }

	// RVA: 0x18090D0 Offset: 0x18076D0 VA: 0x1818090D0
	internal static bool IsStartToken(JsonToken token) { }

	// RVA: 0x1809080 Offset: 0x1807680 VA: 0x181809080
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

	// RVA: 0x13F1E90 Offset: 0x13F0490 VA: 0x1813F1E90
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
	// RVA: 0x13F1E60 Offset: 0x13F0460 VA: 0x1813F1E60
	public Nullable<bool> get_ItemIsReference() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1EF0 Offset: 0x13F04F0 VA: 0x1813F1EF0
	public void set_ItemIsReference(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1E70 Offset: 0x13F0470 VA: 0x1813F1E70
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1F00 Offset: 0x13F0500 VA: 0x1813F1F00
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1E80 Offset: 0x13F0480 VA: 0x1813F1E80
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1F10 Offset: 0x13F0510 VA: 0x1813F1F10
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

	// RVA: 0x13F1D60 Offset: 0x13F0360 VA: 0x1813F1D60
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

	// RVA: 0x18134D0 Offset: 0x1811AD0 VA: 0x1818134D0
	public void .ctor(JsonReader innerReader) { }

	// RVA: 0x1812F40 Offset: 0x1811540 VA: 0x181812F40
	public string GetDeserializedJsonMessage() { }

	// RVA: 0x1813460 Offset: 0x1811A60 VA: 0x181813460 Slot: 10
	public override bool Read() { }

	// RVA: 0x1813380 Offset: 0x1811980 VA: 0x181813380 Slot: 11
	public override Nullable<int> ReadAsInt32() { }

	// RVA: 0x18133F0 Offset: 0x18119F0 VA: 0x1818133F0 Slot: 12
	public override string ReadAsString() { }

	// RVA: 0x1813100 Offset: 0x1811700 VA: 0x181813100 Slot: 13
	public override byte[] ReadAsBytes() { }

	// RVA: 0x1813280 Offset: 0x1811880 VA: 0x181813280 Slot: 16
	public override Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0x1813300 Offset: 0x1811900 VA: 0x181813300 Slot: 14
	public override Nullable<double> ReadAsDouble() { }

	// RVA: 0x1813090 Offset: 0x1811690 VA: 0x181813090 Slot: 15
	public override Nullable<bool> ReadAsBoolean() { }

	// RVA: 0x1813200 Offset: 0x1811800 VA: 0x181813200 Slot: 17
	public override Nullable<DateTime> ReadAsDateTime() { }

	// RVA: 0x1813170 Offset: 0x1811770 VA: 0x181813170 Slot: 18
	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0x1813620 Offset: 0x1811C20 VA: 0x181813620 Slot: 8
	public override int get_Depth() { }

	// RVA: 0x1813650 Offset: 0x1811C50 VA: 0x181813650 Slot: 9
	public override string get_Path() { }

	// RVA: 0x1813680 Offset: 0x1811C80 VA: 0x181813680 Slot: 5
	public override JsonToken get_TokenType() { }

	// RVA: 0x18136E0 Offset: 0x1811CE0 VA: 0x1818136E0 Slot: 6
	public override object get_Value() { }

	// RVA: 0x18136B0 Offset: 0x1811CB0 VA: 0x1818136B0 Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0x1812F10 Offset: 0x1811510 VA: 0x181812F10 Slot: 20
	public override void Close() { }

	// RVA: 0x1812F70 Offset: 0x1811570 VA: 0x181812F70 Slot: 21
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0x1812FD0 Offset: 0x18115D0 VA: 0x181812FD0 Slot: 22
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0x1813030 Offset: 0x1811630 VA: 0x181813030 Slot: 23
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

}

internal class TraceJsonWriter : JsonWriter // TypeDefIndex: 5981
{	// Fields
	private readonly JsonWriter _innerWriter; // 0x60
	private readonly JsonTextWriter _textWriter; // 0x68
	private readonly StringWriter _sw; // 0x70

	// Methods

	// RVA: 0x1814650 Offset: 0x1812C50 VA: 0x181814650
	public void .ctor(JsonWriter innerWriter) { }

	// RVA: 0x1813760 Offset: 0x1811D60 VA: 0x181813760
	public string GetSerializedJsonMessage() { }

	// RVA: 0x18142A0 Offset: 0x18128A0 VA: 0x1818142A0 Slot: 38
	public override void WriteValue(Decimal value) { }

	// RVA: 0x1813E90 Offset: 0x1812490 VA: 0x181813E90 Slot: 32
	public override void WriteValue(bool value) { }

	// RVA: 0x1814400 Offset: 0x1812A00 VA: 0x181814400 Slot: 36
	public override void WriteValue(byte value) { }

	// RVA: 0x1814230 Offset: 0x1812830 VA: 0x181814230 Slot: 53
	public override void WriteValue(Nullable<byte> value) { }

	// RVA: 0x1813D40 Offset: 0x1812340 VA: 0x181813D40 Slot: 35
	public override void WriteValue(char value) { }

	// RVA: 0x1813C70 Offset: 0x1812270 VA: 0x181813C70 Slot: 60
	public override void WriteValue(byte[] value) { }

	// RVA: 0x18144E0 Offset: 0x1812AE0 VA: 0x1818144E0 Slot: 39
	public override void WriteValue(DateTime value) { }

	// RVA: 0x1814550 Offset: 0x1812B50 VA: 0x181814550 Slot: 40
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0x1814070 Offset: 0x1812670 VA: 0x181814070 Slot: 31
	public override void WriteValue(double value) { }

	// RVA: 0x1813C20 Offset: 0x1812220 VA: 0x181813C20 Slot: 22
	public override void WriteUndefined() { }

	// RVA: 0x18138F0 Offset: 0x1811EF0 VA: 0x1818138F0 Slot: 21
	public override void WriteNull() { }

	// RVA: 0x1814470 Offset: 0x1812A70 VA: 0x181814470 Slot: 30
	public override void WriteValue(float value) { }

	// RVA: 0x1813F70 Offset: 0x1812570 VA: 0x181813F70 Slot: 41
	public override void WriteValue(Guid value) { }

	// RVA: 0x1813CE0 Offset: 0x18122E0 VA: 0x181813CE0 Slot: 26
	public override void WriteValue(int value) { }

	// RVA: 0x1813DB0 Offset: 0x18123B0 VA: 0x181813DB0 Slot: 28
	public override void WriteValue(long value) { }

	// RVA: 0x1813F00 Offset: 0x1812500 VA: 0x181813F00 Slot: 62
	public override void WriteValue(object value) { }

	// RVA: 0x1814330 Offset: 0x1812930 VA: 0x181814330 Slot: 37
	public override void WriteValue(sbyte value) { }

	// RVA: 0x1814000 Offset: 0x1812600 VA: 0x181814000 Slot: 33
	public override void WriteValue(short value) { }

	// RVA: 0x1814150 Offset: 0x1812750 VA: 0x181814150 Slot: 25
	public override void WriteValue(string value) { }

	// RVA: 0x18145E0 Offset: 0x1812BE0 VA: 0x1818145E0 Slot: 42
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0x18143A0 Offset: 0x18129A0 VA: 0x1818143A0 Slot: 27
	public override void WriteValue(uint value) { }

	// RVA: 0x1813E20 Offset: 0x1812420 VA: 0x181813E20 Slot: 29
	public override void WriteValue(ulong value) { }

	// RVA: 0x18140E0 Offset: 0x18126E0 VA: 0x1818140E0 Slot: 61
	public override void WriteValue(Uri value) { }

	// RVA: 0x18141C0 Offset: 0x18127C0 VA: 0x1818141C0 Slot: 34
	public override void WriteValue(ushort value) { }

	// RVA: 0x1813790 Offset: 0x1811D90 VA: 0x181813790 Slot: 63
	public override void WriteComment(string text) { }

	// RVA: 0x1813B10 Offset: 0x1812110 VA: 0x181813B10 Slot: 9
	public override void WriteStartArray() { }

	// RVA: 0x1813800 Offset: 0x1811E00 VA: 0x181813800 Slot: 10
	public override void WriteEndArray() { }

	// RVA: 0x1813B60 Offset: 0x1812160 VA: 0x181813B60 Slot: 11
	public override void WriteStartConstructor(string name) { }

	// RVA: 0x1813850 Offset: 0x1811E50 VA: 0x181813850 Slot: 12
	public override void WriteEndConstructor() { }

	// RVA: 0x18139C0 Offset: 0x1811FC0 VA: 0x1818139C0 Slot: 13
	public override void WritePropertyName(string name) { }

	// RVA: 0x1813940 Offset: 0x1811F40 VA: 0x181813940 Slot: 14
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0x1813BD0 Offset: 0x18121D0 VA: 0x181813BD0 Slot: 7
	public override void WriteStartObject() { }

	// RVA: 0x18138A0 Offset: 0x1811EA0 VA: 0x1818138A0 Slot: 8
	public override void WriteEndObject() { }

	// RVA: 0x1813A30 Offset: 0x1812030 VA: 0x181813A30 Slot: 24
	public override void WriteRawValue(string json) { }

	// RVA: 0x1813AA0 Offset: 0x18120A0 VA: 0x181813AA0 Slot: 23
	public override void WriteRaw(string json) { }

	// RVA: 0x1813710 Offset: 0x1811D10 VA: 0x181813710 Slot: 6
	public override void Close() { }

}

internal class JsonFormatterConverter : IFormatterConverter // TypeDefIndex: 5982
{	// Fields
	private readonly JsonSerializerInternalReader _reader; // 0x10
	private readonly JsonISerializableContract _contract; // 0x18
	private readonly JsonProperty _member; // 0x20

	// Methods

	// RVA: 0x13F3ED0 Offset: 0x13F24D0 VA: 0x1813F3ED0
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

	// RVA: 0x13F3AE0 Offset: 0x13F20E0 VA: 0x1813F3AE0 Slot: 4
	public object Convert(object value, Type type) { }

	// RVA: 0x13F3D40 Offset: 0x13F2340 VA: 0x1813F3D40 Slot: 5
	public bool ToBoolean(object value) { }

	// RVA: 0x13F3D90 Offset: 0x13F2390 VA: 0x1813F3D90 Slot: 6
	public int ToInt32(object value) { }

	// RVA: 0x13F3DE0 Offset: 0x13F23E0 VA: 0x1813F3DE0 Slot: 7
	public long ToInt64(object value) { }

	// RVA: 0x13F3E30 Offset: 0x13F2430 VA: 0x1813F3E30 Slot: 8
	public float ToSingle(object value) { }

	// RVA: 0x13F3E80 Offset: 0x13F2480 VA: 0x1813F3E80 Slot: 9
	public string ToString(object value) { }

}

public class JsonLinqContract : JsonContract // TypeDefIndex: 5984
{	// Methods

	// RVA: 0x13F3FA0 Offset: 0x13F25A0 VA: 0x1813F3FA0
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
	// RVA: 0xD27AA0 Offset: 0xD260A0 VA: 0x180D27AA0
	internal PrimitiveTypeCode get_TypeCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD27A10 Offset: 0xD26010 VA: 0x180D27A10
	internal void set_TypeCode(PrimitiveTypeCode value) { }

	// RVA: 0x13F48C0 Offset: 0x13F2EC0 VA: 0x1813F48C0
	public void .ctor(Type underlyingType) { }

	// RVA: 0x13F4680 Offset: 0x13F2C80 VA: 0x1813F4680
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
	// RVA: 0x104F470 Offset: 0x104DA70 VA: 0x18104F470
	public Type get_CollectionItemType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEFB1E0 Offset: 0xEF97E0 VA: 0x180EFB1E0
	private void set_CollectionItemType(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1C20 Offset: 0x13F0220 VA: 0x1813F1C20
	public bool get_IsMultidimensionalArray() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1D10 Offset: 0x13F0310 VA: 0x1813F1D10
	private void set_IsMultidimensionalArray(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA03B0 Offset: 0xD9E9B0 VA: 0x180DA03B0
	internal bool get_IsArray() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA0790 Offset: 0xD9ED90 VA: 0x180DA0790
	private void set_IsArray(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1CE0 Offset: 0x13F02E0 VA: 0x1813F1CE0
	internal bool get_ShouldCreateWrapper() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1D50 Offset: 0x13F0350 VA: 0x1813F1D50
	private void set_ShouldCreateWrapper(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1BD0 Offset: 0x13F01D0 VA: 0x1813F1BD0
	internal bool get_CanDeserialize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1CF0 Offset: 0x13F02F0 VA: 0x1813F1CF0
	private void set_CanDeserialize(bool value) { }

	// RVA: 0x13F1C30 Offset: 0x13F0230 VA: 0x1813F1C30
	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	// RVA: 0xC83460 Offset: 0xC81A60 VA: 0x180C83460
	public ObjectConstructor<object> get_OverrideCreator() { }

	// RVA: 0x13F1D20 Offset: 0x13F0320 VA: 0x1813F1D20
	public void set_OverrideCreator(ObjectConstructor<object> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1C10 Offset: 0x13F0210 VA: 0x1813F1C10
	public bool get_HasParameterizedCreator() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1D00 Offset: 0x13F0300 VA: 0x1813F1D00
	public void set_HasParameterizedCreator(bool value) { }

	// RVA: 0x13F1BE0 Offset: 0x13F01E0 VA: 0x1813F1BE0
	internal bool get_HasParameterizedCreatorInternal() { }

	// RVA: 0x13F1080 Offset: 0x13EF680 VA: 0x1813F1080
	public void .ctor(Type underlyingType) { }

	// RVA: 0x13F0C10 Offset: 0x13EF210 VA: 0x1813F0C10
	internal IWrappedCollection CreateWrapper(object list) { }

	// RVA: 0x13F09F0 Offset: 0x13EEFF0 VA: 0x1813F09F0
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

	// RVA: 0x13F2BF0 Offset: 0x13F11F0 VA: 0x1813F2BF0
	public void set_CreatedType(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F29B0 Offset: 0x13F0FB0 VA: 0x1813F29B0
	public Nullable<bool> get_IsReference() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F2C60 Offset: 0x13F1260 VA: 0x1813F2C60
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

	// RVA: 0x13F29C0 Offset: 0x13F0FC0 VA: 0x1813F29C0
	public IList<SerializationCallback> get_OnDeserializedCallbacks() { }

	// RVA: 0x13F2A30 Offset: 0x13F1030 VA: 0x1813F2A30
	public IList<SerializationCallback> get_OnDeserializingCallbacks() { }

	// RVA: 0x13F2B10 Offset: 0x13F1110 VA: 0x1813F2B10
	public IList<SerializationCallback> get_OnSerializedCallbacks() { }

	// RVA: 0x13F2B80 Offset: 0x13F1180 VA: 0x1813F2B80
	public IList<SerializationCallback> get_OnSerializingCallbacks() { }

	// RVA: 0x13F2AA0 Offset: 0x13F10A0 VA: 0x1813F2AA0
	public IList<SerializationErrorCallback> get_OnErrorCallbacks() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	public Func<object> get_DefaultCreator() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574470 Offset: 0x572A70 VA: 0x180574470
	public void set_DefaultCreator(Func<object> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D710 Offset: 0x69BD10 VA: 0x18069D710
	public bool get_DefaultCreatorNonPublic() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D720 Offset: 0x69BD20 VA: 0x18069D720
	public void set_DefaultCreatorNonPublic(bool value) { }

	// RVA: 0x13F2840 Offset: 0x13F0E40 VA: 0x1813F2840
	internal void .ctor(Type underlyingType) { }

	// RVA: 0x13F2690 Offset: 0x13F0C90 VA: 0x1813F2690
	internal void InvokeOnSerializing(object o, StreamingContext context) { }

	// RVA: 0x13F24E0 Offset: 0x13F0AE0 VA: 0x1813F24E0
	internal void InvokeOnSerialized(object o, StreamingContext context) { }

	// RVA: 0x13F2170 Offset: 0x13F0770 VA: 0x1813F2170
	internal void InvokeOnDeserializing(object o, StreamingContext context) { }

	// RVA: 0x13F2040 Offset: 0x13F0640 VA: 0x1813F2040
	internal void InvokeOnDeserialized(object o, StreamingContext context) { }

	// RVA: 0x13F2320 Offset: 0x13F0920 VA: 0x1813F2320
	internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext) { }

	// RVA: 0x13F1F20 Offset: 0x13F0520 VA: 0x1813F1F20
	internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo) { }

	// RVA: 0x13F1FB0 Offset: 0x13F05B0 VA: 0x1813F1FB0
	internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo) { }

}

private sealed class JsonContract.<>c__DisplayClass73_0 // TypeDefIndex: 6012
{	// Fields
	public MethodInfo callbackMethodInfo; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1409220 Offset: 0x1407820 VA: 0x181409220
	internal void <CreateSerializationCallback>b__0(object o, StreamingContext context) { }

}

private sealed class JsonContract.<>c__DisplayClass74_0 // TypeDefIndex: 6013
{	// Fields
	public MethodInfo callbackMethodInfo; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1409310 Offset: 0x1407910 VA: 0x181409310
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

	// RVA: 0x13F5220 Offset: 0x13F3820 VA: 0x1813F5220
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
	// RVA: 0x8D9040 Offset: 0x8D7640 VA: 0x1808D9040
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

	// RVA: 0x13F52C0 Offset: 0x13F38C0 VA: 0x1813F52C0
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
	// RVA: 0x69D710 Offset: 0x69BD10 VA: 0x18069D710
	public bool get_Ignored() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D720 Offset: 0x69BD20 VA: 0x18069D720
	public void set_Ignored(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEC1490 Offset: 0xEBFA90 VA: 0x180EC1490
	public bool get_Readable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEC1B30 Offset: 0xEC0130 VA: 0x180EC1B30
	public void set_Readable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F5180 Offset: 0x13F3780 VA: 0x1813F5180
	public bool get_Writable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F5310 Offset: 0x13F3910 VA: 0x1813F5310
	public void set_Writable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F50F0 Offset: 0x13F36F0 VA: 0x1813F50F0
	public bool get_HasMemberAttribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F51B0 Offset: 0x13F37B0 VA: 0x1813F51B0
	public void set_HasMemberAttribute(bool value) { }

	// RVA: 0x13F50E0 Offset: 0x13F36E0 VA: 0x1813F50E0
	public object get_DefaultValue() { }

	// RVA: 0x13F51A0 Offset: 0x13F37A0 VA: 0x1813F51A0
	public void set_DefaultValue(object value) { }

	// RVA: 0x13F4FF0 Offset: 0x13F35F0 VA: 0x1813F4FF0
	internal object GetResolvedDefaultValue() { }

	// RVA: 0x13F5140 Offset: 0x13F3740 VA: 0x1813F5140
	public Required get_Required() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F5100 Offset: 0x13F3700 VA: 0x1813F5100
	public Nullable<bool> get_IsReference() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F51C0 Offset: 0x13F37C0 VA: 0x1813F51C0
	public void set_IsReference(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050
	public Nullable<NullValueHandling> get_NullValueHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F5200 Offset: 0x13F3800 VA: 0x1813F5200
	public void set_NullValueHandling(Nullable<NullValueHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public Nullable<DefaultValueHandling> get_DefaultValueHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F5190 Offset: 0x13F3790 VA: 0x1813F5190
	public void set_DefaultValueHandling(Nullable<DefaultValueHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public Nullable<ReferenceLoopHandling> get_ReferenceLoopHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F52F0 Offset: 0x13F38F0 VA: 0x1813F52F0
	public void set_ReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x952CA0 Offset: 0x9512A0 VA: 0x180952CA0
	public Nullable<ObjectCreationHandling> get_ObjectCreationHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F5210 Offset: 0x13F3810 VA: 0x1813F5210
	public void set_ObjectCreationHandling(Nullable<ObjectCreationHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9922B0 Offset: 0x9908B0 VA: 0x1809922B0
	public Nullable<TypeNameHandling> get_TypeNameHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F5300 Offset: 0x13F3900 VA: 0x1813F5300
	public void set_TypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7AD080 Offset: 0x7AB680 VA: 0x1807AD080
	public Predicate<object> get_ShouldSerialize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D4F0 Offset: 0xA4BAF0 VA: 0x180A4D4F0
	public void set_ShouldSerialize(Predicate<object> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x104F470 Offset: 0x104DA70 VA: 0x18104F470
	public Predicate<object> get_ShouldDeserialize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA03A0 Offset: 0xD9E9A0 VA: 0x180DA03A0
	public Predicate<object> get_GetIsSpecified() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA0780 Offset: 0xD9ED80 VA: 0x180DA0780
	public void set_GetIsSpecified(Predicate<object> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC73D40 Offset: 0xC72340 VA: 0x180C73D40
	public Action<object, object> get_SetIsSpecified() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC73E90 Offset: 0xC72490 VA: 0x180C73E90
	public void set_SetIsSpecified(Action<object, object> value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 3
	public override string ToString() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD9F730 Offset: 0xD9DD30 VA: 0x180D9F730
	public JsonConverter get_ItemConverter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD35330 Offset: 0xD33930 VA: 0x180D35330
	public void set_ItemConverter(JsonConverter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F5110 Offset: 0x13F3710 VA: 0x1813F5110
	public Nullable<bool> get_ItemIsReference() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F51D0 Offset: 0x13F37D0 VA: 0x1813F51D0
	public void set_ItemIsReference(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F5130 Offset: 0x13F3730 VA: 0x1813F5130
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F51F0 Offset: 0x13F37F0 VA: 0x1813F51F0
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F5120 Offset: 0x13F3720 VA: 0x1813F5120
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F51E0 Offset: 0x13F37E0 VA: 0x1813F51E0
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	// RVA: 0x13F5090 Offset: 0x13F3690 VA: 0x1813F5090
	internal void WritePropertyName(JsonWriter writer) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class JsonPropertyCollection : KeyedCollection<string, JsonProperty> // TypeDefIndex: 6016
{	// Fields
	private readonly Type _type; // 0x38
	private readonly List<JsonProperty> _list; // 0x40

	// Methods

	// RVA: 0x13F4EB0 Offset: 0x13F34B0 VA: 0x1813F4EB0
	public void .ctor(Type type) { }

	// RVA: 0x13F4C10 Offset: 0x13F3210 VA: 0x1813F4C10 Slot: 38
	protected override string GetKeyForItem(JsonProperty item) { }

	// RVA: 0x13F49B0 Offset: 0x13F2FB0 VA: 0x1813F49B0
	public void AddProperty(JsonProperty property) { }

	// RVA: 0x13F4BD0 Offset: 0x13F31D0 VA: 0x1813F4BD0
	public JsonProperty GetClosestMatchProperty(string propertyName) { }

	// RVA: 0x13F4DD0 Offset: 0x13F33D0 VA: 0x1813F4DD0
	private bool TryGetValue(string key, out JsonProperty item) { }

	// RVA: 0x13F4C30 Offset: 0x13F3230 VA: 0x1813F4C30
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
	// RVA: 0x107A100 Offset: 0x1078700 VA: 0x18107A100
	public MemberSerialization get_MemberSerialization() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A270 Offset: 0x1078870 VA: 0x18107A270
	public void set_MemberSerialization(MemberSerialization value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F4440 Offset: 0x13F2A40 VA: 0x1813F4440
	public Nullable<Required> get_ItemRequired() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F4510 Offset: 0x13F2B10 VA: 0x1813F4510
	public void set_ItemRequired(Nullable<Required> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC73D40 Offset: 0xC72340 VA: 0x180C73D40
	public JsonPropertyCollection get_Properties() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC73E90 Offset: 0xC72490 VA: 0x180C73E90
	private void set_Properties(JsonPropertyCollection value) { }

	// RVA: 0x13F4150 Offset: 0x13F2750 VA: 0x1813F4150
	public JsonPropertyCollection get_CreatorParameters() { }

	// RVA: 0x13F4520 Offset: 0x13F2B20 VA: 0x1813F4520
	public void set_OverrideConstructor(ConstructorInfo value) { }

	// RVA: 0x13F45D0 Offset: 0x13F2BD0 VA: 0x1813F45D0
	public void set_ParametrizedConstructor(ConstructorInfo value) { }

	// RVA: 0xA2ABE0 Offset: 0xA291E0 VA: 0x180A2ABE0
	public ObjectConstructor<object> get_OverrideCreator() { }

	// RVA: 0xC83460 Offset: 0xC81A60 VA: 0x180C83460
	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD9F730 Offset: 0xD9DD30 VA: 0x180D9F730
	public ExtensionDataSetter get_ExtensionDataSetter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD35330 Offset: 0xD33930 VA: 0x180D35330
	public void set_ExtensionDataSetter(ExtensionDataSetter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4EF3A0 Offset: 0x4ED9A0 VA: 0x1804EF3A0
	public ExtensionDataGetter get_ExtensionDataGetter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4EF3B0 Offset: 0x4ED9B0 VA: 0x1804EF3B0
	public void set_ExtensionDataGetter(ExtensionDataGetter value) { }

	// RVA: 0x13F4450 Offset: 0x13F2A50 VA: 0x1813F4450
	public void set_ExtensionDataValueType(Type value) { }

	// RVA: 0x13F41D0 Offset: 0x13F27D0 VA: 0x1813F41D0
	internal bool get_HasRequiredOrDefaultValueProperties() { }

	// RVA: 0x13F40C0 Offset: 0x13F26C0 VA: 0x1813F40C0
	public void .ctor(Type underlyingType) { }

	// RVA: 0x13F3FC0 Offset: 0x13F25C0 VA: 0x1813F3FC0
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

	// RVA: 0x13F5870 Offset: 0x13F3E70 VA: 0x1813F5870
	protected void .ctor(JsonSerializer serializer) { }

	// RVA: 0x13F5900 Offset: 0x13F3F00 VA: 0x1813F5900
	internal BidirectionalDictionary<string, object> get_DefaultReferenceMappings() { }

	// RVA: 0x13F53A0 Offset: 0x13F39A0 VA: 0x1813F53A0
	private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error) { }

	// RVA: 0x13F5320 Offset: 0x13F3920 VA: 0x1813F5320
	protected void ClearErrorContext() { }

	// RVA: 0x13F54C0 Offset: 0x13F3AC0 VA: 0x1813F54C0
	protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex) { }

}

private class JsonSerializerInternalBase.ReferenceEqualsEqualityComparer : IEqualityComparer<object> // TypeDefIndex: 6020
{	// Methods

	// RVA: 0x13CFBD0 Offset: 0x13CE1D0 VA: 0x1813CFBD0 Slot: 4
	private bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y) { }

	// RVA: 0x1408560 Offset: 0x1406B60 VA: 0x181408560 Slot: 5
	private int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal class JsonSerializerInternalReader : JsonSerializerInternalBase // TypeDefIndex: 6021
{	// Methods

	// RVA: 0x13F5870 Offset: 0x13F3E70 VA: 0x1813F5870
	public void .ctor(JsonSerializer serializer) { }

	// RVA: 0x13FEFA0 Offset: 0x13FD5A0 VA: 0x1813FEFA0
	public void Populate(JsonReader reader, object target) { }

	// RVA: 0x13FC070 Offset: 0x13FA670 VA: 0x1813FC070
	private JsonContract GetContractSafe(Type type) { }

	// RVA: 0x13FB2A0 Offset: 0x13F98A0 VA: 0x1813FB2A0
	public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent) { }

	// RVA: 0x13FC250 Offset: 0x13FA850 VA: 0x1813FC250
	private JsonSerializerProxy GetInternalSerializer() { }

	// RVA: 0x13F6CA0 Offset: 0x13F52A0 VA: 0x1813F6CA0
	private JToken CreateJToken(JsonReader reader, JsonContract contract) { }

	// RVA: 0x13F6A40 Offset: 0x13F5040 VA: 0x1813F6A40
	private JToken CreateJObject(JsonReader reader) { }

	// RVA: 0x13FAAF0 Offset: 0x13F90F0 VA: 0x1813FAAF0
	private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	// RVA: 0x13F6140 Offset: 0x13F4740 VA: 0x1813F6140
	private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s) { }

	// RVA: 0x13FC180 Offset: 0x13FA780 VA: 0x1813FC180
	internal string GetExpectedDescription(JsonContract contract) { }

	// RVA: 0x13FC0E0 Offset: 0x13FA6E0 VA: 0x1813FC0E0
	private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x13F9270 Offset: 0x13F7870 VA: 0x1813F9270
	private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	// RVA: 0x13FF800 Offset: 0x13FDE00 VA: 0x1813FF800
	private bool ReadMetadataPropertiesToken(JTokenReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	// RVA: 0x13FFE60 Offset: 0x13FE460 VA: 0x1813FFE60
	private bool ReadMetadataProperties(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	// RVA: 0x1400F30 Offset: 0x13FF530 VA: 0x181400F30
	private void ResolveTypeName(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName) { }

	// RVA: 0x13FBBC0 Offset: 0x13FA1C0 VA: 0x1813FBBC0
	private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract) { }

	// RVA: 0x13F6EC0 Offset: 0x13F54C0 VA: 0x1813F6EC0
	private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id) { }

	// RVA: 0x13FC360 Offset: 0x13FA960 VA: 0x1813FC360
	private bool HasNoDefinedType(JsonContract contract) { }

	// RVA: 0x13FBD60 Offset: 0x13FA360 VA: 0x1813FBD60
	private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType) { }

	// RVA: 0x14015E0 Offset: 0x13FFBE0 VA: 0x1814015E0
	private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target) { }

	// RVA: 0x13F5C00 Offset: 0x13F4200 VA: 0x1813F5C00
	private bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue) { }

	// RVA: 0x13F59D0 Offset: 0x13F3FD0 VA: 0x1813F59D0
	private void AddReference(JsonReader reader, string id, object value) { }

	// RVA: 0xF9C2A0 Offset: 0xF9A8A0 VA: 0x180F9C2A0
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	// RVA: 0x1401E50 Offset: 0x1400450 VA: 0x181401E50
	private bool ShouldSetPropertyValue(JsonProperty property, object value) { }

	// RVA: 0x13F79B0 Offset: 0x13F5FB0 VA: 0x1813F79B0
	private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x13F7720 Offset: 0x13F5D20 VA: 0x1813F7720
	private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x13FC580 Offset: 0x13FAB80 VA: 0x1813FC580
	private void OnDeserializing(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0x13FC3F0 Offset: 0x13FA9F0 VA: 0x1813FC3F0
	private void OnDeserialized(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0x13FC710 Offset: 0x13FAD10 VA: 0x1813FC710
	private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x13FD9A0 Offset: 0x13FBFA0 VA: 0x1813FD9A0
	private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x1401F80 Offset: 0x1400580 VA: 0x181401F80
	private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message) { }

	// RVA: 0x13FD280 Offset: 0x13FB880 VA: 0x1813FD280
	private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x13F63E0 Offset: 0x13F49E0 VA: 0x1813F63E0
	private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id) { }

	// RVA: 0x13F6230 Offset: 0x13F4830 VA: 0x1813F6230
	internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: 0x13F7F40 Offset: 0x13F6540 VA: 0x1813F7F40
	private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, ObjectConstructor<object> creator, string id) { }

	// RVA: 0x13FAFA0 Offset: 0x13F95A0 VA: 0x1813FAFA0
	private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue) { }

	// RVA: 0x1400480 Offset: 0x13FEA80 VA: 0x181400480
	private List<JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType) { }

	// RVA: 0x13FF5C0 Offset: 0x13FDBC0 VA: 0x1813FF5C0
	private bool ReadForType(JsonReader reader, JsonContract contract, bool hasConverter) { }

	// RVA: 0x13F7CE0 Offset: 0x13F62E0 VA: 0x1813F7CE0
	public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x13FE230 Offset: 0x13FC830 VA: 0x1813FE230
	private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id) { }

	// RVA: 0x1401CA0 Offset: 0x14002A0 VA: 0x181401CA0
	private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target) { }

	// RVA: 0x13F6050 Offset: 0x13F4650 VA: 0x1813F6050
	private bool CheckPropertyName(JsonReader reader, string memberName) { }

	// RVA: 0x1401370 Offset: 0x13FF970 VA: 0x181401370
	private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o) { }

	// RVA: 0x13FF500 Offset: 0x13FDB00 VA: 0x1813FF500
	private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader) { }

	// RVA: 0x13FB780 Offset: 0x13F9D80 VA: 0x1813FB780
	private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, JsonSerializerInternalReader.PropertyPresence presence, bool setDefaultValue) { }

	// RVA: 0x14014C0 Offset: 0x13FFAC0 VA: 0x1814014C0
	private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> requiredProperties) { }

	// RVA: 0x13FC2D0 Offset: 0x13FA8D0 VA: 0x1813FC2D0
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

	// RVA: 0x14090D0 Offset: 0x14076D0 VA: 0x1814090D0
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

	// RVA: 0x1409470 Offset: 0x1407A70 VA: 0x181409470
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13F4C10 Offset: 0x13F3210 VA: 0x1813F4C10
	internal string <CreateObjectUsingCreatorWithParameters>b__36_0(JsonProperty p) { }

	// RVA: 0x13F4C10 Offset: 0x13F3210 VA: 0x1813F4C10
	internal string <CreateObjectUsingCreatorWithParameters>b__36_2(JsonProperty p) { }

	// RVA: 0x7B4F90 Offset: 0x7B3590 VA: 0x1807B4F90
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

	// RVA: 0x1408480 Offset: 0x1406A80 VA: 0x181408480
	public void .ctor(JsonSerializer serializer) { }

	// RVA: 0x1406DC0 Offset: 0x14053C0 VA: 0x181406DC0
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0x1402C30 Offset: 0x1401230 VA: 0x181402C30
	private JsonSerializerProxy GetInternalSerializer() { }

	// RVA: 0x1402BB0 Offset: 0x14011B0 VA: 0x181402BB0
	private JsonContract GetContractSafe(object value) { }

	// RVA: 0x1405D70 Offset: 0x1404370 VA: 0x181405D70
	private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x14060B0 Offset: 0x14046B0 VA: 0x1814060B0
	private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x14036C0 Offset: 0x1401CC0 VA: 0x1814036C0
	private Nullable<bool> ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1407330 Offset: 0x1405930 VA: 0x181407330
	private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1407240 Offset: 0x1405840 VA: 0x181407240
	private bool ShouldWriteProperty(object memberValue, JsonProperty property) { }

	// RVA: 0x1402800 Offset: 0x1400E00 VA: 0x181402800
	private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x1407CF0 Offset: 0x14062F0 VA: 0x181407CF0
	private void WriteReference(JsonWriter writer, object value) { }

	// RVA: 0x1403020 Offset: 0x1401620 VA: 0x181403020
	private string GetReference(JsonWriter writer, object value) { }

	// RVA: 0x1407680 Offset: 0x1405C80 VA: 0x181407680
	internal static bool TryConvertToString(object value, Type type, out string s) { }

	// RVA: 0x1406000 Offset: 0x1404600 VA: 0x181406000
	private void SerializeString(JsonWriter writer, object value, JsonStringContract contract) { }

	// RVA: 0x1403550 Offset: 0x1401B50 VA: 0x181403550
	private void OnSerializing(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0x14033E0 Offset: 0x14019E0 VA: 0x1814033E0
	private void OnSerialized(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0x14054B0 Offset: 0x1403AB0 VA: 0x1814054B0
	private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1402090 Offset: 0x1400690 VA: 0x181402090
	private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, out JsonContract memberContract, out object memberValue) { }

	// RVA: 0x14078D0 Offset: 0x1405ED0 VA: 0x1814078D0
	private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1407B60 Offset: 0x1406160 VA: 0x181407B60
	private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value) { }

	// RVA: 0x14082C0 Offset: 0x14068C0 VA: 0x1814082C0
	private void WriteTypeProperty(JsonWriter writer, Type type) { }

	// RVA: 0xF9C2A0 Offset: 0xF9A8A0 VA: 0x180F9C2A0
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	// RVA: 0xF9C2A0 Offset: 0xF9A8A0 VA: 0x180F9C2A0
	private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag) { }

	// RVA: 0xF9C2A0 Offset: 0xF9A8A0 VA: 0x180F9C2A0
	private bool HasFlag(TypeNameHandling value, TypeNameHandling flag) { }

	// RVA: 0x1403770 Offset: 0x1401D70 VA: 0x181403770
	private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1404A50 Offset: 0x1403050 VA: 0x181404A50
	private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1405340 Offset: 0x1403940 VA: 0x181405340
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1404F40 Offset: 0x1403540 VA: 0x181404F40
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices) { }

	// RVA: 0x1407EC0 Offset: 0x14064C0 VA: 0x181407EC0
	private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x1404390 Offset: 0x1402990 VA: 0x181404390
	private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1407510 Offset: 0x1405B10 VA: 0x181407510
	private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x1403B10 Offset: 0x1402110 VA: 0x181403B10
	private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1402CB0 Offset: 0x14012B0 VA: 0x181402CB0
	private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape) { }

	// RVA: 0x14031B0 Offset: 0x14017B0 VA: 0x1814031B0
	private void HandleError(JsonWriter writer, int initialDepth) { }

	// RVA: 0x1407090 Offset: 0x1405690 VA: 0x181407090
	private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target) { }

	// RVA: 0x1403230 Offset: 0x1401830 VA: 0x181403230
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

	// RVA: 0x1808A90 Offset: 0x1807090 VA: 0x181808A90 Slot: 4
	public override void add_Error(EventHandler<ErrorEventArgs> value) { }

	// RVA: 0x1808C50 Offset: 0x1807250 VA: 0x181808C50 Slot: 5
	public override void remove_Error(EventHandler<ErrorEventArgs> value) { }

	// RVA: 0x1808F30 Offset: 0x1807530 VA: 0x181808F30 Slot: 6
	public override void set_ReferenceResolver(IReferenceResolver value) { }

	// RVA: 0x1808C20 Offset: 0x1807220 VA: 0x181808C20 Slot: 8
	public override ITraceWriter get_TraceWriter() { }

	// RVA: 0x1808F60 Offset: 0x1807560 VA: 0x181808F60 Slot: 9
	public override void set_TraceWriter(ITraceWriter value) { }

	// RVA: 0x1808DB0 Offset: 0x18073B0 VA: 0x181808DB0 Slot: 10
	public override void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0x1808B60 Offset: 0x1807160 VA: 0x181808B60 Slot: 23
	public override JsonConverterCollection get_Converters() { }

	// RVA: 0x1808D80 Offset: 0x1807380 VA: 0x181808D80 Slot: 17
	public override void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0x1808B30 Offset: 0x1807130 VA: 0x181808B30 Slot: 24
	public override IContractResolver get_ContractResolver() { }

	// RVA: 0x1808D50 Offset: 0x1807350 VA: 0x181808D50 Slot: 25
	public override void set_ContractResolver(IContractResolver value) { }

	// RVA: 0x1808E40 Offset: 0x1807440 VA: 0x181808E40 Slot: 15
	public override void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0x1808E70 Offset: 0x1807470 VA: 0x181808E70 Slot: 16
	public override void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0x1808BF0 Offset: 0x18071F0 VA: 0x181808BF0 Slot: 18
	public override ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0x1808EA0 Offset: 0x18074A0 VA: 0x181808EA0 Slot: 19
	public override void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0x1808F00 Offset: 0x1807500 VA: 0x181808F00 Slot: 14
	public override void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0x1808ED0 Offset: 0x18074D0 VA: 0x181808ED0 Slot: 13
	public override void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0x1808FC0 Offset: 0x18075C0 VA: 0x181808FC0 Slot: 11
	public override void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0x1808BC0 Offset: 0x18071C0 VA: 0x181808BC0 Slot: 21
	public override MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0x1808E10 Offset: 0x1807410 VA: 0x181808E10 Slot: 22
	public override void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0x1808F90 Offset: 0x1807590 VA: 0x181808F90 Slot: 12
	public override void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	// RVA: 0x1808CE0 Offset: 0x18072E0 VA: 0x181808CE0 Slot: 20
	public override void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0x1808C80 Offset: 0x1807280 VA: 0x181808C80 Slot: 7
	public override void set_Binder(SerializationBinder value) { }

	// RVA: 0x1808AF0 Offset: 0x18070F0 VA: 0x181808AF0 Slot: 26
	public override StreamingContext get_Context() { }

	// RVA: 0x1808D10 Offset: 0x1807310 VA: 0x181808D10 Slot: 27
	public override void set_Context(StreamingContext value) { }

	// RVA: 0x1808B90 Offset: 0x1807190 VA: 0x181808B90 Slot: 28
	public override Formatting get_Formatting() { }

	// RVA: 0x1808DE0 Offset: 0x18073E0 VA: 0x181808DE0 Slot: 29
	public override void set_Formatting(Formatting value) { }

	// RVA: 0x1808AC0 Offset: 0x18070C0 VA: 0x181808AC0 Slot: 30
	public override bool get_CheckAdditionalContent() { }

	// RVA: 0x1808CB0 Offset: 0x18072B0 VA: 0x181808CB0 Slot: 31
	public override void set_CheckAdditionalContent(bool value) { }

	// RVA: 0x1808840 Offset: 0x1806E40 VA: 0x181808840
	internal JsonSerializerInternalBase GetInternalSerializer() { }

	// RVA: 0x18088F0 Offset: 0x1806EF0 VA: 0x1818088F0
	public void .ctor(JsonSerializerInternalReader serializerReader) { }

	// RVA: 0x18089C0 Offset: 0x1806FC0 VA: 0x1818089C0
	public void .ctor(JsonSerializerInternalWriter serializerWriter) { }

	// RVA: 0x18087F0 Offset: 0x1806DF0 VA: 0x1818087F0 Slot: 33
	internal override object DeserializeInternal(JsonReader reader, Type objectType) { }

	// RVA: 0x1808860 Offset: 0x1806E60 VA: 0x181808860 Slot: 32
	internal override void PopulateInternal(JsonReader reader, object target) { }

	// RVA: 0x18088A0 Offset: 0x1806EA0 VA: 0x1818088A0 Slot: 34
	internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType) { }

}

public class JsonStringContract : JsonPrimitiveContract // TypeDefIndex: 6028
{	// Methods

	// RVA: 0x1808FF0 Offset: 0x18075F0 VA: 0x181808FF0
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

	// RVA: 0x18094D0 Offset: 0x1807AD0 VA: 0x1818094D0
	public static DataContractAttribute GetDataContractAttribute(Type type) { }

	// RVA: 0x1809560 Offset: 0x1807B60 VA: 0x181809560
	public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo) { }

	// RVA: 0x1809CF0 Offset: 0x18082F0 VA: 0x181809CF0
	public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute) { }

	// RVA: 0x1809C20 Offset: 0x1808220 VA: 0x181809C20
	public static JsonConverter GetJsonConverter(object attributeProvider) { }

	// RVA: 0x18090F0 Offset: 0x18076F0 VA: 0x1818090F0
	public static JsonConverter CreateJsonConverterInstance(Type converterType, object[] converterArgs) { }

	// RVA: 0x1809AD0 Offset: 0x18080D0 VA: 0x181809AD0
	private static Func<object[], JsonConverter> GetJsonConverterCreator(Type converterType) { }

	// RVA: 0x1809E90 Offset: 0x1808490 VA: 0x181809E90
	public static TypeConverter GetTypeConverter(Type type) { }

	// RVA: 0x1809450 Offset: 0x1807A50 VA: 0x181809450
	private static Type GetAssociatedMetadataType(Type type) { }

	// RVA: 0x1809190 Offset: 0x1807790 VA: 0x181809190
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

	// RVA: 0x1809FF0 Offset: 0x18085F0 VA: 0x181809FF0
	public static bool get_FullyTrusted() { }

	// RVA: 0x180A170 Offset: 0x1808770 VA: 0x18180A170
	public static ReflectionDelegateFactory get_ReflectionDelegateFactory() { }

	// RVA: 0x1809EF0 Offset: 0x18084F0 VA: 0x181809EF0
	private static void .cctor() { }

}

private sealed class JsonTypeReflector.<>c__DisplayClass18_0 // TypeDefIndex: 6030
{	// Fields
	public Type converterType; // 0x10
	public Func<object> defaultConstructor; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x18150A0 Offset: 0x18136A0 VA: 0x1818150A0
	internal JsonConverter <GetJsonConverterCreator>b__0(object[] parameters) { }

}

private sealed class JsonTypeReflector.<>c // TypeDefIndex: 6031
{	// Fields
	public static readonly JsonTypeReflector.<>c <>9; // 0x0
	public static Func<object, Type> <>9__18_1; // 0x8

	// Methods

	// RVA: 0x18158B0 Offset: 0x1813EB0 VA: 0x1818158B0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x98C180 Offset: 0x98A780 VA: 0x18098C180
	internal Type <GetJsonConverterCreator>b__18_1(object param) { }

}

public class JPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 6038
{	// Properties
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	protected override int NameHashCode { get; }

	// Methods

	// RVA: 0xE361E0 Offset: 0xE347E0 VA: 0x180E361E0
	public void .ctor(string name) { }

	// RVA: 0xE35DB0 Offset: 0xE343B0 VA: 0x180E35DB0
	private static JObject CastInstance(object instance) { }

	// RVA: 0xE35E30 Offset: 0xE34430 VA: 0x180E35E30 Slot: 17
	public override object GetValue(object component) { }

	// RVA: 0xE35F50 Offset: 0xE34550 VA: 0x180E35F50 Slot: 19
	public override void SetValue(object component, object value) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 20
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0xE361F0 Offset: 0xE347F0 VA: 0x180E361F0 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0xE36250 Offset: 0xE34850 VA: 0x180E36250 Slot: 16
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

	// RVA: 0xE36EA0 Offset: 0xE354A0 VA: 0x180E36EA0
	public void .ctor() { }

	// RVA: 0xE362B0 Offset: 0xE348B0 VA: 0x180E362B0
	private void AddKey(string key, JToken item) { }

	// RVA: 0xE36320 Offset: 0xE34920 VA: 0x180E36320 Slot: 34
	protected override void ClearItems() { }

	// RVA: 0xE36700 Offset: 0xE34D00 VA: 0x180E36700
	public bool Contains(string key) { }

	// RVA: 0xE36790 Offset: 0xE34D90 VA: 0x180E36790
	private void EnsureDictionary() { }

	// RVA: 0xE36840 Offset: 0xE34E40 VA: 0x180E36840
	private string GetKeyForItem(JToken item) { }

	// RVA: 0xE369A0 Offset: 0xE34FA0 VA: 0x180E369A0 Slot: 35
	protected override void InsertItem(int index, JToken item) { }

	// RVA: 0xE36A60 Offset: 0xE35060 VA: 0x180E36A60 Slot: 36
	protected override void RemoveItem(int index) { }

	// RVA: 0xE36B20 Offset: 0xE35120 VA: 0x180E36B20
	private void RemoveKey(string key) { }

	// RVA: 0xE36B70 Offset: 0xE35170 VA: 0x180E36B70 Slot: 37
	protected override void SetItem(int index, JToken item) { }

	// RVA: 0xE36D70 Offset: 0xE35370 VA: 0x180E36D70
	public bool TryGetValue(string key, out JToken value) { }

	// RVA: 0xE36F10 Offset: 0xE35510 VA: 0x180E36F10
	public ICollection<string> get_Keys() { }

	// RVA: 0xE36900 Offset: 0xE34F00 VA: 0x180E36900
	public int IndexOfReference(JToken t) { }

	// RVA: 0xE36380 Offset: 0xE34980 VA: 0x180E36380
	public bool Compare(JPropertyKeyedCollection other) { }

	// RVA: 0xE36DF0 Offset: 0xE353F0 VA: 0x180E36DF0
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

	// RVA: 0xE385C0 Offset: 0xE36BC0 VA: 0x180E385C0 Slot: 4
	public bool Equals(JToken x, JToken y) { }

	// RVA: 0xE38660 Offset: 0xE36C60 VA: 0x180E38660 Slot: 5
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

	// RVA: 0xE30ED0 Offset: 0xE2F4D0 VA: 0x180E30ED0 Slot: 47
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public string get_Name() { }

	// RVA: 0xAC2060 Offset: 0xAC0660 VA: 0x180AC2060 Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0xE31300 Offset: 0xE2F900 VA: 0x180E31300
	public void .ctor() { }

	// RVA: 0xE314F0 Offset: 0xE2FAF0 VA: 0x180E314F0
	public void .ctor(JConstructor other) { }

	// RVA: 0xE313B0 Offset: 0xE2F9B0 VA: 0x180E313B0
	public void .ctor(string name) { }

	// RVA: 0xE30CC0 Offset: 0xE2F2C0 VA: 0x180E30CC0 Slot: 11
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0xE30C00 Offset: 0xE2F200 VA: 0x180E30C00 Slot: 10
	internal override JToken CloneToken() { }

	// RVA: 0xE31110 Offset: 0xE2F710 VA: 0x180E31110 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE30E80 Offset: 0xE2F480 VA: 0x180E30E80 Slot: 18
	internal override int GetDeepHashCode() { }

	// RVA: 0xE30F20 Offset: 0xE2F520 VA: 0x180E30F20
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

	// RVA: 0xE33EF0 Offset: 0xE324F0 VA: 0x180E33EF0
	internal void .ctor() { }

	// RVA: 0xE33F50 Offset: 0xE32550 VA: 0x180E33F50
	internal void .ctor(JContainer other) { }

	// RVA: 0xE319A0 Offset: 0xE2FFA0 VA: 0x180E319A0
	internal void CheckReentrancy() { }

	// RVA: 0xE328E0 Offset: 0xE30EE0 VA: 0x180E328E0 Slot: 46
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xE34220 Offset: 0xE32820 VA: 0x180E34220 Slot: 13
	public override bool get_HasValues() { }

	// RVA: 0xE31D00 Offset: 0xE30300 VA: 0x180E31D00
	internal bool ContentsEqual(JContainer container) { }

	// RVA: 0xE341A0 Offset: 0xE327A0 VA: 0x180E341A0 Slot: 14
	public override JToken get_First() { }

	// RVA: 0xE34280 Offset: 0xE32880 VA: 0x180E34280 Slot: 15
	public override JToken get_Last() { }

	// RVA: 0xE31A50 Offset: 0xE30050 VA: 0x180E31A50 Slot: 16
	public override JEnumerable<JToken> Children() { }

	// RVA: 0xE32750 Offset: 0xE30D50 VA: 0x180E32750
	internal bool IsMultiContent(object content) { }

	// RVA: 0xE32330 Offset: 0xE30930 VA: 0x180E32330
	internal JToken EnsureParentToken(JToken item, bool skipParentCheck) { }

	// RVA: -1 Offset: -1 Slot: 47
	internal abstract int IndexOfItem(JToken item);

	// RVA: 0xE324E0 Offset: 0xE30AE0 VA: 0x180E324E0 Slot: 48
	internal virtual void InsertItem(int index, JToken item, bool skipParentCheck) { }

	// RVA: 0xE33210 Offset: 0xE31810 VA: 0x180E33210 Slot: 49
	internal virtual void RemoveItemAt(int index) { }

	// RVA: 0xE334B0 Offset: 0xE31AB0 VA: 0x180E334B0 Slot: 50
	internal virtual bool RemoveItem(JToken item) { }

	// RVA: 0xE32470 Offset: 0xE30A70 VA: 0x180E32470 Slot: 51
	internal virtual JToken GetItem(int index) { }

	// RVA: 0xE33550 Offset: 0xE31B50 VA: 0x180E33550 Slot: 52
	internal virtual void SetItem(int index, JToken item) { }

	// RVA: 0xE31AB0 Offset: 0xE300B0 VA: 0x180E31AB0 Slot: 53
	internal virtual void ClearItems() { }

	// RVA: 0xE33500 Offset: 0xE31B00 VA: 0x180E33500 Slot: 54
	internal virtual void ReplaceItem(JToken existing, JToken replacement) { }

	// RVA: 0xE31CE0 Offset: 0xE302E0 VA: 0x180E31CE0 Slot: 55
	internal virtual bool ContainsItem(JToken item) { }

	// RVA: 0xE32010 Offset: 0xE30610 VA: 0x180E32010 Slot: 56
	internal virtual void CopyItemsTo(Array array, int arrayIndex) { }

	// RVA: 0xE32800 Offset: 0xE30E00 VA: 0x180E32800
	internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue) { }

	// RVA: 0xE33DE0 Offset: 0xE323E0 VA: 0x180E33DE0 Slot: 57
	internal virtual void ValidateToken(JToken o, JToken existing) { }

	// RVA: 0xE31920 Offset: 0xE2FF20 VA: 0x180E31920 Slot: 58
	public virtual void Add(object content) { }

	// RVA: 0xE31590 Offset: 0xE2FB90 VA: 0x180E31590
	internal void AddAndSkipParentCheck(JToken token) { }

	// RVA: 0xE31610 Offset: 0xE2FC10 VA: 0x180E31610
	internal void AddInternal(int index, object content, bool skipParentCheck) { }

	// RVA: 0xE32280 Offset: 0xE30880 VA: 0x180E32280
	internal static JToken CreateFromContent(object content) { }

	// RVA: 0xE30310 Offset: 0xE2E910 VA: 0x180E30310
	public void RemoveAll() { }

	// RVA: 0xE33060 Offset: 0xE31660 VA: 0x180E33060
	internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options) { }

	// RVA: 0xE32980 Offset: 0xE30F80 VA: 0x180E32980
	internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings) { }

	// RVA: 0xE31E40 Offset: 0xE30440 VA: 0x180E31E40
	internal int ContentsHashCode() { }

	// RVA: 0xE30680 Offset: 0xE2EC80 VA: 0x180E30680 Slot: 21
	private int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(JToken item) { }

	// RVA: 0xE306A0 Offset: 0xE2ECA0 VA: 0x180E306A0 Slot: 22
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, JToken item) { }

	// RVA: 0xE30880 Offset: 0xE2EE80 VA: 0x180E30880 Slot: 23
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index) { }

	// RVA: 0xE30BC0 Offset: 0xE2F1C0 VA: 0x180E30BC0 Slot: 19
	private JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(int index) { }

	// RVA: 0xE30BE0 Offset: 0xE2F1E0 VA: 0x180E30BE0 Slot: 20
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(int index, JToken value) { }

	// RVA: 0xE302F0 Offset: 0xE2E8F0 VA: 0x180E302F0 Slot: 26
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(JToken item) { }

	// RVA: 0xE30310 Offset: 0xE2E910 VA: 0x180E30310 Slot: 27
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear() { }

	// RVA: 0xE303E0 Offset: 0xE2E9E0 VA: 0x180E303E0 Slot: 28
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(JToken item) { }

	// RVA: 0xE30400 Offset: 0xE2EA00 VA: 0x180E30400 Slot: 29
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 25
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly() { }

	// RVA: 0xE308A0 Offset: 0xE2EEA0 VA: 0x180E308A0 Slot: 30
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(JToken item) { }

	// RVA: 0xE323D0 Offset: 0xE309D0 VA: 0x180E323D0
	private JToken EnsureValue(object value) { }

	// RVA: 0xE338E0 Offset: 0xE31EE0 VA: 0x180E338E0 Slot: 33
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0xE30310 Offset: 0xE2E910 VA: 0x180E30310 Slot: 35
	private void System.Collections.IList.Clear() { }

	// RVA: 0xE339F0 Offset: 0xE31FF0 VA: 0x180E339F0 Slot: 34
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0xE33AB0 Offset: 0xE320B0 VA: 0x180E33AB0 Slot: 38
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0xE33B70 Offset: 0xE32170 VA: 0x180E33B70 Slot: 39
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 37
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 36
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xE33C50 Offset: 0xE32250 VA: 0x180E33C50 Slot: 40
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0xE30880 Offset: 0xE2EE80 VA: 0x180E30880 Slot: 41
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0xE30BC0 Offset: 0xE2F1C0 VA: 0x180E30BC0 Slot: 31
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0xE33D10 Offset: 0xE32310 VA: 0x180E33D10 Slot: 32
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0xE30400 Offset: 0xE2EA00 VA: 0x180E30400 Slot: 42
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0xE34140 Offset: 0xE32740 VA: 0x180E34140 Slot: 43
	public int get_Count() { }

	// RVA: 0xE33870 Offset: 0xE31E70 VA: 0x180E33870 Slot: 44
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

	// RVA: 0xE35B10 Offset: 0xE34110 VA: 0x180E35B10
	public void .ctor() { }

	// RVA: 0xE35A50 Offset: 0xE34050 VA: 0x180E35A50
	public void .ctor(JObject other) { }

	// RVA: 0xE34480 Offset: 0xE32A80 VA: 0x180E34480 Slot: 11
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0xE34590 Offset: 0xE32B90 VA: 0x180E34590 Slot: 47
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xE34630 Offset: 0xE32C30 VA: 0x180E34630 Slot: 48
	internal override void InsertItem(int index, JToken item, bool skipParentCheck) { }

	// RVA: 0xE35690 Offset: 0xE33C90 VA: 0x180E35690 Slot: 57
	internal override void ValidateToken(JToken o, JToken existing) { }

	// RVA: 0xE346A0 Offset: 0xE32CA0 VA: 0x180E346A0
	internal void InternalPropertyChanged(JProperty childProperty) { }

	// RVA: 0xE34760 Offset: 0xE32D60 VA: 0x180E34760
	internal void InternalPropertyChanging(JProperty childProperty) { }

	// RVA: 0xE34390 Offset: 0xE32990 VA: 0x180E34390 Slot: 10
	internal override JToken CloneToken() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0xE34A80 Offset: 0xE33080 VA: 0x180E34A80
	public JProperty Property(string name) { }

	// RVA: 0xE35C00 Offset: 0xE34200 VA: 0x180E35C00 Slot: 59
	public JToken get_Item(string propertyName) { }

	// RVA: 0xE35C80 Offset: 0xE34280 VA: 0x180E35C80 Slot: 60
	public void set_Item(string propertyName, JToken value) { }

	// RVA: 0xE34950 Offset: 0xE32F50 VA: 0x180E34950
	public static JObject Load(JsonReader reader) { }

	// RVA: 0xE34790 Offset: 0xE32D90 VA: 0x180E34790
	public static JObject Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xE35950 Offset: 0xE33F50 VA: 0x180E35950 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE34300 Offset: 0xE32900 VA: 0x180E34300 Slot: 64
	public void Add(string propertyName, JToken value) { }

	// RVA: 0xE35160 Offset: 0xE33760 VA: 0x180E35160 Slot: 63
	private bool System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.ContainsKey(string key) { }

	// RVA: 0xE35200 Offset: 0xE33800 VA: 0x180E35200 Slot: 61
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys() { }

	// RVA: 0xE34B90 Offset: 0xE33190 VA: 0x180E34B90 Slot: 65
	public bool Remove(string propertyName) { }

	// RVA: 0xE35630 Offset: 0xE33C30 VA: 0x180E35630 Slot: 66
	public bool TryGetValue(string propertyName, out JToken value) { }

	// RVA: 0xE35260 Offset: 0xE33860 VA: 0x180E35260 Slot: 62
	private ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values() { }

	// RVA: 0xE34C20 Offset: 0xE33220 VA: 0x180E34C20 Slot: 69
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(KeyValuePair<string, JToken> item) { }

	// RVA: 0xE30310 Offset: 0xE2E910 VA: 0x180E30310 Slot: 70
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear() { }

	// RVA: 0xE34CA0 Offset: 0xE332A0 VA: 0x180E34CA0 Slot: 71
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(KeyValuePair<string, JToken> item) { }

	// RVA: 0xE34D10 Offset: 0xE33310 VA: 0x180E34D10 Slot: 72
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 68
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly() { }

	// RVA: 0xE35010 Offset: 0xE33610 VA: 0x180E35010 Slot: 73
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(KeyValuePair<string, JToken> item) { }

	// RVA: 0xE305C0 Offset: 0xE2EBC0 VA: 0x180E305C0 Slot: 18
	internal override int GetDeepHashCode() { }

	// RVA: 0xE34520 Offset: 0xE32B20 VA: 0x180E34520 Slot: 74
	public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator() { }

	// RVA: 0xE34960 Offset: 0xE32F60 VA: 0x180E34960 Slot: 80
	protected virtual void OnPropertyChanged(string propertyName) { }

	// RVA: 0xE349F0 Offset: 0xE32FF0 VA: 0x180E349F0 Slot: 81
	protected virtual void OnPropertyChanging(string propertyName) { }

	// RVA: 0xE35580 Offset: 0xE33B80 VA: 0x180E35580 Slot: 77
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xE35360 Offset: 0xE33960 VA: 0x180E35360 Slot: 78
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0xE352B0 Offset: 0xE338B0 VA: 0x180E352B0 Slot: 75
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0xE35310 Offset: 0xE33910 VA: 0x180E35310 Slot: 76
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 79
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

private sealed class JObject.<>c // TypeDefIndex: 6061
{	// Fields
	public static readonly JObject.<>c <>9; // 0x35C6

	// Methods

	// RVA: 0xE4D000 Offset: 0xE4B600 VA: 0x180E4D000
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
	// RVA: 0xE4CEA0 Offset: 0xE4B4A0 VA: 0x180E4CEA0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE4CBF0 Offset: 0xE4B1F0 VA: 0x180E4CBF0 Slot: 6
	private bool MoveNext() { }

	// RVA: 0xE4CF50 Offset: 0xE4B550 VA: 0x180E4CF50
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB114F0 Offset: 0xB0FAF0 VA: 0x180B114F0 Slot: 4
	private KeyValuePair<string, JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE4CE00 Offset: 0xE4B400 VA: 0x180E4CE00 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE4CE50 Offset: 0xE4B450 VA: 0x180E4CE50 Slot: 7
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

	// RVA: 0xE309C0 Offset: 0xE2EFC0 VA: 0x180E309C0
	public void .ctor() { }

	// RVA: 0xE30B40 Offset: 0xE2F140 VA: 0x180E30B40
	public void .ctor(JArray other) { }

	// RVA: 0xE30A70 Offset: 0xE2F070 VA: 0x180E30A70
	public void .ctor(object content) { }

	// RVA: 0xE30420 Offset: 0xE2EA20 VA: 0x180E30420 Slot: 11
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0xE30330 Offset: 0xE2E930 VA: 0x180E30330 Slot: 10
	internal override JToken CloneToken() { }

	// RVA: 0xE30870 Offset: 0xE2EE70 VA: 0x180E30870
	public static JArray Load(JsonReader reader) { }

	// RVA: 0xE306D0 Offset: 0xE2ECD0 VA: 0x180E306D0
	public static JArray Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xE308C0 Offset: 0xE2EEC0 VA: 0x180E308C0 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE30BC0 Offset: 0xE2F1C0 VA: 0x180E30BC0 Slot: 19
	public JToken get_Item(int index) { }

	// RVA: 0xE30BE0 Offset: 0xE2F1E0 VA: 0x180E30BE0 Slot: 20
	public void set_Item(int index, JToken value) { }

	// RVA: 0xE30630 Offset: 0xE2EC30 VA: 0x180E30630 Slot: 47
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xE30680 Offset: 0xE2EC80 VA: 0x180E30680 Slot: 21
	public int IndexOf(JToken item) { }

	// RVA: 0xE306A0 Offset: 0xE2ECA0 VA: 0x180E306A0 Slot: 22
	public void Insert(int index, JToken item) { }

	// RVA: 0xE30880 Offset: 0xE2EE80 VA: 0x180E30880 Slot: 23
	public void RemoveAt(int index) { }

	// RVA: 0xE305D0 Offset: 0xE2EBD0 VA: 0x180E305D0 Slot: 4
	public IEnumerator<JToken> GetEnumerator() { }

	// RVA: 0xE302F0 Offset: 0xE2E8F0 VA: 0x180E302F0 Slot: 26
	public void Add(JToken item) { }

	// RVA: 0xE30310 Offset: 0xE2E910 VA: 0x180E30310 Slot: 27
	public void Clear() { }

	// RVA: 0xE303E0 Offset: 0xE2E9E0 VA: 0x180E303E0 Slot: 28
	public bool Contains(JToken item) { }

	// RVA: 0xE30400 Offset: 0xE2EA00 VA: 0x180E30400 Slot: 29
	public void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 25
	public bool get_IsReadOnly() { }

	// RVA: 0xE308A0 Offset: 0xE2EEA0 VA: 0x180E308A0 Slot: 30
	public bool Remove(JToken item) { }

	// RVA: 0xE305C0 Offset: 0xE2EBC0 VA: 0x180E305C0 Slot: 18
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

	// RVA: 0xE39AE0 Offset: 0xE380E0 VA: 0x180E39AE0
	public void .ctor(JToken token) { }

	// RVA: 0xE38AB0 Offset: 0xE370B0 VA: 0x180E38AB0 Slot: 10
	public override bool Read() { }

	// RVA: 0xE38980 Offset: 0xE36F80 VA: 0x180E38980
	private bool ReadOver(JToken t) { }

	// RVA: 0xE38A70 Offset: 0xE37070 VA: 0x180E38A70
	private bool ReadToEnd() { }

	// RVA: 0xE38680 Offset: 0xE36C80 VA: 0x180E38680
	private Nullable<JsonToken> GetEndToken(JContainer c) { }

	// RVA: 0xE388E0 Offset: 0xE36EE0 VA: 0x180E388E0
	private bool ReadInto(JContainer c) { }

	// RVA: 0xE38DF0 Offset: 0xE373F0 VA: 0x180E38DF0
	private bool SetEnd(JContainer c) { }

	// RVA: 0xE38F90 Offset: 0xE37590 VA: 0x180E38F90
	private void SetToken(JToken token) { }

	// RVA: 0xE38DD0 Offset: 0xE373D0 VA: 0x180E38DD0
	private string SafeToString(object value) { }

	// RVA: 0xE387C0 Offset: 0xE36DC0 VA: 0x180E387C0 Slot: 21
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0xE38820 Offset: 0xE36E20 VA: 0x180E38820 Slot: 22
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0xE38880 Offset: 0xE36E80 VA: 0x180E38880 Slot: 23
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0xE39B40 Offset: 0xE38140 VA: 0x180E39B40 Slot: 9
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

	// RVA: 0xE3B080 Offset: 0xE39680 VA: 0x180E3B080
	public JToken get_Token() { }

	// RVA: 0xE3B010 Offset: 0xE39610 VA: 0x180E3B010
	public void .ctor() { }

	// RVA: 0xE39E60 Offset: 0xE38460 VA: 0x180E39E60 Slot: 6
	public override void Close() { }

	// RVA: 0xE3A290 Offset: 0xE38890 VA: 0x180E3A290 Slot: 7
	public override void WriteStartObject() { }

	// RVA: 0xE39C30 Offset: 0xE38230 VA: 0x180E39C30
	private void AddParent(JContainer container) { }

	// RVA: 0xE39ED0 Offset: 0xE384D0 VA: 0x180E39ED0
	private void RemoveParent() { }

	// RVA: 0xE3A1A0 Offset: 0xE387A0 VA: 0x180E3A1A0 Slot: 9
	public override void WriteStartArray() { }

	// RVA: 0xE3A210 Offset: 0xE38810 VA: 0x180E3A210 Slot: 11
	public override void WriteStartConstructor(string name) { }

	// RVA: 0xE39ED0 Offset: 0xE384D0 VA: 0x180E39ED0 Slot: 17
	protected override void WriteEnd(JsonToken token) { }

	// RVA: 0xE39FE0 Offset: 0xE385E0 VA: 0x180E39FE0 Slot: 13
	public override void WritePropertyName(string name) { }

	// RVA: 0xE39D00 Offset: 0xE38300 VA: 0x180E39D00
	private void AddValue(object value, JsonToken token) { }

	// RVA: 0xE39D90 Offset: 0xE38390 VA: 0x180E39D90
	internal void AddValue(JValue value, JsonToken token) { }

	// RVA: 0xE3AF00 Offset: 0xE39500 VA: 0x180E3AF00 Slot: 62
	public override void WriteValue(object value) { }

	// RVA: 0xE39FA0 Offset: 0xE385A0 VA: 0x180E39FA0 Slot: 21
	public override void WriteNull() { }

	// RVA: 0xE3A5A0 Offset: 0xE38BA0 VA: 0x180E3A5A0 Slot: 22
	public override void WriteUndefined() { }

	// RVA: 0xE3A130 Offset: 0xE38730 VA: 0x180E3A130 Slot: 23
	public override void WriteRaw(string json) { }

	// RVA: 0xE39F50 Offset: 0xE38550 VA: 0x180E39F50 Slot: 63
	public override void WriteComment(string text) { }

	// RVA: 0xE3ABD0 Offset: 0xE391D0 VA: 0x180E3ABD0 Slot: 25
	public override void WriteValue(string value) { }

	// RVA: 0xE3ADA0 Offset: 0xE393A0 VA: 0x180E3ADA0 Slot: 26
	public override void WriteValue(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE3A8D0 Offset: 0xE38ED0 VA: 0x180E3A8D0 Slot: 27
	public override void WriteValue(uint value) { }

	// RVA: 0xE3AAD0 Offset: 0xE390D0 VA: 0x180E3AAD0 Slot: 28
	public override void WriteValue(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE3AF10 Offset: 0xE39510 VA: 0x180E3AF10 Slot: 29
	public override void WriteValue(ulong value) { }

	// RVA: 0xE3A7A0 Offset: 0xE38DA0 VA: 0x180E3A7A0 Slot: 30
	public override void WriteValue(float value) { }

	// RVA: 0xE3ACA0 Offset: 0xE392A0 VA: 0x180E3ACA0 Slot: 31
	public override void WriteValue(double value) { }

	// RVA: 0xE3AE20 Offset: 0xE39420 VA: 0x180E3AE20 Slot: 32
	public override void WriteValue(bool value) { }

	// RVA: 0xE3AF90 Offset: 0xE39590 VA: 0x180E3AF90 Slot: 33
	public override void WriteValue(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE3AB50 Offset: 0xE39150 VA: 0x180E3AB50 Slot: 34
	public override void WriteValue(ushort value) { }

	// RVA: 0xE3A710 Offset: 0xE38D10 VA: 0x180E3A710 Slot: 35
	public override void WriteValue(char value) { }

	// RVA: 0xE3A9D0 Offset: 0xE38FD0 VA: 0x180E3A9D0 Slot: 36
	public override void WriteValue(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE3AD20 Offset: 0xE39320 VA: 0x180E3AD20 Slot: 37
	public override void WriteValue(sbyte value) { }

	// RVA: 0xE3A5E0 Offset: 0xE38BE0 VA: 0x180E3A5E0 Slot: 38
	public override void WriteValue(Decimal value) { }

	// RVA: 0xE3A660 Offset: 0xE38C60 VA: 0x180E3A660 Slot: 39
	public override void WriteValue(DateTime value) { }

	// RVA: 0xE3AC20 Offset: 0xE39220 VA: 0x180E3AC20 Slot: 40
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0xE3AEA0 Offset: 0xE394A0 VA: 0x180E3AEA0 Slot: 60
	public override void WriteValue(byte[] value) { }

	// RVA: 0xE3AA50 Offset: 0xE39050 VA: 0x180E3AA50 Slot: 42
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0xE3A950 Offset: 0xE38F50 VA: 0x180E3A950 Slot: 41
	public override void WriteValue(Guid value) { }

	// RVA: 0xE3A820 Offset: 0xE38E20 VA: 0x180E3A820 Slot: 61
	public override void WriteValue(Uri value) { }

	// RVA: 0xE3A300 Offset: 0xE38900 VA: 0x180E3A300 Slot: 16
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

	// RVA: 0xE3E0D0 Offset: 0xE3C6D0 VA: 0x180E3E0D0
	public JToken get_Root() { }

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract JToken CloneToken();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract bool DeepEquals(JToken node);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract JTokenType get_Type();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool get_HasValues();

	// RVA: 0xE3B470 Offset: 0xE39A70 VA: 0x180E3B470
	public static bool DeepEquals(JToken t1, JToken t2) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public JToken get_Next() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	internal void set_Next(JToken value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public JToken get_Previous() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	internal void set_Previous(JToken value) { }

	// RVA: 0xE3DE20 Offset: 0xE3C420 VA: 0x180E3DE20
	public string get_Path() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0xE3DCE0 Offset: 0xE3C2E0 VA: 0x180E3DCE0 Slot: 14
	public virtual JToken get_First() { }

	// RVA: 0xE3DD80 Offset: 0xE3C380 VA: 0x180E3DD80 Slot: 15
	public virtual JToken get_Last() { }

	// RVA: 0xE3B360 Offset: 0xE39960 VA: 0x180E3B360 Slot: 16
	public virtual JEnumerable<JToken> Children() { }

	// RVA: 0xE3BE80 Offset: 0xE3A480 VA: 0x180E3BE80
	public void Remove() { }

	// RVA: 0xE3BF00 Offset: 0xE3A500 VA: 0x180E3BF00
	public void Replace(JToken value) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void WriteTo(JsonWriter writer, JsonConverter[] converters);

	// RVA: 0xE3D340 Offset: 0xE3B940 VA: 0x180E3D340 Slot: 3
	public override string ToString() { }

	// RVA: 0xE3D150 Offset: 0xE3B750 VA: 0x180E3D150
	public string ToString(Formatting formatting, JsonConverter[] converters) { }

	// RVA: 0xE3B4A0 Offset: 0xE39AA0 VA: 0x180E3B4A0
	private static JValue EnsureValue(JToken value) { }

	// RVA: 0xE3B630 Offset: 0xE39C30 VA: 0x180E3B630
	private static string GetType(JToken token) { }

	// RVA: 0xE3D390 Offset: 0xE3B990 VA: 0x180E3D390
	private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable) { }

	// RVA: 0xE42DB0 Offset: 0xE413B0 VA: 0x180E42DB0
	public static bool op_Explicit(JToken value) { }

	// RVA: 0xE40370 Offset: 0xE3E970 VA: 0x180E40370
	public static DateTimeOffset op_Explicit(JToken value) { }

	// RVA: 0xE41170 Offset: 0xE3F770 VA: 0x180E41170
	public static Nullable<bool> op_Explicit(JToken value) { }

	// RVA: 0xE3E530 Offset: 0xE3CB30 VA: 0x180E3E530
	public static long op_Explicit(JToken value) { }

	// RVA: 0xE3E8F0 Offset: 0xE3CEF0 VA: 0x180E3E8F0
	public static Nullable<DateTime> op_Explicit(JToken value) { }

	// RVA: 0xE41EE0 Offset: 0xE404E0 VA: 0x180E41EE0
	public static Nullable<DateTimeOffset> op_Explicit(JToken value) { }

	// RVA: 0xE3F9A0 Offset: 0xE3DFA0 VA: 0x180E3F9A0
	public static Nullable<Decimal> op_Explicit(JToken value) { }

	// RVA: 0xE41C90 Offset: 0xE40290 VA: 0x180E41C90
	public static Nullable<double> op_Explicit(JToken value) { }

	// RVA: 0xE3F040 Offset: 0xE3D640 VA: 0x180E3F040
	public static Nullable<char> op_Explicit(JToken value) { }

	// RVA: 0xE43260 Offset: 0xE41860 VA: 0x180E43260
	public static int op_Explicit(JToken value) { }

	// RVA: 0xE40840 Offset: 0xE3EE40 VA: 0x180E40840
	public static short op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE424E0 Offset: 0xE40AE0 VA: 0x180E424E0
	public static ushort op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE3E100 Offset: 0xE3C700 VA: 0x180E3E100
	public static char op_Explicit(JToken value) { }

	// RVA: 0xE40190 Offset: 0xE3E790 VA: 0x180E40190
	public static byte op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE3EE60 Offset: 0xE3D460 VA: 0x180E3EE60
	public static sbyte op_Explicit(JToken value) { }

	// RVA: 0xE413C0 Offset: 0xE3F9C0 VA: 0x180E413C0
	public static Nullable<int> op_Explicit(JToken value) { }

	// RVA: 0xE41860 Offset: 0xE3FE60 VA: 0x180E41860
	public static Nullable<short> op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE426C0 Offset: 0xE40CC0 VA: 0x180E426C0
	public static Nullable<ushort> op_Explicit(JToken value) { }

	// RVA: 0xE41610 Offset: 0xE3FC10 VA: 0x180E41610
	public static Nullable<byte> op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE40A20 Offset: 0xE3F020 VA: 0x180E40A20
	public static Nullable<sbyte> op_Explicit(JToken value) { }

	// RVA: 0xE422A0 Offset: 0xE408A0 VA: 0x180E422A0
	public static DateTime op_Explicit(JToken value) { }

	// RVA: 0xE3F470 Offset: 0xE3DA70 VA: 0x180E3F470
	public static Nullable<long> op_Explicit(JToken value) { }

	// RVA: 0xE40F20 Offset: 0xE3F520 VA: 0x180E40F20
	public static Nullable<float> op_Explicit(JToken value) { }

	// RVA: 0xE3FC20 Offset: 0xE3E220 VA: 0x180E3FC20
	public static Decimal op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE42B60 Offset: 0xE41160 VA: 0x180E42B60
	public static Nullable<uint> op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE42910 Offset: 0xE40F10 VA: 0x180E42910
	public static Nullable<ulong> op_Explicit(JToken value) { }

	// RVA: 0xE3F290 Offset: 0xE3D890 VA: 0x180E3F290
	public static double op_Explicit(JToken value) { }

	// RVA: 0xE41AB0 Offset: 0xE400B0 VA: 0x180E41AB0
	public static float op_Explicit(JToken value) { }

	// RVA: 0xE40C70 Offset: 0xE3F270 VA: 0x180E40C70
	public static string op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE40660 Offset: 0xE3EC60 VA: 0x180E40660
	public static uint op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE3E710 Offset: 0xE3CD10 VA: 0x180E3E710
	public static ulong op_Explicit(JToken value) { }

	// RVA: 0xE42F90 Offset: 0xE41590 VA: 0x180E42F90
	public static Guid op_Explicit(JToken value) { }

	// RVA: 0xE3FE10 Offset: 0xE3E410 VA: 0x180E3FE10
	public static Nullable<Guid> op_Explicit(JToken value) { }

	// RVA: 0xE3E2E0 Offset: 0xE3C8E0 VA: 0x180E3E2E0
	public static TimeSpan op_Explicit(JToken value) { }

	// RVA: 0xE3EBA0 Offset: 0xE3D1A0 VA: 0x180E3EBA0
	public static Nullable<TimeSpan> op_Explicit(JToken value) { }

	// RVA: 0xE3F6C0 Offset: 0xE3DCC0 VA: 0x180E3F6C0
	public static Uri op_Explicit(JToken value) { }

	// RVA: 0xE3C160 Offset: 0xE3A760 VA: 0x180E3C160 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xE3C100 Offset: 0xE3A700 VA: 0x180E3C100 Slot: 4
	private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract int GetDeepHashCode();

	// RVA: 0xE3B3C0 Offset: 0xE399C0 VA: 0x180E3B3C0
	public JsonReader CreateReader() { }

	// RVA: -1 Offset: -1
	public T ToObject<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CFAA0 Offset: 0x5CE0A0 VA: 0x1805CFAA0
	|-JToken.ToObject<UITwitchTrophy.TrophyPage>
	|-JToken.ToObject<object>
	*/

	// RVA: 0xE3C2F0 Offset: 0xE3A8F0 VA: 0x180E3C2F0
	public object ToObject(Type objectType) { }

	// RVA: 0xE3C1A0 Offset: 0xE3A7A0 VA: 0x180E3C1A0
	public object ToObject(Type objectType, JsonSerializer jsonSerializer) { }

	// RVA: 0xE3BB20 Offset: 0xE3A120 VA: 0x180E3BB20
	public static JToken ReadFrom(JsonReader reader) { }

	// RVA: 0xE3BB80 Offset: 0xE3A180 VA: 0x180E3BB80
	public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xE3BAC0 Offset: 0xE3A0C0 VA: 0x180E3BAC0
	public static JToken Parse(string json) { }

	// RVA: 0xE3B8F0 Offset: 0xE39EF0 VA: 0x180E3B8F0
	public static JToken Parse(string json, JsonLoadSettings settings) { }

	// RVA: 0xE3B7A0 Offset: 0xE39DA0 VA: 0x180E3B7A0
	public static JToken Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xE3C010 Offset: 0xE3A610 VA: 0x180E3C010
	internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings) { }

	// RVA: 0xE3BF90 Offset: 0xE3A590 VA: 0x180E3BF90
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0xE3B810 Offset: 0xE39E10 VA: 0x180E3B810 Slot: 6
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0xE3B850 Offset: 0xE39E50 VA: 0x180E3B850 Slot: 7
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0xE3B8A0 Offset: 0xE39EA0 VA: 0x180E3B8A0 Slot: 8
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0xE3B450 Offset: 0xE39A50 VA: 0x180E3B450 Slot: 9
	private object System.ICloneable.Clone() { }

	// RVA: 0xE3B450 Offset: 0xE39A50 VA: 0x180E3B450
	public JToken DeepClone() { }

	// RVA: 0xE3B090 Offset: 0xE39690 VA: 0x180E3B090
	public void AddAnnotation(object annotation) { }

	// RVA: -1 Offset: -1
	public T Annotation<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CF900 Offset: 0x5CDF00 VA: 0x1805CF900
	|-JToken.Annotation<JToken.LineInfoAnnotation>
	|-JToken.Annotation<object>
	*/

	// RVA: 0xE3D470 Offset: 0xE3BA70 VA: 0x180E3D470
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
	// RVA: 0xE38120 Offset: 0xE36720 VA: 0x180E38120
	public JToken get_Value() { }

	// RVA: 0xE38140 Offset: 0xE36740 VA: 0x180E38140
	public void set_Value(JToken value) { }

	// RVA: 0xE37D90 Offset: 0xE36390 VA: 0x180E37D90
	public void .ctor(JProperty other) { }

	// RVA: 0xE37510 Offset: 0xE35B10 VA: 0x180E37510 Slot: 51
	internal override JToken GetItem(int index) { }

	// RVA: 0xE37A70 Offset: 0xE36070 VA: 0x180E37A70 Slot: 52
	internal override void SetItem(int index, JToken item) { }

	// RVA: 0xE379A0 Offset: 0xE35FA0 VA: 0x180E379A0 Slot: 50
	internal override bool RemoveItem(JToken item) { }

	// RVA: 0xE378D0 Offset: 0xE35ED0 VA: 0x180E378D0 Slot: 49
	internal override void RemoveItemAt(int index) { }

	// RVA: 0xE37590 Offset: 0xE35B90 VA: 0x180E37590 Slot: 47
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xE375C0 Offset: 0xE35BC0 VA: 0x180E375C0 Slot: 48
	internal override void InsertItem(int index, JToken item, bool skipParentCheck) { }

	// RVA: 0xE372C0 Offset: 0xE358C0 VA: 0x180E372C0 Slot: 55
	internal override bool ContainsItem(JToken item) { }

	// RVA: 0xE37130 Offset: 0xE35730 VA: 0x180E37130 Slot: 53
	internal override void ClearItems() { }

	// RVA: 0xE372E0 Offset: 0xE358E0 VA: 0x180E372E0 Slot: 11
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0xE37200 Offset: 0xE35800 VA: 0x180E37200 Slot: 10
	internal override JToken CloneToken() { }

	[DebuggerStepThroughAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE38110 Offset: 0xE36710 VA: 0x180E38110 Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0xE38040 Offset: 0xE36640 VA: 0x180E38040
	internal void .ctor(string name) { }

	// RVA: 0xE37E20 Offset: 0xE36420 VA: 0x180E37E20
	public void .ctor(string name, object content) { }

	// RVA: 0xE37CF0 Offset: 0xE362F0 VA: 0x180E37CF0 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE374A0 Offset: 0xE35AA0 VA: 0x180E374A0 Slot: 18
	internal override int GetDeepHashCode() { }

	// RVA: 0xE376E0 Offset: 0xE35CE0 VA: 0x180E376E0
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

	// RVA: 0xE37020 Offset: 0xE35620 VA: 0x180E37020 Slot: 16
	public IEnumerator<JToken> GetEnumerator() { }

	// RVA: 0xE37020 Offset: 0xE35620 VA: 0x180E37020 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630 Slot: 11
	public void Add(JToken item) { }

	// RVA: 0xE36F60 Offset: 0xE35560 VA: 0x180E36F60 Slot: 12
	public void Clear() { }

	// RVA: 0xE36F80 Offset: 0xE35580 VA: 0x180E36F80 Slot: 13
	public bool Contains(JToken item) { }

	// RVA: 0xE36F90 Offset: 0xE35590 VA: 0x180E36F90 Slot: 14
	public void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0xE370E0 Offset: 0xE356E0 VA: 0x180E370E0 Slot: 15
	public bool Remove(JToken item) { }

	// RVA: 0xE37110 Offset: 0xE35710 VA: 0x180E37110 Slot: 9
	public int get_Count() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0xE37090 Offset: 0xE35690 VA: 0x180E37090 Slot: 6
	public int IndexOf(JToken item) { }

	// RVA: 0xE370A0 Offset: 0xE356A0 VA: 0x180E370A0 Slot: 7
	public void Insert(int index, JToken item) { }

	// RVA: 0xE370C0 Offset: 0xE356C0 VA: 0x180E370C0 Slot: 8
	public void RemoveAt(int index) { }

	// RVA: 0xE37120 Offset: 0xE35720 VA: 0x180E37120 Slot: 4
	public JToken get_Item(int index) { }

	// RVA: 0xE370A0 Offset: 0xE356A0 VA: 0x180E370A0 Slot: 5
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

	// RVA: 0xE4CB40 Offset: 0xE4B140 VA: 0x180E4CB40 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE4CBA0 Offset: 0xE4B1A0 VA: 0x180E4CBA0 Slot: 8
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

	// RVA: 0xE45C40 Offset: 0xE44240 VA: 0x180E45C40
	internal void .ctor(object value, JTokenType type) { }

	// RVA: 0xE384B0 Offset: 0xE36AB0 VA: 0x180E384B0
	public void .ctor(JValue other) { }

	// RVA: 0xE45C00 Offset: 0xE44200 VA: 0x180E45C00
	public void .ctor(object value) { }

	// RVA: 0xE44140 Offset: 0xE42740 VA: 0x180E44140 Slot: 11
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 13
	public override bool get_HasValues() { }

	// RVA: 0xE435F0 Offset: 0xE41BF0 VA: 0x180E435F0
	internal static int Compare(JTokenType valueType, object objA, object objB) { }

	// RVA: 0xE43500 Offset: 0xE41B00 VA: 0x180E43500
	private static int CompareFloat(object objA, object objB) { }

	// RVA: 0xE43440 Offset: 0xE41A40 VA: 0x180E43440 Slot: 10
	internal override JToken CloneToken() { }

	// RVA: 0xE43F60 Offset: 0xE42560 VA: 0x180E43F60
	public static JValue CreateComment(string value) { }

	// RVA: 0xE44000 Offset: 0xE42600 VA: 0x180E44000
	public static JValue CreateNull() { }

	// RVA: 0xE440A0 Offset: 0xE426A0 VA: 0x180E440A0
	public static JValue CreateUndefined() { }

	// RVA: 0xE44400 Offset: 0xE42A00 VA: 0x180E44400
	private static JTokenType GetValueType(Nullable<JTokenType> current, object value) { }

	// RVA: 0xE443A0 Offset: 0xE429A0 VA: 0x180E443A0
	private static JTokenType GetStringValueType(Nullable<JTokenType> current) { }

	// RVA: 0xA38FA0 Offset: 0xA375A0 VA: 0x180A38FA0 Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public object get_Value() { }

	// RVA: 0xE45210 Offset: 0xE43810 VA: 0x180E45210 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE44330 Offset: 0xE42930 VA: 0x180E44330 Slot: 18
	internal override int GetDeepHashCode() { }

	// RVA: 0xE451C0 Offset: 0xE437C0 VA: 0x180E451C0
	private static bool ValuesEquals(JValue v1, JValue v2) { }

	// RVA: 0xE442E0 Offset: 0xE428E0 VA: 0x180E442E0
	public bool Equals(JValue other) { }

	// RVA: 0xE44200 Offset: 0xE42800 VA: 0x180E44200 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xE44380 Offset: 0xE42980 VA: 0x180E44380 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xE44F00 Offset: 0xE43500 VA: 0x180E44F00 Slot: 3
	public override string ToString() { }

	// RVA: 0xE44F60 Offset: 0xE43560 VA: 0x180E44F60 Slot: 36
	public string ToString(IFormatProvider formatProvider) { }

	// RVA: 0xE45080 Offset: 0xE43680 VA: 0x180E45080 Slot: 19
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0xE44810 Offset: 0xE42E10 VA: 0x180E44810 Slot: 20
	private int System.IComparable.CompareTo(object obj) { }

	// RVA: 0xE44930 Offset: 0xE42F30 VA: 0x180E44930 Slot: 21
	private TypeCode System.IConvertible.GetTypeCode() { }

	// RVA: 0xE449A0 Offset: 0xE42FA0 VA: 0x180E449A0 Slot: 22
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0xE44A60 Offset: 0xE43060 VA: 0x180E44A60 Slot: 23
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0xE44D10 Offset: 0xE43310 VA: 0x180E44D10 Slot: 24
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0xE44A00 Offset: 0xE43000 VA: 0x180E44A00 Slot: 25
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0xE44BF0 Offset: 0xE431F0 VA: 0x180E44BF0 Slot: 26
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0xE44DE0 Offset: 0xE433E0 VA: 0x180E44DE0 Slot: 27
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0xE44C50 Offset: 0xE43250 VA: 0x180E44C50 Slot: 28
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0xE44E40 Offset: 0xE43440 VA: 0x180E44E40 Slot: 29
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0xE44CB0 Offset: 0xE432B0 VA: 0x180E44CB0 Slot: 30
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0xE44EA0 Offset: 0xE434A0 VA: 0x180E44EA0 Slot: 31
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0xE44D70 Offset: 0xE43370 VA: 0x180E44D70 Slot: 32
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0xE44B90 Offset: 0xE43190 VA: 0x180E44B90 Slot: 33
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0xE44B20 Offset: 0xE43120 VA: 0x180E44B20 Slot: 34
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0xE44AC0 Offset: 0xE430C0 VA: 0x180E44AC0 Slot: 35
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0xE44DD0 Offset: 0xE433D0 VA: 0x180E44DD0 Slot: 37
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

	// RVA: 0x87AAC0 Offset: 0x8790C0 VA: 0x18087AAC0
	public static Variant Load(string json) { }

	// RVA: 0x87A8A0 Offset: 0x878EA0 VA: 0x18087A8A0
	public static string Dump(object data) { }

	// RVA: 0x87A6B0 Offset: 0x878CB0 VA: 0x18087A6B0
	public static string Dump(object data, EncodeOptions options) { }

	// RVA: -1 Offset: -1
	public static void MakeInto<T>(Variant data, out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CEB70 Offset: 0x5CD170 VA: 0x1805CEB70
	|-JSON.MakeInto<object>
	*/

	// RVA: 0x87A900 Offset: 0x878F00 VA: 0x18087A900
	private static Type FindType(string fullName) { }

	[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	private static T DecodeType<T>(Variant data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDA1C0 Offset: 0xBD87C0 VA: 0x180BDA1C0
	|-JSON.DecodeType<bool>
	|
	|-RVA: 0xBDC1A0 Offset: 0xBDA7A0 VA: 0x180BDC1A0
	|-JSON.DecodeType<Decimal>
	|
	|-RVA: 0xBDE160 Offset: 0xBDC760 VA: 0x180BDE160
	|-JSON.DecodeType<double>
	|
	|-RVA: 0x15A9630 Offset: 0x15A7C30 VA: 0x1815A9630
	|-JSON.DecodeType<short>
	|
	|-RVA: 0x15AB600 Offset: 0x15A9C00 VA: 0x1815AB600
	|-JSON.DecodeType<int>
	|
	|-RVA: 0x15AD5A0 Offset: 0x15ABBA0 VA: 0x1815AD5A0
	|-JSON.DecodeType<long>
	|
	|-RVA: 0x15AF570 Offset: 0x15ADB70 VA: 0x1815AF570
	|-JSON.DecodeType<object>
	|
	|-RVA: 0x15B1490 Offset: 0x15AFA90 VA: 0x1815B1490
	|-JSON.DecodeType<float>
	|
	|-RVA: 0x15B3430 Offset: 0x15B1A30 VA: 0x1815B3430
	|-JSON.DecodeType<ushort>
	|
	|-RVA: 0x15B5400 Offset: 0x15B3A00 VA: 0x1815B5400
	|-JSON.DecodeType<uint>
	|
	|-RVA: 0x15B73A0 Offset: 0x15B59A0 VA: 0x1815B73A0
	|-JSON.DecodeType<ulong>
	*/

	[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	private static List<T> DecodeList<T>(Variant data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AD7D0 Offset: 0x12ABDD0 VA: 0x1812AD7D0
	|-JSON.DecodeList<bool>
	|
	|-RVA: 0x12AD9C0 Offset: 0x12ABFC0 VA: 0x1812AD9C0
	|-JSON.DecodeList<Decimal>
	|
	|-RVA: 0x12ADBC0 Offset: 0x12AC1C0 VA: 0x1812ADBC0
	|-JSON.DecodeList<double>
	|
	|-RVA: 0x12ADDB0 Offset: 0x12AC3B0 VA: 0x1812ADDB0
	|-JSON.DecodeList<short>
	|
	|-RVA: 0x12ADFA0 Offset: 0x12AC5A0 VA: 0x1812ADFA0
	|-JSON.DecodeList<int>
	|
	|-RVA: 0x12AE190 Offset: 0x12AC790 VA: 0x1812AE190
	|-JSON.DecodeList<long>
	|
	|-RVA: 0x12AE380 Offset: 0x12AC980 VA: 0x1812AE380
	|-JSON.DecodeList<object>
	|
	|-RVA: 0x12AE570 Offset: 0x12ACB70 VA: 0x1812AE570
	|-JSON.DecodeList<float>
	|
	|-RVA: 0x12AE760 Offset: 0x12ACD60 VA: 0x1812AE760
	|-JSON.DecodeList<ushort>
	|
	|-RVA: 0x12AE950 Offset: 0x12ACF50 VA: 0x1812AE950
	|-JSON.DecodeList<uint>
	|
	|-RVA: 0x12AEB40 Offset: 0x12AD140 VA: 0x1812AEB40
	|-JSON.DecodeList<ulong>
	*/

	[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	private static Dictionary<TKey, TValue> DecodeDictionary<TKey, TValue>(Variant data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15390A0 Offset: 0x15376A0 VA: 0x1815390A0
	|-JSON.DecodeDictionary<bool, bool>
	|
	|-RVA: 0x1539430 Offset: 0x1537A30 VA: 0x181539430
	|-JSON.DecodeDictionary<bool, Decimal>
	|
	|-RVA: 0x15397C0 Offset: 0x1537DC0 VA: 0x1815397C0
	|-JSON.DecodeDictionary<bool, double>
	|
	|-RVA: 0x1539B50 Offset: 0x1538150 VA: 0x181539B50
	|-JSON.DecodeDictionary<bool, short>
	|
	|-RVA: 0x1539EE0 Offset: 0x15384E0 VA: 0x181539EE0
	|-JSON.DecodeDictionary<bool, int>
	|
	|-RVA: 0x153A270 Offset: 0x1538870 VA: 0x18153A270
	|-JSON.DecodeDictionary<bool, long>
	|
	|-RVA: 0x153A600 Offset: 0x1538C00 VA: 0x18153A600
	|-JSON.DecodeDictionary<bool, object>
	|
	|-RVA: 0x153A990 Offset: 0x1538F90 VA: 0x18153A990
	|-JSON.DecodeDictionary<bool, float>
	|
	|-RVA: 0x153AD20 Offset: 0x1539320 VA: 0x18153AD20
	|-JSON.DecodeDictionary<bool, ushort>
	|
	|-RVA: 0x153B0B0 Offset: 0x15396B0 VA: 0x18153B0B0
	|-JSON.DecodeDictionary<bool, uint>
	|
	|-RVA: 0x153B440 Offset: 0x1539A40 VA: 0x18153B440
	|-JSON.DecodeDictionary<bool, ulong>
	|
	|-RVA: 0x153B7D0 Offset: 0x1539DD0 VA: 0x18153B7D0
	|-JSON.DecodeDictionary<Decimal, bool>
	|
	|-RVA: 0x153BB60 Offset: 0x153A160 VA: 0x18153BB60
	|-JSON.DecodeDictionary<Decimal, Decimal>
	|
	|-RVA: 0x153BF00 Offset: 0x153A500 VA: 0x18153BF00
	|-JSON.DecodeDictionary<Decimal, double>
	|
	|-RVA: 0x153C290 Offset: 0x153A890 VA: 0x18153C290
	|-JSON.DecodeDictionary<Decimal, short>
	|
	|-RVA: 0x153C620 Offset: 0x153AC20 VA: 0x18153C620
	|-JSON.DecodeDictionary<Decimal, int>
	|
	|-RVA: 0x153C9B0 Offset: 0x153AFB0 VA: 0x18153C9B0
	|-JSON.DecodeDictionary<Decimal, long>
	|
	|-RVA: 0x153CD40 Offset: 0x153B340 VA: 0x18153CD40
	|-JSON.DecodeDictionary<Decimal, object>
	|
	|-RVA: 0x153D0D0 Offset: 0x153B6D0 VA: 0x18153D0D0
	|-JSON.DecodeDictionary<Decimal, float>
	|
	|-RVA: 0x153D460 Offset: 0x153BA60 VA: 0x18153D460
	|-JSON.DecodeDictionary<Decimal, ushort>
	|
	|-RVA: 0x153D7F0 Offset: 0x153BDF0 VA: 0x18153D7F0
	|-JSON.DecodeDictionary<Decimal, uint>
	|
	|-RVA: 0x153DB80 Offset: 0x153C180 VA: 0x18153DB80
	|-JSON.DecodeDictionary<Decimal, ulong>
	|
	|-RVA: 0x153DF10 Offset: 0x153C510 VA: 0x18153DF10
	|-JSON.DecodeDictionary<double, bool>
	|
	|-RVA: 0x153E2A0 Offset: 0x153C8A0 VA: 0x18153E2A0
	|-JSON.DecodeDictionary<double, Decimal>
	|
	|-RVA: 0x153E640 Offset: 0x153CC40 VA: 0x18153E640
	|-JSON.DecodeDictionary<double, double>
	|
	|-RVA: 0x153E9D0 Offset: 0x153CFD0 VA: 0x18153E9D0
	|-JSON.DecodeDictionary<double, short>
	|
	|-RVA: 0x153ED60 Offset: 0x153D360 VA: 0x18153ED60
	|-JSON.DecodeDictionary<double, int>
	|
	|-RVA: 0x153F0F0 Offset: 0x153D6F0 VA: 0x18153F0F0
	|-JSON.DecodeDictionary<double, long>
	|
	|-RVA: 0x153F480 Offset: 0x153DA80 VA: 0x18153F480
	|-JSON.DecodeDictionary<double, object>
	|
	|-RVA: 0x153F810 Offset: 0x153DE10 VA: 0x18153F810
	|-JSON.DecodeDictionary<double, float>
	|
	|-RVA: 0x153FBA0 Offset: 0x153E1A0 VA: 0x18153FBA0
	|-JSON.DecodeDictionary<double, ushort>
	|
	|-RVA: 0x153FF30 Offset: 0x153E530 VA: 0x18153FF30
	|-JSON.DecodeDictionary<double, uint>
	|
	|-RVA: 0x15402C0 Offset: 0x153E8C0 VA: 0x1815402C0
	|-JSON.DecodeDictionary<double, ulong>
	|
	|-RVA: 0x1540650 Offset: 0x153EC50 VA: 0x181540650
	|-JSON.DecodeDictionary<short, bool>
	|
	|-RVA: 0x15409E0 Offset: 0x153EFE0 VA: 0x1815409E0
	|-JSON.DecodeDictionary<short, Decimal>
	|
	|-RVA: 0x1540D70 Offset: 0x153F370 VA: 0x181540D70
	|-JSON.DecodeDictionary<short, double>
	|
	|-RVA: 0x1541100 Offset: 0x153F700 VA: 0x181541100
	|-JSON.DecodeDictionary<short, short>
	|
	|-RVA: 0x1541490 Offset: 0x153FA90 VA: 0x181541490
	|-JSON.DecodeDictionary<short, int>
	|
	|-RVA: 0x1541820 Offset: 0x153FE20 VA: 0x181541820
	|-JSON.DecodeDictionary<short, long>
	|
	|-RVA: 0x1541BB0 Offset: 0x15401B0 VA: 0x181541BB0
	|-JSON.DecodeDictionary<short, object>
	|
	|-RVA: 0x1541F40 Offset: 0x1540540 VA: 0x181541F40
	|-JSON.DecodeDictionary<short, float>
	|
	|-RVA: 0x15422D0 Offset: 0x15408D0 VA: 0x1815422D0
	|-JSON.DecodeDictionary<short, ushort>
	|
	|-RVA: 0x1542660 Offset: 0x1540C60 VA: 0x181542660
	|-JSON.DecodeDictionary<short, uint>
	|
	|-RVA: 0x15429F0 Offset: 0x1540FF0 VA: 0x1815429F0
	|-JSON.DecodeDictionary<short, ulong>
	|
	|-RVA: 0x1542D80 Offset: 0x1541380 VA: 0x181542D80
	|-JSON.DecodeDictionary<int, bool>
	|
	|-RVA: 0x1543110 Offset: 0x1541710 VA: 0x181543110
	|-JSON.DecodeDictionary<int, Decimal>
	|
	|-RVA: 0x15434A0 Offset: 0x1541AA0 VA: 0x1815434A0
	|-JSON.DecodeDictionary<int, double>
	|
	|-RVA: 0x1543830 Offset: 0x1541E30 VA: 0x181543830
	|-JSON.DecodeDictionary<int, short>
	|
	|-RVA: 0x1543BC0 Offset: 0x15421C0 VA: 0x181543BC0
	|-JSON.DecodeDictionary<int, int>
	|
	|-RVA: 0x1543F50 Offset: 0x1542550 VA: 0x181543F50
	|-JSON.DecodeDictionary<int, long>
	|
	|-RVA: 0x15442E0 Offset: 0x15428E0 VA: 0x1815442E0
	|-JSON.DecodeDictionary<int, object>
	|
	|-RVA: 0x1544670 Offset: 0x1542C70 VA: 0x181544670
	|-JSON.DecodeDictionary<int, float>
	|
	|-RVA: 0x1544A00 Offset: 0x1543000 VA: 0x181544A00
	|-JSON.DecodeDictionary<int, ushort>
	|
	|-RVA: 0x1544D90 Offset: 0x1543390 VA: 0x181544D90
	|-JSON.DecodeDictionary<int, uint>
	|
	|-RVA: 0x1545120 Offset: 0x1543720 VA: 0x181545120
	|-JSON.DecodeDictionary<int, ulong>
	|
	|-RVA: 0x15454B0 Offset: 0x1543AB0 VA: 0x1815454B0
	|-JSON.DecodeDictionary<long, bool>
	|
	|-RVA: 0x1545840 Offset: 0x1543E40 VA: 0x181545840
	|-JSON.DecodeDictionary<long, Decimal>
	|
	|-RVA: 0x1545BD0 Offset: 0x15441D0 VA: 0x181545BD0
	|-JSON.DecodeDictionary<long, double>
	|
	|-RVA: 0x1545F60 Offset: 0x1544560 VA: 0x181545F60
	|-JSON.DecodeDictionary<long, short>
	|
	|-RVA: 0x15462F0 Offset: 0x15448F0 VA: 0x1815462F0
	|-JSON.DecodeDictionary<long, int>
	|
	|-RVA: 0x1546680 Offset: 0x1544C80 VA: 0x181546680
	|-JSON.DecodeDictionary<long, long>
	|
	|-RVA: 0x1546A10 Offset: 0x1545010 VA: 0x181546A10
	|-JSON.DecodeDictionary<long, object>
	|
	|-RVA: 0x1546DA0 Offset: 0x15453A0 VA: 0x181546DA0
	|-JSON.DecodeDictionary<long, float>
	|
	|-RVA: 0x1547130 Offset: 0x1545730 VA: 0x181547130
	|-JSON.DecodeDictionary<long, ushort>
	|
	|-RVA: 0x15474C0 Offset: 0x1545AC0 VA: 0x1815474C0
	|-JSON.DecodeDictionary<long, uint>
	|
	|-RVA: 0x1547850 Offset: 0x1545E50 VA: 0x181547850
	|-JSON.DecodeDictionary<long, ulong>
	|
	|-RVA: 0x1547BE0 Offset: 0x15461E0 VA: 0x181547BE0
	|-JSON.DecodeDictionary<object, bool>
	|
	|-RVA: 0x1547F80 Offset: 0x1546580 VA: 0x181547F80
	|-JSON.DecodeDictionary<object, Decimal>
	|
	|-RVA: 0x1548320 Offset: 0x1546920 VA: 0x181548320
	|-JSON.DecodeDictionary<object, double>
	|
	|-RVA: 0x15486C0 Offset: 0x1546CC0 VA: 0x1815486C0
	|-JSON.DecodeDictionary<object, short>
	|
	|-RVA: 0x1548A60 Offset: 0x1547060 VA: 0x181548A60
	|-JSON.DecodeDictionary<object, int>
	|
	|-RVA: 0x1548E00 Offset: 0x1547400 VA: 0x181548E00
	|-JSON.DecodeDictionary<object, long>
	|
	|-RVA: 0x15491A0 Offset: 0x15477A0 VA: 0x1815491A0
	|-JSON.DecodeDictionary<object, object>
	|
	|-RVA: 0x1549540 Offset: 0x1547B40 VA: 0x181549540
	|-JSON.DecodeDictionary<object, float>
	|
	|-RVA: 0x15498E0 Offset: 0x1547EE0 VA: 0x1815498E0
	|-JSON.DecodeDictionary<object, ushort>
	|
	|-RVA: 0x1549C80 Offset: 0x1548280 VA: 0x181549C80
	|-JSON.DecodeDictionary<object, uint>
	|
	|-RVA: 0x154A020 Offset: 0x1548620 VA: 0x18154A020
	|-JSON.DecodeDictionary<object, ulong>
	|
	|-RVA: 0x154A3C0 Offset: 0x15489C0 VA: 0x18154A3C0
	|-JSON.DecodeDictionary<float, bool>
	|
	|-RVA: 0x154A750 Offset: 0x1548D50 VA: 0x18154A750
	|-JSON.DecodeDictionary<float, Decimal>
	|
	|-RVA: 0x154AAF0 Offset: 0x15490F0 VA: 0x18154AAF0
	|-JSON.DecodeDictionary<float, double>
	|
	|-RVA: 0x154AE80 Offset: 0x1549480 VA: 0x18154AE80
	|-JSON.DecodeDictionary<float, short>
	|
	|-RVA: 0x154B210 Offset: 0x1549810 VA: 0x18154B210
	|-JSON.DecodeDictionary<float, int>
	|
	|-RVA: 0x154B5A0 Offset: 0x1549BA0 VA: 0x18154B5A0
	|-JSON.DecodeDictionary<float, long>
	|
	|-RVA: 0x154B930 Offset: 0x1549F30 VA: 0x18154B930
	|-JSON.DecodeDictionary<float, object>
	|
	|-RVA: 0x154BCC0 Offset: 0x154A2C0 VA: 0x18154BCC0
	|-JSON.DecodeDictionary<float, float>
	|
	|-RVA: 0x154C050 Offset: 0x154A650 VA: 0x18154C050
	|-JSON.DecodeDictionary<float, ushort>
	|
	|-RVA: 0x154C3E0 Offset: 0x154A9E0 VA: 0x18154C3E0
	|-JSON.DecodeDictionary<float, uint>
	|
	|-RVA: 0x154C770 Offset: 0x154AD70 VA: 0x18154C770
	|-JSON.DecodeDictionary<float, ulong>
	|
	|-RVA: 0x154CB00 Offset: 0x154B100 VA: 0x18154CB00
	|-JSON.DecodeDictionary<ushort, bool>
	|
	|-RVA: 0x154CE90 Offset: 0x154B490 VA: 0x18154CE90
	|-JSON.DecodeDictionary<ushort, Decimal>
	|
	|-RVA: 0x154D220 Offset: 0x154B820 VA: 0x18154D220
	|-JSON.DecodeDictionary<ushort, double>
	|
	|-RVA: 0x154D5B0 Offset: 0x154BBB0 VA: 0x18154D5B0
	|-JSON.DecodeDictionary<ushort, short>
	|
	|-RVA: 0x154D940 Offset: 0x154BF40 VA: 0x18154D940
	|-JSON.DecodeDictionary<ushort, int>
	|
	|-RVA: 0x154DCD0 Offset: 0x154C2D0 VA: 0x18154DCD0
	|-JSON.DecodeDictionary<ushort, long>
	|
	|-RVA: 0x154E060 Offset: 0x154C660 VA: 0x18154E060
	|-JSON.DecodeDictionary<ushort, object>
	|
	|-RVA: 0x154E3F0 Offset: 0x154C9F0 VA: 0x18154E3F0
	|-JSON.DecodeDictionary<ushort, float>
	|
	|-RVA: 0x154E780 Offset: 0x154CD80 VA: 0x18154E780
	|-JSON.DecodeDictionary<ushort, ushort>
	|
	|-RVA: 0x154EB10 Offset: 0x154D110 VA: 0x18154EB10
	|-JSON.DecodeDictionary<ushort, uint>
	|
	|-RVA: 0x154EEA0 Offset: 0x154D4A0 VA: 0x18154EEA0
	|-JSON.DecodeDictionary<ushort, ulong>
	|
	|-RVA: 0x154F230 Offset: 0x154D830 VA: 0x18154F230
	|-JSON.DecodeDictionary<uint, bool>
	|
	|-RVA: 0x154F5C0 Offset: 0x154DBC0 VA: 0x18154F5C0
	|-JSON.DecodeDictionary<uint, Decimal>
	|
	|-RVA: 0x154F950 Offset: 0x154DF50 VA: 0x18154F950
	|-JSON.DecodeDictionary<uint, double>
	|
	|-RVA: 0x154FCE0 Offset: 0x154E2E0 VA: 0x18154FCE0
	|-JSON.DecodeDictionary<uint, short>
	|
	|-RVA: 0x1550070 Offset: 0x154E670 VA: 0x181550070
	|-JSON.DecodeDictionary<uint, int>
	|
	|-RVA: 0x1550400 Offset: 0x154EA00 VA: 0x181550400
	|-JSON.DecodeDictionary<uint, long>
	|
	|-RVA: 0xCFFBF0 Offset: 0xCFE1F0 VA: 0x180CFFBF0
	|-JSON.DecodeDictionary<uint, object>
	|
	|-RVA: 0xCFFF80 Offset: 0xCFE580 VA: 0x180CFFF80
	|-JSON.DecodeDictionary<uint, float>
	|
	|-RVA: 0xD00310 Offset: 0xCFE910 VA: 0x180D00310
	|-JSON.DecodeDictionary<uint, ushort>
	|
	|-RVA: 0xD006A0 Offset: 0xCFECA0 VA: 0x180D006A0
	|-JSON.DecodeDictionary<uint, uint>
	|
	|-RVA: 0xD00A30 Offset: 0xCFF030 VA: 0x180D00A30
	|-JSON.DecodeDictionary<uint, ulong>
	|
	|-RVA: 0xD00DC0 Offset: 0xCFF3C0 VA: 0x180D00DC0
	|-JSON.DecodeDictionary<ulong, bool>
	|
	|-RVA: 0xD01150 Offset: 0xCFF750 VA: 0x180D01150
	|-JSON.DecodeDictionary<ulong, Decimal>
	|
	|-RVA: 0xD014E0 Offset: 0xCFFAE0 VA: 0x180D014E0
	|-JSON.DecodeDictionary<ulong, double>
	|
	|-RVA: 0xD01870 Offset: 0xCFFE70 VA: 0x180D01870
	|-JSON.DecodeDictionary<ulong, short>
	|
	|-RVA: 0xD01C00 Offset: 0xD00200 VA: 0x180D01C00
	|-JSON.DecodeDictionary<ulong, int>
	|
	|-RVA: 0xD01F90 Offset: 0xD00590 VA: 0x180D01F90
	|-JSON.DecodeDictionary<ulong, long>
	|
	|-RVA: 0xD02320 Offset: 0xD00920 VA: 0x180D02320
	|-JSON.DecodeDictionary<ulong, object>
	|
	|-RVA: 0xD026B0 Offset: 0xD00CB0 VA: 0x180D026B0
	|-JSON.DecodeDictionary<ulong, float>
	|
	|-RVA: 0xD02A40 Offset: 0xD01040 VA: 0x180D02A40
	|-JSON.DecodeDictionary<ulong, ushort>
	|
	|-RVA: 0xD02DD0 Offset: 0xD013D0 VA: 0x180D02DD0
	|-JSON.DecodeDictionary<ulong, uint>
	|
	|-RVA: 0xD03160 Offset: 0xD01760 VA: 0x180D03160
	|-JSON.DecodeDictionary<ulong, ulong>
	*/

	[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	private static T[] DecodeArray<T>(Variant data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A39EF0 Offset: 0x1A384F0 VA: 0x181A39EF0
	|-JSON.DecodeArray<bool>
	|
	|-RVA: 0x1A3A110 Offset: 0x1A38710 VA: 0x181A3A110
	|-JSON.DecodeArray<Decimal>
	|
	|-RVA: 0x1A3A350 Offset: 0x1A38950 VA: 0x181A3A350
	|-JSON.DecodeArray<double>
	|
	|-RVA: 0x1A3A580 Offset: 0x1A38B80 VA: 0x181A3A580
	|-JSON.DecodeArray<short>
	|
	|-RVA: 0x1A3A7A0 Offset: 0x1A38DA0 VA: 0x181A3A7A0
	|-JSON.DecodeArray<int>
	|
	|-RVA: 0x1A3A9C0 Offset: 0x1A38FC0 VA: 0x181A3A9C0
	|-JSON.DecodeArray<long>
	|
	|-RVA: 0x1A3ABE0 Offset: 0x1A391E0 VA: 0x181A3ABE0
	|-JSON.DecodeArray<object>
	|
	|-RVA: 0x1A3ADF0 Offset: 0x1A393F0 VA: 0x181A3ADF0
	|-JSON.DecodeArray<float>
	|
	|-RVA: 0x1A3B020 Offset: 0x1A39620 VA: 0x181A3B020
	|-JSON.DecodeArray<ushort>
	|
	|-RVA: 0x1A3B240 Offset: 0x1A39840 VA: 0x181A3B240
	|-JSON.DecodeArray<uint>
	|
	|-RVA: 0x1A3B460 Offset: 0x1A39A60 VA: 0x181A3B460
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
	// RVA: 0x87AB30 Offset: 0x879130 VA: 0x18087AB30
	private static void SupportValueTypesForAOT() { }

	// RVA: 0x87AC00 Offset: 0x879200 VA: 0x18087AC00
	private static void .cctor() { }

}

