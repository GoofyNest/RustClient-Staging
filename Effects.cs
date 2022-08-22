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

	// RVA: 0x201AA50 Offset: 0x2019050 VA: 0x18201AA50
	public static void ResetToPool(EffectData instance) { }

	// RVA: 0x201AB50 Offset: 0x2019150 VA: 0x18201AB50
	public void ResetToPool() { }

	// RVA: 0x201A550 Offset: 0x2018B50 VA: 0x18201A550 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2018B70 Offset: 0x2017170 VA: 0x182018B70
	public void CopyTo(EffectData instance) { }

	// RVA: 0x2018BD0 Offset: 0x20171D0 VA: 0x182018BD0
	public EffectData Copy() { }

	// RVA: 0x2019E60 Offset: 0x2018460 VA: 0x182019E60
	public static EffectData Deserialize(Stream stream) { }

	// RVA: 0x2018C90 Offset: 0x2017290 VA: 0x182018C90
	public static EffectData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2019140 Offset: 0x2017740 VA: 0x182019140
	public static EffectData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2019A10 Offset: 0x2018010 VA: 0x182019A10
	public static EffectData Deserialize(byte[] buffer) { }

	// RVA: 0x201A6D0 Offset: 0x2018CD0 VA: 0x18201A6D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x201B760 Offset: 0x2019D60 VA: 0x18201B760 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x201B780 Offset: 0x2019D80 VA: 0x18201B780 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EffectData previous) { }

	// RVA: 0x201AA30 Offset: 0x2019030 VA: 0x18201AA30 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20195D0 Offset: 0x2017BD0 VA: 0x1820195D0
	public static EffectData Deserialize(byte[] buffer, EffectData instance, bool isDelta = False) { }

	// RVA: 0x201A1F0 Offset: 0x20187F0 VA: 0x18201A1F0
	public static EffectData Deserialize(Stream stream, EffectData instance, bool isDelta) { }

	// RVA: 0x2018D10 Offset: 0x2017310 VA: 0x182018D10
	public static EffectData DeserializeLengthDelimited(Stream stream, EffectData instance, bool isDelta) { }

	// RVA: 0x20191D0 Offset: 0x20177D0 VA: 0x1820191D0
	public static EffectData DeserializeLength(Stream stream, int length, EffectData instance, bool isDelta) { }

	// RVA: 0x201AC50 Offset: 0x2019250 VA: 0x18201AC50
	public static void SerializeDelta(Stream stream, EffectData instance, EffectData previous) { }

	// RVA: 0x201B410 Offset: 0x2019A10 VA: 0x18201B410
	public static void Serialize(Stream stream, EffectData instance) { }

	// RVA: 0x201B750 Offset: 0x2019D50 VA: 0x18201B750
	public byte[] ToProtoBytes() { }

	// RVA: 0x201B760 Offset: 0x2019D60 VA: 0x18201B760
	public void ToProto(Stream stream) { }

	// RVA: 0x201B300 Offset: 0x2019900 VA: 0x18201B300
	public static byte[] SerializeToBytes(EffectData instance) { }

	// RVA: 0x201B250 Offset: 0x2019850 VA: 0x18201B250
	public static void SerializeLengthDelimited(Stream stream, EffectData instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0xABF110 Offset: 0xABD710 VA: 0x180ABF110 Slot: 7
	public override void StartBenchmark() { }

	[IteratorStateMachineAttribute] // RVA: 0xA10B0 Offset: 0xA04B0 VA: 0x1800A10B0
	// RVA: 0xABF090 Offset: 0xABD690 VA: 0x180ABF090
	private IEnumerator DoEffectBenchmark() { }

	// RVA: 0xABF100 Offset: 0xABD700 VA: 0x180ABF100 Slot: 5
	public override bool ShouldEnd() { }

	// RVA: 0xABF180 Offset: 0xABD780 VA: 0x180ABF180
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

	// RVA: 0xAC5990 Offset: 0xAC3F90 VA: 0x180AC5990 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAC5C50 Offset: 0xAC4250 VA: 0x180AC5C50 Slot: 8
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

	// RVA: 0xABB200 Offset: 0xAB9800 VA: 0x180ABB200
	private void LateUpdate() { }

	// RVA: 0xABB450 Offset: 0xAB9A50 VA: 0x180ABB450
	public void SetOn(bool isOn) { }

	// RVA: 0xABB660 Offset: 0xAB9C60 VA: 0x180ABB660
	public void .ctor() { }

}

public class EffectParent : EntityComponent<BaseEntity>, IClientComponent // TypeDefIndex: 8887
{	// Fields
	public GameObject effect; // 0x20

	// Methods

	// RVA: 0xABC760 Offset: 0xABAD60 VA: 0x180ABC760
	private void LateUpdate() { }

	// RVA: 0xABC990 Offset: 0xABAF90 VA: 0x180ABC990
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

	// RVA: 0x6E6F40 Offset: 0x6E5540 VA: 0x1806E6F40
	public void .ctor() { }

	// RVA: 0xABEEA0 Offset: 0xABD4A0 VA: 0x180ABEEA0
	public void .ctor(string effectName, Vector3 posWorld, Vector3 normWorld, Connection sourceConnection) { }

	// RVA: 0xABEFD0 Offset: 0xABD5D0 VA: 0x180ABEFD0
	public void .ctor(string effectName, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, Connection sourceConnection) { }

	// RVA: 0xABDD20 Offset: 0xABC320 VA: 0x180ABDD20
	public void Init(Effect.Type fxtype, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, Connection sourceConnection) { }

	// RVA: 0xABDC10 Offset: 0xABC210 VA: 0x180ABDC10
	public void Init(Effect.Type fxtype, Vector3 posWorld, Vector3 normWorld, Connection sourceConnection) { }

	// RVA: 0xABE020 Offset: 0xABC620 VA: 0x180ABE020
	public bool NetworkConstruct() { }

	// RVA: 0xABDB40 Offset: 0xABC140 VA: 0x180ABDB40
	public void Clear() { }

	// RVA: 0xABED00 Offset: 0xABD300 VA: 0x180ABED00
	public static void Strip(GameObject obj) { }

	// RVA: 0xABEE40 Offset: 0xABD440 VA: 0x180ABEE40
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

	// RVA: 0xAC6E40 Offset: 0xAC5440 VA: 0x180AC6E40
	public static void Run(Effect.Type fxtype, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal) { }

	// RVA: 0xAC7140 Offset: 0xAC5740 VA: 0x180AC7140
	public static void Run(string strName, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal) { }

	// RVA: 0xAC6F70 Offset: 0xAC5570 VA: 0x180AC6F70
	public static void Run(Effect.Type fxtype, Vector3 posWorld, Vector3 normWorld, Vector3 up) { }

	// RVA: 0xAC72B0 Offset: 0xAC58B0 VA: 0x180AC72B0
	public static void Run(string strName, Vector3 posWorld, Vector3 normWorld, Vector3 up, Effect.Type overrideType = 0) { }

	// RVA: 0xAC6BE0 Offset: 0xAC51E0 VA: 0x180AC6BE0
	public static void Run(string strName, GameObject obj) { }

	// RVA: 0xAC6350 Offset: 0xAC4950 VA: 0x180AC6350
	public static void DoAdditiveImpactEffect(HitInfo info, string effectName) { }

	// RVA: 0xAC65A0 Offset: 0xAC4BA0 VA: 0x180AC65A0
	public static void ImpactEffect(HitInfo info) { }

}

public static class Effect.server // TypeDefIndex: 9334
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void Run(Effect.Type fxtype, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, Connection sourceConnection, bool broadcast = False) { }

	// RVA: 0xAC7A40 Offset: 0xAC6040 VA: 0x180AC7A40
	public static void Run(string strName, BaseEntity ent, uint boneID, Vector3 posLocal, Vector3 normLocal, Connection sourceConnection, bool broadcast = False) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void Run(Effect.Type fxtype, Vector3 posWorld, Vector3 normWorld, Connection sourceConnection, bool broadcast = False) { }

	// RVA: 0xAC7A40 Offset: 0xAC6040 VA: 0x180AC7A40
	public static void Run(string strName, Vector3 posWorld, Vector3 normWorld, Connection sourceConnection, bool broadcast = False) { }

	// RVA: 0xAC74C0 Offset: 0xAC5AC0 VA: 0x180AC74C0
	public static void DoAdditiveImpactEffect(HitInfo info, string effectName) { }

	// RVA: 0xAC74F0 Offset: 0xAC5AF0 VA: 0x180AC74F0
	public static void ImpactEffect(HitInfo info) { }

}

public class EffectAudioPerspectiveSwitcher : MonoBehaviour, IEffect, IPrefabPreProcess // TypeDefIndex: 9335
{	// Fields
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public EffectParentToWeaponBone parentToWeaponComponent; // 0x18

	// Methods

	// RVA: 0xAB8CE0 Offset: 0xAB72E0 VA: 0x180AB8CE0
	private BaseViewModel GetViewModel(Effect effect) { }

	// RVA: 0xAB9380 Offset: 0xAB7980 VA: 0x180AB9380 Slot: 6
	public virtual void SetupEffect(Effect effect) { }

	// RVA: 0xAB9280 Offset: 0xAB7880 VA: 0x180AB9280
	private void MakeThirdPerson() { }

	// RVA: 0xAB9120 Offset: 0xAB7720 VA: 0x180AB9120
	private void MakeFirstPerson() { }

	// RVA: 0xAB9320 Offset: 0xAB7920 VA: 0x180AB9320 Slot: 5
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public static class EffectLibrary // TypeDefIndex: 9338
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xABADD0 Offset: 0xAB93D0 VA: 0x180ABADD0
	private static void SetupEffect(GameObject go, Effect effect) { }

	// RVA: 0xABAA40 Offset: 0xAB9040 VA: 0x180ABAA40
	private static void GenericEffectSpawn(Effect effect) { }

	// RVA: 0xABAA70 Offset: 0xAB9070 VA: 0x180ABAA70
	private static void ProjectileEffectSpawn(Effect effect) { }

	// RVA: 0xABAD80 Offset: 0xAB9380 VA: 0x180ABAD80
	public static void Run(Effect fx) { }

	// RVA: 0xABA870 Offset: 0xAB8E70 VA: 0x180ABA870
	public static GameObject CreateEffect(string strPrefab, Transform parent, Vector3 pos, Quaternion rot) { }

	// RVA: 0xAB9FD0 Offset: 0xAB85D0 VA: 0x180AB9FD0
	public static GameObject CreateEffect(string strPrefab, Effect effect) { }

	// RVA: 0xABA6F0 Offset: 0xAB8CF0 VA: 0x180ABA6F0
	public static GameObject CreateEffect(string strPrefab, Vector3 vPos, Quaternion aAngle) { }

}

public class EffectMuzzleFlash : MonoBehaviour, IEffect // TypeDefIndex: 9339
{	// Methods

	// RVA: 0xABB900 Offset: 0xAB9F00 VA: 0x180ABB900 Slot: 5
	public virtual void SetupEffect(Effect effect) { }

	// RVA: 0xABB6A0 Offset: 0xAB9CA0 VA: 0x180ABB6A0
	private bool ApplyToViewModel() { }

	// RVA: 0xABB8B0 Offset: 0xAB9EB0 VA: 0x180ABB8B0
	private void PositionOnObject(Transform muzzle) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public static class EffectNetwork // TypeDefIndex: 9340
{	// Fields
	private static Effect effect; // 0x1D16

	// Methods

	// RVA: 0xABBA80 Offset: 0xABA080 VA: 0x180ABBA80
	public static void OnReceivedEffect(Message msg) { }

	// RVA: 0xABBD80 Offset: 0xABA380 VA: 0x180ABBD80
	private static void .cctor() { }

}

public class EffectParentToWeaponBone : BaseMonoBehaviour, IEffect // TypeDefIndex: 9341
{	// Fields
	public string boneName; // 0x18
	public bool singleFrame; // 0x20
	private bool isFirstPerson; // 0x21
	private Transform bone; // 0x28

	// Methods

	// RVA: 0xABC650 Offset: 0xABAC50 VA: 0x180ABC650 Slot: 7
	public virtual void SetupEffect(Effect effect) { }

	// RVA: 0xABC0D0 Offset: 0xABA6D0 VA: 0x180ABC0D0
	private void LateUpdate() { }

	// RVA: 0xABBDE0 Offset: 0xABA3E0 VA: 0x180ABBDE0
	private bool ApplyToViewModel() { }

	// RVA: 0xABC320 Offset: 0xABA920 VA: 0x180ABC320
	private void PositionOnObject(GameObject wm) { }

	// RVA: 0xABC0A0 Offset: 0xABA6A0 VA: 0x180ABC0A0
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

	// RVA: 0xABD680 Offset: 0xABBC80 VA: 0x180ABD680 Slot: 5
	public virtual void SetupEffect(Effect effect) { }

	// RVA: 0xABDB10 Offset: 0xABC110 VA: 0x180ABDB10
	public void .ctor() { }

	// RVA: 0xABDAD0 Offset: 0xABC0D0 VA: 0x180ABDAD0
	private static void .cctor() { }

}

public class EffectBlood : EffectRecycle // TypeDefIndex: 9854
{	// Fields
	public GameObjectRef ReplacementEffect; // 0x38

	// Methods

	// RVA: 0xAB95F0 Offset: 0xAB7BF0 VA: 0x180AB95F0 Slot: 10
	protected override void OnEnable() { }

	// RVA: 0x521BF0 Offset: 0x5201F0 VA: 0x180521BF0
	public void .ctor() { }

}

public class EffectDictionary // TypeDefIndex: 9855
{	// Fields
	private static Dictionary<string, string[]> effectDictionary; // 0x2CE0

	// Methods

	// RVA: 0xAB9D00 Offset: 0xAB8300 VA: 0x180AB9D00
	public static string GetParticle(string impactType, string materialName) { }

	// RVA: 0xAB9BE0 Offset: 0xAB81E0 VA: 0x180AB9BE0
	public static string GetParticle(DamageType damageType, string materialName) { }

	// RVA: 0xAB99E0 Offset: 0xAB7FE0 VA: 0x180AB99E0
	public static string GetDecal(string impactType, string materialName) { }

	// RVA: 0xAB9A50 Offset: 0xAB8050 VA: 0x180AB9A50
	public static string GetDecal(DamageType damageType, string materialName) { }

	// RVA: 0xAB9B70 Offset: 0xAB8170 VA: 0x180AB9B70
	public static string GetDisplacement(string impactType, string materialName) { }

	// RVA: 0xAB9D70 Offset: 0xAB8370 VA: 0x180AB9D70
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

	// RVA: 0xABCED0 Offset: 0xABB4D0 VA: 0x180ABCED0
	protected void Awake() { }

	// RVA: 0xABD0A0 Offset: 0xABB6A0 VA: 0x180ABD0A0
	private float GetParticleSystemLength() { }

	// RVA: 0xABD300 Offset: 0xABB900 VA: 0x180ABD300
	private float GetSoundLength() { }

	// RVA: 0xABD220 Offset: 0xABB820 VA: 0x180ABD220
	private float GetScreenShakeLength() { }

	// RVA: 0xABD5D0 Offset: 0xABBBD0 VA: 0x180ABD5D0 Slot: 9
	public virtual Transform RagdollInhertTransform() { }

	// RVA: 0xABD4E0 Offset: 0xABBAE0 VA: 0x180ABD4E0 Slot: 10
	protected virtual void OnEnable() { }

	// RVA: 0xABD5E0 Offset: 0xABBBE0 VA: 0x180ABD5E0 Slot: 7
	public void Recycle() { }

	// RVA: 0xABCF80 Offset: 0xABB580 VA: 0x180ABCF80
	private void DetachFromParent() { }

	// RVA: 0xABD050 Offset: 0xABB650 VA: 0x180ABD050
	private void DetachWaitRecycle() { }

	// RVA: 0xABD580 Offset: 0xABBB80 VA: 0x180ABD580 Slot: 8
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

	// RVA: 0xABC9D0 Offset: 0xABAFD0 VA: 0x180ABC9D0
	protected void Awake() { }

	// RVA: 0xABCC00 Offset: 0xABB200 VA: 0x180ABCC00 Slot: 6
	public void Recycle() { }

	// RVA: 0xABCA50 Offset: 0xABB050 VA: 0x180ABCA50
	private void DetachFromParent() { }

	// RVA: 0xABCB20 Offset: 0xABB120 VA: 0x180ABCB20 Slot: 7
	public void OnParentDestroying() { }

	// RVA: 0xABCC90 Offset: 0xABB290 VA: 0x180ABCC90
	public void .ctor() { }

}

public class EffectRecycleLite : BasePrefab, IClientComponent, IEffectRecycle, IOnParentDestroying // TypeDefIndex: 9860
{	// Fields
	private const float lifeTime = 60;
	private Action recycleAction; // 0x20

	// Methods

	// RVA: 0xABCCA0 Offset: 0xABB2A0 VA: 0x180ABCCA0
	protected void Awake() { }

	// RVA: 0xABCD20 Offset: 0xABB320 VA: 0x180ABCD20
	protected void OnEnable() { }

	// RVA: 0xABCE40 Offset: 0xABB440 VA: 0x180ABCE40 Slot: 8
	public void Recycle() { }

	// RVA: 0xABCDA0 Offset: 0xABB3A0 VA: 0x180ABCDA0 Slot: 9
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

	// RVA: 0x6DC400 Offset: 0x6DAA00 VA: 0x1806DC400
	public static int get_antialiasing() { }

	// RVA: 0x6DC6B0 Offset: 0x6DACB0 VA: 0x1806DC6B0
	public static void set_antialiasing(int value) { }

	// RVA: 0x6DC460 Offset: 0x6DAA60 VA: 0x1806DC460
	public static bool get_requireMotionVectors() { }

	// RVA: 0x6DC360 Offset: 0x6DA960 VA: 0x1806DC360
	public static Effects.AntiAliasingType get_AntiAliasingMode() { }

	// RVA: 0x6DC5D0 Offset: 0x6DABD0 VA: 0x1806DC5D0
	public static void set_AntiAliasingMode(Effects.AntiAliasingType value) { }

	// RVA: 0x6DBE80 Offset: 0x6DA480 VA: 0x1806DBE80
	public static int ClearAllGibs() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6DC130 Offset: 0x6DA730 VA: 0x1806DC130
	public static void ClearAllGibs(ConsoleSystem.Arg arg) { }

	// RVA: 0x6DC300 Offset: 0x6DA900 VA: 0x1806DC300
	public void .ctor() { }

	// RVA: 0x6DC1C0 Offset: 0x6DA7C0 VA: 0x1806DC1C0
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

