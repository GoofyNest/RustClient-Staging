public struct FixedShort3 // TypeDefIndex: 13167
{
	private const int FracBits = 10;
	private const float MaxFrac = 1024;
	private const float RcpMaxFrac = 0,0009765625;
	public short x; 
	public short y; 
	public short z; 


	public void .ctor(Vector3 vec) { }

	public static Vector3 op_Explicit(FixedShort3 vec) { }

}

