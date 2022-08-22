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

	// RVA: 0x201B270 Offset: 0x2019870 VA: 0x18201B270
	public static void ResetToPool(EffectData instance) { }

	// RVA: 0x201B370 Offset: 0x2019970 VA: 0x18201B370
	public void ResetToPool() { }

	// RVA: 0x201AD70 Offset: 0x2019370 VA: 0x18201AD70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2019390 Offset: 0x2017990 VA: 0x182019390
	public void CopyTo(EffectData instance) { }

	// RVA: 0x20193F0 Offset: 0x20179F0 VA: 0x1820193F0
	public EffectData Copy() { }

	// RVA: 0x201A680 Offset: 0x2018C80 VA: 0x18201A680
	public static EffectData Deserialize(Stream stream) { }

	// RVA: 0x20194B0 Offset: 0x2017AB0 VA: 0x1820194B0
	public static EffectData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2019960 Offset: 0x2017F60 VA: 0x182019960
	public static EffectData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x201A230 Offset: 0x2018830 VA: 0x18201A230
	public static EffectData Deserialize(byte[] buffer) { }

	// RVA: 0x201AEF0 Offset: 0x20194F0 VA: 0x18201AEF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x201BF80 Offset: 0x201A580 VA: 0x18201BF80 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x201BFA0 Offset: 0x201A5A0 VA: 0x18201BFA0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EffectData previous) { }

	// RVA: 0x201B250 Offset: 0x2019850 VA: 0x18201B250 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2019DF0 Offset: 0x20183F0 VA: 0x182019DF0
	public static EffectData Deserialize(byte[] buffer, EffectData instance, bool isDelta = False) { }

	// RVA: 0x201AA10 Offset: 0x2019010 VA: 0x18201AA10
	public static EffectData Deserialize(Stream stream, EffectData instance, bool isDelta) { }

	// RVA: 0x2019530 Offset: 0x2017B30 VA: 0x182019530
	public static EffectData DeserializeLengthDelimited(Stream stream, EffectData instance, bool isDelta) { }

	// RVA: 0x20199F0 Offset: 0x2017FF0 VA: 0x1820199F0
	public static EffectData DeserializeLength(Stream stream, int length, EffectData instance, bool isDelta) { }

	// RVA: 0x201B470 Offset: 0x2019A70 VA: 0x18201B470
	public static void SerializeDelta(Stream stream, EffectData instance, EffectData previous) { }

	// RVA: 0x201BC30 Offset: 0x201A230 VA: 0x18201BC30
	public static void Serialize(Stream stream, EffectData instance) { }

	// RVA: 0x201BF70 Offset: 0x201A570 VA: 0x18201BF70
	public byte[] ToProtoBytes() { }

	// RVA: 0x201BF80 Offset: 0x201A580 VA: 0x18201BF80
	public void ToProto(Stream stream) { }

	// RVA: 0x201BB20 Offset: 0x201A120 VA: 0x18201BB20
	public static byte[] SerializeToBytes(EffectData instance) { }

	// RVA: 0x201BA70 Offset: 0x201A070 VA: 0x18201BA70
	public static void SerializeLengthDelimited(Stream stream, EffectData instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0xABF5E0 Offset: 0xABDBE0 VA: 0x180ABF5E0 Slot: 7
	public override void StartBenchmark() { }

	[IteratorStateMachineAttribute] // RVA: 0xA10B0 Offset: 0xA04B0 VA: 0x1800A10B0
	// RVA: 0xABF560 Offset: 0xABDB60 VA: 0x180ABF560
	private IEnumerator DoEffectBenchmark() { }

	// RVA: 0xABF5D0 Offset: 0xABDBD0 VA: 0x180ABF5D0 Slot: 5
	public override bool ShouldEnd() { }

	// RVA: 0xABF650 Offset: 0xABDC50 VA: 0x180ABF650
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

	// RVA: 0xAC5E60 Offset: 0xAC4460 VA: 0x180AC5E60 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAC6120 Offset: 0xAC4720 VA: 0x180AC6120 Slot: 8
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

	// RVA: 0xABB6D0 Offset: 0xAB9CD0 VA: 0x180ABB6D0
	private void LateUpdate() { }

	// RVA: 0xABB920 Offset: 0xAB9F20 VA: 0x180ABB920
	public void SetOn(bool isOn) { }

	// RVA: 0xABBB30 Offset: 0xABA130 VA: 0x180ABBB30
	public void .ctor() { }

}

public class EffectParent : EntityComponent<BaseEntity>, IClientComponent // TypeDefIndex: 8887
{	// Fields
	public GameObject effect; // 0x20

	// Methods

	// RVA: 0xABCC30 Offset: 0xABB230 VA: 0x180ABCC30
	private void LateUpdate() { }

	// RVA: 0xABCE60 Offset: 0xABB460 VA: 0x180ABCE60
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

	// RVA: 0x6E6ED0 Offset: 0x6E54D0 VA: 0x1806E6ED0
	public void .ctor() { }

	// RVA: 0xABF370 Offset: 0xABD970 VA: 0x180ABF370
	public void .ctor(string effectName, Vector3 posWorld, Vector3 normWorld, Connection sourceConnection) { }

	// RVA: 0xABF4A0 Offset: 0xABDAA0 VA: 0x180ABF4A0
	public void .ctor(string effectName, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, Connection sourceConnection) { }

	// RVA: 0xABE1F0 Offset: 0xABC7F0 VA: 0x180ABE1F0
	public void Init(Effect.Type fxtype, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, Connection sourceConnection) { }

	// RVA: 0xABE0E0 Offset: 0xABC6E0 VA: 0x180ABE0E0
	public void Init(Effect.Type fxtype, Vector3 posWorld, Vector3 normWorld, Connection sourceConnection) { }

	// RVA: 0xABE4F0 Offset: 0xABCAF0 VA: 0x180ABE4F0
	public bool NetworkConstruct() { }

	// RVA: 0xABE010 Offset: 0xABC610 VA: 0x180ABE010
	public void Clear() { }

	// RVA: 0xABF1D0 Offset: 0xABD7D0 VA: 0x180ABF1D0
	public static void Strip(GameObject obj) { }

	// RVA: 0xABF310 Offset: 0xABD910 VA: 0x180ABF310
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

	// RVA: 0xAC7310 Offset: 0xAC5910 VA: 0x180AC7310
	public static void Run(Effect.Type fxtype, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal) { }

	// RVA: 0xAC7610 Offset: 0xAC5C10 VA: 0x180AC7610
	public static void Run(string strName, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal) { }

	// RVA: 0xAC7440 Offset: 0xAC5A40 VA: 0x180AC7440
	public static void Run(Effect.Type fxtype, Vector3 posWorld, Vector3 normWorld, Vector3 up) { }

	// RVA: 0xAC7780 Offset: 0xAC5D80 VA: 0x180AC7780
	public static void Run(string strName, Vector3 posWorld, Vector3 normWorld, Vector3 up, Effect.Type overrideType = 0) { }

	// RVA: 0xAC70B0 Offset: 0xAC56B0 VA: 0x180AC70B0
	public static void Run(string strName, GameObject obj) { }

	// RVA: 0xAC6820 Offset: 0xAC4E20 VA: 0x180AC6820
	public static void DoAdditiveImpactEffect(HitInfo info, string effectName) { }

	// RVA: 0xAC6A70 Offset: 0xAC5070 VA: 0x180AC6A70
	public static void ImpactEffect(HitInfo info) { }

}

public static class Effect.server // TypeDefIndex: 9334
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void Run(Effect.Type fxtype, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, Connection sourceConnection, bool broadcast = False) { }

	// RVA: 0xAC7F10 Offset: 0xAC6510 VA: 0x180AC7F10
	public static void Run(string strName, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, Connection sourceConnection, bool broadcast = False) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void Run(Effect.Type fxtype, Vector3 posWorld, Vector3 normWorld, Connection sourceConnection, bool broadcast = False) { }

	// RVA: 0xAC7F10 Offset: 0xAC6510 VA: 0x180AC7F10
	public static void Run(string strName, Vector3 posWorld, Vector3 normWorld, Connection sourceConnection, bool broadcast = False) { }

	// RVA: 0xAC7990 Offset: 0xAC5F90 VA: 0x180AC7990
	public static void DoAdditiveImpactEffect(HitInfo info, string effectName) { }

	// RVA: 0xAC79C0 Offset: 0xAC5FC0 VA: 0x180AC79C0
	public static void ImpactEffect(HitInfo info) { }

}

public class EffectAudioPerspectiveSwitcher : MonoBehaviour, IEffect, IPrefabPreProcess // TypeDefIndex: 9335
{	// Fields
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public EffectParentToWeaponBone parentToWeaponComponent; // 0x18

	// Methods

	// RVA: 0xAB91B0 Offset: 0xAB77B0 VA: 0x180AB91B0
	private BaseViewModel GetViewModel(Effect effect) { }

	// RVA: 0xAB9850 Offset: 0xAB7E50 VA: 0x180AB9850 Slot: 6
	public virtual void SetupEffect(Effect effect) { }

	// RVA: 0xAB9750 Offset: 0xAB7D50 VA: 0x180AB9750
	private void MakeThirdPerson() { }

	// RVA: 0xAB95F0 Offset: 0xAB7BF0 VA: 0x180AB95F0
	private void MakeFirstPerson() { }

	// RVA: 0xAB97F0 Offset: 0xAB7DF0 VA: 0x180AB97F0 Slot: 5
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public static class EffectLibrary // TypeDefIndex: 9338
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xABB2A0 Offset: 0xAB98A0 VA: 0x180ABB2A0
	private static void SetupEffect(GameObject go, Effect effect) { }

	// RVA: 0xABAF10 Offset: 0xAB9510 VA: 0x180ABAF10
	private static void GenericEffectSpawn(Effect effect) { }

	// RVA: 0xABAF40 Offset: 0xAB9540 VA: 0x180ABAF40
	private static void ProjectileEffectSpawn(Effect effect) { }

	// RVA: 0xABB250 Offset: 0xAB9850 VA: 0x180ABB250
	public static void Run(Effect fx) { }

	// RVA: 0xABAD40 Offset: 0xAB9340 VA: 0x180ABAD40
	public static GameObject CreateEffect(string strPrefab, Transform parent, Vector3 pos, Quaternion rot) { }

	// RVA: 0xABA4A0 Offset: 0xAB8AA0 VA: 0x180ABA4A0
	public static GameObject CreateEffect(string strPrefab, Effect effect) { }

	// RVA: 0xABABC0 Offset: 0xAB91C0 VA: 0x180ABABC0
	public static GameObject CreateEffect(string strPrefab, Vector3 vPos, Quaternion aAngle) { }

}

public class EffectMuzzleFlash : MonoBehaviour, IEffect // TypeDefIndex: 9339
{	// Methods

	// RVA: 0xABBDD0 Offset: 0xABA3D0 VA: 0x180ABBDD0 Slot: 5
	public virtual void SetupEffect(Effect effect) { }

	// RVA: 0xABBB70 Offset: 0xABA170 VA: 0x180ABBB70
	private bool ApplyToViewModel() { }

	// RVA: 0xABBD80 Offset: 0xABA380 VA: 0x180ABBD80
	private void PositionOnObject(Transform muzzle) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public static class EffectNetwork // TypeDefIndex: 9340
{	// Fields
	private static Effect effect; // 0x1C00

	// Methods

	// RVA: 0xABBF50 Offset: 0xABA550 VA: 0x180ABBF50
	public static void OnReceivedEffect(Message msg) { }

	// RVA: 0xABC250 Offset: 0xABA850 VA: 0x180ABC250
	private static void .cctor() { }

}

public class EffectParentToWeaponBone : BaseMonoBehaviour, IEffect // TypeDefIndex: 9341
{	// Fields
	public string boneName; // 0x18
	public bool singleFrame; // 0x20
	private bool isFirstPerson; // 0x21
	private Transform bone; // 0x28

	// Methods

	// RVA: 0xABCB20 Offset: 0xABB120 VA: 0x180ABCB20 Slot: 7
	public virtual void SetupEffect(Effect effect) { }

	// RVA: 0xABC5A0 Offset: 0xABABA0 VA: 0x180ABC5A0
	private void LateUpdate() { }

	// RVA: 0xABC2B0 Offset: 0xABA8B0 VA: 0x180ABC2B0
	private bool ApplyToViewModel() { }

	// RVA: 0xABC7F0 Offset: 0xABADF0 VA: 0x180ABC7F0
	private void PositionOnObject(GameObject wm) { }

	// RVA: 0xABC570 Offset: 0xABAB70 VA: 0x180ABC570
	public void ClearParent() { }

	// RVA: 0x521B80 Offset: 0x520180 VA: 0x180521B80
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

	// RVA: 0xABDB50 Offset: 0xABC150 VA: 0x180ABDB50 Slot: 5
	public virtual void SetupEffect(Effect effect) { }

	// RVA: 0xABDFE0 Offset: 0xABC5E0 VA: 0x180ABDFE0
	public void .ctor() { }

	// RVA: 0xABDFA0 Offset: 0xABC5A0 VA: 0x180ABDFA0
	private static void .cctor() { }

}

public class EffectBlood : EffectRecycle // TypeDefIndex: 9854
{	// Fields
	public GameObjectRef ReplacementEffect; // 0x38

	// Methods

	// RVA: 0xAB9AC0 Offset: 0xAB80C0 VA: 0x180AB9AC0 Slot: 10
	protected override void OnEnable() { }

	// RVA: 0x521B80 Offset: 0x520180 VA: 0x180521B80
	public void .ctor() { }

}

public class EffectDictionary // TypeDefIndex: 9855
{	// Fields
	private static Dictionary<string, string[]> effectDictionary; // 0x2B10380

	// Methods

	// RVA: 0xABA1D0 Offset: 0xAB87D0 VA: 0x180ABA1D0
	public static string GetParticle(string impactType, string materialName) { }

	// RVA: 0xABA0B0 Offset: 0xAB86B0 VA: 0x180ABA0B0
	public static string GetParticle(DamageType damageType, string materialName) { }

	// RVA: 0xAB9EB0 Offset: 0xAB84B0 VA: 0x180AB9EB0
	public static string GetDecal(string impactType, string materialName) { }

	// RVA: 0xAB9F20 Offset: 0xAB8520 VA: 0x180AB9F20
	public static string GetDecal(DamageType damageType, string materialName) { }

	// RVA: 0xABA040 Offset: 0xAB8640 VA: 0x180ABA040
	public static string GetDisplacement(string impactType, string materialName) { }

	// RVA: 0xABA240 Offset: 0xAB8840 VA: 0x180ABA240
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

	// RVA: 0xABD3A0 Offset: 0xABB9A0 VA: 0x180ABD3A0
	protected void Awake() { }

	// RVA: 0xABD570 Offset: 0xABBB70 VA: 0x180ABD570
	private float GetParticleSystemLength() { }

	// RVA: 0xABD7D0 Offset: 0xABBDD0 VA: 0x180ABD7D0
	private float GetSoundLength() { }

	// RVA: 0xABD6F0 Offset: 0xABBCF0 VA: 0x180ABD6F0
	private float GetScreenShakeLength() { }

	// RVA: 0xABDAA0 Offset: 0xABC0A0 VA: 0x180ABDAA0 Slot: 9
	public virtual Transform RagdollInhertTransform() { }

	// RVA: 0xABD9B0 Offset: 0xABBFB0 VA: 0x180ABD9B0 Slot: 10
	protected virtual void OnEnable() { }

	// RVA: 0xABDAB0 Offset: 0xABC0B0 VA: 0x180ABDAB0 Slot: 7
	public void Recycle() { }

	// RVA: 0xABD450 Offset: 0xABBA50 VA: 0x180ABD450
	private void DetachFromParent() { }

	// RVA: 0xABD520 Offset: 0xABBB20 VA: 0x180ABD520
	private void DetachWaitRecycle() { }

	// RVA: 0xABDA50 Offset: 0xABC050 VA: 0x180ABDA50 Slot: 8
	public void OnParentDestroying() { }

	// RVA: 0x521B80 Offset: 0x520180 VA: 0x180521B80
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

	// RVA: 0xABCEA0 Offset: 0xABB4A0 VA: 0x180ABCEA0
	protected void Awake() { }

	// RVA: 0xABD0D0 Offset: 0xABB6D0 VA: 0x180ABD0D0 Slot: 6
	public void Recycle() { }

	// RVA: 0xABCF20 Offset: 0xABB520 VA: 0x180ABCF20
	private void DetachFromParent() { }

	// RVA: 0xABCFF0 Offset: 0xABB5F0 VA: 0x180ABCFF0 Slot: 7
	public void OnParentDestroying() { }

	// RVA: 0xABD160 Offset: 0xABB760 VA: 0x180ABD160
	public void .ctor() { }

}

public class EffectRecycleLite : BasePrefab, IClientComponent, IEffectRecycle, IOnParentDestroying // TypeDefIndex: 9860
{	// Fields
	private const float lifeTime = 60;
	private Action recycleAction; // 0x20

	// Methods

	// RVA: 0xABD170 Offset: 0xABB770 VA: 0x180ABD170
	protected void Awake() { }

	// RVA: 0xABD1F0 Offset: 0xABB7F0 VA: 0x180ABD1F0
	protected void OnEnable() { }

	// RVA: 0xABD310 Offset: 0xABB910 VA: 0x180ABD310 Slot: 8
	public void Recycle() { }

	// RVA: 0xABD270 Offset: 0xABB870 VA: 0x180ABD270 Slot: 9
	public void OnParentDestroying() { }

	// RVA: 0x4D3840 Offset: 0x4D1E40 VA: 0x1804D3840
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

	// RVA: 0x6DC390 Offset: 0x6DA990 VA: 0x1806DC390
	public static int get_antialiasing() { }

	// RVA: 0x6DC640 Offset: 0x6DAC40 VA: 0x1806DC640
	public static void set_antialiasing(int value) { }

	// RVA: 0x6DC3F0 Offset: 0x6DA9F0 VA: 0x1806DC3F0
	public static bool get_requireMotionVectors() { }

	// RVA: 0x6DC2F0 Offset: 0x6DA8F0 VA: 0x1806DC2F0
	public static Effects.AntiAliasingType get_AntiAliasingMode() { }

	// RVA: 0x6DC560 Offset: 0x6DAB60 VA: 0x1806DC560
	public static void set_AntiAliasingMode(Effects.AntiAliasingType value) { }

	// RVA: 0x6DBE10 Offset: 0x6DA410 VA: 0x1806DBE10
	public static int ClearAllGibs() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6DC0C0 Offset: 0x6DA6C0 VA: 0x1806DC0C0
	public static void ClearAllGibs(ConsoleSystem.Arg arg) { }

	// RVA: 0x6DC290 Offset: 0x6DA890 VA: 0x1806DC290
	public void .ctor() { }

	// RVA: 0x6DC150 Offset: 0x6DA750 VA: 0x1806DC150
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

