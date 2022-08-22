public class EffectData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6278
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint type; // 0x14
	public uint pooledstringid; // 0x18
	public int number; // 0x1C
	public Vector3 origin; // 0x20
	public Vector3 normal; // 0x2C
	public float scale; // 0x38
	public uint entity; // 0x3C
	public uint bone; // 0x40
	public ulong source; // 0x48

	// Methods

	// RVA: 0x201A790 Offset: 0x2018D90 VA: 0x18201A790
	public static void ResetToPool(EffectData instance) { }

	// RVA: 0x201A890 Offset: 0x2018E90 VA: 0x18201A890
	public void ResetToPool() { }

	// RVA: 0x201A290 Offset: 0x2018890 VA: 0x18201A290 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20188B0 Offset: 0x2016EB0 VA: 0x1820188B0
	public void CopyTo(EffectData instance) { }

	// RVA: 0x2018910 Offset: 0x2016F10 VA: 0x182018910
	public EffectData Copy() { }

	// RVA: 0x2019BA0 Offset: 0x20181A0 VA: 0x182019BA0
	public static EffectData Deserialize(Stream stream) { }

	// RVA: 0x20189D0 Offset: 0x2016FD0 VA: 0x1820189D0
	public static EffectData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2018E80 Offset: 0x2017480 VA: 0x182018E80
	public static EffectData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2019750 Offset: 0x2017D50 VA: 0x182019750
	public static EffectData Deserialize(byte[] buffer) { }

	// RVA: 0x201A410 Offset: 0x2018A10 VA: 0x18201A410
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x201B4A0 Offset: 0x2019AA0 VA: 0x18201B4A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x201B4C0 Offset: 0x2019AC0 VA: 0x18201B4C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EffectData previous) { }

	// RVA: 0x201A770 Offset: 0x2018D70 VA: 0x18201A770 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2019310 Offset: 0x2017910 VA: 0x182019310
	public static EffectData Deserialize(byte[] buffer, EffectData instance, bool isDelta = False) { }

	// RVA: 0x2019F30 Offset: 0x2018530 VA: 0x182019F30
	public static EffectData Deserialize(Stream stream, EffectData instance, bool isDelta) { }

	// RVA: 0x2018A50 Offset: 0x2017050 VA: 0x182018A50
	public static EffectData DeserializeLengthDelimited(Stream stream, EffectData instance, bool isDelta) { }

	// RVA: 0x2018F10 Offset: 0x2017510 VA: 0x182018F10
	public static EffectData DeserializeLength(Stream stream, int length, EffectData instance, bool isDelta) { }

	// RVA: 0x201A990 Offset: 0x2018F90 VA: 0x18201A990
	public static void SerializeDelta(Stream stream, EffectData instance, EffectData previous) { }

	// RVA: 0x201B150 Offset: 0x2019750 VA: 0x18201B150
	public static void Serialize(Stream stream, EffectData instance) { }

	// RVA: 0x201B490 Offset: 0x2019A90 VA: 0x18201B490
	public byte[] ToProtoBytes() { }

	// RVA: 0x201B4A0 Offset: 0x2019AA0 VA: 0x18201B4A0
	public void ToProto(Stream stream) { }

	// RVA: 0x201B040 Offset: 0x2019640 VA: 0x18201B040
	public static byte[] SerializeToBytes(EffectData instance) { }

	// RVA: 0x201AF90 Offset: 0x2019590 VA: 0x18201AF90
	public static void SerializeLengthDelimited(Stream stream, EffectData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class EffectsBenchmarkScene : BenchmarkScene // TypeDefIndex: 8251
{	// Fields
	public GameObjectRef[] effectPrefabs; // 0x40
	private int effectCountPerFrame; // 0x48
	private float timeBetweenRuns; // 0x4C
	private int totalRuns; // 0x50
	private bool isFinished; // 0x54

	// Methods

	// RVA: 0xABEE50 Offset: 0xABD450 VA: 0x180ABEE50 Slot: 7
	public override void StartBenchmark() { }

	[IteratorStateMachineAttribute] // RVA: 0xA10B0 Offset: 0xA04B0 VA: 0x1800A10B0
	// RVA: 0xABEDD0 Offset: 0xABD3D0 VA: 0x180ABEDD0
	private IEnumerator DoEffectBenchmark() { }

	// RVA: 0xABEE40 Offset: 0xABD440 VA: 0x180ABEE40 Slot: 5
	public override bool ShouldEnd() { }

	// RVA: 0xABEEC0 Offset: 0xABD4C0 VA: 0x180ABEEC0
	public void .ctor() { }

}

private sealed class EffectsBenchmarkScene.<DoEffectBenchmark>d__6 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8252
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public EffectsBenchmarkScene <>4__this; // 0x20
	private int <i>5__2; // 0x28

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

	// RVA: 0xAC56D0 Offset: 0xAC3CD0 VA: 0x180AC56D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAC5990 Offset: 0xAC3F90 VA: 0x180AC5990 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class EffectMount : EntityComponent<BaseEntity>, IClientComponent // TypeDefIndex: 8886
{	// Fields
	public bool firstPerson; // 0x20
	public GameObject effectPrefab; // 0x28
	public GameObject spawnedEffect; // 0x30
	public GameObject mountBone; // 0x38

	// Methods

	// RVA: 0xABAF40 Offset: 0xAB9540 VA: 0x180ABAF40
	private void LateUpdate() { }

	// RVA: 0xABB190 Offset: 0xAB9790 VA: 0x180ABB190
	public void SetOn(bool isOn) { }

	// RVA: 0xABB3A0 Offset: 0xAB99A0 VA: 0x180ABB3A0
	public void .ctor() { }

}

public class EffectParent : EntityComponent<BaseEntity>, IClientComponent // TypeDefIndex: 8887
{	// Fields
	public GameObject effect; // 0x20

	// Methods

	// RVA: 0xABC4A0 Offset: 0xABAAA0 VA: 0x180ABC4A0
	private void LateUpdate() { }

	// RVA: 0xABC6D0 Offset: 0xABACD0 VA: 0x180ABC6D0
	public void .ctor() { }

}

public class Effect : EffectData // TypeDefIndex: 9331
{	// Fields
	public Vector3 Up; // 0x50
	public Vector3 worldPos; // 0x5C
	public Vector3 worldNrm; // 0x68
	public bool attached; // 0x74
	public Transform transform; // 0x78
	public GameObject gameObject; // 0x80
	public string pooledString; // 0x88
	public bool broadcast; // 0x90
	private static Effect reusableInstace; // 0x0

	// Methods

	// RVA: 0x6E6E30 Offset: 0x6E5430 VA: 0x1806E6E30
	public void .ctor() { }

	// RVA: 0xABEBE0 Offset: 0xABD1E0 VA: 0x180ABEBE0
	public void .ctor(string effectName, Vector3 posWorld, Vector3 normWorld, Connection sourceConnection) { }

	// RVA: 0xABED10 Offset: 0xABD310 VA: 0x180ABED10
	public void .ctor(string effectName, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, Connection sourceConnection) { }

	// RVA: 0xABDA60 Offset: 0xABC060 VA: 0x180ABDA60
	public void Init(Effect.Type fxtype, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, Connection sourceConnection) { }

	// RVA: 0xABD950 Offset: 0xABBF50 VA: 0x180ABD950
	public void Init(Effect.Type fxtype, Vector3 posWorld, Vector3 normWorld, Connection sourceConnection) { }

	// RVA: 0xABDD60 Offset: 0xABC360 VA: 0x180ABDD60
	public bool NetworkConstruct() { }

	// RVA: 0xABD880 Offset: 0xABBE80 VA: 0x180ABD880
	public void Clear() { }

	// RVA: 0xABEA40 Offset: 0xABD040 VA: 0x180ABEA40
	public static void Strip(GameObject obj) { }

	// RVA: 0xABEB80 Offset: 0xABD180 VA: 0x180ABEB80
	private static void .cctor() { }

}

public enum Effect.Type // TypeDefIndex: 9332
{	// Fields
	public uint value__; // 0x0
	public const Effect.Type Generic = 0;
	public const Effect.Type Projectile = 1;
	public const Effect.Type GenericGlobal = 2;

}

public static class Effect.client // TypeDefIndex: 9333
{	// Methods

	// RVA: 0xAC6B80 Offset: 0xAC5180 VA: 0x180AC6B80
	public static void Run(Effect.Type fxtype, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal) { }

	// RVA: 0xAC6E80 Offset: 0xAC5480 VA: 0x180AC6E80
	public static void Run(string strName, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal) { }

	// RVA: 0xAC6CB0 Offset: 0xAC52B0 VA: 0x180AC6CB0
	public static void Run(Effect.Type fxtype, Vector3 posWorld, Vector3 normWorld, Vector3 up) { }

	// RVA: 0xAC6FF0 Offset: 0xAC55F0 VA: 0x180AC6FF0
	public static void Run(string strName, Vector3 posWorld, Vector3 normWorld, Vector3 up, Effect.Type overrideType = 0) { }

	// RVA: 0xAC6920 Offset: 0xAC4F20 VA: 0x180AC6920
	public static void Run(string strName, GameObject obj) { }

	// RVA: 0xAC6090 Offset: 0xAC4690 VA: 0x180AC6090
	public static void DoAdditiveImpactEffect(HitInfo info, string effectName) { }

	// RVA: 0xAC62E0 Offset: 0xAC48E0 VA: 0x180AC62E0
	public static void ImpactEffect(HitInfo info) { }

}

public static class Effect.server // TypeDefIndex: 9334
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void Run(Effect.Type fxtype, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, Connection sourceConnection, bool broadcast = False) { }

	// RVA: 0xAC7780 Offset: 0xAC5D80 VA: 0x180AC7780
	public static void Run(string strName, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, Connection sourceConnection, bool broadcast = False) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void Run(Effect.Type fxtype, Vector3 posWorld, Vector3 normWorld, Connection sourceConnection, bool broadcast = False) { }

	// RVA: 0xAC7780 Offset: 0xAC5D80 VA: 0x180AC7780
	public static void Run(string strName, Vector3 posWorld, Vector3 normWorld, Connection sourceConnection, bool broadcast = False) { }

	// RVA: 0xAC7200 Offset: 0xAC5800 VA: 0x180AC7200
	public static void DoAdditiveImpactEffect(HitInfo info, string effectName) { }

	// RVA: 0xAC7230 Offset: 0xAC5830 VA: 0x180AC7230
	public static void ImpactEffect(HitInfo info) { }

}

public class EffectAudioPerspectiveSwitcher : MonoBehaviour, IEffect, IPrefabPreProcess // TypeDefIndex: 9335
{	// Fields
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public EffectParentToWeaponBone parentToWeaponComponent; // 0x18

	// Methods

	// RVA: 0xAB8A20 Offset: 0xAB7020 VA: 0x180AB8A20
	private BaseViewModel GetViewModel(Effect effect) { }

	// RVA: 0xAB90C0 Offset: 0xAB76C0 VA: 0x180AB90C0 Slot: 6
	public virtual void SetupEffect(Effect effect) { }

	// RVA: 0xAB8FC0 Offset: 0xAB75C0 VA: 0x180AB8FC0
	private void MakeThirdPerson() { }

	// RVA: 0xAB8E60 Offset: 0xAB7460 VA: 0x180AB8E60
	private void MakeFirstPerson() { }

	// RVA: 0xAB9060 Offset: 0xAB7660 VA: 0x180AB9060 Slot: 5
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public static class EffectLibrary // TypeDefIndex: 9338
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xABAB10 Offset: 0xAB9110 VA: 0x180ABAB10
	private static void SetupEffect(GameObject go, Effect effect) { }

	// RVA: 0xABA780 Offset: 0xAB8D80 VA: 0x180ABA780
	private static void GenericEffectSpawn(Effect effect) { }

	// RVA: 0xABA7B0 Offset: 0xAB8DB0 VA: 0x180ABA7B0
	private static void ProjectileEffectSpawn(Effect effect) { }

	// RVA: 0xABAAC0 Offset: 0xAB90C0 VA: 0x180ABAAC0
	public static void Run(Effect fx) { }

	// RVA: 0xABA5B0 Offset: 0xAB8BB0 VA: 0x180ABA5B0
	public static GameObject CreateEffect(string strPrefab, Transform parent, Vector3 pos, Quaternion rot) { }

	// RVA: 0xAB9D10 Offset: 0xAB8310 VA: 0x180AB9D10
	public static GameObject CreateEffect(string strPrefab, Effect effect) { }

	// RVA: 0xABA430 Offset: 0xAB8A30 VA: 0x180ABA430
	public static GameObject CreateEffect(string strPrefab, Vector3 vPos, Quaternion aAngle) { }

}

public class EffectMuzzleFlash : MonoBehaviour, IEffect // TypeDefIndex: 9339
{	// Methods

	// RVA: 0xABB640 Offset: 0xAB9C40 VA: 0x180ABB640 Slot: 5
	public virtual void SetupEffect(Effect effect) { }

	// RVA: 0xABB3E0 Offset: 0xAB99E0 VA: 0x180ABB3E0
	private bool ApplyToViewModel() { }

	// RVA: 0xABB5F0 Offset: 0xAB9BF0 VA: 0x180ABB5F0
	private void PositionOnObject(Transform muzzle) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public static class EffectNetwork // TypeDefIndex: 9340
{	// Fields
	private static Effect effect; // 0x1D16

	// Methods

	// RVA: 0xABB7C0 Offset: 0xAB9DC0 VA: 0x180ABB7C0
	public static void OnReceivedEffect(Message msg) { }

	// RVA: 0xABBAC0 Offset: 0xABA0C0 VA: 0x180ABBAC0
	private static void .cctor() { }

}

public class EffectParentToWeaponBone : BaseMonoBehaviour, IEffect // TypeDefIndex: 9341
{	// Fields
	public string boneName; // 0x18
	public bool singleFrame; // 0x20
	private bool isFirstPerson; // 0x21
	private Transform bone; // 0x28

	// Methods

	// RVA: 0xABC390 Offset: 0xABA990 VA: 0x180ABC390 Slot: 7
	public virtual void SetupEffect(Effect effect) { }

	// RVA: 0xABBE10 Offset: 0xABA410 VA: 0x180ABBE10
	private void LateUpdate() { }

	// RVA: 0xABBB20 Offset: 0xABA120 VA: 0x180ABBB20
	private bool ApplyToViewModel() { }

	// RVA: 0xABC060 Offset: 0xABA660 VA: 0x180ABC060
	private void PositionOnObject(GameObject wm) { }

	// RVA: 0xABBDE0 Offset: 0xABA3E0 VA: 0x180ABBDE0
	public void ClearParent() { }

	// RVA: 0x521BF0 Offset: 0x5201F0 VA: 0x180521BF0
	public void .ctor() { }

}

public class EffectScaleWithCameraDistance : MonoBehaviour, IEffect // TypeDefIndex: 9342
{	// Fields
	public float minScale; // 0x18
	public float maxScale; // 0x1C
	public float scaleStartDistance; // 0x20
	public float scaleEndDistance; // 0x24
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool on; // 0x0

	// Methods

	// RVA: 0xABD3C0 Offset: 0xABB9C0 VA: 0x180ABD3C0 Slot: 5
	public virtual void SetupEffect(Effect effect) { }

	// RVA: 0xABD850 Offset: 0xABBE50 VA: 0x180ABD850
	public void .ctor() { }

	// RVA: 0xABD810 Offset: 0xABBE10 VA: 0x180ABD810
	private static void .cctor() { }

}

public class EffectBlood : EffectRecycle // TypeDefIndex: 9854
{	// Fields
	public GameObjectRef ReplacementEffect; // 0x38

	// Methods

	// RVA: 0xAB9330 Offset: 0xAB7930 VA: 0x180AB9330 Slot: 10
	protected override void OnEnable() { }

	// RVA: 0x521BF0 Offset: 0x5201F0 VA: 0x180521BF0
	public void .ctor() { }

}

public class EffectDictionary // TypeDefIndex: 9855
{	// Fields
	private static Dictionary<string, string[]> effectDictionary; // 0x2CE0

	// Methods

	// RVA: 0xAB9A40 Offset: 0xAB8040 VA: 0x180AB9A40
	public static string GetParticle(string impactType, string materialName) { }

	// RVA: 0xAB9920 Offset: 0xAB7F20 VA: 0x180AB9920
	public static string GetParticle(DamageType damageType, string materialName) { }

	// RVA: 0xAB9720 Offset: 0xAB7D20 VA: 0x180AB9720
	public static string GetDecal(string impactType, string materialName) { }

	// RVA: 0xAB9790 Offset: 0xAB7D90 VA: 0x180AB9790
	public static string GetDecal(DamageType damageType, string materialName) { }

	// RVA: 0xAB98B0 Offset: 0xAB7EB0 VA: 0x180AB98B0
	public static string GetDisplacement(string impactType, string materialName) { }

	// RVA: 0xAB9AB0 Offset: 0xAB80B0 VA: 0x180AB9AB0
	private static string LookupEffect(string category, string effect, string material) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public class EffectRecycle : BaseMonoBehaviour, IClientComponent, IRagdollInhert, IEffectRecycle, IOnParentDestroying // TypeDefIndex: 9856
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x9F790 Offset: 0x9EB90 VA: 0x18009F790
	[ReadOnlyAttribute] // RVA: 0x9F790 Offset: 0x9EB90 VA: 0x18009F790
	public float detachTime; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x9F790 Offset: 0x9EB90 VA: 0x18009F790
	[ReadOnlyAttribute] // RVA: 0x9F790 Offset: 0x9EB90 VA: 0x18009F790
	public float recycleTime; // 0x1C
	public EffectRecycle.PlayMode playMode; // 0x20
	public EffectRecycle.ParentDestroyBehaviour onParentDestroyed; // 0x24
	private Action recycleAction; // 0x28
	private Action detachWaitRecycleAction; // 0x30

	// Methods

	// RVA: 0xABCC10 Offset: 0xABB210 VA: 0x180ABCC10
	protected void Awake() { }

	// RVA: 0xABCDE0 Offset: 0xABB3E0 VA: 0x180ABCDE0
	private float GetParticleSystemLength() { }

	// RVA: 0xABD040 Offset: 0xABB640 VA: 0x180ABD040
	private float GetSoundLength() { }

	// RVA: 0xABCF60 Offset: 0xABB560 VA: 0x180ABCF60
	private float GetScreenShakeLength() { }

	// RVA: 0xABD310 Offset: 0xABB910 VA: 0x180ABD310 Slot: 9
	public virtual Transform RagdollInhertTransform() { }

	// RVA: 0xABD220 Offset: 0xABB820 VA: 0x180ABD220 Slot: 10
	protected virtual void OnEnable() { }

	// RVA: 0xABD320 Offset: 0xABB920 VA: 0x180ABD320 Slot: 7
	public void Recycle() { }

	// RVA: 0xABCCC0 Offset: 0xABB2C0 VA: 0x180ABCCC0
	private void DetachFromParent() { }

	// RVA: 0xABCD90 Offset: 0xABB390 VA: 0x180ABCD90
	private void DetachWaitRecycle() { }

	// RVA: 0xABD2C0 Offset: 0xABB8C0 VA: 0x180ABD2C0 Slot: 8
	public void OnParentDestroying() { }

	// RVA: 0x521BF0 Offset: 0x5201F0 VA: 0x180521BF0
	public void .ctor() { }

}

public enum EffectRecycle.PlayMode // TypeDefIndex: 9857
{	// Fields
	public int value__; // 0x0
	public const EffectRecycle.PlayMode Once = 0;
	public const EffectRecycle.PlayMode Looped = 1;

}

public enum EffectRecycle.ParentDestroyBehaviour // TypeDefIndex: 9858
{	// Fields
	public int value__; // 0x0
	public const EffectRecycle.ParentDestroyBehaviour Detach = 0;
	public const EffectRecycle.ParentDestroyBehaviour Destroy = 1;
	public const EffectRecycle.ParentDestroyBehaviour DetachWaitDestroy = 2;

}

public class EffectRecycleDetach : BaseMonoBehaviour, IClientComponent, IEffectRecycle, IOnParentDestroying // TypeDefIndex: 9859
{	// Fields
	public float recycleTime; // 0x18
	private Action recycleAction; // 0x20

	// Methods

	// RVA: 0xABC710 Offset: 0xABAD10 VA: 0x180ABC710
	protected void Awake() { }

	// RVA: 0xABC940 Offset: 0xABAF40 VA: 0x180ABC940 Slot: 6
	public void Recycle() { }

	// RVA: 0xABC790 Offset: 0xABAD90 VA: 0x180ABC790
	private void DetachFromParent() { }

	// RVA: 0xABC860 Offset: 0xABAE60 VA: 0x180ABC860 Slot: 7
	public void OnParentDestroying() { }

	// RVA: 0xABC9D0 Offset: 0xABAFD0 VA: 0x180ABC9D0
	public void .ctor() { }

}

public class EffectRecycleLite : BasePrefab, IClientComponent, IEffectRecycle, IOnParentDestroying // TypeDefIndex: 9860
{	// Fields
	private const float lifeTime = 60;
	private Action recycleAction; // 0x20

	// Methods

	// RVA: 0xABC9E0 Offset: 0xABAFE0 VA: 0x180ABC9E0
	protected void Awake() { }

	// RVA: 0xABCA60 Offset: 0xABB060 VA: 0x180ABCA60
	protected void OnEnable() { }

	// RVA: 0xABCB80 Offset: 0xABB180 VA: 0x180ABCB80 Slot: 8
	public void Recycle() { }

	// RVA: 0xABCAE0 Offset: 0xABB0E0 VA: 0x180ABCAE0 Slot: 9
	public void OnParentDestroying() { }

	// RVA: 0x4D38B0 Offset: 0x4D1EB0 VA: 0x1804D38B0
	public void .ctor() { }

}

public class Effects : ConsoleSystem // TypeDefIndex: 11910
{	// Fields
	private static int _antialiasing; // 0x0
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool ao; // 0x4
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool bloom; // 0x5
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool lensdirt; // 0x6
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool motionblur; // 0x7
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool sharpen; // 0x8
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool shafts; // 0x9
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool vignet; // 0xA
	public const bool color = True;
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool footsteps; // 0xB
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static int maxgibs; // 0xC
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static int maxGibDist; // 0x10
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static int minGibLife; // 0x14
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static int maxGibLife; // 0x18
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool otherplayerslightflares; // 0x1C
	[ClientVar] // RVA: 0x982E0 Offset: 0x976E0 VA: 0x1800982E0
	public static bool showoutlines; // 0x1D

	// Properties
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static int antialiasing { get; set; }
	public static bool requireMotionVectors { get; }
	public static Effects.AntiAliasingType AntiAliasingMode { get; set; }

	// Methods

	// RVA: 0x6DC2F0 Offset: 0x6DA8F0 VA: 0x1806DC2F0
	public static int get_antialiasing() { }

	// RVA: 0x6DC5A0 Offset: 0x6DABA0 VA: 0x1806DC5A0
	public static void set_antialiasing(int value) { }

	// RVA: 0x6DC350 Offset: 0x6DA950 VA: 0x1806DC350
	public static bool get_requireMotionVectors() { }

	// RVA: 0x6DC250 Offset: 0x6DA850 VA: 0x1806DC250
	public static Effects.AntiAliasingType get_AntiAliasingMode() { }

	// RVA: 0x6DC4C0 Offset: 0x6DAAC0 VA: 0x1806DC4C0
	public static void set_AntiAliasingMode(Effects.AntiAliasingType value) { }

	// RVA: 0x6DBD70 Offset: 0x6DA370 VA: 0x1806DBD70
	public static int ClearAllGibs() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6DC020 Offset: 0x6DA620 VA: 0x1806DC020
	public static void ClearAllGibs(ConsoleSystem.Arg arg) { }

	// RVA: 0x6DC1F0 Offset: 0x6DA7F0 VA: 0x1806DC1F0
	public void .ctor() { }

	// RVA: 0x6DC0B0 Offset: 0x6DA6B0 VA: 0x1806DC0B0
	private static void .cctor() { }

}

public enum Effects.AntiAliasingType // TypeDefIndex: 11911
{	// Fields
	public int value__; // 0x0
	public const Effects.AntiAliasingType None = 0;
	public const Effects.AntiAliasingType FXAA = 1;
	public const Effects.AntiAliasingType SMAA = 2;
	public const Effects.AntiAliasingType TSSAA = 3;

}

