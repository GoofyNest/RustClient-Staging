public class BaseMission : BaseScriptableObject // TypeDefIndex: 10201
{	// Fields
	public string shortname; // 0x20
	public Translate.Phrase missionName; // 0x28
	public Translate.Phrase missionDesc; // 0x30
	public BaseMission.MissionObjectiveEntry[] objectives; // 0x38
	public GameObjectRef acceptEffect; // 0x40
	public GameObjectRef failedEffect; // 0x48
	public GameObjectRef victoryEffect; // 0x50
	public int repeatDelaySecondsSuccess; // 0x58
	public int repeatDelaySecondsFailed; // 0x5C
	public float timeLimitSeconds; // 0x60
	public Sprite icon; // 0x68
	public Sprite providerIcon; // 0x70
	public BaseMission.MissionDependancy[] acceptDependancies; // 0x78
	public BaseMission.MissionDependancy[] completionDependancies; // 0x80
	public BaseMission.MissionEntityEntry[] missionEntities; // 0x88
	public BaseMission.PositionGenerator[] positionGenerators; // 0x90
	public ItemAmount[] baseRewards; // 0x98

	// Properties
	public uint id { get; }
	public bool isRepeatable { get; }

	// Methods

	// RVA: 0xA46D30 Offset: 0xA45330 VA: 0x180A46D30
	public uint get_id() { }

	// RVA: 0xA46D90 Offset: 0xA45390 VA: 0x180A46D90
	public bool get_isRepeatable() { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50 Slot: 4
	public virtual Sprite GetIcon(BaseMission.MissionInstance instance) { }

	// RVA: 0xA46BC0 Offset: 0xA451C0 VA: 0x180A46BC0
	public bool IsEligableForMission(BasePlayer player, IMissionProvider provider) { }

	// RVA: 0xA46D20 Offset: 0xA45320 VA: 0x180A46D20
	public void .ctor() { }

}

public class BaseMission.MissionDependancy // TypeDefIndex: 10202
{	// Fields
	public string targetMissionShortname; // 0x10
	public BaseMission.MissionStatus targetMissionDesiredStatus; // 0x18
	public bool everAttempted; // 0x1C

	// Properties
	public uint targetMissionID { get; }

	// Methods

	// RVA: 0xA54300 Offset: 0xA52900 VA: 0x180A54300
	public uint get_targetMissionID() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public enum BaseMission.MissionStatus // TypeDefIndex: 10203
{	// Fields
	public int value__; // 0x0
	public const BaseMission.MissionStatus Default = 0;
	public const BaseMission.MissionStatus Active = 1;
	public const BaseMission.MissionStatus Accomplished = 2;
	public const BaseMission.MissionStatus Failed = 3;
	public const BaseMission.MissionStatus Completed = 4;

}

public enum BaseMission.MissionEventType // TypeDefIndex: 10204
{	// Fields
	public int value__; // 0x0
	public const BaseMission.MissionEventType CUSTOM = 0;
	public const BaseMission.MissionEventType HARVEST = 1;
	public const BaseMission.MissionEventType CONVERSATION = 2;
	public const BaseMission.MissionEventType KILL_ENTITY = 3;
	public const BaseMission.MissionEventType ACQUIRE_ITEM = 4;
	public const BaseMission.MissionEventType FREE_CRATE = 5;

}

public class BaseMission.MissionObjectiveEntry // TypeDefIndex: 10205
{	// Fields
	public Translate.Phrase description; // 0x10
	public int[] startAfterCompletedObjectives; // 0x18
	public int[] autoCompleteOtherObjectives; // 0x20
	public bool onlyProgressIfStarted; // 0x28
	public MissionObjective objective; // 0x30

	// Methods

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public MissionObjective Get() { }

	// RVA: 0xA54630 Offset: 0xA52C30 VA: 0x180A54630
	public void .ctor() { }

}

public class BaseMission.MissionInstance : Pool.IPooled // TypeDefIndex: 10206
{	// Fields
	private BaseEntity _cachedProviderEntity; // 0x10
	private BaseMission _cachedMission; // 0x18
	public uint providerID; // 0x20
	public uint missionID; // 0x24
	public BaseMission.MissionStatus status; // 0x28
	public float completionScale; // 0x2C
	public float startTime; // 0x30
	public float endTime; // 0x34
	public Vector3 missionLocation; // 0x38
	public float timePassed; // 0x44
	public Dictionary<string, Vector3> missionPoints; // 0x48
	public BaseMission.MissionInstance.ObjectiveStatus[] objectiveStatuses; // 0x50
	public List<MissionEntity> createdEntities; // 0x58
	public ItemAmount[] rewards; // 0x60

	// Methods

	// RVA: 0xA54450 Offset: 0xA52A50 VA: 0x180A54450
	public BaseMission GetMission() { }

	// RVA: 0xA54510 Offset: 0xA52B10 VA: 0x180A54510
	public bool ShouldShowOnMap() { }

	// RVA: 0xA54510 Offset: 0xA52B10 VA: 0x180A54510
	public bool ShouldShowOnCompass() { }

	// RVA: 0xA54360 Offset: 0xA52960 VA: 0x180A54360 Slot: 4
	public void EnterPool() { }

	// RVA: 0xA544A0 Offset: 0xA52AA0 VA: 0x180A544A0 Slot: 5
	public void LeavePool() { }

	// RVA: 0xA545C0 Offset: 0xA52BC0 VA: 0x180A545C0
	public void .ctor() { }

}

public class BaseMission.MissionInstance.ObjectiveStatus // TypeDefIndex: 10207
{	// Fields
	public bool started; // 0x10
	public bool completed; // 0x11
	public bool failed; // 0x12
	public int genericInt1; // 0x14
	public float genericFloat1; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public enum BaseMission.MissionInstance.ObjectiveType // TypeDefIndex: 10208
{	// Fields
	public int value__; // 0x0
	public const BaseMission.MissionInstance.ObjectiveType MOVE = 0;
	public const BaseMission.MissionInstance.ObjectiveType KILL = 1;

}

public class BaseMission.PositionGenerator // TypeDefIndex: 10209
{	// Fields
	public string identifier; // 0x10
	public float minDistForMovePoint; // 0x18
	public float maxDistForMovePoint; // 0x1C
	public bool centerOnProvider; // 0x20
	public bool centerOnPlayer; // 0x21
	public BaseMission.PositionGenerator.PositionType positionType; // 0x24
	[HeaderAttribute] // RVA: 0xBE2E0 Offset: 0xBD6E0 VA: 0x1800BE2E0
	[InspectorFlagsAttribute] // RVA: 0xBE2E0 Offset: 0xBD6E0 VA: 0x1800BE2E0
	public MissionPoint.MissionPointEnum Flags; // 0x28
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public MissionPoint.MissionPointEnum ExclusionFlags; // 0x2C
	[HeaderAttribute] // RVA: 0xBE450 Offset: 0xBD850 VA: 0x1800BE450
	public WorldPositionGenerator worldPositionGenerator; // 0x30

	// Methods

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string GetIdentifier() { }

	// RVA: 0xA54640 Offset: 0xA52C40 VA: 0x180A54640
	public void .ctor() { }

}

public enum BaseMission.PositionGenerator.PositionType // TypeDefIndex: 10210
{	// Fields
	public int value__; // 0x0
	public const BaseMission.PositionGenerator.PositionType MissionPoint = 0;
	public const BaseMission.PositionGenerator.PositionType WorldPositionGenerator = 1;

}

public class BaseMission.MissionEntityEntry // TypeDefIndex: 10211
{	// Fields
	public GameObjectRef entityRef; // 0x10
	public string spawnPositionToUse; // 0x18
	public bool cleanupOnMissionFailed; // 0x20
	public bool cleanupOnMissionSuccess; // 0x21

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

