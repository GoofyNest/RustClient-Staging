public class TrainBarricade : BaseCombatEntity, ITrainCollidable // TypeDefIndex: 9767
{	[FormerlySerializedAsAttribute] // RVA: 0x94930 Offset: 0x93D30 VA: 0x180094930
	[SerializeField] // RVA: 0x94930 Offset: 0x93D30 VA: 0x180094930
	private float trainDamagePerMPS; // 0x240
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float minVelToDestroy; // 0x244
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float velReduction; // 0x248
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private GameObjectRef barricadeDamageEffect; // 0x250
	private float nextEffectTime; // 0x258


	public bool CustomCollision(TrainCar train, TriggerTrainCollisions trainTrigger) { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

}

