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

	// RVA: 0x1D622D0 Offset: 0x1D608D0 VA: 0x181D622D0
	public static void ResetToPool(GrowableEntity instance) { }

	// RVA: 0x1D62140 Offset: 0x1D60740 VA: 0x181D62140
	public void ResetToPool() { }

	// RVA: 0x1D61EF0 Offset: 0x1D604F0 VA: 0x181D61EF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D60650 Offset: 0x1D5EC50 VA: 0x181D60650
	public void CopyTo(GrowableEntity instance) { }

	// RVA: 0x1D606E0 Offset: 0x1D5ECE0 VA: 0x181D606E0
	public GrowableEntity Copy() { }

	// RVA: 0x1D61E70 Offset: 0x1D60470 VA: 0x181D61E70
	public static GrowableEntity Deserialize(Stream stream) { }

	// RVA: 0x1D60E90 Offset: 0x1D5F490 VA: 0x181D60E90
	public static GrowableEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D615C0 Offset: 0x1D5FBC0 VA: 0x181D615C0
	public static GrowableEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D61750 Offset: 0x1D5FD50 VA: 0x181D61750
	public static GrowableEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1D62100 Offset: 0x1D60700 VA: 0x181D62100
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D63120 Offset: 0x1D61720 VA: 0x181D63120 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D63140 Offset: 0x1D61740 VA: 0x181D63140 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GrowableEntity previous) { }

	// RVA: 0x1D62120 Offset: 0x1D60720 VA: 0x181D62120 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D61650 Offset: 0x1D5FC50 VA: 0x181D61650
	public static GrowableEntity Deserialize(byte[] buffer, GrowableEntity instance, bool isDelta = False) { }

	// RVA: 0x1D61870 Offset: 0x1D5FE70 VA: 0x181D61870
	public static GrowableEntity Deserialize(Stream stream, GrowableEntity instance, bool isDelta) { }

	// RVA: 0x1D607C0 Offset: 0x1D5EDC0 VA: 0x181D607C0
	public static GrowableEntity DeserializeLengthDelimited(Stream stream, GrowableEntity instance, bool isDelta) { }

	// RVA: 0x1D60F10 Offset: 0x1D5F510 VA: 0x181D60F10
	public static GrowableEntity DeserializeLength(Stream stream, int length, GrowableEntity instance, bool isDelta) { }

	// RVA: 0x1D62460 Offset: 0x1D60A60 VA: 0x181D62460
	public static void SerializeDelta(Stream stream, GrowableEntity instance, GrowableEntity previous) { }

	// RVA: 0x1D62D80 Offset: 0x1D61380 VA: 0x181D62D80
	public static void Serialize(Stream stream, GrowableEntity instance) { }

	// RVA: 0x1D63110 Offset: 0x1D61710 VA: 0x181D63110
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D63120 Offset: 0x1D61720 VA: 0x181D63120
	public void ToProto(Stream stream) { }

	// RVA: 0x1D62C70 Offset: 0x1D61270 VA: 0x181D62C70
	public static byte[] SerializeToBytes(GrowableEntity instance) { }

	// RVA: 0x1D62BC0 Offset: 0x1D611C0 VA: 0x181D62BC0
	public static void SerializeLengthDelimited(Stream stream, GrowableEntity instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x72E290 Offset: 0x72C890 VA: 0x18072E290 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7300E0 Offset: 0x72E6E0 VA: 0x1807300E0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x72F0C0 Offset: 0x72D6C0 VA: 0x18072F0C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 73
	public override bool AlwaysShowCrosshair() { }

	// RVA: 0x72E1C0 Offset: 0x72C7C0 VA: 0x18072E1C0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE1510 Offset: 0xE0910 VA: 0x1800E1510
	[BaseEntity.Menu.ShowIf] // RVA: 0xE1510 Offset: 0xE0910 VA: 0x1800E1510
	// RVA: 0x72F040 Offset: 0x72D640 VA: 0x18072F040
	public void MenuPick(BasePlayer ply) { }

	// RVA: 0x72EE80 Offset: 0x72D480 VA: 0x18072EE80
	public bool MenuCanPick(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE1630 Offset: 0xE0A30 VA: 0x1800E1630
	[BaseEntity.Menu.ShowIf] // RVA: 0xE1630 Offset: 0xE0A30 VA: 0x1800E1630
	// RVA: 0x72F000 Offset: 0x72D600 VA: 0x18072F000
	public void MenuClone(BasePlayer ply) { }

	// RVA: 0x72EE70 Offset: 0x72D470 VA: 0x18072EE70
	public bool MenuCanClone(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE17E0 Offset: 0xE0BE0 VA: 0x1800E17E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE17E0 Offset: 0xE0BE0 VA: 0x1800E17E0
	// RVA: 0x72F080 Offset: 0x72D680 VA: 0x18072F080
	public void MenuRemove(BasePlayer ply) { }

	// RVA: 0x72EF80 Offset: 0x72D580 VA: 0x18072EF80
	public bool MenuCanRemove(BasePlayer player) { }

	// RVA: 0x72EE00 Offset: 0x72D400 VA: 0x18072EE00 Slot: 75
	public override void LookingAtTick() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x72F590 Offset: 0x72DB90 VA: 0x18072F590
	private void RPC_ReceiveQualityUpdate(BaseEntity.RPCMessage msg) { }

	// RVA: 0x72DE00 Offset: 0x72C400 VA: 0x18072DE00
	private void ChangeSkin() { }

	// RVA: 0x72E0F0 Offset: 0x72C6F0 VA: 0x18072E0F0
	private void DestroySkin() { }

	// RVA: 0x72F6B0 Offset: 0x72DCB0 VA: 0x18072F6B0
	private void SpawnSkin() { }

	// RVA: 0x72F940 Offset: 0x72DF40 VA: 0x18072F940
	private void UpdateSkinParameters() { }

	// RVA: 0x72F600 Offset: 0x72DC00 VA: 0x18072F600
	private void RefreshRenderers() { }

	// RVA: 0x72E1D0 Offset: 0x72C7D0 VA: 0x18072E1D0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x72F570 Offset: 0x72DB70 VA: 0x18072F570 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x72E1F0 Offset: 0x72C7F0 VA: 0x18072E1F0
	public MaterialColorLerp GetMaterialColorLerp() { }

	// RVA: 0x72F840 Offset: 0x72DE40 VA: 0x18072F840
	public void UpdateHealthVisual() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x730350 Offset: 0x72E950 VA: 0x180730350
	public PlantProperties.State get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x730530 Offset: 0x72EB30 VA: 0x180730530
	private void set_State(PlantProperties.State value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x72FF80 Offset: 0x72E580 VA: 0x18072FF80
	public float get_Age() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7304E0 Offset: 0x72EAE0 VA: 0x1807304E0
	private void set_Age(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7302A0 Offset: 0x72E8A0 VA: 0x1807302A0
	public float get_LightQuality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x730510 Offset: 0x72EB10 VA: 0x180730510
	private void set_LightQuality(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7300D0 Offset: 0x72E6D0 VA: 0x1807300D0
	public float get_GroundQuality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x730500 Offset: 0x72EB00 VA: 0x180730500
	private void set_GroundQuality(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7303E0 Offset: 0x72E9E0 VA: 0x1807303E0
	public float get_WaterQuality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x730560 Offset: 0x72EB60 VA: 0x180730560
	private void set_WaterQuality(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7303D0 Offset: 0x72E9D0 VA: 0x1807303D0
	public float get_WaterConsumption() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x730550 Offset: 0x72EB50 VA: 0x180730550
	private void set_WaterConsumption(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7300C0 Offset: 0x72E6C0 VA: 0x1807300C0
	public bool get_Fertilized() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7304F0 Offset: 0x72EAF0 VA: 0x1807304F0
	private void set_Fertilized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x730360 Offset: 0x72E960 VA: 0x180730360
	public float get_TemperatureQuality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x730540 Offset: 0x72EB40 VA: 0x180730540
	private void set_TemperatureQuality(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7302B0 Offset: 0x72E8B0 VA: 0x1807302B0
	public float get_OverallQuality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x730520 Offset: 0x72EB20 VA: 0x180730520
	private void set_OverallQuality(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7303F0 Offset: 0x72E9F0 VA: 0x1807303F0
	public float get_Yield() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x730570 Offset: 0x72EB70 VA: 0x180730570
	private void set_Yield(float value) { }

	// RVA: 0x7302C0 Offset: 0x72E8C0 VA: 0x1807302C0
	public float get_StageProgressFraction() { }

	// RVA: 0x730400 Offset: 0x72EA00 VA: 0x180730400
	private PlantProperties.Stage get_currentStage() { }

	// RVA: 0x730370 Offset: 0x72E970 VA: 0x180730370
	public static float get_ThinkDeltaTime() { }

	// RVA: 0x730470 Offset: 0x72EA70 VA: 0x180730470
	private float get_growDeltaTime() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 145
	public void ReceiveInstanceData(Item.InstanceData data) { }

	// RVA: 0x72F690 Offset: 0x72DC90 VA: 0x18072F690 Slot: 27
	public override void ResetState() { }

	// RVA: 0x72DCF0 Offset: 0x72C2F0 VA: 0x18072DCF0
	public bool CanPick() { }

	// RVA: 0x730000 Offset: 0x72E600 VA: 0x180730000
	public int get_CurrentPickAmount() { }

	// RVA: 0x72FF90 Offset: 0x72E590 VA: 0x18072FF90
	public float get_CurrentPickAmountFloat() { }

	// RVA: 0x72DD50 Offset: 0x72C350 VA: 0x18072DD50
	public bool CanTakeSeeds() { }

	// RVA: 0x72DC40 Offset: 0x72C240 VA: 0x18072DC40
	public bool CanClone() { }

	// RVA: 0x72EA10 Offset: 0x72D010 VA: 0x18072EA10 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x72DFA0 Offset: 0x72C5A0 VA: 0x18072DFA0
	private void ChangeState(PlantProperties.State state, bool resetAge, bool loading = False) { }

	// RVA: 0x72FE20 Offset: 0x72E420 VA: 0x18072FE20
	public void .ctor() { }

}

