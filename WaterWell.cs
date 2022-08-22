public class WaterWell : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6343
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float pressure; // 0x14
	public float waterLevel; // 0x18

	// Methods

	// RVA: 0x1E533D0 Offset: 0x1E519D0 VA: 0x181E533D0
	public static void ResetToPool(WaterWell instance) { }

	// RVA: 0x1E53450 Offset: 0x1E51A50 VA: 0x181E53450
	public void ResetToPool() { }

	// RVA: 0x1E53290 Offset: 0x1E51890 VA: 0x181E53290 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBF390 Offset: 0x1DBD990 VA: 0x181DBF390
	public void CopyTo(WaterWell instance) { }

	// RVA: 0x1E524B0 Offset: 0x1E50AB0 VA: 0x181E524B0
	public WaterWell Copy() { }

	// RVA: 0x1E52D30 Offset: 0x1E51330 VA: 0x181E52D30
	public static WaterWell Deserialize(Stream stream) { }

	// RVA: 0x1E52520 Offset: 0x1E50B20 VA: 0x181E52520
	public static WaterWell DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E52930 Offset: 0x1E50F30 VA: 0x181E52930
	public static WaterWell DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E53170 Offset: 0x1E51770 VA: 0x181E53170
	public static WaterWell Deserialize(byte[] buffer) { }

	// RVA: 0x1E53390 Offset: 0x1E51990 VA: 0x181E53390
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E53960 Offset: 0x1E51F60 VA: 0x181E53960 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E53980 Offset: 0x1E51F80 VA: 0x181E53980 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, WaterWell previous) { }

	// RVA: 0x1E533B0 Offset: 0x1E519B0 VA: 0x181E533B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E53070 Offset: 0x1E51670 VA: 0x181E53070
	public static WaterWell Deserialize(byte[] buffer, WaterWell instance, bool isDelta = False) { }

	// RVA: 0x1E52DB0 Offset: 0x1E513B0 VA: 0x181E52DB0
	public static WaterWell Deserialize(Stream stream, WaterWell instance, bool isDelta) { }

	// RVA: 0x1E525A0 Offset: 0x1E50BA0 VA: 0x181E525A0
	public static WaterWell DeserializeLengthDelimited(Stream stream, WaterWell instance, bool isDelta) { }

	// RVA: 0x1E529C0 Offset: 0x1E50FC0 VA: 0x181E529C0
	public static WaterWell DeserializeLength(Stream stream, int length, WaterWell instance, bool isDelta) { }

	// RVA: 0x1E534D0 Offset: 0x1E51AD0 VA: 0x181E534D0
	public static void SerializeDelta(Stream stream, WaterWell instance, WaterWell previous) { }

	// RVA: 0x1E53850 Offset: 0x1E51E50 VA: 0x181E53850
	public static void Serialize(Stream stream, WaterWell instance) { }

	// RVA: 0x1E53950 Offset: 0x1E51F50 VA: 0x181E53950
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E53960 Offset: 0x1E51F60 VA: 0x181E53960
	public void ToProto(Stream stream) { }

	// RVA: 0x1E53740 Offset: 0x1E51D40 VA: 0x181E53740
	public static byte[] SerializeToBytes(WaterWell instance) { }

	// RVA: 0x1E53650 Offset: 0x1E51C50 VA: 0x181E53650
	public static void SerializeLengthDelimited(Stream stream, WaterWell instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x8F0E60 Offset: 0x8EF460 VA: 0x1808F0E60 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x8F1830 Offset: 0x8EFE30 VA: 0x1808F1830 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x8F13D0 Offset: 0x8EF9D0 VA: 0x1808F13D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x8F11A0 Offset: 0x8EF7A0 VA: 0x1808F11A0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x8F1170 Offset: 0x8EF770 VA: 0x1808F1170
	public float GetWaterAmount() { }

	[BaseEntity.Menu] // RVA: 0x9CBE0 Offset: 0x9BFE0 VA: 0x18009CBE0
	[BaseEntity.Menu.Description] // RVA: 0x9CBE0 Offset: 0x9BFE0 VA: 0x18009CBE0
	[BaseEntity.Menu.Icon] // RVA: 0x9CBE0 Offset: 0x9BFE0 VA: 0x18009CBE0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9CBE0 Offset: 0x9BFE0 VA: 0x18009CBE0
	// RVA: 0x8F1390 Offset: 0x8EF990 VA: 0x1808F1390
	public void Menu_Pump(BasePlayer player) { }

	// RVA: 0x8F1200 Offset: 0x8EF800 VA: 0x1808F1200
	public bool Menu_Pump_ShowIf(BasePlayer player) { }

	// RVA: 0x8F14C0 Offset: 0x8EFAC0 VA: 0x1808F14C0 Slot: 164
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x8F0E00 Offset: 0x8EF400 VA: 0x1808F0E00 Slot: 168
	public override bool DrinkEligable(BasePlayer player) { }

	// RVA: 0x8F1620 Offset: 0x8EFC20 VA: 0x1808F1620
	public void Update() { }

	// RVA: 0x8F1800 Offset: 0x8EFE00 VA: 0x1808F1800
	public void .ctor() { }

}

