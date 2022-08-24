public class WheelCollider : Collider // TypeDefIndex: 4772
{
[NativeHeaderAttribute] // RVA: 0xC7160 Offset: 0xC6560 VA: 0x1800C7160
[NativeHeaderAttribute] // RVA: 0xC7160 Offset: 0xC6560 VA: 0x1800C7160
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

	[NativeNameAttribute] // RVA: 0xC7570 Offset: 0xC6970 VA: 0x1800C7570
	public bool get_isGrounded() { }

}

