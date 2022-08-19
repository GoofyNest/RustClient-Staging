public class BasePrefab : BaseMonoBehaviour, IPrefabPreProcess // TypeDefIndex: 11298
{	// Fields
	[HideInInspector] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public uint prefabID; // 0x18
	[HideInInspector] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public bool isClient; // 0x1C

	// Properties
	public bool isServer { get; }

	// Methods

	// RVA: 0x920DA0 Offset: 0x91F3A0 VA: 0x180920DA0
	public bool get_isServer() { }

	// RVA: 0x920D30 Offset: 0x91F330 VA: 0x180920D30 Slot: 7
	public virtual void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x521BF0 Offset: 0x5201F0 VA: 0x180521BF0
	public void .ctor() { }

}

