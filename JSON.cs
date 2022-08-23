public static class JsonUtility // TypeDefIndex: 4525
{
[NativeHeaderAttribute] // RVA: 0xE7DF0 Offset: 0xE71F0 VA: 0x1800E7DF0
public static class JsonUtility // TypeDefIndex: 4525

	[ThreadSafeAttribute] // RVA: 0xE7F30 Offset: 0xE7330 VA: 0x1800E7F30
	[FreeFunctionAttribute] // RVA: 0xE7F30 Offset: 0xE7330 VA: 0x1800E7F30
	private static object FromJsonInternal(string json, object objectToOverwrite, Type type) { }

	public static T FromJson<T>(string json) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B8580 Offset: 0x15B6B80 VA: 0x1815B8580
	|-JsonUtility.FromJson<RandomUsernames.DataFile>
	|-JsonUtility.FromJson<object>
	*/

	public static object FromJson(string json, Type type) { }

}

internal enum JSONNodeType // TypeDefIndex: 5637
{	public int value__; // 0x0
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
{	public int value__; // 0x0
	public const JSONTextMode Compact = 0;
	public const JSONTextMode Indent = 1;

}

internal abstract class JSONNode // TypeDefIndex: 5639
{	public static bool forceASCII; // 0x0
	public static bool longAsString; // 0x1
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static StringBuilder m_EscapeBuilder; // 0x80000000

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


	public virtual JSONNode get_Item(int aIndex) { }

	public virtual JSONNode get_Item(string aKey) { }

	public virtual void set_Item(string aKey, JSONNode value) { }

	public virtual string get_Value() { }

	public virtual int get_Count() { }

	public virtual bool get_IsNumber() { }

	public virtual bool get_IsBoolean() { }

	public virtual bool get_IsArray() { }

	public virtual void Add(string aKey, JSONNode aItem) { }

	public virtual void Add(JSONNode aItem) { }

	[IteratorStateMachineAttribute] // RVA: 0xBB950 Offset: 0xBAD50 VA: 0x1800BB950
	public virtual IEnumerable<JSONNode> get_Children() { }

	public override string ToString() { }

	internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

	public abstract JSONNode.Enumerator GetEnumerator();

	public virtual double get_AsDouble() { }

	public virtual int get_AsInt() { }

	public virtual bool get_AsBool() { }

	public virtual long get_AsLong() { }

	public virtual JSONArray get_AsArray() { }

	public virtual JSONObject get_AsObject() { }

	public static JSONNode op_Implicit(string s) { }

	public static string op_Implicit(JSONNode d) { }

	public static JSONNode op_Implicit(double n) { }

	public static JSONNode op_Implicit(bool b) { }

	public static bool op_Equality(JSONNode a, object b) { }

	public static bool op_Inequality(JSONNode a, object b) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	internal static StringBuilder get_EscapeBuilder() { }

	internal static string Escape(string aText) { }

	private static JSONNode ParseElement(string token, bool quoted) { }

	public static JSONNode Parse(string aJSON) { }

	public abstract void SerializeBinary(BinaryWriter aWriter);

	public void SaveToBinaryStream(Stream aData) { }

	public string SaveToBinaryBase64() { }

	public static JSONNode DeserializeBinary(BinaryReader aReader) { }

	public static JSONNode LoadFromBinaryStream(Stream aData) { }

	public static JSONNode LoadFromBinaryBase64(string aBase64) { }

	protected void .ctor() { }

}

public struct JSONNode.Enumerator // TypeDefIndex: 5640
{	private JSONNode.Enumerator.Type type; // 0x0
	private Dictionary.Enumerator<string, JSONNode> m_Object; // 0x8
	private List.Enumerator<JSONNode> m_Array; // 0x30

	public KeyValuePair<string, JSONNode> Current { get; }


	public void .ctor(List.Enumerator<JSONNode> aArrayEnum) { }

	public void .ctor(Dictionary.Enumerator<string, JSONNode> aDictEnum) { }

	public KeyValuePair<string, JSONNode> get_Current() { }

	public bool MoveNext() { }

}

private enum JSONNode.Enumerator.Type // TypeDefIndex: 5641
{	public int value__; // 0x0
	public const JSONNode.Enumerator.Type None = 0;
	public const JSONNode.Enumerator.Type Array = 1;
	public const JSONNode.Enumerator.Type Object = 2;

}

private sealed class JSONNode.<get_Children>d__40 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IDisposable, IEnumerator // TypeDefIndex: 5642
{	private int <>1__state; // 0x10
	private JSONNode <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20

	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<GameAnalyticsSDK.Net.Utilities.JSONNode>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

internal class JSONArray : JSONNode // TypeDefIndex: 5643
{	private List<JSONNode> m_List; // 0x10
	private bool inline; // 0x18

	public override bool IsArray { get; }
	public override JSONNode Item { get; }
	public override JSONNode Item { get; set; }
	public override int Count { get; }
	public override IEnumerable<JSONNode> Children { get; }


	public override bool get_IsArray() { }

	public override JSONNode.Enumerator GetEnumerator() { }

	public override JSONNode get_Item(int aIndex) { }

	public override JSONNode get_Item(string aKey) { }

	public override void set_Item(string aKey, JSONNode value) { }

	public override int get_Count() { }

	public override void Add(string aKey, JSONNode aItem) { }

	[IteratorStateMachineAttribute] // RVA: 0xBBEB0 Offset: 0xBB2B0 VA: 0x1800BBEB0
	public override IEnumerable<JSONNode> get_Children() { }

	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	public override void SerializeBinary(BinaryWriter aWriter) { }

	public void .ctor() { }

}

private sealed class JSONArray.<get_Children>d__22 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IDisposable, IEnumerator // TypeDefIndex: 5644
{	private int <>1__state; // 0x10
	private JSONNode <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public JSONArray <>4__this; // 0x28
	private List.Enumerator<JSONNode> <>7__wrap1; // 0x30

	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<GameAnalyticsSDK.Net.Utilities.JSONNode>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

internal class JSONObject : JSONNode // TypeDefIndex: 5645
{	private Dictionary<string, JSONNode> m_Dict; // 0x10
	private bool inline; // 0x18

	public override JSONNode Item { get; set; }
	public override JSONNode Item { get; }
	public override int Count { get; }
	public override IEnumerable<JSONNode> Children { get; }


	public override JSONNode.Enumerator GetEnumerator() { }

	public override JSONNode get_Item(string aKey) { }

	public override void set_Item(string aKey, JSONNode value) { }

	public override JSONNode get_Item(int aIndex) { }

	public override int get_Count() { }

	public override void Add(string aKey, JSONNode aItem) { }

	[IteratorStateMachineAttribute] // RVA: 0xBDD90 Offset: 0xBD190 VA: 0x1800BDD90
	public override IEnumerable<JSONNode> get_Children() { }

	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	public override void SerializeBinary(BinaryWriter aWriter) { }

	public void .ctor() { }

}

private sealed class JSONObject.<get_Children>d__23 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IDisposable, IEnumerator // TypeDefIndex: 5646
{	private int <>1__state; // 0x10
	private JSONNode <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public JSONObject <>4__this; // 0x28
	private Dictionary.Enumerator<string, JSONNode> <>7__wrap1; // 0x30

	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<GameAnalyticsSDK.Net.Utilities.JSONNode>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

internal class JSONString : JSONNode // TypeDefIndex: 5647
{	private string m_Data; // 0x10

	public override string Value { get; }


	public override JSONNode.Enumerator GetEnumerator() { }

	public override string get_Value() { }

	public void .ctor(string aData) { }

	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override void SerializeBinary(BinaryWriter aWriter) { }

}

internal class JSONNumber : JSONNode // TypeDefIndex: 5648
{	private double m_Data; // 0x10

	public override bool IsNumber { get; }
	public override string Value { get; }
	public override double AsDouble { get; }
	public override long AsLong { get; }


	public override bool get_IsNumber() { }

	public override JSONNode.Enumerator GetEnumerator() { }

	public override string get_Value() { }

	public override double get_AsDouble() { }

	public override long get_AsLong() { }

	public void .ctor(double aData) { }

	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	private static bool IsNumeric(object value) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override void SerializeBinary(BinaryWriter aWriter) { }

}

internal class JSONBool : JSONNode // TypeDefIndex: 5649
{	private bool m_Data; // 0x10

	public override bool IsBoolean { get; }
	public override string Value { get; }
	public override bool AsBool { get; }


	public override bool get_IsBoolean() { }

	public override JSONNode.Enumerator GetEnumerator() { }

	public override string get_Value() { }

	public override bool get_AsBool() { }

	public void .ctor(bool aData) { }

	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override void SerializeBinary(BinaryWriter aWriter) { }

}

internal class JSONNull : JSONNode // TypeDefIndex: 5650
{	private static JSONNull m_StaticInstance; // 0x0
	public static bool reuseSameInstance; // 0x8

	public override string Value { get; }
	public override bool AsBool { get; }


	public static JSONNull CreateOrGet() { }

	private void .ctor() { }

	public override JSONNode.Enumerator GetEnumerator() { }

	public override string get_Value() { }

	public override bool get_AsBool() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	public override void SerializeBinary(BinaryWriter aWriter) { }

	private static void .cctor() { }

}

internal class JSONLazyCreator : JSONNode // TypeDefIndex: 5651
{	private JSONNode m_Node; // 0x10
	private string m_Key; // 0x18

	public override JSONNode Item { get; }
	public override JSONNode Item { get; set; }
	public override int AsInt { get; }
	public override double AsDouble { get; }
	public override long AsLong { get; }
	public override bool AsBool { get; }
	public override JSONArray AsArray { get; }
	public override JSONObject AsObject { get; }


	public override JSONNode.Enumerator GetEnumerator() { }

	public void .ctor(JSONNode aNode) { }

	public void .ctor(JSONNode aNode, string aKey) { }

	private T Set<T>(T aVal) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CE9A0 Offset: 0x5CCFA0 VA: 0x1805CE9A0
	|-JSONLazyCreator.Set<JSONArray>
	|-JSONLazyCreator.Set<JSONBool>
	|-JSONLazyCreator.Set<JSONNumber>
	|-JSONLazyCreator.Set<JSONObject>
	|-JSONLazyCreator.Set<JSONString>
	|-JSONLazyCreator.Set<object>
	*/

	public override JSONNode get_Item(int aIndex) { }

	public override JSONNode get_Item(string aKey) { }

	public override void set_Item(string aKey, JSONNode value) { }

	public override void Add(JSONNode aItem) { }

	public override void Add(string aKey, JSONNode aItem) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override int get_AsInt() { }

	public override double get_AsDouble() { }

	public override long get_AsLong() { }

	public override bool get_AsBool() { }

	public override JSONArray get_AsArray() { }

	public override JSONObject get_AsObject() { }

	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	public override void SerializeBinary(BinaryWriter aWriter) { }

}

internal static class JSON // TypeDefIndex: 5652
{
	public static JSONNode Parse(string aJSON) { }

}

public sealed class JsonConstructorAttribute : Attribute // TypeDefIndex: 5872
{
	public void .ctor() { }

}

public class JsonException : Exception // TypeDefIndex: 5874
{
	public void .ctor() { }

	public void .ctor(string message) { }

	public void .ctor(string message, Exception innerException) { }

	public void .ctor(SerializationInfo info, StreamingContext context) { }

}

public class JsonExtensionDataAttribute : Attribute // TypeDefIndex: 5875
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <WriteData>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <ReadData>k__BackingField; // 0x11

	public bool WriteData { get; set; }
	public bool ReadData { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool get_WriteData() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_WriteData(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool get_ReadData() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ReadData(bool value) { }

	public void .ctor() { }

}

internal enum JsonContainerType // TypeDefIndex: 5876
{	public int value__; // 0x0
	public const JsonContainerType None = 0;
	public const JsonContainerType Object = 1;
	public const JsonContainerType Array = 2;
	public const JsonContainerType Constructor = 3;

}

internal struct JsonPosition // TypeDefIndex: 5877
{	private static readonly char[] SpecialCharacters; // 0x0
	internal JsonContainerType Type; // 0x0
	internal int Position; // 0x4
	internal string PropertyName; // 0x8
	internal bool HasIndex; // 0x10


	public void .ctor(JsonContainerType type) { }

	internal int CalculateLength() { }

	internal void WriteTo(StringBuilder sb) { }

	internal static bool TypeHasIndex(JsonContainerType type) { }

	internal static string BuildPath(List<JsonPosition> positions, Nullable<JsonPosition> currentPosition) { }

	internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message) { }

	private static void .cctor() { }

}

public sealed class JsonRequiredAttribute : Attribute // TypeDefIndex: 5878
{
	public void .ctor() { }

}

public sealed class JsonArrayAttribute : JsonContainerAttribute // TypeDefIndex: 5884
{
	public void .ctor() { }

}

public abstract class JsonContainerAttribute : Attribute // TypeDefIndex: 5885
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Type <ItemConverterType>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object[] <ItemConverterParameters>k__BackingField; // 0x18
	internal Nullable<bool> _isReference; // 0x20
	internal Nullable<bool> _itemIsReference; // 0x22
	internal Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling; // 0x24
	internal Nullable<TypeNameHandling> _itemTypeNameHandling; // 0x2C

	public Type ItemConverterType { get; }
	public object[] ItemConverterParameters { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Type get_ItemConverterType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public object[] get_ItemConverterParameters() { }

	protected void .ctor() { }

}

public sealed class JsonConverterAttribute : Attribute // TypeDefIndex: 5887
{	private readonly Type _converterType; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object[] <ConverterParameters>k__BackingField; // 0x18

	public Type ConverterType { get; }
	public object[] ConverterParameters { get; }


	public Type get_ConverterType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public object[] get_ConverterParameters() { }

	public void .ctor(Type converterType) { }

}

public sealed class JsonObjectAttribute : JsonContainerAttribute // TypeDefIndex: 5888
{	private MemberSerialization _memberSerialization; // 0x38
	internal Nullable<Required> _itemRequired; // 0x3C

	public MemberSerialization MemberSerialization { get; }


	public MemberSerialization get_MemberSerialization() { }

	public void .ctor() { }

}

public class JsonSerializerSettings // TypeDefIndex: 5889
{	internal static readonly StreamingContext DefaultContext; // 0x0
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


	public ReferenceLoopHandling get_ReferenceLoopHandling() { }

	public MissingMemberHandling get_MissingMemberHandling() { }

	public ObjectCreationHandling get_ObjectCreationHandling() { }

	public NullValueHandling get_NullValueHandling() { }

	public DefaultValueHandling get_DefaultValueHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public IList<JsonConverter> get_Converters() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_Converters(IList<JsonConverter> value) { }

	public PreserveReferencesHandling get_PreserveReferencesHandling() { }

	public TypeNameHandling get_TypeNameHandling() { }

	public MetadataPropertyHandling get_MetadataPropertyHandling() { }

	public FormatterAssemblyStyle get_TypeNameAssemblyFormat() { }

	public ConstructorHandling get_ConstructorHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public IContractResolver get_ContractResolver() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public IEqualityComparer get_EqualityComparer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Func<IReferenceResolver> get_ReferenceResolverProvider() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public ITraceWriter get_TraceWriter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public SerializationBinder get_Binder() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public EventHandler<ErrorEventArgs> get_Error() { }

	public StreamingContext get_Context() { }

	private static void .cctor() { }

	public void .ctor() { }

}

private sealed class JsonSerializerSettings.<>c__DisplayClass90_0 // TypeDefIndex: 5890
{
	public void .ctor() { }

}

public class JsonTextReader : JsonReader, IJsonLineInfo // TypeDefIndex: 5894
{	private readonly TextReader _reader; // 0x78
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

	public int LineNumber { get; }
	public int LinePosition { get; }


	public void .ctor(TextReader reader) { }

	private void EnsureBufferNotEmpty() { }

	private void OnNewLine(int pos) { }

	private void ParseString(char quote, ReadType readType) { }

	private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count) { }

	private void ShiftBufferIfNeeded() { }

	private int ReadData(bool append) { }

	private int ReadData(bool append, int charsRequired) { }

	private bool EnsureChars(int relativePosition, bool append) { }

	private bool ReadChars(int relativePosition, bool append) { }

	public override bool Read() { }

	public override Nullable<int> ReadAsInt32() { }

	public override Nullable<DateTime> ReadAsDateTime() { }

	public override string ReadAsString() { }

	public override byte[] ReadAsBytes() { }

	private object ReadStringValue(ReadType readType) { }

	private JsonReaderException CreateUnexpectedCharacterException(char c) { }

	public override Nullable<bool> ReadAsBoolean() { }

	private void ProcessValueComma() { }

	private object ReadNumberValue(ReadType readType) { }

	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	public override Nullable<Decimal> ReadAsDecimal() { }

	public override Nullable<double> ReadAsDouble() { }

	private void HandleNull() { }

	private void ReadFinished() { }

	private bool ReadNullChar() { }

	private void EnsureBuffer() { }

	private void ReadStringIntoBuffer(char quote) { }

	private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition) { }

	private char ParseUnicode() { }

	private void ReadNumberIntoBuffer() { }

	private void ClearRecentString() { }

	private bool ParsePostValue() { }

	private bool ParseObject() { }

	private bool ParseProperty() { }

	private bool ValidIdentifierChar(char value) { }

	private void ParseUnquotedProperty() { }

	private bool ParseValue() { }

	private void ProcessLineFeed() { }

	private void ProcessCarriageReturn(bool append) { }

	private bool EatWhitespace(bool oneOrMore) { }

	private void ParseConstructor() { }

	private void ParseNumber(ReadType readType) { }

	private void ParseComment(bool setToken) { }

	private void EndComment(bool setToken, int initialPosition, int endPosition) { }

	private bool MatchValue(string value) { }

	private bool MatchValueWithTrailingSeparator(string value) { }

	private bool IsSeparator(char c) { }

	private void ParseTrue() { }

	private void ParseNull() { }

	private void ParseUndefined() { }

	private void ParseFalse() { }

	private object ParseNumberNegativeInfinity(ReadType readType) { }

	private object ParseNumberPositiveInfinity(ReadType readType) { }

	private object ParseNumberNaN(ReadType readType) { }

	public override void Close() { }

	public bool HasLineInfo() { }

	public int get_LineNumber() { }

	public int get_LinePosition() { }

}

public sealed class JsonPropertyAttribute : Attribute // TypeDefIndex: 5895
{	internal Nullable<NullValueHandling> _nullValueHandling; // 0x10
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

	public Type ItemConverterType { get; }
	public object[] ItemConverterParameters { get; }
	public string PropertyName { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Type get_ItemConverterType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public object[] get_ItemConverterParameters() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public string get_PropertyName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_PropertyName(string value) { }

	public void .ctor() { }

	public void .ctor(string propertyName) { }

}

public sealed class JsonIgnoreAttribute : Attribute // TypeDefIndex: 5896
{
	public void .ctor() { }

}

public class JsonTextWriter : JsonWriter // TypeDefIndex: 5897
{	private readonly TextWriter _writer; // 0x60
	private Base64Encoder _base64Encoder; // 0x68
	private char _indentChar; // 0x70
	private int _indentation; // 0x74
	private char _quoteChar; // 0x78
	private bool _quoteName; // 0x7A
	private bool[] _charEscapeFlags; // 0x80
	private char[] _writeBuffer; // 0x88
	private IArrayPool<char> _arrayPool; // 0x90
	private char[] _indentChars; // 0x98

	private Base64Encoder Base64Encoder { get; }
	public char QuoteChar { get; }


	private Base64Encoder get_Base64Encoder() { }

	public char get_QuoteChar() { }

	public void .ctor(TextWriter textWriter) { }

	public override void Close() { }

	public override void WriteStartObject() { }

	public override void WriteStartArray() { }

	public override void WriteStartConstructor(string name) { }

	protected override void WriteEnd(JsonToken token) { }

	public override void WritePropertyName(string name) { }

	public override void WritePropertyName(string name, bool escape) { }

	internal override void OnStringEscapeHandlingChanged() { }

	private void UpdateCharEscapeFlags() { }

	protected override void WriteIndent() { }

	protected override void WriteValueDelimiter() { }

	protected override void WriteIndentSpace() { }

	private void WriteValueInternal(string value, JsonToken token) { }

	public override void WriteValue(object value) { }

	public override void WriteNull() { }

	public override void WriteUndefined() { }

	public override void WriteRaw(string json) { }

	public override void WriteValue(string value) { }

	private void WriteEscapedString(string value, bool quote) { }

	public override void WriteValue(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public override void WriteValue(uint value) { }

	public override void WriteValue(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public override void WriteValue(ulong value) { }

	public override void WriteValue(float value) { }

	public override void WriteValue(Nullable<float> value) { }

	public override void WriteValue(double value) { }

	public override void WriteValue(Nullable<double> value) { }

	public override void WriteValue(bool value) { }

	public override void WriteValue(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public override void WriteValue(ushort value) { }

	public override void WriteValue(char value) { }

	public override void WriteValue(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public override void WriteValue(sbyte value) { }

	public override void WriteValue(Decimal value) { }

	public override void WriteValue(DateTime value) { }

	public override void WriteValue(byte[] value) { }

	public override void WriteValue(DateTimeOffset value) { }

	public override void WriteValue(Guid value) { }

	public override void WriteValue(TimeSpan value) { }

	public override void WriteValue(Uri value) { }

	public override void WriteComment(string text) { }

	private void EnsureWriteBuffer() { }

	private void WriteIntegerValue(long value) { }

	private void WriteIntegerValue(ulong uvalue) { }

}

public class JsonWriterException : JsonException // TypeDefIndex: 5898
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Path>k__BackingField; // 0x88

	private string Path { set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_Path(string value) { }

	public void .ctor() { }

	public void .ctor(SerializationInfo info, StreamingContext context) { }

	internal void .ctor(string message, Exception innerException, string path) { }

	internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex) { }

	internal static JsonWriterException Create(string path, string message, Exception ex) { }

}

public class JsonReaderException : JsonException // TypeDefIndex: 5899
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <LineNumber>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <LinePosition>k__BackingField; // 0x8C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Path>k__BackingField; // 0x90

	private int LineNumber { set; }
	private int LinePosition { set; }
	private string Path { set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_LineNumber(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_LinePosition(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_Path(string value) { }

	public void .ctor() { }

	public void .ctor(SerializationInfo info, StreamingContext context) { }

	internal void .ctor(string message, Exception innerException, string path, int lineNumber, int linePosition) { }

	internal static JsonReaderException Create(JsonReader reader, string message) { }

	internal static JsonReaderException Create(JsonReader reader, string message, Exception ex) { }

	internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }

}

public abstract class JsonConverter // TypeDefIndex: 5900
{	public virtual bool CanRead { get; }
	public virtual bool CanWrite { get; }


	public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);

	public abstract object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);

	public abstract bool CanConvert(Type objectType);

	public virtual bool get_CanRead() { }

	public virtual bool get_CanWrite() { }

	protected void .ctor() { }

}

public class JsonConverterCollection : Collection<JsonConverter> // TypeDefIndex: 5901
{
	public void .ctor() { }

}

public abstract class JsonReader : IDisposable // TypeDefIndex: 5902
{	private JsonToken _tokenType; // 0x10
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


	protected JsonReader.State get_CurrentState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool get_CloseInput() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_CloseInput(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool get_SupportMultipleContent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_SupportMultipleContent(bool value) { }

	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	public DateParseHandling get_DateParseHandling() { }

	public void set_DateParseHandling(DateParseHandling value) { }

	public FloatParseHandling get_FloatParseHandling() { }

	public void set_FloatParseHandling(FloatParseHandling value) { }

	public string get_DateFormatString() { }

	public void set_DateFormatString(string value) { }

	public Nullable<int> get_MaxDepth() { }

	public void set_MaxDepth(Nullable<int> value) { }

	public virtual JsonToken get_TokenType() { }

	public virtual object get_Value() { }

	public virtual Type get_ValueType() { }

	public virtual int get_Depth() { }

	public virtual string get_Path() { }

	public CultureInfo get_Culture() { }

	public void set_Culture(CultureInfo value) { }

	internal JsonPosition GetPosition(int depth) { }

	protected void .ctor() { }

	private void Push(JsonContainerType value) { }

	private JsonContainerType Pop() { }

	private JsonContainerType Peek() { }

	public abstract bool Read();

	public virtual Nullable<int> ReadAsInt32() { }

	internal Nullable<int> ReadInt32String(string s) { }

	public virtual string ReadAsString() { }

	public virtual byte[] ReadAsBytes() { }

	internal byte[] ReadArrayIntoByteArray() { }

	public virtual Nullable<double> ReadAsDouble() { }

	internal Nullable<double> ReadDoubleString(string s) { }

	public virtual Nullable<bool> ReadAsBoolean() { }

	internal Nullable<bool> ReadBooleanString(string s) { }

	public virtual Nullable<Decimal> ReadAsDecimal() { }

	internal Nullable<Decimal> ReadDecimalString(string s) { }

	public virtual Nullable<DateTime> ReadAsDateTime() { }

	internal Nullable<DateTime> ReadDateTimeString(string s) { }

	public virtual Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	internal Nullable<DateTimeOffset> ReadDateTimeOffsetString(string s) { }

	internal void ReaderReadAndAssert() { }

	internal JsonReaderException CreateUnexpectedEndException() { }

	internal void ReadIntoWrappedTypeObject() { }

	public void Skip() { }

	protected void SetToken(JsonToken newToken) { }

	protected void SetToken(JsonToken newToken, object value) { }

	internal void SetToken(JsonToken newToken, object value, bool updateIndex) { }

	internal void SetPostValueState(bool updateIndex) { }

	private void UpdateScopeWithFinishedValue() { }

	private void ValidateEnd(JsonToken endToken) { }

	protected void SetStateBasedOnCurrent() { }

	private void SetFinished() { }

	private JsonContainerType GetTypeForCloseToken(JsonToken token) { }

	private void System.IDisposable.Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual void Close() { }

	internal void ReadAndAssert() { }

	internal bool ReadAndMoveToContent() { }

	internal bool MoveToContent() { }

	private JsonToken GetContentToken() { }

}

public static class JsonConvert // TypeDefIndex: 5904
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Func<JsonSerializerSettings> <DefaultSettings>k__BackingField; // 0x0
	public static readonly string True; // 0x8
	public static readonly string False; // 0x10
	public static readonly string Null; // 0x18
	public static readonly string Undefined; // 0x20
	public static readonly string PositiveInfinity; // 0x28
	public static readonly string NegativeInfinity; // 0x30
	public static readonly string NaN; // 0x38
	private static readonly JsonSerializerSettings InitialSerializerSettings; // 0x40

	public static Func<JsonSerializerSettings> DefaultSettings { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static Func<JsonSerializerSettings> get_DefaultSettings() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void set_DefaultSettings(Func<JsonSerializerSettings> value) { }

	private static void .cctor() { }

	internal static JsonSerializerSettings GetDefaultSettings() { }

	public static string ToString(bool value) { }

	public static string ToString(char value) { }

	internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	private static string EnsureDecimalPlace(double value, string text) { }

	private static string EnsureDecimalPlace(string text) { }

	public static string ToString(Decimal value) { }

	public static string ToString(string value) { }

	public static string ToString(string value, char delimiter) { }

	public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling) { }

	public static string SerializeObject(object value) { }

	public static string SerializeObject(object value, Formatting formatting) { }

	public static string SerializeObject(object value, Type type, JsonSerializerSettings settings) { }

	public static string SerializeObject(object value, Formatting formatting, JsonSerializerSettings settings) { }

	public static string SerializeObject(object value, Type type, Formatting formatting, JsonSerializerSettings settings) { }

	private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer) { }

	public static object DeserializeObject(string value, Type type) { }

	public static T DeserializeObject<T>(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CFCF0 Offset: 0x5CE2F0 VA: 0x1805CFCF0
	|-JsonConvert.DeserializeObject<CameraMan.CameraState>
	|
	|-RVA: 0x5D0270 Offset: 0x5CE870 VA: 0x1805D0270
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
	|-RVA: 0x5D00B0 Offset: 0x5CE6B0 VA: 0x1805D00B0
	|-JsonConvert.DeserializeObject<NoticeData>
	|
	|-RVA: 0x5CFEA0 Offset: 0x5CE4A0 VA: 0x1805CFEA0
	|-JsonConvert.DeserializeObject<RCon.Command>
	|
	|-RVA: 0x5CFF40 Offset: 0x5CE540 VA: 0x1805CFF40
	|-JsonConvert.DeserializeObject<CorePropsFile>
	*/

	public static T DeserializeObject<T>(string value, JsonSerializerSettings settings) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CFBD0 Offset: 0x5CE1D0 VA: 0x1805CFBD0
	|-JsonConvert.DeserializeObject<CameraMan.CameraState>
	|
	|-RVA: 0x5D0150 Offset: 0x5CE750 VA: 0x1805D0150
	|-JsonConvert.DeserializeObject<NoticeData>
	|
	|-RVA: 0x5CFD80 Offset: 0x5CE380 VA: 0x1805CFD80
	|-JsonConvert.DeserializeObject<RCon.Command>
	|
	|-RVA: 0x5CFFB0 Offset: 0x5CE5B0 VA: 0x1805CFFB0
	|-JsonConvert.DeserializeObject<CorePropsFile>
	|
	|-RVA: 0x5D02E0 Offset: 0x5CE8E0 VA: 0x1805D02E0
	|-JsonConvert.DeserializeObject<object>
	*/

	public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings) { }

}

public class JsonSerializationException : JsonException // TypeDefIndex: 5905
{
	public void .ctor() { }

	public void .ctor(string message) { }

	public void .ctor(string message, Exception innerException) { }

	public void .ctor(SerializationInfo info, StreamingContext context) { }

	internal static JsonSerializationException Create(JsonReader reader, string message) { }

	internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex) { }

	internal static JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }

}

public class JsonSerializer // TypeDefIndex: 5906
{	internal TypeNameHandling _typeNameHandling; // 0x10
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


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public virtual void add_Error(EventHandler<ErrorEventArgs> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public virtual void remove_Error(EventHandler<ErrorEventArgs> value) { }

	public virtual void set_ReferenceResolver(IReferenceResolver value) { }

	public virtual void set_Binder(SerializationBinder value) { }

	public virtual ITraceWriter get_TraceWriter() { }

	public virtual void set_TraceWriter(ITraceWriter value) { }

	public virtual void set_EqualityComparer(IEqualityComparer value) { }

	public virtual void set_TypeNameHandling(TypeNameHandling value) { }

	public virtual void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	public virtual void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	public virtual void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	public virtual void set_MissingMemberHandling(MissingMemberHandling value) { }

	public virtual void set_NullValueHandling(NullValueHandling value) { }

	public virtual void set_DefaultValueHandling(DefaultValueHandling value) { }

	public virtual ObjectCreationHandling get_ObjectCreationHandling() { }

	public virtual void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	public virtual void set_ConstructorHandling(ConstructorHandling value) { }

	public virtual MetadataPropertyHandling get_MetadataPropertyHandling() { }

	public virtual void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	public virtual JsonConverterCollection get_Converters() { }

	public virtual IContractResolver get_ContractResolver() { }

	public virtual void set_ContractResolver(IContractResolver value) { }

	public virtual StreamingContext get_Context() { }

	public virtual void set_Context(StreamingContext value) { }

	public virtual Formatting get_Formatting() { }

	public virtual void set_Formatting(Formatting value) { }

	public virtual bool get_CheckAdditionalContent() { }

	public virtual void set_CheckAdditionalContent(bool value) { }

	internal bool IsCheckAdditionalContentSet() { }

	public void .ctor() { }

	public static JsonSerializer Create() { }

	public static JsonSerializer Create(JsonSerializerSettings settings) { }

	public static JsonSerializer CreateDefault() { }

	public static JsonSerializer CreateDefault(JsonSerializerSettings settings) { }

	private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings) { }

	public void Populate(JsonReader reader, object target) { }

	internal virtual void PopulateInternal(JsonReader reader, object target) { }

	public T Deserialize<T>(JsonReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0BA0 Offset: 0x5CF1A0 VA: 0x1805D0BA0
	|-JsonSerializer.Deserialize<Int32Enum>
	|-JsonSerializer.Deserialize<RegexOptions>
	|
	|-RVA: 0x5D0C80 Offset: 0x5CF280 VA: 0x1805D0C80
	|-JsonSerializer.Deserialize<object>
	*/

	public object Deserialize(JsonReader reader, Type objectType) { }

	internal virtual object DeserializeInternal(JsonReader reader, Type objectType) { }

	private void SetupReader(JsonReader reader, out CultureInfo previousCulture, out Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, out Nullable<DateParseHandling> previousDateParseHandling, out Nullable<FloatParseHandling> previousFloatParseHandling, out Nullable<int> previousMaxDepth, out string previousDateFormatString) { }

	private void ResetReader(JsonReader reader, CultureInfo previousCulture, Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, Nullable<DateParseHandling> previousDateParseHandling, Nullable<FloatParseHandling> previousFloatParseHandling, Nullable<int> previousMaxDepth, string previousDateFormatString) { }

	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	public void Serialize(JsonWriter jsonWriter, object value) { }

	internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType) { }

	internal IReferenceResolver GetReferenceResolver() { }

	internal JsonConverter GetMatchingConverter(Type type) { }

	internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType) { }

	internal void OnError(ErrorEventArgs e) { }

}

public enum JsonToken // TypeDefIndex: 5911
{	public int value__; // 0x0
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
{	private static readonly JsonWriter.State[][] StateArray; // 0x0
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


	internal static JsonWriter.State[][] BuildStateArray() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool get_CloseOutput() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_CloseOutput(bool value) { }

	protected internal int get_Top() { }

	public WriteState get_WriteState() { }

	internal string get_ContainerPath() { }

	public string get_Path() { }

	public Formatting get_Formatting() { }

	public void set_Formatting(Formatting value) { }

	public DateFormatHandling get_DateFormatHandling() { }

	public void set_DateFormatHandling(DateFormatHandling value) { }

	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	public StringEscapeHandling get_StringEscapeHandling() { }

	public void set_StringEscapeHandling(StringEscapeHandling value) { }

	internal virtual void OnStringEscapeHandlingChanged() { }

	public FloatFormatHandling get_FloatFormatHandling() { }

	public void set_FloatFormatHandling(FloatFormatHandling value) { }

	public string get_DateFormatString() { }

	public void set_DateFormatString(string value) { }

	public CultureInfo get_Culture() { }

	public void set_Culture(CultureInfo value) { }

	protected void .ctor() { }

	internal void UpdateScopeWithFinishedValue() { }

	private void Push(JsonContainerType value) { }

	private JsonContainerType Pop() { }

	private JsonContainerType Peek() { }

	public virtual void Close() { }

	public virtual void WriteStartObject() { }

	public virtual void WriteEndObject() { }

	public virtual void WriteStartArray() { }

	public virtual void WriteEndArray() { }

	public virtual void WriteStartConstructor(string name) { }

	public virtual void WriteEndConstructor() { }

	public virtual void WritePropertyName(string name) { }

	public virtual void WritePropertyName(string name, bool escape) { }

	public virtual void WriteEnd() { }

	public void WriteToken(JsonReader reader) { }

	public void WriteToken(JsonReader reader, bool writeChildren) { }

	public void WriteToken(JsonToken token, object value) { }

	internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

	private void WriteConstructorDate(JsonReader reader) { }

	private void WriteEnd(JsonContainerType type) { }

	private void AutoCompleteAll() { }

	private JsonToken GetCloseTokenForType(JsonContainerType type) { }

	private void AutoCompleteClose(JsonContainerType type) { }

	protected virtual void WriteEnd(JsonToken token) { }

	protected virtual void WriteIndent() { }

	protected virtual void WriteValueDelimiter() { }

	protected virtual void WriteIndentSpace() { }

	internal void AutoComplete(JsonToken tokenBeingWritten) { }

	public virtual void WriteNull() { }

	public virtual void WriteUndefined() { }

	public virtual void WriteRaw(string json) { }

	public virtual void WriteRawValue(string json) { }

	public virtual void WriteValue(string value) { }

	public virtual void WriteValue(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public virtual void WriteValue(uint value) { }

	public virtual void WriteValue(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public virtual void WriteValue(ulong value) { }

	public virtual void WriteValue(float value) { }

	public virtual void WriteValue(double value) { }

	public virtual void WriteValue(bool value) { }

	public virtual void WriteValue(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public virtual void WriteValue(ushort value) { }

	public virtual void WriteValue(char value) { }

	public virtual void WriteValue(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public virtual void WriteValue(sbyte value) { }

	public virtual void WriteValue(Decimal value) { }

	public virtual void WriteValue(DateTime value) { }

	public virtual void WriteValue(DateTimeOffset value) { }

	public virtual void WriteValue(Guid value) { }

	public virtual void WriteValue(TimeSpan value) { }

	public virtual void WriteValue(Nullable<int> value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public virtual void WriteValue(Nullable<uint> value) { }

	public virtual void WriteValue(Nullable<long> value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public virtual void WriteValue(Nullable<ulong> value) { }

	public virtual void WriteValue(Nullable<float> value) { }

	public virtual void WriteValue(Nullable<double> value) { }

	public virtual void WriteValue(Nullable<bool> value) { }

	public virtual void WriteValue(Nullable<short> value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public virtual void WriteValue(Nullable<ushort> value) { }

	public virtual void WriteValue(Nullable<char> value) { }

	public virtual void WriteValue(Nullable<byte> value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public virtual void WriteValue(Nullable<sbyte> value) { }

	public virtual void WriteValue(Nullable<Decimal> value) { }

	public virtual void WriteValue(Nullable<DateTime> value) { }

	public virtual void WriteValue(Nullable<DateTimeOffset> value) { }

	public virtual void WriteValue(Nullable<Guid> value) { }

	public virtual void WriteValue(Nullable<TimeSpan> value) { }

	public virtual void WriteValue(byte[] value) { }

	public virtual void WriteValue(Uri value) { }

	public virtual void WriteValue(object value) { }

	public virtual void WriteComment(string text) { }

	private void System.IDisposable.Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value) { }

	private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value) { }

	internal void InternalWriteEnd(JsonContainerType container) { }

	internal void InternalWritePropertyName(string name) { }

	internal void InternalWriteRaw() { }

	internal void InternalWriteStart(JsonToken token, JsonContainerType container) { }

	internal void InternalWriteValue(JsonToken token) { }

	internal void InternalWriteComment() { }

}

internal enum JsonWriter.State // TypeDefIndex: 5913
{	public int value__; // 0x0
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
{
	internal static bool IsEndToken(JsonToken token) { }

	internal static bool IsStartToken(JsonToken token) { }

	internal static bool IsPrimitiveToken(JsonToken token) { }

}

public class JsonContainerContract : JsonContract // TypeDefIndex: 5977
{	private JsonContract _itemContract; // 0x90
	private JsonContract _finalItemContract; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private JsonConverter <ItemConverter>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<bool> <ItemIsReference>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField; // 0xAC
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<TypeNameHandling> <ItemTypeNameHandling>k__BackingField; // 0xB4

	internal JsonContract ItemContract { get; set; }
	internal JsonContract FinalItemContract { get; }
	public JsonConverter ItemConverter { get; set; }
	public Nullable<bool> ItemIsReference { get; set; }
	public Nullable<ReferenceLoopHandling> ItemReferenceLoopHandling { get; set; }
	public Nullable<TypeNameHandling> ItemTypeNameHandling { get; set; }


	internal JsonContract get_ItemContract() { }

	internal void set_ItemContract(JsonContract value) { }

	internal JsonContract get_FinalItemContract() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public JsonConverter get_ItemConverter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ItemConverter(JsonConverter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Nullable<bool> get_ItemIsReference() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ItemIsReference(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

	internal void .ctor(Type underlyingType) { }

}

internal class TraceJsonReader : JsonReader, IJsonLineInfo // TypeDefIndex: 5980
{	private readonly JsonReader _innerReader; // 0x78
	private readonly JsonTextWriter _textWriter; // 0x80
	private readonly StringWriter _sw; // 0x88

	public override int Depth { get; }
	public override string Path { get; }
	public override JsonToken TokenType { get; }
	public override object Value { get; }
	public override Type ValueType { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }


	public void .ctor(JsonReader innerReader) { }

	public string GetDeserializedJsonMessage() { }

	public override bool Read() { }

	public override Nullable<int> ReadAsInt32() { }

	public override string ReadAsString() { }

	public override byte[] ReadAsBytes() { }

	public override Nullable<Decimal> ReadAsDecimal() { }

	public override Nullable<double> ReadAsDouble() { }

	public override Nullable<bool> ReadAsBoolean() { }

	public override Nullable<DateTime> ReadAsDateTime() { }

	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	public override int get_Depth() { }

	public override string get_Path() { }

	public override JsonToken get_TokenType() { }

	public override object get_Value() { }

	public override Type get_ValueType() { }

	public override void Close() { }

	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

}

internal class TraceJsonWriter : JsonWriter // TypeDefIndex: 5981
{	private readonly JsonWriter _innerWriter; // 0x60
	private readonly JsonTextWriter _textWriter; // 0x68
	private readonly StringWriter _sw; // 0x70


	public void .ctor(JsonWriter innerWriter) { }

	public string GetSerializedJsonMessage() { }

	public override void WriteValue(Decimal value) { }

	public override void WriteValue(bool value) { }

	public override void WriteValue(byte value) { }

	public override void WriteValue(Nullable<byte> value) { }

	public override void WriteValue(char value) { }

	public override void WriteValue(byte[] value) { }

	public override void WriteValue(DateTime value) { }

	public override void WriteValue(DateTimeOffset value) { }

	public override void WriteValue(double value) { }

	public override void WriteUndefined() { }

	public override void WriteNull() { }

	public override void WriteValue(float value) { }

	public override void WriteValue(Guid value) { }

	public override void WriteValue(int value) { }

	public override void WriteValue(long value) { }

	public override void WriteValue(object value) { }

	public override void WriteValue(sbyte value) { }

	public override void WriteValue(short value) { }

	public override void WriteValue(string value) { }

	public override void WriteValue(TimeSpan value) { }

	public override void WriteValue(uint value) { }

	public override void WriteValue(ulong value) { }

	public override void WriteValue(Uri value) { }

	public override void WriteValue(ushort value) { }

	public override void WriteComment(string text) { }

	public override void WriteStartArray() { }

	public override void WriteEndArray() { }

	public override void WriteStartConstructor(string name) { }

	public override void WriteEndConstructor() { }

	public override void WritePropertyName(string name) { }

	public override void WritePropertyName(string name, bool escape) { }

	public override void WriteStartObject() { }

	public override void WriteEndObject() { }

	public override void WriteRawValue(string json) { }

	public override void WriteRaw(string json) { }

	public override void Close() { }

}

internal class JsonFormatterConverter : IFormatterConverter // TypeDefIndex: 5982
{	private readonly JsonSerializerInternalReader _reader; // 0x10
	private readonly JsonISerializableContract _contract; // 0x18
	private readonly JsonProperty _member; // 0x20


	public void .ctor(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member) { }

	private T GetTokenValue<T>(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D03D0 Offset: 0x5CE9D0 VA: 0x1805D03D0
	|-JsonFormatterConverter.GetTokenValue<bool>
	|
	|-RVA: 0x5D0560 Offset: 0x5CEB60 VA: 0x1805D0560
	|-JsonFormatterConverter.GetTokenValue<int>
	|
	|-RVA: 0x5D06F0 Offset: 0x5CECF0 VA: 0x1805D06F0
	|-JsonFormatterConverter.GetTokenValue<long>
	|
	|-RVA: 0x5D0880 Offset: 0x5CEE80 VA: 0x1805D0880
	|-JsonFormatterConverter.GetTokenValue<object>
	|-JsonFormatterConverter.GetTokenValue<string>
	|
	|-RVA: 0x5D0A10 Offset: 0x5CF010 VA: 0x1805D0A10
	|-JsonFormatterConverter.GetTokenValue<float>
	*/

	public object Convert(object value, Type type) { }

	public bool ToBoolean(object value) { }

	public int ToInt32(object value) { }

	public long ToInt64(object value) { }

	public float ToSingle(object value) { }

	public string ToString(object value) { }

}

public class JsonLinqContract : JsonContract // TypeDefIndex: 5984
{
	public void .ctor(Type underlyingType) { }

}

public class JsonPrimitiveContract : JsonContract // TypeDefIndex: 5985
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PrimitiveTypeCode <TypeCode>k__BackingField; // 0x90
	private static readonly Dictionary<Type, ReadType> ReadTypeMap; // 0x0

	internal PrimitiveTypeCode TypeCode { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal PrimitiveTypeCode get_TypeCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal void set_TypeCode(PrimitiveTypeCode value) { }

	public void .ctor(Type underlyingType) { }

	private static void .cctor() { }

}

public class JsonArrayContract : JsonContainerContract // TypeDefIndex: 6005
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	public Type CollectionItemType { get; set; }
	public bool IsMultidimensionalArray { get; set; }
	internal bool IsArray { get; set; }
	internal bool ShouldCreateWrapper { get; set; }
	internal bool CanDeserialize { get; set; }
	internal ObjectConstructor<object> ParameterizedCreator { get; }
	public ObjectConstructor<object> OverrideCreator { get; set; }
	public bool HasParameterizedCreator { get; set; }
	internal bool HasParameterizedCreatorInternal { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Type get_CollectionItemType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_CollectionItemType(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool get_IsMultidimensionalArray() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_IsMultidimensionalArray(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal bool get_IsArray() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_IsArray(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal bool get_ShouldCreateWrapper() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ShouldCreateWrapper(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal bool get_CanDeserialize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_CanDeserialize(bool value) { }

	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	public ObjectConstructor<object> get_OverrideCreator() { }

	public void set_OverrideCreator(ObjectConstructor<object> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool get_HasParameterizedCreator() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_HasParameterizedCreator(bool value) { }

	internal bool get_HasParameterizedCreatorInternal() { }

	public void .ctor(Type underlyingType) { }

	internal IWrappedCollection CreateWrapper(object list) { }

	internal IList CreateTemporaryCollection() { }

}

internal enum JsonContractType // TypeDefIndex: 6006
{	public int value__; // 0x0
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
{	internal bool IsNullable; // 0x10
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


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Type get_UnderlyingType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_UnderlyingType(Type value) { }

	public Type get_CreatedType() { }

	public void set_CreatedType(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Nullable<bool> get_IsReference() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_IsReference(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public JsonConverter get_Converter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_Converter(JsonConverter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal JsonConverter get_InternalConverter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal void set_InternalConverter(JsonConverter value) { }

	public IList<SerializationCallback> get_OnDeserializedCallbacks() { }

	public IList<SerializationCallback> get_OnDeserializingCallbacks() { }

	public IList<SerializationCallback> get_OnSerializedCallbacks() { }

	public IList<SerializationCallback> get_OnSerializingCallbacks() { }

	public IList<SerializationErrorCallback> get_OnErrorCallbacks() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Func<object> get_DefaultCreator() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_DefaultCreator(Func<object> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool get_DefaultCreatorNonPublic() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_DefaultCreatorNonPublic(bool value) { }

	internal void .ctor(Type underlyingType) { }

	internal void InvokeOnSerializing(object o, StreamingContext context) { }

	internal void InvokeOnSerialized(object o, StreamingContext context) { }

	internal void InvokeOnDeserializing(object o, StreamingContext context) { }

	internal void InvokeOnDeserialized(object o, StreamingContext context) { }

	internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext) { }

	internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo) { }

	internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo) { }

}

private sealed class JsonContract.<>c__DisplayClass73_0 // TypeDefIndex: 6012
{	public MethodInfo callbackMethodInfo; // 0x10


	public void .ctor() { }

	internal void <CreateSerializationCallback>b__0(object o, StreamingContext context) { }

}

private sealed class JsonContract.<>c__DisplayClass74_0 // TypeDefIndex: 6013
{	public MethodInfo callbackMethodInfo; // 0x10


	public void .ctor() { }

	internal void <CreateSerializationErrorCallback>b__0(object o, StreamingContext context, ErrorContext econtext) { }

}

public class JsonProperty // TypeDefIndex: 6015
{	internal Nullable<Required> _required; // 0x10
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


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal JsonContract get_PropertyContract() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal void set_PropertyContract(JsonContract value) { }

	public string get_PropertyName() { }

	public void set_PropertyName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Type get_DeclaringType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_DeclaringType(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Nullable<int> get_Order() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_Order(Nullable<int> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public string get_UnderlyingName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_UnderlyingName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public IValueProvider get_ValueProvider() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ValueProvider(IValueProvider value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_AttributeProvider(IAttributeProvider value) { }

	public Type get_PropertyType() { }

	public void set_PropertyType(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public JsonConverter get_Converter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_Converter(JsonConverter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public JsonConverter get_MemberConverter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_MemberConverter(JsonConverter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool get_Ignored() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_Ignored(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool get_Readable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_Readable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool get_Writable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_Writable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool get_HasMemberAttribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_HasMemberAttribute(bool value) { }

	public object get_DefaultValue() { }

	public void set_DefaultValue(object value) { }

	internal object GetResolvedDefaultValue() { }

	public Required get_Required() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Nullable<bool> get_IsReference() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_IsReference(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Nullable<NullValueHandling> get_NullValueHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_NullValueHandling(Nullable<NullValueHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Nullable<DefaultValueHandling> get_DefaultValueHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_DefaultValueHandling(Nullable<DefaultValueHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Nullable<ReferenceLoopHandling> get_ReferenceLoopHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Nullable<ObjectCreationHandling> get_ObjectCreationHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ObjectCreationHandling(Nullable<ObjectCreationHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Nullable<TypeNameHandling> get_TypeNameHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_TypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Predicate<object> get_ShouldSerialize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ShouldSerialize(Predicate<object> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Predicate<object> get_ShouldDeserialize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Predicate<object> get_GetIsSpecified() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_GetIsSpecified(Predicate<object> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Action<object, object> get_SetIsSpecified() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_SetIsSpecified(Action<object, object> value) { }

	public override string ToString() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public JsonConverter get_ItemConverter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ItemConverter(JsonConverter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Nullable<bool> get_ItemIsReference() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ItemIsReference(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	internal void WritePropertyName(JsonWriter writer) { }

	public void .ctor() { }

}

public class JsonPropertyCollection : KeyedCollection<string, JsonProperty> // TypeDefIndex: 6016
{	private readonly Type _type; // 0x38
	private readonly List<JsonProperty> _list; // 0x40


	public void .ctor(Type type) { }

	protected override string GetKeyForItem(JsonProperty item) { }

	public void AddProperty(JsonProperty property) { }

	public JsonProperty GetClosestMatchProperty(string propertyName) { }

	private bool TryGetValue(string key, out JsonProperty item) { }

	public JsonProperty GetProperty(string propertyName, StringComparison comparisonType) { }

}

public class JsonObjectContract : JsonContainerContract // TypeDefIndex: 6018
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public MemberSerialization get_MemberSerialization() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_MemberSerialization(MemberSerialization value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Nullable<Required> get_ItemRequired() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ItemRequired(Nullable<Required> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public JsonPropertyCollection get_Properties() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_Properties(JsonPropertyCollection value) { }

	public JsonPropertyCollection get_CreatorParameters() { }

	public void set_OverrideConstructor(ConstructorInfo value) { }

	public void set_ParametrizedConstructor(ConstructorInfo value) { }

	public ObjectConstructor<object> get_OverrideCreator() { }

	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public ExtensionDataSetter get_ExtensionDataSetter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ExtensionDataSetter(ExtensionDataSetter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public ExtensionDataGetter get_ExtensionDataGetter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ExtensionDataGetter(ExtensionDataGetter value) { }

	public void set_ExtensionDataValueType(Type value) { }

	internal bool get_HasRequiredOrDefaultValueProperties() { }

	public void .ctor(Type underlyingType) { }

	internal object GetUninitializedObject() { }

}

internal abstract class JsonSerializerInternalBase // TypeDefIndex: 6019
{	private ErrorContext _currentErrorContext; // 0x10
	private BidirectionalDictionary<string, object> _mappings; // 0x18
	internal readonly JsonSerializer Serializer; // 0x20
	internal readonly ITraceWriter TraceWriter; // 0x28
	protected JsonSerializerProxy InternalSerializer; // 0x30

	internal BidirectionalDictionary<string, object> DefaultReferenceMappings { get; }


	protected void .ctor(JsonSerializer serializer) { }

	internal BidirectionalDictionary<string, object> get_DefaultReferenceMappings() { }

	private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error) { }

	protected void ClearErrorContext() { }

	protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex) { }

}

private class JsonSerializerInternalBase.ReferenceEqualsEqualityComparer : IEqualityComparer<object> // TypeDefIndex: 6020
{
	private bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y) { }

	private int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj) { }

	public void .ctor() { }

}

internal class JsonSerializerInternalReader : JsonSerializerInternalBase // TypeDefIndex: 6021
{
	public void .ctor(JsonSerializer serializer) { }

	public void Populate(JsonReader reader, object target) { }

	private JsonContract GetContractSafe(Type type) { }

	public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent) { }

	private JsonSerializerProxy GetInternalSerializer() { }

	private JToken CreateJToken(JsonReader reader, JsonContract contract) { }

	private JToken CreateJObject(JsonReader reader) { }

	private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s) { }

	internal string GetExpectedDescription(JsonContract contract) { }

	private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	private bool ReadMetadataPropertiesToken(JTokenReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	private bool ReadMetadataProperties(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	private void ResolveTypeName(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName) { }

	private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract) { }

	private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id) { }

	private bool HasNoDefinedType(JsonContract contract) { }

	private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType) { }

	private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target) { }

	private bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue) { }

	private void AddReference(JsonReader reader, string id, object value) { }

	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	private bool ShouldSetPropertyValue(JsonProperty property, object value) { }

	private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator) { }

	private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator) { }

	private void OnDeserializing(JsonReader reader, JsonContract contract, object value) { }

	private void OnDeserialized(JsonReader reader, JsonContract contract, object value) { }

	private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id) { }

	private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message) { }

	private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id) { }

	internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member) { }

	private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, ObjectConstructor<object> creator, string id) { }

	private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue) { }

	private List<JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType) { }

	private bool ReadForType(JsonReader reader, JsonContract contract, bool hasConverter) { }

	public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, out bool createdFromNonDefaultCreator) { }

	private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id) { }

	private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target) { }

	private bool CheckPropertyName(JsonReader reader, string memberName) { }

	private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o) { }

	private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader) { }

	private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, JsonSerializerInternalReader.PropertyPresence presence, bool setDefaultValue) { }

	private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> requiredProperties) { }

	private void HandleError(JsonReader reader, bool readPastError, int initialDepth) { }

}

internal enum JsonSerializerInternalReader.PropertyPresence // TypeDefIndex: 6022
{	public int value__; // 0x0
	public const JsonSerializerInternalReader.PropertyPresence None = 0;
	public const JsonSerializerInternalReader.PropertyPresence Null = 1;
	public const JsonSerializerInternalReader.PropertyPresence Value = 2;

}

internal class JsonSerializerInternalReader.CreatorPropertyContext // TypeDefIndex: 6023
{	public string Name; // 0x10
	public JsonProperty Property; // 0x18
	public JsonProperty ConstructorProperty; // 0x20
	public Nullable<JsonSerializerInternalReader.PropertyPresence> Presence; // 0x28
	public object Value; // 0x30
	public bool Used; // 0x38


	public void .ctor() { }

}

private sealed class JsonSerializerInternalReader.<>c__DisplayClass36_0 // TypeDefIndex: 6024
{	public JsonProperty property; // 0x10


	public void .ctor() { }

	internal bool <CreateObjectUsingCreatorWithParameters>b__1(JsonSerializerInternalReader.CreatorPropertyContext p) { }

}

private sealed class JsonSerializerInternalReader.<>c // TypeDefIndex: 6025
{	public static readonly JsonSerializerInternalReader.<>c <>9; // 0x0
	public static Func<JsonProperty, string> <>9__36_0; // 0x8
	public static Func<JsonProperty, string> <>9__36_2; // 0x10
	public static Func<JsonProperty, JsonProperty> <>9__41_0; // 0x18
	public static Func<JsonProperty, JsonSerializerInternalReader.PropertyPresence> <>9__41_1; // 0x20


	private static void .cctor() { }

	public void .ctor() { }

	internal string <CreateObjectUsingCreatorWithParameters>b__36_0(JsonProperty p) { }

	internal string <CreateObjectUsingCreatorWithParameters>b__36_2(JsonProperty p) { }

	internal JsonProperty <PopulateObject>b__41_0(JsonProperty m) { }

	internal JsonSerializerInternalReader.PropertyPresence <PopulateObject>b__41_1(JsonProperty m) { }

}

internal class JsonSerializerInternalWriter : JsonSerializerInternalBase // TypeDefIndex: 6026
{	private Type _rootType; // 0x38
	private int _rootLevel; // 0x40
	private readonly List<object> _serializeStack; // 0x48


	public void .ctor(JsonSerializer serializer) { }

	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	private JsonSerializerProxy GetInternalSerializer() { }

	private JsonContract GetContractSafe(object value) { }

	private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	private Nullable<bool> ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private bool ShouldWriteProperty(object memberValue, JsonProperty property) { }

	private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	private void WriteReference(JsonWriter writer, object value) { }

	private string GetReference(JsonWriter writer, object value) { }

	internal static bool TryConvertToString(object value, Type type, out string s) { }

	private void SerializeString(JsonWriter writer, object value, JsonStringContract contract) { }

	private void OnSerializing(JsonWriter writer, JsonContract contract, object value) { }

	private void OnSerialized(JsonWriter writer, JsonContract contract, object value) { }

	private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, out JsonContract memberContract, out object memberValue) { }

	private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value) { }

	private void WriteTypeProperty(JsonWriter writer, Type type) { }

	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag) { }

	private bool HasFlag(TypeNameHandling value, TypeNameHandling flag) { }

	private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices) { }

	private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape) { }

	private void HandleError(JsonWriter writer, int initialDepth) { }

	private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target) { }

	private bool IsSpecified(JsonWriter writer, JsonProperty property, object target) { }

}

internal class JsonSerializerProxy : JsonSerializer // TypeDefIndex: 6027
{	private readonly JsonSerializerInternalReader _serializerReader; // 0xE0
	private readonly JsonSerializerInternalWriter _serializerWriter; // 0xE8
	private readonly JsonSerializer _serializer; // 0xF0

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


	public override void add_Error(EventHandler<ErrorEventArgs> value) { }

	public override void remove_Error(EventHandler<ErrorEventArgs> value) { }

	public override void set_ReferenceResolver(IReferenceResolver value) { }

	public override ITraceWriter get_TraceWriter() { }

	public override void set_TraceWriter(ITraceWriter value) { }

	public override void set_EqualityComparer(IEqualityComparer value) { }

	public override JsonConverterCollection get_Converters() { }

	public override void set_DefaultValueHandling(DefaultValueHandling value) { }

	public override IContractResolver get_ContractResolver() { }

	public override void set_ContractResolver(IContractResolver value) { }

	public override void set_MissingMemberHandling(MissingMemberHandling value) { }

	public override void set_NullValueHandling(NullValueHandling value) { }

	public override ObjectCreationHandling get_ObjectCreationHandling() { }

	public override void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	public override void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	public override void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	public override void set_TypeNameHandling(TypeNameHandling value) { }

	public override MetadataPropertyHandling get_MetadataPropertyHandling() { }

	public override void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	public override void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	public override void set_ConstructorHandling(ConstructorHandling value) { }

	public override void set_Binder(SerializationBinder value) { }

	public override StreamingContext get_Context() { }

	public override void set_Context(StreamingContext value) { }

	public override Formatting get_Formatting() { }

	public override void set_Formatting(Formatting value) { }

	public override bool get_CheckAdditionalContent() { }

	public override void set_CheckAdditionalContent(bool value) { }

	internal JsonSerializerInternalBase GetInternalSerializer() { }

	public void .ctor(JsonSerializerInternalReader serializerReader) { }

	public void .ctor(JsonSerializerInternalWriter serializerWriter) { }

	internal override object DeserializeInternal(JsonReader reader, Type objectType) { }

	internal override void PopulateInternal(JsonReader reader, object target) { }

	internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType) { }

}

public class JsonStringContract : JsonPrimitiveContract // TypeDefIndex: 6028
{
	public void .ctor(Type underlyingType) { }

}

internal static class JsonTypeReflector // TypeDefIndex: 6029
{	private static Nullable<bool> _fullyTrusted; // 0x0
	private static readonly ThreadSafeStore<Type, Func<object[], JsonConverter>> JsonConverterCreatorCache; // 0x8
	private static readonly ThreadSafeStore<Type, Type> AssociatedMetadataTypesCache; // 0x10
	private static ReflectionObject _metadataTypeAttributeReflectionObject; // 0x18

	public static bool FullyTrusted { get; }
	public static ReflectionDelegateFactory ReflectionDelegateFactory { get; }


	public static T GetCachedAttribute<T>(object attributeProvider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1240 Offset: 0x5CF840 VA: 0x1805D1240
	|-JsonTypeReflector.GetCachedAttribute<JsonContainerAttribute>
	|-JsonTypeReflector.GetCachedAttribute<JsonConverterAttribute>
	|-JsonTypeReflector.GetCachedAttribute<JsonObjectAttribute>
	|-JsonTypeReflector.GetCachedAttribute<object>
	|-JsonTypeReflector.GetCachedAttribute<SerializableAttribute>
	*/

	public static DataContractAttribute GetDataContractAttribute(Type type) { }

	public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo) { }

	public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute) { }

	public static JsonConverter GetJsonConverter(object attributeProvider) { }

	public static JsonConverter CreateJsonConverterInstance(Type converterType, object[] converterArgs) { }

	private static Func<object[], JsonConverter> GetJsonConverterCreator(Type converterType) { }

	public static TypeConverter GetTypeConverter(Type type) { }

	private static Type GetAssociatedMetadataType(Type type) { }

	private static Type GetAssociateMetadataTypeFromAttribute(Type type) { }

	private static T GetAttribute<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D10C0 Offset: 0x5CF6C0 VA: 0x1805D10C0
	|-JsonTypeReflector.GetAttribute<object>
	*/

	private static T GetAttribute<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0D60 Offset: 0x5CF360 VA: 0x1805D0D60
	|-JsonTypeReflector.GetAttribute<object>
	*/

	public static T GetAttribute<T>(object provider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D0FB0 Offset: 0x5CF5B0 VA: 0x1805D0FB0
	|-JsonTypeReflector.GetAttribute<JsonExtensionDataAttribute>
	|-JsonTypeReflector.GetAttribute<JsonIgnoreAttribute>
	|-JsonTypeReflector.GetAttribute<JsonPropertyAttribute>
	|-JsonTypeReflector.GetAttribute<JsonRequiredAttribute>
	|-JsonTypeReflector.GetAttribute<DefaultValueAttribute>
	|-JsonTypeReflector.GetAttribute<NonSerializedAttribute>
	|-JsonTypeReflector.GetAttribute<object>
	|-JsonTypeReflector.GetAttribute<DataMemberAttribute>
	*/

	public static bool get_FullyTrusted() { }

	public static ReflectionDelegateFactory get_ReflectionDelegateFactory() { }

	private static void .cctor() { }

}

private sealed class JsonTypeReflector.<>c__DisplayClass18_0 // TypeDefIndex: 6030
{	public Type converterType; // 0x10
	public Func<object> defaultConstructor; // 0x18


	public void .ctor() { }

	internal JsonConverter <GetJsonConverterCreator>b__0(object[] parameters) { }

}

private sealed class JsonTypeReflector.<>c // TypeDefIndex: 6031
{	public static readonly JsonTypeReflector.<>c <>9; // 0x0
	public static Func<object, Type> <>9__18_1; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal Type <GetJsonConverterCreator>b__18_1(object param) { }

}

public class JPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 6038
{	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	protected override int NameHashCode { get; }


	public void .ctor(string name) { }

	private static JObject CastInstance(object instance) { }

	public override object GetValue(object component) { }

	public override void SetValue(object component, object value) { }

	public override bool ShouldSerializeValue(object component) { }

	public override Type get_ComponentType() { }

	public override bool get_IsReadOnly() { }

	public override Type get_PropertyType() { }

	protected override int get_NameHashCode() { }

}

internal class JPropertyKeyedCollection : Collection<JToken> // TypeDefIndex: 6039
{	private static readonly IEqualityComparer<string> Comparer; // 0x0
	private Dictionary<string, JToken> _dictionary; // 0x20

	public ICollection<string> Keys { get; }


	public void .ctor() { }

	private void AddKey(string key, JToken item) { }

	protected override void ClearItems() { }

	public bool Contains(string key) { }

	private void EnsureDictionary() { }

	private string GetKeyForItem(JToken item) { }

	protected override void InsertItem(int index, JToken item) { }

	protected override void RemoveItem(int index) { }

	private void RemoveKey(string key) { }

	protected override void SetItem(int index, JToken item) { }

	public bool TryGetValue(string key, out JToken value) { }

	public ICollection<string> get_Keys() { }

	public int IndexOfReference(JToken t) { }

	public bool Compare(JPropertyKeyedCollection other) { }

	private static void .cctor() { }

}

public class JsonLoadSettings // TypeDefIndex: 6040
{	private CommentHandling _commentHandling; // 0x10
	private LineInfoHandling _lineInfoHandling; // 0x14

	public CommentHandling CommentHandling { get; }
	public LineInfoHandling LineInfoHandling { get; }


	public CommentHandling get_CommentHandling() { }

	public LineInfoHandling get_LineInfoHandling() { }

	public void .ctor() { }

}

public class JsonMergeSettings // TypeDefIndex: 6041
{
	public void .ctor() { }

}

public class JTokenEqualityComparer : IEqualityComparer<JToken> // TypeDefIndex: 6046
{
[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
public class JTokenEqualityComparer : IEqualityComparer<JToken> // TypeDefIndex: 6046

	public bool Equals(JToken x, JToken y) { }

	public int GetHashCode(JToken obj) { }

	public void .ctor() { }

}

public class JConstructor : JContainer // TypeDefIndex: 6056
{
[PreserveAttribute] // RVA: 0x71550 Offset: 0x70950 VA: 0x180071550
[DefaultMemberAttribute] // RVA: 0x71550 Offset: 0x70950 VA: 0x180071550
public class JConstructor : JContainer // TypeDefIndex: 6056
	private string _name; // 0x48
	private readonly List<JToken> _values; // 0x50

	protected override IList<JToken> ChildrenTokens { get; }
	public string Name { get; }
	public override JTokenType Type { get; }


	protected override IList<JToken> get_ChildrenTokens() { }

	internal override int IndexOfItem(JToken item) { }

	public string get_Name() { }

	public override JTokenType get_Type() { }

	public void .ctor() { }

	public void .ctor(JConstructor other) { }

	public void .ctor(string name) { }

	internal override bool DeepEquals(JToken node) { }

	internal override JToken CloneToken() { }

	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	internal override int GetDeepHashCode() { }

	public static JConstructor Load(JsonReader reader, JsonLoadSettings settings) { }

}

public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, IBindingList, IList, ICollection // TypeDefIndex: 6057
{	internal ListChangedEventHandler _listChanged; // 0x30
	private object _syncRoot; // 0x38
	private bool _busy; // 0x40

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


	protected abstract IList<JToken> get_ChildrenTokens();

	internal void .ctor() { }

	internal void .ctor(JContainer other) { }

	internal void CheckReentrancy() { }

	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	public override bool get_HasValues() { }

	internal bool ContentsEqual(JContainer container) { }

	public override JToken get_First() { }

	public override JToken get_Last() { }

	public override JEnumerable<JToken> Children() { }

	internal bool IsMultiContent(object content) { }

	internal JToken EnsureParentToken(JToken item, bool skipParentCheck) { }

	internal abstract int IndexOfItem(JToken item);

	internal virtual void InsertItem(int index, JToken item, bool skipParentCheck) { }

	internal virtual void RemoveItemAt(int index) { }

	internal virtual bool RemoveItem(JToken item) { }

	internal virtual JToken GetItem(int index) { }

	internal virtual void SetItem(int index, JToken item) { }

	internal virtual void ClearItems() { }

	internal virtual void ReplaceItem(JToken existing, JToken replacement) { }

	internal virtual bool ContainsItem(JToken item) { }

	internal virtual void CopyItemsTo(Array array, int arrayIndex) { }

	internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue) { }

	internal virtual void ValidateToken(JToken o, JToken existing) { }

	public virtual void Add(object content) { }

	internal void AddAndSkipParentCheck(JToken token) { }

	internal void AddInternal(int index, object content, bool skipParentCheck) { }

	internal static JToken CreateFromContent(object content) { }

	public void RemoveAll() { }

	internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options) { }

	internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings) { }

	internal int ContentsHashCode() { }

	private int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(JToken item) { }

	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, JToken item) { }

	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index) { }

	private JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(int index) { }

	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(int index, JToken value) { }

	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(JToken item) { }

	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear() { }

	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(JToken item) { }

	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(JToken[] array, int arrayIndex) { }

	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly() { }

	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(JToken item) { }

	private JToken EnsureValue(object value) { }

	private int System.Collections.IList.Add(object value) { }

	private void System.Collections.IList.Clear() { }

	private bool System.Collections.IList.Contains(object value) { }

	private int System.Collections.IList.IndexOf(object value) { }

	private void System.Collections.IList.Insert(int index, object value) { }

	private bool System.Collections.IList.get_IsFixedSize() { }

	private bool System.Collections.IList.get_IsReadOnly() { }

	private void System.Collections.IList.Remove(object value) { }

	private void System.Collections.IList.RemoveAt(int index) { }

	private object System.Collections.IList.get_Item(int index) { }

	private void System.Collections.IList.set_Item(int index, object value) { }

	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	public int get_Count() { }

	private object System.Collections.ICollection.get_SyncRoot() { }

}

public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, ICustomTypeDescriptor, INotifyPropertyChanging // TypeDefIndex: 6060
{	private readonly JPropertyKeyedCollection _properties; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PropertyChangedEventHandler PropertyChanged; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PropertyChangingEventHandler PropertyChanging; // 0x58

	protected override IList<JToken> ChildrenTokens { get; }
	public override JTokenType Type { get; }
	public JToken Item { get; set; }
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Keys { get; }
	private ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Values { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.IsReadOnly { get; }


	protected override IList<JToken> get_ChildrenTokens() { }

	public void .ctor() { }

	public void .ctor(JObject other) { }

	internal override bool DeepEquals(JToken node) { }

	internal override int IndexOfItem(JToken item) { }

	internal override void InsertItem(int index, JToken item, bool skipParentCheck) { }

	internal override void ValidateToken(JToken o, JToken existing) { }

	internal void InternalPropertyChanged(JProperty childProperty) { }

	internal void InternalPropertyChanging(JProperty childProperty) { }

	internal override JToken CloneToken() { }

	public override JTokenType get_Type() { }

	public JProperty Property(string name) { }

	public JToken get_Item(string propertyName) { }

	public void set_Item(string propertyName, JToken value) { }

	public static JObject Load(JsonReader reader) { }

	public static JObject Load(JsonReader reader, JsonLoadSettings settings) { }

	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	public void Add(string propertyName, JToken value) { }

	private bool System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.ContainsKey(string key) { }

	private ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys() { }

	public bool Remove(string propertyName) { }

	public bool TryGetValue(string propertyName, out JToken value) { }

	private ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values() { }

	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(KeyValuePair<string, JToken> item) { }

	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear() { }

	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(KeyValuePair<string, JToken> item) { }

	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex) { }

	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly() { }

	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(KeyValuePair<string, JToken> item) { }

	internal override int GetDeepHashCode() { }

	public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator() { }

	protected virtual void OnPropertyChanged(string propertyName) { }

	protected virtual void OnPropertyChanging(string propertyName) { }

	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

private sealed class JObject.<>c // TypeDefIndex: 6061
{	public static readonly JObject.<>c <>9; // 0x3370


	private static void .cctor() { }

	public void .ctor() { }

}

private sealed class JObject.<GetEnumerator>d__58 : IEnumerator<KeyValuePair<string, JToken>>, IDisposable, IEnumerator // TypeDefIndex: 6062
{	private int <>1__state; // 0x10
	private KeyValuePair<string, JToken> <>2__current; // 0x18
	public JObject <>4__this; // 0x28
	private IEnumerator<JToken> <>7__wrap1; // 0x30

	private KeyValuePair<string, JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private KeyValuePair<string, JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }

}

public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable // TypeDefIndex: 6063
{	private readonly List<JToken> _values; // 0x48

	protected override IList<JToken> ChildrenTokens { get; }
	public override JTokenType Type { get; }
	public JToken Item { get; set; }
	public bool IsReadOnly { get; }


	protected override IList<JToken> get_ChildrenTokens() { }

	public override JTokenType get_Type() { }

	public void .ctor() { }

	public void .ctor(JArray other) { }

	public void .ctor(object content) { }

	internal override bool DeepEquals(JToken node) { }

	internal override JToken CloneToken() { }

	public static JArray Load(JsonReader reader) { }

	public static JArray Load(JsonReader reader, JsonLoadSettings settings) { }

	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	public JToken get_Item(int index) { }

	public void set_Item(int index, JToken value) { }

	internal override int IndexOfItem(JToken item) { }

	public int IndexOf(JToken item) { }

	public void Insert(int index, JToken item) { }

	public void RemoveAt(int index) { }

	public IEnumerator<JToken> GetEnumerator() { }

	public void Add(JToken item) { }

	public void Clear() { }

	public bool Contains(JToken item) { }

	public void CopyTo(JToken[] array, int arrayIndex) { }

	public bool get_IsReadOnly() { }

	public bool Remove(JToken item) { }

	internal override int GetDeepHashCode() { }

}

public class JTokenReader : JsonReader, IJsonLineInfo // TypeDefIndex: 6064
{	private readonly JToken _root; // 0x78
	private string _initialPath; // 0x80
	private JToken _parent; // 0x88
	private JToken _current; // 0x90

	public JToken CurrentToken { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }
	public override string Path { get; }


	public JToken get_CurrentToken() { }

	public void .ctor(JToken token) { }

	public override bool Read() { }

	private bool ReadOver(JToken t) { }

	private bool ReadToEnd() { }

	private Nullable<JsonToken> GetEndToken(JContainer c) { }

	private bool ReadInto(JContainer c) { }

	private bool SetEnd(JContainer c) { }

	private void SetToken(JToken token) { }

	private string SafeToString(object value) { }

	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	public override string get_Path() { }

}

public class JTokenWriter : JsonWriter // TypeDefIndex: 6065
{	private JContainer _token; // 0x60
	private JContainer _parent; // 0x68
	private JValue _value; // 0x70
	private JToken _current; // 0x78

	public JToken Token { get; }


	public JToken get_Token() { }

	public void .ctor() { }

	public override void Close() { }

	public override void WriteStartObject() { }

	private void AddParent(JContainer container) { }

	private void RemoveParent() { }

	public override void WriteStartArray() { }

	public override void WriteStartConstructor(string name) { }

	protected override void WriteEnd(JsonToken token) { }

	public override void WritePropertyName(string name) { }

	private void AddValue(object value, JsonToken token) { }

	internal void AddValue(JValue value, JsonToken token) { }

	public override void WriteValue(object value) { }

	public override void WriteNull() { }

	public override void WriteUndefined() { }

	public override void WriteRaw(string json) { }

	public override void WriteComment(string text) { }

	public override void WriteValue(string value) { }

	public override void WriteValue(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public override void WriteValue(uint value) { }

	public override void WriteValue(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public override void WriteValue(ulong value) { }

	public override void WriteValue(float value) { }

	public override void WriteValue(double value) { }

	public override void WriteValue(bool value) { }

	public override void WriteValue(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public override void WriteValue(ushort value) { }

	public override void WriteValue(char value) { }

	public override void WriteValue(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public override void WriteValue(sbyte value) { }

	public override void WriteValue(Decimal value) { }

	public override void WriteValue(DateTime value) { }

	public override void WriteValue(DateTimeOffset value) { }

	public override void WriteValue(byte[] value) { }

	public override void WriteValue(TimeSpan value) { }

	public override void WriteValue(Guid value) { }

	public override void WriteValue(Uri value) { }

	internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

}

public abstract class JToken : IJEnumerable<JToken>, IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable // TypeDefIndex: 6066
{	private JContainer _parent; // 0x10
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


	[DebuggerStepThroughAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public JContainer get_Parent() { }

	internal void set_Parent(JContainer value) { }

	public JToken get_Root() { }

	internal abstract JToken CloneToken();

	internal abstract bool DeepEquals(JToken node);

	public abstract JTokenType get_Type();

	public abstract bool get_HasValues();

	public static bool DeepEquals(JToken t1, JToken t2) { }

	public JToken get_Next() { }

	internal void set_Next(JToken value) { }

	public JToken get_Previous() { }

	internal void set_Previous(JToken value) { }

	public string get_Path() { }

	internal void .ctor() { }

	public virtual JToken get_First() { }

	public virtual JToken get_Last() { }

	public virtual JEnumerable<JToken> Children() { }

	public void Remove() { }

	public void Replace(JToken value) { }

	public abstract void WriteTo(JsonWriter writer, JsonConverter[] converters);

	public override string ToString() { }

	public string ToString(Formatting formatting, JsonConverter[] converters) { }

	private static JValue EnsureValue(JToken value) { }

	private static string GetType(JToken token) { }

	private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable) { }

	public static bool op_Explicit(JToken value) { }

	public static DateTimeOffset op_Explicit(JToken value) { }

	public static Nullable<bool> op_Explicit(JToken value) { }

	public static long op_Explicit(JToken value) { }

	public static Nullable<DateTime> op_Explicit(JToken value) { }

	public static Nullable<DateTimeOffset> op_Explicit(JToken value) { }

	public static Nullable<Decimal> op_Explicit(JToken value) { }

	public static Nullable<double> op_Explicit(JToken value) { }

	public static Nullable<char> op_Explicit(JToken value) { }

	public static int op_Explicit(JToken value) { }

	public static short op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public static ushort op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public static char op_Explicit(JToken value) { }

	public static byte op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public static sbyte op_Explicit(JToken value) { }

	public static Nullable<int> op_Explicit(JToken value) { }

	public static Nullable<short> op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public static Nullable<ushort> op_Explicit(JToken value) { }

	public static Nullable<byte> op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public static Nullable<sbyte> op_Explicit(JToken value) { }

	public static DateTime op_Explicit(JToken value) { }

	public static Nullable<long> op_Explicit(JToken value) { }

	public static Nullable<float> op_Explicit(JToken value) { }

	public static Decimal op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public static Nullable<uint> op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public static Nullable<ulong> op_Explicit(JToken value) { }

	public static double op_Explicit(JToken value) { }

	public static float op_Explicit(JToken value) { }

	public static string op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public static uint op_Explicit(JToken value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public static ulong op_Explicit(JToken value) { }

	public static Guid op_Explicit(JToken value) { }

	public static Nullable<Guid> op_Explicit(JToken value) { }

	public static TimeSpan op_Explicit(JToken value) { }

	public static Nullable<TimeSpan> op_Explicit(JToken value) { }

	public static Uri op_Explicit(JToken value) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	internal abstract int GetDeepHashCode();

	public JsonReader CreateReader() { }

	public T ToObject<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CFB00 Offset: 0x5CE100 VA: 0x1805CFB00
	|-JToken.ToObject<UITwitchTrophy.TrophyPage>
	|-JToken.ToObject<object>
	*/

	public object ToObject(Type objectType) { }

	public object ToObject(Type objectType, JsonSerializer jsonSerializer) { }

	public static JToken ReadFrom(JsonReader reader) { }

	public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings) { }

	public static JToken Parse(string json) { }

	public static JToken Parse(string json, JsonLoadSettings settings) { }

	public static JToken Load(JsonReader reader, JsonLoadSettings settings) { }

	internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings) { }

	internal void SetLineInfo(int lineNumber, int linePosition) { }

	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	private object System.ICloneable.Clone() { }

	public JToken DeepClone() { }

	public void AddAnnotation(object annotation) { }

	public T Annotation<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CF960 Offset: 0x5CDF60 VA: 0x1805CF960
	|-JToken.Annotation<JToken.LineInfoAnnotation>
	|-JToken.Annotation<object>
	*/

	private static void .cctor() { }

}

private class JToken.LineInfoAnnotation // TypeDefIndex: 6067
{	internal readonly int LineNumber; // 0x10
	internal readonly int LinePosition; // 0x14


	public void .ctor(int lineNumber, int linePosition) { }

}

public class JProperty : JContainer // TypeDefIndex: 6073
{
[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
private sealed class JToken.<AfterSelf>d__42 // TypeDefIndex: 6069

[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
private sealed class JToken.<BeforeSelf>d__43 // TypeDefIndex: 6070

[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
private sealed class JToken.<Annotations>d__171<T> // TypeDefIndex: 6071

[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
private sealed class JToken.<Annotations>d__172 // TypeDefIndex: 6072

[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
public class JProperty : JContainer // TypeDefIndex: 6073
	private readonly JProperty.JPropertyList _content; // 0x48
	private readonly string _name; // 0x50

	protected override IList<JToken> ChildrenTokens { get; }
	public string Name { get; }
	public JToken Value { get; set; }
	public override JTokenType Type { get; }


	protected override IList<JToken> get_ChildrenTokens() { }

	[DebuggerStepThroughAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public string get_Name() { }

	[DebuggerStepThroughAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public JToken get_Value() { }

	public void set_Value(JToken value) { }

	public void .ctor(JProperty other) { }

	internal override JToken GetItem(int index) { }

	internal override void SetItem(int index, JToken item) { }

	internal override bool RemoveItem(JToken item) { }

	internal override void RemoveItemAt(int index) { }

	internal override int IndexOfItem(JToken item) { }

	internal override void InsertItem(int index, JToken item, bool skipParentCheck) { }

	internal override bool ContainsItem(JToken item) { }

	internal override void ClearItems() { }

	internal override bool DeepEquals(JToken node) { }

	internal override JToken CloneToken() { }

	[DebuggerStepThroughAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public override JTokenType get_Type() { }

	internal void .ctor(string name) { }

	public void .ctor(string name, object content) { }

	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	internal override int GetDeepHashCode() { }

	public static JProperty Load(JsonReader reader, JsonLoadSettings settings) { }

}

private class JProperty.JPropertyList : IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable // TypeDefIndex: 6074
{	internal JToken _token; // 0x10

	public int Count { get; }
	public bool IsReadOnly { get; }
	public JToken Item { get; set; }


	public IEnumerator<JToken> GetEnumerator() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public void Add(JToken item) { }

	public void Clear() { }

	public bool Contains(JToken item) { }

	public void CopyTo(JToken[] array, int arrayIndex) { }

	public bool Remove(JToken item) { }

	public int get_Count() { }

	public bool get_IsReadOnly() { }

	public int IndexOf(JToken item) { }

	public void Insert(int index, JToken item) { }

	public void RemoveAt(int index) { }

	public JToken get_Item(int index) { }

	public void set_Item(int index, JToken value) { }

	public void .ctor() { }

}

private sealed class JProperty.JPropertyList.<GetEnumerator>d__1 : IEnumerator<JToken>, IDisposable, IEnumerator // TypeDefIndex: 6075
{	private int <>1__state; // 0x10
	private JToken <>2__current; // 0x18
	public JProperty.JPropertyList <>4__this; // 0x20

	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }

}

public enum JTokenType // TypeDefIndex: 6076
{	public int value__; // 0x0
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
{	private JTokenType _valueType; // 0x30
	private object _value; // 0x38

	public override bool HasValues { get; }
	public override JTokenType Type { get; }
	public object Value { get; }


	internal void .ctor(object value, JTokenType type) { }

	public void .ctor(JValue other) { }

	public void .ctor(object value) { }

	internal override bool DeepEquals(JToken node) { }

	public override bool get_HasValues() { }

	internal static int Compare(JTokenType valueType, object objA, object objB) { }

	private static int CompareFloat(object objA, object objB) { }

	internal override JToken CloneToken() { }

	public static JValue CreateComment(string value) { }

	public static JValue CreateNull() { }

	public static JValue CreateUndefined() { }

	private static JTokenType GetValueType(Nullable<JTokenType> current, object value) { }

	private static JTokenType GetStringValueType(Nullable<JTokenType> current) { }

	public override JTokenType get_Type() { }

	public object get_Value() { }

	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	internal override int GetDeepHashCode() { }

	private static bool ValuesEquals(JValue v1, JValue v2) { }

	public bool Equals(JValue other) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	public string ToString(IFormatProvider formatProvider) { }

	public string ToString(string format, IFormatProvider formatProvider) { }

	private int System.IComparable.CompareTo(object obj) { }

	private TypeCode System.IConvertible.GetTypeCode() { }

	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	private object System.IConvertible.ToType(Type conversionType, IFormatProvider provider) { }

}

public static class JSON // TypeDefIndex: 11582
{	private static readonly Type includeAttrType; // 0x0
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


	public static Variant Load(string json) { }

	public static string Dump(object data) { }

	public static string Dump(object data, EncodeOptions options) { }

	public static void MakeInto<T>(Variant data, out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CEBD0 Offset: 0x5CD1D0 VA: 0x1805CEBD0
	|-JSON.MakeInto<object>
	*/

	private static Type FindType(string fullName) { }

	[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static T DecodeType<T>(Variant data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDA7D0 Offset: 0xBD8DD0 VA: 0x180BDA7D0
	|-JSON.DecodeType<bool>
	|
	|-RVA: 0xBDC7B0 Offset: 0xBDADB0 VA: 0x180BDC7B0
	|-JSON.DecodeType<Decimal>
	|
	|-RVA: 0xBDE770 Offset: 0xBDCD70 VA: 0x180BDE770
	|-JSON.DecodeType<double>
	|
	|-RVA: 0x15A8840 Offset: 0x15A6E40 VA: 0x1815A8840
	|-JSON.DecodeType<short>
	|
	|-RVA: 0x15AA810 Offset: 0x15A8E10 VA: 0x1815AA810
	|-JSON.DecodeType<int>
	|
	|-RVA: 0x15AC7B0 Offset: 0x15AADB0 VA: 0x1815AC7B0
	|-JSON.DecodeType<long>
	|
	|-RVA: 0x15AE780 Offset: 0x15ACD80 VA: 0x1815AE780
	|-JSON.DecodeType<object>
	|
	|-RVA: 0x15B06A0 Offset: 0x15AECA0 VA: 0x1815B06A0
	|-JSON.DecodeType<float>
	|
	|-RVA: 0x15B2640 Offset: 0x15B0C40 VA: 0x1815B2640
	|-JSON.DecodeType<ushort>
	|
	|-RVA: 0x15B4610 Offset: 0x15B2C10 VA: 0x1815B4610
	|-JSON.DecodeType<uint>
	|
	|-RVA: 0x15B65B0 Offset: 0x15B4BB0 VA: 0x1815B65B0
	|-JSON.DecodeType<ulong>
	*/

	[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static List<T> DecodeList<T>(Variant data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12ADFB0 Offset: 0x12AC5B0 VA: 0x1812ADFB0
	|-JSON.DecodeList<bool>
	|
	|-RVA: 0x12AE1A0 Offset: 0x12AC7A0 VA: 0x1812AE1A0
	|-JSON.DecodeList<Decimal>
	|
	|-RVA: 0x12AE3A0 Offset: 0x12AC9A0 VA: 0x1812AE3A0
	|-JSON.DecodeList<double>
	|
	|-RVA: 0x12AE590 Offset: 0x12ACB90 VA: 0x1812AE590
	|-JSON.DecodeList<short>
	|
	|-RVA: 0x12AE780 Offset: 0x12ACD80 VA: 0x1812AE780
	|-JSON.DecodeList<int>
	|
	|-RVA: 0x12AE970 Offset: 0x12ACF70 VA: 0x1812AE970
	|-JSON.DecodeList<long>
	|
	|-RVA: 0x12AEB60 Offset: 0x12AD160 VA: 0x1812AEB60
	|-JSON.DecodeList<object>
	|
	|-RVA: 0x12AED50 Offset: 0x12AD350 VA: 0x1812AED50
	|-JSON.DecodeList<float>
	|
	|-RVA: 0x12AEF40 Offset: 0x12AD540 VA: 0x1812AEF40
	|-JSON.DecodeList<ushort>
	|
	|-RVA: 0x12AF130 Offset: 0x12AD730 VA: 0x1812AF130
	|-JSON.DecodeList<uint>
	|
	|-RVA: 0x12AF320 Offset: 0x12AD920 VA: 0x1812AF320
	|-JSON.DecodeList<ulong>
	*/

	[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Dictionary<TKey, TValue> DecodeDictionary<TKey, TValue>(Variant data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15382B0 Offset: 0x15368B0 VA: 0x1815382B0
	|-JSON.DecodeDictionary<bool, bool>
	|
	|-RVA: 0x1538640 Offset: 0x1536C40 VA: 0x181538640
	|-JSON.DecodeDictionary<bool, Decimal>
	|
	|-RVA: 0x15389D0 Offset: 0x1536FD0 VA: 0x1815389D0
	|-JSON.DecodeDictionary<bool, double>
	|
	|-RVA: 0x1538D60 Offset: 0x1537360 VA: 0x181538D60
	|-JSON.DecodeDictionary<bool, short>
	|
	|-RVA: 0x15390F0 Offset: 0x15376F0 VA: 0x1815390F0
	|-JSON.DecodeDictionary<bool, int>
	|
	|-RVA: 0x1539480 Offset: 0x1537A80 VA: 0x181539480
	|-JSON.DecodeDictionary<bool, long>
	|
	|-RVA: 0x1539810 Offset: 0x1537E10 VA: 0x181539810
	|-JSON.DecodeDictionary<bool, object>
	|
	|-RVA: 0x1539BA0 Offset: 0x15381A0 VA: 0x181539BA0
	|-JSON.DecodeDictionary<bool, float>
	|
	|-RVA: 0x1539F30 Offset: 0x1538530 VA: 0x181539F30
	|-JSON.DecodeDictionary<bool, ushort>
	|
	|-RVA: 0x153A2C0 Offset: 0x15388C0 VA: 0x18153A2C0
	|-JSON.DecodeDictionary<bool, uint>
	|
	|-RVA: 0x153A650 Offset: 0x1538C50 VA: 0x18153A650
	|-JSON.DecodeDictionary<bool, ulong>
	|
	|-RVA: 0x153A9E0 Offset: 0x1538FE0 VA: 0x18153A9E0
	|-JSON.DecodeDictionary<Decimal, bool>
	|
	|-RVA: 0x153AD70 Offset: 0x1539370 VA: 0x18153AD70
	|-JSON.DecodeDictionary<Decimal, Decimal>
	|
	|-RVA: 0x153B110 Offset: 0x1539710 VA: 0x18153B110
	|-JSON.DecodeDictionary<Decimal, double>
	|
	|-RVA: 0x153B4A0 Offset: 0x1539AA0 VA: 0x18153B4A0
	|-JSON.DecodeDictionary<Decimal, short>
	|
	|-RVA: 0x153B830 Offset: 0x1539E30 VA: 0x18153B830
	|-JSON.DecodeDictionary<Decimal, int>
	|
	|-RVA: 0x153BBC0 Offset: 0x153A1C0 VA: 0x18153BBC0
	|-JSON.DecodeDictionary<Decimal, long>
	|
	|-RVA: 0x153BF50 Offset: 0x153A550 VA: 0x18153BF50
	|-JSON.DecodeDictionary<Decimal, object>
	|
	|-RVA: 0x153C2E0 Offset: 0x153A8E0 VA: 0x18153C2E0
	|-JSON.DecodeDictionary<Decimal, float>
	|
	|-RVA: 0x153C670 Offset: 0x153AC70 VA: 0x18153C670
	|-JSON.DecodeDictionary<Decimal, ushort>
	|
	|-RVA: 0x153CA00 Offset: 0x153B000 VA: 0x18153CA00
	|-JSON.DecodeDictionary<Decimal, uint>
	|
	|-RVA: 0x153CD90 Offset: 0x153B390 VA: 0x18153CD90
	|-JSON.DecodeDictionary<Decimal, ulong>
	|
	|-RVA: 0x153D120 Offset: 0x153B720 VA: 0x18153D120
	|-JSON.DecodeDictionary<double, bool>
	|
	|-RVA: 0x153D4B0 Offset: 0x153BAB0 VA: 0x18153D4B0
	|-JSON.DecodeDictionary<double, Decimal>
	|
	|-RVA: 0x153D850 Offset: 0x153BE50 VA: 0x18153D850
	|-JSON.DecodeDictionary<double, double>
	|
	|-RVA: 0x153DBE0 Offset: 0x153C1E0 VA: 0x18153DBE0
	|-JSON.DecodeDictionary<double, short>
	|
	|-RVA: 0x153DF70 Offset: 0x153C570 VA: 0x18153DF70
	|-JSON.DecodeDictionary<double, int>
	|
	|-RVA: 0x153E300 Offset: 0x153C900 VA: 0x18153E300
	|-JSON.DecodeDictionary<double, long>
	|
	|-RVA: 0x153E690 Offset: 0x153CC90 VA: 0x18153E690
	|-JSON.DecodeDictionary<double, object>
	|
	|-RVA: 0x153EA20 Offset: 0x153D020 VA: 0x18153EA20
	|-JSON.DecodeDictionary<double, float>
	|
	|-RVA: 0x153EDB0 Offset: 0x153D3B0 VA: 0x18153EDB0
	|-JSON.DecodeDictionary<double, ushort>
	|
	|-RVA: 0x153F140 Offset: 0x153D740 VA: 0x18153F140
	|-JSON.DecodeDictionary<double, uint>
	|
	|-RVA: 0x153F4D0 Offset: 0x153DAD0 VA: 0x18153F4D0
	|-JSON.DecodeDictionary<double, ulong>
	|
	|-RVA: 0x153F860 Offset: 0x153DE60 VA: 0x18153F860
	|-JSON.DecodeDictionary<short, bool>
	|
	|-RVA: 0x153FBF0 Offset: 0x153E1F0 VA: 0x18153FBF0
	|-JSON.DecodeDictionary<short, Decimal>
	|
	|-RVA: 0x153FF80 Offset: 0x153E580 VA: 0x18153FF80
	|-JSON.DecodeDictionary<short, double>
	|
	|-RVA: 0x1540310 Offset: 0x153E910 VA: 0x181540310
	|-JSON.DecodeDictionary<short, short>
	|
	|-RVA: 0x15406A0 Offset: 0x153ECA0 VA: 0x1815406A0
	|-JSON.DecodeDictionary<short, int>
	|
	|-RVA: 0x1540A30 Offset: 0x153F030 VA: 0x181540A30
	|-JSON.DecodeDictionary<short, long>
	|
	|-RVA: 0x1540DC0 Offset: 0x153F3C0 VA: 0x181540DC0
	|-JSON.DecodeDictionary<short, object>
	|
	|-RVA: 0x1541150 Offset: 0x153F750 VA: 0x181541150
	|-JSON.DecodeDictionary<short, float>
	|
	|-RVA: 0x15414E0 Offset: 0x153FAE0 VA: 0x1815414E0
	|-JSON.DecodeDictionary<short, ushort>
	|
	|-RVA: 0x1541870 Offset: 0x153FE70 VA: 0x181541870
	|-JSON.DecodeDictionary<short, uint>
	|
	|-RVA: 0x1541C00 Offset: 0x1540200 VA: 0x181541C00
	|-JSON.DecodeDictionary<short, ulong>
	|
	|-RVA: 0x1541F90 Offset: 0x1540590 VA: 0x181541F90
	|-JSON.DecodeDictionary<int, bool>
	|
	|-RVA: 0x1542320 Offset: 0x1540920 VA: 0x181542320
	|-JSON.DecodeDictionary<int, Decimal>
	|
	|-RVA: 0x15426B0 Offset: 0x1540CB0 VA: 0x1815426B0
	|-JSON.DecodeDictionary<int, double>
	|
	|-RVA: 0x1542A40 Offset: 0x1541040 VA: 0x181542A40
	|-JSON.DecodeDictionary<int, short>
	|
	|-RVA: 0x1542DD0 Offset: 0x15413D0 VA: 0x181542DD0
	|-JSON.DecodeDictionary<int, int>
	|
	|-RVA: 0x1543160 Offset: 0x1541760 VA: 0x181543160
	|-JSON.DecodeDictionary<int, long>
	|
	|-RVA: 0x15434F0 Offset: 0x1541AF0 VA: 0x1815434F0
	|-JSON.DecodeDictionary<int, object>
	|
	|-RVA: 0x1543880 Offset: 0x1541E80 VA: 0x181543880
	|-JSON.DecodeDictionary<int, float>
	|
	|-RVA: 0x1543C10 Offset: 0x1542210 VA: 0x181543C10
	|-JSON.DecodeDictionary<int, ushort>
	|
	|-RVA: 0x1543FA0 Offset: 0x15425A0 VA: 0x181543FA0
	|-JSON.DecodeDictionary<int, uint>
	|
	|-RVA: 0x1544330 Offset: 0x1542930 VA: 0x181544330
	|-JSON.DecodeDictionary<int, ulong>
	|
	|-RVA: 0x15446C0 Offset: 0x1542CC0 VA: 0x1815446C0
	|-JSON.DecodeDictionary<long, bool>
	|
	|-RVA: 0x1544A50 Offset: 0x1543050 VA: 0x181544A50
	|-JSON.DecodeDictionary<long, Decimal>
	|
	|-RVA: 0x1544DE0 Offset: 0x15433E0 VA: 0x181544DE0
	|-JSON.DecodeDictionary<long, double>
	|
	|-RVA: 0x1545170 Offset: 0x1543770 VA: 0x181545170
	|-JSON.DecodeDictionary<long, short>
	|
	|-RVA: 0x1545500 Offset: 0x1543B00 VA: 0x181545500
	|-JSON.DecodeDictionary<long, int>
	|
	|-RVA: 0x1545890 Offset: 0x1543E90 VA: 0x181545890
	|-JSON.DecodeDictionary<long, long>
	|
	|-RVA: 0x1545C20 Offset: 0x1544220 VA: 0x181545C20
	|-JSON.DecodeDictionary<long, object>
	|
	|-RVA: 0x1545FB0 Offset: 0x15445B0 VA: 0x181545FB0
	|-JSON.DecodeDictionary<long, float>
	|
	|-RVA: 0x1546340 Offset: 0x1544940 VA: 0x181546340
	|-JSON.DecodeDictionary<long, ushort>
	|
	|-RVA: 0x15466D0 Offset: 0x1544CD0 VA: 0x1815466D0
	|-JSON.DecodeDictionary<long, uint>
	|
	|-RVA: 0x1546A60 Offset: 0x1545060 VA: 0x181546A60
	|-JSON.DecodeDictionary<long, ulong>
	|
	|-RVA: 0x1546DF0 Offset: 0x15453F0 VA: 0x181546DF0
	|-JSON.DecodeDictionary<object, bool>
	|
	|-RVA: 0x1547190 Offset: 0x1545790 VA: 0x181547190
	|-JSON.DecodeDictionary<object, Decimal>
	|
	|-RVA: 0x1547530 Offset: 0x1545B30 VA: 0x181547530
	|-JSON.DecodeDictionary<object, double>
	|
	|-RVA: 0x15478D0 Offset: 0x1545ED0 VA: 0x1815478D0
	|-JSON.DecodeDictionary<object, short>
	|
	|-RVA: 0x1547C70 Offset: 0x1546270 VA: 0x181547C70
	|-JSON.DecodeDictionary<object, int>
	|
	|-RVA: 0x1548010 Offset: 0x1546610 VA: 0x181548010
	|-JSON.DecodeDictionary<object, long>
	|
	|-RVA: 0x15483B0 Offset: 0x15469B0 VA: 0x1815483B0
	|-JSON.DecodeDictionary<object, object>
	|
	|-RVA: 0x1548750 Offset: 0x1546D50 VA: 0x181548750
	|-JSON.DecodeDictionary<object, float>
	|
	|-RVA: 0x1548AF0 Offset: 0x15470F0 VA: 0x181548AF0
	|-JSON.DecodeDictionary<object, ushort>
	|
	|-RVA: 0x1548E90 Offset: 0x1547490 VA: 0x181548E90
	|-JSON.DecodeDictionary<object, uint>
	|
	|-RVA: 0x1549230 Offset: 0x1547830 VA: 0x181549230
	|-JSON.DecodeDictionary<object, ulong>
	|
	|-RVA: 0x15495D0 Offset: 0x1547BD0 VA: 0x1815495D0
	|-JSON.DecodeDictionary<float, bool>
	|
	|-RVA: 0x1549960 Offset: 0x1547F60 VA: 0x181549960
	|-JSON.DecodeDictionary<float, Decimal>
	|
	|-RVA: 0x1549D00 Offset: 0x1548300 VA: 0x181549D00
	|-JSON.DecodeDictionary<float, double>
	|
	|-RVA: 0x154A090 Offset: 0x1548690 VA: 0x18154A090
	|-JSON.DecodeDictionary<float, short>
	|
	|-RVA: 0x154A420 Offset: 0x1548A20 VA: 0x18154A420
	|-JSON.DecodeDictionary<float, int>
	|
	|-RVA: 0x154A7B0 Offset: 0x1548DB0 VA: 0x18154A7B0
	|-JSON.DecodeDictionary<float, long>
	|
	|-RVA: 0x154AB40 Offset: 0x1549140 VA: 0x18154AB40
	|-JSON.DecodeDictionary<float, object>
	|
	|-RVA: 0x154AED0 Offset: 0x15494D0 VA: 0x18154AED0
	|-JSON.DecodeDictionary<float, float>
	|
	|-RVA: 0x154B260 Offset: 0x1549860 VA: 0x18154B260
	|-JSON.DecodeDictionary<float, ushort>
	|
	|-RVA: 0x154B5F0 Offset: 0x1549BF0 VA: 0x18154B5F0
	|-JSON.DecodeDictionary<float, uint>
	|
	|-RVA: 0x154B980 Offset: 0x1549F80 VA: 0x18154B980
	|-JSON.DecodeDictionary<float, ulong>
	|
	|-RVA: 0x154BD10 Offset: 0x154A310 VA: 0x18154BD10
	|-JSON.DecodeDictionary<ushort, bool>
	|
	|-RVA: 0x154C0A0 Offset: 0x154A6A0 VA: 0x18154C0A0
	|-JSON.DecodeDictionary<ushort, Decimal>
	|
	|-RVA: 0x154C430 Offset: 0x154AA30 VA: 0x18154C430
	|-JSON.DecodeDictionary<ushort, double>
	|
	|-RVA: 0x154C7C0 Offset: 0x154ADC0 VA: 0x18154C7C0
	|-JSON.DecodeDictionary<ushort, short>
	|
	|-RVA: 0x154CB50 Offset: 0x154B150 VA: 0x18154CB50
	|-JSON.DecodeDictionary<ushort, int>
	|
	|-RVA: 0x154CEE0 Offset: 0x154B4E0 VA: 0x18154CEE0
	|-JSON.DecodeDictionary<ushort, long>
	|
	|-RVA: 0x154D270 Offset: 0x154B870 VA: 0x18154D270
	|-JSON.DecodeDictionary<ushort, object>
	|
	|-RVA: 0x154D600 Offset: 0x154BC00 VA: 0x18154D600
	|-JSON.DecodeDictionary<ushort, float>
	|
	|-RVA: 0x154D990 Offset: 0x154BF90 VA: 0x18154D990
	|-JSON.DecodeDictionary<ushort, ushort>
	|
	|-RVA: 0x154DD20 Offset: 0x154C320 VA: 0x18154DD20
	|-JSON.DecodeDictionary<ushort, uint>
	|
	|-RVA: 0x154E0B0 Offset: 0x154C6B0 VA: 0x18154E0B0
	|-JSON.DecodeDictionary<ushort, ulong>
	|
	|-RVA: 0x154E440 Offset: 0x154CA40 VA: 0x18154E440
	|-JSON.DecodeDictionary<uint, bool>
	|
	|-RVA: 0x154E7D0 Offset: 0x154CDD0 VA: 0x18154E7D0
	|-JSON.DecodeDictionary<uint, Decimal>
	|
	|-RVA: 0x154EB60 Offset: 0x154D160 VA: 0x18154EB60
	|-JSON.DecodeDictionary<uint, double>
	|
	|-RVA: 0x154EEF0 Offset: 0x154D4F0 VA: 0x18154EEF0
	|-JSON.DecodeDictionary<uint, short>
	|
	|-RVA: 0x154F280 Offset: 0x154D880 VA: 0x18154F280
	|-JSON.DecodeDictionary<uint, int>
	|
	|-RVA: 0x154F610 Offset: 0x154DC10 VA: 0x18154F610
	|-JSON.DecodeDictionary<uint, long>
	|
	|-RVA: 0xD001D0 Offset: 0xCFE7D0 VA: 0x180D001D0
	|-JSON.DecodeDictionary<uint, object>
	|
	|-RVA: 0xD00560 Offset: 0xCFEB60 VA: 0x180D00560
	|-JSON.DecodeDictionary<uint, float>
	|
	|-RVA: 0xD008F0 Offset: 0xCFEEF0 VA: 0x180D008F0
	|-JSON.DecodeDictionary<uint, ushort>
	|
	|-RVA: 0xD00C80 Offset: 0xCFF280 VA: 0x180D00C80
	|-JSON.DecodeDictionary<uint, uint>
	|
	|-RVA: 0xD01010 Offset: 0xCFF610 VA: 0x180D01010
	|-JSON.DecodeDictionary<uint, ulong>
	|
	|-RVA: 0xD013A0 Offset: 0xCFF9A0 VA: 0x180D013A0
	|-JSON.DecodeDictionary<ulong, bool>
	|
	|-RVA: 0xD01730 Offset: 0xCFFD30 VA: 0x180D01730
	|-JSON.DecodeDictionary<ulong, Decimal>
	|
	|-RVA: 0xD01AC0 Offset: 0xD000C0 VA: 0x180D01AC0
	|-JSON.DecodeDictionary<ulong, double>
	|
	|-RVA: 0xD01E50 Offset: 0xD00450 VA: 0x180D01E50
	|-JSON.DecodeDictionary<ulong, short>
	|
	|-RVA: 0xD021E0 Offset: 0xD007E0 VA: 0x180D021E0
	|-JSON.DecodeDictionary<ulong, int>
	|
	|-RVA: 0xD02570 Offset: 0xD00B70 VA: 0x180D02570
	|-JSON.DecodeDictionary<ulong, long>
	|
	|-RVA: 0xD02900 Offset: 0xD00F00 VA: 0x180D02900
	|-JSON.DecodeDictionary<ulong, object>
	|
	|-RVA: 0xD02C90 Offset: 0xD01290 VA: 0x180D02C90
	|-JSON.DecodeDictionary<ulong, float>
	|
	|-RVA: 0xD03020 Offset: 0xD01620 VA: 0x180D03020
	|-JSON.DecodeDictionary<ulong, ushort>
	|
	|-RVA: 0xD033B0 Offset: 0xD019B0 VA: 0x180D033B0
	|-JSON.DecodeDictionary<ulong, uint>
	|
	|-RVA: 0xD03740 Offset: 0xD01D40 VA: 0x180D03740
	|-JSON.DecodeDictionary<ulong, ulong>
	*/

	[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static T[] DecodeArray<T>(Variant data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A39750 Offset: 0x1A37D50 VA: 0x181A39750
	|-JSON.DecodeArray<bool>
	|
	|-RVA: 0x1A39970 Offset: 0x1A37F70 VA: 0x181A39970
	|-JSON.DecodeArray<Decimal>
	|
	|-RVA: 0x1A39BB0 Offset: 0x1A381B0 VA: 0x181A39BB0
	|-JSON.DecodeArray<double>
	|
	|-RVA: 0x1A39DE0 Offset: 0x1A383E0 VA: 0x181A39DE0
	|-JSON.DecodeArray<short>
	|
	|-RVA: 0x1A3A000 Offset: 0x1A38600 VA: 0x181A3A000
	|-JSON.DecodeArray<int>
	|
	|-RVA: 0x1A3A220 Offset: 0x1A38820 VA: 0x181A3A220
	|-JSON.DecodeArray<long>
	|
	|-RVA: 0x1A3A440 Offset: 0x1A38A40 VA: 0x181A3A440
	|-JSON.DecodeArray<object>
	|
	|-RVA: 0x1A3A650 Offset: 0x1A38C50 VA: 0x181A3A650
	|-JSON.DecodeArray<float>
	|
	|-RVA: 0x1A3A880 Offset: 0x1A38E80 VA: 0x181A3A880
	|-JSON.DecodeArray<ushort>
	|
	|-RVA: 0x1A3AAA0 Offset: 0x1A390A0 VA: 0x181A3AAA0
	|-JSON.DecodeArray<uint>
	|
	|-RVA: 0x1A3ACC0 Offset: 0x1A392C0 VA: 0x181A3ACC0
	|-JSON.DecodeArray<ulong>
	*/

	[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void DecodeMultiRankArray<T>(ProxyArray arrayData, Array array, int arrayRank, int[] indices) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CEA20 Offset: 0x5CD020 VA: 0x1805CEA20
	|-JSON.DecodeMultiRankArray<object>
	*/

	[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void SupportTypeForAOT<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CEC50 Offset: 0x5CD250 VA: 0x1805CEC50
	|-JSON.SupportTypeForAOT<bool>
	|
	|-RVA: 0x5CED80 Offset: 0x5CD380 VA: 0x1805CED80
	|-JSON.SupportTypeForAOT<Decimal>
	|
	|-RVA: 0x5CEEB0 Offset: 0x5CD4B0 VA: 0x1805CEEB0
	|-JSON.SupportTypeForAOT<double>
	|
	|-RVA: 0x5CEFE0 Offset: 0x5CD5E0 VA: 0x1805CEFE0
	|-JSON.SupportTypeForAOT<short>
	|
	|-RVA: 0x5CF110 Offset: 0x5CD710 VA: 0x1805CF110
	|-JSON.SupportTypeForAOT<int>
	|
	|-RVA: 0x5CF240 Offset: 0x5CD840 VA: 0x1805CF240
	|-JSON.SupportTypeForAOT<long>
	|
	|-RVA: 0x5CF370 Offset: 0x5CD970 VA: 0x1805CF370
	|-JSON.SupportTypeForAOT<object>
	|-JSON.SupportTypeForAOT<string>
	|
	|-RVA: 0x5CF4A0 Offset: 0x5CDAA0 VA: 0x1805CF4A0
	|-JSON.SupportTypeForAOT<float>
	|
	|-RVA: 0x5CF5D0 Offset: 0x5CDBD0 VA: 0x1805CF5D0
	|-JSON.SupportTypeForAOT<ushort>
	|
	|-RVA: 0x5CF700 Offset: 0x5CDD00 VA: 0x1805CF700
	|-JSON.SupportTypeForAOT<uint>
	|
	|-RVA: 0x5CF830 Offset: 0x5CDE30 VA: 0x1805CF830
	|-JSON.SupportTypeForAOT<ulong>
	*/

	[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void SupportValueTypesForAOT() { }

	private static void .cctor() { }

}

