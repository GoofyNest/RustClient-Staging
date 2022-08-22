public abstract class PrefabAttribute : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 11330
{	// Fields
	public Vector3 worldPosition; // 0x18
	public Quaternion worldRotation; // 0x24
	public Vector3 worldForward; // 0x34
	public Vector3 localPosition; // 0x40
	public Vector3 localScale; // 0x4C
	public Quaternion localRotation; // 0x58
	public string fullName; // 0x68
	public string hierachyName; // 0x70
	public uint prefabID; // 0x78
	public int instanceID; // 0x7C
	public PrefabAttribute.Library prefabAttribute; // 0x80
	public GameManager gameManager; // 0x88
	public bool isServer; // 0x90
	public static PrefabAttribute.Library client; // 0x0

	// Properties
	public bool isClient { get; }

	// Methods

	// RVA: 0x9A1710 Offset: 0x99FD10 VA: 0x1809A1710
	public bool get_isClient() { }

	// RVA: 0x9A1210 Offset: 0x99F810 VA: 0x1809A1210 Slot: 5
	public virtual void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	protected virtual void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract Type GetIndexedType();

	// RVA: 0x9A1720 Offset: 0x99FD20 VA: 0x1809A1720
	public static bool op_Equality(PrefabAttribute x, PrefabAttribute y) { }

	// RVA: 0x9A17C0 Offset: 0x99FDC0 VA: 0x1809A17C0
	public static bool op_Inequality(PrefabAttribute x, PrefabAttribute y) { }

	// RVA: 0x9A1120 Offset: 0x99F720 VA: 0x1809A1120 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x9A11E0 Offset: 0x99F7E0 VA: 0x1809A11E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x682990 Offset: 0x680F90 VA: 0x180682990
	public static bool op_Implicit(PrefabAttribute exists) { }

	// RVA: 0x9A10D0 Offset: 0x99F6D0 VA: 0x1809A10D0
	internal static bool ComparePrefabAttribute(PrefabAttribute x, PrefabAttribute y) { }

	// RVA: 0x9A1620 Offset: 0x99FC20 VA: 0x1809A1620 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

	// RVA: 0x9A1660 Offset: 0x99FC60 VA: 0x1809A1660
	private static void .cctor() { }

}

public class PrefabAttribute.AttributeCollection // TypeDefIndex: 11331
{	// Fields
	private Dictionary<Type, List<PrefabAttribute>> attributes; // 0x10
	private Dictionary<Type, object> cache; // 0x18

	// Methods

	// RVA: 0x98CCC0 Offset: 0x98B2C0 VA: 0x18098CCC0
	internal List<PrefabAttribute> Find(Type t) { }

	// RVA: -1 Offset: -1
	public T[] Find<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A36900 Offset: 0x1A34F00 VA: 0x181A36900
	|-PrefabAttribute.AttributeCollection.Find<object>
	*/

	// RVA: 0x98CB40 Offset: 0x98B140 VA: 0x18098CB40
	public void Add(PrefabAttribute attribute) { }

	// RVA: 0x98CD80 Offset: 0x98B380 VA: 0x18098CD80
	public void .ctor() { }

}

public class PrefabAttribute.Library // TypeDefIndex: 11332
{	// Fields
	public bool clientside; // 0x10
	public bool serverside; // 0x11
	private Dictionary<uint, PrefabAttribute.AttributeCollection> prefabs; // 0x18

	// Methods

	// RVA: 0x98D2A0 Offset: 0x98B8A0 VA: 0x18098D2A0
	public void .ctor(bool clientside, bool serverside) { }

	// RVA: 0x98D0B0 Offset: 0x98B6B0 VA: 0x18098D0B0
	public PrefabAttribute.AttributeCollection Find(uint prefabID, bool warmup = True) { }

	// RVA: -1 Offset: -1
	public T Find<T>(uint prefabID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D16A0 Offset: 0x5CFCA0 VA: 0x1805D16A0
	|-PrefabAttribute.Library.Find<CardGameSounds>
	|-PrefabAttribute.Library.Find<Construction>
	|-PrefabAttribute.Library.Find<DecorSocketFemale>
	|-PrefabAttribute.Library.Find<DecorSocketMale>
	|-PrefabAttribute.Library.Find<DeployShell>
	|-PrefabAttribute.Library.Find<Deployable>
	|-PrefabAttribute.Library.Find<DiscoFloorColourLookups>
	|-PrefabAttribute.Library.Find<PathSequence>
	|-PrefabAttribute.Library.Find<PetCommandList>
	|-PrefabAttribute.Library.Find<PlayerModelCinematicList>
	|-PrefabAttribute.Library.Find<PrefabInformation>
	|-PrefabAttribute.Library.Find<RigidbodyInfo>
	|-PrefabAttribute.Library.Find<object>
	|-PrefabAttribute.Library.Find<Upkeep>
	*/

	// RVA: -1 Offset: -1
	public T[] FindAll<T>(uint prefabID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3ADA0 Offset: 0x1A393A0 VA: 0x181A3ADA0
	|-PrefabAttribute.Library.FindAll<AttractionPoint>
	|-PrefabAttribute.Library.FindAll<ConditionalModel>
	|-PrefabAttribute.Library.FindAll<DecalComponent>
	|-PrefabAttribute.Library.FindAll<DecorComponent>
	|-PrefabAttribute.Library.FindAll<DeployVolume>
	|-PrefabAttribute.Library.FindAll<Gibbable>
	|-PrefabAttribute.Library.FindAll<Socket_Base>
	|-PrefabAttribute.Library.FindAll<object>
	|-PrefabAttribute.Library.FindAll<TerrainAnchor>
	|-PrefabAttribute.Library.FindAll<TerrainCheck>
	|-PrefabAttribute.Library.FindAll<TerrainFilter>
	|-PrefabAttribute.Library.FindAll<TerrainModifier>
	|-PrefabAttribute.Library.FindAll<TerrainPlacement>
	|-PrefabAttribute.Library.FindAll<WaterCheck>
	*/

	// RVA: 0x98CE20 Offset: 0x98B420 VA: 0x18098CE20
	public void Add(uint prefabID, PrefabAttribute attribute) { }

	// RVA: 0x98D240 Offset: 0x98B840 VA: 0x18098D240
	public void Invalidate(uint prefabID) { }

}

