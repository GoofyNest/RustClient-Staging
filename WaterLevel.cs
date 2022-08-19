public static class WaterLevel // TypeDefIndex: 10055
{	// Methods

	// RVA: 0xC15300 Offset: 0xC13900 VA: 0x180C15300
	public static float Factor(Vector3 start, Vector3 end, float radius, BaseEntity forEntity) { }

	// RVA: 0xC15080 Offset: 0xC13680 VA: 0x180C15080
	public static float Factor(Bounds bounds, BaseEntity forEntity) { }

	// RVA: 0xC174B0 Offset: 0xC15AB0 VA: 0x180C174B0
	public static bool Test(Vector3 pos, bool waves = True, BaseEntity forEntity) { }

	// RVA: 0xC15BD0 Offset: 0xC141D0 VA: 0x180C15BD0
	public static float GetWaterDepth(Vector3 pos, bool waves = True, BaseEntity forEntity) { }

	// RVA: 0xC15A80 Offset: 0xC14080 VA: 0x180C15A80
	public static float GetOverallWaterDepth(Vector3 pos, bool waves = True, BaseEntity forEntity, bool noEarlyExit = False) { }

	// RVA: 0xC154E0 Offset: 0xC13AE0 VA: 0x180C154E0
	public static WaterLevel.WaterInfo GetBuoyancyWaterInfo(Vector3 pos, Vector2 posUV, float terrainHeight, float waterHeight, bool doDeepwaterChecks, BaseEntity forEntity) { }

	// RVA: 0xC15F60 Offset: 0xC14560 VA: 0x180C15F60
	public static WaterLevel.WaterInfo GetWaterInfo(Vector3 pos, bool waves = True, BaseEntity forEntity, bool noEarlyExit = False) { }

	// RVA: 0xC16600 Offset: 0xC14C00 VA: 0x180C16600
	public static WaterLevel.WaterInfo GetWaterInfo(Bounds bounds, BaseEntity forEntity, bool waves = True) { }

	// RVA: 0xC16C70 Offset: 0xC15270 VA: 0x180C16C70
	public static WaterLevel.WaterInfo GetWaterInfo(Vector3 start, Vector3 end, float radius, BaseEntity forEntity, bool waves = True) { }

	// RVA: 0xC15D10 Offset: 0xC14310 VA: 0x180C15D10
	private static WaterLevel.WaterInfo GetWaterInfoFromVolumes(Bounds bounds, BaseEntity forEntity) { }

	// RVA: 0xC15DC0 Offset: 0xC143C0 VA: 0x180C15DC0
	private static WaterLevel.WaterInfo GetWaterInfoFromVolumes(Vector3 pos, BaseEntity forEntity) { }

	// RVA: 0xC15E70 Offset: 0xC14470 VA: 0x180C15E70
	private static WaterLevel.WaterInfo GetWaterInfoFromVolumes(Vector3 start, Vector3 end, float radius, BaseEntity forEntity) { }

}

public struct WaterLevel.WaterInfo // TypeDefIndex: 10056
{	// Fields
	public bool isValid; // 0x0
	public float currentDepth; // 0x4
	public float overallDepth; // 0x8
	public float surfaceLevel; // 0xC

}

