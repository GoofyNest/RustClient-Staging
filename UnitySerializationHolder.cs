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

	// RVA: 0x2146C80 Offset: 0x2145280 VA: 0x182146C80
	internal static void GetUnitySerializationInfo(SerializationInfo info, Missing missing) { }

	// RVA: 0x2145FC0 Offset: 0x21445C0 VA: 0x182145FC0
	internal static RuntimeType AddElementTypes(SerializationInfo info, RuntimeType type) { }

	// RVA: 0x2146F40 Offset: 0x2145540 VA: 0x182146F40
	internal Type MakeElementTypes(Type type) { }

	// RVA: 0x2146900 Offset: 0x2144F00 VA: 0x182146900
	internal static void GetUnitySerializationInfo(SerializationInfo info, RuntimeType type) { }

	// RVA: 0x2146D60 Offset: 0x2145360 VA: 0x182146D60
	internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType, string data, RuntimeAssembly assembly) { }

	// RVA: 0x2147100 Offset: 0x2145700 VA: 0x182147100
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2147060 Offset: 0x2145660 VA: 0x182147060
	private void ThrowInsufficientInformation(string field) { }

	// RVA: 0x2146250 Offset: 0x2144850 VA: 0x182146250 Slot: 6
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x21462C0 Offset: 0x21448C0 VA: 0x1821462C0 Slot: 7
	public virtual object GetRealObject(StreamingContext context) { }

}

