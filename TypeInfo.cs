public abstract class TypeInfo : Type, IReflectableType // TypeDefIndex: 554
{	// Properties
	public virtual IEnumerable<FieldInfo> DeclaredFields { get; }

	// Methods

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFF6A50 Offset: 0xFF5050 VA: 0x180FF6A50
	internal void .ctor() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 120
	private TypeInfo System.Reflection.IReflectableType.GetTypeInfo() { }

	// RVA: 0xFF6AB0 Offset: 0xFF50B0 VA: 0x180FF6AB0 Slot: 121
	public virtual IEnumerable<FieldInfo> get_DeclaredFields() { }

}

internal class TypeInfo : IRemotingTypeInfo // TypeDefIndex: 1153
{	// Fields
	private string serverType; // 0x10
	private string[] serverHierarchy; // 0x18
	private string[] interfacesImplemented; // 0x20

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x12066D0 Offset: 0x1204CD0 VA: 0x1812066D0
	public void .ctor(Type type) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 4
	public string get_TypeName() { }

	// RVA: 0x1206470 Offset: 0x1204A70 VA: 0x181206470 Slot: 5
	public bool CanCastTo(Type fromType, object o) { }

}

