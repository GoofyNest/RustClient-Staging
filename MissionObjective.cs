public class MissionObjective : ScriptableObject // TypeDefIndex: 11935
{

	public void .ctor() { }

}

public class MissionObjective_AcquireItem : MissionObjective // TypeDefIndex: 11936
{
	public string itemShortname; 
	public int targetItemAmount; 


	public void .ctor() { }

}

public class MissionObjective_FreeCrate : MissionObjective // TypeDefIndex: 11937
{
	public int targetAmount; 


	public void .ctor() { }

}

public class MissionObjective_Harvest : MissionObjective // TypeDefIndex: 11938
{
	public string[] itemShortnames; 
	public int targetItemAmount; 


	public void .ctor() { }

}

public class MissionObjective_KillEntity : MissionObjective // TypeDefIndex: 11939
{
	public string[] targetPrefabIDs; 
	public int numToKill; 
	public bool shouldUpdateMissionLocation; 


	public void .ctor() { }

}

public class MissionObjective_Move : MissionObjective // TypeDefIndex: 11940
{
	public string positionName; 
	public float distForCompletion; 
	public bool use2D; 


	public void .ctor() { }

}

public class MissionObjective_SpeakWith : MissionObjective // TypeDefIndex: 11941
{
	public ItemAmount[] requiredReturnItems; 
	public bool destroyReturnItems; 


	public void .ctor() { }

}

