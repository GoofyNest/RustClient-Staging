public class FirstPersonEffect : MonoBehaviour, IEffect, IPrefabPreProcess // TypeDefIndex: 9348
{	// Fields
	public bool isGunShot; // 0x18
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public EffectParentToWeaponBone parentToWeaponComponent; // 0x20

	// Methods

	// RVA: 0x78ADA0 Offset: 0x7893A0 VA: 0x18078ADA0
	private BaseViewModel GetViewModel(Effect effect) { }

	// RVA: 0x78B790 Offset: 0x789D90 VA: 0x18078B790 Slot: 6
	public virtual void SetupEffect(Effect effect) { }

	// RVA: 0x78B430 Offset: 0x789A30 VA: 0x18078B430
	private void MakeThirdPerson() { }

	// RVA: 0x78B1E0 Offset: 0x7897E0 VA: 0x18078B1E0
	private void MakeFirstPerson() { }

	// RVA: 0x78B730 Offset: 0x789D30 VA: 0x18078B730 Slot: 5
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

