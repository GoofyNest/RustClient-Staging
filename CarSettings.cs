public class CarSettings // TypeDefIndex: 9705
{	// Fields
	[HeaderAttribute] // RVA: 0x848A0 Offset: 0x83CA0 VA: 0x1800848A0
	[RangeAttribute] // RVA: 0x848A0 Offset: 0x83CA0 VA: 0x1800848A0
	public float rollingResistance; // 0x10
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float antiRoll; // 0x14
	public bool canSleep; // 0x18
	[HeaderAttribute] // RVA: 0x84B30 Offset: 0x83F30 VA: 0x180084B30
	public bool tankSteering; // 0x19
	[RangeAttribute] // RVA: 0x84D50 Offset: 0x84150 VA: 0x180084D50
	public float maxSteerAngle; // 0x1C
	public bool steeringAssist; // 0x20
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float steeringAssistRatio; // 0x24
	public bool steeringLimit; // 0x28
	[RangeAttribute] // RVA: 0x84D50 Offset: 0x84150 VA: 0x180084D50
	public float minSteerLimitAngle; // 0x2C
	[RangeAttribute] // RVA: 0x85150 Offset: 0x84550 VA: 0x180085150
	public float minSteerLimitSpeed; // 0x30
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float rearWheelSteer; // 0x34
	public float steerMinLerpSpeed; // 0x38
	public float steerMaxLerpSpeed; // 0x3C
	public float steerReturnLerpSpeed; // 0x40
	[HeaderAttribute] // RVA: 0x853A0 Offset: 0x847A0 VA: 0x1800853A0
	public float maxDriveSlip; // 0x44
	public float driveForceToMaxSlip; // 0x48
	public float reversePercentSpeed; // 0x4C
	[HeaderAttribute] // RVA: 0x85550 Offset: 0x84950 VA: 0x180085550
	public float brakeForceMultiplier; // 0x50
	[HeaderAttribute] // RVA: 0x85680 Offset: 0x84A80 VA: 0x180085680
	[RangeAttribute] // RVA: 0x85680 Offset: 0x84A80 VA: 0x180085680
	public float handlingBias; // 0x54

	// Methods

	// RVA: 0x6FE1C0 Offset: 0x6FC7C0 VA: 0x1806FE1C0
	public void .ctor() { }

}

