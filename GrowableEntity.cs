public class GrowableEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6325
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int state; // 0x14
	public float age; // 0x18
	public int water; // 0x1C
	public float healthy; // 0x20
	public float totalAge; // 0x24
	public float growthAge; // 0x28
	public float yieldFraction; // 0x2C
	public float stageAge; // 0x30
	public int genes; // 0x34
	public float lightModifier; // 0x38
	public float waterModifier; // 0x3C
	public float groundModifier; // 0x40
	public float happiness; // 0x44
	public float temperatureModifier; // 0x48
	public float waterConsumption; // 0x4C
	public float yieldPool; // 0x50
	public bool fertilized; // 0x54
	public int previousGenes; // 0x58

	// Methods

	// RVA: 0x1D61AE0 Offset: 0x1D600E0 VA: 0x181D61AE0
	public static void ResetToPool(GrowableEntity instance) { }

	// RVA: 0x1D61950 Offset: 0x1D5FF50 VA: 0x181D61950
	public void ResetToPool() { }

	// RVA: 0x1D61700 Offset: 0x1D5FD00 VA: 0x181D61700 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D5FE60 Offset: 0x1D5E460 VA: 0x181D5FE60
	public void CopyTo(GrowableEntity instance) { }

	// RVA: 0x1D5FEF0 Offset: 0x1D5E4F0 VA: 0x181D5FEF0
	public GrowableEntity Copy() { }

	// RVA: 0x1D61680 Offset: 0x1D5FC80 VA: 0x181D61680
	public static GrowableEntity Deserialize(Stream stream) { }

	// RVA: 0x1D606A0 Offset: 0x1D5ECA0 VA: 0x181D606A0
	public static GrowableEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D60DD0 Offset: 0x1D5F3D0 VA: 0x181D60DD0
	public static GrowableEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D60F60 Offset: 0x1D5F560 VA: 0x181D60F60
	public static GrowableEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1D61910 Offset: 0x1D5FF10 VA: 0x181D61910
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D62930 Offset: 0x1D60F30 VA: 0x181D62930 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D62950 Offset: 0x1D60F50 VA: 0x181D62950 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GrowableEntity previous) { }

	// RVA: 0x1D61930 Offset: 0x1D5FF30 VA: 0x181D61930 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D60E60 Offset: 0x1D5F460 VA: 0x181D60E60
	public static GrowableEntity Deserialize(byte[] buffer, GrowableEntity instance, bool isDelta = False) { }

	// RVA: 0x1D61080 Offset: 0x1D5F680 VA: 0x181D61080
	public static GrowableEntity Deserialize(Stream stream, GrowableEntity instance, bool isDelta) { }

	// RVA: 0x1D5FFD0 Offset: 0x1D5E5D0 VA: 0x181D5FFD0
	public static GrowableEntity DeserializeLengthDelimited(Stream stream, GrowableEntity instance, bool isDelta) { }

	// RVA: 0x1D60720 Offset: 0x1D5ED20 VA: 0x181D60720
	public static GrowableEntity DeserializeLength(Stream stream, int length, GrowableEntity instance, bool isDelta) { }

	// RVA: 0x1D61C70 Offset: 0x1D60270 VA: 0x181D61C70
	public static void SerializeDelta(Stream stream, GrowableEntity instance, GrowableEntity previous) { }

	// RVA: 0x1D62590 Offset: 0x1D60B90 VA: 0x181D62590
	public static void Serialize(Stream stream, GrowableEntity instance) { }

	// RVA: 0x1D62920 Offset: 0x1D60F20 VA: 0x181D62920
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D62930 Offset: 0x1D60F30 VA: 0x181D62930
	public void ToProto(Stream stream) { }

	// RVA: 0x1D62480 Offset: 0x1D60A80 VA: 0x181D62480
	public static byte[] SerializeToBytes(GrowableEntity instance) { }

	// RVA: 0x1D623D0 Offset: 0x1D609D0 VA: 0x181D623D0
	public static void SerializeLengthDelimited(Stream stream, GrowableEntity instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class GrowableEntity : BaseCombatEntity, IInstanceDataReceiver // TypeDefIndex: 8395
{	// Fields
	private Option __menuOption_MenuClone; // 0x240
	private Option __menuOption_MenuPick; // 0x298
	private Option __menuOption_MenuRemove; // 0x2F0
	private TimeSince qualityUpdate; // 0x348
	private DeferredAction skinChange; // 0x350
	private GameObject skin; // 0x358
	private PlantSkin skinComponent; // 0x360
	private MaterialColorLerp materialColorLerp; // 0x368
	private float client_healthScale; // 0x370
	public PlantProperties Properties; // 0x378
	public ItemDefinition SourceItemDef; // 0x380
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private PlantProperties.State <State>k__BackingField; // 0x388
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <Age>k__BackingField; // 0x38C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <LightQuality>k__BackingField; // 0x390
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <GroundQuality>k__BackingField; // 0x394
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <WaterQuality>k__BackingField; // 0x398
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <WaterConsumption>k__BackingField; // 0x39C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <Fertilized>k__BackingField; // 0x3A0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <TemperatureQuality>k__BackingField; // 0x3A4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <OverallQuality>k__BackingField; // 0x3A8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <Yield>k__BackingField; // 0x3AC
	private float stageAge; // 0x3B0
	public GrowableGenes Genes; // 0x3B8
	private const float startingHealth = 10;

	// Properties
	public override bool HasMenuOptions { get; }
	public PlantProperties.State State { get; set; }
	public float Age { get; set; }
	public float LightQuality { get; set; }
	public float GroundQuality { get; set; }
	public float WaterQuality { get; set; }
	public float WaterConsumption { get; set; }
	public bool Fertilized { get; set; }
	public float TemperatureQuality { get; set; }
	public float OverallQuality { get; set; }
	public float Yield { get; set; }
	public float StageProgressFraction { get; }
	private PlantProperties.Stage currentStage { get; }
	public static float ThinkDeltaTime { get; }
	private float growDeltaTime { get; }
	public int CurrentPickAmount { get; }
	public float CurrentPickAmountFloat { get; }

	// Methods

	// RVA: 0x72E340 Offset: 0x72C940 VA: 0x18072E340 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x730190 Offset: 0x72E790 VA: 0x180730190 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x72F170 Offset: 0x72D770 VA: 0x18072F170 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 73
	public override bool AlwaysShowCrosshair() { }

	// RVA: 0x72E270 Offset: 0x72C870 VA: 0x18072E270 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE1510 Offset: 0xE0910 VA: 0x1800E1510
	[BaseEntity.Menu.ShowIf] // RVA: 0xE1510 Offset: 0xE0910 VA: 0x1800E1510
	// RVA: 0x72F0F0 Offset: 0x72D6F0 VA: 0x18072F0F0
	public void MenuPick(BasePlayer ply) { }

	// RVA: 0x72EF30 Offset: 0x72D530 VA: 0x18072EF30
	public bool MenuCanPick(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE1630 Offset: 0xE0A30 VA: 0x1800E1630
	[BaseEntity.Menu.ShowIf] // RVA: 0xE1630 Offset: 0xE0A30 VA: 0x1800E1630
	// RVA: 0x72F0B0 Offset: 0x72D6B0 VA: 0x18072F0B0
	public void MenuClone(BasePlayer ply) { }

	// RVA: 0x72EF20 Offset: 0x72D520 VA: 0x18072EF20
	public bool MenuCanClone(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE17E0 Offset: 0xE0BE0 VA: 0x1800E17E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE17E0 Offset: 0xE0BE0 VA: 0x1800E17E0
	// RVA: 0x72F130 Offset: 0x72D730 VA: 0x18072F130
	public void MenuRemove(BasePlayer ply) { }

	// RVA: 0x72F030 Offset: 0x72D630 VA: 0x18072F030
	public bool MenuCanRemove(BasePlayer player) { }

	// RVA: 0x72EEB0 Offset: 0x72D4B0 VA: 0x18072EEB0 Slot: 75
	public override void LookingAtTick() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x72F640 Offset: 0x72DC40 VA: 0x18072F640
	private void RPC_ReceiveQualityUpdate(BaseEntity.RPCMessage msg) { }

	// RVA: 0x72DEB0 Offset: 0x72C4B0 VA: 0x18072DEB0
	private void ChangeSkin() { }

	// RVA: 0x72E1A0 Offset: 0x72C7A0 VA: 0x18072E1A0
	private void DestroySkin() { }

	// RVA: 0x72F760 Offset: 0x72DD60 VA: 0x18072F760
	private void SpawnSkin() { }

	// RVA: 0x72F9F0 Offset: 0x72DFF0 VA: 0x18072F9F0
	private void UpdateSkinParameters() { }

	// RVA: 0x72F6B0 Offset: 0x72DCB0 VA: 0x18072F6B0
	private void RefreshRenderers() { }

	// RVA: 0x72E280 Offset: 0x72C880 VA: 0x18072E280 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x72F620 Offset: 0x72DC20 VA: 0x18072F620 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x72E2A0 Offset: 0x72C8A0 VA: 0x18072E2A0
	public MaterialColorLerp GetMaterialColorLerp() { }

	// RVA: 0x72F8F0 Offset: 0x72DEF0 VA: 0x18072F8F0
	public void UpdateHealthVisual() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x730400 Offset: 0x72EA00 VA: 0x180730400
	public PlantProperties.State get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7305E0 Offset: 0x72EBE0 VA: 0x1807305E0
	private void set_State(PlantProperties.State value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x730030 Offset: 0x72E630 VA: 0x180730030
	public float get_Age() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x730590 Offset: 0x72EB90 VA: 0x180730590
	private void set_Age(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x730350 Offset: 0x72E950 VA: 0x180730350
	public float get_LightQuality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7305C0 Offset: 0x72EBC0 VA: 0x1807305C0
	private void set_LightQuality(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x730180 Offset: 0x72E780 VA: 0x180730180
	public float get_GroundQuality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7305B0 Offset: 0x72EBB0 VA: 0x1807305B0
	private void set_GroundQuality(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x730490 Offset: 0x72EA90 VA: 0x180730490
	public float get_WaterQuality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x730610 Offset: 0x72EC10 VA: 0x180730610
	private void set_WaterQuality(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x730480 Offset: 0x72EA80 VA: 0x180730480
	public float get_WaterConsumption() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x730600 Offset: 0x72EC00 VA: 0x180730600
	private void set_WaterConsumption(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x730170 Offset: 0x72E770 VA: 0x180730170
	public bool get_Fertilized() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7305A0 Offset: 0x72EBA0 VA: 0x1807305A0
	private void set_Fertilized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x730410 Offset: 0x72EA10 VA: 0x180730410
	public float get_TemperatureQuality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7305F0 Offset: 0x72EBF0 VA: 0x1807305F0
	private void set_TemperatureQuality(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x730360 Offset: 0x72E960 VA: 0x180730360
	public float get_OverallQuality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7305D0 Offset: 0x72EBD0 VA: 0x1807305D0
	private void set_OverallQuality(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7304A0 Offset: 0x72EAA0 VA: 0x1807304A0
	public float get_Yield() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x730620 Offset: 0x72EC20 VA: 0x180730620
	private void set_Yield(float value) { }

	// RVA: 0x730370 Offset: 0x72E970 VA: 0x180730370
	public float get_StageProgressFraction() { }

	// RVA: 0x7304B0 Offset: 0x72EAB0 VA: 0x1807304B0
	private PlantProperties.Stage get_currentStage() { }

	// RVA: 0x730420 Offset: 0x72EA20 VA: 0x180730420
	public static float get_ThinkDeltaTime() { }

	// RVA: 0x730520 Offset: 0x72EB20 VA: 0x180730520
	private float get_growDeltaTime() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 145
	public void ReceiveInstanceData(Item.InstanceData data) { }

	// RVA: 0x72F740 Offset: 0x72DD40 VA: 0x18072F740 Slot: 27
	public override void ResetState() { }

	// RVA: 0x72DDA0 Offset: 0x72C3A0 VA: 0x18072DDA0
	public bool CanPick() { }

	// RVA: 0x7300B0 Offset: 0x72E6B0 VA: 0x1807300B0
	public int get_CurrentPickAmount() { }

	// RVA: 0x730040 Offset: 0x72E640 VA: 0x180730040
	public float get_CurrentPickAmountFloat() { }

	// RVA: 0x72DE00 Offset: 0x72C400 VA: 0x18072DE00
	public bool CanTakeSeeds() { }

	// RVA: 0x72DCF0 Offset: 0x72C2F0 VA: 0x18072DCF0
	public bool CanClone() { }

	// RVA: 0x72EAC0 Offset: 0x72D0C0 VA: 0x18072EAC0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x72E050 Offset: 0x72C650 VA: 0x18072E050
	private void ChangeState(PlantProperties.State state, bool resetAge, bool loading = False) { }

	// RVA: 0x72FED0 Offset: 0x72E4D0 VA: 0x18072FED0
	public void .ctor() { }

}

