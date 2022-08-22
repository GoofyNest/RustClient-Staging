public class MissionManifest : ScriptableObject // TypeDefIndex: 10214
{	// Fields
	public ScriptableObjectRef[] missionList; // 0x18
	public WorldPositionGenerator[] positionGenerators; // 0x20
	public static MissionManifest instance; // 0x0

	// Methods

	// RVA: 0x768100 Offset: 0x766700 VA: 0x180768100
	public static MissionManifest Get() { }

	// RVA: 0x767FE0 Offset: 0x7665E0 VA: 0x180767FE0
	public static BaseMission GetFromShortName(string shortname) { }

	// RVA: 0x767ED0 Offset: 0x7664D0 VA: 0x180767ED0
	public static BaseMission GetFromID(uint id) { }

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
	public void .ctor() { }

}

