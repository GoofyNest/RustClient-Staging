public class DefaultSerializationBinder : SerializationBinder // TypeDefIndex: 6000
{	// Fields
	internal static readonly DefaultSerializationBinder Instance; // 0x0
	private readonly ThreadSafeStore<DefaultSerializationBinder.TypeNameKey, Type> _typeCache; // 0x10

	// Methods

	// RVA: 0x13EF5C0 Offset: 0x13EDBC0 VA: 0x1813EF5C0
	private static Type GetTypeFromTypeNameKey(DefaultSerializationBinder.TypeNameKey typeNameKey) { }

	// RVA: 0x13EF520 Offset: 0x13EDB20 VA: 0x1813EF520 Slot: 5
	public override Type BindToType(string assemblyName, string typeName) { }

	// RVA: 0x13EF910 Offset: 0x13EDF10 VA: 0x1813EF910
	public void .ctor() { }

	// RVA: 0x13EF830 Offset: 0x13EDE30 VA: 0x1813EF830
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

