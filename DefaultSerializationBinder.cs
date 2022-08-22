public class DefaultSerializationBinder : SerializationBinder // TypeDefIndex: 6000
{	// Fields
	internal static readonly DefaultSerializationBinder Instance; // 0x0
	private readonly ThreadSafeStore<DefaultSerializationBinder.TypeNameKey, Type> _typeCache; // 0x10

	// Methods

	// RVA: 0x13EE980 Offset: 0x13ECF80 VA: 0x1813EE980
	private static Type GetTypeFromTypeNameKey(DefaultSerializationBinder.TypeNameKey typeNameKey) { }

	// RVA: 0x13EE8E0 Offset: 0x13ECEE0 VA: 0x1813EE8E0 Slot: 5
	public override Type BindToType(string assemblyName, string typeName) { }

	// RVA: 0x13EECD0 Offset: 0x13ED2D0 VA: 0x1813EECD0
	public void .ctor() { }

	// RVA: 0x13EEBF0 Offset: 0x13ED1F0 VA: 0x1813EEBF0
	private static void .cctor() { }

}

internal struct DefaultSerializationBinder.TypeNameKey // TypeDefIndex: 6001
{	// Fields
	internal readonly string AssemblyName; // 0x0
	internal readonly string TypeName; // 0x8

	// Methods

	// RVA: 0xF5DB0 Offset: 0xF51B0 VA: 0x1800F5DB0
	public void .ctor(string assemblyName, string typeName) { }

	// RVA: 0x1EF7A0 Offset: 0x1EEBA0 VA: 0x1801EF7A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EF6F0 Offset: 0x1EEAF0 VA: 0x1801EF6F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF5CF0 Offset: 0xF50F0 VA: 0x1800F5CF0
	public bool Equals(DefaultSerializationBinder.TypeNameKey other) { }

}

