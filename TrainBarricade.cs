public class TrainBarricade : BaseCombatEntity, ITrainCollidable // TypeDefIndex: 9767
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x94760 Offset: 0x93B60 VA: 0x180094760
	[SerializeField] // RVA: 0x94760 Offset: 0x93B60 VA: 0x180094760
	private float trainDamagePerMPS; // 0x240
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float minVelToDestroy; // 0x244
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float velReduction; // 0x248
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObjectRef barricadeDamageEffect; // 0x250
	private float nextEffectTime; // 0x258

	// Methods

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 145
	public bool CustomCollision(TrainCar train, TriggerTrainCollisions trainTrigger) { }

	// RVA: 0xA0B1A0 Offset: 0xA097A0 VA: 0x180A0B1A0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0xA0B1D0 Offset: 0xA097D0 VA: 0x180A0B1D0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA0B400 Offset: 0xA09A00 VA: 0x180A0B400
	public void .ctor() { }

}

