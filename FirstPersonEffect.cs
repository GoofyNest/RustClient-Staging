public class FirstPersonEffect : MonoBehaviour, IEffect, IPrefabPreProcess // TypeDefIndex: 11088
{
	public bool isGunShot;
	[HideInInspector]
	public EffectParentToWeaponBone parentToWeaponComponent;


	private BaseViewModel GetViewModel(Effect effect) { }

	public virtual void SetupEffect(Effect effect) { }

	private void MakeThirdPerson() { }

	private void MakeFirstPerson() { }

	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

}

