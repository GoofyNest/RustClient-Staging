public class FirstPersonEffect : MonoBehaviour, IEffect, IPrefabPreProcess // TypeDefIndex: 9348
{	// Fields
	public bool isGunShot; // 0x18
	[HideInInspector] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public EffectParentToWeaponBone parentToWeaponComponent; // 0x20

	// Methods

	// RVA: 0x78AC90 Offset: 0x789290 VA: 0x18078AC90
	private BaseViewModel GetViewModel(Effect effect) { }

	// RVA: 0x78B680 Offset: 0x789C80 VA: 0x18078B680 Slot: 6
	public virtual void SetupEffect(Effect effect) { }

	// RVA: 0x78B320 Offset: 0x789920 VA: 0x18078B320
	private void MakeThirdPerson() { }

	// RVA: 0x78B0D0 Offset: 0x7896D0 VA: 0x18078B0D0
	private void MakeFirstPerson() { }

	// RVA: 0x78B620 Offset: 0x789C20 VA: 0x18078B620 Slot: 5
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

