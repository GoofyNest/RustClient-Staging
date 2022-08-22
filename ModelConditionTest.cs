public abstract class ModelConditionTest : PrefabAttribute // TypeDefIndex: 9066
{	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool DoTest(BaseEntity ent);

	// RVA: 0x76FA30 Offset: 0x76E030 VA: 0x18076FA30 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x76F4B0 Offset: 0x76DAB0 VA: 0x18076F4B0
	protected void .ctor() { }

}

public class ModelConditionTest_False : ModelConditionTest // TypeDefIndex: 9067
{	// Fields
	public ConditionalModel reference; // 0x98

	// Methods

	// RVA: 0x76F480 Offset: 0x76DA80 VA: 0x18076F480 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F4B0 Offset: 0x76DAB0 VA: 0x18076F4B0
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

	// RVA: 0x76F8A0 Offset: 0x76DEA0 VA: 0x18076F8A0
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x76F510 Offset: 0x76DB10 VA: 0x18076F510 Slot: 6
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x76F720 Offset: 0x76DD20 VA: 0x18076F720 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F9A0 Offset: 0x76DFA0 VA: 0x18076F9A0
	public void .ctor() { }

}

public class ModelConditionTest_RampHigh : ModelConditionTest // TypeDefIndex: 9069
{	// Fields
	private const string socket = "ramp/sockets/block-male/1";

	// Methods

	// RVA: 0x76FAF0 Offset: 0x76E0F0 VA: 0x18076FAF0
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x76FA90 Offset: 0x76E090 VA: 0x18076FA90 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F4B0 Offset: 0x76DAB0 VA: 0x18076F4B0
	public void .ctor() { }

}

public class ModelConditionTest_RampLow : ModelConditionTest // TypeDefIndex: 9070
{	// Fields
	private const string socket = "ramp/sockets/block-male/1";

	// Methods

	// RVA: 0x76FC70 Offset: 0x76E270 VA: 0x18076FC70
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x76FC00 Offset: 0x76E200 VA: 0x18076FC00 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F4B0 Offset: 0x76DAB0 VA: 0x18076F4B0
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

	// RVA: 0x76FF70 Offset: 0x76E570 VA: 0x18076FF70
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x76FD80 Offset: 0x76E380 VA: 0x18076FD80 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F4B0 Offset: 0x76DAB0 VA: 0x18076F4B0
	public void .ctor() { }

	// RVA: 0x770080 Offset: 0x76E680 VA: 0x180770080
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

	// RVA: 0x770A10 Offset: 0x76F010 VA: 0x180770A10
	private bool get_IsConvex() { }

	// RVA: 0x770A00 Offset: 0x76F000 VA: 0x180770A00
	private bool get_IsConcave() { }

	// RVA: 0x770770 Offset: 0x76ED70 VA: 0x180770770
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x7702B0 Offset: 0x76E8B0 VA: 0x1807702B0 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x7709A0 Offset: 0x76EFA0 VA: 0x1807709A0
	public void .ctor() { }

	// RVA: 0x770880 Offset: 0x76EE80 VA: 0x180770880
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

	// RVA: 0x770A10 Offset: 0x76F010 VA: 0x180770A10
	private bool get_IsConvex() { }

	// RVA: 0x770A00 Offset: 0x76F000 VA: 0x180770A00
	private bool get_IsConcave() { }

	// RVA: 0x770F00 Offset: 0x76F500 VA: 0x180770F00
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x770A20 Offset: 0x76F020 VA: 0x180770A20 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x7709A0 Offset: 0x76EFA0 VA: 0x1807709A0
	public void .ctor() { }

	// RVA: 0x771010 Offset: 0x76F610 VA: 0x180771010
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

	// RVA: 0x76FF70 Offset: 0x76E570 VA: 0x18076FF70
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x771130 Offset: 0x76F730 VA: 0x180771130 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F4B0 Offset: 0x76DAB0 VA: 0x18076F4B0
	public void .ctor() { }

	// RVA: 0x771320 Offset: 0x76F920 VA: 0x180771320
	private static void .cctor() { }

}

public class ModelConditionTest_RoofTriangle : ModelConditionTest // TypeDefIndex: 9079
{	// Fields
	private const string socket = "roof/sockets/wall-female";

	// Methods

	// RVA: 0x771550 Offset: 0x76FB50 VA: 0x180771550 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F4B0 Offset: 0x76DAB0 VA: 0x18076F4B0
	public void .ctor() { }

}

public class ModelConditionTest_SpiralStairs : ModelConditionTest // TypeDefIndex: 9080
{	// Fields
	private const string stairs_socket_female = "sockets/stairs-female/1";
	private static string[] stairs_sockets_female; // 0x0
	private const string floor_socket_female = "sockets/floor-female/1";
	private static string[] floor_sockets_female; // 0x8

	// Methods

	// RVA: 0x771820 Offset: 0x76FE20 VA: 0x180771820
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x7715C0 Offset: 0x76FBC0 VA: 0x1807715C0 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F4B0 Offset: 0x76DAB0 VA: 0x18076F4B0
	public void .ctor() { }

	// RVA: 0x771930 Offset: 0x76FF30 VA: 0x180771930
	private static void .cctor() { }

}

public class ModelConditionTest_True : ModelConditionTest // TypeDefIndex: 9081
{	// Fields
	public ConditionalModel reference; // 0x98

	// Methods

	// RVA: 0x771B60 Offset: 0x770160 VA: 0x180771B60 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F4B0 Offset: 0x76DAB0 VA: 0x18076F4B0
	public void .ctor() { }

}

public class ModelConditionTest_Wall : ModelConditionTest // TypeDefIndex: 9082
{	// Methods

	// RVA: 0x7732C0 Offset: 0x7718C0 VA: 0x1807732C0 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F4B0 Offset: 0x76DAB0 VA: 0x18076F4B0
	public void .ctor() { }

}

public class ModelConditionTest_WallCornerLeft : ModelConditionTest // TypeDefIndex: 9083
{	// Fields
	private const string socket = "sockets/stability/2";
	private static string[] sockets; // 0x1C85

	// Methods

	// RVA: 0x771B90 Offset: 0x770190 VA: 0x180771B90 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F4B0 Offset: 0x76DAB0 VA: 0x18076F4B0
	public void .ctor() { }

	// RVA: 0x771FB0 Offset: 0x7705B0 VA: 0x180771FB0
	private static void .cctor() { }

}

public class ModelConditionTest_WallCornerRight : ModelConditionTest // TypeDefIndex: 9084
{	// Fields
	private const string socket = "sockets/stability/1";
	private static string[] sockets; // 0x1C90

	// Methods

	// RVA: 0x772210 Offset: 0x770810 VA: 0x180772210 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F4B0 Offset: 0x76DAB0 VA: 0x18076F4B0
	public void .ctor() { }

	// RVA: 0x772630 Offset: 0x770C30 VA: 0x180772630
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

	// RVA: 0x772890 Offset: 0x770E90 VA: 0x180772890
	public static bool CheckCondition(BaseEntity ent) { }

	// RVA: 0x772D50 Offset: 0x771350 VA: 0x180772D50
	private static bool CheckSocketOccupied(BaseEntity ent, string socket) { }

	// RVA: 0x772D90 Offset: 0x771390 VA: 0x180772D90 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F4B0 Offset: 0x76DAB0 VA: 0x18076F4B0
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

	// RVA: 0x772DA0 Offset: 0x7713A0 VA: 0x180772DA0
	public static bool CheckCondition(BaseEntity ent) { }

	// RVA: 0x772D50 Offset: 0x771350 VA: 0x180772D50
	private static bool CheckSocketOccupied(BaseEntity ent, string socket) { }

	// RVA: 0x7732B0 Offset: 0x7718B0 VA: 0x1807732B0 Slot: 8
	public override bool DoTest(BaseEntity ent) { }

	// RVA: 0x76F4B0 Offset: 0x76DAB0 VA: 0x18076F4B0
	public void .ctor() { }

}

