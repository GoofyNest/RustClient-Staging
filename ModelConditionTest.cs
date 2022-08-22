public abstract class ModelConditionTest : PrefabAttribute // TypeDefIndex: 9066
{	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool DoTest(BaseEntity ent);

	// RVA: 0x76F980 Offset: 0x76DF80 VA: 0x18076F980 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x76F400 Offset: 0x76DA00 VA: 0x18076F400
	protected void .ctor() { }

}

public class ModelConditionTest_False : ModelConditionTest // TypeDefIndex: 9067
{	// Fields
	public ConditionalModel reference; // 0x98

	// Methods

	// RVA: 0x76F3D0 Offset: 0x76D9D0 VA: 0x18076F3D0 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F400 Offset: 0x76DA00 VA: 0x18076F400
	public void .ctor() { }

}

public class ModelConditionTest_FoundationSide : ModelConditionTest // TypeDefIndex: 9068
{	// Fields
	private const string square_south = "foundation/sockets/foundation-top/1";
	private const string square_north = "foundation/sockets/foundation-top/3";
	private const string square_west = "foundation/sockets/foundation-top/2";
	private const string square_east = "foundation/sockets/foundation-top/4";
	private const string triangle_south = "foundation.triangle/sockets/foundation-top/1";
	private const string triangle_northwest = "foundation.triangle/sockets/foundation-top/2";
	private const string triangle_northeast = "foundation.triangle/sockets/foundation-top/3";
	private string socket; // 0x98

	// Methods

	// RVA: 0x76F7F0 Offset: 0x76DDF0 VA: 0x18076F7F0
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x76F460 Offset: 0x76DA60 VA: 0x18076F460 Slot: 6
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x76F670 Offset: 0x76DC70 VA: 0x18076F670 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F8F0 Offset: 0x76DEF0 VA: 0x18076F8F0
	public void .ctor() { }

}

public class ModelConditionTest_RampHigh : ModelConditionTest // TypeDefIndex: 9069
{	// Fields
	private const string socket = "ramp/sockets/block-male/1";

	// Methods

	// RVA: 0x76FA40 Offset: 0x76E040 VA: 0x18076FA40
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x76F9E0 Offset: 0x76DFE0 VA: 0x18076F9E0 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F400 Offset: 0x76DA00 VA: 0x18076F400
	public void .ctor() { }

}

public class ModelConditionTest_RampLow : ModelConditionTest // TypeDefIndex: 9070
{	// Fields
	private const string socket = "ramp/sockets/block-male/1";

	// Methods

	// RVA: 0x76FBC0 Offset: 0x76E1C0 VA: 0x18076FBC0
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x76FB50 Offset: 0x76E150 VA: 0x18076FB50 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F400 Offset: 0x76DA00 VA: 0x18076F400
	public void .ctor() { }

}

public class ModelConditionTest_RoofBottom : ModelConditionTest // TypeDefIndex: 9071
{	// Fields
	private const string roof_square = "roof/";
	private const string roof_triangle = "roof.triangle/";
	private const string socket_bot_right = "sockets/neighbour/3";
	private const string socket_bot_left = "sockets/neighbour/4";
	private const string socket_top_right = "sockets/neighbour/5";
	private const string socket_top_left = "sockets/neighbour/6";
	private static string[] sockets_bot_right; // 0x0
	private static string[] sockets_bot_left; // 0x8

	// Methods

	// RVA: 0x76FEC0 Offset: 0x76E4C0 VA: 0x18076FEC0
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x76FCD0 Offset: 0x76E2D0 VA: 0x18076FCD0 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F400 Offset: 0x76DA00 VA: 0x18076F400
	public void .ctor() { }

	// RVA: 0x76FFD0 Offset: 0x76E5D0 VA: 0x18076FFD0
	private static void .cctor() { }

}

public class ModelConditionTest_RoofLeft : ModelConditionTest // TypeDefIndex: 9072
{	// Fields
	public ModelConditionTest_RoofLeft.AngleType angle; // 0x98
	public ModelConditionTest_RoofLeft.ShapeType shape; // 0x9C
	private const string roof_square = "roof/";
	private const string roof_triangle = "roof.triangle/";
	private const string socket_right = "sockets/neighbour/3";
	private const string socket_left = "sockets/neighbour/4";
	private static string[] sockets_left; // 0x0

	// Properties
	private bool IsConvex { get; }
	private bool IsConcave { get; }

	// Methods

	// RVA: 0x770960 Offset: 0x76EF60 VA: 0x180770960
	private bool get_IsConvex() { }

	// RVA: 0x770950 Offset: 0x76EF50 VA: 0x180770950
	private bool get_IsConcave() { }

	// RVA: 0x7706C0 Offset: 0x76ECC0 VA: 0x1807706C0
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x770200 Offset: 0x76E800 VA: 0x180770200 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x7708F0 Offset: 0x76EEF0 VA: 0x1807708F0
	public void .ctor() { }

	// RVA: 0x7707D0 Offset: 0x76EDD0 VA: 0x1807707D0
	private static void .cctor() { }

}

public enum ModelConditionTest_RoofLeft.AngleType // TypeDefIndex: 9073
{	// Fields
	public int value__; // 0x0
	public const ModelConditionTest_RoofLeft.AngleType None = -1;
	public const ModelConditionTest_RoofLeft.AngleType Straight = 0;
	public const ModelConditionTest_RoofLeft.AngleType Convex60 = 60;
	public const ModelConditionTest_RoofLeft.AngleType Convex90 = 90;
	public const ModelConditionTest_RoofLeft.AngleType Convex120 = 120;
	public const ModelConditionTest_RoofLeft.AngleType Concave30 = -30;
	public const ModelConditionTest_RoofLeft.AngleType Concave60 = -60;
	public const ModelConditionTest_RoofLeft.AngleType Concave90 = -90;
	public const ModelConditionTest_RoofLeft.AngleType Concave120 = -120;

}

public enum ModelConditionTest_RoofLeft.ShapeType // TypeDefIndex: 9074
{	// Fields
	public int value__; // 0x0
	public const ModelConditionTest_RoofLeft.ShapeType Any = -1;
	public const ModelConditionTest_RoofLeft.ShapeType Square = 0;
	public const ModelConditionTest_RoofLeft.ShapeType Triangle = 1;

}

public class ModelConditionTest_RoofRight : ModelConditionTest // TypeDefIndex: 9075
{	// Fields
	public ModelConditionTest_RoofRight.AngleType angle; // 0x98
	public ModelConditionTest_RoofRight.ShapeType shape; // 0x9C
	private const string roof_square = "roof/";
	private const string roof_triangle = "roof.triangle/";
	private const string socket_right = "sockets/neighbour/3";
	private const string socket_left = "sockets/neighbour/4";
	private static string[] sockets_right; // 0x0

	// Properties
	private bool IsConvex { get; }
	private bool IsConcave { get; }

	// Methods

	// RVA: 0x770960 Offset: 0x76EF60 VA: 0x180770960
	private bool get_IsConvex() { }

	// RVA: 0x770950 Offset: 0x76EF50 VA: 0x180770950
	private bool get_IsConcave() { }

	// RVA: 0x770E50 Offset: 0x76F450 VA: 0x180770E50
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x770970 Offset: 0x76EF70 VA: 0x180770970 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x7708F0 Offset: 0x76EEF0 VA: 0x1807708F0
	public void .ctor() { }

	// RVA: 0x770F60 Offset: 0x76F560 VA: 0x180770F60
	private static void .cctor() { }

}

public enum ModelConditionTest_RoofRight.AngleType // TypeDefIndex: 9076
{	// Fields
	public int value__; // 0x0
	public const ModelConditionTest_RoofRight.AngleType None = -1;
	public const ModelConditionTest_RoofRight.AngleType Straight = 0;
	public const ModelConditionTest_RoofRight.AngleType Convex60 = 60;
	public const ModelConditionTest_RoofRight.AngleType Convex90 = 90;
	public const ModelConditionTest_RoofRight.AngleType Convex120 = 120;
	public const ModelConditionTest_RoofRight.AngleType Concave30 = -30;
	public const ModelConditionTest_RoofRight.AngleType Concave60 = -60;
	public const ModelConditionTest_RoofRight.AngleType Concave90 = -90;
	public const ModelConditionTest_RoofRight.AngleType Concave120 = -120;

}

public enum ModelConditionTest_RoofRight.ShapeType // TypeDefIndex: 9077
{	// Fields
	public int value__; // 0x0
	public const ModelConditionTest_RoofRight.ShapeType Any = -1;
	public const ModelConditionTest_RoofRight.ShapeType Square = 0;
	public const ModelConditionTest_RoofRight.ShapeType Triangle = 1;

}

public class ModelConditionTest_RoofTop : ModelConditionTest // TypeDefIndex: 9078
{	// Fields
	private const string roof_square = "roof/";
	private const string roof_triangle = "roof.triangle/";
	private const string socket_bot_right = "sockets/neighbour/3";
	private const string socket_bot_left = "sockets/neighbour/4";
	private const string socket_top_right = "sockets/neighbour/5";
	private const string socket_top_left = "sockets/neighbour/6";
	private static string[] sockets_top_right; // 0x0
	private static string[] sockets_top_left; // 0x8

	// Methods

	// RVA: 0x76FEC0 Offset: 0x76E4C0 VA: 0x18076FEC0
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x771080 Offset: 0x76F680 VA: 0x180771080 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F400 Offset: 0x76DA00 VA: 0x18076F400
	public void .ctor() { }

	// RVA: 0x771270 Offset: 0x76F870 VA: 0x180771270
	private static void .cctor() { }

}

public class ModelConditionTest_RoofTriangle : ModelConditionTest // TypeDefIndex: 9079
{	// Fields
	private const string socket = "roof/sockets/wall-female";

	// Methods

	// RVA: 0x7714A0 Offset: 0x76FAA0 VA: 0x1807714A0 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F400 Offset: 0x76DA00 VA: 0x18076F400
	public void .ctor() { }

}

public class ModelConditionTest_SpiralStairs : ModelConditionTest // TypeDefIndex: 9080
{	// Fields
	private const string stairs_socket_female = "sockets/stairs-female/1";
	private static string[] stairs_sockets_female; // 0x0
	private const string floor_socket_female = "sockets/floor-female/1";
	private static string[] floor_sockets_female; // 0x8

	// Methods

	// RVA: 0x771770 Offset: 0x76FD70 VA: 0x180771770
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x771510 Offset: 0x76FB10 VA: 0x180771510 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F400 Offset: 0x76DA00 VA: 0x18076F400
	public void .ctor() { }

	// RVA: 0x771880 Offset: 0x76FE80 VA: 0x180771880
	private static void .cctor() { }

}

public class ModelConditionTest_True : ModelConditionTest // TypeDefIndex: 9081
{	// Fields
	public ConditionalModel reference; // 0x98

	// Methods

	// RVA: 0x771AB0 Offset: 0x7700B0 VA: 0x180771AB0 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F400 Offset: 0x76DA00 VA: 0x18076F400
	public void .ctor() { }

}

public class ModelConditionTest_Wall : ModelConditionTest // TypeDefIndex: 9082
{	// Methods

	// RVA: 0x773210 Offset: 0x771810 VA: 0x180773210 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F400 Offset: 0x76DA00 VA: 0x18076F400
	public void .ctor() { }

}

public class ModelConditionTest_WallCornerLeft : ModelConditionTest // TypeDefIndex: 9083
{	// Fields
	private const string socket = "sockets/stability/2";
	private static string[] sockets; // 0x1B90

	// Methods

	// RVA: 0x771AE0 Offset: 0x7700E0 VA: 0x180771AE0 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F400 Offset: 0x76DA00 VA: 0x18076F400
	public void .ctor() { }

	// RVA: 0x771F00 Offset: 0x770500 VA: 0x180771F00
	private static void .cctor() { }

}

public class ModelConditionTest_WallCornerRight : ModelConditionTest // TypeDefIndex: 9084
{	// Fields
	private const string socket = "sockets/stability/1";
	private static string[] sockets; // 0x2B10368

	// Methods

	// RVA: 0x772160 Offset: 0x770760 VA: 0x180772160 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F400 Offset: 0x76DA00 VA: 0x18076F400
	public void .ctor() { }

	// RVA: 0x772580 Offset: 0x770B80 VA: 0x180772580
	private static void .cctor() { }

}

public class ModelConditionTest_WallTriangleLeft : ModelConditionTest // TypeDefIndex: 9085
{	// Fields
	private const string socket_1 = "wall/sockets/wall-female";
	private const string socket_2 = "wall/sockets/floor-female/1";
	private const string socket_3 = "wall/sockets/floor-female/2";
	private const string socket_4 = "wall/sockets/floor-female/3";
	private const string socket_5 = "wall/sockets/floor-female/4";
	private const string socket_6 = "wall/sockets/stability/1";
	private const string socket = "wall/sockets/neighbour/1";

	// Methods

	// RVA: 0x7727E0 Offset: 0x770DE0 VA: 0x1807727E0
	public static bool CheckCondition(BaseEntity ent) { }

	// RVA: 0x772CA0 Offset: 0x7712A0 VA: 0x180772CA0
	private static bool CheckSocketOccupied(BaseEntity ent, string socket) { }

	// RVA: 0x772CE0 Offset: 0x7712E0 VA: 0x180772CE0 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F400 Offset: 0x76DA00 VA: 0x18076F400
	public void .ctor() { }

}

public class ModelConditionTest_WallTriangleRight : ModelConditionTest // TypeDefIndex: 9086
{	// Fields
	private const string socket_1 = "wall/sockets/wall-female";
	private const string socket_2 = "wall/sockets/floor-female/1";
	private const string socket_3 = "wall/sockets/floor-female/2";
	private const string socket_4 = "wall/sockets/floor-female/3";
	private const string socket_5 = "wall/sockets/floor-female/4";
	private const string socket_6 = "wall/sockets/stability/2";
	private const string socket = "wall/sockets/neighbour/1";

	// Methods

	// RVA: 0x772CF0 Offset: 0x7712F0 VA: 0x180772CF0
	public static bool CheckCondition(BaseEntity ent) { }

	// RVA: 0x772CA0 Offset: 0x7712A0 VA: 0x180772CA0
	private static bool CheckSocketOccupied(BaseEntity ent, string socket) { }

	// RVA: 0x773200 Offset: 0x771800 VA: 0x180773200 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F400 Offset: 0x76DA00 VA: 0x18076F400
	public void .ctor() { }

}

