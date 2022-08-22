public static class WaterLevel // TypeDefIndex: 10055
{	// Methods

	// RVA: 0xC15A90 Offset: 0xC14090 VA: 0x180C15A90
	public static float Factor(Vector3 start, Vector3 end, float radius, BaseEntity forEntity) { }

	// RVA: 0xC15810 Offset: 0xC13E10 VA: 0x180C15810
	public static float Factor(Bounds bounds, BaseEntity forEntity) { }

	// RVA: 0xC17C40 Offset: 0xC16240 VA: 0x180C17C40
	public static bool Test(Vector3 pos, bool waves = True, BaseEntity forEntity) { }

	// RVA: 0xC16360 Offset: 0xC14960 VA: 0x180C16360
	public static float GetWaterDepth(Vector3 pos, bool waves = True, BaseEntity forEntity) { }

	// RVA: 0xC16210 Offset: 0xC14810 VA: 0x180C16210
	public static float GetOverallWaterDepth(Vector3 pos, bool waves = True, BaseEntity forEntity, bool noEarlyExit = False) { }

	// RVA: 0xC15C70 Offset: 0xC14270 VA: 0x180C15C70
	public static WaterLevel.WaterInfo GetBuoyancyWaterInfo(Vector3 pos, Vector2 posUV, float terrainHeight, float waterHeight, bool doDeepwaterChecks, BaseEntity forEntity) { }

	// RVA: 0xC166F0 Offset: 0xC14CF0 VA: 0x180C166F0
	public static WaterLevel.WaterInfo GetWaterInfo(Vector3 pos, bool waves = True, BaseEntity forEntity, bool noEarlyExit = False) { }

	// RVA: 0xC16D90 Offset: 0xC15390 VA: 0x180C16D90
	public static WaterLevel.WaterInfo GetWaterInfo(Bounds bounds, BaseEntity forEntity, bool waves = True) { }

	// RVA: 0xC17400 Offset: 0xC15A00 VA: 0x180C17400
	public static WaterLevel.WaterInfo GetWaterInfo(Vector3 start, Vector3 end, float radius, BaseEntity forEntity, bool waves = True) { }

	// RVA: 0xC164A0 Offset: 0xC14AA0 VA: 0x180C164A0
	private static WaterLevel.WaterInfo GetWaterInfoFromVolumes(Bounds bounds, BaseEntity forEntity) { }

	// RVA: 0xC16550 Offset: 0xC14B50 VA: 0x180C16550
	private static WaterLevel.WaterInfo GetWaterInfoFromVolumes(Vector3 pos, BaseEntity forEntity) { }

	// RVA: 0xC16600 Offset: 0xC14C00 VA: 0x180C16600
	private static WaterLevel.WaterInfo GetWaterInfoFromVolumes(Vector3 start, Vector3 end, float radius, BaseEntity forEntity) { }

}

public struct WaterLevel.WaterInfo // TypeDefIndex: 10056
{	// Fields
	public bool isValid; // 0x0
	public float currentDepth; // 0x4
	public float overallDepth; // 0x8
	public float surfaceLevel; // 0xC

}

