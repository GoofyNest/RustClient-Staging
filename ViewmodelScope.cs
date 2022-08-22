public class ViewmodelScope : MonoBehaviour // TypeDefIndex: 8894
{	// Fields
	public float smoothSpeed; // 0x18
	public Material scopeMaterialOverride; // 0x20
	private bool wasVisible; // 0x28

	// Methods

	// RVA: 0x7FB1E0 Offset: 0x7F97E0 VA: 0x1807FB1E0
	public void OnEnable() { }

	// RVA: 0x7FB150 Offset: 0x7F9750 VA: 0x1807FB150
	public void OnDisable() { }

	// RVA: 0x7FB1E0 Offset: 0x7F97E0 VA: 0x1807FB1E0
	public void Update() { }

	// RVA: 0x7FB4C0 Offset: 0x7F9AC0 VA: 0x1807FB4C0
	public void UpdateScope() { }

	// RVA: 0x7FAB30 Offset: 0x7F9130 VA: 0x1807FAB30
	public Vector3 GetScreenPos(Vector3 oldPos) { }

	// RVA: 0x7FB0A0 Offset: 0x7F96A0 VA: 0x1807FB0A0
	public void HideAttachments(Transform root, bool shouldShow) { }

	// RVA: -1 Offset: -1
	public void ShowVMParts<T>(Transform root, bool shouldShow) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D8D80 Offset: 0x5D7380 VA: 0x1805D8D80
	|-ViewmodelScope.ShowVMParts<object>
	|-ViewmodelScope.ShowVMParts<MeshRenderer>
	|-ViewmodelScope.ShowVMParts<SkinnedMeshRenderer>
	*/

	// RVA: 0x7FA9B0 Offset: 0x7F8FB0 VA: 0x1807FA9B0
	public ProjectileWeaponMod GetScopeMod() { }

	// RVA: 0x7FA7E0 Offset: 0x7F8DE0 VA: 0x1807FA7E0
	public BaseProjectile GetLocalPlayerWeapon() { }

	// RVA: 0x7FB1F0 Offset: 0x7F97F0 VA: 0x1807FB1F0
	public bool ShouldShow() { }

	// RVA: 0x7FB890 Offset: 0x7F9E90 VA: 0x1807FB890
	public void .ctor() { }

}

private sealed class ViewmodelScope.<>c // TypeDefIndex: 8895
{	// Fields
	public static readonly ViewmodelScope.<>c <>9; // 0x0
	public static Func<ProjectileWeaponMod, bool> <>9__10_0; // 0x8

	// Methods

	// RVA: 0x7F0760 Offset: 0x7EED60 VA: 0x1807F0760
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7F0540 Offset: 0x7EEB40 VA: 0x1807F0540
	internal bool <GetScopeMod>b__10_0(ProjectileWeaponMod x) { }

}

