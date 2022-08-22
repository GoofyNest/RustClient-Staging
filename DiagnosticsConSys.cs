public class DiagnosticsConSys : ConsoleSystem // TypeDefIndex: 9276
{	// Methods

	// RVA: 0x980AA0 Offset: 0x97F0A0 VA: 0x180980AA0
	private static void DumpAnimators(string targetFolder) { }

	// RVA: 0x981BC0 Offset: 0x9801C0 VA: 0x180981BC0
	private static void DumpEntities(string targetFolder) { }

	// RVA: 0x983650 Offset: 0x981C50 VA: 0x180983650
	private static void DumpLODGroups(string targetFolder) { }

	// RVA: 0x9831E0 Offset: 0x9817E0 VA: 0x1809831E0
	private static void DumpLODGroupTotals(string targetFolder) { }

	// RVA: 0x983660 Offset: 0x981C60 VA: 0x180983660
	private static void DumpNetwork(string targetFolder) { }

	// RVA: 0x9837E0 Offset: 0x981DE0 VA: 0x1809837E0
	private static void DumpObjects(string targetFolder) { }

	// RVA: 0x984150 Offset: 0x982750 VA: 0x180984150
	private static void DumpPhysics(string targetFolder) { }

	// RVA: 0x984DD0 Offset: 0x9833D0 VA: 0x180984DD0
	private static void DumpTotals(string targetFolder) { }

	// RVA: 0x981500 Offset: 0x97FB00 VA: 0x180981500
	private static void DumpColliders(string targetFolder) { }

	// RVA: 0x984180 Offset: 0x982780 VA: 0x180984180
	private static void DumpRigidBodies(string targetFolder) { }

	// RVA: 0x9825D0 Offset: 0x980BD0 VA: 0x1809825D0
	private static void DumpGameObjects(string targetFolder) { }

	// RVA: 0x9822E0 Offset: 0x9808E0 VA: 0x1809822E0
	private static void DumpGameObjectRecursive(StringBuilder str, Transform tx, int indent, bool includeComponents = False) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x985250 Offset: 0x983850 VA: 0x180985250
	public static void dump(ConsoleSystem.Arg args) { }

	// RVA: 0x984D70 Offset: 0x983370 VA: 0x180984D70
	private static void DumpSystemInformation(string targetFolder) { }

	// RVA: 0x9851E0 Offset: 0x9837E0 VA: 0x1809851E0
	private static void WriteTextToFile(string file, string text) { }

	// RVA: 0x9851F0 Offset: 0x9837F0 VA: 0x1809851F0
	public void .ctor() { }

}

private sealed class DiagnosticsConSys.<>c // TypeDefIndex: 9277
{	// Fields
	public static readonly DiagnosticsConSys.<>c <>9; // 0x0
	public static Func<Animator, string> <>9__0_0; // 0x8
	public static Func<IGrouping<string, Animator>, int> <>9__0_1; // 0x10
	public static Func<Animator, string> <>9__0_2; // 0x18
	public static Func<IGrouping<string, Animator>, int> <>9__0_3; // 0x20
	public static Func<BaseNetworkable, uint> <>9__1_0; // 0x28
	public static Func<IGrouping<uint, BaseNetworkable>, int> <>9__1_1; // 0x30
	public static Func<LODGroup, string> <>9__3_0; // 0x38
	public static Func<IGrouping<string, LODGroup>, int> <>9__3_1; // 0x40
	public static Func<Object, Type> <>9__5_0; // 0x48
	public static Func<IGrouping<Type, Object>, int> <>9__5_1; // 0x50
	public static Func<Object, bool> <>9__5_2; // 0x58
	public static Func<Object, Type> <>9__5_3; // 0x60
	public static Func<IGrouping<Type, Object>, int> <>9__5_4; // 0x68
	public static Func<Collider, bool> <>9__7_0; // 0x70
	public static Func<Collider, string> <>9__8_0; // 0x78
	public static Func<IGrouping<string, Collider>, int> <>9__8_1; // 0x80
	public static Func<Collider, bool> <>9__8_2; // 0x88
	public static Func<Collider, bool> <>9__8_3; // 0x90
	public static Func<Rigidbody, string> <>9__9_0; // 0x98
	public static Func<IGrouping<string, Rigidbody>, int> <>9__9_1; // 0xA0
	public static Func<Rigidbody, bool> <>9__9_2; // 0xA8
	public static Func<Rigidbody, bool> <>9__9_3; // 0xB0
	public static Func<Rigidbody, bool> <>9__9_4; // 0xB8
	public static Func<Transform, string> <>9__10_0; // 0xC0
	public static Func<IGrouping<string, Transform>, int> <>9__10_1; // 0xC8
	public static Func<Transform, string> <>9__10_2; // 0xD0
	public static Func<Transform, int> <>9__10_5; // 0xD8
	public static Func<IGrouping<string, Transform>, KeyValuePair<Transform, int>> <>9__10_3; // 0xE0
	public static Func<KeyValuePair<Transform, int>, int> <>9__10_4; // 0xE8

	// Methods

	// RVA: 0x98C5E0 Offset: 0x98ABE0 VA: 0x18098C5E0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x98BC70 Offset: 0x98A270 VA: 0x18098BC70
	internal string <DumpAnimators>b__0_0(Animator x) { }

	// RVA: 0x98BCC0 Offset: 0x98A2C0 VA: 0x18098BCC0
	internal int <DumpAnimators>b__0_1(IGrouping<string, Animator> x) { }

	// RVA: 0x98BD00 Offset: 0x98A300 VA: 0x18098BD00
	internal string <DumpAnimators>b__0_2(Animator x) { }

	// RVA: 0x98BD80 Offset: 0x98A380 VA: 0x18098BD80
	internal int <DumpAnimators>b__0_3(IGrouping<string, Animator> x) { }

	// RVA: 0x98BE70 Offset: 0x98A470 VA: 0x18098BE70
	internal uint <DumpEntities>b__1_0(BaseNetworkable x) { }

	// RVA: 0x98BE90 Offset: 0x98A490 VA: 0x18098BE90
	internal int <DumpEntities>b__1_1(IGrouping<uint, BaseNetworkable> x) { }

	// RVA: 0x98C0F0 Offset: 0x98A6F0 VA: 0x18098C0F0
	internal string <DumpLODGroupTotals>b__3_0(LODGroup x) { }

	// RVA: 0x98C140 Offset: 0x98A740 VA: 0x18098C140
	internal int <DumpLODGroupTotals>b__3_1(IGrouping<string, LODGroup> x) { }

	// RVA: 0x98C180 Offset: 0x98A780 VA: 0x18098C180
	internal Type <DumpObjects>b__5_0(Object x) { }

	// RVA: 0x98C1A0 Offset: 0x98A7A0 VA: 0x18098C1A0
	internal int <DumpObjects>b__5_1(IGrouping<Type, Object> x) { }

	// RVA: 0x98C1E0 Offset: 0x98A7E0 VA: 0x18098C1E0
	internal bool <DumpObjects>b__5_2(Object x) { }

	// RVA: 0x98C180 Offset: 0x98A780 VA: 0x18098C180
	internal Type <DumpObjects>b__5_3(Object x) { }

	// RVA: 0x98C260 Offset: 0x98A860 VA: 0x18098C260
	internal int <DumpObjects>b__5_4(IGrouping<Type, Object> x) { }

	// RVA: 0x6E8330 Offset: 0x6E6930 VA: 0x1806E8330
	internal bool <DumpTotals>b__7_0(Collider x) { }

	// RVA: 0x98BDC0 Offset: 0x98A3C0 VA: 0x18098BDC0
	internal string <DumpColliders>b__8_0(Collider x) { }

	// RVA: 0x98BE10 Offset: 0x98A410 VA: 0x18098BE10
	internal int <DumpColliders>b__8_1(IGrouping<string, Collider> x) { }

	// RVA: 0x98BE50 Offset: 0x98A450 VA: 0x18098BE50
	internal bool <DumpColliders>b__8_2(Collider x) { }

	// RVA: 0x6E8330 Offset: 0x6E6930 VA: 0x1806E8330
	internal bool <DumpColliders>b__8_3(Collider x) { }

	// RVA: 0x98C2A0 Offset: 0x98A8A0 VA: 0x18098C2A0
	internal string <DumpRigidBodies>b__9_0(Rigidbody x) { }

	// RVA: 0x98C2F0 Offset: 0x98A8F0 VA: 0x18098C2F0
	internal int <DumpRigidBodies>b__9_1(IGrouping<string, Rigidbody> x) { }

	// RVA: 0x98C330 Offset: 0x98A930 VA: 0x18098C330
	internal bool <DumpRigidBodies>b__9_2(Rigidbody x) { }

	// RVA: 0x98C360 Offset: 0x98A960 VA: 0x18098C360
	internal bool <DumpRigidBodies>b__9_3(Rigidbody x) { }

	// RVA: 0x98C380 Offset: 0x98A980 VA: 0x18098C380
	internal bool <DumpRigidBodies>b__9_4(Rigidbody x) { }

	// RVA: 0x7EFF90 Offset: 0x7EE590 VA: 0x1807EFF90
	internal string <DumpGameObjects>b__10_0(Transform x) { }

	// RVA: 0x98BED0 Offset: 0x98A4D0 VA: 0x18098BED0
	internal int <DumpGameObjects>b__10_1(IGrouping<string, Transform> x) { }

	// RVA: 0x7EFF90 Offset: 0x7EE590 VA: 0x1807EFF90
	internal string <DumpGameObjects>b__10_2(Transform x) { }

	// RVA: 0x98BF10 Offset: 0x98A510 VA: 0x18098BF10
	internal KeyValuePair<Transform, int> <DumpGameObjects>b__10_3(IGrouping<string, Transform> x) { }

	// RVA: 0x98C0A0 Offset: 0x98A6A0 VA: 0x18098C0A0
	internal int <DumpGameObjects>b__10_5(Transform y) { }

	// RVA: 0x98C060 Offset: 0x98A660 VA: 0x18098C060
	internal int <DumpGameObjects>b__10_4(KeyValuePair<Transform, int> x) { }

}

