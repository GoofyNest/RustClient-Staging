public abstract class SerializationBinder // TypeDefIndex: 1053
{	// Methods

	// RVA: 0x12A5E40 Offset: 0x12A4440 VA: 0x1812A5E40 Slot: 4
	public virtual void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Type BindToType(string assemblyName, string typeName);

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

