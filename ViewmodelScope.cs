public class ViewmodelScope : MonoBehaviour // TypeDefIndex: 8894
{	// Fields
	public float smoothSpeed; // 0x18
	public Material scopeMaterialOverride; // 0x20
	private bool wasVisible; // 0x28

	// Methods

	// RVA: 0x7FAC50 Offset: 0x7F9250 VA: 0x1807FAC50
	public void OnEnable() { }

	// RVA: 0x7FABC0 Offset: 0x7F91C0 VA: 0x1807FABC0
	public void OnDisable() { }

	// RVA: 0x7FAC50 Offset: 0x7F9250 VA: 0x1807FAC50
	public void Update() { }

	// RVA: 0x7FAF30 Offset: 0x7F9530 VA: 0x1807FAF30
	public void UpdateScope() { }

	// RVA: 0x7FA5A0 Offset: 0x7F8BA0 VA: 0x1807FA5A0
	public Vector3 GetScreenPos(Vector3 oldPos) { }

	// RVA: 0x7FAB10 Offset: 0x7F9110 VA: 0x1807FAB10
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

	// RVA: 0x7FA420 Offset: 0x7F8A20 VA: 0x1807FA420
	public ProjectileWeaponMod GetScopeMod() { }

	// RVA: 0x7FA250 Offset: 0x7F8850 VA: 0x1807FA250
	public BaseProjectile GetLocalPlayerWeapon() { }

	// RVA: 0x7FAC60 Offset: 0x7F9260 VA: 0x1807FAC60
	public bool ShouldShow() { }

	// RVA: 0x7FB300 Offset: 0x7F9900 VA: 0x1807FB300
	public void .ctor() { }

}

private sealed class ViewmodelScope.<>c // TypeDefIndex: 8895
{	// Fields
	public static readonly ViewmodelScope.<>c <>9; // 0x0
	public static Func<ProjectileWeaponMod, bool> <>9__10_0; // 0x8

	// Methods

	// RVA: 0x7F01D0 Offset: 0x7EE7D0 VA: 0x1807F01D0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7EFFB0 Offset: 0x7EE5B0 VA: 0x1807EFFB0
	internal bool <GetScopeMod>b__10_0(ProjectileWeaponMod x) { }

}

