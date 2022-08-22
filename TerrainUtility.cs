public static class TerrainUtility // TypeDefIndex: 4099
{	// Methods

	// RVA: 0x22C2CE0 Offset: 0x22C12E0 VA: 0x1822C2CE0
	internal static bool HasValidTerrains() { }

	// RVA: 0x22C2930 Offset: 0x22C0F30 VA: 0x1822C2930
	internal static void ClearConnectivity() { }

	// RVA: 0x22C29F0 Offset: 0x22C0FF0 VA: 0x1822C29F0
	internal static TerrainUtility.TerrainGroups CollectTerrains(bool onlyAutoConnectedTerrains = True) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22C2560 Offset: 0x22C0B60 VA: 0x1822C2560
	public static void AutoConnect() { }

}

public class TerrainUtility.TerrainMap // TypeDefIndex: 4100
{	// Fields
	private Vector3 m_patchSize; // 0x10
	public TerrainUtility.TerrainMap.ErrorCode m_errorCode; // 0x1C
	public Dictionary<TerrainUtility.TerrainMap.TileCoord, Terrain> m_terrainTiles; // 0x20

	// Methods

	// RVA: 0x22C1A00 Offset: 0x22C0000 VA: 0x1822C1A00
	public Terrain GetTerrain(int tileX, int tileZ) { }

	// RVA: 0x22C1690 Offset: 0x22BFC90 VA: 0x1822C1690
	public static TerrainUtility.TerrainMap CreateFromPlacement(Terrain originTerrain, TerrainUtility.TerrainMap.TerrainFilter filter, bool fullValidation = True) { }

	// RVA: 0x22C12F0 Offset: 0x22BF8F0 VA: 0x1822C12F0
	public static TerrainUtility.TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, TerrainUtility.TerrainMap.TerrainFilter filter, bool fullValidation = True) { }

	// RVA: 0x22C24F0 Offset: 0x22C0AF0 VA: 0x1822C24F0
	public void .ctor() { }

	// RVA: 0x22C1110 Offset: 0x22BF710 VA: 0x1822C1110
	private void AddTerrainInternal(int x, int z, Terrain terrain) { }

	// RVA: 0x22C1A80 Offset: 0x22C0080 VA: 0x1822C1A80
	private bool TryToAddTerrain(int tileX, int tileZ, Terrain terrain) { }

	// RVA: 0x22C1BB0 Offset: 0x22C01B0 VA: 0x1822C1BB0
	private void ValidateTerrain(int tileX, int tileZ) { }

	// RVA: 0x22C23B0 Offset: 0x22C09B0 VA: 0x1822C23B0
	private TerrainUtility.TerrainMap.ErrorCode Validate() { }

}

public sealed class TerrainUtility.TerrainMap.TerrainFilter : MulticastDelegate // TypeDefIndex: 4101
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1786310 Offset: 0x1784910 VA: 0x181786310 Slot: 12
	public virtual bool Invoke(Terrain terrain) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(Terrain terrain, AsyncCallback callback, object object) { }

	// RVA: 0xFF6510 Offset: 0xFF4B10 VA: 0x180FF6510 Slot: 14
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

	// RVA: 0x22C3AA0 Offset: 0x22C20A0 VA: 0x1822C3AA0
	internal bool <CreateFromPlacement>b__0(Terrain x) { }

}

public class TerrainUtility.TerrainGroups : Dictionary<int, TerrainUtility.TerrainMap> // TypeDefIndex: 4105
{	// Methods

	// RVA: 0x22C0FD0 Offset: 0x22BF5D0 VA: 0x1822C0FD0
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

	// RVA: 0x22C3AF0 Offset: 0x22C20F0 VA: 0x1822C3AF0
	internal bool <CollectTerrains>b__0(Terrain x) { }

}

