public abstract class ModelConditionTest : PrefabAttribute // TypeDefIndex: 9066
{	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool DoTest(BaseEntity ent);

	// RVA: 0x76F920 Offset: 0x76DF20 VA: 0x18076F920 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x76F3A0 Offset: 0x76D9A0 VA: 0x18076F3A0
	protected void .ctor() { }

}

public class ModelConditionTest_False : ModelConditionTest // TypeDefIndex: 9067
{	// Fields
	public ConditionalModel reference; // 0x98

	// Methods

	// RVA: 0x76F370 Offset: 0x76D970 VA: 0x18076F370 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F3A0 Offset: 0x76D9A0 VA: 0x18076F3A0
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

	// RVA: 0x76F790 Offset: 0x76DD90 VA: 0x18076F790
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x76F400 Offset: 0x76DA00 VA: 0x18076F400 Slot: 6
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x76F610 Offset: 0x76DC10 VA: 0x18076F610 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F890 Offset: 0x76DE90 VA: 0x18076F890
	public void .ctor() { }

}

public class ModelConditionTest_RampHigh : ModelConditionTest // TypeDefIndex: 9069
{	// Fields
	private const string socket = "ramp/sockets/block-male/1";

	// Methods

	// RVA: 0x76F9E0 Offset: 0x76DFE0 VA: 0x18076F9E0
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x76F980 Offset: 0x76DF80 VA: 0x18076F980 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F3A0 Offset: 0x76D9A0 VA: 0x18076F3A0
	public void .ctor() { }

}

public class ModelConditionTest_RampLow : ModelConditionTest // TypeDefIndex: 9070
{	// Fields
	private const string socket = "ramp/sockets/block-male/1";

	// Methods

	// RVA: 0x76FB60 Offset: 0x76E160 VA: 0x18076FB60
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x76FAF0 Offset: 0x76E0F0 VA: 0x18076FAF0 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F3A0 Offset: 0x76D9A0 VA: 0x18076F3A0
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

	// RVA: 0x76FE60 Offset: 0x76E460 VA: 0x18076FE60
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x76FC70 Offset: 0x76E270 VA: 0x18076FC70 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F3A0 Offset: 0x76D9A0 VA: 0x18076F3A0
	public void .ctor() { }

	// RVA: 0x76FF70 Offset: 0x76E570 VA: 0x18076FF70
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

	// RVA: 0x770900 Offset: 0x76EF00 VA: 0x180770900
	private bool get_IsConvex() { }

	// RVA: 0x7708F0 Offset: 0x76EEF0 VA: 0x1807708F0
	private bool get_IsConcave() { }

	// RVA: 0x770660 Offset: 0x76EC60 VA: 0x180770660
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x7701A0 Offset: 0x76E7A0 VA: 0x1807701A0 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x770890 Offset: 0x76EE90 VA: 0x180770890
	public void .ctor() { }

	// RVA: 0x770770 Offset: 0x76ED70 VA: 0x180770770
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

	// RVA: 0x770900 Offset: 0x76EF00 VA: 0x180770900
	private bool get_IsConvex() { }

	// RVA: 0x7708F0 Offset: 0x76EEF0 VA: 0x1807708F0
	private bool get_IsConcave() { }

	// RVA: 0x770DF0 Offset: 0x76F3F0 VA: 0x180770DF0
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x770910 Offset: 0x76EF10 VA: 0x180770910 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x770890 Offset: 0x76EE90 VA: 0x180770890
	public void .ctor() { }

	// RVA: 0x770F00 Offset: 0x76F500 VA: 0x180770F00
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

	// RVA: 0x76FE60 Offset: 0x76E460 VA: 0x18076FE60
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x771020 Offset: 0x76F620 VA: 0x180771020 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F3A0 Offset: 0x76D9A0 VA: 0x18076F3A0
	public void .ctor() { }

	// RVA: 0x771210 Offset: 0x76F810 VA: 0x180771210
	private static void .cctor() { }

}

public class ModelConditionTest_RoofTriangle : ModelConditionTest // TypeDefIndex: 9079
{	// Fields
	private const string socket = "roof/sockets/wall-female";

	// Methods

	// RVA: 0x771440 Offset: 0x76FA40 VA: 0x180771440 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F3A0 Offset: 0x76D9A0 VA: 0x18076F3A0
	public void .ctor() { }

}

public class ModelConditionTest_SpiralStairs : ModelConditionTest // TypeDefIndex: 9080
{	// Fields
	private const string stairs_socket_female = "sockets/stairs-female/1";
	private static string[] stairs_sockets_female; // 0x0
	private const string floor_socket_female = "sockets/floor-female/1";
	private static string[] floor_sockets_female; // 0x8

	// Methods

	// RVA: 0x771710 Offset: 0x76FD10 VA: 0x180771710
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x7714B0 Offset: 0x76FAB0 VA: 0x1807714B0 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F3A0 Offset: 0x76D9A0 VA: 0x18076F3A0
	public void .ctor() { }

	// RVA: 0x771820 Offset: 0x76FE20 VA: 0x180771820
	private static void .cctor() { }

}

public class ModelConditionTest_True : ModelConditionTest // TypeDefIndex: 9081
{	// Fields
	public ConditionalModel reference; // 0x98

	// Methods

	// RVA: 0x771A50 Offset: 0x770050 VA: 0x180771A50 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F3A0 Offset: 0x76D9A0 VA: 0x18076F3A0
	public void .ctor() { }

}

public class ModelConditionTest_Wall : ModelConditionTest // TypeDefIndex: 9082
{	// Methods

	// RVA: 0x7731B0 Offset: 0x7717B0 VA: 0x1807731B0 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F3A0 Offset: 0x76D9A0 VA: 0x18076F3A0
	public void .ctor() { }

}

public class ModelConditionTest_WallCornerLeft : ModelConditionTest // TypeDefIndex: 9083
{	// Fields
	private const string socket = "sockets/stability/2";
	private static string[] sockets; // 0x1C85

	// Methods

	// RVA: 0x771A80 Offset: 0x770080 VA: 0x180771A80 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F3A0 Offset: 0x76D9A0 VA: 0x18076F3A0
	public void .ctor() { }

	// RVA: 0x771EA0 Offset: 0x7704A0 VA: 0x180771EA0
	private static void .cctor() { }

}

public class ModelConditionTest_WallCornerRight : ModelConditionTest // TypeDefIndex: 9084
{	// Fields
	private const string socket = "sockets/stability/1";
	private static string[] sockets; // 0x1C90

	// Methods

	// RVA: 0x772100 Offset: 0x770700 VA: 0x180772100 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F3A0 Offset: 0x76D9A0 VA: 0x18076F3A0
	public void .ctor() { }

	// RVA: 0x772520 Offset: 0x770B20 VA: 0x180772520
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

	// RVA: 0x772780 Offset: 0x770D80 VA: 0x180772780
	public static bool CheckCondition(BaseEntity ent) { }

	// RVA: 0x772C40 Offset: 0x771240 VA: 0x180772C40
	private static bool CheckSocketOccupied(BaseEntity ent, string socket) { }

	// RVA: 0x772C80 Offset: 0x771280 VA: 0x180772C80 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F3A0 Offset: 0x76D9A0 VA: 0x18076F3A0
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

	// RVA: 0x772C90 Offset: 0x771290 VA: 0x180772C90
	public static bool CheckCondition(BaseEntity ent) { }

	// RVA: 0x772C40 Offset: 0x771240 VA: 0x180772C40
	private static bool CheckSocketOccupied(BaseEntity ent, string socket) { }

	// RVA: 0x7731A0 Offset: 0x7717A0 VA: 0x1807731A0 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F3A0 Offset: 0x76D9A0 VA: 0x18076F3A0
	public void .ctor() { }

}

