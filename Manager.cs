public class Manager : IDisposable // TypeDefIndex: 6709
{	// Fields
	private Dictionary<uint, Group> groups; // 0x10
	internal Provider provider; // 0x18

	// Methods

	// RVA: 0x220F310 Offset: 0x220D910 VA: 0x18220F310 Slot: 5
	public virtual void Dispose() { }

	// RVA: 0x220F930 Offset: 0x220DF30 VA: 0x18220F930
	public void .ctor(Provider p) { }

	// RVA: 0x220F8B0 Offset: 0x220DEB0 VA: 0x18220F8B0
	public Group TryGet(uint ID) { }

	// RVA: 0x220F640 Offset: 0x220DC40 VA: 0x18220F640
	public Group Get(uint ID) { }

	// RVA: 0x220F200 Offset: 0x220D800 VA: 0x18220F200
	public Subscriber CreateSubscriber(Connection connection) { }

	// RVA: 0x220F2A0 Offset: 0x220D8A0 VA: 0x18220F2A0
	public void DestroySubscriber(ref Subscriber subscriber) { }

	// RVA: 0x220F7B0 Offset: 0x220DDB0 VA: 0x18220F7B0
	public bool IsInside(Group group, Vector3 vPos) { }

	// RVA: 0x220F470 Offset: 0x220DA70 VA: 0x18220F470
	public Group GetGroup(Vector3 vPos) { }

	// RVA: 0x220F560 Offset: 0x220DB60 VA: 0x18220F560
	public void GetVisibleFromFar(Group center, List<Group> groups) { }

	// RVA: 0x220F5D0 Offset: 0x220DBD0 VA: 0x18220F5D0
	public void GetVisibleFromNear(Group center, List<Group> groups) { }

}

public static class Manager // TypeDefIndex: 7007
{	// Fields
	private static Dictionary<string, GameObject> Prefabs; // 0x3934

	// Methods

	// RVA: 0xFC40E0 Offset: 0xFC26E0 VA: 0x180FC40E0
	internal static GameObject CreatePrefab(string name) { }

	// RVA: -1 Offset: -1
	internal static T Create<T>(string prefabName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D19B0 Offset: 0x5CFFB0 VA: 0x1805D19B0
	|-Manager.Create<Blocker>
	|-Manager.Create<Dropdown>
	|-Manager.Create<Menu>
	|-Manager.Create<RustButton>
	|-Manager.Create<RustButtonGroup>
	|-Manager.Create<RustIcon>
	|-Manager.Create<RustInput>
	|-Manager.Create<RustLayout>
	|-Manager.Create<RustOption>
	|-Manager.Create<RustSlider>
	|-Manager.Create<RustText>
	|-Manager.Create<RustToggle>
	|-Manager.Create<RustWrapper>
	|-Manager.Create<TabControl>
	|-Manager.Create<Video>
	|-Manager.Create<object>
	|-Manager.Create<LayoutElement>
	*/

	// RVA: 0xFC42B0 Offset: 0xFC28B0 VA: 0x180FC42B0
	private static void .cctor() { }

}

public class Manager // TypeDefIndex: 7372
{	// Fields
	private const string hex = "0123456789abcdef";
	private static Manager manager; // 0x0
	private Hashtable handlers; // 0x10
	private Hashtable active; // 0x18
	private Hashtable assemblies; // 0x20
	private static readonly object lockobj; // 0x8

	// Properties
	public static Manager PrimaryManager { get; }

	// Methods

	// RVA: 0x22AC260 Offset: 0x22AA860 VA: 0x1822AC260
	private void .ctor() { }

	// RVA: 0x22AC200 Offset: 0x22AA800 VA: 0x1822AC200
	private static void .cctor() { }

	// RVA: 0x22AC360 Offset: 0x22AA960 VA: 0x1822AC360
	public static Manager get_PrimaryManager() { }

	// RVA: 0x22AC180 Offset: 0x22AA780 VA: 0x1822AC180
	private static string Normalize(string name) { }

	// RVA: 0x22AB980 Offset: 0x22A9F80 VA: 0x1822AB980
	public Encoding GetEncoding(int codePage) { }

	// RVA: 0x22AB590 Offset: 0x22A9B90 VA: 0x1822AB590
	public Encoding GetEncoding(string name) { }

	// RVA: 0x22AB180 Offset: 0x22A9780 VA: 0x1822AB180
	public CultureInfo GetCulture(int culture, bool useUserOverride) { }

	// RVA: 0x22AB370 Offset: 0x22A9970 VA: 0x1822AB370
	public CultureInfo GetCulture(string name, bool useUserOverride) { }

	// RVA: 0x22ABA30 Offset: 0x22AA030 VA: 0x1822ABA30
	internal object Instantiate(string name) { }

	// RVA: 0x22ABE60 Offset: 0x22AA460 VA: 0x1822ABE60
	private void LoadClassList() { }

	// RVA: 0x22AC020 Offset: 0x22AA620 VA: 0x1822AC020
	private void LoadInternalClasses() { }

}

