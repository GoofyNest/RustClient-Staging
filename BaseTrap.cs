public class Landmine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6326
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong triggeredID; // 0x18

	// Methods

	// RVA: 0x1F1D780 Offset: 0x1F1BD80 VA: 0x181F1D780
	public static void ResetToPool(Landmine instance) { }

	// RVA: 0x1F1D800 Offset: 0x1F1BE00 VA: 0x181F1D800
	public void ResetToPool() { }

	// RVA: 0x1F1D650 Offset: 0x1F1BC50 VA: 0x181F1D650 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F1CCB0 Offset: 0x1F1B2B0 VA: 0x181F1CCB0
	public void CopyTo(Landmine instance) { }

	// RVA: 0x1F1CCD0 Offset: 0x1F1B2D0 VA: 0x181F1CCD0
	public Landmine Copy() { }

	// RVA: 0x1F1D270 Offset: 0x1F1B870 VA: 0x181F1D270
	public static Landmine Deserialize(Stream stream) { }

	// RVA: 0x1F1CF60 Offset: 0x1F1B560 VA: 0x181F1CF60
	public static Landmine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F1CFE0 Offset: 0x1F1B5E0 VA: 0x181F1CFE0
	public static Landmine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F1D530 Offset: 0x1F1BB30 VA: 0x181F1D530
	public static Landmine Deserialize(byte[] buffer) { }

	// RVA: 0x1F1D740 Offset: 0x1F1BD40 VA: 0x181F1D740
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F1DCD0 Offset: 0x1F1C2D0 VA: 0x181F1DCD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F1DDA0 Offset: 0x1F1C3A0 VA: 0x181F1DDA0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Landmine previous) { }

	// RVA: 0x1F1D760 Offset: 0x1F1BD60 VA: 0x181F1D760 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F1D430 Offset: 0x1F1BA30 VA: 0x181F1D430
	public static Landmine Deserialize(byte[] buffer, Landmine instance, bool isDelta = False) { }

	// RVA: 0x1F1D2F0 Offset: 0x1F1B8F0 VA: 0x181F1D2F0
	public static Landmine Deserialize(Stream stream, Landmine instance, bool isDelta) { }

	// RVA: 0x1F1CD40 Offset: 0x1F1B340 VA: 0x181F1CD40
	public static Landmine DeserializeLengthDelimited(Stream stream, Landmine instance, bool isDelta) { }

	// RVA: 0x1F1D070 Offset: 0x1F1B670 VA: 0x181F1D070
	public static Landmine DeserializeLength(Stream stream, int length, Landmine instance, bool isDelta) { }

	// RVA: 0x1F1D880 Offset: 0x1F1BE80 VA: 0x181F1D880
	public static void SerializeDelta(Stream stream, Landmine instance, Landmine previous) { }

	// RVA: 0x1F1DBF0 Offset: 0x1F1C1F0 VA: 0x181F1DBF0
	public static void Serialize(Stream stream, Landmine instance) { }

	// RVA: 0x1F1DCC0 Offset: 0x1F1C2C0 VA: 0x181F1DCC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F1DCD0 Offset: 0x1F1C2D0 VA: 0x181F1DCD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F1DA40 Offset: 0x1F1C040 VA: 0x181F1DA40
	public static byte[] SerializeToBytes(Landmine instance) { }

	// RVA: 0x1F1D990 Offset: 0x1F1BF90 VA: 0x181F1D990
	public static void SerializeLengthDelimited(Stream stream, Landmine instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class BearTrap : BaseTrap // TypeDefIndex: 8362
{	// Fields
	private Option __menuOption_Arm_Beartrap; // 0x258
	protected Animator animator; // 0x2B0
	private bool initialized; // 0x2B8

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x50DB40 Offset: 0x50C140 VA: 0x18050DB40 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x50E070 Offset: 0x50C670 VA: 0x18050E070 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x50DF70 Offset: 0x50C570 VA: 0x18050DF70 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4F6310 Offset: 0x4F4910 VA: 0x1804F6310
	public bool Armed() { }

	// RVA: 0x50DE40 Offset: 0x50C440 VA: 0x18050DE40 Slot: 28
	public override void InitShared() { }

	// RVA: 0x50DA20 Offset: 0x50C020 VA: 0x18050DA20 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCD8A0 Offset: 0xCCCA0 VA: 0x1800CD8A0
	[BaseEntity.Menu.Description] // RVA: 0xCD8A0 Offset: 0xCCCA0 VA: 0x1800CD8A0
	[BaseEntity.Menu.Icon] // RVA: 0xCD8A0 Offset: 0xCCCA0 VA: 0x1800CD8A0
	[BaseEntity.Menu.ShowIf] // RVA: 0xCD8A0 Offset: 0xCCCA0 VA: 0x1800CD8A0
	// RVA: 0x50D9E0 Offset: 0x50BFE0 VA: 0x18050D9E0
	public void Arm_Beartrap(BasePlayer player) { }

	// RVA: 0x50DF50 Offset: 0x50C550 VA: 0x18050DF50
	public bool Menu_Arm_ShowIf(BasePlayer player) { }

	// RVA: 0x50DA80 Offset: 0x50C080 VA: 0x18050DA80 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x50DEA0 Offset: 0x50C4A0 VA: 0x18050DEA0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x50E060 Offset: 0x50C660 VA: 0x18050E060
	public void .ctor() { }

}

public class Landmine : BaseTrap // TypeDefIndex: 8402
{	// Fields
	private Option __menuOption_Arm_Landmine; // 0x258
	public GameObjectRef explosionEffect; // 0x2B0
	public GameObjectRef triggeredEffect; // 0x2B8
	public float minExplosionRadius; // 0x2C0
	public float explosionRadius; // 0x2C4
	public bool blocked; // 0x2C8
	private ulong triggerPlayerID; // 0x2D0
	public List<DamageTypeEntry> damageTypes; // 0x2D8

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x686A60 Offset: 0x685060 VA: 0x180686A60 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x687100 Offset: 0x685700 VA: 0x180687100 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x686F90 Offset: 0x685590 VA: 0x180686F90 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x687080 Offset: 0x685680 VA: 0x180687080
	public bool Triggered() { }

	// RVA: 0x4F6310 Offset: 0x4F4910 VA: 0x1804F6310
	public bool Armed() { }

	// RVA: 0x686DB0 Offset: 0x6853B0 VA: 0x180686DB0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xE9F40 Offset: 0xE9340 VA: 0x1800E9F40
	[BaseEntity.Menu.Description] // RVA: 0xE9F40 Offset: 0xE9340 VA: 0x1800E9F40
	[BaseEntity.Menu.Icon] // RVA: 0xE9F40 Offset: 0xE9340 VA: 0x1800E9F40
	[BaseEntity.Menu.ShowIf] // RVA: 0xE9F40 Offset: 0xE9340 VA: 0x1800E9F40
	// RVA: 0x686A20 Offset: 0x685020 VA: 0x180686A20
	public void Arm_Landmine(BasePlayer player) { }

	// RVA: 0x686F20 Offset: 0x685520 VA: 0x180686F20
	public bool Menu_Disarm_ShowIf(BasePlayer player) { }

	// RVA: 0x687090 Offset: 0x685690 VA: 0x180687090
	public void .ctor() { }

}

public class GunTrap : StorageContainer // TypeDefIndex: 8572
{	// Fields
	public GameObjectRef gun_fire_effect; // 0x3D0
	public GameObjectRef bulletEffect; // 0x3D8
	public GameObjectRef triggeredEffect; // 0x3E0
	public Transform muzzlePos; // 0x3E8
	public Transform eyeTransform; // 0x3F0
	public int numPellets; // 0x3F8
	public int aimCone; // 0x3FC
	public float sensorRadius; // 0x400
	public ItemDefinition ammoType; // 0x408
	public TargetTrigger trigger; // 0x410

	// Methods

	// RVA: 0x731D30 Offset: 0x730330 VA: 0x180731D30 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x731CC0 Offset: 0x7302C0 VA: 0x180731CC0 Slot: 122
	public override string Categorize() { }

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60
	public bool IsTriggered() { }

	// RVA: 0x731CF0 Offset: 0x7302F0 VA: 0x180731CF0
	public Vector3 GetEyePosition() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x731930 Offset: 0x72FF30 VA: 0x180731930
	public void CLIENT_FireGun(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x732180 Offset: 0x730780 VA: 0x180732180
	public void .ctor() { }

}

public static class GunTrap.GunTrapFlags // TypeDefIndex: 8573
{	// Fields
	public const BaseEntity.Flags Triggered = 128;

}

public class BaseTrap : DecayEntity // TypeDefIndex: 9685
{	// Methods

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x932030 Offset: 0x930630 VA: 0x180932030
	public void .ctor() { }

}

public class BaseTrapTrigger : TriggerBase // TypeDefIndex: 9686
{	// Fields
	public BaseTrap _trap; // 0x30

	// Methods

	// RVA: 0x4D38B0 Offset: 0x4D1EB0 VA: 0x1804D38B0
	public void .ctor() { }

}

public class BearTrapTrigger : BaseTrapTrigger // TypeDefIndex: 9687
{	// Methods

	// RVA: 0x50D9D0 Offset: 0x50BFD0 VA: 0x18050D9D0
	public void .ctor() { }

}

public class SurvivalFishTrap : WildlifeTrap // TypeDefIndex: 9688
{	// Methods

	// RVA: 0x7A6540 Offset: 0x7A4B40 VA: 0x1807A6540 Slot: 155
	public override void TrappedEffect() { }

	// RVA: 0x7A6770 Offset: 0x7A4D70 VA: 0x1807A6770
	public void .ctor() { }

}

public class TrappableWildlife : ScriptableObject // TypeDefIndex: 9689
{	// Fields
	public GameObjectRef worldObject; // 0x18
	public ItemDefinition inventoryObject; // 0x20
	public int minToCatch; // 0x28
	public int maxToCatch; // 0x2C
	public List<TrappableWildlife.BaitType> baitTypes; // 0x30
	public int caloriesForInterest; // 0x38
	public float successRate; // 0x3C
	public float xpScale; // 0x40

	// Methods

	// RVA: 0xA17D30 Offset: 0xA16330 VA: 0x180A17D30
	public void .ctor() { }

}

public class TrappableWildlife.BaitType // TypeDefIndex: 9690
{	// Fields
	public float successRate; // 0x10
	public ItemDefinition bait; // 0x18
	public int minForInterest; // 0x20
	public int maxToConsume; // 0x24

	// Methods

	// RVA: 0xA08520 Offset: 0xA06B20 VA: 0x180A08520
	public void .ctor() { }

}

public class WildlifeTrap : StorageContainer // TypeDefIndex: 9691
{	// Fields
	public float tickRate; // 0x3D0
	public GameObjectRef trappedEffect; // 0x3D8
	public float trappedEffectRepeatRate; // 0x3E0
	public float trapSuccessRate; // 0x3E4
	public List<ItemDefinition> ignoreBait; // 0x3E8
	public List<WildlifeTrap.WildlifeWeight> targetWildlife; // 0x3F0
	protected float nextEffectTime; // 0x3F8

	// Methods

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60
	public bool HasCatch() { }

	// RVA: 0x4F6310 Offset: 0x4F4910 VA: 0x1804F6310
	public bool IsTrapActive() { }

	// RVA: 0x8F6150 Offset: 0x8F4750 VA: 0x1808F6150 Slot: 27
	public override void ResetState() { }

	// RVA: 0x8F6310 Offset: 0x8F4910 VA: 0x1808F6310
	public void Update() { }

	// RVA: 0x8F6180 Offset: 0x8F4780 VA: 0x1808F6180 Slot: 155
	public virtual void TrappedEffect() { }

	// RVA: 0x8F6350 Offset: 0x8F4950 VA: 0x1808F6350
	public void .ctor() { }

}

public static class WildlifeTrap.WildlifeTrapFlags // TypeDefIndex: 9692
{	// Fields
	public const BaseEntity.Flags Occupied = 128;

}

public class WildlifeTrap.WildlifeWeight // TypeDefIndex: 9693
{	// Fields
	public TrappableWildlife wildlife; // 0x10
	public int weight; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class Bootstrap : SingletonComponent<Bootstrap> // TypeDefIndex: 9820
{	// Fields
	internal static bool bootstrapInitRun; // 0x0
	public static bool isErrored; // 0x1
	public string messageString; // 0x18
	public CanvasGroup BootstrapUiCanvas; // 0x20
	public GameObject errorPanel; // 0x28
	public TextMeshProUGUI errorText; // 0x30
	public TextMeshProUGUI statusText; // 0x38
	private TimeSince timeSinceVisible; // 0x40
	private static GameObject _engineUi; // 0x8
	private static GameObject _gameUi; // 0x10
	private static GameObject _menuUi; // 0x18
	private static string lastWrittenValue; // 0x20

	// Properties
	public static bool needsSetup { get; }
	public static bool isPresent { get; }

	// Methods

	// RVA: 0x51BA10 Offset: 0x51A010 VA: 0x18051BA10
	public static bool get_needsSetup() { }

	// RVA: 0x51B970 Offset: 0x519F70 VA: 0x18051B970
	public static bool get_isPresent() { }

	// RVA: 0x51B180 Offset: 0x519780 VA: 0x18051B180
	public static void RunDefaults() { }

	// RVA: 0x51A580 Offset: 0x518B80 VA: 0x18051A580
	public static void Init_Tier0() { }

	// RVA: 0x51A090 Offset: 0x518690 VA: 0x18051A090
	public static void Init_Systems() { }

	// RVA: 0x519F50 Offset: 0x518550 VA: 0x180519F50
	public static void Init_Config() { }

	// RVA: 0x51B0E0 Offset: 0x5196E0 VA: 0x18051B0E0
	public static void NetworkInitRaknet() { }

	// RVA: 0x51B130 Offset: 0x519730 VA: 0x18051B130
	public static void NetworkInitSteamworks(bool enableSteamDatagramRelay) { }

	[IteratorStateMachineAttribute] // RVA: 0x99F30 Offset: 0x99330 VA: 0x180099F30
	// RVA: 0x51B5E0 Offset: 0x519BE0 VA: 0x18051B5E0
	private IEnumerator Start() { }

	// RVA: 0x51AEF0 Offset: 0x5194F0 VA: 0x18051AEF0
	public static GameObject LoadEngineUI() { }

	// RVA: 0x51AF70 Offset: 0x519570 VA: 0x18051AF70
	public static GameObject LoadGameUI() { }

	// RVA: 0x51AFF0 Offset: 0x5195F0 VA: 0x18051AFF0
	public static GameObject LoadMenuUI() { }

	// RVA: 0x51ADB0 Offset: 0x5193B0 VA: 0x18051ADB0
	private static GameObject InstantiatePrefabPersistent(string path) { }

	// RVA: 0x51B740 Offset: 0x519D40 VA: 0x18051B740
	public static void ToggleUIHack() { }

	// RVA: 0x51B2D0 Offset: 0x5198D0 VA: 0x18051B2D0
	public static void SetUIVisible(bool visible) { }

	[IteratorStateMachineAttribute] // RVA: 0x9A170 Offset: 0x99570 VA: 0x18009A170
	// RVA: 0x519E60 Offset: 0x518460 VA: 0x180519E60
	private IEnumerator ClientStartup() { }

	// RVA: 0x51B7A0 Offset: 0x519DA0 VA: 0x18051B7A0
	protected void Update() { }

	// RVA: 0x51B650 Offset: 0x519C50 VA: 0x18051B650
	private void StartupShared() { }

	// RVA: 0x51B660 Offset: 0x519C60 VA: 0x18051B660
	public void ThrowError(string error) { }

	// RVA: 0x519ED0 Offset: 0x5184D0 VA: 0x180519ED0
	public void ExitGame() { }

	[IteratorStateMachineAttribute] // RVA: 0x9A550 Offset: 0x99950 VA: 0x18009A550
	// RVA: 0x51B070 Offset: 0x519670 VA: 0x18051B070
	public static IEnumerator LoadingUpdate(string str) { }

	// RVA: 0x51B820 Offset: 0x519E20 VA: 0x18051B820
	public static void WriteToLog(string str) { }

	// RVA: 0x51B900 Offset: 0x519F00 VA: 0x18051B900
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

private sealed class Bootstrap.<>c // TypeDefIndex: 9821
{	// Fields
	public static readonly Bootstrap.<>c <>9; // 0x0
	public static Func<string, GameObject> <>9__13_0; // 0x8
	public static Action <>9__13_1; // 0x10
	public static Func<bool> <>9__13_2; // 0x18
	public static Func<int> <>9__14_0; // 0x20

	// Methods

	// RVA: 0x529330 Offset: 0x527930 VA: 0x180529330
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x529130 Offset: 0x527730 VA: 0x180529130
	internal GameObject <Init_Tier0>b__13_0(string str) { }

	// RVA: 0x5291B0 Offset: 0x5277B0 VA: 0x1805291B0
	internal void <Init_Tier0>b__13_1() { }

	// RVA: 0x5291C0 Offset: 0x5277C0 VA: 0x1805291C0
	internal bool <Init_Tier0>b__13_2() { }

	// RVA: 0x5290E0 Offset: 0x5276E0 VA: 0x1805290E0
	internal int <Init_Systems>b__14_0() { }

}

private sealed class Bootstrap.<Start>d__18 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9822
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Bootstrap <>4__this; // 0x20
	private BenchmarkTimer <timer>5__2; // 0x28
	private AssetBundleBackend <newBackend>5__3; // 0x30
	private BenchmarkTimer <>7__wrap3; // 0x38

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x528E30 Offset: 0x527430 VA: 0x180528E30 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x527B80 Offset: 0x526180 VA: 0x180527B80 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x528FF0 Offset: 0x5275F0 VA: 0x180528FF0
	private void <>m__Finally1() { }

	// RVA: 0x529040 Offset: 0x527640 VA: 0x180529040
	private void <>m__Finally2() { }

	// RVA: 0x529090 Offset: 0x527690 VA: 0x180529090
	private void <>m__Finally3() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x528DE0 Offset: 0x5273E0 VA: 0x180528DE0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class Bootstrap.<ClientStartup>d__28 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9823
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Bootstrap <>4__this; // 0x20
	private BenchmarkTimer <>7__wrap1; // 0x28
	private AsyncOperation <op>5__3; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x524C90 Offset: 0x523290 VA: 0x180524C90 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x523310 Offset: 0x521910 VA: 0x180523310 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x524E50 Offset: 0x523450 VA: 0x180524E50
	private void <>m__Finally1() { }

	// RVA: 0x524EA0 Offset: 0x5234A0 VA: 0x180524EA0
	private void <>m__Finally2() { }

	// RVA: 0x524EF0 Offset: 0x5234F0 VA: 0x180524EF0
	private void <>m__Finally3() { }

	// RVA: 0x524F40 Offset: 0x523540 VA: 0x180524F40
	private void <>m__Finally4() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x524C40 Offset: 0x523240 VA: 0x180524C40 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class Bootstrap.<LoadingUpdate>d__33 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9824
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string str; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x524F90 Offset: 0x523590 VA: 0x180524F90 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x525140 Offset: 0x523740 VA: 0x180525140 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

