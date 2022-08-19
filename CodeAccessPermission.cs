public abstract class CodeAccessPermission : IPermission, ISecurityEncodable // TypeDefIndex: 898
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	[ConditionalAttribute] // RVA: 0xC11A0 Offset: 0xC05A0 VA: 0x1800C11A0
	// RVA: 0x16F8610 Offset: 0x16F6C10 VA: 0x1816F8610 Slot: 7
	public void Demand() { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x16F87D0 Offset: 0x16F6DD0 VA: 0x1816F87D0 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0xCCE560 Offset: 0xCCCB60 VA: 0x180CCE560 Slot: 2
	public override int GetHashCode() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool IsSubsetOf(IPermission target);

	// RVA: 0x16F8990 Offset: 0x16F6F90 VA: 0x1816F8990 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract SecurityElement ToXml();

	// RVA: 0x16F8690 Offset: 0x16F6C90 VA: 0x1816F8690
	internal SecurityElement Element(int version) { }

	// RVA: 0x16F8560 Offset: 0x16F6B60 VA: 0x1816F8560
	internal static PermissionState CheckPermissionState(PermissionState state, bool allowUnrestricted) { }

	// RVA: 0x16F88F0 Offset: 0x16F6EF0 VA: 0x1816F88F0
	internal static void ThrowInvalidPermission(IPermission target, Type expected) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	private void System.Security.IPermission.Demand() { }

}

