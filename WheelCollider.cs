public class WheelCollider : Collider // TypeDefIndex: 4772
{
[NativeHeaderAttribute] // RVA: 0xC7050 Offset: 0xC6450 VA: 0x1800C7050
[NativeHeaderAttribute] // RVA: 0xC7050 Offset: 0xC6450 VA: 0x1800C7050
public class WheelCollider : Collider // TypeDefIndex: 4772
	public float radius { get; }
	public float suspensionDistance { get; }
	public float motorTorque { get; set; }
	public float brakeTorque { set; }
	public float steerAngle { set; }
	public bool isGrounded { get; }


	public float get_radius() { }

	public float get_suspensionDistance() { }

	public float get_motorTorque() { }

	public void set_motorTorque(float value) { }

	public void set_brakeTorque(float value) { }

	public void set_steerAngle(float value) { }

	[NativeNameAttribute] // RVA: 0xC7420 Offset: 0xC6820 VA: 0x1800C7420
	public bool get_isGrounded() { }

}

