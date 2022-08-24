public sealed class SecurityPermission : CodeAccessPermission // TypeDefIndex: 916
{
[ComVisibleAttribute] // RVA: 0x760B0 Offset: 0x754B0 VA: 0x1800760B0
[Serializable]
public sealed class SecurityPermission : CodeAccessPermission // TypeDefIndex: 916
	private SecurityPermissionFlag flags; // 0x10


	public void .ctor(PermissionState state) { }

	public bool IsUnrestricted() { }

	public override bool IsSubsetOf(IPermission target) { }

	public override SecurityElement ToXml() { }

	private bool IsEmpty() { }

	private SecurityPermission Cast(IPermission target) { }

}

