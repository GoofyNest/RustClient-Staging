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

	// RVA: 0x1D619E0 Offset: 0x1D5FFE0 VA: 0x181D619E0
	public static void ResetToPool(GrowableEntity instance) { }

	// RVA: 0x1D61850 Offset: 0x1D5FE50 VA: 0x181D61850
	public void ResetToPool() { }

	// RVA: 0x1D61600 Offset: 0x1D5FC00 VA: 0x181D61600 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D5FD60 Offset: 0x1D5E360 VA: 0x181D5FD60
	public void CopyTo(GrowableEntity instance) { }

	// RVA: 0x1D5FDF0 Offset: 0x1D5E3F0 VA: 0x181D5FDF0
	public GrowableEntity Copy() { }

	// RVA: 0x1D61580 Offset: 0x1D5FB80 VA: 0x181D61580
	public static GrowableEntity Deserialize(Stream stream) { }

	// RVA: 0x1D605A0 Offset: 0x1D5EBA0 VA: 0x181D605A0
	public static GrowableEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D60CD0 Offset: 0x1D5F2D0 VA: 0x181D60CD0
	public static GrowableEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D60E60 Offset: 0x1D5F460 VA: 0x181D60E60
	public static GrowableEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1D61810 Offset: 0x1D5FE10 VA: 0x181D61810
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D62830 Offset: 0x1D60E30 VA: 0x181D62830 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D62850 Offset: 0x1D60E50 VA: 0x181D62850 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GrowableEntity previous) { }

	// RVA: 0x1D61830 Offset: 0x1D5FE30 VA: 0x181D61830 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D60D60 Offset: 0x1D5F360 VA: 0x181D60D60
	public static GrowableEntity Deserialize(byte[] buffer, GrowableEntity instance, bool isDelta = False) { }

	// RVA: 0x1D60F80 Offset: 0x1D5F580 VA: 0x181D60F80
	public static GrowableEntity Deserialize(Stream stream, GrowableEntity instance, bool isDelta) { }

	// RVA: 0x1D5FED0 Offset: 0x1D5E4D0 VA: 0x181D5FED0
	public static GrowableEntity DeserializeLengthDelimited(Stream stream, GrowableEntity instance, bool isDelta) { }

	// RVA: 0x1D60620 Offset: 0x1D5EC20 VA: 0x181D60620
	public static GrowableEntity DeserializeLength(Stream stream, int length, GrowableEntity instance, bool isDelta) { }

	// RVA: 0x1D61B70 Offset: 0x1D60170 VA: 0x181D61B70
	public static void SerializeDelta(Stream stream, GrowableEntity instance, GrowableEntity previous) { }

	// RVA: 0x1D62490 Offset: 0x1D60A90 VA: 0x181D62490
	public static void Serialize(Stream stream, GrowableEntity instance) { }

	// RVA: 0x1D62820 Offset: 0x1D60E20 VA: 0x181D62820
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D62830 Offset: 0x1D60E30 VA: 0x181D62830
	public void ToProto(Stream stream) { }

	// RVA: 0x1D62380 Offset: 0x1D60980 VA: 0x181D62380
	public static byte[] SerializeToBytes(GrowableEntity instance) { }

	// RVA: 0x1D622D0 Offset: 0x1D608D0 VA: 0x181D622D0
	public static void SerializeLengthDelimited(Stream stream, GrowableEntity instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private PlantProperties.State <State>k__BackingField; // 0x388
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <Age>k__BackingField; // 0x38C
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <LightQuality>k__BackingField; // 0x390
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <GroundQuality>k__BackingField; // 0x394
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <WaterQuality>k__BackingField; // 0x398
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <WaterConsumption>k__BackingField; // 0x39C
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <Fertilized>k__BackingField; // 0x3A0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <TemperatureQuality>k__BackingField; // 0x3A4
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <OverallQuality>k__BackingField; // 0x3A8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x72E230 Offset: 0x72C830 VA: 0x18072E230 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x730080 Offset: 0x72E680 VA: 0x180730080 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x72F060 Offset: 0x72D660 VA: 0x18072F060 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 73
	public override bool AlwaysShowCrosshair() { }

	// RVA: 0x72E160 Offset: 0x72C760 VA: 0x18072E160 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE13F0 Offset: 0xE07F0 VA: 0x1800E13F0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE13F0 Offset: 0xE07F0 VA: 0x1800E13F0
	// RVA: 0x72EFE0 Offset: 0x72D5E0 VA: 0x18072EFE0
	public void MenuPick(BasePlayer ply) { }

	// RVA: 0x72EE20 Offset: 0x72D420 VA: 0x18072EE20
	public bool MenuCanPick(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE15D0 Offset: 0xE09D0 VA: 0x1800E15D0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE15D0 Offset: 0xE09D0 VA: 0x1800E15D0
	// RVA: 0x72EFA0 Offset: 0x72D5A0 VA: 0x18072EFA0
	public void MenuClone(BasePlayer ply) { }

	// RVA: 0x72EE10 Offset: 0x72D410 VA: 0x18072EE10
	public bool MenuCanClone(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE1780 Offset: 0xE0B80 VA: 0x1800E1780
	[BaseEntity.Menu.ShowIf] // RVA: 0xE1780 Offset: 0xE0B80 VA: 0x1800E1780
	// RVA: 0x72F020 Offset: 0x72D620 VA: 0x18072F020
	public void MenuRemove(BasePlayer ply) { }

	// RVA: 0x72EF20 Offset: 0x72D520 VA: 0x18072EF20
	public bool MenuCanRemove(BasePlayer player) { }

	// RVA: 0x72EDA0 Offset: 0x72D3A0 VA: 0x18072EDA0 Slot: 75
	public override void LookingAtTick() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x72F530 Offset: 0x72DB30 VA: 0x18072F530
	private void RPC_ReceiveQualityUpdate(BaseEntity.RPCMessage msg) { }

	// RVA: 0x72DDA0 Offset: 0x72C3A0 VA: 0x18072DDA0
	private void ChangeSkin() { }

	// RVA: 0x72E090 Offset: 0x72C690 VA: 0x18072E090
	private void DestroySkin() { }

	// RVA: 0x72F650 Offset: 0x72DC50 VA: 0x18072F650
	private void SpawnSkin() { }

	// RVA: 0x72F8E0 Offset: 0x72DEE0 VA: 0x18072F8E0
	private void UpdateSkinParameters() { }

	// RVA: 0x72F5A0 Offset: 0x72DBA0 VA: 0x18072F5A0
	private void RefreshRenderers() { }

	// RVA: 0x72E170 Offset: 0x72C770 VA: 0x18072E170 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x72F510 Offset: 0x72DB10 VA: 0x18072F510 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x72E190 Offset: 0x72C790 VA: 0x18072E190
	public MaterialColorLerp GetMaterialColorLerp() { }

	// RVA: 0x72F7E0 Offset: 0x72DDE0 VA: 0x18072F7E0
	public void UpdateHealthVisual() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7302F0 Offset: 0x72E8F0 VA: 0x1807302F0
	public PlantProperties.State get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7304D0 Offset: 0x72EAD0 VA: 0x1807304D0
	private void set_State(PlantProperties.State value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x72FF20 Offset: 0x72E520 VA: 0x18072FF20
	public float get_Age() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x730480 Offset: 0x72EA80 VA: 0x180730480
	private void set_Age(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x730240 Offset: 0x72E840 VA: 0x180730240
	public float get_LightQuality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7304B0 Offset: 0x72EAB0 VA: 0x1807304B0
	private void set_LightQuality(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x730070 Offset: 0x72E670 VA: 0x180730070
	public float get_GroundQuality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7304A0 Offset: 0x72EAA0 VA: 0x1807304A0
	private void set_GroundQuality(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x730380 Offset: 0x72E980 VA: 0x180730380
	public float get_WaterQuality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x730500 Offset: 0x72EB00 VA: 0x180730500
	private void set_WaterQuality(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x730370 Offset: 0x72E970 VA: 0x180730370
	public float get_WaterConsumption() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7304F0 Offset: 0x72EAF0 VA: 0x1807304F0
	private void set_WaterConsumption(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x730060 Offset: 0x72E660 VA: 0x180730060
	public bool get_Fertilized() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x730490 Offset: 0x72EA90 VA: 0x180730490
	private void set_Fertilized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x730300 Offset: 0x72E900 VA: 0x180730300
	public float get_TemperatureQuality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7304E0 Offset: 0x72EAE0 VA: 0x1807304E0
	private void set_TemperatureQuality(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x730250 Offset: 0x72E850 VA: 0x180730250
	public float get_OverallQuality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7304C0 Offset: 0x72EAC0 VA: 0x1807304C0
	private void set_OverallQuality(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x730390 Offset: 0x72E990 VA: 0x180730390
	public float get_Yield() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x730510 Offset: 0x72EB10 VA: 0x180730510
	private void set_Yield(float value) { }

	// RVA: 0x730260 Offset: 0x72E860 VA: 0x180730260
	public float get_StageProgressFraction() { }

	// RVA: 0x7303A0 Offset: 0x72E9A0 VA: 0x1807303A0
	private PlantProperties.Stage get_currentStage() { }

	// RVA: 0x730310 Offset: 0x72E910 VA: 0x180730310
	public static float get_ThinkDeltaTime() { }

	// RVA: 0x730410 Offset: 0x72EA10 VA: 0x180730410
	private float get_growDeltaTime() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 145
	public void ReceiveInstanceData(Item.InstanceData data) { }

	// RVA: 0x72F630 Offset: 0x72DC30 VA: 0x18072F630 Slot: 27
	public override void ResetState() { }

	// RVA: 0x72DC90 Offset: 0x72C290 VA: 0x18072DC90
	public bool CanPick() { }

	// RVA: 0x72FFA0 Offset: 0x72E5A0 VA: 0x18072FFA0
	public int get_CurrentPickAmount() { }

	// RVA: 0x72FF30 Offset: 0x72E530 VA: 0x18072FF30
	public float get_CurrentPickAmountFloat() { }

	// RVA: 0x72DCF0 Offset: 0x72C2F0 VA: 0x18072DCF0
	public bool CanTakeSeeds() { }

	// RVA: 0x72DBE0 Offset: 0x72C1E0 VA: 0x18072DBE0
	public bool CanClone() { }

	// RVA: 0x72E9B0 Offset: 0x72CFB0 VA: 0x18072E9B0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x72DF40 Offset: 0x72C540 VA: 0x18072DF40
	private void ChangeState(PlantProperties.State state, bool resetAge, bool loading = False) { }

	// RVA: 0x72FDC0 Offset: 0x72E3C0 VA: 0x18072FDC0
	public void .ctor() { }

}

