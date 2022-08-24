public abstract class TileBase : ScriptableObject // TypeDefIndex: 4568
{
	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public virtual void RefreshTile(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public virtual void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	private TileData GetTileDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public virtual bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData) { }

	private TileAnimationData GetTileAnimationDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public virtual bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go) { }

	protected void .ctor() { }

}

