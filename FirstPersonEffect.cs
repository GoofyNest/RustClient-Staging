public class FirstPersonEffect : MonoBehaviour, IEffect, IPrefabPreProcess // TypeDefIndex: 9348
{	// Fields
	public bool isGunShot; // 0x18
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public EffectParentToWeaponBone parentToWeaponComponent; // 0x20

	// Methods

	// RVA: 0x78ACF0 Offset: 0x7892F0 VA: 0x18078ACF0
	private BaseViewModel GetViewModel(Effect effect) { }

	// RVA: 0x78B6E0 Offset: 0x789CE0 VA: 0x18078B6E0 Slot: 6
	public virtual void SetupEffect(Effect effect) { }

	// RVA: 0x78B380 Offset: 0x789980 VA: 0x18078B380
	private void MakeThirdPerson() { }

	// RVA: 0x78B130 Offset: 0x789730 VA: 0x18078B130
	private void MakeFirstPerson() { }

	// RVA: 0x78B680 Offset: 0x789C80 VA: 0x18078B680 Slot: 5
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

