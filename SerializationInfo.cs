public sealed class SerializationInfo // TypeDefIndex: 1058
{	// Fields
	private const int defaultSize = 4;
	private const string s_mscorlibAssemblySimpleName = "mscorlib";
	private const string s_mscorlibFileName = "mscorlib.dll";
	internal string[] m_members; // 0x10
	internal object[] m_data; // 0x18
	internal Type[] m_types; // 0x20
	private Dictionary<string, int> m_nameToIndex; // 0x28
	internal int m_currMember; // 0x30
	internal IFormatterConverter m_converter; // 0x38
	private string m_fullTypeName; // 0x40
	private string m_assemName; // 0x48
	private Type objectType; // 0x50
	private bool isFullTypeNameSetExplicit; // 0x58
	private bool isAssemblyNameSetExplicit; // 0x59
	private bool requireSameTokenInPartialTrust; // 0x5A

	// Properties
	public string FullTypeName { get; }
	public string AssemblyName { get; }
	public int MemberCount { get; }
	public Type ObjectType { get; }
	public bool IsFullTypeNameSetExplicit { get; }
	public bool IsAssemblyNameSetExplicit { get; }

	// Methods

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x12A9EB0 Offset: 0x12A84B0 VA: 0x1812A9EB0
	public void .ctor(Type type, IFormatterConverter converter) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x12A9ED0 Offset: 0x12A84D0 VA: 0x1812A9ED0
	public void .ctor(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public string get_FullTypeName() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public string get_AssemblyName() { }

	// RVA: 0x12A9B50 Offset: 0x12A8150 VA: 0x1812A9B50
	public void SetType(Type type) { }

	// RVA: 0x12A8A10 Offset: 0x12A7010 VA: 0x1812A8A10
	private static bool Compare(byte[] a, byte[] b) { }

	// RVA: 0x12A8AA0 Offset: 0x12A70A0 VA: 0x1812A8AA0
	internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x12A99C0 Offset: 0x12A7FC0 VA: 0x1812A99C0
	internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0xA38FA0 Offset: 0xA375A0 VA: 0x180A38FA0
	public int get_MemberCount() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public Type get_ObjectType() { }

	// RVA: 0x592630 Offset: 0x590C30 VA: 0x180592630
	public bool get_IsFullTypeNameSetExplicit() { }

	// RVA: 0xAF5FA0 Offset: 0xAF45A0 VA: 0x180AF5FA0
	public bool get_IsAssemblyNameSetExplicit() { }

	// RVA: 0x12A90C0 Offset: 0x12A76C0 VA: 0x1812A90C0
	public SerializationInfoEnumerator GetEnumerator() { }

	// RVA: 0x12A8AB0 Offset: 0x12A70B0 VA: 0x1812A8AB0
	private void ExpandArrays() { }

	// RVA: 0x12A87F0 Offset: 0x12A6DF0 VA: 0x1812A87F0
	public void AddValue(string name, object value, Type type) { }

	// RVA: 0x12A84C0 Offset: 0x12A6AC0 VA: 0x1812A84C0
	public void AddValue(string name, object value) { }

	// RVA: 0x12A7D40 Offset: 0x12A6340 VA: 0x1812A7D40
	public void AddValue(string name, bool value) { }

	// RVA: 0x12A88D0 Offset: 0x12A6ED0 VA: 0x1812A88D0
	public void AddValue(string name, char value) { }

	// RVA: 0x12A7E80 Offset: 0x12A6480 VA: 0x1812A7E80
	public void AddValue(string name, byte value) { }

	// RVA: 0x12A7FC0 Offset: 0x12A65C0 VA: 0x1812A7FC0
	public void AddValue(string name, short value) { }

	// RVA: 0x12A8100 Offset: 0x12A6700 VA: 0x1812A8100
	public void AddValue(string name, int value) { }

	// RVA: 0x12A86B0 Offset: 0x12A6CB0 VA: 0x1812A86B0
	public void AddValue(string name, long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x12A8240 Offset: 0x12A6840 VA: 0x1812A8240
	public void AddValue(string name, ulong value) { }

	// RVA: 0x12A7BF0 Offset: 0x12A61F0 VA: 0x1812A7BF0
	public void AddValue(string name, float value) { }

	// RVA: 0x12A8380 Offset: 0x12A6980 VA: 0x1812A8380
	public void AddValue(string name, DateTime value) { }

	// RVA: 0x12A78D0 Offset: 0x12A5ED0 VA: 0x1812A78D0
	internal void AddValueInternal(string name, object value, Type type) { }

	// RVA: 0x12A9CF0 Offset: 0x12A82F0 VA: 0x1812A9CF0
	internal void UpdateValue(string name, object value, Type type) { }

	// RVA: 0x12A8BC0 Offset: 0x12A71C0 VA: 0x1812A8BC0
	private int FindElement(string name) { }

	// RVA: 0x12A8F00 Offset: 0x12A7500 VA: 0x1812A8F00
	private object GetElement(string name, out Type foundType) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x12A8DC0 Offset: 0x12A73C0 VA: 0x1812A8DC0
	private object GetElementNoThrow(string name, out Type foundType) { }

	// RVA: 0x12A9830 Offset: 0x12A7E30 VA: 0x1812A9830
	public object GetValue(string name, Type type) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x12A9670 Offset: 0x12A7C70 VA: 0x1812A9670
	internal object GetValueNoThrow(string name, Type type) { }

	// RVA: 0x12A8C70 Offset: 0x12A7270 VA: 0x1812A8C70
	public bool GetBoolean(string name) { }

	// RVA: 0x12A9180 Offset: 0x12A7780 VA: 0x1812A9180
	public int GetInt32(string name) { }

	// RVA: 0x12A9270 Offset: 0x12A7870 VA: 0x1812A9270
	public long GetInt64(string name) { }

	// RVA: 0x12A93C0 Offset: 0x12A79C0 VA: 0x1812A93C0
	public float GetSingle(string name) { }

	// RVA: 0x12A9520 Offset: 0x12A7B20 VA: 0x1812A9520
	public string GetString(string name) { }

}

