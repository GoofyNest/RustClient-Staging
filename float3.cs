public struct float3 : IEquatable<float3>, IFormattable // TypeDefIndex: 7103
{
[DebuggerTypeProxyAttribute] // RVA: 0x7D520 Offset: 0x7C920 VA: 0x18007D520
[DefaultMemberAttribute] // RVA: 0x7D520 Offset: 0x7C920 VA: 0x18007D520
[Serializable]
public struct float3 : IEquatable<float3>, IFormattable // TypeDefIndex: 7103
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public static readonly float3 zero; // 0x0

	[EditorBrowsableAttribute] // RVA: 0x7D770 Offset: 0x7CB70 VA: 0x18007D770
	public float3 yzx { get; }


	public void .ctor(float x, float y, float z) { }

	public static float3 op_Multiply(float3 lhs, float3 rhs) { }

	public static float3 op_Multiply(float3 lhs, float rhs) { }

	public static float3 op_Multiply(float lhs, float3 rhs) { }

	public static float3 op_Addition(float3 lhs, float3 rhs) { }

	public static float3 op_Subtraction(float3 lhs, float3 rhs) { }

	public static float3 op_Division(float3 lhs, float rhs) { }

	public static float3 op_UnaryNegation(float3 val) { }

	public float3 get_yzx() { }

	public bool Equals(float3 rhs) { }

	public override bool Equals(object o) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	public string ToString(string format, IFormatProvider formatProvider) { }

	public static Vector3 op_Implicit(float3 v) { }

	public static float3 op_Implicit(Vector3 v) { }

}

