public class EnvironmentManager : SingletonComponent<EnvironmentManager> // TypeDefIndex: 9861
{	// Methods

	// RVA: 0x8CA320 Offset: 0x8C8920 VA: 0x1808CA320
	public static EnvironmentType Get(OBB obb) { }

	// RVA: 0x8CA0A0 Offset: 0x8C86A0 VA: 0x1808CA0A0
	public static EnvironmentType Get(Vector3 pos, ref List<EnvironmentVolume> list) { }

	// RVA: 0x8CA1B0 Offset: 0x8C87B0 VA: 0x1808CA1B0
	public static EnvironmentType Get(Vector3 pos) { }

	// RVA: 0x8C9F00 Offset: 0x8C8500 VA: 0x1808C9F00
	public static bool Check(OBB obb, EnvironmentType type) { }

	// RVA: 0x8C9D90 Offset: 0x8C8390 VA: 0x1808C9D90
	public static bool Check(Vector3 pos, EnvironmentType type) { }

	// RVA: 0x8CA4C0 Offset: 0x8C8AC0 VA: 0x1808CA4C0
	public void .ctor() { }

}

