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

	// RVA: 0x2147760 Offset: 0x2145D60 VA: 0x182147760
	internal static void GetUnitySerializationInfo(SerializationInfo info, Missing missing) { }

	// RVA: 0x2146AA0 Offset: 0x21450A0 VA: 0x182146AA0
	internal static RuntimeType AddElementTypes(SerializationInfo info, RuntimeType type) { }

	// RVA: 0x2147A20 Offset: 0x2146020 VA: 0x182147A20
	internal Type MakeElementTypes(Type type) { }

	// RVA: 0x21473E0 Offset: 0x21459E0 VA: 0x1821473E0
	internal static void GetUnitySerializationInfo(SerializationInfo info, RuntimeType type) { }

	// RVA: 0x2147840 Offset: 0x2145E40 VA: 0x182147840
	internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType, string data, RuntimeAssembly assembly) { }

	// RVA: 0x2147BE0 Offset: 0x21461E0 VA: 0x182147BE0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2147B40 Offset: 0x2146140 VA: 0x182147B40
	private void ThrowInsufficientInformation(string field) { }

	// RVA: 0x2146D30 Offset: 0x2145330 VA: 0x182146D30 Slot: 6
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2146DA0 Offset: 0x21453A0 VA: 0x182146DA0 Slot: 7
	public virtual object GetRealObject(StreamingContext context) { }

}

