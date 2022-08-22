public sealed class SecurityPermission : CodeAccessPermission // TypeDefIndex: 916
{
// Namespace: System.Security.Permissions
[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
[Serializable]
public sealed class SecurityPermission : CodeAccessPermission // TypeDefIndex: 916
	// Fields
	private SecurityPermissionFlag flags; // 0x10

	// Methods

	// RVA: 0x17C5830 Offset: 0x17C3E30 VA: 0x1817C5830
	public void .ctor(PermissionState state) { }

	// RVA: 0x17C5740 Offset: 0x17C3D40 VA: 0x1817C5740 Slot: 10
	public bool IsUnrestricted() { }

	// RVA: 0x17C5640 Offset: 0x17C3C40 VA: 0x1817C5640 Slot: 8
	public override bool IsSubsetOf(IPermission target) { }

	// RVA: 0x17C5750 Offset: 0x17C3D50 VA: 0x1817C5750 Slot: 9
	public override SecurityElement ToXml() { }

	// RVA: 0x17C5630 Offset: 0x17C3C30 VA: 0x1817C5630
	private bool IsEmpty() { }

	// RVA: 0x17C5590 Offset: 0x17C3B90 VA: 0x1817C5590
	private SecurityPermission Cast(IPermission target) { }

}

