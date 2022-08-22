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

	// RVA: 0x9A1220 Offset: 0x99F820 VA: 0x1809A1220
	public bool get_isClient() { }

	// RVA: 0x9A0D20 Offset: 0x99F320 VA: 0x1809A0D20 Slot: 5
	public virtual void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	protected virtual void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract Type GetIndexedType();

	// RVA: 0x9A1230 Offset: 0x99F830 VA: 0x1809A1230
	public static bool op_Equality(PrefabAttribute x, PrefabAttribute y) { }

	// RVA: 0x9A12D0 Offset: 0x99F8D0 VA: 0x1809A12D0
	public static bool op_Inequality(PrefabAttribute x, PrefabAttribute y) { }

	// RVA: 0x9A0C30 Offset: 0x99F230 VA: 0x1809A0C30 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x9A0CF0 Offset: 0x99F2F0 VA: 0x1809A0CF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x682A00 Offset: 0x681000 VA: 0x180682A00
	public static bool op_Implicit(PrefabAttribute exists) { }

	// RVA: 0x9A0BE0 Offset: 0x99F1E0 VA: 0x1809A0BE0
	internal static bool ComparePrefabAttribute(PrefabAttribute x, PrefabAttribute y) { }

	// RVA: 0x9A1130 Offset: 0x99F730 VA: 0x1809A1130 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

	// RVA: 0x9A1170 Offset: 0x99F770 VA: 0x1809A1170
	private static void .cctor() { }

}

public class PrefabAttribute.AttributeCollection // TypeDefIndex: 11331
{	// Fields
	private Dictionary<Type, List<PrefabAttribute>> attributes; // 0x10
	private Dictionary<Type, object> cache; // 0x18

	// Methods

	// RVA: 0x98C7C0 Offset: 0x98ADC0 VA: 0x18098C7C0
	internal List<PrefabAttribute> Find(Type t) { }

	// RVA: -1 Offset: -1
	public T[] Find<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A371E0 Offset: 0x1A357E0 VA: 0x181A371E0
	|-PrefabAttribute.AttributeCollection.Find<object>
	*/

	// RVA: 0x98C640 Offset: 0x98AC40 VA: 0x18098C640
	public void Add(PrefabAttribute attribute) { }

	// RVA: 0x98C880 Offset: 0x98AE80 VA: 0x18098C880
	public void .ctor() { }

}

public class PrefabAttribute.Library // TypeDefIndex: 11332
{	// Fields
	public bool clientside; // 0x10
	public bool serverside; // 0x11
	private Dictionary<uint, PrefabAttribute.AttributeCollection> prefabs; // 0x18

	// Methods

	// RVA: 0x98CDA0 Offset: 0x98B3A0 VA: 0x18098CDA0
	public void .ctor(bool clientside, bool serverside) { }

	// RVA: 0x98CBB0 Offset: 0x98B1B0 VA: 0x18098CBB0
	public PrefabAttribute.AttributeCollection Find(uint prefabID, bool warmup = True) { }

	// RVA: -1 Offset: -1
	public T Find<T>(uint prefabID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1710 Offset: 0x5CFD10 VA: 0x1805D1710
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
	|-RVA: 0x1A3B680 Offset: 0x1A39C80 VA: 0x181A3B680
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

	// RVA: 0x98C920 Offset: 0x98AF20 VA: 0x18098C920
	public void Add(uint prefabID, PrefabAttribute attribute) { }

	// RVA: 0x98CD40 Offset: 0x98B340 VA: 0x18098CD40
	public void Invalidate(uint prefabID) { }

}

