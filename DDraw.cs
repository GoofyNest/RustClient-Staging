public class DDraw : MonoBehaviour // TypeDefIndex: 11683
{	// Fields
	public static GameObject store; // 0x0
	public static DDraw singleton; // 0x8
	public List<DDraw.BaseObject> list; // 0x18
	internal static int AutoYPosition; // 0x10
	internal static float LastAutoY; // 0x14
	private static Material lineMaterial; // 0x18
	internal static GUISkin _skin; // 0x20

	// Properties
	internal static GUISkin skin { get; }

	// Methods

	// RVA: 0x9FA270 Offset: 0x9F8870 VA: 0x1809FA270
	public static DDraw Get() { }

	// RVA: 0x9F9E90 Offset: 0x9F8490 VA: 0x1809F9E90
	public static void Capsule(Vector3 pos, Quaternion rotation, float fRadius, float fHeight, Color color, float fDuration = 0,5, bool distanceFade = True) { }

	// RVA: 0x9FB710 Offset: 0x9F9D10 VA: 0x1809FB710
	public static void Sphere(Vector3 vPos, float fRadius, Color color, float fDuration = 0,5, bool distanceFade = True) { }

	// RVA: 0x9FB420 Offset: 0x9F9A20 VA: 0x1809FB420
	public static void SphereGizmo(Vector3 vPos, float fRadius, Color color, float fDuration = 0,5, bool distanceFade = True, bool ztest = True) { }

	// RVA: 0x9FA540 Offset: 0x9F8B40 VA: 0x1809FA540
	public static void Line(Vector3 vPos, Vector3 vPosB, Color color, float fDuration = 0,5, bool distanceFade = True, bool ztest = True) { }

	// RVA: 0x9FA6C0 Offset: 0x9F8CC0 VA: 0x1809FA6C0
	public static void Line(Vector3 vPos, Vector3 vNormal, float magnitude, Color color, float fDuration = 0,5, bool distanceFade = True, bool ztest = True) { }

	// RVA: 0x9F8F60 Offset: 0x9F7560 VA: 0x1809F8F60
	public static void Arrow(Vector3 vPos, Vector3 vPosB, float headSize, Color color, float fDuration = 0,5) { }

	// RVA: 0x9F8860 Offset: 0x9F6E60 VA: 0x1809F8860
	public static void ArrowPadded(Vector3 vPos, Vector3 vPosB, float padding, float headSize, Color color, float fDuration = 0,5) { }

	// RVA: 0x9F8B60 Offset: 0x9F7160 VA: 0x1809F8B60
	public static void Arrow(Vector3 vPos, Vector3 vNormal, float magnitude, float headSize, Color color, float fDuration = 0,5) { }

	// RVA: 0x9F9190 Offset: 0x9F7790 VA: 0x1809F9190
	public static void Bounds(Bounds bnds, Color color, float fDuration = 0,5, bool distanceFade = True, bool ztest = False) { }

	// RVA: 0x9F9440 Offset: 0x9F7A40 VA: 0x1809F9440
	public static void Bounds(Matrix4x4 matrix, Bounds bnds, Color color, float fDuration = 0,5) { }

	// RVA: 0x9F9750 Offset: 0x9F7D50 VA: 0x1809F9750
	public static void Box(Vector3 vPos, float fSize, Color color, float fDuration = 1, bool distanceFade = True) { }

	// RVA: 0x9F9A00 Offset: 0x9F8000 VA: 0x1809F9A00
	public static void Box(Vector3 vPos, Quaternion rot, Vector3 size, Color color, float fDuration = 1, bool distanceFade = True) { }

	// RVA: 0x9F9C10 Offset: 0x9F8210 VA: 0x1809F9C10
	public static void Box(Vector3 vPos) { }

	// RVA: 0x9F9CC0 Offset: 0x9F82C0 VA: 0x1809F9CC0
	public static void Box(Matrix4x4 matrix, Color color, float fDuration = 1) { }

	// RVA: 0x9FB9F0 Offset: 0x9F9FF0 VA: 0x1809FB9F0
	public static void Text(string text, Vector3 vPos, Color color, float fDuration = 0,5) { }

	// RVA: 0x9FB280 Offset: 0x9F9880 VA: 0x1809FB280
	public static void ScreenText(string text, int x, int y, Color color, float fDuration = 0,5) { }

	// RVA: 0x9FAFB0 Offset: 0x9F95B0 VA: 0x1809FAFB0
	public static void ScreenText(string text, int x, Color color, float fDuration = 0,5) { }

	// RVA: 0x9F9120 Offset: 0x9F7720 VA: 0x1809F9120
	private void Awake() { }

	// RVA: 0x9FAEA0 Offset: 0x9F94A0 VA: 0x1809FAEA0
	private void OnPreRender() { }

	// RVA: 0x9FAB60 Offset: 0x9F9160 VA: 0x1809FAB60
	private void OnPostRender() { }

	// RVA: 0x9FA990 Offset: 0x9F8F90 VA: 0x1809FA990
	private void OnGUI() { }

	// RVA: 0x9FA110 Offset: 0x9F8710 VA: 0x1809FA110
	private static void CreateLineMaterial() { }

	// RVA: 0x9FBC00 Offset: 0x9FA200 VA: 0x1809FBC00
	internal static GUISkin get_skin() { }

	// RVA: 0x9FBB90 Offset: 0x9FA190 VA: 0x1809FBB90
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public class DDraw.BaseObject // TypeDefIndex: 11684
{	// Fields
	public Vector3 position; // 0x10
	public Matrix4x4 transform; // 0x1C
	public Color color; // 0x5C
	public float end; // 0x6C
	public float start; // 0x70
	public float delta; // 0x74
	public bool distanceFade; // 0x78
	public bool ztest; // 0x79
	public Stack<Matrix4x4> matrixStack; // 0x80
	private static Vector3[] vDisc; // 0x0
	private static Vector3[] vPlane; // 0x8

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	public virtual void Draw() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public virtual void DrawGUI() { }

	// RVA: 0x9EEC70 Offset: 0x9ED270 VA: 0x1809EEC70 Slot: 6
	public virtual void Render() { }

	// RVA: 0x9EEAA0 Offset: 0x9ED0A0 VA: 0x1809EEAA0
	public void PushMatrix(Matrix4x4 mat) { }

	// RVA: 0x9EEA40 Offset: 0x9ED040 VA: 0x1809EEA40
	public void PopMatrix() { }

	// RVA: 0x9EE570 Offset: 0x9ECB70 VA: 0x1809EE570
	public void DrawHalfDisc() { }

	// RVA: 0x9EE340 Offset: 0x9EC940 VA: 0x1809EE340
	public void DrawDisc() { }

	// RVA: 0x9EE810 Offset: 0x9ECE10 VA: 0x1809EE810
	public void DrawPlane() { }

	// RVA: 0x9EE1A0 Offset: 0x9EC7A0 VA: 0x1809EE1A0
	internal void Begin(int type) { }

	// RVA: 0x9EF530 Offset: 0x9EDB30 VA: 0x1809EF530
	public void .ctor() { }

	// RVA: 0x9EED80 Offset: 0x9ED380 VA: 0x1809EED80
	private static void .cctor() { }

}

public class DDraw.CapsuleObj : DDraw.BaseObject // TypeDefIndex: 11685
{	// Fields
	public float radius; // 0x88
	public float height; // 0x8C

	// Methods

	// RVA: 0x9F0A10 Offset: 0x9EF010 VA: 0x1809F0A10 Slot: 4
	public override void Draw() { }

	// RVA: 0x9F17C0 Offset: 0x9EFDC0 VA: 0x1809F17C0
	public void .ctor() { }

}

public class DDraw.SphereObj : DDraw.BaseObject // TypeDefIndex: 11686
{	// Methods

	// RVA: 0x9FF990 Offset: 0x9FDF90 VA: 0x1809FF990 Slot: 4
	public override void Draw() { }

	// RVA: 0x9FFBF0 Offset: 0x9FE1F0 VA: 0x1809FFBF0
	public void .ctor() { }

}

public class DDraw.SphereGizmoObj : DDraw.BaseObject // TypeDefIndex: 11687
{	// Fields
	private static Matrix4x4 XZ; // 0x0
	private static Matrix4x4 YZ; // 0x40
	private static Matrix4x4 XY; // 0x80

	// Methods

	// RVA: 0x9FF470 Offset: 0x9FDA70 VA: 0x1809FF470 Slot: 4
	public override void Draw() { }

	// RVA: 0x9FF930 Offset: 0x9FDF30 VA: 0x1809FF930
	public void .ctor() { }

	// RVA: 0x9FF680 Offset: 0x9FDC80 VA: 0x1809FF680
	private static void .cctor() { }

}

public class DDraw.LineObj : DDraw.BaseObject // TypeDefIndex: 11688
{	// Methods

	// RVA: 0x9FDAA0 Offset: 0x9FC0A0 VA: 0x1809FDAA0 Slot: 4
	public override void Draw() { }

	// RVA: 0x9FDB50 Offset: 0x9FC150 VA: 0x1809FDB50
	public void .ctor() { }

}

public class DDraw.CubeObj : DDraw.BaseObject // TypeDefIndex: 11689
{	// Methods

	// RVA: 0x9F8180 Offset: 0x9F6780 VA: 0x1809F8180 Slot: 4
	public override void Draw() { }

	// RVA: 0x9F8800 Offset: 0x9F6E00 VA: 0x1809F8800
	public void .ctor() { }

}

public class DDraw.ArrowHead : DDraw.BaseObject // TypeDefIndex: 11690
{	// Methods

	// RVA: 0x9ECE70 Offset: 0x9EB470 VA: 0x1809ECE70 Slot: 4
	public override void Draw() { }

	// RVA: 0x9ECFF0 Offset: 0x9EB5F0 VA: 0x1809ECFF0
	public void .ctor() { }

}

public class DDraw.TextObj : DDraw.BaseObject // TypeDefIndex: 11691
{	// Fields
	public string text; // 0x88
	protected Rect rect; // 0x90
	protected bool draw; // 0xA0

	// Methods

	// RVA: 0x9FFE70 Offset: 0x9FE470 VA: 0x1809FFE70 Slot: 4
	public override void Draw() { }

	// RVA: 0x9FFC50 Offset: 0x9FE250 VA: 0x1809FFC50 Slot: 5
	public override void DrawGUI() { }

	// RVA: 0x9FFFE0 Offset: 0x9FE5E0 VA: 0x1809FFFE0
	public void .ctor() { }

}

public class DDraw.ScreenTextObj : DDraw.BaseObject // TypeDefIndex: 11692
{	// Fields
	public string text; // 0x88
	public int x; // 0x90
	public int y; // 0x94
	protected Rect rect; // 0x98

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	public override void Draw() { }

	// RVA: 0x9FF1E0 Offset: 0x9FD7E0 VA: 0x1809FF1E0 Slot: 5
	public override void DrawGUI() { }

	// RVA: 0x9FF400 Offset: 0x9FDA00 VA: 0x1809FF400
	public void .ctor() { }

}

private sealed class DDraw.<>c // TypeDefIndex: 11693
{	// Fields
	public static readonly DDraw.<>c <>9; // 0x0
	public static Predicate<DDraw.BaseObject> <>9__24_0; // 0x8

	// Methods

	// RVA: 0xA00280 Offset: 0x9FE880 VA: 0x180A00280
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA001F0 Offset: 0x9FE7F0 VA: 0x180A001F0
	internal bool <OnPreRender>b__24_0(DDraw.BaseObject o) { }

}

public class DDraw // TypeDefIndex: 11899
{	// Methods

	[ClientVar] // RVA: 0x930E0 Offset: 0x924E0 VA: 0x1800930E0
	// RVA: 0x6D5870 Offset: 0x6D3E70 VA: 0x1806D5870
	public static void line(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x930E0 Offset: 0x924E0 VA: 0x1800930E0
	// RVA: 0x6D54B0 Offset: 0x6D3AB0 VA: 0x1806D54B0
	public static void arrow(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x930E0 Offset: 0x924E0 VA: 0x1800930E0
	// RVA: 0x6D5A60 Offset: 0x6D4060 VA: 0x1806D5A60
	public static void sphere(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x930E0 Offset: 0x924E0 VA: 0x1800930E0
	// RVA: 0x6D5C00 Offset: 0x6D4200 VA: 0x1806D5C00
	public static void text(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x930E0 Offset: 0x924E0 VA: 0x1800930E0
	// RVA: 0x6D56D0 Offset: 0x6D3CD0 VA: 0x1806D56D0
	public static void box(ConsoleSystem.Arg arg) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

