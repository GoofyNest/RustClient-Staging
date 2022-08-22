public class Object // TypeDefIndex: 383
{	// Methods

	// RVA: 0xAE6170 Offset: 0xAE4770 VA: 0x180AE6170 Slot: 0
	public virtual bool Equals(object obj) { }

	// RVA: 0x16815C0 Offset: 0x167FBC0 VA: 0x1816815C0
	public static bool Equals(object objA, object objB) { }

	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void .ctor() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 1
	protected virtual void Finalize() { }

	// RVA: 0x16815F0 Offset: 0x167FBF0 VA: 0x1816815F0 Slot: 2
	public virtual int GetHashCode() { }

	// RVA: 0x1681600 Offset: 0x167FC00 VA: 0x181681600
	public Type GetType() { }

	// RVA: 0x1681610 Offset: 0x167FC10 VA: 0x181681610
	protected object MemberwiseClone() { }

	// RVA: 0x1681620 Offset: 0x167FC20 VA: 0x181681620 Slot: 3
	public virtual string ToString() { }

	// RVA: 0x16815F0 Offset: 0x167FBF0 VA: 0x1816815F0
	internal static int InternalGetHashCode(object o) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void FieldGetter(string typeName, string fieldName, ref object val) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void FieldSetter(string typeName, string fieldName, object val) { }

}

public class Object // TypeDefIndex: 3535
{	// Fields
	private IntPtr m_CachedPtr; // 0x10
	internal static int OffsetOfInstanceIDInCPlusPlusObject; // 0x0
	private const string objectIsNullMessage = "The Object you want to instantiate is null.";
	private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.";

	// Properties
	public string name { get; set; }
	public HideFlags hideFlags { get; set; }

	// Methods

	// RVA: 0x18F7C20 Offset: 0x18F6220 VA: 0x1818F7C20
	public int GetInstanceID() { }

	// RVA: 0x18F7C10 Offset: 0x18F6210 VA: 0x1818F7C10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18F7830 Offset: 0x18F5E30 VA: 0x1818F7830 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x18F90B0 Offset: 0x18F76B0 VA: 0x1818F90B0
	public static bool op_Implicit(Object exists) { }

	// RVA: 0x18F7540 Offset: 0x18F5B40 VA: 0x1818F7540
	private static bool CompareBaseObjects(Object lhs, Object rhs) { }

	// RVA: 0x18F8D00 Offset: 0x18F7300 VA: 0x1818F8D00
	private static bool IsNativeObjectAlive(Object o) { }

	// RVA: 0x180B0F0 Offset: 0x18096F0 VA: 0x18180B0F0
	private IntPtr GetCachedPtr() { }

	// RVA: 0x18F8ED0 Offset: 0x18F74D0 VA: 0x1818F8ED0
	public string get_name() { }

	// RVA: 0x18F9330 Offset: 0x18F7930 VA: 0x1818F9330
	public void set_name(string value) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5BE0 Offset: 0xC4FE0 VA: 0x1800C5BE0
	// RVA: 0x18F8780 Offset: 0x18F6D80 VA: 0x1818F8780
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5BE0 Offset: 0xC4FE0 VA: 0x1800C5BE0
	// RVA: 0x18F7F80 Offset: 0x18F6580 VA: 0x1818F7F80
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5BE0 Offset: 0xC4FE0 VA: 0x1800C5BE0
	// RVA: 0x18F7DC0 Offset: 0x18F63C0 VA: 0x1818F7DC0
	public static Object Instantiate(Object original) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5BE0 Offset: 0xC4FE0 VA: 0x1800C5BE0
	// RVA: 0x18F8300 Offset: 0x18F6900 VA: 0x1818F8300
	public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace) { }

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B8F10 Offset: 0x15B7510 VA: 0x1815B8F10
	|-Object.Instantiate<ERMarkerExt>
	|-Object.Instantiate<ERSOMarkerExt>
	|-Object.Instantiate<ERSORoadExt>
	|-Object.Instantiate<ItemSearchEntry>
	|-Object.Instantiate<TechTreeDialog>
	|-Object.Instantiate<TechTreeEntry>
	|-Object.Instantiate<TechTreeGroup>
	|-Object.Instantiate<TechTreeLine>
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<Material>
	|-Object.Instantiate<Mesh>
	|-Object.Instantiate<ParticleSystem>
	|-Object.Instantiate<PostProcessEffectSettings>
	|-Object.Instantiate<Texture2D>
	|-Object.Instantiate<Transform>
	|-Object.Instantiate<Dropdown.DropdownItem>
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9250 Offset: 0x15B7850 VA: 0x1815B9250
	|-Object.Instantiate<ArcadeEntity>
	|-Object.Instantiate<ArcadeEntityController>
	|-Object.Instantiate<BaseArcadeGame>
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9160 Offset: 0x15B7760 VA: 0x1815B9160
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9020 Offset: 0x15B7620 VA: 0x1815B9020
	|-Object.Instantiate<ContactsEntry>
	|-Object.Instantiate<HttpImage>
	|-Object.Instantiate<RustText>
	|-Object.Instantiate<SleepingBagButton>
	|-Object.Instantiate<SleepingBagClusterMapMarker>
	|-Object.Instantiate<SleepingBagMapMarker>
	|-Object.Instantiate<UIMapVendingMachineMarker>
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Transform parent, bool worldPositionStays) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B90A0 Offset: 0x15B76A0 VA: 0x1815B90A0
	|-Object.Instantiate<object>
	*/

	[NativeMethodAttribute] // RVA: 0xC5F20 Offset: 0xC5320 VA: 0x1800C5F20
	// RVA: 0x18F7730 Offset: 0x18F5D30 VA: 0x1818F7730
	public static void Destroy(Object obj, float t) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F7780 Offset: 0x18F5D80 VA: 0x1818F7780
	public static void Destroy(Object obj) { }

	[NativeMethodAttribute] // RVA: 0xC6230 Offset: 0xC5630 VA: 0x1800C6230
	// RVA: 0x18F76E0 Offset: 0x18F5CE0 VA: 0x1818F76E0
	public static void DestroyImmediate(Object obj, bool allowDestroyingAssets) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F7670 Offset: 0x18F5C70 VA: 0x1818F7670
	public static void DestroyImmediate(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0xC6380 Offset: 0xC5780 VA: 0x1800C6380
	[TypeInferenceRuleAttribute] // RVA: 0xC6380 Offset: 0xC5780 VA: 0x1800C6380
	// RVA: 0x18F7BD0 Offset: 0x18F61D0 VA: 0x1818F7BD0
	public static Object[] FindObjectsOfType(Type type) { }

	[FreeFunctionAttribute] // RVA: 0xC6410 Offset: 0xC5810 VA: 0x1800C6410
	// RVA: 0x18F77F0 Offset: 0x18F5DF0 VA: 0x1818F77F0
	public static void DontDestroyOnLoad(Object target) { }

	// RVA: 0x18F8E90 Offset: 0x18F7490 VA: 0x1818F8E90
	public HideFlags get_hideFlags() { }

	// RVA: 0x18F92F0 Offset: 0x18F78F0 VA: 0x1818F92F0
	public void set_hideFlags(HideFlags value) { }

	// RVA: -1 Offset: -1
	public static T[] FindObjectsOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3AFB0 Offset: 0x1A395B0 VA: 0x181A3AFB0
	|-Object.FindObjectsOfType<BaseEntity>
	|-Object.FindObjectsOfType<BenchmarkScene>
	|-Object.FindObjectsOfType<BlendedLoopEngineSound>
	|-Object.FindObjectsOfType<DamageRenderer>
	|-Object.FindObjectsOfType<GameSetup>
	|-Object.FindObjectsOfType<LaserBeam>
	|-Object.FindObjectsOfType<RendererBatch>
	|-Object.FindObjectsOfType<PropRenderer>
	|-Object.FindObjectsOfType<SingletonComponent>
	|-Object.FindObjectsOfType<Animator>
	|-Object.FindObjectsOfType<BoxCollider>
	|-Object.FindObjectsOfType<CapsuleCollider>
	|-Object.FindObjectsOfType<Collider>
	|-Object.FindObjectsOfType<LODGroup>
	|-Object.FindObjectsOfType<MeshCollider>
	|-Object.FindObjectsOfType<Object>
	|-Object.FindObjectsOfType<ParticleSystem>
	|-Object.FindObjectsOfType<Renderer>
	|-Object.FindObjectsOfType<Rigidbody>
	|-Object.FindObjectsOfType<SphereCollider>
	|-Object.FindObjectsOfType<Texture>
	|-Object.FindObjectsOfType<Transform>
	|-Object.FindObjectsOfType<WearableShadowLod>
	|-Object.FindObjectsOfType<object>
	*/

	// RVA: -1 Offset: -1
	public static T FindObjectOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B8E30 Offset: 0x15B7430 VA: 0x1815B8E30
	|-Object.FindObjectOfType<Client>
	|-Object.FindObjectOfType<CursorManager>
	|-Object.FindObjectOfType<MainCamera>
	|-Object.FindObjectOfType<MusicManager>
	|-Object.FindObjectOfType<Performance>
	|-Object.FindObjectOfType<SoundManager>
	|-Object.FindObjectOfType<Terrain>
	|-Object.FindObjectOfType<WindZone>
	|-Object.FindObjectOfType<object>
	*/

	// RVA: 0x18F74D0 Offset: 0x18F5AD0 VA: 0x1818F74D0
	private static void CheckNullArgument(object arg, string message) { }

	[TypeInferenceRuleAttribute] // RVA: 0xB9C80 Offset: 0xB9080 VA: 0x1800B9C80
	// RVA: 0x18F7B40 Offset: 0x18F6140 VA: 0x1818F7B40
	public static Object FindObjectOfType(Type type) { }

	// RVA: 0x18F8DA0 Offset: 0x18F73A0 VA: 0x1818F8DA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x18F8F40 Offset: 0x18F7540 VA: 0x1818F8F40
	public static bool op_Equality(Object x, Object y) { }

	// RVA: 0x18F9180 Offset: 0x18F7780 VA: 0x1818F9180
	public static bool op_Inequality(Object x, Object y) { }

	[NativeMethodAttribute] // RVA: 0xC6530 Offset: 0xC5930 VA: 0x1800C6530
	// RVA: 0x18F7D90 Offset: 0x18F6390 VA: 0x1818F7D90
	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	[FreeFunctionAttribute] // RVA: 0xC6590 Offset: 0xC5990 VA: 0x1800C6590
	// RVA: 0x18F8AC0 Offset: 0x18F70C0 VA: 0x1818F8AC0
	private static Object Internal_CloneSingle(Object data) { }

	[FreeFunctionAttribute] // RVA: 0xC6590 Offset: 0xC5990 VA: 0x1800C6590
	// RVA: 0x18F8A60 Offset: 0x18F7060 VA: 0x1818F8A60
	private static Object Internal_CloneSingleWithParent(Object data, Transform parent, bool worldPositionStays) { }

	[FreeFunctionAttribute] // RVA: 0xC6720 Offset: 0xC5B20 VA: 0x1800C6720
	// RVA: 0x18F8C70 Offset: 0x18F7270 VA: 0x1818F8C70
	private static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot) { }

	[FreeFunctionAttribute] // RVA: 0xC6720 Offset: 0xC5B20 VA: 0x1800C6720
	// RVA: 0x18F8B70 Offset: 0x18F7170 VA: 0x1818F8B70
	private static Object Internal_InstantiateSingleWithParent(Object data, Transform parent, Vector3 pos, Quaternion rot) { }

	[FreeFunctionAttribute] // RVA: 0xC6A30 Offset: 0xC5E30 VA: 0x1800C6A30
	// RVA: 0x18F8E10 Offset: 0x18F7410 VA: 0x1818F8E10
	private static string ToString(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0xC6AF0 Offset: 0xC5EF0 VA: 0x1800C6AF0
	// RVA: 0x18F7D50 Offset: 0x18F6350 VA: 0x1818F7D50
	private static string GetName(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0xC6BB0 Offset: 0xC5FB0 VA: 0x1800C6BB0
	// RVA: 0x18F8D50 Offset: 0x18F7350 VA: 0x1818F8D50
	private static void SetName(Object obj, string name) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xC6C70 Offset: 0xC6070 VA: 0x1800C6C70
	[FreeFunctionAttribute] // RVA: 0xC6C70 Offset: 0xC6070 VA: 0x1800C6C70
	// RVA: 0x18F7B00 Offset: 0x18F6100 VA: 0x1818F7B00
	internal static Object FindObjectFromInstanceID(int instanceID) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x18F8E50 Offset: 0x18F7450 VA: 0x1818F8E50
	private static void .cctor() { }

	// RVA: 0x18F8C10 Offset: 0x18F7210 VA: 0x1818F8C10
	private static Object Internal_InstantiateSingle_Injected(Object data, ref Vector3 pos, ref Quaternion rot) { }

	// RVA: 0x18F8B00 Offset: 0x18F7100 VA: 0x1818F8B00
	private static Object Internal_InstantiateSingleWithParent_Injected(Object data, Transform parent, ref Vector3 pos, ref Quaternion rot) { }

}

public class Object : IEnumerable<KeyValuePair<string, Value>>, IEnumerable // TypeDefIndex: 8141
{	// Fields
	private readonly IDictionary<string, Value> values; // 0x10

	// Properties
	public Value Item { get; set; }

	// Methods

	// RVA: 0x1073C70 Offset: 0x1072270 VA: 0x181073C70
	public void .ctor() { }

	// RVA: 0x10739C0 Offset: 0x1071FC0 VA: 0x1810739C0
	public void .ctor(Object other) { }

	// RVA: 0x1072150 Offset: 0x1070750 VA: 0x181072150
	public bool ContainsKey(string key) { }

	// RVA: 0x1072520 Offset: 0x1070B20 VA: 0x181072520
	public Value GetValue(string key) { }

	// RVA: 0x1072490 Offset: 0x1070A90 VA: 0x181072490
	public string GetString(string key, string strDEFAULT = "") { }

	// RVA: 0x1072340 Offset: 0x1070940 VA: 0x181072340
	public double GetNumber(string key, double iDefault = 0) { }

	// RVA: 0x1072320 Offset: 0x1070920 VA: 0x181072320
	public int GetInt(string key, int iDefault = 0) { }

	// RVA: 0x1072300 Offset: 0x1070900 VA: 0x181072300
	public float GetFloat(string key, float iDefault = 0) { }

	// RVA: 0x1072410 Offset: 0x1070A10 VA: 0x181072410
	public Object GetObject(string key) { }

	// RVA: 0x1072250 Offset: 0x1070850 VA: 0x181072250
	public bool GetBoolean(string key, bool bDefault = False) { }

	// RVA: 0x10721D0 Offset: 0x10707D0 VA: 0x1810721D0
	public Array GetArray(string key) { }

	// RVA: 0x1073CE0 Offset: 0x10722E0 VA: 0x181073CE0
	public Value get_Item(string key) { }

	// RVA: 0x1073CF0 Offset: 0x10722F0 VA: 0x181073CF0
	public void set_Item(string key, Value value) { }

	// RVA: 0x1072020 Offset: 0x1070620 VA: 0x181072020
	public void Add(string key, Value value) { }

	// RVA: 0x1072090 Offset: 0x1070690 VA: 0x181072090
	public void Add(KeyValuePair<string, Value> pair) { }

	// RVA: 0x10728B0 Offset: 0x1070EB0 VA: 0x1810728B0
	public static Object Parse(string jsonString) { }

	// RVA: 0x10735B0 Offset: 0x1071BB0 VA: 0x1810735B0
	private static int SkipWhitespace(string str, int pos) { }

	// RVA: 0x10727A0 Offset: 0x1070DA0 VA: 0x1810727A0
	private static string ParseString(string str, ref int startPosition) { }

	// RVA: 0x10725F0 Offset: 0x1070BF0 VA: 0x1810725F0
	private static double ParseNumber(string str, ref int startPosition) { }

	// RVA: 0x10721B0 Offset: 0x10707B0 VA: 0x1810721B0
	private static Object Fail(char expected, int position) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0
	private static Object Fail(string expected, int position) { }

	// RVA: 0x10736A0 Offset: 0x1071CA0 VA: 0x1810736A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x10722B0 Offset: 0x10708B0 VA: 0x1810722B0 Slot: 4
	public IEnumerator<KeyValuePair<string, Value>> GetEnumerator() { }

	// RVA: 0x1073650 Offset: 0x1071C50 VA: 0x181073650 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1072100 Offset: 0x1070700 VA: 0x181072100
	public void Clear() { }

	// RVA: 0x1073530 Offset: 0x1071B30 VA: 0x181073530
	public void Remove(string key) { }

}

private enum Object.ParsingState // TypeDefIndex: 8142
{	// Fields
	public int value__; // 0x0
	public const Object.ParsingState Object = 0;
	public const Object.ParsingState Array = 1;
	public const Object.ParsingState EndObject = 2;
	public const Object.ParsingState EndArray = 3;
	public const Object.ParsingState Key = 4;
	public const Object.ParsingState Value = 5;
	public const Object.ParsingState KeyValueSeparator = 6;
	public const Object.ParsingState ValueSeparator = 7;
	public const Object.ParsingState String = 8;
	public const Object.ParsingState Number = 9;
	public const Object.ParsingState Boolean = 10;
	public const Object.ParsingState Null = 11;

}

