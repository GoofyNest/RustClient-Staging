public sealed class SecurityPermission : CodeAccessPermission // TypeDefIndex: 916
{
// Namespace: System.Security.Permissions
[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
[Serializable]
public sealed class SecurityPermission : CodeAccessPermission // TypeDefIndex: 916
	// Fields
	private SecurityPermissionFlag flags; // 0x10

	// Methods

	// RVA: 0x17C5AF0 Offset: 0x17C40F0 VA: 0x1817C5AF0
	public void .ctor(PermissionState state) { }

	// RVA: 0x17C5A00 Offset: 0x17C4000 VA: 0x1817C5A00 Slot: 10
	public bool IsUnrestricted() { }

	// RVA: 0x17C5900 Offset: 0x17C3F00 VA: 0x1817C5900 Slot: 8
	public override bool IsSubsetOf(IPermission target) { }

	// RVA: 0x17C5A10 Offset: 0x17C4010 VA: 0x1817C5A10 Slot: 9
	public override SecurityElement ToXml() { }

	// RVA: 0x17C58F0 Offset: 0x17C3EF0 VA: 0x1817C58F0
	private bool IsEmpty() { }

	// RVA: 0x17C5850 Offset: 0x17C3E50 VA: 0x1817C5850
	private SecurityPermission Cast(IPermission target) { }

}

