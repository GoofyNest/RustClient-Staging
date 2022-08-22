public class BasePrefab : BaseMonoBehaviour, IPrefabPreProcess // TypeDefIndex: 11298
{	// Fields
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public uint prefabID; // 0x18
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool isClient; // 0x1C

	// Properties
	public bool isServer { get; }

	// Methods

	// RVA: 0x920EB0 Offset: 0x91F4B0 VA: 0x180920EB0
	public bool get_isServer() { }

	// RVA: 0x920E40 Offset: 0x91F440 VA: 0x180920E40 Slot: 7
	public virtual void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x521BF0 Offset: 0x5201F0 VA: 0x180521BF0
	public void .ctor() { }

}

