public class WaterWell : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6343
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float pressure; // 0x14
	public float waterLevel; // 0x18

	// Methods

	// RVA: 0x1E528F0 Offset: 0x1E50EF0 VA: 0x181E528F0
	public static void ResetToPool(WaterWell instance) { }

	// RVA: 0x1E52970 Offset: 0x1E50F70 VA: 0x181E52970
	public void ResetToPool() { }

	// RVA: 0x1E527B0 Offset: 0x1E50DB0 VA: 0x181E527B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBE8E0 Offset: 0x1DBCEE0 VA: 0x181DBE8E0
	public void CopyTo(WaterWell instance) { }

	// RVA: 0x1E519D0 Offset: 0x1E4FFD0 VA: 0x181E519D0
	public WaterWell Copy() { }

	// RVA: 0x1E52250 Offset: 0x1E50850 VA: 0x181E52250
	public static WaterWell Deserialize(Stream stream) { }

	// RVA: 0x1E51A40 Offset: 0x1E50040 VA: 0x181E51A40
	public static WaterWell DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E51E50 Offset: 0x1E50450 VA: 0x181E51E50
	public static WaterWell DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E52690 Offset: 0x1E50C90 VA: 0x181E52690
	public static WaterWell Deserialize(byte[] buffer) { }

	// RVA: 0x1E528B0 Offset: 0x1E50EB0 VA: 0x181E528B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E52E80 Offset: 0x1E51480 VA: 0x181E52E80 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E52EA0 Offset: 0x1E514A0 VA: 0x181E52EA0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, WaterWell previous) { }

	// RVA: 0x1E528D0 Offset: 0x1E50ED0 VA: 0x181E528D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E52590 Offset: 0x1E50B90 VA: 0x181E52590
	public static WaterWell Deserialize(byte[] buffer, WaterWell instance, bool isDelta = False) { }

	// RVA: 0x1E522D0 Offset: 0x1E508D0 VA: 0x181E522D0
	public static WaterWell Deserialize(Stream stream, WaterWell instance, bool isDelta) { }

	// RVA: 0x1E51AC0 Offset: 0x1E500C0 VA: 0x181E51AC0
	public static WaterWell DeserializeLengthDelimited(Stream stream, WaterWell instance, bool isDelta) { }

	// RVA: 0x1E51EE0 Offset: 0x1E504E0 VA: 0x181E51EE0
	public static WaterWell DeserializeLength(Stream stream, int length, WaterWell instance, bool isDelta) { }

	// RVA: 0x1E529F0 Offset: 0x1E50FF0 VA: 0x181E529F0
	public static void SerializeDelta(Stream stream, WaterWell instance, WaterWell previous) { }

	// RVA: 0x1E52D70 Offset: 0x1E51370 VA: 0x181E52D70
	public static void Serialize(Stream stream, WaterWell instance) { }

	// RVA: 0x1E52E70 Offset: 0x1E51470 VA: 0x181E52E70
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E52E80 Offset: 0x1E51480 VA: 0x181E52E80
	public void ToProto(Stream stream) { }

	// RVA: 0x1E52C60 Offset: 0x1E51260 VA: 0x181E52C60
	public static byte[] SerializeToBytes(WaterWell instance) { }

	// RVA: 0x1E52B70 Offset: 0x1E51170 VA: 0x181E52B70
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

	[BaseEntity.Menu] // RVA: 0x9CBE0 Offset: 0x9BFE0 VA: 0x18009CBE0
	[BaseEntity.Menu.Description] // RVA: 0x9CBE0 Offset: 0x9BFE0 VA: 0x18009CBE0
	[BaseEntity.Menu.Icon] // RVA: 0x9CBE0 Offset: 0x9BFE0 VA: 0x18009CBE0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9CBE0 Offset: 0x9BFE0 VA: 0x18009CBE0
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

