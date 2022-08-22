public class Landmine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6326
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong triggeredID; // 0x18

	// Methods

	// RVA: 0x1F1DFA0 Offset: 0x1F1C5A0 VA: 0x181F1DFA0
	public static void ResetToPool(Landmine instance) { }

	// RVA: 0x1F1E020 Offset: 0x1F1C620 VA: 0x181F1E020
	public void ResetToPool() { }

	// RVA: 0x1F1DE70 Offset: 0x1F1C470 VA: 0x181F1DE70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F1D4D0 Offset: 0x1F1BAD0 VA: 0x181F1D4D0
	public void CopyTo(Landmine instance) { }

	// RVA: 0x1F1D4F0 Offset: 0x1F1BAF0 VA: 0x181F1D4F0
	public Landmine Copy() { }

	// RVA: 0x1F1DA90 Offset: 0x1F1C090 VA: 0x181F1DA90
	public static Landmine Deserialize(Stream stream) { }

	// RVA: 0x1F1D780 Offset: 0x1F1BD80 VA: 0x181F1D780
	public static Landmine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F1D800 Offset: 0x1F1BE00 VA: 0x181F1D800
	public static Landmine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F1DD50 Offset: 0x1F1C350 VA: 0x181F1DD50
	public static Landmine Deserialize(byte[] buffer) { }

	// RVA: 0x1F1DF60 Offset: 0x1F1C560 VA: 0x181F1DF60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F1E4F0 Offset: 0x1F1CAF0 VA: 0x181F1E4F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F1E5C0 Offset: 0x1F1CBC0 VA: 0x181F1E5C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Landmine previous) { }

	// RVA: 0x1F1DF80 Offset: 0x1F1C580 VA: 0x181F1DF80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F1DC50 Offset: 0x1F1C250 VA: 0x181F1DC50
	public static Landmine Deserialize(byte[] buffer, Landmine instance, bool isDelta = False) { }

	// RVA: 0x1F1DB10 Offset: 0x1F1C110 VA: 0x181F1DB10
	public static Landmine Deserialize(Stream stream, Landmine instance, bool isDelta) { }

	// RVA: 0x1F1D560 Offset: 0x1F1BB60 VA: 0x181F1D560
	public static Landmine DeserializeLengthDelimited(Stream stream, Landmine instance, bool isDelta) { }

	// RVA: 0x1F1D890 Offset: 0x1F1BE90 VA: 0x181F1D890
	public static Landmine DeserializeLength(Stream stream, int length, Landmine instance, bool isDelta) { }

	// RVA: 0x1F1E0A0 Offset: 0x1F1C6A0 VA: 0x181F1E0A0
	public static void SerializeDelta(Stream stream, Landmine instance, Landmine previous) { }

	// RVA: 0x1F1E410 Offset: 0x1F1CA10 VA: 0x181F1E410
	public static void Serialize(Stream stream, Landmine instance) { }

	// RVA: 0x1F1E4E0 Offset: 0x1F1CAE0 VA: 0x181F1E4E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F1E4F0 Offset: 0x1F1CAF0 VA: 0x181F1E4F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F1E260 Offset: 0x1F1C860 VA: 0x181F1E260
	public static byte[] SerializeToBytes(Landmine instance) { }

	// RVA: 0x1F1E1B0 Offset: 0x1F1C7B0 VA: 0x181F1E1B0
	public static void SerializeLengthDelimited(Stream stream, Landmine instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x50DAD0 Offset: 0x50C0D0 VA: 0x18050DAD0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x50E000 Offset: 0x50C600 VA: 0x18050E000 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x50DF00 Offset: 0x50C500 VA: 0x18050DF00 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4F62A0 Offset: 0x4F48A0 VA: 0x1804F62A0
	public bool Armed() { }

	// RVA: 0x50DDD0 Offset: 0x50C3D0 VA: 0x18050DDD0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x50D9B0 Offset: 0x50BFB0 VA: 0x18050D9B0 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCD8A0 Offset: 0xCCCA0 VA: 0x1800CD8A0
	[BaseEntity.Menu.Description] // RVA: 0xCD8A0 Offset: 0xCCCA0 VA: 0x1800CD8A0
	[BaseEntity.Menu.Icon] // RVA: 0xCD8A0 Offset: 0xCCCA0 VA: 0x1800CD8A0
	[BaseEntity.Menu.ShowIf] // RVA: 0xCD8A0 Offset: 0xCCCA0 VA: 0x1800CD8A0
	// RVA: 0x50D970 Offset: 0x50BF70 VA: 0x18050D970
	public void Arm_Beartrap(BasePlayer player) { }

	// RVA: 0x50DEE0 Offset: 0x50C4E0 VA: 0x18050DEE0
	public bool Menu_Arm_ShowIf(BasePlayer player) { }

	// RVA: 0x50DA10 Offset: 0x50C010 VA: 0x18050DA10 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x50DE30 Offset: 0x50C430 VA: 0x18050DE30 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x50DFF0 Offset: 0x50C5F0 VA: 0x18050DFF0
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

	// RVA: 0x6869F0 Offset: 0x684FF0 VA: 0x1806869F0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x687090 Offset: 0x685690 VA: 0x180687090 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x686F20 Offset: 0x685520 VA: 0x180686F20 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x687010 Offset: 0x685610 VA: 0x180687010
	public bool Triggered() { }

	// RVA: 0x4F62A0 Offset: 0x4F48A0 VA: 0x1804F62A0
	public bool Armed() { }

	// RVA: 0x686D40 Offset: 0x685340 VA: 0x180686D40 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xE9F40 Offset: 0xE9340 VA: 0x1800E9F40
	[BaseEntity.Menu.Description] // RVA: 0xE9F40 Offset: 0xE9340 VA: 0x1800E9F40
	[BaseEntity.Menu.Icon] // RVA: 0xE9F40 Offset: 0xE9340 VA: 0x1800E9F40
	[BaseEntity.Menu.ShowIf] // RVA: 0xE9F40 Offset: 0xE9340 VA: 0x1800E9F40
	// RVA: 0x6869B0 Offset: 0x684FB0 VA: 0x1806869B0
	public void Arm_Landmine(BasePlayer player) { }

	// RVA: 0x686EB0 Offset: 0x6854B0 VA: 0x180686EB0
	public bool Menu_Disarm_ShowIf(BasePlayer player) { }

	// RVA: 0x687020 Offset: 0x685620 VA: 0x180687020
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

	// RVA: 0x731C80 Offset: 0x730280 VA: 0x180731C80 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x731C10 Offset: 0x730210 VA: 0x180731C10 Slot: 122
	public override string Categorize() { }

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60
	public bool IsTriggered() { }

	// RVA: 0x731C40 Offset: 0x730240 VA: 0x180731C40
	public Vector3 GetEyePosition() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x731880 Offset: 0x72FE80 VA: 0x180731880
	public void CLIENT_FireGun(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x7320D0 Offset: 0x7306D0 VA: 0x1807320D0
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

	// RVA: 0x932540 Offset: 0x930B40 VA: 0x180932540
	public void .ctor() { }

}

public class BaseTrapTrigger : TriggerBase // TypeDefIndex: 9686
{	// Fields
	public BaseTrap _trap; // 0x30

	// Methods

	// RVA: 0x4D3840 Offset: 0x4D1E40 VA: 0x1804D3840
	public void .ctor() { }

}

public class BearTrapTrigger : BaseTrapTrigger // TypeDefIndex: 9687
{	// Methods

	// RVA: 0x50D960 Offset: 0x50BF60 VA: 0x18050D960
	public void .ctor() { }

}

public class SurvivalFishTrap : WildlifeTrap // TypeDefIndex: 9688
{	// Methods

	// RVA: 0x7C4940 Offset: 0x7C2F40 VA: 0x1807C4940 Slot: 155
	public override void TrappedEffect() { }

	// RVA: 0x7C4B70 Offset: 0x7C3170 VA: 0x1807C4B70
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

	// RVA: 0xA18220 Offset: 0xA16820 VA: 0x180A18220
	public void .ctor() { }

}

public class TrappableWildlife.BaitType // TypeDefIndex: 9690
{	// Fields
	public float successRate; // 0x10
	public ItemDefinition bait; // 0x18
	public int minForInterest; // 0x20
	public int maxToConsume; // 0x24

	// Methods

	// RVA: 0xA08A10 Offset: 0xA07010 VA: 0x180A08A10
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

	// RVA: 0x4F62A0 Offset: 0x4F48A0 VA: 0x1804F62A0
	public bool IsTrapActive() { }

	// RVA: 0x8F6660 Offset: 0x8F4C60 VA: 0x1808F6660 Slot: 27
	public override void ResetState() { }

	// RVA: 0x8F6820 Offset: 0x8F4E20 VA: 0x1808F6820
	public void Update() { }

	// RVA: 0x8F6690 Offset: 0x8F4C90 VA: 0x1808F6690 Slot: 155
	public virtual void TrappedEffect() { }

	// RVA: 0x8F6860 Offset: 0x8F4E60 VA: 0x1808F6860
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

	// RVA: 0x51B9A0 Offset: 0x519FA0 VA: 0x18051B9A0
	public static bool get_needsSetup() { }

	// RVA: 0x51B900 Offset: 0x519F00 VA: 0x18051B900
	public static bool get_isPresent() { }

	// RVA: 0x51B110 Offset: 0x519710 VA: 0x18051B110
	public static void RunDefaults() { }

	// RVA: 0x51A510 Offset: 0x518B10 VA: 0x18051A510
	public static void Init_Tier0() { }

	// RVA: 0x51A020 Offset: 0x518620 VA: 0x18051A020
	public static void Init_Systems() { }

	// RVA: 0x519EE0 Offset: 0x5184E0 VA: 0x180519EE0
	public static void Init_Config() { }

	// RVA: 0x51B070 Offset: 0x519670 VA: 0x18051B070
	public static void NetworkInitRaknet() { }

	// RVA: 0x51B0C0 Offset: 0x5196C0 VA: 0x18051B0C0
	public static void NetworkInitSteamworks(bool enableSteamDatagramRelay) { }

	[IteratorStateMachineAttribute] // RVA: 0x99F30 Offset: 0x99330 VA: 0x180099F30
	// RVA: 0x51B570 Offset: 0x519B70 VA: 0x18051B570
	private IEnumerator Start() { }

	// RVA: 0x51AE80 Offset: 0x519480 VA: 0x18051AE80
	public static GameObject LoadEngineUI() { }

	// RVA: 0x51AF00 Offset: 0x519500 VA: 0x18051AF00
	public static GameObject LoadGameUI() { }

	// RVA: 0x51AF80 Offset: 0x519580 VA: 0x18051AF80
	public static GameObject LoadMenuUI() { }

	// RVA: 0x51AD40 Offset: 0x519340 VA: 0x18051AD40
	private static GameObject InstantiatePrefabPersistent(string path) { }

	// RVA: 0x51B6D0 Offset: 0x519CD0 VA: 0x18051B6D0
	public static void ToggleUIHack() { }

	// RVA: 0x51B260 Offset: 0x519860 VA: 0x18051B260
	public static void SetUIVisible(bool visible) { }

	[IteratorStateMachineAttribute] // RVA: 0x9A170 Offset: 0x99570 VA: 0x18009A170
	// RVA: 0x519DF0 Offset: 0x5183F0 VA: 0x180519DF0
	private IEnumerator ClientStartup() { }

	// RVA: 0x51B730 Offset: 0x519D30 VA: 0x18051B730
	protected void Update() { }

	// RVA: 0x51B5E0 Offset: 0x519BE0 VA: 0x18051B5E0
	private void StartupShared() { }

	// RVA: 0x51B5F0 Offset: 0x519BF0 VA: 0x18051B5F0
	public void ThrowError(string error) { }

	// RVA: 0x519E60 Offset: 0x518460 VA: 0x180519E60
	public void ExitGame() { }

	[IteratorStateMachineAttribute] // RVA: 0x9A550 Offset: 0x99950 VA: 0x18009A550
	// RVA: 0x51B000 Offset: 0x519600 VA: 0x18051B000
	public static IEnumerator LoadingUpdate(string str) { }

	// RVA: 0x51B7B0 Offset: 0x519DB0 VA: 0x18051B7B0
	public static void WriteToLog(string str) { }

	// RVA: 0x51B890 Offset: 0x519E90 VA: 0x18051B890
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

	// RVA: 0x5292C0 Offset: 0x5278C0 VA: 0x1805292C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5290C0 Offset: 0x5276C0 VA: 0x1805290C0
	internal GameObject <Init_Tier0>b__13_0(string str) { }

	// RVA: 0x529140 Offset: 0x527740 VA: 0x180529140
	internal void <Init_Tier0>b__13_1() { }

	// RVA: 0x529150 Offset: 0x527750 VA: 0x180529150
	internal bool <Init_Tier0>b__13_2() { }

	// RVA: 0x529070 Offset: 0x527670 VA: 0x180529070
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
	// RVA: 0x528DC0 Offset: 0x5273C0 VA: 0x180528DC0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x527B10 Offset: 0x526110 VA: 0x180527B10 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x528F80 Offset: 0x527580 VA: 0x180528F80
	private void <>m__Finally1() { }

	// RVA: 0x528FD0 Offset: 0x5275D0 VA: 0x180528FD0
	private void <>m__Finally2() { }

	// RVA: 0x529020 Offset: 0x527620 VA: 0x180529020
	private void <>m__Finally3() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x528D70 Offset: 0x527370 VA: 0x180528D70 Slot: 8
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
	// RVA: 0x524C20 Offset: 0x523220 VA: 0x180524C20 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x5232A0 Offset: 0x5218A0 VA: 0x1805232A0 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x524DE0 Offset: 0x5233E0 VA: 0x180524DE0
	private void <>m__Finally1() { }

	// RVA: 0x524E30 Offset: 0x523430 VA: 0x180524E30
	private void <>m__Finally2() { }

	// RVA: 0x524E80 Offset: 0x523480 VA: 0x180524E80
	private void <>m__Finally3() { }

	// RVA: 0x524ED0 Offset: 0x5234D0 VA: 0x180524ED0
	private void <>m__Finally4() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x524BD0 Offset: 0x5231D0 VA: 0x180524BD0 Slot: 8
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

	// RVA: 0x524F20 Offset: 0x523520 VA: 0x180524F20 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5250D0 Offset: 0x5236D0 VA: 0x1805250D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

