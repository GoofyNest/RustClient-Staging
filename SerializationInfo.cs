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
	// RVA: 0x12A9BF0 Offset: 0x12A81F0 VA: 0x1812A9BF0
	public void .ctor(Type type, IFormatterConverter converter) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x12A9C10 Offset: 0x12A8210 VA: 0x1812A9C10
	public void .ctor(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public string get_FullTypeName() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public string get_AssemblyName() { }

	// RVA: 0x12A9890 Offset: 0x12A7E90 VA: 0x1812A9890
	public void SetType(Type type) { }

	// RVA: 0x12A8750 Offset: 0x12A6D50 VA: 0x1812A8750
	private static bool Compare(byte[] a, byte[] b) { }

	// RVA: 0x12A87E0 Offset: 0x12A6DE0 VA: 0x1812A87E0
	internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x12A9700 Offset: 0x12A7D00 VA: 0x1812A9700
	internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0xA38CE0 Offset: 0xA372E0 VA: 0x180A38CE0
	public int get_MemberCount() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public Type get_ObjectType() { }

	// RVA: 0x592630 Offset: 0x590C30 VA: 0x180592630
	public bool get_IsFullTypeNameSetExplicit() { }

	// RVA: 0xAF5CE0 Offset: 0xAF42E0 VA: 0x180AF5CE0
	public bool get_IsAssemblyNameSetExplicit() { }

	// RVA: 0x12A8E00 Offset: 0x12A7400 VA: 0x1812A8E00
	public SerializationInfoEnumerator GetEnumerator() { }

	// RVA: 0x12A87F0 Offset: 0x12A6DF0 VA: 0x1812A87F0
	private void ExpandArrays() { }

	// RVA: 0x12A8530 Offset: 0x12A6B30 VA: 0x1812A8530
	public void AddValue(string name, object value, Type type) { }

	// RVA: 0x12A8200 Offset: 0x12A6800 VA: 0x1812A8200
	public void AddValue(string name, object value) { }

	// RVA: 0x12A7A80 Offset: 0x12A6080 VA: 0x1812A7A80
	public void AddValue(string name, bool value) { }

	// RVA: 0x12A8610 Offset: 0x12A6C10 VA: 0x1812A8610
	public void AddValue(string name, char value) { }

	// RVA: 0x12A7BC0 Offset: 0x12A61C0 VA: 0x1812A7BC0
	public void AddValue(string name, byte value) { }

	// RVA: 0x12A7D00 Offset: 0x12A6300 VA: 0x1812A7D00
	public void AddValue(string name, short value) { }

	// RVA: 0x12A7E40 Offset: 0x12A6440 VA: 0x1812A7E40
	public void AddValue(string name, int value) { }

	// RVA: 0x12A83F0 Offset: 0x12A69F0 VA: 0x1812A83F0
	public void AddValue(string name, long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x12A7F80 Offset: 0x12A6580 VA: 0x1812A7F80
	public void AddValue(string name, ulong value) { }

	// RVA: 0x12A7930 Offset: 0x12A5F30 VA: 0x1812A7930
	public void AddValue(string name, float value) { }

	// RVA: 0x12A80C0 Offset: 0x12A66C0 VA: 0x1812A80C0
	public void AddValue(string name, DateTime value) { }

	// RVA: 0x12A7610 Offset: 0x12A5C10 VA: 0x1812A7610
	internal void AddValueInternal(string name, object value, Type type) { }

	// RVA: 0x12A9A30 Offset: 0x12A8030 VA: 0x1812A9A30
	internal void UpdateValue(string name, object value, Type type) { }

	// RVA: 0x12A8900 Offset: 0x12A6F00 VA: 0x1812A8900
	private int FindElement(string name) { }

	// RVA: 0x12A8C40 Offset: 0x12A7240 VA: 0x1812A8C40
	private object GetElement(string name, out Type foundType) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x12A8B00 Offset: 0x12A7100 VA: 0x1812A8B00
	private object GetElementNoThrow(string name, out Type foundType) { }

	// RVA: 0x12A9570 Offset: 0x12A7B70 VA: 0x1812A9570
	public object GetValue(string name, Type type) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x12A93B0 Offset: 0x12A79B0 VA: 0x1812A93B0
	internal object GetValueNoThrow(string name, Type type) { }

	// RVA: 0x12A89B0 Offset: 0x12A6FB0 VA: 0x1812A89B0
	public bool GetBoolean(string name) { }

	// RVA: 0x12A8EC0 Offset: 0x12A74C0 VA: 0x1812A8EC0
	public int GetInt32(string name) { }

	// RVA: 0x12A8FB0 Offset: 0x12A75B0 VA: 0x1812A8FB0
	public long GetInt64(string name) { }

	// RVA: 0x12A9100 Offset: 0x12A7700 VA: 0x1812A9100
	public float GetSingle(string name) { }

	// RVA: 0x12A9260 Offset: 0x12A7860 VA: 0x1812A9260
	public string GetString(string name) { }

}

