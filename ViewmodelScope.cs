public class ViewmodelScope : MonoBehaviour // TypeDefIndex: 8894
{	// Fields
	public float smoothSpeed; // 0x18
	public Material scopeMaterialOverride; // 0x20
	private bool wasVisible; // 0x28

	// Methods

	// RVA: 0x7FAB40 Offset: 0x7F9140 VA: 0x1807FAB40
	public void OnEnable() { }

	// RVA: 0x7FAAB0 Offset: 0x7F90B0 VA: 0x1807FAAB0
	public void OnDisable() { }

	// RVA: 0x7FAB40 Offset: 0x7F9140 VA: 0x1807FAB40
	public void Update() { }

	// RVA: 0x7FAE20 Offset: 0x7F9420 VA: 0x1807FAE20
	public void UpdateScope() { }

	// RVA: 0x7FA490 Offset: 0x7F8A90 VA: 0x1807FA490
	public Vector3 GetScreenPos(Vector3 oldPos) { }

	// RVA: 0x7FAA00 Offset: 0x7F9000 VA: 0x1807FAA00
	public void HideAttachments(Transform root, bool shouldShow) { }

	// RVA: -1 Offset: -1
	public void ShowVMParts<T>(Transform root, bool shouldShow) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D8DF0 Offset: 0x5D73F0 VA: 0x1805D8DF0
	|-ViewmodelScope.ShowVMParts<object>
	|-ViewmodelScope.ShowVMParts<MeshRenderer>
	|-ViewmodelScope.ShowVMParts<SkinnedMeshRenderer>
	*/

	// RVA: 0x7FA310 Offset: 0x7F8910 VA: 0x1807FA310
	public ProjectileWeaponMod GetScopeMod() { }

	// RVA: 0x7FA140 Offset: 0x7F8740 VA: 0x1807FA140
	public BaseProjectile GetLocalPlayerWeapon() { }

	// RVA: 0x7FAB50 Offset: 0x7F9150 VA: 0x1807FAB50
	public bool ShouldShow() { }

	// RVA: 0x7FB1F0 Offset: 0x7F97F0 VA: 0x1807FB1F0
	public void .ctor() { }

}

private sealed class ViewmodelScope.<>c // TypeDefIndex: 8895
{	// Fields
	public static readonly ViewmodelScope.<>c <>9; // 0x0
	public static Func<ProjectileWeaponMod, bool> <>9__10_0; // 0x8

	// Methods

	// RVA: 0x7F00C0 Offset: 0x7EE6C0 VA: 0x1807F00C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7EFEA0 Offset: 0x7EE4A0 VA: 0x1807EFEA0
	internal bool <GetScopeMod>b__10_0(ProjectileWeaponMod x) { }

}

