public static class EnvironmentVolumeEx // TypeDefIndex: 9864
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8CB310 Offset: 0x8C9910 VA: 0x1808CB310
	public static bool CheckEnvironmentVolumes(Transform transform, Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8CB240 Offset: 0x8C9840 VA: 0x1808CB240
	public static bool CheckEnvironmentVolumes(Transform transform, EnvironmentType type) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8CA520 Offset: 0x8C8B20 VA: 0x1808CA520
	public static bool CheckEnvironmentVolumesInsideTerrain(Transform transform, Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type, float padding = 0) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8CAAD0 Offset: 0x8C90D0 VA: 0x1808CAAD0
	public static bool CheckEnvironmentVolumesInsideTerrain(Transform transform, EnvironmentType type) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8CAC90 Offset: 0x8C9290 VA: 0x1808CAC90
	public static bool CheckEnvironmentVolumesOutsideTerrain(Transform transform, Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type, float padding = 0) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8CABB0 Offset: 0x8C91B0 VA: 0x1808CABB0
	public static bool CheckEnvironmentVolumesOutsideTerrain(Transform transform, EnvironmentType type) { }

}

private sealed class EnvironmentVolumeEx.<>c__DisplayClass2_0 // TypeDefIndex: 9865
{	// Fields
	public float max; // 0x10
	public bool fail; // 0x14

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8D9E50 Offset: 0x8D8450 VA: 0x1808D9E50
	internal void <CheckEnvironmentVolumesInsideTerrain>b__0(int x, int z) { }

}

private sealed class EnvironmentVolumeEx.<>c__DisplayClass4_0 // TypeDefIndex: 9866
{	// Fields
	public float min; // 0x10
	public bool fail; // 0x14

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8D9F30 Offset: 0x8D8530 VA: 0x1808D9F30
	internal void <CheckEnvironmentVolumesOutsideTerrain>b__0(int x, int z) { }

}

