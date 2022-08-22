public class BasePrefab : BaseMonoBehaviour, IPrefabPreProcess // TypeDefIndex: 11298
{	// Fields
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public uint prefabID; // 0x18
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool isClient; // 0x1C

	// Properties
	public bool isServer { get; }

	// Methods

	// RVA: 0x9213C0 Offset: 0x91F9C0 VA: 0x1809213C0
	public bool get_isServer() { }

	// RVA: 0x921350 Offset: 0x91F950 VA: 0x180921350 Slot: 7
	public virtual void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x521B80 Offset: 0x520180 VA: 0x180521B80
	public void .ctor() { }

}

