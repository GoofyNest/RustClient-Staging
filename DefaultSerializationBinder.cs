public class DefaultSerializationBinder : SerializationBinder // TypeDefIndex: 6000
{	// Fields
	internal static readonly DefaultSerializationBinder Instance; // 0x0
	private readonly ThreadSafeStore<DefaultSerializationBinder.TypeNameKey, Type> _typeCache; // 0x10

	// Methods

	// RVA: 0x13EF880 Offset: 0x13EDE80 VA: 0x1813EF880
	private static Type GetTypeFromTypeNameKey(DefaultSerializationBinder.TypeNameKey typeNameKey) { }

	// RVA: 0x13EF7E0 Offset: 0x13EDDE0 VA: 0x1813EF7E0 Slot: 5
	public override Type BindToType(string assemblyName, string typeName) { }

	// RVA: 0x13EFBD0 Offset: 0x13EE1D0 VA: 0x1813EFBD0
	public void .ctor() { }

	// RVA: 0x13EFAF0 Offset: 0x13EE0F0 VA: 0x1813EFAF0
	private static void .cctor() { }

}

internal struct DefaultSerializationBinder.TypeNameKey // TypeDefIndex: 6001
{	// Fields
	internal readonly string AssemblyName; // 0x0
	internal readonly string TypeName; // 0x8

	// Methods

	// RVA: 0xF5A50 Offset: 0xF4E50 VA: 0x1800F5A50
	public void .ctor(string assemblyName, string typeName) { }

	// RVA: 0x1EF380 Offset: 0x1EE780 VA: 0x1801EF380 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EF2D0 Offset: 0x1EE6D0 VA: 0x1801EF2D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF5990 Offset: 0xF4D90 VA: 0x1800F5990
	public bool Equals(DefaultSerializationBinder.TypeNameKey other) { }

}

