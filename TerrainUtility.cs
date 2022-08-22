public static class TerrainUtility // TypeDefIndex: 4099
{	// Methods

	// RVA: 0x22C3500 Offset: 0x22C1B00 VA: 0x1822C3500
	internal static bool HasValidTerrains() { }

	// RVA: 0x22C3150 Offset: 0x22C1750 VA: 0x1822C3150
	internal static void ClearConnectivity() { }

	// RVA: 0x22C3210 Offset: 0x22C1810 VA: 0x1822C3210
	internal static TerrainUtility.TerrainGroups CollectTerrains(bool onlyAutoConnectedTerrains = True) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22C2D80 Offset: 0x22C1380 VA: 0x1822C2D80
	public static void AutoConnect() { }

}

public class TerrainUtility.TerrainMap // TypeDefIndex: 4100
{	// Fields
	private Vector3 m_patchSize; // 0x10
	public TerrainUtility.TerrainMap.ErrorCode m_errorCode; // 0x1C
	public Dictionary<TerrainUtility.TerrainMap.TileCoord, Terrain> m_terrainTiles; // 0x20

	// Methods

	// RVA: 0x22C2220 Offset: 0x22C0820 VA: 0x1822C2220
	public Terrain GetTerrain(int tileX, int tileZ) { }

	// RVA: 0x22C1EB0 Offset: 0x22C04B0 VA: 0x1822C1EB0
	public static TerrainUtility.TerrainMap CreateFromPlacement(Terrain originTerrain, TerrainUtility.TerrainMap.TerrainFilter filter, bool fullValidation = True) { }

	// RVA: 0x22C1B10 Offset: 0x22C0110 VA: 0x1822C1B10
	public static TerrainUtility.TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, TerrainUtility.TerrainMap.TerrainFilter filter, bool fullValidation = True) { }

	// RVA: 0x22C2D10 Offset: 0x22C1310 VA: 0x1822C2D10
	public void .ctor() { }

	// RVA: 0x22C1930 Offset: 0x22BFF30 VA: 0x1822C1930
	private void AddTerrainInternal(int x, int z, Terrain terrain) { }

	// RVA: 0x22C22A0 Offset: 0x22C08A0 VA: 0x1822C22A0
	private bool TryToAddTerrain(int tileX, int tileZ, Terrain terrain) { }

	// RVA: 0x22C23D0 Offset: 0x22C09D0 VA: 0x1822C23D0
	private void ValidateTerrain(int tileX, int tileZ) { }

	// RVA: 0x22C2BD0 Offset: 0x22C11D0 VA: 0x1822C2BD0
	private TerrainUtility.TerrainMap.ErrorCode Validate() { }

}

public sealed class TerrainUtility.TerrainMap.TerrainFilter : MulticastDelegate // TypeDefIndex: 4101
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1783E60 Offset: 0x1782460 VA: 0x181783E60 Slot: 12
	public virtual bool Invoke(Terrain terrain) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(Terrain terrain, AsyncCallback callback, object object) { }

	// RVA: 0xFF6FB0 Offset: 0xFF55B0 VA: 0x180FF6FB0 Slot: 14
	public virtual bool EndInvoke(IAsyncResult result) { }

}

public struct TerrainUtility.TerrainMap.TileCoord // TypeDefIndex: 4102
{	// Fields
	public readonly int tileX; // 0x0
	public readonly int tileZ; // 0x4

	// Methods

	// RVA: 0xF88D0 Offset: 0xF7CD0 VA: 0x1800F88D0
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

	// RVA: 0x22C42C0 Offset: 0x22C28C0 VA: 0x1822C42C0
	internal bool <CreateFromPlacement>b__0(Terrain x) { }

}

public class TerrainUtility.TerrainGroups : Dictionary<int, TerrainUtility.TerrainMap> // TypeDefIndex: 4105
{	// Methods

	// RVA: 0x22C17F0 Offset: 0x22BFDF0 VA: 0x1822C17F0
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

	// RVA: 0x22C4310 Offset: 0x22C2910 VA: 0x1822C4310
	internal bool <CollectTerrains>b__0(Terrain x) { }

}

