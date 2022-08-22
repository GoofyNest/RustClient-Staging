public class EnvironmentManager : SingletonComponent<EnvironmentManager> // TypeDefIndex: 9861
{	// Methods

	// RVA: 0x8C9E10 Offset: 0x8C8410 VA: 0x1808C9E10
	public static EnvironmentType Get(OBB obb) { }

	// RVA: 0x8C9B90 Offset: 0x8C8190 VA: 0x1808C9B90
	public static EnvironmentType Get(Vector3 pos, ref List<EnvironmentVolume> list) { }

	// RVA: 0x8C9CA0 Offset: 0x8C82A0 VA: 0x1808C9CA0
	public static EnvironmentType Get(Vector3 pos) { }

	// RVA: 0x8C99F0 Offset: 0x8C7FF0 VA: 0x1808C99F0
	public static bool Check(OBB obb, EnvironmentType type) { }

	// RVA: 0x8C9880 Offset: 0x8C7E80 VA: 0x1808C9880
	public static bool Check(Vector3 pos, EnvironmentType type) { }

	// RVA: 0x8C9FB0 Offset: 0x8C85B0 VA: 0x1808C9FB0
	public void .ctor() { }

}

