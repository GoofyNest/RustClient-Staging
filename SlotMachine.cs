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

	// RVA: 0x1DB0D90 Offset: 0x1DAF390 VA: 0x181DB0D90
	public static void ResetToPool(SlotMachine instance) { }

	// RVA: 0x1DB0E90 Offset: 0x1DAF490 VA: 0x181DB0E90
	public void ResetToPool() { }

	// RVA: 0x1DB0840 Offset: 0x1DAEE40 VA: 0x181DB0840 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DAEC60 Offset: 0x1DAD260 VA: 0x181DAEC60
	public void CopyTo(SlotMachine instance) { }

	// RVA: 0x1DAECC0 Offset: 0x1DAD2C0 VA: 0x181DAECC0
	public SlotMachine Copy() { }

	// RVA: 0x1DAFC20 Offset: 0x1DAE220 VA: 0x181DAFC20
	public static SlotMachine Deserialize(Stream stream) { }

	// RVA: 0x1DAED70 Offset: 0x1DAD370 VA: 0x181DAED70
	public static SlotMachine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DAF270 Offset: 0x1DAD870 VA: 0x181DAF270
	public static SlotMachine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DAF760 Offset: 0x1DADD60 VA: 0x181DAF760
	public static SlotMachine Deserialize(byte[] buffer) { }

	// RVA: 0x1DB09D0 Offset: 0x1DAEFD0 VA: 0x181DB09D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB1790 Offset: 0x1DAFD90 VA: 0x181DB1790 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB17B0 Offset: 0x1DAFDB0 VA: 0x181DB17B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SlotMachine previous) { }

	// RVA: 0x1DB0D70 Offset: 0x1DAF370 VA: 0x181DB0D70 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB0000 Offset: 0x1DAE600 VA: 0x181DB0000
	public static SlotMachine Deserialize(byte[] buffer, SlotMachine instance, bool isDelta = False) { }

	// RVA: 0x1DB04A0 Offset: 0x1DAEAA0 VA: 0x181DB04A0
	public static SlotMachine Deserialize(Stream stream, SlotMachine instance, bool isDelta) { }

	// RVA: 0x1DAEDF0 Offset: 0x1DAD3F0 VA: 0x181DAEDF0
	public static SlotMachine DeserializeLengthDelimited(Stream stream, SlotMachine instance, bool isDelta) { }

	// RVA: 0x1DAF300 Offset: 0x1DAD900 VA: 0x181DAF300
	public static SlotMachine DeserializeLength(Stream stream, int length, SlotMachine instance, bool isDelta) { }

	// RVA: 0x1DB0F90 Offset: 0x1DAF590 VA: 0x181DB0F90
	public static void SerializeDelta(Stream stream, SlotMachine instance, SlotMachine previous) { }

	// RVA: 0x1DB1560 Offset: 0x1DAFB60 VA: 0x181DB1560
	public static void Serialize(Stream stream, SlotMachine instance) { }

	// RVA: 0x1DB1780 Offset: 0x1DAFD80 VA: 0x181DB1780
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB1790 Offset: 0x1DAFD90 VA: 0x181DB1790
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB1450 Offset: 0x1DAFA50 VA: 0x181DB1450
	public static byte[] SerializeToBytes(SlotMachine instance) { }

	// RVA: 0x1DB13A0 Offset: 0x1DAF9A0 VA: 0x181DB13A0
	public static void SerializeLengthDelimited(Stream stream, SlotMachine instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class SlotMachine : BaseMountable // TypeDefIndex: 8447
{	// Fields
	private Option __menuOption_Menu_Deposit; // 0x320
	private Option __menuOption_Menu_Spin; // 0x378
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int ForcePayoutIndex; // 0x0
	[HeaderAttribute] // RVA: 0x85A30 Offset: 0x84E30 VA: 0x180085A30
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
	[ColorUsageAttribute] // RVA: 0x85AC0 Offset: 0x84EC0 VA: 0x180085AC0
	public Color PulseFrom; // 0x474
	[ColorUsageAttribute] // RVA: 0x85AC0 Offset: 0x84EC0 VA: 0x180085AC0
	public Color PulseTo; // 0x484
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <CurrentMultiplier>k__BackingField; // 0x494
	private TimeSince lastWin; // 0x498
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x5ACD30 Offset: 0x5AB330 VA: 0x1805ACD30 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x5AE8F0 Offset: 0x5ACEF0 VA: 0x1805AE8F0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x5AD5E0 Offset: 0x5ABBE0 VA: 0x1805AD5E0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5799C0 Offset: 0x577FC0 VA: 0x1805799C0
	private bool get_IsSpinning() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5AE8E0 Offset: 0x5ACEE0 VA: 0x1805AE8E0
	public int get_CurrentMultiplier() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5AEB50 Offset: 0x5AD150 VA: 0x1805AEB50
	private void set_CurrentMultiplier(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5AEA90 Offset: 0x5AD090 VA: 0x1805AEA90
	public static Material get_instancedSpriteMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5AEB60 Offset: 0x5AD160 VA: 0x1805AEB60
	private static void set_instancedSpriteMaterial(Material value) { }

	// RVA: 0x5559F0 Offset: 0x553FF0 VA: 0x1805559F0 Slot: 65
	protected override bool HideMenuItems(BasePlayer player) { }

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60
	private bool CanSpin() { }

	[BaseEntity.Menu] // RVA: 0x86010 Offset: 0x85410 VA: 0x180086010
	[BaseEntity.Menu.Description] // RVA: 0x86010 Offset: 0x85410 VA: 0x180086010
	[BaseEntity.Menu.Icon] // RVA: 0x86010 Offset: 0x85410 VA: 0x180086010
	[BaseEntity.Menu.ShowIf] // RVA: 0x86010 Offset: 0x85410 VA: 0x180086010
	// RVA: 0x5AD5A0 Offset: 0x5ABBA0 VA: 0x1805AD5A0
	public void Menu_Spin(BasePlayer player) { }

	// RVA: 0x5AD540 Offset: 0x5ABB40 VA: 0x1805AD540
	public bool Menu_Spin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x862C0 Offset: 0x856C0 VA: 0x1800862C0
	[BaseEntity.Menu.Description] // RVA: 0x862C0 Offset: 0x856C0 VA: 0x1800862C0
	[BaseEntity.Menu.Icon] // RVA: 0x862C0 Offset: 0x856C0 VA: 0x1800862C0
	[BaseEntity.Menu.ShowIf] // RVA: 0x862C0 Offset: 0x856C0 VA: 0x1800862C0
	// RVA: 0x5AD500 Offset: 0x5ABB00 VA: 0x1805AD500
	public void Menu_Deposit(BasePlayer player) { }

	// RVA: 0x5AD4C0 Offset: 0x5ABAC0 VA: 0x1805AD4C0
	public bool Menu_Deposit_ShowIf(BasePlayer player) { }

	// RVA: 0x5AC9D0 Offset: 0x5AAFD0 VA: 0x1805AC9D0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x5AE6A0 Offset: 0x5ACCA0 VA: 0x1805AE6A0
	private void UpdateSpriteMaterial() { }

	// RVA: 0x5ADF00 Offset: 0x5AC500 VA: 0x1805ADF00
	private void UpdatePulse() { }

	// RVA: 0x5ADC90 Offset: 0x5AC290 VA: 0x1805ADC90
	private void StartPulse(float duration) { }

	// RVA: 0x5AC8F0 Offset: 0x5AAEF0 VA: 0x1805AC8F0
	private static float CalculateReelAngle(int oldResult, int newResult, int numSpins, int maxNumSpins, float timeSinceSpin, float maxTime) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5ADA30 Offset: 0x5AC030 VA: 0x1805ADA30
	private void RPC_OnSpin(BaseEntity.RPCMessage msg) { }

	// RVA: 0x5AE110 Offset: 0x5AC710 VA: 0x1805AE110
	private void UpdateSpinVisualsInvoke() { }

	// RVA: 0x5AE120 Offset: 0x5AC720 VA: 0x1805AE120
	private void UpdateSpinVisuals(bool force = False) { }

	// RVA: 0x5AD2E0 Offset: 0x5AB8E0 VA: 0x1805AD2E0 Slot: 175
	public override Quaternion GetMountedRotation() { }

	// RVA: 0x5ADC30 Offset: 0x5AC230 VA: 0x1805ADC30
	public void RequestMultiplierChange(int newMultiplier) { }

	// RVA: 0x5ADE00 Offset: 0x5AC400 VA: 0x1805ADE00 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x5AD320 Offset: 0x5AB920 VA: 0x1805AD320 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5AC6A0 Offset: 0x5AACA0 VA: 0x1805AC6A0
	private bool CalculatePayout(out SlotMachinePayoutSettings.PayoutInfo info, out int bonus) { }

	// RVA: 0x5AE840 Offset: 0x5ACE40 VA: 0x1805AE840
	public void .ctor() { }

	// RVA: 0x5AE7C0 Offset: 0x5ACDC0 VA: 0x1805AE7C0
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

