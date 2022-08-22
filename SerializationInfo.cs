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
	// RVA: 0x12AA550 Offset: 0x12A8B50 VA: 0x1812AA550
	public void .ctor(Type type, IFormatterConverter converter) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x12AA570 Offset: 0x12A8B70 VA: 0x1812AA570
	public void .ctor(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public string get_FullTypeName() { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public string get_AssemblyName() { }

	// RVA: 0x12AA1F0 Offset: 0x12A87F0 VA: 0x1812AA1F0
	public void SetType(Type type) { }

	// RVA: 0x12A90B0 Offset: 0x12A76B0 VA: 0x1812A90B0
	private static bool Compare(byte[] a, byte[] b) { }

	// RVA: 0x12A9140 Offset: 0x12A7740 VA: 0x1812A9140
	internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x12AA060 Offset: 0x12A8660 VA: 0x1812AA060
	internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0xA39490 Offset: 0xA37A90 VA: 0x180A39490
	public int get_MemberCount() { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public Type get_ObjectType() { }

	// RVA: 0x5925C0 Offset: 0x590BC0 VA: 0x1805925C0
	public bool get_IsFullTypeNameSetExplicit() { }

	// RVA: 0xAF6470 Offset: 0xAF4A70 VA: 0x180AF6470
	public bool get_IsAssemblyNameSetExplicit() { }

	// RVA: 0x12A9760 Offset: 0x12A7D60 VA: 0x1812A9760
	public SerializationInfoEnumerator GetEnumerator() { }

	// RVA: 0x12A9150 Offset: 0x12A7750 VA: 0x1812A9150
	private void ExpandArrays() { }

	// RVA: 0x12A8E90 Offset: 0x12A7490 VA: 0x1812A8E90
	public void AddValue(string name, object value, Type type) { }

	// RVA: 0x12A8B60 Offset: 0x12A7160 VA: 0x1812A8B60
	public void AddValue(string name, object value) { }

	// RVA: 0x12A83E0 Offset: 0x12A69E0 VA: 0x1812A83E0
	public void AddValue(string name, bool value) { }

	// RVA: 0x12A8F70 Offset: 0x12A7570 VA: 0x1812A8F70
	public void AddValue(string name, char value) { }

	// RVA: 0x12A8520 Offset: 0x12A6B20 VA: 0x1812A8520
	public void AddValue(string name, byte value) { }

	// RVA: 0x12A8660 Offset: 0x12A6C60 VA: 0x1812A8660
	public void AddValue(string name, short value) { }

	// RVA: 0x12A87A0 Offset: 0x12A6DA0 VA: 0x1812A87A0
	public void AddValue(string name, int value) { }

	// RVA: 0x12A8D50 Offset: 0x12A7350 VA: 0x1812A8D50
	public void AddValue(string name, long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x12A88E0 Offset: 0x12A6EE0 VA: 0x1812A88E0
	public void AddValue(string name, ulong value) { }

	// RVA: 0x12A8290 Offset: 0x12A6890 VA: 0x1812A8290
	public void AddValue(string name, float value) { }

	// RVA: 0x12A8A20 Offset: 0x12A7020 VA: 0x1812A8A20
	public void AddValue(string name, DateTime value) { }

	// RVA: 0x12A7F70 Offset: 0x12A6570 VA: 0x1812A7F70
	internal void AddValueInternal(string name, object value, Type type) { }

	// RVA: 0x12AA390 Offset: 0x12A8990 VA: 0x1812AA390
	internal void UpdateValue(string name, object value, Type type) { }

	// RVA: 0x12A9260 Offset: 0x12A7860 VA: 0x1812A9260
	private int FindElement(string name) { }

	// RVA: 0x12A95A0 Offset: 0x12A7BA0 VA: 0x1812A95A0
	private object GetElement(string name, out Type foundType) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x12A9460 Offset: 0x12A7A60 VA: 0x1812A9460
	private object GetElementNoThrow(string name, out Type foundType) { }

	// RVA: 0x12A9ED0 Offset: 0x12A84D0 VA: 0x1812A9ED0
	public object GetValue(string name, Type type) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x12A9D10 Offset: 0x12A8310 VA: 0x1812A9D10
	internal object GetValueNoThrow(string name, Type type) { }

	// RVA: 0x12A9310 Offset: 0x12A7910 VA: 0x1812A9310
	public bool GetBoolean(string name) { }

	// RVA: 0x12A9820 Offset: 0x12A7E20 VA: 0x1812A9820
	public int GetInt32(string name) { }

	// RVA: 0x12A9910 Offset: 0x12A7F10 VA: 0x1812A9910
	public long GetInt64(string name) { }

	// RVA: 0x12A9A60 Offset: 0x12A8060 VA: 0x1812A9A60
	public float GetSingle(string name) { }

	// RVA: 0x12A9BC0 Offset: 0x12A81C0 VA: 0x1812A9BC0
	public string GetString(string name) { }

}

