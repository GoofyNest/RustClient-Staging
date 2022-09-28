internal struct BoneData // TypeDefIndex: 7321
{
	public int Depth; 
	public int Parent; 
	public int Child; 
	public float Length; 
	public int LeftSibling; 
	public float3 LeftPosition; 
	public float LengthToLeft; 
	public int RightSibling; 
	public float3 RightPosition; 
	public float LengthToRight; 
	public float3 LocalPosition; 
	public quaternion LocalRotation; 
	public float3 DirectionFromOrigin; 
	public float ResistanceInv; 
	public float DampingInv; 
	public float Stiffness; 
	public float Slackness; 
	public float CollisionRadius; 

}

