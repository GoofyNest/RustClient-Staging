public abstract class CodeAccessPermission : IPermission, ISecurityEncodable // TypeDefIndex: 898
{
	protected void .ctor() { }

	[ConditionalAttribute] // RVA: 0xC12E0 Offset: 0xC06E0 VA: 0x1800C12E0
	public void Demand() { }

	[ComVisibleAttribute] // RVA: 0x75DE0 Offset: 0x751E0 VA: 0x180075DE0
	public override bool Equals(object obj) { }

	[ComVisibleAttribute] // RVA: 0x75DE0 Offset: 0x751E0 VA: 0x180075DE0
	public override int GetHashCode() { }

	public abstract bool IsSubsetOf(IPermission target);

	public override string ToString() { }

	public abstract SecurityElement ToXml();

	internal SecurityElement Element(int version) { }

	internal static PermissionState CheckPermissionState(PermissionState state, bool allowUnrestricted) { }

	internal static void ThrowInvalidPermission(IPermission target, Type expected) { }

	private void System.Security.IPermission.Demand() { }

}

