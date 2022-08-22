public class MissionManifest : ScriptableObject // TypeDefIndex: 10214
{	// Fields
	public ScriptableObjectRef[] missionList; // 0x18
	public WorldPositionGenerator[] positionGenerators; // 0x20
	public static MissionManifest instance; // 0x0

	// Methods

	// RVA: 0x7681B0 Offset: 0x7667B0 VA: 0x1807681B0
	public static MissionManifest Get() { }

	// RVA: 0x768090 Offset: 0x766690 VA: 0x180768090
	public static BaseMission GetFromShortName(string shortname) { }

	// RVA: 0x767F80 Offset: 0x766580 VA: 0x180767F80
	public static BaseMission GetFromID(uint id) { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

}

