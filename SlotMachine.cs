public class SlotMachine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6406
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int oldResult1; // 0x14
	public int oldResult2; // 0x18
	public int oldResult3; // 0x1C
	public int newResult1; // 0x20
	public int newResult2; // 0x24
	public int newResult3; // 0x28
	public bool isSpinning; // 0x2C
	public float spinTime; // 0x30
	public uint storageID; // 0x34
	public int multiplier; // 0x38

	// Methods

	// RVA: 0x1DB1680 Offset: 0x1DAFC80 VA: 0x181DB1680
	public static void ResetToPool(SlotMachine instance) { }

	// RVA: 0x1DB1780 Offset: 0x1DAFD80 VA: 0x181DB1780
	public void ResetToPool() { }

	// RVA: 0x1DB1130 Offset: 0x1DAF730 VA: 0x181DB1130 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DAF550 Offset: 0x1DADB50 VA: 0x181DAF550
	public void CopyTo(SlotMachine instance) { }

	// RVA: 0x1DAF5B0 Offset: 0x1DADBB0 VA: 0x181DAF5B0
	public SlotMachine Copy() { }

	// RVA: 0x1DB0510 Offset: 0x1DAEB10 VA: 0x181DB0510
	public static SlotMachine Deserialize(Stream stream) { }

	// RVA: 0x1DAF660 Offset: 0x1DADC60 VA: 0x181DAF660
	public static SlotMachine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DAFB60 Offset: 0x1DAE160 VA: 0x181DAFB60
	public static SlotMachine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DB0050 Offset: 0x1DAE650 VA: 0x181DB0050
	public static SlotMachine Deserialize(byte[] buffer) { }

	// RVA: 0x1DB12C0 Offset: 0x1DAF8C0 VA: 0x181DB12C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB2080 Offset: 0x1DB0680 VA: 0x181DB2080 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB20A0 Offset: 0x1DB06A0 VA: 0x181DB20A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SlotMachine previous) { }

	// RVA: 0x1DB1660 Offset: 0x1DAFC60 VA: 0x181DB1660 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB08F0 Offset: 0x1DAEEF0 VA: 0x181DB08F0
	public static SlotMachine Deserialize(byte[] buffer, SlotMachine instance, bool isDelta = False) { }

	// RVA: 0x1DB0D90 Offset: 0x1DAF390 VA: 0x181DB0D90
	public static SlotMachine Deserialize(Stream stream, SlotMachine instance, bool isDelta) { }

	// RVA: 0x1DAF6E0 Offset: 0x1DADCE0 VA: 0x181DAF6E0
	public static SlotMachine DeserializeLengthDelimited(Stream stream, SlotMachine instance, bool isDelta) { }

	// RVA: 0x1DAFBF0 Offset: 0x1DAE1F0 VA: 0x181DAFBF0
	public static SlotMachine DeserializeLength(Stream stream, int length, SlotMachine instance, bool isDelta) { }

	// RVA: 0x1DB1880 Offset: 0x1DAFE80 VA: 0x181DB1880
	public static void SerializeDelta(Stream stream, SlotMachine instance, SlotMachine previous) { }

	// RVA: 0x1DB1E50 Offset: 0x1DB0450 VA: 0x181DB1E50
	public static void Serialize(Stream stream, SlotMachine instance) { }

	// RVA: 0x1DB2070 Offset: 0x1DB0670 VA: 0x181DB2070
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB2080 Offset: 0x1DB0680 VA: 0x181DB2080
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB1D40 Offset: 0x1DB0340 VA: 0x181DB1D40
	public static byte[] SerializeToBytes(SlotMachine instance) { }

	// RVA: 0x1DB1C90 Offset: 0x1DB0290 VA: 0x181DB1C90
	public static void SerializeLengthDelimited(Stream stream, SlotMachine instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class SlotMachine : BaseMountable // TypeDefIndex: 8447
{	// Fields
	private Option __menuOption_Menu_Deposit; // 0x320
	private Option __menuOption_Menu_Spin; // 0x378
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int ForcePayoutIndex; // 0x0
	[HeaderAttribute] // RVA: 0x85AD0 Offset: 0x84ED0 VA: 0x180085AD0
	public Transform Reel1; // 0x3D0
	public Transform Reel2; // 0x3D8
	public Transform Reel3; // 0x3E0
	public Transform Arm; // 0x3E8
	public AnimationCurve Curve; // 0x3F0
	public int Reel1Spins; // 0x3F8
	public int Reel2Spins; // 0x3FC
	public int Reel3Spins; // 0x400
	public int MaxReelSpins; // 0x404
	public float SpinDuration; // 0x408
	private int SpinResult1; // 0x40C
	private int SpinResult2; // 0x410
	private int SpinResult3; // 0x414
	private int SpinResultPrevious1; // 0x418
	private int SpinResultPrevious2; // 0x41C
	private int SpinResultPrevious3; // 0x420
	private float SpinTime; // 0x424
	public GameObjectRef StoragePrefab; // 0x428
	public EntityRef StorageInstance; // 0x430
	public SoundDefinition SpinSound; // 0x440
	public SlotMachinePayoutDisplay PayoutDisplay; // 0x448
	public SlotMachinePayoutSettings PayoutSettings; // 0x450
	public Transform HandIkTarget; // 0x458
	private const BaseEntity.Flags HasScrapForSpin = 128;
	private const BaseEntity.Flags IsSpinningFlag = 256;
	public Material PayoutIconMaterial; // 0x460
	public MeshRenderer[] PulseRenderers; // 0x468
	public float PulseSpeed; // 0x470
	[ColorUsageAttribute] // RVA: 0x85B30 Offset: 0x84F30 VA: 0x180085B30
	public Color PulseFrom; // 0x474
	[ColorUsageAttribute] // RVA: 0x85B30 Offset: 0x84F30 VA: 0x180085B30
	public Color PulseTo; // 0x484
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <CurrentMultiplier>k__BackingField; // 0x494
	private TimeSince lastWin; // 0x498
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Material <instancedSpriteMaterial>k__BackingField; // 0x8
	private Material instancedPulseMaterial; // 0x4A0
	private TimeSince pulseTime; // 0x4A8
	private float pulseFor; // 0x4AC
	private static int emissionId; // 0x10
	private Quaternion InitialArmRotation; // 0x4B0

	// Properties
	public override bool HasMenuOptions { get; }
	private bool IsSpinning { get; }
	public int CurrentMultiplier { get; set; }
	public static Material instancedSpriteMaterial { get; set; }

	// Methods

	// RVA: 0x5ACCC0 Offset: 0x5AB2C0 VA: 0x1805ACCC0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x5AE880 Offset: 0x5ACE80 VA: 0x1805AE880 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x5AD570 Offset: 0x5ABB70 VA: 0x1805AD570 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x579950 Offset: 0x577F50 VA: 0x180579950
	private bool get_IsSpinning() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5AE870 Offset: 0x5ACE70 VA: 0x1805AE870
	public int get_CurrentMultiplier() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5AEAE0 Offset: 0x5AD0E0 VA: 0x1805AEAE0
	private void set_CurrentMultiplier(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5AEA20 Offset: 0x5AD020 VA: 0x1805AEA20
	public static Material get_instancedSpriteMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5AEAF0 Offset: 0x5AD0F0 VA: 0x1805AEAF0
	private static void set_instancedSpriteMaterial(Material value) { }

	// RVA: 0x555980 Offset: 0x553F80 VA: 0x180555980 Slot: 65
	protected override bool HideMenuItems(BasePlayer player) { }

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60
	private bool CanSpin() { }

	[BaseEntity.Menu] // RVA: 0x860F0 Offset: 0x854F0 VA: 0x1800860F0
	[BaseEntity.Menu.Description] // RVA: 0x860F0 Offset: 0x854F0 VA: 0x1800860F0
	[BaseEntity.Menu.Icon] // RVA: 0x860F0 Offset: 0x854F0 VA: 0x1800860F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x860F0 Offset: 0x854F0 VA: 0x1800860F0
	// RVA: 0x5AD530 Offset: 0x5ABB30 VA: 0x1805AD530
	public void Menu_Spin(BasePlayer player) { }

	// RVA: 0x5AD4D0 Offset: 0x5ABAD0 VA: 0x1805AD4D0
	public bool Menu_Spin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x86330 Offset: 0x85730 VA: 0x180086330
	[BaseEntity.Menu.Description] // RVA: 0x86330 Offset: 0x85730 VA: 0x180086330
	[BaseEntity.Menu.Icon] // RVA: 0x86330 Offset: 0x85730 VA: 0x180086330
	[BaseEntity.Menu.ShowIf] // RVA: 0x86330 Offset: 0x85730 VA: 0x180086330
	// RVA: 0x5AD490 Offset: 0x5ABA90 VA: 0x1805AD490
	public void Menu_Deposit(BasePlayer player) { }

	// RVA: 0x5AD450 Offset: 0x5ABA50 VA: 0x1805AD450
	public bool Menu_Deposit_ShowIf(BasePlayer player) { }

	// RVA: 0x5AC960 Offset: 0x5AAF60 VA: 0x1805AC960 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x5AE630 Offset: 0x5ACC30 VA: 0x1805AE630
	private void UpdateSpriteMaterial() { }

	// RVA: 0x5ADE90 Offset: 0x5AC490 VA: 0x1805ADE90
	private void UpdatePulse() { }

	// RVA: 0x5ADC20 Offset: 0x5AC220 VA: 0x1805ADC20
	private void StartPulse(float duration) { }

	// RVA: 0x5AC880 Offset: 0x5AAE80 VA: 0x1805AC880
	private static float CalculateReelAngle(int oldResult, int newResult, int numSpins, int maxNumSpins, float timeSinceSpin, float maxTime) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5AD9C0 Offset: 0x5ABFC0 VA: 0x1805AD9C0
	private void RPC_OnSpin(BaseEntity.RPCMessage msg) { }

	// RVA: 0x5AE0A0 Offset: 0x5AC6A0 VA: 0x1805AE0A0
	private void UpdateSpinVisualsInvoke() { }

	// RVA: 0x5AE0B0 Offset: 0x5AC6B0 VA: 0x1805AE0B0
	private void UpdateSpinVisuals(bool force = False) { }

	// RVA: 0x5AD270 Offset: 0x5AB870 VA: 0x1805AD270 Slot: 175
	public override Quaternion GetMountedRotation() { }

	// RVA: 0x5ADBC0 Offset: 0x5AC1C0 VA: 0x1805ADBC0
	public void RequestMultiplierChange(int newMultiplier) { }

	// RVA: 0x5ADD90 Offset: 0x5AC390 VA: 0x1805ADD90 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x5AD2B0 Offset: 0x5AB8B0 VA: 0x1805AD2B0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5AC630 Offset: 0x5AAC30 VA: 0x1805AC630
	private bool CalculatePayout(out SlotMachinePayoutSettings.PayoutInfo info, out int bonus) { }

	// RVA: 0x5AE7D0 Offset: 0x5ACDD0 VA: 0x1805AE7D0
	public void .ctor() { }

	// RVA: 0x5AE750 Offset: 0x5ACD50 VA: 0x1805AE750
	private static void .cctor() { }

}

public enum SlotMachine.SlotFaces // TypeDefIndex: 8448
{	// Fields
	public int value__; // 0x0
	public const SlotMachine.SlotFaces Scrap = 0;
	public const SlotMachine.SlotFaces Rope = 1;
	public const SlotMachine.SlotFaces Apple = 2;
	public const SlotMachine.SlotFaces LowGrade = 3;
	public const SlotMachine.SlotFaces Wood = 4;
	public const SlotMachine.SlotFaces Bandage = 5;
	public const SlotMachine.SlotFaces Charcoal = 6;
	public const SlotMachine.SlotFaces Gunpowder = 7;
	public const SlotMachine.SlotFaces Rust = 8;
	public const SlotMachine.SlotFaces Meat = 9;
	public const SlotMachine.SlotFaces Hammer = 10;
	public const SlotMachine.SlotFaces Sulfur = 11;
	public const SlotMachine.SlotFaces TechScrap = 12;
	public const SlotMachine.SlotFaces Frags = 13;
	public const SlotMachine.SlotFaces Cloth = 14;
	public const SlotMachine.SlotFaces LuckySeven = 15;

}

