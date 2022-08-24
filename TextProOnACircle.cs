public class TextProOnACircle : TextProOnACurve // TypeDefIndex: 7121
{
internal class <Module> // TypeDefIndex: 7120

[ExecuteInEditMode] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
public class TextProOnACircle : TextProOnACurve // TypeDefIndex: 7121
	[SerializeField] // RVA: 0x80080 Offset: 0x7F480 VA: 0x180080080
	[TooltipAttribute] // RVA: 0x80080 Offset: 0x7F480 VA: 0x180080080
	private float m_radius; // 0x20
	[TooltipAttribute] // RVA: 0x80240 Offset: 0x7F640 VA: 0x180080240
	public float m_arcDegrees; // 0x24
	[SerializeField] // RVA: 0x802E0 Offset: 0x7F6E0 VA: 0x1800802E0
	[TooltipAttribute] // RVA: 0x802E0 Offset: 0x7F6E0 VA: 0x1800802E0
	private float m_angularOffset; // 0x28
	private float m_oldRadius; // 0x2C
	private float m_oldArcDegrees; // 0x30
	private float m_oldAngularOffset; // 0x34


	protected override bool ParametersHaveChanged() { }

	protected override Matrix4x4 ComputeTransformationMatrix(Vector3 charMidBaselinePos, float zeroToOnePos, TMP_TextInfo textInfo, int charIdx) { }

	public void .ctor() { }

}

