public class FirstPersonEffect : MonoBehaviour, IEffect, IPrefabPreProcess // TypeDefIndex: 9348
{	public bool isGunShot; // 0x18
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public EffectParentToWeaponBone parentToWeaponComponent; // 0x20


	private BaseViewModel GetViewModel(Effect effect) { }

	public virtual void SetupEffect(Effect effect) { }

	private void MakeThirdPerson() { }

	private void MakeFirstPerson() { }

	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

}

