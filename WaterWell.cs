public class WaterWell : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6343
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float pressure; // 0x14
	public float waterLevel; // 0x18

	// Methods

	// RVA: 0x1E52AB0 Offset: 0x1E510B0 VA: 0x181E52AB0
	public static void ResetToPool(WaterWell instance) { }

	// RVA: 0x1E52B30 Offset: 0x1E51130 VA: 0x181E52B30
	public void ResetToPool() { }

	// RVA: 0x1E52970 Offset: 0x1E50F70 VA: 0x181E52970 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBEAA0 Offset: 0x1DBD0A0 VA: 0x181DBEAA0
	public void CopyTo(WaterWell instance) { }

	// RVA: 0x1E51B90 Offset: 0x1E50190 VA: 0x181E51B90
	public WaterWell Copy() { }

	// RVA: 0x1E52410 Offset: 0x1E50A10 VA: 0x181E52410
	public static WaterWell Deserialize(Stream stream) { }

	// RVA: 0x1E51C00 Offset: 0x1E50200 VA: 0x181E51C00
	public static WaterWell DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E52010 Offset: 0x1E50610 VA: 0x181E52010
	public static WaterWell DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E52850 Offset: 0x1E50E50 VA: 0x181E52850
	public static WaterWell Deserialize(byte[] buffer) { }

	// RVA: 0x1E52A70 Offset: 0x1E51070 VA: 0x181E52A70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E53040 Offset: 0x1E51640 VA: 0x181E53040 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E53060 Offset: 0x1E51660 VA: 0x181E53060 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, WaterWell previous) { }

	// RVA: 0x1E52A90 Offset: 0x1E51090 VA: 0x181E52A90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E52750 Offset: 0x1E50D50 VA: 0x181E52750
	public static WaterWell Deserialize(byte[] buffer, WaterWell instance, bool isDelta = False) { }

	// RVA: 0x1E52490 Offset: 0x1E50A90 VA: 0x181E52490
	public static WaterWell Deserialize(Stream stream, WaterWell instance, bool isDelta) { }

	// RVA: 0x1E51C80 Offset: 0x1E50280 VA: 0x181E51C80
	public static WaterWell DeserializeLengthDelimited(Stream stream, WaterWell instance, bool isDelta) { }

	// RVA: 0x1E520A0 Offset: 0x1E506A0 VA: 0x181E520A0
	public static WaterWell DeserializeLength(Stream stream, int length, WaterWell instance, bool isDelta) { }

	// RVA: 0x1E52BB0 Offset: 0x1E511B0 VA: 0x181E52BB0
	public static void SerializeDelta(Stream stream, WaterWell instance, WaterWell previous) { }

	// RVA: 0x1E52F30 Offset: 0x1E51530 VA: 0x181E52F30
	public static void Serialize(Stream stream, WaterWell instance) { }

	// RVA: 0x1E53030 Offset: 0x1E51630 VA: 0x181E53030
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E53040 Offset: 0x1E51640 VA: 0x181E53040
	public void ToProto(Stream stream) { }

	// RVA: 0x1E52E20 Offset: 0x1E51420 VA: 0x181E52E20
	public static byte[] SerializeToBytes(WaterWell instance) { }

	// RVA: 0x1E52D30 Offset: 0x1E51330 VA: 0x181E52D30
	public static void SerializeLengthDelimited(Stream stream, WaterWell instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x8F0840 Offset: 0x8EEE40 VA: 0x1808F0840 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x8F1210 Offset: 0x8EF810 VA: 0x1808F1210 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x8F0DB0 Offset: 0x8EF3B0 VA: 0x1808F0DB0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x8F0B80 Offset: 0x8EF180 VA: 0x1808F0B80 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x8F0B50 Offset: 0x8EF150 VA: 0x1808F0B50
	public float GetWaterAmount() { }

	[BaseEntity.Menu] // RVA: 0x9CB50 Offset: 0x9BF50 VA: 0x18009CB50
	[BaseEntity.Menu.Description] // RVA: 0x9CB50 Offset: 0x9BF50 VA: 0x18009CB50
	[BaseEntity.Menu.Icon] // RVA: 0x9CB50 Offset: 0x9BF50 VA: 0x18009CB50
	[BaseEntity.Menu.ShowIf] // RVA: 0x9CB50 Offset: 0x9BF50 VA: 0x18009CB50
	// RVA: 0x8F0D70 Offset: 0x8EF370 VA: 0x1808F0D70
	public void Menu_Pump(BasePlayer player) { }

	// RVA: 0x8F0BE0 Offset: 0x8EF1E0 VA: 0x1808F0BE0
	public bool Menu_Pump_ShowIf(BasePlayer player) { }

	// RVA: 0x8F0EA0 Offset: 0x8EF4A0 VA: 0x1808F0EA0 Slot: 164
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x8F07E0 Offset: 0x8EEDE0 VA: 0x1808F07E0 Slot: 168
	public override bool DrinkEligable(BasePlayer player) { }

	// RVA: 0x8F1000 Offset: 0x8EF600 VA: 0x1808F1000
	public void Update() { }

	// RVA: 0x8F11E0 Offset: 0x8EF7E0 VA: 0x1808F11E0
	public void .ctor() { }

}

