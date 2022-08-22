public abstract class CodeAccessPermission : IPermission, ISecurityEncodable // TypeDefIndex: 898
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	[ConditionalAttribute] // RVA: 0xC11B0 Offset: 0xC05B0 VA: 0x1800C11B0
	// RVA: 0x16F88D0 Offset: 0x16F6ED0 VA: 0x1816F88D0 Slot: 7
	public void Demand() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x16F8A90 Offset: 0x16F7090 VA: 0x1816F8A90 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0xCCE820 Offset: 0xCCCE20 VA: 0x180CCE820 Slot: 2
	public override int GetHashCode() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool IsSubsetOf(IPermission target);

	// RVA: 0x16F8C50 Offset: 0x16F7250 VA: 0x1816F8C50 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract SecurityElement ToXml();

	// RVA: 0x16F8950 Offset: 0x16F6F50 VA: 0x1816F8950
	internal SecurityElement Element(int version) { }

	// RVA: 0x16F8820 Offset: 0x16F6E20 VA: 0x1816F8820
	internal static PermissionState CheckPermissionState(PermissionState state, bool allowUnrestricted) { }

	// RVA: 0x16F8BB0 Offset: 0x16F71B0 VA: 0x1816F8BB0
	internal static void ThrowInvalidPermission(IPermission target, Type expected) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	private void System.Security.IPermission.Demand() { }

}

