public class MissionManifest : ScriptableObject // TypeDefIndex: 11928
{
	public ScriptableObjectRef[] missionList; 
	public WorldPositionGenerator[] positionGenerators; 
	public static MissionManifest instance; 


	public static MissionManifest Get() { }

	public static BaseMission GetFromShortName(string shortname) { }

	public static BaseMission GetFromID(uint id) { }

	public void .ctor() { }

}

