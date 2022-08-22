public abstract class CodeAccessPermission : IPermission, ISecurityEncodable // TypeDefIndex: 898
{
	protected void .ctor() { }

	[ConditionalAttribute] // RVA: 0xC11B0 Offset: 0xC05B0 VA: 0x1800C11B0
	public void Demand() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public override bool Equals(object obj) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public override int GetHashCode() { }

	public abstract bool IsSubsetOf(IPermission target);

	public override string ToString() { }

	public abstract SecurityElement ToXml();

	internal SecurityElement Element(int version) { }

	internal static PermissionState CheckPermissionState(PermissionState state, bool allowUnrestricted) { }

	internal static void ThrowInvalidPermission(IPermission target, Type expected) { }

	private void System.Security.IPermission.Demand() { }

}

