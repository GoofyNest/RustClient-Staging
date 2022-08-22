public class MissionObjective : ScriptableObject // TypeDefIndex: 10219
{	// Methods

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
	public void .ctor() { }

}

public class MissionObjective_AcquireItem : MissionObjective // TypeDefIndex: 10220
{	// Fields
	public string itemShortname; // 0x18
	public int targetItemAmount; // 0x20

	// Methods

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
	public void .ctor() { }

}

public class MissionObjective_FreeCrate : MissionObjective // TypeDefIndex: 10221
{	// Fields
	public int targetAmount; // 0x18

	// Methods

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
	public void .ctor() { }

}

public class MissionObjective_Harvest : MissionObjective // TypeDefIndex: 10222
{	// Fields
	public string[] itemShortnames; // 0x18
	public int targetItemAmount; // 0x20

	// Methods

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
	public void .ctor() { }

}

public class MissionObjective_KillEntity : MissionObjective // TypeDefIndex: 10223
{	// Fields
	public string[] targetPrefabIDs; // 0x18
	public int numToKill; // 0x20
	public bool shouldUpdateMissionLocation; // 0x24

	// Methods

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
	public void .ctor() { }

}

public class MissionObjective_Move : MissionObjective // TypeDefIndex: 10224
{	// Fields
	public string positionName; // 0x18
	public float distForCompletion; // 0x20
	public bool use2D; // 0x24

	// Methods

	// RVA: 0x768240 Offset: 0x766840 VA: 0x180768240
	public void .ctor() { }

}

public class MissionObjective_SpeakWith : MissionObjective // TypeDefIndex: 10225
{	// Fields
	public ItemAmount[] requiredReturnItems; // 0x18
	public bool destroyReturnItems; // 0x20

	// Methods

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
	public void .ctor() { }

}

