public static class EnvironmentVolumeEx // TypeDefIndex: 9864
{
	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool CheckEnvironmentVolumes(Transform transform, Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type) { }

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool CheckEnvironmentVolumes(Transform transform, EnvironmentType type) { }

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool CheckEnvironmentVolumesInsideTerrain(Transform transform, Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type, float padding = 0) { }

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool CheckEnvironmentVolumesInsideTerrain(Transform transform, EnvironmentType type) { }

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool CheckEnvironmentVolumesOutsideTerrain(Transform transform, Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type, float padding = 0) { }

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool CheckEnvironmentVolumesOutsideTerrain(Transform transform, EnvironmentType type) { }

}

private sealed class EnvironmentVolumeEx.<>c__DisplayClass2_0 // TypeDefIndex: 9865
{	public float max; // 0x10
	public bool fail; // 0x14


	public void .ctor() { }

	internal void <CheckEnvironmentVolumesInsideTerrain>b__0(int x, int z) { }

}

private sealed class EnvironmentVolumeEx.<>c__DisplayClass4_0 // TypeDefIndex: 9866
{	public float min; // 0x10
	public bool fail; // 0x14


	public void .ctor() { }

	internal void <CheckEnvironmentVolumesOutsideTerrain>b__0(int x, int z) { }

}

