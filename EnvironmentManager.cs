public class EnvironmentManager : SingletonComponent<EnvironmentManager> // TypeDefIndex: 9861
{	// Methods

	// RVA: 0x8C9D00 Offset: 0x8C8300 VA: 0x1808C9D00
	public static EnvironmentType Get(OBB obb) { }

	// RVA: 0x8C9A80 Offset: 0x8C8080 VA: 0x1808C9A80
	public static EnvironmentType Get(Vector3 pos, ref List<EnvironmentVolume> list) { }

	// RVA: 0x8C9B90 Offset: 0x8C8190 VA: 0x1808C9B90
	public static EnvironmentType Get(Vector3 pos) { }

	// RVA: 0x8C98E0 Offset: 0x8C7EE0 VA: 0x1808C98E0
	public static bool Check(OBB obb, EnvironmentType type) { }

	// RVA: 0x8C9770 Offset: 0x8C7D70 VA: 0x1808C9770
	public static bool Check(Vector3 pos, EnvironmentType type) { }

	// RVA: 0x8C9EA0 Offset: 0x8C84A0 VA: 0x1808C9EA0
	public void .ctor() { }

}

