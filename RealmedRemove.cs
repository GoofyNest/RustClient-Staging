public class RealmedRemove : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 9987
{	// Fields
	public GameObject[] removedFromClient; // 0x18
	public Component[] removedComponentFromClient; // 0x20
	public GameObject[] removedFromServer; // 0x28
	public Component[] removedComponentFromServer; // 0x30
	public Component[] doNotRemoveFromServer; // 0x38
	public Component[] doNotRemoveFromClient; // 0x40

	// Methods

	// RVA: 0x6AB380 Offset: 0x6A9980 VA: 0x1806AB380 Slot: 4
	public void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x6AB5B0 Offset: 0x6A9BB0 VA: 0x1806AB5B0
	public bool ShouldDelete(Component comp, bool client, bool server) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

