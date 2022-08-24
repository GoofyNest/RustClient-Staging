public class BasePrefab : BaseMonoBehaviour, IPrefabPreProcess // TypeDefIndex: 11302
{	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public uint prefabID; // 0x18
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool isClient; // 0x1C

	public bool isServer { get; }


	public bool get_isServer() { }

	public virtual void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

}

