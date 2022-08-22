public abstract class TileBase : ScriptableObject // TypeDefIndex: 4568
{	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x231FC70 Offset: 0x231E270 VA: 0x18231FC70 Slot: 4
	public virtual void RefreshTile(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public virtual void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	// RVA: 0x231FB70 Offset: 0x231E170 VA: 0x18231FB70
	private TileData GetTileDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x48D660 Offset: 0x48BC60 VA: 0x18048D660 Slot: 6
	public virtual bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData) { }

	// RVA: 0x231FB00 Offset: 0x231E100 VA: 0x18231FB00
	private TileAnimationData GetTileAnimationDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x48D660 Offset: 0x48BC60 VA: 0x18048D660 Slot: 7
	public virtual bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go) { }

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
	protected void .ctor() { }

}

