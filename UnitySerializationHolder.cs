internal class UnitySerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 332
{	// Fields
	private Type[] m_instantiation; // 0x10
	private int[] m_elementTypes; // 0x18
	private int m_genericParameterPosition; // 0x20
	private Type m_declaringType; // 0x28
	private MethodBase m_declaringMethod; // 0x30
	private string m_data; // 0x38
	private string m_assemblyName; // 0x40
	private int m_unityType; // 0x48

	// Methods

	// RVA: 0x2146E40 Offset: 0x2145440 VA: 0x182146E40
	internal static void GetUnitySerializationInfo(SerializationInfo info, Missing missing) { }

	// RVA: 0x2146180 Offset: 0x2144780 VA: 0x182146180
	internal static RuntimeType AddElementTypes(SerializationInfo info, RuntimeType type) { }

	// RVA: 0x2147100 Offset: 0x2145700 VA: 0x182147100
	internal Type MakeElementTypes(Type type) { }

	// RVA: 0x2146AC0 Offset: 0x21450C0 VA: 0x182146AC0
	internal static void GetUnitySerializationInfo(SerializationInfo info, RuntimeType type) { }

	// RVA: 0x2146F20 Offset: 0x2145520 VA: 0x182146F20
	internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType, string data, RuntimeAssembly assembly) { }

	// RVA: 0x21472C0 Offset: 0x21458C0 VA: 0x1821472C0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2147220 Offset: 0x2145820 VA: 0x182147220
	private void ThrowInsufficientInformation(string field) { }

	// RVA: 0x2146410 Offset: 0x2144A10 VA: 0x182146410 Slot: 6
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2146480 Offset: 0x2144A80 VA: 0x182146480 Slot: 7
	public virtual object GetRealObject(StreamingContext context) { }

}

