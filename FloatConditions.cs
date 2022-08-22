public class FloatConditions // TypeDefIndex: 11369
{	public FloatConditions.Condition[] conditions; // 0x10


	public bool AllTrue(float val) { }

	public void .ctor() { }

}

public struct FloatConditions.Condition // TypeDefIndex: 11370
{	public FloatConditions.Condition.Types type; // 0x0
	public float value; // 0x4


	public bool Test(float val) { }

}

public enum FloatConditions.Condition.Types // TypeDefIndex: 11371
{	public int value__; // 0x0
	public const FloatConditions.Condition.Types Equal = 0;
	public const FloatConditions.Condition.Types NotEqual = 1;
	public const FloatConditions.Condition.Types Higher = 2;
	public const FloatConditions.Condition.Types Lower = 3;

}

