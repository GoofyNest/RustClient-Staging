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

	// RVA: 0x9F9FB0 Offset: 0x9F85B0 VA: 0x1809F9FB0
	public static DDraw Get() { }

	// RVA: 0x9F9BD0 Offset: 0x9F81D0 VA: 0x1809F9BD0
	public static void Capsule(Vector3 pos, Quaternion rotation, float fRadius, float fHeight, Color color, float fDuration = 0,5, bool distanceFade = True) { }

	// RVA: 0x9FB450 Offset: 0x9F9A50 VA: 0x1809FB450
	public static void Sphere(Vector3 vPos, float fRadius, Color color, float fDuration = 0,5, bool distanceFade = True) { }

	// RVA: 0x9FB160 Offset: 0x9F9760 VA: 0x1809FB160
	public static void SphereGizmo(Vector3 vPos, float fRadius, Color color, float fDuration = 0,5, bool distanceFade = True, bool ztest = True) { }

	// RVA: 0x9FA280 Offset: 0x9F8880 VA: 0x1809FA280
	public static void Line(Vector3 vPos, Vector3 vPosB, Color color, float fDuration = 0,5, bool distanceFade = True, bool ztest = True) { }

	// RVA: 0x9FA400 Offset: 0x9F8A00 VA: 0x1809FA400
	public static void Line(Vector3 vPos, Vector3 vNormal, float magnitude, Color color, float fDuration = 0,5, bool distanceFade = True, bool ztest = True) { }

	// RVA: 0x9F8CA0 Offset: 0x9F72A0 VA: 0x1809F8CA0
	public static void Arrow(Vector3 vPos, Vector3 vPosB, float headSize, Color color, float fDuration = 0,5) { }

	// RVA: 0x9F85A0 Offset: 0x9F6BA0 VA: 0x1809F85A0
	public static void ArrowPadded(Vector3 vPos, Vector3 vPosB, float padding, float headSize, Color color, float fDuration = 0,5) { }

	// RVA: 0x9F88A0 Offset: 0x9F6EA0 VA: 0x1809F88A0
	public static void Arrow(Vector3 vPos, Vector3 vNormal, float magnitude, float headSize, Color color, float fDuration = 0,5) { }

	// RVA: 0x9F8ED0 Offset: 0x9F74D0 VA: 0x1809F8ED0
	public static void Bounds(Bounds bnds, Color color, float fDuration = 0,5, bool distanceFade = True, bool ztest = False) { }

	// RVA: 0x9F9180 Offset: 0x9F7780 VA: 0x1809F9180
	public static void Bounds(Matrix4x4 matrix, Bounds bnds, Color color, float fDuration = 0,5) { }

	// RVA: 0x9F9490 Offset: 0x9F7A90 VA: 0x1809F9490
	public static void Box(Vector3 vPos, float fSize, Color color, float fDuration = 1, bool distanceFade = True) { }

	// RVA: 0x9F9740 Offset: 0x9F7D40 VA: 0x1809F9740
	public static void Box(Vector3 vPos, Quaternion rot, Vector3 size, Color color, float fDuration = 1, bool distanceFade = True) { }

	// RVA: 0x9F9950 Offset: 0x9F7F50 VA: 0x1809F9950
	public static void Box(Vector3 vPos) { }

	// RVA: 0x9F9A00 Offset: 0x9F8000 VA: 0x1809F9A00
	public static void Box(Matrix4x4 matrix, Color color, float fDuration = 1) { }

	// RVA: 0x9FB730 Offset: 0x9F9D30 VA: 0x1809FB730
	public static void Text(string text, Vector3 vPos, Color color, float fDuration = 0,5) { }

	// RVA: 0x9FAFC0 Offset: 0x9F95C0 VA: 0x1809FAFC0
	public static void ScreenText(string text, int x, int y, Color color, float fDuration = 0,5) { }

	// RVA: 0x9FACF0 Offset: 0x9F92F0 VA: 0x1809FACF0
	public static void ScreenText(string text, int x, Color color, float fDuration = 0,5) { }

	// RVA: 0x9F8E60 Offset: 0x9F7460 VA: 0x1809F8E60
	private void Awake() { }

	// RVA: 0x9FABE0 Offset: 0x9F91E0 VA: 0x1809FABE0
	private void OnPreRender() { }

	// RVA: 0x9FA8A0 Offset: 0x9F8EA0 VA: 0x1809FA8A0
	private void OnPostRender() { }

	// RVA: 0x9FA6D0 Offset: 0x9F8CD0 VA: 0x1809FA6D0
	private void OnGUI() { }

	// RVA: 0x9F9E50 Offset: 0x9F8450 VA: 0x1809F9E50
	private static void CreateLineMaterial() { }

	// RVA: 0x9FB940 Offset: 0x9F9F40 VA: 0x1809FB940
	internal static GUISkin get_skin() { }

	// RVA: 0x9FB8D0 Offset: 0x9F9ED0 VA: 0x1809FB8D0
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

	// RVA: 0x9EE9B0 Offset: 0x9ECFB0 VA: 0x1809EE9B0 Slot: 6
	public virtual void Render() { }

	// RVA: 0x9EE7E0 Offset: 0x9ECDE0 VA: 0x1809EE7E0
	public void PushMatrix(Matrix4x4 mat) { }

	// RVA: 0x9EE780 Offset: 0x9ECD80 VA: 0x1809EE780
	public void PopMatrix() { }

	// RVA: 0x9EE2B0 Offset: 0x9EC8B0 VA: 0x1809EE2B0
	public void DrawHalfDisc() { }

	// RVA: 0x9EE080 Offset: 0x9EC680 VA: 0x1809EE080
	public void DrawDisc() { }

	// RVA: 0x9EE550 Offset: 0x9ECB50 VA: 0x1809EE550
	public void DrawPlane() { }

	// RVA: 0x9EDEE0 Offset: 0x9EC4E0 VA: 0x1809EDEE0
	internal void Begin(int type) { }

	// RVA: 0x9EF270 Offset: 0x9ED870 VA: 0x1809EF270
	public void .ctor() { }

	// RVA: 0x9EEAC0 Offset: 0x9ED0C0 VA: 0x1809EEAC0
	private static void .cctor() { }

}

public class DDraw.CapsuleObj : DDraw.BaseObject // TypeDefIndex: 11685
{	// Fields
	public float radius; // 0x88
	public float height; // 0x8C

	// Methods

	// RVA: 0x9F0750 Offset: 0x9EED50 VA: 0x1809F0750 Slot: 4
	public override void Draw() { }

	// RVA: 0x9F1500 Offset: 0x9EFB00 VA: 0x1809F1500
	public void .ctor() { }

}

public class DDraw.SphereObj : DDraw.BaseObject // TypeDefIndex: 11686
{	// Methods

	// RVA: 0x9FF6D0 Offset: 0x9FDCD0 VA: 0x1809FF6D0 Slot: 4
	public override void Draw() { }

	// RVA: 0x9FF930 Offset: 0x9FDF30 VA: 0x1809FF930
	public void .ctor() { }

}

public class DDraw.SphereGizmoObj : DDraw.BaseObject // TypeDefIndex: 11687
{	// Fields
	private static Matrix4x4 XZ; // 0x0
	private static Matrix4x4 YZ; // 0x40
	private static Matrix4x4 XY; // 0x80

	// Methods

	// RVA: 0x9FF1B0 Offset: 0x9FD7B0 VA: 0x1809FF1B0 Slot: 4
	public override void Draw() { }

	// RVA: 0x9FF670 Offset: 0x9FDC70 VA: 0x1809FF670
	public void .ctor() { }

	// RVA: 0x9FF3C0 Offset: 0x9FD9C0 VA: 0x1809FF3C0
	private static void .cctor() { }

}

public class DDraw.LineObj : DDraw.BaseObject // TypeDefIndex: 11688
{	// Methods

	// RVA: 0x9FD7E0 Offset: 0x9FBDE0 VA: 0x1809FD7E0 Slot: 4
	public override void Draw() { }

	// RVA: 0x9FD890 Offset: 0x9FBE90 VA: 0x1809FD890
	public void .ctor() { }

}

public class DDraw.CubeObj : DDraw.BaseObject // TypeDefIndex: 11689
{	// Methods

	// RVA: 0x9F7EC0 Offset: 0x9F64C0 VA: 0x1809F7EC0 Slot: 4
	public override void Draw() { }

	// RVA: 0x9F8540 Offset: 0x9F6B40 VA: 0x1809F8540
	public void .ctor() { }

}

public class DDraw.ArrowHead : DDraw.BaseObject // TypeDefIndex: 11690
{	// Methods

	// RVA: 0x9ECBB0 Offset: 0x9EB1B0 VA: 0x1809ECBB0 Slot: 4
	public override void Draw() { }

	// RVA: 0x9ECD30 Offset: 0x9EB330 VA: 0x1809ECD30
	public void .ctor() { }

}

public class DDraw.TextObj : DDraw.BaseObject // TypeDefIndex: 11691
{	// Fields
	public string text; // 0x88
	protected Rect rect; // 0x90
	protected bool draw; // 0xA0

	// Methods

	// RVA: 0x9FFBB0 Offset: 0x9FE1B0 VA: 0x1809FFBB0 Slot: 4
	public override void Draw() { }

	// RVA: 0x9FF990 Offset: 0x9FDF90 VA: 0x1809FF990 Slot: 5
	public override void DrawGUI() { }

	// RVA: 0x9FFD20 Offset: 0x9FE320 VA: 0x1809FFD20
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

	// RVA: 0x9FEF20 Offset: 0x9FD520 VA: 0x1809FEF20 Slot: 5
	public override void DrawGUI() { }

	// RVA: 0x9FF140 Offset: 0x9FD740 VA: 0x1809FF140
	public void .ctor() { }

}

private sealed class DDraw.<>c // TypeDefIndex: 11693
{	// Fields
	public static readonly DDraw.<>c <>9; // 0x0
	public static Predicate<DDraw.BaseObject> <>9__24_0; // 0x8

	// Methods

	// RVA: 0x9FFFC0 Offset: 0x9FE5C0 VA: 0x1809FFFC0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x9FFF30 Offset: 0x9FE530 VA: 0x1809FFF30
	internal bool <OnPreRender>b__24_0(DDraw.BaseObject o) { }

}

public class DDraw // TypeDefIndex: 11899
{	// Methods

	[ClientVar] // RVA: 0x93000 Offset: 0x92400 VA: 0x180093000
	// RVA: 0x6D5760 Offset: 0x6D3D60 VA: 0x1806D5760
	public static void line(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x93000 Offset: 0x92400 VA: 0x180093000
	// RVA: 0x6D53A0 Offset: 0x6D39A0 VA: 0x1806D53A0
	public static void arrow(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x93000 Offset: 0x92400 VA: 0x180093000
	// RVA: 0x6D5950 Offset: 0x6D3F50 VA: 0x1806D5950
	public static void sphere(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x93000 Offset: 0x92400 VA: 0x180093000
	// RVA: 0x6D5AF0 Offset: 0x6D40F0 VA: 0x1806D5AF0
	public static void text(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x93000 Offset: 0x92400 VA: 0x180093000
	// RVA: 0x6D55C0 Offset: 0x6D3BC0 VA: 0x1806D55C0
	public static void box(ConsoleSystem.Arg arg) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

