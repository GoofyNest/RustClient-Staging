public class WaterWell : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6343
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float pressure; // 0x14
	public float waterLevel; // 0x18

	// Methods

	// RVA: 0x1E52BB0 Offset: 0x1E511B0 VA: 0x181E52BB0
	public static void ResetToPool(WaterWell instance) { }

	// RVA: 0x1E52C30 Offset: 0x1E51230 VA: 0x181E52C30
	public void ResetToPool() { }

	// RVA: 0x1E52A70 Offset: 0x1E51070 VA: 0x181E52A70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBEBA0 Offset: 0x1DBD1A0 VA: 0x181DBEBA0
	public void CopyTo(WaterWell instance) { }

	// RVA: 0x1E51C90 Offset: 0x1E50290 VA: 0x181E51C90
	public WaterWell Copy() { }

	// RVA: 0x1E52510 Offset: 0x1E50B10 VA: 0x181E52510
	public static WaterWell Deserialize(Stream stream) { }

	// RVA: 0x1E51D00 Offset: 0x1E50300 VA: 0x181E51D00
	public static WaterWell DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E52110 Offset: 0x1E50710 VA: 0x181E52110
	public static WaterWell DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E52950 Offset: 0x1E50F50 VA: 0x181E52950
	public static WaterWell Deserialize(byte[] buffer) { }

	// RVA: 0x1E52B70 Offset: 0x1E51170 VA: 0x181E52B70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E53140 Offset: 0x1E51740 VA: 0x181E53140 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E53160 Offset: 0x1E51760 VA: 0x181E53160 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, WaterWell previous) { }

	// RVA: 0x1E52B90 Offset: 0x1E51190 VA: 0x181E52B90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E52850 Offset: 0x1E50E50 VA: 0x181E52850
	public static WaterWell Deserialize(byte[] buffer, WaterWell instance, bool isDelta = False) { }

	// RVA: 0x1E52590 Offset: 0x1E50B90 VA: 0x181E52590
	public static WaterWell Deserialize(Stream stream, WaterWell instance, bool isDelta) { }

	// RVA: 0x1E51D80 Offset: 0x1E50380 VA: 0x181E51D80
	public static WaterWell DeserializeLengthDelimited(Stream stream, WaterWell instance, bool isDelta) { }

	// RVA: 0x1E521A0 Offset: 0x1E507A0 VA: 0x181E521A0
	public static WaterWell DeserializeLength(Stream stream, int length, WaterWell instance, bool isDelta) { }

	// RVA: 0x1E52CB0 Offset: 0x1E512B0 VA: 0x181E52CB0
	public static void SerializeDelta(Stream stream, WaterWell instance, WaterWell previous) { }

	// RVA: 0x1E53030 Offset: 0x1E51630 VA: 0x181E53030
	public static void Serialize(Stream stream, WaterWell instance) { }

	// RVA: 0x1E53130 Offset: 0x1E51730 VA: 0x181E53130
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E53140 Offset: 0x1E51740 VA: 0x181E53140
	public void ToProto(Stream stream) { }

	// RVA: 0x1E52F20 Offset: 0x1E51520 VA: 0x181E52F20
	public static byte[] SerializeToBytes(WaterWell instance) { }

	// RVA: 0x1E52E30 Offset: 0x1E51430 VA: 0x181E52E30
	public static void SerializeLengthDelimited(Stream stream, WaterWell instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class WaterWell : LiquidContainer // TypeDefIndex: 8486
{	// Fields
	private Option __menuOption_Menu_Pump; // 0x3F8
	public Animator animator; // 0x450
	private const BaseEntity.Flags Pumping = 256;
	private const BaseEntity.Flags WaterFlow = 512;
	public float caloriesPerPump; // 0x458
	public float pressurePerPump; // 0x45C
	public float pressureForProduction; // 0x460
	public float currentPressure; // 0x464
	public int waterPerPump; // 0x468
	public GameObject waterLevelObj; // 0x470
	public float waterLevelObjFullOffset; // 0x478
	private float cachedWaterLevel; // 0x47C

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x8F0950 Offset: 0x8EEF50 VA: 0x1808F0950 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x8F1320 Offset: 0x8EF920 VA: 0x1808F1320 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x8F0EC0 Offset: 0x8EF4C0 VA: 0x1808F0EC0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x8F0C90 Offset: 0x8EF290 VA: 0x1808F0C90 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x8F0C60 Offset: 0x8EF260 VA: 0x1808F0C60
	public float GetWaterAmount() { }

	[BaseEntity.Menu] // RVA: 0x9CBE0 Offset: 0x9BFE0 VA: 0x18009CBE0
	[BaseEntity.Menu.Description] // RVA: 0x9CBE0 Offset: 0x9BFE0 VA: 0x18009CBE0
	[BaseEntity.Menu.Icon] // RVA: 0x9CBE0 Offset: 0x9BFE0 VA: 0x18009CBE0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9CBE0 Offset: 0x9BFE0 VA: 0x18009CBE0
	// RVA: 0x8F0E80 Offset: 0x8EF480 VA: 0x1808F0E80
	public void Menu_Pump(BasePlayer player) { }

	// RVA: 0x8F0CF0 Offset: 0x8EF2F0 VA: 0x1808F0CF0
	public bool Menu_Pump_ShowIf(BasePlayer player) { }

	// RVA: 0x8F0FB0 Offset: 0x8EF5B0 VA: 0x1808F0FB0 Slot: 164
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x8F08F0 Offset: 0x8EEEF0 VA: 0x1808F08F0 Slot: 168
	public override bool DrinkEligable(BasePlayer player) { }

	// RVA: 0x8F1110 Offset: 0x8EF710 VA: 0x1808F1110
	public void Update() { }

	// RVA: 0x8F12F0 Offset: 0x8EF8F0 VA: 0x1808F12F0
	public void .ctor() { }

}

