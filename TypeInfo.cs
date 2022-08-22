public abstract class TypeInfo : Type, IReflectableType // TypeDefIndex: 554
{	// Properties
	public virtual IEnumerable<FieldInfo> DeclaredFields { get; }

	// Methods

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFF74F0 Offset: 0xFF5AF0 VA: 0x180FF74F0
	internal void .ctor() { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 120
	private TypeInfo System.Reflection.IReflectableType.GetTypeInfo() { }

	// RVA: 0xFF7550 Offset: 0xFF5B50 VA: 0x180FF7550 Slot: 121
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

	// RVA: 0x1206D70 Offset: 0x1205370 VA: 0x181206D70
	public void .ctor(Type type) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 4
	public string get_TypeName() { }

	// RVA: 0x1206B10 Offset: 0x1205110 VA: 0x181206B10 Slot: 5
	public bool CanCastTo(Type fromType, object o) { }

}

