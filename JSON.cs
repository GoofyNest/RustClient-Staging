public static class JsonUtility // TypeDefIndex: 4525
{
// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0xE7DF0 Offset: 0xE71F0 VA: 0x1800E7DF0
public static class JsonUtility // TypeDefIndex: 4525
	// Methods

	[ThreadSafeAttribute] // RVA: 0xE7F30 Offset: 0xE7330 VA: 0x1800E7F30
	[FreeFunctionAttribute] // RVA: 0xE7F30 Offset: 0xE7330 VA: 0x1800E7F30
	// RVA: 0x2323230 Offset: 0x2321830 VA: 0x182323230
	private static object FromJsonInternal(string json, object objectToOverwrite, Type type) { }

	// RVA: -1 Offset: -1
	public static T FromJson<T>(string json) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B8440 Offset: 0x15B6A40 VA: 0x1815B8440
	|-JsonUtility.FromJson<RandomUsernames.DataFile>
	|-JsonUtility.FromJson<object>
	*/

	// RVA: 0x2323290 Offset: 0x2321890 VA: 0x182323290
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

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 4
	public virtual JSONNode get_Item(int aIndex) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 5
	public virtual JSONNode get_Item(string aKey) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	public virtual void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x13C9C50 Offset: 0x13C8250 VA: 0x1813C9C50 Slot: 7
	public virtual string get_Value() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 8
	public virtual int get_Count() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	public virtual bool get_IsNumber() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 10
	public virtual bool get_IsBoolean() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 11
	public virtual bool get_IsArray() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	public virtual void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x13C8580 Offset: 0x13C6B80 VA: 0x1813C8580 Slot: 13
	public virtual void Add(JSONNode aItem) { }

	[IteratorStateMachineAttribute] // RVA: 0xBB950 Offset: 0xBAD50 VA: 0x1800BB950
	// RVA: 0x13C9B60 Offset: 0x13C8160 VA: 0x1813C9B60 Slot: 14
	public virtual IEnumerable<JSONNode> get_Children() { }

	// RVA: 0x13C97B0 Offset: 0x13C7DB0 VA: 0x1813C97B0 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract JSONNode.Enumerator GetEnumerator();

	// RVA: 0x13C9990 Offset: 0x13C7F90 VA: 0x1813C9990 Slot: 17
	public virtual double get_AsDouble() { }

	// RVA: 0x13C9A70 Offset: 0x13C8070 VA: 0x1813C9A70 Slot: 18
	public virtual int get_AsInt() { }

	// RVA: 0x13C98D0 Offset: 0x13C7ED0 VA: 0x1813C98D0 Slot: 19
	public virtual bool get_AsBool() { }

	// RVA: 0x13C9A90 Offset: 0x13C8090 VA: 0x1813C9A90 Slot: 20
	public virtual long get_AsLong() { }

	// RVA: 0x13C9850 Offset: 0x13C7E50 VA: 0x1813C9850 Slot: 21
	public virtual JSONArray get_AsArray() { }

	// RVA: 0x13C9AE0 Offset: 0x13C80E0 VA: 0x1813C9AE0 Slot: 22
	public virtual JSONObject get_AsObject() { }

	// RVA: 0x13C9E80 Offset: 0x13C8480 VA: 0x1813C9E80
	public static JSONNode op_Implicit(string s) { }

	// RVA: 0x13C9EE0 Offset: 0x13C84E0 VA: 0x1813C9EE0
	public static string op_Implicit(JSONNode d) { }

	// RVA: 0x13C9F30 Offset: 0x13C8530 VA: 0x1813C9F30
	public static JSONNode op_Implicit(double n) { }

	// RVA: 0x13C9E20 Offset: 0x13C8420 VA: 0x1813C9E20
	public static JSONNode op_Implicit(bool b) { }

	// RVA: 0x13C9C80 Offset: 0x13C8280 VA: 0x1813C9C80
	public static bool op_Equality(JSONNode a, object b) { }

	// RVA: 0x13C9F90 Offset: 0x13C8590 VA: 0x1813C9F90
	public static bool op_Inequality(JSONNode a, object b) { }

	// RVA: 0xAE6170 Offset: 0xAE4770 VA: 0x180AE6170 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCCECC0 Offset: 0xCCD2C0 VA: 0x180CCECC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13C9BC0 Offset: 0x13C81C0 VA: 0x1813C9BC0
	internal static StringBuilder get_EscapeBuilder() { }

	// RVA: 0x13C88D0 Offset: 0x13C6ED0 VA: 0x1813C88D0
	internal static string Escape(string aText) { }

	// RVA: 0x13C8D30 Offset: 0x13C7330 VA: 0x1813C8D30
	private static JSONNode ParseElement(string token, bool quoted) { }

	// RVA: 0x13C8F90 Offset: 0x13C7590 VA: 0x1813C8F90
	public static JSONNode Parse(string aJSON) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void SerializeBinary(BinaryWriter aWriter);

	// RVA: 0x13C9730 Offset: 0x13C7D30 VA: 0x1813C9730
	public void SaveToBinaryStream(Stream aData) { }

	// RVA: 0x13C9590 Offset: 0x13C7B90 VA: 0x1813C9590
	public string SaveToBinaryBase64() { }

	// RVA: 0x13C85E0 Offset: 0x13C6BE0 VA: 0x1813C85E0
	public static JSONNode DeserializeBinary(BinaryReader aReader) { }

	// RVA: 0x13C8C40 Offset: 0x13C7240 VA: 0x1813C8C40
	public static JSONNode LoadFromBinaryStream(Stream aData) { }

	// RVA: 0x13C8B90 Offset: 0x13C7190 VA: 0x1813C8B90
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

	// RVA: 0x1EF3F0 Offset: 0x1EE7F0 VA: 0x1801EF3F0
	public void .ctor(List.Enumerator<JSONNode> aArrayEnum) { }

	// RVA: 0x1EF430 Offset: 0x1EE830 VA: 0x1801EF430
	public void .ctor(Dictionary.Enumerator<string, JSONNode> aDictEnum) { }

	// RVA: 0x1EF480 Offset: 0x1EE880 VA: 0x1801EF480
	public KeyValuePair<string, JSONNode> get_Current() { }

	// RVA: 0x1EF380 Offset: 0x1EE780 VA: 0x1801EF380
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
	// RVA: 0xD88200 Offset: 0xD86800 VA: 0x180D88200
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13CEB40 Offset: 0x13CD140 VA: 0x1813CEB40 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CEBE0 Offset: 0x13CD1E0 VA: 0x1813CEBE0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CEB50 Offset: 0x13CD150 VA: 0x1813CEB50 Slot: 4
	private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<GameAnalyticsSDK.Net.Utilities.JSONNode>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CEB50 Offset: 0x13CD150 VA: 0x1813CEB50 Slot: 5
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

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 11
	public override bool get_IsArray() { }

	// RVA: 0x13C7630 Offset: 0x13C5C30 VA: 0x1813C7630 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x13C7AB0 Offset: 0x13C60B0 VA: 0x1813C7AB0 Slot: 4
	public override JSONNode get_Item(int aIndex) { }

	// RVA: 0x13C7A40 Offset: 0x13C6040 VA: 0x1813C7A40 Slot: 5
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x13C7B70 Offset: 0x13C6170 VA: 0x1813C7B70 Slot: 6
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x13C7A00 Offset: 0x13C6000 VA: 0x1813C7A00 Slot: 8
	public override int get_Count() { }

	// RVA: 0x13C75A0 Offset: 0x13C5BA0 VA: 0x1813C75A0 Slot: 12
	public override void Add(string aKey, JSONNode aItem) { }

	[IteratorStateMachineAttribute] // RVA: 0xBBEB0 Offset: 0xBB2B0 VA: 0x1800BBEB0
	// RVA: 0x13C7990 Offset: 0x13C5F90 VA: 0x1813C7990 Slot: 14
	public override IEnumerable<JSONNode> get_Children() { }

	// RVA: 0x13C77C0 Offset: 0x13C5DC0 VA: 0x1813C77C0 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13C76C0 Offset: 0x13C5CC0 VA: 0x1813C76C0 Slot: 23
	public override void SerializeBinary(BinaryWriter aWriter) { }

	// RVA: 0x13C7920 Offset: 0x13C5F20 VA: 0x1813C7920
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
	// RVA: 0xD88200 Offset: 0xD86800 VA: 0x180D88200
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CE720 Offset: 0x13CCD20 VA: 0x1813CE720 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13CE4D0 Offset: 0x13CCAD0 VA: 0x1813CE4D0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x13CE7C0 Offset: 0x13CCDC0 VA: 0x1813CE7C0
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CE6D0 Offset: 0x13CCCD0 VA: 0x1813CE6D0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CE630 Offset: 0x13CCC30 VA: 0x1813CE630 Slot: 4
	private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<GameAnalyticsSDK.Net.Utilities.JSONNode>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CE630 Offset: 0x13CCC30 VA: 0x1813CE630 Slot: 5
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

	// RVA: 0x13CA8C0 Offset: 0x13C8EC0 VA: 0x1813CA8C0 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x13CAFA0 Offset: 0x13C95A0 VA: 0x1813CAFA0 Slot: 5
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x13CB070 Offset: 0x13C9670 VA: 0x1813CB070 Slot: 6
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x13CAF10 Offset: 0x13C9510 VA: 0x1813CAF10 Slot: 4
	public override JSONNode get_Item(int aIndex) { }

	// RVA: 0x13CAEC0 Offset: 0x13C94C0 VA: 0x1813CAEC0 Slot: 8
	public override int get_Count() { }

	// RVA: 0x13CA770 Offset: 0x13C8D70 VA: 0x1813CA770 Slot: 12
	public override void Add(string aKey, JSONNode aItem) { }

	[IteratorStateMachineAttribute] // RVA: 0xBDD90 Offset: 0xBD190 VA: 0x1800BDD90
	// RVA: 0x13CAE50 Offset: 0x13C9450 VA: 0x1813CAE50 Slot: 14
	public override IEnumerable<JSONNode> get_Children() { }

	// RVA: 0x13CAB40 Offset: 0x13C9140 VA: 0x1813CAB40 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13CA970 Offset: 0x13C8F70 VA: 0x1813CA970 Slot: 23
	public override void SerializeBinary(BinaryWriter aWriter) { }

	// RVA: 0x13CADE0 Offset: 0x13C93E0 VA: 0x1813CADE0
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
	// RVA: 0xD88200 Offset: 0xD86800 VA: 0x180D88200
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CEA60 Offset: 0x13CD060 VA: 0x1813CEA60 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13CE800 Offset: 0x13CCE00 VA: 0x1813CE800 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x13CEB00 Offset: 0x13CD100 VA: 0x1813CEB00
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CEA10 Offset: 0x13CD010 VA: 0x1813CEA10 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CE970 Offset: 0x13CCF70 VA: 0x1813CE970 Slot: 4
	private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<GameAnalyticsSDK.Net.Utilities.JSONNode>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13CE970 Offset: 0x13CCF70 VA: 0x1813CE970 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

internal class JSONString : JSONNode // TypeDefIndex: 5647
{	// Fields
	private string m_Data; // 0x10

	// Properties
	public override string Value { get; }

	// Methods

	// RVA: 0x13C7C90 Offset: 0x13C6290 VA: 0x1813C7C90 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 7
	public override string get_Value() { }

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	public void .ctor(string aData) { }

	// RVA: 0x13CB350 Offset: 0x13C9950 VA: 0x1813CB350 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13CB150 Offset: 0x13C9750 VA: 0x1813CB150 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xDE2D10 Offset: 0xDE1310 VA: 0x180DE2D10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13CB2F0 Offset: 0x13C98F0 VA: 0x1813CB2F0 Slot: 23
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

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 9
	public override bool get_IsNumber() { }

	// RVA: 0x13C7C90 Offset: 0x13C6290 VA: 0x1813C7C90 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x13CA710 Offset: 0x13C8D10 VA: 0x1813CA710 Slot: 7
	public override string get_Value() { }

	// RVA: 0xB3C020 Offset: 0xB3A620 VA: 0x180B3C020 Slot: 17
	public override double get_AsDouble() { }

	// RVA: 0x13CA700 Offset: 0x13C8D00 VA: 0x1813CA700 Slot: 20
	public override long get_AsLong() { }

	// RVA: 0x13CA6D0 Offset: 0x13C8CD0 VA: 0x1813CA6D0
	public void .ctor(double aData) { }

	// RVA: 0x13CA690 Offset: 0x13C8C90 VA: 0x1813CA690 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13CA510 Offset: 0x13C8B10 VA: 0x1813CA510
	private static bool IsNumeric(object value) { }

	// RVA: 0x13CA240 Offset: 0x13C8840 VA: 0x1813CA240 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13CA500 Offset: 0x13C8B00 VA: 0x1813CA500 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13CA630 Offset: 0x13C8C30 VA: 0x1813CA630 Slot: 23
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

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 10
	public override bool get_IsBoolean() { }

	// RVA: 0x13C7C90 Offset: 0x13C6290 VA: 0x1813C7C90 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x13C7D80 Offset: 0x13C6380 VA: 0x1813C7D80 Slot: 7
	public override string get_Value() { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90 Slot: 19
	public override bool get_AsBool() { }

	// RVA: 0xF89460 Offset: 0xF87A60 VA: 0x180F89460
	public void .ctor(bool aData) { }

	// RVA: 0x13C7D20 Offset: 0x13C6320 VA: 0x1813C7D20 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13C7C00 Offset: 0x13C6200 VA: 0x1813C7C00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13C7CB0 Offset: 0x13C62B0 VA: 0x1813C7CB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13C7CC0 Offset: 0x13C62C0 VA: 0x1813C7CC0 Slot: 23
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

	// RVA: 0x13C9FB0 Offset: 0x13C85B0 VA: 0x1813C9FB0
	public static JSONNull CreateOrGet() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x13C7C90 Offset: 0x13C6290 VA: 0x1813C7C90 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x13CA210 Offset: 0x13C8810 VA: 0x1813CA210 Slot: 7
	public override string get_Value() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 19
	public override bool get_AsBool() { }

	// RVA: 0x13CA060 Offset: 0x13C8660 VA: 0x1813CA060 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13CA150 Offset: 0x13C8750 VA: 0x1813CA150 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13CA120 Offset: 0x13C8720 VA: 0x1813CA120 Slot: 23
	public override void SerializeBinary(BinaryWriter aWriter) { }

	// RVA: 0x13CA1A0 Offset: 0x13C87A0 VA: 0x1813CA1A0
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

	// RVA: 0x13C7C90 Offset: 0x13C6290 VA: 0x1813C7C90 Slot: 16
	public override JSONNode.Enumerator GetEnumerator() { }

	// RVA: 0x13C7FC0 Offset: 0x13C65C0 VA: 0x1813C7FC0
	public void .ctor(JSONNode aNode) { }

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	public void .ctor(JSONNode aNode, string aKey) { }

	// RVA: -1 Offset: -1
	private T Set<T>(T aVal) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CE8D0 Offset: 0x5CCED0 VA: 0x1805CE8D0
	|-JSONLazyCreator.Set<JSONArray>
	|-JSONLazyCreator.Set<JSONBool>
	|-JSONLazyCreator.Set<JSONNumber>
	|-JSONLazyCreator.Set<JSONObject>
	|-JSONLazyCreator.Set<JSONString>
	|-JSONLazyCreator.Set<object>
	*/

	// RVA: 0x13C8420 Offset: 0x13C6A20 VA: 0x1813C8420 Slot: 4
	public override JSONNode get_Item(int aIndex) { }

	// RVA: 0x13C83A0 Offset: 0x13C69A0 VA: 0x1813C83A0 Slot: 5
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x13C8490 Offset: 0x13C6A90 VA: 0x1813C8490 Slot: 6
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x13C7E80 Offset: 0x13C6480 VA: 0x1813C7E80 Slot: 13
	public override void Add(JSONNode aItem) { }

	// RVA: 0x13C7D90 Offset: 0x13C6390 VA: 0x1813C7D90 Slot: 12
	public override void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x13C7F60 Offset: 0x13C6560 VA: 0x1813C7F60 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13C81A0 Offset: 0x13C67A0 VA: 0x1813C81A0 Slot: 18
	public override int get_AsInt() { }

	// RVA: 0x13C8130 Offset: 0x13C6730 VA: 0x1813C8130 Slot: 17
	public override double get_AsDouble() { }

	// RVA: 0x13C8210 Offset: 0x13C6810 VA: 0x1813C8210 Slot: 20
	public override long get_AsLong() { }

	// RVA: 0x13C80C0 Offset: 0x13C66C0 VA: 0x1813C80C0 Slot: 19
	public override bool get_AsBool() { }

	// RVA: 0x13C8010 Offset: 0x13C6610 VA: 0x1813C8010 Slot: 21
	public override JSONArray get_AsArray() { }

	// RVA: 0x13C82F0 Offset: 0x13C68F0 VA: 0x1813C82F0 Slot: 22
	public override JSONObject get_AsObject() { }

	// RVA: 0x13C7F70 Offset: 0x13C6570 VA: 0x1813C7F70 Slot: 15
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 23
	public override void SerializeBinary(BinaryWriter aWriter) { }

}

internal static class JSON // TypeDefIndex: 5652
{	// Methods

	// RVA: 0x13CB3C0 Offset: 0x13C99C0 VA: 0x1813CB3C0
	public static JSONNode Parse(string aJSON) { }

}

public sealed class JsonConstructorAttribute : Attribute // TypeDefIndex: 5872
{	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

}

public class JsonException : Exception // TypeDefIndex: 5874
{	// Methods

	// RVA: 0xF8BFA0 Offset: 0xF8A5A0 VA: 0x180F8BFA0
	public void .ctor() { }

	// RVA: 0xF8C080 Offset: 0xF8A680 VA: 0x180F8C080
	public void .ctor(string message) { }

	// RVA: 0xF8C000 Offset: 0xF8A600 VA: 0x180F8C000
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0xF8BF20 Offset: 0xF8A520 VA: 0x180F8BF20
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
	// RVA: 0xF8C110 Offset: 0xF8A710 VA: 0x180F8C110
	public bool get_ReadData() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8C120 Offset: 0xF8A720 VA: 0x180F8C120
	public void set_ReadData(bool value) { }

	// RVA: 0xF8C0F0 Offset: 0xF8A6F0 VA: 0x180F8C0F0
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

	// RVA: 0x141D90 Offset: 0x141190 VA: 0x180141D90
	public void .ctor(JsonContainerType type) { }

	// RVA: 0x141D70 Offset: 0x141170 VA: 0x180141D70
	internal int CalculateLength() { }

	// RVA: 0x141D80 Offset: 0x141180 VA: 0x180141D80
	internal void WriteTo(StringBuilder sb) { }

	// RVA: 0x4BCC30 Offset: 0x4BB230 VA: 0x1804BCC30
	internal static bool TypeHasIndex(JsonContainerType type) { }

	// RVA: 0xF8C130 Offset: 0xF8A730 VA: 0x180F8C130
	internal static string BuildPath(List<JsonPosition> positions, Nullable<JsonPosition> currentPosition) { }

	// RVA: 0xF8C550 Offset: 0xF8AB50 VA: 0x180F8C550
	internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message) { }

	// RVA: 0xF8C890 Offset: 0xF8AE90 VA: 0x180F8C890
	private static void .cctor() { }

}

public sealed class JsonRequiredAttribute : Attribute // TypeDefIndex: 5878
{	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

}

public sealed class JsonArrayAttribute : JsonContainerAttribute // TypeDefIndex: 5884
{	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
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
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public Type get_ItemConverterType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public object[] get_ItemConverterParameters() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
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

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public Type get_ConverterType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public object[] get_ConverterParameters() { }

	// RVA: 0xF8BE50 Offset: 0xF8A450 VA: 0x180F8BE50
	public void .ctor(Type converterType) { }

}

public sealed class JsonObjectAttribute : JsonContainerAttribute // TypeDefIndex: 5888
{	// Fields
	private MemberSerialization _memberSerialization; // 0x38
	internal Nullable<Required> _itemRequired; // 0x3C

	// Properties
	public MemberSerialization MemberSerialization { get; }

	// Methods

	// RVA: 0x6BB9E0 Offset: 0x6B9FE0 VA: 0x1806BB9E0
	public MemberSerialization get_MemberSerialization() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
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

	// RVA: 0xF91550 Offset: 0xF8FB50 VA: 0x180F91550
	public ReferenceLoopHandling get_ReferenceLoopHandling() { }

	// RVA: 0xF91450 Offset: 0xF8FA50 VA: 0x180F91450
	public MissingMemberHandling get_MissingMemberHandling() { }

	// RVA: 0xF914D0 Offset: 0xF8FAD0 VA: 0x180F914D0
	public ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0xF91490 Offset: 0xF8FA90 VA: 0x180F91490
	public NullValueHandling get_NullValueHandling() { }

	// RVA: 0xF913D0 Offset: 0xF8F9D0 VA: 0x180F913D0
	public DefaultValueHandling get_DefaultValueHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA01E0 Offset: 0xD9E7E0 VA: 0x180DA01E0
	public IList<JsonConverter> get_Converters() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD357D0 Offset: 0xD33DD0 VA: 0x180D357D0
	public void set_Converters(IList<JsonConverter> value) { }

	// RVA: 0xF91510 Offset: 0xF8FB10 VA: 0x180F91510
	public PreserveReferencesHandling get_PreserveReferencesHandling() { }

	// RVA: 0xF915D0 Offset: 0xF8FBD0 VA: 0x180F915D0
	public TypeNameHandling get_TypeNameHandling() { }

	// RVA: 0xF91410 Offset: 0xF8FA10 VA: 0x180F91410
	public MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0xF91590 Offset: 0xF8FB90 VA: 0x180F91590
	public FormatterAssemblyStyle get_TypeNameAssemblyFormat() { }

	// RVA: 0xF912F0 Offset: 0xF8F8F0 VA: 0x180F912F0
	public ConstructorHandling get_ConstructorHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4EF330 Offset: 0x4ED930 VA: 0x1804EF330
	public IContractResolver get_ContractResolver() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D970 Offset: 0x88BF70 VA: 0x18088D970
	public IEqualityComparer get_EqualityComparer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC742E0 Offset: 0xC728E0 VA: 0x180C742E0
	public Func<IReferenceResolver> get_ReferenceResolverProvider() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB0F550 Offset: 0xB0DB50 VA: 0x180B0F550
	public ITraceWriter get_TraceWriter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2B0D0 Offset: 0xA296D0 VA: 0x180A2B0D0
	public SerializationBinder get_Binder() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC83900 Offset: 0xC81F00 VA: 0x180C83900
	public EventHandler<ErrorEventArgs> get_Error() { }

	// RVA: 0xF91330 Offset: 0xF8F930 VA: 0x180F91330
	public StreamingContext get_Context() { }

	// RVA: 0xF91100 Offset: 0xF8F700 VA: 0x180F91100
	private static void .cctor() { }

	// RVA: 0xF91180 Offset: 0xF8F780 VA: 0x180F91180
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

	// RVA: 0xF9C160 Offset: 0xF9A760 VA: 0x180F9C160
	public void .ctor(TextReader reader) { }

	// RVA: 0xF94580 Offset: 0xF92B80 VA: 0x180F94580
	private void EnsureBufferNotEmpty() { }

	// RVA: 0xF94DA0 Offset: 0xF933A0 VA: 0x180F94DA0
	private void OnNewLine(int pos) { }

	// RVA: 0xF97690 Offset: 0xF95C90 VA: 0x180F97690
	private void ParseString(char quote, ReadType readType) { }

	// RVA: 0xBB46F0 Offset: 0xBB2CF0 VA: 0x180BB46F0
	private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count) { }

	// RVA: 0xF9BF90 Offset: 0xF9A590 VA: 0x180F9BF90
	private void ShiftBufferIfNeeded() { }

	// RVA: 0xF9A270 Offset: 0xF98870 VA: 0x180F9A270
	private int ReadData(bool append) { }

	// RVA: 0xF99FE0 Offset: 0xF985E0 VA: 0x180F99FE0
	private int ReadData(bool append, int charsRequired) { }

	// RVA: 0xF94660 Offset: 0xF92C60 VA: 0x180F94660
	private bool EnsureChars(int relativePosition, bool append) { }

	// RVA: 0xF99F50 Offset: 0xF98550 VA: 0x180F99F50
	private bool ReadChars(int relativePosition, bool append) { }

	// RVA: 0xF9BCA0 Offset: 0xF9A2A0 VA: 0x180F9BCA0 Slot: 10
	public override bool Read() { }

	// RVA: 0xF99E60 Offset: 0xF98460 VA: 0x180F99E60 Slot: 11
	public override Nullable<int> ReadAsInt32() { }

	// RVA: 0xF99C80 Offset: 0xF98280 VA: 0x180F99C80 Slot: 17
	public override Nullable<DateTime> ReadAsDateTime() { }

	// RVA: 0xF99EF0 Offset: 0xF984F0 VA: 0x180F99EF0 Slot: 12
	public override string ReadAsString() { }

	// RVA: 0xF99560 Offset: 0xF97B60 VA: 0x180F99560 Slot: 13
	public override byte[] ReadAsBytes() { }

	// RVA: 0xF9B330 Offset: 0xF99930 VA: 0x180F9B330
	private object ReadStringValue(ReadType readType) { }

	// RVA: 0xF94310 Offset: 0xF92910 VA: 0x180F94310
	private JsonReaderException CreateUnexpectedCharacterException(char c) { }

	// RVA: 0xF98C30 Offset: 0xF97230 VA: 0x180F98C30 Slot: 15
	public override Nullable<bool> ReadAsBoolean() { }

	// RVA: 0xF98BC0 Offset: 0xF971C0 VA: 0x180F98BC0
	private void ProcessValueComma() { }

	// RVA: 0xF9A6A0 Offset: 0xF98CA0 VA: 0x180F9A6A0
	private object ReadNumberValue(ReadType readType) { }

	// RVA: 0xF99BE0 Offset: 0xF981E0 VA: 0x180F99BE0 Slot: 18
	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0xF99D20 Offset: 0xF98320 VA: 0x180F99D20 Slot: 16
	public override Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0xF99DC0 Offset: 0xF983C0 VA: 0x180F99DC0 Slot: 14
	public override Nullable<double> ReadAsDouble() { }

	// RVA: 0xF94700 Offset: 0xF92D00 VA: 0x180F94700
	private void HandleNull() { }

	// RVA: 0xF9A280 Offset: 0xF98880 VA: 0x180F9A280
	private void ReadFinished() { }

	// RVA: 0xF9A410 Offset: 0xF98A10 VA: 0x180F9A410
	private bool ReadNullChar() { }

	// RVA: 0xF945F0 Offset: 0xF92BF0 VA: 0x180F945F0
	private void EnsureBuffer() { }

	// RVA: 0xF9AC80 Offset: 0xF99280 VA: 0x180F9AC80
	private void ReadStringIntoBuffer(char quote) { }

	// RVA: 0xF9C0E0 Offset: 0xF9A6E0 VA: 0x180F9C0E0
	private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition) { }

	// RVA: 0xF97CF0 Offset: 0xF962F0 VA: 0x180F97CF0
	private char ParseUnicode() { }

	// RVA: 0xF9A460 Offset: 0xF98A60 VA: 0x180F9A460
	private void ReadNumberIntoBuffer() { }

	// RVA: 0xF94250 Offset: 0xF92850 VA: 0x180F94250
	private void ClearRecentString() { }

	// RVA: 0xF97010 Offset: 0xF95610 VA: 0x180F97010
	private bool ParsePostValue() { }

	// RVA: 0xF96E40 Offset: 0xF95440 VA: 0x180F96E40
	private bool ParseObject() { }

	// RVA: 0xF97350 Offset: 0xF95950 VA: 0x180F97350
	private bool ParseProperty() { }

	// RVA: 0xF9C070 Offset: 0xF9A670 VA: 0x180F9C070
	private bool ValidIdentifierChar(char value) { }

	// RVA: 0xF97DE0 Offset: 0xF963E0 VA: 0x180F97DE0
	private void ParseUnquotedProperty() { }

	// RVA: 0xF98030 Offset: 0xF96630 VA: 0x180F98030
	private bool ParseValue() { }

	// RVA: 0xF98BA0 Offset: 0xF971A0 VA: 0x180F98BA0
	private void ProcessLineFeed() { }

	// RVA: 0xF98AB0 Offset: 0xF970B0 VA: 0x180F98AB0
	private void ProcessCarriageReturn(bool append) { }

	// RVA: 0xF943C0 Offset: 0xF929C0 VA: 0x180F943C0
	private bool EatWhitespace(bool oneOrMore) { }

	// RVA: 0xF951A0 Offset: 0xF937A0 VA: 0x180F951A0
	private void ParseConstructor() { }

	// RVA: 0xF95E30 Offset: 0xF94430 VA: 0x180F95E30
	private void ParseNumber(ReadType readType) { }

	// RVA: 0xF94DB0 Offset: 0xF933B0 VA: 0x180F94DB0
	private void ParseComment(bool setToken) { }

	// RVA: 0xF94510 Offset: 0xF92B10 VA: 0x180F94510
	private void EndComment(bool setToken, int initialPosition, int endPosition) { }

	// RVA: 0xF94C90 Offset: 0xF93290 VA: 0x180F94C90
	private bool MatchValue(string value) { }

	// RVA: 0xF94980 Offset: 0xF92F80 VA: 0x180F94980
	private bool MatchValueWithTrailingSeparator(string value) { }

	// RVA: 0xF94830 Offset: 0xF92E30 VA: 0x180F94830
	private bool IsSeparator(char c) { }

	// RVA: 0xF97AE0 Offset: 0xF960E0 VA: 0x180F97AE0
	private void ParseTrue() { }

	// RVA: 0xF956B0 Offset: 0xF93CB0 VA: 0x180F956B0
	private void ParseNull() { }

	// RVA: 0xF97BF0 Offset: 0xF961F0 VA: 0x180F97BF0
	private void ParseUndefined() { }

	// RVA: 0xF955A0 Offset: 0xF93BA0 VA: 0x180F955A0
	private void ParseFalse() { }

	// RVA: 0xF959D0 Offset: 0xF93FD0 VA: 0x180F959D0
	private object ParseNumberNegativeInfinity(ReadType readType) { }

	// RVA: 0xF95C00 Offset: 0xF94200 VA: 0x180F95C00
	private object ParseNumberPositiveInfinity(ReadType readType) { }

	// RVA: 0xF957A0 Offset: 0xF93DA0 VA: 0x180F957A0
	private object ParseNumberNaN(ReadType readType) { }

	// RVA: 0xF94270 Offset: 0xF92870 VA: 0x180F94270 Slot: 20
	public override void Close() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 21
	public bool HasLineInfo() { }

	// RVA: 0xF9C210 Offset: 0xF9A810 VA: 0x180F9C210 Slot: 22
	public int get_LineNumber() { }

	// RVA: 0xF9C260 Offset: 0xF9A860 VA: 0x180F9C260 Slot: 23
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
	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public Type get_ItemConverterType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public object[] get_ItemConverterParameters() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public string get_PropertyName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	public void set_PropertyName(string value) { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xF8C980 Offset: 0xF8AF80 VA: 0x180F8C980
	public void .ctor(string propertyName) { }

}

public sealed class JsonIgnoreAttribute : Attribute // TypeDefIndex: 5896
{	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
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

	// RVA: 0xE48500 Offset: 0xE46B00 VA: 0x180E48500
	private Base64Encoder get_Base64Encoder() { }

	// RVA: 0xE48580 Offset: 0xE46B80 VA: 0x180E48580
	public char get_QuoteChar() { }

	// RVA: 0xE48420 Offset: 0xE46A20 VA: 0x180E48420
	public void .ctor(TextWriter textWriter) { }

	// RVA: 0xE46770 Offset: 0xE44D70 VA: 0x180E46770 Slot: 6
	public override void Close() { }

	// RVA: 0xE47220 Offset: 0xE45820 VA: 0x180E47220 Slot: 7
	public override void WriteStartObject() { }

	// RVA: 0xE47120 Offset: 0xE45720 VA: 0x180E47120 Slot: 9
	public override void WriteStartArray() { }

	// RVA: 0xE47170 Offset: 0xE45770 VA: 0x180E47170 Slot: 11
	public override void WriteStartConstructor(string name) { }

	// RVA: 0xE469B0 Offset: 0xE44FB0 VA: 0x180E469B0 Slot: 17
	protected override void WriteEnd(JsonToken token) { }

	// RVA: 0xE47080 Offset: 0xE45680 VA: 0x180E47080 Slot: 13
	public override void WritePropertyName(string name) { }

	// RVA: 0xE46F90 Offset: 0xE45590 VA: 0x180E46F90 Slot: 14
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0xE46870 Offset: 0xE44E70 VA: 0x180E46870 Slot: 5
	internal override void OnStringEscapeHandlingChanged() { }

	// RVA: 0xE46880 Offset: 0xE44E80 VA: 0x180E46880
	private void UpdateCharEscapeFlags() { }

	// RVA: 0xE46BC0 Offset: 0xE451C0 VA: 0x180E46BC0 Slot: 18
	protected override void WriteIndent() { }

	// RVA: 0xE47310 Offset: 0xE45910 VA: 0x180E47310 Slot: 19
	protected override void WriteValueDelimiter() { }

	// RVA: 0xE46B90 Offset: 0xE45190 VA: 0x180E46B90 Slot: 20
	protected override void WriteIndentSpace() { }

	// RVA: 0xE470F0 Offset: 0xE456F0 VA: 0x180E470F0
	private void WriteValueInternal(string value, JsonToken token) { }

	// RVA: 0xE3B9B0 Offset: 0xE39FB0 VA: 0x180E3B9B0 Slot: 62
	public override void WriteValue(object value) { }

	// RVA: 0xE46EF0 Offset: 0xE454F0 VA: 0x180E46EF0 Slot: 21
	public override void WriteNull() { }

	// RVA: 0xE47270 Offset: 0xE45870 VA: 0x180E47270 Slot: 22
	public override void WriteUndefined() { }

	// RVA: 0xE470F0 Offset: 0xE456F0 VA: 0x180E470F0 Slot: 23
	public override void WriteRaw(string json) { }

	// RVA: 0xE481D0 Offset: 0xE467D0 VA: 0x180E481D0 Slot: 25
	public override void WriteValue(string value) { }

	// RVA: 0xE46A90 Offset: 0xE45090 VA: 0x180E46A90
	private void WriteEscapedString(string value, bool quote) { }

	// RVA: 0xE48190 Offset: 0xE46790 VA: 0x180E48190 Slot: 26
	public override void WriteValue(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE47F00 Offset: 0xE46500 VA: 0x180E47F00 Slot: 27
	public override void WriteValue(uint value) { }

	// RVA: 0xE480D0 Offset: 0xE466D0 VA: 0x180E480D0 Slot: 28
	public override void WriteValue(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE475C0 Offset: 0xE45BC0 VA: 0x180E475C0 Slot: 29
	public override void WriteValue(ulong value) { }

	// RVA: 0xE47400 Offset: 0xE45A00 VA: 0x180E47400 Slot: 30
	public override void WriteValue(float value) { }

	// RVA: 0xE474D0 Offset: 0xE45AD0 VA: 0x180E474D0 Slot: 47
	public override void WriteValue(Nullable<float> value) { }

	// RVA: 0xE47600 Offset: 0xE45C00 VA: 0x180E47600 Slot: 31
	public override void WriteValue(double value) { }

	// RVA: 0xE47F40 Offset: 0xE46540 VA: 0x180E47F40 Slot: 48
	public override void WriteValue(Nullable<double> value) { }

	// RVA: 0xE48030 Offset: 0xE46630 VA: 0x180E48030 Slot: 32
	public override void WriteValue(bool value) { }

	// RVA: 0xE47D30 Offset: 0xE46330 VA: 0x180E47D30 Slot: 33
	public override void WriteValue(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE48110 Offset: 0xE46710 VA: 0x180E48110 Slot: 34
	public override void WriteValue(ushort value) { }

	// RVA: 0xE47E60 Offset: 0xE46460 VA: 0x180E47E60 Slot: 35
	public override void WriteValue(char value) { }

	// RVA: 0xE48150 Offset: 0xE46750 VA: 0x180E48150 Slot: 36
	public override void WriteValue(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE483E0 Offset: 0xE469E0 VA: 0x180E483E0 Slot: 37
	public override void WriteValue(sbyte value) { }

	// RVA: 0xE48290 Offset: 0xE46890 VA: 0x180E48290 Slot: 38
	public override void WriteValue(Decimal value) { }

	// RVA: 0xE477B0 Offset: 0xE45DB0 VA: 0x180E477B0 Slot: 39
	public override void WriteValue(DateTime value) { }

	// RVA: 0xE476D0 Offset: 0xE45CD0 VA: 0x180E476D0 Slot: 60
	public override void WriteValue(byte[] value) { }

	// RVA: 0xE47A80 Offset: 0xE46080 VA: 0x180E47A80 Slot: 40
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0xE47D70 Offset: 0xE46370 VA: 0x180E47D70 Slot: 41
	public override void WriteValue(Guid value) { }

	// RVA: 0xE48340 Offset: 0xE46940 VA: 0x180E48340 Slot: 42
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0xE47340 Offset: 0xE45940 VA: 0x180E47340 Slot: 61
	public override void WriteValue(Uri value) { }

	// RVA: 0xE46900 Offset: 0xE44F00 VA: 0x180E46900 Slot: 63
	public override void WriteComment(string text) { }

	// RVA: 0xE46830 Offset: 0xE44E30 VA: 0x180E46830
	private void EnsureWriteBuffer() { }

	// RVA: 0xE46E60 Offset: 0xE45460 VA: 0x180E46E60
	private void WriteIntegerValue(long value) { }

	// RVA: 0xE46D20 Offset: 0xE45320 VA: 0x180E46D20
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
	// RVA: 0x574390 Offset: 0x572990 VA: 0x180574390
	private void set_Path(string value) { }

	// RVA: 0xE487F0 Offset: 0xE46DF0 VA: 0x180E487F0
	public void .ctor() { }

	// RVA: 0xE487D0 Offset: 0xE46DD0 VA: 0x180E487D0
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE48790 Offset: 0xE46D90 VA: 0x180E48790
	internal void .ctor(string message, Exception innerException, string path) { }

	// RVA: 0xE48590 Offset: 0xE46B90 VA: 0x180E48590
	internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex) { }

	// RVA: 0xE486D0 Offset: 0xE46CD0 VA: 0x180E486D0
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
	// RVA: 0xF8CD60 Offset: 0xF8B360 VA: 0x180F8CD60
	private void set_LineNumber(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8CD70 Offset: 0xF8B370 VA: 0x180F8CD70
	private void set_LinePosition(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E3FF0 Offset: 0x4E25F0 VA: 0x1804E3FF0
	private void set_Path(string value) { }

	// RVA: 0xF8BFA0 Offset: 0xF8A5A0 VA: 0x180F8BFA0
	public void .ctor() { }

	// RVA: 0xF8BF20 Offset: 0xF8A520 VA: 0x180F8BF20
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF8CCB0 Offset: 0xF8B2B0 VA: 0x180F8CCB0
	internal void .ctor(string message, Exception innerException, string path, int lineNumber, int linePosition) { }

	// RVA: 0xF8C9B0 Offset: 0xF8AFB0 VA: 0x180F8C9B0
	internal static JsonReaderException Create(JsonReader reader, string message) { }

	// RVA: 0xF8C9C0 Offset: 0xF8AFC0 VA: 0x180F8C9C0
	internal static JsonReaderException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0xF8CB60 Offset: 0xF8B160 VA: 0x180F8CB60
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

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 7
	public virtual bool get_CanRead() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 8
	public virtual bool get_CanWrite() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

public class JsonConverterCollection : Collection<JsonConverter> // TypeDefIndex: 5901
{	// Methods

	// RVA: 0xF8BEE0 Offset: 0xF8A4E0 VA: 0x180F8BEE0
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

	// RVA: 0x79C630 Offset: 0x79AC30 VA: 0x18079C630
	protected JsonReader.State get_CurrentState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC31A80 Offset: 0xC30080 VA: 0x180C31A80
	public bool get_CloseInput() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC32BA0 Offset: 0xC311A0 VA: 0x180C32BA0
	public void set_CloseInput(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE765B0 Offset: 0xE74BB0 VA: 0x180E765B0
	public bool get_SupportMultipleContent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE765E0 Offset: 0xE74BE0 VA: 0x180E765E0
	public void set_SupportMultipleContent(bool value) { }

	// RVA: 0x5983B0 Offset: 0x5969B0 VA: 0x1805983B0
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0xF90D70 Offset: 0xF8F370 VA: 0x180F90D70
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0xAE9F70 Offset: 0xAE8570 VA: 0x180AE9F70
	public DateParseHandling get_DateParseHandling() { }

	// RVA: 0xF90D00 Offset: 0xF8F300 VA: 0x180F90D00
	public void set_DateParseHandling(DateParseHandling value) { }

	// RVA: 0x574330 Offset: 0x572930 VA: 0x180574330
	public FloatParseHandling get_FloatParseHandling() { }

	// RVA: 0xF90DE0 Offset: 0xF8F3E0 VA: 0x180F90DE0
	public void set_FloatParseHandling(FloatParseHandling value) { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public string get_DateFormatString() { }

	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0
	public void set_DateFormatString(string value) { }

	// RVA: 0xF90BD0 Offset: 0xF8F1D0 VA: 0x180F90BD0
	public Nullable<int> get_MaxDepth() { }

	// RVA: 0xF90E50 Offset: 0xF8F450 VA: 0x180F90E50
	public void set_MaxDepth(Nullable<int> value) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 5
	public virtual JsonToken get_TokenType() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	public virtual object get_Value() { }

	// RVA: 0xF90CE0 Offset: 0xF8F2E0 VA: 0x180F90CE0 Slot: 7
	public virtual Type get_ValueType() { }

	// RVA: 0xF90B60 Offset: 0xF8F160 VA: 0x180F90B60 Slot: 8
	public virtual int get_Depth() { }

	// RVA: 0xF90BE0 Offset: 0xF8F1E0 VA: 0x180F90BE0 Slot: 9
	public virtual string get_Path() { }

	// RVA: 0xF90B00 Offset: 0xF8F100 VA: 0x180F90B00
	public CultureInfo get_Culture() { }

	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	public void set_Culture(CultureInfo value) { }

	// RVA: 0xF8CE90 Offset: 0xF8B490 VA: 0x180F8CE90
	internal JsonPosition GetPosition(int depth) { }

	// RVA: 0xF90AD0 Offset: 0xF8F0D0 VA: 0x180F90AD0
	protected void .ctor() { }

	// RVA: 0xF8D180 Offset: 0xF8B780 VA: 0x180F8D180
	private void Push(JsonContainerType value) { }

	// RVA: 0xF8D080 Offset: 0xF8B680 VA: 0x180F8D080
	private JsonContainerType Pop() { }

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
	private JsonContainerType Peek() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool Read();

	// RVA: 0xF8EAC0 Offset: 0xF8D0C0 VA: 0x180F8EAC0 Slot: 11
	public virtual Nullable<int> ReadAsInt32() { }

	// RVA: 0xF8FEF0 Offset: 0xF8E4F0 VA: 0x180F8FEF0
	internal Nullable<int> ReadInt32String(string s) { }

	// RVA: 0xF8EDA0 Offset: 0xF8D3A0 VA: 0x180F8EDA0 Slot: 12
	public virtual string ReadAsString() { }

	// RVA: 0xF8DA80 Offset: 0xF8C080 VA: 0x180F8DA80 Slot: 13
	public virtual byte[] ReadAsBytes() { }

	// RVA: 0xF8D520 Offset: 0xF8BB20 VA: 0x180F8D520
	internal byte[] ReadArrayIntoByteArray() { }

	// RVA: 0xF8E7F0 Offset: 0xF8CDF0 VA: 0x180F8E7F0 Slot: 14
	public virtual Nullable<double> ReadAsDouble() { }

	// RVA: 0xF8FCA0 Offset: 0xF8E2A0 VA: 0x180F8FCA0
	internal Nullable<double> ReadDoubleString(string s) { }

	// RVA: 0xF8D790 Offset: 0xF8BD90 VA: 0x180F8D790 Slot: 15
	public virtual Nullable<bool> ReadAsBoolean() { }

	// RVA: 0xF8F1C0 Offset: 0xF8D7C0 VA: 0x180F8F1C0
	internal Nullable<bool> ReadBooleanString(string s) { }

	// RVA: 0xF8E4F0 Offset: 0xF8CAF0 VA: 0x180F8E4F0 Slot: 16
	public virtual Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0xF8FA20 Offset: 0xF8E020 VA: 0x180F8FA20
	internal Nullable<Decimal> ReadDecimalString(string s) { }

	// RVA: 0xF8E220 Offset: 0xF8C820 VA: 0x180F8E220 Slot: 17
	public virtual Nullable<DateTime> ReadAsDateTime() { }

	// RVA: 0xF8F720 Offset: 0xF8DD20 VA: 0x180F8F720
	internal Nullable<DateTime> ReadDateTimeString(string s) { }

	// RVA: 0xF8DF20 Offset: 0xF8C520 VA: 0x180F8DF20 Slot: 18
	public virtual Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0xF8F3B0 Offset: 0xF8D9B0 VA: 0x180F8F3B0
	internal Nullable<DateTimeOffset> ReadDateTimeOffsetString(string s) { }

	// RVA: 0xF90350 Offset: 0xF8E950 VA: 0x180F90350
	internal void ReaderReadAndAssert() { }

	// RVA: 0xF8CDA0 Offset: 0xF8B3A0 VA: 0x180F8CDA0
	internal JsonReaderException CreateUnexpectedEndException() { }

	// RVA: 0xF90100 Offset: 0xF8E700 VA: 0x180F90100
	internal void ReadIntoWrappedTypeObject() { }

	// RVA: 0xF90710 Offset: 0xF8ED10 VA: 0x180F90710
	public void Skip() { }

	// RVA: 0xF906F0 Offset: 0xF8ECF0 VA: 0x180F906F0
	protected void SetToken(JsonToken newToken) { }

	// RVA: 0xF906D0 Offset: 0xF8ECD0 VA: 0x180F906D0
	protected void SetToken(JsonToken newToken, object value) { }

	// RVA: 0xF90510 Offset: 0xF8EB10 VA: 0x180F90510
	internal void SetToken(JsonToken newToken, object value, bool updateIndex) { }

	// RVA: 0xF903D0 Offset: 0xF8E9D0 VA: 0x180F903D0
	internal void SetPostValueState(bool updateIndex) { }

	// RVA: 0xF90830 Offset: 0xF8EE30 VA: 0x180F90830
	private void UpdateScopeWithFinishedValue() { }

	// RVA: 0xF90840 Offset: 0xF8EE40 VA: 0x180F90840
	private void ValidateEnd(JsonToken endToken) { }

	// RVA: 0xF90400 Offset: 0xF8EA00 VA: 0x180F90400
	protected void SetStateBasedOnCurrent() { }

	// RVA: 0xF903B0 Offset: 0xF8E9B0 VA: 0x180F903B0
	private void SetFinished() { }

	// RVA: 0xF8CF30 Offset: 0xF8B530 VA: 0x180F8CF30
	private JsonContainerType GetTypeForCloseToken(JsonToken token) { }

	// RVA: 0xF907C0 Offset: 0xF8EDC0 VA: 0x180F907C0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0xF8CDE0 Offset: 0xF8B3E0 VA: 0x180F8CDE0 Slot: 19
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xF8CD80 Offset: 0xF8B380 VA: 0x180F8CD80 Slot: 20
	public virtual void Close() { }

	// RVA: 0xF8D450 Offset: 0xF8BA50 VA: 0x180F8D450
	internal void ReadAndAssert() { }

	// RVA: 0xF8D4C0 Offset: 0xF8BAC0 VA: 0x180F8D4C0
	internal bool ReadAndMoveToContent() { }

	// RVA: 0xF8D020 Offset: 0xF8B620 VA: 0x180F8D020
	internal bool MoveToContent() { }

	// RVA: 0xF8CE10 Offset: 0xF8B410 VA: 0x180F8CE10
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
	// RVA: 0xF8BD90 Offset: 0xF8A390 VA: 0x180F8BD90
	public static Func<JsonSerializerSettings> get_DefaultSettings() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8BDF0 Offset: 0xF8A3F0 VA: 0x180F8BDF0
	public static void set_DefaultSettings(Func<JsonSerializerSettings> value) { }

	// RVA: 0xF8BA90 Offset: 0xF8A090 VA: 0x180F8BA90
	private static void .cctor() { }

	// RVA: 0xF8ACD0 Offset: 0xF892D0 VA: 0x180F8ACD0
	internal static JsonSerializerSettings GetDefaultSettings() { }

	// RVA: 0xF8B830 Offset: 0xF89E30 VA: 0x180F8B830
	public static string ToString(bool value) { }

	// RVA: 0xF8B410 Offset: 0xF89A10 VA: 0x180F8B410
	public static string ToString(char value) { }

	// RVA: 0xF8B560 Offset: 0xF89B60 VA: 0x180F8B560
	internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0xF8AB70 Offset: 0xF89170 VA: 0x180F8AB70
	private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0xF8B990 Offset: 0xF89F90 VA: 0x180F8B990
	internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0xF8AA70 Offset: 0xF89070 VA: 0x180F8AA70
	private static string EnsureDecimalPlace(double value, string text) { }

	// RVA: 0xF8AA00 Offset: 0xF89000 VA: 0x180F8AA00
	private static string EnsureDecimalPlace(string text) { }

	// RVA: 0xF8B660 Offset: 0xF89C60 VA: 0x180F8B660
	public static string ToString(Decimal value) { }

	// RVA: 0xF8B330 Offset: 0xF89930 VA: 0x180F8B330
	public static string ToString(string value) { }

	// RVA: 0xF8B740 Offset: 0xF89D40 VA: 0x180F8B740
	public static string ToString(string value, char delimiter) { }

	// RVA: 0xF8B8D0 Offset: 0xF89ED0 VA: 0x180F8B8D0
	public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0xF8AFB0 Offset: 0xF895B0 VA: 0x180F8AFB0
	public static string SerializeObject(object value) { }

	// RVA: 0xF8B220 Offset: 0xF89820 VA: 0x180F8B220
	public static string SerializeObject(object value, Formatting formatting) { }

	// RVA: 0xF8AF10 Offset: 0xF89510 VA: 0x180F8AF10
	public static string SerializeObject(object value, Type type, JsonSerializerSettings settings) { }

	// RVA: 0xF8B060 Offset: 0xF89660 VA: 0x180F8B060
	public static string SerializeObject(object value, Formatting formatting, JsonSerializerSettings settings) { }

	// RVA: 0xF8B150 Offset: 0xF89750 VA: 0x180F8B150
	public static string SerializeObject(object value, Type type, Formatting formatting, JsonSerializerSettings settings) { }

	// RVA: 0xF8AD30 Offset: 0xF89330 VA: 0x180F8AD30
	private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer) { }

	// RVA: 0xF8A990 Offset: 0xF88F90 VA: 0x180F8A990
	public static object DeserializeObject(string value, Type type) { }

	// RVA: -1 Offset: -1
	public static T DeserializeObject<T>(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CFC20 Offset: 0x5CE220 VA: 0x1805CFC20
	|-JsonConvert.DeserializeObject<CameraMan.CameraState>
	|
	|-RVA: 0x5D01A0 Offset: 0x5CE7A0 VA: 0x1805D01A0
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
	|-RVA: 0x5CFFE0 Offset: 0x5CE5E0 VA: 0x1805CFFE0
	|-JsonConvert.DeserializeObject<NoticeData>
	|
	|-RVA: 0x5CFDD0 Offset: 0x5CE3D0 VA: 0x1805CFDD0
	|-JsonConvert.DeserializeObject<RCon.Command>
	|
	|-RVA: 0x5CFE70 Offset: 0x5CE470 VA: 0x1805CFE70
	|-JsonConvert.DeserializeObject<CorePropsFile>
	*/

	// RVA: -1 Offset: -1
	public static T DeserializeObject<T>(string value, JsonSerializerSettings settings) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CFB00 Offset: 0x5CE100 VA: 0x1805CFB00
	|-JsonConvert.DeserializeObject<CameraMan.CameraState>
	|
	|-RVA: 0x5D0080 Offset: 0x5CE680 VA: 0x1805D0080
	|-JsonConvert.DeserializeObject<NoticeData>
	|
	|-RVA: 0x5CFCB0 Offset: 0x5CE2B0 VA: 0x1805CFCB0
	|-JsonConvert.DeserializeObject<RCon.Command>
	|
	|-RVA: 0x5CFEE0 Offset: 0x5CE4E0 VA: 0x1805CFEE0
	|-JsonConvert.DeserializeObject<CorePropsFile>
	|
	|-RVA: 0x5D0210 Offset: 0x5CE810 VA: 0x1805D0210
	|-JsonConvert.DeserializeObject<object>
	*/

	// RVA: 0xF8A770 Offset: 0xF88D70 VA: 0x180F8A770
	public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings) { }

}

public class JsonSerializationException : JsonException // TypeDefIndex: 5905
{	// Methods

	// RVA: 0xF8BFA0 Offset: 0xF8A5A0 VA: 0x180F8BFA0
	public void .ctor() { }

	// RVA: 0xF8C080 Offset: 0xF8A680 VA: 0x180F8C080
	public void .ctor(string message) { }

	// RVA: 0xF8C000 Offset: 0xF8A600 VA: 0x180F8C000
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0xF8BF20 Offset: 0xF8A520 VA: 0x180F8BF20
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF90FC0 Offset: 0xF8F5C0 VA: 0x180F90FC0
	internal static JsonSerializationException Create(JsonReader reader, string message) { }

	// RVA: 0xF90FD0 Offset: 0xF8F5D0 VA: 0x180F90FD0
	internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0xF90EE0 Offset: 0xF8F4E0 VA: 0x180F90EE0
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
	// RVA: 0xF938D0 Offset: 0xF91ED0 VA: 0x180F938D0 Slot: 4
	public virtual void add_Error(EventHandler<ErrorEventArgs> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF93A80 Offset: 0xF92080 VA: 0x180F93A80 Slot: 5
	public virtual void remove_Error(EventHandler<ErrorEventArgs> value) { }

	// RVA: 0xF940E0 Offset: 0xF926E0 VA: 0x180F940E0 Slot: 6
	public virtual void set_ReferenceResolver(IReferenceResolver value) { }

	// RVA: 0xF93B20 Offset: 0xF92120 VA: 0x180F93B20 Slot: 7
	public virtual void set_Binder(SerializationBinder value) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0 Slot: 8
	public virtual ITraceWriter get_TraceWriter() { }

	// RVA: 0x5DD7A0 Offset: 0x5DBDA0 VA: 0x1805DD7A0 Slot: 9
	public virtual void set_TraceWriter(ITraceWriter value) { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820 Slot: 10
	public virtual void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0xF941E0 Offset: 0xF927E0 VA: 0x180F941E0 Slot: 11
	public virtual void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0xF94170 Offset: 0xF92770 VA: 0x180F94170 Slot: 12
	public virtual void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	// RVA: 0xF94000 Offset: 0xF92600 VA: 0x180F94000 Slot: 13
	public virtual void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0xF94070 Offset: 0xF92670 VA: 0x180F94070 Slot: 14
	public virtual void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0xF93EB0 Offset: 0xF924B0 VA: 0x180F93EB0 Slot: 15
	public virtual void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0xF93F20 Offset: 0xF92520 VA: 0x180F93F20 Slot: 16
	public virtual void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0xF93D70 Offset: 0xF92370 VA: 0x180F93D70 Slot: 17
	public virtual void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0x79C630 Offset: 0x79AC30 VA: 0x18079C630 Slot: 18
	public virtual ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0xF93F90 Offset: 0xF92590 VA: 0x180F93F90 Slot: 19
	public virtual void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0xF93C10 Offset: 0xF92210 VA: 0x180F93C10 Slot: 20
	public virtual void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0x5E2ED0 Offset: 0x5E14D0 VA: 0x1805E2ED0 Slot: 21
	public virtual MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0xF93E40 Offset: 0xF92440 VA: 0x180F93E40 Slot: 22
	public virtual void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0xF939B0 Offset: 0xF91FB0 VA: 0x180F939B0 Slot: 23
	public virtual JsonConverterCollection get_Converters() { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540 Slot: 24
	public virtual IContractResolver get_ContractResolver() { }

	// RVA: 0xF93CA0 Offset: 0xF922A0 VA: 0x180F93CA0 Slot: 25
	public virtual void set_ContractResolver(IContractResolver value) { }

	// RVA: 0xC325D0 Offset: 0xC30BD0 VA: 0x180C325D0 Slot: 26
	public virtual StreamingContext get_Context() { }

	// RVA: 0xF93C80 Offset: 0xF92280 VA: 0x180F93C80 Slot: 27
	public virtual void set_Context(StreamingContext value) { }

	// RVA: 0xF93A40 Offset: 0xF92040 VA: 0x180F93A40 Slot: 28
	public virtual Formatting get_Formatting() { }

	// RVA: 0xF93DE0 Offset: 0xF923E0 VA: 0x180F93DE0 Slot: 29
	public virtual void set_Formatting(Formatting value) { }

	// RVA: 0xF93970 Offset: 0xF91F70 VA: 0x180F93970 Slot: 30
	public virtual bool get_CheckAdditionalContent() { }

	// RVA: 0xF93BB0 Offset: 0xF921B0 VA: 0x180F93BB0 Slot: 31
	public virtual void set_CheckAdditionalContent(bool value) { }

	// RVA: 0xF92970 Offset: 0xF90F70 VA: 0x180F92970
	internal bool IsCheckAdditionalContentSet() { }

	// RVA: 0xF93760 Offset: 0xF91D60 VA: 0x180F93760
	public void .ctor() { }

	// RVA: 0xF920B0 Offset: 0xF906B0 VA: 0x180F920B0
	public static JsonSerializer Create() { }

	// RVA: 0xF92250 Offset: 0xF90850 VA: 0x180F92250
	public static JsonSerializer Create(JsonSerializerSettings settings) { }

	// RVA: 0xF91E10 Offset: 0xF90410 VA: 0x180F91E10
	public static JsonSerializer CreateDefault() { }

	// RVA: 0xF92070 Offset: 0xF90670 VA: 0x180F92070
	public static JsonSerializer CreateDefault(JsonSerializerSettings settings) { }

	// RVA: 0xF91610 Offset: 0xF8FC10 VA: 0x180F91610
	private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings) { }

	// RVA: 0xF92D40 Offset: 0xF91340 VA: 0x180F92D40
	public void Populate(JsonReader reader, object target) { }

	// RVA: 0xF92A10 Offset: 0xF91010 VA: 0x180F92A10 Slot: 32
	internal virtual void PopulateInternal(JsonReader reader, object target) { }

	// RVA: -1 Offset: -1
	public T Deserialize<T>(JsonReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0AD0 Offset: 0x5CF0D0 VA: 0x1805D0AD0
	|-JsonSerializer.Deserialize<Int32Enum>
	|-JsonSerializer.Deserialize<RegexOptions>
	|
	|-RVA: 0x5D0BB0 Offset: 0x5CF1B0 VA: 0x1805D0BB0
	|-JsonSerializer.Deserialize<object>
	*/

	// RVA: 0xF92760 Offset: 0xF90D60 VA: 0x180F92760
	public object Deserialize(JsonReader reader, Type objectType) { }

	// RVA: 0xF92410 Offset: 0xF90A10 VA: 0x180F92410 Slot: 33
	internal virtual object DeserializeInternal(JsonReader reader, Type objectType) { }

	// RVA: 0xF933B0 Offset: 0xF919B0 VA: 0x180F933B0
	private void SetupReader(JsonReader reader, out CultureInfo previousCulture, out Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, out Nullable<DateParseHandling> previousDateParseHandling, out Nullable<FloatParseHandling> previousFloatParseHandling, out Nullable<int> previousMaxDepth, out string previousDateFormatString) { }

	// RVA: 0xF92D60 Offset: 0xF91360 VA: 0x180F92D60
	private void ResetReader(JsonReader reader, CultureInfo previousCulture, Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, Nullable<DateParseHandling> previousDateParseHandling, Nullable<FloatParseHandling> previousFloatParseHandling, Nullable<int> previousMaxDepth, string previousDateFormatString) { }

	// RVA: 0xF93390 Offset: 0xF91990 VA: 0x180F93390
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0xF93360 Offset: 0xF91960 VA: 0x180F93360
	public void Serialize(JsonWriter jsonWriter, object value) { }

	// RVA: 0xF92ED0 Offset: 0xF914D0 VA: 0x180F92ED0 Slot: 34
	internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0xF92900 Offset: 0xF90F00 VA: 0x180F92900
	internal IReferenceResolver GetReferenceResolver() { }

	// RVA: 0xF92780 Offset: 0xF90D80 VA: 0x180F92780
	internal JsonConverter GetMatchingConverter(Type type) { }

	// RVA: 0xF92840 Offset: 0xF90E40 VA: 0x180F92840
	internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType) { }

	// RVA: 0xF929B0 Offset: 0xF90FB0 VA: 0x180F929B0
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

	// RVA: 0xE48DF0 Offset: 0xE473F0 VA: 0x180E48DF0
	internal static JsonWriter.State[][] BuildStateArray() { }

	// RVA: 0xE4C250 Offset: 0xE4A850 VA: 0x180E4C250
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1660 Offset: 0x8BFC60 VA: 0x1808C1660
	public bool get_CloseOutput() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x78E190 Offset: 0x78C790 VA: 0x18078E190
	public void set_CloseOutput(bool value) { }

	// RVA: 0xE4D230 Offset: 0xE4B830 VA: 0x180E4D230
	protected internal int get_Top() { }

	// RVA: 0xE4D290 Offset: 0xE4B890 VA: 0x180E4D290
	public WriteState get_WriteState() { }

	// RVA: 0xE4D040 Offset: 0xE4B640 VA: 0x180E4D040
	internal string get_ContainerPath() { }

	// RVA: 0xE4D130 Offset: 0xE4B730 VA: 0x180E4D130
	public string get_Path() { }

	// RVA: 0x5E2ED0 Offset: 0x5E14D0 VA: 0x1805E2ED0
	public Formatting get_Formatting() { }

	// RVA: 0xE4D4F0 Offset: 0xE4BAF0 VA: 0x180E4D4F0
	public void set_Formatting(Formatting value) { }

	// RVA: 0x5E2EE0 Offset: 0x5E14E0 VA: 0x1805E2EE0
	public DateFormatHandling get_DateFormatHandling() { }

	// RVA: 0xE4D3A0 Offset: 0xE4B9A0 VA: 0x180E4D3A0
	public void set_DateFormatHandling(DateFormatHandling value) { }

	// RVA: 0x5DE3D0 Offset: 0x5DC9D0 VA: 0x1805DE3D0
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0xE4D410 Offset: 0xE4BA10 VA: 0x180E4D410
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0x5DE3E0 Offset: 0x5DC9E0 VA: 0x1805DE3E0
	public StringEscapeHandling get_StringEscapeHandling() { }

	// RVA: 0xE4D560 Offset: 0xE4BB60 VA: 0x180E4D560
	public void set_StringEscapeHandling(StringEscapeHandling value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	internal virtual void OnStringEscapeHandlingChanged() { }

	// RVA: 0x5983B0 Offset: 0x5969B0 VA: 0x1805983B0
	public FloatFormatHandling get_FloatFormatHandling() { }

	// RVA: 0xE4D480 Offset: 0xE4BA80 VA: 0x180E4D480
	public void set_FloatFormatHandling(FloatFormatHandling value) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public string get_DateFormatString() { }

	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	public void set_DateFormatString(string value) { }

	// RVA: 0xE4D0D0 Offset: 0xE4B6D0 VA: 0x180E4D0D0
	public CultureInfo get_Culture() { }

	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810
	public void set_Culture(CultureInfo value) { }

	// RVA: 0xE4D010 Offset: 0xE4B610 VA: 0x180E4D010
	protected void .ctor() { }

	// RVA: 0xE496D0 Offset: 0xE47CD0 VA: 0x180E496D0
	internal void UpdateScopeWithFinishedValue() { }

	// RVA: 0xE49560 Offset: 0xE47B60 VA: 0x180E49560
	private void Push(JsonContainerType value) { }

	// RVA: 0xE49470 Offset: 0xE47A70 VA: 0x180E49470
	private JsonContainerType Pop() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	private JsonContainerType Peek() { }

	// RVA: 0xE3A910 Offset: 0xE38F10 VA: 0x180E3A910 Slot: 6
	public virtual void Close() { }

	// RVA: 0xE49BD0 Offset: 0xE481D0 VA: 0x180E49BD0 Slot: 7
	public virtual void WriteStartObject() { }

	// RVA: 0xE49940 Offset: 0xE47F40 VA: 0x180E49940 Slot: 8
	public virtual void WriteEndObject() { }

	// RVA: 0xE49BB0 Offset: 0xE481B0 VA: 0x180E49BB0 Slot: 9
	public virtual void WriteStartArray() { }

	// RVA: 0xE49920 Offset: 0xE47F20 VA: 0x180E49920 Slot: 10
	public virtual void WriteEndArray() { }

	// RVA: 0xE49BC0 Offset: 0xE481C0 VA: 0x180E49BC0 Slot: 11
	public virtual void WriteStartConstructor(string name) { }

	// RVA: 0xE49930 Offset: 0xE47F30 VA: 0x180E49930 Slot: 12
	public virtual void WriteEndConstructor() { }

	// RVA: 0xE49310 Offset: 0xE47910 VA: 0x180E49310 Slot: 13
	public virtual void WritePropertyName(string name) { }

	// RVA: 0xE49B40 Offset: 0xE48140 VA: 0x180E49B40 Slot: 14
	public virtual void WritePropertyName(string name, bool escape) { }

	// RVA: 0xE49A40 Offset: 0xE48040 VA: 0x180E49A40 Slot: 15
	public virtual void WriteEnd() { }

	// RVA: 0xE49DF0 Offset: 0xE483F0 VA: 0x180E49DF0
	public void WriteToken(JsonReader reader) { }

	// RVA: 0xE4A670 Offset: 0xE48C70 VA: 0x180E4A670
	public void WriteToken(JsonReader reader, bool writeChildren) { }

	// RVA: 0xE49E60 Offset: 0xE48460 VA: 0x180E49E60
	public void WriteToken(JsonToken token, object value) { }

	// RVA: 0xE49BE0 Offset: 0xE481E0 VA: 0x180E49BE0 Slot: 16
	internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

	// RVA: 0xE496E0 Offset: 0xE47CE0 VA: 0x180E496E0
	private void WriteConstructorDate(JsonReader reader) { }

	// RVA: 0xE49950 Offset: 0xE47F50 VA: 0x180E49950
	private void WriteEnd(JsonContainerType type) { }

	// RVA: 0xE3A910 Offset: 0xE38F10 VA: 0x180E3A910
	private void AutoCompleteAll() { }

	// RVA: 0xE49230 Offset: 0xE47830 VA: 0x180E49230
	private JsonToken GetCloseTokenForType(JsonContainerType type) { }

	// RVA: 0xE48800 Offset: 0xE46E00 VA: 0x180E48800
	private void AutoCompleteClose(JsonContainerType type) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 17
	protected virtual void WriteEnd(JsonToken token) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	protected virtual void WriteIndent() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 19
	protected virtual void WriteValueDelimiter() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 20
	protected virtual void WriteIndentSpace() { }

	// RVA: 0xE48B90 Offset: 0xE47190 VA: 0x180E48B90
	internal void AutoComplete(JsonToken tokenBeingWritten) { }

	// RVA: 0xE49B20 Offset: 0xE48120 VA: 0x180E49B20 Slot: 21
	public virtual void WriteNull() { }

	// RVA: 0xE4A6F0 Offset: 0xE48CF0 VA: 0x180E4A6F0 Slot: 22
	public virtual void WriteUndefined() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 23
	public virtual void WriteRaw(string json) { }

	// RVA: 0xE49B60 Offset: 0xE48160 VA: 0x180E49B60 Slot: 24
	public virtual void WriteRawValue(string json) { }

	// RVA: 0xE4A780 Offset: 0xE48D80 VA: 0x180E4A780 Slot: 25
	public virtual void WriteValue(string value) { }

	// RVA: 0xE4B930 Offset: 0xE49F30 VA: 0x180E4B930 Slot: 26
	public virtual void WriteValue(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE4B930 Offset: 0xE49F30 VA: 0x180E4B930 Slot: 27
	public virtual void WriteValue(uint value) { }

	// RVA: 0xE4B930 Offset: 0xE49F30 VA: 0x180E4B930 Slot: 28
	public virtual void WriteValue(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE4B930 Offset: 0xE49F30 VA: 0x180E4B930 Slot: 29
	public virtual void WriteValue(ulong value) { }

	// RVA: 0xE4BDB0 Offset: 0xE4A3B0 VA: 0x180E4BDB0 Slot: 30
	public virtual void WriteValue(float value) { }

	// RVA: 0xE4BDB0 Offset: 0xE4A3B0 VA: 0x180E4BDB0 Slot: 31
	public virtual void WriteValue(double value) { }

	// RVA: 0xE4BC30 Offset: 0xE4A230 VA: 0x180E4BC30 Slot: 32
	public virtual void WriteValue(bool value) { }

	// RVA: 0xE4B930 Offset: 0xE49F30 VA: 0x180E4B930 Slot: 33
	public virtual void WriteValue(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE4B930 Offset: 0xE49F30 VA: 0x180E4B930 Slot: 34
	public virtual void WriteValue(ushort value) { }

	// RVA: 0xE4A780 Offset: 0xE48D80 VA: 0x180E4A780 Slot: 35
	public virtual void WriteValue(char value) { }

	// RVA: 0xE4B930 Offset: 0xE49F30 VA: 0x180E4B930 Slot: 36
	public virtual void WriteValue(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE4B930 Offset: 0xE49F30 VA: 0x180E4B930 Slot: 37
	public virtual void WriteValue(sbyte value) { }

	// RVA: 0xE4BDB0 Offset: 0xE4A3B0 VA: 0x180E4BDB0 Slot: 38
	public virtual void WriteValue(Decimal value) { }

	// RVA: 0xE4BD90 Offset: 0xE4A390 VA: 0x180E4BD90 Slot: 39
	public virtual void WriteValue(DateTime value) { }

	// RVA: 0xE4BD90 Offset: 0xE4A390 VA: 0x180E4BD90 Slot: 40
	public virtual void WriteValue(DateTimeOffset value) { }

	// RVA: 0xE4A780 Offset: 0xE48D80 VA: 0x180E4A780 Slot: 41
	public virtual void WriteValue(Guid value) { }

	// RVA: 0xE4A780 Offset: 0xE48D80 VA: 0x180E4A780 Slot: 42
	public virtual void WriteValue(TimeSpan value) { }

	// RVA: 0xE4BAD0 Offset: 0xE4A0D0 VA: 0x180E4BAD0 Slot: 43
	public virtual void WriteValue(Nullable<int> value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE4C1E0 Offset: 0xE4A7E0 VA: 0x180E4C1E0 Slot: 44
	public virtual void WriteValue(Nullable<uint> value) { }

	// RVA: 0xE4C080 Offset: 0xE4A680 VA: 0x180E4C080 Slot: 45
	public virtual void WriteValue(Nullable<long> value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE4A710 Offset: 0xE48D10 VA: 0x180E4A710 Slot: 46
	public virtual void WriteValue(Nullable<ulong> value) { }

	// RVA: 0xE4C0F0 Offset: 0xE4A6F0 VA: 0x180E4C0F0 Slot: 47
	public virtual void WriteValue(Nullable<float> value) { }

	// RVA: 0xE4B9C0 Offset: 0xE49FC0 VA: 0x180E4B9C0 Slot: 48
	public virtual void WriteValue(Nullable<double> value) { }

	// RVA: 0xE4BEB0 Offset: 0xE4A4B0 VA: 0x180E4BEB0 Slot: 49
	public virtual void WriteValue(Nullable<bool> value) { }

	// RVA: 0xE4BDD0 Offset: 0xE4A3D0 VA: 0x180E4BDD0 Slot: 50
	public virtual void WriteValue(Nullable<short> value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE4BB40 Offset: 0xE4A140 VA: 0x180E4BB40 Slot: 51
	public virtual void WriteValue(Nullable<ushort> value) { }

	// RVA: 0xE4BE40 Offset: 0xE4A440 VA: 0x180E4BE40 Slot: 52
	public virtual void WriteValue(Nullable<char> value) { }

	// RVA: 0xE4BC50 Offset: 0xE4A250 VA: 0x180E4BC50 Slot: 53
	public virtual void WriteValue(Nullable<byte> value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE4B950 Offset: 0xE49F50 VA: 0x180E4B950 Slot: 54
	public virtual void WriteValue(Nullable<sbyte> value) { }

	// RVA: 0xE4BBB0 Offset: 0xE4A1B0 VA: 0x180E4BBB0 Slot: 55
	public virtual void WriteValue(Nullable<Decimal> value) { }

	// RVA: 0xE4C010 Offset: 0xE4A610 VA: 0x180E4C010 Slot: 56
	public virtual void WriteValue(Nullable<DateTime> value) { }

	// RVA: 0xE4C160 Offset: 0xE4A760 VA: 0x180E4C160 Slot: 57
	public virtual void WriteValue(Nullable<DateTimeOffset> value) { }

	// RVA: 0xE4BF20 Offset: 0xE4A520 VA: 0x180E4BF20 Slot: 58
	public virtual void WriteValue(Nullable<Guid> value) { }

	// RVA: 0xE4BFA0 Offset: 0xE4A5A0 VA: 0x180E4BFA0 Slot: 59
	public virtual void WriteValue(Nullable<TimeSpan> value) { }

	// RVA: 0xE4A7A0 Offset: 0xE48DA0 VA: 0x180E4A7A0 Slot: 60
	public virtual void WriteValue(byte[] value) { }

	// RVA: 0xE4BA30 Offset: 0xE4A030 VA: 0x180E4BA30 Slot: 61
	public virtual void WriteValue(Uri value) { }

	// RVA: 0xE4BCC0 Offset: 0xE4A2C0 VA: 0x180E4BCC0 Slot: 62
	public virtual void WriteValue(object value) { }

	// RVA: 0xE492F0 Offset: 0xE478F0 VA: 0x180E492F0 Slot: 63
	public virtual void WriteComment(string text) { }

	// RVA: 0xE49660 Offset: 0xE47C60 VA: 0x180E49660 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE49200 Offset: 0xE47800 VA: 0x180E49200 Slot: 64
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xE4A7D0 Offset: 0xE48DD0 VA: 0x180E4A7D0
	internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value) { }

	// RVA: 0xE49150 Offset: 0xE47750 VA: 0x180E49150
	private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value) { }

	// RVA: 0xE49300 Offset: 0xE47900 VA: 0x180E49300
	internal void InternalWriteEnd(JsonContainerType container) { }

	// RVA: 0xE49310 Offset: 0xE47910 VA: 0x180E49310
	internal void InternalWritePropertyName(string name) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void InternalWriteRaw() { }

	// RVA: 0xE49340 Offset: 0xE47940 VA: 0x180E49340
	internal void InternalWriteStart(JsonToken token, JsonContainerType container) { }

	// RVA: 0xE49450 Offset: 0xE47A50 VA: 0x180E49450
	internal void InternalWriteValue(JsonToken token) { }

	// RVA: 0xE492F0 Offset: 0xE478F0 VA: 0x180E492F0
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

	// RVA: 0x17F64A0 Offset: 0x17F4AA0 VA: 0x1817F64A0
	internal static bool IsEndToken(JsonToken token) { }

	// RVA: 0x17F6510 Offset: 0x17F4B10 VA: 0x1817F6510
	internal static bool IsStartToken(JsonToken token) { }

	// RVA: 0x17F64C0 Offset: 0x17F4AC0 VA: 0x1817F64C0
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

	// RVA: 0x4E3FE0 Offset: 0x4E25E0 VA: 0x1804E3FE0
	internal JsonContract get_ItemContract() { }

	// RVA: 0x13F0F70 Offset: 0x13EF570 VA: 0x1813F0F70
	internal void set_ItemContract(JsonContract value) { }

	// RVA: 0x574310 Offset: 0x572910 VA: 0x180574310
	internal JsonContract get_FinalItemContract() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5742F0 Offset: 0x5728F0 VA: 0x1805742F0
	public JsonConverter get_ItemConverter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public void set_ItemConverter(JsonConverter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F0F40 Offset: 0x13EF540 VA: 0x1813F0F40
	public Nullable<bool> get_ItemIsReference() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F0FD0 Offset: 0x13EF5D0 VA: 0x1813F0FD0
	public void set_ItemIsReference(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F0F50 Offset: 0x13EF550 VA: 0x1813F0F50
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F0FE0 Offset: 0x13EF5E0 VA: 0x1813F0FE0
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F0F60 Offset: 0x13EF560 VA: 0x1813F0F60
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F0FF0 Offset: 0x13EF5F0 VA: 0x1813F0FF0
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

	// RVA: 0x13F0E40 Offset: 0x13EF440 VA: 0x1813F0E40
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

	// RVA: 0x1800910 Offset: 0x17FEF10 VA: 0x181800910
	public void .ctor(JsonReader innerReader) { }

	// RVA: 0x1800380 Offset: 0x17FE980 VA: 0x181800380
	public string GetDeserializedJsonMessage() { }

	// RVA: 0x18008A0 Offset: 0x17FEEA0 VA: 0x1818008A0 Slot: 10
	public override bool Read() { }

	// RVA: 0x18007C0 Offset: 0x17FEDC0 VA: 0x1818007C0 Slot: 11
	public override Nullable<int> ReadAsInt32() { }

	// RVA: 0x1800830 Offset: 0x17FEE30 VA: 0x181800830 Slot: 12
	public override string ReadAsString() { }

	// RVA: 0x1800540 Offset: 0x17FEB40 VA: 0x181800540 Slot: 13
	public override byte[] ReadAsBytes() { }

	// RVA: 0x18006C0 Offset: 0x17FECC0 VA: 0x1818006C0 Slot: 16
	public override Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0x1800740 Offset: 0x17FED40 VA: 0x181800740 Slot: 14
	public override Nullable<double> ReadAsDouble() { }

	// RVA: 0x18004D0 Offset: 0x17FEAD0 VA: 0x1818004D0 Slot: 15
	public override Nullable<bool> ReadAsBoolean() { }

	// RVA: 0x1800640 Offset: 0x17FEC40 VA: 0x181800640 Slot: 17
	public override Nullable<DateTime> ReadAsDateTime() { }

	// RVA: 0x18005B0 Offset: 0x17FEBB0 VA: 0x1818005B0 Slot: 18
	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0x1800A60 Offset: 0x17FF060 VA: 0x181800A60 Slot: 8
	public override int get_Depth() { }

	// RVA: 0x1800A90 Offset: 0x17FF090 VA: 0x181800A90 Slot: 9
	public override string get_Path() { }

	// RVA: 0x1800AC0 Offset: 0x17FF0C0 VA: 0x181800AC0 Slot: 5
	public override JsonToken get_TokenType() { }

	// RVA: 0x1800B20 Offset: 0x17FF120 VA: 0x181800B20 Slot: 6
	public override object get_Value() { }

	// RVA: 0x1800AF0 Offset: 0x17FF0F0 VA: 0x181800AF0 Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0x1800350 Offset: 0x17FE950 VA: 0x181800350 Slot: 20
	public override void Close() { }

	// RVA: 0x18003B0 Offset: 0x17FE9B0 VA: 0x1818003B0 Slot: 21
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0x1800410 Offset: 0x17FEA10 VA: 0x181800410 Slot: 22
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0x1800470 Offset: 0x17FEA70 VA: 0x181800470 Slot: 23
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

}

internal class TraceJsonWriter : JsonWriter // TypeDefIndex: 5981
{	// Fields
	private readonly JsonWriter _innerWriter; // 0x60
	private readonly JsonTextWriter _textWriter; // 0x68
	private readonly StringWriter _sw; // 0x70

	// Methods

	// RVA: 0x1801A90 Offset: 0x1800090 VA: 0x181801A90
	public void .ctor(JsonWriter innerWriter) { }

	// RVA: 0x1800BA0 Offset: 0x17FF1A0 VA: 0x181800BA0
	public string GetSerializedJsonMessage() { }

	// RVA: 0x18016E0 Offset: 0x17FFCE0 VA: 0x1818016E0 Slot: 38
	public override void WriteValue(Decimal value) { }

	// RVA: 0x18012D0 Offset: 0x17FF8D0 VA: 0x1818012D0 Slot: 32
	public override void WriteValue(bool value) { }

	// RVA: 0x1801840 Offset: 0x17FFE40 VA: 0x181801840 Slot: 36
	public override void WriteValue(byte value) { }

	// RVA: 0x1801670 Offset: 0x17FFC70 VA: 0x181801670 Slot: 53
	public override void WriteValue(Nullable<byte> value) { }

	// RVA: 0x1801180 Offset: 0x17FF780 VA: 0x181801180 Slot: 35
	public override void WriteValue(char value) { }

	// RVA: 0x18010B0 Offset: 0x17FF6B0 VA: 0x1818010B0 Slot: 60
	public override void WriteValue(byte[] value) { }

	// RVA: 0x1801920 Offset: 0x17FFF20 VA: 0x181801920 Slot: 39
	public override void WriteValue(DateTime value) { }

	// RVA: 0x1801990 Offset: 0x17FFF90 VA: 0x181801990 Slot: 40
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0x18014B0 Offset: 0x17FFAB0 VA: 0x1818014B0 Slot: 31
	public override void WriteValue(double value) { }

	// RVA: 0x1801060 Offset: 0x17FF660 VA: 0x181801060 Slot: 22
	public override void WriteUndefined() { }

	// RVA: 0x1800D30 Offset: 0x17FF330 VA: 0x181800D30 Slot: 21
	public override void WriteNull() { }

	// RVA: 0x18018B0 Offset: 0x17FFEB0 VA: 0x1818018B0 Slot: 30
	public override void WriteValue(float value) { }

	// RVA: 0x18013B0 Offset: 0x17FF9B0 VA: 0x1818013B0 Slot: 41
	public override void WriteValue(Guid value) { }

	// RVA: 0x1801120 Offset: 0x17FF720 VA: 0x181801120 Slot: 26
	public override void WriteValue(int value) { }

	// RVA: 0x18011F0 Offset: 0x17FF7F0 VA: 0x1818011F0 Slot: 28
	public override void WriteValue(long value) { }

	// RVA: 0x1801340 Offset: 0x17FF940 VA: 0x181801340 Slot: 62
	public override void WriteValue(object value) { }

	// RVA: 0x1801770 Offset: 0x17FFD70 VA: 0x181801770 Slot: 37
	public override void WriteValue(sbyte value) { }

	// RVA: 0x1801440 Offset: 0x17FFA40 VA: 0x181801440 Slot: 33
	public override void WriteValue(short value) { }

	// RVA: 0x1801590 Offset: 0x17FFB90 VA: 0x181801590 Slot: 25
	public override void WriteValue(string value) { }

	// RVA: 0x1801A20 Offset: 0x1800020 VA: 0x181801A20 Slot: 42
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0x18017E0 Offset: 0x17FFDE0 VA: 0x1818017E0 Slot: 27
	public override void WriteValue(uint value) { }

	// RVA: 0x1801260 Offset: 0x17FF860 VA: 0x181801260 Slot: 29
	public override void WriteValue(ulong value) { }

	// RVA: 0x1801520 Offset: 0x17FFB20 VA: 0x181801520 Slot: 61
	public override void WriteValue(Uri value) { }

	// RVA: 0x1801600 Offset: 0x17FFC00 VA: 0x181801600 Slot: 34
	public override void WriteValue(ushort value) { }

	// RVA: 0x1800BD0 Offset: 0x17FF1D0 VA: 0x181800BD0 Slot: 63
	public override void WriteComment(string text) { }

	// RVA: 0x1800F50 Offset: 0x17FF550 VA: 0x181800F50 Slot: 9
	public override void WriteStartArray() { }

	// RVA: 0x1800C40 Offset: 0x17FF240 VA: 0x181800C40 Slot: 10
	public override void WriteEndArray() { }

	// RVA: 0x1800FA0 Offset: 0x17FF5A0 VA: 0x181800FA0 Slot: 11
	public override void WriteStartConstructor(string name) { }

	// RVA: 0x1800C90 Offset: 0x17FF290 VA: 0x181800C90 Slot: 12
	public override void WriteEndConstructor() { }

	// RVA: 0x1800E00 Offset: 0x17FF400 VA: 0x181800E00 Slot: 13
	public override void WritePropertyName(string name) { }

	// RVA: 0x1800D80 Offset: 0x17FF380 VA: 0x181800D80 Slot: 14
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0x1801010 Offset: 0x17FF610 VA: 0x181801010 Slot: 7
	public override void WriteStartObject() { }

	// RVA: 0x1800CE0 Offset: 0x17FF2E0 VA: 0x181800CE0 Slot: 8
	public override void WriteEndObject() { }

	// RVA: 0x1800E70 Offset: 0x17FF470 VA: 0x181800E70 Slot: 24
	public override void WriteRawValue(string json) { }

	// RVA: 0x1800EE0 Offset: 0x17FF4E0 VA: 0x181800EE0 Slot: 23
	public override void WriteRaw(string json) { }

	// RVA: 0x1800B50 Offset: 0x17FF150 VA: 0x181800B50 Slot: 6
	public override void Close() { }

}

internal class JsonFormatterConverter : IFormatterConverter // TypeDefIndex: 5982
{	// Fields
	private readonly JsonSerializerInternalReader _reader; // 0x10
	private readonly JsonISerializableContract _contract; // 0x18
	private readonly JsonProperty _member; // 0x20

	// Methods

	// RVA: 0x13F2FB0 Offset: 0x13F15B0 VA: 0x1813F2FB0
	public void .ctor(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: -1 Offset: -1
	private T GetTokenValue<T>(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0300 Offset: 0x5CE900 VA: 0x1805D0300
	|-JsonFormatterConverter.GetTokenValue<bool>
	|
	|-RVA: 0x5D0490 Offset: 0x5CEA90 VA: 0x1805D0490
	|-JsonFormatterConverter.GetTokenValue<int>
	|
	|-RVA: 0x5D0620 Offset: 0x5CEC20 VA: 0x1805D0620
	|-JsonFormatterConverter.GetTokenValue<long>
	|
	|-RVA: 0x5D07B0 Offset: 0x5CEDB0 VA: 0x1805D07B0
	|-JsonFormatterConverter.GetTokenValue<object>
	|-JsonFormatterConverter.GetTokenValue<string>
	|
	|-RVA: 0x5D0940 Offset: 0x5CEF40 VA: 0x1805D0940
	|-JsonFormatterConverter.GetTokenValue<float>
	*/

	// RVA: 0x13F2BC0 Offset: 0x13F11C0 VA: 0x1813F2BC0 Slot: 4
	public object Convert(object value, Type type) { }

	// RVA: 0x13F2E20 Offset: 0x13F1420 VA: 0x1813F2E20 Slot: 5
	public bool ToBoolean(object value) { }

	// RVA: 0x13F2E70 Offset: 0x13F1470 VA: 0x1813F2E70 Slot: 6
	public int ToInt32(object value) { }

	// RVA: 0x13F2EC0 Offset: 0x13F14C0 VA: 0x1813F2EC0 Slot: 7
	public long ToInt64(object value) { }

	// RVA: 0x13F2F10 Offset: 0x13F1510 VA: 0x1813F2F10 Slot: 8
	public float ToSingle(object value) { }

	// RVA: 0x13F2F60 Offset: 0x13F1560 VA: 0x1813F2F60 Slot: 9
	public string ToString(object value) { }

}

public class JsonLinqContract : JsonContract // TypeDefIndex: 5984
{	// Methods

	// RVA: 0x13F3080 Offset: 0x13F1680 VA: 0x1813F3080
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
	// RVA: 0xD27F40 Offset: 0xD26540 VA: 0x180D27F40
	internal PrimitiveTypeCode get_TypeCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD27EB0 Offset: 0xD264B0 VA: 0x180D27EB0
	internal void set_TypeCode(PrimitiveTypeCode value) { }

	// RVA: 0x13F39A0 Offset: 0x13F1FA0 VA: 0x1813F39A0
	public void .ctor(Type underlyingType) { }

	// RVA: 0x13F3760 Offset: 0x13F1D60 VA: 0x1813F3760
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
	// RVA: 0x79BE20 Offset: 0x79A420 VA: 0x18079BE20
	public Type get_CollectionItemType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BEA0 Offset: 0x79A4A0 VA: 0x18079BEA0
	private void set_CollectionItemType(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE00 Offset: 0x79A400 VA: 0x18079BE00
	public bool get_IsMultidimensionalArray() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE80 Offset: 0x79A480 VA: 0x18079BE80
	private void set_IsMultidimensionalArray(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA0E60 Offset: 0xD9F460 VA: 0x180DA0E60
	internal bool get_IsArray() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA1240 Offset: 0xD9F840 VA: 0x180DA1240
	private void set_IsArray(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F0DD0 Offset: 0x13EF3D0 VA: 0x1813F0DD0
	internal bool get_ShouldCreateWrapper() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F0E30 Offset: 0x13EF430 VA: 0x1813F0E30
	private void set_ShouldCreateWrapper(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F0CD0 Offset: 0x13EF2D0 VA: 0x1813F0CD0
	internal bool get_CanDeserialize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F0DE0 Offset: 0x13EF3E0 VA: 0x1813F0DE0
	private void set_CanDeserialize(bool value) { }

	// RVA: 0x13F0D20 Offset: 0x13EF320 VA: 0x1813F0D20
	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	// RVA: 0xC83900 Offset: 0xC81F00 VA: 0x180C83900
	public ObjectConstructor<object> get_OverrideCreator() { }

	// RVA: 0x13F0E00 Offset: 0x13EF400 VA: 0x1813F0E00
	public void set_OverrideCreator(ObjectConstructor<object> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F0D10 Offset: 0x13EF310 VA: 0x1813F0D10
	public bool get_HasParameterizedCreator() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F0DF0 Offset: 0x13EF3F0 VA: 0x1813F0DF0
	public void set_HasParameterizedCreator(bool value) { }

	// RVA: 0x13F0CE0 Offset: 0x13EF2E0 VA: 0x1813F0CE0
	internal bool get_HasParameterizedCreatorInternal() { }

	// RVA: 0x13F0180 Offset: 0x13EE780 VA: 0x1813F0180
	public void .ctor(Type underlyingType) { }

	// RVA: 0x13EFD10 Offset: 0x13EE310 VA: 0x1813EFD10
	internal IWrappedCollection CreateWrapper(object list) { }

	// RVA: 0x13EFAF0 Offset: 0x13EE0F0 VA: 0x1813EFAF0
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
	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public Type get_UnderlyingType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0
	private void set_UnderlyingType(Type value) { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public Type get_CreatedType() { }

	// RVA: 0x13F1CD0 Offset: 0x13F02D0 VA: 0x1813F1CD0
	public void set_CreatedType(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1A90 Offset: 0x13F0090 VA: 0x1813F1A90
	public Nullable<bool> get_IsReference() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F1D40 Offset: 0x13F0340 VA: 0x1813F1D40
	public void set_IsReference(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public JsonConverter get_Converter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	public void set_Converter(JsonConverter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E84B0 Offset: 0x4E6AB0 VA: 0x1804E84B0
	internal JsonConverter get_InternalConverter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E87D0 Offset: 0x4E6DD0 VA: 0x1804E87D0
	internal void set_InternalConverter(JsonConverter value) { }

	// RVA: 0x13F1AA0 Offset: 0x13F00A0 VA: 0x1813F1AA0
	public IList<SerializationCallback> get_OnDeserializedCallbacks() { }

	// RVA: 0x13F1B10 Offset: 0x13F0110 VA: 0x1813F1B10
	public IList<SerializationCallback> get_OnDeserializingCallbacks() { }

	// RVA: 0x13F1BF0 Offset: 0x13F01F0 VA: 0x1813F1BF0
	public IList<SerializationCallback> get_OnSerializedCallbacks() { }

	// RVA: 0x13F1C60 Offset: 0x13F0260 VA: 0x1813F1C60
	public IList<SerializationCallback> get_OnSerializingCallbacks() { }

	// RVA: 0x13F1B80 Offset: 0x13F0180 VA: 0x1813F1B80
	public IList<SerializationErrorCallback> get_OnErrorCallbacks() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public Func<object> get_DefaultCreator() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	public void set_DefaultCreator(Func<object> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D6A0 Offset: 0x69BCA0 VA: 0x18069D6A0
	public bool get_DefaultCreatorNonPublic() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D6B0 Offset: 0x69BCB0 VA: 0x18069D6B0
	public void set_DefaultCreatorNonPublic(bool value) { }

	// RVA: 0x13F1920 Offset: 0x13EFF20 VA: 0x1813F1920
	internal void .ctor(Type underlyingType) { }

	// RVA: 0x13F1770 Offset: 0x13EFD70 VA: 0x1813F1770
	internal void InvokeOnSerializing(object o, StreamingContext context) { }

	// RVA: 0x13F15C0 Offset: 0x13EFBC0 VA: 0x1813F15C0
	internal void InvokeOnSerialized(object o, StreamingContext context) { }

	// RVA: 0x13F1250 Offset: 0x13EF850 VA: 0x1813F1250
	internal void InvokeOnDeserializing(object o, StreamingContext context) { }

	// RVA: 0x13F1120 Offset: 0x13EF720 VA: 0x1813F1120
	internal void InvokeOnDeserialized(object o, StreamingContext context) { }

	// RVA: 0x13F1400 Offset: 0x13EFA00 VA: 0x1813F1400
	internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext) { }

	// RVA: 0x13F1000 Offset: 0x13EF600 VA: 0x1813F1000
	internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo) { }

	// RVA: 0x13F1090 Offset: 0x13EF690 VA: 0x1813F1090
	internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo) { }

}

private sealed class JsonContract.<>c__DisplayClass73_0 // TypeDefIndex: 6012
{	// Fields
	public MethodInfo callbackMethodInfo; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1408300 Offset: 0x1406900 VA: 0x181408300
	internal void <CreateSerializationCallback>b__0(object o, StreamingContext context) { }

}

private sealed class JsonContract.<>c__DisplayClass74_0 // TypeDefIndex: 6013
{	// Fields
	public MethodInfo callbackMethodInfo; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14083F0 Offset: 0x14069F0 VA: 0x1814083F0
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
	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	internal JsonContract get_PropertyContract() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5DD7A0 Offset: 0x5DBDA0 VA: 0x1805DD7A0
	internal void set_PropertyContract(JsonContract value) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_PropertyName() { }

	// RVA: 0x13F4300 Offset: 0x13F2900 VA: 0x1813F4300
	public void set_PropertyName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public Type get_DeclaringType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	public void set_DeclaringType(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public Nullable<int> get_Order() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D9550 Offset: 0x8D7B50 VA: 0x1808D9550
	public void set_Order(Nullable<int> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public string get_UnderlyingName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0
	public void set_UnderlyingName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public IValueProvider get_ValueProvider() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519DE0 Offset: 0x5183E0 VA: 0x180519DE0
	public void set_ValueProvider(IValueProvider value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	public void set_AttributeProvider(IAttributeProvider value) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public Type get_PropertyType() { }

	// RVA: 0x13F43A0 Offset: 0x13F29A0 VA: 0x1813F43A0
	public void set_PropertyType(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E84B0 Offset: 0x4E6AB0 VA: 0x1804E84B0
	public JsonConverter get_Converter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E87D0 Offset: 0x4E6DD0 VA: 0x1804E87D0
	public void set_Converter(JsonConverter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public JsonConverter get_MemberConverter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	public void set_MemberConverter(JsonConverter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D6A0 Offset: 0x69BCA0 VA: 0x18069D6A0
	public bool get_Ignored() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D6B0 Offset: 0x69BCB0 VA: 0x18069D6B0
	public void set_Ignored(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEC1F40 Offset: 0xEC0540 VA: 0x180EC1F40
	public bool get_Readable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEC25E0 Offset: 0xEC0BE0 VA: 0x180EC25E0
	public void set_Readable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F4260 Offset: 0x13F2860 VA: 0x1813F4260
	public bool get_Writable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F43F0 Offset: 0x13F29F0 VA: 0x1813F43F0
	public void set_Writable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F41D0 Offset: 0x13F27D0 VA: 0x1813F41D0
	public bool get_HasMemberAttribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F4290 Offset: 0x13F2890 VA: 0x1813F4290
	public void set_HasMemberAttribute(bool value) { }

	// RVA: 0x13F41C0 Offset: 0x13F27C0 VA: 0x1813F41C0
	public object get_DefaultValue() { }

	// RVA: 0x13F4280 Offset: 0x13F2880 VA: 0x1813F4280
	public void set_DefaultValue(object value) { }

	// RVA: 0x13F40D0 Offset: 0x13F26D0 VA: 0x1813F40D0
	internal object GetResolvedDefaultValue() { }

	// RVA: 0x13F4220 Offset: 0x13F2820 VA: 0x1813F4220
	public Required get_Required() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F41E0 Offset: 0x13F27E0 VA: 0x1813F41E0
	public Nullable<bool> get_IsReference() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F42A0 Offset: 0x13F28A0 VA: 0x1813F42A0
	public void set_IsReference(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E3FE0 Offset: 0x4E25E0 VA: 0x1804E3FE0
	public Nullable<NullValueHandling> get_NullValueHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F42E0 Offset: 0x13F28E0 VA: 0x1813F42E0
	public void set_NullValueHandling(Nullable<NullValueHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574310 Offset: 0x572910 VA: 0x180574310
	public Nullable<DefaultValueHandling> get_DefaultValueHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F4270 Offset: 0x13F2870 VA: 0x1813F4270
	public void set_DefaultValueHandling(Nullable<DefaultValueHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5742F0 Offset: 0x5728F0 VA: 0x1805742F0
	public Nullable<ReferenceLoopHandling> get_ReferenceLoopHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F43D0 Offset: 0x13F29D0 VA: 0x1813F43D0
	public void set_ReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BDE0 Offset: 0x79A3E0 VA: 0x18079BDE0
	public Nullable<ObjectCreationHandling> get_ObjectCreationHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F42F0 Offset: 0x13F28F0 VA: 0x1813F42F0
	public void set_ObjectCreationHandling(Nullable<ObjectCreationHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BDB0 Offset: 0x79A3B0 VA: 0x18079BDB0
	public Nullable<TypeNameHandling> get_TypeNameHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F43E0 Offset: 0x13F29E0 VA: 0x1813F43E0
	public void set_TypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BDD0 Offset: 0x79A3D0 VA: 0x18079BDD0
	public Predicate<object> get_ShouldSerialize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE50 Offset: 0x79A450 VA: 0x18079BE50
	public void set_ShouldSerialize(Predicate<object> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE20 Offset: 0x79A420 VA: 0x18079BE20
	public Predicate<object> get_ShouldDeserialize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA0E50 Offset: 0xD9F450 VA: 0x180DA0E50
	public Predicate<object> get_GetIsSpecified() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA1230 Offset: 0xD9F830 VA: 0x180DA1230
	public void set_GetIsSpecified(Predicate<object> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BDF0 Offset: 0x79A3F0 VA: 0x18079BDF0
	public Action<object, object> get_SetIsSpecified() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE70 Offset: 0x79A470 VA: 0x18079BE70
	public void set_SetIsSpecified(Action<object, object> value) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0 Slot: 3
	public override string ToString() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA01E0 Offset: 0xD9E7E0 VA: 0x180DA01E0
	public JsonConverter get_ItemConverter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD357D0 Offset: 0xD33DD0 VA: 0x180D357D0
	public void set_ItemConverter(JsonConverter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F41F0 Offset: 0x13F27F0 VA: 0x1813F41F0
	public Nullable<bool> get_ItemIsReference() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F42B0 Offset: 0x13F28B0 VA: 0x1813F42B0
	public void set_ItemIsReference(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F4210 Offset: 0x13F2810 VA: 0x1813F4210
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F42D0 Offset: 0x13F28D0 VA: 0x1813F42D0
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F4200 Offset: 0x13F2800 VA: 0x1813F4200
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F42C0 Offset: 0x13F28C0 VA: 0x1813F42C0
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	// RVA: 0x13F4170 Offset: 0x13F2770 VA: 0x1813F4170
	internal void WritePropertyName(JsonWriter writer) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class JsonPropertyCollection : KeyedCollection<string, JsonProperty> // TypeDefIndex: 6016
{	// Fields
	private readonly Type _type; // 0x38
	private readonly List<JsonProperty> _list; // 0x40

	// Methods

	// RVA: 0x13F3F90 Offset: 0x13F2590 VA: 0x1813F3F90
	public void .ctor(Type type) { }

	// RVA: 0x13F3CF0 Offset: 0x13F22F0 VA: 0x1813F3CF0 Slot: 38
	protected override string GetKeyForItem(JsonProperty item) { }

	// RVA: 0x13F3A90 Offset: 0x13F2090 VA: 0x1813F3A90
	public void AddProperty(JsonProperty property) { }

	// RVA: 0x13F3CB0 Offset: 0x13F22B0 VA: 0x1813F3CB0
	public JsonProperty GetClosestMatchProperty(string propertyName) { }

	// RVA: 0x13F3EB0 Offset: 0x13F24B0 VA: 0x1813F3EB0
	private bool TryGetValue(string key, out JsonProperty item) { }

	// RVA: 0x13F3D10 Offset: 0x13F2310 VA: 0x1813F3D10
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
	// RVA: 0x107AB70 Offset: 0x1079170 VA: 0x18107AB70
	public MemberSerialization get_MemberSerialization() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107ACE0 Offset: 0x10792E0 VA: 0x18107ACE0
	public void set_MemberSerialization(MemberSerialization value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F3520 Offset: 0x13F1B20 VA: 0x1813F3520
	public Nullable<Required> get_ItemRequired() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13F35F0 Offset: 0x13F1BF0 VA: 0x1813F35F0
	public void set_ItemRequired(Nullable<Required> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BDF0 Offset: 0x79A3F0 VA: 0x18079BDF0
	public JsonPropertyCollection get_Properties() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE70 Offset: 0x79A470 VA: 0x18079BE70
	private void set_Properties(JsonPropertyCollection value) { }

	// RVA: 0x13F3230 Offset: 0x13F1830 VA: 0x1813F3230
	public JsonPropertyCollection get_CreatorParameters() { }

	// RVA: 0x13F3600 Offset: 0x13F1C00 VA: 0x1813F3600
	public void set_OverrideConstructor(ConstructorInfo value) { }

	// RVA: 0x13F36B0 Offset: 0x13F1CB0 VA: 0x1813F36B0
	public void set_ParametrizedConstructor(ConstructorInfo value) { }

	// RVA: 0xA2B0D0 Offset: 0xA296D0 VA: 0x180A2B0D0
	public ObjectConstructor<object> get_OverrideCreator() { }

	// RVA: 0xC83900 Offset: 0xC81F00 VA: 0x180C83900
	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA01E0 Offset: 0xD9E7E0 VA: 0x180DA01E0
	public ExtensionDataSetter get_ExtensionDataSetter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD357D0 Offset: 0xD33DD0 VA: 0x180D357D0
	public void set_ExtensionDataSetter(ExtensionDataSetter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4EF330 Offset: 0x4ED930 VA: 0x1804EF330
	public ExtensionDataGetter get_ExtensionDataGetter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4EF340 Offset: 0x4ED940 VA: 0x1804EF340
	public void set_ExtensionDataGetter(ExtensionDataGetter value) { }

	// RVA: 0x13F3530 Offset: 0x13F1B30 VA: 0x1813F3530
	public void set_ExtensionDataValueType(Type value) { }

	// RVA: 0x13F32B0 Offset: 0x13F18B0 VA: 0x1813F32B0
	internal bool get_HasRequiredOrDefaultValueProperties() { }

	// RVA: 0x13F31A0 Offset: 0x13F17A0 VA: 0x1813F31A0
	public void .ctor(Type underlyingType) { }

	// RVA: 0x13F30A0 Offset: 0x13F16A0 VA: 0x1813F30A0
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

	// RVA: 0x13F4950 Offset: 0x13F2F50 VA: 0x1813F4950
	protected void .ctor(JsonSerializer serializer) { }

	// RVA: 0x13F49E0 Offset: 0x13F2FE0 VA: 0x1813F49E0
	internal BidirectionalDictionary<string, object> get_DefaultReferenceMappings() { }

	// RVA: 0x13F4480 Offset: 0x13F2A80 VA: 0x1813F4480
	private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error) { }

	// RVA: 0x13F4400 Offset: 0x13F2A00 VA: 0x1813F4400
	protected void ClearErrorContext() { }

	// RVA: 0x13F45A0 Offset: 0x13F2BA0 VA: 0x1813F45A0
	protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex) { }

}

private class JsonSerializerInternalBase.ReferenceEqualsEqualityComparer : IEqualityComparer<object> // TypeDefIndex: 6020
{	// Methods

	// RVA: 0x13CECD0 Offset: 0x13CD2D0 VA: 0x1813CECD0 Slot: 4
	private bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y) { }

	// RVA: 0x1407640 Offset: 0x1405C40 VA: 0x181407640 Slot: 5
	private int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal class JsonSerializerInternalReader : JsonSerializerInternalBase // TypeDefIndex: 6021
{	// Methods

	// RVA: 0x13F4950 Offset: 0x13F2F50 VA: 0x1813F4950
	public void .ctor(JsonSerializer serializer) { }

	// RVA: 0x13FE080 Offset: 0x13FC680 VA: 0x1813FE080
	public void Populate(JsonReader reader, object target) { }

	// RVA: 0x13FB150 Offset: 0x13F9750 VA: 0x1813FB150
	private JsonContract GetContractSafe(Type type) { }

	// RVA: 0x13FA380 Offset: 0x13F8980 VA: 0x1813FA380
	public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent) { }

	// RVA: 0x13FB330 Offset: 0x13F9930 VA: 0x1813FB330
	private JsonSerializerProxy GetInternalSerializer() { }

	// RVA: 0x13F5D80 Offset: 0x13F4380 VA: 0x1813F5D80
	private JToken CreateJToken(JsonReader reader, JsonContract contract) { }

	// RVA: 0x13F5B20 Offset: 0x13F4120 VA: 0x1813F5B20
	private JToken CreateJObject(JsonReader reader) { }

	// RVA: 0x13F9BD0 Offset: 0x13F81D0 VA: 0x1813F9BD0
	private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	// RVA: 0x13F5220 Offset: 0x13F3820 VA: 0x1813F5220
	private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s) { }

	// RVA: 0x13FB260 Offset: 0x13F9860 VA: 0x1813FB260
	internal string GetExpectedDescription(JsonContract contract) { }

	// RVA: 0x13FB1C0 Offset: 0x13F97C0 VA: 0x1813FB1C0
	private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x13F8350 Offset: 0x13F6950 VA: 0x1813F8350
	private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	// RVA: 0x13FE8E0 Offset: 0x13FCEE0 VA: 0x1813FE8E0
	private bool ReadMetadataPropertiesToken(JTokenReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	// RVA: 0x13FEF40 Offset: 0x13FD540 VA: 0x1813FEF40
	private bool ReadMetadataProperties(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	// RVA: 0x1400010 Offset: 0x13FE610 VA: 0x181400010
	private void ResolveTypeName(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName) { }

	// RVA: 0x13FACA0 Offset: 0x13F92A0 VA: 0x1813FACA0
	private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract) { }

	// RVA: 0x13F5FA0 Offset: 0x13F45A0 VA: 0x1813F5FA0
	private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id) { }

	// RVA: 0x13FB440 Offset: 0x13F9A40 VA: 0x1813FB440
	private bool HasNoDefinedType(JsonContract contract) { }

	// RVA: 0x13FAE40 Offset: 0x13F9440 VA: 0x1813FAE40
	private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType) { }

	// RVA: 0x14006C0 Offset: 0x13FECC0 VA: 0x1814006C0
	private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target) { }

	// RVA: 0x13F4CE0 Offset: 0x13F32E0 VA: 0x1813F4CE0
	private bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue) { }

	// RVA: 0x13F4AB0 Offset: 0x13F30B0 VA: 0x1813F4AB0
	private void AddReference(JsonReader reader, string id, object value) { }

	// RVA: 0xF9CD40 Offset: 0xF9B340 VA: 0x180F9CD40
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	// RVA: 0x1400F30 Offset: 0x13FF530 VA: 0x181400F30
	private bool ShouldSetPropertyValue(JsonProperty property, object value) { }

	// RVA: 0x13F6A90 Offset: 0x13F5090 VA: 0x1813F6A90
	private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x13F6800 Offset: 0x13F4E00 VA: 0x1813F6800
	private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x13FB660 Offset: 0x13F9C60 VA: 0x1813FB660
	private void OnDeserializing(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0x13FB4D0 Offset: 0x13F9AD0 VA: 0x1813FB4D0
	private void OnDeserialized(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0x13FB7F0 Offset: 0x13F9DF0 VA: 0x1813FB7F0
	private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x13FCA80 Offset: 0x13FB080 VA: 0x1813FCA80
	private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x1401060 Offset: 0x13FF660 VA: 0x181401060
	private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message) { }

	// RVA: 0x13FC360 Offset: 0x13FA960 VA: 0x1813FC360
	private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x13F54C0 Offset: 0x13F3AC0 VA: 0x1813F54C0
	private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id) { }

	// RVA: 0x13F5310 Offset: 0x13F3910 VA: 0x1813F5310
	internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: 0x13F7020 Offset: 0x13F5620 VA: 0x1813F7020
	private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, ObjectConstructor<object> creator, string id) { }

	// RVA: 0x13FA080 Offset: 0x13F8680 VA: 0x1813FA080
	private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue) { }

	// RVA: 0x13FF560 Offset: 0x13FDB60 VA: 0x1813FF560
	private List<JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType) { }

	// RVA: 0x13FE6A0 Offset: 0x13FCCA0 VA: 0x1813FE6A0
	private bool ReadForType(JsonReader reader, JsonContract contract, bool hasConverter) { }

	// RVA: 0x13F6DC0 Offset: 0x13F53C0 VA: 0x1813F6DC0
	public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x13FD310 Offset: 0x13FB910 VA: 0x1813FD310
	private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id) { }

	// RVA: 0x1400D80 Offset: 0x13FF380 VA: 0x181400D80
	private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target) { }

	// RVA: 0x13F5130 Offset: 0x13F3730 VA: 0x1813F5130
	private bool CheckPropertyName(JsonReader reader, string memberName) { }

	// RVA: 0x1400450 Offset: 0x13FEA50 VA: 0x181400450
	private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o) { }

	// RVA: 0x13FE5E0 Offset: 0x13FCBE0 VA: 0x1813FE5E0
	private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader) { }

	// RVA: 0x13FA860 Offset: 0x13F8E60 VA: 0x1813FA860
	private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, JsonSerializerInternalReader.PropertyPresence presence, bool setDefaultValue) { }

	// RVA: 0x14005A0 Offset: 0x13FEBA0 VA: 0x1814005A0
	private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> requiredProperties) { }

	// RVA: 0x13FB3B0 Offset: 0x13F99B0 VA: 0x1813FB3B0
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

	// RVA: 0x14081B0 Offset: 0x14067B0 VA: 0x1814081B0
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

	// RVA: 0x1408550 Offset: 0x1406B50 VA: 0x181408550
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13F3CF0 Offset: 0x13F22F0 VA: 0x1813F3CF0
	internal string <CreateObjectUsingCreatorWithParameters>b__36_0(JsonProperty p) { }

	// RVA: 0x13F3CF0 Offset: 0x13F22F0 VA: 0x1813F3CF0
	internal string <CreateObjectUsingCreatorWithParameters>b__36_2(JsonProperty p) { }

	// RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380
	internal JsonProperty <PopulateObject>b__41_0(JsonProperty m) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0
	internal JsonSerializerInternalReader.PropertyPresence <PopulateObject>b__41_1(JsonProperty m) { }

}

internal class JsonSerializerInternalWriter : JsonSerializerInternalBase // TypeDefIndex: 6026
{	// Fields
	private Type _rootType; // 0x38
	private int _rootLevel; // 0x40
	private readonly List<object> _serializeStack; // 0x48

	// Methods

	// RVA: 0x1407560 Offset: 0x1405B60 VA: 0x181407560
	public void .ctor(JsonSerializer serializer) { }

	// RVA: 0x1405EA0 Offset: 0x14044A0 VA: 0x181405EA0
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0x1401D10 Offset: 0x1400310 VA: 0x181401D10
	private JsonSerializerProxy GetInternalSerializer() { }

	// RVA: 0x1401C90 Offset: 0x1400290 VA: 0x181401C90
	private JsonContract GetContractSafe(object value) { }

	// RVA: 0x1404E50 Offset: 0x1403450 VA: 0x181404E50
	private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x1405190 Offset: 0x1403790 VA: 0x181405190
	private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x14027A0 Offset: 0x1400DA0 VA: 0x1814027A0
	private Nullable<bool> ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1406410 Offset: 0x1404A10 VA: 0x181406410
	private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1406320 Offset: 0x1404920 VA: 0x181406320
	private bool ShouldWriteProperty(object memberValue, JsonProperty property) { }

	// RVA: 0x14018E0 Offset: 0x13FFEE0 VA: 0x1814018E0
	private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x1406DD0 Offset: 0x14053D0 VA: 0x181406DD0
	private void WriteReference(JsonWriter writer, object value) { }

	// RVA: 0x1402100 Offset: 0x1400700 VA: 0x181402100
	private string GetReference(JsonWriter writer, object value) { }

	// RVA: 0x1406760 Offset: 0x1404D60 VA: 0x181406760
	internal static bool TryConvertToString(object value, Type type, out string s) { }

	// RVA: 0x14050E0 Offset: 0x14036E0 VA: 0x1814050E0
	private void SerializeString(JsonWriter writer, object value, JsonStringContract contract) { }

	// RVA: 0x1402630 Offset: 0x1400C30 VA: 0x181402630
	private void OnSerializing(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0x14024C0 Offset: 0x1400AC0 VA: 0x1814024C0
	private void OnSerialized(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0x1404590 Offset: 0x1402B90 VA: 0x181404590
	private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1401170 Offset: 0x13FF770 VA: 0x181401170
	private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, out JsonContract memberContract, out object memberValue) { }

	// RVA: 0x14069B0 Offset: 0x1404FB0 VA: 0x1814069B0
	private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1406C40 Offset: 0x1405240 VA: 0x181406C40
	private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value) { }

	// RVA: 0x14073A0 Offset: 0x14059A0 VA: 0x1814073A0
	private void WriteTypeProperty(JsonWriter writer, Type type) { }

	// RVA: 0xF9CD40 Offset: 0xF9B340 VA: 0x180F9CD40
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	// RVA: 0xF9CD40 Offset: 0xF9B340 VA: 0x180F9CD40
	private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag) { }

	// RVA: 0xF9CD40 Offset: 0xF9B340 VA: 0x180F9CD40
	private bool HasFlag(TypeNameHandling value, TypeNameHandling flag) { }

	// RVA: 0x1402850 Offset: 0x1400E50 VA: 0x181402850
	private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1403B30 Offset: 0x1402130 VA: 0x181403B30
	private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1404420 Offset: 0x1402A20 VA: 0x181404420
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1404020 Offset: 0x1402620 VA: 0x181404020
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices) { }

	// RVA: 0x1406FA0 Offset: 0x14055A0 VA: 0x181406FA0
	private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x1403470 Offset: 0x1401A70 VA: 0x181403470
	private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x14065F0 Offset: 0x1404BF0 VA: 0x1814065F0
	private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x1402BF0 Offset: 0x14011F0 VA: 0x181402BF0
	private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1401D90 Offset: 0x1400390 VA: 0x181401D90
	private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape) { }

	// RVA: 0x1402290 Offset: 0x1400890 VA: 0x181402290
	private void HandleError(JsonWriter writer, int initialDepth) { }

	// RVA: 0x1406170 Offset: 0x1404770 VA: 0x181406170
	private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target) { }

	// RVA: 0x1402310 Offset: 0x1400910 VA: 0x181402310
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

	// RVA: 0x17F5ED0 Offset: 0x17F44D0 VA: 0x1817F5ED0 Slot: 4
	public override void add_Error(EventHandler<ErrorEventArgs> value) { }

	// RVA: 0x17F6090 Offset: 0x17F4690 VA: 0x1817F6090 Slot: 5
	public override void remove_Error(EventHandler<ErrorEventArgs> value) { }

	// RVA: 0x17F6370 Offset: 0x17F4970 VA: 0x1817F6370 Slot: 6
	public override void set_ReferenceResolver(IReferenceResolver value) { }

	// RVA: 0x17F6060 Offset: 0x17F4660 VA: 0x1817F6060 Slot: 8
	public override ITraceWriter get_TraceWriter() { }

	// RVA: 0x17F63A0 Offset: 0x17F49A0 VA: 0x1817F63A0 Slot: 9
	public override void set_TraceWriter(ITraceWriter value) { }

	// RVA: 0x17F61F0 Offset: 0x17F47F0 VA: 0x1817F61F0 Slot: 10
	public override void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0x17F5FA0 Offset: 0x17F45A0 VA: 0x1817F5FA0 Slot: 23
	public override JsonConverterCollection get_Converters() { }

	// RVA: 0x17F61C0 Offset: 0x17F47C0 VA: 0x1817F61C0 Slot: 17
	public override void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0x17F5F70 Offset: 0x17F4570 VA: 0x1817F5F70 Slot: 24
	public override IContractResolver get_ContractResolver() { }

	// RVA: 0x17F6190 Offset: 0x17F4790 VA: 0x1817F6190 Slot: 25
	public override void set_ContractResolver(IContractResolver value) { }

	// RVA: 0x17F6280 Offset: 0x17F4880 VA: 0x1817F6280 Slot: 15
	public override void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0x17F62B0 Offset: 0x17F48B0 VA: 0x1817F62B0 Slot: 16
	public override void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0x17F6030 Offset: 0x17F4630 VA: 0x1817F6030 Slot: 18
	public override ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0x17F62E0 Offset: 0x17F48E0 VA: 0x1817F62E0 Slot: 19
	public override void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0x17F6340 Offset: 0x17F4940 VA: 0x1817F6340 Slot: 14
	public override void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0x17F6310 Offset: 0x17F4910 VA: 0x1817F6310 Slot: 13
	public override void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0x17F6400 Offset: 0x17F4A00 VA: 0x1817F6400 Slot: 11
	public override void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0x17F6000 Offset: 0x17F4600 VA: 0x1817F6000 Slot: 21
	public override MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0x17F6250 Offset: 0x17F4850 VA: 0x1817F6250 Slot: 22
	public override void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0x17F63D0 Offset: 0x17F49D0 VA: 0x1817F63D0 Slot: 12
	public override void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	// RVA: 0x17F6120 Offset: 0x17F4720 VA: 0x1817F6120 Slot: 20
	public override void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0x17F60C0 Offset: 0x17F46C0 VA: 0x1817F60C0 Slot: 7
	public override void set_Binder(SerializationBinder value) { }

	// RVA: 0x17F5F30 Offset: 0x17F4530 VA: 0x1817F5F30 Slot: 26
	public override StreamingContext get_Context() { }

	// RVA: 0x17F6150 Offset: 0x17F4750 VA: 0x1817F6150 Slot: 27
	public override void set_Context(StreamingContext value) { }

	// RVA: 0x17F5FD0 Offset: 0x17F45D0 VA: 0x1817F5FD0 Slot: 28
	public override Formatting get_Formatting() { }

	// RVA: 0x17F6220 Offset: 0x17F4820 VA: 0x1817F6220 Slot: 29
	public override void set_Formatting(Formatting value) { }

	// RVA: 0x17F5F00 Offset: 0x17F4500 VA: 0x1817F5F00 Slot: 30
	public override bool get_CheckAdditionalContent() { }

	// RVA: 0x17F60F0 Offset: 0x17F46F0 VA: 0x1817F60F0 Slot: 31
	public override void set_CheckAdditionalContent(bool value) { }

	// RVA: 0x17F5C80 Offset: 0x17F4280 VA: 0x1817F5C80
	internal JsonSerializerInternalBase GetInternalSerializer() { }

	// RVA: 0x17F5D30 Offset: 0x17F4330 VA: 0x1817F5D30
	public void .ctor(JsonSerializerInternalReader serializerReader) { }

	// RVA: 0x17F5E00 Offset: 0x17F4400 VA: 0x1817F5E00
	public void .ctor(JsonSerializerInternalWriter serializerWriter) { }

	// RVA: 0x17F5C30 Offset: 0x17F4230 VA: 0x1817F5C30 Slot: 33
	internal override object DeserializeInternal(JsonReader reader, Type objectType) { }

	// RVA: 0x17F5CA0 Offset: 0x17F42A0 VA: 0x1817F5CA0 Slot: 32
	internal override void PopulateInternal(JsonReader reader, object target) { }

	// RVA: 0x17F5CE0 Offset: 0x17F42E0 VA: 0x1817F5CE0 Slot: 34
	internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType) { }

}

public class JsonStringContract : JsonPrimitiveContract // TypeDefIndex: 6028
{	// Methods

	// RVA: 0x17F6430 Offset: 0x17F4A30 VA: 0x1817F6430
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
	|-RVA: 0x5D1170 Offset: 0x5CF770 VA: 0x1805D1170
	|-JsonTypeReflector.GetCachedAttribute<JsonContainerAttribute>
	|-JsonTypeReflector.GetCachedAttribute<JsonConverterAttribute>
	|-JsonTypeReflector.GetCachedAttribute<JsonObjectAttribute>
	|-JsonTypeReflector.GetCachedAttribute<object>
	|-JsonTypeReflector.GetCachedAttribute<SerializableAttribute>
	*/

	// RVA: 0x17F6910 Offset: 0x17F4F10 VA: 0x1817F6910
	public static DataContractAttribute GetDataContractAttribute(Type type) { }

	// RVA: 0x17F69A0 Offset: 0x17F4FA0 VA: 0x1817F69A0
	public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo) { }

	// RVA: 0x17F7130 Offset: 0x17F5730 VA: 0x1817F7130
	public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute) { }

	// RVA: 0x17F7060 Offset: 0x17F5660 VA: 0x1817F7060
	public static JsonConverter GetJsonConverter(object attributeProvider) { }

	// RVA: 0x17F6530 Offset: 0x17F4B30 VA: 0x1817F6530
	public static JsonConverter CreateJsonConverterInstance(Type converterType, object[] converterArgs) { }

	// RVA: 0x17F6F10 Offset: 0x17F5510 VA: 0x1817F6F10
	private static Func<object[], JsonConverter> GetJsonConverterCreator(Type converterType) { }

	// RVA: 0x17F72D0 Offset: 0x17F58D0 VA: 0x1817F72D0
	public static TypeConverter GetTypeConverter(Type type) { }

	// RVA: 0x17F6890 Offset: 0x17F4E90 VA: 0x1817F6890
	private static Type GetAssociatedMetadataType(Type type) { }

	// RVA: 0x17F65D0 Offset: 0x17F4BD0 VA: 0x1817F65D0
	private static Type GetAssociateMetadataTypeFromAttribute(Type type) { }

	// RVA: -1 Offset: -1
	private static T GetAttribute<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0FF0 Offset: 0x5CF5F0 VA: 0x1805D0FF0
	|-JsonTypeReflector.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	private static T GetAttribute<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0C90 Offset: 0x5CF290 VA: 0x1805D0C90
	|-JsonTypeReflector.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(object provider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0EE0 Offset: 0x5CF4E0 VA: 0x1805D0EE0
	|-JsonTypeReflector.GetAttribute<JsonExtensionDataAttribute>
	|-JsonTypeReflector.GetAttribute<JsonIgnoreAttribute>
	|-JsonTypeReflector.GetAttribute<JsonPropertyAttribute>
	|-JsonTypeReflector.GetAttribute<JsonRequiredAttribute>
	|-JsonTypeReflector.GetAttribute<DefaultValueAttribute>
	|-JsonTypeReflector.GetAttribute<NonSerializedAttribute>
	|-JsonTypeReflector.GetAttribute<object>
	|-JsonTypeReflector.GetAttribute<DataMemberAttribute>
	*/

	// RVA: 0x17F7430 Offset: 0x17F5A30 VA: 0x1817F7430
	public static bool get_FullyTrusted() { }

	// RVA: 0x17F75B0 Offset: 0x17F5BB0 VA: 0x1817F75B0
	public static ReflectionDelegateFactory get_ReflectionDelegateFactory() { }

	// RVA: 0x17F7330 Offset: 0x17F5930 VA: 0x1817F7330
	private static void .cctor() { }

}

private sealed class JsonTypeReflector.<>c__DisplayClass18_0 // TypeDefIndex: 6030
{	// Fields
	public Type converterType; // 0x10
	public Func<object> defaultConstructor; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x18024E0 Offset: 0x1800AE0 VA: 0x1818024E0
	internal JsonConverter <GetJsonConverterCreator>b__0(object[] parameters) { }

}

private sealed class JsonTypeReflector.<>c // TypeDefIndex: 6031
{	// Fields
	public static readonly JsonTypeReflector.<>c <>9; // 0x0
	public static Func<object, Type> <>9__18_1; // 0x8

	// Methods

	// RVA: 0x1802CF0 Offset: 0x18012F0 VA: 0x181802CF0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x98C680 Offset: 0x98AC80 VA: 0x18098C680
	internal Type <GetJsonConverterCreator>b__18_1(object param) { }

}

public class JPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 6038
{	// Properties
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	protected override int NameHashCode { get; }

	// Methods

	// RVA: 0xE36C90 Offset: 0xE35290 VA: 0x180E36C90
	public void .ctor(string name) { }

	// RVA: 0xE36860 Offset: 0xE34E60 VA: 0x180E36860
	private static JObject CastInstance(object instance) { }

	// RVA: 0xE368E0 Offset: 0xE34EE0 VA: 0x180E368E0 Slot: 17
	public override object GetValue(object component) { }

	// RVA: 0xE36A00 Offset: 0xE35000 VA: 0x180E36A00 Slot: 19
	public override void SetValue(object component, object value) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 20
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0xE36CA0 Offset: 0xE352A0 VA: 0x180E36CA0 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0xE36D00 Offset: 0xE35300 VA: 0x180E36D00 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760 Slot: 8
	protected override int get_NameHashCode() { }

}

internal class JPropertyKeyedCollection : Collection<JToken> // TypeDefIndex: 6039
{	// Fields
	private static readonly IEqualityComparer<string> Comparer; // 0x0
	private Dictionary<string, JToken> _dictionary; // 0x20

	// Properties
	public ICollection<string> Keys { get; }

	// Methods

	// RVA: 0xE37950 Offset: 0xE35F50 VA: 0x180E37950
	public void .ctor() { }

	// RVA: 0xE36D60 Offset: 0xE35360 VA: 0x180E36D60
	private void AddKey(string key, JToken item) { }

	// RVA: 0xE36DD0 Offset: 0xE353D0 VA: 0x180E36DD0 Slot: 34
	protected override void ClearItems() { }

	// RVA: 0xE371B0 Offset: 0xE357B0 VA: 0x180E371B0
	public bool Contains(string key) { }

	// RVA: 0xE37240 Offset: 0xE35840 VA: 0x180E37240
	private void EnsureDictionary() { }

	// RVA: 0xE372F0 Offset: 0xE358F0 VA: 0x180E372F0
	private string GetKeyForItem(JToken item) { }

	// RVA: 0xE37450 Offset: 0xE35A50 VA: 0x180E37450 Slot: 35
	protected override void InsertItem(int index, JToken item) { }

	// RVA: 0xE37510 Offset: 0xE35B10 VA: 0x180E37510 Slot: 36
	protected override void RemoveItem(int index) { }

	// RVA: 0xE375D0 Offset: 0xE35BD0 VA: 0x180E375D0
	private void RemoveKey(string key) { }

	// RVA: 0xE37620 Offset: 0xE35C20 VA: 0x180E37620 Slot: 37
	protected override void SetItem(int index, JToken item) { }

	// RVA: 0xE37820 Offset: 0xE35E20 VA: 0x180E37820
	public bool TryGetValue(string key, out JToken value) { }

	// RVA: 0xE379C0 Offset: 0xE35FC0 VA: 0x180E379C0
	public ICollection<string> get_Keys() { }

	// RVA: 0xE373B0 Offset: 0xE359B0 VA: 0x180E373B0
	public int IndexOfReference(JToken t) { }

	// RVA: 0xE36E30 Offset: 0xE35430 VA: 0x180E36E30
	public bool Compare(JPropertyKeyedCollection other) { }

	// RVA: 0xE378A0 Offset: 0xE35EA0 VA: 0x180E378A0
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

	// RVA: 0x57C960 Offset: 0x57AF60 VA: 0x18057C960
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

	// RVA: 0xE39070 Offset: 0xE37670 VA: 0x180E39070 Slot: 4
	public bool Equals(JToken x, JToken y) { }

	// RVA: 0xE39110 Offset: 0xE37710 VA: 0x180E39110 Slot: 5
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

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800 Slot: 45
	protected override IList<JToken> get_ChildrenTokens() { }

	// RVA: 0xE31980 Offset: 0xE2FF80 VA: 0x180E31980 Slot: 47
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public string get_Name() { }

	// RVA: 0xAC2530 Offset: 0xAC0B30 VA: 0x180AC2530 Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0xE31DB0 Offset: 0xE303B0 VA: 0x180E31DB0
	public void .ctor() { }

	// RVA: 0xE31FA0 Offset: 0xE305A0 VA: 0x180E31FA0
	public void .ctor(JConstructor other) { }

	// RVA: 0xE31E60 Offset: 0xE30460 VA: 0x180E31E60
	public void .ctor(string name) { }

	// RVA: 0xE31770 Offset: 0xE2FD70 VA: 0x180E31770 Slot: 11
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0xE316B0 Offset: 0xE2FCB0 VA: 0x180E316B0 Slot: 10
	internal override JToken CloneToken() { }

	// RVA: 0xE31BC0 Offset: 0xE301C0 VA: 0x180E31BC0 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE31930 Offset: 0xE2FF30 VA: 0x180E31930 Slot: 18
	internal override int GetDeepHashCode() { }

	// RVA: 0xE319D0 Offset: 0xE2FFD0 VA: 0x180E319D0
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

	// RVA: 0xE349A0 Offset: 0xE32FA0 VA: 0x180E349A0
	internal void .ctor() { }

	// RVA: 0xE34A00 Offset: 0xE33000 VA: 0x180E34A00
	internal void .ctor(JContainer other) { }

	// RVA: 0xE32450 Offset: 0xE30A50 VA: 0x180E32450
	internal void CheckReentrancy() { }

	// RVA: 0xE33390 Offset: 0xE31990 VA: 0x180E33390 Slot: 46
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xE34CD0 Offset: 0xE332D0 VA: 0x180E34CD0 Slot: 13
	public override bool get_HasValues() { }

	// RVA: 0xE327B0 Offset: 0xE30DB0 VA: 0x180E327B0
	internal bool ContentsEqual(JContainer container) { }

	// RVA: 0xE34C50 Offset: 0xE33250 VA: 0x180E34C50 Slot: 14
	public override JToken get_First() { }

	// RVA: 0xE34D30 Offset: 0xE33330 VA: 0x180E34D30 Slot: 15
	public override JToken get_Last() { }

	// RVA: 0xE32500 Offset: 0xE30B00 VA: 0x180E32500 Slot: 16
	public override JEnumerable<JToken> Children() { }

	// RVA: 0xE33200 Offset: 0xE31800 VA: 0x180E33200
	internal bool IsMultiContent(object content) { }

	// RVA: 0xE32DE0 Offset: 0xE313E0 VA: 0x180E32DE0
	internal JToken EnsureParentToken(JToken item, bool skipParentCheck) { }

	// RVA: -1 Offset: -1 Slot: 47
	internal abstract int IndexOfItem(JToken item);

	// RVA: 0xE32F90 Offset: 0xE31590 VA: 0x180E32F90 Slot: 48
	internal virtual void InsertItem(int index, JToken item, bool skipParentCheck) { }

	// RVA: 0xE33CC0 Offset: 0xE322C0 VA: 0x180E33CC0 Slot: 49
	internal virtual void RemoveItemAt(int index) { }

	// RVA: 0xE33F60 Offset: 0xE32560 VA: 0x180E33F60 Slot: 50
	internal virtual bool RemoveItem(JToken item) { }

	// RVA: 0xE32F20 Offset: 0xE31520 VA: 0x180E32F20 Slot: 51
	internal virtual JToken GetItem(int index) { }

	// RVA: 0xE34000 Offset: 0xE32600 VA: 0x180E34000 Slot: 52
	internal virtual void SetItem(int index, JToken item) { }

	// RVA: 0xE32560 Offset: 0xE30B60 VA: 0x180E32560 Slot: 53
	internal virtual void ClearItems() { }

	// RVA: 0xE33FB0 Offset: 0xE325B0 VA: 0x180E33FB0 Slot: 54
	internal virtual void ReplaceItem(JToken existing, JToken replacement) { }

	// RVA: 0xE32790 Offset: 0xE30D90 VA: 0x180E32790 Slot: 55
	internal virtual bool ContainsItem(JToken item) { }

	// RVA: 0xE32AC0 Offset: 0xE310C0 VA: 0x180E32AC0 Slot: 56
	internal virtual void CopyItemsTo(Array array, int arrayIndex) { }

	// RVA: 0xE332B0 Offset: 0xE318B0 VA: 0x180E332B0
	internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue) { }

	// RVA: 0xE34890 Offset: 0xE32E90 VA: 0x180E34890 Slot: 57
	internal virtual void ValidateToken(JToken o, JToken existing) { }

	// RVA: 0xE323D0 Offset: 0xE309D0 VA: 0x180E323D0 Slot: 58
	public virtual void Add(object content) { }

	// RVA: 0xE32040 Offset: 0xE30640 VA: 0x180E32040
	internal void AddAndSkipParentCheck(JToken token) { }

	// RVA: 0xE320C0 Offset: 0xE306C0 VA: 0x180E320C0
	internal void AddInternal(int index, object content, bool skipParentCheck) { }

	// RVA: 0xE32D30 Offset: 0xE31330 VA: 0x180E32D30
	internal static JToken CreateFromContent(object content) { }

	// RVA: 0xE30DC0 Offset: 0xE2F3C0 VA: 0x180E30DC0
	public void RemoveAll() { }

	// RVA: 0xE33B10 Offset: 0xE32110 VA: 0x180E33B10
	internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options) { }

	// RVA: 0xE33430 Offset: 0xE31A30 VA: 0x180E33430
	internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings) { }

	// RVA: 0xE328F0 Offset: 0xE30EF0 VA: 0x180E328F0
	internal int ContentsHashCode() { }

	// RVA: 0xE31130 Offset: 0xE2F730 VA: 0x180E31130 Slot: 21
	private int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(JToken item) { }

	// RVA: 0xE31150 Offset: 0xE2F750 VA: 0x180E31150 Slot: 22
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, JToken item) { }

	// RVA: 0xE31330 Offset: 0xE2F930 VA: 0x180E31330 Slot: 23
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index) { }

	// RVA: 0xE31670 Offset: 0xE2FC70 VA: 0x180E31670 Slot: 19
	private JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(int index) { }

	// RVA: 0xE31690 Offset: 0xE2FC90 VA: 0x180E31690 Slot: 20
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(int index, JToken value) { }

	// RVA: 0xE30DA0 Offset: 0xE2F3A0 VA: 0x180E30DA0 Slot: 26
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(JToken item) { }

	// RVA: 0xE30DC0 Offset: 0xE2F3C0 VA: 0x180E30DC0 Slot: 27
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear() { }

	// RVA: 0xE30E90 Offset: 0xE2F490 VA: 0x180E30E90 Slot: 28
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(JToken item) { }

	// RVA: 0xE30EB0 Offset: 0xE2F4B0 VA: 0x180E30EB0 Slot: 29
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 25
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly() { }

	// RVA: 0xE31350 Offset: 0xE2F950 VA: 0x180E31350 Slot: 30
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(JToken item) { }

	// RVA: 0xE32E80 Offset: 0xE31480 VA: 0x180E32E80
	private JToken EnsureValue(object value) { }

	// RVA: 0xE34390 Offset: 0xE32990 VA: 0x180E34390 Slot: 33
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0xE30DC0 Offset: 0xE2F3C0 VA: 0x180E30DC0 Slot: 35
	private void System.Collections.IList.Clear() { }

	// RVA: 0xE344A0 Offset: 0xE32AA0 VA: 0x180E344A0 Slot: 34
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0xE34560 Offset: 0xE32B60 VA: 0x180E34560 Slot: 38
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0xE34620 Offset: 0xE32C20 VA: 0x180E34620 Slot: 39
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 37
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 36
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xE34700 Offset: 0xE32D00 VA: 0x180E34700 Slot: 40
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0xE31330 Offset: 0xE2F930 VA: 0x180E31330 Slot: 41
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0xE31670 Offset: 0xE2FC70 VA: 0x180E31670 Slot: 31
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0xE347C0 Offset: 0xE32DC0 VA: 0x180E347C0 Slot: 32
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0xE30EB0 Offset: 0xE2F4B0 VA: 0x180E30EB0 Slot: 42
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0xE34BF0 Offset: 0xE331F0 VA: 0x180E34BF0 Slot: 43
	public int get_Count() { }

	// RVA: 0xE34320 Offset: 0xE32920 VA: 0x180E34320 Slot: 44
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

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0 Slot: 45
	protected override IList<JToken> get_ChildrenTokens() { }

	// RVA: 0xE365C0 Offset: 0xE34BC0 VA: 0x180E365C0
	public void .ctor() { }

	// RVA: 0xE36500 Offset: 0xE34B00 VA: 0x180E36500
	public void .ctor(JObject other) { }

	// RVA: 0xE34F30 Offset: 0xE33530 VA: 0x180E34F30 Slot: 11
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0xE35040 Offset: 0xE33640 VA: 0x180E35040 Slot: 47
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xE350E0 Offset: 0xE336E0 VA: 0x180E350E0 Slot: 48
	internal override void InsertItem(int index, JToken item, bool skipParentCheck) { }

	// RVA: 0xE36140 Offset: 0xE34740 VA: 0x180E36140 Slot: 57
	internal override void ValidateToken(JToken o, JToken existing) { }

	// RVA: 0xE35150 Offset: 0xE33750 VA: 0x180E35150
	internal void InternalPropertyChanged(JProperty childProperty) { }

	// RVA: 0xE35210 Offset: 0xE33810 VA: 0x180E35210
	internal void InternalPropertyChanging(JProperty childProperty) { }

	// RVA: 0xE34E40 Offset: 0xE33440 VA: 0x180E34E40 Slot: 10
	internal override JToken CloneToken() { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0xE35530 Offset: 0xE33B30 VA: 0x180E35530
	public JProperty Property(string name) { }

	// RVA: 0xE366B0 Offset: 0xE34CB0 VA: 0x180E366B0 Slot: 59
	public JToken get_Item(string propertyName) { }

	// RVA: 0xE36730 Offset: 0xE34D30 VA: 0x180E36730 Slot: 60
	public void set_Item(string propertyName, JToken value) { }

	// RVA: 0xE35400 Offset: 0xE33A00 VA: 0x180E35400
	public static JObject Load(JsonReader reader) { }

	// RVA: 0xE35240 Offset: 0xE33840 VA: 0x180E35240
	public static JObject Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xE36400 Offset: 0xE34A00 VA: 0x180E36400 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE34DB0 Offset: 0xE333B0 VA: 0x180E34DB0 Slot: 64
	public void Add(string propertyName, JToken value) { }

	// RVA: 0xE35C10 Offset: 0xE34210 VA: 0x180E35C10 Slot: 63
	private bool System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.ContainsKey(string key) { }

	// RVA: 0xE35CB0 Offset: 0xE342B0 VA: 0x180E35CB0 Slot: 61
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys() { }

	// RVA: 0xE35640 Offset: 0xE33C40 VA: 0x180E35640 Slot: 65
	public bool Remove(string propertyName) { }

	// RVA: 0xE360E0 Offset: 0xE346E0 VA: 0x180E360E0 Slot: 66
	public bool TryGetValue(string propertyName, out JToken value) { }

	// RVA: 0xE35D10 Offset: 0xE34310 VA: 0x180E35D10 Slot: 62
	private ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values() { }

	// RVA: 0xE356D0 Offset: 0xE33CD0 VA: 0x180E356D0 Slot: 69
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(KeyValuePair<string, JToken> item) { }

	// RVA: 0xE30DC0 Offset: 0xE2F3C0 VA: 0x180E30DC0 Slot: 70
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear() { }

	// RVA: 0xE35750 Offset: 0xE33D50 VA: 0x180E35750 Slot: 71
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(KeyValuePair<string, JToken> item) { }

	// RVA: 0xE357C0 Offset: 0xE33DC0 VA: 0x180E357C0 Slot: 72
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 68
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly() { }

	// RVA: 0xE35AC0 Offset: 0xE340C0 VA: 0x180E35AC0 Slot: 73
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(KeyValuePair<string, JToken> item) { }

	// RVA: 0xE31070 Offset: 0xE2F670 VA: 0x180E31070 Slot: 18
	internal override int GetDeepHashCode() { }

	// RVA: 0xE34FD0 Offset: 0xE335D0 VA: 0x180E34FD0 Slot: 74
	public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator() { }

	// RVA: 0xE35410 Offset: 0xE33A10 VA: 0x180E35410 Slot: 80
	protected virtual void OnPropertyChanged(string propertyName) { }

	// RVA: 0xE354A0 Offset: 0xE33AA0 VA: 0x180E354A0 Slot: 81
	protected virtual void OnPropertyChanging(string propertyName) { }

	// RVA: 0xE36030 Offset: 0xE34630 VA: 0x180E36030 Slot: 77
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xE35E10 Offset: 0xE34410 VA: 0x180E35E10 Slot: 78
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0xE35D60 Offset: 0xE34360 VA: 0x180E35D60 Slot: 75
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0xE35DC0 Offset: 0xE343C0 VA: 0x180E35DC0 Slot: 76
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 79
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

private sealed class JObject.<>c // TypeDefIndex: 6061
{	// Fields
	public static readonly JObject.<>c <>9; // 0x3370

	// Methods

	// RVA: 0xE4DAB0 Offset: 0xE4C0B0 VA: 0x180E4DAB0
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
	// RVA: 0xE4D950 Offset: 0xE4BF50 VA: 0x180E4D950 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE4D6A0 Offset: 0xE4BCA0 VA: 0x180E4D6A0 Slot: 6
	private bool MoveNext() { }

	// RVA: 0xE4DA00 Offset: 0xE4C000 VA: 0x180E4DA00
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB119C0 Offset: 0xB0FFC0 VA: 0x180B119C0 Slot: 4
	private KeyValuePair<string, JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE4D8B0 Offset: 0xE4BEB0 VA: 0x180E4D8B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE4D900 Offset: 0xE4BF00 VA: 0x180E4D900 Slot: 7
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

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0 Slot: 45
	protected override IList<JToken> get_ChildrenTokens() { }

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20 Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0xE31470 Offset: 0xE2FA70 VA: 0x180E31470
	public void .ctor() { }

	// RVA: 0xE315F0 Offset: 0xE2FBF0 VA: 0x180E315F0
	public void .ctor(JArray other) { }

	// RVA: 0xE31520 Offset: 0xE2FB20 VA: 0x180E31520
	public void .ctor(object content) { }

	// RVA: 0xE30ED0 Offset: 0xE2F4D0 VA: 0x180E30ED0 Slot: 11
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0xE30DE0 Offset: 0xE2F3E0 VA: 0x180E30DE0 Slot: 10
	internal override JToken CloneToken() { }

	// RVA: 0xE31320 Offset: 0xE2F920 VA: 0x180E31320
	public static JArray Load(JsonReader reader) { }

	// RVA: 0xE31180 Offset: 0xE2F780 VA: 0x180E31180
	public static JArray Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xE31370 Offset: 0xE2F970 VA: 0x180E31370 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE31670 Offset: 0xE2FC70 VA: 0x180E31670 Slot: 19
	public JToken get_Item(int index) { }

	// RVA: 0xE31690 Offset: 0xE2FC90 VA: 0x180E31690 Slot: 20
	public void set_Item(int index, JToken value) { }

	// RVA: 0xE310E0 Offset: 0xE2F6E0 VA: 0x180E310E0 Slot: 47
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xE31130 Offset: 0xE2F730 VA: 0x180E31130 Slot: 21
	public int IndexOf(JToken item) { }

	// RVA: 0xE31150 Offset: 0xE2F750 VA: 0x180E31150 Slot: 22
	public void Insert(int index, JToken item) { }

	// RVA: 0xE31330 Offset: 0xE2F930 VA: 0x180E31330 Slot: 23
	public void RemoveAt(int index) { }

	// RVA: 0xE31080 Offset: 0xE2F680 VA: 0x180E31080 Slot: 4
	public IEnumerator<JToken> GetEnumerator() { }

	// RVA: 0xE30DA0 Offset: 0xE2F3A0 VA: 0x180E30DA0 Slot: 26
	public void Add(JToken item) { }

	// RVA: 0xE30DC0 Offset: 0xE2F3C0 VA: 0x180E30DC0 Slot: 27
	public void Clear() { }

	// RVA: 0xE30E90 Offset: 0xE2F490 VA: 0x180E30E90 Slot: 28
	public bool Contains(JToken item) { }

	// RVA: 0xE30EB0 Offset: 0xE2F4B0 VA: 0x180E30EB0 Slot: 29
	public void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 25
	public bool get_IsReadOnly() { }

	// RVA: 0xE31350 Offset: 0xE2F950 VA: 0x180E31350 Slot: 30
	public bool Remove(JToken item) { }

	// RVA: 0xE31070 Offset: 0xE2F670 VA: 0x180E31070 Slot: 18
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

	// RVA: 0x4E3FE0 Offset: 0x4E25E0 VA: 0x1804E3FE0
	public JToken get_CurrentToken() { }

	// RVA: 0xE3A590 Offset: 0xE38B90 VA: 0x180E3A590
	public void .ctor(JToken token) { }

	// RVA: 0xE39560 Offset: 0xE37B60 VA: 0x180E39560 Slot: 10
	public override bool Read() { }

	// RVA: 0xE39430 Offset: 0xE37A30 VA: 0x180E39430
	private bool ReadOver(JToken t) { }

	// RVA: 0xE39520 Offset: 0xE37B20 VA: 0x180E39520
	private bool ReadToEnd() { }

	// RVA: 0xE39130 Offset: 0xE37730 VA: 0x180E39130
	private Nullable<JsonToken> GetEndToken(JContainer c) { }

	// RVA: 0xE39390 Offset: 0xE37990 VA: 0x180E39390
	private bool ReadInto(JContainer c) { }

	// RVA: 0xE398A0 Offset: 0xE37EA0 VA: 0x180E398A0
	private bool SetEnd(JContainer c) { }

	// RVA: 0xE39A40 Offset: 0xE38040 VA: 0x180E39A40
	private void SetToken(JToken token) { }

	// RVA: 0xE39880 Offset: 0xE37E80 VA: 0x180E39880
	private string SafeToString(object value) { }

	// RVA: 0xE39270 Offset: 0xE37870 VA: 0x180E39270 Slot: 21
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0xE392D0 Offset: 0xE378D0 VA: 0x180E392D0 Slot: 22
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0xE39330 Offset: 0xE37930 VA: 0x180E39330 Slot: 23
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0xE3A5F0 Offset: 0xE38BF0 VA: 0x180E3A5F0 Slot: 9
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

	// RVA: 0xE3BB30 Offset: 0xE3A130 VA: 0x180E3BB30
	public JToken get_Token() { }

	// RVA: 0xE3BAC0 Offset: 0xE3A0C0 VA: 0x180E3BAC0
	public void .ctor() { }

	// RVA: 0xE3A910 Offset: 0xE38F10 VA: 0x180E3A910 Slot: 6
	public override void Close() { }

	// RVA: 0xE3AD40 Offset: 0xE39340 VA: 0x180E3AD40 Slot: 7
	public override void WriteStartObject() { }

	// RVA: 0xE3A6E0 Offset: 0xE38CE0 VA: 0x180E3A6E0
	private void AddParent(JContainer container) { }

	// RVA: 0xE3A980 Offset: 0xE38F80 VA: 0x180E3A980
	private void RemoveParent() { }

	// RVA: 0xE3AC50 Offset: 0xE39250 VA: 0x180E3AC50 Slot: 9
	public override void WriteStartArray() { }

	// RVA: 0xE3ACC0 Offset: 0xE392C0 VA: 0x180E3ACC0 Slot: 11
	public override void WriteStartConstructor(string name) { }

	// RVA: 0xE3A980 Offset: 0xE38F80 VA: 0x180E3A980 Slot: 17
	protected override void WriteEnd(JsonToken token) { }

	// RVA: 0xE3AA90 Offset: 0xE39090 VA: 0x180E3AA90 Slot: 13
	public override void WritePropertyName(string name) { }

	// RVA: 0xE3A7B0 Offset: 0xE38DB0 VA: 0x180E3A7B0
	private void AddValue(object value, JsonToken token) { }

	// RVA: 0xE3A840 Offset: 0xE38E40 VA: 0x180E3A840
	internal void AddValue(JValue value, JsonToken token) { }

	// RVA: 0xE3B9B0 Offset: 0xE39FB0 VA: 0x180E3B9B0 Slot: 62
	public override void WriteValue(object value) { }

	// RVA: 0xE3AA50 Offset: 0xE39050 VA: 0x180E3AA50 Slot: 21
	public override void WriteNull() { }

	// RVA: 0xE3B050 Offset: 0xE39650 VA: 0x180E3B050 Slot: 22
	public override void WriteUndefined() { }

	// RVA: 0xE3ABE0 Offset: 0xE391E0 VA: 0x180E3ABE0 Slot: 23
	public override void WriteRaw(string json) { }

	// RVA: 0xE3AA00 Offset: 0xE39000 VA: 0x180E3AA00 Slot: 63
	public override void WriteComment(string text) { }

	// RVA: 0xE3B680 Offset: 0xE39C80 VA: 0x180E3B680 Slot: 25
	public override void WriteValue(string value) { }

	// RVA: 0xE3B850 Offset: 0xE39E50 VA: 0x180E3B850 Slot: 26
	public override void WriteValue(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE3B380 Offset: 0xE39980 VA: 0x180E3B380 Slot: 27
	public override void WriteValue(uint value) { }

	// RVA: 0xE3B580 Offset: 0xE39B80 VA: 0x180E3B580 Slot: 28
	public override void WriteValue(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE3B9C0 Offset: 0xE39FC0 VA: 0x180E3B9C0 Slot: 29
	public override void WriteValue(ulong value) { }

	// RVA: 0xE3B250 Offset: 0xE39850 VA: 0x180E3B250 Slot: 30
	public override void WriteValue(float value) { }

	// RVA: 0xE3B750 Offset: 0xE39D50 VA: 0x180E3B750 Slot: 31
	public override void WriteValue(double value) { }

	// RVA: 0xE3B8D0 Offset: 0xE39ED0 VA: 0x180E3B8D0 Slot: 32
	public override void WriteValue(bool value) { }

	// RVA: 0xE3BA40 Offset: 0xE3A040 VA: 0x180E3BA40 Slot: 33
	public override void WriteValue(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE3B600 Offset: 0xE39C00 VA: 0x180E3B600 Slot: 34
	public override void WriteValue(ushort value) { }

	// RVA: 0xE3B1C0 Offset: 0xE397C0 VA: 0x180E3B1C0 Slot: 35
	public override void WriteValue(char value) { }

	// RVA: 0xE3B480 Offset: 0xE39A80 VA: 0x180E3B480 Slot: 36
	public override void WriteValue(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE3B7D0 Offset: 0xE39DD0 VA: 0x180E3B7D0 Slot: 37
	public override void WriteValue(sbyte value) { }

	// RVA: 0xE3B090 Offset: 0xE39690 VA: 0x180E3B090 Slot: 38
	public override void WriteValue(Decimal value) { }

	// RVA: 0xE3B110 Offset: 0xE39710 VA: 0x180E3B110 Slot: 39
	public override void WriteValue(DateTime value) { }

	// RVA: 0xE3B6D0 Offset: 0xE39CD0 VA: 0x180E3B6D0 Slot: 40
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0xE3B950 Offset: 0xE39F50 VA: 0x180E3B950 Slot: 60
	public override void WriteValue(byte[] value) { }

	// RVA: 0xE3B500 Offset: 0xE39B00 VA: 0x180E3B500 Slot: 42
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0xE3B400 Offset: 0xE39A00 VA: 0x180E3B400 Slot: 41
	public override void WriteValue(Guid value) { }

	// RVA: 0xE3B2D0 Offset: 0xE398D0 VA: 0x180E3B2D0 Slot: 61
	public override void WriteValue(Uri value) { }

	// RVA: 0xE3ADB0 Offset: 0xE393B0 VA: 0x180E3ADB0 Slot: 16
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
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public JContainer get_Parent() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	internal void set_Parent(JContainer value) { }

	// RVA: 0xE3EB80 Offset: 0xE3D180 VA: 0x180E3EB80
	public JToken get_Root() { }

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract JToken CloneToken();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract bool DeepEquals(JToken node);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract JTokenType get_Type();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool get_HasValues();

	// RVA: 0xE3BF20 Offset: 0xE3A520 VA: 0x180E3BF20
	public static bool DeepEquals(JToken t1, JToken t2) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public JToken get_Next() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	internal void set_Next(JToken value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public JToken get_Previous() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	internal void set_Previous(JToken value) { }

	// RVA: 0xE3E8D0 Offset: 0xE3CED0 VA: 0x180E3E8D0
	public string get_Path() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0xE3E790 Offset: 0xE3CD90 VA: 0x180E3E790 Slot: 14
	public virtual JToken get_First() { }

	// RVA: 0xE3E830 Offset: 0xE3CE30 VA: 0x180E3E830 Slot: 15
	public virtual JToken get_Last() { }

	// RVA: 0xE3BE10 Offset: 0xE3A410 VA: 0x180E3BE10 Slot: 16
	public virtual JEnumerable<JToken> Children() { }

	// RVA: 0xE3C930 Offset: 0xE3AF30 VA: 0x180E3C930
	public void Remove() { }

	// RVA: 0xE3C9B0 Offset: 0xE3AFB0 VA: 0x180E3C9B0
	public void Replace(JToken value) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void WriteTo(JsonWriter writer, JsonConverter[] converters);

	// RVA: 0xE3DDF0 Offset: 0xE3C3F0 VA: 0x180E3DDF0 Slot: 3
	public override string ToString() { }

	// RVA: 0xE3DC00 Offset: 0xE3C200 VA: 0x180E3DC00
	public string ToString(Formatting formatting, JsonConverter[] converters) { }

	// RVA: 0xE3BF50 Offset: 0xE3A550 VA: 0x180E3BF50
	private static JValue EnsureValue(JToken value) { }

	// RVA: 0xE3C0E0 Offset: 0xE3A6E0 VA: 0x180E3C0E0
	private static string GetType(JToken token) { }

	// RVA: 0xE3DE40 Offset: 0xE3C440 VA: 0x180E3DE40
	private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable) { }

	// RVA: 0xE43860 Offset: 0xE41E60 VA: 0x180E43860
	public static bool op_Explicit(JToken value) { }

	// RVA: 0xE40E20 Offset: 0xE3F420 VA: 0x180E40E20
	public static DateTimeOffset op_Explicit(JToken value) { }

	// RVA: 0xE41C20 Offset: 0xE40220 VA: 0x180E41C20
	public static Nullable<bool> op_Explicit(JToken value) { }

	// RVA: 0xE3EFE0 Offset: 0xE3D5E0 VA: 0x180E3EFE0
	public static long op_Explicit(JToken value) { }

	// RVA: 0xE3F3A0 Offset: 0xE3D9A0 VA: 0x180E3F3A0
	public static Nullable<DateTime> op_Explicit(JToken value) { }

	// RVA: 0xE42990 Offset: 0xE40F90 VA: 0x180E42990
	public static Nullable<DateTimeOffset> op_Explicit(JToken value) { }

	// RVA: 0xE40450 Offset: 0xE3EA50 VA: 0x180E40450
	public static Nullable<Decimal> op_Explicit(JToken value) { }

	// RVA: 0xE42740 Offset: 0xE40D40 VA: 0x180E42740
	public static Nullable<double> op_Explicit(JToken value) { }

	// RVA: 0xE3FAF0 Offset: 0xE3E0F0 VA: 0x180E3FAF0
	public static Nullable<char> op_Explicit(JToken value) { }

	// RVA: 0xE43D10 Offset: 0xE42310 VA: 0x180E43D10
	public static int op_Explicit(JToken value) { }

	// RVA: 0xE412F0 Offset: 0xE3F8F0 VA: 0x180E412F0
	public static short op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE42F90 Offset: 0xE41590 VA: 0x180E42F90
	public static ushort op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE3EBB0 Offset: 0xE3D1B0 VA: 0x180E3EBB0
	public static char op_Explicit(JToken value) { }

	// RVA: 0xE40C40 Offset: 0xE3F240 VA: 0x180E40C40
	public static byte op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE3F910 Offset: 0xE3DF10 VA: 0x180E3F910
	public static sbyte op_Explicit(JToken value) { }

	// RVA: 0xE41E70 Offset: 0xE40470 VA: 0x180E41E70
	public static Nullable<int> op_Explicit(JToken value) { }

	// RVA: 0xE42310 Offset: 0xE40910 VA: 0x180E42310
	public static Nullable<short> op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE43170 Offset: 0xE41770 VA: 0x180E43170
	public static Nullable<ushort> op_Explicit(JToken value) { }

	// RVA: 0xE420C0 Offset: 0xE406C0 VA: 0x180E420C0
	public static Nullable<byte> op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE414D0 Offset: 0xE3FAD0 VA: 0x180E414D0
	public static Nullable<sbyte> op_Explicit(JToken value) { }

	// RVA: 0xE42D50 Offset: 0xE41350 VA: 0x180E42D50
	public static DateTime op_Explicit(JToken value) { }

	// RVA: 0xE3FF20 Offset: 0xE3E520 VA: 0x180E3FF20
	public static Nullable<long> op_Explicit(JToken value) { }

	// RVA: 0xE419D0 Offset: 0xE3FFD0 VA: 0x180E419D0
	public static Nullable<float> op_Explicit(JToken value) { }

	// RVA: 0xE406D0 Offset: 0xE3ECD0 VA: 0x180E406D0
	public static Decimal op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE43610 Offset: 0xE41C10 VA: 0x180E43610
	public static Nullable<uint> op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE433C0 Offset: 0xE419C0 VA: 0x180E433C0
	public static Nullable<ulong> op_Explicit(JToken value) { }

	// RVA: 0xE3FD40 Offset: 0xE3E340 VA: 0x180E3FD40
	public static double op_Explicit(JToken value) { }

	// RVA: 0xE42560 Offset: 0xE40B60 VA: 0x180E42560
	public static float op_Explicit(JToken value) { }

	// RVA: 0xE41720 Offset: 0xE3FD20 VA: 0x180E41720
	public static string op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE41110 Offset: 0xE3F710 VA: 0x180E41110
	public static uint op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0xE3F1C0 Offset: 0xE3D7C0 VA: 0x180E3F1C0
	public static ulong op_Explicit(JToken value) { }

	// RVA: 0xE43A40 Offset: 0xE42040 VA: 0x180E43A40
	public static Guid op_Explicit(JToken value) { }

	// RVA: 0xE408C0 Offset: 0xE3EEC0 VA: 0x180E408C0
	public static Nullable<Guid> op_Explicit(JToken value) { }

	// RVA: 0xE3ED90 Offset: 0xE3D390 VA: 0x180E3ED90
	public static TimeSpan op_Explicit(JToken value) { }

	// RVA: 0xE3F650 Offset: 0xE3DC50 VA: 0x180E3F650
	public static Nullable<TimeSpan> op_Explicit(JToken value) { }

	// RVA: 0xE40170 Offset: 0xE3E770 VA: 0x180E40170
	public static Uri op_Explicit(JToken value) { }

	// RVA: 0xE3CC10 Offset: 0xE3B210 VA: 0x180E3CC10 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xE3CBB0 Offset: 0xE3B1B0 VA: 0x180E3CBB0 Slot: 4
	private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract int GetDeepHashCode();

	// RVA: 0xE3BE70 Offset: 0xE3A470 VA: 0x180E3BE70
	public JsonReader CreateReader() { }

	// RVA: -1 Offset: -1
	public T ToObject<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CFA30 Offset: 0x5CE030 VA: 0x1805CFA30
	|-JToken.ToObject<UITwitchTrophy.TrophyPage>
	|-JToken.ToObject<object>
	*/

	// RVA: 0xE3CDA0 Offset: 0xE3B3A0 VA: 0x180E3CDA0
	public object ToObject(Type objectType) { }

	// RVA: 0xE3CC50 Offset: 0xE3B250 VA: 0x180E3CC50
	public object ToObject(Type objectType, JsonSerializer jsonSerializer) { }

	// RVA: 0xE3C5D0 Offset: 0xE3ABD0 VA: 0x180E3C5D0
	public static JToken ReadFrom(JsonReader reader) { }

	// RVA: 0xE3C630 Offset: 0xE3AC30 VA: 0x180E3C630
	public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xE3C570 Offset: 0xE3AB70 VA: 0x180E3C570
	public static JToken Parse(string json) { }

	// RVA: 0xE3C3A0 Offset: 0xE3A9A0 VA: 0x180E3C3A0
	public static JToken Parse(string json, JsonLoadSettings settings) { }

	// RVA: 0xE3C250 Offset: 0xE3A850 VA: 0x180E3C250
	public static JToken Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xE3CAC0 Offset: 0xE3B0C0 VA: 0x180E3CAC0
	internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings) { }

	// RVA: 0xE3CA40 Offset: 0xE3B040 VA: 0x180E3CA40
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0xE3C2C0 Offset: 0xE3A8C0 VA: 0x180E3C2C0 Slot: 6
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0xE3C300 Offset: 0xE3A900 VA: 0x180E3C300 Slot: 7
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0xE3C350 Offset: 0xE3A950 VA: 0x180E3C350 Slot: 8
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0xE3BF00 Offset: 0xE3A500 VA: 0x180E3BF00 Slot: 9
	private object System.ICloneable.Clone() { }

	// RVA: 0xE3BF00 Offset: 0xE3A500 VA: 0x180E3BF00
	public JToken DeepClone() { }

	// RVA: 0xE3BB40 Offset: 0xE3A140 VA: 0x180E3BB40
	public void AddAnnotation(object annotation) { }

	// RVA: -1 Offset: -1
	public T Annotation<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CF890 Offset: 0x5CDE90 VA: 0x1805CF890
	|-JToken.Annotation<JToken.LineInfoAnnotation>
	|-JToken.Annotation<object>
	*/

	// RVA: 0xE3DF20 Offset: 0xE3C520 VA: 0x180E3DF20
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

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0 Slot: 45
	protected override IList<JToken> get_ChildrenTokens() { }

	[DebuggerStepThroughAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public string get_Name() { }

	[DebuggerStepThroughAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE38BD0 Offset: 0xE371D0 VA: 0x180E38BD0
	public JToken get_Value() { }

	// RVA: 0xE38BF0 Offset: 0xE371F0 VA: 0x180E38BF0
	public void set_Value(JToken value) { }

	// RVA: 0xE38840 Offset: 0xE36E40 VA: 0x180E38840
	public void .ctor(JProperty other) { }

	// RVA: 0xE37FC0 Offset: 0xE365C0 VA: 0x180E37FC0 Slot: 51
	internal override JToken GetItem(int index) { }

	// RVA: 0xE38520 Offset: 0xE36B20 VA: 0x180E38520 Slot: 52
	internal override void SetItem(int index, JToken item) { }

	// RVA: 0xE38450 Offset: 0xE36A50 VA: 0x180E38450 Slot: 50
	internal override bool RemoveItem(JToken item) { }

	// RVA: 0xE38380 Offset: 0xE36980 VA: 0x180E38380 Slot: 49
	internal override void RemoveItemAt(int index) { }

	// RVA: 0xE38040 Offset: 0xE36640 VA: 0x180E38040 Slot: 47
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xE38070 Offset: 0xE36670 VA: 0x180E38070 Slot: 48
	internal override void InsertItem(int index, JToken item, bool skipParentCheck) { }

	// RVA: 0xE37D70 Offset: 0xE36370 VA: 0x180E37D70 Slot: 55
	internal override bool ContainsItem(JToken item) { }

	// RVA: 0xE37BE0 Offset: 0xE361E0 VA: 0x180E37BE0 Slot: 53
	internal override void ClearItems() { }

	// RVA: 0xE37D90 Offset: 0xE36390 VA: 0x180E37D90 Slot: 11
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0xE37CB0 Offset: 0xE362B0 VA: 0x180E37CB0 Slot: 10
	internal override JToken CloneToken() { }

	[DebuggerStepThroughAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE38BC0 Offset: 0xE371C0 VA: 0x180E38BC0 Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0xE38AF0 Offset: 0xE370F0 VA: 0x180E38AF0
	internal void .ctor(string name) { }

	// RVA: 0xE388D0 Offset: 0xE36ED0 VA: 0x180E388D0
	public void .ctor(string name, object content) { }

	// RVA: 0xE387A0 Offset: 0xE36DA0 VA: 0x180E387A0 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE37F50 Offset: 0xE36550 VA: 0x180E37F50 Slot: 18
	internal override int GetDeepHashCode() { }

	// RVA: 0xE38190 Offset: 0xE36790 VA: 0x180E38190
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

	// RVA: 0xE37AD0 Offset: 0xE360D0 VA: 0x180E37AD0 Slot: 16
	public IEnumerator<JToken> GetEnumerator() { }

	// RVA: 0xE37AD0 Offset: 0xE360D0 VA: 0x180E37AD0 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0 Slot: 11
	public void Add(JToken item) { }

	// RVA: 0xE37A10 Offset: 0xE36010 VA: 0x180E37A10 Slot: 12
	public void Clear() { }

	// RVA: 0xE37A30 Offset: 0xE36030 VA: 0x180E37A30 Slot: 13
	public bool Contains(JToken item) { }

	// RVA: 0xE37A40 Offset: 0xE36040 VA: 0x180E37A40 Slot: 14
	public void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0xE37B90 Offset: 0xE36190 VA: 0x180E37B90 Slot: 15
	public bool Remove(JToken item) { }

	// RVA: 0xE37BC0 Offset: 0xE361C0 VA: 0x180E37BC0 Slot: 9
	public int get_Count() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0xE37B40 Offset: 0xE36140 VA: 0x180E37B40 Slot: 6
	public int IndexOf(JToken item) { }

	// RVA: 0xE37B50 Offset: 0xE36150 VA: 0x180E37B50 Slot: 7
	public void Insert(int index, JToken item) { }

	// RVA: 0xE37B70 Offset: 0xE36170 VA: 0x180E37B70 Slot: 8
	public void RemoveAt(int index) { }

	// RVA: 0xE37BD0 Offset: 0xE361D0 VA: 0x180E37BD0 Slot: 4
	public JToken get_Item(int index) { }

	// RVA: 0xE37B50 Offset: 0xE36150 VA: 0x180E37B50 Slot: 5
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

	// RVA: 0xE4D5F0 Offset: 0xE4BBF0 VA: 0x180E4D5F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE4D650 Offset: 0xE4BC50 VA: 0x180E4D650 Slot: 8
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

	// RVA: 0xE466F0 Offset: 0xE44CF0 VA: 0x180E466F0
	internal void .ctor(object value, JTokenType type) { }

	// RVA: 0xE38F60 Offset: 0xE37560 VA: 0x180E38F60
	public void .ctor(JValue other) { }

	// RVA: 0xE466B0 Offset: 0xE44CB0 VA: 0x180E466B0
	public void .ctor(object value) { }

	// RVA: 0xE44BF0 Offset: 0xE431F0 VA: 0x180E44BF0 Slot: 11
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 13
	public override bool get_HasValues() { }

	// RVA: 0xE440A0 Offset: 0xE426A0 VA: 0x180E440A0
	internal static int Compare(JTokenType valueType, object objA, object objB) { }

	// RVA: 0xE43FB0 Offset: 0xE425B0 VA: 0x180E43FB0
	private static int CompareFloat(object objA, object objB) { }

	// RVA: 0xE43EF0 Offset: 0xE424F0 VA: 0x180E43EF0 Slot: 10
	internal override JToken CloneToken() { }

	// RVA: 0xE44A10 Offset: 0xE43010 VA: 0x180E44A10
	public static JValue CreateComment(string value) { }

	// RVA: 0xE44AB0 Offset: 0xE430B0 VA: 0x180E44AB0
	public static JValue CreateNull() { }

	// RVA: 0xE44B50 Offset: 0xE43150 VA: 0x180E44B50
	public static JValue CreateUndefined() { }

	// RVA: 0xE44EB0 Offset: 0xE434B0 VA: 0x180E44EB0
	private static JTokenType GetValueType(Nullable<JTokenType> current, object value) { }

	// RVA: 0xE44E50 Offset: 0xE43450 VA: 0x180E44E50
	private static JTokenType GetStringValueType(Nullable<JTokenType> current) { }

	// RVA: 0xA39490 Offset: 0xA37A90 VA: 0x180A39490 Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public object get_Value() { }

	// RVA: 0xE45CC0 Offset: 0xE442C0 VA: 0x180E45CC0 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE44DE0 Offset: 0xE433E0 VA: 0x180E44DE0 Slot: 18
	internal override int GetDeepHashCode() { }

	// RVA: 0xE45C70 Offset: 0xE44270 VA: 0x180E45C70
	private static bool ValuesEquals(JValue v1, JValue v2) { }

	// RVA: 0xE44D90 Offset: 0xE43390 VA: 0x180E44D90
	public bool Equals(JValue other) { }

	// RVA: 0xE44CB0 Offset: 0xE432B0 VA: 0x180E44CB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xE44E30 Offset: 0xE43430 VA: 0x180E44E30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xE459B0 Offset: 0xE43FB0 VA: 0x180E459B0 Slot: 3
	public override string ToString() { }

	// RVA: 0xE45A10 Offset: 0xE44010 VA: 0x180E45A10 Slot: 36
	public string ToString(IFormatProvider formatProvider) { }

	// RVA: 0xE45B30 Offset: 0xE44130 VA: 0x180E45B30 Slot: 19
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0xE452C0 Offset: 0xE438C0 VA: 0x180E452C0 Slot: 20
	private int System.IComparable.CompareTo(object obj) { }

	// RVA: 0xE453E0 Offset: 0xE439E0 VA: 0x180E453E0 Slot: 21
	private TypeCode System.IConvertible.GetTypeCode() { }

	// RVA: 0xE45450 Offset: 0xE43A50 VA: 0x180E45450 Slot: 22
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0xE45510 Offset: 0xE43B10 VA: 0x180E45510 Slot: 23
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0xE457C0 Offset: 0xE43DC0 VA: 0x180E457C0 Slot: 24
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0xE454B0 Offset: 0xE43AB0 VA: 0x180E454B0 Slot: 25
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0xE456A0 Offset: 0xE43CA0 VA: 0x180E456A0 Slot: 26
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0xE45890 Offset: 0xE43E90 VA: 0x180E45890 Slot: 27
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0xE45700 Offset: 0xE43D00 VA: 0x180E45700 Slot: 28
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0xE458F0 Offset: 0xE43EF0 VA: 0x180E458F0 Slot: 29
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0xE45760 Offset: 0xE43D60 VA: 0x180E45760 Slot: 30
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0xE45950 Offset: 0xE43F50 VA: 0x180E45950 Slot: 31
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0xE45820 Offset: 0xE43E20 VA: 0x180E45820 Slot: 32
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0xE45640 Offset: 0xE43C40 VA: 0x180E45640 Slot: 33
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0xE455D0 Offset: 0xE43BD0 VA: 0x180E455D0 Slot: 34
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0xE45570 Offset: 0xE43B70 VA: 0x180E45570 Slot: 35
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0xE45880 Offset: 0xE43E80 VA: 0x180E45880 Slot: 37
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

	// RVA: 0x85DE00 Offset: 0x85C400 VA: 0x18085DE00
	public static Variant Load(string json) { }

	// RVA: 0x85DBE0 Offset: 0x85C1E0 VA: 0x18085DBE0
	public static string Dump(object data) { }

	// RVA: 0x85D9F0 Offset: 0x85BFF0 VA: 0x18085D9F0
	public static string Dump(object data, EncodeOptions options) { }

	// RVA: -1 Offset: -1
	public static void MakeInto<T>(Variant data, out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CEB00 Offset: 0x5CD100 VA: 0x1805CEB00
	|-JSON.MakeInto<object>
	*/

	// RVA: 0x85DC40 Offset: 0x85C240 VA: 0x18085DC40
	private static Type FindType(string fullName) { }

	[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	private static T DecodeType<T>(Variant data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDA690 Offset: 0xBD8C90 VA: 0x180BDA690
	|-JSON.DecodeType<bool>
	|
	|-RVA: 0xBDC670 Offset: 0xBDAC70 VA: 0x180BDC670
	|-JSON.DecodeType<Decimal>
	|
	|-RVA: 0xBDE630 Offset: 0xBDCC30 VA: 0x180BDE630
	|-JSON.DecodeType<double>
	|
	|-RVA: 0x15A8700 Offset: 0x15A6D00 VA: 0x1815A8700
	|-JSON.DecodeType<short>
	|
	|-RVA: 0x15AA6D0 Offset: 0x15A8CD0 VA: 0x1815AA6D0
	|-JSON.DecodeType<int>
	|
	|-RVA: 0x15AC670 Offset: 0x15AAC70 VA: 0x1815AC670
	|-JSON.DecodeType<long>
	|
	|-RVA: 0x15AE640 Offset: 0x15ACC40 VA: 0x1815AE640
	|-JSON.DecodeType<object>
	|
	|-RVA: 0x15B0560 Offset: 0x15AEB60 VA: 0x1815B0560
	|-JSON.DecodeType<float>
	|
	|-RVA: 0x15B2500 Offset: 0x15B0B00 VA: 0x1815B2500
	|-JSON.DecodeType<ushort>
	|
	|-RVA: 0x15B44D0 Offset: 0x15B2AD0 VA: 0x1815B44D0
	|-JSON.DecodeType<uint>
	|
	|-RVA: 0x15B6470 Offset: 0x15B4A70 VA: 0x1815B6470
	|-JSON.DecodeType<ulong>
	*/

	[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	private static List<T> DecodeList<T>(Variant data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12ADE70 Offset: 0x12AC470 VA: 0x1812ADE70
	|-JSON.DecodeList<bool>
	|
	|-RVA: 0x12AE060 Offset: 0x12AC660 VA: 0x1812AE060
	|-JSON.DecodeList<Decimal>
	|
	|-RVA: 0x12AE260 Offset: 0x12AC860 VA: 0x1812AE260
	|-JSON.DecodeList<double>
	|
	|-RVA: 0x12AE450 Offset: 0x12ACA50 VA: 0x1812AE450
	|-JSON.DecodeList<short>
	|
	|-RVA: 0x12AE640 Offset: 0x12ACC40 VA: 0x1812AE640
	|-JSON.DecodeList<int>
	|
	|-RVA: 0x12AE830 Offset: 0x12ACE30 VA: 0x1812AE830
	|-JSON.DecodeList<long>
	|
	|-RVA: 0x12AEA20 Offset: 0x12AD020 VA: 0x1812AEA20
	|-JSON.DecodeList<object>
	|
	|-RVA: 0x12AEC10 Offset: 0x12AD210 VA: 0x1812AEC10
	|-JSON.DecodeList<float>
	|
	|-RVA: 0x12AEE00 Offset: 0x12AD400 VA: 0x1812AEE00
	|-JSON.DecodeList<ushort>
	|
	|-RVA: 0x12AEFF0 Offset: 0x12AD5F0 VA: 0x1812AEFF0
	|-JSON.DecodeList<uint>
	|
	|-RVA: 0x12AF1E0 Offset: 0x12AD7E0 VA: 0x1812AF1E0
	|-JSON.DecodeList<ulong>
	*/

	[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	private static Dictionary<TKey, TValue> DecodeDictionary<TKey, TValue>(Variant data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1538170 Offset: 0x1536770 VA: 0x181538170
	|-JSON.DecodeDictionary<bool, bool>
	|
	|-RVA: 0x1538500 Offset: 0x1536B00 VA: 0x181538500
	|-JSON.DecodeDictionary<bool, Decimal>
	|
	|-RVA: 0x1538890 Offset: 0x1536E90 VA: 0x181538890
	|-JSON.DecodeDictionary<bool, double>
	|
	|-RVA: 0x1538C20 Offset: 0x1537220 VA: 0x181538C20
	|-JSON.DecodeDictionary<bool, short>
	|
	|-RVA: 0x1538FB0 Offset: 0x15375B0 VA: 0x181538FB0
	|-JSON.DecodeDictionary<bool, int>
	|
	|-RVA: 0x1539340 Offset: 0x1537940 VA: 0x181539340
	|-JSON.DecodeDictionary<bool, long>
	|
	|-RVA: 0x15396D0 Offset: 0x1537CD0 VA: 0x1815396D0
	|-JSON.DecodeDictionary<bool, object>
	|
	|-RVA: 0x1539A60 Offset: 0x1538060 VA: 0x181539A60
	|-JSON.DecodeDictionary<bool, float>
	|
	|-RVA: 0x1539DF0 Offset: 0x15383F0 VA: 0x181539DF0
	|-JSON.DecodeDictionary<bool, ushort>
	|
	|-RVA: 0x153A180 Offset: 0x1538780 VA: 0x18153A180
	|-JSON.DecodeDictionary<bool, uint>
	|
	|-RVA: 0x153A510 Offset: 0x1538B10 VA: 0x18153A510
	|-JSON.DecodeDictionary<bool, ulong>
	|
	|-RVA: 0x153A8A0 Offset: 0x1538EA0 VA: 0x18153A8A0
	|-JSON.DecodeDictionary<Decimal, bool>
	|
	|-RVA: 0x153AC30 Offset: 0x1539230 VA: 0x18153AC30
	|-JSON.DecodeDictionary<Decimal, Decimal>
	|
	|-RVA: 0x153AFD0 Offset: 0x15395D0 VA: 0x18153AFD0
	|-JSON.DecodeDictionary<Decimal, double>
	|
	|-RVA: 0x153B360 Offset: 0x1539960 VA: 0x18153B360
	|-JSON.DecodeDictionary<Decimal, short>
	|
	|-RVA: 0x153B6F0 Offset: 0x1539CF0 VA: 0x18153B6F0
	|-JSON.DecodeDictionary<Decimal, int>
	|
	|-RVA: 0x153BA80 Offset: 0x153A080 VA: 0x18153BA80
	|-JSON.DecodeDictionary<Decimal, long>
	|
	|-RVA: 0x153BE10 Offset: 0x153A410 VA: 0x18153BE10
	|-JSON.DecodeDictionary<Decimal, object>
	|
	|-RVA: 0x153C1A0 Offset: 0x153A7A0 VA: 0x18153C1A0
	|-JSON.DecodeDictionary<Decimal, float>
	|
	|-RVA: 0x153C530 Offset: 0x153AB30 VA: 0x18153C530
	|-JSON.DecodeDictionary<Decimal, ushort>
	|
	|-RVA: 0x153C8C0 Offset: 0x153AEC0 VA: 0x18153C8C0
	|-JSON.DecodeDictionary<Decimal, uint>
	|
	|-RVA: 0x153CC50 Offset: 0x153B250 VA: 0x18153CC50
	|-JSON.DecodeDictionary<Decimal, ulong>
	|
	|-RVA: 0x153CFE0 Offset: 0x153B5E0 VA: 0x18153CFE0
	|-JSON.DecodeDictionary<double, bool>
	|
	|-RVA: 0x153D370 Offset: 0x153B970 VA: 0x18153D370
	|-JSON.DecodeDictionary<double, Decimal>
	|
	|-RVA: 0x153D710 Offset: 0x153BD10 VA: 0x18153D710
	|-JSON.DecodeDictionary<double, double>
	|
	|-RVA: 0x153DAA0 Offset: 0x153C0A0 VA: 0x18153DAA0
	|-JSON.DecodeDictionary<double, short>
	|
	|-RVA: 0x153DE30 Offset: 0x153C430 VA: 0x18153DE30
	|-JSON.DecodeDictionary<double, int>
	|
	|-RVA: 0x153E1C0 Offset: 0x153C7C0 VA: 0x18153E1C0
	|-JSON.DecodeDictionary<double, long>
	|
	|-RVA: 0x153E550 Offset: 0x153CB50 VA: 0x18153E550
	|-JSON.DecodeDictionary<double, object>
	|
	|-RVA: 0x153E8E0 Offset: 0x153CEE0 VA: 0x18153E8E0
	|-JSON.DecodeDictionary<double, float>
	|
	|-RVA: 0x153EC70 Offset: 0x153D270 VA: 0x18153EC70
	|-JSON.DecodeDictionary<double, ushort>
	|
	|-RVA: 0x153F000 Offset: 0x153D600 VA: 0x18153F000
	|-JSON.DecodeDictionary<double, uint>
	|
	|-RVA: 0x153F390 Offset: 0x153D990 VA: 0x18153F390
	|-JSON.DecodeDictionary<double, ulong>
	|
	|-RVA: 0x153F720 Offset: 0x153DD20 VA: 0x18153F720
	|-JSON.DecodeDictionary<short, bool>
	|
	|-RVA: 0x153FAB0 Offset: 0x153E0B0 VA: 0x18153FAB0
	|-JSON.DecodeDictionary<short, Decimal>
	|
	|-RVA: 0x153FE40 Offset: 0x153E440 VA: 0x18153FE40
	|-JSON.DecodeDictionary<short, double>
	|
	|-RVA: 0x15401D0 Offset: 0x153E7D0 VA: 0x1815401D0
	|-JSON.DecodeDictionary<short, short>
	|
	|-RVA: 0x1540560 Offset: 0x153EB60 VA: 0x181540560
	|-JSON.DecodeDictionary<short, int>
	|
	|-RVA: 0x15408F0 Offset: 0x153EEF0 VA: 0x1815408F0
	|-JSON.DecodeDictionary<short, long>
	|
	|-RVA: 0x1540C80 Offset: 0x153F280 VA: 0x181540C80
	|-JSON.DecodeDictionary<short, object>
	|
	|-RVA: 0x1541010 Offset: 0x153F610 VA: 0x181541010
	|-JSON.DecodeDictionary<short, float>
	|
	|-RVA: 0x15413A0 Offset: 0x153F9A0 VA: 0x1815413A0
	|-JSON.DecodeDictionary<short, ushort>
	|
	|-RVA: 0x1541730 Offset: 0x153FD30 VA: 0x181541730
	|-JSON.DecodeDictionary<short, uint>
	|
	|-RVA: 0x1541AC0 Offset: 0x15400C0 VA: 0x181541AC0
	|-JSON.DecodeDictionary<short, ulong>
	|
	|-RVA: 0x1541E50 Offset: 0x1540450 VA: 0x181541E50
	|-JSON.DecodeDictionary<int, bool>
	|
	|-RVA: 0x15421E0 Offset: 0x15407E0 VA: 0x1815421E0
	|-JSON.DecodeDictionary<int, Decimal>
	|
	|-RVA: 0x1542570 Offset: 0x1540B70 VA: 0x181542570
	|-JSON.DecodeDictionary<int, double>
	|
	|-RVA: 0x1542900 Offset: 0x1540F00 VA: 0x181542900
	|-JSON.DecodeDictionary<int, short>
	|
	|-RVA: 0x1542C90 Offset: 0x1541290 VA: 0x181542C90
	|-JSON.DecodeDictionary<int, int>
	|
	|-RVA: 0x1543020 Offset: 0x1541620 VA: 0x181543020
	|-JSON.DecodeDictionary<int, long>
	|
	|-RVA: 0x15433B0 Offset: 0x15419B0 VA: 0x1815433B0
	|-JSON.DecodeDictionary<int, object>
	|
	|-RVA: 0x1543740 Offset: 0x1541D40 VA: 0x181543740
	|-JSON.DecodeDictionary<int, float>
	|
	|-RVA: 0x1543AD0 Offset: 0x15420D0 VA: 0x181543AD0
	|-JSON.DecodeDictionary<int, ushort>
	|
	|-RVA: 0x1543E60 Offset: 0x1542460 VA: 0x181543E60
	|-JSON.DecodeDictionary<int, uint>
	|
	|-RVA: 0x15441F0 Offset: 0x15427F0 VA: 0x1815441F0
	|-JSON.DecodeDictionary<int, ulong>
	|
	|-RVA: 0x1544580 Offset: 0x1542B80 VA: 0x181544580
	|-JSON.DecodeDictionary<long, bool>
	|
	|-RVA: 0x1544910 Offset: 0x1542F10 VA: 0x181544910
	|-JSON.DecodeDictionary<long, Decimal>
	|
	|-RVA: 0x1544CA0 Offset: 0x15432A0 VA: 0x181544CA0
	|-JSON.DecodeDictionary<long, double>
	|
	|-RVA: 0x1545030 Offset: 0x1543630 VA: 0x181545030
	|-JSON.DecodeDictionary<long, short>
	|
	|-RVA: 0x15453C0 Offset: 0x15439C0 VA: 0x1815453C0
	|-JSON.DecodeDictionary<long, int>
	|
	|-RVA: 0x1545750 Offset: 0x1543D50 VA: 0x181545750
	|-JSON.DecodeDictionary<long, long>
	|
	|-RVA: 0x1545AE0 Offset: 0x15440E0 VA: 0x181545AE0
	|-JSON.DecodeDictionary<long, object>
	|
	|-RVA: 0x1545E70 Offset: 0x1544470 VA: 0x181545E70
	|-JSON.DecodeDictionary<long, float>
	|
	|-RVA: 0x1546200 Offset: 0x1544800 VA: 0x181546200
	|-JSON.DecodeDictionary<long, ushort>
	|
	|-RVA: 0x1546590 Offset: 0x1544B90 VA: 0x181546590
	|-JSON.DecodeDictionary<long, uint>
	|
	|-RVA: 0x1546920 Offset: 0x1544F20 VA: 0x181546920
	|-JSON.DecodeDictionary<long, ulong>
	|
	|-RVA: 0x1546CB0 Offset: 0x15452B0 VA: 0x181546CB0
	|-JSON.DecodeDictionary<object, bool>
	|
	|-RVA: 0x1547050 Offset: 0x1545650 VA: 0x181547050
	|-JSON.DecodeDictionary<object, Decimal>
	|
	|-RVA: 0x15473F0 Offset: 0x15459F0 VA: 0x1815473F0
	|-JSON.DecodeDictionary<object, double>
	|
	|-RVA: 0x1547790 Offset: 0x1545D90 VA: 0x181547790
	|-JSON.DecodeDictionary<object, short>
	|
	|-RVA: 0x1547B30 Offset: 0x1546130 VA: 0x181547B30
	|-JSON.DecodeDictionary<object, int>
	|
	|-RVA: 0x1547ED0 Offset: 0x15464D0 VA: 0x181547ED0
	|-JSON.DecodeDictionary<object, long>
	|
	|-RVA: 0x1548270 Offset: 0x1546870 VA: 0x181548270
	|-JSON.DecodeDictionary<object, object>
	|
	|-RVA: 0x1548610 Offset: 0x1546C10 VA: 0x181548610
	|-JSON.DecodeDictionary<object, float>
	|
	|-RVA: 0x15489B0 Offset: 0x1546FB0 VA: 0x1815489B0
	|-JSON.DecodeDictionary<object, ushort>
	|
	|-RVA: 0x1548D50 Offset: 0x1547350 VA: 0x181548D50
	|-JSON.DecodeDictionary<object, uint>
	|
	|-RVA: 0x15490F0 Offset: 0x15476F0 VA: 0x1815490F0
	|-JSON.DecodeDictionary<object, ulong>
	|
	|-RVA: 0x1549490 Offset: 0x1547A90 VA: 0x181549490
	|-JSON.DecodeDictionary<float, bool>
	|
	|-RVA: 0x1549820 Offset: 0x1547E20 VA: 0x181549820
	|-JSON.DecodeDictionary<float, Decimal>
	|
	|-RVA: 0x1549BC0 Offset: 0x15481C0 VA: 0x181549BC0
	|-JSON.DecodeDictionary<float, double>
	|
	|-RVA: 0x1549F50 Offset: 0x1548550 VA: 0x181549F50
	|-JSON.DecodeDictionary<float, short>
	|
	|-RVA: 0x154A2E0 Offset: 0x15488E0 VA: 0x18154A2E0
	|-JSON.DecodeDictionary<float, int>
	|
	|-RVA: 0x154A670 Offset: 0x1548C70 VA: 0x18154A670
	|-JSON.DecodeDictionary<float, long>
	|
	|-RVA: 0x154AA00 Offset: 0x1549000 VA: 0x18154AA00
	|-JSON.DecodeDictionary<float, object>
	|
	|-RVA: 0x154AD90 Offset: 0x1549390 VA: 0x18154AD90
	|-JSON.DecodeDictionary<float, float>
	|
	|-RVA: 0x154B120 Offset: 0x1549720 VA: 0x18154B120
	|-JSON.DecodeDictionary<float, ushort>
	|
	|-RVA: 0x154B4B0 Offset: 0x1549AB0 VA: 0x18154B4B0
	|-JSON.DecodeDictionary<float, uint>
	|
	|-RVA: 0x154B840 Offset: 0x1549E40 VA: 0x18154B840
	|-JSON.DecodeDictionary<float, ulong>
	|
	|-RVA: 0x154BBD0 Offset: 0x154A1D0 VA: 0x18154BBD0
	|-JSON.DecodeDictionary<ushort, bool>
	|
	|-RVA: 0x154BF60 Offset: 0x154A560 VA: 0x18154BF60
	|-JSON.DecodeDictionary<ushort, Decimal>
	|
	|-RVA: 0x154C2F0 Offset: 0x154A8F0 VA: 0x18154C2F0
	|-JSON.DecodeDictionary<ushort, double>
	|
	|-RVA: 0x154C680 Offset: 0x154AC80 VA: 0x18154C680
	|-JSON.DecodeDictionary<ushort, short>
	|
	|-RVA: 0x154CA10 Offset: 0x154B010 VA: 0x18154CA10
	|-JSON.DecodeDictionary<ushort, int>
	|
	|-RVA: 0x154CDA0 Offset: 0x154B3A0 VA: 0x18154CDA0
	|-JSON.DecodeDictionary<ushort, long>
	|
	|-RVA: 0x154D130 Offset: 0x154B730 VA: 0x18154D130
	|-JSON.DecodeDictionary<ushort, object>
	|
	|-RVA: 0x154D4C0 Offset: 0x154BAC0 VA: 0x18154D4C0
	|-JSON.DecodeDictionary<ushort, float>
	|
	|-RVA: 0x154D850 Offset: 0x154BE50 VA: 0x18154D850
	|-JSON.DecodeDictionary<ushort, ushort>
	|
	|-RVA: 0x154DBE0 Offset: 0x154C1E0 VA: 0x18154DBE0
	|-JSON.DecodeDictionary<ushort, uint>
	|
	|-RVA: 0x154DF70 Offset: 0x154C570 VA: 0x18154DF70
	|-JSON.DecodeDictionary<ushort, ulong>
	|
	|-RVA: 0x154E300 Offset: 0x154C900 VA: 0x18154E300
	|-JSON.DecodeDictionary<uint, bool>
	|
	|-RVA: 0x154E690 Offset: 0x154CC90 VA: 0x18154E690
	|-JSON.DecodeDictionary<uint, Decimal>
	|
	|-RVA: 0x154EA20 Offset: 0x154D020 VA: 0x18154EA20
	|-JSON.DecodeDictionary<uint, double>
	|
	|-RVA: 0x154EDB0 Offset: 0x154D3B0 VA: 0x18154EDB0
	|-JSON.DecodeDictionary<uint, short>
	|
	|-RVA: 0x154F140 Offset: 0x154D740 VA: 0x18154F140
	|-JSON.DecodeDictionary<uint, int>
	|
	|-RVA: 0x154F4D0 Offset: 0x154DAD0 VA: 0x18154F4D0
	|-JSON.DecodeDictionary<uint, long>
	|
	|-RVA: 0xD00090 Offset: 0xCFE690 VA: 0x180D00090
	|-JSON.DecodeDictionary<uint, object>
	|
	|-RVA: 0xD00420 Offset: 0xCFEA20 VA: 0x180D00420
	|-JSON.DecodeDictionary<uint, float>
	|
	|-RVA: 0xD007B0 Offset: 0xCFEDB0 VA: 0x180D007B0
	|-JSON.DecodeDictionary<uint, ushort>
	|
	|-RVA: 0xD00B40 Offset: 0xCFF140 VA: 0x180D00B40
	|-JSON.DecodeDictionary<uint, uint>
	|
	|-RVA: 0xD00ED0 Offset: 0xCFF4D0 VA: 0x180D00ED0
	|-JSON.DecodeDictionary<uint, ulong>
	|
	|-RVA: 0xD01260 Offset: 0xCFF860 VA: 0x180D01260
	|-JSON.DecodeDictionary<ulong, bool>
	|
	|-RVA: 0xD015F0 Offset: 0xCFFBF0 VA: 0x180D015F0
	|-JSON.DecodeDictionary<ulong, Decimal>
	|
	|-RVA: 0xD01980 Offset: 0xCFFF80 VA: 0x180D01980
	|-JSON.DecodeDictionary<ulong, double>
	|
	|-RVA: 0xD01D10 Offset: 0xD00310 VA: 0x180D01D10
	|-JSON.DecodeDictionary<ulong, short>
	|
	|-RVA: 0xD020A0 Offset: 0xD006A0 VA: 0x180D020A0
	|-JSON.DecodeDictionary<ulong, int>
	|
	|-RVA: 0xD02430 Offset: 0xD00A30 VA: 0x180D02430
	|-JSON.DecodeDictionary<ulong, long>
	|
	|-RVA: 0xD027C0 Offset: 0xD00DC0 VA: 0x180D027C0
	|-JSON.DecodeDictionary<ulong, object>
	|
	|-RVA: 0xD02B50 Offset: 0xD01150 VA: 0x180D02B50
	|-JSON.DecodeDictionary<ulong, float>
	|
	|-RVA: 0xD02EE0 Offset: 0xD014E0 VA: 0x180D02EE0
	|-JSON.DecodeDictionary<ulong, ushort>
	|
	|-RVA: 0xD03270 Offset: 0xD01870 VA: 0x180D03270
	|-JSON.DecodeDictionary<ulong, uint>
	|
	|-RVA: 0xD03600 Offset: 0xD01C00 VA: 0x180D03600
	|-JSON.DecodeDictionary<ulong, ulong>
	*/

	[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	private static T[] DecodeArray<T>(Variant data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A39610 Offset: 0x1A37C10 VA: 0x181A39610
	|-JSON.DecodeArray<bool>
	|
	|-RVA: 0x1A39830 Offset: 0x1A37E30 VA: 0x181A39830
	|-JSON.DecodeArray<Decimal>
	|
	|-RVA: 0x1A39A70 Offset: 0x1A38070 VA: 0x181A39A70
	|-JSON.DecodeArray<double>
	|
	|-RVA: 0x1A39CA0 Offset: 0x1A382A0 VA: 0x181A39CA0
	|-JSON.DecodeArray<short>
	|
	|-RVA: 0x1A39EC0 Offset: 0x1A384C0 VA: 0x181A39EC0
	|-JSON.DecodeArray<int>
	|
	|-RVA: 0x1A3A0E0 Offset: 0x1A386E0 VA: 0x181A3A0E0
	|-JSON.DecodeArray<long>
	|
	|-RVA: 0x1A3A300 Offset: 0x1A38900 VA: 0x181A3A300
	|-JSON.DecodeArray<object>
	|
	|-RVA: 0x1A3A510 Offset: 0x1A38B10 VA: 0x181A3A510
	|-JSON.DecodeArray<float>
	|
	|-RVA: 0x1A3A740 Offset: 0x1A38D40 VA: 0x181A3A740
	|-JSON.DecodeArray<ushort>
	|
	|-RVA: 0x1A3A960 Offset: 0x1A38F60 VA: 0x181A3A960
	|-JSON.DecodeArray<uint>
	|
	|-RVA: 0x1A3AB80 Offset: 0x1A39180 VA: 0x181A3AB80
	|-JSON.DecodeArray<ulong>
	*/

	[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	private static void DecodeMultiRankArray<T>(ProxyArray arrayData, Array array, int arrayRank, int[] indices) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CE950 Offset: 0x5CCF50 VA: 0x1805CE950
	|-JSON.DecodeMultiRankArray<object>
	*/

	[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static void SupportTypeForAOT<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CEB80 Offset: 0x5CD180 VA: 0x1805CEB80
	|-JSON.SupportTypeForAOT<bool>
	|
	|-RVA: 0x5CECB0 Offset: 0x5CD2B0 VA: 0x1805CECB0
	|-JSON.SupportTypeForAOT<Decimal>
	|
	|-RVA: 0x5CEDE0 Offset: 0x5CD3E0 VA: 0x1805CEDE0
	|-JSON.SupportTypeForAOT<double>
	|
	|-RVA: 0x5CEF10 Offset: 0x5CD510 VA: 0x1805CEF10
	|-JSON.SupportTypeForAOT<short>
	|
	|-RVA: 0x5CF040 Offset: 0x5CD640 VA: 0x1805CF040
	|-JSON.SupportTypeForAOT<int>
	|
	|-RVA: 0x5CF170 Offset: 0x5CD770 VA: 0x1805CF170
	|-JSON.SupportTypeForAOT<long>
	|
	|-RVA: 0x5CF2A0 Offset: 0x5CD8A0 VA: 0x1805CF2A0
	|-JSON.SupportTypeForAOT<object>
	|-JSON.SupportTypeForAOT<string>
	|
	|-RVA: 0x5CF3D0 Offset: 0x5CD9D0 VA: 0x1805CF3D0
	|-JSON.SupportTypeForAOT<float>
	|
	|-RVA: 0x5CF500 Offset: 0x5CDB00 VA: 0x1805CF500
	|-JSON.SupportTypeForAOT<ushort>
	|
	|-RVA: 0x5CF630 Offset: 0x5CDC30 VA: 0x1805CF630
	|-JSON.SupportTypeForAOT<uint>
	|
	|-RVA: 0x5CF760 Offset: 0x5CDD60 VA: 0x1805CF760
	|-JSON.SupportTypeForAOT<ulong>
	*/

	[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x85DE70 Offset: 0x85C470 VA: 0x18085DE70
	private static void SupportValueTypesForAOT() { }

	// RVA: 0x85DF40 Offset: 0x85C540 VA: 0x18085DF40
	private static void .cctor() { }

}

