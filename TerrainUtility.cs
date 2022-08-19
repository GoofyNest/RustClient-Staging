public static class TerrainUtility // TypeDefIndex: 4099
{	// Methods

	// RVA: 0x22C2BE0 Offset: 0x22C11E0 VA: 0x1822C2BE0
	internal static bool HasValidTerrains() { }

	// RVA: 0x22C2830 Offset: 0x22C0E30 VA: 0x1822C2830
	internal static void ClearConnectivity() { }

	// RVA: 0x22C28F0 Offset: 0x22C0EF0 VA: 0x1822C28F0
	internal static TerrainUtility.TerrainGroups CollectTerrains(bool onlyAutoConnectedTerrains = True) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22C2460 Offset: 0x22C0A60 VA: 0x1822C2460
	public static void AutoConnect() { }

}

public class TerrainUtility.TerrainMap // TypeDefIndex: 4100
{	// Fields
	private Vector3 m_patchSize; // 0x10
	public TerrainUtility.TerrainMap.ErrorCode m_errorCode; // 0x1C
	public Dictionary<TerrainUtility.TerrainMap.TileCoord, Terrain> m_terrainTiles; // 0x20

	// Methods

	// RVA: 0x22C1900 Offset: 0x22BFF00 VA: 0x1822C1900
	public Terrain GetTerrain(int tileX, int tileZ) { }

	// RVA: 0x22C1590 Offset: 0x22BFB90 VA: 0x1822C1590
	public static TerrainUtility.TerrainMap CreateFromPlacement(Terrain originTerrain, TerrainUtility.TerrainMap.TerrainFilter filter, bool fullValidation = True) { }

	// RVA: 0x22C11F0 Offset: 0x22BF7F0 VA: 0x1822C11F0
	public static TerrainUtility.TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, TerrainUtility.TerrainMap.TerrainFilter filter, bool fullValidation = True) { }

	// RVA: 0x22C23F0 Offset: 0x22C09F0 VA: 0x1822C23F0
	public void .ctor() { }

	// RVA: 0x22C1010 Offset: 0x22BF610 VA: 0x1822C1010
	private void AddTerrainInternal(int x, int z, Terrain terrain) { }

	// RVA: 0x22C1980 Offset: 0x22BFF80 VA: 0x1822C1980
	private bool TryToAddTerrain(int tileX, int tileZ, Terrain terrain) { }

	// RVA: 0x22C1AB0 Offset: 0x22C00B0 VA: 0x1822C1AB0
	private void ValidateTerrain(int tileX, int tileZ) { }

	// RVA: 0x22C22B0 Offset: 0x22C08B0 VA: 0x1822C22B0
	private TerrainUtility.TerrainMap.ErrorCode Validate() { }

}

public sealed class TerrainUtility.TerrainMap.TerrainFilter : MulticastDelegate // TypeDefIndex: 4101
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1786050 Offset: 0x1784650 VA: 0x181786050 Slot: 12
	public virtual bool Invoke(Terrain terrain) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(Terrain terrain, AsyncCallback callback, object object) { }

	// RVA: 0xFF6250 Offset: 0xFF4850 VA: 0x180FF6250 Slot: 14
	public virtual bool EndInvoke(IAsyncResult result) { }

}

public struct TerrainUtility.TerrainMap.TileCoord // TypeDefIndex: 4102
{	// Fields
	public readonly int tileX; // 0x0
	public readonly int tileZ; // 0x4

	// Methods

	// RVA: 0xF8950 Offset: 0xF7D50 VA: 0x1800F8950
	public void .ctor(int tileX, int tileZ) { }

}

public enum TerrainUtility.TerrainMap.ErrorCode // TypeDefIndex: 4103
{	// Fields
	public int value__; // 0x0
	public const TerrainUtility.TerrainMap.ErrorCode OK = 0;
	public const TerrainUtility.TerrainMap.ErrorCode Overlapping = 1;
	public const TerrainUtility.TerrainMap.ErrorCode SizeMismatch = 4;
	public const TerrainUtility.TerrainMap.ErrorCode EdgeAlignmentMismatch = 8;

}

private sealed class TerrainUtility.TerrainMap.<>c__DisplayClass4_0 // TypeDefIndex: 4104
{	// Fields
	public int groupID; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22C39A0 Offset: 0x22C1FA0 VA: 0x1822C39A0
	internal bool <CreateFromPlacement>b__0(Terrain x) { }

}

public class TerrainUtility.TerrainGroups : Dictionary<int, TerrainUtility.TerrainMap> // TypeDefIndex: 4105
{	// Methods

	// RVA: 0x22C0ED0 Offset: 0x22BF4D0 VA: 0x1822C0ED0
	public void .ctor() { }

}

private sealed class TerrainUtility.<>c__DisplayClass4_0 // TypeDefIndex: 4106
{	// Fields
	public bool onlyAutoConnectedTerrains; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class TerrainUtility.<>c__DisplayClass4_1 // TypeDefIndex: 4107
{	// Fields
	public Terrain t; // 0x10
	public TerrainUtility.<>c__DisplayClass4_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22C39F0 Offset: 0x22C1FF0 VA: 0x1822C39F0
	internal bool <CollectTerrains>b__0(Terrain x) { }

}

