public sealed class SecurityPermission : CodeAccessPermission // TypeDefIndex: 916
{
// Namespace: System.Security.Permissions
[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
[Serializable]
public sealed class SecurityPermission : CodeAccessPermission // TypeDefIndex: 916
	// Fields
	private SecurityPermissionFlag flags; // 0x10

	// Methods

	// RVA: 0x17C3640 Offset: 0x17C1C40 VA: 0x1817C3640
	public void .ctor(PermissionState state) { }

	// RVA: 0x17C3550 Offset: 0x17C1B50 VA: 0x1817C3550 Slot: 10
	public bool IsUnrestricted() { }

	// RVA: 0x17C3450 Offset: 0x17C1A50 VA: 0x1817C3450 Slot: 8
	public override bool IsSubsetOf(IPermission target) { }

	// RVA: 0x17C3560 Offset: 0x17C1B60 VA: 0x1817C3560 Slot: 9
	public override SecurityElement ToXml() { }

	// RVA: 0x17C3440 Offset: 0x17C1A40 VA: 0x1817C3440
	private bool IsEmpty() { }

	// RVA: 0x17C33A0 Offset: 0x17C19A0 VA: 0x1817C33A0
	private SecurityPermission Cast(IPermission target) { }

}

