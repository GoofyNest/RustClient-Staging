public class DiagnosticsConSys : ConsoleSystem // TypeDefIndex: 9276
{	// Methods

	// RVA: 0x980FA0 Offset: 0x97F5A0 VA: 0x180980FA0
	private static void DumpAnimators(string targetFolder) { }

	// RVA: 0x9820C0 Offset: 0x9806C0 VA: 0x1809820C0
	private static void DumpEntities(string targetFolder) { }

	// RVA: 0x983B50 Offset: 0x982150 VA: 0x180983B50
	private static void DumpLODGroups(string targetFolder) { }

	// RVA: 0x9836E0 Offset: 0x981CE0 VA: 0x1809836E0
	private static void DumpLODGroupTotals(string targetFolder) { }

	// RVA: 0x983B60 Offset: 0x982160 VA: 0x180983B60
	private static void DumpNetwork(string targetFolder) { }

	// RVA: 0x983CE0 Offset: 0x9822E0 VA: 0x180983CE0
	private static void DumpObjects(string targetFolder) { }

	// RVA: 0x984650 Offset: 0x982C50 VA: 0x180984650
	private static void DumpPhysics(string targetFolder) { }

	// RVA: 0x9852D0 Offset: 0x9838D0 VA: 0x1809852D0
	private static void DumpTotals(string targetFolder) { }

	// RVA: 0x981A00 Offset: 0x980000 VA: 0x180981A00
	private static void DumpColliders(string targetFolder) { }

	// RVA: 0x984680 Offset: 0x982C80 VA: 0x180984680
	private static void DumpRigidBodies(string targetFolder) { }

	// RVA: 0x982AD0 Offset: 0x9810D0 VA: 0x180982AD0
	private static void DumpGameObjects(string targetFolder) { }

	// RVA: 0x9827E0 Offset: 0x980DE0 VA: 0x1809827E0
	private static void DumpGameObjectRecursive(StringBuilder str, Transform tx, int indent, bool includeComponents = False) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x985750 Offset: 0x983D50 VA: 0x180985750
	public static void dump(ConsoleSystem.Arg args) { }

	// RVA: 0x985270 Offset: 0x983870 VA: 0x180985270
	private static void DumpSystemInformation(string targetFolder) { }

	// RVA: 0x9856E0 Offset: 0x983CE0 VA: 0x1809856E0
	private static void WriteTextToFile(string file, string text) { }

	// RVA: 0x9856F0 Offset: 0x983CF0 VA: 0x1809856F0
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

	// RVA: 0x98CAE0 Offset: 0x98B0E0 VA: 0x18098CAE0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x98C170 Offset: 0x98A770 VA: 0x18098C170
	internal string <DumpAnimators>b__0_0(Animator x) { }

	// RVA: 0x98C1C0 Offset: 0x98A7C0 VA: 0x18098C1C0
	internal int <DumpAnimators>b__0_1(IGrouping<string, Animator> x) { }

	// RVA: 0x98C200 Offset: 0x98A800 VA: 0x18098C200
	internal string <DumpAnimators>b__0_2(Animator x) { }

	// RVA: 0x98C280 Offset: 0x98A880 VA: 0x18098C280
	internal int <DumpAnimators>b__0_3(IGrouping<string, Animator> x) { }

	// RVA: 0x98C370 Offset: 0x98A970 VA: 0x18098C370
	internal uint <DumpEntities>b__1_0(BaseNetworkable x) { }

	// RVA: 0x98C390 Offset: 0x98A990 VA: 0x18098C390
	internal int <DumpEntities>b__1_1(IGrouping<uint, BaseNetworkable> x) { }

	// RVA: 0x98C5F0 Offset: 0x98ABF0 VA: 0x18098C5F0
	internal string <DumpLODGroupTotals>b__3_0(LODGroup x) { }

	// RVA: 0x98C640 Offset: 0x98AC40 VA: 0x18098C640
	internal int <DumpLODGroupTotals>b__3_1(IGrouping<string, LODGroup> x) { }

	// RVA: 0x98C680 Offset: 0x98AC80 VA: 0x18098C680
	internal Type <DumpObjects>b__5_0(Object x) { }

	// RVA: 0x98C6A0 Offset: 0x98ACA0 VA: 0x18098C6A0
	internal int <DumpObjects>b__5_1(IGrouping<Type, Object> x) { }

	// RVA: 0x98C6E0 Offset: 0x98ACE0 VA: 0x18098C6E0
	internal bool <DumpObjects>b__5_2(Object x) { }

	// RVA: 0x98C680 Offset: 0x98AC80 VA: 0x18098C680
	internal Type <DumpObjects>b__5_3(Object x) { }

	// RVA: 0x98C760 Offset: 0x98AD60 VA: 0x18098C760
	internal int <DumpObjects>b__5_4(IGrouping<Type, Object> x) { }

	// RVA: 0x6E82C0 Offset: 0x6E68C0 VA: 0x1806E82C0
	internal bool <DumpTotals>b__7_0(Collider x) { }

	// RVA: 0x98C2C0 Offset: 0x98A8C0 VA: 0x18098C2C0
	internal string <DumpColliders>b__8_0(Collider x) { }

	// RVA: 0x98C310 Offset: 0x98A910 VA: 0x18098C310
	internal int <DumpColliders>b__8_1(IGrouping<string, Collider> x) { }

	// RVA: 0x98C350 Offset: 0x98A950 VA: 0x18098C350
	internal bool <DumpColliders>b__8_2(Collider x) { }

	// RVA: 0x6E82C0 Offset: 0x6E68C0 VA: 0x1806E82C0
	internal bool <DumpColliders>b__8_3(Collider x) { }

	// RVA: 0x98C7A0 Offset: 0x98ADA0 VA: 0x18098C7A0
	internal string <DumpRigidBodies>b__9_0(Rigidbody x) { }

	// RVA: 0x98C7F0 Offset: 0x98ADF0 VA: 0x18098C7F0
	internal int <DumpRigidBodies>b__9_1(IGrouping<string, Rigidbody> x) { }

	// RVA: 0x98C830 Offset: 0x98AE30 VA: 0x18098C830
	internal bool <DumpRigidBodies>b__9_2(Rigidbody x) { }

	// RVA: 0x98C860 Offset: 0x98AE60 VA: 0x18098C860
	internal bool <DumpRigidBodies>b__9_3(Rigidbody x) { }

	// RVA: 0x98C880 Offset: 0x98AE80 VA: 0x18098C880
	internal bool <DumpRigidBodies>b__9_4(Rigidbody x) { }

	// RVA: 0x7F0520 Offset: 0x7EEB20 VA: 0x1807F0520
	internal string <DumpGameObjects>b__10_0(Transform x) { }

	// RVA: 0x98C3D0 Offset: 0x98A9D0 VA: 0x18098C3D0
	internal int <DumpGameObjects>b__10_1(IGrouping<string, Transform> x) { }

	// RVA: 0x7F0520 Offset: 0x7EEB20 VA: 0x1807F0520
	internal string <DumpGameObjects>b__10_2(Transform x) { }

	// RVA: 0x98C410 Offset: 0x98AA10 VA: 0x18098C410
	internal KeyValuePair<Transform, int> <DumpGameObjects>b__10_3(IGrouping<string, Transform> x) { }

	// RVA: 0x98C5A0 Offset: 0x98ABA0 VA: 0x18098C5A0
	internal int <DumpGameObjects>b__10_5(Transform y) { }

	// RVA: 0x98C560 Offset: 0x98AB60 VA: 0x18098C560
	internal int <DumpGameObjects>b__10_4(KeyValuePair<Transform, int> x) { }

}

