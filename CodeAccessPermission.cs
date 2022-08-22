public abstract class CodeAccessPermission : IPermission, ISecurityEncodable // TypeDefIndex: 898
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	[ConditionalAttribute] // RVA: 0xC11B0 Offset: 0xC05B0 VA: 0x1800C11B0
	// RVA: 0x16F64C0 Offset: 0x16F4AC0 VA: 0x1816F64C0 Slot: 7
	public void Demand() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x16F6680 Offset: 0x16F4C80 VA: 0x1816F6680 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0xCCECC0 Offset: 0xCCD2C0 VA: 0x180CCECC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool IsSubsetOf(IPermission target);

	// RVA: 0x16F6840 Offset: 0x16F4E40 VA: 0x1816F6840 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract SecurityElement ToXml();

	// RVA: 0x16F6540 Offset: 0x16F4B40 VA: 0x1816F6540
	internal SecurityElement Element(int version) { }

	// RVA: 0x16F6410 Offset: 0x16F4A10 VA: 0x1816F6410
	internal static PermissionState CheckPermissionState(PermissionState state, bool allowUnrestricted) { }

	// RVA: 0x16F67A0 Offset: 0x16F4DA0 VA: 0x1816F67A0
	internal static void ThrowInvalidPermission(IPermission target, Type expected) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	private void System.Security.IPermission.Demand() { }

}

