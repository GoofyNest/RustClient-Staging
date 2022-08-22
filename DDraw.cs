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

	// RVA: 0x9FA760 Offset: 0x9F8D60 VA: 0x1809FA760
	public static DDraw Get() { }

	// RVA: 0x9FA380 Offset: 0x9F8980 VA: 0x1809FA380
	public static void Capsule(Vector3 pos, Quaternion rotation, float fRadius, float fHeight, Color color, float fDuration = 0,5, bool distanceFade = True) { }

	// RVA: 0x9FBC00 Offset: 0x9FA200 VA: 0x1809FBC00
	public static void Sphere(Vector3 vPos, float fRadius, Color color, float fDuration = 0,5, bool distanceFade = True) { }

	// RVA: 0x9FB910 Offset: 0x9F9F10 VA: 0x1809FB910
	public static void SphereGizmo(Vector3 vPos, float fRadius, Color color, float fDuration = 0,5, bool distanceFade = True, bool ztest = True) { }

	// RVA: 0x9FAA30 Offset: 0x9F9030 VA: 0x1809FAA30
	public static void Line(Vector3 vPos, Vector3 vPosB, Color color, float fDuration = 0,5, bool distanceFade = True, bool ztest = True) { }

	// RVA: 0x9FABB0 Offset: 0x9F91B0 VA: 0x1809FABB0
	public static void Line(Vector3 vPos, Vector3 vNormal, float magnitude, Color color, float fDuration = 0,5, bool distanceFade = True, bool ztest = True) { }

	// RVA: 0x9F9450 Offset: 0x9F7A50 VA: 0x1809F9450
	public static void Arrow(Vector3 vPos, Vector3 vPosB, float headSize, Color color, float fDuration = 0,5) { }

	// RVA: 0x9F8D50 Offset: 0x9F7350 VA: 0x1809F8D50
	public static void ArrowPadded(Vector3 vPos, Vector3 vPosB, float padding, float headSize, Color color, float fDuration = 0,5) { }

	// RVA: 0x9F9050 Offset: 0x9F7650 VA: 0x1809F9050
	public static void Arrow(Vector3 vPos, Vector3 vNormal, float magnitude, float headSize, Color color, float fDuration = 0,5) { }

	// RVA: 0x9F9680 Offset: 0x9F7C80 VA: 0x1809F9680
	public static void Bounds(Bounds bnds, Color color, float fDuration = 0,5, bool distanceFade = True, bool ztest = False) { }

	// RVA: 0x9F9930 Offset: 0x9F7F30 VA: 0x1809F9930
	public static void Bounds(Matrix4x4 matrix, Bounds bnds, Color color, float fDuration = 0,5) { }

	// RVA: 0x9F9C40 Offset: 0x9F8240 VA: 0x1809F9C40
	public static void Box(Vector3 vPos, float fSize, Color color, float fDuration = 1, bool distanceFade = True) { }

	// RVA: 0x9F9EF0 Offset: 0x9F84F0 VA: 0x1809F9EF0
	public static void Box(Vector3 vPos, Quaternion rot, Vector3 size, Color color, float fDuration = 1, bool distanceFade = True) { }

	// RVA: 0x9FA100 Offset: 0x9F8700 VA: 0x1809FA100
	public static void Box(Vector3 vPos) { }

	// RVA: 0x9FA1B0 Offset: 0x9F87B0 VA: 0x1809FA1B0
	public static void Box(Matrix4x4 matrix, Color color, float fDuration = 1) { }

	// RVA: 0x9FBEE0 Offset: 0x9FA4E0 VA: 0x1809FBEE0
	public static void Text(string text, Vector3 vPos, Color color, float fDuration = 0,5) { }

	// RVA: 0x9FB770 Offset: 0x9F9D70 VA: 0x1809FB770
	public static void ScreenText(string text, int x, int y, Color color, float fDuration = 0,5) { }

	// RVA: 0x9FB4A0 Offset: 0x9F9AA0 VA: 0x1809FB4A0
	public static void ScreenText(string text, int x, Color color, float fDuration = 0,5) { }

	// RVA: 0x9F9610 Offset: 0x9F7C10 VA: 0x1809F9610
	private void Awake() { }

	// RVA: 0x9FB390 Offset: 0x9F9990 VA: 0x1809FB390
	private void OnPreRender() { }

	// RVA: 0x9FB050 Offset: 0x9F9650 VA: 0x1809FB050
	private void OnPostRender() { }

	// RVA: 0x9FAE80 Offset: 0x9F9480 VA: 0x1809FAE80
	private void OnGUI() { }

	// RVA: 0x9FA600 Offset: 0x9F8C00 VA: 0x1809FA600
	private static void CreateLineMaterial() { }

	// RVA: 0x9FC0F0 Offset: 0x9FA6F0 VA: 0x1809FC0F0
	internal static GUISkin get_skin() { }

	// RVA: 0x9FC080 Offset: 0x9FA680 VA: 0x1809FC080
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

	// RVA: 0x9EF160 Offset: 0x9ED760 VA: 0x1809EF160 Slot: 6
	public virtual void Render() { }

	// RVA: 0x9EEF90 Offset: 0x9ED590 VA: 0x1809EEF90
	public void PushMatrix(Matrix4x4 mat) { }

	// RVA: 0x9EEF30 Offset: 0x9ED530 VA: 0x1809EEF30
	public void PopMatrix() { }

	// RVA: 0x9EEA60 Offset: 0x9ED060 VA: 0x1809EEA60
	public void DrawHalfDisc() { }

	// RVA: 0x9EE830 Offset: 0x9ECE30 VA: 0x1809EE830
	public void DrawDisc() { }

	// RVA: 0x9EED00 Offset: 0x9ED300 VA: 0x1809EED00
	public void DrawPlane() { }

	// RVA: 0x9EE690 Offset: 0x9ECC90 VA: 0x1809EE690
	internal void Begin(int type) { }

	// RVA: 0x9EFA20 Offset: 0x9EE020 VA: 0x1809EFA20
	public void .ctor() { }

	// RVA: 0x9EF270 Offset: 0x9ED870 VA: 0x1809EF270
	private static void .cctor() { }

}

public class DDraw.CapsuleObj : DDraw.BaseObject // TypeDefIndex: 11685
{	// Fields
	public float radius; // 0x88
	public float height; // 0x8C

	// Methods

	// RVA: 0x9F0F00 Offset: 0x9EF500 VA: 0x1809F0F00 Slot: 4
	public override void Draw() { }

	// RVA: 0x9F1CB0 Offset: 0x9F02B0 VA: 0x1809F1CB0
	public void .ctor() { }

}

public class DDraw.SphereObj : DDraw.BaseObject // TypeDefIndex: 11686
{	// Methods

	// RVA: 0x9FFE80 Offset: 0x9FE480 VA: 0x1809FFE80 Slot: 4
	public override void Draw() { }

	// RVA: 0xA000E0 Offset: 0x9FE6E0 VA: 0x180A000E0
	public void .ctor() { }

}

public class DDraw.SphereGizmoObj : DDraw.BaseObject // TypeDefIndex: 11687
{	// Fields
	private static Matrix4x4 XZ; // 0x0
	private static Matrix4x4 YZ; // 0x40
	private static Matrix4x4 XY; // 0x80

	// Methods

	// RVA: 0x9FF960 Offset: 0x9FDF60 VA: 0x1809FF960 Slot: 4
	public override void Draw() { }

	// RVA: 0x9FFE20 Offset: 0x9FE420 VA: 0x1809FFE20
	public void .ctor() { }

	// RVA: 0x9FFB70 Offset: 0x9FE170 VA: 0x1809FFB70
	private static void .cctor() { }

}

public class DDraw.LineObj : DDraw.BaseObject // TypeDefIndex: 11688
{	// Methods

	// RVA: 0x9FDF90 Offset: 0x9FC590 VA: 0x1809FDF90 Slot: 4
	public override void Draw() { }

	// RVA: 0x9FE040 Offset: 0x9FC640 VA: 0x1809FE040
	public void .ctor() { }

}

public class DDraw.CubeObj : DDraw.BaseObject // TypeDefIndex: 11689
{	// Methods

	// RVA: 0x9F8670 Offset: 0x9F6C70 VA: 0x1809F8670 Slot: 4
	public override void Draw() { }

	// RVA: 0x9F8CF0 Offset: 0x9F72F0 VA: 0x1809F8CF0
	public void .ctor() { }

}

public class DDraw.ArrowHead : DDraw.BaseObject // TypeDefIndex: 11690
{	// Methods

	// RVA: 0x9ED360 Offset: 0x9EB960 VA: 0x1809ED360 Slot: 4
	public override void Draw() { }

	// RVA: 0x9ED4E0 Offset: 0x9EBAE0 VA: 0x1809ED4E0
	public void .ctor() { }

}

public class DDraw.TextObj : DDraw.BaseObject // TypeDefIndex: 11691
{	// Fields
	public string text; // 0x88
	protected Rect rect; // 0x90
	protected bool draw; // 0xA0

	// Methods

	// RVA: 0xA00360 Offset: 0x9FE960 VA: 0x180A00360 Slot: 4
	public override void Draw() { }

	// RVA: 0xA00140 Offset: 0x9FE740 VA: 0x180A00140 Slot: 5
	public override void DrawGUI() { }

	// RVA: 0xA004D0 Offset: 0x9FEAD0 VA: 0x180A004D0
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

	// RVA: 0x9FF6D0 Offset: 0x9FDCD0 VA: 0x1809FF6D0 Slot: 5
	public override void DrawGUI() { }

	// RVA: 0x9FF8F0 Offset: 0x9FDEF0 VA: 0x1809FF8F0
	public void .ctor() { }

}

private sealed class DDraw.<>c // TypeDefIndex: 11693
{	// Fields
	public static readonly DDraw.<>c <>9; // 0x0
	public static Predicate<DDraw.BaseObject> <>9__24_0; // 0x8

	// Methods

	// RVA: 0xA00770 Offset: 0x9FED70 VA: 0x180A00770
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA006E0 Offset: 0x9FECE0 VA: 0x180A006E0
	internal bool <OnPreRender>b__24_0(DDraw.BaseObject o) { }

}

public class DDraw // TypeDefIndex: 11899
{	// Methods

	[ClientVar] // RVA: 0x930E0 Offset: 0x924E0 VA: 0x1800930E0
	// RVA: 0x6D5800 Offset: 0x6D3E00 VA: 0x1806D5800
	public static void line(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x930E0 Offset: 0x924E0 VA: 0x1800930E0
	// RVA: 0x6D5440 Offset: 0x6D3A40 VA: 0x1806D5440
	public static void arrow(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x930E0 Offset: 0x924E0 VA: 0x1800930E0
	// RVA: 0x6D59F0 Offset: 0x6D3FF0 VA: 0x1806D59F0
	public static void sphere(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x930E0 Offset: 0x924E0 VA: 0x1800930E0
	// RVA: 0x6D5B90 Offset: 0x6D4190 VA: 0x1806D5B90
	public static void text(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x930E0 Offset: 0x924E0 VA: 0x1800930E0
	// RVA: 0x6D5660 Offset: 0x6D3C60 VA: 0x1806D5660
	public static void box(ConsoleSystem.Arg arg) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

