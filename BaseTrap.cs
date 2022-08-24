public class Landmine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6326
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong triggeredID; // 0x18


	public static void ResetToPool(Landmine instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Landmine instance) { }

	public Landmine Copy() { }

	public static Landmine Deserialize(Stream stream) { }

	public static Landmine DeserializeLengthDelimited(Stream stream) { }

	public static Landmine DeserializeLength(Stream stream, int length) { }

	public static Landmine Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Landmine previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Landmine Deserialize(byte[] buffer, Landmine instance, bool isDelta = False) { }

	public static Landmine Deserialize(Stream stream, Landmine instance, bool isDelta) { }

	public static Landmine DeserializeLengthDelimited(Stream stream, Landmine instance, bool isDelta) { }

	public static Landmine DeserializeLength(Stream stream, int length, Landmine instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Landmine instance, Landmine previous) { }

	public static void Serialize(Stream stream, Landmine instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Landmine instance) { }

	public static void SerializeLengthDelimited(Stream stream, Landmine instance) { }

	public void .ctor() { }

}

public class BearTrap : BaseTrap // TypeDefIndex: 8362
{	private Option __menuOption_Arm_Beartrap; // 0x258
	protected Animator animator; // 0x2B0
	private bool initialized; // 0x2B8

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool Armed() { }

	public override void InitShared() { }

	public override bool CanPickup(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCDA80 Offset: 0xCCE80 VA: 0x1800CDA80
	[BaseEntity.Menu.Description] // RVA: 0xCDA80 Offset: 0xCCE80 VA: 0x1800CDA80
	[BaseEntity.Menu.Icon] // RVA: 0xCDA80 Offset: 0xCCE80 VA: 0x1800CDA80
	[BaseEntity.Menu.ShowIf] // RVA: 0xCDA80 Offset: 0xCCE80 VA: 0x1800CDA80
	public void Arm_Beartrap(BasePlayer player) { }

	public bool Menu_Arm_ShowIf(BasePlayer player) { }

	public override void ClientOnEnable() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

}

public class Landmine : BaseTrap // TypeDefIndex: 8402
{	private Option __menuOption_Arm_Landmine; // 0x258
	public GameObjectRef explosionEffect; // 0x2B0
	public GameObjectRef triggeredEffect; // 0x2B8
	public float minExplosionRadius; // 0x2C0
	public float explosionRadius; // 0x2C4
	public bool blocked; // 0x2C8
	private ulong triggerPlayerID; // 0x2D0
	public List<DamageTypeEntry> damageTypes; // 0x2D8

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool Triggered() { }

	public bool Armed() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xEA0F0 Offset: 0xE94F0 VA: 0x1800EA0F0
	[BaseEntity.Menu.Description] // RVA: 0xEA0F0 Offset: 0xE94F0 VA: 0x1800EA0F0
	[BaseEntity.Menu.Icon] // RVA: 0xEA0F0 Offset: 0xE94F0 VA: 0x1800EA0F0
	[BaseEntity.Menu.ShowIf] // RVA: 0xEA0F0 Offset: 0xE94F0 VA: 0x1800EA0F0
	public void Arm_Landmine(BasePlayer player) { }

	public bool Menu_Disarm_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

public class GunTrap : StorageContainer // TypeDefIndex: 8572
{	public GameObjectRef gun_fire_effect; // 0x3D0
	public GameObjectRef bulletEffect; // 0x3D8
	public GameObjectRef triggeredEffect; // 0x3E0
	public Transform muzzlePos; // 0x3E8
	public Transform eyeTransform; // 0x3F0
	public int numPellets; // 0x3F8
	public int aimCone; // 0x3FC
	public float sensorRadius; // 0x400
	public ItemDefinition ammoType; // 0x408
	public TargetTrigger trigger; // 0x410


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override string Categorize() { }

	public bool IsTriggered() { }

	public Vector3 GetEyePosition() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void CLIENT_FireGun(BaseEntity.RPCMessage rpc) { }

	public void .ctor() { }

}

public static class GunTrap.GunTrapFlags // TypeDefIndex: 8573
{	public const BaseEntity.Flags Triggered = 128;

}

public class BaseTrap : DecayEntity // TypeDefIndex: 9685
{
	public override bool DisplayHealthInfo(BasePlayer player) { }

	public void .ctor() { }

}

public class BaseTrapTrigger : TriggerBase // TypeDefIndex: 9686
{	public BaseTrap _trap; // 0x30


	public void .ctor() { }

}

public class BearTrapTrigger : BaseTrapTrigger // TypeDefIndex: 9687
{
	public void .ctor() { }

}

public class SurvivalFishTrap : WildlifeTrap // TypeDefIndex: 9688
{
	public override void TrappedEffect() { }

	public void .ctor() { }

}

public class TrappableWildlife : ScriptableObject // TypeDefIndex: 9689
{	public GameObjectRef worldObject; // 0x18
	public ItemDefinition inventoryObject; // 0x20
	public int minToCatch; // 0x28
	public int maxToCatch; // 0x2C
	public List<TrappableWildlife.BaitType> baitTypes; // 0x30
	public int caloriesForInterest; // 0x38
	public float successRate; // 0x3C
	public float xpScale; // 0x40


	public void .ctor() { }

}

public class TrappableWildlife.BaitType // TypeDefIndex: 9690
{	public float successRate; // 0x10
	public ItemDefinition bait; // 0x18
	public int minForInterest; // 0x20
	public int maxToConsume; // 0x24


	public void .ctor() { }

}

public class WildlifeTrap : StorageContainer // TypeDefIndex: 9691
{	public float tickRate; // 0x3D0
	public GameObjectRef trappedEffect; // 0x3D8
	public float trappedEffectRepeatRate; // 0x3E0
	public float trapSuccessRate; // 0x3E4
	public List<ItemDefinition> ignoreBait; // 0x3E8
	public List<WildlifeTrap.WildlifeWeight> targetWildlife; // 0x3F0
	protected float nextEffectTime; // 0x3F8


	public bool HasCatch() { }

	public bool IsTrapActive() { }

	public override void ResetState() { }

	public void Update() { }

	public virtual void TrappedEffect() { }

	public void .ctor() { }

}

public static class WildlifeTrap.WildlifeTrapFlags // TypeDefIndex: 9692
{	public const BaseEntity.Flags Occupied = 128;

}

public class WildlifeTrap.WildlifeWeight // TypeDefIndex: 9693
{	public TrappableWildlife wildlife; // 0x10
	public int weight; // 0x18


	public void .ctor() { }

}

public class Bootstrap : SingletonComponent<Bootstrap> // TypeDefIndex: 9820
{	internal static bool bootstrapInitRun; // 0x0
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

	public static bool needsSetup { get; }
	public static bool isPresent { get; }


	public static bool get_needsSetup() { }

	public static bool get_isPresent() { }

	public static void RunDefaults() { }

	public static void Init_Tier0() { }

	public static void Init_Systems() { }

	public static void Init_Config() { }

	public static void NetworkInitRaknet() { }

	public static void NetworkInitSteamworks(bool enableSteamDatagramRelay) { }

	[IteratorStateMachineAttribute] // RVA: 0x99440 Offset: 0x98840 VA: 0x180099440
	private IEnumerator Start() { }

	public static GameObject LoadEngineUI() { }

	public static GameObject LoadGameUI() { }

	public static GameObject LoadMenuUI() { }

	private static GameObject InstantiatePrefabPersistent(string path) { }

	public static void ToggleUIHack() { }

	public static void SetUIVisible(bool visible) { }

	[IteratorStateMachineAttribute] // RVA: 0x995C0 Offset: 0x989C0 VA: 0x1800995C0
	private IEnumerator ClientStartup() { }

	protected void Update() { }

	private void StartupShared() { }

	public void ThrowError(string error) { }

	public void ExitGame() { }

	[IteratorStateMachineAttribute] // RVA: 0x99880 Offset: 0x98C80 VA: 0x180099880
	public static IEnumerator LoadingUpdate(string str) { }

	public static void WriteToLog(string str) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class Bootstrap.<>c // TypeDefIndex: 9821
{	public static readonly Bootstrap.<>c <>9; // 0x0
	public static Func<string, GameObject> <>9__13_0; // 0x8
	public static Action <>9__13_1; // 0x10
	public static Func<bool> <>9__13_2; // 0x18
	public static Func<int> <>9__14_0; // 0x20


	private static void .cctor() { }

	public void .ctor() { }

	internal GameObject <Init_Tier0>b__13_0(string str) { }

	internal void <Init_Tier0>b__13_1() { }

	internal bool <Init_Tier0>b__13_2() { }

	internal int <Init_Systems>b__14_0() { }

}

private sealed class Bootstrap.<Start>d__18 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9822
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Bootstrap <>4__this; // 0x20
	private BenchmarkTimer <timer>5__2; // 0x28
	private AssetBundleBackend <newBackend>5__3; // 0x30
	private BenchmarkTimer <>7__wrap3; // 0x38

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	private void <>m__Finally2() { }

	private void <>m__Finally3() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class Bootstrap.<ClientStartup>d__28 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9823
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Bootstrap <>4__this; // 0x20
	private BenchmarkTimer <>7__wrap1; // 0x28
	private AsyncOperation <op>5__3; // 0x30

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	private void <>m__Finally2() { }

	private void <>m__Finally3() { }

	private void <>m__Finally4() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class Bootstrap.<LoadingUpdate>d__33 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9824
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string str; // 0x20

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.IEnumerator.get_Current() { }

}

