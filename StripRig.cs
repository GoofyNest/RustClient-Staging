public class StripRig : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 10013
{	// Fields
	public Transform root; // 0x18
	public bool fromClient; // 0x20
	public bool fromServer; // 0x21

	// Methods

	// RVA: 0x79EF00 Offset: 0x79D500 VA: 0x18079EF00 Slot: 4
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x79F190 Offset: 0x79D790 VA: 0x18079F190
	public void Strip(IPrefabProcessor preProcess, SkinnedMeshRenderer skinnedMeshRenderer) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

