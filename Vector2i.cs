public struct Vector2i : IEquatable<Vector2i> // TypeDefIndex: 4821
{
	public static readonly Vector2i zero; 
	public static readonly Vector2i one; 
	public static readonly Vector2i left; 
	public static readonly Vector2i right; 
	public static readonly Vector2i forward; 
	public static readonly Vector2i back; 
	public int x; 
	public int y; 


	public void .ctor(int x, int y) { }

	public static Vector2i op_RightShift(Vector2i v, int shift) { }

	public static Vector2i op_LeftShift(Vector2i v, int shift) { }

	public static Vector2i op_UnaryPlus(Vector2i v) { }

	public static Vector2i op_UnaryNegation(Vector2i v) { }

	public static Vector2i op_Addition(Vector2i a, Vector2i b) { }

	public static Vector2i op_Subtraction(Vector2i a, Vector2i b) { }

	public static Vector2i op_Multiply(Vector2i v, int multiplier) { }

	public static Vector2i op_Division(Vector2i v, int divisor) { }

	public static Vector2 op_Multiply(Vector2i v, float multiplier) { }

	public static Vector2 op_Division(Vector2i v, float divisor) { }

	public static Vector2i op_Modulus(Vector2i v, int mod) { }

	public static Vector2 op_Implicit(Vector2i other) { }

	public static Vector2i op_Explicit(Vector2 other) { }

	public static bool op_Equality(Vector2i a, Vector2i b) { }

	public static bool op_Inequality(Vector2i a, Vector2i b) { }

	public bool Equals(Vector2i o) { }

	public override int GetHashCode() { }

	public override bool Equals(object o) { }

	public override string ToString() { }

	private static void .cctor() { }

}

