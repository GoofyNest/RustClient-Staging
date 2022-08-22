public static class WaterLevel // TypeDefIndex: 10055
{	// Methods

	// RVA: 0xC155C0 Offset: 0xC13BC0 VA: 0x180C155C0
	public static float Factor(Vector3 start, Vector3 end, float radius, BaseEntity forEntity) { }

	// RVA: 0xC15340 Offset: 0xC13940 VA: 0x180C15340
	public static float Factor(Bounds bounds, BaseEntity forEntity) { }

	// RVA: 0xC17770 Offset: 0xC15D70 VA: 0x180C17770
	public static bool Test(Vector3 pos, bool waves = True, BaseEntity forEntity) { }

	// RVA: 0xC15E90 Offset: 0xC14490 VA: 0x180C15E90
	public static float GetWaterDepth(Vector3 pos, bool waves = True, BaseEntity forEntity) { }

	// RVA: 0xC15D40 Offset: 0xC14340 VA: 0x180C15D40
	public static float GetOverallWaterDepth(Vector3 pos, bool waves = True, BaseEntity forEntity, bool noEarlyExit = False) { }

	// RVA: 0xC157A0 Offset: 0xC13DA0 VA: 0x180C157A0
	public static WaterLevel.WaterInfo GetBuoyancyWaterInfo(Vector3 pos, Vector2 posUV, float terrainHeight, float waterHeight, bool doDeepwaterChecks, BaseEntity forEntity) { }

	// RVA: 0xC16220 Offset: 0xC14820 VA: 0x180C16220
	public static WaterLevel.WaterInfo GetWaterInfo(Vector3 pos, bool waves = True, BaseEntity forEntity, bool noEarlyExit = False) { }

	// RVA: 0xC168C0 Offset: 0xC14EC0 VA: 0x180C168C0
	public static WaterLevel.WaterInfo GetWaterInfo(Bounds bounds, BaseEntity forEntity, bool waves = True) { }

	// RVA: 0xC16F30 Offset: 0xC15530 VA: 0x180C16F30
	public static WaterLevel.WaterInfo GetWaterInfo(Vector3 start, Vector3 end, float radius, BaseEntity forEntity, bool waves = True) { }

	// RVA: 0xC15FD0 Offset: 0xC145D0 VA: 0x180C15FD0
	private static WaterLevel.WaterInfo GetWaterInfoFromVolumes(Bounds bounds, BaseEntity forEntity) { }

	// RVA: 0xC16080 Offset: 0xC14680 VA: 0x180C16080
	private static WaterLevel.WaterInfo GetWaterInfoFromVolumes(Vector3 pos, BaseEntity forEntity) { }

	// RVA: 0xC16130 Offset: 0xC14730 VA: 0x180C16130
	private static WaterLevel.WaterInfo GetWaterInfoFromVolumes(Vector3 start, Vector3 end, float radius, BaseEntity forEntity) { }

}

public struct WaterLevel.WaterInfo // TypeDefIndex: 10056
{	// Fields
	public bool isValid; // 0x0
	public float currentDepth; // 0x4
	public float overallDepth; // 0x8
	public float surfaceLevel; // 0xC

}

