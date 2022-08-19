public class DiagnosticsConSys : ConsoleSystem // TypeDefIndex: 9276
{	// Methods

	// RVA: 0x980990 Offset: 0x97EF90 VA: 0x180980990
	private static void DumpAnimators(string targetFolder) { }

	// RVA: 0x981AB0 Offset: 0x9800B0 VA: 0x180981AB0
	private static void DumpEntities(string targetFolder) { }

	// RVA: 0x983540 Offset: 0x981B40 VA: 0x180983540
	private static void DumpLODGroups(string targetFolder) { }

	// RVA: 0x9830D0 Offset: 0x9816D0 VA: 0x1809830D0
	private static void DumpLODGroupTotals(string targetFolder) { }

	// RVA: 0x983550 Offset: 0x981B50 VA: 0x180983550
	private static void DumpNetwork(string targetFolder) { }

	// RVA: 0x9836D0 Offset: 0x981CD0 VA: 0x1809836D0
	private static void DumpObjects(string targetFolder) { }

	// RVA: 0x984040 Offset: 0x982640 VA: 0x180984040
	private static void DumpPhysics(string targetFolder) { }

	// RVA: 0x984CC0 Offset: 0x9832C0 VA: 0x180984CC0
	private static void DumpTotals(string targetFolder) { }

	// RVA: 0x9813F0 Offset: 0x97F9F0 VA: 0x1809813F0
	private static void DumpColliders(string targetFolder) { }

	// RVA: 0x984070 Offset: 0x982670 VA: 0x180984070
	private static void DumpRigidBodies(string targetFolder) { }

	// RVA: 0x9824C0 Offset: 0x980AC0 VA: 0x1809824C0
	private static void DumpGameObjects(string targetFolder) { }

	// RVA: 0x9821D0 Offset: 0x9807D0 VA: 0x1809821D0
	private static void DumpGameObjectRecursive(StringBuilder str, Transform tx, int indent, bool includeComponents = False) { }

	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	// RVA: 0x985140 Offset: 0x983740 VA: 0x180985140
	public static void dump(ConsoleSystem.Arg args) { }

	// RVA: 0x984C60 Offset: 0x983260 VA: 0x180984C60
	private static void DumpSystemInformation(string targetFolder) { }

	// RVA: 0x9850D0 Offset: 0x9836D0 VA: 0x1809850D0
	private static void WriteTextToFile(string file, string text) { }

	// RVA: 0x9850E0 Offset: 0x9836E0 VA: 0x1809850E0
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

	// RVA: 0x98C4D0 Offset: 0x98AAD0 VA: 0x18098C4D0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x98BB60 Offset: 0x98A160 VA: 0x18098BB60
	internal string <DumpAnimators>b__0_0(Animator x) { }

	// RVA: 0x98BBB0 Offset: 0x98A1B0 VA: 0x18098BBB0
	internal int <DumpAnimators>b__0_1(IGrouping<string, Animator> x) { }

	// RVA: 0x98BBF0 Offset: 0x98A1F0 VA: 0x18098BBF0
	internal string <DumpAnimators>b__0_2(Animator x) { }

	// RVA: 0x98BC70 Offset: 0x98A270 VA: 0x18098BC70
	internal int <DumpAnimators>b__0_3(IGrouping<string, Animator> x) { }

	// RVA: 0x98BD60 Offset: 0x98A360 VA: 0x18098BD60
	internal uint <DumpEntities>b__1_0(BaseNetworkable x) { }

	// RVA: 0x98BD80 Offset: 0x98A380 VA: 0x18098BD80
	internal int <DumpEntities>b__1_1(IGrouping<uint, BaseNetworkable> x) { }

	// RVA: 0x98BFE0 Offset: 0x98A5E0 VA: 0x18098BFE0
	internal string <DumpLODGroupTotals>b__3_0(LODGroup x) { }

	// RVA: 0x98C030 Offset: 0x98A630 VA: 0x18098C030
	internal int <DumpLODGroupTotals>b__3_1(IGrouping<string, LODGroup> x) { }

	// RVA: 0x98C070 Offset: 0x98A670 VA: 0x18098C070
	internal Type <DumpObjects>b__5_0(Object x) { }

	// RVA: 0x98C090 Offset: 0x98A690 VA: 0x18098C090
	internal int <DumpObjects>b__5_1(IGrouping<Type, Object> x) { }

	// RVA: 0x98C0D0 Offset: 0x98A6D0 VA: 0x18098C0D0
	internal bool <DumpObjects>b__5_2(Object x) { }

	// RVA: 0x98C070 Offset: 0x98A670 VA: 0x18098C070
	internal Type <DumpObjects>b__5_3(Object x) { }

	// RVA: 0x98C150 Offset: 0x98A750 VA: 0x18098C150
	internal int <DumpObjects>b__5_4(IGrouping<Type, Object> x) { }

	// RVA: 0x6E8220 Offset: 0x6E6820 VA: 0x1806E8220
	internal bool <DumpTotals>b__7_0(Collider x) { }

	// RVA: 0x98BCB0 Offset: 0x98A2B0 VA: 0x18098BCB0
	internal string <DumpColliders>b__8_0(Collider x) { }

	// RVA: 0x98BD00 Offset: 0x98A300 VA: 0x18098BD00
	internal int <DumpColliders>b__8_1(IGrouping<string, Collider> x) { }

	// RVA: 0x98BD40 Offset: 0x98A340 VA: 0x18098BD40
	internal bool <DumpColliders>b__8_2(Collider x) { }

	// RVA: 0x6E8220 Offset: 0x6E6820 VA: 0x1806E8220
	internal bool <DumpColliders>b__8_3(Collider x) { }

	// RVA: 0x98C190 Offset: 0x98A790 VA: 0x18098C190
	internal string <DumpRigidBodies>b__9_0(Rigidbody x) { }

	// RVA: 0x98C1E0 Offset: 0x98A7E0 VA: 0x18098C1E0
	internal int <DumpRigidBodies>b__9_1(IGrouping<string, Rigidbody> x) { }

	// RVA: 0x98C220 Offset: 0x98A820 VA: 0x18098C220
	internal bool <DumpRigidBodies>b__9_2(Rigidbody x) { }

	// RVA: 0x98C250 Offset: 0x98A850 VA: 0x18098C250
	internal bool <DumpRigidBodies>b__9_3(Rigidbody x) { }

	// RVA: 0x98C270 Offset: 0x98A870 VA: 0x18098C270
	internal bool <DumpRigidBodies>b__9_4(Rigidbody x) { }

	// RVA: 0x7EFE80 Offset: 0x7EE480 VA: 0x1807EFE80
	internal string <DumpGameObjects>b__10_0(Transform x) { }

	// RVA: 0x98BDC0 Offset: 0x98A3C0 VA: 0x18098BDC0
	internal int <DumpGameObjects>b__10_1(IGrouping<string, Transform> x) { }

	// RVA: 0x7EFE80 Offset: 0x7EE480 VA: 0x1807EFE80
	internal string <DumpGameObjects>b__10_2(Transform x) { }

	// RVA: 0x98BE00 Offset: 0x98A400 VA: 0x18098BE00
	internal KeyValuePair<Transform, int> <DumpGameObjects>b__10_3(IGrouping<string, Transform> x) { }

	// RVA: 0x98BF90 Offset: 0x98A590 VA: 0x18098BF90
	internal int <DumpGameObjects>b__10_5(Transform y) { }

	// RVA: 0x98BF50 Offset: 0x98A550 VA: 0x18098BF50
	internal int <DumpGameObjects>b__10_4(KeyValuePair<Transform, int> x) { }

}

