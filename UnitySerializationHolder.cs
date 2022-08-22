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

	// RVA: 0x2146F40 Offset: 0x2145540 VA: 0x182146F40
	internal static void GetUnitySerializationInfo(SerializationInfo info, Missing missing) { }

	// RVA: 0x2146280 Offset: 0x2144880 VA: 0x182146280
	internal static RuntimeType AddElementTypes(SerializationInfo info, RuntimeType type) { }

	// RVA: 0x2147200 Offset: 0x2145800 VA: 0x182147200
	internal Type MakeElementTypes(Type type) { }

	// RVA: 0x2146BC0 Offset: 0x21451C0 VA: 0x182146BC0
	internal static void GetUnitySerializationInfo(SerializationInfo info, RuntimeType type) { }

	// RVA: 0x2147020 Offset: 0x2145620 VA: 0x182147020
	internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType, string data, RuntimeAssembly assembly) { }

	// RVA: 0x21473C0 Offset: 0x21459C0 VA: 0x1821473C0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2147320 Offset: 0x2145920 VA: 0x182147320
	private void ThrowInsufficientInformation(string field) { }

	// RVA: 0x2146510 Offset: 0x2144B10 VA: 0x182146510 Slot: 6
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2146580 Offset: 0x2144B80 VA: 0x182146580 Slot: 7
	public virtual object GetRealObject(StreamingContext context) { }

}

